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

namespace Arc56.Generated.ghoshvidip26.VoiceVaultAlgorand.VoiceApp_b18fcbb1
{


    //
    // 
    //    A contract that manages AI voice models, rights, and pricing.
    //    
    //
    public class VoiceAppProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public VoiceAppProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        /// <param name="model_uri"> </param>
        /// <param name="rights"> </param>
        /// <param name="price_per_use"> </param>
        public async Task RegisterVoice(string name, string model_uri, string rights, ulong price_per_use, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 104, 171, 159, 19 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var model_uriAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); model_uriAbi.From(model_uri);
            var rightsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); rightsAbi.From(rights);
            var price_per_useAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); price_per_useAbi.From(price_per_use);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi, model_uriAbi, rightsAbi, price_per_useAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RegisterVoice_Transactions(string name, string model_uri, string rights, ulong price_per_use, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 104, 171, 159, 19 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var model_uriAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); model_uriAbi.From(model_uri);
            var rightsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); rightsAbi.From(rights);
            var price_per_useAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); price_per_useAbi.From(price_per_use);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi, model_uriAbi, rightsAbi, price_per_useAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="owner"> </param>
        public async Task<ulong> GetVoiceId(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 39, 4, 229 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            var result = await base.SimApp(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetVoiceId_Transactions(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 39, 4, 229 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="owner"> </param>
        public async Task<bool> VoiceExists(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 81, 238, 127 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            var result = await base.SimApp(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VoiceExists_Transactions(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 81, 238, 127 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task UnregisterVoice(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 233, 208, 239, 219 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UnregisterVoice_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 233, 208, 239, 219 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVm9pY2VBcHAiLCJkZXNjIjoiXG4gICAgQSBjb250cmFjdCB0aGF0IG1hbmFnZXMgQUkgdm9pY2UgbW9kZWxzLCByaWdodHMsIGFuZCBwcmljaW5nLlxuICAgICIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJyZWdpc3Rlcl92b2ljZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtb2RlbF91cmkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJpZ2h0cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJpY2VfcGVyX3VzZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdm9pY2VfaWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2b2ljZV9leGlzdHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidW5yZWdpc3Rlcl92b2ljZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzIzNF0sImVycm9yTWVzc2FnZSI6IlZvaWNlIElEIG5vdCBmb3VuZCBmb3IgdGhpcyBvd25lciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyMiwxMzUsMTQ4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI5LDE0MiwxNTVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjI3LDI1MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ01pQXpNZ29nSUNBZ1lubDBaV05pYkc5amF5QXdlRFkxTnpnMk9UY3pOelEzTXpWbUlEQjROamsyTkRWbUlEQjRObVUyTVRaa05qVTFaaUF3ZURjMU56STJPVFZtSURCNE56STJPVFkzTmpnM05EY3pOV1lnTUhnM01EY3lOamsyTXpZMU5XWWdNSGcyTXpjeU5qVTJNVGMwTmpVMk5EVm1JREI0TVRVeFpqZGpOelVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTJiMmxqWlM5amIyNTBjbUZqZEM1d2VUb3hNQW9nSUNBZ0x5OGdZMnhoYzNNZ1ZtOXBZMlZCY0hBb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURFeENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnMk9HRmlPV1l4TXlBd2VERmlNamN3TkdVMUlEQjRZemMxTVdWbE4yWWdNSGhsT1dRd1pXWmtZaUF2THlCdFpYUm9iMlFnSW5KbFoybHpkR1Z5WDNadmFXTmxLSE4wY21sdVp5eHpkSEpwYm1jc2MzUnlhVzVuTEhWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSm5aWFJmZG05cFkyVmZhV1FvWVdSa2NtVnpjeWwxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJblp2YVdObFgyVjRhWE4wY3loaFpHUnlaWE56S1dKdmIyd2lMQ0J0WlhSb2IyUWdJblZ1Y21WbmFYTjBaWEpmZG05cFkyVW9LWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnlaV2RwYzNSbGNsOTJiMmxqWlNCblpYUmZkbTlwWTJWZmFXUWdkbTlwWTJWZlpYaHBjM1J6SUhWdWNtVm5hWE4wWlhKZmRtOXBZMlVLSUNBZ0lHVnljZ29LYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBeE1Ub0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNBbUpnb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5admFXTmxMbU52Ym5SeVlXTjBMbFp2YVdObFFYQndMbkpsWjJsemRHVnlYM1p2YVdObFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVZuYVhOMFpYSmZkbTlwWTJVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG05cFkyVXZZMjl1ZEhKaFkzUXVjSGs2TVRVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTJiMmxqWlM5amIyNTBjbUZqZEM1d2VUb3lNeTB5TkFvZ0lDQWdMeThnSXlCVmMyVWdSMnh2WW1Gc0xtTnlaV0YwYjNKZllXUmtjbVZ6Y3lCaWVYUmxjeUJoY3lCd1lYSjBJRzltSUhSb1pTQnJaWGtLSUNBZ0lDOHZJR0ZrWkhKZllubDBaWE1nUFNCSGJHOWlZV3d1WTNKbFlYUnZjbDloWkdSeVpYTnpMbUo1ZEdWekNpQWdJQ0JuYkc5aVlXd2dRM0psWVhSdmNrRmtaSEpsYzNNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyYjJsalpTOWpiMjUwY21GamRDNXdlVG95TmdvZ0lDQWdMeThnYjNBdVFYQndSMnh2WW1Gc0xuQjFkQ2hpSW1WNGFYTjBjMThpSUNzZ1lXUmtjbDlpZVhSbGN5d2dWVWx1ZERZMEtERXBLUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlRFkxTnpnMk9UY3pOelEzTXpWbUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MmIybGpaUzlqYjI1MGNtRmpkQzV3ZVRveU55MHlPQW9nSUNBZ0x5OGdJeUJ2Y0M1QmNIQkhiRzlpWVd3dWNIVjBLR0lpYVdSZklpQXJJR0ZrWkhKZllubDBaWE1zSUVkc2IySmhiQzV5YjNWdVpDa2dJeUJIYkc5aVlXd3VjbTkxYm1RZ2FYTWdabWx1WlFvZ0lDQWdMeThnYjNBdVFYQndSMnh2WW1Gc0xuQjFkQ2hpSW1sa1h5SWdLeUJoWkdSeVgySjVkR1Z6TENCSGJHOWlZV3d1Y205MWJtUXBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjROamsyTkRWbUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbmJHOWlZV3dnVW05MWJtUUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtOXBZMlV2WTI5dWRISmhZM1F1Y0hrNk1qa0tJQ0FnSUM4dklHOXdMa0Z3Y0Vkc2IySmhiQzV3ZFhRb1lpSnVZVzFsWHlJZ0t5QmhaR1J5WDJKNWRHVnpMQ0J1WVcxbExtSjVkR1Z6S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURabE5qRTJaRFkxTldZS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyYjJsalpTOWpiMjUwY21GamRDNXdlVG96TUFvZ0lDQWdMeThnYjNBdVFYQndSMnh2WW1Gc0xuQjFkQ2hpSW5WeWFWOGlJQ3NnWVdSa2NsOWllWFJsY3l3Z2JXOWtaV3hmZFhKcExtSjVkR1Z6S1FvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURjMU56STJPVFZtQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbTlwWTJVdlkyOXVkSEpoWTNRdWNIazZNekVLSUNBZ0lDOHZJRzl3TGtGd2NFZHNiMkpoYkM1d2RYUW9ZaUp5YVdkb2RITmZJaUFySUdGa1pISmZZbmwwWlhNc0lISnBaMmgwY3k1aWVYUmxjeWtLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGczTWpZNU5qYzJPRGMwTnpNMVpnb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNadmFXTmxMMk52Ym5SeVlXTjBMbkI1T2pNeUNpQWdJQ0F2THlCdmNDNUJjSEJIYkc5aVlXd3VjSFYwS0dJaWNISnBZMlZmSWlBcklHRmtaSEpmWW5sMFpYTXNJSEJ5YVdObFgzQmxjbDkxYzJVdWJtRjBhWFpsS1FvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURjd056STJPVFl6TmpVMVpnb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JpZEc5cENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNadmFXTmxMMk52Ym5SeVlXTjBMbkI1T2pNekNpQWdJQ0F2THlCdmNDNUJjSEJIYkc5aVlXd3VjSFYwS0dJaVkzSmxZWFJsWkY4aUlDc2dZV1JrY2w5aWVYUmxjeXdnUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQXBDaUFnSUNCaWVYUmxZeUEySUM4dklEQjROak0zTWpZMU5qRTNORFkxTmpRMVpnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzWnZhV05sTDJOdmJuUnlZV04wTG5CNU9qRTFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVkbTlwWTJVdVkyOXVkSEpoWTNRdVZtOXBZMlZCY0hBdVoyVjBYM1p2YVdObFgybGtXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgzWnZhV05sWDJsa09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNadmFXTmxMMk52Ym5SeVlXTjBMbkI1T2pNMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNadmFXTmxMMk52Ym5SeVlXTjBMbkI1T2pNNENpQWdJQ0F2THlCMllXd3NJR1Y0YVhOMGN5QTlJRzl3TGtGd2NFZHNiMkpoYkM1blpYUmZaWGhmZFdsdWREWTBLRlZKYm5RMk5DZ3dLU3dnWWlKcFpGOGlJQ3NnWVdSa2NsOWllWFJsY3lrS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnMk9UWTBOV1lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG05cFkyVXZZMjl1ZEhKaFkzUXVjSGs2TXprS0lDQWdJQzh2SUdGemMyVnlkQ0JsZUdsemRITXNJQ0pXYjJsalpTQkpSQ0J1YjNRZ1ptOTFibVFnWm05eUlIUm9hWE1nYjNkdVpYSWlDaUFnSUNCaGMzTmxjblFnTHk4Z1ZtOXBZMlVnU1VRZ2JtOTBJR1p2ZFc1a0lHWnZjaUIwYUdseklHOTNibVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbTlwWTJVdlkyOXVkSEpoWTNRdWNIazZOREFLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGxWSmJuUTJOQ2gyWVd3cENpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG05cFkyVXZZMjl1ZEhKaFkzUXVjSGs2TXpVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWW5sMFpXTWdOeUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTUyYjJsalpTNWpiMjUwY21GamRDNVdiMmxqWlVGd2NDNTJiMmxqWlY5bGVHbHpkSE5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMmIybGpaVjlsZUdsemRITTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtOXBZMlV2WTI5dWRISmhZM1F1Y0hrNk5ESUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtOXBZMlV2WTI5dWRISmhZM1F1Y0hrNk5EVUtJQ0FnSUM4dklHbG5ibTl5WldSZmRtRnNMQ0JsZUdsemRITWdQU0J2Y0M1QmNIQkhiRzlpWVd3dVoyVjBYMlY0WDNWcGJuUTJOQ2hWU1c1ME5qUW9NQ2tzSUdJaVpYaHBjM1J6WHlJZ0t5QmhaR1J5WDJKNWRHVnpLUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlRFkxTnpnMk9UY3pOelEzTXpWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1luVnllU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbTlwWTJVdlkyOXVkSEpoWTNRdWNIazZORFlLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGtKdmIyd29aWGhwYzNSektRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1p2YVdObEwyTnZiblJ5WVdOMExuQjVPalF5Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0o1ZEdWaklEY2dMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVkbTlwWTJVdVkyOXVkSEpoWTNRdVZtOXBZMlZCY0hBdWRXNXlaV2RwYzNSbGNsOTJiMmxqWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuVnVjbVZuYVhOMFpYSmZkbTlwWTJVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG05cFkyVXZZMjl1ZEhKaFkzUXVjSGs2TlRBdE5URUtJQ0FnSUM4dklDTWdRWE56ZFcxcGJtY2diMjVzZVNCamNtVmhkRzl5SUdOaGJpQjFibkpsWjJsemRHVnlJSFJvWldseUlHOTNiaUIyYjJsalpTQm1iM0lnYm05M0lHSmhjMlZrSUc5dUlIQnlaWFpwYjNWeklHeHZaMmxqQ2lBZ0lDQXZMeUJoWkdSeVgySjVkR1Z6SUQwZ1IyeHZZbUZzTG1OeVpXRjBiM0pmWVdSa2NtVnpjeTVpZVhSbGN3b2dJQ0FnWjJ4dlltRnNJRU55WldGMGIzSkJaR1J5WlhOekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG05cFkyVXZZMjl1ZEhKaFkzUXVjSGs2TlRJS0lDQWdJQzh2SUc5d0xrRndjRWRzYjJKaGJDNWtaV3hsZEdVb1lpSmxlR2x6ZEhOZklpQXJJR0ZrWkhKZllubDBaWE1wQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TmpVM09EWTVOek0zTkRjek5XWUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHRndjRjluYkc5aVlXeGZaR1ZzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbTlwWTJVdlkyOXVkSEpoWTNRdWNIazZOVE1LSUNBZ0lDOHZJRzl3TGtGd2NFZHNiMkpoYkM1a1pXeGxkR1VvWWlKcFpGOGlJQ3NnWVdSa2NsOWllWFJsY3lrS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnMk9UWTBOV1lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWkdWc0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG05cFkyVXZZMjl1ZEhKaFkzUXVjSGs2TlRRS0lDQWdJQzh2SUc5d0xrRndjRWRzYjJKaGJDNWtaV3hsZEdVb1lpSnVZVzFsWHlJZ0t5QmhaR1J5WDJKNWRHVnpLUW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlRFpsTmpFMlpEWTFOV1lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWkdWc0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG05cFkyVXZZMjl1ZEhKaFkzUXVjSGs2TlRVS0lDQWdJQzh2SUc5d0xrRndjRWRzYjJKaGJDNWtaV3hsZEdVb1lpSjFjbWxmSWlBcklHRmtaSEpmWW5sMFpYTXBDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjROelUzTWpZNU5XWUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHRndjRjluYkc5aVlXeGZaR1ZzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbTlwWTJVdlkyOXVkSEpoWTNRdWNIazZOVFlLSUNBZ0lDOHZJRzl3TGtGd2NFZHNiMkpoYkM1a1pXeGxkR1VvWWlKeWFXZG9kSE5mSWlBcklHRmtaSEpmWW5sMFpYTXBDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjROekkyT1RZM05qZzNORGN6TldZS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZlpHVnNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtOXBZMlV2WTI5dWRISmhZM1F1Y0hrNk5UY0tJQ0FnSUM4dklHOXdMa0Z3Y0Vkc2IySmhiQzVrWld4bGRHVW9ZaUp3Y21salpWOGlJQ3NnWVdSa2NsOWllWFJsY3lrS0lDQWdJR0o1ZEdWaklEVWdMeThnTUhnM01EY3lOamsyTXpZMU5XWUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHRndjRjluYkc5aVlXeGZaR1ZzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbTlwWTJVdlkyOXVkSEpoWTNRdWNIazZOVGdLSUNBZ0lDOHZJRzl3TGtGd2NFZHNiMkpoYkM1a1pXeGxkR1VvWWlKamNtVmhkR1ZrWHlJZ0t5QmhaR1J5WDJKNWRHVnpLUW9nSUNBZ1lubDBaV01nTmlBdkx5QXdlRFl6TnpJMk5UWXhOelEyTlRZME5XWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lYQndYMmRzYjJKaGJGOWtaV3dLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTJiMmxqWlM5amIyNTBjbUZqZEM1d2VUbzBPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFQ0lDWUlCMlY0YVhOMGMxOERhV1JmQlc1aGJXVmZCSFZ5YVY4SGNtbG5hSFJ6WHdad2NtbGpaVjhJWTNKbFlYUmxaRjhFRlI5OGRURWJRUUFyTVJrVVJERVlSSUlFQkdpcm54TUVHeWNFNVFUSFVlNS9CT25RNzlzMkdnQ09CQUFKQUhBQWh3Q2xBREVaRkRFWUZCQkROaG9CU1NKWkpBaExBUlVTUkRZYUFra2lXU1FJU3dFVkVrUTJHZ05KSWxra0NFc0JGUkpFTmhvRVNSV0JDQkpFTWdrb1N3RlFJMmNwU3dGUU1nWm5La3NCVUU4Rlp5dExBVkJQQkdjbkJFc0JVRThEWnljRlN3RlFUd0lYWnljR1RGQXlCMmNqUXpZYUFVa1ZKUkpFS1V4UUlreGxSQlluQjB4UXNDTkROaG9CU1JVbEVrUW9URkFpVEdWRkFZQUJBQ0pQQWxRbkIweFFzQ05ETWdrb1N3RlFhU2xMQVZCcEtrc0JVR2tyU3dGUWFTY0VTd0ZRYVNjRlN3RlFhU2NHVEZCcEkwTT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo3LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
