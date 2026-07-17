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

namespace Arc56.Generated.algorandfoundation.TEALScript.ABITestNestedArrayInBoxWithoutBool_527bd9b2
{


    public class ABITestNestedArrayInBoxWithoutBoolProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ABITestNestedArrayInBoxWithoutBoolProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class T12 : AVMObjectType
            {
                public byte[][] Bytes4Array { get; set; }

                public ulong U64A { get; set; }

                public ulong U64B { get; set; }

                public ulong U64C { get; set; }

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
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static T12 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new T12();
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
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as T12);
                }
                public bool Equals(T12? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(T12 left, T12 right)
                {
                    return EqualityComparer<T12>.Default.Equals(left, right);
                }
                public static bool operator !=(T12 left, T12 right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.T12> NestedArrayInBoxWithoutBool(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 255, 94, 252, 2 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.T12.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> NestedArrayInBoxWithoutBool_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 255, 94, 252, 2 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJBQklUZXN0TmVzdGVkQXJyYXlJbkJveFdpdGhvdXRCb29sIiwiZGVzYyI6IiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJUMTIiOlt7Im5hbWUiOiJieXRlczRBcnJheSIsInR5cGUiOiJieXRlWzRdW10ifSx7Im5hbWUiOiJ1NjRhIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InU2NGIiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidTY0YyIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoibmVzdGVkQXJyYXlJbkJveFdpdGhvdXRCb29sIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6IihieXRlWzRdW10sdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiVDEyIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImNyZWF0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjg0In0seyJwYyI6WzEsMiwzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY4NCJ9LHsicGMiOls0LDUsNiw3LDgsOSwxMCwxMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2ODQifSx7InBjIjpbMTIsMTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY4NCJ9LHsicGMiOlsxNF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjg0In0seyJwYyI6WzE1LDE2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2ODQifSx7InBjIjpbMTddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY4NCJ9LHsicGMiOlsxOCwxOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjg0In0seyJwYyI6WzIwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyMCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2ODQifSx7InBjIjpbMjEsMjIsMjMsMjQsMjUsMjYsMjcsMjgsMjksMzAsMzEsMzIsMzMsMzQsMzUsMzYsMzcsMzgsMzksNDAsNDEsNDIsNDMsNDQsNDUsNDZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY4NCJ9LHsicGMiOls0N10sImVycm9yTWVzc2FnZSI6IlRoZSByZXF1ZXN0ZWQgYWN0aW9uIGlzIG5vdCBpbXBsZW1lbnRlZCBpbiB0aGlzIGNvbnRyYWN0LiBBcmUgeW91IHVzaW5nIHRoZSBjb3JyZWN0IE9uQ29tcGxldGU/IERpZCB5b3Ugc2V0IHlvdXIgYXBwIElEPyIsInRlYWwiOjI1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY4NCJ9LHsicGMiOls0OCw0OSw1MCw1MSw1Miw1M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjg3In0seyJwYyI6WzU0LDU1LDU2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2ODcifSx7InBjIjpbNTddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY4NyJ9LHsicGMiOls1OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjg3In0seyJwYyI6WzU5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2ODcifSx7InBjIjpbNjBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY4NyJ9LHsicGMiOls2MSw2Miw2M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjg3In0seyJwYyI6WzY0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1MCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2ODgifSx7InBjIjpbNjVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjUxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY4OCJ9LHsicGMiOls2Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjg4In0seyJwYyI6WzY3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2ODgifSx7InBjIjpbNjhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY4OCJ9LHsicGMiOls2OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjg4In0seyJwYyI6WzcwLDcxLDcyLDczXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2ODgifSx7InBjIjpbNzQsNzUsNzYsNzcsNzgsNzksODAsODEsODIsODMsODQsODVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY4OSJ9LHsicGMiOls4Niw4Nyw4OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjg5In0seyJwYyI6Wzg5LDkwLDkxLDkyLDkzLDk0LDk1LDk2LDk3LDk4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1OSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2OTAifSx7InBjIjpbOTksMTAwLDEwMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjkwIn0seyJwYyI6WzEwMiwxMDMsMTA0LDEwNSwxMDYsMTA3LDEwOCwxMDksMTEwLDExMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjkxIn0seyJwYyI6WzExMiwxMTMsMTE0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2OTEifSx7InBjIjpbMTE1LDExNiwxMTcsMTE4LDExOSwxMjAsMTIxLDEyMiwxMjMsMTI0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2OTIifSx7InBjIjpbMTI1LDEyNiwxMjddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY5MiJ9LHsicGMiOlsxMjhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY4OCJ9LHsicGMiOlsxMjldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY4OCJ9LHsicGMiOlsxMzBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY4OCJ9LHsicGMiOlsxMzFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjcxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY5NSJ9LHsicGMiOlsxMzJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjcyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY5NSJ9LHsicGMiOlsxMzNdLCJlcnJvck1lc3NhZ2UiOiJib3ggdmFsdWUgZG9lcyBub3QgZXhpc3Q6IHRoaXMuYk1hcCgnYk1hcCcpLnZhbHVlIiwidGVhbCI6NzUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjk1In0seyJwYyI6WzEzNF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjg3In0seyJwYyI6WzEzNV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjg0In0seyJwYyI6WzEzNl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjg0In0seyJwYyI6WzEzNywxMzgsMTM5LDE0MCwxNDEsMTQyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2ODQifSx7InBjIjpbMTQzLDE0NCwxNDVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjg0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY4NCJ9LHsicGMiOlsxNDYsMTQ3LDE0OCwxNDldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjg1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY4NCJ9LHsicGMiOlsxNTBdLCJlcnJvck1lc3NhZ2UiOiJ0aGlzIGNvbnRyYWN0IGRvZXMgbm90IGltcGxlbWVudCB0aGUgZ2l2ZW4gQUJJIG1ldGhvZCBmb3IgY3JlYXRlIE5vT3AiLCJ0ZWFsIjo4OCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2ODQifSx7InBjIjpbMTUxLDE1MiwxNTMsMTU0LDE1NSwxNTZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjkxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY4NCJ9LHsicGMiOlsxNTcsMTU4LDE1OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjg0In0seyJwYyI6WzE2MCwxNjEsMTYyLDE2M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjg0In0seyJwYyI6WzE2NF0sImVycm9yTWVzc2FnZSI6InRoaXMgY29udHJhY3QgZG9lcyBub3QgaW1wbGVtZW50IHRoZSBnaXZlbiBBQkkgbWV0aG9kIGZvciBjYWxsIE5vT3AiLCJ0ZWFsIjo5Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2ODQifSx7InBjIjpbMTY1LDE2NiwxNjddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjk5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY4NCJ9LHsicGMiOlsxNjgsMTY5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjg0In0seyJwYyI6WzE3MCwxNzFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwMSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2ODQifSx7InBjIjpbMTcyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjg0In0seyJwYyI6WzE3MywxNzRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwMywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2ODQifSx7InBjIjpbMTc1LDE3Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTA0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY4NCJ9LHsicGMiOlsxNzddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwNSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2ODQifSx7InBjIjpbMTc4LDE3OSwxODBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwOCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2ODQifSx7InBjIjpbMTgxLDE4Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTA5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY4NCJ9LHsicGMiOlsxODMsMTg0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMTAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjg0In0seyJwYyI6WzE4NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTExLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY4NCJ9LHsicGMiOlsxODYsMTg3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMTIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjg0In0seyJwYyI6WzE4OCwxODldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjExMywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2ODQifSx7InBjIjpbMTkwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMTQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjg0In0seyJwYyI6WzE5MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTE1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY4NCJ9LHsicGMiOlsxOTIsMTkzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMTYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjg0In0seyJwYyI6WzE5NF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTE3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY4NCJ9LHsicGMiOlsxOTVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjExOCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2ODQifSx7InBjIjpbMTk2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMTksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjg0In0seyJwYyI6WzE5NywxOTgsMTk5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMjAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjg0In0seyJwYyI6WzIwMCwyMDFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyMSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2ODQifSx7InBjIjpbMjAyLDIwM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTIyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY4NCJ9LHsicGMiOlsyMDRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyMywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2ODQifSx7InBjIjpbMjA1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMjQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjg0In0seyJwYyI6WzIwNiwyMDddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyNSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2ODQifSx7InBjIjpbMjA4LDIwOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTI2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY4NCJ9LHsicGMiOlsyMTAsMjExXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMjcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjg0In0seyJwYyI6WzIxMiwyMTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyOCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2ODQifSx7InBjIjpbMjE0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMjksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjg0In1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q21sdWRHTmliRzlqYXlBeENtSjVkR1ZqWW14dlkyc2dNSGcyTWpSa05qRTNNQ0F3ZUFvS0x5OGdWR2hwY3lCVVJVRk1JSGRoY3lCblpXNWxjbUYwWldRZ1lua2dWRVZCVEZOamNtbHdkQ0IyTUM0eE1EY3VNZ292THlCb2RIUndjem92TDJkcGRHaDFZaTVqYjIwdllXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwxUkZRVXhUWTNKcGNIUUtDaTh2SUZSb2FYTWdZMjl1ZEhKaFkzUWdhWE1nWTI5dGNHeHBZVzUwSUhkcGRHZ2dZVzVrTDI5eUlHbHRjR3hsYldWdWRITWdkR2hsSUdadmJHeHZkMmx1WnlCQlVrTnpPaUJiSUVGU1F6UWdYUW9LTHk4Z1ZHaGxJR1p2Ykd4dmQybHVaeUIwWlc0Z2JHbHVaWE1nYjJZZ1ZFVkJUQ0JvWVc1a2JHVWdhVzVwZEdsaGJDQndjbTluY21GdElHWnNiM2NLTHk4Z1ZHaHBjeUJ3WVhSMFpYSnVJR2x6SUhWelpXUWdkRzhnYldGclpTQnBkQ0JsWVhONUlHWnZjaUJoYm5sdmJtVWdkRzhnY0dGeWMyVWdkR2hsSUhOMFlYSjBJRzltSUhSb1pTQndjbTluY21GdElHRnVaQ0JrWlhSbGNtMXBibVVnYVdZZ1lTQnpjR1ZqYVdacFl5QmhZM1JwYjI0Z2FYTWdZV3hzYjNkbFpBb3ZMeUJJWlhKbExDQmhZM1JwYjI0Z2NtVm1aWEp6SUhSdklIUm9aU0JQYmtOdmJYQnNaWFJsSUdsdUlHTnZiV0pwYm1GMGFXOXVJSGRwZEdnZ2QyaGxkR2hsY2lCMGFHVWdZWEJ3SUdseklHSmxhVzVuSUdOeVpXRjBaV1FnYjNJZ1kyRnNiR1ZrQ2k4dklFVjJaWEo1SUhCdmMzTnBZbXhsSUdGamRHbHZiaUJtYjNJZ2RHaHBjeUJqYjI1MGNtRmpkQ0JwY3lCeVpYQnlaWE5sYm5SbFpDQnBiaUIwYUdVZ2MzZHBkR05vSUhOMFlYUmxiV1Z1ZEFvdkx5QkpaaUIwYUdVZ1lXTjBhVzl1SUdseklHNXZkQ0JwYlhCc1pXMWxiblJsWkNCcGJpQjBhR1VnWTI5dWRISmhZM1FzSUdsMGN5QnlaWE53WldOMGFYWmxJR0p5WVc1amFDQjNhV3hzSUdKbElDSXFUazlVWDBsTlVFeEZUVVZPVkVWRUlpQjNhR2xqYUNCcWRYTjBJR052Ym5SaGFXNXpJQ0psY25JaUNuUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpRUtjSFZ6YUdsdWRDQTJDaW9LZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29yQ25OM2FYUmphQ0FxWTJGc2JGOU9iMDl3SUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFZM0psWVhSbFgwNXZUM0FnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUNnb3FUazlVWDBsTlVFeEZUVVZPVkVWRU9nb0pMeThnVkdobElISmxjWFZsYzNSbFpDQmhZM1JwYjI0Z2FYTWdibTkwSUdsdGNHeGxiV1Z1ZEdWa0lHbHVJSFJvYVhNZ1kyOXVkSEpoWTNRdUlFRnlaU0I1YjNVZ2RYTnBibWNnZEdobElHTnZjbkpsWTNRZ1QyNURiMjF3YkdWMFpUOGdSR2xrSUhsdmRTQnpaWFFnZVc5MWNpQmhjSEFnU1VRL0NnbGxjbklLQ2k4dklHNWxjM1JsWkVGeWNtRjVTVzVDYjNoWGFYUm9iM1YwUW05dmJDZ3BLR0o1ZEdWYk5GMWJYU3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkNrS0ttRmlhVjl5YjNWMFpWOXVaWE4wWldSQmNuSmhlVWx1UW05NFYybDBhRzkxZEVKdmIydzZDZ2t2THlCVWFHVWdRVUpKSUhKbGRIVnliaUJ3Y21WbWFYZ0tDWEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxQ2dvSkx5OGdaWGhsWTNWMFpTQnVaWE4wWldSQmNuSmhlVWx1UW05NFYybDBhRzkxZEVKdmIyd29LU2hpZVhSbFd6UmRXMTBzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRcENnbGpZV3hzYzNWaUlHNWxjM1JsWkVGeWNtRjVTVzVDYjNoWGFYUm9iM1YwUW05dmJBb0pZMjl1WTJGMENnbHNiMmNLQ1dsdWRHTWdNQ0F2THlBeENnbHlaWFIxY200S0NpOHZJRzVsYzNSbFpFRnljbUY1U1c1Q2IzaFhhWFJvYjNWMFFtOXZiQ2dwT2lCVU1USUtibVZ6ZEdWa1FYSnlZWGxKYmtKdmVGZHBkR2h2ZFhSQ2IyOXNPZ29KY0hKdmRHOGdNQ0F4Q2dvSkx5OGdkR1Z6ZEhNdlkyOXVkSEpoWTNSekwyRmlhUzVoYkdkdkxuUnpPakUyT0RnS0NTOHZJSFJvYVhNdVlrMWhjQ2duWWsxaGNDY3BMblpoYkhWbElEMGdld29KTHk4Z0lDQWdJQ0FnWW5sMFpYTTBRWEp5WVhrNklGc25ZV0pqWkNjZ1lYTWdZbmwwWlhNOE5ENHNJQ2RsWm1kb0p5QmhjeUJpZVhSbGN6dzBQbDBzQ2drdkx5QWdJQ0FnSUNCMU5qUmhPaUF4TEFvSkx5OGdJQ0FnSUNBZ2RUWTBZam9nTWl3S0NTOHZJQ0FnSUNBZ0lIVTJOR002SURNc0Nna3ZMeUFnSUNBZ2ZRb0pZbmwwWldNZ01DQXZMeUFnSW1KTllYQWlDZ2xrZFhBS0NXSnZlRjlrWld3S0NYQnZjQW9KWW5sMFpXTWdNU0F2THlBZ2FXNXBkR2xoYkNCb1pXRmtDZ2xpZVhSbFl5QXhJQzh2SUNCcGJtbDBhV0ZzSUhSaGFXd0tDWEIxYzJoaWVYUmxjeUF3ZURBd01XRWdMeThnYVc1cGRHbGhiQ0JvWldGa0lHOW1abk5sZEFvSmNIVnphR0o1ZEdWeklEQjRNREF3TWpZeE5qSTJNelkwTmpVMk5qWTNOamdLQ1dOaGJHeHpkV0lnS25CeWIyTmxjM05mWkhsdVlXMXBZMTkwZFhCc1pWOWxiR1Z0Wlc1MENnbHdkWE5vWW5sMFpYTWdNSGd3TURBd01EQXdNREF3TURBd01EQXhDZ2xqWVd4c2MzVmlJQ3B3Y205alpYTnpYM04wWVhScFkxOTBkWEJzWlY5bGJHVnRaVzUwQ2dsd2RYTm9ZbmwwWlhNZ01IZ3dNREF3TURBd01EQXdNREF3TURBeUNnbGpZV3hzYzNWaUlDcHdjbTlqWlhOelgzTjBZWFJwWTE5MGRYQnNaVjlsYkdWdFpXNTBDZ2x3ZFhOb1lubDBaWE1nTUhnd01EQXdNREF3TURBd01EQXdNREF6Q2dsallXeHNjM1ZpSUNwd2NtOWpaWE56WDNOMFlYUnBZMTkwZFhCc1pWOWxiR1Z0Wlc1MENnbHdiM0FnTHk4Z2NHOXdJR2hsWVdRZ2IyWm1jMlYwQ2dsamIyNWpZWFFnTHk4Z1kyOXVZMkYwSUdobFlXUWdZVzVrSUhSaGFXd0tDV0p2ZUY5d2RYUUtDZ2t2THlCMFpYTjBjeTlqYjI1MGNtRmpkSE12WVdKcExtRnNaMjh1ZEhNNk1UWTVOUW9KTHk4Z2NtVjBkWEp1SUhSb2FYTXVZazFoY0NnbllrMWhjQ2NwTG5aaGJIVmxPd29KWW5sMFpXTWdNQ0F2THlBZ0ltSk5ZWEFpQ2dsaWIzaGZaMlYwQ2dvSkx5OGdZbTk0SUhaaGJIVmxJR1J2WlhNZ2JtOTBJR1Y0YVhOME9pQjBhR2x6TG1KTllYQW9KMkpOWVhBbktTNTJZV3gxWlFvSllYTnpaWEowQ2dseVpYUnpkV0lLQ2lwaFltbGZjbTkxZEdWZlkzSmxZWFJsUVhCd2JHbGpZWFJwYjI0NkNnbHBiblJqSURBZ0x5OGdNUW9KY21WMGRYSnVDZ29xWTNKbFlYUmxYMDV2VDNBNkNnbHdkWE5vWW5sMFpYTWdNSGhpT0RRME4ySXpOaUF2THlCdFpYUm9iMlFnSW1OeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1S0NsMmIybGtJZ29KZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb0piV0YwWTJnZ0ttRmlhVjl5YjNWMFpWOWpjbVZoZEdWQmNIQnNhV05oZEdsdmJnb0tDUzh2SUhSb2FYTWdZMjl1ZEhKaFkzUWdaRzlsY3lCdWIzUWdhVzF3YkdWdFpXNTBJSFJvWlNCbmFYWmxiaUJCUWtrZ2JXVjBhRzlrSUdadmNpQmpjbVZoZEdVZ1RtOVBjQW9KWlhKeUNnb3FZMkZzYkY5T2IwOXdPZ29KY0hWemFHSjVkR1Z6SURCNFptWTFaV1pqTURJZ0x5OGdiV1YwYUc5a0lDSnVaWE4wWldSQmNuSmhlVWx1UW05NFYybDBhRzkxZEVKdmIyd29LU2hpZVhSbFd6UmRXMTBzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRcElnb0pkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvSmJXRjBZMmdnS21GaWFWOXliM1YwWlY5dVpYTjBaV1JCY25KaGVVbHVRbTk0VjJsMGFHOTFkRUp2YjJ3S0Nna3ZMeUIwYUdseklHTnZiblJ5WVdOMElHUnZaWE1nYm05MElHbHRjR3hsYldWdWRDQjBhR1VnWjJsMlpXNGdRVUpKSUcxbGRHaHZaQ0JtYjNJZ1kyRnNiQ0JPYjA5d0NnbGxjbklLQ2lwd2NtOWpaWE56WDNOMFlYUnBZMTkwZFhCc1pWOWxiR1Z0Wlc1ME9nb0pjSEp2ZEc4Z05DQXpDZ2xtY21GdFpWOWthV2NnTFRRZ0x5OGdkSFZ3YkdVZ2FHVmhaQW9KWm5KaGJXVmZaR2xuSUMweElDOHZJR1ZzWlcxbGJuUUtDV052Ym1OaGRBb0pabkpoYldWZlpHbG5JQzB6SUM4dklIUjFjR3hsSUhSaGFXd0tDV1p5WVcxbFgyUnBaeUF0TWlBdkx5Qm9aV0ZrSUc5bVpuTmxkQW9KY21WMGMzVmlDZ29xY0hKdlkyVnpjMTlrZVc1aGJXbGpYM1IxY0d4bFgyVnNaVzFsYm5RNkNnbHdjbTkwYnlBMElETUtDV1p5WVcxbFgyUnBaeUF0TkNBdkx5QjBkWEJzWlNCb1pXRmtDZ2xtY21GdFpWOWthV2NnTFRJZ0x5OGdhR1ZoWkNCdlptWnpaWFFLQ1dOdmJtTmhkQW9KWm5KaGJXVmZZblZ5ZVNBdE5DQXZMeUIwZFhCc1pTQm9aV0ZrQ2dsbWNtRnRaVjlrYVdjZ0xURWdMeThnWld4bGJXVnVkQW9KWkhWd0NnbHNaVzRLQ1daeVlXMWxYMlJwWnlBdE1pQXZMeUJvWldGa0lHOW1abk5sZEFvSlluUnZhUW9KS3dvSmFYUnZZZ29KWlhoMGNtRmpkQ0EySURJS0NXWnlZVzFsWDJKMWNua2dMVElnTHk4Z2FHVmhaQ0J2Wm1aelpYUUtDV1p5WVcxbFgyUnBaeUF0TXlBdkx5QjBkWEJzWlNCMFlXbHNDZ2x6ZDJGd0NnbGpiMjVqWVhRS0NXWnlZVzFsWDJKMWNua2dMVE1nTHk4Z2RIVndiR1VnZEdGcGJBb0pabkpoYldWZlpHbG5JQzAwSUM4dklIUjFjR3hsSUdobFlXUUtDV1p5WVcxbFgyUnBaeUF0TXlBdkx5QjBkWEJzWlNCMFlXbHNDZ2xtY21GdFpWOWthV2NnTFRJZ0x5OGdhR1ZoWkNCdlptWnpaWFFLQ1hKbGRITjFZZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXcifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFCQVNZQ0JHSk5ZWEFBTVJnVWdRWUxNUmtJalF3QWFBQUFBQUFBQUFBQUFBQUFXZ0FBQUFBQUFBQUFBQUFBZ0FRVkgzeDFpQUFFVUxBaVE0b0FBU2hKdkVncEtZQUNBQnFBQ2dBQ1lXSmpaR1ZtWjJpSUFGbUFDQUFBQUFBQUFBQUJpQUEvZ0FnQUFBQUFBQUFBQW9nQU1vQUlBQUFBQUFBQUFBT0lBQ1ZJVUw4b3ZrU0pJa09BQkxoRWV6WTJHZ0NPQWYveEFJQUUvMTc4QWpZYUFJNEIvNHdBaWdRRGkveUwvMUNML1l2K2lZb0VBNHY4aS81UWpQeUwvMGtWaS80WENCWlhCZ0tNL292OVRGQ00vWXY4aS8yTC9vaz0iLCJjbGVhciI6IkNnPT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoiYWxnb2QiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo0LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6IjdiNjA3Y2U0In19LCJldmVudHMiOm51bGwsInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
