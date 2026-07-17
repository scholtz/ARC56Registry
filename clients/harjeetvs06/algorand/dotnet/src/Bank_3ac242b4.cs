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

namespace Arc56.Generated.harjeetvs06.algorand.Bank_3ac242b4
{


    public class BankProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public BankProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetAllFieldsReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetAllFieldsReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetAllFieldsReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetAllFieldsReturn);
                }
                public bool Equals(GetAllFieldsReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetAllFieldsReturn left, GetAllFieldsReturn right)
                {
                    return EqualityComparer<GetAllFieldsReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetAllFieldsReturn left, GetAllFieldsReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Accepts a payment into the app escrow and records sender's deposited balance
        ///</summary>
        /// <param name="memo"> </param>
        /// <param name="pay_txn"> </param>
        public async Task<ulong> Deposit(PaymentTransaction pay_txn, string memo, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay_txn });
            byte[] abiHandle = { 159, 89, 124, 50 };
            var memoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); memoAbi.From(memo);

            var result = await base.CallApp(new List<object> { abiHandle, memoAbi, pay_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Deposit_Transactions(PaymentTransaction pay_txn, string memo, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay_txn });
            byte[] abiHandle = { 159, 89, 124, 50 };
            var memoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); memoAbi.From(memo);

            return await base.MakeTransactionList(new List<object> { abiHandle, memoAbi, pay_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Sends ALGO back to the caller from their recorded balance
        ///</summary>
        /// <param name="amount"> </param>
        public async Task<ulong> Withdraw(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 49, 33, 65, 118 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Withdraw_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 49, 33, 65, 118 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns all stored global fields and the caller's deposit (0 if none).
        ///</summary>
        public async Task<Structs.GetAllFieldsReturn> GetAllFields(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 183, 39, 117 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetAllFieldsReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetAllFields_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 183, 39, 117 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Constructor Bare Action
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.CreateApplication)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 193, 250, 21 };

            var result = await base.CallApp(new List<object> { }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.CreateApplication)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 193, 250, 21 };

            return await base.MakeTransactionList(new List<object> { }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQmFuayIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJHZXRBbGxGaWVsZHNSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJkZXBvc2l0IiwiZGVzYyI6IkFjY2VwdHMgYSBwYXltZW50IGludG8gdGhlIGFwcCBlc2Nyb3cgYW5kIHJlY29yZHMgc2VuZGVyJ3MgZGVwb3NpdGVkIGJhbGFuY2UiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibWVtbyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5X3R4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IndpdGhkcmF3IiwiZGVzYyI6IlNlbmRzIEFMR08gYmFjayB0byB0aGUgY2FsbGVyIGZyb20gdGhlaXIgcmVjb3JkZWQgYmFsYW5jZSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfYWxsX2ZpZWxkcyIsImRlc2MiOiJSZXR1cm5zIGFsbCBzdG9yZWQgZ2xvYmFsIGZpZWxkcyBhbmQgdGhlIGNhbGxlcidzIGRlcG9zaXQgKDAgaWYgbm9uZSkuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkdldEFsbEZpZWxkc1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxNzFdLCJlcnJvck1lc3NhZ2UiOiJEZXBvc2l0IGFtb3VudCBtdXN0IGJlIGdyZWF0ZXIgdGhhbiB6ZXJvIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjMzXSwiZXJyb3JNZXNzYWdlIjoiTm8gZGVwb3NpdHMgZm91bmQgZm9yIHRoaXMgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcyLDkzLDExNF0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2NV0sImVycm9yTWVzc2FnZSI6IlJlY2VpdmVyIG11c3QgYmUgdGhlIGNvbnRyYWN0IGFkZHJlc3MiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDJdLCJlcnJvck1lc3NhZ2UiOiJXaXRoZHJhd2FsIGFtb3VudCBleGNlZWRzIGJhbGFuY2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzZdLCJlcnJvck1lc3NhZ2UiOiJXaXRoZHJhd2FsIGFtb3VudCBtdXN0IGJlIGdyZWF0ZXIgdGhhbiB6ZXJvIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUyXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzUsOTYsMTE3XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxMF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZGVwb3NpdHMgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk3LDMwMV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfZGVwb3NpdCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzNdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WW1GdWF5NWpiMjUwY21GamRDNUNZVzVyTGw5ZllXeG5iM0I1WDJWdWRISjVjRzlwYm5SZmQybDBhRjlwYm1sMEtDa2dMVDRnZFdsdWREWTBPZ3B0WVdsdU9nb2dJQ0FnYVc1MFkySnNiMk5ySURFZ01Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBaWRHOTBZV3hmWkdWd2IzTnBkQ0lnTUhneE5URm1OMk0zTlFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySmhibXN2WTI5dWRISmhZM1F1Y0hrNk1USUtJQ0FnSUM4dklITmxiR1l1ZEc5MFlXeGZaR1Z3YjNOcGRDQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkRzkwWVd4ZlpHVndiM05wZENJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRnVheTlqYjI1MGNtRmpkQzV3ZVRvMkNpQWdJQ0F2THlCamJHRnpjeUJDWVc1cktFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWlZWEpsWDNKdmRYUnBibWRBT0FvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURsbU5UazNZek15SURCNE16RXlNVFF4TnpZZ01IZzFPV0kzTWpjM05TQXZMeUJ0WlhSb2IyUWdJbVJsY0c5emFYUW9jM1J5YVc1bkxIQmhlU2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbmRwZEdoa2NtRjNLSFZwYm5RMk5DbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltZGxkRjloYkd4ZlptbGxiR1J6S0Nrb2RXbHVkRFkwTEhWcGJuUTJOQ2tpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMlJsY0c5emFYUmZjbTkxZEdWQU5TQnRZV2x1WDNkcGRHaGtjbUYzWDNKdmRYUmxRRFlnYldGcGJsOW5aWFJmWVd4c1gyWnBaV3hrYzE5eWIzVjBaVUEzQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1UQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRnVheTlqYjI1MGNtRmpkQzV3ZVRvMkNpQWdJQ0F2THlCamJHRnpjeUJDWVc1cktFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEY5aGJHeGZabWxsYkdSelgzSnZkWFJsUURjNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1GdWF5OWpiMjUwY21GamRDNXdlVG8wTndvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUdkbGRGOWhiR3hmWm1sbGJHUnpDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkMmwwYUdSeVlYZGZjbTkxZEdWQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aVlXNXJMMk52Ym5SeVlXTjBMbkI1T2pJNUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKaGJtc3ZZMjl1ZEhKaFkzUXVjSGs2TmdvZ0lDQWdMeThnWTJ4aGMzTWdRbUZ1YXloQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySmhibXN2WTI5dWRISmhZM1F1Y0hrNk1qa0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ1kyRnNiSE4xWWlCM2FYUm9aSEpoZHdvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlrWlhCdmMybDBYM0p2ZFhSbFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRnVheTlqYjI1MGNtRmpkQzV3ZVRveE5Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aVlXNXJMMk52Ym5SeVlXTjBMbkI1T2pZS0lDQWdJQzh2SUdOc1lYTnpJRUpoYm1zb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpWVc1ckwyTnZiblJ5WVdOMExuQjVPakUwQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR05oYkd4emRXSWdaR1Z3YjNOcGRBb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aVlYSmxYM0p2ZFhScGJtZEFPRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlZVzVyTDJOdmJuUnlZV04wTG5CNU9qWUtJQ0FnSUM4dklHTnNZWE56SUVKaGJtc29RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVEFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJR055WldGMGFXNW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1KaGJtc3VZMjl1ZEhKaFkzUXVRbUZ1YXk1a1pYQnZjMmwwS0cxbGJXODZJR0o1ZEdWekxDQndZWGxmZEhodU9pQjFhVzUwTmpRcElDMCtJSFZwYm5RMk5Eb0taR1Z3YjNOcGREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aVlXNXJMMk52Ym5SeVlXTjBMbkI1T2pFMExURTFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lDOHZJR1JsWmlCa1pYQnZjMmwwS0hObGJHWXNJRzFsYlc4NklGTjBjbWx1Wnl3Z2NHRjVYM1I0YmpvZ1ozUjRiaTVRWVhsdFpXNTBWSEpoYm5OaFkzUnBiMjRwSUMwK0lGVkpiblEyTkRvS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySmhibXN2WTI5dWRISmhZM1F1Y0hrNk1UY0tJQ0FnSUM4dklHRnpjMlZ5ZENCd1lYbGZkSGh1TG5KbFkyVnBkbVZ5SUQwOUlFZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0lDSlNaV05sYVhabGNpQnRkWE4wSUdKbElIUm9aU0JqYjI1MGNtRmpkQ0JoWkdSeVpYTnpJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbmRIaHVjeUJTWldObGFYWmxjZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1VtVmpaV2wyWlhJZ2JYVnpkQ0JpWlNCMGFHVWdZMjl1ZEhKaFkzUWdZV1JrY21WemN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKaGJtc3ZZMjl1ZEhKaFkzUXVjSGs2TVRnS0lDQWdJQzh2SUdGemMyVnlkQ0J3WVhsZmRIaHVMbUZ0YjNWdWRDQStJREFzSUNKRVpYQnZjMmwwSUdGdGIzVnVkQ0J0ZFhOMElHSmxJR2R5WldGMFpYSWdkR2hoYmlCNlpYSnZJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtJQ0FnSUdSMWNBb2dJQ0FnWVhOelpYSjBJQzh2SUVSbGNHOXphWFFnWVcxdmRXNTBJRzExYzNRZ1ltVWdaM0psWVhSbGNpQjBhR0Z1SUhwbGNtOEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aVlXNXJMMk52Ym5SeVlXTjBMbkI1T2pJd0NpQWdJQ0F2THlCaGJXOTFiblFzSUdWNGFYTjBjeUE5SUhObGJHWXVaR1Z3YjNOcGRITXViV0Y1WW1Vb2NHRjVYM1I0Ymk1elpXNWtaWElwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHZDBlRzV6SUZObGJtUmxjZ29nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbUZ1YXk5amIyNTBjbUZqZEM1d2VUb3lNUW9nSUNBZ0x5OGdhV1lnWlhocGMzUnpPZ29nSUNBZ1lub2daR1Z3YjNOcGRGOWxiSE5sWDJKdlpIbEFNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySmhibXN2WTI5dWRISmhZM1F1Y0hrNk1qSUtJQ0FnSUM4dklITmxiR1l1WkdWd2IzTnBkSE5iY0dGNVgzUjRiaTV6Wlc1a1pYSmRJRDBnWVcxdmRXNTBJQ3NnY0dGNVgzUjRiaTVoYlc5MWJuUUtJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLQ21SbGNHOXphWFJmWVdaMFpYSmZhV1pmWld4elpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySmhibXN2WTI5dWRISmhZM1F1Y0hrNk1qWUtJQ0FnSUM4dklITmxiR1l1ZEc5MFlXeGZaR1Z3YjNOcGRDQXJQU0J3WVhsZmRIaHVMbUZ0YjNWdWRBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5SdmRHRnNYMlJsY0c5emFYUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5MFlXeGZaR1Z3YjNOcGRDQmxlR2x6ZEhNS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjBiM1JoYkY5a1pYQnZjMmwwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpWVc1ckwyTnZiblJ5WVdOMExuQjVPakkzQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1a1pYQnZjMmwwYzF0d1lYbGZkSGh1TG5ObGJtUmxjbDBLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVrWlhCdmMybDBjeUJsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNncGtaWEJ2YzJsMFgyVnNjMlZmWW05a2VVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySmhibXN2WTI5dWRISmhZM1F1Y0hrNk1qUUtJQ0FnSUM4dklITmxiR1l1WkdWd2IzTnBkSE5iY0dGNVgzUjRiaTV6Wlc1a1pYSmRJRDBnY0dGNVgzUjRiaTVoYlc5MWJuUUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JwZEc5aUNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnWWlCa1pYQnZjMmwwWDJGbWRHVnlYMmxtWDJWc2MyVkFNd29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1aVlXNXJMbU52Ym5SeVlXTjBMa0poYm1zdWQybDBhR1J5WVhjb1lXMXZkVzUwT2lCMWFXNTBOalFwSUMwK0lIVnBiblEyTkRvS2QybDBhR1J5WVhjNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1GdWF5OWpiMjUwY21GamRDNXdlVG95T1Mwek1Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QmtaV1lnZDJsMGFHUnlZWGNvYzJWc1ppd2dZVzF2ZFc1ME9pQlZTVzUwTmpRcElDMCtJRlZKYm5RMk5Eb0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoYm1zdlkyOXVkSEpoWTNRdWNIazZNeklLSUNBZ0lDOHZJR04xY25KbGJuUXNJR1Y0YVhOMGN5QTlJSE5sYkdZdVpHVndiM05wZEhNdWJXRjVZbVVvVkhodUxuTmxibVJsY2lrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSE4zWVhBS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpWVc1ckwyTnZiblJ5WVdOMExuQjVPak16Q2lBZ0lDQXZMeUJoYzNObGNuUWdaWGhwYzNSekxDQWlUbThnWkdWd2IzTnBkSE1nWm05MWJtUWdabTl5SUhSb2FYTWdZV05qYjNWdWRDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGemMyVnlkQ0F2THlCT2J5QmtaWEJ2YzJsMGN5Qm1iM1Z1WkNCbWIzSWdkR2hwY3lCaFkyTnZkVzUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbUZ1YXk5amIyNTBjbUZqZEM1d2VUb3pOQW9nSUNBZ0x5OGdZWE56WlhKMElHRnRiM1Z1ZENBK0lEQXNJQ0pYYVhSb1pISmhkMkZzSUdGdGIzVnVkQ0J0ZFhOMElHSmxJR2R5WldGMFpYSWdkR2hoYmlCNlpYSnZJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGMzTmxjblFnTHk4Z1YybDBhR1J5WVhkaGJDQmhiVzkxYm5RZ2JYVnpkQ0JpWlNCbmNtVmhkR1Z5SUhSb1lXNGdlbVZ5YndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoYm1zdlkyOXVkSEpoWTNRdWNIazZNelVLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhiVzkxYm5RZ1BEMGdZM1Z5Y21WdWRDd2dJbGRwZEdoa2NtRjNZV3dnWVcxdmRXNTBJR1Y0WTJWbFpITWdZbUZzWVc1alpTSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWkdsbklERUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnVjJsMGFHUnlZWGRoYkNCaGJXOTFiblFnWlhoalpXVmtjeUJpWVd4aGJtTmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRnVheTlqYjI1MGNtRmpkQzV3ZVRvek53b2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLSEpsWTJWcGRtVnlQVlI0Ymk1elpXNWtaWElzSUdGdGIzVnVkRDFoYlc5MWJuUXNJR1psWlQwd0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoYm1zdlkyOXVkSEpoWTNRdWNIazZNemtLSUNBZ0lDOHZJSEpsYldGcGJtbHVaeUE5SUdOMWNuSmxiblFnTFNCaGJXOTFiblFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1GdWF5OWpiMjUwY21GamRDNXdlVG8wTUFvZ0lDQWdMeThnYVdZZ2NtVnRZV2x1YVc1bklEMDlJRlZKYm5RMk5DZ3dLVG9LSUNBZ0lHSnVlaUIzYVhSb1pISmhkMTlsYkhObFgySnZaSGxBTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoYm1zdlkyOXVkSEpoWTNRdWNIazZOREVLSUNBZ0lDOHZJR1JsYkNCelpXeG1MbVJsY0c5emFYUnpXMVI0Ymk1elpXNWtaWEpkQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLQ25kcGRHaGtjbUYzWDJGbWRHVnlYMmxtWDJWc2MyVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlZVzVyTDJOdmJuUnlZV04wTG5CNU9qUTFDaUFnSUNBdkx5QnlaWFIxY200Z2NtVnRZV2x1YVc1bkNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdjbVYwYzNWaUNncDNhWFJvWkhKaGQxOWxiSE5sWDJKdlpIbEFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlZVzVyTDJOdmJuUnlZV04wTG5CNU9qUXpDaUFnSUNBdkx5QnpaV3htTG1SbGNHOXphWFJ6VzFSNGJpNXpaVzVrWlhKZElEMGdjbVZ0WVdsdWFXNW5DaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnWWlCM2FYUm9aSEpoZDE5aFpuUmxjbDlwWmw5bGJITmxRRFFLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVltRnVheTVqYjI1MGNtRmpkQzVDWVc1ckxtZGxkRjloYkd4ZlptbGxiR1J6S0NrZ0xUNGdkV2x1ZERZMExDQjFhVzUwTmpRNkNtZGxkRjloYkd4ZlptbGxiR1J6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoYm1zdlkyOXVkSEpoWTNRdWNIazZORGN0TkRnS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lDOHZJR1JsWmlCblpYUmZZV3hzWDJacFpXeGtjeWh6Wld4bUtTQXRQaUJVZFhCc1pWdFZTVzUwTmpRc0lGVkpiblEyTkYwNkNpQWdJQ0J3Y205MGJ5QXdJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlZVzVyTDJOdmJuUnlZV04wTG5CNU9qVXdDaUFnSUNBdkx5QmpZV3hzWlhKZllXMTBMQ0JsZUdsemRITWdQU0J6Wld4bUxtUmxjRzl6YVhSekxtMWhlV0psS0ZSNGJpNXpaVzVrWlhJcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZEc5cENpQWdJQ0J6ZDJGd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1GdWF5OWpiMjUwY21GamRDNXdlVG8xTVFvZ0lDQWdMeThnYVdZZ2JtOTBJR1Y0YVhOMGN6b0tJQ0FnSUdKdWVpQm5aWFJmWVd4c1gyWnBaV3hrYzE5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlZVzVyTDJOdmJuUnlZV04wTG5CNU9qVXlDaUFnSUNBdkx5QmpZV3hzWlhKZllXMTBJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDZ3BuWlhSZllXeHNYMlpwWld4a2MxOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1GdWF5OWpiMjUwY21GamRDNXdlVG8xTXdvZ0lDQWdMeThnY21WMGRYSnVJQ2h6Wld4bUxuUnZkR0ZzWDJSbGNHOXphWFFzSUdOaGJHeGxjbDloYlhRcENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZEc5MFlXeGZaR1Z3YjNOcGRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjNSaGJGOWtaWEJ2YzJsMElHVjRhWE4wY3dvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUNBUUFtQWcxMGIzUmhiRjlrWlhCdmMybDBCQlVmZkhVeEdFQUFBeWdqWnpFYlFRQnBnZ01FbjFsOE1nUXhJVUYyQkZtM0ozVTJHZ0NPQXdBc0FCY0FBaU5ETVJrVVJERVlSSWdBekV3V1RCWlFLVXhRc0NKRE1Sa1VSREVZUkRZYUFSZUlBSGdXS1V4UXNDSkRNUmtVUkRFWVJEWWFBVmNDQURFV0lnbEpPQkFpRWtTSUFCSVdLVXhRc0NKRE1SbEEvNjR4R0JSRUlrT0tBZ0dML3pnSE1nb1NSSXYvT0FoSlJJdi9PQUJKdmt3WFRFRUFIb3NDaXdBSUZvc0JUTDhqS0dWRWl3QUlLRXhuaXdHK1RCZE1SSXdBaVlzQUZvc0JUTDlDLytLS0FRRXhBTDVNRjB4RWkvOUVpLzlMQVE1RXNURUFpLyt5Q0xJSElySVFJN0lCczR2L0NVbEFBQWd4QUx4SWl3Qk1pVEVBaXdBV3YwTC84NG9BQWpFQXZrd1hURUFBQXlPTUFDTW9aVVNMQUU4Q2lRPT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo3LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
