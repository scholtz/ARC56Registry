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

namespace Arc56.Generated.Algorand_Developer_Retreat.makerx_ai_agents.AiRegistry_b5382e1a
{


    public class AiRegistryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AiRegistryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="lsig_address"> </param>
        /// <param name="admin_address"> </param>
        public async Task Bootstrap(Address lsig_address, Address admin_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { lsig_address, admin_address });
            byte lsig_addressRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte admin_addressRefIndex = (byte)(_acctRefBase + 1 + 1);
            byte[] abiHandle = { 215, 92, 4, 230 };
            var lsig_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); lsig_addressAbi.From(lsig_address);
            var admin_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); admin_addressAbi.From(admin_address);

            var result = await base.CallApp(new List<object> { abiHandle, lsig_addressRefIndex, admin_addressRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Bootstrap_Transactions(Address lsig_address, Address admin_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { lsig_address, admin_address });
            byte lsig_addressRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte admin_addressRefIndex = (byte)(_acctRefBase + 1 + 1);
            byte[] abiHandle = { 215, 92, 4, 230 };
            var lsig_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); lsig_addressAbi.From(lsig_address);
            var admin_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); admin_addressAbi.From(admin_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, lsig_addressRefIndex, admin_addressRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agent_p_key"> </param>
        /// <param name="permissions"> </param>
        /// <param name="max_amount"> </param>
        /// <param name="valid_until_round"> </param>
        public async Task RegisterAgent(byte[] agent_p_key, ulong permissions, ulong max_amount, ulong valid_until_round, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 169, 141, 247 };
            var agent_p_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); agent_p_keyAbi.From(agent_p_key);
            var permissionsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); permissionsAbi.From(permissions);
            var max_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); max_amountAbi.From(max_amount);
            var valid_until_roundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valid_until_roundAbi.From(valid_until_round);

            var result = await base.CallApp(new List<object> { abiHandle, agent_p_keyAbi, permissionsAbi, max_amountAbi, valid_until_roundAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RegisterAgent_Transactions(byte[] agent_p_key, ulong permissions, ulong max_amount, ulong valid_until_round, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 169, 141, 247 };
            var agent_p_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); agent_p_keyAbi.From(agent_p_key);
            var permissionsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); permissionsAbi.From(permissions);
            var max_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); max_amountAbi.From(max_amount);
            var valid_until_roundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valid_until_roundAbi.From(valid_until_round);

            return await base.MakeTransactionList(new List<object> { abiHandle, agent_p_keyAbi, permissionsAbi, max_amountAbi, valid_until_roundAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="amount"> </param>
        /// <param name="receiver"> </param>
        /// <param name="agent_name"> </param>
        /// <param name="agent_p_key"> </param>
        /// <param name="signature"> </param>
        public async Task IssuePayment(Address receiver, ulong amount, string agent_name, byte[] agent_p_key, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { receiver });
            byte receiverRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 82, 115, 52, 105 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var agent_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); agent_nameAbi.From(agent_name);
            var agent_p_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); agent_p_keyAbi.From(agent_p_key);
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi, receiverRefIndex, agent_nameAbi, agent_p_keyAbi, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> IssuePayment_Transactions(Address receiver, ulong amount, string agent_name, byte[] agent_p_key, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { receiver });
            byte receiverRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 82, 115, 52, 105 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var agent_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); agent_nameAbi.From(agent_name);
            var agent_p_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); agent_p_keyAbi.From(agent_p_key);
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi, receiverRefIndex, agent_nameAbi, agent_p_keyAbi, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="receiver"> </param>
        /// <param name="amount"> </param>
        /// <param name="asset_id"> </param>
        /// <param name="agent_p_key"> </param>
        /// <param name="signature"> </param>
        public async Task IssueAxfer(Address receiver, ulong amount, ulong asset_id, byte[] agent_p_key, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { receiver });
            byte receiverRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 43, 207, 4, 248 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);
            var agent_p_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); agent_p_keyAbi.From(agent_p_key);
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            var result = await base.CallApp(new List<object> { abiHandle, receiverRefIndex, amountAbi, asset_idAbi, agent_p_keyAbi, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> IssueAxfer_Transactions(Address receiver, ulong amount, ulong asset_id, byte[] agent_p_key, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { receiver });
            byte receiverRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 43, 207, 4, 248 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);
            var agent_p_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); agent_p_keyAbi.From(agent_p_key);
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            return await base.MakeTransactionList(new List<object> { abiHandle, receiverRefIndex, amountAbi, asset_idAbi, agent_p_keyAbi, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset_id"> </param>
        /// <param name="agent_p_key"> </param>
        /// <param name="signature"> </param>
        public async Task IssueOptIn(ulong asset_id, byte[] agent_p_key, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 9, 135, 136 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);
            var agent_p_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); agent_p_keyAbi.From(agent_p_key);
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            var result = await base.CallApp(new List<object> { abiHandle, asset_idAbi, agent_p_keyAbi, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> IssueOptIn_Transactions(ulong asset_id, byte[] agent_p_key, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 9, 135, 136 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);
            var agent_p_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); agent_p_keyAbi.From(agent_p_key);
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            return await base.MakeTransactionList(new List<object> { abiHandle, asset_idAbi, agent_p_keyAbi, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWlSZWdpc3RyeSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJib290c3RyYXAiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImxzaWdfYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkbWluX2FkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVnaXN0ZXJfYWdlbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnRfcF9rZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBlcm1pc3Npb25zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYXhfYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWxpZF91bnRpbF9yb3VuZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc3N1ZV9wYXltZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2VpdmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudF9uYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudF9wX2tleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2lnbmF0dXJlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Imlzc3VlX2F4ZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNlaXZlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnRfcF9rZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNpZ25hdHVyZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc3N1ZV9vcHRfaW4iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFnZW50X3Bfa2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaWduYXR1cmUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjoyfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls0NzZdLCJlcnJvck1lc3NhZ2UiOiJBZ2VudCBhdXRob3JpemF0aW9uIGV4cGlyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MDFdLCJlcnJvck1lc3NhZ2UiOiJBZ2VudCBub3QgcmVnaXN0ZXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzOF0sImVycm9yTWVzc2FnZSI6IkFscmVhZHkgYm9vdHN0cmFwcGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDcyXSwiZXJyb3JNZXNzYWdlIjoiQW1vdW50IGV4Y2VlZHMgYWdlbnQncyBsaW1pdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUzMyw2MTUsNjkzXSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZCBzaWduYXR1cmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDMsMTMxLDE2OSwyMDksMjM5XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzkxXSwiZXJyb3JNZXNzYWdlIjoiT25seSBMU0lHIGNhbiBjYWxsIHRoaXMgbWV0aG9kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzU4XSwiZXJyb3JNZXNzYWdlIjoiT25seSBhZG1pbiBjYW4gcmVnaXN0ZXIgYWdlbnRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDY2XSwiZXJyb3JNZXNzYWdlIjoiT3BlcmF0aW9uIG5vdCBhbGxvd2VkIGZvciB0aGlzIGFnZW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjY4XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA2LDEzNCwxNzIsMjEyLDI0Ml0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNTZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFkbWluIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwM10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYWdlbnRfcGVybWlzc2lvbnMgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTAwLDU4MCw2NjZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmxhc3RfdmFsaWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzM0LDM4OV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubHNpZ19hZGRyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WVdsZmNtVm5hWE4wY25rdVkyOXVkSEpoWTNRdVFXbFNaV2RwYzNSeWVTNWZYMkZzWjI5d2VWOWxiblJ5ZVhCdmFXNTBYM2RwZEdoZmFXNXBkQ2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnT0NBeE5pQXhNREF3TURBS0lDQWdJR0o1ZEdWallteHZZMnNnTUhnMll6YzJJQ0pzYzJsblgyRmtaSElpSUNKaFpHMXBiaUlnTUhnd05qZ3hNREVnTUhnMk1UY3dDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKc2MybG5YMkZrWkhJaUNpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0poWkcxcGJpSUtJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlltRnlaVjl5YjNWMGFXNW5RREV3Q2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0WkRjMVl6QTBaVFlnTUhneU4yRTVPR1JtTnlBd2VEVXlOek16TkRZNUlEQjRNbUpqWmpBMFpqZ2dNSGd4TVRBNU9EYzRPQ0F2THlCdFpYUm9iMlFnSW1KdmIzUnpkSEpoY0NoaFkyTnZkVzUwTEdGalkyOTFiblFwZG05cFpDSXNJRzFsZEdodlpDQWljbVZuYVhOMFpYSmZZV2RsYm5Rb1lubDBaVnRkTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1semMzVmxYM0JoZVcxbGJuUW9kV2x1ZERZMExHRmpZMjkxYm5Rc2MzUnlhVzVuTEdKNWRHVmJYU3hpZVhSbFcxMHBkbTlwWkNJc0lHMWxkR2h2WkNBaWFYTnpkV1ZmWVhobVpYSW9ZV05qYjNWdWRDeDFhVzUwTmpRc2RXbHVkRFkwTEdKNWRHVmJYU3hpZVhSbFcxMHBkbTlwWkNJc0lHMWxkR2h2WkNBaWFYTnpkV1ZmYjNCMFgybHVLSFZwYm5RMk5DeGllWFJsVzEwc1lubDBaVnRkS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgySnZiM1J6ZEhKaGNGOXliM1YwWlVBMUlHMWhhVzVmY21WbmFYTjBaWEpmWVdkbGJuUmZjbTkxZEdWQU5pQnRZV2x1WDJsemMzVmxYM0JoZVcxbGJuUmZjbTkxZEdWQU55QnRZV2x1WDJsemMzVmxYMkY0Wm1WeVgzSnZkWFJsUURnZ2JXRnBibDlwYzNOMVpWOXZjSFJmYVc1ZmNtOTFkR1ZBT1FvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERXlPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXBjM04xWlY5dmNIUmZhVzVmY205MWRHVkFPVG9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JqWVd4c2MzVmlJR2x6YzNWbFgyOXdkRjlwYmdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlwYzNOMVpWOWhlR1psY2w5eWIzVjBaVUE0T2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoY3lCQlkyTnZkVzUwY3dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCallXeHNjM1ZpSUdsemMzVmxYMkY0Wm1WeUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJsemMzVmxYM0JoZVcxbGJuUmZjbTkxZEdWQU56b0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlYTWdRV05qYjNWdWRITUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTlFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHTmhiR3h6ZFdJZ2FYTnpkV1ZmY0dGNWJXVnVkQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXlaV2RwYzNSbGNsOWhaMlZ1ZEY5eWIzVjBaVUEyT2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ1luUnZhUW9nSUNBZ1kyRnNiSE4xWWlCeVpXZHBjM1JsY2w5aFoyVnVkQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWliMjkwYzNSeVlYQmZjbTkxZEdWQU5Ub0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlYTWdRV05qYjNWdWRITUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRnpJRUZqWTI5MWJuUnpDaUFnSUNCallXeHNjM1ZpSUdKdmIzUnpkSEpoY0FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlpWVhKbFgzSnZkWFJwYm1kQU1UQTZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFeUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCamNtVmhkR2x1WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJRjl3ZFhsaFgyeHBZaTUxZEdsc0xtVnVjM1Z5WlY5aWRXUm5aWFFvY21WeGRXbHlaV1JmWW5Wa1oyVjBPaUIxYVc1ME5qUXNJR1psWlY5emIzVnlZMlU2SUhWcGJuUTJOQ2tnTFQ0Z2RtOXBaRG9LWlc1emRYSmxYMkoxWkdkbGREb0tJQ0FnSUhCeWIzUnZJRElnTUFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQndkWE5vYVc1MElERXdJQzh2SURFd0NpQWdJQ0FyQ2dwbGJuTjFjbVZmWW5Wa1oyVjBYM2RvYVd4bFgzUnZjRUF4T2dvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHZHNiMkpoYkNCUGNHTnZaR1ZDZFdSblpYUUtJQ0FnSUQ0S0lDQWdJR0o2SUdWdWMzVnlaVjlpZFdSblpYUmZZV1owWlhKZmQyaHBiR1ZBTndvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2NIVnphR2x1ZENBMklDOHZJR0Z3Y0d3S0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lIQjFjMmhwYm5RZ05TQXZMeUJFWld4bGRHVkJjSEJzYVdOaGRHbHZiZ29nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd3TmpneE1ERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndjbTkyWVd4UWNtOW5jbUZ0Q2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TURZNE1UQXhDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnNaV0Z5VTNSaGRHVlFjbTluY21GdENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSE4zYVhSamFDQmxibk4xY21WZlluVmtaMlYwWDNOM2FYUmphRjlqWVhObFh6QkFNeUJsYm5OMWNtVmZZblZrWjJWMFgzTjNhWFJqYUY5allYTmxYekZBTkFvS1pXNXpkWEpsWDJKMVpHZGxkRjl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRRFk2Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ1lpQmxibk4xY21WZlluVmtaMlYwWDNkb2FXeGxYM1J2Y0VBeENncGxibk4xY21WZlluVmtaMlYwWDNOM2FYUmphRjlqWVhObFh6RkFORG9LSUNBZ0lHZHNiMkpoYkNCTmFXNVVlRzVHWldVS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JpSUdWdWMzVnlaVjlpZFdSblpYUmZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQTJDZ3BsYm5OMWNtVmZZblZrWjJWMFgzTjNhWFJqYUY5allYTmxYekJBTXpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdZaUJsYm5OMWNtVmZZblZrWjJWMFgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU5nb0taVzV6ZFhKbFgySjFaR2RsZEY5aFpuUmxjbDkzYUdsc1pVQTNPZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtRnBYM0psWjJsemRISjVMbU52Ym5SeVlXTjBMa0ZwVW1WbmFYTjBjbmt1WW05dmRITjBjbUZ3S0d4emFXZGZZV1JrY21WemN6b2dZbmwwWlhNc0lHRmtiV2x1WDJGa1pISmxjM002SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3BpYjI5MGMzUnlZWEE2Q2lBZ0lDQndjbTkwYnlBeUlEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKc2MybG5YMkZrWkhJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXViSE5wWjE5aFpHUnlJR1Y0YVhOMGN3b2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFRnNjbVZoWkhrZ1ltOXZkSE4wY21Gd2NHVmtDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnNjMmxuWDJGa1pISWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmhaRzFwYmlJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVoYVY5eVpXZHBjM1J5ZVM1amIyNTBjbUZqZEM1QmFWSmxaMmx6ZEhKNUxuSmxaMmx6ZEdWeVgyRm5aVzUwS0dGblpXNTBYM0JmYTJWNU9pQmllWFJsY3l3Z2NHVnliV2x6YzJsdmJuTTZJSFZwYm5RMk5Dd2diV0Y0WDJGdGIzVnVkRG9nZFdsdWREWTBMQ0IyWVd4cFpGOTFiblJwYkY5eWIzVnVaRG9nZFdsdWREWTBLU0F0UGlCMmIybGtPZ3B5WldkcGMzUmxjbDloWjJWdWREb0tJQ0FnSUhCeWIzUnZJRFFnTUFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRmtiV2x1SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR0ZrYldsdUlHTmhiaUJ5WldkcGMzUmxjaUJoWjJWdWRITUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnYVhSdllnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjROakUzTUFvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVlXbGZjbVZuYVhOMGNua3VZMjl1ZEhKaFkzUXVRV2xTWldkcGMzUnllUzVmZG1WeWFXWjVYMkZuWlc1MFgzQmxjbTFwYzNOcGIyNXpLR0ZuWlc1MFgzQmZhMlY1T2lCaWVYUmxjeXdnYjNCbGNtRjBhVzl1WDJKcGREb2dkV2x1ZERZMExDQmhiVzkxYm5RNklIVnBiblEyTkN3Z1kzVnljbVZ1ZEY5eWIzVnVaRG9nZFdsdWREWTBLU0F0UGlCMmIybGtPZ3BmZG1WeWFXWjVYMkZuWlc1MFgzQmxjbTFwYzNOcGIyNXpPZ29nSUNBZ2NISnZkRzhnTkNBd0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWliSE5wWjE5aFpHUnlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG14emFXZGZZV1JrY2lCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0JNVTBsSElHTmhiaUJqWVd4c0lIUm9hWE1nYldWMGFHOWtDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjROakUzTUFvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1FXZGxiblFnYm05MElISmxaMmx6ZEdWeVpXUUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUZuWlc1MFgzQmxjbTFwYzNOcGIyNXpJR1Z1ZEhKNUlHVjRhWE4wY3dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNCa2FXY2dNUW9nSUNBZ1BqMEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0JrYVdjZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1JwWnlBeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaR2xuSURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHSjBiMmtLSUNBZ0lHbHVkR05mTXlBdkx5QXhOZ29nSUNBZ1pHbG5JRE1LSUNBZ0lENDlDaUFnSUNCcGJuUmpYek1nTHk4Z01UWUtJQ0FnSUdScFp5QTBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWkdsbklEUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdaR2xuSURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHSjBiMmtLSUNBZ0lIQjFjMmhwYm5RZ01qUWdMeThnTWpRS0lDQWdJR1JwWnlBMENpQWdJQ0ErUFFvZ0lDQWdjSFZ6YUdsdWRDQXlOQ0F2THlBeU5Bb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdZblJ2YVFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ1lYTnpaWEowSUM4dklFOXdaWEpoZEdsdmJpQnViM1FnWVd4c2IzZGxaQ0JtYjNJZ2RHaHBjeUJoWjJWdWRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z1FXMXZkVzUwSUdWNFkyVmxaSE1nWVdkbGJuUW5jeUJzYVcxcGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0ErUFFvZ0lDQWdZWE56WlhKMElDOHZJRUZuWlc1MElHRjFkR2h2Y21sNllYUnBiMjRnWlhod2FYSmxaQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtRnBYM0psWjJsemRISjVMbU52Ym5SeVlXTjBMa0ZwVW1WbmFYTjBjbmt1YVhOemRXVmZjR0Y1YldWdWRDaGhiVzkxYm5RNklIVnBiblEyTkN3Z2NtVmpaV2wyWlhJNklHSjVkR1Z6TENCaFoyVnVkRjl1WVcxbE9pQmllWFJsY3l3Z1lXZGxiblJmY0Y5clpYazZJR0o1ZEdWekxDQnphV2R1WVhSMWNtVTZJR0o1ZEdWektTQXRQaUIyYjJsa09ncHBjM04xWlY5d1lYbHRaVzUwT2dvZ0lDQWdjSEp2ZEc4Z05TQXdDaUFnSUNCd2RYTm9hVzUwSURFNU1EQWdMeThnTVRrd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR05oYkd4emRXSWdaVzV6ZFhKbFgySjFaR2RsZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURaak56WUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbm9nYVhOemRXVmZjR0Y1YldWdWRGOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnMll6YzJDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVzWVhOMFgzWmhiR2xrSUdWNGFYTjBjd29nSUNBZ2RIaHVJRVpwY25OMFZtRnNhV1FLSUNBZ0lEd0tJQ0FnSUdGemMyVnlkQW9LYVhOemRXVmZjR0Y1YldWdWRGOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFVLSUNBZ0lIUjRiaUJHYVhKemRGWmhiR2xrQ2lBZ0lDQmpZV3hzYzNWaUlGOTJaWEpwWm5sZllXZGxiblJmY0dWeWJXbHpjMmx2Ym5NS0lDQWdJR1p5WVcxbFgyUnBaeUF0TlFvZ0lDQWdhWFJ2WWdvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IwZUc0Z1JtbHljM1JXWVd4cFpBb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWldReU5UVXhPWFpsY21sbWVWOWlZWEpsQ2lBZ0lDQmhjM05sY25RZ0x5OGdTVzUyWVd4cFpDQnphV2R1WVhSMWNtVUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR1p5WVcxbFgyUnBaeUF0TlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdhVzUwWTE4eElDOHZJSEJoZVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZeUEwSUM4dklERXdNREF3TUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQjBlRzRnUm1seWMzUldZV3hwWkFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURaak56WUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWhhVjl5WldkcGMzUnllUzVqYjI1MGNtRmpkQzVCYVZKbFoybHpkSEo1TG1semMzVmxYMkY0Wm1WeUtISmxZMlZwZG1WeU9pQmllWFJsY3l3Z1lXMXZkVzUwT2lCMWFXNTBOalFzSUdGemMyVjBYMmxrT2lCMWFXNTBOalFzSUdGblpXNTBYM0JmYTJWNU9pQmllWFJsY3l3Z2MybG5ibUYwZFhKbE9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS2FYTnpkV1ZmWVhobVpYSTZDaUFnSUNCd2NtOTBieUExSURBS0lDQWdJSEIxYzJocGJuUWdNakF3TUNBdkx5QXlNREF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1kyRnNiSE4xWWlCbGJuTjFjbVZmWW5Wa1oyVjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRObU0zTmdvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWVpQnBjM04xWlY5aGVHWmxjbDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzJZemMyQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZEc5cENpQWdJQ0J6ZDJGd0NpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1c1lYTjBYM1poYkdsa0lHVjRhWE4wY3dvZ0lDQWdkSGh1SUVacGNuTjBWbUZzYVdRS0lDQWdJRHdLSUNBZ0lHRnpjMlZ5ZEFvS2FYTnpkV1ZmWVhobVpYSmZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQjBlRzRnUm1seWMzUldZV3hwWkFvZ0lDQWdZMkZzYkhOMVlpQmZkbVZ5YVdaNVgyRm5aVzUwWDNCbGNtMXBjM05wYjI1ekNpQWdJQ0JtY21GdFpWOWthV2NnTFRRS0lDQWdJR2wwYjJJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZEhodUlFWnBjbk4wVm1Gc2FXUUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdWa01qVTFNVGwyWlhKcFpubGZZbUZ5WlFvZ0lDQWdZWE56WlhKMElDOHZJRWx1ZG1Gc2FXUWdjMmxuYm1GMGRYSmxDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR2wwZUc1ZlptbGxiR1FnV0dabGNrRnpjMlYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSQmJXOTFiblFLSUNBZ0lHWnlZVzFsWDJScFp5QXROUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEZKbFkyVnBkbVZ5Q2lBZ0lDQndkWE5vYVc1MElEUWdMeThnWVhobVpYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lIUjRiaUJHYVhKemRGWmhiR2xrQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Tm1NM05nb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtRnBYM0psWjJsemRISjVMbU52Ym5SeVlXTjBMa0ZwVW1WbmFYTjBjbmt1YVhOemRXVmZiM0IwWDJsdUtHRnpjMlYwWDJsa09pQjFhVzUwTmpRc0lHRm5aVzUwWDNCZmEyVjVPaUJpZVhSbGN5d2djMmxuYm1GMGRYSmxPaUJpZVhSbGN5a2dMVDRnZG05cFpEb0thWE56ZFdWZmIzQjBYMmx1T2dvZ0lDQWdjSEp2ZEc4Z015QXdDaUFnSUNCd2RYTm9hVzUwSURJd01EQWdMeThnTWpBd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR05oYkd4emRXSWdaVzV6ZFhKbFgySjFaR2RsZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURaak56WUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbm9nYVhOemRXVmZiM0IwWDJsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURaak56WUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lITjNZWEFLSUNBZ0lHSjBiMmtLSUNBZ0lITjNZWEFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbXhoYzNSZmRtRnNhV1FnWlhocGMzUnpDaUFnSUNCMGVHNGdSbWx5YzNSV1lXeHBaQW9nSUNBZ1BBb2dJQ0FnWVhOelpYSjBDZ3BwYzNOMVpWOXZjSFJmYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQndkWE5vYVc1MElESWdMeThnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIUjRiaUJHYVhKemRGWmhiR2xrQ2lBZ0lDQmpZV3hzYzNWaUlGOTJaWEpwWm5sZllXZGxiblJmY0dWeWJXbHpjMmx2Ym5NS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdhWFJ2WWdvZ0lDQWdkSGh1SUVacGNuTjBWbUZzYVdRS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1ZrTWpVMU1UbDJaWEpwWm5sZlltRnlaUW9nSUNBZ1lYTnpaWEowSUM4dklFbHVkbUZzYVdRZ2MybG5ibUYwZFhKbENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRmhtWlhKQmMzTmxkQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJTWldObGFYWmxjZ29nSUNBZ2NIVnphR2x1ZENBMElDOHZJR0Y0Wm1WeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqSURRZ0x5OGdNVEF3TURBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJSFI0YmlCR2FYSnpkRlpoYkdsa0NpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE5tTTNOZ29nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRkFBRUlFS0NOQmlZRkFteDJDV3h6YVdkZllXUmtjZ1ZoWkcxcGJnTUdnUUVDWVhBeEdFQUFDQ2t5QTJjcU1nTm5NUnRCQU15Q0JRVFhYQVRtQkNlcGpmY0VVbk0wYVFRcnp3VDRCQkVKaDRnMkdnQ09CUUNLQUd3QVJBQWVBQUlpUXpFWkZFUXhHRVEyR2dFWE5ob0NWd0lBTmhvRFZ3SUFpQUlHSTBNeEdSUkVNUmhFTmhvQkY4QWNOaG9DRnpZYUF4YzJHZ1JYQWdBMkdnVlhBZ0NJQVlvalF6RVpGRVF4R0VRMkdnRVhOaG9DRjhBY05ob0RWd0lBTmhvRVZ3SUFOaG9GVndJQWlBRVNJME14R1JSRU1SaEVOaG9CVndJQU5ob0NGellhQXhjMkdnUVhpQUJ5STBNeEdSUkVNUmhFTmhvQkY4QWNOaG9DRjhBY2lBQkdJME14R1VEL1dURVlGRVFqUTRvQ0FJditnUW9JaXdBeURBMUJBQ2l4Z1FheUVJRUZzaGtyc2g0cnNoK0wvNDBDQUFzQUJMTkMvOTB5QUxJQlF2LzFJcklCUXYvdmlZb0NBQ0lwWlVReUF4SkVLWXYrWnlxTC8yZUppZ1FBTVFBaUttVkVFa1NML1JhTC9oWlFpLzhXVUNjRWkveFFTYnhJVEwrSmlnUUFNUUFpS1dWRUVrUW5CSXY4VUVtOVJRRkV2a1JKRlNSTEFROGtTd0pQQWsxTEFpSkxBbElYSlVzRER5VkxCRThDVFVzRVR3TkxBbElYZ1JoTEJBK0JHRThGVHdKTlR3UlBBMDhDVWhkUEFvdjlVMFNML2s4Q0RrU0wvdzlFaVlvRkFJSHNEaUtJL3ljb3ZVVUJRUUFLS0w1TUYweEVNUUlNUkl2K0lvdjdNUUtJLzNxTCt4YUwvRkNML1ZBeEFoWlFpLytML29SRXNZdjdzZ2lML0xJSEk3SVFJUVN5QWJNeEFoWW9UTCtKaWdVQWdkQVBJb2orMXlpOVJRRkJBQW9vdmt3WFRFUXhBZ3hFaS80amkvd3hBb2ovS292OEZvdjdURkNML1JaUU1RSVdVSXYvaS82RVJMR0wvYklSaS95eUVvdjdzaFNCQkxJUUlySUJzekVDRmloTXY0bUtBd0NCMEE4aWlQNkJLTDFGQVVFQUNpaStUQmRNUkRFQ0RFU0wvb0VDSWpFQ2lQN1VpLzBXTVFJV1VJdi9pLzZFUkxFeUNvdjlzaEVpc2hLeUZJRUVzaEFoQkxJQnN6RUNGaWhNdjRrPSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjYsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
