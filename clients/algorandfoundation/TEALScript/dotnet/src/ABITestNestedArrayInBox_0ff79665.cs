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

namespace Arc56.Generated.algorandfoundation.TEALScript.ABITestNestedArrayInBox_0ff79665
{


    public class ABITestNestedArrayInBoxProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ABITestNestedArrayInBoxProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class T10 : AVMObjectType
            {
                public byte[][] Bytes4Array { get; set; }

                public ulong U64A { get; set; }

                public ulong U64B { get; set; }

                public ulong U64C { get; set; }

                public bool BoolValue { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBytes4Array = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[4][]");
                    vBytes4Array.From(Bytes4Array);
                    ret.AddRange(vBytes4Array.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vU64A = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vU64A.From(U64A);
                    ret.AddRange(vU64A.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vU64B = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vU64B.From(U64B);
                    ret.AddRange(vU64B.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vU64C = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vU64C.From(U64C);
                    ret.AddRange(vU64C.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBoolValue = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vBoolValue.From(BoolValue);
                    ret.AddRange(vBoolValue.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static T10 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new T10();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBytes4Array = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[4][]");
                    count = vBytes4Array.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBytes4Array = vBytes4Array.ToValue();
                    if (valueBytes4Array is byte[][] vBytes4ArrayValue) { ret.Bytes4Array = vBytes4ArrayValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vU64A = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vU64A.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueU64A = vU64A.ToValue();
                    if (valueU64A is ulong vU64AValue) { ret.U64A = vU64AValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vU64B = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vU64B.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueU64B = vU64B.ToValue();
                    if (valueU64B is ulong vU64BValue) { ret.U64B = vU64BValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vU64C = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vU64C.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueU64C = vU64C.ToValue();
                    if (valueU64C is ulong vU64CValue) { ret.U64C = vU64CValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBoolValue = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vBoolValue.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBoolValue = vBoolValue.ToValue();
                    if (valueBoolValue is bool vBoolValueValue) { ret.BoolValue = vBoolValueValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as T10);
                }
                public bool Equals(T10? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(T10 left, T10 right)
                {
                    return EqualityComparer<T10>.Default.Equals(left, right);
                }
                public static bool operator !=(T10 left, T10 right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.T10> NestedArrayInBox(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 124, 160, 200 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.T10.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> NestedArrayInBox_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 124, 160, 200 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJBQklUZXN0TmVzdGVkQXJyYXlJbkJveCIsImRlc2MiOiIiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiVDEwIjpbeyJuYW1lIjoiYnl0ZXM0QXJyYXkiLCJ0eXBlIjoiYnl0ZVs0XVtdIn0seyJuYW1lIjoidTY0YSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ1NjRiIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InU2NGMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYm9vbFZhbHVlIiwidHlwZSI6ImJvb2wifV19LCJNZXRob2RzIjpbeyJuYW1lIjoibmVzdGVkQXJyYXlJbkJveCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIoYnl0ZVs0XVtdLHVpbnQ2NCx1aW50NjQsdWludDY0LGJvb2wpIiwic3RydWN0IjoiVDEwIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImNyZWF0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjM3In0seyJwYyI6WzEsMiwzLDRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjM3In0seyJwYyI6WzUsNiw3LDgsOSwxMCwxMSwxMl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2MzcifSx7InBjIjpbMTMsMTRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYzNyJ9LHsicGMiOlsxNV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjM3In0seyJwYyI6WzE2LDE3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2MzcifSx7InBjIjpbMThdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYzNyJ9LHsicGMiOlsxOSwyMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjM3In0seyJwYyI6WzIxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyMCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2MzcifSx7InBjIjpbMjIsMjMsMjQsMjUsMjYsMjcsMjgsMjksMzAsMzEsMzIsMzMsMzQsMzUsMzYsMzcsMzgsMzksNDAsNDEsNDIsNDMsNDQsNDUsNDYsNDddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYzNyJ9LHsicGMiOls0OF0sImVycm9yTWVzc2FnZSI6IlRoZSByZXF1ZXN0ZWQgYWN0aW9uIGlzIG5vdCBpbXBsZW1lbnRlZCBpbiB0aGlzIGNvbnRyYWN0LiBBcmUgeW91IHVzaW5nIHRoZSBjb3JyZWN0IE9uQ29tcGxldGU/IERpZCB5b3Ugc2V0IHlvdXIgYXBwIElEPyIsInRlYWwiOjI1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYzNyJ9LHsicGMiOls0OSw1MCw1MSw1Miw1Myw1NF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjQwIn0seyJwYyI6WzU1LDU2LDU3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NDAifSx7InBjIjpbNThdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY0MCJ9LHsicGMiOls1OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjQwIn0seyJwYyI6WzYwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NDAifSx7InBjIjpbNjFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY0MCJ9LHsicGMiOls2Miw2Myw2NF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjQwIn0seyJwYyI6WzY1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NDEifSx7InBjIjpbNjZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjUyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY0MSJ9LHsicGMiOls2N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjQxIn0seyJwYyI6WzY4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NDEifSx7InBjIjpbNjldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY0MSJ9LHsicGMiOls3MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjQxIn0seyJwYyI6WzcxLDcyLDczLDc0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1Nywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NDEifSx7InBjIjpbNzUsNzYsNzcsNzgsNzksODAsODEsODIsODMsODQsODUsODZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY0MiJ9LHsicGMiOls4Nyw4OCw4OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjQyIn0seyJwYyI6WzkwLDkxLDkyLDkzLDk0LDk1LDk2LDk3LDk4LDk5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2MCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NDMifSx7InBjIjpbMTAwLDEwMSwxMDJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjYxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY0MyJ9LHsicGMiOlsxMDMsMTA0LDEwNSwxMDYsMTA3LDEwOCwxMDksMTEwLDExMSwxMTJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjYyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY0NCJ9LHsicGMiOlsxMTMsMTE0LDExNV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjQ0In0seyJwYyI6WzExNiwxMTcsMTE4LDExOSwxMjAsMTIxLDEyMiwxMjMsMTI0LDEyNV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjQ1In0seyJwYyI6WzEyNiwxMjcsMTI4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2NSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NDUifSx7InBjIjpbMTI5LDEzMCwxMzFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY0NiJ9LHsicGMiOlsxMzJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY0NiJ9LHsicGMiOlsxMzNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY0NiJ9LHsicGMiOlsxMzRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY0NiJ9LHsicGMiOlsxMzUsMTM2LDEzN10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjQxIn0seyJwYyI6WzEzOF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjQxIn0seyJwYyI6WzEzOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjQxIn0seyJwYyI6WzE0MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjQxIn0seyJwYyI6WzE0MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjQ5In0seyJwYyI6WzE0Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjQ5In0seyJwYyI6WzE0M10sImVycm9yTWVzc2FnZSI6ImJveCB2YWx1ZSBkb2VzIG5vdCBleGlzdDogdGhpcy5iTWFwKCdiTWFwJykudmFsdWUiLCJ0ZWFsIjo4MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NDkifSx7InBjIjpbMTQ0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NDAifSx7InBjIjpbMTQ1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4NSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2MzcifSx7InBjIjpbMTQ2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2MzcifSx7InBjIjpbMTQ3LDE0OCwxNDksMTUwLDE1MSwxNTJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjg5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYzNyJ9LHsicGMiOlsxNTMsMTU0LDE1NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjM3In0seyJwYyI6WzE1NiwxNTcsMTU4LDE1OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjM3In0seyJwYyI6WzE2MF0sImVycm9yTWVzc2FnZSI6InRoaXMgY29udHJhY3QgZG9lcyBub3QgaW1wbGVtZW50IHRoZSBnaXZlbiBBQkkgbWV0aG9kIGZvciBjcmVhdGUgTm9PcCIsInRlYWwiOjk0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYzNyJ9LHsicGMiOlsxNjEsMTYyLDE2MywxNjQsMTY1LDE2Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjM3In0seyJwYyI6WzE2NywxNjgsMTY5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo5OCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2MzcifSx7InBjIjpbMTcwLDE3MSwxNzIsMTczXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo5OSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2MzcifSx7InBjIjpbMTc0XSwiZXJyb3JNZXNzYWdlIjoidGhpcyBjb250cmFjdCBkb2VzIG5vdCBpbXBsZW1lbnQgdGhlIGdpdmVuIEFCSSBtZXRob2QgZm9yIGNhbGwgTm9PcCIsInRlYWwiOjEwMiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2MzcifSx7InBjIjpbMTc1LDE3NiwxNzddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwNSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2MzcifSx7InBjIjpbMTc4LDE3OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTA2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYzNyJ9LHsicGMiOlsxODAsMTgxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjM3In0seyJwYyI6WzE4Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTA4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYzNyJ9LHsicGMiOlsxODMsMTg0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjM3In0seyJwYyI6WzE4NSwxODZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjExMCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2MzcifSx7InBjIjpbMTg3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMTEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjM3In0seyJwYyI6WzE4OCwxODksMTkwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMTQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjM3In0seyJwYyI6WzE5MSwxOTJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjExNSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2MzcifSx7InBjIjpbMTkzLDE5NF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTE2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYzNyJ9LHsicGMiOlsxOTVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjExNywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2MzcifSx7InBjIjpbMTk2LDE5N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTE4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYzNyJ9LHsicGMiOlsxOTgsMTk5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMTksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjM3In0seyJwYyI6WzIwMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTIwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYzNyJ9LHsicGMiOlsyMDFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyMSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2MzcifSx7InBjIjpbMjAyLDIwM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTIyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYzNyJ9LHsicGMiOlsyMDRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyMywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2MzcifSx7InBjIjpbMjA1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMjQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjM3In0seyJwYyI6WzIwNl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTI1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYzNyJ9LHsicGMiOlsyMDcsMjA4LDIwOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTI2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYzNyJ9LHsicGMiOlsyMTAsMjExXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMjcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjM3In0seyJwYyI6WzIxMiwyMTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyOCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2MzcifSx7InBjIjpbMjE0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMjksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjM3In0seyJwYyI6WzIxNV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTMwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYzNyJ9LHsicGMiOlsyMTYsMjE3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMzEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjM3In0seyJwYyI6WzIxOCwyMTldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEzMiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2MzcifSx7InBjIjpbMjIwLDIyMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTMzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYzNyJ9LHsicGMiOlsyMjIsMjIzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMzQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjM3In0seyJwYyI6WzIyNF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTM1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYzNyJ9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NtbHVkR05pYkc5amF5QXdJREVLWW5sMFpXTmliRzlqYXlBd2VEWXlOR1EyTVRjd0lEQjRDZ292THlCVWFHbHpJRlJGUVV3Z2QyRnpJR2RsYm1WeVlYUmxaQ0JpZVNCVVJVRk1VMk55YVhCMElIWXdMakV3Tnk0eUNpOHZJR2gwZEhCek9pOHZaMmwwYUhWaUxtTnZiUzloYkdkdmNtRnVaR1p2ZFc1a1lYUnBiMjR2VkVWQlRGTmpjbWx3ZEFvS0x5OGdWR2hwY3lCamIyNTBjbUZqZENCcGN5QmpiMjF3YkdsaGJuUWdkMmwwYUNCaGJtUXZiM0lnYVcxd2JHVnRaVzUwY3lCMGFHVWdabTlzYkc5M2FXNW5JRUZTUTNNNklGc2dRVkpETkNCZENnb3ZMeUJVYUdVZ1ptOXNiRzkzYVc1bklIUmxiaUJzYVc1bGN5QnZaaUJVUlVGTUlHaGhibVJzWlNCcGJtbDBhV0ZzSUhCeWIyZHlZVzBnWm14dmR3b3ZMeUJVYUdseklIQmhkSFJsY200Z2FYTWdkWE5sWkNCMGJ5QnRZV3RsSUdsMElHVmhjM2tnWm05eUlHRnVlVzl1WlNCMGJ5QndZWEp6WlNCMGFHVWdjM1JoY25RZ2IyWWdkR2hsSUhCeWIyZHlZVzBnWVc1a0lHUmxkR1Z5YldsdVpTQnBaaUJoSUhOd1pXTnBabWxqSUdGamRHbHZiaUJwY3lCaGJHeHZkMlZrQ2k4dklFaGxjbVVzSUdGamRHbHZiaUJ5WldabGNuTWdkRzhnZEdobElFOXVRMjl0Y0d4bGRHVWdhVzRnWTI5dFltbHVZWFJwYjI0Z2QybDBhQ0IzYUdWMGFHVnlJSFJvWlNCaGNIQWdhWE1nWW1WcGJtY2dZM0psWVhSbFpDQnZjaUJqWVd4c1pXUUtMeThnUlhabGNua2djRzl6YzJsaWJHVWdZV04wYVc5dUlHWnZjaUIwYUdseklHTnZiblJ5WVdOMElHbHpJSEpsY0hKbGMyVnVkR1ZrSUdsdUlIUm9aU0J6ZDJsMFkyZ2djM1JoZEdWdFpXNTBDaTh2SUVsbUlIUm9aU0JoWTNScGIyNGdhWE1nYm05MElHbHRjR3hsYldWdWRHVmtJR2x1SUhSb1pTQmpiMjUwY21GamRDd2dhWFJ6SUhKbGMzQmxZM1JwZG1VZ1luSmhibU5vSUhkcGJHd2dZbVVnSWlwT1QxUmZTVTFRVEVWTlJVNVVSVVFpSUhkb2FXTm9JR3AxYzNRZ1kyOXVkR0ZwYm5NZ0ltVnljaUlLZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSVFwd2RYTm9hVzUwSURZS0tncDBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpc0tjM2RwZEdOb0lDcGpZV3hzWDA1dlQzQWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwamNtVmhkR1ZmVG05UGNDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFLQ2lwT1QxUmZTVTFRVEVWTlJVNVVSVVE2Q2drdkx5QlVhR1VnY21WeGRXVnpkR1ZrSUdGamRHbHZiaUJwY3lCdWIzUWdhVzF3YkdWdFpXNTBaV1FnYVc0Z2RHaHBjeUJqYjI1MGNtRmpkQzRnUVhKbElIbHZkU0IxYzJsdVp5QjBhR1VnWTI5eWNtVmpkQ0JQYmtOdmJYQnNaWFJsUHlCRWFXUWdlVzkxSUhObGRDQjViM1Z5SUdGd2NDQkpSRDhLQ1dWeWNnb0tMeThnYm1WemRHVmtRWEp5WVhsSmJrSnZlQ2dwS0dKNWRHVmJORjFiWFN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeGliMjlzS1FvcVlXSnBYM0p2ZFhSbFgyNWxjM1JsWkVGeWNtRjVTVzVDYjNnNkNna3ZMeUJVYUdVZ1FVSkpJSEpsZEhWeWJpQndjbVZtYVhnS0NYQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFDZ29KTHk4Z1pYaGxZM1YwWlNCdVpYTjBaV1JCY25KaGVVbHVRbTk0S0Nrb1lubDBaVnMwWFZ0ZExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMR0p2YjJ3cENnbGpZV3hzYzNWaUlHNWxjM1JsWkVGeWNtRjVTVzVDYjNnS0NXTnZibU5oZEFvSmJHOW5DZ2xwYm5SaklERWdMeThnTVFvSmNtVjBkWEp1Q2dvdkx5QnVaWE4wWldSQmNuSmhlVWx1UW05NEtDazZJRlF4TUFwdVpYTjBaV1JCY25KaGVVbHVRbTk0T2dvSmNISnZkRzhnTUNBeENnb0pMeThnZEdWemRITXZZMjl1ZEhKaFkzUnpMMkZpYVM1aGJHZHZMblJ6T2pFMk5ERUtDUzh2SUhSb2FYTXVZazFoY0NnbllrMWhjQ2NwTG5aaGJIVmxJRDBnZXdvSkx5OGdJQ0FnSUNBZ1lubDBaWE0wUVhKeVlYazZJRnNuWVdKalpDY2dZWE1nWW5sMFpYTThORDRzSUNkbFptZG9KeUJoY3lCaWVYUmxjencwUGwwc0Nna3ZMeUFnSUNBZ0lDQjFOalJoT2lBeExBb0pMeThnSUNBZ0lDQWdkVFkwWWpvZ01pd0tDUzh2SUNBZ0lDQWdJSFUyTkdNNklETXNDZ2t2THlBZ0lDQWdJQ0JpYjI5c1ZtRnNkV1U2SUdaaGJITmxMQW9KTHk4Z0lDQWdJSDBLQ1dKNWRHVmpJREFnTHk4Z0lDSmlUV0Z3SWdvSlpIVndDZ2xpYjNoZlpHVnNDZ2x3YjNBS0NXSjVkR1ZqSURFZ0x5OGdJR2x1YVhScFlXd2dhR1ZoWkFvSllubDBaV01nTVNBdkx5QWdhVzVwZEdsaGJDQjBZV2xzQ2dsd2RYTm9ZbmwwWlhNZ01IZ3dNREZpSUM4dklHbHVhWFJwWVd3Z2FHVmhaQ0J2Wm1aelpYUUtDWEIxYzJoaWVYUmxjeUF3ZURBd01ESTJNVFl5TmpNMk5EWTFOalkyTnpZNENnbGpZV3hzYzNWaUlDcHdjbTlqWlhOelgyUjVibUZ0YVdOZmRIVndiR1ZmWld4bGJXVnVkQW9KY0hWemFHSjVkR1Z6SURCNE1EQXdNREF3TURBd01EQXdNREF3TVFvSlkyRnNiSE4xWWlBcWNISnZZMlZ6YzE5emRHRjBhV05mZEhWd2JHVmZaV3hsYldWdWRBb0pjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd01EQXdNZ29KWTJGc2JITjFZaUFxY0hKdlkyVnpjMTl6ZEdGMGFXTmZkSFZ3YkdWZlpXeGxiV1Z1ZEFvSmNIVnphR0o1ZEdWeklEQjRNREF3TURBd01EQXdNREF3TURBd013b0pZMkZzYkhOMVlpQXFjSEp2WTJWemMxOXpkR0YwYVdOZmRIVndiR1ZmWld4bGJXVnVkQW9KY0hWemFHSjVkR1Z6SURCNE1EQUtDV2x1ZEdNZ01DQXZMeUF3Q2dsa2RYQUtDWE5sZEdKcGRBb0pZMkZzYkhOMVlpQXFjSEp2WTJWemMxOXpkR0YwYVdOZmRIVndiR1ZmWld4bGJXVnVkQW9KY0c5d0lDOHZJSEJ2Y0NCb1pXRmtJRzltWm5ObGRBb0pZMjl1WTJGMElDOHZJR052Ym1OaGRDQm9aV0ZrSUdGdVpDQjBZV2xzQ2dsaWIzaGZjSFYwQ2dvSkx5OGdkR1Z6ZEhNdlkyOXVkSEpoWTNSekwyRmlhUzVoYkdkdkxuUnpPakUyTkRrS0NTOHZJSEpsZEhWeWJpQjBhR2x6TG1KTllYQW9KMkpOWVhBbktTNTJZV3gxWlRzS0NXSjVkR1ZqSURBZ0x5OGdJQ0ppVFdGd0lnb0pZbTk0WDJkbGRBb0tDUzh2SUdKdmVDQjJZV3gxWlNCa2IyVnpJRzV2ZENCbGVHbHpkRG9nZEdocGN5NWlUV0Z3S0NkaVRXRndKeWt1ZG1Gc2RXVUtDV0Z6YzJWeWRBb0pjbVYwYzNWaUNnb3FZV0pwWDNKdmRYUmxYMk55WldGMFpVRndjR3hwWTJGMGFXOXVPZ29KYVc1MFl5QXhJQzh2SURFS0NYSmxkSFZ5YmdvS0ttTnlaV0YwWlY5T2IwOXdPZ29KY0hWemFHSjVkR1Z6SURCNFlqZzBORGRpTXpZZ0x5OGdiV1YwYUc5a0lDSmpjbVZoZEdWQmNIQnNhV05oZEdsdmJpZ3BkbTlwWkNJS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLQ1cxaGRHTm9JQ3BoWW1sZmNtOTFkR1ZmWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRLQ2drdkx5QjBhR2x6SUdOdmJuUnlZV04wSUdSdlpYTWdibTkwSUdsdGNHeGxiV1Z1ZENCMGFHVWdaMmwyWlc0Z1FVSkpJRzFsZEdodlpDQm1iM0lnWTNKbFlYUmxJRTV2VDNBS0NXVnljZ29LS21OaGJHeGZUbTlQY0RvS0NYQjFjMmhpZVhSbGN5QXdlR0V3TjJOaE1HTTRJQzh2SUcxbGRHaHZaQ0FpYm1WemRHVmtRWEp5WVhsSmJrSnZlQ2dwS0dKNWRHVmJORjFiWFN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeGliMjlzS1NJS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLQ1cxaGRHTm9JQ3BoWW1sZmNtOTFkR1ZmYm1WemRHVmtRWEp5WVhsSmJrSnZlQW9LQ1M4dklIUm9hWE1nWTI5dWRISmhZM1FnWkc5bGN5QnViM1FnYVcxd2JHVnRaVzUwSUhSb1pTQm5hWFpsYmlCQlFra2diV1YwYUc5a0lHWnZjaUJqWVd4c0lFNXZUM0FLQ1dWeWNnb0tLbkJ5YjJObGMzTmZjM1JoZEdsalgzUjFjR3hsWDJWc1pXMWxiblE2Q2dsd2NtOTBieUEwSURNS0NXWnlZVzFsWDJScFp5QXROQ0F2THlCMGRYQnNaU0JvWldGa0NnbG1jbUZ0WlY5a2FXY2dMVEVnTHk4Z1pXeGxiV1Z1ZEFvSlkyOXVZMkYwQ2dsbWNtRnRaVjlrYVdjZ0xUTWdMeThnZEhWd2JHVWdkR0ZwYkFvSlpuSmhiV1ZmWkdsbklDMHlJQzh2SUdobFlXUWdiMlptYzJWMENnbHlaWFJ6ZFdJS0NpcHdjbTlqWlhOelgyUjVibUZ0YVdOZmRIVndiR1ZmWld4bGJXVnVkRG9LQ1hCeWIzUnZJRFFnTXdvSlpuSmhiV1ZmWkdsbklDMDBJQzh2SUhSMWNHeGxJR2hsWVdRS0NXWnlZVzFsWDJScFp5QXRNaUF2THlCb1pXRmtJRzltWm5ObGRBb0pZMjl1WTJGMENnbG1jbUZ0WlY5aWRYSjVJQzAwSUM4dklIUjFjR3hsSUdobFlXUUtDV1p5WVcxbFgyUnBaeUF0TVNBdkx5QmxiR1Z0Wlc1MENnbGtkWEFLQ1d4bGJnb0pabkpoYldWZlpHbG5JQzB5SUM4dklHaGxZV1FnYjJabWMyVjBDZ2xpZEc5cENna3JDZ2xwZEc5aUNnbGxlSFJ5WVdOMElEWWdNZ29KWm5KaGJXVmZZblZ5ZVNBdE1pQXZMeUJvWldGa0lHOW1abk5sZEFvSlpuSmhiV1ZmWkdsbklDMHpJQzh2SUhSMWNHeGxJSFJoYVd3S0NYTjNZWEFLQ1dOdmJtTmhkQW9KWm5KaGJXVmZZblZ5ZVNBdE15QXZMeUIwZFhCc1pTQjBZV2xzQ2dsbWNtRnRaVjlrYVdjZ0xUUWdMeThnZEhWd2JHVWdhR1ZoWkFvSlpuSmhiV1ZmWkdsbklDMHpJQzh2SUhSMWNHeGxJSFJoYVd3S0NXWnlZVzFsWDJScFp5QXRNaUF2THlCb1pXRmtJRzltWm5ObGRBb0pjbVYwYzNWaSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQ0FBRW1BZ1JpVFdGd0FERVlGSUVHQ3pFWkNJME1BSEVBQUFBQUFBQUFBQUFBQUdNQUFBQUFBQUFBQUFBQUFJQUVGUjk4ZFlnQUJGQ3dJME9LQUFFb1NieElLU21BQWdBYmdBb0FBbUZpWTJSbFptZG9pQUJpZ0FnQUFBQUFBQUFBQVlnQVNJQUlBQUFBQUFBQUFBS0lBRHVBQ0FBQUFBQUFBQUFEaUFBdWdBRUFJa2xVaUFBbFNGQy9LTDVFaVNORGdBUzRSSHMyTmhvQWpnSC84UUNBQktCOG9NZzJHZ0NPQWYrREFJb0VBNHY4aS85UWkvMkwvb21LQkFPTC9JditVSXo4aS85SkZZditGd2dXVndZQ2pQNkwvVXhRalAyTC9JdjlpLzZKIiwiY2xlYXIiOiJDZz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6ImFsZ29kIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6NCwicGF0Y2giOjEsImNvbW1pdEhhc2giOiI3YjYwN2NlNCJ9fSwiZXZlbnRzIjpudWxsLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
