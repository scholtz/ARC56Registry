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

namespace Arc56.Generated.algorandfoundation.TEALScript.ABITestNestedArrayAlongsideBoolean_5564826c
{


    public class ABITestNestedArrayAlongsideBooleanProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ABITestNestedArrayAlongsideBooleanProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        public async Task<Structs.T10> NestedArrayAlongsideBoolean(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 196, 156, 185, 167 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.T10.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> NestedArrayAlongsideBoolean_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 196, 156, 185, 167 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJBQklUZXN0TmVzdGVkQXJyYXlBbG9uZ3NpZGVCb29sZWFuIiwiZGVzYyI6IiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJUMTAiOlt7Im5hbWUiOiJieXRlczRBcnJheSIsInR5cGUiOiJieXRlWzRdW10ifSx7Im5hbWUiOiJ1NjRhIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InU2NGIiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidTY0YyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJib29sVmFsdWUiLCJ0eXBlIjoiYm9vbCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJuZXN0ZWRBcnJheUFsb25nc2lkZUJvb2xlYW4iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKGJ5dGVbNF1bXSx1aW50NjQsdWludDY0LHVpbnQ2NCxib29sKSIsInN0cnVjdCI6IlQxMCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlswXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY5OSJ9LHsicGMiOlsxLDIsMyw0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY5OSJ9LHsicGMiOls1LDYsN10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2OTkifSx7InBjIjpbOCw5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2OTkifSx7InBjIjpbMTBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY5OSJ9LHsicGMiOlsxMSwxMl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjk5In0seyJwYyI6WzEzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxOCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2OTkifSx7InBjIjpbMTQsMTVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY5OSJ9LHsicGMiOlsxNl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjk5In0seyJwYyI6WzE3LDE4LDE5LDIwLDIxLDIyLDIzLDI0LDI1LDI2LDI3LDI4LDI5LDMwLDMxLDMyLDMzLDM0LDM1LDM2LDM3LDM4LDM5LDQwLDQxLDQyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyMSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2OTkifSx7InBjIjpbNDNdLCJlcnJvck1lc3NhZ2UiOiJUaGUgcmVxdWVzdGVkIGFjdGlvbiBpcyBub3QgaW1wbGVtZW50ZWQgaW4gdGhpcyBjb250cmFjdC4gQXJlIHlvdSB1c2luZyB0aGUgY29ycmVjdCBPbkNvbXBsZXRlPyBEaWQgeW91IHNldCB5b3VyIGFwcCBJRD8iLCJ0ZWFsIjoyNSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2OTkifSx7InBjIjpbNDQsNDUsNDYsNDcsNDgsNDldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTcwMiJ9LHsicGMiOls1MCw1MSw1Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNzAyIn0seyJwYyI6WzUzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE3MDIifSx7InBjIjpbNTRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTcwMiJ9LHsicGMiOls1NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNzAyIn0seyJwYyI6WzU2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE3MDIifSx7InBjIjpbNTcsNTgsNTldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTcwMiJ9LHsicGMiOls2MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNzAyIn0seyJwYyI6WzYxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE3MDMifSx7InBjIjpbNjJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTcwMyJ9LHsicGMiOls2Myw2NCw2NSw2Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNzAzIn0seyJwYyI6WzY3LDY4LDY5LDcwLDcxLDcyLDczLDc0LDc1LDc2LDc3LDc4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1Nywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE3MDQifSx7InBjIjpbNzksODAsODFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTcwNCJ9LHsicGMiOls4Miw4Myw4NCw4NSw4Niw4Nyw4OCw4OSw5MCw5MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNzA1In0seyJwYyI6WzkyLDkzLDk0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2MCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE3MDUifSx7InBjIjpbOTUsOTYsOTcsOTgsOTksMTAwLDEwMSwxMDIsMTAzLDEwNF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNzA2In0seyJwYyI6WzEwNSwxMDYsMTA3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE3MDYifSx7InBjIjpbMTA4LDEwOSwxMTAsMTExLDExMiwxMTMsMTE0LDExNSwxMTYsMTE3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE3MDcifSx7InBjIjpbMTE4LDExOSwxMjBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTcwNyJ9LHsicGMiOlsxMjEsMTIyLDEyM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNzA4In0seyJwYyI6WzEyNF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNzA4In0seyJwYyI6WzEyNV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNzA4In0seyJwYyI6WzEyNl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNzA4In0seyJwYyI6WzEyNywxMjgsMTI5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2OSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE3MDMifSx7InBjIjpbMTMwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3MCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE3MDMifSx7InBjIjpbMTMxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE3MDMifSx7InBjIjpbMTMyLDEzM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNzAzIn0seyJwYyI6WzEzNCwxMzVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjc2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTcxMSJ9LHsicGMiOlsxMzYsMTM3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3OSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE3MDIifSx7InBjIjpbMTM4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4MCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE3MDIifSx7InBjIjpbMTM5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2OTkifSx7InBjIjpbMTQwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2OTkifSx7InBjIjpbMTQxLDE0MiwxNDMsMTQ0LDE0NSwxNDZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjg3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY5OSJ9LHsicGMiOlsxNDcsMTQ4LDE0OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjk5In0seyJwYyI6WzE1MCwxNTEsMTUyLDE1M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjk5In0seyJwYyI6WzE1NF0sImVycm9yTWVzc2FnZSI6InRoaXMgY29udHJhY3QgZG9lcyBub3QgaW1wbGVtZW50IHRoZSBnaXZlbiBBQkkgbWV0aG9kIGZvciBjcmVhdGUgTm9PcCIsInRlYWwiOjkyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY5OSJ9LHsicGMiOlsxNTUsMTU2LDE1NywxNTgsMTU5LDE2MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjk5In0seyJwYyI6WzE2MSwxNjIsMTYzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo5Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2OTkifSx7InBjIjpbMTY0LDE2NSwxNjYsMTY3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo5Nywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2OTkifSx7InBjIjpbMTY4XSwiZXJyb3JNZXNzYWdlIjoidGhpcyBjb250cmFjdCBkb2VzIG5vdCBpbXBsZW1lbnQgdGhlIGdpdmVuIEFCSSBtZXRob2QgZm9yIGNhbGwgTm9PcCIsInRlYWwiOjEwMCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2OTkifSx7InBjIjpbMTY5LDE3MCwxNzFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwMywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2OTkifSx7InBjIjpbMTcyLDE3M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTA0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY5OSJ9LHsicGMiOlsxNzQsMTc1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjk5In0seyJwYyI6WzE3Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTA2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY5OSJ9LHsicGMiOlsxNzcsMTc4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjk5In0seyJwYyI6WzE3OSwxODBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwOCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2OTkifSx7InBjIjpbMTgxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjk5In0seyJwYyI6WzE4MiwxODMsMTg0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMTIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjk5In0seyJwYyI6WzE4NSwxODZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjExMywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2OTkifSx7InBjIjpbMTg3LDE4OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTE0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY5OSJ9LHsicGMiOlsxODldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjExNSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2OTkifSx7InBjIjpbMTkwLDE5MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTE2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY5OSJ9LHsicGMiOlsxOTIsMTkzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMTcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjk5In0seyJwYyI6WzE5NF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTE4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY5OSJ9LHsicGMiOlsxOTVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjExOSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2OTkifSx7InBjIjpbMTk2LDE5N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTIwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY5OSJ9LHsicGMiOlsxOThdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyMSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2OTkifSx7InBjIjpbMTk5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMjIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjk5In0seyJwYyI6WzIwMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTIzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY5OSJ9LHsicGMiOlsyMDEsMjAyLDIwM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTI0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY5OSJ9LHsicGMiOlsyMDQsMjA1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMjUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjk5In0seyJwYyI6WzIwNiwyMDddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyNiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2OTkifSx7InBjIjpbMjA4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMjcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjk5In0seyJwYyI6WzIwOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTI4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY5OSJ9LHsicGMiOlsyMTAsMjExXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMjksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjk5In0seyJwYyI6WzIxMiwyMTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEzMCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2OTkifSx7InBjIjpbMjE0LDIxNV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTMxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY5OSJ9LHsicGMiOlsyMTYsMjE3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMzIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjk5In0seyJwYyI6WzIxOF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTMzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTY5OSJ9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NtbHVkR05pYkc5amF5QXdJREVLWW5sMFpXTmliRzlqYXlBd2VBb0tMeThnVkdocGN5QlVSVUZNSUhkaGN5Qm5aVzVsY21GMFpXUWdZbmtnVkVWQlRGTmpjbWx3ZENCMk1DNHhNRGN1TWdvdkx5Qm9kSFJ3Y3pvdkwyZHBkR2gxWWk1amIyMHZZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMVJGUVV4VFkzSnBjSFFLQ2k4dklGUm9hWE1nWTI5dWRISmhZM1FnYVhNZ1kyOXRjR3hwWVc1MElIZHBkR2dnWVc1a0wyOXlJR2x0Y0d4bGJXVnVkSE1nZEdobElHWnZiR3h2ZDJsdVp5QkJVa056T2lCYklFRlNRelFnWFFvS0x5OGdWR2hsSUdadmJHeHZkMmx1WnlCMFpXNGdiR2x1WlhNZ2IyWWdWRVZCVENCb1lXNWtiR1VnYVc1cGRHbGhiQ0J3Y205bmNtRnRJR1pzYjNjS0x5OGdWR2hwY3lCd1lYUjBaWEp1SUdseklIVnpaV1FnZEc4Z2JXRnJaU0JwZENCbFlYTjVJR1p2Y2lCaGJubHZibVVnZEc4Z2NHRnljMlVnZEdobElITjBZWEowSUc5bUlIUm9aU0J3Y205bmNtRnRJR0Z1WkNCa1pYUmxjbTFwYm1VZ2FXWWdZU0J6Y0dWamFXWnBZeUJoWTNScGIyNGdhWE1nWVd4c2IzZGxaQW92THlCSVpYSmxMQ0JoWTNScGIyNGdjbVZtWlhKeklIUnZJSFJvWlNCUGJrTnZiWEJzWlhSbElHbHVJR052YldKcGJtRjBhVzl1SUhkcGRHZ2dkMmhsZEdobGNpQjBhR1VnWVhCd0lHbHpJR0psYVc1bklHTnlaV0YwWldRZ2IzSWdZMkZzYkdWa0NpOHZJRVYyWlhKNUlIQnZjM05wWW14bElHRmpkR2x2YmlCbWIzSWdkR2hwY3lCamIyNTBjbUZqZENCcGN5QnlaWEJ5WlhObGJuUmxaQ0JwYmlCMGFHVWdjM2RwZEdOb0lITjBZWFJsYldWdWRBb3ZMeUJKWmlCMGFHVWdZV04wYVc5dUlHbHpJRzV2ZENCcGJYQnNaVzFsYm5SbFpDQnBiaUIwYUdVZ1kyOXVkSEpoWTNRc0lHbDBjeUJ5WlhOd1pXTjBhWFpsSUdKeVlXNWphQ0IzYVd4c0lHSmxJQ0lxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJaUIzYUdsamFDQnFkWE4wSUdOdmJuUmhhVzV6SUNKbGNuSWlDblI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUVLY0hWemFHbHVkQ0EyQ2lvS2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvckNuTjNhWFJqYUNBcVkyRnNiRjlPYjA5d0lDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxWTNKbFlYUmxYMDV2VDNBZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVDZ29xVGs5VVgwbE5VRXhGVFVWT1ZFVkVPZ29KTHk4Z1ZHaGxJSEpsY1hWbGMzUmxaQ0JoWTNScGIyNGdhWE1nYm05MElHbHRjR3hsYldWdWRHVmtJR2x1SUhSb2FYTWdZMjl1ZEhKaFkzUXVJRUZ5WlNCNWIzVWdkWE5wYm1jZ2RHaGxJR052Y25KbFkzUWdUMjVEYjIxd2JHVjBaVDhnUkdsa0lIbHZkU0J6WlhRZ2VXOTFjaUJoY0hBZ1NVUS9DZ2xsY25JS0NpOHZJRzVsYzNSbFpFRnljbUY1UVd4dmJtZHphV1JsUW05dmJHVmhiaWdwS0dKNWRHVmJORjFiWFN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeGliMjlzS1FvcVlXSnBYM0p2ZFhSbFgyNWxjM1JsWkVGeWNtRjVRV3h2Ym1kemFXUmxRbTl2YkdWaGJqb0tDUzh2SUZSb1pTQkJRa2tnY21WMGRYSnVJSEJ5WldacGVBb0pjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelVLQ2drdkx5QmxlR1ZqZFhSbElHNWxjM1JsWkVGeWNtRjVRV3h2Ym1kemFXUmxRbTl2YkdWaGJpZ3BLR0o1ZEdWYk5GMWJYU3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4aWIyOXNLUW9KWTJGc2JITjFZaUJ1WlhOMFpXUkJjbkpoZVVGc2IyNW5jMmxrWlVKdmIyeGxZVzRLQ1dOdmJtTmhkQW9KYkc5bkNnbHBiblJqSURFZ0x5OGdNUW9KY21WMGRYSnVDZ292THlCdVpYTjBaV1JCY25KaGVVRnNiMjVuYzJsa1pVSnZiMnhsWVc0b0tUb2dWREV3Q201bGMzUmxaRUZ5Y21GNVFXeHZibWR6YVdSbFFtOXZiR1ZoYmpvS0NYQnliM1J2SURBZ01Rb0tDUzh2SUZCMWMyZ2daVzF3ZEhrZ1lubDBaWE1nWVdaMFpYSWdkR2hsSUdaeVlXMWxJSEJ2YVc1MFpYSWdkRzhnY21WelpYSjJaU0J6Y0dGalpTQm1iM0lnYkc5allXd2dkbUZ5YVdGaWJHVnpDZ2xpZVhSbFl5QXdJQzh2SURCNENnb0pMeThnZEdWemRITXZZMjl1ZEhKaFkzUnpMMkZpYVM1aGJHZHZMblJ6T2pFM01ETUtDUzh2SUc4NklGUXhNQ0E5SUhzS0NTOHZJQ0FnSUNBZ0lHSjVkR1Z6TkVGeWNtRjVPaUJiSjJGaVkyUW5JR0Z6SUdKNWRHVnpQRFErTENBblpXWm5hQ2NnWVhNZ1lubDBaWE04TkQ1ZExBb0pMeThnSUNBZ0lDQWdkVFkwWVRvZ01Td0tDUzh2SUNBZ0lDQWdJSFUyTkdJNklESXNDZ2t2THlBZ0lDQWdJQ0IxTmpSak9pQXpMQW9KTHk4Z0lDQWdJQ0FnWW05dmJGWmhiSFZsT2lCbVlXeHpaU3dLQ1M4dklDQWdJQ0I5Q2dsaWVYUmxZeUF3SUM4dklDQnBibWwwYVdGc0lHaGxZV1FLQ1dKNWRHVmpJREFnTHk4Z0lHbHVhWFJwWVd3Z2RHRnBiQW9KY0hWemFHSjVkR1Z6SURCNE1EQXhZaUF2THlCcGJtbDBhV0ZzSUdobFlXUWdiMlptYzJWMENnbHdkWE5vWW5sMFpYTWdNSGd3TURBeU5qRTJNall6TmpRMk5UWTJOamMyT0FvSlkyRnNiSE4xWWlBcWNISnZZMlZ6YzE5a2VXNWhiV2xqWDNSMWNHeGxYMlZzWlcxbGJuUUtDWEIxYzJoaWVYUmxjeUF3ZURBd01EQXdNREF3TURBd01EQXdNREVLQ1dOaGJHeHpkV0lnS25CeWIyTmxjM05mYzNSaGRHbGpYM1IxY0d4bFgyVnNaVzFsYm5RS0NYQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdNREF3TURBd01ESUtDV05oYkd4emRXSWdLbkJ5YjJObGMzTmZjM1JoZEdsalgzUjFjR3hsWDJWc1pXMWxiblFLQ1hCMWMyaGllWFJsY3lBd2VEQXdNREF3TURBd01EQXdNREF3TURNS0NXTmhiR3h6ZFdJZ0tuQnliMk5sYzNOZmMzUmhkR2xqWDNSMWNHeGxYMlZzWlcxbGJuUUtDWEIxYzJoaWVYUmxjeUF3ZURBd0NnbHBiblJqSURBZ0x5OGdNQW9KWkhWd0NnbHpaWFJpYVhRS0NXTmhiR3h6ZFdJZ0tuQnliMk5sYzNOZmMzUmhkR2xqWDNSMWNHeGxYMlZzWlcxbGJuUUtDWEJ2Y0NBdkx5QndiM0FnYUdWaFpDQnZabVp6WlhRS0NXTnZibU5oZENBdkx5QmpiMjVqWVhRZ2FHVmhaQ0JoYm1RZ2RHRnBiQW9KWm5KaGJXVmZZblZ5ZVNBd0lDOHZJRzg2SUZReE1Bb0tDUzh2SUhSbGMzUnpMMk52Ym5SeVlXTjBjeTloWW1rdVlXeG5ieTUwY3pveE56RXhDZ2t2THlCeVpYUjFjbTRnYnpzS0NXWnlZVzFsWDJScFp5QXdJQzh2SUc4NklGUXhNQW9LQ1M4dklITmxkQ0IwYUdVZ2MzVmljbTkxZEdsdVpTQnlaWFIxY200Z2RtRnNkV1VLQ1daeVlXMWxYMkoxY25rZ01Bb0pjbVYwYzNWaUNnb3FZV0pwWDNKdmRYUmxYMk55WldGMFpVRndjR3hwWTJGMGFXOXVPZ29KYVc1MFl5QXhJQzh2SURFS0NYSmxkSFZ5YmdvS0ttTnlaV0YwWlY5T2IwOXdPZ29KY0hWemFHSjVkR1Z6SURCNFlqZzBORGRpTXpZZ0x5OGdiV1YwYUc5a0lDSmpjbVZoZEdWQmNIQnNhV05oZEdsdmJpZ3BkbTlwWkNJS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLQ1cxaGRHTm9JQ3BoWW1sZmNtOTFkR1ZmWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRLQ2drdkx5QjBhR2x6SUdOdmJuUnlZV04wSUdSdlpYTWdibTkwSUdsdGNHeGxiV1Z1ZENCMGFHVWdaMmwyWlc0Z1FVSkpJRzFsZEdodlpDQm1iM0lnWTNKbFlYUmxJRTV2VDNBS0NXVnljZ29LS21OaGJHeGZUbTlQY0RvS0NYQjFjMmhpZVhSbGN5QXdlR00wT1dOaU9XRTNJQzh2SUcxbGRHaHZaQ0FpYm1WemRHVmtRWEp5WVhsQmJHOXVaM05wWkdWQ2IyOXNaV0Z1S0Nrb1lubDBaVnMwWFZ0ZExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMR0p2YjJ3cElnb0pkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvSmJXRjBZMmdnS21GaWFWOXliM1YwWlY5dVpYTjBaV1JCY25KaGVVRnNiMjVuYzJsa1pVSnZiMnhsWVc0S0Nna3ZMeUIwYUdseklHTnZiblJ5WVdOMElHUnZaWE1nYm05MElHbHRjR3hsYldWdWRDQjBhR1VnWjJsMlpXNGdRVUpKSUcxbGRHaHZaQ0JtYjNJZ1kyRnNiQ0JPYjA5d0NnbGxjbklLQ2lwd2NtOWpaWE56WDNOMFlYUnBZMTkwZFhCc1pWOWxiR1Z0Wlc1ME9nb0pjSEp2ZEc4Z05DQXpDZ2xtY21GdFpWOWthV2NnTFRRZ0x5OGdkSFZ3YkdVZ2FHVmhaQW9KWm5KaGJXVmZaR2xuSUMweElDOHZJR1ZzWlcxbGJuUUtDV052Ym1OaGRBb0pabkpoYldWZlpHbG5JQzB6SUM4dklIUjFjR3hsSUhSaGFXd0tDV1p5WVcxbFgyUnBaeUF0TWlBdkx5Qm9aV0ZrSUc5bVpuTmxkQW9KY21WMGMzVmlDZ29xY0hKdlkyVnpjMTlrZVc1aGJXbGpYM1IxY0d4bFgyVnNaVzFsYm5RNkNnbHdjbTkwYnlBMElETUtDV1p5WVcxbFgyUnBaeUF0TkNBdkx5QjBkWEJzWlNCb1pXRmtDZ2xtY21GdFpWOWthV2NnTFRJZ0x5OGdhR1ZoWkNCdlptWnpaWFFLQ1dOdmJtTmhkQW9KWm5KaGJXVmZZblZ5ZVNBdE5DQXZMeUIwZFhCc1pTQm9aV0ZrQ2dsbWNtRnRaVjlrYVdjZ0xURWdMeThnWld4bGJXVnVkQW9KWkhWd0NnbHNaVzRLQ1daeVlXMWxYMlJwWnlBdE1pQXZMeUJvWldGa0lHOW1abk5sZEFvSlluUnZhUW9KS3dvSmFYUnZZZ29KWlhoMGNtRmpkQ0EySURJS0NXWnlZVzFsWDJKMWNua2dMVElnTHk4Z2FHVmhaQ0J2Wm1aelpYUUtDV1p5WVcxbFgyUnBaeUF0TXlBdkx5QjBkWEJzWlNCMFlXbHNDZ2x6ZDJGd0NnbGpiMjVqWVhRS0NXWnlZVzFsWDJKMWNua2dMVE1nTHk4Z2RIVndiR1VnZEdGcGJBb0pabkpoYldWZlpHbG5JQzAwSUM4dklIUjFjR3hsSUdobFlXUUtDV1p5WVcxbFgyUnBaeUF0TXlBdkx5QjBkWEJzWlNCMFlXbHNDZ2xtY21GdFpWOWthV2NnTFRJZ0x5OGdhR1ZoWkNCdlptWnpaWFFLQ1hKbGRITjFZZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXcifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFDQUFFbUFRQXhHQlNCQmdzeEdRaU5EQUJ3QUFBQUFBQUFBQUFBQUFCaUFBQUFBQUFBQUFBQUFBQ0FCQlVmZkhXSUFBUlFzQ05EaWdBQktDZ29nQUlBRzRBS0FBSmhZbU5rWldabmFJZ0FaSUFJQUFBQUFBQUFBQUdJQUVxQUNBQUFBQUFBQUFBQ2lBQTlnQWdBQUFBQUFBQUFBNGdBTUlBQkFDSkpWSWdBSjBoUWpBQ0xBSXdBaVNORGdBUzRSSHMyTmhvQWpnSC84UUNBQk1TY3VhYzJHZ0NPQWYrRUFJb0VBNHY4aS85UWkvMkwvb21LQkFPTC9JditVSXo4aS85SkZZditGd2dXVndZQ2pQNkwvVXhRalAyTC9JdjlpLzZKIiwiY2xlYXIiOiJDZz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6ImFsZ29kIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6NCwicGF0Y2giOjEsImNvbW1pdEhhc2giOiI3YjYwN2NlNCJ9fSwiZXZlbnRzIjpudWxsLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
