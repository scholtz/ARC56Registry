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

namespace Arc56.Generated.algorandfoundation.TEALScript.ABITestNonLiteralDynamicElementInTuple_74dd4910
{


    public class ABITestNonLiteralDynamicElementInTupleProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ABITestNonLiteralDynamicElementInTupleProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class NonLiteralDynamicElementInTupleReturn : AVMObjectType
            {
                public byte Field0 { get; set; }

                public ushort Field1 { get; set; }

                public byte[] Field2 { get; set; }

                public ushort[] Field3 { get; set; }

                public byte[] Field4 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[]");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16[]");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[]");
                    vField4.From(Field4);
                    ret.AddRange(vField4.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static NonLiteralDynamicElementInTupleReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new NonLiteralDynamicElementInTupleReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is byte vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ushort vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[]");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is byte[] vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16[]");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is ushort[] vField3Value) { ret.Field3 = vField3Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[]");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is byte[] vField4Value) { ret.Field4 = vField4Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as NonLiteralDynamicElementInTupleReturn);
                }
                public bool Equals(NonLiteralDynamicElementInTupleReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(NonLiteralDynamicElementInTupleReturn left, NonLiteralDynamicElementInTupleReturn right)
                {
                    return EqualityComparer<NonLiteralDynamicElementInTupleReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(NonLiteralDynamicElementInTupleReturn left, NonLiteralDynamicElementInTupleReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.NonLiteralDynamicElementInTupleReturn> NonLiteralDynamicElementInTuple(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 70, 162, 15 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.NonLiteralDynamicElementInTupleReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> NonLiteralDynamicElementInTuple_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 70, 162, 15 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJBQklUZXN0Tm9uTGl0ZXJhbER5bmFtaWNFbGVtZW50SW5UdXBsZSIsImRlc2MiOiIiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiTm9uTGl0ZXJhbER5bmFtaWNFbGVtZW50SW5UdXBsZVJldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50OCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50MTYifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDhbXSJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJ1aW50MTZbXSJ9LHsibmFtZSI6ImZpZWxkNCIsInR5cGUiOiJ1aW50OFtdIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6Im5vbkxpdGVyYWxEeW5hbWljRWxlbWVudEluVHVwbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ4LHVpbnQxNix1aW50OFtdLHVpbnQxNltdLHVpbnQ4W10pIiwic3RydWN0IjoiTm9uTGl0ZXJhbER5bmFtaWNFbGVtZW50SW5UdXBsZVJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlswXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NDE4In0seyJwYyI6WzEsMiwzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NDE4In0seyJwYyI6WzQsNSw2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NDE4In0seyJwYyI6WzcsOF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo0MTgifSx7InBjIjpbOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo0MTgifSx7InBjIjpbMTAsMTFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NDE4In0seyJwYyI6WzEyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxOCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjQxOCJ9LHsicGMiOlsxMywxNF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo0MTgifSx7InBjIjpbMTVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NDE4In0seyJwYyI6WzE2LDE3LDE4LDE5LDIwLDIxLDIyLDIzLDI0LDI1LDI2LDI3LDI4LDI5LDMwLDMxLDMyLDMzLDM0LDM1LDM2LDM3LDM4LDM5LDQwLDQxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyMSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjQxOCJ9LHsicGMiOls0Ml0sImVycm9yTWVzc2FnZSI6IlRoZSByZXF1ZXN0ZWQgYWN0aW9uIGlzIG5vdCBpbXBsZW1lbnRlZCBpbiB0aGlzIGNvbnRyYWN0LiBBcmUgeW91IHVzaW5nIHRoZSBjb3JyZWN0IE9uQ29tcGxldGU/IERpZCB5b3Ugc2V0IHlvdXIgYXBwIElEPyIsInRlYWwiOjI1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NDE4In0seyJwYyI6WzQzLDQ0LDQ1LDQ2LDQ3LDQ4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjQxOSJ9LHsicGMiOls0OSw1MCw1MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo0MTkifSx7InBjIjpbNTJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NDE5In0seyJwYyI6WzUzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjQxOSJ9LHsicGMiOls1NF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo0MTkifSx7InBjIjpbNTVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NDE5In0seyJwYyI6WzU2LDU3LDU4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjQxOSJ9LHsicGMiOls1OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo0MTkifSx7InBjIjpbNjBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQ1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NDE5In0seyJwYyI6WzYxLDYyLDYzLDY0LDY1LDY2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0OSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjQyMCJ9LHsicGMiOls2Nyw2OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo0MjAifSx7InBjIjpbNjldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NDIxIn0seyJwYyI6WzcwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1NSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjQyMSJ9LHsicGMiOls3MSw3Miw3Myw3NF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo0MjEifSx7InBjIjpbNzUsNzYsNzddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NDIxIn0seyJwYyI6Wzc4LDc5LDgwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1OCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjQyMSJ9LHsicGMiOls4MSw4Miw4Myw4NF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo0MjEifSx7InBjIjpbODUsODYsODddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjYwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NDIxIn0seyJwYyI6Wzg4LDg5LDkwLDkxLDkyLDkzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjQyMSJ9LHsicGMiOls5NCw5NSw5Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo0MjEifSx7InBjIjpbOTcsOThdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjYzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NDIxIn0seyJwYyI6Wzk5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjQyMSJ9LHsicGMiOlsxMDBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NDIxIn0seyJwYyI6WzEwMSwxMDJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NDIxIn0seyJwYyI6WzEwM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo0MjEifSx7InBjIjpbMTA0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2OCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjQyMSJ9LHsicGMiOlsxMDUsMTA2LDEwN10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo0MjEifSx7InBjIjpbMTA4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3MCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjQyMSJ9LHsicGMiOlsxMDldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjcxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NDIxIn0seyJwYyI6WzExMCwxMTEsMTEyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjQyMSJ9LHsicGMiOlsxMTMsMTE0LDExNSwxMTYsMTE3LDExOF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo0MjEifSx7InBjIjpbMTE5LDEyMCwxMjFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjc0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NDIxIn0seyJwYyI6WzEyMl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo0MjEifSx7InBjIjpbMTIzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjQyMSJ9LHsicGMiOlsxMjQsMTI1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3Nywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjQyMSJ9LHsicGMiOlsxMjYsMTI3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjQyMyJ9LHsicGMiOlsxMjgsMTI5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjQxOSJ9LHsicGMiOlsxMzAsMTMxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4Nywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjQxOSJ9LHsicGMiOlsxMzJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjg4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NDE5In0seyJwYyI6WzEzM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo0MTgifSx7InBjIjpbMTM0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo5Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjQxOCJ9LHsicGMiOlsxMzUsMTM2LDEzNywxMzgsMTM5LDE0MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo0MTgifSx7InBjIjpbMTQxLDE0MiwxNDNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjk2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NDE4In0seyJwYyI6WzE0NCwxNDUsMTQ2LDE0N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo0MTgifSx7InBjIjpbMTQ4XSwiZXJyb3JNZXNzYWdlIjoidGhpcyBjb250cmFjdCBkb2VzIG5vdCBpbXBsZW1lbnQgdGhlIGdpdmVuIEFCSSBtZXRob2QgZm9yIGNyZWF0ZSBOb09wIiwidGVhbCI6MTAwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NDE4In0seyJwYyI6WzE0OSwxNTAsMTUxLDE1MiwxNTMsMTU0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo0MTgifSx7InBjIjpbMTU1LDE1NiwxNTddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwNCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjQxOCJ9LHsicGMiOlsxNTgsMTU5LDE2MCwxNjFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwNSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjQxOCJ9LHsicGMiOlsxNjJdLCJlcnJvck1lc3NhZ2UiOiJ0aGlzIGNvbnRyYWN0IGRvZXMgbm90IGltcGxlbWVudCB0aGUgZ2l2ZW4gQUJJIG1ldGhvZCBmb3IgY2FsbCBOb09wIiwidGVhbCI6MTA4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NDE4In0seyJwYyI6WzE2MywxNjQsMTY1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMTEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo0MTgifSx7InBjIjpbMTY2LDE2N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTEyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NDE4In0seyJwYyI6WzE2OCwxNjldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjExMywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjQxOCJ9LHsicGMiOlsxNzBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjExNCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjQxOCJ9LHsicGMiOlsxNzEsMTcyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMTUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo0MTgifSx7InBjIjpbMTczLDE3NF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTE2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NDE4In0seyJwYyI6WzE3NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTE3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NDE4In0seyJwYyI6WzE3NiwxNzcsMTc4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMjAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo0MTgifSx7InBjIjpbMTc5LDE4MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTIxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NDE4In0seyJwYyI6WzE4MSwxODJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyMiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjQxOCJ9LHsicGMiOlsxODNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyMywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjQxOCJ9LHsicGMiOlsxODQsMTg1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMjQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo0MTgifSx7InBjIjpbMTg2LDE4N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTI1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NDE4In0seyJwYyI6WzE4OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTI2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NDE4In0seyJwYyI6WzE4OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTI3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NDE4In0seyJwYyI6WzE5MCwxOTFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyOCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjQxOCJ9LHsicGMiOlsxOTJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyOSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjQxOCJ9LHsicGMiOlsxOTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEzMCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjQxOCJ9LHsicGMiOlsxOTRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEzMSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjQxOCJ9LHsicGMiOlsxOTUsMTk2LDE5N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTMyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NDE4In0seyJwYyI6WzE5OCwxOTldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEzMywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjQxOCJ9LHsicGMiOlsyMDAsMjAxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMzQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo0MTgifSx7InBjIjpbMjAyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMzUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo0MTgifSx7InBjIjpbMjAzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMzYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo0MTgifSx7InBjIjpbMjA0LDIwNV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTM3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NDE4In0seyJwYyI6WzIwNiwyMDddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEzOCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjQxOCJ9LHsicGMiOlsyMDgsMjA5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMzksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo0MTgifSx7InBjIjpbMjEwLDIxMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTQwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NDE4In0seyJwYyI6WzIxMl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTQxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NDE4In1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q21sdWRHTmliRzlqYXlBeENtSjVkR1ZqWW14dlkyc2dNSGdLQ2k4dklGUm9hWE1nVkVWQlRDQjNZWE1nWjJWdVpYSmhkR1ZrSUdKNUlGUkZRVXhUWTNKcGNIUWdkakF1TVRBM0xqSUtMeThnYUhSMGNITTZMeTluYVhSb2RXSXVZMjl0TDJGc1oyOXlZVzVrWm05MWJtUmhkR2x2Ymk5VVJVRk1VMk55YVhCMENnb3ZMeUJVYUdseklHTnZiblJ5WVdOMElHbHpJR052YlhCc2FXRnVkQ0IzYVhSb0lHRnVaQzl2Y2lCcGJYQnNaVzFsYm5SeklIUm9aU0JtYjJ4c2IzZHBibWNnUVZKRGN6b2dXeUJCVWtNMElGMEtDaTh2SUZSb1pTQm1iMnhzYjNkcGJtY2dkR1Z1SUd4cGJtVnpJRzltSUZSRlFVd2dhR0Z1Wkd4bElHbHVhWFJwWVd3Z2NISnZaM0poYlNCbWJHOTNDaTh2SUZSb2FYTWdjR0YwZEdWeWJpQnBjeUIxYzJWa0lIUnZJRzFoYTJVZ2FYUWdaV0Z6ZVNCbWIzSWdZVzU1YjI1bElIUnZJSEJoY25ObElIUm9aU0J6ZEdGeWRDQnZaaUIwYUdVZ2NISnZaM0poYlNCaGJtUWdaR1YwWlhKdGFXNWxJR2xtSUdFZ2MzQmxZMmxtYVdNZ1lXTjBhVzl1SUdseklHRnNiRzkzWldRS0x5OGdTR1Z5WlN3Z1lXTjBhVzl1SUhKbFptVnljeUIwYnlCMGFHVWdUMjVEYjIxd2JHVjBaU0JwYmlCamIyMWlhVzVoZEdsdmJpQjNhWFJvSUhkb1pYUm9aWElnZEdobElHRndjQ0JwY3lCaVpXbHVaeUJqY21WaGRHVmtJRzl5SUdOaGJHeGxaQW92THlCRmRtVnllU0J3YjNOemFXSnNaU0JoWTNScGIyNGdabTl5SUhSb2FYTWdZMjl1ZEhKaFkzUWdhWE1nY21Wd2NtVnpaVzUwWldRZ2FXNGdkR2hsSUhOM2FYUmphQ0J6ZEdGMFpXMWxiblFLTHk4Z1NXWWdkR2hsSUdGamRHbHZiaUJwY3lCdWIzUWdhVzF3YkdWdFpXNTBaV1FnYVc0Z2RHaGxJR052Ym5SeVlXTjBMQ0JwZEhNZ2NtVnpjR1ZqZEdsMlpTQmljbUZ1WTJnZ2QybHNiQ0JpWlNBaUtrNVBWRjlKVFZCTVJVMUZUbFJGUkNJZ2QyaHBZMmdnYW5WemRDQmpiMjUwWVdsdWN5QWlaWEp5SWdwMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvaENuQjFjMmhwYm5RZ05nb3FDblI0YmlCUGJrTnZiWEJzWlhScGIyNEtLd3B6ZDJsMFkyZ2dLbU5oYkd4ZlRtOVBjQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0ttTnlaV0YwWlY5T2IwOXdJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkFvS0trNVBWRjlKVFZCTVJVMUZUbFJGUkRvS0NTOHZJRlJvWlNCeVpYRjFaWE4wWldRZ1lXTjBhVzl1SUdseklHNXZkQ0JwYlhCc1pXMWxiblJsWkNCcGJpQjBhR2x6SUdOdmJuUnlZV04wTGlCQmNtVWdlVzkxSUhWemFXNW5JSFJvWlNCamIzSnlaV04wSUU5dVEyOXRjR3hsZEdVL0lFUnBaQ0I1YjNVZ2MyVjBJSGx2ZFhJZ1lYQndJRWxFUHdvSlpYSnlDZ292THlCdWIyNU1hWFJsY21Gc1JIbHVZVzFwWTBWc1pXMWxiblJKYmxSMWNHeGxLQ2tvZFdsdWREZ3NkV2x1ZERFMkxIVnBiblE0VzEwc2RXbHVkREUyVzEwc2RXbHVkRGhiWFNrS0ttRmlhVjl5YjNWMFpWOXViMjVNYVhSbGNtRnNSSGx1WVcxcFkwVnNaVzFsYm5SSmJsUjFjR3hsT2dvSkx5OGdWR2hsSUVGQ1NTQnlaWFIxY200Z2NISmxabWw0Q2dsd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05Rb0tDUzh2SUdWNFpXTjFkR1VnYm05dVRHbDBaWEpoYkVSNWJtRnRhV05GYkdWdFpXNTBTVzVVZFhCc1pTZ3BLSFZwYm5RNExIVnBiblF4Tml4MWFXNTBPRnRkTEhWcGJuUXhObHRkTEhWcGJuUTRXMTBwQ2dsallXeHNjM1ZpSUc1dmJreHBkR1Z5WVd4RWVXNWhiV2xqUld4bGJXVnVkRWx1VkhWd2JHVUtDV052Ym1OaGRBb0piRzluQ2dscGJuUmpJREFnTHk4Z01Rb0pjbVYwZFhKdUNnb3ZMeUJ1YjI1TWFYUmxjbUZzUkhsdVlXMXBZMFZzWlcxbGJuUkpibFIxY0d4bEtDazZJRnQxYVc1MFBEZytMQ0IxYVc1ME1UWXNJSFZwYm5ROE9ENWJYU3dnZFdsdWRERTJXMTBzSUhWcGJuUThPRDViWFYwS2JtOXVUR2wwWlhKaGJFUjVibUZ0YVdORmJHVnRaVzUwU1c1VWRYQnNaVG9LQ1hCeWIzUnZJREFnTVFvS0NTOHZJRkIxYzJnZ1pXMXdkSGtnWW5sMFpYTWdZV1owWlhJZ2RHaGxJR1p5WVcxbElIQnZhVzUwWlhJZ2RHOGdjbVZ6WlhKMlpTQnpjR0ZqWlNCbWIzSWdiRzlqWVd3Z2RtRnlhV0ZpYkdWekNnbGllWFJsWXlBd0lDOHZJREI0Q2dsa2RYQUtDZ2t2THlCMFpYTjBjeTlqYjI1MGNtRmpkSE12WVdKcExtRnNaMjh1ZEhNNk5ESXdDZ2t2THlCbE9pQjFhVzUwTVRaYlhTQTlJRnMxTENBMlhRb0pjSFZ6YUdKNWRHVnpJREI0TURBd05UQXdNRFlLQ1daeVlXMWxYMkoxY25rZ01DQXZMeUJsT2lCMWFXNTBNVFpiWFFvS0NTOHZJSFJsYzNSekwyTnZiblJ5WVdOMGN5OWhZbWt1WVd4bmJ5NTBjem8wTWpFS0NTOHZJR0U2SUZ0MWFXNTBQRGcrTENCMWFXNTBNVFlzSUhWcGJuUThPRDViWFN3Z2RXbHVkREUyVzEwc0lIVnBiblE4T0Q1YlhWMGdQU0JiTVN3Z01pd2dXek1zSURSZExDQmxMQ0JiTnl3Z09GMWRDZ2xpZVhSbFl5QXdJQzh2SUNCcGJtbDBhV0ZzSUdobFlXUUtDV0o1ZEdWaklEQWdMeThnSUdsdWFYUnBZV3dnZEdGcGJBb0pjSFZ6YUdKNWRHVnpJREI0TURBd09TQXZMeUJwYm1sMGFXRnNJR2hsWVdRZ2IyWm1jMlYwQ2dsd2RYTm9ZbmwwWlhNZ01IZ3dNUW9KWTJGc2JITjFZaUFxY0hKdlkyVnpjMTl6ZEdGMGFXTmZkSFZ3YkdWZlpXeGxiV1Z1ZEFvSmNIVnphR0o1ZEdWeklEQjRNREF3TWdvSlkyRnNiSE4xWWlBcWNISnZZMlZ6YzE5emRHRjBhV05mZEhWd2JHVmZaV3hsYldWdWRBb0pjSFZ6YUdKNWRHVnpJREI0TURBd01qQXpNRFFLQ1dOaGJHeHpkV0lnS25CeWIyTmxjM05mWkhsdVlXMXBZMTkwZFhCc1pWOWxiR1Z0Wlc1MENnbG1jbUZ0WlY5a2FXY2dNQ0F2THlCbE9pQjFhVzUwTVRaYlhRb0paSFZ3Q2dsc1pXNEtDWEIxYzJocGJuUWdNZ29KTHdvSmFYUnZZZ29KWlhoMGNtRmpkQ0EySURJS0NYTjNZWEFLQ1dOdmJtTmhkQW9KWTJGc2JITjFZaUFxY0hKdlkyVnpjMTlrZVc1aGJXbGpYM1IxY0d4bFgyVnNaVzFsYm5RS0NYQjFjMmhpZVhSbGN5QXdlREF3TURJd056QTRDZ2xqWVd4c2MzVmlJQ3B3Y205alpYTnpYMlI1Ym1GdGFXTmZkSFZ3YkdWZlpXeGxiV1Z1ZEFvSmNHOXdJQzh2SUhCdmNDQm9aV0ZrSUc5bVpuTmxkQW9KWTI5dVkyRjBJQzh2SUdOdmJtTmhkQ0JvWldGa0lHRnVaQ0IwWVdsc0NnbG1jbUZ0WlY5aWRYSjVJREVnTHk4Z1lUb2dXM1ZwYm5ROE9ENHNJSFZwYm5ReE5pd2dkV2x1ZER3NFBsdGRMQ0IxYVc1ME1UWmJYU3dnZFdsdWREdzRQbHRkWFFvS0NTOHZJSFJsYzNSekwyTnZiblJ5WVdOMGN5OWhZbWt1WVd4bmJ5NTBjem8wTWpNS0NTOHZJSEpsZEhWeWJpQmhPd29KWm5KaGJXVmZaR2xuSURFZ0x5OGdZVG9nVzNWcGJuUThPRDRzSUhWcGJuUXhOaXdnZFdsdWREdzRQbHRkTENCMWFXNTBNVFpiWFN3Z2RXbHVkRHc0UGx0ZFhRb0tDUzh2SUhObGRDQjBhR1VnYzNWaWNtOTFkR2x1WlNCeVpYUjFjbTRnZG1Gc2RXVUtDV1p5WVcxbFgySjFjbmtnTUFvS0NTOHZJSEJ2Y0NCaGJHd2diRzlqWVd3Z2RtRnlhV0ZpYkdWeklHWnliMjBnZEdobElITjBZV05yQ2dsd2IzQnVJREVLQ1hKbGRITjFZZ29LS21GaWFWOXliM1YwWlY5amNtVmhkR1ZCY0hCc2FXTmhkR2x2YmpvS0NXbHVkR01nTUNBdkx5QXhDZ2x5WlhSMWNtNEtDaXBqY21WaGRHVmZUbTlQY0RvS0NYQjFjMmhpZVhSbGN5QXdlR0k0TkRRM1lqTTJJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRvS1hadmFXUWlDZ2wwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NnbHRZWFJqYUNBcVlXSnBYM0p2ZFhSbFgyTnlaV0YwWlVGd2NHeHBZMkYwYVc5dUNnb0pMeThnZEdocGN5QmpiMjUwY21GamRDQmtiMlZ6SUc1dmRDQnBiWEJzWlcxbGJuUWdkR2hsSUdkcGRtVnVJRUZDU1NCdFpYUm9iMlFnWm05eUlHTnlaV0YwWlNCT2IwOXdDZ2xsY25JS0NpcGpZV3hzWDA1dlQzQTZDZ2x3ZFhOb1lubDBaWE1nTUhneE16UTJZVEl3WmlBdkx5QnRaWFJvYjJRZ0ltNXZia3hwZEdWeVlXeEVlVzVoYldsalJXeGxiV1Z1ZEVsdVZIVndiR1VvS1NoMWFXNTBPQ3gxYVc1ME1UWXNkV2x1ZERoYlhTeDFhVzUwTVRaYlhTeDFhVzUwT0Z0ZEtTSUtDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0NXMWhkR05vSUNwaFltbGZjbTkxZEdWZmJtOXVUR2wwWlhKaGJFUjVibUZ0YVdORmJHVnRaVzUwU1c1VWRYQnNaUW9LQ1M4dklIUm9hWE1nWTI5dWRISmhZM1FnWkc5bGN5QnViM1FnYVcxd2JHVnRaVzUwSUhSb1pTQm5hWFpsYmlCQlFra2diV1YwYUc5a0lHWnZjaUJqWVd4c0lFNXZUM0FLQ1dWeWNnb0tLbkJ5YjJObGMzTmZjM1JoZEdsalgzUjFjR3hsWDJWc1pXMWxiblE2Q2dsd2NtOTBieUEwSURNS0NXWnlZVzFsWDJScFp5QXROQ0F2THlCMGRYQnNaU0JvWldGa0NnbG1jbUZ0WlY5a2FXY2dMVEVnTHk4Z1pXeGxiV1Z1ZEFvSlkyOXVZMkYwQ2dsbWNtRnRaVjlrYVdjZ0xUTWdMeThnZEhWd2JHVWdkR0ZwYkFvSlpuSmhiV1ZmWkdsbklDMHlJQzh2SUdobFlXUWdiMlptYzJWMENnbHlaWFJ6ZFdJS0NpcHdjbTlqWlhOelgyUjVibUZ0YVdOZmRIVndiR1ZmWld4bGJXVnVkRG9LQ1hCeWIzUnZJRFFnTXdvSlpuSmhiV1ZmWkdsbklDMDBJQzh2SUhSMWNHeGxJR2hsWVdRS0NXWnlZVzFsWDJScFp5QXRNaUF2THlCb1pXRmtJRzltWm5ObGRBb0pZMjl1WTJGMENnbG1jbUZ0WlY5aWRYSjVJQzAwSUM4dklIUjFjR3hsSUdobFlXUUtDV1p5WVcxbFgyUnBaeUF0TVNBdkx5QmxiR1Z0Wlc1MENnbGtkWEFLQ1d4bGJnb0pabkpoYldWZlpHbG5JQzB5SUM4dklHaGxZV1FnYjJabWMyVjBDZ2xpZEc5cENna3JDZ2xwZEc5aUNnbGxlSFJ5WVdOMElEWWdNZ29KWm5KaGJXVmZZblZ5ZVNBdE1pQXZMeUJvWldGa0lHOW1abk5sZEFvSlpuSmhiV1ZmWkdsbklDMHpJQzh2SUhSMWNHeGxJSFJoYVd3S0NYTjNZWEFLQ1dOdmJtTmhkQW9KWm5KaGJXVmZZblZ5ZVNBdE15QXZMeUIwZFhCc1pTQjBZV2xzQ2dsbWNtRnRaVjlrYVdjZ0xUUWdMeThnZEhWd2JHVWdhR1ZoWkFvSlpuSmhiV1ZmWkdsbklDMHpJQzh2SUhSMWNHeGxJSFJoYVd3S0NXWnlZVzFsWDJScFp5QXRNaUF2THlCb1pXRmtJRzltWm5ObGRBb0pjbVYwYzNWaSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQkFTWUJBREVZRklFR0N6RVpDSTBNQUdzQUFBQUFBQUFBQUFBQUFGMEFBQUFBQUFBQUFBQUFBSUFFRlI5OGRZZ0FCRkN3SWtPS0FBRW9TWUFFQUFVQUJvd0FLQ2lBQWdBSmdBRUJpQUJTZ0FJQUFvZ0FTNEFFQUFJREJJZ0FUNHNBU1JXQkFnb1dWd1lDVEZDSUFEK0FCQUFDQndpSUFEWklVSXdCaXdHTUFFWUJpU0pEZ0FTNFJIczJOaG9BamdILzhRQ0FCQk5Hb2c4MkdnQ09BZitKQUlvRUE0djhpLzlRaS8yTC9vbUtCQU9ML0l2K1VJejhpLzlKRll2K0Z3Z1dWd1lDalA2TC9VeFFqUDJML0l2OWkvNkoiLCJjbGVhciI6IkNnPT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoiYWxnb2QiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo0LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6IjdiNjA3Y2U0In19LCJldmVudHMiOm51bGwsInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
