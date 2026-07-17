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

namespace Arc56.Generated.algorandfoundation.TEALScript.ABITestBooleanLastInObj_af1ea9a5
{


    public class ABITestBooleanLastInObjProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ABITestBooleanLastInObjProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class NUint64BBoolean : AVMObjectType
            {
                public ulong N { get; set; }

                public bool B { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vN = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vN.From(N);
                    ret.AddRange(vN.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vB.From(B);
                    ret.AddRange(vB.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static NUint64BBoolean Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new NUint64BBoolean();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vN = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vN.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueN = vN.ToValue();
                    if (valueN is ulong vNValue) { ret.N = vNValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vB.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueB = vB.ToValue();
                    if (valueB is bool vBValue) { ret.B = vBValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as NUint64BBoolean);
                }
                public bool Equals(NUint64BBoolean? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(NUint64BBoolean left, NUint64BBoolean right)
                {
                    return EqualityComparer<NUint64BBoolean>.Default.Equals(left, right);
                }
                public static bool operator !=(NUint64BBoolean left, NUint64BBoolean right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.NUint64BBoolean> BooleanLastInObj(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 102, 200, 144, 202 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.NUint64BBoolean.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> BooleanLastInObj_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 102, 200, 144, 202 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJBQklUZXN0Qm9vbGVhbkxhc3RJbk9iaiIsImRlc2MiOiIiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsieyBuOiB1aW50NjQ7IGI6IGJvb2xlYW47IH0iOlt7Im5hbWUiOiJuIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImIiLCJ0eXBlIjoiYm9vbCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJib29sZWFuTGFzdEluT2JqIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsYm9vbCkiLCJzdHJ1Y3QiOiJ7IG46IHVpbnQ2NDsgYjogYm9vbGVhbjsgfSIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlswXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTI2MyJ9LHsicGMiOlsxLDIsMyw0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTI2MyJ9LHsicGMiOls1LDZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTI2MyJ9LHsicGMiOls3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyNjMifSx7InBjIjpbOCw5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyNjMifSx7InBjIjpbMTBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTI2MyJ9LHsicGMiOlsxMSwxMl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjYzIn0seyJwYyI6WzEzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxOSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyNjMifSx7InBjIjpbMTQsMTUsMTYsMTcsMTgsMTksMjAsMjEsMjIsMjMsMjQsMjUsMjYsMjcsMjgsMjksMzAsMzEsMzIsMzMsMzQsMzUsMzYsMzcsMzgsMzldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTI2MyJ9LHsicGMiOls0MF0sImVycm9yTWVzc2FnZSI6IlRoZSByZXF1ZXN0ZWQgYWN0aW9uIGlzIG5vdCBpbXBsZW1lbnRlZCBpbiB0aGlzIGNvbnRyYWN0LiBBcmUgeW91IHVzaW5nIHRoZSBjb3JyZWN0IE9uQ29tcGxldGU/IERpZCB5b3Ugc2V0IHlvdXIgYXBwIElEPyIsInRlYWwiOjI0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTI2MyJ9LHsicGMiOls0MSw0Miw0Myw0NCw0NSw0Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjY0In0seyJwYyI6WzQ3LDQ4LDQ5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyNjQifSx7InBjIjpbNTBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTI2NCJ9LHsicGMiOls1MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjY0In0seyJwYyI6WzUyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyNjQifSx7InBjIjpbNTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTI2NCJ9LHsicGMiOls1NCw1NSw1Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjY0In0seyJwYyI6WzU3LDU4LDU5LDYwLDYxLDYyLDYzLDY0LDY1LDY2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0Nywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyNjYifSx7InBjIjpbNjcsNjgsNjldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQ4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTI2NyJ9LHsicGMiOls3MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjY3In0seyJwYyI6WzcxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1MCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyNjcifSx7InBjIjpbNzJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjUxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTI2NyJ9LHsicGMiOls3M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjY1In0seyJwYyI6Wzc0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyNjQifSx7InBjIjpbNzVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTI2MyJ9LHsicGMiOls3Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjYzIn0seyJwYyI6Wzc3LDc4LDc5LDgwLDgxLDgyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2MCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyNjMifSx7InBjIjpbODMsODQsODVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjYxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTI2MyJ9LHsicGMiOls4Niw4Nyw4OCw4OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjYzIn0seyJwYyI6WzkwXSwiZXJyb3JNZXNzYWdlIjoidGhpcyBjb250cmFjdCBkb2VzIG5vdCBpbXBsZW1lbnQgdGhlIGdpdmVuIEFCSSBtZXRob2QgZm9yIGNyZWF0ZSBOb09wIiwidGVhbCI6NjUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjYzIn0seyJwYyI6WzkxLDkyLDkzLDk0LDk1LDk2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2OCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyNjMifSx7InBjIjpbOTcsOTgsOTldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTI2MyJ9LHsicGMiOlsxMDAsMTAxLDEwMiwxMDNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjcwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTI2MyJ9LHsicGMiOlsxMDRdLCJlcnJvck1lc3NhZ2UiOiJ0aGlzIGNvbnRyYWN0IGRvZXMgbm90IGltcGxlbWVudCB0aGUgZ2l2ZW4gQUJJIG1ldGhvZCBmb3IgY2FsbCBOb09wIiwidGVhbCI6NzMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjYzIn1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q21sdWRHTmliRzlqYXlBd0lERUtDaTh2SUZSb2FYTWdWRVZCVENCM1lYTWdaMlZ1WlhKaGRHVmtJR0o1SUZSRlFVeFRZM0pwY0hRZ2RqQXVNVEEzTGpJS0x5OGdhSFIwY0hNNkx5OW5hWFJvZFdJdVkyOXRMMkZzWjI5eVlXNWtabTkxYm1SaGRHbHZiaTlVUlVGTVUyTnlhWEIwQ2dvdkx5QlVhR2x6SUdOdmJuUnlZV04wSUdseklHTnZiWEJzYVdGdWRDQjNhWFJvSUdGdVpDOXZjaUJwYlhCc1pXMWxiblJ6SUhSb1pTQm1iMnhzYjNkcGJtY2dRVkpEY3pvZ1d5QkJVa00wSUYwS0NpOHZJRlJvWlNCbWIyeHNiM2RwYm1jZ2RHVnVJR3hwYm1WeklHOW1JRlJGUVV3Z2FHRnVaR3hsSUdsdWFYUnBZV3dnY0hKdlozSmhiU0JtYkc5M0NpOHZJRlJvYVhNZ2NHRjBkR1Z5YmlCcGN5QjFjMlZrSUhSdklHMWhhMlVnYVhRZ1pXRnplU0JtYjNJZ1lXNTViMjVsSUhSdklIQmhjbk5sSUhSb1pTQnpkR0Z5ZENCdlppQjBhR1VnY0hKdlozSmhiU0JoYm1RZ1pHVjBaWEp0YVc1bElHbG1JR0VnYzNCbFkybG1hV01nWVdOMGFXOXVJR2x6SUdGc2JHOTNaV1FLTHk4Z1NHVnlaU3dnWVdOMGFXOXVJSEpsWm1WeWN5QjBieUIwYUdVZ1QyNURiMjF3YkdWMFpTQnBiaUJqYjIxaWFXNWhkR2x2YmlCM2FYUm9JSGRvWlhSb1pYSWdkR2hsSUdGd2NDQnBjeUJpWldsdVp5QmpjbVZoZEdWa0lHOXlJR05oYkd4bFpBb3ZMeUJGZG1WeWVTQndiM056YVdKc1pTQmhZM1JwYjI0Z1ptOXlJSFJvYVhNZ1kyOXVkSEpoWTNRZ2FYTWdjbVZ3Y21WelpXNTBaV1FnYVc0Z2RHaGxJSE4zYVhSamFDQnpkR0YwWlcxbGJuUUtMeThnU1dZZ2RHaGxJR0ZqZEdsdmJpQnBjeUJ1YjNRZ2FXMXdiR1Z0Wlc1MFpXUWdhVzRnZEdobElHTnZiblJ5WVdOMExDQnBkSE1nY21WemNHVmpkR2wyWlNCaWNtRnVZMmdnZDJsc2JDQmlaU0FpS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0lnZDJocFkyZ2dhblZ6ZENCamIyNTBZV2x1Y3lBaVpYSnlJZ3AwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9oQ25CMWMyaHBiblFnTmdvcUNuUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0t3cHpkMmwwWTJnZ0ttTmhiR3hmVG05UGNDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS21OeVpXRjBaVjlPYjA5d0lDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQW9LS2s1UFZGOUpUVkJNUlUxRlRsUkZSRG9LQ1M4dklGUm9aU0J5WlhGMVpYTjBaV1FnWVdOMGFXOXVJR2x6SUc1dmRDQnBiWEJzWlcxbGJuUmxaQ0JwYmlCMGFHbHpJR052Ym5SeVlXTjBMaUJCY21VZ2VXOTFJSFZ6YVc1bklIUm9aU0JqYjNKeVpXTjBJRTl1UTI5dGNHeGxkR1UvSUVScFpDQjViM1VnYzJWMElIbHZkWElnWVhCd0lFbEVQd29KWlhKeUNnb3ZMeUJpYjI5c1pXRnVUR0Z6ZEVsdVQySnFLQ2tvZFdsdWREWTBMR0p2YjJ3cENpcGhZbWxmY205MWRHVmZZbTl2YkdWaGJreGhjM1JKYms5aWFqb0tDUzh2SUZSb1pTQkJRa2tnY21WMGRYSnVJSEJ5WldacGVBb0pjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelVLQ2drdkx5QmxlR1ZqZFhSbElHSnZiMnhsWVc1TVlYTjBTVzVQWW1vb0tTaDFhVzUwTmpRc1ltOXZiQ2tLQ1dOaGJHeHpkV0lnWW05dmJHVmhia3hoYzNSSmJrOWlhZ29KWTI5dVkyRjBDZ2xzYjJjS0NXbHVkR01nTVNBdkx5QXhDZ2x5WlhSMWNtNEtDaTh2SUdKdmIyeGxZVzVNWVhOMFNXNVBZbW9vS1RvZ2V5QnVPaUIxYVc1ME5qUTdJR0k2SUdKdmIyeGxZVzRnZlFwaWIyOXNaV0Z1VEdGemRFbHVUMkpxT2dvSmNISnZkRzhnTUNBeENnb0pMeThnZEdWemRITXZZMjl1ZEhKaFkzUnpMMkZpYVM1aGJHZHZMblJ6T2pFeU5qVUtDUzh2SUhKbGRIVnliaUI3Q2drdkx5QWdJQ0FnSUNCdU9pQXhMQW9KTHk4Z0lDQWdJQ0FnWWpvZ1ptRnNjMlVzQ2drdkx5QWdJQ0FnZlRzS0NYQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdNREF3TURBd01ERUtDWEIxYzJoaWVYUmxjeUF3ZURBd0NnbHBiblJqSURBZ0x5OGdNQW9KWkhWd0NnbHpaWFJpYVhRS0NXTnZibU5oZEFvSmNtVjBjM1ZpQ2dvcVlXSnBYM0p2ZFhSbFgyTnlaV0YwWlVGd2NHeHBZMkYwYVc5dU9nb0phVzUwWXlBeElDOHZJREVLQ1hKbGRIVnliZ29LS21OeVpXRjBaVjlPYjA5d09nb0pjSFZ6YUdKNWRHVnpJREI0WWpnME5EZGlNellnTHk4Z2JXVjBhRzlrSUNKamNtVmhkR1ZCY0hCc2FXTmhkR2x2YmlncGRtOXBaQ0lLQ1hSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtDVzFoZEdOb0lDcGhZbWxmY205MWRHVmZZM0psWVhSbFFYQndiR2xqWVhScGIyNEtDZ2t2THlCMGFHbHpJR052Ym5SeVlXTjBJR1J2WlhNZ2JtOTBJR2x0Y0d4bGJXVnVkQ0IwYUdVZ1oybDJaVzRnUVVKSklHMWxkR2h2WkNCbWIzSWdZM0psWVhSbElFNXZUM0FLQ1dWeWNnb0tLbU5oYkd4ZlRtOVBjRG9LQ1hCMWMyaGllWFJsY3lBd2VEWTJZemc1TUdOaElDOHZJRzFsZEdodlpDQWlZbTl2YkdWaGJreGhjM1JKYms5aWFpZ3BLSFZwYm5RMk5DeGliMjlzS1NJS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLQ1cxaGRHTm9JQ3BoWW1sZmNtOTFkR1ZmWW05dmJHVmhia3hoYzNSSmJrOWlhZ29LQ1M4dklIUm9hWE1nWTI5dWRISmhZM1FnWkc5bGN5QnViM1FnYVcxd2JHVnRaVzUwSUhSb1pTQm5hWFpsYmlCQlFra2diV1YwYUc5a0lHWnZjaUJqWVd4c0lFNXZUM0FLQ1dWeWNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFdyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUNBQUV4R0JTQkJnc3hHUWlOREFBekFBQUFBQUFBQUFBQUFBQWxBQUFBQUFBQUFBQUFBQUNBQkJVZmZIV0lBQVJRc0NORGlnQUJnQWdBQUFBQUFBQUFBWUFCQUNKSlZGQ0pJME9BQkxoRWV6WTJHZ0NPQWYveEFJQUVac2lReWpZYUFJNEIvOEVBIiwiY2xlYXIiOiJDZz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6ImFsZ29kIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6NCwicGF0Y2giOjEsImNvbW1pdEhhc2giOiI3YjYwN2NlNCJ9fSwiZXZlbnRzIjpudWxsLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
