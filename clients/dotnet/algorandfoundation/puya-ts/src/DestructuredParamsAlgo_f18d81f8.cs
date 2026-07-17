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

namespace Arc56.Generated.algorandfoundation.puya_ts.DestructuredParamsAlgo_f18d81f8
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRGVzdHJ1Y3R1cmVkUGFyYW1zQWxnbyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJBcmM0IjpbeyJuYW1lIjoiYSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJiIiwidHlwZSI6ImJ5dGVbXSJ9LHsibmFtZSI6ImMiLCJ0eXBlIjoiYm9vbCJ9XSwiT2JqZWN0NEI3MzE0QTkiOlt7Im5hbWUiOiJhIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImIiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoiYyIsInR5cGUiOiJib29sIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InRlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCxieXRlW10sYm9vbCkiLCJzdHJ1Y3QiOiJPYmplY3Q0QjczMTRBOSIsIm5hbWUiOiJwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RNdXRhYmxlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsYnl0ZVtdLGJvb2wpIiwic3RydWN0IjoiQXJjNCIsIm5hbWUiOiJwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImluaXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxNTEsMTk0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjA2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIEFyYzQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgT2JqZWN0NEI3MzE0QTkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDIsMTg1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggMSBvZiAodWludDY0LChsZW4rdWludDhbXSksYm9vbDEpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM4LDE4MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdHVwbGUgZW5jb2RpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRGdnTVRFS0lDQWdJR0o1ZEdWallteHZZMnNnTUhnZ01IZ3dNQ0FpU0dWc2JHOGlDaUFnSUNCaUlHMWhhVzVmWW14dlkydEFNQW9LYldGcGJsOWliRzlqYTBBd09nb2dJQ0FnWWlCdFlXbHVYMkpzYjJOclFERUtDbTFoYVc1ZllteHZZMnRBTVRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlrWlhOMGNuVmpkSFZ5WldRdGNHRnlZVzF6TG1Gc1oyOHVkSE02T0FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFUmxjM1J5ZFdOMGRYSmxaRkJoY21GdGMwRnNaMjhnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDRTlDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUF4TUFvZ0lDQWdZaUJ0WVdsdVgyRmlhVjl5YjNWMGFXNW5RRElLQ20xaGFXNWZZV0pwWDNKdmRYUnBibWRBTWpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlrWlhOMGNuVmpkSFZ5WldRdGNHRnlZVzF6TG1Gc1oyOHVkSE02T0FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFUmxjM1J5ZFdOMGRYSmxaRkJoY21GdGMwRnNaMjhnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnVG05UGNBb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBaFBRb2dJQ0FnWW5vZ2JXRnBibDlqY21WaGRHVmZUbTlQY0VBNENpQWdJQ0JpSUcxaGFXNWZZMkZzYkY5T2IwOXdRRE1LQ20xaGFXNWZZMkZzYkY5T2IwOXdRRE02Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaR1Z6ZEhKMVkzUjFjbVZrTFhCaGNtRnRjeTVoYkdkdkxuUnpPamdLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCRVpYTjBjblZqZEhWeVpXUlFZWEpoYlhOQmJHZHZJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRabVZtWldFM05qWWdMeThnYldWMGFHOWtJQ0owWlhOMEtDaDFhVzUwTmpRc1lubDBaVnRkTEdKdmIyd3BLWFp2YVdRaUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnek5ETTVPV1JpTkNBdkx5QnRaWFJvYjJRZ0luUmxjM1JOZFhSaFlteGxLQ2gxYVc1ME5qUXNZbmwwWlZ0ZExHSnZiMndwS1hadmFXUWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzRNMll4TkRjME9DQXZMeUJ0WlhSb2IyUWdJbWx1YVhRb0tYWnZhV1FpQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZmRHVnpkRjl5YjNWMFpVQTBJRzFoYVc1ZmRHVnpkRTExZEdGaWJHVmZjbTkxZEdWQU5TQnRZV2x1WDJsdWFYUmZjbTkxZEdWQU5nb2dJQ0FnWWlCdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFOd29LYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFEYzZDaUFnSUNCaUlHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQTVDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBT1RvS0lDQWdJR0lnYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFeENncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVEU2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaR1Z6ZEhKMVkzUjFjbVZrTFhCaGNtRnRjeTVoYkdkdkxuUnpPamdLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCRVpYTjBjblZqZEhWeVpXUlFZWEpoYlhOQmJHZHZJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ1pYSnlDZ3B0WVdsdVgybHVhWFJmY205MWRHVkFOam9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWtaWE4wY25WamRIVnlaV1F0Y0dGeVlXMXpMbUZzWjI4dWRITTZNVGNLSUNBZ0lDOHZJR2x1YVhRb0tTQjdDaUFnSUNCallXeHNjM1ZpSUdsdWFYUUtJQ0FnSUdJZ2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRRGNLQ20xaGFXNWZkR1Z6ZEUxMWRHRmliR1ZmY205MWRHVkFOVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWtaWE4wY25WamRIVnlaV1F0Y0dGeVlXMXpMbUZzWjI4dWRITTZNVE1LSUNBZ0lDOHZJSFJsYzNSTmRYUmhZbXhsS0hzZ1lTd2dZaXdnWXlCOU9pQkJjbU0wS1NCN0NpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSTmRYUmhZbXhsQ2lBZ0lDQmlJRzFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBM0NncHRZV2x1WDNSbGMzUmZjbTkxZEdWQU5Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5a1pYTjBjblZqZEhWeVpXUXRjR0Z5WVcxekxtRnNaMjh1ZEhNNk9Rb2dJQ0FnTHk4Z2RHVnpkQ2g3SUdFc0lHSXNJR01nZlRvZ2V5QmhPaUIxYVc1ME5qUTdJR0k2SUdKNWRHVnpPeUJqT2lCaWIyOXNaV0Z1SUgwcE9pQjJiMmxrSUhzS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEFvZ0lDQWdZaUJ0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU53b0tiV0ZwYmw5amNtVmhkR1ZmVG05UGNFQTRPZ29nSUNBZ1lpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFPUW9LYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1UQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlpHVnpkSEoxWTNSMWNtVmtMWEJoY21GdGN5NWhiR2R2TG5Sek9qZ0tJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJFWlhOMGNuVmpkSFZ5WldSUVlYSmhiWE5CYkdkdklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklFNXZUM0FLSUNBZ0lEMDlDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lEMDlDaUFnSUNBbUpnb2dJQ0FnWVhOelpYSjBDaUFnSUNCallXeHNjM1ZpSUY5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5a1pYTjBjblZqZEhWeVpXUXRjR0Z5WVcxekxtRnNaMjh1ZEhNNk9rUmxjM1J5ZFdOMGRYSmxaRkJoY21GdGMwRnNaMjh1ZEdWemRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblJsYzNRNkNpQWdJQ0JpSUhSbGMzUmZZbXh2WTJ0QU1Bb0tkR1Z6ZEY5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlJsYzNSeWRXTjBkWEpsWkMxd1lYSmhiWE11WVd4bmJ5NTBjem81Q2lBZ0lDQXZMeUIwWlhOMEtIc2dZU3dnWWl3Z1l5QjlPaUI3SUdFNklIVnBiblEyTkRzZ1lqb2dZbmwwWlhNN0lHTTZJR0p2YjJ4bFlXNGdmU2s2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdOdmRtVnlJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUhSMWNHeGxJR1Z1WTI5a2FXNW5DaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNeUF2THlBeE1Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJSFJoYVd3Z2NHOXBiblJsY2lCaGRDQnBibVJsZUNBeElHOW1JQ2gxYVc1ME5qUXNLR3hsYml0MWFXNTBPRnRkS1N4aWIyOXNNU2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXFDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ3NLSUNBZ0lHbHVkR05mTXlBdkx5QXhNUW9nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnVDJKcVpXTjBORUkzTXpFMFFUa0tJQ0FnSUdOaGJHeHpkV0lnZEdWemRITXZZWEJ3Y205MllXeHpMMlJsYzNSeWRXTjBkWEpsWkMxd1lYSmhiWE11WVd4bmJ5NTBjem82UkdWemRISjFZM1IxY21Wa1VHRnlZVzF6UVd4bmJ5NTBaWE4wQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyUmxjM1J5ZFdOMGRYSmxaQzF3WVhKaGJYTXVZV3huYnk1MGN6bzZSR1Z6ZEhKMVkzUjFjbVZrVUdGeVlXMXpRV3huYnk1MFpYTjBUWFYwWVdKc1pWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblJsYzNSTmRYUmhZbXhsT2dvZ0lDQWdZaUIwWlhOMFRYVjBZV0pzWlY5aWJHOWphMEF3Q2dwMFpYTjBUWFYwWVdKc1pWOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJSbGMzUnlkV04wZFhKbFpDMXdZWEpoYlhNdVlXeG5ieTUwY3pveE13b2dJQ0FnTHk4Z2RHVnpkRTExZEdGaWJHVW9leUJoTENCaUxDQmpJSDA2SUVGeVl6UXBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCamIzWmxjaUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCMGRYQnNaU0JsYm1OdlpHbHVad29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYek1nTHk4Z01URUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0IwWVdsc0lIQnZhVzUwWlhJZ1lYUWdhVzVrWlhnZ01TQnZaaUFvZFdsdWREWTBMQ2hzWlc0cmRXbHVkRGhiWFNrc1ltOXZiREVwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FyQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNVEVLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUVGeVl6UUtJQ0FnSUdOaGJHeHpkV0lnZEdWemRITXZZWEJ3Y205MllXeHpMMlJsYzNSeWRXTjBkWEpsWkMxd1lYSmhiWE11WVd4bmJ5NTBjem82UkdWemRISjFZM1IxY21Wa1VHRnlZVzF6UVd4bmJ5NTBaWE4wVFhWMFlXSnNaUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5a1pYTjBjblZqZEhWeVpXUXRjR0Z5WVcxekxtRnNaMjh1ZEhNNk9rUmxjM1J5ZFdOMGRYSmxaRkJoY21GdGMwRnNaMjh1YVc1cGRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWx1YVhRNkNpQWdJQ0JpSUdsdWFYUmZZbXh2WTJ0QU1Bb0thVzVwZEY5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlJsYzNSeWRXTjBkWEpsWkMxd1lYSmhiWE11WVd4bmJ5NTBjem94TndvZ0lDQWdMeThnYVc1cGRDZ3BJSHNLSUNBZ0lHTmhiR3h6ZFdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDJSbGMzUnlkV04wZFhKbFpDMXdZWEpoYlhNdVlXeG5ieTUwY3pvNlJHVnpkSEoxWTNSMWNtVmtVR0Z5WVcxelFXeG5ieTVwYm1sMENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlJsYzNSeWRXTjBkWEpsWkMxd1lYSmhiWE11WVd4bmJ5NTBjem82UkdWemRISjFZM1IxY21Wa1VHRnlZVzF6UVd4bmJ5NTBaWE4wS0hBNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDJSbGMzUnlkV04wZFhKbFpDMXdZWEpoYlhNdVlXeG5ieTUwY3pvNlJHVnpkSEoxWTNSMWNtVmtVR0Z5WVcxelFXeG5ieTUwWlhOME9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJSbGMzUnlkV04wZFhKbFpDMXdZWEpoYlhNdVlXeG5ieTUwY3pvNUNpQWdJQ0F2THlCMFpYTjBLSHNnWVN3Z1lpd2dZeUI5T2lCN0lHRTZJSFZwYm5RMk5Ec2dZam9nWW5sMFpYTTdJR002SUdKdmIyeGxZVzRnZlNrNklIWnZhV1FnZXdvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNCaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5a1pYTjBjblZqZEhWeVpXUXRjR0Z5WVcxekxtRnNaMjh1ZEhNNk9rUmxjM1J5ZFdOMGRYSmxaRkJoY21GdGMwRnNaMjh1ZEdWemRGOWliRzlqYTBBd0NncDBaWE4wY3k5aGNIQnliM1poYkhNdlpHVnpkSEoxWTNSMWNtVmtMWEJoY21GdGN5NWhiR2R2TG5Sek9qcEVaWE4wY25WamRIVnlaV1JRWVhKaGJYTkJiR2R2TG5SbGMzUmZZbXh2WTJ0QU1Eb0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJSbGMzUnlkV04wZFhKbFpDMXdZWEpoYlhNdVlXeG5ieTUwY3pvNUNpQWdJQ0F2THlCMFpYTjBLSHNnWVN3Z1lpd2dZeUI5T2lCN0lHRTZJSFZwYm5RMk5Ec2dZam9nWW5sMFpYTTdJR002SUdKdmIyeGxZVzRnZlNrNklIWnZhV1FnZXdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCc1pXNEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lIQjFjMmhwYm5RZ09EQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjNabGNpQXhDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaR1Z6ZEhKMVkzUjFjbVZrTFhCaGNtRnRjeTVoYkdkdkxuUnpPakV3Q2lBZ0lDQXZMeUJzYjJjb1lTd2dZaXdnWXlrS0lDQWdJR2wwYjJJS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlpHVnpkSEoxWTNSMWNtVmtMWEJoY21GdGN5NWhiR2R2TG5Sek9qcEVaWE4wY25WamRIVnlaV1JRWVhKaGJYTkJiR2R2TG5SbGMzUk5kWFJoWW14bEtIQTZJR0o1ZEdWektTQXRQaUIyYjJsa09ncDBaWE4wY3k5aGNIQnliM1poYkhNdlpHVnpkSEoxWTNSMWNtVmtMWEJoY21GdGN5NWhiR2R2TG5Sek9qcEVaWE4wY25WamRIVnlaV1JRWVhKaGJYTkJiR2R2TG5SbGMzUk5kWFJoWW14bE9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJSbGMzUnlkV04wZFhKbFpDMXdZWEpoYlhNdVlXeG5ieTUwY3pveE13b2dJQ0FnTHk4Z2RHVnpkRTExZEdGaWJHVW9leUJoTENCaUxDQmpJSDA2SUVGeVl6UXBJSHNLSUNBZ0lIQnliM1J2SURFZ01Bb2dJQ0FnWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12WkdWemRISjFZM1IxY21Wa0xYQmhjbUZ0Y3k1aGJHZHZMblJ6T2pwRVpYTjBjblZqZEhWeVpXUlFZWEpoYlhOQmJHZHZMblJsYzNSTmRYUmhZbXhsWDJKc2IyTnJRREFLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTlrWlhOMGNuVmpkSFZ5WldRdGNHRnlZVzF6TG1Gc1oyOHVkSE02T2tSbGMzUnlkV04wZFhKbFpGQmhjbUZ0YzBGc1oyOHVkR1Z6ZEUxMWRHRmliR1ZmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWtaWE4wY25WamRIVnlaV1F0Y0dGeVlXMXpMbUZzWjI4dWRITTZNVE1LSUNBZ0lDOHZJSFJsYzNSTmRYUmhZbXhsS0hzZ1lTd2dZaXdnWXlCOU9pQkJjbU0wS1NCN0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHeGxiZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J3ZFhOb2FXNTBJRGd3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmRtVnlJREVLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WkdWemRISjFZM1IxY21Wa0xYQmhjbUZ0Y3k1aGJHZHZMblJ6T2pFMENpQWdJQ0F2THlCc2IyY29ZU3dnWWl3Z1l5a0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJSbGMzUnlkV04wZFhKbFpDMXdZWEpoYlhNdVlXeG5ieTUwY3pvNlJHVnpkSEoxWTNSMWNtVmtVR0Z5WVcxelFXeG5ieTVwYm1sMEtDa2dMVDRnZG05cFpEb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyUmxjM1J5ZFdOMGRYSmxaQzF3WVhKaGJYTXVZV3huYnk1MGN6bzZSR1Z6ZEhKMVkzUjFjbVZrVUdGeVlXMXpRV3huYnk1cGJtbDBPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyUmxjM1J5ZFdOMGRYSmxaQzF3WVhKaGJYTXVZV3huYnk1MGN6b3hOd29nSUNBZ0x5OGdhVzVwZENncElIc0tJQ0FnSUhCeWIzUnZJREFnTUFvZ0lDQWdZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaR1Z6ZEhKMVkzUjFjbVZrTFhCaGNtRnRjeTVoYkdkdkxuUnpPanBFWlhOMGNuVmpkSFZ5WldSUVlYSmhiWE5CYkdkdkxtbHVhWFJmWW14dlkydEFNQW9LZEdWemRITXZZWEJ3Y205MllXeHpMMlJsYzNSeWRXTjBkWEpsWkMxd1lYSmhiWE11WVd4bmJ5NTBjem82UkdWemRISjFZM1IxY21Wa1VHRnlZVzF6UVd4bmJ5NXBibWwwWDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaR1Z6ZEhKMVkzUjFjbVZrTFhCaGNtRnRjeTVoYkdkdkxuUnpPakU0Q2lBZ0lDQXZMeUIwYUdsekxuUmxjM1FvZXlCaE9pQTBOVFlzSUdJNklFSjVkR1Z6S0NjbktTd2dZem9nWm1Gc2MyVWdmU2tLSUNBZ0lIQjFjMmhwYm5RZ05EVTJDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaUlnb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdZbmwwWldOZk1DQXZMeUFpSWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JwYm5Salh6TWdMeThnTVRFS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdjMlYwWW1sMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWtaWE4wY25WamRIVnlaV1F0Y0dGeVlXMXpMbUZzWjI4dWRITTZPa1JsYzNSeWRXTjBkWEpsWkZCaGNtRnRjMEZzWjI4dWRHVnpkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyUmxjM1J5ZFdOMGRYSmxaQzF3WVhKaGJYTXVZV3huYnk1MGN6b3hPUW9nSUNBZ0x5OGdZMjl1YzNRZ2RHVnRjQ0E5SUhzZ1lUb2dWV2x1ZERZMEtESXBMQ0JpT2lCQ2VYUmxjeWduU0dWc2JHOG5LU3dnWXpvZ2RISjFaU0I5Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKSVpXeHNieUlLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0lraGxiR3h2SWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JwYm5Salh6TWdMeThnTVRFS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjMlYwWW1sMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WkdWemRISjFZM1IxY21Wa0xYQmhjbUZ0Y3k1aGJHZHZMblJ6T2pJd0NpQWdJQ0F2THlCMGFHbHpMblJsYzNRb2RHVnRjQ2tLSUNBZ0lHTmhiR3h6ZFdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDJSbGMzUnlkV04wZFhKbFpDMXdZWEpoYlhNdVlXeG5ieTUwY3pvNlJHVnpkSEoxWTNSMWNtVmtVR0Z5WVcxelFXeG5ieTUwWlhOMENpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WkdWemRISjFZM1IxY21Wa0xYQmhjbUZ0Y3k1aGJHZHZMblJ6T2pwRVpYTjBjblZqZEhWeVpXUlFZWEpoYlhOQmJHZHZMbDlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpTZ3BJQzArSUhadmFXUTZDbDlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpUb0tJQ0FnSUdJZ1gxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsWDJKc2IyTnJRREFLQ2w5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVjlpYkc5amEwQXdPZ29nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JpSUcxaGFXNWZZbXh2WTJ0QU1Bb0tiV0ZwYmw5aWJHOWphMEF3T2dvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUlDeVlEQUFFQUJVaGxiR3h2UWdBQVFnQUFNUnNpRTBFQVVFSUFBREVaSWhKRU1SZ2lFMEVBUGtJQUFEWWFBSUFFL3Y2blpvQUVORG1kdElBRWcvRkhTRThEamdNQUZnQVFBQXBDQUFCQ0FBQkNBQUFBaUFCM1F2L3ppQUJHUXYvdGlBQVZRdi9uUXYvbk1Sa2lFakVZSWhJUVJJZ0JGeU5EUWdBQU5ob0JTUlZPQVVra1dVa2xFa1JMQVU4QlR3TlNJbGtqQzRFQ0NDVUlTd0VWRWtTSUFEVWpRMElBQURZYUFVa1ZUZ0ZKSkZsSkpSSkVTd0ZQQVU4RFVpSlpJd3VCQWdnbENFc0JGUkpFaUFBK0kwTkNBQUNJQUdralE0b0JBVUlBQUl2L2kvOGlKRmdYaS84a1dZdi9GWXYvVHdKUEFsSlhBZ0NMLzRGUVUwOENUZ0ZPQWhaUEFWQlBBUlpRc0ltS0FRQkNBQUNML3lJa1dJdi9KRm1ML3hXTC8wOENUd0pTaS8rQlVGTXBJazhDVkU4Q1RnRlBBazhCVGdKUVR3RlFzSW1LQUFCQ0FBQ0J5QU1XS0U4QlVDZ1ZGbGNHQWloUUpSWlhCZ0pQQWs4QlVDa2lJbFJRVHdGUWlQOXVnUUlXS0U4QlVDb1ZGbGNHQWlwUUpSWlhCZ0pQQWs4QlVDa2lJMVJRVHdGUWlQOUtpVUlBQUlrPSIsImNsZWFyIjoiQzBJQUFJRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
