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

namespace Arc56.Generated.algorandfoundation.TEALScript.ABITestStringInTuple_980a5467
{


    public class ABITestStringInTupleProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ABITestStringInTupleProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class StringInTupleReturn : AVMObjectType
            {
                public ushort Field0 { get; set; }

                public byte[] Field1 { get; set; }

                public string Field2 { get; set; }

                public byte[] Field3 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[]");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField2.From(Field2);
                    stringRef[ret.Count] = vField2.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[]");
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

                public static StringInTupleReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new StringInTupleReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ushort vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[]");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is byte[] vField1Value) { ret.Field1 = vField1Value; }
                    var indexField2 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField2.Decode(bytes.Skip(indexField2 + prefixOffset).ToArray());
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is string vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[]");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is byte[] vField3Value) { ret.Field3 = vField3Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as StringInTupleReturn);
                }
                public bool Equals(StringInTupleReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(StringInTupleReturn left, StringInTupleReturn right)
                {
                    return EqualityComparer<StringInTupleReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(StringInTupleReturn left, StringInTupleReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.StringInTupleReturn> StringInTuple(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 13, 86, 88 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.StringInTupleReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> StringInTuple_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 13, 86, 88 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJBQklUZXN0U3RyaW5nSW5UdXBsZSIsImRlc2MiOiIiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiU3RyaW5nSW5UdXBsZVJldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50MTYifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDhbXSJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoidWludDhbXSJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJzdHJpbmdJblR1cGxlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50MTYsdWludDhbXSxzdHJpbmcsdWludDhbXSkiLCJzdHJ1Y3QiOiJTdHJpbmdJblR1cGxlUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImNyZWF0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo1NDAifSx7InBjIjpbMSwyLDNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo1NDAifSx7InBjIjpbNCw1LDZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo1NDAifSx7InBjIjpbNyw4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjU0MCJ9LHsicGMiOls5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjU0MCJ9LHsicGMiOlsxMCwxMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo1NDAifSx7InBjIjpbMTJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTQwIn0seyJwYyI6WzEzLDE0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxOSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjU0MCJ9LHsicGMiOlsxNV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo1NDAifSx7InBjIjpbMTYsMTcsMTgsMTksMjAsMjEsMjIsMjMsMjQsMjUsMjYsMjcsMjgsMjksMzAsMzEsMzIsMzMsMzQsMzUsMzYsMzcsMzgsMzksNDAsNDFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTQwIn0seyJwYyI6WzQyXSwiZXJyb3JNZXNzYWdlIjoiVGhlIHJlcXVlc3RlZCBhY3Rpb24gaXMgbm90IGltcGxlbWVudGVkIGluIHRoaXMgY29udHJhY3QuIEFyZSB5b3UgdXNpbmcgdGhlIGNvcnJlY3QgT25Db21wbGV0ZT8gRGlkIHlvdSBzZXQgeW91ciBhcHAgSUQ/IiwidGVhbCI6MjUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo1NDAifSx7InBjIjpbNDMsNDQsNDUsNDYsNDcsNDhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTQxIn0seyJwYyI6WzQ5LDUwLDUxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjU0MSJ9LHsicGMiOls1Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo1NDEifSx7InBjIjpbNTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTQxIn0seyJwYyI6WzU0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjU0MSJ9LHsicGMiOls1NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo1NDEifSx7InBjIjpbNTYsNTcsNThdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTQxIn0seyJwYyI6WzU5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjU0MSJ9LHsicGMiOls2MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo1NDIifSx7InBjIjpbNjFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQ5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTQyIn0seyJwYyI6WzYyLDYzLDY0LDY1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1MCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjU0MiJ9LHsicGMiOls2Niw2Nyw2OCw2OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo1NDIifSx7InBjIjpbNzAsNzEsNzJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjUyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTQyIn0seyJwYyI6WzczLDc0LDc1LDc2LDc3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjU0MiJ9LHsicGMiOls3OCw3OSw4MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo1NDIifSx7InBjIjpbODEsODIsODMsODQsODUsODYsODcsODgsODksOTAsOTEsOTIsOTMsOTQsOTUsOTZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTQyIn0seyJwYyI6Wzk3LDk4LDk5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjU0MiJ9LHsicGMiOlsxMDAsMTAxLDEwMiwxMDMsMTA0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1Nywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjU0MiJ9LHsicGMiOlsxMDUsMTA2LDEwN10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo1NDIifSx7InBjIjpbMTA4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1OSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjU0MiJ9LHsicGMiOlsxMDldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjYwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTQyIn0seyJwYyI6WzExMCwxMTFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjYxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTQyIn0seyJwYyI6WzExMiwxMTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTQ0In0seyJwYyI6WzExNCwxMTVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTQxIn0seyJwYyI6WzExNl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo1NDEifSx7InBjIjpbMTE3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjU0MCJ9LHsicGMiOlsxMThdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjczLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTQwIn0seyJwYyI6WzExOSwxMjAsMTIxLDEyMiwxMjMsMTI0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjU0MCJ9LHsicGMiOlsxMjUsMTI2LDEyN10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo1NDAifSx7InBjIjpbMTI4LDEyOSwxMzAsMTMxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3OCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjU0MCJ9LHsicGMiOlsxMzJdLCJlcnJvck1lc3NhZ2UiOiJ0aGlzIGNvbnRyYWN0IGRvZXMgbm90IGltcGxlbWVudCB0aGUgZ2l2ZW4gQUJJIG1ldGhvZCBmb3IgY3JlYXRlIE5vT3AiLCJ0ZWFsIjo4MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjU0MCJ9LHsicGMiOlsxMzMsMTM0LDEzNSwxMzYsMTM3LDEzOF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo1NDAifSx7InBjIjpbMTM5LDE0MCwxNDFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjg1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTQwIn0seyJwYyI6WzE0MiwxNDMsMTQ0LDE0NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo1NDAifSx7InBjIjpbMTQ2XSwiZXJyb3JNZXNzYWdlIjoidGhpcyBjb250cmFjdCBkb2VzIG5vdCBpbXBsZW1lbnQgdGhlIGdpdmVuIEFCSSBtZXRob2QgZm9yIGNhbGwgTm9PcCIsInRlYWwiOjg5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTQwIn0seyJwYyI6WzE0NywxNDgsMTQ5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo5Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjU0MCJ9LHsicGMiOlsxNTAsMTUxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo5Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjU0MCJ9LHsicGMiOlsxNTIsMTUzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo5NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjU0MCJ9LHsicGMiOlsxNTRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjk1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTQwIn0seyJwYyI6WzE1NSwxNTZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjk2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTQwIn0seyJwYyI6WzE1NywxNThdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjk3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTQwIn0seyJwYyI6WzE1OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo1NDAifSx7InBjIjpbMTYwLDE2MSwxNjJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwMSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjU0MCJ9LHsicGMiOlsxNjMsMTY0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo1NDAifSx7InBjIjpbMTY1LDE2Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTAzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTQwIn0seyJwYyI6WzE2N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTA0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTQwIn0seyJwYyI6WzE2OCwxNjldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwNSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjU0MCJ9LHsicGMiOlsxNzAsMTcxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo1NDAifSx7InBjIjpbMTcyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo1NDAifSx7InBjIjpbMTczXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo1NDAifSx7InBjIjpbMTc0LDE3NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTA5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTQwIn0seyJwYyI6WzE3Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTEwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTQwIn0seyJwYyI6WzE3N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTExLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTQwIn0seyJwYyI6WzE3OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTEyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTQwIn0seyJwYyI6WzE3OSwxODAsMTgxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMTMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo1NDAifSx7InBjIjpbMTgyLDE4M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTE0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTQwIn0seyJwYyI6WzE4NCwxODVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjExNSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjU0MCJ9LHsicGMiOlsxODZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjExNiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjU0MCJ9LHsicGMiOlsxODddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjExNywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjU0MCJ9LHsicGMiOlsxODgsMTg5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMTgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo1NDAifSx7InBjIjpbMTkwLDE5MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTE5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTQwIn0seyJwYyI6WzE5MiwxOTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyMCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjU0MCJ9LHsicGMiOlsxOTQsMTk1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMjEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo1NDAifSx7InBjIjpbMTk2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMjIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo1NDAifV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDbWx1ZEdOaWJHOWpheUF4Q21KNWRHVmpZbXh2WTJzZ01IZ0tDaTh2SUZSb2FYTWdWRVZCVENCM1lYTWdaMlZ1WlhKaGRHVmtJR0o1SUZSRlFVeFRZM0pwY0hRZ2RqQXVNVEEzTGpJS0x5OGdhSFIwY0hNNkx5OW5hWFJvZFdJdVkyOXRMMkZzWjI5eVlXNWtabTkxYm1SaGRHbHZiaTlVUlVGTVUyTnlhWEIwQ2dvdkx5QlVhR2x6SUdOdmJuUnlZV04wSUdseklHTnZiWEJzYVdGdWRDQjNhWFJvSUdGdVpDOXZjaUJwYlhCc1pXMWxiblJ6SUhSb1pTQm1iMnhzYjNkcGJtY2dRVkpEY3pvZ1d5QkJVa00wSUYwS0NpOHZJRlJvWlNCbWIyeHNiM2RwYm1jZ2RHVnVJR3hwYm1WeklHOW1JRlJGUVV3Z2FHRnVaR3hsSUdsdWFYUnBZV3dnY0hKdlozSmhiU0JtYkc5M0NpOHZJRlJvYVhNZ2NHRjBkR1Z5YmlCcGN5QjFjMlZrSUhSdklHMWhhMlVnYVhRZ1pXRnplU0JtYjNJZ1lXNTViMjVsSUhSdklIQmhjbk5sSUhSb1pTQnpkR0Z5ZENCdlppQjBhR1VnY0hKdlozSmhiU0JoYm1RZ1pHVjBaWEp0YVc1bElHbG1JR0VnYzNCbFkybG1hV01nWVdOMGFXOXVJR2x6SUdGc2JHOTNaV1FLTHk4Z1NHVnlaU3dnWVdOMGFXOXVJSEpsWm1WeWN5QjBieUIwYUdVZ1QyNURiMjF3YkdWMFpTQnBiaUJqYjIxaWFXNWhkR2x2YmlCM2FYUm9JSGRvWlhSb1pYSWdkR2hsSUdGd2NDQnBjeUJpWldsdVp5QmpjbVZoZEdWa0lHOXlJR05oYkd4bFpBb3ZMeUJGZG1WeWVTQndiM056YVdKc1pTQmhZM1JwYjI0Z1ptOXlJSFJvYVhNZ1kyOXVkSEpoWTNRZ2FYTWdjbVZ3Y21WelpXNTBaV1FnYVc0Z2RHaGxJSE4zYVhSamFDQnpkR0YwWlcxbGJuUUtMeThnU1dZZ2RHaGxJR0ZqZEdsdmJpQnBjeUJ1YjNRZ2FXMXdiR1Z0Wlc1MFpXUWdhVzRnZEdobElHTnZiblJ5WVdOMExDQnBkSE1nY21WemNHVmpkR2wyWlNCaWNtRnVZMmdnZDJsc2JDQmlaU0FpS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0lnZDJocFkyZ2dhblZ6ZENCamIyNTBZV2x1Y3lBaVpYSnlJZ3AwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9oQ25CMWMyaHBiblFnTmdvcUNuUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0t3cHpkMmwwWTJnZ0ttTmhiR3hmVG05UGNDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS21OeVpXRjBaVjlPYjA5d0lDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQW9LS2s1UFZGOUpUVkJNUlUxRlRsUkZSRG9LQ1M4dklGUm9aU0J5WlhGMVpYTjBaV1FnWVdOMGFXOXVJR2x6SUc1dmRDQnBiWEJzWlcxbGJuUmxaQ0JwYmlCMGFHbHpJR052Ym5SeVlXTjBMaUJCY21VZ2VXOTFJSFZ6YVc1bklIUm9aU0JqYjNKeVpXTjBJRTl1UTI5dGNHeGxkR1UvSUVScFpDQjViM1VnYzJWMElIbHZkWElnWVhCd0lFbEVQd29KWlhKeUNnb3ZMeUJ6ZEhKcGJtZEpibFIxY0d4bEtDa29kV2x1ZERFMkxIVnBiblE0VzEwc2MzUnlhVzVuTEhWcGJuUTRXMTBwQ2lwaFltbGZjbTkxZEdWZmMzUnlhVzVuU1c1VWRYQnNaVG9LQ1M4dklGUm9aU0JCUWtrZ2NtVjBkWEp1SUhCeVpXWnBlQW9KY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVS0Nna3ZMeUJsZUdWamRYUmxJSE4wY21sdVowbHVWSFZ3YkdVb0tTaDFhVzUwTVRZc2RXbHVkRGhiWFN4emRISnBibWNzZFdsdWREaGJYU2tLQ1dOaGJHeHpkV0lnYzNSeWFXNW5TVzVVZFhCc1pRb0pZMjl1WTJGMENnbHNiMmNLQ1dsdWRHTWdNQ0F2THlBeENnbHlaWFIxY200S0NpOHZJSE4wY21sdVowbHVWSFZ3YkdVb0tUb2dXM1ZwYm5ReE5pd2dkV2x1ZER3NFBsdGRMQ0J6ZEhKcGJtY3NJSFZwYm5ROE9ENWJYVjBLYzNSeWFXNW5TVzVVZFhCc1pUb0tDWEJ5YjNSdklEQWdNUW9LQ1M4dklGQjFjMmdnWlcxd2RIa2dZbmwwWlhNZ1lXWjBaWElnZEdobElHWnlZVzFsSUhCdmFXNTBaWElnZEc4Z2NtVnpaWEoyWlNCemNHRmpaU0JtYjNJZ2JHOWpZV3dnZG1GeWFXRmliR1Z6Q2dsaWVYUmxZeUF3SUM4dklEQjRDZ29KTHk4Z2RHVnpkSE12WTI5dWRISmhZM1J6TDJGaWFTNWhiR2R2TG5Sek9qVTBNZ29KTHk4Z1lUb2dXM1ZwYm5ReE5pd2dkV2x1ZER3NFBsdGRMQ0J6ZEhKcGJtY3NJSFZwYm5ROE9ENWJYVjBnUFNCYk1Td2dXekpkTENBblNHVnNiRzhnVjI5eWJHUWhKeXdnV3pOZFhRb0pZbmwwWldNZ01DQXZMeUFnYVc1cGRHbGhiQ0JvWldGa0NnbGllWFJsWXlBd0lDOHZJQ0JwYm1sMGFXRnNJSFJoYVd3S0NYQjFjMmhpZVhSbGN5QXdlREF3TURnZ0x5OGdhVzVwZEdsaGJDQm9aV0ZrSUc5bVpuTmxkQW9KY0hWemFHSjVkR1Z6SURCNE1EQXdNUW9KWTJGc2JITjFZaUFxY0hKdlkyVnpjMTl6ZEdGMGFXTmZkSFZ3YkdWZlpXeGxiV1Z1ZEFvSmNIVnphR0o1ZEdWeklEQjRNREF3TVRBeUNnbGpZV3hzYzNWaUlDcHdjbTlqWlhOelgyUjVibUZ0YVdOZmRIVndiR1ZmWld4bGJXVnVkQW9KY0hWemFHSjVkR1Z6SURCNE1EQXdZelE0TmpVMll6WmpObVl5TURVM05tWTNNalpqTmpReU1Rb0pZMkZzYkhOMVlpQXFjSEp2WTJWemMxOWtlVzVoYldsalgzUjFjR3hsWDJWc1pXMWxiblFLQ1hCMWMyaGllWFJsY3lBd2VEQXdNREV3TXdvSlkyRnNiSE4xWWlBcWNISnZZMlZ6YzE5a2VXNWhiV2xqWDNSMWNHeGxYMlZzWlcxbGJuUUtDWEJ2Y0NBdkx5QndiM0FnYUdWaFpDQnZabVp6WlhRS0NXTnZibU5oZENBdkx5QmpiMjVqWVhRZ2FHVmhaQ0JoYm1RZ2RHRnBiQW9KWm5KaGJXVmZZblZ5ZVNBd0lDOHZJR0U2SUZ0MWFXNTBNVFlzSUhWcGJuUThPRDViWFN3Z2MzUnlhVzVuTENCMWFXNTBQRGcrVzExZENnb0pMeThnZEdWemRITXZZMjl1ZEhKaFkzUnpMMkZpYVM1aGJHZHZMblJ6T2pVME5Bb0pMeThnY21WMGRYSnVJR0U3Q2dsbWNtRnRaVjlrYVdjZ01DQXZMeUJoT2lCYmRXbHVkREUyTENCMWFXNTBQRGcrVzEwc0lITjBjbWx1Wnl3Z2RXbHVkRHc0UGx0ZFhRb0tDUzh2SUhObGRDQjBhR1VnYzNWaWNtOTFkR2x1WlNCeVpYUjFjbTRnZG1Gc2RXVUtDV1p5WVcxbFgySjFjbmtnTUFvSmNtVjBjM1ZpQ2dvcVlXSnBYM0p2ZFhSbFgyTnlaV0YwWlVGd2NHeHBZMkYwYVc5dU9nb0phVzUwWXlBd0lDOHZJREVLQ1hKbGRIVnliZ29LS21OeVpXRjBaVjlPYjA5d09nb0pjSFZ6YUdKNWRHVnpJREI0WWpnME5EZGlNellnTHk4Z2JXVjBhRzlrSUNKamNtVmhkR1ZCY0hCc2FXTmhkR2x2YmlncGRtOXBaQ0lLQ1hSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtDVzFoZEdOb0lDcGhZbWxmY205MWRHVmZZM0psWVhSbFFYQndiR2xqWVhScGIyNEtDZ2t2THlCMGFHbHpJR052Ym5SeVlXTjBJR1J2WlhNZ2JtOTBJR2x0Y0d4bGJXVnVkQ0IwYUdVZ1oybDJaVzRnUVVKSklHMWxkR2h2WkNCbWIzSWdZM0psWVhSbElFNXZUM0FLQ1dWeWNnb0tLbU5oYkd4ZlRtOVBjRG9LQ1hCMWMyaGllWFJsY3lBd2VEUmpNR1ExTmpVNElDOHZJRzFsZEdodlpDQWljM1J5YVc1blNXNVVkWEJzWlNncEtIVnBiblF4Tml4MWFXNTBPRnRkTEhOMGNtbHVaeXgxYVc1ME9GdGRLU0lLQ1hSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtDVzFoZEdOb0lDcGhZbWxmY205MWRHVmZjM1J5YVc1blNXNVVkWEJzWlFvS0NTOHZJSFJvYVhNZ1kyOXVkSEpoWTNRZ1pHOWxjeUJ1YjNRZ2FXMXdiR1Z0Wlc1MElIUm9aU0JuYVhabGJpQkJRa2tnYldWMGFHOWtJR1p2Y2lCallXeHNJRTV2VDNBS0NXVnljZ29LS25CeWIyTmxjM05mYzNSaGRHbGpYM1IxY0d4bFgyVnNaVzFsYm5RNkNnbHdjbTkwYnlBMElETUtDV1p5WVcxbFgyUnBaeUF0TkNBdkx5QjBkWEJzWlNCb1pXRmtDZ2xtY21GdFpWOWthV2NnTFRFZ0x5OGdaV3hsYldWdWRBb0pZMjl1WTJGMENnbG1jbUZ0WlY5a2FXY2dMVE1nTHk4Z2RIVndiR1VnZEdGcGJBb0pabkpoYldWZlpHbG5JQzB5SUM4dklHaGxZV1FnYjJabWMyVjBDZ2x5WlhSemRXSUtDaXB3Y205alpYTnpYMlI1Ym1GdGFXTmZkSFZ3YkdWZlpXeGxiV1Z1ZERvS0NYQnliM1J2SURRZ013b0pabkpoYldWZlpHbG5JQzAwSUM4dklIUjFjR3hsSUdobFlXUUtDV1p5WVcxbFgyUnBaeUF0TWlBdkx5Qm9aV0ZrSUc5bVpuTmxkQW9KWTI5dVkyRjBDZ2xtY21GdFpWOWlkWEo1SUMwMElDOHZJSFIxY0d4bElHaGxZV1FLQ1daeVlXMWxYMlJwWnlBdE1TQXZMeUJsYkdWdFpXNTBDZ2xrZFhBS0NXeGxiZ29KWm5KaGJXVmZaR2xuSUMweUlDOHZJR2hsWVdRZ2IyWm1jMlYwQ2dsaWRHOXBDZ2tyQ2dscGRHOWlDZ2xsZUhSeVlXTjBJRFlnTWdvSlpuSmhiV1ZmWW5WeWVTQXRNaUF2THlCb1pXRmtJRzltWm5ObGRBb0pabkpoYldWZlpHbG5JQzB6SUM4dklIUjFjR3hsSUhSaGFXd0tDWE4zWVhBS0NXTnZibU5oZEFvSlpuSmhiV1ZmWW5WeWVTQXRNeUF2THlCMGRYQnNaU0IwWVdsc0NnbG1jbUZ0WlY5a2FXY2dMVFFnTHk4Z2RIVndiR1VnYUdWaFpBb0pabkpoYldWZlpHbG5JQzB6SUM4dklIUjFjR3hsSUhSaGFXd0tDV1p5WVcxbFgyUnBaeUF0TWlBdkx5Qm9aV0ZrSUc5bVpuTmxkQW9KY21WMGMzVmkiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFdyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUJBU1lCQURFWUZJRUdDekVaQ0kwTUFGc0FBQUFBQUFBQUFBQUFBRTBBQUFBQUFBQUFBQUFBQUlBRUZSOThkWWdBQkZDd0lrT0tBQUVvS0NpQUFnQUlnQUlBQVlnQVNvQURBQUVDaUFCUGdBNEFERWhsYkd4dklGZHZjbXhrSVlnQVBJQURBQUVEaUFBMFNGQ01BSXNBakFDSklrT0FCTGhFZXpZMkdnQ09BZi94QUlBRVRBMVdXRFlhQUk0Qi81a0FpZ1FEaS95TC8xQ0wvWXYraVlvRUE0djhpLzVRalB5TC8wa1ZpLzRYQ0JaWEJnS00vb3Y5VEZDTS9ZdjhpLzJML29rPSIsImNsZWFyIjoiQ2c9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJhbGdvZCIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjQsInBhdGNoIjoxLCJjb21taXRIYXNoIjoiN2I2MDdjZTQifX0sImV2ZW50cyI6bnVsbCwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
