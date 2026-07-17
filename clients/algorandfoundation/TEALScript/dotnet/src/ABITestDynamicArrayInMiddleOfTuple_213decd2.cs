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

namespace Arc56.Generated.algorandfoundation.TEALScript.ABITestDynamicArrayInMiddleOfTuple_213decd2
{


    public class ABITestDynamicArrayInMiddleOfTupleProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ABITestDynamicArrayInMiddleOfTupleProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class DynamicArrayInMiddleOfTupleReturn : AVMObjectType
            {
                public ushort Field0 { get; set; }

                public byte[] Field1 { get; set; }

                public ushort Field2 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static DynamicArrayInMiddleOfTupleReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new DynamicArrayInMiddleOfTupleReturn();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ushort vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as DynamicArrayInMiddleOfTupleReturn);
                }
                public bool Equals(DynamicArrayInMiddleOfTupleReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(DynamicArrayInMiddleOfTupleReturn left, DynamicArrayInMiddleOfTupleReturn right)
                {
                    return EqualityComparer<DynamicArrayInMiddleOfTupleReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(DynamicArrayInMiddleOfTupleReturn left, DynamicArrayInMiddleOfTupleReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.DynamicArrayInMiddleOfTupleReturn> DynamicArrayInMiddleOfTuple(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 191, 46, 115 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.DynamicArrayInMiddleOfTupleReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> DynamicArrayInMiddleOfTuple_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 191, 46, 115 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJBQklUZXN0RHluYW1pY0FycmF5SW5NaWRkbGVPZlR1cGxlIiwiZGVzYyI6IiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJEeW5hbWljQXJyYXlJbk1pZGRsZU9mVHVwbGVSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDE2In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ4W10ifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDE2In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImR5bmFtaWNBcnJheUluTWlkZGxlT2ZUdXBsZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDE2LHVpbnQ4W10sdWludDE2KSIsInN0cnVjdCI6IkR5bmFtaWNBcnJheUluTWlkZGxlT2ZUdXBsZVJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlswXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjU2In0seyJwYyI6WzEsMiwzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjU2In0seyJwYyI6WzQsNSw2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjU2In0seyJwYyI6WzcsOF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2NTYifSx7InBjIjpbOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2NTYifSx7InBjIjpbMTAsMTFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjU2In0seyJwYyI6WzEyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxOCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY1NiJ9LHsicGMiOlsxMywxNF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2NTYifSx7InBjIjpbMTVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjU2In0seyJwYyI6WzE2LDE3LDE4LDE5LDIwLDIxLDIyLDIzLDI0LDI1LDI2LDI3LDI4LDI5LDMwLDMxLDMyLDMzLDM0LDM1LDM2LDM3LDM4LDM5LDQwLDQxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyMSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY1NiJ9LHsicGMiOls0Ml0sImVycm9yTWVzc2FnZSI6IlRoZSByZXF1ZXN0ZWQgYWN0aW9uIGlzIG5vdCBpbXBsZW1lbnRlZCBpbiB0aGlzIGNvbnRyYWN0LiBBcmUgeW91IHVzaW5nIHRoZSBjb3JyZWN0IE9uQ29tcGxldGU/IERpZCB5b3Ugc2V0IHlvdXIgYXBwIElEPyIsInRlYWwiOjI1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjU2In0seyJwYyI6WzQzLDQ0LDQ1LDQ2LDQ3LDQ4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY1NyJ9LHsicGMiOls0OSw1MCw1MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2NTcifSx7InBjIjpbNTJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjU3In0seyJwYyI6WzUzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY1NyJ9LHsicGMiOls1NF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2NTcifSx7InBjIjpbNTVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjU3In0seyJwYyI6WzU2LDU3LDU4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY1NyJ9LHsicGMiOls1OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2NTcifSx7InBjIjpbNjBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQ4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjU4In0seyJwYyI6WzYxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0OSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY1OCJ9LHsicGMiOls2Miw2Myw2NCw2NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2NTgifSx7InBjIjpbNjYsNjcsNjgsNjldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjUxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjU4In0seyJwYyI6WzcwLDcxLDcyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY1OCJ9LHsicGMiOls3Myw3NCw3NSw3Niw3N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2NTgifSx7InBjIjpbNzgsNzksODBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjU4In0seyJwYyI6WzgxLDgyLDgzLDg0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1NSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY1OCJ9LHsicGMiOls4NSw4Niw4N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2NTgifSx7InBjIjpbODhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjU4In0seyJwYyI6Wzg5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1OCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY1OCJ9LHsicGMiOls5MCw5MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2NTgifSx7InBjIjpbOTIsOTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjYzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjYwIn0seyJwYyI6Wzk0LDk1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY1NyJ9LHsicGMiOls5Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2NTcifSx7InBjIjpbOTddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjcwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjU2In0seyJwYyI6Wzk4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY1NiJ9LHsicGMiOls5OSwxMDAsMTAxLDEwMiwxMDMsMTA0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY1NiJ9LHsicGMiOlsxMDUsMTA2LDEwN10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2NTYifSx7InBjIjpbMTA4LDEwOSwxMTAsMTExXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY1NiJ9LHsicGMiOlsxMTJdLCJlcnJvck1lc3NhZ2UiOiJ0aGlzIGNvbnRyYWN0IGRvZXMgbm90IGltcGxlbWVudCB0aGUgZ2l2ZW4gQUJJIG1ldGhvZCBmb3IgY3JlYXRlIE5vT3AiLCJ0ZWFsIjo3OSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY1NiJ9LHsicGMiOlsxMTMsMTE0LDExNSwxMTYsMTE3LDExOF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2NTYifSx7InBjIjpbMTE5LDEyMCwxMjFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjgzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjU2In0seyJwYyI6WzEyMiwxMjMsMTI0LDEyNV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2NTYifSx7InBjIjpbMTI2XSwiZXJyb3JNZXNzYWdlIjoidGhpcyBjb250cmFjdCBkb2VzIG5vdCBpbXBsZW1lbnQgdGhlIGdpdmVuIEFCSSBtZXRob2QgZm9yIGNhbGwgTm9PcCIsInRlYWwiOjg3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjU2In0seyJwYyI6WzEyNywxMjgsMTI5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo5MCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY1NiJ9LHsicGMiOlsxMzAsMTMxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo5MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY1NiJ9LHsicGMiOlsxMzIsMTMzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo5Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY1NiJ9LHsicGMiOlsxMzRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjkzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjU2In0seyJwYyI6WzEzNSwxMzZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjk0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjU2In0seyJwYyI6WzEzNywxMzhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjk1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjU2In0seyJwYyI6WzEzOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2NTYifSx7InBjIjpbMTQwLDE0MSwxNDJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjk5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjU2In0seyJwYyI6WzE0MywxNDRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwMCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY1NiJ9LHsicGMiOlsxNDUsMTQ2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2NTYifSx7InBjIjpbMTQ3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2NTYifSx7InBjIjpbMTQ4LDE0OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTAzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjU2In0seyJwYyI6WzE1MCwxNTFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwNCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY1NiJ9LHsicGMiOlsxNTJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwNSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY1NiJ9LHsicGMiOlsxNTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwNiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY1NiJ9LHsicGMiOlsxNTQsMTU1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2NTYifSx7InBjIjpbMTU2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2NTYifSx7InBjIjpbMTU3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2NTYifSx7InBjIjpbMTU4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMTAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2NTYifSx7InBjIjpbMTU5LDE2MCwxNjFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjExMSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY1NiJ9LHsicGMiOlsxNjIsMTYzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMTIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2NTYifSx7InBjIjpbMTY0LDE2NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTEzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjU2In0seyJwYyI6WzE2Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTE0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjU2In0seyJwYyI6WzE2N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTE1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjU2In0seyJwYyI6WzE2OCwxNjldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjExNiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY1NiJ9LHsicGMiOlsxNzAsMTcxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMTcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo2NTYifSx7InBjIjpbMTcyLDE3M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTE4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NjU2In0seyJwYyI6WzE3NCwxNzVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjExOSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY1NiJ9LHsicGMiOlsxNzZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyMCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjY1NiJ9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NtbHVkR05pYkc5amF5QXhDbUo1ZEdWallteHZZMnNnTUhnS0NpOHZJRlJvYVhNZ1ZFVkJUQ0IzWVhNZ1oyVnVaWEpoZEdWa0lHSjVJRlJGUVV4VFkzSnBjSFFnZGpBdU1UQTNMaklLTHk4Z2FIUjBjSE02THk5bmFYUm9kV0l1WTI5dEwyRnNaMjl5WVc1a1ptOTFibVJoZEdsdmJpOVVSVUZNVTJOeWFYQjBDZ292THlCVWFHbHpJR052Ym5SeVlXTjBJR2x6SUdOdmJYQnNhV0Z1ZENCM2FYUm9JR0Z1WkM5dmNpQnBiWEJzWlcxbGJuUnpJSFJvWlNCbWIyeHNiM2RwYm1jZ1FWSkRjem9nV3lCQlVrTTBJRjBLQ2k4dklGUm9aU0JtYjJ4c2IzZHBibWNnZEdWdUlHeHBibVZ6SUc5bUlGUkZRVXdnYUdGdVpHeGxJR2x1YVhScFlXd2djSEp2WjNKaGJTQm1iRzkzQ2k4dklGUm9hWE1nY0dGMGRHVnliaUJwY3lCMWMyVmtJSFJ2SUcxaGEyVWdhWFFnWldGemVTQm1iM0lnWVc1NWIyNWxJSFJ2SUhCaGNuTmxJSFJvWlNCemRHRnlkQ0J2WmlCMGFHVWdjSEp2WjNKaGJTQmhibVFnWkdWMFpYSnRhVzVsSUdsbUlHRWdjM0JsWTJsbWFXTWdZV04wYVc5dUlHbHpJR0ZzYkc5M1pXUUtMeThnU0dWeVpTd2dZV04wYVc5dUlISmxabVZ5Y3lCMGJ5QjBhR1VnVDI1RGIyMXdiR1YwWlNCcGJpQmpiMjFpYVc1aGRHbHZiaUIzYVhSb0lIZG9aWFJvWlhJZ2RHaGxJR0Z3Y0NCcGN5QmlaV2x1WnlCamNtVmhkR1ZrSUc5eUlHTmhiR3hsWkFvdkx5QkZkbVZ5ZVNCd2IzTnphV0pzWlNCaFkzUnBiMjRnWm05eUlIUm9hWE1nWTI5dWRISmhZM1FnYVhNZ2NtVndjbVZ6Wlc1MFpXUWdhVzRnZEdobElITjNhWFJqYUNCemRHRjBaVzFsYm5RS0x5OGdTV1lnZEdobElHRmpkR2x2YmlCcGN5QnViM1FnYVcxd2JHVnRaVzUwWldRZ2FXNGdkR2hsSUdOdmJuUnlZV04wTENCcGRITWdjbVZ6Y0dWamRHbDJaU0JpY21GdVkyZ2dkMmxzYkNCaVpTQWlLazVQVkY5SlRWQk1SVTFGVGxSRlJDSWdkMmhwWTJnZ2FuVnpkQ0JqYjI1MFlXbHVjeUFpWlhKeUlncDBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2hDbkIxYzJocGJuUWdOZ29xQ25SNGJpQlBia052YlhCc1pYUnBiMjRLS3dwemQybDBZMmdnS21OaGJHeGZUbTlQY0NBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLbU55WldGMFpWOU9iMDl3SUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJBb0tLazVQVkY5SlRWQk1SVTFGVGxSRlJEb0tDUzh2SUZSb1pTQnlaWEYxWlhOMFpXUWdZV04wYVc5dUlHbHpJRzV2ZENCcGJYQnNaVzFsYm5SbFpDQnBiaUIwYUdseklHTnZiblJ5WVdOMExpQkJjbVVnZVc5MUlIVnphVzVuSUhSb1pTQmpiM0p5WldOMElFOXVRMjl0Y0d4bGRHVS9JRVJwWkNCNWIzVWdjMlYwSUhsdmRYSWdZWEJ3SUVsRVB3b0paWEp5Q2dvdkx5QmtlVzVoYldsalFYSnlZWGxKYmsxcFpHUnNaVTltVkhWd2JHVW9LU2gxYVc1ME1UWXNkV2x1ZERoYlhTeDFhVzUwTVRZcENpcGhZbWxmY205MWRHVmZaSGx1WVcxcFkwRnljbUY1U1c1TmFXUmtiR1ZQWmxSMWNHeGxPZ29KTHk4Z1ZHaGxJRUZDU1NCeVpYUjFjbTRnY0hKbFptbDRDZ2x3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlFvS0NTOHZJR1Y0WldOMWRHVWdaSGx1WVcxcFkwRnljbUY1U1c1TmFXUmtiR1ZQWmxSMWNHeGxLQ2tvZFdsdWRERTJMSFZwYm5RNFcxMHNkV2x1ZERFMktRb0pZMkZzYkhOMVlpQmtlVzVoYldsalFYSnlZWGxKYmsxcFpHUnNaVTltVkhWd2JHVUtDV052Ym1OaGRBb0piRzluQ2dscGJuUmpJREFnTHk4Z01Rb0pjbVYwZFhKdUNnb3ZMeUJrZVc1aGJXbGpRWEp5WVhsSmJrMXBaR1JzWlU5bVZIVndiR1VvS1RvZ1czVnBiblF4Tml3Z2RXbHVkRHc0UGx0ZExDQjFhVzUwTVRaZENtUjVibUZ0YVdOQmNuSmhlVWx1VFdsa1pHeGxUMlpVZFhCc1pUb0tDWEJ5YjNSdklEQWdNUW9LQ1M4dklGQjFjMmdnWlcxd2RIa2dZbmwwWlhNZ1lXWjBaWElnZEdobElHWnlZVzFsSUhCdmFXNTBaWElnZEc4Z2NtVnpaWEoyWlNCemNHRmpaU0JtYjNJZ2JHOWpZV3dnZG1GeWFXRmliR1Z6Q2dsaWVYUmxZeUF3SUM4dklEQjRDZ29KTHk4Z2RHVnpkSE12WTI5dWRISmhZM1J6TDJGaWFTNWhiR2R2TG5Sek9qWTFPQW9KTHk4Z1lUb2dXM1ZwYm5ReE5pd2dkV2x1ZER3NFBsdGRMQ0IxYVc1ME1UWmRJRDBnV3pFc0lGc3lYU3dnTTEwS0NXSjVkR1ZqSURBZ0x5OGdJR2x1YVhScFlXd2dhR1ZoWkFvSllubDBaV01nTUNBdkx5QWdhVzVwZEdsaGJDQjBZV2xzQ2dsd2RYTm9ZbmwwWlhNZ01IZ3dNREEySUM4dklHbHVhWFJwWVd3Z2FHVmhaQ0J2Wm1aelpYUUtDWEIxYzJoaWVYUmxjeUF3ZURBd01ERUtDV05oYkd4emRXSWdLbkJ5YjJObGMzTmZjM1JoZEdsalgzUjFjR3hsWDJWc1pXMWxiblFLQ1hCMWMyaGllWFJsY3lBd2VEQXdNREV3TWdvSlkyRnNiSE4xWWlBcWNISnZZMlZ6YzE5a2VXNWhiV2xqWDNSMWNHeGxYMlZzWlcxbGJuUUtDWEIxYzJoaWVYUmxjeUF3ZURBd01ETUtDV05oYkd4emRXSWdLbkJ5YjJObGMzTmZjM1JoZEdsalgzUjFjR3hsWDJWc1pXMWxiblFLQ1hCdmNDQXZMeUJ3YjNBZ2FHVmhaQ0J2Wm1aelpYUUtDV052Ym1OaGRDQXZMeUJqYjI1allYUWdhR1ZoWkNCaGJtUWdkR0ZwYkFvSlpuSmhiV1ZmWW5WeWVTQXdJQzh2SUdFNklGdDFhVzUwTVRZc0lIVnBiblE4T0Q1YlhTd2dkV2x1ZERFMlhRb0tDUzh2SUhSbGMzUnpMMk52Ym5SeVlXTjBjeTloWW1rdVlXeG5ieTUwY3pvMk5qQUtDUzh2SUhKbGRIVnliaUJoT3dvSlpuSmhiV1ZmWkdsbklEQWdMeThnWVRvZ1czVnBiblF4Tml3Z2RXbHVkRHc0UGx0ZExDQjFhVzUwTVRaZENnb0pMeThnYzJWMElIUm9aU0J6ZFdKeWIzVjBhVzVsSUhKbGRIVnliaUIyWVd4MVpRb0pabkpoYldWZlluVnllU0F3Q2dseVpYUnpkV0lLQ2lwaFltbGZjbTkxZEdWZlkzSmxZWFJsUVhCd2JHbGpZWFJwYjI0NkNnbHBiblJqSURBZ0x5OGdNUW9KY21WMGRYSnVDZ29xWTNKbFlYUmxYMDV2VDNBNkNnbHdkWE5vWW5sMFpYTWdNSGhpT0RRME4ySXpOaUF2THlCdFpYUm9iMlFnSW1OeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1S0NsMmIybGtJZ29KZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb0piV0YwWTJnZ0ttRmlhVjl5YjNWMFpWOWpjbVZoZEdWQmNIQnNhV05oZEdsdmJnb0tDUzh2SUhSb2FYTWdZMjl1ZEhKaFkzUWdaRzlsY3lCdWIzUWdhVzF3YkdWdFpXNTBJSFJvWlNCbmFYWmxiaUJCUWtrZ2JXVjBhRzlrSUdadmNpQmpjbVZoZEdVZ1RtOVBjQW9KWlhKeUNnb3FZMkZzYkY5T2IwOXdPZ29KY0hWemFHSjVkR1Z6SURCNFlXTmlaakpsTnpNZ0x5OGdiV1YwYUc5a0lDSmtlVzVoYldsalFYSnlZWGxKYmsxcFpHUnNaVTltVkhWd2JHVW9LU2gxYVc1ME1UWXNkV2x1ZERoYlhTeDFhVzUwTVRZcElnb0pkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvSmJXRjBZMmdnS21GaWFWOXliM1YwWlY5a2VXNWhiV2xqUVhKeVlYbEpiazFwWkdSc1pVOW1WSFZ3YkdVS0Nna3ZMeUIwYUdseklHTnZiblJ5WVdOMElHUnZaWE1nYm05MElHbHRjR3hsYldWdWRDQjBhR1VnWjJsMlpXNGdRVUpKSUcxbGRHaHZaQ0JtYjNJZ1kyRnNiQ0JPYjA5d0NnbGxjbklLQ2lwd2NtOWpaWE56WDNOMFlYUnBZMTkwZFhCc1pWOWxiR1Z0Wlc1ME9nb0pjSEp2ZEc4Z05DQXpDZ2xtY21GdFpWOWthV2NnTFRRZ0x5OGdkSFZ3YkdVZ2FHVmhaQW9KWm5KaGJXVmZaR2xuSUMweElDOHZJR1ZzWlcxbGJuUUtDV052Ym1OaGRBb0pabkpoYldWZlpHbG5JQzB6SUM4dklIUjFjR3hsSUhSaGFXd0tDV1p5WVcxbFgyUnBaeUF0TWlBdkx5Qm9aV0ZrSUc5bVpuTmxkQW9KY21WMGMzVmlDZ29xY0hKdlkyVnpjMTlrZVc1aGJXbGpYM1IxY0d4bFgyVnNaVzFsYm5RNkNnbHdjbTkwYnlBMElETUtDV1p5WVcxbFgyUnBaeUF0TkNBdkx5QjBkWEJzWlNCb1pXRmtDZ2xtY21GdFpWOWthV2NnTFRJZ0x5OGdhR1ZoWkNCdlptWnpaWFFLQ1dOdmJtTmhkQW9KWm5KaGJXVmZZblZ5ZVNBdE5DQXZMeUIwZFhCc1pTQm9aV0ZrQ2dsbWNtRnRaVjlrYVdjZ0xURWdMeThnWld4bGJXVnVkQW9KWkhWd0NnbHNaVzRLQ1daeVlXMWxYMlJwWnlBdE1pQXZMeUJvWldGa0lHOW1abk5sZEFvSlluUnZhUW9KS3dvSmFYUnZZZ29KWlhoMGNtRmpkQ0EySURJS0NXWnlZVzFsWDJKMWNua2dMVElnTHk4Z2FHVmhaQ0J2Wm1aelpYUUtDV1p5WVcxbFgyUnBaeUF0TXlBdkx5QjBkWEJzWlNCMFlXbHNDZ2x6ZDJGd0NnbGpiMjVqWVhRS0NXWnlZVzFsWDJKMWNua2dMVE1nTHk4Z2RIVndiR1VnZEdGcGJBb0pabkpoYldWZlpHbG5JQzAwSUM4dklIUjFjR3hsSUdobFlXUUtDV1p5WVcxbFgyUnBaeUF0TXlBdkx5QjBkWEJzWlNCMFlXbHNDZ2xtY21GdFpWOWthV2NnTFRJZ0x5OGdhR1ZoWkNCdlptWnpaWFFLQ1hKbGRITjFZZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXcifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFCQVNZQkFERVlGSUVHQ3pFWkNJME1BRWNBQUFBQUFBQUFBQUFBQURrQUFBQUFBQUFBQUFBQUFJQUVGUjk4ZFlnQUJGQ3dJa09LQUFFb0tDaUFBZ0FHZ0FJQUFZZ0FOb0FEQUFFQ2lBQTdnQUlBQTRnQUowaFFqQUNMQUl3QWlTSkRnQVM0UkhzMk5ob0FqZ0gvOFFDQUJLeS9Mbk0yR2dDT0FmK3RBSW9FQTR2OGkvOVFpLzJML29tS0JBT0wvSXYrVUl6OGkvOUpGWXYrRndnV1Z3WUNqUDZML1V4UWpQMkwvSXY5aS82SiIsImNsZWFyIjoiQ2c9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJhbGdvZCIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjQsInBhdGNoIjoxLCJjb21taXRIYXNoIjoiN2I2MDdjZTQifX0sImV2ZW50cyI6bnVsbCwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
