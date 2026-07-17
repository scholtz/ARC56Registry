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

namespace Arc56.Generated.algorandfoundation.TEALScript.ABITestNestedArrayInBoxLast_b10cd645
{


    public class ABITestNestedArrayInBoxLastProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ABITestNestedArrayInBoxLastProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class T11 : AVMObjectType
            {
                public ulong U64A { get; set; }

                public ulong U64B { get; set; }

                public ulong U64C { get; set; }

                public bool BoolValue { get; set; }

                public byte[][] Bytes4Array { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBytes4Array = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[4][]");
                    vBytes4Array.From(Bytes4Array);
                    ret.AddRange(vBytes4Array.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static T11 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new T11();
                    uint count = 0;
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBytes4Array = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[4][]");
                    count = vBytes4Array.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBytes4Array = vBytes4Array.ToValue();
                    if (valueBytes4Array is byte[][] vBytes4ArrayValue) { ret.Bytes4Array = vBytes4ArrayValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as T11);
                }
                public bool Equals(T11? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(T11 left, T11 right)
                {
                    return EqualityComparer<T11>.Default.Equals(left, right);
                }
                public static bool operator !=(T11 left, T11 right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.T11> NestedArrayInBoxLast(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 40, 120, 139 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.T11.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> NestedArrayInBoxLast_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 40, 120, 139 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJBQklUZXN0TmVzdGVkQXJyYXlJbkJveExhc3QiLCJkZXNjIjoiIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IlQxMSI6W3sibmFtZSI6InU2NGEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidTY0YiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ1NjRjIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImJvb2xWYWx1ZSIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiYnl0ZXM0QXJyYXkiLCJ0eXBlIjoiYnl0ZVs0XVtdIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6Im5lc3RlZEFycmF5SW5Cb3hMYXN0IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCxib29sLGJ5dGVbNF1bXSkiLCJzdHJ1Y3QiOiJUMTEiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiY3JlYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NjEifSx7InBjIjpbMSwyLDMsNF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NjEifSx7InBjIjpbNSw2LDcsOCw5LDEwLDExLDEyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY2MSJ9LHsicGMiOlsxMywxNF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjYxIn0seyJwYyI6WzE1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NjEifSx7InBjIjpbMTYsMTddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY2MSJ9LHsicGMiOlsxOF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjYxIn0seyJwYyI6WzE5LDIwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxOSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NjEifSx7InBjIjpbMjFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY2MSJ9LHsicGMiOlsyMiwyMywyNCwyNSwyNiwyNywyOCwyOSwzMCwzMSwzMiwzMywzNCwzNSwzNiwzNywzOCwzOSw0MCw0MSw0Miw0Myw0NCw0NSw0Niw0N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjYxIn0seyJwYyI6WzQ4XSwiZXJyb3JNZXNzYWdlIjoiVGhlIHJlcXVlc3RlZCBhY3Rpb24gaXMgbm90IGltcGxlbWVudGVkIGluIHRoaXMgY29udHJhY3QuIEFyZSB5b3UgdXNpbmcgdGhlIGNvcnJlY3QgT25Db21wbGV0ZT8gRGlkIHlvdSBzZXQgeW91ciBhcHAgSUQ/IiwidGVhbCI6MjUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjYxIn0seyJwYyI6WzQ5LDUwLDUxLDUyLDUzLDU0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NjQifSx7InBjIjpbNTUsNTYsNTddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY2NCJ9LHsicGMiOls1OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjY0In0seyJwYyI6WzU5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NjQifSx7InBjIjpbNjBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY2NCJ9LHsicGMiOls2MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjY0In0seyJwYyI6WzYyLDYzLDY0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NjQifSx7InBjIjpbNjVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjUxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY2NSJ9LHsicGMiOls2Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjY1In0seyJwYyI6WzY3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NjUifSx7InBjIjpbNjhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY2NSJ9LHsicGMiOls2OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjY1In0seyJwYyI6WzcwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NjUifSx7InBjIjpbNzEsNzIsNzMsNzRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY2NSJ9LHsicGMiOls3NSw3Niw3Nyw3OCw3OSw4MCw4MSw4Miw4Myw4NF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjY3In0seyJwYyI6Wzg1LDg2LDg3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1OSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NjcifSx7InBjIjpbODgsODksOTAsOTEsOTIsOTMsOTQsOTUsOTYsOTddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjYwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY2OCJ9LHsicGMiOls5OCw5OSwxMDBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjYxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY2OCJ9LHsicGMiOlsxMDEsMTAyLDEwMywxMDQsMTA1LDEwNiwxMDcsMTA4LDEwOSwxMTBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjYyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY2OSJ9LHsicGMiOlsxMTEsMTEyLDExM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjY5In0seyJwYyI6WzExNCwxMTUsMTE2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NzAifSx7InBjIjpbMTE3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2NSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NzAifSx7InBjIjpbMTE4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NzAifSx7InBjIjpbMTE5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2Nywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NzAifSx7InBjIjpbMTIwLDEyMSwxMjJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY2NiJ9LHsicGMiOlsxMjMsMTI0LDEyNSwxMjYsMTI3LDEyOCwxMjksMTMwLDEzMSwxMzIsMTMzLDEzNF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjY2In0seyJwYyI6WzEzNSwxMzYsMTM3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3MCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NjYifSx7InBjIjpbMTM4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NjUifSx7InBjIjpbMTM5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NjUifSx7InBjIjpbMTQwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NjUifSx7InBjIjpbMTQxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3Nywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NzMifSx7InBjIjpbMTQyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3OCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NzMifSx7InBjIjpbMTQzXSwiZXJyb3JNZXNzYWdlIjoiYm94IHZhbHVlIGRvZXMgbm90IGV4aXN0OiB0aGlzLmJNYXAoJ2JNYXAnKS52YWx1ZSIsInRlYWwiOjgxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY3MyJ9LHsicGMiOlsxNDRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjgyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY2NCJ9LHsicGMiOlsxNDVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjg1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY2MSJ9LHsicGMiOlsxNDZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjg2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY2MSJ9LHsicGMiOlsxNDcsMTQ4LDE0OSwxNTAsMTUxLDE1Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjYxIn0seyJwYyI6WzE1MywxNTQsMTU1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo5MCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NjEifSx7InBjIjpbMTU2LDE1NywxNTgsMTU5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo5MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NjEifSx7InBjIjpbMTYwXSwiZXJyb3JNZXNzYWdlIjoidGhpcyBjb250cmFjdCBkb2VzIG5vdCBpbXBsZW1lbnQgdGhlIGdpdmVuIEFCSSBtZXRob2QgZm9yIGNyZWF0ZSBOb09wIiwidGVhbCI6OTQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjYxIn0seyJwYyI6WzE2MSwxNjIsMTYzLDE2NCwxNjUsMTY2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo5Nywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NjEifSx7InBjIjpbMTY3LDE2OCwxNjldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjk4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY2MSJ9LHsicGMiOlsxNzAsMTcxLDE3MiwxNzNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjk5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY2MSJ9LHsicGMiOlsxNzRdLCJlcnJvck1lc3NhZ2UiOiJ0aGlzIGNvbnRyYWN0IGRvZXMgbm90IGltcGxlbWVudCB0aGUgZ2l2ZW4gQUJJIG1ldGhvZCBmb3IgY2FsbCBOb09wIiwidGVhbCI6MTAyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY2MSJ9LHsicGMiOlsxNzUsMTc2LDE3N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTA1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY2MSJ9LHsicGMiOlsxNzgsMTc5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjYxIn0seyJwYyI6WzE4MCwxODFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwNywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NjEifSx7InBjIjpbMTgyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjYxIn0seyJwYyI6WzE4MywxODRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwOSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NjEifSx7InBjIjpbMTg1LDE4Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTEwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY2MSJ9LHsicGMiOlsxODddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjExMSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NjEifSx7InBjIjpbMTg4LDE4OSwxOTBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjExNCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NjEifSx7InBjIjpbMTkxLDE5Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTE1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY2MSJ9LHsicGMiOlsxOTMsMTk0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMTYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjYxIn0seyJwYyI6WzE5NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTE3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY2MSJ9LHsicGMiOlsxOTYsMTk3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMTgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjYxIn0seyJwYyI6WzE5OCwxOTldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjExOSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NjEifSx7InBjIjpbMjAwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMjAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjYxIn0seyJwYyI6WzIwMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTIxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY2MSJ9LHsicGMiOlsyMDIsMjAzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMjIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjYxIn0seyJwYyI6WzIwNF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTIzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY2MSJ9LHsicGMiOlsyMDVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyNCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NjEifSx7InBjIjpbMjA2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMjUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjYxIn0seyJwYyI6WzIwNywyMDgsMjA5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMjYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjYxIn0seyJwYyI6WzIxMCwyMTFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyNywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NjEifSx7InBjIjpbMjEyLDIxM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTI4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY2MSJ9LHsicGMiOlsyMTRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyOSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NjEifSx7InBjIjpbMjE1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMzAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjYxIn0seyJwYyI6WzIxNiwyMTddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEzMSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NjEifSx7InBjIjpbMjE4LDIxOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTMyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY2MSJ9LHsicGMiOlsyMjAsMjIxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMzMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjYxIn0seyJwYyI6WzIyMiwyMjNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEzNCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2NjEifSx7InBjIjpbMjI0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMzUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjYxIn1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q21sdWRHTmliRzlqYXlBd0lERUtZbmwwWldOaWJHOWpheUF3ZURZeU5HUTJNVGN3SURCNENnb3ZMeUJVYUdseklGUkZRVXdnZDJGeklHZGxibVZ5WVhSbFpDQmllU0JVUlVGTVUyTnlhWEIwSUhZd0xqRXdOeTR5Q2k4dklHaDBkSEJ6T2k4dloybDBhSFZpTG1OdmJTOWhiR2R2Y21GdVpHWnZkVzVrWVhScGIyNHZWRVZCVEZOamNtbHdkQW9LTHk4Z1ZHaHBjeUJqYjI1MGNtRmpkQ0JwY3lCamIyMXdiR2xoYm5RZ2QybDBhQ0JoYm1RdmIzSWdhVzF3YkdWdFpXNTBjeUIwYUdVZ1ptOXNiRzkzYVc1bklFRlNRM002SUZzZ1FWSkROQ0JkQ2dvdkx5QlVhR1VnWm05c2JHOTNhVzVuSUhSbGJpQnNhVzVsY3lCdlppQlVSVUZNSUdoaGJtUnNaU0JwYm1sMGFXRnNJSEJ5YjJkeVlXMGdabXh2ZHdvdkx5QlVhR2x6SUhCaGRIUmxjbTRnYVhNZ2RYTmxaQ0IwYnlCdFlXdGxJR2wwSUdWaGMza2dabTl5SUdGdWVXOXVaU0IwYnlCd1lYSnpaU0IwYUdVZ2MzUmhjblFnYjJZZ2RHaGxJSEJ5YjJkeVlXMGdZVzVrSUdSbGRHVnliV2x1WlNCcFppQmhJSE53WldOcFptbGpJR0ZqZEdsdmJpQnBjeUJoYkd4dmQyVmtDaTh2SUVobGNtVXNJR0ZqZEdsdmJpQnlaV1psY25NZ2RHOGdkR2hsSUU5dVEyOXRjR3hsZEdVZ2FXNGdZMjl0WW1sdVlYUnBiMjRnZDJsMGFDQjNhR1YwYUdWeUlIUm9aU0JoY0hBZ2FYTWdZbVZwYm1jZ1kzSmxZWFJsWkNCdmNpQmpZV3hzWldRS0x5OGdSWFpsY25rZ2NHOXpjMmxpYkdVZ1lXTjBhVzl1SUdadmNpQjBhR2x6SUdOdmJuUnlZV04wSUdseklISmxjSEpsYzJWdWRHVmtJR2x1SUhSb1pTQnpkMmwwWTJnZ2MzUmhkR1Z0Wlc1MENpOHZJRWxtSUhSb1pTQmhZM1JwYjI0Z2FYTWdibTkwSUdsdGNHeGxiV1Z1ZEdWa0lHbHVJSFJvWlNCamIyNTBjbUZqZEN3Z2FYUnpJSEpsYzNCbFkzUnBkbVVnWW5KaGJtTm9JSGRwYkd3Z1ltVWdJaXBPVDFSZlNVMVFURVZOUlU1VVJVUWlJSGRvYVdOb0lHcDFjM1FnWTI5dWRHRnBibk1nSW1WeWNpSUtkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJUXB3ZFhOb2FXNTBJRFlLS2dwMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lzS2MzZHBkR05vSUNwallXeHNYMDV2VDNBZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BqY21WaGRHVmZUbTlQY0NBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUUtDaXBPVDFSZlNVMVFURVZOUlU1VVJVUTZDZ2t2THlCVWFHVWdjbVZ4ZFdWemRHVmtJR0ZqZEdsdmJpQnBjeUJ1YjNRZ2FXMXdiR1Z0Wlc1MFpXUWdhVzRnZEdocGN5QmpiMjUwY21GamRDNGdRWEpsSUhsdmRTQjFjMmx1WnlCMGFHVWdZMjl5Y21WamRDQlBia052YlhCc1pYUmxQeUJFYVdRZ2VXOTFJSE5sZENCNWIzVnlJR0Z3Y0NCSlJEOEtDV1Z5Y2dvS0x5OGdibVZ6ZEdWa1FYSnlZWGxKYmtKdmVFeGhjM1FvS1NoMWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeGliMjlzTEdKNWRHVmJORjFiWFNrS0ttRmlhVjl5YjNWMFpWOXVaWE4wWldSQmNuSmhlVWx1UW05NFRHRnpkRG9LQ1M4dklGUm9aU0JCUWtrZ2NtVjBkWEp1SUhCeVpXWnBlQW9KY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVS0Nna3ZMeUJsZUdWamRYUmxJRzVsYzNSbFpFRnljbUY1U1c1Q2IzaE1ZWE4wS0Nrb2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNZbTl2YkN4aWVYUmxXelJkVzEwcENnbGpZV3hzYzNWaUlHNWxjM1JsWkVGeWNtRjVTVzVDYjNoTVlYTjBDZ2xqYjI1allYUUtDV3h2WndvSmFXNTBZeUF4SUM4dklERUtDWEpsZEhWeWJnb0tMeThnYm1WemRHVmtRWEp5WVhsSmJrSnZlRXhoYzNRb0tUb2dWREV4Q201bGMzUmxaRUZ5Y21GNVNXNUNiM2hNWVhOME9nb0pjSEp2ZEc4Z01DQXhDZ29KTHk4Z2RHVnpkSE12WTI5dWRISmhZM1J6TDJGaWFTNWhiR2R2TG5Sek9qRTJOalVLQ1M4dklIUm9hWE11WWsxaGNDZ25ZazFoY0NjcExuWmhiSFZsSUQwZ2V3b0pMeThnSUNBZ0lDQWdZbmwwWlhNMFFYSnlZWGs2SUZzbllXSmpaQ2NnWVhNZ1lubDBaWE04TkQ0c0lDZGxabWRvSnlCaGN5QmllWFJsY3p3MFBsMHNDZ2t2THlBZ0lDQWdJQ0IxTmpSaE9pQXhMQW9KTHk4Z0lDQWdJQ0FnZFRZMFlqb2dNaXdLQ1M4dklDQWdJQ0FnSUhVMk5HTTZJRE1zQ2drdkx5QWdJQ0FnSUNCaWIyOXNWbUZzZFdVNklHWmhiSE5sTEFvSkx5OGdJQ0FnSUgwS0NXSjVkR1ZqSURBZ0x5OGdJQ0ppVFdGd0lnb0paSFZ3Q2dsaWIzaGZaR1ZzQ2dsd2IzQUtDV0o1ZEdWaklERWdMeThnSUdsdWFYUnBZV3dnYUdWaFpBb0pZbmwwWldNZ01TQXZMeUFnYVc1cGRHbGhiQ0IwWVdsc0NnbHdkWE5vWW5sMFpYTWdNSGd3TURGaUlDOHZJR2x1YVhScFlXd2dhR1ZoWkNCdlptWnpaWFFLQ1hCMWMyaGllWFJsY3lBd2VEQXdNREF3TURBd01EQXdNREF3TURFS0NXTmhiR3h6ZFdJZ0tuQnliMk5sYzNOZmMzUmhkR2xqWDNSMWNHeGxYMlZzWlcxbGJuUUtDWEIxYzJoaWVYUmxjeUF3ZURBd01EQXdNREF3TURBd01EQXdNRElLQ1dOaGJHeHpkV0lnS25CeWIyTmxjM05mYzNSaGRHbGpYM1IxY0d4bFgyVnNaVzFsYm5RS0NYQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdNREF3TURBd01ETUtDV05oYkd4emRXSWdLbkJ5YjJObGMzTmZjM1JoZEdsalgzUjFjR3hsWDJWc1pXMWxiblFLQ1hCMWMyaGllWFJsY3lBd2VEQXdDZ2xwYm5SaklEQWdMeThnTUFvSlpIVndDZ2x6WlhSaWFYUUtDV05oYkd4emRXSWdLbkJ5YjJObGMzTmZjM1JoZEdsalgzUjFjR3hsWDJWc1pXMWxiblFLQ1hCMWMyaGllWFJsY3lBd2VEQXdNREkyTVRZeU5qTTJORFkxTmpZMk56WTRDZ2xqWVd4c2MzVmlJQ3B3Y205alpYTnpYMlI1Ym1GdGFXTmZkSFZ3YkdWZlpXeGxiV1Z1ZEFvSmNHOXdJQzh2SUhCdmNDQm9aV0ZrSUc5bVpuTmxkQW9KWTI5dVkyRjBJQzh2SUdOdmJtTmhkQ0JvWldGa0lHRnVaQ0IwWVdsc0NnbGliM2hmY0hWMENnb0pMeThnZEdWemRITXZZMjl1ZEhKaFkzUnpMMkZpYVM1aGJHZHZMblJ6T2pFMk56TUtDUzh2SUhKbGRIVnliaUIwYUdsekxtSk5ZWEFvSjJKTllYQW5LUzUyWVd4MVpUc0tDV0o1ZEdWaklEQWdMeThnSUNKaVRXRndJZ29KWW05NFgyZGxkQW9LQ1M4dklHSnZlQ0IyWVd4MVpTQmtiMlZ6SUc1dmRDQmxlR2x6ZERvZ2RHaHBjeTVpVFdGd0tDZGlUV0Z3SnlrdWRtRnNkV1VLQ1dGemMyVnlkQW9KY21WMGMzVmlDZ29xWVdKcFgzSnZkWFJsWDJOeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1T2dvSmFXNTBZeUF4SUM4dklERUtDWEpsZEhWeWJnb0tLbU55WldGMFpWOU9iMDl3T2dvSmNIVnphR0o1ZEdWeklEQjRZamcwTkRkaU16WWdMeThnYldWMGFHOWtJQ0pqY21WaGRHVkJjSEJzYVdOaGRHbHZiaWdwZG05cFpDSUtDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0NXMWhkR05vSUNwaFltbGZjbTkxZEdWZlkzSmxZWFJsUVhCd2JHbGpZWFJwYjI0S0Nna3ZMeUIwYUdseklHTnZiblJ5WVdOMElHUnZaWE1nYm05MElHbHRjR3hsYldWdWRDQjBhR1VnWjJsMlpXNGdRVUpKSUcxbGRHaHZaQ0JtYjNJZ1kzSmxZWFJsSUU1dlQzQUtDV1Z5Y2dvS0ttTmhiR3hmVG05UGNEb0tDWEIxYzJoaWVYUmxjeUF3ZURrMU1qZzNPRGhpSUM4dklHMWxkR2h2WkNBaWJtVnpkR1ZrUVhKeVlYbEpia0p2ZUV4aGMzUW9LU2gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4aWIyOXNMR0o1ZEdWYk5GMWJYU2tpQ2dsMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDZ2x0WVhSamFDQXFZV0pwWDNKdmRYUmxYMjVsYzNSbFpFRnljbUY1U1c1Q2IzaE1ZWE4wQ2dvSkx5OGdkR2hwY3lCamIyNTBjbUZqZENCa2IyVnpJRzV2ZENCcGJYQnNaVzFsYm5RZ2RHaGxJR2RwZG1WdUlFRkNTU0J0WlhSb2IyUWdabTl5SUdOaGJHd2dUbTlQY0FvSlpYSnlDZ29xY0hKdlkyVnpjMTl6ZEdGMGFXTmZkSFZ3YkdWZlpXeGxiV1Z1ZERvS0NYQnliM1J2SURRZ013b0pabkpoYldWZlpHbG5JQzAwSUM4dklIUjFjR3hsSUdobFlXUUtDV1p5WVcxbFgyUnBaeUF0TVNBdkx5QmxiR1Z0Wlc1MENnbGpiMjVqWVhRS0NXWnlZVzFsWDJScFp5QXRNeUF2THlCMGRYQnNaU0IwWVdsc0NnbG1jbUZ0WlY5a2FXY2dMVElnTHk4Z2FHVmhaQ0J2Wm1aelpYUUtDWEpsZEhOMVlnb0tLbkJ5YjJObGMzTmZaSGx1WVcxcFkxOTBkWEJzWlY5bGJHVnRaVzUwT2dvSmNISnZkRzhnTkNBekNnbG1jbUZ0WlY5a2FXY2dMVFFnTHk4Z2RIVndiR1VnYUdWaFpBb0pabkpoYldWZlpHbG5JQzB5SUM4dklHaGxZV1FnYjJabWMyVjBDZ2xqYjI1allYUUtDV1p5WVcxbFgySjFjbmtnTFRRZ0x5OGdkSFZ3YkdVZ2FHVmhaQW9KWm5KaGJXVmZaR2xuSUMweElDOHZJR1ZzWlcxbGJuUUtDV1IxY0FvSmJHVnVDZ2xtY21GdFpWOWthV2NnTFRJZ0x5OGdhR1ZoWkNCdlptWnpaWFFLQ1dKMGIya0tDU3NLQ1dsMGIySUtDV1Y0ZEhKaFkzUWdOaUF5Q2dsbWNtRnRaVjlpZFhKNUlDMHlJQzh2SUdobFlXUWdiMlptYzJWMENnbG1jbUZ0WlY5a2FXY2dMVE1nTHk4Z2RIVndiR1VnZEdGcGJBb0pjM2RoY0FvSlkyOXVZMkYwQ2dsbWNtRnRaVjlpZFhKNUlDMHpJQzh2SUhSMWNHeGxJSFJoYVd3S0NXWnlZVzFsWDJScFp5QXROQ0F2THlCMGRYQnNaU0JvWldGa0NnbG1jbUZ0WlY5a2FXY2dMVE1nTHk4Z2RIVndiR1VnZEdGcGJBb0pabkpoYldWZlpHbG5JQzB5SUM4dklHaGxZV1FnYjJabWMyVjBDZ2x5WlhSemRXST0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFdyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUNBQUVtQWdSaVRXRndBREVZRklFR0N6RVpDSTBNQUhFQUFBQUFBQUFBQUFBQUFHTUFBQUFBQUFBQUFBQUFBSUFFRlI5OGRZZ0FCRkN3STBPS0FBRW9TYnhJS1NtQUFnQWJnQWdBQUFBQUFBQUFBWWdBVjRBSUFBQUFBQUFBQUFLSUFFcUFDQUFBQUFBQUFBQURpQUE5Z0FFQUlrbFVpQUEwZ0FvQUFtRmlZMlJsWm1kb2lBQXlTRkMvS0w1RWlTTkRnQVM0UkhzMk5ob0FqZ0gvOFFDQUJKVW9lSXMyR2dDT0FmK0RBSW9FQTR2OGkvOVFpLzJML29tS0JBT0wvSXYrVUl6OGkvOUpGWXYrRndnV1Z3WUNqUDZML1V4UWpQMkwvSXY5aS82SiIsImNsZWFyIjoiQ2c9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJhbGdvZCIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjQsInBhdGNoIjoxLCJjb21taXRIYXNoIjoiN2I2MDdjZTQifX0sImV2ZW50cyI6bnVsbCwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
