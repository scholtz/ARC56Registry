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

namespace Arc56.Generated.algorandfoundation.TEALScript.ABITestNestedTuple_4fe99338
{


    public class ABITestNestedTupleProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ABITestNestedTupleProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class NestedTupleReturn : AVMObjectType
            {
                public ushort Field0 { get; set; }

                public Structs.NestedTupleReturnField1 Field1 { get; set; } = new Structs.NestedTupleReturnField1();

                public Structs.NestedTupleReturnField2 Field2 { get; set; } = new Structs.NestedTupleReturnField2();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    stringRef[ret.Count] = Field1.ToByteArray();
                    ret.AddRange(new byte[2]);
                    stringRef[ret.Count] = Field2.ToByteArray();
                    ret.AddRange(new byte[2]);
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static NestedTupleReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new NestedTupleReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ushort vField0Value) { ret.Field0 = vField0Value; }
                    var indexField1 = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Field1 = Structs.NestedTupleReturnField1.Parse(bytes.Skip(indexField1 + prefixOffset).ToArray());
                    var indexField2 = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Field2 = Structs.NestedTupleReturnField2.Parse(bytes.Skip(indexField2 + prefixOffset).ToArray());
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as NestedTupleReturn);
                }
                public bool Equals(NestedTupleReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(NestedTupleReturn left, NestedTupleReturn right)
                {
                    return EqualityComparer<NestedTupleReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(NestedTupleReturn left, NestedTupleReturn right)
                {
                    return !(left == right);
                }

            }

            public class NestedTupleReturnField1 : AVMObjectType
            {
                public byte Field0 { get; set; }

                public string Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField1.From(Field1);
                    stringRef[ret.Count] = vField1.Encode();
                    ret.AddRange(new byte[2]);
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static NestedTupleReturnField1 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new NestedTupleReturnField1();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is byte vField0Value) { ret.Field0 = vField0Value; }
                    var indexField1 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField1.Decode(bytes.Skip(indexField1 + prefixOffset).ToArray());
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is string vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as NestedTupleReturnField1);
                }
                public bool Equals(NestedTupleReturnField1? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(NestedTupleReturnField1 left, NestedTupleReturnField1 right)
                {
                    return EqualityComparer<NestedTupleReturnField1>.Default.Equals(left, right);
                }
                public static bool operator !=(NestedTupleReturnField1 left, NestedTupleReturnField1 right)
                {
                    return !(left == right);
                }

            }

            public class NestedTupleReturnField2 : AVMObjectType
            {
                public ushort Field0 { get; set; }

                public string Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField1.From(Field1);
                    stringRef[ret.Count] = vField1.Encode();
                    ret.AddRange(new byte[2]);
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static NestedTupleReturnField2 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new NestedTupleReturnField2();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ushort vField0Value) { ret.Field0 = vField0Value; }
                    var indexField1 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField1.Decode(bytes.Skip(indexField1 + prefixOffset).ToArray());
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is string vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as NestedTupleReturnField2);
                }
                public bool Equals(NestedTupleReturnField2? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(NestedTupleReturnField2 left, NestedTupleReturnField2 right)
                {
                    return EqualityComparer<NestedTupleReturnField2>.Default.Equals(left, right);
                }
                public static bool operator !=(NestedTupleReturnField2 left, NestedTupleReturnField2 right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.NestedTupleReturn> NestedTuple(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 73, 187, 112, 25 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.NestedTupleReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> NestedTuple_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 73, 187, 112, 25 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJBQklUZXN0TmVzdGVkVHVwbGUiLCJkZXNjIjoiIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7Ik5lc3RlZFR1cGxlUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQxNiJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJOZXN0ZWRUdXBsZVJldHVybkZpZWxkMSJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJOZXN0ZWRUdXBsZVJldHVybkZpZWxkMiJ9XSwiTmVzdGVkVHVwbGVSZXR1cm5GaWVsZDEiOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDgifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoic3RyaW5nIn1dLCJOZXN0ZWRUdXBsZVJldHVybkZpZWxkMiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50MTYifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoic3RyaW5nIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6Im5lc3RlZFR1cGxlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50MTYsKHVpbnQ4LHN0cmluZyksKHVpbnQxNixzdHJpbmcpKSIsInN0cnVjdCI6Ik5lc3RlZFR1cGxlUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImNyZWF0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2OTAifSx7InBjIjpbMSwyLDNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2OTAifSx7InBjIjpbNCw1LDZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2OTAifSx7InBjIjpbNyw4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY5MCJ9LHsicGMiOls5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY5MCJ9LHsicGMiOlsxMCwxMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2OTAifSx7InBjIjpbMTJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjkwIn0seyJwYyI6WzEzLDE0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxOSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY5MCJ9LHsicGMiOlsxNV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2OTAifSx7InBjIjpbMTYsMTcsMTgsMTksMjAsMjEsMjIsMjMsMjQsMjUsMjYsMjcsMjgsMjksMzAsMzEsMzIsMzMsMzQsMzUsMzYsMzcsMzgsMzksNDAsNDFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjkwIn0seyJwYyI6WzQyXSwiZXJyb3JNZXNzYWdlIjoiVGhlIHJlcXVlc3RlZCBhY3Rpb24gaXMgbm90IGltcGxlbWVudGVkIGluIHRoaXMgY29udHJhY3QuIEFyZSB5b3UgdXNpbmcgdGhlIGNvcnJlY3QgT25Db21wbGV0ZT8gRGlkIHlvdSBzZXQgeW91ciBhcHAgSUQ/IiwidGVhbCI6MjUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2OTAifSx7InBjIjpbNDMsNDQsNDUsNDYsNDcsNDhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjkxIn0seyJwYyI6WzQ5LDUwLDUxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY5MSJ9LHsicGMiOls1Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2OTEifSx7InBjIjpbNTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjkxIn0seyJwYyI6WzU0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY5MSJ9LHsicGMiOls1NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2OTEifSx7InBjIjpbNTYsNTcsNThdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjkxIn0seyJwYyI6WzU5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY5MSJ9LHsicGMiOls2MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2OTIifSx7InBjIjpbNjFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQ5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjkyIn0seyJwYyI6WzYyLDYzLDY0LDY1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1MCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY5MiJ9LHsicGMiOls2Niw2Nyw2OCw2OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2OTIifSx7InBjIjpbNzAsNzEsNzJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjUyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjkyIn0seyJwYyI6WzczXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY5MiJ9LHsicGMiOls3NF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2OTIifSx7InBjIjpbNzUsNzYsNzcsNzhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjkyIn0seyJwYyI6Wzc5LDgwLDgxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY5MiJ9LHsicGMiOls4Miw4Myw4NF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2OTIifSx7InBjIjpbODUsODYsODcsODgsODksOTAsOTFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjkyIn0seyJwYyI6WzkyLDkzLDk0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1OSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY5MiJ9LHsicGMiOls5NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2OTIifSx7InBjIjpbOTZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjYxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjkyIn0seyJwYyI6Wzk3LDk4LDk5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY5MiJ9LHsicGMiOlsxMDBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjYzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjkyIn0seyJwYyI6WzEwMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2OTIifSx7InBjIjpbMTAyLDEwMywxMDQsMTA1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2NSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY5MiJ9LHsicGMiOlsxMDYsMTA3LDEwOCwxMDldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjkyIn0seyJwYyI6WzExMCwxMTEsMTEyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2Nywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY5MiJ9LHsicGMiOlsxMTMsMTE0LDExNSwxMTYsMTE3LDExOCwxMTldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjkyIn0seyJwYyI6WzEyMCwxMjEsMTIyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2OSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY5MiJ9LHsicGMiOlsxMjNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjcwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjkyIn0seyJwYyI6WzEyNF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2OTIifSx7InBjIjpbMTI1LDEyNiwxMjddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjcyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjkyIn0seyJwYyI6WzEyOF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2OTIifSx7InBjIjpbMTI5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY5MiJ9LHsicGMiOlsxMzAsMTMxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3NSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY5MiJ9LHsicGMiOlsxMzIsMTMzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3OSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY5NCJ9LHsicGMiOlsxMzQsMTM1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY5MSJ9LHsicGMiOlsxMzZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjgzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjkxIn0seyJwYyI6WzEzN10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2OTAifSx7InBjIjpbMTM4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4Nywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY5MCJ9LHsicGMiOlsxMzksMTQwLDE0MSwxNDIsMTQzLDE0NF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2OTAifSx7InBjIjpbMTQ1LDE0NiwxNDddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjkxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjkwIn0seyJwYyI6WzE0OCwxNDksMTUwLDE1MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2OTAifSx7InBjIjpbMTUyXSwiZXJyb3JNZXNzYWdlIjoidGhpcyBjb250cmFjdCBkb2VzIG5vdCBpbXBsZW1lbnQgdGhlIGdpdmVuIEFCSSBtZXRob2QgZm9yIGNyZWF0ZSBOb09wIiwidGVhbCI6OTUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2OTAifSx7InBjIjpbMTUzLDE1NCwxNTUsMTU2LDE1NywxNThdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjk4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjkwIn0seyJwYyI6WzE1OSwxNjAsMTYxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo5OSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY5MCJ9LHsicGMiOlsxNjIsMTYzLDE2NCwxNjVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwMCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY5MCJ9LHsicGMiOlsxNjZdLCJlcnJvck1lc3NhZ2UiOiJ0aGlzIGNvbnRyYWN0IGRvZXMgbm90IGltcGxlbWVudCB0aGUgZ2l2ZW4gQUJJIG1ldGhvZCBmb3IgY2FsbCBOb09wIiwidGVhbCI6MTAzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjkwIn0seyJwYyI6WzE2NywxNjgsMTY5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2OTAifSx7InBjIjpbMTcwLDE3MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTA3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjkwIn0seyJwYyI6WzE3MiwxNzNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwOCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY5MCJ9LHsicGMiOlsxNzRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwOSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY5MCJ9LHsicGMiOlsxNzUsMTc2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMTAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2OTAifSx7InBjIjpbMTc3LDE3OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTExLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjkwIn0seyJwYyI6WzE3OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTEyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjkwIn0seyJwYyI6WzE4MCwxODEsMTgyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMTUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2OTAifSx7InBjIjpbMTgzLDE4NF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTE2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjkwIn0seyJwYyI6WzE4NSwxODZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjExNywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY5MCJ9LHsicGMiOlsxODddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjExOCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY5MCJ9LHsicGMiOlsxODgsMTg5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMTksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2OTAifSx7InBjIjpbMTkwLDE5MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTIwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjkwIn0seyJwYyI6WzE5Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTIxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjkwIn0seyJwYyI6WzE5M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTIyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjkwIn0seyJwYyI6WzE5NCwxOTVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyMywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY5MCJ9LHsicGMiOlsxOTZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyNCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY5MCJ9LHsicGMiOlsxOTddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyNSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY5MCJ9LHsicGMiOlsxOThdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyNiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY5MCJ9LHsicGMiOlsxOTksMjAwLDIwMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTI3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjkwIn0seyJwYyI6WzIwMiwyMDNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyOCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY5MCJ9LHsicGMiOlsyMDQsMjA1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMjksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2OTAifSx7InBjIjpbMjA2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMzAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2OTAifSx7InBjIjpbMjA3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMzEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2OTAifSx7InBjIjpbMjA4LDIwOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTMyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjkwIn0seyJwYyI6WzIxMCwyMTFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEzMywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY5MCJ9LHsicGMiOlsyMTIsMjEzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMzQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2OTAifSx7InBjIjpbMjE0LDIxNV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTM1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjkwIn0seyJwYyI6WzIxNl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTM2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjkwIn1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q21sdWRHTmliRzlqYXlBeENtSjVkR1ZqWW14dlkyc2dNSGdLQ2k4dklGUm9hWE1nVkVWQlRDQjNZWE1nWjJWdVpYSmhkR1ZrSUdKNUlGUkZRVXhUWTNKcGNIUWdkakF1TVRBM0xqSUtMeThnYUhSMGNITTZMeTluYVhSb2RXSXVZMjl0TDJGc1oyOXlZVzVrWm05MWJtUmhkR2x2Ymk5VVJVRk1VMk55YVhCMENnb3ZMeUJVYUdseklHTnZiblJ5WVdOMElHbHpJR052YlhCc2FXRnVkQ0IzYVhSb0lHRnVaQzl2Y2lCcGJYQnNaVzFsYm5SeklIUm9aU0JtYjJ4c2IzZHBibWNnUVZKRGN6b2dXeUJCVWtNMElGMEtDaTh2SUZSb1pTQm1iMnhzYjNkcGJtY2dkR1Z1SUd4cGJtVnpJRzltSUZSRlFVd2dhR0Z1Wkd4bElHbHVhWFJwWVd3Z2NISnZaM0poYlNCbWJHOTNDaTh2SUZSb2FYTWdjR0YwZEdWeWJpQnBjeUIxYzJWa0lIUnZJRzFoYTJVZ2FYUWdaV0Z6ZVNCbWIzSWdZVzU1YjI1bElIUnZJSEJoY25ObElIUm9aU0J6ZEdGeWRDQnZaaUIwYUdVZ2NISnZaM0poYlNCaGJtUWdaR1YwWlhKdGFXNWxJR2xtSUdFZ2MzQmxZMmxtYVdNZ1lXTjBhVzl1SUdseklHRnNiRzkzWldRS0x5OGdTR1Z5WlN3Z1lXTjBhVzl1SUhKbFptVnljeUIwYnlCMGFHVWdUMjVEYjIxd2JHVjBaU0JwYmlCamIyMWlhVzVoZEdsdmJpQjNhWFJvSUhkb1pYUm9aWElnZEdobElHRndjQ0JwY3lCaVpXbHVaeUJqY21WaGRHVmtJRzl5SUdOaGJHeGxaQW92THlCRmRtVnllU0J3YjNOemFXSnNaU0JoWTNScGIyNGdabTl5SUhSb2FYTWdZMjl1ZEhKaFkzUWdhWE1nY21Wd2NtVnpaVzUwWldRZ2FXNGdkR2hsSUhOM2FYUmphQ0J6ZEdGMFpXMWxiblFLTHk4Z1NXWWdkR2hsSUdGamRHbHZiaUJwY3lCdWIzUWdhVzF3YkdWdFpXNTBaV1FnYVc0Z2RHaGxJR052Ym5SeVlXTjBMQ0JwZEhNZ2NtVnpjR1ZqZEdsMlpTQmljbUZ1WTJnZ2QybHNiQ0JpWlNBaUtrNVBWRjlKVFZCTVJVMUZUbFJGUkNJZ2QyaHBZMmdnYW5WemRDQmpiMjUwWVdsdWN5QWlaWEp5SWdwMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvaENuQjFjMmhwYm5RZ05nb3FDblI0YmlCUGJrTnZiWEJzWlhScGIyNEtLd3B6ZDJsMFkyZ2dLbU5oYkd4ZlRtOVBjQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0ttTnlaV0YwWlY5T2IwOXdJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkFvS0trNVBWRjlKVFZCTVJVMUZUbFJGUkRvS0NTOHZJRlJvWlNCeVpYRjFaWE4wWldRZ1lXTjBhVzl1SUdseklHNXZkQ0JwYlhCc1pXMWxiblJsWkNCcGJpQjBhR2x6SUdOdmJuUnlZV04wTGlCQmNtVWdlVzkxSUhWemFXNW5JSFJvWlNCamIzSnlaV04wSUU5dVEyOXRjR3hsZEdVL0lFUnBaQ0I1YjNVZ2MyVjBJSGx2ZFhJZ1lYQndJRWxFUHdvSlpYSnlDZ292THlCdVpYTjBaV1JVZFhCc1pTZ3BLSFZwYm5ReE5pd29kV2x1ZERnc2MzUnlhVzVuS1N3b2RXbHVkREUyTEhOMGNtbHVaeWtwQ2lwaFltbGZjbTkxZEdWZmJtVnpkR1ZrVkhWd2JHVTZDZ2t2THlCVWFHVWdRVUpKSUhKbGRIVnliaUJ3Y21WbWFYZ0tDWEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxQ2dvSkx5OGdaWGhsWTNWMFpTQnVaWE4wWldSVWRYQnNaU2dwS0hWcGJuUXhOaXdvZFdsdWREZ3NjM1J5YVc1bktTd29kV2x1ZERFMkxITjBjbWx1WnlrcENnbGpZV3hzYzNWaUlHNWxjM1JsWkZSMWNHeGxDZ2xqYjI1allYUUtDV3h2WndvSmFXNTBZeUF3SUM4dklERUtDWEpsZEhWeWJnb0tMeThnYm1WemRHVmtWSFZ3YkdVb0tUb2dXM1ZwYm5ReE5pd2dXM1ZwYm5ROE9ENHNJSE4wY21sdVoxMHNJRnQxYVc1ME1UWXNJSE4wY21sdVoxMWRDbTVsYzNSbFpGUjFjR3hsT2dvSmNISnZkRzhnTUNBeENnb0pMeThnVUhWemFDQmxiWEIwZVNCaWVYUmxjeUJoWm5SbGNpQjBhR1VnWm5KaGJXVWdjRzlwYm5SbGNpQjBieUJ5WlhObGNuWmxJSE53WVdObElHWnZjaUJzYjJOaGJDQjJZWEpwWVdKc1pYTUtDV0o1ZEdWaklEQWdMeThnTUhnS0Nna3ZMeUIwWlhOMGN5OWpiMjUwY21GamRITXZZV0pwTG1Gc1oyOHVkSE02TmpreUNna3ZMeUJoT2lCYmRXbHVkREUyTENCYmRXbHVkRHc0UGl3Z2MzUnlhVzVuWFN3Z1czVnBiblF4Tml3Z2MzUnlhVzVuWFYwZ1BTQmJNVEVzSUZzeU1pd2dKMlp2YnlkZExDQmJNek1zSUNkaVlYSW5YVjBLQ1dKNWRHVmpJREFnTHk4Z0lHbHVhWFJwWVd3Z2FHVmhaQW9KWW5sMFpXTWdNQ0F2THlBZ2FXNXBkR2xoYkNCMFlXbHNDZ2x3ZFhOb1lubDBaWE1nTUhnd01EQTJJQzh2SUdsdWFYUnBZV3dnYUdWaFpDQnZabVp6WlhRS0NYQjFjMmhpZVhSbGN5QXdlREF3TUdJS0NXTmhiR3h6ZFdJZ0tuQnliMk5sYzNOZmMzUmhkR2xqWDNSMWNHeGxYMlZzWlcxbGJuUUtDV0o1ZEdWaklEQWdMeThnSUdsdWFYUnBZV3dnYUdWaFpBb0pZbmwwWldNZ01DQXZMeUFnYVc1cGRHbGhiQ0IwWVdsc0NnbHdkWE5vWW5sMFpYTWdNSGd3TURBeklDOHZJR2x1YVhScFlXd2dhR1ZoWkNCdlptWnpaWFFLQ1hCMWMyaGllWFJsY3lBd2VERTJDZ2xqWVd4c2MzVmlJQ3B3Y205alpYTnpYM04wWVhScFkxOTBkWEJzWlY5bGJHVnRaVzUwQ2dsd2RYTm9ZbmwwWlhNZ01IZ3dNREF6TmpZMlpqWm1DZ2xqWVd4c2MzVmlJQ3B3Y205alpYTnpYMlI1Ym1GdGFXTmZkSFZ3YkdWZlpXeGxiV1Z1ZEFvSmNHOXdJQzh2SUhCdmNDQm9aV0ZrSUc5bVpuTmxkQW9KWTI5dVkyRjBJQzh2SUdOdmJtTmhkQ0JvWldGa0lHRnVaQ0IwWVdsc0NnbGpZV3hzYzNWaUlDcHdjbTlqWlhOelgyUjVibUZ0YVdOZmRIVndiR1ZmWld4bGJXVnVkQW9KWW5sMFpXTWdNQ0F2THlBZ2FXNXBkR2xoYkNCb1pXRmtDZ2xpZVhSbFl5QXdJQzh2SUNCcGJtbDBhV0ZzSUhSaGFXd0tDWEIxYzJoaWVYUmxjeUF3ZURBd01EUWdMeThnYVc1cGRHbGhiQ0JvWldGa0lHOW1abk5sZEFvSmNIVnphR0o1ZEdWeklEQjRNREF5TVFvSlkyRnNiSE4xWWlBcWNISnZZMlZ6YzE5emRHRjBhV05mZEhWd2JHVmZaV3hsYldWdWRBb0pjSFZ6YUdKNWRHVnpJREI0TURBd016WXlOakUzTWdvSlkyRnNiSE4xWWlBcWNISnZZMlZ6YzE5a2VXNWhiV2xqWDNSMWNHeGxYMlZzWlcxbGJuUUtDWEJ2Y0NBdkx5QndiM0FnYUdWaFpDQnZabVp6WlhRS0NXTnZibU5oZENBdkx5QmpiMjVqWVhRZ2FHVmhaQ0JoYm1RZ2RHRnBiQW9KWTJGc2JITjFZaUFxY0hKdlkyVnpjMTlrZVc1aGJXbGpYM1IxY0d4bFgyVnNaVzFsYm5RS0NYQnZjQ0F2THlCd2IzQWdhR1ZoWkNCdlptWnpaWFFLQ1dOdmJtTmhkQ0F2THlCamIyNWpZWFFnYUdWaFpDQmhibVFnZEdGcGJBb0pabkpoYldWZlluVnllU0F3SUM4dklHRTZJRnQxYVc1ME1UWXNJRnQxYVc1MFBEZytMQ0J6ZEhKcGJtZGRMQ0JiZFdsdWRERTJMQ0J6ZEhKcGJtZGRYUW9LQ1M4dklIUmxjM1J6TDJOdmJuUnlZV04wY3k5aFlta3VZV3huYnk1MGN6bzJPVFFLQ1M4dklISmxkSFZ5YmlCaE93b0pabkpoYldWZlpHbG5JREFnTHk4Z1lUb2dXM1ZwYm5ReE5pd2dXM1ZwYm5ROE9ENHNJSE4wY21sdVoxMHNJRnQxYVc1ME1UWXNJSE4wY21sdVoxMWRDZ29KTHk4Z2MyVjBJSFJvWlNCemRXSnliM1YwYVc1bElISmxkSFZ5YmlCMllXeDFaUW9KWm5KaGJXVmZZblZ5ZVNBd0NnbHlaWFJ6ZFdJS0NpcGhZbWxmY205MWRHVmZZM0psWVhSbFFYQndiR2xqWVhScGIyNDZDZ2xwYm5SaklEQWdMeThnTVFvSmNtVjBkWEp1Q2dvcVkzSmxZWFJsWDA1dlQzQTZDZ2x3ZFhOb1lubDBaWE1nTUhoaU9EUTBOMkl6TmlBdkx5QnRaWFJvYjJRZ0ltTnlaV0YwWlVGd2NHeHBZMkYwYVc5dUtDbDJiMmxrSWdvSmRIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9KYldGMFkyZ2dLbUZpYVY5eWIzVjBaVjlqY21WaGRHVkJjSEJzYVdOaGRHbHZiZ29LQ1M4dklIUm9hWE1nWTI5dWRISmhZM1FnWkc5bGN5QnViM1FnYVcxd2JHVnRaVzUwSUhSb1pTQm5hWFpsYmlCQlFra2diV1YwYUc5a0lHWnZjaUJqY21WaGRHVWdUbTlQY0FvSlpYSnlDZ29xWTJGc2JGOU9iMDl3T2dvSmNIVnphR0o1ZEdWeklEQjRORGxpWWpjd01Ua2dMeThnYldWMGFHOWtJQ0p1WlhOMFpXUlVkWEJzWlNncEtIVnBiblF4Tml3b2RXbHVkRGdzYzNSeWFXNW5LU3dvZFdsdWRERTJMSE4wY21sdVp5a3BJZ29KZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb0piV0YwWTJnZ0ttRmlhVjl5YjNWMFpWOXVaWE4wWldSVWRYQnNaUW9LQ1M4dklIUm9hWE1nWTI5dWRISmhZM1FnWkc5bGN5QnViM1FnYVcxd2JHVnRaVzUwSUhSb1pTQm5hWFpsYmlCQlFra2diV1YwYUc5a0lHWnZjaUJqWVd4c0lFNXZUM0FLQ1dWeWNnb0tLbkJ5YjJObGMzTmZjM1JoZEdsalgzUjFjR3hsWDJWc1pXMWxiblE2Q2dsd2NtOTBieUEwSURNS0NXWnlZVzFsWDJScFp5QXROQ0F2THlCMGRYQnNaU0JvWldGa0NnbG1jbUZ0WlY5a2FXY2dMVEVnTHk4Z1pXeGxiV1Z1ZEFvSlkyOXVZMkYwQ2dsbWNtRnRaVjlrYVdjZ0xUTWdMeThnZEhWd2JHVWdkR0ZwYkFvSlpuSmhiV1ZmWkdsbklDMHlJQzh2SUdobFlXUWdiMlptYzJWMENnbHlaWFJ6ZFdJS0NpcHdjbTlqWlhOelgyUjVibUZ0YVdOZmRIVndiR1ZmWld4bGJXVnVkRG9LQ1hCeWIzUnZJRFFnTXdvSlpuSmhiV1ZmWkdsbklDMDBJQzh2SUhSMWNHeGxJR2hsWVdRS0NXWnlZVzFsWDJScFp5QXRNaUF2THlCb1pXRmtJRzltWm5ObGRBb0pZMjl1WTJGMENnbG1jbUZ0WlY5aWRYSjVJQzAwSUM4dklIUjFjR3hsSUdobFlXUUtDV1p5WVcxbFgyUnBaeUF0TVNBdkx5QmxiR1Z0Wlc1MENnbGtkWEFLQ1d4bGJnb0pabkpoYldWZlpHbG5JQzB5SUM4dklHaGxZV1FnYjJabWMyVjBDZ2xpZEc5cENna3JDZ2xwZEc5aUNnbGxlSFJ5WVdOMElEWWdNZ29KWm5KaGJXVmZZblZ5ZVNBdE1pQXZMeUJvWldGa0lHOW1abk5sZEFvSlpuSmhiV1ZmWkdsbklDMHpJQzh2SUhSMWNHeGxJSFJoYVd3S0NYTjNZWEFLQ1dOdmJtTmhkQW9KWm5KaGJXVmZZblZ5ZVNBdE15QXZMeUIwZFhCc1pTQjBZV2xzQ2dsbWNtRnRaVjlrYVdjZ0xUUWdMeThnZEhWd2JHVWdhR1ZoWkFvSlpuSmhiV1ZmWkdsbklDMHpJQzh2SUhSMWNHeGxJSFJoYVd3S0NXWnlZVzFsWDJScFp5QXRNaUF2THlCb1pXRmtJRzltWm5ObGRBb0pjbVYwYzNWaSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQkFTWUJBREVZRklFR0N6RVpDSTBNQUc4QUFBQUFBQUFBQUFBQUFHRUFBQUFBQUFBQUFBQUFBSUFFRlI5OGRZZ0FCRkN3SWtPS0FBRW9LQ2lBQWdBR2dBSUFDNGdBWGlnb2dBSUFBNEFCRm9nQVVvQUZBQU5tYjIrSUFGVklVSWdBVUNnb2dBSUFCSUFDQUNHSUFEYUFCUUFEWW1GeWlBQTVTRkNJQURSSVVJd0Fpd0NNQUlraVE0QUV1RVI3TmpZYUFJNEIvL0VBZ0FSSnUzQVpOaG9BamdIL2hRQ0tCQU9ML0l2L1VJdjlpLzZKaWdRRGkveUwvbENNL0l2L1NSV0wvaGNJRmxjR0FveitpLzFNVUl6OWkveUwvWXYraVE9PSIsImNsZWFyIjoiQ2c9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJhbGdvZCIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjQsInBhdGNoIjoxLCJjb21taXRIYXNoIjoiN2I2MDdjZTQifX0sImV2ZW50cyI6bnVsbCwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
