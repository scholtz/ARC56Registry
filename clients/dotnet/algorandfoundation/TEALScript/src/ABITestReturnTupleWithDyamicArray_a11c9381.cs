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

namespace Arc56.Generated.algorandfoundation.TEALScript.ABITestReturnTupleWithDyamicArray_a11c9381
{


    public class ABITestReturnTupleWithDyamicArrayProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ABITestReturnTupleWithDyamicArrayProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ReturnTupleWithDyamicArrayReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ushort Field1 { get; set; }

                public ulong[] Field2 { get; set; }

                public ushort[] Field3 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16[]");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ReturnTupleWithDyamicArrayReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ReturnTupleWithDyamicArrayReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ushort vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong[] vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16[]");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is ushort[] vField3Value) { ret.Field3 = vField3Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ReturnTupleWithDyamicArrayReturn);
                }
                public bool Equals(ReturnTupleWithDyamicArrayReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ReturnTupleWithDyamicArrayReturn left, ReturnTupleWithDyamicArrayReturn right)
                {
                    return EqualityComparer<ReturnTupleWithDyamicArrayReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(ReturnTupleWithDyamicArrayReturn left, ReturnTupleWithDyamicArrayReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.ReturnTupleWithDyamicArrayReturn> ReturnTupleWithDyamicArray(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 136, 166, 156, 92 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ReturnTupleWithDyamicArrayReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ReturnTupleWithDyamicArray_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 136, 166, 156, 92 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJBQklUZXN0UmV0dXJuVHVwbGVXaXRoRHlhbWljQXJyYXkiLCJkZXNjIjoiIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IlJldHVyblR1cGxlV2l0aER5YW1pY0FycmF5UmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50MTYifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDY0W10ifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoidWludDE2W10ifV19LCJNZXRob2RzIjpbeyJuYW1lIjoicmV0dXJuVHVwbGVXaXRoRHlhbWljQXJyYXkiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50MTYsdWludDY0W10sdWludDE2W10pIiwic3RydWN0IjoiUmV0dXJuVHVwbGVXaXRoRHlhbWljQXJyYXlSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiY3JlYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM4OCJ9LHsicGMiOlsxLDIsM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM4OCJ9LHsicGMiOls0LDUsNl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM4OCJ9LHsicGMiOls3LDhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6Mzg4In0seyJwYyI6WzldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6Mzg4In0seyJwYyI6WzEwLDExXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM4OCJ9LHsicGMiOlsxMl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozODgifSx7InBjIjpbMTMsMTRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6Mzg4In0seyJwYyI6WzE1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyMCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM4OCJ9LHsicGMiOlsxNiwxNywxOCwxOSwyMCwyMSwyMiwyMywyNCwyNSwyNiwyNywyOCwyOSwzMCwzMSwzMiwzMywzNCwzNSwzNiwzNywzOCwzOSw0MCw0MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozODgifSx7InBjIjpbNDJdLCJlcnJvck1lc3NhZ2UiOiJUaGUgcmVxdWVzdGVkIGFjdGlvbiBpcyBub3QgaW1wbGVtZW50ZWQgaW4gdGhpcyBjb250cmFjdC4gQXJlIHlvdSB1c2luZyB0aGUgY29ycmVjdCBPbkNvbXBsZXRlPyBEaWQgeW91IHNldCB5b3VyIGFwcCBJRD8iLCJ0ZWFsIjoyNSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM4OCJ9LHsicGMiOls0Myw0NCw0NSw0Niw0Nyw0OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozODkifSx7InBjIjpbNDksNTAsNTFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6Mzg5In0seyJwYyI6WzUyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM4OSJ9LHsicGMiOls1M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozODkifSx7InBjIjpbNTRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6Mzg5In0seyJwYyI6WzU1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM4OSJ9LHsicGMiOls1Niw1Nyw1OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozODkifSx7InBjIjpbNTldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQ0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6Mzg5In0seyJwYyI6WzYwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0OCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM5MCJ9LHsicGMiOls2MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozOTAifSx7InBjIjpbNjIsNjMsNjQsNjVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjUwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MzkwIn0seyJwYyI6WzY2LDY3LDY4LDY5LDcwLDcxLDcyLDczLDc0LDc1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM5MCJ9LHsicGMiOls3Niw3Nyw3OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozOTAifSx7InBjIjpbNzksODAsODEsODJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjUzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MzkwIn0seyJwYyI6WzgzLDg0LDg1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM5MCJ9LHsicGMiOls4Niw4Nyw4OCw4OSw5MCw5MSw5Miw5Myw5NCw5NSw5Niw5Nyw5OCw5OSwxMDAsMTAxLDEwMiwxMDMsMTA0LDEwNV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozOTAifSx7InBjIjpbMTA2LDEwNywxMDhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MzkwIn0seyJwYyI6WzEwOSwxMTAsMTExLDExMiwxMTMsMTE0LDExNSwxMTZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MzkwIn0seyJwYyI6WzExNywxMTgsMTE5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1OCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM5MCJ9LHsicGMiOlsxMjBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MzkwIn0seyJwYyI6WzEyMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozOTAifSx7InBjIjpbMTIyLDEyM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozOTAifSx7InBjIjpbMTI0LDEyNV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozOTIifSx7InBjIjpbMTI2LDEyN10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozODkifSx7InBjIjpbMTI4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2OSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM4OSJ9LHsicGMiOlsxMjldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjcyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6Mzg4In0seyJwYyI6WzEzMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozODgifSx7InBjIjpbMTMxLDEzMiwxMzMsMTM0LDEzNSwxMzZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjc2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6Mzg4In0seyJwYyI6WzEzNywxMzgsMTM5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3Nywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM4OCJ9LHsicGMiOlsxNDAsMTQxLDE0MiwxNDNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjc4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6Mzg4In0seyJwYyI6WzE0NF0sImVycm9yTWVzc2FnZSI6InRoaXMgY29udHJhY3QgZG9lcyBub3QgaW1wbGVtZW50IHRoZSBnaXZlbiBBQkkgbWV0aG9kIGZvciBjcmVhdGUgTm9PcCIsInRlYWwiOjgxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6Mzg4In0seyJwYyI6WzE0NSwxNDYsMTQ3LDE0OCwxNDksMTUwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM4OCJ9LHsicGMiOlsxNTEsMTUyLDE1M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozODgifSx7InBjIjpbMTU0LDE1NSwxNTYsMTU3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM4OCJ9LHsicGMiOlsxNThdLCJlcnJvck1lc3NhZ2UiOiJ0aGlzIGNvbnRyYWN0IGRvZXMgbm90IGltcGxlbWVudCB0aGUgZ2l2ZW4gQUJJIG1ldGhvZCBmb3IgY2FsbCBOb09wIiwidGVhbCI6ODksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozODgifSx7InBjIjpbMTU5LDE2MCwxNjFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjkyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6Mzg4In0seyJwYyI6WzE2MiwxNjNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjkzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6Mzg4In0seyJwYyI6WzE2NCwxNjVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjk0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6Mzg4In0seyJwYyI6WzE2Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozODgifSx7InBjIjpbMTY3LDE2OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozODgifSx7InBjIjpbMTY5LDE3MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozODgifSx7InBjIjpbMTcxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo5OCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM4OCJ9LHsicGMiOlsxNzIsMTczLDE3NF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTAxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6Mzg4In0seyJwYyI6WzE3NSwxNzZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwMiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM4OCJ9LHsicGMiOlsxNzcsMTc4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozODgifSx7InBjIjpbMTc5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozODgifSx7InBjIjpbMTgwLDE4MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTA1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6Mzg4In0seyJwYyI6WzE4MiwxODNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwNiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM4OCJ9LHsicGMiOlsxODRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwNywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM4OCJ9LHsicGMiOlsxODVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwOCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM4OCJ9LHsicGMiOlsxODYsMTg3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozODgifSx7InBjIjpbMTg4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMTAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozODgifSx7InBjIjpbMTg5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMTEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozODgifSx7InBjIjpbMTkwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMTIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozODgifSx7InBjIjpbMTkxLDE5MiwxOTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjExMywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM4OCJ9LHsicGMiOlsxOTQsMTk1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMTQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozODgifSx7InBjIjpbMTk2LDE5N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTE1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6Mzg4In0seyJwYyI6WzE5OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTE2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6Mzg4In0seyJwYyI6WzE5OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTE3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6Mzg4In0seyJwYyI6WzIwMCwyMDFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjExOCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM4OCJ9LHsicGMiOlsyMDIsMjAzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMTksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozODgifSx7InBjIjpbMjA0LDIwNV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTIwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6Mzg4In0seyJwYyI6WzIwNiwyMDddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyMSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM4OCJ9LHsicGMiOlsyMDhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyMiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM4OCJ9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NtbHVkR05pYkc5amF5QXhDbUo1ZEdWallteHZZMnNnTUhnS0NpOHZJRlJvYVhNZ1ZFVkJUQ0IzWVhNZ1oyVnVaWEpoZEdWa0lHSjVJRlJGUVV4VFkzSnBjSFFnZGpBdU1UQTNMaklLTHk4Z2FIUjBjSE02THk5bmFYUm9kV0l1WTI5dEwyRnNaMjl5WVc1a1ptOTFibVJoZEdsdmJpOVVSVUZNVTJOeWFYQjBDZ292THlCVWFHbHpJR052Ym5SeVlXTjBJR2x6SUdOdmJYQnNhV0Z1ZENCM2FYUm9JR0Z1WkM5dmNpQnBiWEJzWlcxbGJuUnpJSFJvWlNCbWIyeHNiM2RwYm1jZ1FWSkRjem9nV3lCQlVrTTBJRjBLQ2k4dklGUm9aU0JtYjJ4c2IzZHBibWNnZEdWdUlHeHBibVZ6SUc5bUlGUkZRVXdnYUdGdVpHeGxJR2x1YVhScFlXd2djSEp2WjNKaGJTQm1iRzkzQ2k4dklGUm9hWE1nY0dGMGRHVnliaUJwY3lCMWMyVmtJSFJ2SUcxaGEyVWdhWFFnWldGemVTQm1iM0lnWVc1NWIyNWxJSFJ2SUhCaGNuTmxJSFJvWlNCemRHRnlkQ0J2WmlCMGFHVWdjSEp2WjNKaGJTQmhibVFnWkdWMFpYSnRhVzVsSUdsbUlHRWdjM0JsWTJsbWFXTWdZV04wYVc5dUlHbHpJR0ZzYkc5M1pXUUtMeThnU0dWeVpTd2dZV04wYVc5dUlISmxabVZ5Y3lCMGJ5QjBhR1VnVDI1RGIyMXdiR1YwWlNCcGJpQmpiMjFpYVc1aGRHbHZiaUIzYVhSb0lIZG9aWFJvWlhJZ2RHaGxJR0Z3Y0NCcGN5QmlaV2x1WnlCamNtVmhkR1ZrSUc5eUlHTmhiR3hsWkFvdkx5QkZkbVZ5ZVNCd2IzTnphV0pzWlNCaFkzUnBiMjRnWm05eUlIUm9hWE1nWTI5dWRISmhZM1FnYVhNZ2NtVndjbVZ6Wlc1MFpXUWdhVzRnZEdobElITjNhWFJqYUNCemRHRjBaVzFsYm5RS0x5OGdTV1lnZEdobElHRmpkR2x2YmlCcGN5QnViM1FnYVcxd2JHVnRaVzUwWldRZ2FXNGdkR2hsSUdOdmJuUnlZV04wTENCcGRITWdjbVZ6Y0dWamRHbDJaU0JpY21GdVkyZ2dkMmxzYkNCaVpTQWlLazVQVkY5SlRWQk1SVTFGVGxSRlJDSWdkMmhwWTJnZ2FuVnpkQ0JqYjI1MFlXbHVjeUFpWlhKeUlncDBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2hDbkIxYzJocGJuUWdOZ29xQ25SNGJpQlBia052YlhCc1pYUnBiMjRLS3dwemQybDBZMmdnS21OaGJHeGZUbTlQY0NBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLbU55WldGMFpWOU9iMDl3SUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJBb0tLazVQVkY5SlRWQk1SVTFGVGxSRlJEb0tDUzh2SUZSb1pTQnlaWEYxWlhOMFpXUWdZV04wYVc5dUlHbHpJRzV2ZENCcGJYQnNaVzFsYm5SbFpDQnBiaUIwYUdseklHTnZiblJ5WVdOMExpQkJjbVVnZVc5MUlIVnphVzVuSUhSb1pTQmpiM0p5WldOMElFOXVRMjl0Y0d4bGRHVS9JRVJwWkNCNWIzVWdjMlYwSUhsdmRYSWdZWEJ3SUVsRVB3b0paWEp5Q2dvdkx5QnlaWFIxY201VWRYQnNaVmRwZEdoRWVXRnRhV05CY25KaGVTZ3BLSFZwYm5RMk5DeDFhVzUwTVRZc2RXbHVkRFkwVzEwc2RXbHVkREUyVzEwcENpcGhZbWxmY205MWRHVmZjbVYwZFhKdVZIVndiR1ZYYVhSb1JIbGhiV2xqUVhKeVlYazZDZ2t2THlCVWFHVWdRVUpKSUhKbGRIVnliaUJ3Y21WbWFYZ0tDWEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxQ2dvSkx5OGdaWGhsWTNWMFpTQnlaWFIxY201VWRYQnNaVmRwZEdoRWVXRnRhV05CY25KaGVTZ3BLSFZwYm5RMk5DeDFhVzUwTVRZc2RXbHVkRFkwVzEwc2RXbHVkREUyVzEwcENnbGpZV3hzYzNWaUlISmxkSFZ5YmxSMWNHeGxWMmwwYUVSNVlXMXBZMEZ5Y21GNUNnbGpiMjVqWVhRS0NXeHZad29KYVc1MFl5QXdJQzh2SURFS0NYSmxkSFZ5YmdvS0x5OGdjbVYwZFhKdVZIVndiR1ZYYVhSb1JIbGhiV2xqUVhKeVlYa29LVG9nVzNWcGJuUTJOQ3dnZFdsdWRERTJMQ0IxYVc1ME5qUmJYU3dnZFdsdWRERTJXMTFkQ25KbGRIVnlibFIxY0d4bFYybDBhRVI1WVcxcFkwRnljbUY1T2dvSmNISnZkRzhnTUNBeENnb0pMeThnVUhWemFDQmxiWEIwZVNCaWVYUmxjeUJoWm5SbGNpQjBhR1VnWm5KaGJXVWdjRzlwYm5SbGNpQjBieUJ5WlhObGNuWmxJSE53WVdObElHWnZjaUJzYjJOaGJDQjJZWEpwWVdKc1pYTUtDV0o1ZEdWaklEQWdMeThnTUhnS0Nna3ZMeUIwWlhOMGN5OWpiMjUwY21GamRITXZZV0pwTG1Gc1oyOHVkSE02TXprd0Nna3ZMeUJoT2lCYmRXbHVkRFkwTENCMWFXNTBNVFlzSUhWcGJuUTJORnRkTENCMWFXNTBNVFpiWFYwZ1BTQmJNU3dnTWl3Z1d6TXNJRFJkTENCYk5Td2dObDFkQ2dsaWVYUmxZeUF3SUM4dklDQnBibWwwYVdGc0lHaGxZV1FLQ1dKNWRHVmpJREFnTHk4Z0lHbHVhWFJwWVd3Z2RHRnBiQW9KY0hWemFHSjVkR1Z6SURCNE1EQXdaU0F2THlCcGJtbDBhV0ZzSUdobFlXUWdiMlptYzJWMENnbHdkWE5vWW5sMFpYTWdNSGd3TURBd01EQXdNREF3TURBd01EQXhDZ2xqWVd4c2MzVmlJQ3B3Y205alpYTnpYM04wWVhScFkxOTBkWEJzWlY5bGJHVnRaVzUwQ2dsd2RYTm9ZbmwwWlhNZ01IZ3dNREF5Q2dsallXeHNjM1ZpSUNwd2NtOWpaWE56WDNOMFlYUnBZMTkwZFhCc1pWOWxiR1Z0Wlc1MENnbHdkWE5vWW5sMFpYTWdNSGd3TURBeU1EQXdNREF3TURBd01EQXdNREF3TXpBd01EQXdNREF3TURBd01EQXdNRFFLQ1dOaGJHeHpkV0lnS25CeWIyTmxjM05mWkhsdVlXMXBZMTkwZFhCc1pWOWxiR1Z0Wlc1MENnbHdkWE5vWW5sMFpYTWdNSGd3TURBeU1EQXdOVEF3TURZS0NXTmhiR3h6ZFdJZ0tuQnliMk5sYzNOZlpIbHVZVzFwWTE5MGRYQnNaVjlsYkdWdFpXNTBDZ2x3YjNBZ0x5OGdjRzl3SUdobFlXUWdiMlptYzJWMENnbGpiMjVqWVhRZ0x5OGdZMjl1WTJGMElHaGxZV1FnWVc1a0lIUmhhV3dLQ1daeVlXMWxYMkoxY25rZ01DQXZMeUJoT2lCYmRXbHVkRFkwTENCMWFXNTBNVFlzSUhWcGJuUTJORnRkTENCMWFXNTBNVFpiWFYwS0Nna3ZMeUIwWlhOMGN5OWpiMjUwY21GamRITXZZV0pwTG1Gc1oyOHVkSE02TXpreUNna3ZMeUJ5WlhSMWNtNGdZVHNLQ1daeVlXMWxYMlJwWnlBd0lDOHZJR0U2SUZ0MWFXNTBOalFzSUhWcGJuUXhOaXdnZFdsdWREWTBXMTBzSUhWcGJuUXhObHRkWFFvS0NTOHZJSE5sZENCMGFHVWdjM1ZpY205MWRHbHVaU0J5WlhSMWNtNGdkbUZzZFdVS0NXWnlZVzFsWDJKMWNua2dNQW9KY21WMGMzVmlDZ29xWVdKcFgzSnZkWFJsWDJOeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1T2dvSmFXNTBZeUF3SUM4dklERUtDWEpsZEhWeWJnb0tLbU55WldGMFpWOU9iMDl3T2dvSmNIVnphR0o1ZEdWeklEQjRZamcwTkRkaU16WWdMeThnYldWMGFHOWtJQ0pqY21WaGRHVkJjSEJzYVdOaGRHbHZiaWdwZG05cFpDSUtDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0NXMWhkR05vSUNwaFltbGZjbTkxZEdWZlkzSmxZWFJsUVhCd2JHbGpZWFJwYjI0S0Nna3ZMeUIwYUdseklHTnZiblJ5WVdOMElHUnZaWE1nYm05MElHbHRjR3hsYldWdWRDQjBhR1VnWjJsMlpXNGdRVUpKSUcxbGRHaHZaQ0JtYjNJZ1kzSmxZWFJsSUU1dlQzQUtDV1Z5Y2dvS0ttTmhiR3hmVG05UGNEb0tDWEIxYzJoaWVYUmxjeUF3ZURnNFlUWTVZelZqSUM4dklHMWxkR2h2WkNBaWNtVjBkWEp1VkhWd2JHVlhhWFJvUkhsaGJXbGpRWEp5WVhrb0tTaDFhVzUwTmpRc2RXbHVkREUyTEhWcGJuUTJORnRkTEhWcGJuUXhObHRkS1NJS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLQ1cxaGRHTm9JQ3BoWW1sZmNtOTFkR1ZmY21WMGRYSnVWSFZ3YkdWWGFYUm9SSGxoYldsalFYSnlZWGtLQ2drdkx5QjBhR2x6SUdOdmJuUnlZV04wSUdSdlpYTWdibTkwSUdsdGNHeGxiV1Z1ZENCMGFHVWdaMmwyWlc0Z1FVSkpJRzFsZEdodlpDQm1iM0lnWTJGc2JDQk9iMDl3Q2dsbGNuSUtDaXB3Y205alpYTnpYM04wWVhScFkxOTBkWEJzWlY5bGJHVnRaVzUwT2dvSmNISnZkRzhnTkNBekNnbG1jbUZ0WlY5a2FXY2dMVFFnTHk4Z2RIVndiR1VnYUdWaFpBb0pabkpoYldWZlpHbG5JQzB4SUM4dklHVnNaVzFsYm5RS0NXTnZibU5oZEFvSlpuSmhiV1ZmWkdsbklDMHpJQzh2SUhSMWNHeGxJSFJoYVd3S0NXWnlZVzFsWDJScFp5QXRNaUF2THlCb1pXRmtJRzltWm5ObGRBb0pjbVYwYzNWaUNnb3FjSEp2WTJWemMxOWtlVzVoYldsalgzUjFjR3hsWDJWc1pXMWxiblE2Q2dsd2NtOTBieUEwSURNS0NXWnlZVzFsWDJScFp5QXROQ0F2THlCMGRYQnNaU0JvWldGa0NnbG1jbUZ0WlY5a2FXY2dMVElnTHk4Z2FHVmhaQ0J2Wm1aelpYUUtDV052Ym1OaGRBb0pabkpoYldWZlluVnllU0F0TkNBdkx5QjBkWEJzWlNCb1pXRmtDZ2xtY21GdFpWOWthV2NnTFRFZ0x5OGdaV3hsYldWdWRBb0paSFZ3Q2dsc1pXNEtDV1p5WVcxbFgyUnBaeUF0TWlBdkx5Qm9aV0ZrSUc5bVpuTmxkQW9KWW5SdmFRb0pLd29KYVhSdllnb0paWGgwY21GamRDQTJJRElLQ1daeVlXMWxYMkoxY25rZ0xUSWdMeThnYUdWaFpDQnZabVp6WlhRS0NXWnlZVzFsWDJScFp5QXRNeUF2THlCMGRYQnNaU0IwWVdsc0NnbHpkMkZ3Q2dsamIyNWpZWFFLQ1daeVlXMWxYMkoxY25rZ0xUTWdMeThnZEhWd2JHVWdkR0ZwYkFvSlpuSmhiV1ZmWkdsbklDMDBJQzh2SUhSMWNHeGxJR2hsWVdRS0NXWnlZVzFsWDJScFp5QXRNeUF2THlCMGRYQnNaU0IwWVdsc0NnbG1jbUZ0WlY5a2FXY2dMVElnTHk4Z2FHVmhaQ0J2Wm1aelpYUUtDWEpsZEhOMVlnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFdyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUJBU1lCQURFWUZJRUdDekVaQ0kwTUFHY0FBQUFBQUFBQUFBQUFBRmtBQUFBQUFBQUFBQUFBQUlBRUZSOThkWWdBQkZDd0lrT0tBQUVvS0NpQUFnQU9nQWdBQUFBQUFBQUFBWWdBVUlBQ0FBS0lBRW1BRWdBQ0FBQUFBQUFBQUFNQUFBQUFBQUFBQklnQVA0QUdBQUlBQlFBR2lBQTBTRkNNQUlzQWpBQ0pJa09BQkxoRWV6WTJHZ0NPQWYveEFJQUVpS2FjWERZYUFJNEIvNDBBaWdRRGkveUwvMUNML1l2K2lZb0VBNHY4aS81UWpQeUwvMGtWaS80WENCWlhCZ0tNL292OVRGQ00vWXY4aS8yTC9vaz0iLCJjbGVhciI6IkNnPT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoiYWxnb2QiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo0LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6IjdiNjA3Y2U0In19LCJldmVudHMiOm51bGwsInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
