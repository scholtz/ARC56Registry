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

namespace Arc56.Generated.algorandfoundation.devportal_code_examples.Arc4Struct_ce5efd08
{


    public class Arc4StructProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public Arc4StructProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Todo : AVMObjectType
            {
                public string Task { get; set; }

                public bool Completed { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTask = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vTask.From(Task);
                    stringRef[ret.Count] = vTask.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCompleted = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vCompleted.From(Completed);
                    ret.AddRange(vCompleted.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Todo Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Todo();
                    uint count = 0;
                    var indexTask = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTask = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vTask.Decode(bytes.Skip(indexTask + prefixOffset).ToArray());
                    var valueTask = vTask.ToValue();
                    if (valueTask is string vTaskValue) { ret.Task = vTaskValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCompleted = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vCompleted.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCompleted = vCompleted.ToValue();
                    if (valueCompleted is bool vCompletedValue) { ret.Completed = vCompletedValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Todo);
                }
                public bool Equals(Todo? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Todo left, Todo right)
                {
                    return EqualityComparer<Todo>.Default.Equals(left, right);
                }
                public static bool operator !=(Todo left, Todo right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="task"> </param>
        public async Task<Structs.Todo[]> AddTodo(string task, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 246, 24, 162, 85 };
            var taskAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); taskAbi.From(task);

            var result = await base.CallApp(new List<object> { abiHandle, taskAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.Todo>(x => Structs.Todo.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.ToArray();

        }

        public async Task<List<Transaction>> AddTodo_Transactions(string task, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 246, 24, 162, 85 };
            var taskAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); taskAbi.From(task);

            return await base.MakeTransactionList(new List<object> { abiHandle, taskAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="task"> </param>
        public async Task CompleteTodo(string task, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 207, 226, 216 };
            var taskAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); taskAbi.From(task);

            var result = await base.CallApp(new List<object> { abiHandle, taskAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CompleteTodo_Transactions(string task, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 207, 226, 216 };
            var taskAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); taskAbi.From(task);

            return await base.MakeTransactionList(new List<object> { abiHandle, taskAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="task"> </param>
        public async Task<Structs.Todo> ReturnTodo(string task, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 234, 158, 45, 157 };
            var taskAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); taskAbi.From(task);

            var result = await base.CallApp(new List<object> { abiHandle, taskAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Todo.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ReturnTodo_Transactions(string task, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 234, 158, 45, 157 };
            var taskAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); taskAbi.From(task);

            return await base.MakeTransactionList(new List<object> { abiHandle, taskAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXJjNFN0cnVjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJUb2RvIjpbeyJuYW1lIjoidGFzayIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJjb21wbGV0ZWQiLCJ0eXBlIjoiYm9vbCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJhZGRfdG9kbyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXNrIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihzdHJpbmcsYm9vbClbXSIsInN0cnVjdCI6IlRvZG8iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjb21wbGV0ZV90b2RvIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRhc2siLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmV0dXJuX3RvZG8iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFzayIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoc3RyaW5nLGJvb2wpIiwic3RydWN0IjoiVG9kbyIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMzldLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzldLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wICYmIGNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk4LDExOCwxMjgsMjc4LDI5MiwzNTcsNTMzLDU0Nyw2MTJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvZG9zIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyMiwzNzUsNDA4LDU3Nyw2MjhdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJRElnTVFvZ0lDQWdZbmwwWldOaWJHOWpheUFpZEc5a2IzTWlJREI0SURCNE1EQXdNQ0F3ZURFMU1XWTNZemMxQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpORjkwZVhCbGN5OWpiMjUwY21GamRDNXdlVG95TWprS0lDQWdJQzh2SUhObGJHWXVkRzlrYjNNZ1BTQlViMlJ2Y3lncENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMGIyUnZjeUlLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TURBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTkY5MGVYQmxjeTlqYjI1MGNtRmpkQzV3ZVRveU1qY0tJQ0FnSUM4dklHTnNZWE56SUVGeVl6UlRkSEoxWTNRb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURFeUNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHMTFjM1FnWW1VZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VHWTJNVGhoTWpVMUlEQjRNVEZqWm1VeVpEZ2dNSGhsWVRsbE1tUTVaQ0F2THlCdFpYUm9iMlFnSW1Ga1pGOTBiMlJ2S0hOMGNtbHVaeWtvYzNSeWFXNW5MR0p2YjJ3cFcxMGlMQ0J0WlhSb2IyUWdJbU52YlhCc1pYUmxYM1J2Wkc4b2MzUnlhVzVuS1hadmFXUWlMQ0J0WlhSb2IyUWdJbkpsZEhWeWJsOTBiMlJ2S0hOMGNtbHVaeWtvYzNSeWFXNW5MR0p2YjJ3cElnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dZV1JrWDNSdlpHOGdZMjl0Y0d4bGRHVmZkRzlrYnlCeVpYUjFjbTVmZEc5a2J3b2dJQ0FnWlhKeUNncHRZV2x1WDE5ZllXeG5iM0I1WDJSbFptRjFiSFJmWTNKbFlYUmxRREV5T2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQnlaWFIxY200Z0x5OGdiMjRnWlhKeWIzSTZJRTl1UTI5dGNHeGxkR2x2YmlCdGRYTjBJR0psSUU1dlQzQWdKaVlnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUdOeVpXRjBhVzVuQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtRnlZelJmZEhsd1pYTXVZMjl1ZEhKaFkzUXVRWEpqTkZOMGNuVmpkQzVoWkdSZmRHOWtiMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21Ga1pGOTBiMlJ2T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdZbmwwWldOZk1TQXZMeUFpSWdvZ0lDQWdaSFZ3YmlBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5GOTBlWEJsY3k5amIyNTBjbUZqZEM1d2VUb3lNek1LSUNBZ0lDOHZJSFJ2Wkc4Z1BTQlViMlJ2S0hSaGMyczlkR0Z6YXl3Z1kyOXRjR3hsZEdWa1BXRnlZelF1UW05dmJDaEdZV3h6WlNrcElDQWpJRzV2Y1dFNklFWkNWREF3TXdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd016QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpORjkwZVhCbGN5OWpiMjUwY21GamRDNXdlVG95TXpFS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6UmZkSGx3WlhNdlkyOXVkSEpoWTNRdWNIazZNak16Q2lBZ0lDQXZMeUIwYjJSdklEMGdWRzlrYnloMFlYTnJQWFJoYzJzc0lHTnZiWEJzWlhSbFpEMWhjbU0wTGtKdmIyd29SbUZzYzJVcEtTQWdJeUJ1YjNGaE9pQkdRbFF3TURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6UmZkSGx3WlhNdlkyOXVkSEpoWTNRdWNIazZNak0xQ2lBZ0lDQXZMeUJwWmlCdWIzUWdjMlZzWmk1MGIyUnZjem9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjBiMlJ2Y3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiMlJ2Y3lCbGVHbHpkSE1LSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TURBd0NpQWdJQ0E5UFFvZ0lDQWdZbm9nWVdSa1gzUnZaRzlmWld4elpWOWliMlI1UURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMFgzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qSXpOZ29nSUNBZ0x5OGdjMlZzWmk1MGIyUnZjeUE5SUZSdlpHOXpLSFJ2Wkc4dVkyOXdlU2dwS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01UQXdNRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZEc5a2IzTWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LWVdSa1gzUnZaRzlmWVdaMFpYSmZhV1pmWld4elpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelJmZEhsd1pYTXZZMjl1ZEhKaFkzUXVjSGs2TWpRd0NpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNTBiMlJ2Y3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblJ2Wkc5eklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2Wkc5eklHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpSZmRIbHdaWE12WTI5dWRISmhZM1F1Y0hrNk1qTXhDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ21Ga1pGOTBiMlJ2WDJWc2MyVmZZbTlrZVVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6UmZkSGx3WlhNdlkyOXVkSEpoWTNRdWNIazZNak00Q2lBZ0lDQXZMeUJ6Wld4bUxuUnZaRzl6TG1Gd2NHVnVaQ2gwYjJSdkxtTnZjSGtvS1NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0owYjJSdmN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjJSdmN5QmxlR2x6ZEhNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0oxY25rZ053b2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR0oxY25rZ09Rb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdKMWNua2dOZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlQW9nSUNBZ1luVnllU0EzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0tnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5WeWVTQXlDZ3BoWkdSZmRHOWtiMTltYjNKZmFHVmhaR1Z5UURZNkNpQWdJQ0JrZFhBeUNpQWdJQ0E4Q2lBZ0lDQmllaUJoWkdSZmRHOWtiMTloWm5SbGNsOW1iM0pBT0FvZ0lDQWdaR2xuSURZS0lDQWdJR1JwWnlBeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHUnBaeUEzQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0oxY25rZ053b2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHSjFjbmtnTWdvZ0lDQWdZaUJoWkdSZmRHOWtiMTltYjNKZmFHVmhaR1Z5UURZS0NtRmtaRjkwYjJSdlgyRm1kR1Z5WDJadmNrQTRPZ29nSUNBZ1pHbG5JRFlLSUNBZ0lHeGxiZ29nSUNBZ1luVnllU0F6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1luVnllU0F5Q2dwaFpHUmZkRzlrYjE5bWIzSmZhR1ZoWkdWeVFEazZDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUR3S0lDQWdJR0o2SUdGa1pGOTBiMlJ2WDJGbWRHVnlYMlp2Y2tBeE1Rb2dJQ0FnWkdsbklEUUtJQ0FnSUdScFp5QXlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTkFvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUdScFp5QTNDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjFjbmtnTndvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDc0tJQ0FnSUdKMWNua2dNZ29nSUNBZ1lpQmhaR1JmZEc5a2IxOW1iM0pmYUdWaFpHVnlRRGtLQ21Ga1pGOTBiMlJ2WDJGbWRHVnlYMlp2Y2tBeE1Ub0tJQ0FnSUdScFp5QXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpORjkwZVhCbGN5OWpiMjUwY21GamRDNXdlVG95TXpnS0lDQWdJQzh2SUhObGJHWXVkRzlrYjNNdVlYQndaVzVrS0hSdlpHOHVZMjl3ZVNncEtRb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCa2FXY2dOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTndvZ0lDQWdaR2xuSURJS0lDQWdJR1JwWnlBMUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBMUNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5GOTBlWEJsY3k5amIyNTBjbUZqZEM1d2VUb3lNemdLSUNBZ0lDOHZJSE5sYkdZdWRHOWtiM011WVhCd1pXNWtLSFJ2Wkc4dVkyOXdlU2dwS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZEc5a2IzTWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lpQmhaR1JmZEc5a2IxOWhablJsY2w5cFpsOWxiSE5sUURRS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZWEpqTkY5MGVYQmxjeTVqYjI1MGNtRmpkQzVCY21NMFUzUnlkV04wTG1OdmJYQnNaWFJsWDNSdlpHOWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqYjIxd2JHVjBaVjkwYjJSdk9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1IxY0FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpSWdvZ0lDQWdaSFZ3YmlBMUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5GOTBlWEJsY3k5amIyNTBjbUZqZEM1d2VUb3lORElLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpSZmRIbHdaWE12WTI5dWRISmhZM1F1Y0hrNk1qUTBDaUFnSUNBdkx5Qm1iM0lnYVc1a1pYZ2dhVzRnZFhKaGJtZGxLSE5sYkdZdWRHOWtiM011YkdWdVozUm9LVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjBiMlJ2Y3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiMlJ2Y3lCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtDbU52YlhCc1pYUmxYM1J2Wkc5ZlptOXlYMmhsWVdSbGNrQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelJmZEhsd1pYTXZZMjl1ZEhKaFkzUXVjSGs2TWpRMENpQWdJQ0F2THlCbWIzSWdhVzVrWlhnZ2FXNGdkWEpoYm1kbEtITmxiR1l1ZEc5a2IzTXViR1Z1WjNSb0tUb0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklESUtJQ0FnSUR3S0lDQWdJR0o2SUdOdmJYQnNaWFJsWDNSdlpHOWZZV1owWlhKZlptOXlRRGNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0wWDNSNWNHVnpMMk52Ym5SeVlXTjBMbkI1T2pJME5Rb2dJQ0FnTHk4Z2FXWWdjMlZzWmk1MGIyUnZjMXRwYm1SbGVGMHVkR0Z6YXlBOVBTQjBZWE5yT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblJ2Wkc5eklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2Wkc5eklHVjRhWE4wY3dvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS2dvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURFekNpQWdJQ0JrYVdjZ013b2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0FyQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pHbG5JREVLSUNBZ0lDMGdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JrYVdjZ013b2dJQ0FnYkdWdUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBcUNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01UUUtJQ0FnSUdScFp5QTBDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCa2FXY2dOQW9nSUNBZ1BUMEtJQ0FnSUdKNklHTnZiWEJzWlhSbFgzUnZaRzlmWVdaMFpYSmZhV1pmWld4elpVQTFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpORjkwZVhCbGN5OWpiMjUwY21GamRDNXdlVG95TkRZS0lDQWdJQzh2SUhObGJHWXVkRzlrYjNOYmFXNWtaWGhkTG1OdmJYQnNaWFJsWkNBOUlHRnlZelF1UW05dmJDaFVjblZsS1NBZ0l5QnViM0ZoT2lCR1FsUXdNRE1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjBiMlJ2Y3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiMlJ2Y3lCbGVHbHpkSE1LSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdScFp5QXhDaUFnSUNCa2FXY2dNVE1LSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNBdElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdaR2xuSURNS0lDQWdJR3hsYmdvZ0lDQWdaR2xuSURRS0lDQWdJR1JwWnlBeE5Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pIVndNZ29nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdScFp5QTFDaUFnSUNCa2FXY2dOQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQndkWE5vYVc1MElERTJJQzh2SURFMkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjMlYwWW1sMENpQWdJQ0JrYVdjZ09Bb2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lEd0tJQ0FnSUdGemMyVnlkQ0F2THlCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQnpkV0p6ZEhKcGJtY2dNQ0F5Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTVRnS0lDQWdJR0owYjJrS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pHbG5JRFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURVS0lDQWdJQzBLSUNBZ0lHSjFjbmtnTVRJS0lDQWdJR1JwWnlBeUNpQWdJQ0JzWlc0S0lDQWdJR0oxY25rZ01UTUtJQ0FnSUdScFp5QTFDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmlkWEo1SURFekNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLZ29nSUNBZ1luVnllU0ExQ2lBZ0lDQmlkWEo1SURjS0NtTnZiWEJzWlhSbFgzUnZaRzlmWm05eVgyaGxZV1JsY2tBNU9nb2dJQ0FnWkdsbklEWUtJQ0FnSUdScFp5QTBDaUFnSUNBOENpQWdJQ0JpZWlCamIyMXdiR1YwWlY5MGIyUnZYMkZtZEdWeVgyWnZja0F4TVFvZ0lDQWdaR2xuSURFd0NpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBNENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlETUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dPQW9nSUNBZ0t3b2dJQ0FnWkdsbklEY0tJQ0FnSUMwS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQmthV2NnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdjbVZ3YkdGalpUTUtJQ0FnSUdKMWNua2dNVElLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0JpZFhKNUlEY0tJQ0FnSUdJZ1kyOXRjR3hsZEdWZmRHOWtiMTltYjNKZmFHVmhaR1Z5UURrS0NtTnZiWEJzWlhSbFgzUnZaRzlmWVdaMFpYSmZabTl5UURFeE9nb2dJQ0FnWkdsbklEa0tJQ0FnSUdScFp5QXhNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTkY5MGVYQmxjeTlqYjI1MGNtRmpkQzV3ZVRveU5EWUtJQ0FnSUM4dklITmxiR1l1ZEc5a2IzTmJhVzVrWlhoZExtTnZiWEJzWlhSbFpDQTlJR0Z5WXpRdVFtOXZiQ2hVY25WbEtTQWdJeUJ1YjNGaE9pQkdRbFF3TURNS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5SdlpHOXpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLQ21OdmJYQnNaWFJsWDNSdlpHOWZZV1owWlhKZlptOXlRRGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTkY5MGVYQmxjeTlqYjI1MGNtRmpkQzV3ZVRveU5ESUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LWTI5dGNHeGxkR1ZmZEc5a2IxOWhablJsY2w5cFpsOWxiSE5sUURVNkNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdJZ1kyOXRjR3hsZEdWZmRHOWtiMTltYjNKZmFHVmhaR1Z5UURJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZWEpqTkY5MGVYQmxjeTVqYjI1MGNtRmpkQzVCY21NMFUzUnlkV04wTG5KbGRIVnlibDkwYjJSdlczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVYwZFhKdVgzUnZaRzg2Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0lpQ2lBZ0lDQmtkWEJ1SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMFgzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qSTBPUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelJmZEhsd1pYTXZZMjl1ZEhKaFkzUXVjSGs2TWpVekxUSTFOQW9nSUNBZ0x5OGdaWGhwYzNRZ1BTQkdZV3h6WlFvZ0lDQWdMeThnWm05eUlHbHVaR1Y0SUdsdUlIVnlZVzVuWlNoelpXeG1MblJ2Wkc5ekxteGxibWQwYUNrNkNpQWdJQ0JrZFhCdUlESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTBYM1I1Y0dWekwyTnZiblJ5WVdOMExuQjVPakkxTkFvZ0lDQWdMeThnWm05eUlHbHVaR1Y0SUdsdUlIVnlZVzVuWlNoelpXeG1MblJ2Wkc5ekxteGxibWQwYUNrNkNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMGIyUnZjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIyUnZjeUJsZUdsemRITUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0NuSmxkSFZ5Ymw5MGIyUnZYMlp2Y2w5b1pXRmtaWEpBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMFgzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qSTFOQW9nSUNBZ0x5OGdabTl5SUdsdVpHVjRJR2x1SUhWeVlXNW5aU2h6Wld4bUxuUnZaRzl6TG14bGJtZDBhQ2s2Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQThDaUFnSUNCaWVpQnlaWFIxY201ZmRHOWtiMTloWm5SbGNsOW1iM0pBTndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpSZmRIbHdaWE12WTI5dWRISmhZM1F1Y0hrNk1qVTFDaUFnSUNBdkx5QnBaaUJ6Wld4bUxuUnZaRzl6VzJsdVpHVjRYUzUwWVhOcklEMDlJSFJoYzJzNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZEc5a2IzTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5a2IzTWdaWGhwYzNSekNpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBcUNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01USUtJQ0FnSUdScFp5QXpDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUNzS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeE1Rb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdMU0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdScFp5QXpDaUFnSUNCc1pXNEtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDb0tJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXhNUW9nSUNBZ1pHbG5JRFFLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHUnBaeUExQ2lBZ0lDQTlQUW9nSUNBZ1lub2djbVYwZFhKdVgzUnZaRzlmWVdaMFpYSmZhV1pmWld4elpVQTFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpORjkwZVhCbGN5OWpiMjUwY21GamRDNXdlVG95TlRZS0lDQWdJQzh2SUhSdlpHOWZkRzlmY21WMGRYSnVJRDBnYzJWc1ppNTBiMlJ2YzF0cGJtUmxlRjB1WTI5d2VTZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRHOWtiM01pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOWtiM01nWlhocGMzUnpDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeENpQWdJQ0JrYVdjZ01UQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dPUW9nSUNBZ0xTQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1JwWnlBeUNpQWdJQ0JzWlc0S0lDQWdJR1JwWnlBekNpQWdJQ0JrYVdjZ01UQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdZblZ5ZVNBMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5GOTBlWEJsY3k5amIyNTBjbUZqZEM1d2VUb3lOVGNLSUNBZ0lDOHZJR1Y0YVhOMElEMGdWSEoxWlFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lHSjFjbmtnTXdvS2NtVjBkWEp1WDNSdlpHOWZZV1owWlhKZmFXWmZaV3h6WlVBMU9nb2dJQ0FnWkdsbklEWUtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lpQnlaWFIxY201ZmRHOWtiMTltYjNKZmFHVmhaR1Z5UURJS0NuSmxkSFZ5Ymw5MGIyUnZYMkZtZEdWeVgyWnZja0EzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpSZmRIbHdaWE12WTI5dWRISmhZM1F1Y0hrNk1qVTVDaUFnSUNBdkx5QmhjM05sY25RZ1pYaHBjM1FLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMFgzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qSTBPUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFEQUFJQkpnUUZkRzlrYjNNQUFnQUFCQlVmZkhVeEdFQUFBeWdxWnpFYlFRQWtNUmtVUkRFWVJJSURCUFlZb2xVRUVjL2kyQVRxbmkyZE5ob0FqZ01BQ1FERUFjTUFNUmtVTVJnVUVFTWlSd0lwUndPQUF3QURBRFlhQVZBaUtHVkVLaEpCQUJXQUJBQUJBQUpNVUNoTVp5SW9aVVFyVEZDd0pFTWlLR1ZFU1NKWlNVNENSUWRYQWdCRkNZQUNBQUpQQWxCRkJpbEZCeU1MUlFFaVJRSktERUVBRzBzR1N3SkpUZ0paSXdnV1Z3WUNTd2RNVUVVSEl3aEZBa0wvNEVzR0ZVVURJa1VDU3dFakRFRUFIRXNFU3dKSlRnSlpTd1FJRmxjR0Frc0hURkJGQnlNSVJRSkMvOTFMQXlRSUZsY0dBa3NHVUVzSFN3SkxCVkpRU3dWWEFnQlFLRXhuUXY5b0lra3BSd1UyR2dFaUtHVkVJbGtpU1VzQ0RFRUE0aUlvWlVSSlZ3SUFUQ0paU3dKSkl3dEpSUTFMQTB4WlRDUUlTVTRFVHdKTEFRbExBeFZQQWlNTFNVVU9Td1JNV1U4Q1RWSkpJbGxMQVJWU1N3UVNRUUNqSWlobFJFbFhBZ0JMQVNKWlN3RkxEVmxMQVU4RkNVc0RGVXNFU3c1SlRnaFpTazhFVFVzRlN3UlBBbEtCRUNSVVN3aEpUd1lNUkU4R1VRQUNTVVVTRjBsUEFna2tDVXNFVHdSUEFrMUpTd1VKUlF4TEFoVkZEVXNGSWs4R1VrOERVRThFVHdKUEJGSlFSUTBqQzBVRlJRZExCa3NFREVFQUlFc0tTVXNJU1U0RFdVc0lDRXNIQ1JaWEJnSkxBa3hkUlF3akNFVUhRdi9ZU3dsTEMxQW9UR2NrUTBVQlF2OFFLVWNDTmhvQklrY0NLR1ZFSWxraVNVc0NERUVBYlNJb1pVUkpWd0lBVENKWlN3SkpJd3RKUlF4TEEweFpUQ1FJU1VVTFR3SkxBUWxMQXhWUEFpTUxTVVVMU3dSTVdVOENUVkpKSWxsTEFSVlNTd1VTUVFBbElpaGxSRWxYQWdCTUlsbExBVXNLV1V4TENRbExBaFZMQTBzS1dVOENUVkpGQkNSRkEwc0dSUUZDLzR4TEFrUXJTd1JRc0NSRCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjAsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
