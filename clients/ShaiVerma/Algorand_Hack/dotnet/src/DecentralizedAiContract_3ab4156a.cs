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

namespace Arc56.Generated.ShaiVerma.Algorand_Hack.DecentralizedAiContract_3ab4156a
{


    public class DecentralizedAiContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public DecentralizedAiContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="token_id"> </param>
        /// <param name="fee"> </param>
        public async Task Create(ulong token_id, ulong fee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { token_id });
            byte token_idRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 110, 178, 96, 179 };
            var token_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); token_idAbi.From(token_id);
            var feeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); feeAbi.From(fee);

            var result = await base.CallApp(new List<object> { abiHandle, token_idRefIndex, feeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(ulong token_id, ulong fee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { token_id });
            byte token_idRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 110, 178, 96, 179 };
            var token_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); token_idAbi.From(token_id);
            var feeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); feeAbi.From(fee);

            return await base.MakeTransactionList(new List<object> { abiHandle, token_idRefIndex, feeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="new_governor"> </param>
        public async Task SetGovernor(Address new_governor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { new_governor });
            byte new_governorRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 8, 169, 86, 247 };
            var new_governorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_governorAbi.From(new_governor);

            var result = await base.CallApp(new List<object> { abiHandle, new_governorRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetGovernor_Transactions(Address new_governor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { new_governor });
            byte new_governorRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 8, 169, 86, 247 };
            var new_governorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_governorAbi.From(new_governor);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_governorRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="new_fee"> </param>
        public async Task SetFee(ulong new_fee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 252, 75, 136, 183 };
            var new_feeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_feeAbi.From(new_fee);

            var result = await base.CallApp(new List<object> { abiHandle, new_feeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetFee_Transactions(ulong new_fee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 252, 75, 136, 183 };
            var new_feeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_feeAbi.From(new_fee);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_feeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Opts the contract into the DAISY ASA token.
        ///Required before the contract can receive/transfer DAISY.
        ///</summary>
        public async Task OptInToToken(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 47, 46, 56 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptInToToken_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 47, 46, 56 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="amount"> </param>
        public async Task WithdrawAsset(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 16, 80, 180, 80 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> WithdrawAsset_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 16, 80, 180, 80 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="query_text"> </param>
        /// <param name="payment"> </param>
        public async Task<ulong> PostQuery(AssetTransferTransaction payment, string query_text, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 207, 91, 217, 197 };
            var query_textAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); query_textAbi.From(query_text);

            var result = await base.CallApp(new List<object> { abiHandle, query_textAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> PostQuery_Transactions(AssetTransferTransaction payment, string query_text, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 207, 91, 217, 197 };
            var query_textAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); query_textAbi.From(query_text);

            return await base.MakeTransactionList(new List<object> { abiHandle, query_textAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="query_id"> </param>
        /// <param name="response_ref"> </param>
        public async Task SubmitResponse(ulong query_id, string response_ref, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 60, 48, 96, 91 };
            var query_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); query_idAbi.From(query_id);
            var response_refAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); response_refAbi.From(response_ref);

            var result = await base.CallApp(new List<object> { abiHandle, query_idAbi, response_refAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SubmitResponse_Transactions(ulong query_id, string response_ref, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 60, 48, 96, 91 };
            var query_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); query_idAbi.From(query_id);
            var response_refAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); response_refAbi.From(response_ref);

            return await base.MakeTransactionList(new List<object> { abiHandle, query_idAbi, response_refAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="query_id"> </param>
        public async Task<string> ReadPrompt(ulong query_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 93, 69, 99 };
            var query_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); query_idAbi.From(query_id);

            var result = await base.SimApp(new List<object> { abiHandle, query_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> ReadPrompt_Transactions(ulong query_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 93, 69, 99 };
            var query_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); query_idAbi.From(query_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, query_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRGVjZW50cmFsaXplZEFpQ29udHJhY3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFzc2V0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5faWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZlZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfZ292ZXJub3IiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19nb3Zlcm5vciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfZmVlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19mZWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3B0X2luX3RvX3Rva2VuIiwiZGVzYyI6Ik9wdHMgdGhlIGNvbnRyYWN0IGludG8gdGhlIERBSVNZIEFTQSB0b2tlbi5cblJlcXVpcmVkIGJlZm9yZSB0aGUgY29udHJhY3QgY2FuIHJlY2VpdmUvdHJhbnNmZXIgREFJU1kuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IndpdGhkcmF3X2Fzc2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwb3N0X3F1ZXJ5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InF1ZXJ5X3RleHQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImF4ZmVyIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InN1Ym1pdF9yZXNwb25zZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJxdWVyeV9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVzcG9uc2VfcmVmIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlYWRfcHJvbXB0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InF1ZXJ5X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MywiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE0NSwxNjYsMTg1LDIxNiwyMzIsMjQ0LDI2MCwyNzhdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMjddLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGdvdmVybm9yIGNhbiBjaGFuZ2UgZ292ZXJub3IiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNTZdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGdvdmVybm9yIGNhbiBvcHQtaW4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDNdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGdvdmVybm9yIGNhbiBzZXQgZmVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzkyXSwiZXJyb3JNZXNzYWdlIjoiT25seSBnb3Zlcm5vciBjYW4gd2l0aGRyYXciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NTNdLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IG11c3QgYmUgZnJvbSBjYWxsZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MzVdLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IG11c3QgZ28gdG8gY29udHJhY3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NDVdLCJlcnJvck1lc3NhZ2UiOiJXcm9uZyBmZWUgYW1vdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDI3XSwiZXJyb3JNZXNzYWdlIjoiV3JvbmcgdG9rZW4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODJdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDgsMTY5LDE4OCwyMTksMjM1LDI0NywyNjNdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzI1LDM0MSwzNTQsMzg3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5nb3Zlcm5vciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NTddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm5leHRfcXVlcnlfaWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDkxLDUzMF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYucXVlcmllcyBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NDMsNTAwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5xdWVyeV9mZWUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzYxLDM5Nyw0MjUsNDk2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b2tlbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDFdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIGF4ZmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJqYjI1MGNtRmpkRjh5TGtSbFkyVnVkSEpoYkdsNlpXUkJhVU52Ym5SeVlXTjBMbDlmWVd4bmIzQjVYMlZ1ZEhKNWNHOXBiblJmZDJsMGFGOXBibWwwS0NrZ0xUNGdkV2x1ZERZME9ncHRZV2x1T2dvZ0lDQWdhVzUwWTJKc2IyTnJJREFnTVNBMENpQWdJQ0JpZVhSbFkySnNiMk5ySUNKbmIzWmxjbTV2Y2lJZ0luUnZhMlZ1SWlBaWNYVmxjbmxmWm1WbElpQWlibVY0ZEY5eGRXVnllVjlwWkNJZ0lsRWlJREI0TVRVeFpqZGpOelVLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklHTnZiblJ5WVdOMFh6SXVjSGs2TVRZS0lDQWdJQzh2SUhObGJHWXVaMjkyWlhKdWIzSWdQU0JCWTJOdmRXNTBLQ2tnSUNBZ0lDQWdJQ0FnSUNBZ0lDTWdZMjl1ZEhKaFkzUWdaMjkyWlhKdWIzSWdLRzFoYm1GblpYTWdZMjl1Wm1sbklDc2diM0IwTFdsdUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVoyOTJaWEp1YjNJaUNpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkRjh5TG5CNU9qRTNDaUFnSUNBdkx5QnpaV3htTG5SdmEyVnVJRDBnUVhOelpYUW9NQ2tnSUNBZ0lDQWdJQ0FnSUNBZ0lDQWdJQ0FqSUVGVFFTQjFjMlZrSUdadmNpQndZWGx0Wlc1MGN5QW9SRUZKVTFrZ2RHOXJaVzRwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0owYjJ0bGJpSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSZk1pNXdlVG94T0FvZ0lDQWdMeThnYzJWc1ppNXhkV1Z5ZVY5bVpXVWdQU0JWU1c1ME5qUW9NQ2tnSUNBZ0lDQWdJQ0FnSUNBZ0l5Qm1aV1VnY21WeGRXbHlaV1FnZEc4Z2NHOXpkQ0JoSUhGMVpYSjVDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnhkV1Z5ZVY5bVpXVWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMFh6SXVjSGs2TVRrS0lDQWdJQzh2SUhObGJHWXVibVY0ZEY5eGRXVnllVjlwWkNBOUlGVkpiblEyTkNneEtTQWdJQ0FnSUNBZ0lDTWdhVzVqY21WdFpXNTBZV3dnY1hWbGNua2dZMjkxYm5SbGNnb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWJtVjRkRjl4ZFdWeWVWOXBaQ0lLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCamIyNTBjbUZqZEY4eUxuQjVPakUwQ2lBZ0lDQXZMeUJqYkdGemN5QkVaV05sYm5SeVlXeHBlbVZrUVdsRGIyNTBjbUZqZENoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TXdvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURabFlqSTJNR0l6SURCNE1EaGhPVFUyWmpjZ01IaG1ZelJpT0RoaU55QXdlRE5sTW1ZeVpUTTRJREI0TVRBMU1HSTBOVEFnTUhoalpqVmlaRGxqTlNBd2VETmpNekEyTURWaUlEQjRNakUxWkRRMU5qTWdMeThnYldWMGFHOWtJQ0pqY21WaGRHVW9ZWE56WlhRc2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbk5sZEY5bmIzWmxjbTV2Y2loaFkyTnZkVzUwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbk5sZEY5bVpXVW9kV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW05d2RGOXBibDkwYjE5MGIydGxiaWdwZG05cFpDSXNJRzFsZEdodlpDQWlkMmwwYUdSeVlYZGZZWE56WlhRb2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbkJ2YzNSZmNYVmxjbmtvYzNSeWFXNW5MR0Y0Wm1WeUtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaWMzVmliV2wwWDNKbGMzQnZibk5sS0hWcGJuUTJOQ3h6ZEhKcGJtY3BkbTlwWkNJc0lHMWxkR2h2WkNBaWNtVmhaRjl3Y205dGNIUW9kV2x1ZERZMEtYTjBjbWx1WnlJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmWTNKbFlYUmxYM0p2ZFhSbFFEVWdiV0ZwYmw5elpYUmZaMjkyWlhKdWIzSmZjbTkxZEdWQU5pQnRZV2x1WDNObGRGOW1aV1ZmY205MWRHVkFOeUJ0WVdsdVgyOXdkRjlwYmw5MGIxOTBiMnRsYmw5eWIzVjBaVUE0SUcxaGFXNWZkMmwwYUdSeVlYZGZZWE56WlhSZmNtOTFkR1ZBT1NCdFlXbHVYM0J2YzNSZmNYVmxjbmxmY205MWRHVkFNVEFnYldGcGJsOXpkV0p0YVhSZmNtVnpjRzl1YzJWZmNtOTFkR1ZBTVRFZ2JXRnBibDl5WldGa1gzQnliMjF3ZEY5eWIzVjBaVUF4TWdvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERXpPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUmZNaTV3ZVRveE5Bb2dJQ0FnTHk4Z1kyeGhjM01nUkdWalpXNTBjbUZzYVhwbFpFRnBRMjl1ZEhKaFkzUW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmY21WaFpGOXdjbTl0Y0hSZmNtOTFkR1ZBTVRJNkNpQWdJQ0F2THlCamIyNTBjbUZqZEY4eUxuQjVPakV3TnkweE1EZ0tJQ0FnSUM4dklDTWdVbVZoWkMxdmJteDVJRzFsZEdodlpEb2djbVYwZFhKdWN5QjBhR1VnY0hKdmJYQjBJR1p2Y2lCaElHZHBkbVZ1SUhGMVpYSjVJR2xrSUNobWIzSWdjSEp2ZG1sa1pYSnpJSFJ2SUdabGRHTm9LUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJR052Ym5SeVlXTjBYekl1Y0hrNk1UUUtJQ0FnSUM4dklHTnNZWE56SUVSbFkyVnVkSEpoYkdsNlpXUkJhVU52Ym5SeVlXTjBLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCamIyNTBjbUZqZEY4eUxuQjVPakV3TnkweE1EZ0tJQ0FnSUM4dklDTWdVbVZoWkMxdmJteDVJRzFsZEdodlpEb2djbVYwZFhKdWN5QjBhR1VnY0hKdmJYQjBJR1p2Y2lCaElHZHBkbVZ1SUhGMVpYSjVJR2xrSUNobWIzSWdjSEp2ZG1sa1pYSnpJSFJ2SUdabGRHTm9LUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmpZV3hzYzNWaUlISmxZV1JmY0hKdmJYQjBDaUFnSUNCaWVYUmxZeUExSUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzTjFZbTFwZEY5eVpYTndiMjV6WlY5eWIzVjBaVUF4TVRvS0lDQWdJQzh2SUdOdmJuUnlZV04wWHpJdWNIazZPRGN0T0RrS0lDQWdJQzh2SUNNZ1VISnZkbWxrWlhJZ2MzVmliV2wwY3lCaElISmxjM0J2Ym5ObElHRnVaQ0JuWlhSeklISmxkMkZ5WkdWa0lHbHVJRVJCU1ZOWkNpQWdJQ0F2THlBaklGSmxZV1J6SUNobmRXRnlaSE1nYjI0cElIUm9aU0J3Y205dGNIUWdZbTk0SUdGdVpDQmtaV3hsZEdWeklHbDBJR2x0YldWa2FXRjBaV3g1SUhSdklISmxZMnhoYVcwZ1RVSlNDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnWTI5dWRISmhZM1JmTWk1d2VUb3hOQW9nSUNBZ0x5OGdZMnhoYzNNZ1JHVmpaVzUwY21Gc2FYcGxaRUZwUTI5dWRISmhZM1FvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUM4dklHTnZiblJ5WVdOMFh6SXVjSGs2T0RjdE9Ea0tJQ0FnSUM4dklDTWdVSEp2ZG1sa1pYSWdjM1ZpYldsMGN5QmhJSEpsYzNCdmJuTmxJR0Z1WkNCblpYUnpJSEpsZDJGeVpHVmtJR2x1SUVSQlNWTlpDaUFnSUNBdkx5QWpJRkpsWVdSeklDaG5kV0Z5WkhNZ2IyNHBJSFJvWlNCd2NtOXRjSFFnWW05NElHRnVaQ0JrWld4bGRHVnpJR2wwSUdsdGJXVmthV0YwWld4NUlIUnZJSEpsWTJ4aGFXMGdUVUpTQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdOaGJHeHpkV0lnYzNWaWJXbDBYM0psYzNCdmJuTmxDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzQnZjM1JmY1hWbGNubGZjbTkxZEdWQU1UQTZDaUFnSUNBdkx5QmpiMjUwY21GamRGOHlMbkI1T2pZNUxUY3hDaUFnSUNBdkx5QWpJRlZ6WlhJZ2NHOXpkSE1nWVNCeGRXVnllU0IzYVhSb0lHRWdSRUZKVTFrZ2RHOXJaVzRnY0dGNWJXVnVkQW9nSUNBZ0x5OGdJeUJUZEc5eVpYTWdkR2hsSUhCeWIyMXdkQ0JwYmlCaElIQmxjaTF4ZFdWeWVTQmliM2c3SUhSb2FYTWdZbTk0SUdseklHUmxiR1YwWldRZ2RYQnZiaUJ5WlhOd2IyNXpaUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUdOdmJuUnlZV04wWHpJdWNIazZNVFFLSUNBZ0lDOHZJR05zWVhOeklFUmxZMlZ1ZEhKaGJHbDZaV1JCYVVOdmJuUnlZV04wS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1pQXZMeUJoZUdabGNnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUdGNFptVnlDaUFnSUNBdkx5QmpiMjUwY21GamRGOHlMbkI1T2pZNUxUY3hDaUFnSUNBdkx5QWpJRlZ6WlhJZ2NHOXpkSE1nWVNCeGRXVnllU0IzYVhSb0lHRWdSRUZKVTFrZ2RHOXJaVzRnY0dGNWJXVnVkQW9nSUNBZ0x5OGdJeUJUZEc5eVpYTWdkR2hsSUhCeWIyMXdkQ0JwYmlCaElIQmxjaTF4ZFdWeWVTQmliM2c3SUhSb2FYTWdZbTk0SUdseklHUmxiR1YwWldRZ2RYQnZiaUJ5WlhOd2IyNXpaUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JqWVd4c2MzVmlJSEJ2YzNSZmNYVmxjbmtLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkMmwwYUdSeVlYZGZZWE56WlhSZmNtOTFkR1ZBT1RvS0lDQWdJQzh2SUdOdmJuUnlZV04wWHpJdWNIazZOVGd0TlRrS0lDQWdJQzh2SUNNZ1IyOTJaWEp1YjNJZ1kyRnVJSGRwZEdoa2NtRjNJRVJCU1ZOWklIUnZhMlZ1Y3lCbWNtOXRJR052Ym5SeVlXTjBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnWTI5dWRISmhZM1JmTWk1d2VUb3hOQW9nSUNBZ0x5OGdZMnhoYzNNZ1JHVmpaVzUwY21Gc2FYcGxaRUZwUTI5dWRISmhZM1FvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklHTnZiblJ5WVdOMFh6SXVjSGs2TlRndE5Ua0tJQ0FnSUM4dklDTWdSMjkyWlhKdWIzSWdZMkZ1SUhkcGRHaGtjbUYzSUVSQlNWTlpJSFJ2YTJWdWN5Qm1jbTl0SUdOdmJuUnlZV04wQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdOaGJHeHpkV0lnZDJsMGFHUnlZWGRmWVhOelpYUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmIzQjBYMmx1WDNSdlgzUnZhMlZ1WDNKdmRYUmxRRGc2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkRjh5TG5CNU9qUTBMVFExQ2lBZ0lDQXZMeUFqSUVkdmRtVnlibTl5SUc5d2RITWdkR2hsSUdOdmJuUnlZV04wSUdsdWRHOGdkR2hsSUVSQlNWTlpJSFJ2YTJWdUlFRlRRUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJR05oYkd4emRXSWdiM0IwWDJsdVgzUnZYM1J2YTJWdUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNObGRGOW1aV1ZmY205MWRHVkFOem9LSUNBZ0lDOHZJR052Ym5SeVlXTjBYekl1Y0hrNk16Z3RNemtLSUNBZ0lDOHZJQ01nUjI5MlpYSnViM0lnWTJGdUlHTm9ZVzVuWlNCbVpXVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkRjh5TG5CNU9qRTBDaUFnSUNBdkx5QmpiR0Z6Y3lCRVpXTmxiblJ5WVd4cGVtVmtRV2xEYjI1MGNtRmpkQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSZk1pNXdlVG96T0Mwek9Rb2dJQ0FnTHk4Z0l5QkhiM1psY201dmNpQmpZVzRnWTJoaGJtZGxJR1psWlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCallXeHNjM1ZpSUhObGRGOW1aV1VLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZjMlYwWDJkdmRtVnlibTl5WDNKdmRYUmxRRFk2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkRjh5TG5CNU9qTXlMVE16Q2lBZ0lDQXZMeUFqSUVkdmRtVnlibTl5SUdOaGJpQmphR0Z1WjJVZ1oyOTJaWEp1YjNJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QmpiMjUwY21GamRGOHlMbkI1T2pFMENpQWdJQ0F2THlCamJHRnpjeUJFWldObGJuUnlZV3hwZW1Wa1FXbERiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVhNZ1FXTmpiM1Z1ZEhNS0lDQWdJQzh2SUdOdmJuUnlZV04wWHpJdWNIazZNekl0TXpNS0lDQWdJQzh2SUNNZ1IyOTJaWEp1YjNJZ1kyRnVJR05vWVc1blpTQm5iM1psY201dmNnb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQmpZV3hzYzNWaUlITmxkRjluYjNabGNtNXZjZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWpjbVZoZEdWZmNtOTFkR1ZBTlRvS0lDQWdJQzh2SUdOdmJuUnlZV04wWHpJdWNIazZNalF0TWpVS0lDQWdJQzh2SUNNZ1NXNXBkR2xoYkdsNlpTQmpiMjUwY21GamRDQjNhWFJvSUVSQlNWTlpJSFJ2YTJWdUlFRlRRU0JKUkNBcklIQnZjM1JwYm1jZ1ptVmxDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb1kzSmxZWFJsUFNKeVpYRjFhWEpsSWlrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHTnlaV0YwYVc1bkNpQWdJQ0F2THlCamIyNTBjbUZqZEY4eUxuQjVPakUwQ2lBZ0lDQXZMeUJqYkdGemN5QkVaV05sYm5SeVlXeHBlbVZrUVdsRGIyNTBjbUZqZENoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZWE1nUVhOelpYUnpDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QmpiMjUwY21GamRGOHlMbkI1T2pJMExUSTFDaUFnSUNBdkx5QWpJRWx1YVhScFlXeHBlbVVnWTI5dWRISmhZM1FnZDJsMGFDQkVRVWxUV1NCMGIydGxiaUJCVTBFZ1NVUWdLeUJ3YjNOMGFXNW5JR1psWlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLR055WldGMFpUMGljbVZ4ZFdseVpTSXBDaUFnSUNCallXeHNjM1ZpSUdOeVpXRjBaUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTnZiblJ5WVdOMFh6SXVSR1ZqWlc1MGNtRnNhWHBsWkVGcFEyOXVkSEpoWTNRdVkzSmxZWFJsS0hSdmEyVnVYMmxrT2lCMWFXNTBOalFzSUdabFpUb2dkV2x1ZERZMEtTQXRQaUIyYjJsa09ncGpjbVZoZEdVNkNpQWdJQ0F2THlCamIyNTBjbUZqZEY4eUxuQjVPakkwTFRJMkNpQWdJQ0F2THlBaklFbHVhWFJwWVd4cGVtVWdZMjl1ZEhKaFkzUWdkMmwwYUNCRVFVbFRXU0IwYjJ0bGJpQkJVMEVnU1VRZ0t5QndiM04wYVc1bklHWmxaUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tHTnlaV0YwWlQwaWNtVnhkV2x5WlNJcENpQWdJQ0F2THlCa1pXWWdZM0psWVhSbEtITmxiR1lzSUhSdmEyVnVYMmxrT2lCQmMzTmxkQ3dnWm1WbE9pQlZTVzUwTmpRcElDMCtJRTV2Ym1VNkNpQWdJQ0J3Y205MGJ5QXlJREFLSUNBZ0lDOHZJR052Ym5SeVlXTjBYekl1Y0hrNk1qY0tJQ0FnSUM4dklITmxiR1l1WjI5MlpYSnViM0lnUFNCVWVHNHVjMlZ1WkdWeUNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKbmIzWmxjbTV2Y2lJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkRjh5TG5CNU9qSTRDaUFnSUNBdkx5QnpaV3htTG5SdmEyVnVJRDBnZEc5clpXNWZhV1FLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblJ2YTJWdUlnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSZk1pNXdlVG95T1FvZ0lDQWdMeThnYzJWc1ppNXhkV1Z5ZVY5bVpXVWdQU0JtWldVS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5GMVpYSjVYMlpsWlNJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUdOdmJuUnlZV04wWHpJdWNIazZNekFLSUNBZ0lDOHZJSE5sYkdZdWJtVjRkRjl4ZFdWeWVWOXBaQ0E5SUZWSmJuUTJOQ2d4S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpYm1WNGRGOXhkV1Z5ZVY5cFpDSUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z1kyOXVkSEpoWTNSZk1pNUVaV05sYm5SeVlXeHBlbVZrUVdsRGIyNTBjbUZqZEM1elpYUmZaMjkyWlhKdWIzSW9ibVYzWDJkdmRtVnlibTl5T2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LYzJWMFgyZHZkbVZ5Ym05eU9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSZk1pNXdlVG96TWkwek5Bb2dJQ0FnTHk4Z0l5QkhiM1psY201dmNpQmpZVzRnWTJoaGJtZGxJR2R2ZG1WeWJtOXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJQzh2SUdSbFppQnpaWFJmWjI5MlpYSnViM0lvYzJWc1ppd2dibVYzWDJkdmRtVnlibTl5T2lCQlkyTnZkVzUwS1NBdFBpQk9iMjVsT2dvZ0lDQWdjSEp2ZEc4Z01TQXdDaUFnSUNBdkx5QmpiMjUwY21GamRGOHlMbkI1T2pNMUNpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQnpaV3htTG1kdmRtVnlibTl5TENBaVQyNXNlU0JuYjNabGNtNXZjaUJqWVc0Z1kyaGhibWRsSUdkdmRtVnlibTl5SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltZHZkbVZ5Ym05eUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbWR2ZG1WeWJtOXlJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHZHZkbVZ5Ym05eUlHTmhiaUJqYUdGdVoyVWdaMjkyWlhKdWIzSUtJQ0FnSUM4dklHTnZiblJ5WVdOMFh6SXVjSGs2TXpZS0lDQWdJQzh2SUhObGJHWXVaMjkyWlhKdWIzSWdQU0J1WlhkZloyOTJaWEp1YjNJS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1kdmRtVnlibTl5SWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnWTI5dWRISmhZM1JmTWk1RVpXTmxiblJ5WVd4cGVtVmtRV2xEYjI1MGNtRmpkQzV6WlhSZlptVmxLRzVsZDE5bVpXVTZJSFZwYm5RMk5Da2dMVDRnZG05cFpEb0tjMlYwWDJabFpUb0tJQ0FnSUM4dklHTnZiblJ5WVdOMFh6SXVjSGs2TXpndE5EQUtJQ0FnSUM4dklDTWdSMjkyWlhKdWIzSWdZMkZ1SUdOb1lXNW5aU0JtWldVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ0x5OGdaR1ZtSUhObGRGOW1aV1VvYzJWc1ppd2dibVYzWDJabFpUb2dWVWx1ZERZMEtTQXRQaUJPYjI1bE9nb2dJQ0FnY0hKdmRHOGdNU0F3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkRjh5TG5CNU9qUXhDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0J6Wld4bUxtZHZkbVZ5Ym05eUxDQWlUMjVzZVNCbmIzWmxjbTV2Y2lCallXNGdjMlYwSUdabFpTSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0puYjNabGNtNXZjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1bmIzWmxjbTV2Y2lCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0JuYjNabGNtNXZjaUJqWVc0Z2MyVjBJR1psWlFvZ0lDQWdMeThnWTI5dWRISmhZM1JmTWk1d2VUbzBNZ29nSUNBZ0x5OGdjMlZzWmk1eGRXVnllVjltWldVZ1BTQnVaWGRmWm1WbENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKeGRXVnllVjltWldVaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0J5WlhSemRXSUtDZ292THlCamIyNTBjbUZqZEY4eUxrUmxZMlZ1ZEhKaGJHbDZaV1JCYVVOdmJuUnlZV04wTG05d2RGOXBibDkwYjE5MGIydGxiaWdwSUMwK0lIWnZhV1E2Q205d2RGOXBibDkwYjE5MGIydGxiam9LSUNBZ0lDOHZJR052Ym5SeVlXTjBYekl1Y0hrNk5URUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdVoyOTJaWEp1YjNJc0lDSlBibXg1SUdkdmRtVnlibTl5SUdOaGJpQnZjSFF0YVc0aUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlaMjkyWlhKdWIzSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WjI5MlpYSnViM0lnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2daMjkyWlhKdWIzSWdZMkZ1SUc5d2RDMXBiZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUmZNaTV3ZVRvMU1pMDFOZ29nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSmZZWE56WlhROWMyVnNaaTUwYjJ0bGJpd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOWhiVzkxYm5ROVZVbHVkRFkwS0RBcExDQWdJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0l5QnZjSFF0YVc0Z2NtVnhkV2x5WlhNZ01DQjBjbUZ1YzJabGNnb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgzSmxZMlZwZG1WeVBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkRjh5TG5CNU9qVXpDaUFnSUNBdkx5QjRabVZ5WDJGemMyVjBQWE5sYkdZdWRHOXJaVzRzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlkRzlyWlc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkRzlyWlc0Z1pYaHBjM1J6Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkRjh5TG5CNU9qVTFDaUFnSUNBdkx5QmhjM05sZEY5eVpXTmxhWFpsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUlNaV05sYVhabGNnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSZk1pNXdlVG8xTkFvZ0lDQWdMeThnWVhOelpYUmZZVzF2ZFc1MFBWVkpiblEyTkNnd0tTd2dJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0lDTWdiM0IwTFdsdUlISmxjWFZwY21WeklEQWdkSEpoYm5ObVpYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUZobVpYSkJjM05sZEFvZ0lDQWdMeThnWTI5dWRISmhZM1JmTWk1d2VUbzFNZ29nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ2FXNTBZMTh5SUM4dklHRjRabVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklHTnZiblJ5WVdOMFh6SXVjSGs2TlRJdE5UWUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVgyRnpjMlYwUFhObGJHWXVkRzlyWlc0c0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZllXMXZkVzUwUFZWSmJuUTJOQ2d3S1N3Z0lDQWdJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0lDQWdJQ0FnSUNNZ2IzQjBMV2x1SUhKbGNYVnBjbVZ6SURBZ2RISmhibk5tWlhJS0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJR052Ym5SeVlXTjBYekl1UkdWalpXNTBjbUZzYVhwbFpFRnBRMjl1ZEhKaFkzUXVkMmwwYUdSeVlYZGZZWE56WlhRb1lXMXZkVzUwT2lCMWFXNTBOalFwSUMwK0lIWnZhV1E2Q25kcGRHaGtjbUYzWDJGemMyVjBPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUmZNaTV3ZVRvMU9DMDJNQW9nSUNBZ0x5OGdJeUJIYjNabGNtNXZjaUJqWVc0Z2QybDBhR1J5WVhjZ1JFRkpVMWtnZEc5clpXNXpJR1p5YjIwZ1kyOXVkSEpoWTNRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ0x5OGdaR1ZtSUhkcGRHaGtjbUYzWDJGemMyVjBLSE5sYkdZc0lHRnRiM1Z1ZERvZ1ZVbHVkRFkwS1NBdFBpQk9iMjVsT2dvZ0lDQWdjSEp2ZEc4Z01TQXdDaUFnSUNBdkx5QmpiMjUwY21GamRGOHlMbkI1T2pZeENpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQnpaV3htTG1kdmRtVnlibTl5TENBaVQyNXNlU0JuYjNabGNtNXZjaUJqWVc0Z2QybDBhR1J5WVhjaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlaMjkyWlhKdWIzSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WjI5MlpYSnViM0lnWlhocGMzUnpDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR2R2ZG1WeWJtOXlJR05oYmlCM2FYUm9aSEpoZHdvZ0lDQWdMeThnWTI5dWRISmhZM1JmTWk1d2VUbzJNaTAyTndvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdMeThnSUNBZ0lIaG1aWEpmWVhOelpYUTljMlZzWmk1MGIydGxiaXdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjloYlc5MWJuUTlZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgzSmxZMlZwZG1WeVBYTmxiR1l1WjI5MlpYSnViM0lzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVEFzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QmpiMjUwY21GamRGOHlMbkI1T2pZekNpQWdJQ0F2THlCNFptVnlYMkZ6YzJWMFBYTmxiR1l1ZEc5clpXNHNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWRHOXJaVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOXJaVzRnWlhocGMzUnpDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwVW1WalpXbDJaWElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQllabVZ5UVhOelpYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMFh6SXVjSGs2TmpJS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJR2x1ZEdOZk1pQXZMeUJoZUdabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnWTI5dWRISmhZM1JmTWk1d2VUbzJOZ29nSUNBZ0x5OGdabVZsUFRBc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUdOdmJuUnlZV04wWHpJdWNIazZOakl0TmpjS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJQzh2SUNBZ0lDQjRabVZ5WDJGemMyVjBQWE5sYkdZdWRHOXJaVzRzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmWVcxdmRXNTBQV0Z0YjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXlaV05sYVhabGNqMXpaV3htTG1kdmRtVnlibTl5TEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDB3TEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJR052Ym5SeVlXTjBYekl1UkdWalpXNTBjbUZzYVhwbFpFRnBRMjl1ZEhKaFkzUXVjRzl6ZEY5eGRXVnllU2h4ZFdWeWVWOTBaWGgwT2lCaWVYUmxjeXdnY0dGNWJXVnVkRG9nZFdsdWREWTBLU0F0UGlCMWFXNTBOalE2Q25CdmMzUmZjWFZsY25rNkNpQWdJQ0F2THlCamIyNTBjbUZqZEY4eUxuQjVPalk1TFRjeUNpQWdJQ0F2THlBaklGVnpaWElnY0c5emRITWdZU0J4ZFdWeWVTQjNhWFJvSUdFZ1JFRkpVMWtnZEc5clpXNGdjR0Y1YldWdWRBb2dJQ0FnTHk4Z0l5QlRkRzl5WlhNZ2RHaGxJSEJ5YjIxd2RDQnBiaUJoSUhCbGNpMXhkV1Z5ZVNCaWIzZzdJSFJvYVhNZ1ltOTRJR2x6SUdSbGJHVjBaV1FnZFhCdmJpQnlaWE53YjI1elpRb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQXZMeUJrWldZZ2NHOXpkRjl4ZFdWeWVTaHpaV3htTENCeGRXVnllVjkwWlhoME9pQmhjbU0wTGxOMGNtbHVaeXdnY0dGNWJXVnVkRG9nWjNSNGJpNUJjM05sZEZSeVlXNXpabVZ5VkhKaGJuTmhZM1JwYjI0cElDMCtJRlZKYm5RMk5Eb0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdMeThnWTI5dWRISmhZM1JmTWk1d2VUbzNNeTAzTkFvZ0lDQWdMeThnSXlCV1lXeHBaR0YwWlNCd1lYbHRaVzUwQ2lBZ0lDQXZMeUJoYzNObGNuUWdjR0Y1YldWdWRDNTRabVZ5WDJGemMyVjBJRDA5SUhObGJHWXVkRzlyWlc0c0lDSlhjbTl1WnlCMGIydGxiaUlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1ozUjRibk1nV0dabGNrRnpjMlYwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlkRzlyWlc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkRzlyWlc0Z1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklGZHliMjVuSUhSdmEyVnVDaUFnSUNBdkx5QmpiMjUwY21GamRGOHlMbkI1T2pjMUNpQWdJQ0F2THlCaGMzTmxjblFnY0dGNWJXVnVkQzVoYzNObGRGOXlaV05sYVhabGNpQTlQU0JIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQ0FpVUdGNWJXVnVkQ0J0ZFhOMElHZHZJSFJ2SUdOdmJuUnlZV04wSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm5kSGh1Y3lCQmMzTmxkRkpsWTJWcGRtVnlDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUVlYbHRaVzUwSUcxMWMzUWdaMjhnZEc4Z1kyOXVkSEpoWTNRS0lDQWdJQzh2SUdOdmJuUnlZV04wWHpJdWNIazZOellLSUNBZ0lDOHZJR0Z6YzJWeWRDQndZWGx0Wlc1MExtRnpjMlYwWDJGdGIzVnVkQ0E5UFNCelpXeG1MbkYxWlhKNVgyWmxaU3dnSWxkeWIyNW5JR1psWlNCaGJXOTFiblFpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHZDBlRzV6SUVGemMyVjBRVzF2ZFc1MENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpY1hWbGNubGZabVZsSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuRjFaWEo1WDJabFpTQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdWM0p2Ym1jZ1ptVmxJR0Z0YjNWdWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSZk1pNXdlVG8zTndvZ0lDQWdMeThnWVhOelpYSjBJSEJoZVcxbGJuUXVjMlZ1WkdWeUlEMDlJRlI0Ymk1elpXNWtaWElzSUNKUVlYbHRaVzUwSUcxMWMzUWdZbVVnWm5KdmJTQmpZV3hzWlhJaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2QwZUc1eklGTmxibVJsY2dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUVlYbHRaVzUwSUcxMWMzUWdZbVVnWm5KdmJTQmpZV3hzWlhJS0lDQWdJQzh2SUdOdmJuUnlZV04wWHpJdWNIazZOemtLSUNBZ0lDOHZJSEZwWkNBOUlITmxiR1l1Ym1WNGRGOXhkV1Z5ZVY5cFpBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW01bGVIUmZjWFZsY25sZmFXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Ym1WNGRGOXhkV1Z5ZVY5cFpDQmxlR2x6ZEhNS0lDQWdJQzh2SUdOdmJuUnlZV04wWHpJdWNIazZPREFLSUNBZ0lDOHZJSE5sYkdZdWJtVjRkRjl4ZFdWeWVWOXBaQ0FyUFNCVlNXNTBOalFvTVNrS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltNWxlSFJmY1hWbGNubGZhV1FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1JmTWk1d2VUbzRNaTA0TXdvZ0lDQWdMeThnSXlCVGRHOXlaU0J3Y205dGNIUWdhVzRnWVNCd1pYSXRjWFZsY25rZ1ltOTRJQ2hsY0dobGJXVnlZV3dwQ2lBZ0lDQXZMeUJ6Wld4bUxuRjFaWEpwWlhOYmNXbGtYU0E5SUhGMVpYSjVYM1JsZUhRS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldNZ05DQXZMeUFpVVNJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUmZNaTV3ZVRvNE5Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhGcFpBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z1kyOXVkSEpoWTNSZk1pNUVaV05sYm5SeVlXeHBlbVZrUVdsRGIyNTBjbUZqZEM1emRXSnRhWFJmY21WemNHOXVjMlVvY1hWbGNubGZhV1E2SUhWcGJuUTJOQ3dnY21WemNHOXVjMlZmY21WbU9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS2MzVmliV2wwWDNKbGMzQnZibk5sT2dvZ0lDQWdMeThnWTI5dWRISmhZM1JmTWk1d2VUbzROeTA1TUFvZ0lDQWdMeThnSXlCUWNtOTJhV1JsY2lCemRXSnRhWFJ6SUdFZ2NtVnpjRzl1YzJVZ1lXNWtJR2RsZEhNZ2NtVjNZWEprWldRZ2FXNGdSRUZKVTFrS0lDQWdJQzh2SUNNZ1VtVmhaSE1nS0dkMVlYSmtjeUJ2YmlrZ2RHaGxJSEJ5YjIxd2RDQmliM2dnWVc1a0lHUmxiR1YwWlhNZ2FYUWdhVzF0WldScFlYUmxiSGtnZEc4Z2NtVmpiR0ZwYlNCTlFsSUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdMeThnWkdWbUlITjFZbTFwZEY5eVpYTndiMjV6WlNoelpXeG1MQ0J4ZFdWeWVWOXBaRG9nVlVsdWREWTBMQ0J5WlhOd2IyNXpaVjl5WldZNklHRnlZelF1VTNSeWFXNW5LU0F0UGlCT2IyNWxPZ29nSUNBZ2NISnZkRzhnTWlBd0NpQWdJQ0F2THlCamIyNTBjbUZqZEY4eUxuQjVPamt4TFRreUNpQWdJQ0F2THlBaklFZDFZWEprT2lCbGJuTjFjbVVnZEdobElIQnliMjF3ZENCaWIzZ2daWGhwYzNSek95QjNhV3hzSUdaaGFXd2dhV1lnYldsemMybHVaeUFvY0hKbGRtVnVkSE1nWkc5MVlteGxMMmx1ZG1Gc2FXUWdjbVZ6Y0c5dWMyVnpLUW9nSUNBZ0x5OGdYM0J5YjIxd2RDQTlJSE5sYkdZdWNYVmxjbWxsYzF0eGRXVnllVjlwWkYwS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldNZ05DQXZMeUFpVVNJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbkYxWlhKcFpYTWdaVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkRjh5TG5CNU9qazBMVEV3TUFvZ0lDQWdMeThnSXlCUVlYa2djSEp2ZG1sa1pYSWdhVzRnUkVGSlUxa2dLR2x1Ym1WeUlIaG1aWElwTGlCVWFHVWdiM1YwWlhJZ1kyRnNiQ0J6YUc5MWJHUWdZMjkyWlhJZ2FXNXVaWElnWm1WbGN5NEtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVgyRnpjMlYwUFhObGJHWXVkRzlyWlc0c0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZllXMXZkVzUwUFhObGJHWXVjWFZsY25sZlptVmxMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYM0psWTJWcGRtVnlQVlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVEFzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QmpiMjUwY21GamRGOHlMbkI1T2prMkNpQWdJQ0F2THlCNFptVnlYMkZ6YzJWMFBYTmxiR1l1ZEc5clpXNHNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWRHOXJaVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOXJaVzRnWlhocGMzUnpDaUFnSUNBdkx5QmpiMjUwY21GamRGOHlMbkI1T2prM0NpQWdJQ0F2THlCaGMzTmxkRjloYlc5MWJuUTljMlZzWmk1eGRXVnllVjltWldVc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpY1hWbGNubGZabVZsSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuRjFaWEo1WDJabFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUdOdmJuUnlZV04wWHpJdWNIazZPVGdLSUNBZ0lDOHZJR0Z6YzJWMFgzSmxZMlZwZG1WeVBWUjRiaTV6Wlc1a1pYSXNDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBVbVZqWldsMlpYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1dHWmxja0Z6YzJWMENpQWdJQ0F2THlCamIyNTBjbUZqZEY4eUxuQjVPamswTFRrMUNpQWdJQ0F2THlBaklGQmhlU0J3Y205MmFXUmxjaUJwYmlCRVFVbFRXU0FvYVc1dVpYSWdlR1psY2lrdUlGUm9aU0J2ZFhSbGNpQmpZV3hzSUhOb2IzVnNaQ0JqYjNabGNpQnBibTVsY2lCbVpXVnpMZ29nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ2FXNTBZMTh5SUM4dklHRjRabVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QmpiMjUwY21GamRGOHlMbkI1T2prNUNpQWdJQ0F2THlCbVpXVTlNQ3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUmZNaTV3ZVRvNU5DMHhNREFLSUNBZ0lDOHZJQ01nVUdGNUlIQnliM1pwWkdWeUlHbHVJRVJCU1ZOWklDaHBibTVsY2lCNFptVnlLUzRnVkdobElHOTFkR1Z5SUdOaGJHd2djMmh2ZFd4a0lHTnZkbVZ5SUdsdWJtVnlJR1psWlhNdUNpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0F2THlBZ0lDQWdlR1psY2w5aGMzTmxkRDF6Wld4bUxuUnZhMlZ1TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDF6Wld4bUxuRjFaWEo1WDJabFpTd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXlaV05sYVhabGNqMVVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMHdMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMFh6SXVjSGs2TVRBeUxURXdNd29nSUNBZ0x5OGdJeUJFWld4bGRHVWdkR2hsSUhCbGNpMXhkV1Z5ZVNCd2NtOXRjSFFnWW05NElIUnZJR2x0YldWa2FXRjBaV3g1SUhKbFkyeGhhVzBnVFVKU0NpQWdJQ0F2THlCa1pXd2djMlZzWmk1eGRXVnlhV1Z6VzNGMVpYSjVYMmxrWFFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0J5WlhSemRXSUtDZ292THlCamIyNTBjbUZqZEY4eUxrUmxZMlZ1ZEhKaGJHbDZaV1JCYVVOdmJuUnlZV04wTG5KbFlXUmZjSEp2YlhCMEtIRjFaWEo1WDJsa09pQjFhVzUwTmpRcElDMCtJR0o1ZEdWek9ncHlaV0ZrWDNCeWIyMXdkRG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBYekl1Y0hrNk1UQTNMVEV3T1FvZ0lDQWdMeThnSXlCU1pXRmtMVzl1YkhrZ2JXVjBhRzlrT2lCeVpYUjFjbTV6SUhSb1pTQndjbTl0Y0hRZ1ptOXlJR0VnWjJsMlpXNGdjWFZsY25rZ2FXUWdLR1p2Y2lCd2NtOTJhV1JsY25NZ2RHOGdabVYwWTJncENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUM4dklHUmxaaUJ5WldGa1gzQnliMjF3ZENoelpXeG1MQ0J4ZFdWeWVWOXBaRG9nVlVsdWREWTBLU0F0UGlCaGNtTTBMbE4wY21sdVp6b0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdMeThnWTI5dWRISmhZM1JmTWk1d2VUb3hNVEFLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG5GMVpYSnBaWE5iY1hWbGNubGZhV1JkQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbEVpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuRjFaWEpwWlhNZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQURBQUVFSmdZSVoyOTJaWEp1YjNJRmRHOXJaVzRKY1hWbGNubGZabVZsRFc1bGVIUmZjWFZsY25sZmFXUUJVUVFWSDN4MU1SaEFBQTBvTWdObktTSm5LaUpuS3lObk1SdEJBRCtDQ0FSdXNtQ3pCQWlwVnZjRS9FdUl0d1ErTHk0NEJCQlF0RkFFejF2WnhRUThNR0JiQkNGZFJXTTJHZ0NPQ0FDSEFIVUFaUUJaQUVrQUtnQVhBQUlpUXpFWkZFUXhHRVEyR2dFWGlBRnJKd1ZNVUxBalF6RVpGRVF4R0VRMkdnRVhOaG9DaUFFcEkwTXhHUlJFTVJoRU5ob0JNUllqQ1VrNEVDUVNSSWdBMGhZbkJVeFFzQ05ETVJrVVJERVlSRFlhQVJlSUFKZ2pRekVaRkVReEdFU0lBRzRqUXpFWkZFUXhHRVEyR2dFWGlBQk9JME14R1JSRU1SaEVOaG9CRjhBY2lBQXNJME14R1JSRU1SZ1VSRFlhQVJmQU1EWWFBaGVJQUFJalE0b0NBQ2d4QUdjcGkvNW5Lb3YvWnlzalo0bUtBUUF4QUNJb1pVUVNSQ2lMLzJlSmlnRUFNUUFpS0dWRUVrUXFpLzluaVRFQUlpaGxSQkpFc1NJcFpVUXlDcklVSXJJU3NoRWtzaEFpc2dHemlZb0JBREVBSWlobFJFeExBUkpFc1NJcFpVUk1zaFNMLzdJU3NoRWtzaEFpc2dHemlZb0NBWXYvT0JFaUtXVkVFa1NML3pnVU1nb1NSSXYvT0JJaUttVkVFa1NML3pnQU1RQVNSQ0lyWlVSSkl3Z3JUR2RKRmljRVRGQkp2RWlML3IrSmlnSUFpLzRXSndSTVVFbStSUUZFc1NJcFpVUWlLbVZFTVFDeUZMSVNzaEVrc2hBaXNnR3p2RWlKaWdFQmkvOFdKd1JNVUw1RWlRPT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjoxMCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
