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

namespace Arc56.Generated.algorandfoundation.TEALScript.ABITestBoolTuple_12422180
{


    public class ABITestBoolTupleProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ABITestBoolTupleProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class BoolTupleReturn : AVMObjectType
            {
                public bool Field0 { get; set; }

                public bool Field1 { get; set; }

                public bool Field2 { get; set; }

                public bool Field3 { get; set; }

                public bool Field4 { get; set; }

                public bool Field5 { get; set; }

                public bool Field6 { get; set; }

                public bool Field7 { get; set; }

                public bool Field8 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField4.From(Field4);
                    ret.AddRange(vField4.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField5.From(Field5);
                    ret.AddRange(vField5.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField6.From(Field6);
                    ret.AddRange(vField6.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField7 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField7.From(Field7);
                    ret.AddRange(vField7.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField8 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField8.From(Field8);
                    ret.AddRange(vField8.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static BoolTupleReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new BoolTupleReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is bool vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is bool vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is bool vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is bool vField3Value) { ret.Field3 = vField3Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is bool vField4Value) { ret.Field4 = vField4Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField5.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField5 = vField5.ToValue();
                    if (valueField5 is bool vField5Value) { ret.Field5 = vField5Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField6.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField6 = vField6.ToValue();
                    if (valueField6 is bool vField6Value) { ret.Field6 = vField6Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField7 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField7.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField7 = vField7.ToValue();
                    if (valueField7 is bool vField7Value) { ret.Field7 = vField7Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField8 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField8.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField8 = vField8.ToValue();
                    if (valueField8 is bool vField8Value) { ret.Field8 = vField8Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as BoolTupleReturn);
                }
                public bool Equals(BoolTupleReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(BoolTupleReturn left, BoolTupleReturn right)
                {
                    return EqualityComparer<BoolTupleReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(BoolTupleReturn left, BoolTupleReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.BoolTupleReturn> BoolTuple(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 89, 58, 254 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.BoolTupleReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> BoolTuple_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 89, 58, 254 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJBQklUZXN0Qm9vbFR1cGxlIiwiZGVzYyI6IiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJCb29sVHVwbGVSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImZpZWxkNCIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiZmllbGQ1IiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJmaWVsZDYiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImZpZWxkNyIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiZmllbGQ4IiwidHlwZSI6ImJvb2wifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiYm9vbFR1cGxlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iihib29sLGJvb2wsYm9vbCxib29sLGJvb2wsYm9vbCxib29sLGJvb2wsYm9vbCkiLCJzdHJ1Y3QiOiJCb29sVHVwbGVSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiY3JlYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg3NyJ9LHsicGMiOlsxLDIsMyw0LDVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4NzcifSx7InBjIjpbNiw3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg3NyJ9LHsicGMiOls4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg3NyJ9LHsicGMiOls5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg3NyJ9LHsicGMiOlsxMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4NzcifSx7InBjIjpbMTEsMTJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODc3In0seyJwYyI6WzEzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxOSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg3NyJ9LHsicGMiOlsxNCwxNSwxNiwxNywxOCwxOSwyMCwyMSwyMiwyMywyNCwyNSwyNiwyNywyOCwyOSwzMCwzMSwzMiwzMywzNCwzNSwzNiwzNywzOCwzOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4NzcifSx7InBjIjpbNDBdLCJlcnJvck1lc3NhZ2UiOiJUaGUgcmVxdWVzdGVkIGFjdGlvbiBpcyBub3QgaW1wbGVtZW50ZWQgaW4gdGhpcyBjb250cmFjdC4gQXJlIHlvdSB1c2luZyB0aGUgY29ycmVjdCBPbkNvbXBsZXRlPyBEaWQgeW91IHNldCB5b3VyIGFwcCBJRD8iLCJ0ZWFsIjoyNCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg3NyJ9LHsicGMiOls0MSw0Miw0Myw0NCw0NSw0Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4NzgifSx7InBjIjpbNDcsNDgsNDldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODc4In0seyJwYyI6WzUwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg3OCJ9LHsicGMiOls1MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4NzgifSx7InBjIjpbNTJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODc4In0seyJwYyI6WzUzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg3OCJ9LHsicGMiOls1NCw1NSw1Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4NzgifSx7InBjIjpbNTcsNThdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODc4In0seyJwYyI6WzU5LDYwLDYxLDYyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1Nywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg4MCJ9LHsicGMiOls2M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4ODAifSx7InBjIjpbNjRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODgwIn0seyJwYyI6WzY1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2MCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg4MCJ9LHsicGMiOls2Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4ODEifSx7InBjIjpbNjddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjYyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODgxIn0seyJwYyI6WzY4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg4MSJ9LHsicGMiOls2OSw3MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4ODIifSx7InBjIjpbNzFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODgyIn0seyJwYyI6WzcyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg4MiJ9LHsicGMiOls3Myw3NF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4ODMifSx7InBjIjpbNzVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODgzIn0seyJwYyI6Wzc2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2OSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg4MyJ9LHsicGMiOls3Nyw3OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4ODQifSx7InBjIjpbNzldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjcxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODg0In0seyJwYyI6WzgwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg4NCJ9LHsicGMiOls4MSw4Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4ODUifSx7InBjIjpbODNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjc0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODg1In0seyJwYyI6Wzg0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3NSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg4NSJ9LHsicGMiOls4NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4ODYifSx7InBjIjpbODZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjc3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODg2In0seyJwYyI6Wzg3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3OCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg4NiJ9LHsicGMiOls4OCw4OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4ODcifSx7InBjIjpbOTBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjgwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODg3In0seyJwYyI6WzkxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg4NyJ9LHsicGMiOls5Miw5M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4ODgifSx7InBjIjpbOTRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjgzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODg4In0seyJwYyI6Wzk1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg4OCJ9LHsicGMiOls5Niw5N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4NzkifSx7InBjIjpbOTgsOTldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjg5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODkxIn0seyJwYyI6WzEwMCwxMDFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjkyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODc4In0seyJwYyI6WzEwMl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4NzgifSx7InBjIjpbMTAzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo5Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg3NyJ9LHsicGMiOlsxMDRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjk3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODc3In0seyJwYyI6WzEwNSwxMDYsMTA3LDEwOCwxMDksMTEwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4NzcifSx7InBjIjpbMTExLDExMiwxMTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwMSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg3NyJ9LHsicGMiOlsxMTQsMTE1LDExNiwxMTddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwMiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg3NyJ9LHsicGMiOlsxMThdLCJlcnJvck1lc3NhZ2UiOiJ0aGlzIGNvbnRyYWN0IGRvZXMgbm90IGltcGxlbWVudCB0aGUgZ2l2ZW4gQUJJIG1ldGhvZCBmb3IgY3JlYXRlIE5vT3AiLCJ0ZWFsIjoxMDUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4NzcifSx7InBjIjpbMTE5LDEyMCwxMjEsMTIyLDEyMywxMjRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwOCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg3NyJ9LHsicGMiOlsxMjUsMTI2LDEyN10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTA5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODc3In0seyJwYyI6WzEyOCwxMjksMTMwLDEzMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTEwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODc3In0seyJwYyI6WzEzMl0sImVycm9yTWVzc2FnZSI6InRoaXMgY29udHJhY3QgZG9lcyBub3QgaW1wbGVtZW50IHRoZSBnaXZlbiBBQkkgbWV0aG9kIGZvciBjYWxsIE5vT3AiLCJ0ZWFsIjoxMTMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4NzcifV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDbWx1ZEdOaWJHOWpheUF4SURBZ05nb0tMeThnVkdocGN5QlVSVUZNSUhkaGN5Qm5aVzVsY21GMFpXUWdZbmtnVkVWQlRGTmpjbWx3ZENCMk1DNHhNRGN1TWdvdkx5Qm9kSFJ3Y3pvdkwyZHBkR2gxWWk1amIyMHZZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMVJGUVV4VFkzSnBjSFFLQ2k4dklGUm9hWE1nWTI5dWRISmhZM1FnYVhNZ1kyOXRjR3hwWVc1MElIZHBkR2dnWVc1a0wyOXlJR2x0Y0d4bGJXVnVkSE1nZEdobElHWnZiR3h2ZDJsdVp5QkJVa056T2lCYklFRlNRelFnWFFvS0x5OGdWR2hsSUdadmJHeHZkMmx1WnlCMFpXNGdiR2x1WlhNZ2IyWWdWRVZCVENCb1lXNWtiR1VnYVc1cGRHbGhiQ0J3Y205bmNtRnRJR1pzYjNjS0x5OGdWR2hwY3lCd1lYUjBaWEp1SUdseklIVnpaV1FnZEc4Z2JXRnJaU0JwZENCbFlYTjVJR1p2Y2lCaGJubHZibVVnZEc4Z2NHRnljMlVnZEdobElITjBZWEowSUc5bUlIUm9aU0J3Y205bmNtRnRJR0Z1WkNCa1pYUmxjbTFwYm1VZ2FXWWdZU0J6Y0dWamFXWnBZeUJoWTNScGIyNGdhWE1nWVd4c2IzZGxaQW92THlCSVpYSmxMQ0JoWTNScGIyNGdjbVZtWlhKeklIUnZJSFJvWlNCUGJrTnZiWEJzWlhSbElHbHVJR052YldKcGJtRjBhVzl1SUhkcGRHZ2dkMmhsZEdobGNpQjBhR1VnWVhCd0lHbHpJR0psYVc1bklHTnlaV0YwWldRZ2IzSWdZMkZzYkdWa0NpOHZJRVYyWlhKNUlIQnZjM05wWW14bElHRmpkR2x2YmlCbWIzSWdkR2hwY3lCamIyNTBjbUZqZENCcGN5QnlaWEJ5WlhObGJuUmxaQ0JwYmlCMGFHVWdjM2RwZEdOb0lITjBZWFJsYldWdWRBb3ZMeUJKWmlCMGFHVWdZV04wYVc5dUlHbHpJRzV2ZENCcGJYQnNaVzFsYm5SbFpDQnBiaUIwYUdVZ1kyOXVkSEpoWTNRc0lHbDBjeUJ5WlhOd1pXTjBhWFpsSUdKeVlXNWphQ0IzYVd4c0lHSmxJQ0lxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJaUIzYUdsamFDQnFkWE4wSUdOdmJuUmhhVzV6SUNKbGNuSWlDblI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUVLYVc1MFl5QXlJQzh2SURZS0tncDBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpc0tjM2RwZEdOb0lDcGpZV3hzWDA1dlQzQWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwamNtVmhkR1ZmVG05UGNDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFLQ2lwT1QxUmZTVTFRVEVWTlJVNVVSVVE2Q2drdkx5QlVhR1VnY21WeGRXVnpkR1ZrSUdGamRHbHZiaUJwY3lCdWIzUWdhVzF3YkdWdFpXNTBaV1FnYVc0Z2RHaHBjeUJqYjI1MGNtRmpkQzRnUVhKbElIbHZkU0IxYzJsdVp5QjBhR1VnWTI5eWNtVmpkQ0JQYmtOdmJYQnNaWFJsUHlCRWFXUWdlVzkxSUhObGRDQjViM1Z5SUdGd2NDQkpSRDhLQ1dWeWNnb0tMeThnWW05dmJGUjFjR3hsS0Nrb1ltOXZiQ3hpYjI5c0xHSnZiMndzWW05dmJDeGliMjlzTEdKdmIyd3NZbTl2YkN4aWIyOXNMR0p2YjJ3cENpcGhZbWxmY205MWRHVmZZbTl2YkZSMWNHeGxPZ29KTHk4Z1ZHaGxJRUZDU1NCeVpYUjFjbTRnY0hKbFptbDRDZ2x3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlFvS0NTOHZJR1Y0WldOMWRHVWdZbTl2YkZSMWNHeGxLQ2tvWW05dmJDeGliMjlzTEdKdmIyd3NZbTl2YkN4aWIyOXNMR0p2YjJ3c1ltOXZiQ3hpYjI5c0xHSnZiMndwQ2dsallXeHNjM1ZpSUdKdmIyeFVkWEJzWlFvSlkyOXVZMkYwQ2dsc2IyY0tDV2x1ZEdNZ01DQXZMeUF4Q2dseVpYUjFjbTRLQ2k4dklHSnZiMnhVZFhCc1pTZ3BPaUJiWW05dmJHVmhiaXdnWW05dmJHVmhiaXdnWW05dmJHVmhiaXdnWW05dmJHVmhiaXdnWW05dmJHVmhiaXdnWW05dmJHVmhiaXdnWW05dmJHVmhiaXdnWW05dmJHVmhiaXdnWW05dmJHVmhibDBLWW05dmJGUjFjR3hsT2dvSmNISnZkRzhnTUNBeENnb0pMeThnVUhWemFDQmxiWEIwZVNCaWVYUmxjeUJoWm5SbGNpQjBhR1VnWm5KaGJXVWdjRzlwYm5SbGNpQjBieUJ5WlhObGNuWmxJSE53WVdObElHWnZjaUJzYjJOaGJDQjJZWEpwWVdKc1pYTUtDWEIxYzJoaWVYUmxjeUF3ZUFvS0NTOHZJSFJsYzNSekwyTnZiblJ5WVdOMGN5OWhZbWt1WVd4bmJ5NTBjem80TnprS0NTOHZJR0U2SUZ0aWIyOXNaV0Z1TENCaWIyOXNaV0Z1TENCaWIyOXNaV0Z1TENCaWIyOXNaV0Z1TENCaWIyOXNaV0Z1TENCaWIyOXNaV0Z1TENCaWIyOXNaV0Z1TENCaWIyOXNaV0Z1TENCaWIyOXNaV0Z1WFNBOUlGc0tDUzh2SUNBZ0lDQWdJSFJ5ZFdVc0Nna3ZMeUFnSUNBZ0lDQm1ZV3h6WlN3S0NTOHZJQ0FnSUNBZ0lIUnlkV1VzQ2drdkx5QWdJQ0FnSUNCMGNuVmxMQW9KTHk4Z0lDQWdJQ0FnWm1Gc2MyVXNDZ2t2THlBZ0lDQWdJQ0JtWVd4elpTd0tDUzh2SUNBZ0lDQWdJSFJ5ZFdVc0Nna3ZMeUFnSUNBZ0lDQm1ZV3h6WlN3S0NTOHZJQ0FnSUNBZ0lHWmhiSE5sTEFvSkx5OGdJQ0FnSUYwS0NYQjFjMmhpZVhSbGN5QXdlREF3TURBS0NXbHVkR01nTVNBdkx5QXdDZ2xwYm5SaklEQWdMeThnTVFvSmMyVjBZbWwwQ2dscGJuUmpJREFnTHk4Z01Rb0phVzUwWXlBeElDOHZJREFLQ1hObGRHSnBkQW9KY0hWemFHbHVkQ0F5Q2dscGJuUmpJREFnTHk4Z01Rb0pjMlYwWW1sMENnbHdkWE5vYVc1MElETUtDV2x1ZEdNZ01DQXZMeUF4Q2dselpYUmlhWFFLQ1hCMWMyaHBiblFnTkFvSmFXNTBZeUF4SUM4dklEQUtDWE5sZEdKcGRBb0pjSFZ6YUdsdWRDQTFDZ2xwYm5SaklERWdMeThnTUFvSmMyVjBZbWwwQ2dscGJuUmpJRElnTHk4Z05nb0phVzUwWXlBd0lDOHZJREVLQ1hObGRHSnBkQW9KY0hWemFHbHVkQ0EzQ2dscGJuUmpJREVnTHk4Z01Bb0pjMlYwWW1sMENnbHdkWE5vYVc1MElEZ0tDV2x1ZEdNZ01TQXZMeUF3Q2dselpYUmlhWFFLQ1daeVlXMWxYMkoxY25rZ01DQXZMeUJoT2lCYlltOXZiR1ZoYml3Z1ltOXZiR1ZoYml3Z1ltOXZiR1ZoYml3Z1ltOXZiR1ZoYml3Z1ltOXZiR1ZoYml3Z1ltOXZiR1ZoYml3Z1ltOXZiR1ZoYml3Z1ltOXZiR1ZoYml3Z1ltOXZiR1ZoYmwwS0Nna3ZMeUIwWlhOMGN5OWpiMjUwY21GamRITXZZV0pwTG1Gc1oyOHVkSE02T0RreENna3ZMeUJ5WlhSMWNtNGdZVHNLQ1daeVlXMWxYMlJwWnlBd0lDOHZJR0U2SUZ0aWIyOXNaV0Z1TENCaWIyOXNaV0Z1TENCaWIyOXNaV0Z1TENCaWIyOXNaV0Z1TENCaWIyOXNaV0Z1TENCaWIyOXNaV0Z1TENCaWIyOXNaV0Z1TENCaWIyOXNaV0Z1TENCaWIyOXNaV0Z1WFFvS0NTOHZJSE5sZENCMGFHVWdjM1ZpY205MWRHbHVaU0J5WlhSMWNtNGdkbUZzZFdVS0NXWnlZVzFsWDJKMWNua2dNQW9KY21WMGMzVmlDZ29xWVdKcFgzSnZkWFJsWDJOeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1T2dvSmFXNTBZeUF3SUM4dklERUtDWEpsZEhWeWJnb0tLbU55WldGMFpWOU9iMDl3T2dvSmNIVnphR0o1ZEdWeklEQjRZamcwTkRkaU16WWdMeThnYldWMGFHOWtJQ0pqY21WaGRHVkJjSEJzYVdOaGRHbHZiaWdwZG05cFpDSUtDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0NXMWhkR05vSUNwaFltbGZjbTkxZEdWZlkzSmxZWFJsUVhCd2JHbGpZWFJwYjI0S0Nna3ZMeUIwYUdseklHTnZiblJ5WVdOMElHUnZaWE1nYm05MElHbHRjR3hsYldWdWRDQjBhR1VnWjJsMlpXNGdRVUpKSUcxbGRHaHZaQ0JtYjNJZ1kzSmxZWFJsSUU1dlQzQUtDV1Z5Y2dvS0ttTmhiR3hmVG05UGNEb0tDWEIxYzJoaWVYUmxjeUF3ZUdRME5Ua3pZV1psSUM4dklHMWxkR2h2WkNBaVltOXZiRlIxY0d4bEtDa29ZbTl2YkN4aWIyOXNMR0p2YjJ3c1ltOXZiQ3hpYjI5c0xHSnZiMndzWW05dmJDeGliMjlzTEdKdmIyd3BJZ29KZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb0piV0YwWTJnZ0ttRmlhVjl5YjNWMFpWOWliMjlzVkhWd2JHVUtDZ2t2THlCMGFHbHpJR052Ym5SeVlXTjBJR1J2WlhNZ2JtOTBJR2x0Y0d4bGJXVnVkQ0IwYUdVZ1oybDJaVzRnUVVKSklHMWxkR2h2WkNCbWIzSWdZMkZzYkNCT2IwOXdDZ2xsY25JPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBREFRQUdNUmdVSkFzeEdRaU5EQUJQQUFBQUFBQUFBQUFBQUFCQkFBQUFBQUFBQUFBQUFBQ0FCQlVmZkhXSUFBUlFzQ0pEaWdBQmdBQ0FBZ0FBSXlKVUlpTlVnUUlpVklFRElsU0JCQ05VZ1FValZDUWlWSUVISTFTQkNDTlVqQUNMQUl3QWlTSkRnQVM0UkhzMk5ob0FqZ0gvOFFDQUJOUlpPdjQyR2dDT0FmK2xBQT09IiwiY2xlYXIiOiJDZz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6ImFsZ29kIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6NCwicGF0Y2giOjEsImNvbW1pdEhhc2giOiI3YjYwN2NlNCJ9fSwiZXZlbnRzIjpudWxsLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
