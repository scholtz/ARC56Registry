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

namespace Arc56.Generated.Ghynmo.decentralized_todo_list.TodoApp_f8e3fdb1
{


    //
    // 
    //    A simple Todo application smart contract for Algorand.
    //    Allows users to create, complete, and view their todos.
    //    
    //
    public class TodoAppProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TodoAppProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Create a new todo item.
        ///Returns the ID of the created todo.
        ///</summary>
        /// <param name="task"> </param>
        public async Task<ulong> CreateTodo(string task, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 56, 1, 24, 21 };
            var taskAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); taskAbi.From(task);

            var result = await base.CallApp(new List<object> { abiHandle, taskAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateTodo_Transactions(string task, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 56, 1, 24, 21 };
            var taskAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); taskAbi.From(task);

            return await base.MakeTransactionList(new List<object> { abiHandle, taskAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Mark a todo as completed.
        ///Returns a success message.
        ///</summary>
        /// <param name="todo_id"> </param>
        public async Task<string> CompleteTodo(ulong todo_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 127, 129, 152 };
            var todo_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); todo_idAbi.From(todo_id);

            var result = await base.CallApp(new List<object> { abiHandle, todo_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> CompleteTodo_Transactions(ulong todo_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 127, 129, 152 };
            var todo_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); todo_idAbi.From(todo_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, todo_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get a specific todo by its ID.
        ///Returns the todo text.
        ///</summary>
        /// <param name="todo_id"> </param>
        public async Task<string> GetTodo(ulong todo_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 196, 91, 58, 180 };
            var todo_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); todo_idAbi.From(todo_id);

            var result = await base.CallApp(new List<object> { abiHandle, todo_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetTodo_Transactions(ulong todo_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 196, 91, 58, 180 };
            var todo_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); todo_idAbi.From(todo_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, todo_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check if a todo is completed.
        ///Returns True if completed, False otherwise.
        ///</summary>
        /// <param name="todo_id"> </param>
        public async Task<bool> IsCompleted(ulong todo_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 116, 175, 194 };
            var todo_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); todo_idAbi.From(todo_id);

            var result = await base.CallApp(new List<object> { abiHandle, todo_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsCompleted_Transactions(ulong todo_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 116, 175, 194 };
            var todo_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); todo_idAbi.From(todo_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, todo_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the total number of todos created.
        ///</summary>
        public async Task<ulong> GetTotalTodos(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 254, 88, 37, 233 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalTodos_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 254, 88, 37, 233 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Delete a todo item.
        ///Returns a success message.
        ///</summary>
        /// <param name="todo_id"> </param>
        public async Task<string> DeleteTodo(ulong todo_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 119, 54, 56, 83 };
            var todo_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); todo_idAbi.From(todo_id);

            var result = await base.CallApp(new List<object> { abiHandle, todo_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> DeleteTodo_Transactions(ulong todo_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 119, 54, 56, 83 };
            var todo_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); todo_idAbi.From(todo_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, todo_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVG9kb0FwcCIsImRlc2MiOiJcbiAgICBBIHNpbXBsZSBUb2RvIGFwcGxpY2F0aW9uIHNtYXJ0IGNvbnRyYWN0IGZvciBBbGdvcmFuZC5cbiAgICBBbGxvd3MgdXNlcnMgdG8gY3JlYXRlLCBjb21wbGV0ZSwgYW5kIHZpZXcgdGhlaXIgdG9kb3MuXG4gICAgIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZV90b2RvIiwiZGVzYyI6IkNyZWF0ZSBhIG5ldyB0b2RvIGl0ZW0uXG5SZXR1cm5zIHRoZSBJRCBvZiB0aGUgY3JlYXRlZCB0b2RvLiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXNrIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY29tcGxldGVfdG9kbyIsImRlc2MiOiJNYXJrIGEgdG9kbyBhcyBjb21wbGV0ZWQuXG5SZXR1cm5zIGEgc3VjY2VzcyBtZXNzYWdlLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2RvX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3RvZG8iLCJkZXNjIjoiR2V0IGEgc3BlY2lmaWMgdG9kbyBieSBpdHMgSUQuXG5SZXR1cm5zIHRoZSB0b2RvIHRleHQuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvZG9faWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc19jb21wbGV0ZWQiLCJkZXNjIjoiQ2hlY2sgaWYgYSB0b2RvIGlzIGNvbXBsZXRlZC5cblJldHVybnMgVHJ1ZSBpZiBjb21wbGV0ZWQsIEZhbHNlIG90aGVyd2lzZS4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9kb19pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdG90YWxfdG9kb3MiLCJkZXNjIjoiR2V0IHRoZSB0b3RhbCBudW1iZXIgb2YgdG9kb3MgY3JlYXRlZC4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWxldGVfdG9kbyIsImRlc2MiOiJEZWxldGUgYSB0b2RvIGl0ZW0uXG5SZXR1cm5zIGEgc3VjY2VzcyBtZXNzYWdlLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2RvX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls3NV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzZdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wICYmIGNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxNV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuY29tcGxldGVkIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1NiwzMjJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvZG9fY291bnRlciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvZG9zIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTYsMjYxLDI5MywzMzhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF4SURBZ09Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VERTFNV1kzWXpjMUlDSjBiMlJ2WDJOdmRXNTBaWElpSUNKMGIyUnZjeUlnSW1OdmJYQnNaWFJsWkNJZ01IZ3dNREJsTlRRMlpqWTBObVl5TURabE5tWTNOREl3TmpZMlpqYzFObVUyTkFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnZaRzlmWVhCd0wyTnZiblJ5WVdOMExuQjVPakV4TFRFeUNpQWdJQ0F2THlBaklFTnZkVzUwWlhJZ2RHOGdkSEpoWTJzZ2RHOTBZV3dnYm5WdFltVnlJRzltSUhSdlpHOXpJR055WldGMFpXUUtJQ0FnSUM4dklITmxiR1l1ZEc5a2IxOWpiM1Z1ZEdWeUlEMGdSMnh2WW1Gc1UzUmhkR1VvVlVsdWREWTBLREFwS1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpZEc5a2IxOWpiM1Z1ZEdWeUlnb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBiMlJ2WDJGd2NDOWpiMjUwY21GamRDNXdlVG8wQ2lBZ0lDQXZMeUJqYkdGemN5QlViMlJ2UVhCd0tFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBeE5Rb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnRkWE4wSUdKbElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZ3pPREF4TVRneE5TQXdlRFEwTjJZNE1UazRJREI0WXpRMVlqTmhZalFnTUhoak1qYzBZV1pqTWlBd2VHWmxOVGd5TldVNUlEQjROemN6TmpNNE5UTWdMeThnYldWMGFHOWtJQ0pqY21WaGRHVmZkRzlrYnloemRISnBibWNwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0pqYjIxd2JHVjBaVjkwYjJSdktIVnBiblEyTkNsemRISnBibWNpTENCdFpYUm9iMlFnSW1kbGRGOTBiMlJ2S0hWcGJuUTJOQ2x6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJbWx6WDJOdmJYQnNaWFJsWkNoMWFXNTBOalFwWW05dmJDSXNJRzFsZEdodlpDQWlaMlYwWDNSdmRHRnNYM1J2Wkc5ektDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltUmxiR1YwWlY5MGIyUnZLSFZwYm5RMk5DbHpkSEpwYm1jaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmpjbVZoZEdWZmRHOWtieUJqYjIxd2JHVjBaVjkwYjJSdklHZGxkRjkwYjJSdklHbHpYMk52YlhCc1pYUmxaQ0JuWlhSZmRHOTBZV3hmZEc5a2IzTWdaR1ZzWlhSbFgzUnZaRzhLSUNBZ0lHVnljZ29LYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBeE5Ub0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNBbUpnb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnRkWE4wSUdKbElFNXZUM0FnSmlZZ1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHTnlaV0YwYVc1bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMblJ2Wkc5ZllYQndMbU52Ym5SeVlXTjBMbFJ2Wkc5QmNIQXVZM0psWVhSbFgzUnZaRzliY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamNtVmhkR1ZmZEc5a2J6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGIyUnZYMkZ3Y0M5amIyNTBjbUZqZEM1d2VUb3hPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGIyUnZYMkZ3Y0M5amIyNTBjbUZqZEM1d2VUb3lOQzB5TlFvZ0lDQWdMeThnSXlCSmJtTnlaVzFsYm5RZ2RHaGxJR052ZFc1MFpYSWdkRzhnWjJWMElHNWxkeUIwYjJSdklFbEVDaUFnSUNBdkx5QmpkWEp5Wlc1MFgybGtJRDBnYzJWc1ppNTBiMlJ2WDJOdmRXNTBaWEl1ZG1Gc2RXVUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMGIyUnZYMk52ZFc1MFpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5a2IxOWpiM1Z1ZEdWeUlHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J2Wkc5ZllYQndMMk52Ym5SeVlXTjBMbkI1T2pJMkNpQWdJQ0F2THlCdVpYZGZhV1FnUFNCamRYSnlaVzUwWDJsa0lDc2dWVWx1ZERZMEtERXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J2Wkc5ZllYQndMMk52Ym5SeVlXTjBMbkI1T2pJM0NpQWdJQ0F2THlCelpXeG1MblJ2Wkc5ZlkyOTFiblJsY2k1MllXeDFaU0E5SUc1bGQxOXBaQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlkRzlrYjE5amIzVnVkR1Z5SWdvZ0lDQWdaR2xuSURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEc5a2IxOWhjSEF2WTI5dWRISmhZM1F1Y0hrNk1qa3RNekFLSUNBZ0lDOHZJQ01nVTNSdmNtVWdkR2hsSUhSdlpHOGdkR0Z6YXdvZ0lDQWdMeThnZEc5a2IxOXBaQ0E5SUdGeVl6UXVWVWx1ZERZMEtHNWxkMTlwWkNrS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYjJSdlgyRndjQzlqYjI1MGNtRmpkQzV3ZVRvek1Rb2dJQ0FnTHk4Z2MyVnNaaTUwYjJSdmMxdDBiMlJ2WDJsa1hTQTlJSFJoYzJzS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5SdlpHOXpJZ29nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J2Wkc5ZllYQndMMk52Ym5SeVlXTjBMbkI1T2pNeUNpQWdJQ0F2THlCelpXeG1MbU52YlhCc1pYUmxaRnQwYjJSdlgybGtYU0E5SUdGeVl6UXVRbTl2YkNoR1lXeHpaU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbU52YlhCc1pYUmxaQ0lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOWtiMTloY0hBdlkyOXVkSEpoWTNRdWNIazZNVGdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5SdlpHOWZZWEJ3TG1OdmJuUnlZV04wTGxSdlpHOUJjSEF1WTI5dGNHeGxkR1ZmZEc5a2IxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU52YlhCc1pYUmxYM1J2Wkc4NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEc5a2IxOWhjSEF2WTI5dWRISmhZM1F1Y0hrNk16WUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhCdUlESUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlrYjE5aGNIQXZZMjl1ZEhKaFkzUXVjSGs2TkRJdE5ETUtJQ0FnSUM4dklDTWdRMmhsWTJzZ2FXWWdkRzlrYnlCbGVHbHpkSE1LSUNBZ0lDOHZJR2xtSUhSdlpHOWZhV1FnYm05MElHbHVJSE5sYkdZdWRHOWtiM002Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0owYjJSdmN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpYm5vZ1kyOXRjR3hsZEdWZmRHOWtiMTloWm5SbGNsOXBabDlsYkhObFFETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGIyUnZYMkZ3Y0M5amIyNTBjbUZqZEM1d2VUbzBOQW9nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1VTNSeWFXNW5LQ0pVYjJSdklHNXZkQ0JtYjNWdVpDSXBDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNREF3WlRVME5tWTJORFptTWpBMlpUWm1OelF5TURZMk5tWTNOVFpsTmpRS0NtTnZiWEJzWlhSbFgzUnZaRzlmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdWRHOWtiMTloY0hBdVkyOXVkSEpoWTNRdVZHOWtiMEZ3Y0M1amIyMXdiR1YwWlY5MGIyUnZRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlrYjE5aGNIQXZZMjl1ZEhKaFkzUXVjSGs2TXpZS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwamIyMXdiR1YwWlY5MGIyUnZYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGIyUnZYMkZ3Y0M5amIyNTBjbUZqZEM1d2VUbzBOaTAwTndvZ0lDQWdMeThnSXlCTllYSnJJR0Z6SUdOdmJYQnNaWFJsWkFvZ0lDQWdMeThnYzJWc1ppNWpiMjF3YkdWMFpXUmJkRzlrYjE5cFpGMGdQU0JoY21NMExrSnZiMndvVkhKMVpTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltTnZiWEJzWlhSbFpDSUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRGd3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEc5a2IxOWhjSEF2WTI5dWRISmhZM1F1Y0hrNk5Ea0tJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMbE4wY21sdVp5Z2lWRzlrYnlCdFlYSnJaV1FnWVhNZ1kyOXRjR3hsZEdWa0lTSXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREU1TlRRMlpqWTBObVl5TURaa05qRTNNalppTmpVMk5ESXdOakUzTXpJd05qTTJaalprTnpBMll6WTFOelEyTlRZME1qRUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGIyUnZYMkZ3Y0M5amIyNTBjbUZqZEM1d2VUb3pOZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdJZ1kyOXRjR3hsZEdWZmRHOWtiMTloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k1MGIyUnZYMkZ3Y0M1amIyNTBjbUZqZEM1VWIyUnZRWEJ3TG1OdmJYQnNaWFJsWDNSdlpHOUFOQW9LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1MGIyUnZYMkZ3Y0M1amIyNTBjbUZqZEM1VWIyUnZRWEJ3TG1kbGRGOTBiMlJ2VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBYM1J2Wkc4NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEc5a2IxOWhjSEF2WTI5dWRISmhZM1F1Y0hrNk5URUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOWtiMTloY0hBdlkyOXVkSEpoWTNRdWNIazZOVGNLSUNBZ0lDOHZJR2xtSUhSdlpHOWZhV1FnYm05MElHbHVJSE5sYkdZdWRHOWtiM002Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0owYjJSdmN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0p1ZWlCblpYUmZkRzlrYjE5aFpuUmxjbDlwWmw5bGJITmxRRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBiMlJ2WDJGd2NDOWpiMjUwY21GamRDNXdlVG8xT0FvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVUzUnlhVzVuS0NKVWIyUnZJRzV2ZENCbWIzVnVaQ0lwQ2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TURBd1pUVTBObVkyTkRabU1qQTJaVFptTnpReU1EWTJObVkzTlRabE5qUUtDbWRsZEY5MGIyUnZYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TG5SdlpHOWZZWEJ3TG1OdmJuUnlZV04wTGxSdlpHOUJjSEF1WjJWMFgzUnZaRzlBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYjJSdlgyRndjQzlqYjI1MGNtRmpkQzV3ZVRvMU1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtZGxkRjkwYjJSdlgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYjJSdlgyRndjQzlqYjI1MGNtRmpkQzV3ZVRvMk1Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVkRzlrYjNOYmRHOWtiMTlwWkYwS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOWtiM01nWlc1MGNua2daWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEc5a2IxOWhjSEF2WTI5dWRISmhZM1F1Y0hrNk5URUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JpSUdkbGRGOTBiMlJ2WDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekxuUnZaRzlmWVhCd0xtTnZiblJ5WVdOMExsUnZaRzlCY0hBdVoyVjBYM1J2Wkc5QU5Bb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTUwYjJSdlgyRndjQzVqYjI1MGNtRmpkQzVVYjJSdlFYQndMbWx6WDJOdmJYQnNaWFJsWkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtbHpYMk52YlhCc1pYUmxaRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBiMlJ2WDJGd2NDOWpiMjUwY21GamRDNXdlVG8yTWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYjJSdlgyRndjQzlqYjI1MGNtRmpkQzV3ZVRvMk9Bb2dJQ0FnTHk4Z2FXWWdkRzlrYjE5cFpDQnViM1FnYVc0Z2MyVnNaaTVqYjIxd2JHVjBaV1E2Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0pqYjIxd2JHVjBaV1FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWJub2dhWE5mWTI5dGNHeGxkR1ZrWDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnZaRzlmWVhCd0wyTnZiblJ5WVdOMExuQjVPalk1Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1Q2IyOXNLRVpoYkhObEtRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQUtDbWx6WDJOdmJYQnNaWFJsWkY5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5NTBiMlJ2WDJGd2NDNWpiMjUwY21GamRDNVViMlJ2UVhCd0xtbHpYMk52YlhCc1pYUmxaRUEwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J2Wkc5ZllYQndMMk52Ym5SeVlXTjBMbkI1T2pZeUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2FYTmZZMjl0Y0d4bGRHVmtYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGIyUnZYMkZ3Y0M5amIyNTBjbUZqZEM1d2VUbzNNUW9nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1WTI5dGNHeGxkR1ZrVzNSdlpHOWZhV1JkQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1OdmJYQnNaWFJsWkNCbGJuUnllU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGIyUnZYMkZ3Y0M5amIyNTBjbUZqZEM1d2VUbzJNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdJZ2FYTmZZMjl0Y0d4bGRHVmtYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TG5SdlpHOWZZWEJ3TG1OdmJuUnlZV04wTGxSdlpHOUJjSEF1YVhOZlkyOXRjR3hsZEdWa1FEUUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11ZEc5a2IxOWhjSEF1WTI5dWRISmhZM1F1Vkc5a2IwRndjQzVuWlhSZmRHOTBZV3hmZEc5a2IzTmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZmRHOTBZV3hmZEc5a2IzTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOWtiMTloY0hBdlkyOXVkSEpoWTNRdWNIazZOemdLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxuUnZaRzlmWTI5MWJuUmxjaTUyWVd4MVpTa0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMGIyUnZYMk52ZFc1MFpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5a2IxOWpiM1Z1ZEdWeUlHVjRhWE4wY3dvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J2Wkc5ZllYQndMMk52Ym5SeVlXTjBMbkI1T2pjekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NTBiMlJ2WDJGd2NDNWpiMjUwY21GamRDNVViMlJ2UVhCd0xtUmxiR1YwWlY5MGIyUnZXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWkdWc1pYUmxYM1J2Wkc4NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEc5a2IxOWhjSEF2WTI5dWRISmhZM1F1Y0hrNk9EQUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhCdUlESUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlrYjE5aGNIQXZZMjl1ZEhKaFkzUXVjSGs2T0RZS0lDQWdJQzh2SUdsbUlIUnZaRzlmYVdRZ2JtOTBJR2x1SUhObGJHWXVkRzlrYjNNNkNpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKMGIyUnZjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKdWVpQmtaV3hsZEdWZmRHOWtiMTloWm5SbGNsOXBabDlsYkhObFFETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGIyUnZYMkZ3Y0M5amIyNTBjbUZqZEM1d2VUbzROd29nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1VTNSeWFXNW5LQ0pVYjJSdklHNXZkQ0JtYjNWdVpDSXBDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNREF3WlRVME5tWTJORFptTWpBMlpUWm1OelF5TURZMk5tWTNOVFpsTmpRS0NtUmxiR1YwWlY5MGIyUnZYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TG5SdlpHOWZZWEJ3TG1OdmJuUnlZV04wTGxSdlpHOUJjSEF1WkdWc1pYUmxYM1J2Wkc5QU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGIyUnZYMkZ3Y0M5amIyNTBjbUZqZEM1d2VUbzRNQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbVJsYkdWMFpWOTBiMlJ2WDJGbWRHVnlYMmxtWDJWc2MyVkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBiMlJ2WDJGd2NDOWpiMjUwY21GamRDNXdlVG80T1MwNU1Bb2dJQ0FnTHk4Z0l5QkVaV3hsZEdVZ1puSnZiU0JpYjNSb0lITjBiM0poWjJVZ1ltOTRaWE1LSUNBZ0lDOHZJR1JsYkNCelpXeG1MblJ2Wkc5elczUnZaRzlmYVdSZENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSdlpHOWZZWEJ3TDJOdmJuUnlZV04wTG5CNU9qa3hDaUFnSUNBdkx5QmtaV3dnYzJWc1ppNWpiMjF3YkdWMFpXUmJkRzlrYjE5cFpGMEtJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltTnZiWEJzWlhSbFpDSUtJQ0FnSUdScFp5QXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J2Wkc5ZllYQndMMk52Ym5SeVlXTjBMbkI1T2prekNpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNVRkSEpwYm1jb0lsUnZaRzhnWkdWc1pYUmxaQ0J6ZFdOalpYTnpablZzYkhraElpa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNV0UxTkRabU5qUTJaakl3TmpRMk5UWmpOalUzTkRZMU5qUXlNRGN6TnpVMk16WXpOalUzTXpjek5qWTNOVFpqTm1NM09USXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOWtiMTloY0hBdlkyOXVkSEpoWTNRdWNIazZPREFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCaUlHUmxiR1YwWlY5MGIyUnZYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TG5SdlpHOWZZWEJ3TG1OdmJuUnlZV04wTGxSdlpHOUJjSEF1WkdWc1pYUmxYM1J2Wkc5QU5Bbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBREFRQUlKZ1VFRlI5OGRReDBiMlJ2WDJOdmRXNTBaWElGZEc5a2IzTUpZMjl0Y0d4bGRHVmtFQUFPVkc5a2J5QnViM1FnWm05MWJtUXhHRUFBQXlralp6RWJRUUE1TVJrVVJERVlSSUlHQkRnQkdCVUVSSCtCbUFURVd6cTBCTUowcjhJRS9sZ2w2UVIzTmpoVE5ob0FqZ1lBQ3dBOEFINEFuZ0MvQU1vQU1Sa1VNUmdVRUVRaVF6WWFBVWtqV1lFQ0NFc0JGUkpFSXlsbFJDSUlLVXNCWnhZcVN3RlFTYnhJVHdLL0swc0JVSUFCQUw4b1RGQ3dJa00yR2dGSEFoVWtFa1FxVEZDOVJRRkFBQWduQkNoTVVMQWlReXRMQVZDQUFZQy9nQnNBR1ZSdlpHOGdiV0Z5YTJWa0lHRnpJR052YlhCc1pYUmxaQ0ZDLzlJMkdnRkpGU1FTUkNwTVVFbTlSUUZBQUFnbkJDaE1VTEFpUTBtK1JFTC85RFlhQVVrVkpCSkVLMHhRU2IxRkFVQUFDWUFCQUNoTVVMQWlRMG0rUkVMLzlDTXBaVVFXS0V4UXNDSkROaG9CUndJVkpCSkVLa3hRU2IxRkFVQUFDQ2NFS0V4UXNDSkRTYnhJSzBzQ1VMeElnQndBR2xSdlpHOGdaR1ZzWlhSbFpDQnpkV05qWlhOelpuVnNiSGtoUXYvUSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjQsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
