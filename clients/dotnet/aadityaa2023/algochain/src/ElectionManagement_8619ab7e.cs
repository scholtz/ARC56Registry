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

namespace Arc56.Generated.aadityaa2023.algochain.ElectionManagement_8619ab7e
{


    public class ElectionManagementProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ElectionManagementProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="name"> </param>
        public async Task<string> Hello(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 190, 206, 17 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Hello_Transactions(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 190, 206, 17 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="voterHash"> </param>
        /// <param name="state"> </param>
        /// <param name="timestamp"> </param>
        public async Task RegisterVoter(string voterHash, string state, string timestamp, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 68, 86, 69 };
            var voterHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); voterHashAbi.From(voterHash);
            var stateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); stateAbi.From(state);
            var timestampAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); timestampAbi.From(timestamp);

            var result = await base.CallApp(new List<object> { abiHandle, voterHashAbi, stateAbi, timestampAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RegisterVoter_Transactions(string voterHash, string state, string timestamp, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 68, 86, 69 };
            var voterHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); voterHashAbi.From(voterHash);
            var stateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); stateAbi.From(state);
            var timestampAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); timestampAbi.From(timestamp);

            return await base.MakeTransactionList(new List<object> { abiHandle, voterHashAbi, stateAbi, timestampAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="voterHash"> </param>
        /// <param name="toState"> </param>
        /// <param name="timestamp"> </param>
        public async Task MigrateVoter(string voterHash, string toState, string timestamp, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 16, 13, 148 };
            var voterHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); voterHashAbi.From(voterHash);
            var toStateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); toStateAbi.From(toState);
            var timestampAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); timestampAbi.From(timestamp);

            var result = await base.CallApp(new List<object> { abiHandle, voterHashAbi, toStateAbi, timestampAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> MigrateVoter_Transactions(string voterHash, string toState, string timestamp, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 16, 13, 148 };
            var voterHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); voterHashAbi.From(voterHash);
            var toStateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); toStateAbi.From(toState);
            var timestampAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); timestampAbi.From(timestamp);

            return await base.MakeTransactionList(new List<object> { abiHandle, voterHashAbi, toStateAbi, timestampAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="voterHash"> </param>
        /// <param name="status"> </param>
        /// <param name="method"> </param>
        /// <param name="timestamp"> </param>
        public async Task VerifyVoter(string voterHash, bool status, string method, string timestamp, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 192, 118, 4 };
            var voterHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); voterHashAbi.From(voterHash);
            var statusAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); statusAbi.From(status);
            var methodAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); methodAbi.From(method);
            var timestampAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); timestampAbi.From(timestamp);

            var result = await base.CallApp(new List<object> { abiHandle, voterHashAbi, statusAbi, methodAbi, timestampAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> VerifyVoter_Transactions(string voterHash, bool status, string method, string timestamp, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 192, 118, 4 };
            var voterHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); voterHashAbi.From(voterHash);
            var statusAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); statusAbi.From(status);
            var methodAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); methodAbi.From(method);
            var timestampAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); timestampAbi.From(timestamp);

            return await base.MakeTransactionList(new List<object> { abiHandle, voterHashAbi, statusAbi, methodAbi, timestampAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRWxlY3Rpb25NYW5hZ2VtZW50IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImhlbGxvIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWdpc3RlclZvdGVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZvdGVySGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RhdGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRpbWVzdGFtcCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJtaWdyYXRlVm90ZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidm90ZXJIYXNoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b1N0YXRlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0aW1lc3RhbXAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmVyaWZ5Vm90ZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidm90ZXJIYXNoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RhdHVzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtZXRob2QiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRpbWVzdGFtcCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzM3XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg0XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCAmJiBjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMjRdLCJlcnJvck1lc3NhZ2UiOiJWb3RlciBhbHJlYWR5IGluIHRoaXMgc3RhdGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTBdLCJlcnJvck1lc3NhZ2UiOiJWb3RlciBhbHJlYWR5IHJlZ2lzdGVyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTZdLCJlcnJvck1lc3NhZ2UiOiJWb3RlciBub3QgcmVnaXN0ZXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkyLDEzOCwxNTQsMTcwLDI2NSwyODEsMjk3LDQyMiw0NDgsNDY1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDQwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk5LDE0NSwxNjEsMTc3LDI3MiwyODgsMzA0LDQyOSw0NTUsNDcyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeUlERUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ0lsd2lMRndpZEdsdFpYTjBZVzF3WENJNlhDSWlJQ0pjSW4waUlDSjJJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnNaV04wYVc5dVgyMWhibUZuWlcxbGJuUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUld4bFkzUnBiMjVOWVc1aFoyVnRaVzUwSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFERXhDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJRzExYzNRZ1ltVWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlREF5WW1WalpURXhJREI0TUdVME5EVTJORFVnTUhoak56RXdNR1E1TkNBd2VHTTVZekEzTmpBMElDOHZJRzFsZEdodlpDQWlhR1ZzYkc4b2MzUnlhVzVuS1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpY21WbmFYTjBaWEpXYjNSbGNpaHpkSEpwYm1jc2MzUnlhVzVuTEhOMGNtbHVaeWwyYjJsa0lpd2diV1YwYUc5a0lDSnRhV2R5WVhSbFZtOTBaWElvYzNSeWFXNW5MSE4wY21sdVp5eHpkSEpwYm1jcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZG1WeWFXWjVWbTkwWlhJb2MzUnlhVzVuTEdKdmIyd3NjM1J5YVc1bkxITjBjbWx1WnlsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYUdWc2JHOGdjbVZuYVhOMFpYSldiM1JsY2lCdGFXZHlZWFJsVm05MFpYSWdkbVZ5YVdaNVZtOTBaWElLSUNBZ0lHVnljZ29LYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1URTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpXeGxZM1JwYjI1ZmJXRnVZV2RsYldWdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJGYkdWamRHbHZiazFoYm1GblpXMWxiblFnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdKaVlLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYlhWemRDQmlaU0JPYjA5d0lDWW1JR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGJHVmpkR2x2Ymw5dFlXNWhaMlZ0Wlc1MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rVnNaV04wYVc5dVRXRnVZV2RsYldWdWRDNW9aV3hzYjF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtaGxiR3h2T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZzWldOMGFXOXVYMjFoYm1GblpXMWxiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zQ2lBZ0lDQXZMeUJvWld4c2J5aHVZVzFsT2lCemRISnBibWNwT2lCemRISnBibWNnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGJHVmpkR2x2Ymw5dFlXNWhaMlZ0Wlc1MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUdCSVpXeHNieXdnSkh0dVlXMWxmV0FLSUNBZ0lIQjFjMmhpZVhSbGN5QWlTR1ZzYkc4c0lDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnNaV04wYVc5dVgyMWhibUZuWlcxbGJuUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNDaUFnSUNBdkx5Qm9aV3hzYnlodVlXMWxPaUJ6ZEhKcGJtY3BPaUJ6ZEhKcGJtY2dld29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYkdWamRHbHZibDl0WVc1aFoyVnRaVzUwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tWc1pXTjBhVzl1VFdGdVlXZGxiV1Z1ZEM1eVpXZHBjM1JsY2xadmRHVnlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY21WbmFYTjBaWEpXYjNSbGNqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGJHVmpkR2x2Ymw5dFlXNWhaMlZ0Wlc1MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USUtJQ0FnSUM4dklISmxaMmx6ZEdWeVZtOTBaWElvZG05MFpYSklZWE5vT2lCemRISnBibWNzSUhOMFlYUmxPaUJ6ZEhKcGJtY3NJSFJwYldWemRHRnRjRG9nYzNSeWFXNW5LVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaV3hsWTNScGIyNWZiV0Z1WVdkbGJXVnVkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalVLSUNBZ0lDOHZJSEpsWjJsemRHVnlaV1JXYjNSbGNuTWdQU0JDYjNoTllYQThjM1J5YVc1bkxDQnpkSEpwYm1jK0tIc2dhMlY1VUhKbFptbDRPaUFuZGljZ2ZTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0luWWlDaUFnSUNCa2FXY2dNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaV3hsWTNScGIyNWZiV0Z1WVdkbGJXVnVkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6Q2lBZ0lDQXZMeUJoYzNObGNuUW9JWFJvYVhNdWNtVm5hWE4wWlhKbFpGWnZkR1Z5Y3loMmIzUmxja2hoYzJncExtVjRhWE4wY3l3Z0oxWnZkR1Z5SUdGc2NtVmhaSGtnY21WbmFYTjBaWEpsWkNjcENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUZadmRHVnlJR0ZzY21WaFpIa2djbVZuYVhOMFpYSmxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnNaV04wYVc5dVgyMWhibUZuWlcxbGJuUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOQW9nSUNBZ0x5OGdkR2hwY3k1eVpXZHBjM1JsY21Wa1ZtOTBaWEp6S0hadmRHVnlTR0Z6YUNrdWRtRnNkV1VnUFNCemRHRjBaUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wld4bFkzUnBiMjVmYldGdVlXZGxiV1Z1ZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMUNpQWdJQ0F2THlCamIyNXpkQ0JzYjJkS2MyOXVJRDBnWUhzaWRIbHdaU0k2SWxKRlIwbFRWRVZTSWl3aWRtOTBaWEpJWVhOb0lqb2lKSHQyYjNSbGNraGhjMmg5SWl3aWMzUmhkR1VpT2lJa2UzTjBZWFJsZlNJc0luUnBiV1Z6ZEdGdGNDSTZJaVI3ZEdsdFpYTjBZVzF3ZlNKOVlBb2dJQ0FnY0hWemFHSjVkR1Z6SUNKN1hDSjBlWEJsWENJNlhDSlNSVWRKVTFSRlVsd2lMRndpZG05MFpYSklZWE5vWENJNlhDSWlDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SUNKY0lpeGNJbk4wWVhSbFhDSTZYQ0lpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pjSWl4Y0luUnBiV1Z6ZEdGdGNGd2lPbHdpSWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0lsd2lmU0lLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZzWldOMGFXOXVYMjFoYm1GblpXMWxiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TmdvZ0lDQWdMeThnYkc5bktHeHZaMHB6YjI0cENpQWdJQ0JzYjJjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYkdWamRHbHZibDl0WVc1aFoyVnRaVzUwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJS0lDQWdJQzh2SUhKbFoybHpkR1Z5Vm05MFpYSW9kbTkwWlhKSVlYTm9PaUJ6ZEhKcGJtY3NJSE4wWVhSbE9pQnpkSEpwYm1jc0lIUnBiV1Z6ZEdGdGNEb2djM1J5YVc1bktUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZzWldOMGFXOXVYMjFoYm1GblpXMWxiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82Uld4bFkzUnBiMjVOWVc1aFoyVnRaVzUwTG0xcFozSmhkR1ZXYjNSbGNsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbTFwWjNKaGRHVldiM1JsY2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYkdWamRHbHZibDl0WVc1aFoyVnRaVzUwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpBS0lDQWdJQzh2SUcxcFozSmhkR1ZXYjNSbGNpaDJiM1JsY2toaGMyZzZJSE4wY21sdVp5d2dkRzlUZEdGMFpUb2djM1J5YVc1bkxDQjBhVzFsYzNSaGJYQTZJSE4wY21sdVp5azZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnNaV04wYVc5dVgyMWhibUZuWlcxbGJuUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFDaUFnSUNBdkx5QnlaV2RwYzNSbGNtVmtWbTkwWlhKeklEMGdRbTk0VFdGd1BITjBjbWx1Wnl3Z2MzUnlhVzVuUGloN0lHdGxlVkJ5WldacGVEb2dKM1luSUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKMklnb2dJQ0FnWkdsbklETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnNaV04wYVc5dVgyMWhibUZuWlcxbGJuUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNUW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11Y21WbmFYTjBaWEpsWkZadmRHVnljeWgyYjNSbGNraGhjMmdwTG1WNGFYTjBjeXdnSjFadmRHVnlJRzV2ZENCeVpXZHBjM1JsY21Wa0p5a0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdWbTkwWlhJZ2JtOTBJSEpsWjJsemRHVnlaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxiR1ZqZEdsdmJsOXRZVzVoWjJWdFpXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNaklLSUNBZ0lDOHZJR052Ym5OMElHWnliMjFUZEdGMFpTQTlJSFJvYVhNdWNtVm5hWE4wWlhKbFpGWnZkR1Z5Y3loMmIzUmxja2hoYzJncExuWmhiSFZsQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZzWldOMGFXOXVYMjFoYm1GblpXMWxiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TXdvZ0lDQWdMeThnWVhOelpYSjBLR1p5YjIxVGRHRjBaU0FoUFQwZ2RHOVRkR0YwWlN3Z0oxWnZkR1Z5SUdGc2NtVmhaSGtnYVc0Z2RHaHBjeUJ6ZEdGMFpTY3BDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QTBDaUFnSUNBaFBRb2dJQ0FnWVhOelpYSjBJQzh2SUZadmRHVnlJR0ZzY21WaFpIa2dhVzRnZEdocGN5QnpkR0YwWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZzWldOMGFXOXVYMjFoYm1GblpXMWxiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TkFvZ0lDQWdMeThnZEdocGN5NXlaV2RwYzNSbGNtVmtWbTkwWlhKektIWnZkR1Z5U0dGemFDa3VkbUZzZFdVZ1BTQjBiMU4wWVhSbENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNd29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZzWldOMGFXOXVYMjFoYm1GblpXMWxiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TlFvZ0lDQWdMeThnWTI5dWMzUWdiRzluU25OdmJpQTlJR0I3SW5SNWNHVWlPaUpOU1VkU1FWUkZJaXdpZG05MFpYSklZWE5vSWpvaUpIdDJiM1JsY2toaGMyaDlJaXdpWm5KdmJWTjBZWFJsSWpvaUpIdG1jbTl0VTNSaGRHVjlJaXdpZEc5VGRHRjBaU0k2SWlSN2RHOVRkR0YwWlgwaUxDSjBhVzFsYzNSaGJYQWlPaUlrZTNScGJXVnpkR0Z0Y0gwaWZXQUtJQ0FnSUhCMWMyaGllWFJsY3lBaWUxd2lkSGx3WlZ3aU9sd2lUVWxIVWtGVVJWd2lMRndpZG05MFpYSklZWE5vWENJNlhDSWlDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SUNKY0lpeGNJbVp5YjIxVGRHRjBaVndpT2x3aUlnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlYQ0lzWENKMGIxTjBZWFJsWENJNlhDSWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmNJaXhjSW5ScGJXVnpkR0Z0Y0Z3aU9sd2lJZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6RWdMeThnSWx3aWZTSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnNaV04wYVc5dVgyMWhibUZuWlcxbGJuUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOZ29nSUNBZ0x5OGdiRzluS0d4dlowcHpiMjRwQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxiR1ZqZEdsdmJsOXRZVzVoWjJWdFpXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakFLSUNBZ0lDOHZJRzFwWjNKaGRHVldiM1JsY2loMmIzUmxja2hoYzJnNklITjBjbWx1Wnl3Z2RHOVRkR0YwWlRvZ2MzUnlhVzVuTENCMGFXMWxjM1JoYlhBNklITjBjbWx1WnlrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxiR1ZqZEdsdmJsOXRZVzVoWjJWdFpXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa1ZzWldOMGFXOXVUV0Z1WVdkbGJXVnVkQzUyWlhKcFpubFdiM1JsY2x0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuWmxjbWxtZVZadmRHVnlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnNaV04wYVc5dVgyMWhibUZuWlcxbGJuUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNQW9nSUNBZ0x5OGdkbVZ5YVdaNVZtOTBaWElvZG05MFpYSklZWE5vT2lCemRISnBibWNzSUhOMFlYUjFjem9nWW05dmJHVmhiaXdnYldWMGFHOWtPaUJ6ZEhKcGJtY3NJSFJwYldWemRHRnRjRG9nYzNSeWFXNW5LVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbUp2YjJ3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCemQyRndDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZzWldOMGFXOXVYMjFoYm1GblpXMWxiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TVFvZ0lDQWdMeThnWTI5dWMzUWdjM1JoZEhWelUzUnlJRDBnYzNSaGRIVnpJRDhnSW5SeWRXVWlJRG9nSW1aaGJITmxJZ29nSUNBZ1lub2dkbVZ5YVdaNVZtOTBaWEpmZEdWeWJtRnllVjltWVd4elpVQXpDaUFnSUNCd2RYTm9ZbmwwWlhNZ0luUnlkV1VpQ2dwMlpYSnBabmxXYjNSbGNsOTBaWEp1WVhKNVgyMWxjbWRsUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wld4bFkzUnBiMjVmYldGdVlXZGxiV1Z1ZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNeUNpQWdJQ0F2THlCamIyNXpkQ0JzYjJkS2MyOXVJRDBnWUhzaWRIbHdaU0k2SWxaRlVrbEdXU0lzSW5admRHVnlTR0Z6YUNJNklpUjdkbTkwWlhKSVlYTm9mU0lzSW5OMFlYUjFjeUk2Skh0emRHRjBkWE5UZEhKOUxDSnRaWFJvYjJRaU9pSWtlMjFsZEdodlpIMGlMQ0owYVcxbGMzUmhiWEFpT2lJa2UzUnBiV1Z6ZEdGdGNIMGlmV0FLSUNBZ0lIQjFjMmhpZVhSbGN5QWllMXdpZEhsd1pWd2lPbHdpVmtWU1NVWlpYQ0lzWENKMmIzUmxja2hoYzJoY0lqcGNJaUlLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUFpWENJc1hDSnpkR0YwZFhOY0lqb2lDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lzWENKdFpYUm9iMlJjSWpwY0lpSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWENJc1hDSjBhVzFsYzNSaGJYQmNJanBjSWlJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlYQ0o5SWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wld4bFkzUnBiMjVmYldGdVlXZGxiV1Z1ZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNekNpQWdJQ0F2THlCc2IyY29iRzluU25OdmJpa0tJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWc1pXTjBhVzl1WDIxaGJtRm5aVzFsYm5RdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1Bb2dJQ0FnTHk4Z2RtVnlhV1o1Vm05MFpYSW9kbTkwWlhKSVlYTm9PaUJ6ZEhKcGJtY3NJSE4wWVhSMWN6b2dZbTl2YkdWaGJpd2diV1YwYUc5a09pQnpkSEpwYm1jc0lIUnBiV1Z6ZEdGdGNEb2djM1J5YVc1bktUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncDJaWEpwWm5sV2IzUmxjbDkwWlhKdVlYSjVYMlpoYkhObFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpXeGxZM1JwYjI1ZmJXRnVZV2RsYldWdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXhDaUFnSUNBdkx5QmpiMjV6ZENCemRHRjBkWE5UZEhJZ1BTQnpkR0YwZFhNZ1B5QWlkSEoxWlNJZ09pQWlabUZzYzJVaUNpQWdJQ0J3ZFhOb1lubDBaWE1nSW1aaGJITmxJZ29nSUNBZ1lpQjJaWEpwWm5sV2IzUmxjbDkwWlhKdVlYSjVYMjFsY21kbFFEUUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QURBQUlCSmdNUElpd2lkR2x0WlhOMFlXMXdJam9pQWlKOUFYWXhHMEVBS3pFWkZFUXhHRVNDQkFRQ3ZzNFJCQTVFVmtVRXh4QU5sQVRKd0hZRU5ob0FqZ1FBQ3dBNUFMZ0JWUUF4R1JReEdCUVFSQ1JETmhvQlNTSlpJd2hMQVJVU1JGY0NBSUFIU0dWc2JHOHNJRXhRU1JVV1Z3WUNURkNBQkJVZmZIVk1VTEFrUXpZYUFVa2lXU01JU3dFVkVrUlhBZ0EyR2dKSklsa2pDRXNCRlJKRVZ3SUFOaG9EU1NKWkl3aExBUlVTUkZjQ0FDcExBMUJKdlVVQkZFUkp2RWhMQXIrQUlIc2lkSGx3WlNJNklsSkZSMGxUVkVWU0lpd2lkbTkwWlhKSVlYTm9Jam9pVHdOUWdBc2lMQ0p6ZEdGMFpTSTZJbEJQQWxBb1VFeFFLVkN3SkVNMkdnRkpJbGtqQ0VzQkZSSkVWd0lBTmhvQ1NTSlpJd2hMQVJVU1JGY0NBRFlhQTBraVdTTUlTd0VWRWtSWEFnQXFTd05RU2IxRkFVUkp2a2hKU3dRVFJFc0J2RWhNU3dPL2dCOTdJblI1Y0dVaU9pSk5TVWRTUVZSRklpd2lkbTkwWlhKSVlYTm9Jam9pVHdSUWdBOGlMQ0ptY205dFUzUmhkR1VpT2lKUVRGQ0FEU0lzSW5SdlUzUmhkR1VpT2lKUVR3SlFLRkJNVUNsUXNDUkROaG9CU1NKWkl3aExBUlVTUkZjQ0FEWWFBa2tWSkJKRUlsTTJHZ05KSWxrakNFc0JGUkpFVndJQVREWWFCRWtpV1NNSVN3RVZFa1JYQWdCTVFRQlVnQVIwY25WbGdCNTdJblI1Y0dVaU9pSldSVkpKUmxraUxDSjJiM1JsY2toaGMyZ2lPaUpMQkZDQUN5SXNJbk4wWVhSMWN5STZVRXhRZ0Fzc0ltMWxkR2h2WkNJNklsQkxBbEFvVUVzQlVDbFFzQ1JEZ0FWbVlXeHpaVUwvcUE9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjMsInBhdGNoIjoyLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
