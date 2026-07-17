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

namespace Arc56.Generated.algorandfoundation.TEALScript.ABITestPostBoolTupleOffset_65df7a21
{


    public class ABITestPostBoolTupleOffsetProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ABITestPostBoolTupleOffsetProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class T9 : AVMObjectType
            {
                public bool A { get; set; }

                public ulong B { get; set; }

                public ulong C { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vA.From(A);
                    ret.AddRange(vA.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vB.From(B);
                    ret.AddRange(vB.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vC.From(C);
                    ret.AddRange(vC.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static T9 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new T9();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vA.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueA = vA.ToValue();
                    if (valueA is bool vAValue) { ret.A = vAValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vB.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueB = vB.ToValue();
                    if (valueB is ulong vBValue) { ret.B = vBValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vC.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueC = vC.ToValue();
                    if (valueC is ulong vCValue) { ret.C = vCValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as T9);
                }
                public bool Equals(T9? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(T9 left, T9 right)
                {
                    return EqualityComparer<T9>.Default.Equals(left, right);
                }
                public static bool operator !=(T9 left, T9 right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.T9> PostBoolTupleOffset(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 232, 228, 207, 197 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.T9.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> PostBoolTupleOffset_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 232, 228, 207, 197 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJBQklUZXN0UG9zdEJvb2xUdXBsZU9mZnNldCIsImRlc2MiOiIiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiVDkiOlt7Im5hbWUiOiJhIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJiIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImMiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InBvc3RCb29sVHVwbGVPZmZzZXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKGJvb2wsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJUOSIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlswXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYxNyJ9LHsicGMiOlsxLDIsMyw0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYxNyJ9LHsicGMiOls1LDYsNyw4LDksMTAsMTEsMTIsMTMsMTQsMTVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjE3In0seyJwYyI6WzE2LDE3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2MTcifSx7InBjIjpbMThdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYxNyJ9LHsicGMiOlsxOSwyMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjE3In0seyJwYyI6WzIxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxOCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2MTcifSx7InBjIjpbMjIsMjNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYxNyJ9LHsicGMiOlsyNF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjE3In0seyJwYyI6WzI1LDI2LDI3LDI4LDI5LDMwLDMxLDMyLDMzLDM0LDM1LDM2LDM3LDM4LDM5LDQwLDQxLDQyLDQzLDQ0LDQ1LDQ2LDQ3LDQ4LDQ5LDUwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyMSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2MTcifSx7InBjIjpbNTFdLCJlcnJvck1lc3NhZ2UiOiJUaGUgcmVxdWVzdGVkIGFjdGlvbiBpcyBub3QgaW1wbGVtZW50ZWQgaW4gdGhpcyBjb250cmFjdC4gQXJlIHlvdSB1c2luZyB0aGUgY29ycmVjdCBPbkNvbXBsZXRlPyBEaWQgeW91IHNldCB5b3VyIGFwcCBJRD8iLCJ0ZWFsIjoyNSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2MTcifSx7InBjIjpbNTIsNTMsNTQsNTUsNTYsNTddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYxOCJ9LHsicGMiOls1OCw1OSw2MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjE4In0seyJwYyI6WzYxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2MTgifSx7InBjIjpbNjJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYxOCJ9LHsicGMiOls2M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjE4In0seyJwYyI6WzY0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2MTgifSx7InBjIjpbNjUsNjYsNjddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYxOCJ9LHsicGMiOls2OCw2OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjE4In0seyJwYyI6WzcwLDcxLDcyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0OCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2MTkifSx7InBjIjpbNzNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQ5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYxOSJ9LHsicGMiOls3NF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjE5In0seyJwYyI6Wzc1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2MTkifSx7InBjIjpbNzZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjUyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYxOSJ9LHsicGMiOls3N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjE5In0seyJwYyI6Wzc4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2MTkifSx7InBjIjpbNzldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYxOSJ9LHsicGMiOls4MCw4MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjE5In0seyJwYyI6WzgyLDgzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2MCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2MjEifSx7InBjIjpbODQsODVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjYxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYyMSJ9LHsicGMiOls4Niw4N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjIxIn0seyJwYyI6Wzg4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2MjEifSx7InBjIjpbODldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYyMSJ9LHsicGMiOls5MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjIxIn0seyJwYyI6WzkxLDkyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2MjEifSx7InBjIjpbOTMsOTRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjcwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYyMiJ9LHsicGMiOls5NSw5Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjIyIn0seyJwYyI6Wzk3LDk4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2MjIifSx7InBjIjpbOTksMTAwLDEwMSwxMDIsMTAzLDEwNCwxMDUsMTA2LDEwNywxMDhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjczLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYyMiJ9LHsicGMiOlsxMDksMTEwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2MjIifSx7InBjIjpbMTExLDExMl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjIyIn0seyJwYyI6WzExMywxMTRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjc5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYyMyJ9LHsicGMiOlsxMTUsMTE2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4MCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2MjMifSx7InBjIjpbMTE3LDExOF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjIzIn0seyJwYyI6WzExOSwxMjAsMTIxLDEyMiwxMjMsMTI0LDEyNSwxMjYsMTI3LDEyOF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjIzIn0seyJwYyI6WzEyOSwxMzBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjgzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYyMyJ9LHsicGMiOlsxMzEsMTMyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE2MjMifSx7InBjIjpbMTMzLDEzNF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjI1In0seyJwYyI6WzEzNSwxMzZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjkxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYxOCJ9LHsicGMiOlsxMzddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjkyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYxOCJ9LHsicGMiOlsxMzhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjk1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYxNyJ9LHsicGMiOlsxMzldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjk2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYxNyJ9LHsicGMiOlsxNDAsMTQxLDE0MiwxNDMsMTQ0LDE0NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjE3In0seyJwYyI6WzE0NiwxNDcsMTQ4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjE3In0seyJwYyI6WzE0OSwxNTAsMTUxLDE1Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTAxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYxNyJ9LHsicGMiOlsxNTNdLCJlcnJvck1lc3NhZ2UiOiJ0aGlzIGNvbnRyYWN0IGRvZXMgbm90IGltcGxlbWVudCB0aGUgZ2l2ZW4gQUJJIG1ldGhvZCBmb3IgY3JlYXRlIE5vT3AiLCJ0ZWFsIjoxMDQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjE3In0seyJwYyI6WzE1NCwxNTUsMTU2LDE1NywxNTgsMTU5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjE3In0seyJwYyI6WzE2MCwxNjEsMTYyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNjE3In0seyJwYyI6WzE2MywxNjQsMTY1LDE2Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTA5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYxNyJ9LHsicGMiOlsxNjddLCJlcnJvck1lc3NhZ2UiOiJ0aGlzIGNvbnRyYWN0IGRvZXMgbm90IGltcGxlbWVudCB0aGUgZ2l2ZW4gQUJJIG1ldGhvZCBmb3IgY2FsbCBOb09wIiwidGVhbCI6MTEyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTYxNyJ9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NtbHVkR05pYkc5amF5QXdJREVLWW5sMFpXTmliRzlqYXlBd2VEQXdNREF3TURBd01EQXdNREF3TURBS0NpOHZJRlJvYVhNZ1ZFVkJUQ0IzWVhNZ1oyVnVaWEpoZEdWa0lHSjVJRlJGUVV4VFkzSnBjSFFnZGpBdU1UQTNMaklLTHk4Z2FIUjBjSE02THk5bmFYUm9kV0l1WTI5dEwyRnNaMjl5WVc1a1ptOTFibVJoZEdsdmJpOVVSVUZNVTJOeWFYQjBDZ292THlCVWFHbHpJR052Ym5SeVlXTjBJR2x6SUdOdmJYQnNhV0Z1ZENCM2FYUm9JR0Z1WkM5dmNpQnBiWEJzWlcxbGJuUnpJSFJvWlNCbWIyeHNiM2RwYm1jZ1FWSkRjem9nV3lCQlVrTTBJRjBLQ2k4dklGUm9aU0JtYjJ4c2IzZHBibWNnZEdWdUlHeHBibVZ6SUc5bUlGUkZRVXdnYUdGdVpHeGxJR2x1YVhScFlXd2djSEp2WjNKaGJTQm1iRzkzQ2k4dklGUm9hWE1nY0dGMGRHVnliaUJwY3lCMWMyVmtJSFJ2SUcxaGEyVWdhWFFnWldGemVTQm1iM0lnWVc1NWIyNWxJSFJ2SUhCaGNuTmxJSFJvWlNCemRHRnlkQ0J2WmlCMGFHVWdjSEp2WjNKaGJTQmhibVFnWkdWMFpYSnRhVzVsSUdsbUlHRWdjM0JsWTJsbWFXTWdZV04wYVc5dUlHbHpJR0ZzYkc5M1pXUUtMeThnU0dWeVpTd2dZV04wYVc5dUlISmxabVZ5Y3lCMGJ5QjBhR1VnVDI1RGIyMXdiR1YwWlNCcGJpQmpiMjFpYVc1aGRHbHZiaUIzYVhSb0lIZG9aWFJvWlhJZ2RHaGxJR0Z3Y0NCcGN5QmlaV2x1WnlCamNtVmhkR1ZrSUc5eUlHTmhiR3hsWkFvdkx5QkZkbVZ5ZVNCd2IzTnphV0pzWlNCaFkzUnBiMjRnWm05eUlIUm9hWE1nWTI5dWRISmhZM1FnYVhNZ2NtVndjbVZ6Wlc1MFpXUWdhVzRnZEdobElITjNhWFJqYUNCemRHRjBaVzFsYm5RS0x5OGdTV1lnZEdobElHRmpkR2x2YmlCcGN5QnViM1FnYVcxd2JHVnRaVzUwWldRZ2FXNGdkR2hsSUdOdmJuUnlZV04wTENCcGRITWdjbVZ6Y0dWamRHbDJaU0JpY21GdVkyZ2dkMmxzYkNCaVpTQWlLazVQVkY5SlRWQk1SVTFGVGxSRlJDSWdkMmhwWTJnZ2FuVnpkQ0JqYjI1MFlXbHVjeUFpWlhKeUlncDBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2hDbkIxYzJocGJuUWdOZ29xQ25SNGJpQlBia052YlhCc1pYUnBiMjRLS3dwemQybDBZMmdnS21OaGJHeGZUbTlQY0NBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLbU55WldGMFpWOU9iMDl3SUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJBb0tLazVQVkY5SlRWQk1SVTFGVGxSRlJEb0tDUzh2SUZSb1pTQnlaWEYxWlhOMFpXUWdZV04wYVc5dUlHbHpJRzV2ZENCcGJYQnNaVzFsYm5SbFpDQnBiaUIwYUdseklHTnZiblJ5WVdOMExpQkJjbVVnZVc5MUlIVnphVzVuSUhSb1pTQmpiM0p5WldOMElFOXVRMjl0Y0d4bGRHVS9JRVJwWkNCNWIzVWdjMlYwSUhsdmRYSWdZWEJ3SUVsRVB3b0paWEp5Q2dvdkx5QndiM04wUW05dmJGUjFjR3hsVDJabWMyVjBLQ2tvWW05dmJDeDFhVzUwTmpRc2RXbHVkRFkwS1FvcVlXSnBYM0p2ZFhSbFgzQnZjM1JDYjI5c1ZIVndiR1ZQWm1aelpYUTZDZ2t2THlCVWFHVWdRVUpKSUhKbGRIVnliaUJ3Y21WbWFYZ0tDWEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxQ2dvSkx5OGdaWGhsWTNWMFpTQndiM04wUW05dmJGUjFjR3hsVDJabWMyVjBLQ2tvWW05dmJDeDFhVzUwTmpRc2RXbHVkRFkwS1FvSlkyRnNiSE4xWWlCd2IzTjBRbTl2YkZSMWNHeGxUMlptYzJWMENnbGpiMjVqWVhRS0NXeHZad29KYVc1MFl5QXhJQzh2SURFS0NYSmxkSFZ5YmdvS0x5OGdjRzl6ZEVKdmIyeFVkWEJzWlU5bVpuTmxkQ2dwT2lCVU9RcHdiM04wUW05dmJGUjFjR3hsVDJabWMyVjBPZ29KY0hKdmRHOGdNQ0F4Q2dvSkx5OGdVSFZ6YUNCbGJYQjBlU0JpZVhSbGN5QmhablJsY2lCMGFHVWdabkpoYldVZ2NHOXBiblJsY2lCMGJ5QnlaWE5sY25abElITndZV05sSUdadmNpQnNiMk5oYkNCMllYSnBZV0pzWlhNS0NYQjFjMmhpZVhSbGN5QXdlQW9LQ1M4dklIUmxjM1J6TDJOdmJuUnlZV04wY3k5aFlta3VZV3huYnk1MGN6b3hOakU1Q2drdkx5QnlaWFJXWVd3NklGUTVJRDBnZXlCaE9pQm1ZV3h6WlN3Z1lqb2dNQ3dnWXpvZ01DQjlDZ2x3ZFhOb1lubDBaWE1nTUhnd01Bb0phVzUwWXlBd0lDOHZJREFLQ1dSMWNBb0pjMlYwWW1sMENnbGllWFJsWXlBd0lDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNQW9KWTI5dVkyRjBDZ2xpZVhSbFl5QXdJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TUFvSlkyOXVZMkYwQ2dsbWNtRnRaVjlpZFhKNUlEQWdMeThnY21WMFZtRnNPaUJVT1FvS0NTOHZJSFJsYzNSekwyTnZiblJ5WVdOMGN5OWhZbWt1WVd4bmJ5NTBjem94TmpJeENna3ZMeUJ5WlhSV1lXd3VZU0E5SUhSeWRXVUtDV1p5WVcxbFgyUnBaeUF3SUM4dklISmxkRlpoYkRvZ1ZEa0tDWE4wYjNKbElESTFOU0F2THlCbWRXeHNJR0Z5Y21GNUNnbHNiMkZrSURJMU5TQXZMeUJtZFd4c0lHRnljbUY1Q2dscGJuUmpJREFnTHk4Z01Bb0phVzUwWXlBeElDOHZJREVLQ1hObGRHSnBkQW9KWm5KaGJXVmZZblZ5ZVNBd0lDOHZJSEpsZEZaaGJEb2dWRGtLQ2drdkx5QjBaWE4wY3k5amIyNTBjbUZqZEhNdllXSnBMbUZzWjI4dWRITTZNVFl5TWdvSkx5OGdjbVYwVm1Gc0xtSWdQU0F4Q2dsbWNtRnRaVjlrYVdjZ01DQXZMeUJ5WlhSV1lXdzZJRlE1Q2dsemRHOXlaU0F5TlRVZ0x5OGdablZzYkNCaGNuSmhlUW9KYkc5aFpDQXlOVFVnTHk4Z1puVnNiQ0JoY25KaGVRb0pjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd01EQXdNUW9KY21Wd2JHRmpaVElnTVFvSlpuSmhiV1ZmWW5WeWVTQXdJQzh2SUhKbGRGWmhiRG9nVkRrS0Nna3ZMeUIwWlhOMGN5OWpiMjUwY21GamRITXZZV0pwTG1Gc1oyOHVkSE02TVRZeU13b0pMeThnY21WMFZtRnNMbU1nUFNBeUNnbG1jbUZ0WlY5a2FXY2dNQ0F2THlCeVpYUldZV3c2SUZRNUNnbHpkRzl5WlNBeU5UVWdMeThnWm5Wc2JDQmhjbkpoZVFvSmJHOWhaQ0F5TlRVZ0x5OGdablZzYkNCaGNuSmhlUW9KY0hWemFHSjVkR1Z6SURCNE1EQXdNREF3TURBd01EQXdNREF3TWdvSmNtVndiR0ZqWlRJZ09Rb0pabkpoYldWZlluVnllU0F3SUM4dklISmxkRlpoYkRvZ1ZEa0tDZ2t2THlCMFpYTjBjeTlqYjI1MGNtRmpkSE12WVdKcExtRnNaMjh1ZEhNNk1UWXlOUW9KTHk4Z2NtVjBkWEp1SUhKbGRGWmhiRHNLQ1daeVlXMWxYMlJwWnlBd0lDOHZJSEpsZEZaaGJEb2dWRGtLQ2drdkx5QnpaWFFnZEdobElITjFZbkp2ZFhScGJtVWdjbVYwZFhKdUlIWmhiSFZsQ2dsbWNtRnRaVjlpZFhKNUlEQUtDWEpsZEhOMVlnb0tLbUZpYVY5eWIzVjBaVjlqY21WaGRHVkJjSEJzYVdOaGRHbHZiam9LQ1dsdWRHTWdNU0F2THlBeENnbHlaWFIxY200S0NpcGpjbVZoZEdWZlRtOVBjRG9LQ1hCMWMyaGllWFJsY3lBd2VHSTRORFEzWWpNMklDOHZJRzFsZEdodlpDQWlZM0psWVhSbFFYQndiR2xqWVhScGIyNG9LWFp2YVdRaUNnbDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2dsdFlYUmphQ0FxWVdKcFgzSnZkWFJsWDJOeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1Q2dvSkx5OGdkR2hwY3lCamIyNTBjbUZqZENCa2IyVnpJRzV2ZENCcGJYQnNaVzFsYm5RZ2RHaGxJR2RwZG1WdUlFRkNTU0J0WlhSb2IyUWdabTl5SUdOeVpXRjBaU0JPYjA5d0NnbGxjbklLQ2lwallXeHNYMDV2VDNBNkNnbHdkWE5vWW5sMFpYTWdNSGhsT0dVMFkyWmpOU0F2THlCdFpYUm9iMlFnSW5CdmMzUkNiMjlzVkhWd2JHVlBabVp6WlhRb0tTaGliMjlzTEhWcGJuUTJOQ3gxYVc1ME5qUXBJZ29KZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb0piV0YwWTJnZ0ttRmlhVjl5YjNWMFpWOXdiM04wUW05dmJGUjFjR3hsVDJabWMyVjBDZ29KTHk4Z2RHaHBjeUJqYjI1MGNtRmpkQ0JrYjJWeklHNXZkQ0JwYlhCc1pXMWxiblFnZEdobElHZHBkbVZ1SUVGQ1NTQnRaWFJvYjJRZ1ptOXlJR05oYkd3Z1RtOVBjQW9KWlhKeSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQ0FBRW1BUWdBQUFBQUFBQUFBREVZRklFR0N6RVpDSTBNQUdjQUFBQUFBQUFBQUFBQUFGa0FBQUFBQUFBQUFBQUFBSUFFRlI5OGRZZ0FCRkN3STBPS0FBR0FBSUFCQUNKSlZDaFFLRkNNQUlzQU5mODAveUlqVkl3QWl3QTEvelQvZ0FnQUFBQUFBQUFBQVZ3QmpBQ0xBRFgvTlArQUNBQUFBQUFBQUFBQ1hBbU1BSXNBakFDSkkwT0FCTGhFZXpZMkdnQ09BZi94QUlBRTZPVFB4VFlhQUk0Qi80MEEiLCJjbGVhciI6IkNnPT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoiYWxnb2QiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo0LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6IjdiNjA3Y2U0In19LCJldmVudHMiOm51bGwsInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
