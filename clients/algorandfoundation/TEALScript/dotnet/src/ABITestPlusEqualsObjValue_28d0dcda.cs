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

namespace Arc56.Generated.algorandfoundation.TEALScript.ABITestPlusEqualsObjValue_28d0dcda
{


    public class ABITestPlusEqualsObjValueProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ABITestPlusEqualsObjValueProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class FooUint64BarUint64 : AVMObjectType
            {
                public ulong Foo { get; set; }

                public ulong Bar { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFoo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFoo.From(Foo);
                    ret.AddRange(vFoo.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBar = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBar.From(Bar);
                    ret.AddRange(vBar.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static FooUint64BarUint64 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new FooUint64BarUint64();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFoo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFoo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFoo = vFoo.ToValue();
                    if (valueFoo is ulong vFooValue) { ret.Foo = vFooValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBar = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBar.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBar = vBar.ToValue();
                    if (valueBar is ulong vBarValue) { ret.Bar = vBarValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as FooUint64BarUint64);
                }
                public bool Equals(FooUint64BarUint64? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(FooUint64BarUint64 left, FooUint64BarUint64 right)
                {
                    return EqualityComparer<FooUint64BarUint64>.Default.Equals(left, right);
                }
                public static bool operator !=(FooUint64BarUint64 left, FooUint64BarUint64 right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.FooUint64BarUint64> PlusEqualsObjValue(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 41, 248, 111, 140 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.FooUint64BarUint64.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> PlusEqualsObjValue_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 41, 248, 111, 140 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJBQklUZXN0UGx1c0VxdWFsc09ialZhbHVlIiwiZGVzYyI6IiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJ7IGZvbzogdWludDY0OyBiYXI6IHVpbnQ2NDsgfSI6W3sibmFtZSI6ImZvbyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJiYXIiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InBsdXNFcXVhbHNPYmpWYWx1ZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJ7IGZvbzogdWludDY0OyBiYXI6IHVpbnQ2NDsgfSIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlswXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTIzOSJ9LHsicGMiOlsxLDIsM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyMzkifSx7InBjIjpbNCw1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyMzkifSx7InBjIjpbNl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjM5In0seyJwYyI6WzcsOF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjM5In0seyJwYyI6WzldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTIzOSJ9LHsicGMiOlsxMCwxMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjM5In0seyJwYyI6WzEyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxOSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyMzkifSx7InBjIjpbMTMsMTQsMTUsMTYsMTcsMTgsMTksMjAsMjEsMjIsMjMsMjQsMjUsMjYsMjcsMjgsMjksMzAsMzEsMzIsMzMsMzQsMzUsMzYsMzcsMzhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTIzOSJ9LHsicGMiOlszOV0sImVycm9yTWVzc2FnZSI6IlRoZSByZXF1ZXN0ZWQgYWN0aW9uIGlzIG5vdCBpbXBsZW1lbnRlZCBpbiB0aGlzIGNvbnRyYWN0LiBBcmUgeW91IHVzaW5nIHRoZSBjb3JyZWN0IE9uQ29tcGxldGU/IERpZCB5b3Ugc2V0IHlvdXIgYXBwIElEPyIsInRlYWwiOjI0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTIzOSJ9LHsicGMiOls0MCw0MSw0Miw0Myw0NCw0NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjQwIn0seyJwYyI6WzQ2LDQ3LDQ4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyNDAifSx7InBjIjpbNDldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTI0MCJ9LHsicGMiOls1MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjQwIn0seyJwYyI6WzUxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyNDAifSx7InBjIjpbNTJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTI0MCJ9LHsicGMiOls1Myw1NCw1NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjQwIn0seyJwYyI6WzU2LDU3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyNDAifSx7InBjIjpbNTgsNTksNjAsNjEsNjIsNjMsNjQsNjUsNjYsNjcsNjgsNjksNzAsNzEsNzIsNzMsNzQsNzVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQ3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTI0MSJ9LHsicGMiOls3Niw3N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjQxIn0seyJwYyI6Wzc4LDc5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyNDIifSx7InBjIjpbODAsODFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjUzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTI0MiJ9LHsicGMiOls4Miw4M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjQyIn0seyJwYyI6Wzg0LDg1LDg2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1NSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyNDIifSx7InBjIjpbODddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTI0MiJ9LHsicGMiOls4OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjQyIn0seyJwYyI6Wzg5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1OCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyNDIifSx7InBjIjpbOTBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTI0MiJ9LHsicGMiOls5MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjQyIn0seyJwYyI6WzkyLDkzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyNDIifSx7InBjIjpbOTQsOTVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTI0MyJ9LHsicGMiOls5Niw5N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjQwIn0seyJwYyI6Wzk4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2OSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyNDAifSx7InBjIjpbOTldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjcyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTIzOSJ9LHsicGMiOlsxMDBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjczLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTIzOSJ9LHsicGMiOlsxMDEsMTAyLDEwMywxMDQsMTA1LDEwNl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjM5In0seyJwYyI6WzEwNywxMDgsMTA5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3Nywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyMzkifSx7InBjIjpbMTEwLDExMSwxMTIsMTEzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3OCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyMzkifSx7InBjIjpbMTE0XSwiZXJyb3JNZXNzYWdlIjoidGhpcyBjb250cmFjdCBkb2VzIG5vdCBpbXBsZW1lbnQgdGhlIGdpdmVuIEFCSSBtZXRob2QgZm9yIGNyZWF0ZSBOb09wIiwidGVhbCI6ODEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjM5In0seyJwYyI6WzExNSwxMTYsMTE3LDExOCwxMTksMTIwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyMzkifSx7InBjIjpbMTIxLDEyMiwxMjNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjg1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTIzOSJ9LHsicGMiOlsxMjQsMTI1LDEyNiwxMjddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjg2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTIzOSJ9LHsicGMiOlsxMjhdLCJlcnJvck1lc3NhZ2UiOiJ0aGlzIGNvbnRyYWN0IGRvZXMgbm90IGltcGxlbWVudCB0aGUgZ2l2ZW4gQUJJIG1ldGhvZCBmb3IgY2FsbCBOb09wIiwidGVhbCI6ODksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjM5In1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q21sdWRHTmliRzlqYXlBeENnb3ZMeUJVYUdseklGUkZRVXdnZDJGeklHZGxibVZ5WVhSbFpDQmllU0JVUlVGTVUyTnlhWEIwSUhZd0xqRXdOeTR5Q2k4dklHaDBkSEJ6T2k4dloybDBhSFZpTG1OdmJTOWhiR2R2Y21GdVpHWnZkVzVrWVhScGIyNHZWRVZCVEZOamNtbHdkQW9LTHk4Z1ZHaHBjeUJqYjI1MGNtRmpkQ0JwY3lCamIyMXdiR2xoYm5RZ2QybDBhQ0JoYm1RdmIzSWdhVzF3YkdWdFpXNTBjeUIwYUdVZ1ptOXNiRzkzYVc1bklFRlNRM002SUZzZ1FWSkROQ0JkQ2dvdkx5QlVhR1VnWm05c2JHOTNhVzVuSUhSbGJpQnNhVzVsY3lCdlppQlVSVUZNSUdoaGJtUnNaU0JwYm1sMGFXRnNJSEJ5YjJkeVlXMGdabXh2ZHdvdkx5QlVhR2x6SUhCaGRIUmxjbTRnYVhNZ2RYTmxaQ0IwYnlCdFlXdGxJR2wwSUdWaGMza2dabTl5SUdGdWVXOXVaU0IwYnlCd1lYSnpaU0IwYUdVZ2MzUmhjblFnYjJZZ2RHaGxJSEJ5YjJkeVlXMGdZVzVrSUdSbGRHVnliV2x1WlNCcFppQmhJSE53WldOcFptbGpJR0ZqZEdsdmJpQnBjeUJoYkd4dmQyVmtDaTh2SUVobGNtVXNJR0ZqZEdsdmJpQnlaV1psY25NZ2RHOGdkR2hsSUU5dVEyOXRjR3hsZEdVZ2FXNGdZMjl0WW1sdVlYUnBiMjRnZDJsMGFDQjNhR1YwYUdWeUlIUm9aU0JoY0hBZ2FYTWdZbVZwYm1jZ1kzSmxZWFJsWkNCdmNpQmpZV3hzWldRS0x5OGdSWFpsY25rZ2NHOXpjMmxpYkdVZ1lXTjBhVzl1SUdadmNpQjBhR2x6SUdOdmJuUnlZV04wSUdseklISmxjSEpsYzJWdWRHVmtJR2x1SUhSb1pTQnpkMmwwWTJnZ2MzUmhkR1Z0Wlc1MENpOHZJRWxtSUhSb1pTQmhZM1JwYjI0Z2FYTWdibTkwSUdsdGNHeGxiV1Z1ZEdWa0lHbHVJSFJvWlNCamIyNTBjbUZqZEN3Z2FYUnpJSEpsYzNCbFkzUnBkbVVnWW5KaGJtTm9JSGRwYkd3Z1ltVWdJaXBPVDFSZlNVMVFURVZOUlU1VVJVUWlJSGRvYVdOb0lHcDFjM1FnWTI5dWRHRnBibk1nSW1WeWNpSUtkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJUXB3ZFhOb2FXNTBJRFlLS2dwMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lzS2MzZHBkR05vSUNwallXeHNYMDV2VDNBZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BqY21WaGRHVmZUbTlQY0NBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUUtDaXBPVDFSZlNVMVFURVZOUlU1VVJVUTZDZ2t2THlCVWFHVWdjbVZ4ZFdWemRHVmtJR0ZqZEdsdmJpQnBjeUJ1YjNRZ2FXMXdiR1Z0Wlc1MFpXUWdhVzRnZEdocGN5QmpiMjUwY21GamRDNGdRWEpsSUhsdmRTQjFjMmx1WnlCMGFHVWdZMjl5Y21WamRDQlBia052YlhCc1pYUmxQeUJFYVdRZ2VXOTFJSE5sZENCNWIzVnlJR0Z3Y0NCSlJEOEtDV1Z5Y2dvS0x5OGdjR3gxYzBWeGRXRnNjMDlpYWxaaGJIVmxLQ2tvZFdsdWREWTBMSFZwYm5RMk5Da0tLbUZpYVY5eWIzVjBaVjl3YkhWelJYRjFZV3h6VDJKcVZtRnNkV1U2Q2drdkx5QlVhR1VnUVVKSklISmxkSFZ5YmlCd2NtVm1hWGdLQ1hCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMUNnb0pMeThnWlhobFkzVjBaU0J3YkhWelJYRjFZV3h6VDJKcVZtRnNkV1VvS1NoMWFXNTBOalFzZFdsdWREWTBLUW9KWTJGc2JITjFZaUJ3YkhWelJYRjFZV3h6VDJKcVZtRnNkV1VLQ1dOdmJtTmhkQW9KYkc5bkNnbHBiblJqSURBZ0x5OGdNUW9KY21WMGRYSnVDZ292THlCd2JIVnpSWEYxWVd4elQySnFWbUZzZFdVb0tUb2dleUJtYjI4NklIVnBiblEyTkRzZ1ltRnlPaUIxYVc1ME5qUWdmUXB3YkhWelJYRjFZV3h6VDJKcVZtRnNkV1U2Q2dsd2NtOTBieUF3SURFS0Nna3ZMeUJRZFhOb0lHVnRjSFI1SUdKNWRHVnpJR0ZtZEdWeUlIUm9aU0JtY21GdFpTQndiMmx1ZEdWeUlIUnZJSEpsYzJWeWRtVWdjM0JoWTJVZ1ptOXlJR3h2WTJGc0lIWmhjbWxoWW14bGN3b0pjSFZ6YUdKNWRHVnpJREI0Q2dvSkx5OGdkR1Z6ZEhNdlkyOXVkSEpoWTNSekwyRmlhUzVoYkdkdkxuUnpPakV5TkRFS0NTOHZJR0U2SUhzZ1ptOXZPaUIxYVc1ME5qUTdJR0poY2pvZ2RXbHVkRFkwSUgwZ1BTQjdJR1p2YnpvZ015d2dZbUZ5T2lBMElIMEtDWEIxYzJoaWVYUmxjeUF3ZURBd01EQXdNREF3TURBd01EQXdNRE13TURBd01EQXdNREF3TURBd01EQTBDZ2xtY21GdFpWOWlkWEo1SURBZ0x5OGdZVG9nZXlCbWIyODZJSFZwYm5RMk5Ec2dZbUZ5T2lCMWFXNTBOalFnZlFvS0NTOHZJSFJsYzNSekwyTnZiblJ5WVdOMGN5OWhZbWt1WVd4bmJ5NTBjem94TWpReUNna3ZMeUJoTG1KaGNpQXJQU0F4Q2dsbWNtRnRaVjlrYVdjZ01DQXZMeUJoT2lCN0lHWnZiem9nZFdsdWREWTBPeUJpWVhJNklIVnBiblEyTkNCOUNnbHdkWE5vYVc1MElEZ2dMeThnYUdWaFpFOW1abk5sZEFvSlpuSmhiV1ZmWkdsbklEQWdMeThnWVRvZ2V5Qm1iMjg2SUhWcGJuUTJORHNnWW1GeU9pQjFhVzUwTmpRZ2ZRb0paWGgwY21GamRDQTRJRGdLQ1dKMGIya0tDV2x1ZEdNZ01DQXZMeUF4Q2drckNnbHBkRzlpQ2dseVpYQnNZV05sTXdvSlpuSmhiV1ZmWW5WeWVTQXdJQzh2SUdFNklIc2dabTl2T2lCMWFXNTBOalE3SUdKaGNqb2dkV2x1ZERZMElIMEtDZ2t2THlCMFpYTjBjeTlqYjI1MGNtRmpkSE12WVdKcExtRnNaMjh1ZEhNNk1USTBNd29KTHk4Z2NtVjBkWEp1SUdFN0NnbG1jbUZ0WlY5a2FXY2dNQ0F2THlCaE9pQjdJR1p2YnpvZ2RXbHVkRFkwT3lCaVlYSTZJSFZwYm5RMk5DQjlDZ29KTHk4Z2MyVjBJSFJvWlNCemRXSnliM1YwYVc1bElISmxkSFZ5YmlCMllXeDFaUW9KWm5KaGJXVmZZblZ5ZVNBd0NnbHlaWFJ6ZFdJS0NpcGhZbWxmY205MWRHVmZZM0psWVhSbFFYQndiR2xqWVhScGIyNDZDZ2xwYm5SaklEQWdMeThnTVFvSmNtVjBkWEp1Q2dvcVkzSmxZWFJsWDA1dlQzQTZDZ2x3ZFhOb1lubDBaWE1nTUhoaU9EUTBOMkl6TmlBdkx5QnRaWFJvYjJRZ0ltTnlaV0YwWlVGd2NHeHBZMkYwYVc5dUtDbDJiMmxrSWdvSmRIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9KYldGMFkyZ2dLbUZpYVY5eWIzVjBaVjlqY21WaGRHVkJjSEJzYVdOaGRHbHZiZ29LQ1M4dklIUm9hWE1nWTI5dWRISmhZM1FnWkc5bGN5QnViM1FnYVcxd2JHVnRaVzUwSUhSb1pTQm5hWFpsYmlCQlFra2diV1YwYUc5a0lHWnZjaUJqY21WaGRHVWdUbTlQY0FvSlpYSnlDZ29xWTJGc2JGOU9iMDl3T2dvSmNIVnphR0o1ZEdWeklEQjRNamxtT0RabU9HTWdMeThnYldWMGFHOWtJQ0p3YkhWelJYRjFZV3h6VDJKcVZtRnNkV1VvS1NoMWFXNTBOalFzZFdsdWREWTBLU0lLQ1hSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtDVzFoZEdOb0lDcGhZbWxmY205MWRHVmZjR3gxYzBWeGRXRnNjMDlpYWxaaGJIVmxDZ29KTHk4Z2RHaHBjeUJqYjI1MGNtRmpkQ0JrYjJWeklHNXZkQ0JwYlhCc1pXMWxiblFnZEdobElHZHBkbVZ1SUVGQ1NTQnRaWFJvYjJRZ1ptOXlJR05oYkd3Z1RtOVBjQW9KWlhKeSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQkFURVlGSUVHQ3pFWkNJME1BRXdBQUFBQUFBQUFBQUFBQUQ0QUFBQUFBQUFBQUFBQUFJQUVGUjk4ZFlnQUJGQ3dJa09LQUFHQUFJQVFBQUFBQUFBQUFBTUFBQUFBQUFBQUJJd0Fpd0NCQ0lzQVZ3Z0lGeUlJRmwyTUFJc0FqQUNKSWtPQUJMaEVlelkyR2dDT0FmL3hBSUFFS2ZodmpEWWFBSTRCLzZnQSIsImNsZWFyIjoiQ2c9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJhbGdvZCIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjQsInBhdGNoIjoxLCJjb21taXRIYXNoIjoiN2I2MDdjZTQifX0sImV2ZW50cyI6bnVsbCwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
