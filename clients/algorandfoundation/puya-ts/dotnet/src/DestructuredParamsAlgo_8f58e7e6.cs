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

namespace Arc56.Generated.algorandfoundation.puya_ts.DestructuredParamsAlgo_8f58e7e6
{


    public class DestructuredParamsAlgoProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public DestructuredParamsAlgoProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Arc4 : AVMObjectType
            {
                public ulong A { get; set; }

                public byte[] B { get; set; }

                public bool C { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vA.From(A);
                    ret.AddRange(vA.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vB.From(B);
                    ret.AddRange(vB.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vC.From(C);
                    ret.AddRange(vC.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Arc4 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Arc4();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vA.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueA = vA.ToValue();
                    if (valueA is ulong vAValue) { ret.A = vAValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vB.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueB = vB.ToValue();
                    if (valueB is byte[] vBValue) { ret.B = vBValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vC.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueC = vC.ToValue();
                    if (valueC is bool vCValue) { ret.C = vCValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Arc4);
                }
                public bool Equals(Arc4? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Arc4 left, Arc4 right)
                {
                    return EqualityComparer<Arc4>.Default.Equals(left, right);
                }
                public static bool operator !=(Arc4 left, Arc4 right)
                {
                    return !(left == right);
                }

            }

            public class Object4B7314A9 : AVMObjectType
            {
                public ulong A { get; set; }

                public byte[] B { get; set; }

                public bool C { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vA.From(A);
                    ret.AddRange(vA.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vB.From(B);
                    ret.AddRange(vB.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vC.From(C);
                    ret.AddRange(vC.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Object4B7314A9 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Object4B7314A9();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vA.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueA = vA.ToValue();
                    if (valueA is ulong vAValue) { ret.A = vAValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vB.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueB = vB.ToValue();
                    if (valueB is byte[] vBValue) { ret.B = vBValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vC.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueC = vC.ToValue();
                    if (valueC is bool vCValue) { ret.C = vCValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Object4B7314A9);
                }
                public bool Equals(Object4B7314A9? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Object4B7314A9 left, Object4B7314A9 right)
                {
                    return EqualityComparer<Object4B7314A9>.Default.Equals(left, right);
                }
                public static bool operator !=(Object4B7314A9 left, Object4B7314A9 right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="p"> Object4B7314A9</param>
        public async Task Test(Structs.Object4B7314A9 p, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 254, 254, 167, 102 };

            var result = await base.CallApp(new List<object> { abiHandle, p }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Test_Transactions(Structs.Object4B7314A9 p, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 254, 254, 167, 102 };

            return await base.MakeTransactionList(new List<object> { abiHandle, p }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="p"> Arc4</param>
        public async Task TestMutable(Structs.Arc4 p, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 52, 57, 157, 180 };

            var result = await base.CallApp(new List<object> { abiHandle, p }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestMutable_Transactions(Structs.Arc4 p, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 52, 57, 157, 180 };

            return await base.MakeTransactionList(new List<object> { abiHandle, p }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Init(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 241, 71, 72 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Init_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 241, 71, 72 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRGVzdHJ1Y3R1cmVkUGFyYW1zQWxnbyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJBcmM0IjpbeyJuYW1lIjoiYSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJiIiwidHlwZSI6ImJ5dGVbXSJ9LHsibmFtZSI6ImMiLCJ0eXBlIjoiYm9vbCJ9XSwiT2JqZWN0NEI3MzE0QTkiOlt7Im5hbWUiOiJhIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImIiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoiYyIsInR5cGUiOiJib29sIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InRlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCxieXRlW10sYm9vbCkiLCJzdHJ1Y3QiOiJPYmplY3Q0QjczMTRBOSIsIm5hbWUiOiJwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RNdXRhYmxlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsYnl0ZVtdLGJvb2wpIiwic3RydWN0IjoiQXJjNCIsIm5hbWUiOiJwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImluaXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxMTQsMTY4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTIxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIEFyYzQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgT2JqZWN0NEI3MzE0QTkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDUsMTYwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggMSBvZiAodWludDY0LChsZW4rdWludDhbXSksYm9vbDEpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAxLDE1Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdHVwbGUgZW5jb2RpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQTRJREFnTVRFS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlrWlhOMGNuVmpkSFZ5WldRdGNHRnlZVzF6TG1Gc1oyOHVkSE02T0FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFUmxjM1J5ZFdOMGRYSmxaRkJoY21GdGMwRnNaMjhnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1UQUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VHWmxabVZoTnpZMklEQjRNelF6T1Rsa1lqUWdNSGc0TTJZeE5EYzBPQ0F2THlCdFpYUm9iMlFnSW5SbGMzUW9LSFZwYm5RMk5DeGllWFJsVzEwc1ltOXZiQ2twZG05cFpDSXNJRzFsZEdodlpDQWlkR1Z6ZEUxMWRHRmliR1VvS0hWcGJuUTJOQ3hpZVhSbFcxMHNZbTl2YkNrcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYVc1cGRDZ3BkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmZEdWemRGOXliM1YwWlVBMElHMWhhVzVmZEdWemRFMTFkR0ZpYkdWZmNtOTFkR1ZBTlNCdFlXbHVYMmx1YVhSZmNtOTFkR1ZBTmdvZ0lDQWdaWEp5Q2dwdFlXbHVYMmx1YVhSZmNtOTFkR1ZBTmpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlrWlhOMGNuVmpkSFZ5WldRdGNHRnlZVzF6TG1Gc1oyOHVkSE02TVRnS0lDQWdJQzh2SUhSb2FYTXVkR1Z6ZENoN0lHRTZJRFExTml3Z1lqb2dRbmwwWlhNb0p5Y3BMQ0JqT2lCbVlXeHpaU0I5S1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd01ERmpPREF3TUdJd01EQXdNREFLSUNBZ0lHTmhiR3h6ZFdJZ2RHVnpkQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlpHVnpkSEoxWTNSMWNtVmtMWEJoY21GdGN5NWhiR2R2TG5Sek9qRTVDaUFnSUNBdkx5QmpiMjV6ZENCMFpXMXdJRDBnZXlCaE9pQlZhVzUwTmpRb01pa3NJR0k2SUVKNWRHVnpLQ2RJWld4c2J5Y3BMQ0JqT2lCMGNuVmxJSDBLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdNREF3TURBd01ESXdNREJpT0RBd01EQTFORGcyTlRaak5tTTJaZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyUmxjM1J5ZFdOMGRYSmxaQzF3WVhKaGJYTXVZV3huYnk1MGN6b3lNQW9nSUNBZ0x5OGdkR2hwY3k1MFpYTjBLSFJsYlhBcENpQWdJQ0JqWVd4c2MzVmlJSFJsYzNRS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlJsYzNSeWRXTjBkWEpsWkMxd1lYSmhiWE11WVd4bmJ5NTBjem94TndvZ0lDQWdMeThnYVc1cGRDZ3BJSHNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z6ZEUxMWRHRmliR1ZmY205MWRHVkFOVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWtaWE4wY25WamRIVnlaV1F0Y0dGeVlXMXpMbUZzWjI4dWRITTZNVE1LSUNBZ0lDOHZJSFJsYzNSTmRYUmhZbXhsS0hzZ1lTd2dZaXdnWXlCOU9pQkJjbU0wS1NCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQjBkWEJzWlNCbGJtTnZaR2x1WndvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNVEVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCMFlXbHNJSEJ2YVc1MFpYSWdZWFFnYVc1a1pYZ2dNU0J2WmlBb2RXbHVkRFkwTENoc1pXNHJkV2x1ZERoYlhTa3NZbTl2YkRFcENpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTVRNS0lDQWdJQ3NLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnUVhKak5Bb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnTUNBNENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lIQjFjMmhwYm5RZ09EQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREFLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJSbGMzUnlkV04wZFhKbFpDMXdZWEpoYlhNdVlXeG5ieTUwY3pveE5Bb2dJQ0FnTHk4Z2JHOW5LR0VzSUdJc0lHTXBDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5a1pYTjBjblZqZEhWeVpXUXRjR0Z5WVcxekxtRnNaMjh1ZEhNNk1UTUtJQ0FnSUM4dklIUmxjM1JOZFhSaFlteGxLSHNnWVN3Z1lpd2dZeUI5T2lCQmNtTTBLU0I3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1JsYzNSZmNtOTFkR1ZBTkRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlrWlhOMGNuVmpkSFZ5WldRdGNHRnlZVzF6TG1Gc1oyOHVkSE02T1FvZ0lDQWdMeThnZEdWemRDaDdJR0VzSUdJc0lHTWdmVG9nZXlCaE9pQjFhVzUwTmpRN0lHSTZJR0o1ZEdWek95QmpPaUJpYjI5c1pXRnVJSDBwT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUhSMWNHeGxJR1Z1WTI5a2FXNW5DaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNeUF2THlBeE1Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJSFJoYVd3Z2NHOXBiblJsY2lCaGRDQnBibVJsZUNBeElHOW1JQ2gxYVc1ME5qUXNLR3hsYml0MWFXNTBPRnRkS1N4aWIyOXNNU2tLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNVE1LSUNBZ0lDc0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUU5aWFtVmpkRFJDTnpNeE5FRTVDaUFnSUNCallXeHNjM1ZpSUhSbGMzUUtJQ0FnSUhCdmNBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTVRBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WkdWemRISjFZM1IxY21Wa0xYQmhjbUZ0Y3k1aGJHZHZMblJ6T2pnS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkVaWE4wY25WamRIVnlaV1JRWVhKaGJYTkJiR2R2SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaR1Z6ZEhKMVkzUjFjbVZrTFhCaGNtRnRjeTVoYkdkdkxuUnpPanBFWlhOMGNuVmpkSFZ5WldSUVlYSmhiWE5CYkdkdkxuUmxjM1FvY0RvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwMFpYTjBPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyUmxjM1J5ZFdOMGRYSmxaQzF3WVhKaGJYTXVZV3huYnk1MGN6bzVDaUFnSUNBdkx5QjBaWE4wS0hzZ1lTd2dZaXdnWXlCOU9pQjdJR0U2SUhWcGJuUTJORHNnWWpvZ1lubDBaWE03SUdNNklHSnZiMnhsWVc0Z2ZTazZJSFp2YVdRZ2V3b2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHVjRkSEpoWTNRZ01DQTRDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JzWlc0S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2NIVnphR2x1ZENBNE1Bb2dJQ0FnWjJWMFltbDBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlpHVnpkSEoxWTNSMWNtVmtMWEJoY21GdGN5NWhiR2R2TG5Sek9qRXdDaUFnSUNBdkx5QnNiMmNvWVN3Z1lpd2dZeWtLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFRZ0FDekViUVFDb01Sa1VSREVZUklJREJQNytwMllFTkRtZHRBU0Q4VWRJTmhvQWpnTUFaUUF1QUFFQWdBMEFBQUFBQUFBQnlBQUxBQUFBaUFCNlNJQVNBQUFBQUFBQUFBSUFDNEFBQlVobGJHeHZpQUJpU0NKRE5ob0JTUlZMQVNOWlNTVVNSRXNDVEVzQ1Vra2tXWUVOQ0U4Q0VrUkxBVmNBQ0U4Q2dWQlRnQUVBSkU4Q1ZFeFBBbEJNVUxBaVF6WWFBVWtWU3dFaldVa2xFa1JMQWt4TEFsSWtXWUVOQ0JKRWlBQUxTQ0pETVJrVU1SZ1VFRU9LQVFHTC8xY0FDSXYvSTFtTC94V0wvMDRDVWxjQ0FJdi9nVkJUVGdKUVRCWlFzSXYvaVE9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
