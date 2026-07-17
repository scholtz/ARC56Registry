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

namespace Arc56.Generated.algorandfoundation.TEALScript.ContractWithCustomStruct_983e8a06
{


    public class ContractWithCustomStructProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ContractWithCustomStructProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class AnotherCustomStruct : AVMObjectType
            {
                public ulong B { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
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

                public static AnotherCustomStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new AnotherCustomStruct();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vB.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueB = vB.ToValue();
                    if (valueB is ulong vBValue) { ret.B = vBValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AnotherCustomStruct);
                }
                public bool Equals(AnotherCustomStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AnotherCustomStruct left, AnotherCustomStruct right)
                {
                    return EqualityComparer<AnotherCustomStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(AnotherCustomStruct left, AnotherCustomStruct right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="input"> AnotherCustomStruct</param>
        public async Task<Structs.AnotherCustomStruct> CustomStructMethod(Structs.AnotherCustomStruct input, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 34, 115, 154 };

            var result = await base.CallApp(new List<object> { abiHandle, input }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.AnotherCustomStruct.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> CustomStructMethod_Transactions(Structs.AnotherCustomStruct input, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 34, 115, 154 };

            return await base.MakeTransactionList(new List<object> { abiHandle, input }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJDb250cmFjdFdpdGhDdXN0b21TdHJ1Y3QiLCJkZXNjIjoiIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkFub3RoZXJDdXN0b21TdHJ1Y3QiOlt7Im5hbWUiOiJiIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjdXN0b21TdHJ1Y3RNZXRob2QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCkiLCJzdHJ1Y3QiOiJBbm90aGVyQ3VzdG9tU3RydWN0IiwibmFtZSI6ImlucHV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQpIiwic3RydWN0IjoiQW5vdGhlckN1c3RvbVN0cnVjdCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlswXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UtZXh0ZXJuYWwuYWxnby50czoxOSJ9LHsicGMiOlsxLDIsM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLWV4dGVybmFsLmFsZ28udHM6MTkifSx7InBjIjpbNCw1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLWV4dGVybmFsLmFsZ28udHM6MTkifSx7InBjIjpbNl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS1leHRlcm5hbC5hbGdvLnRzOjE5In0seyJwYyI6WzcsOF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS1leHRlcm5hbC5hbGdvLnRzOjE5In0seyJwYyI6WzldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UtZXh0ZXJuYWwuYWxnby50czoxOSJ9LHsicGMiOlsxMCwxMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS1leHRlcm5hbC5hbGdvLnRzOjE5In0seyJwYyI6WzEyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxOSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLWV4dGVybmFsLmFsZ28udHM6MTkifSx7InBjIjpbMTMsMTQsMTUsMTYsMTcsMTgsMTksMjAsMjEsMjIsMjMsMjQsMjUsMjYsMjcsMjgsMjksMzAsMzEsMzIsMzMsMzQsMzUsMzYsMzcsMzhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UtZXh0ZXJuYWwuYWxnby50czoxOSJ9LHsicGMiOlszOV0sImVycm9yTWVzc2FnZSI6IlRoZSByZXF1ZXN0ZWQgYWN0aW9uIGlzIG5vdCBpbXBsZW1lbnRlZCBpbiB0aGlzIGNvbnRyYWN0LiBBcmUgeW91IHVzaW5nIHRoZSBjb3JyZWN0IE9uQ29tcGxldGU/IERpZCB5b3Ugc2V0IHlvdXIgYXBwIElEPyIsInRlYWwiOjI0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UtZXh0ZXJuYWwuYWxnby50czoxOSJ9LHsicGMiOls0MCw0MSw0Miw0Myw0NCw0NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS1leHRlcm5hbC5hbGdvLnRzOjIwIn0seyJwYyI6WzQ2LDQ3LDQ4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLWV4dGVybmFsLmFsZ28udHM6MjAifSx7InBjIjpbNDldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UtZXh0ZXJuYWwuYWxnby50czoyMCJ9LHsicGMiOls1MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS1leHRlcm5hbC5hbGdvLnRzOjIwIn0seyJwYyI6WzUxLDUyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLWV4dGVybmFsLmFsZ28udHM6MjAifSx7InBjIjpbNTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UtZXh0ZXJuYWwuYWxnby50czoyMCJ9LHsicGMiOls1NF0sImVycm9yTWVzc2FnZSI6ImFyZ3VtZW50IDAgKGlucHV0KSBmb3IgY3VzdG9tU3RydWN0TWV0aG9kIG11c3QgYmUgYSAodWludDY0KSIsInRlYWwiOjM5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UtZXh0ZXJuYWwuYWxnby50czoyMCJ9LHsicGMiOls1NSw1Niw1N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS1leHRlcm5hbC5hbGdvLnRzOjIwIn0seyJwYyI6WzU4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLWV4dGVybmFsLmFsZ28udHM6MjAifSx7InBjIjpbNTldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQ0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UtZXh0ZXJuYWwuYWxnby50czoyMCJ9LHsicGMiOls2MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS1leHRlcm5hbC5hbGdvLnRzOjIwIn0seyJwYyI6WzYxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLWV4dGVybmFsLmFsZ28udHM6MjAifSx7InBjIjpbNjIsNjMsNjRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjUwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UtZXh0ZXJuYWwuYWxnby50czoyMCJ9LHsicGMiOls2NSw2Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS1leHRlcm5hbC5hbGdvLnRzOjIxIn0seyJwYyI6WzY3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1NSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLWV4dGVybmFsLmFsZ28udHM6MjAifSx7InBjIjpbNjhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UtZXh0ZXJuYWwuYWxnby50czoxOSJ9LHsicGMiOls2OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS1leHRlcm5hbC5hbGdvLnRzOjE5In0seyJwYyI6WzcwLDcxLDcyLDczLDc0LDc1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLWV4dGVybmFsLmFsZ28udHM6MTkifSx7InBjIjpbNzYsNzcsNzhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjYzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UtZXh0ZXJuYWwuYWxnby50czoxOSJ9LHsicGMiOls3OSw4MCw4MSw4Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS1leHRlcm5hbC5hbGdvLnRzOjE5In0seyJwYyI6WzgzXSwiZXJyb3JNZXNzYWdlIjoidGhpcyBjb250cmFjdCBkb2VzIG5vdCBpbXBsZW1lbnQgdGhlIGdpdmVuIEFCSSBtZXRob2QgZm9yIGNyZWF0ZSBOb09wIiwidGVhbCI6NjcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS1leHRlcm5hbC5hbGdvLnRzOjE5In0seyJwYyI6Wzg0LDg1LDg2LDg3LDg4LDg5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3MCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLWV4dGVybmFsLmFsZ28udHM6MTkifSx7InBjIjpbOTAsOTEsOTJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjcxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UtZXh0ZXJuYWwuYWxnby50czoxOSJ9LHsicGMiOls5Myw5NCw5NSw5Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS1leHRlcm5hbC5hbGdvLnRzOjE5In0seyJwYyI6Wzk3XSwiZXJyb3JNZXNzYWdlIjoidGhpcyBjb250cmFjdCBkb2VzIG5vdCBpbXBsZW1lbnQgdGhlIGdpdmVuIEFCSSBtZXRob2QgZm9yIGNhbGwgTm9PcCIsInRlYWwiOjc1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UtZXh0ZXJuYWwuYWxnby50czoxOSJ9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NtbHVkR05pYkc5amF5QXhDZ292THlCVWFHbHpJRlJGUVV3Z2QyRnpJR2RsYm1WeVlYUmxaQ0JpZVNCVVJVRk1VMk55YVhCMElIWXdMakV3Tnk0eUNpOHZJR2gwZEhCek9pOHZaMmwwYUhWaUxtTnZiUzloYkdkdmNtRnVaR1p2ZFc1a1lYUnBiMjR2VkVWQlRGTmpjbWx3ZEFvS0x5OGdWR2hwY3lCamIyNTBjbUZqZENCcGN5QmpiMjF3YkdsaGJuUWdkMmwwYUNCaGJtUXZiM0lnYVcxd2JHVnRaVzUwY3lCMGFHVWdabTlzYkc5M2FXNW5JRUZTUTNNNklGc2dRVkpETkNCZENnb3ZMeUJVYUdVZ1ptOXNiRzkzYVc1bklIUmxiaUJzYVc1bGN5QnZaaUJVUlVGTUlHaGhibVJzWlNCcGJtbDBhV0ZzSUhCeWIyZHlZVzBnWm14dmR3b3ZMeUJVYUdseklIQmhkSFJsY200Z2FYTWdkWE5sWkNCMGJ5QnRZV3RsSUdsMElHVmhjM2tnWm05eUlHRnVlVzl1WlNCMGJ5QndZWEp6WlNCMGFHVWdjM1JoY25RZ2IyWWdkR2hsSUhCeWIyZHlZVzBnWVc1a0lHUmxkR1Z5YldsdVpTQnBaaUJoSUhOd1pXTnBabWxqSUdGamRHbHZiaUJwY3lCaGJHeHZkMlZrQ2k4dklFaGxjbVVzSUdGamRHbHZiaUJ5WldabGNuTWdkRzhnZEdobElFOXVRMjl0Y0d4bGRHVWdhVzRnWTI5dFltbHVZWFJwYjI0Z2QybDBhQ0IzYUdWMGFHVnlJSFJvWlNCaGNIQWdhWE1nWW1WcGJtY2dZM0psWVhSbFpDQnZjaUJqWVd4c1pXUUtMeThnUlhabGNua2djRzl6YzJsaWJHVWdZV04wYVc5dUlHWnZjaUIwYUdseklHTnZiblJ5WVdOMElHbHpJSEpsY0hKbGMyVnVkR1ZrSUdsdUlIUm9aU0J6ZDJsMFkyZ2djM1JoZEdWdFpXNTBDaTh2SUVsbUlIUm9aU0JoWTNScGIyNGdhWE1nYm05MElHbHRjR3hsYldWdWRHVmtJR2x1SUhSb1pTQmpiMjUwY21GamRDd2dhWFJ6SUhKbGMzQmxZM1JwZG1VZ1luSmhibU5vSUhkcGJHd2dZbVVnSWlwT1QxUmZTVTFRVEVWTlJVNVVSVVFpSUhkb2FXTm9JR3AxYzNRZ1kyOXVkR0ZwYm5NZ0ltVnljaUlLZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSVFwd2RYTm9hVzUwSURZS0tncDBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpc0tjM2RwZEdOb0lDcGpZV3hzWDA1dlQzQWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwamNtVmhkR1ZmVG05UGNDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFLQ2lwT1QxUmZTVTFRVEVWTlJVNVVSVVE2Q2drdkx5QlVhR1VnY21WeGRXVnpkR1ZrSUdGamRHbHZiaUJwY3lCdWIzUWdhVzF3YkdWdFpXNTBaV1FnYVc0Z2RHaHBjeUJqYjI1MGNtRmpkQzRnUVhKbElIbHZkU0IxYzJsdVp5QjBhR1VnWTI5eWNtVmpkQ0JQYmtOdmJYQnNaWFJsUHlCRWFXUWdlVzkxSUhObGRDQjViM1Z5SUdGd2NDQkpSRDhLQ1dWeWNnb0tMeThnWTNWemRHOXRVM1J5ZFdOMFRXVjBhRzlrS0NoMWFXNTBOalFwS1NoMWFXNTBOalFwQ2lwaFltbGZjbTkxZEdWZlkzVnpkRzl0VTNSeWRXTjBUV1YwYUc5a09nb0pMeThnVkdobElFRkNTU0J5WlhSMWNtNGdjSEpsWm1sNENnbHdkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOUW9LQ1M4dklHbHVjSFYwT2lBb2RXbHVkRFkwS1FvSmRIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9KWkhWd0NnbHNaVzRLQ1hCMWMyaHBiblFnT0FvSlBUMEtDZ2t2THlCaGNtZDFiV1Z1ZENBd0lDaHBibkIxZENrZ1ptOXlJR04xYzNSdmJWTjBjblZqZEUxbGRHaHZaQ0J0ZFhOMElHSmxJR0VnS0hWcGJuUTJOQ2tLQ1dGemMyVnlkQW9LQ1M4dklHVjRaV04xZEdVZ1kzVnpkRzl0VTNSeWRXTjBUV1YwYUc5a0tDaDFhVzUwTmpRcEtTaDFhVzUwTmpRcENnbGpZV3hzYzNWaUlHTjFjM1J2YlZOMGNuVmpkRTFsZEdodlpBb0pZMjl1WTJGMENnbHNiMmNLQ1dsdWRHTWdNQ0F2THlBeENnbHlaWFIxY200S0NpOHZJR04xYzNSdmJWTjBjblZqZEUxbGRHaHZaQ2hwYm5CMWREb2dRVzV2ZEdobGNrTjFjM1J2YlZOMGNuVmpkQ2s2SUVGdWIzUm9aWEpEZFhOMGIyMVRkSEoxWTNRS1kzVnpkRzl0VTNSeWRXTjBUV1YwYUc5a09nb0pjSEp2ZEc4Z01TQXhDZ29KTHk4Z2RHVnpkSE12WTI5dWRISmhZM1J6TDJsdWFHVnlhWFJoYm1ObExXVjRkR1Z5Ym1Gc0xtRnNaMjh1ZEhNNk1qRUtDUzh2SUhKbGRIVnliaUJwYm5CMWREc0tDV1p5WVcxbFgyUnBaeUF0TVNBdkx5QnBibkIxZERvZ1FXNXZkR2hsY2tOMWMzUnZiVk4wY25WamRBb0pjbVYwYzNWaUNnb3FZV0pwWDNKdmRYUmxYMk55WldGMFpVRndjR3hwWTJGMGFXOXVPZ29KYVc1MFl5QXdJQzh2SURFS0NYSmxkSFZ5YmdvS0ttTnlaV0YwWlY5T2IwOXdPZ29KY0hWemFHSjVkR1Z6SURCNFlqZzBORGRpTXpZZ0x5OGdiV1YwYUc5a0lDSmpjbVZoZEdWQmNIQnNhV05oZEdsdmJpZ3BkbTlwWkNJS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLQ1cxaGRHTm9JQ3BoWW1sZmNtOTFkR1ZmWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRLQ2drdkx5QjBhR2x6SUdOdmJuUnlZV04wSUdSdlpYTWdibTkwSUdsdGNHeGxiV1Z1ZENCMGFHVWdaMmwyWlc0Z1FVSkpJRzFsZEdodlpDQm1iM0lnWTNKbFlYUmxJRTV2VDNBS0NXVnljZ29LS21OaGJHeGZUbTlQY0RvS0NYQjFjMmhpZVhSbGN5QXdlRGhrTWpJM016bGhJQzh2SUcxbGRHaHZaQ0FpWTNWemRHOXRVM1J5ZFdOMFRXVjBhRzlrS0NoMWFXNTBOalFwS1NoMWFXNTBOalFwSWdvSmRIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9KYldGMFkyZ2dLbUZpYVY5eWIzVjBaVjlqZFhOMGIyMVRkSEoxWTNSTlpYUm9iMlFLQ2drdkx5QjBhR2x6SUdOdmJuUnlZV04wSUdSdlpYTWdibTkwSUdsdGNHeGxiV1Z1ZENCMGFHVWdaMmwyWlc0Z1FVSkpJRzFsZEdodlpDQm1iM0lnWTJGc2JDQk9iMDl3Q2dsbGNuST0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFdyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUJBVEVZRklFR0N6RVpDSTBNQUMwQUFBQUFBQUFBQUFBQUFCOEFBQUFBQUFBQUFBQUFBSUFFRlI5OGRUWWFBVWtWZ1FnU1JJZ0FCRkN3SWtPS0FRR0wvNGtpUTRBRXVFUjdOallhQUk0Qi8vRUFnQVNOSW5PYU5ob0FqZ0gveHdBPSIsImNsZWFyIjoiQ2c9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJhbGdvZCIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjQsInBhdGNoIjoxLCJjb21taXRIYXNoIjoiN2I2MDdjZTQifX0sImV2ZW50cyI6bnVsbCwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
