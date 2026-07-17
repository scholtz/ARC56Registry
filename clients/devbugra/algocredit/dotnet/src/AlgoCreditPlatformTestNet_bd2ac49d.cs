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

namespace Arc56.Generated.devbugra.algocredit.AlgoCreditPlatformTestNet_bd2ac49d
{


    public class AlgoCreditPlatformTestNetProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AlgoCreditPlatformTestNetProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Simple hello method for testing
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
        ///Register a new investor - REAL GlobalState tracking
        ///</summary>
        /// <param name="investorType"> </param>
        /// <param name="riskLevel"> </param>
        public async Task<string> RegisterInvestor(string investorType, ulong riskLevel, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 50, 135, 171 };
            var investorTypeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); investorTypeAbi.From(investorType);
            var riskLevelAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); riskLevelAbi.From(riskLevel);

            var result = await base.CallApp(new List<object> { abiHandle, investorTypeAbi, riskLevelAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> RegisterInvestor_Transactions(string investorType, ulong riskLevel, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 50, 135, 171 };
            var investorTypeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); investorTypeAbi.From(investorType);
            var riskLevelAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); riskLevelAbi.From(riskLevel);

            return await base.MakeTransactionList(new List<object> { abiHandle, investorTypeAbi, riskLevelAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Register API key for wallet - REAL GlobalState tracking
        ///</summary>
        /// <param name="walletAddress"> </param>
        /// <param name="apiKeyHash"> </param>
        /// <param name="tier"> </param>
        public async Task<string> RegisterApiKey(string walletAddress, string apiKeyHash, string tier, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 136, 30, 181, 175 };
            var walletAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); walletAddressAbi.From(walletAddress);
            var apiKeyHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); apiKeyHashAbi.From(apiKeyHash);
            var tierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); tierAbi.From(tier);

            var result = await base.CallApp(new List<object> { abiHandle, walletAddressAbi, apiKeyHashAbi, tierAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> RegisterApiKey_Transactions(string walletAddress, string apiKeyHash, string tier, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 136, 30, 181, 175 };
            var walletAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); walletAddressAbi.From(walletAddress);
            var apiKeyHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); apiKeyHashAbi.From(apiKeyHash);
            var tierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); tierAbi.From(tier);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAddressAbi, apiKeyHashAbi, tierAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get API key count - REAL from global state
        ///</summary>
        public async Task<ulong> GetApiKeyCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 158, 100, 24, 23 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetApiKeyCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 158, 100, 24, 23 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check if wallet can get API key - always allow
        ///</summary>
        /// <param name="walletAddress"> </param>
        public async Task<ulong> CanGenerateApiKey(string walletAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 240, 234, 137 };
            var walletAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); walletAddressAbi.From(walletAddress);

            var result = await base.CallApp(new List<object> { abiHandle, walletAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CanGenerateApiKey_Transactions(string walletAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 240, 234, 137 };
            var walletAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); walletAddressAbi.From(walletAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Register a new startup owner - REAL GlobalState tracking
        ///</summary>
        /// <param name="startupName"> </param>
        /// <param name="industry"> </param>
        /// <param name="requestedAmount"> </param>
        public async Task<string> RegisterStartup(string startupName, string industry, ulong requestedAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 126, 172, 28, 161 };
            var startupNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); startupNameAbi.From(startupName);
            var industryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); industryAbi.From(industry);
            var requestedAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); requestedAmountAbi.From(requestedAmount);

            var result = await base.CallApp(new List<object> { abiHandle, startupNameAbi, industryAbi, requestedAmountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> RegisterStartup_Transactions(string startupName, string industry, ulong requestedAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 126, 172, 28, 161 };
            var startupNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); startupNameAbi.From(startupName);
            var industryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); industryAbi.From(industry);
            var requestedAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); requestedAmountAbi.From(requestedAmount);

            return await base.MakeTransactionList(new List<object> { abiHandle, startupNameAbi, industryAbi, requestedAmountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Tokenize a startup - Create tokenized investment opportunity
        ///</summary>
        /// <param name="startupName"> </param>
        /// <param name="tokenPrice"> </param>
        /// <param name="totalSupply"> </param>
        /// <param name="industry"> </param>
        public async Task<string> TokenizeStartup(string startupName, ulong tokenPrice, ulong totalSupply, string industry, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 31, 82, 60, 116 };
            var startupNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); startupNameAbi.From(startupName);
            var tokenPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenPriceAbi.From(tokenPrice);
            var totalSupplyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); totalSupplyAbi.From(totalSupply);
            var industryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); industryAbi.From(industry);

            var result = await base.CallApp(new List<object> { abiHandle, startupNameAbi, tokenPriceAbi, totalSupplyAbi, industryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> TokenizeStartup_Transactions(string startupName, ulong tokenPrice, ulong totalSupply, string industry, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 31, 82, 60, 116 };
            var startupNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); startupNameAbi.From(startupName);
            var tokenPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenPriceAbi.From(tokenPrice);
            var totalSupplyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); totalSupplyAbi.From(totalSupply);
            var industryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); industryAbi.From(industry);

            return await base.MakeTransactionList(new List<object> { abiHandle, startupNameAbi, tokenPriceAbi, totalSupplyAbi, industryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Create a loan request from startup - REAL implementation
        ///</summary>
        /// <param name="amount"> </param>
        /// <param name="duration"> </param>
        /// <param name="interestRate"> </param>
        public async Task<string> RequestLoan(ulong amount, ulong duration, ulong interestRate, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 255, 132, 55, 235 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var durationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); durationAbi.From(duration);
            var interestRateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); interestRateAbi.From(interestRate);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi, durationAbi, interestRateAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> RequestLoan_Transactions(ulong amount, ulong duration, ulong interestRate, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 255, 132, 55, 235 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var durationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); durationAbi.From(duration);
            var interestRateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); interestRateAbi.From(interestRate);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi, durationAbi, interestRateAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get investor count - REAL from global state
        ///</summary>
        public async Task<ulong> GetInvestorCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 156, 124, 236 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetInvestorCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 156, 124, 236 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get startup count - REAL from global state
        ///</summary>
        public async Task<ulong> GetStartupCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 160, 220, 160 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetStartupCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 160, 220, 160 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get tokenized startups count - REAL from global state
        ///</summary>
        public async Task<ulong> GetTokenizedStartupsCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 161, 75, 166, 157 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTokenizedStartupsCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 161, 75, 166, 157 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get total investments count - REAL from global state
        ///</summary>
        public async Task<ulong> GetTotalInvestmentsCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 226, 187, 120 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalInvestmentsCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 226, 187, 120 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get loan requests count - REAL from global state
        ///</summary>
        public async Task<ulong> GetLoanRequestCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 165, 124, 99, 62 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetLoanRequestCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 165, 124, 99, 62 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Invest in tokenized startup - REAL investment tracking
        ///</summary>
        /// <param name="startupId"> </param>
        /// <param name="investmentAmount"> </param>
        /// <param name="tokenAmount"> </param>
        public async Task<string> InvestInStartup(ulong startupId, ulong investmentAmount, ulong tokenAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 154, 212, 10, 203 };
            var startupIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); startupIdAbi.From(startupId);
            var investmentAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); investmentAmountAbi.From(investmentAmount);
            var tokenAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenAmountAbi.From(tokenAmount);

            var result = await base.CallApp(new List<object> { abiHandle, startupIdAbi, investmentAmountAbi, tokenAmountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> InvestInStartup_Transactions(ulong startupId, ulong investmentAmount, ulong tokenAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 154, 212, 10, 203 };
            var startupIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); startupIdAbi.From(startupId);
            var investmentAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); investmentAmountAbi.From(investmentAmount);
            var tokenAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenAmountAbi.From(tokenAmount);

            return await base.MakeTransactionList(new List<object> { abiHandle, startupIdAbi, investmentAmountAbi, tokenAmountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Real ALGO deposit - requires payment transaction
        ///</summary>
        public async Task<string> RealDeposit(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 152, 36, 199, 2 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> RealDeposit_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 152, 36, 199, 2 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Simulate deposit - for testing without payment
        ///</summary>
        /// <param name="amount"> </param>
        public async Task<string> SimulateDeposit(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 41, 77, 204 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> SimulateDeposit_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 41, 77, 204 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Real ALGO withdrawal - sends ALGO back to user
        ///</summary>
        /// <param name="amount"> </param>
        public async Task<string> RealWithdraw(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 15, 58, 248 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> RealWithdraw_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 15, 58, 248 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Simulate investment allocation - REAL GlobalState tracking
        ///</summary>
        /// <param name="amount"> </param>
        public async Task<string> SimulateInvestment(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 69, 225, 159, 169 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> SimulateInvestment_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 69, 225, 159, 169 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get available funds - REAL calculation
        ///</summary>
        public async Task<ulong> GetAvailableFunds(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 203, 69, 168, 183 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetAvailableFunds_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 203, 69, 168, 183 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get total deposited funds - REAL from global state
        ///</summary>
        public async Task<ulong> GetTotalDeposited(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 88, 122, 165, 115 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalDeposited_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 88, 122, 165, 115 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get total invested funds - REAL from global state
        ///</summary>
        public async Task<ulong> GetTotalInvested(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 228, 118, 209, 130 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalInvested_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 228, 118, 209, 130 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get platform fees - REAL from global state
        ///</summary>
        public async Task<ulong> GetPlatformFees(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 238, 87, 200, 44 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetPlatformFees_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 238, 87, 200, 44 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get platform statistics - REAL data
        ///</summary>
        public async Task<string> GetPlatformStats(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 35, 123, 72 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetPlatformStats_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 35, 123, 72 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get detailed platform info
        ///</summary>
        public async Task<string> GetContractInfo(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 94, 114, 160 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetContractInfo_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 94, 114, 160 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Real loan funding - sends ALGO to startup
        ///</summary>
        /// <param name="loanId"> </param>
        /// <param name="amount"> </param>
        public async Task<string> RealLoanFunding(ulong loanId, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 215, 167, 156, 47 };
            var loanIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); loanIdAbi.From(loanId);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, loanIdAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> RealLoanFunding_Transactions(ulong loanId, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 215, 167, 156, 47 };
            var loanIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); loanIdAbi.From(loanId);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, loanIdAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Simulate loan funding - for testing
        ///</summary>
        /// <param name="loanId"> </param>
        /// <param name="amount"> </param>
        public async Task<string> SimulateLoanFunding(ulong loanId, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 197, 220, 173, 63 };
            var loanIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); loanIdAbi.From(loanId);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, loanIdAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> SimulateLoanFunding_Transactions(ulong loanId, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 197, 220, 173, 63 };
            var loanIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); loanIdAbi.From(loanId);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, loanIdAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Platform status check - REAL from global state
        ///</summary>
        public async Task<ulong> IsContractActive(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 29, 172, 75 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsContractActive_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 29, 172, 75 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get active loans count - REAL from global state
        ///</summary>
        public async Task<ulong> GetActiveLoansCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 92, 142, 229, 210 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetActiveLoansCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 92, 142, 229, 210 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Admin function to toggle platform status - REAL state change
        ///</summary>
        public async Task<string> TogglePlatformStatus(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 238, 122, 125, 4 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> TogglePlatformStatus_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 238, 122, 125, 4 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Admin function to collect platform fees - REAL ALGO transfer
        ///</summary>
        public async Task<string> CollectPlatformFees(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 246, 92, 194, 119 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> CollectPlatformFees_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 246, 92, 194, 119 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get platform fees amount
        ///</summary>
        public async Task<ulong> GetPlatformFeesAmount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 9, 195, 213, 253 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetPlatformFeesAmount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 9, 195, 213, 253 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Test platform with real state
        ///</summary>
        public async Task<string> TestPlatform(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 128, 82, 33, 94 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> TestPlatform_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 128, 82, 33, 94 };

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

        protected override ulong? ExtraProgramPages { get; set; } = 1;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWxnb0NyZWRpdFBsYXRmb3JtVGVzdE5ldCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJoZWxsbyIsImRlc2MiOiJTaW1wbGUgaGVsbG8gbWV0aG9kIGZvciB0ZXN0aW5nIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWdpc3RlckludmVzdG9yIiwiZGVzYyI6IlJlZ2lzdGVyIGEgbmV3IGludmVzdG9yIC0gUkVBTCBHbG9iYWxTdGF0ZSB0cmFja2luZyIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnZlc3RvclR5cGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJpc2tMZXZlbCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZ2lzdGVyQXBpS2V5IiwiZGVzYyI6IlJlZ2lzdGVyIEFQSSBrZXkgZm9yIHdhbGxldCAtIFJFQUwgR2xvYmFsU3RhdGUgdHJhY2tpbmciLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoid2FsbGV0QWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBpS2V5SGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGllciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEFwaUtleUNvdW50IiwiZGVzYyI6IkdldCBBUEkga2V5IGNvdW50IC0gUkVBTCBmcm9tIGdsb2JhbCBzdGF0ZSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhbkdlbmVyYXRlQXBpS2V5IiwiZGVzYyI6IkNoZWNrIGlmIHdhbGxldCBjYW4gZ2V0IEFQSSBrZXkgLSBhbHdheXMgYWxsb3ciLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoid2FsbGV0QWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZ2lzdGVyU3RhcnR1cCIsImRlc2MiOiJSZWdpc3RlciBhIG5ldyBzdGFydHVwIG93bmVyIC0gUkVBTCBHbG9iYWxTdGF0ZSB0cmFja2luZyIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdGFydHVwTmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5kdXN0cnkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlcXVlc3RlZEFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRva2VuaXplU3RhcnR1cCIsImRlc2MiOiJUb2tlbml6ZSBhIHN0YXJ0dXAgLSBDcmVhdGUgdG9rZW5pemVkIGludmVzdG1lbnQgb3Bwb3J0dW5pdHkiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RhcnR1cE5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2VuUHJpY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsU3VwcGx5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbmR1c3RyeSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlcXVlc3RMb2FuIiwiZGVzYyI6IkNyZWF0ZSBhIGxvYW4gcmVxdWVzdCBmcm9tIHN0YXJ0dXAgLSBSRUFMIGltcGxlbWVudGF0aW9uIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZHVyYXRpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImludGVyZXN0UmF0ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEludmVzdG9yQ291bnQiLCJkZXNjIjoiR2V0IGludmVzdG9yIGNvdW50IC0gUkVBTCBmcm9tIGdsb2JhbCBzdGF0ZSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFN0YXJ0dXBDb3VudCIsImRlc2MiOiJHZXQgc3RhcnR1cCBjb3VudCAtIFJFQUwgZnJvbSBnbG9iYWwgc3RhdGUiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRUb2tlbml6ZWRTdGFydHVwc0NvdW50IiwiZGVzYyI6IkdldCB0b2tlbml6ZWQgc3RhcnR1cHMgY291bnQgLSBSRUFMIGZyb20gZ2xvYmFsIHN0YXRlIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0VG90YWxJbnZlc3RtZW50c0NvdW50IiwiZGVzYyI6IkdldCB0b3RhbCBpbnZlc3RtZW50cyBjb3VudCAtIFJFQUwgZnJvbSBnbG9iYWwgc3RhdGUiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRMb2FuUmVxdWVzdENvdW50IiwiZGVzYyI6IkdldCBsb2FuIHJlcXVlc3RzIGNvdW50IC0gUkVBTCBmcm9tIGdsb2JhbCBzdGF0ZSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImludmVzdEluU3RhcnR1cCIsImRlc2MiOiJJbnZlc3QgaW4gdG9rZW5pemVkIHN0YXJ0dXAgLSBSRUFMIGludmVzdG1lbnQgdHJhY2tpbmciLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RhcnR1cElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnZlc3RtZW50QW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbkFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlYWxEZXBvc2l0IiwiZGVzYyI6IlJlYWwgQUxHTyBkZXBvc2l0IC0gcmVxdWlyZXMgcGF5bWVudCB0cmFuc2FjdGlvbiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNpbXVsYXRlRGVwb3NpdCIsImRlc2MiOiJTaW11bGF0ZSBkZXBvc2l0IC0gZm9yIHRlc3Rpbmcgd2l0aG91dCBwYXltZW50IiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlYWxXaXRoZHJhdyIsImRlc2MiOiJSZWFsIEFMR08gd2l0aGRyYXdhbCAtIHNlbmRzIEFMR08gYmFjayB0byB1c2VyIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNpbXVsYXRlSW52ZXN0bWVudCIsImRlc2MiOiJTaW11bGF0ZSBpbnZlc3RtZW50IGFsbG9jYXRpb24gLSBSRUFMIEdsb2JhbFN0YXRlIHRyYWNraW5nIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEF2YWlsYWJsZUZ1bmRzIiwiZGVzYyI6IkdldCBhdmFpbGFibGUgZnVuZHMgLSBSRUFMIGNhbGN1bGF0aW9uIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0VG90YWxEZXBvc2l0ZWQiLCJkZXNjIjoiR2V0IHRvdGFsIGRlcG9zaXRlZCBmdW5kcyAtIFJFQUwgZnJvbSBnbG9iYWwgc3RhdGUiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRUb3RhbEludmVzdGVkIiwiZGVzYyI6IkdldCB0b3RhbCBpbnZlc3RlZCBmdW5kcyAtIFJFQUwgZnJvbSBnbG9iYWwgc3RhdGUiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRQbGF0Zm9ybUZlZXMiLCJkZXNjIjoiR2V0IHBsYXRmb3JtIGZlZXMgLSBSRUFMIGZyb20gZ2xvYmFsIHN0YXRlIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0UGxhdGZvcm1TdGF0cyIsImRlc2MiOiJHZXQgcGxhdGZvcm0gc3RhdGlzdGljcyAtIFJFQUwgZGF0YSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldENvbnRyYWN0SW5mbyIsImRlc2MiOiJHZXQgZGV0YWlsZWQgcGxhdGZvcm0gaW5mbyIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlYWxMb2FuRnVuZGluZyIsImRlc2MiOiJSZWFsIGxvYW4gZnVuZGluZyAtIHNlbmRzIEFMR08gdG8gc3RhcnR1cCIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsb2FuSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNpbXVsYXRlTG9hbkZ1bmRpbmciLCJkZXNjIjoiU2ltdWxhdGUgbG9hbiBmdW5kaW5nIC0gZm9yIHRlc3RpbmciLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibG9hbklkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc0NvbnRyYWN0QWN0aXZlIiwiZGVzYyI6IlBsYXRmb3JtIHN0YXR1cyBjaGVjayAtIFJFQUwgZnJvbSBnbG9iYWwgc3RhdGUiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRBY3RpdmVMb2Fuc0NvdW50IiwiZGVzYyI6IkdldCBhY3RpdmUgbG9hbnMgY291bnQgLSBSRUFMIGZyb20gZ2xvYmFsIHN0YXRlIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidG9nZ2xlUGxhdGZvcm1TdGF0dXMiLCJkZXNjIjoiQWRtaW4gZnVuY3Rpb24gdG8gdG9nZ2xlIHBsYXRmb3JtIHN0YXR1cyAtIFJFQUwgc3RhdGUgY2hhbmdlIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY29sbGVjdFBsYXRmb3JtRmVlcyIsImRlc2MiOiJBZG1pbiBmdW5jdGlvbiB0byBjb2xsZWN0IHBsYXRmb3JtIGZlZXMgLSBSRUFMIEFMR08gdHJhbnNmZXIiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRQbGF0Zm9ybUZlZXNBbW91bnQiLCJkZXNjIjoiR2V0IHBsYXRmb3JtIGZlZXMgYW1vdW50IiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdFBsYXRmb3JtIiwiZGVzYyI6IlRlc3QgcGxhdGZvcm0gd2l0aCByZWFsIHN0YXRlIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjExLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNjE3LDY0MSw2NTgsNjgyLDcwNiw3MjMsNzM1LDc2Nyw3OTksODYzLDg4Nyw5MDQsOTIxLDkzOCw5NTUsOTgzLDEwMTEsMTAzOSwxMDYzLDEwOTksMTExNiwxMTMzLDExNTAsMTE2NywxMTg0LDEyMjAsMTI2NCwxMzA0LDEzMTYsMTMzMywxMzc1LDE0MDldLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDQ0XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjIwLDY0NCw2NjEsNjg1LDcwOSw3MjYsNzM4LDc3MCw4MDIsODY2LDg5MCw5MDcsOTI0LDk0MSw5NTgsOTg2LDEwMTQsMTA0MiwxMDY2LDExMDIsMTExOSwxMTM2LDExNTMsMTE3MCwxMTg3LDEyMjMsMTI2NywxMzA3LDEzMTksMTMzNiwxMzc4LDE0MTJdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUyMywxNTcyLDE2MzMsMTcyNiwxODc4LDE5MzAsMjEzNSwyMTgyLDIxODgsMjE5NCwyMjAwLDIyMDYsMjI5OCwyMzA5LDIzMTksMjMyOSwyMzc2LDI0OTgsMjU5NCwyNTk4LDI2OTUsMjc1OSwyNzYzLDI4MjAsMjg2NiwyODcwLDI4NzYsMjg4MSwyODg2LDI4OTUsMjkwMywzMDA5LDMwMTMsMzAyNywzMDM4LDMwNDgsMzEyNiwzMTMwLDMxNDQsMzE1NSwzMTY1LDMyMTYsMzIyMiwzMjgzLDMzNjksMzM3NV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElERXdNREF3TURBZ05UQWdNVEF3TURBd01EQXdNQ0F4TURBd01EQUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZ3hOVEZtTjJNM05TQWlkRzkwWVd4R2RXNWtjMGx1ZG1WemRHVmtJaUFpZEc5MFlXeEdkVzVrYzBSbGNHOXphWFJsWkNJZ0luQnNZWFJtYjNKdFJtVmxjeUlnSW1OdmJuUnlZV04wUVdOMGFYWmxJaUFpZEc5MFlXeEJZM1JwZG1WTWIyRnVjeUlnSW5SdmRHRnNTVzUyWlhOMGIzSnpJaUFpZEc5MFlXeFRkR0Z5ZEhWd2N5SWdJblJ2ZEdGc1FYQnBTMlY1Y3lJZ0luUnZkR0ZzVkc5clpXNXBlbVZrVTNSaGNuUjFjSE1pSUNKMGIzUmhiRXh2WVc1U1pYRjFaWE4wY3lJZ0luUnZkR0ZzU1c1MlpYTjBiV1Z1ZEhNaUlEQjRNVFV4Wmpkak56VXdNREF3TURBd01EQXdNREF3TURBeElDSlFiR0YwWm05eWJTQnBjeUJqZFhKeVpXNTBiSGtnYVc1aFkzUnBkbVVpSUNKSmJuWmxjM1J0Wlc1MElHRnRiM1Z1ZENCdGRYTjBJR0psSUdkeVpXRjBaWElnZEdoaGJpQXdJaUFpUm5WdVpHbHVaeUJoYlc5MWJuUWdiWFZ6ZENCaVpTQm5jbVZoZEdWeUlIUm9ZVzRnTUNJZ0lrbHVkbUZzYVdRZ2JHOWhiaUJKUkNJZ0lrbHVjM1ZtWm1samFXVnVkQ0JoZG1GcGJHRmliR1VnWm5WdVpITWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6YldGeWRHTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk13b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUZzWjI5RGNtVmthWFJRYkdGMFptOXliVlJsYzNST1pYUWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5aVlYSmxYM0p2ZFhScGJtZEFNemNLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGd3TW1KbFkyVXhNU0F3ZUdZME16STROMkZpSURCNE9EZ3haV0kxWVdZZ01IZzVaVFkwTVRneE55QXdlRGswWmpCbFlUZzVJREI0TjJWaFl6RmpZVEVnTUhneFpqVXlNMk0zTkNBd2VHWm1PRFF6TjJWaUlEQjRaalU1WXpkalpXTWdNSGczWm1Fd1pHTmhNQ0F3ZUdFeE5HSmhOamxrSURCNE5qUmxNbUppTnpnZ01IaGhOVGRqTmpNelpTQXdlRGxoWkRRd1lXTmlJREI0T1RneU5HTTNNRElnTUhneFlqSTVOR1JqWXlBd2VEYzVNR1l6WVdZNElEQjRORFZsTVRsbVlUa2dNSGhqWWpRMVlUaGlOeUF3ZURVNE4yRmhOVGN6SURCNFpUUTNObVF4T0RJZ01IaGxaVFUzWXpneVl5QXdlREV4TWpNM1lqUTRJREI0WW1VMVpUY3lZVEFnTUhoa04yRTNPV015WmlBd2VHTTFaR05oWkRObUlEQjRPR0V4WkdGak5HSWdNSGcxWXpobFpUVmtNaUF3ZUdWbE4yRTNaREEwSURCNFpqWTFZMk15TnpjZ01IZ3dPV016WkRWbVpDQXdlRGd3TlRJeU1UVmxJQzh2SUcxbGRHaHZaQ0FpYUdWc2JHOG9jM1J5YVc1bktYTjBjbWx1WnlJc0lHMWxkR2h2WkNBaWNtVm5hWE4wWlhKSmJuWmxjM1J2Y2loemRISnBibWNzZFdsdWREWTBLWE4wY21sdVp5SXNJRzFsZEdodlpDQWljbVZuYVhOMFpYSkJjR2xMWlhrb2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3BjM1J5YVc1bklpd2diV1YwYUc5a0lDSm5aWFJCY0dsTFpYbERiM1Z1ZENncGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKallXNUhaVzVsY21GMFpVRndhVXRsZVNoemRISnBibWNwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0p5WldkcGMzUmxjbE4wWVhKMGRYQW9jM1J5YVc1bkxITjBjbWx1Wnl4MWFXNTBOalFwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0owYjJ0bGJtbDZaVk4wWVhKMGRYQW9jM1J5YVc1bkxIVnBiblEyTkN4MWFXNTBOalFzYzNSeWFXNW5LWE4wY21sdVp5SXNJRzFsZEdodlpDQWljbVZ4ZFdWemRFeHZZVzRvZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRcGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKblpYUkpiblpsYzNSdmNrTnZkVzUwS0NsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGRGTjBZWEowZFhCRGIzVnVkQ2dwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0puWlhSVWIydGxibWw2WldSVGRHRnlkSFZ3YzBOdmRXNTBLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbWRsZEZSdmRHRnNTVzUyWlhOMGJXVnVkSE5EYjNWdWRDZ3BkV2x1ZERZMElpd2diV1YwYUc5a0lDSm5aWFJNYjJGdVVtVnhkV1Z6ZEVOdmRXNTBLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbWx1ZG1WemRFbHVVM1JoY25SMWNDaDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ2x6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJbkpsWVd4RVpYQnZjMmwwS0NsemRISnBibWNpTENCdFpYUm9iMlFnSW5OcGJYVnNZWFJsUkdWd2IzTnBkQ2gxYVc1ME5qUXBjM1J5YVc1bklpd2diV1YwYUc5a0lDSnlaV0ZzVjJsMGFHUnlZWGNvZFdsdWREWTBLWE4wY21sdVp5SXNJRzFsZEdodlpDQWljMmx0ZFd4aGRHVkpiblpsYzNSdFpXNTBLSFZwYm5RMk5DbHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0ltZGxkRUYyWVdsc1lXSnNaVVoxYm1SektDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltZGxkRlJ2ZEdGc1JHVndiM05wZEdWa0tDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltZGxkRlJ2ZEdGc1NXNTJaWE4wWldRb0tYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVoyVjBVR3hoZEdadmNtMUdaV1Z6S0NsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGRGQnNZWFJtYjNKdFUzUmhkSE1vS1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpWjJWMFEyOXVkSEpoWTNSSmJtWnZLQ2x6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJbkpsWVd4TWIyRnVSblZ1WkdsdVp5aDFhVzUwTmpRc2RXbHVkRFkwS1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpYzJsdGRXeGhkR1ZNYjJGdVJuVnVaR2x1WnloMWFXNTBOalFzZFdsdWREWTBLWE4wY21sdVp5SXNJRzFsZEdodlpDQWlhWE5EYjI1MGNtRmpkRUZqZEdsMlpTZ3BkV2x1ZERZMElpd2diV1YwYUc5a0lDSm5aWFJCWTNScGRtVk1iMkZ1YzBOdmRXNTBLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJblJ2WjJkc1pWQnNZWFJtYjNKdFUzUmhkSFZ6S0NsemRISnBibWNpTENCdFpYUm9iMlFnSW1OdmJHeGxZM1JRYkdGMFptOXliVVpsWlhNb0tYTjBjbWx1WnlJc0lHMWxkR2h2WkNBaVoyVjBVR3hoZEdadmNtMUdaV1Z6UVcxdmRXNTBLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJblJsYzNSUWJHRjBabTl5YlNncGMzUnlhVzVuSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDlvWld4c2IxOXliM1YwWlVBeklHMWhhVzVmY21WbmFYTjBaWEpKYm5abGMzUnZjbDl5YjNWMFpVQTBJRzFoYVc1ZmNtVm5hWE4wWlhKQmNHbExaWGxmY205MWRHVkFOU0J0WVdsdVgyZGxkRUZ3YVV0bGVVTnZkVzUwWDNKdmRYUmxRRFlnYldGcGJsOWpZVzVIWlc1bGNtRjBaVUZ3YVV0bGVWOXliM1YwWlVBM0lHMWhhVzVmY21WbmFYTjBaWEpUZEdGeWRIVndYM0p2ZFhSbFFEZ2diV0ZwYmw5MGIydGxibWw2WlZOMFlYSjBkWEJmY205MWRHVkFPU0J0WVdsdVgzSmxjWFZsYzNSTWIyRnVYM0p2ZFhSbFFERXdJRzFoYVc1ZloyVjBTVzUyWlhOMGIzSkRiM1Z1ZEY5eWIzVjBaVUF4TVNCdFlXbHVYMmRsZEZOMFlYSjBkWEJEYjNWdWRGOXliM1YwWlVBeE1pQnRZV2x1WDJkbGRGUnZhMlZ1YVhwbFpGTjBZWEowZFhCelEyOTFiblJmY205MWRHVkFNVE1nYldGcGJsOW5aWFJVYjNSaGJFbHVkbVZ6ZEcxbGJuUnpRMjkxYm5SZmNtOTFkR1ZBTVRRZ2JXRnBibDluWlhSTWIyRnVVbVZ4ZFdWemRFTnZkVzUwWDNKdmRYUmxRREUxSUcxaGFXNWZhVzUyWlhOMFNXNVRkR0Z5ZEhWd1gzSnZkWFJsUURFMklHMWhhVzVmY21WaGJFUmxjRzl6YVhSZmNtOTFkR1ZBTVRjZ2JXRnBibDl6YVcxMWJHRjBaVVJsY0c5emFYUmZjbTkxZEdWQU1UZ2diV0ZwYmw5eVpXRnNWMmwwYUdSeVlYZGZjbTkxZEdWQU1Ua2diV0ZwYmw5emFXMTFiR0YwWlVsdWRtVnpkRzFsYm5SZmNtOTFkR1ZBTWpBZ2JXRnBibDluWlhSQmRtRnBiR0ZpYkdWR2RXNWtjMTl5YjNWMFpVQXlNU0J0WVdsdVgyZGxkRlJ2ZEdGc1JHVndiM05wZEdWa1gzSnZkWFJsUURJeUlHMWhhVzVmWjJWMFZHOTBZV3hKYm5abGMzUmxaRjl5YjNWMFpVQXlNeUJ0WVdsdVgyZGxkRkJzWVhSbWIzSnRSbVZsYzE5eWIzVjBaVUF5TkNCdFlXbHVYMmRsZEZCc1lYUm1iM0p0VTNSaGRITmZjbTkxZEdWQU1qVWdiV0ZwYmw5blpYUkRiMjUwY21GamRFbHVabTlmY205MWRHVkFNallnYldGcGJsOXlaV0ZzVEc5aGJrWjFibVJwYm1kZmNtOTFkR1ZBTWpjZ2JXRnBibDl6YVcxMWJHRjBaVXh2WVc1R2RXNWthVzVuWDNKdmRYUmxRREk0SUcxaGFXNWZhWE5EYjI1MGNtRmpkRUZqZEdsMlpWOXliM1YwWlVBeU9TQnRZV2x1WDJkbGRFRmpkR2wyWlV4dllXNXpRMjkxYm5SZmNtOTFkR1ZBTXpBZ2JXRnBibDkwYjJkbmJHVlFiR0YwWm05eWJWTjBZWFIxYzE5eWIzVjBaVUF6TVNCdFlXbHVYMk52Ykd4bFkzUlFiR0YwWm05eWJVWmxaWE5mY205MWRHVkFNeklnYldGcGJsOW5aWFJRYkdGMFptOXliVVpsWlhOQmJXOTFiblJmY205MWRHVkFNek1nYldGcGJsOTBaWE4wVUd4aGRHWnZjbTFmY205MWRHVkFNelFLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBME1Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM050WVhKMFkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvekNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRV3huYjBOeVpXUnBkRkJzWVhSbWIzSnRWR1Z6ZEU1bGRDQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnpkRkJzWVhSbWIzSnRYM0p2ZFhSbFFETTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzIxaGNuUmpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTJOQW9nSUNBZ0x5OGdkR1Z6ZEZCc1lYUm1iM0p0S0NrNklITjBjbWx1WnlCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEZCc1lYUm1iM0p0Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJRYkdGMFptOXliVVpsWlhOQmJXOTFiblJmY205MWRHVkFNek02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5emJXRnlkR052Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFUzQ2lBZ0lDQXZMeUJuWlhSUWJHRjBabTl5YlVabFpYTkJiVzkxYm5Rb0tUb2dkV2x1ZERZMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUJuWlhSUWJHRjBabTl5YlVabFpYTkJiVzkxYm5RS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWTI5c2JHVmpkRkJzWVhSbWIzSnRSbVZsYzE5eWIzVjBaVUF6TWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTnRZWEowWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTXpnS0lDQWdJQzh2SUdOdmJHeGxZM1JRYkdGMFptOXliVVpsWlhNb0tUb2djM1J5YVc1bklIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUJqYjJ4c1pXTjBVR3hoZEdadmNtMUdaV1Z6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBiMmRuYkdWUWJHRjBabTl5YlZOMFlYUjFjMTl5YjNWMFpVQXpNVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBNalVLSUNBZ0lDOHZJSFJ2WjJkc1pWQnNZWFJtYjNKdFUzUmhkSFZ6S0NrNklITjBjbWx1WnlCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJR05oYkd4emRXSWdkRzluWjJ4bFVHeGhkR1p2Y20xVGRHRjBkWE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRUZqZEdsMlpVeHZZVzV6UTI5MWJuUmZjbTkxZEdWQU16QTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6YldGeWRHTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5ERTRDaUFnSUNBdkx5Qm5aWFJCWTNScGRtVk1iMkZ1YzBOdmRXNTBLQ2s2SUhWcGJuUTJOQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBRV04wYVhabFRHOWhibk5EYjNWdWRBb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5cGMwTnZiblJ5WVdOMFFXTjBhWFpsWDNKdmRYUmxRREk1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZmMyMWhjblJqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalF3T1FvZ0lDQWdMeThnYVhORGIyNTBjbUZqZEVGamRHbDJaU2dwT2lCMWFXNTBOalFnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmllWFJsWXlBeE1pQXZMeUF3ZURFMU1XWTNZemMxTURBd01EQXdNREF3TURBd01EQXdNUW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzTnBiWFZzWVhSbFRHOWhia1oxYm1ScGJtZGZjbTkxZEdWQU1qZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6YldGeWRHTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16Z3hDaUFnSUNBdkx5QnphVzExYkdGMFpVeHZZVzVHZFc1a2FXNW5LR3h2WVc1SlpEb2dkV2x1ZERZMExDQmhiVzkxYm5RNklIVnBiblEyTkNrNklITjBjbWx1WnlCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTnRZWEowWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1FXeG5iME55WldScGRGQnNZWFJtYjNKdFZHVnpkRTVsZENCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTnRZWEowWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96T0RFS0lDQWdJQzh2SUhOcGJYVnNZWFJsVEc5aGJrWjFibVJwYm1jb2JHOWhia2xrT2lCMWFXNTBOalFzSUdGdGIzVnVkRG9nZFdsdWREWTBLVG9nYzNSeWFXNW5JSHNLSUNBZ0lHTmhiR3h6ZFdJZ2MybHRkV3hoZEdWTWIyRnVSblZ1WkdsdVp3b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmY21WaGJFeHZZVzVHZFc1a2FXNW5YM0p2ZFhSbFFESTNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzIxaGNuUmpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTFNQW9nSUNBZ0x5OGdjbVZoYkV4dllXNUdkVzVrYVc1bktHeHZZVzVKWkRvZ2RXbHVkRFkwTENCaGJXOTFiblE2SUhWcGJuUTJOQ2s2SUhOMGNtbHVaeUI3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUVd4bmIwTnlaV1JwZEZCc1lYUm1iM0p0VkdWemRFNWxkQ0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOVEFLSUNBZ0lDOHZJSEpsWVd4TWIyRnVSblZ1WkdsdVp5aHNiMkZ1U1dRNklIVnBiblEyTkN3Z1lXMXZkVzUwT2lCMWFXNTBOalFwT2lCemRISnBibWNnZXdvZ0lDQWdZMkZzYkhOMVlpQnlaV0ZzVEc5aGJrWjFibVJwYm1jS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEVOdmJuUnlZV04wU1c1bWIxOXliM1YwWlVBeU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM050WVhKMFkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5ETUtJQ0FnSUM4dklHZGxkRU52Ym5SeVlXTjBTVzVtYnlncE9pQnpkSEpwYm1jZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlRBd01tVTBNVFpqTmpjMlpqUXpOekkyTlRZME5qazNOREl3TlRBMll6WXhOelEyTmpabU56STJaREl3TnpZek16SmxNekF5TURKa01qQTFNalkxTmpFMll6SXdOVEEyTVRjNU5tUTJOVFpsTnpRM016SXdOVEkyTlRZeE5qUTNPUW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRkJzWVhSbWIzSnRVM1JoZEhOZmNtOTFkR1ZBTWpVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOXpiV0Z5ZEdOdmJuUnlZV04wTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpJNUNpQWdJQ0F2THlCblpYUlFiR0YwWm05eWJWTjBZWFJ6S0NrNklITjBjbWx1WnlCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJR05oYkd4emRXSWdaMlYwVUd4aGRHWnZjbTFUZEdGMGN3b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFVHeGhkR1p2Y20xR1pXVnpYM0p2ZFhSbFFESTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzIxaGNuUmpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXlNZ29nSUNBZ0x5OGdaMlYwVUd4aGRHWnZjbTFHWldWektDazZJSFZwYm5RMk5DQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFVHeGhkR1p2Y20xR1pXVnpDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRlJ2ZEdGc1NXNTJaWE4wWldSZmNtOTFkR1ZBTWpNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOXpiV0Z5ZEdOdmJuUnlZV04wTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpFMUNpQWdJQ0F2THlCblpYUlViM1JoYkVsdWRtVnpkR1ZrS0NrNklIVnBiblEyTkNCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJR05oYkd4emRXSWdaMlYwVkc5MFlXeEpiblpsYzNSbFpBb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUlViM1JoYkVSbGNHOXphWFJsWkY5eWIzVjBaVUF5TWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTnRZWEowWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TURnS0lDQWdJQzh2SUdkbGRGUnZkR0ZzUkdWd2IzTnBkR1ZrS0NrNklIVnBiblEyTkNCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJR05oYkd4emRXSWdaMlYwVkc5MFlXeEVaWEJ2YzJsMFpXUUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBRWFpoYVd4aFlteGxSblZ1WkhOZmNtOTFkR1ZBTWpFNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOXpiV0Z5ZEdOdmJuUnlZV04wTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpBeENpQWdJQ0F2THlCblpYUkJkbUZwYkdGaWJHVkdkVzVrY3lncE9pQjFhVzUwTmpRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJR2RsZEVGMllXbHNZV0pzWlVaMWJtUnpDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzTnBiWFZzWVhSbFNXNTJaWE4wYldWdWRGOXliM1YwWlVBeU1Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM050WVhKMFkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9ERUtJQ0FnSUM4dklITnBiWFZzWVhSbFNXNTJaWE4wYldWdWRDaGhiVzkxYm5RNklIVnBiblEyTkNrNklITjBjbWx1WnlCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTnRZWEowWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1FXeG5iME55WldScGRGQnNZWFJtYjNKdFZHVnpkRTVsZENCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTnRZWEowWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T0RFS0lDQWdJQzh2SUhOcGJYVnNZWFJsU1c1MlpYTjBiV1Z1ZENoaGJXOTFiblE2SUhWcGJuUTJOQ2s2SUhOMGNtbHVaeUI3Q2lBZ0lDQmpZV3hzYzNWaUlITnBiWFZzWVhSbFNXNTJaWE4wYldWdWRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmY21WaGJGZHBkR2hrY21GM1gzSnZkWFJsUURFNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZjMjFoY25SamIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJMU13b2dJQ0FnTHk4Z2NtVmhiRmRwZEdoa2NtRjNLR0Z0YjNWdWREb2dkV2x1ZERZMEtUb2djM1J5YVc1bklIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZjMjFoY25SamIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkJiR2R2UTNKbFpHbDBVR3hoZEdadmNtMVVaWE4wVG1WMElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZjMjFoY25SamIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJMU13b2dJQ0FnTHk4Z2NtVmhiRmRwZEdoa2NtRjNLR0Z0YjNWdWREb2dkV2x1ZERZMEtUb2djM1J5YVc1bklIc0tJQ0FnSUdOaGJHeHpkV0lnY21WaGJGZHBkR2hrY21GM0NpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl6YVcxMWJHRjBaVVJsY0c5emFYUmZjbTkxZEdWQU1UZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6YldGeWRHTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qTXpDaUFnSUNBdkx5QnphVzExYkdGMFpVUmxjRzl6YVhRb1lXMXZkVzUwT2lCMWFXNTBOalFwT2lCemRISnBibWNnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5emJXRnlkR052Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNd29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVGc1oyOURjbVZrYVhSUWJHRjBabTl5YlZSbGMzUk9aWFFnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5emJXRnlkR052Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNak16Q2lBZ0lDQXZMeUJ6YVcxMWJHRjBaVVJsY0c5emFYUW9ZVzF2ZFc1ME9pQjFhVzUwTmpRcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnWTJGc2JITjFZaUJ6YVcxMWJHRjBaVVJsY0c5emFYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNKbFlXeEVaWEJ2YzJsMFgzSnZkWFJsUURFM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZjMjFoY25SamIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJeE53b2dJQ0FnTHk4Z2NtVmhiRVJsY0c5emFYUW9LVG9nYzNSeWFXNW5JSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCeVpXRnNSR1Z3YjNOcGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmYVc1MlpYTjBTVzVUZEdGeWRIVndYM0p2ZFhSbFFERTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzIxaGNuUmpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTROQW9nSUNBZ0x5OGdhVzUyWlhOMFNXNVRkR0Z5ZEhWd0tITjBZWEowZFhCSlpEb2dkV2x1ZERZMExDQnBiblpsYzNSdFpXNTBRVzF2ZFc1ME9pQjFhVzUwTmpRc0lIUnZhMlZ1UVcxdmRXNTBPaUIxYVc1ME5qUXBPaUJ6ZEhKcGJtY2dld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6YldGeWRHTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk13b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUZzWjI5RGNtVmthWFJRYkdGMFptOXliVlJsYzNST1pYUWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6YldGeWRHTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UZzBDaUFnSUNBdkx5QnBiblpsYzNSSmJsTjBZWEowZFhBb2MzUmhjblIxY0Vsa09pQjFhVzUwTmpRc0lHbHVkbVZ6ZEcxbGJuUkJiVzkxYm5RNklIVnBiblEyTkN3Z2RHOXJaVzVCYlc5MWJuUTZJSFZwYm5RMk5DazZJSE4wY21sdVp5QjdDaUFnSUNCallXeHNjM1ZpSUdsdWRtVnpkRWx1VTNSaGNuUjFjQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBURzloYmxKbGNYVmxjM1JEYjNWdWRGOXliM1YwWlVBeE5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM050WVhKMFkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE56WUtJQ0FnSUM4dklHZGxkRXh2WVc1U1pYRjFaWE4wUTI5MWJuUW9LVG9nZFdsdWREWTBJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCblpYUk1iMkZ1VW1WeGRXVnpkRU52ZFc1MENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGUnZkR0ZzU1c1MlpYTjBiV1Z1ZEhORGIzVnVkRjl5YjNWMFpVQXhORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOamdLSUNBZ0lDOHZJR2RsZEZSdmRHRnNTVzUyWlhOMGJXVnVkSE5EYjNWdWRDZ3BPaUIxYVc1ME5qUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUdkbGRGUnZkR0ZzU1c1MlpYTjBiV1Z1ZEhORGIzVnVkQW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJVYjJ0bGJtbDZaV1JUZEdGeWRIVndjME52ZFc1MFgzSnZkWFJsUURFek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZjMjFoY25SamIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMk1Bb2dJQ0FnTHk4Z1oyVjBWRzlyWlc1cGVtVmtVM1JoY25SMWNITkRiM1Z1ZENncE9pQjFhVzUwTmpRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJR2RsZEZSdmEyVnVhWHBsWkZOMFlYSjBkWEJ6UTI5MWJuUUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBVM1JoY25SMWNFTnZkVzUwWDNKdmRYUmxRREV5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZmMyMWhjblJqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxTWdvZ0lDQWdMeThnWjJWMFUzUmhjblIxY0VOdmRXNTBLQ2s2SUhWcGJuUTJOQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBVM1JoY25SMWNFTnZkVzUwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEVsdWRtVnpkRzl5UTI5MWJuUmZjbTkxZEdWQU1URTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6YldGeWRHTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUTBDaUFnSUNBdkx5Qm5aWFJKYm5abGMzUnZja052ZFc1MEtDazZJSFZwYm5RMk5DQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFNXNTJaWE4wYjNKRGIzVnVkQW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXlaWEYxWlhOMFRHOWhibDl5YjNWMFpVQXhNRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNVEFLSUNBZ0lDOHZJSEpsY1hWbGMzUk1iMkZ1S0dGdGIzVnVkRG9nZFdsdWREWTBMQ0JrZFhKaGRHbHZiam9nZFdsdWREWTBMQ0JwYm5SbGNtVnpkRkpoZEdVNklIVnBiblEyTkNrNklITjBjbWx1WnlCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTnRZWEowWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1FXeG5iME55WldScGRGQnNZWFJtYjNKdFZHVnpkRTVsZENCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTnRZWEowWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRBS0lDQWdJQzh2SUhKbGNYVmxjM1JNYjJGdUtHRnRiM1Z1ZERvZ2RXbHVkRFkwTENCa2RYSmhkR2x2YmpvZ2RXbHVkRFkwTENCcGJuUmxjbVZ6ZEZKaGRHVTZJSFZwYm5RMk5DazZJSE4wY21sdVp5QjdDaUFnSUNCallXeHNjM1ZpSUhKbGNYVmxjM1JNYjJGdUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkwYjJ0bGJtbDZaVk4wWVhKMGRYQmZjbTkxZEdWQU9Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM050WVhKMFkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU1Rb2dJQ0FnTHk4Z2RHOXJaVzVwZW1WVGRHRnlkSFZ3S0hOMFlYSjBkWEJPWVcxbE9pQnpkSEpwYm1jc0lIUnZhMlZ1VUhKcFkyVTZJSFZwYm5RMk5Dd2dkRzkwWVd4VGRYQndiSGs2SUhWcGJuUTJOQ3dnYVc1a2RYTjBjbms2SUhOMGNtbHVaeWs2SUhOMGNtbHVaeUI3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUVd4bmIwTnlaV1JwZEZCc1lYUm1iM0p0VkdWemRFNWxkQ0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZjMjFoY25SamIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2preENpQWdJQ0F2THlCMGIydGxibWw2WlZOMFlYSjBkWEFvYzNSaGNuUjFjRTVoYldVNklITjBjbWx1Wnl3Z2RHOXJaVzVRY21salpUb2dkV2x1ZERZMExDQjBiM1JoYkZOMWNIQnNlVG9nZFdsdWREWTBMQ0JwYm1SMWMzUnllVG9nYzNSeWFXNW5LVG9nYzNSeWFXNW5JSHNLSUNBZ0lHTmhiR3h6ZFdJZ2RHOXJaVzVwZW1WVGRHRnlkSFZ3Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXlaV2RwYzNSbGNsTjBZWEowZFhCZmNtOTFkR1ZBT0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTnRZWEowWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTVFvZ0lDQWdMeThnY21WbmFYTjBaWEpUZEdGeWRIVndLSE4wWVhKMGRYQk9ZVzFsT2lCemRISnBibWNzSUdsdVpIVnpkSEo1T2lCemRISnBibWNzSUhKbGNYVmxjM1JsWkVGdGIzVnVkRG9nZFdsdWREWTBLVG9nYzNSeWFXNW5JSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzIxaGNuUmpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJCYkdkdlEzSmxaR2wwVUd4aGRHWnZjbTFVWlhOMFRtVjBJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOXpiV0Z5ZEdOdmJuUnlZV04wTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpFS0lDQWdJQzh2SUhKbFoybHpkR1Z5VTNSaGNuUjFjQ2h6ZEdGeWRIVndUbUZ0WlRvZ2MzUnlhVzVuTENCcGJtUjFjM1J5ZVRvZ2MzUnlhVzVuTENCeVpYRjFaWE4wWldSQmJXOTFiblE2SUhWcGJuUTJOQ2s2SUhOMGNtbHVaeUI3Q2lBZ0lDQmpZV3hzYzNWaUlISmxaMmx6ZEdWeVUzUmhjblIxY0FvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZMkZ1UjJWdVpYSmhkR1ZCY0dsTFpYbGZjbTkxZEdWQU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM050WVhKMFkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk5Bb2dJQ0FnTHk4Z1kyRnVSMlZ1WlhKaGRHVkJjR2xMWlhrb2QyRnNiR1YwUVdSa2NtVnpjem9nYzNSeWFXNW5LVG9nZFdsdWREWTBJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1lubDBaV01nTVRJZ0x5OGdNSGd4TlRGbU4yTTNOVEF3TURBd01EQXdNREF3TURBd01ERUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUkJjR2xMWlhsRGIzVnVkRjl5YjNWMFpVQTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzIxaGNuUmpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTNDaUFnSUNBdkx5Qm5aWFJCY0dsTFpYbERiM1Z1ZENncE9pQjFhVzUwTmpRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJR2RsZEVGd2FVdGxlVU52ZFc1MENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNKbFoybHpkR1Z5UVhCcFMyVjVYM0p2ZFhSbFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6YldGeWRHTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EWUtJQ0FnSUM4dklISmxaMmx6ZEdWeVFYQnBTMlY1S0hkaGJHeGxkRUZrWkhKbGMzTTZJSE4wY21sdVp5d2dZWEJwUzJWNVNHRnphRG9nYzNSeWFXNW5MQ0IwYVdWeU9pQnpkSEpwYm1jcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOXpiV0Z5ZEdOdmJuUnlZV04wTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFRnNaMjlEY21Wa2FYUlFiR0YwWm05eWJWUmxjM1JPWlhRZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6YldGeWRHTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EWUtJQ0FnSUM4dklISmxaMmx6ZEdWeVFYQnBTMlY1S0hkaGJHeGxkRUZrWkhKbGMzTTZJSE4wY21sdVp5d2dZWEJwUzJWNVNHRnphRG9nYzNSeWFXNW5MQ0IwYVdWeU9pQnpkSEpwYm1jcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnWTJGc2JITjFZaUJ5WldkcGMzUmxja0Z3YVV0bGVRb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmY21WbmFYTjBaWEpKYm5abGMzUnZjbDl5YjNWMFpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzIxaGNuUmpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXhDaUFnSUNBdkx5QnlaV2RwYzNSbGNrbHVkbVZ6ZEc5eUtHbHVkbVZ6ZEc5eVZIbHdaVG9nYzNSeWFXNW5MQ0J5YVhOclRHVjJaV3c2SUhWcGJuUTJOQ2s2SUhOMGNtbHVaeUI3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUVd4bmIwTnlaV1JwZEZCc1lYUm1iM0p0VkdWemRFNWxkQ0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6YldGeWRHTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16RUtJQ0FnSUM4dklISmxaMmx6ZEdWeVNXNTJaWE4wYjNJb2FXNTJaWE4wYjNKVWVYQmxPaUJ6ZEhKcGJtY3NJSEpwYzJ0TVpYWmxiRG9nZFdsdWREWTBLVG9nYzNSeWFXNW5JSHNLSUNBZ0lHTmhiR3h6ZFdJZ2NtVm5hWE4wWlhKSmJuWmxjM1J2Y2dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZhR1ZzYkc5ZmNtOTFkR1ZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTnRZWEowWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TXdvZ0lDQWdMeThnYUdWc2JHOG9ibUZ0WlRvZ2MzUnlhVzVuS1RvZ2MzUnlhVzVuSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZmMyMWhjblJqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak1LSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQmJHZHZRM0psWkdsMFVHeGhkR1p2Y20xVVpYTjBUbVYwSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNd29nSUNBZ0x5OGdhR1ZzYkc4b2JtRnRaVG9nYzNSeWFXNW5LVG9nYzNSeWFXNW5JSHNLSUNBZ0lHTmhiR3h6ZFdJZ2FHVnNiRzhLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgySmhjbVZmY205MWRHbHVaMEF6TnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTnRZWEowWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1FXeG5iME55WldScGRGQnNZWFJtYjNKdFZHVnpkRTVsZENCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFOREVLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJR055WldGMGFXNW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZjMjFoY25SamIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwQmJHZHZRM0psWkdsMFVHeGhkR1p2Y20xVVpYTjBUbVYwTG1obGJHeHZLRzVoYldVNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS2FHVnNiRzg2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5emJXRnlkR052Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNak1LSUNBZ0lDOHZJR2hsYkd4dktHNWhiV1U2SUhOMGNtbHVaeWs2SUhOMGNtbHVaeUI3Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM050WVhKMFkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUdCSVpXeHNieXdnSkh0dVlXMWxmV0FLSUNBZ0lIQjFjMmhpZVhSbGN5QWlTR1ZzYkc4c0lDSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6YldGeWRHTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rRnNaMjlEY21Wa2FYUlFiR0YwWm05eWJWUmxjM1JPWlhRdWNtVm5hWE4wWlhKSmJuWmxjM1J2Y2locGJuWmxjM1J2Y2xSNWNHVTZJR0o1ZEdWekxDQnlhWE5yVEdWMlpXdzZJSFZwYm5RMk5Da2dMVDRnWW5sMFpYTTZDbkpsWjJsemRHVnlTVzUyWlhOMGIzSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6YldGeWRHTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16RUtJQ0FnSUM4dklISmxaMmx6ZEdWeVNXNTJaWE4wYjNJb2FXNTJaWE4wYjNKVWVYQmxPaUJ6ZEhKcGJtY3NJSEpwYzJ0TVpYWmxiRG9nZFdsdWREWTBLVG9nYzNSeWFXNW5JSHNLSUNBZ0lIQnliM1J2SURJZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZjMjFoY25SamIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNekNpQWdJQ0F2THlCcFppQW9jbWx6YTB4bGRtVnNJRHdnTVNCOGZDQnlhWE5yVEdWMlpXd2dQaUF4TUNrZ2V3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdQQW9nSUNBZ1ltNTZJSEpsWjJsemRHVnlTVzUyWlhOMGIzSmZhV1pmWW05a2VVQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhCMWMyaHBiblFnTVRBZ0x5OGdNVEFLSUNBZ0lENEtJQ0FnSUdKNklISmxaMmx6ZEdWeVNXNTJaWE4wYjNKZllXWjBaWEpmYVdaZlpXeHpaVUF6Q2dweVpXZHBjM1JsY2tsdWRtVnpkRzl5WDJsbVgySnZaSGxBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTnRZWEowWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TkFvZ0lDQWdMeThnY21WMGRYSnVJQ2RTYVhOcklHeGxkbVZzSUcxMWMzUWdZbVVnWW1WMGQyVmxiaUF4SUdGdVpDQXhNQ2NLSUNBZ0lIQjFjMmhpZVhSbGN5QWlVbWx6YXlCc1pYWmxiQ0J0ZFhOMElHSmxJR0psZEhkbFpXNGdNU0JoYm1RZ01UQWlDaUFnSUNCeVpYUnpkV0lLQ25KbFoybHpkR1Z5U1c1MlpYTjBiM0pmWVdaMFpYSmZhV1pmWld4elpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzIxaGNuUmpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVUtJQ0FnSUM4dklIUnZkR0ZzU1c1MlpYTjBiM0p6SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOaUF2THlBaWRHOTBZV3hKYm5abGMzUnZjbk1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzIxaGNuUmpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTRDaUFnSUNBdkx5QjBhR2x6TG5SdmRHRnNTVzUyWlhOMGIzSnpMblpoYkhWbElEMGdkR2hwY3k1MGIzUmhiRWx1ZG1WemRHOXljeTUyWVd4MVpTQXJJREVLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOXpiV0Z5ZEdOdmJuUnlZV04wTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlFvZ0lDQWdMeThnZEc5MFlXeEpiblpsYzNSdmNuTWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrS0lDQWdJR0o1ZEdWaklEWWdMeThnSW5SdmRHRnNTVzUyWlhOMGIzSnpJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzIxaGNuUmpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTRDaUFnSUNBdkx5QjBhR2x6TG5SdmRHRnNTVzUyWlhOMGIzSnpMblpoYkhWbElEMGdkR2hwY3k1MGIzUmhiRWx1ZG1WemRHOXljeTUyWVd4MVpTQXJJREVLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5emJXRnlkR052Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOREFLSUNBZ0lDOHZJSEpsZEhWeWJpQW5TVzUyWlhOMGIzSWdjbVZuYVhOMFpYSmxaQ0J6ZFdOalpYTnpablZzYkhrbkNpQWdJQ0J3ZFhOb1lubDBaWE1nSWtsdWRtVnpkRzl5SUhKbFoybHpkR1Z5WldRZ2MzVmpZMlZ6YzJaMWJHeDVJZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzIxaGNuUmpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEJiR2R2UTNKbFpHbDBVR3hoZEdadmNtMVVaWE4wVG1WMExuSmxaMmx6ZEdWeVFYQnBTMlY1S0hkaGJHeGxkRUZrWkhKbGMzTTZJR0o1ZEdWekxDQmhjR2xMWlhsSVlYTm9PaUJpZVhSbGN5d2dkR2xsY2pvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dweVpXZHBjM1JsY2tGd2FVdGxlVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOZ29nSUNBZ0x5OGdjbVZuYVhOMFpYSkJjR2xMWlhrb2QyRnNiR1YwUVdSa2NtVnpjem9nYzNSeWFXNW5MQ0JoY0dsTFpYbElZWE5vT2lCemRISnBibWNzSUhScFpYSTZJSE4wY21sdVp5azZJSE4wY21sdVp5QjdDaUFnSUNCd2NtOTBieUF6SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTnRZWEowWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlFvZ0lDQWdMeThnZEc5MFlXeEJjR2xMWlhseklEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwSUM4dklGUnZkR0ZzSUVGUVNTQnJaWGx6SUdkbGJtVnlZWFJsWkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJblJ2ZEdGc1FYQnBTMlY1Y3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5emJXRnlkR052Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORGdLSUNBZ0lDOHZJSFJvYVhNdWRHOTBZV3hCY0dsTFpYbHpMblpoYkhWbElEMGdkR2hwY3k1MGIzUmhiRUZ3YVV0bGVYTXVkbUZzZFdVZ0t5QXhDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZmMyMWhjblJqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxQ2lBZ0lDQXZMeUIwYjNSaGJFRndhVXRsZVhNZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tnTHk4Z1ZHOTBZV3dnUVZCSklHdGxlWE1nWjJWdVpYSmhkR1ZrQ2lBZ0lDQmllWFJsWXlBNElDOHZJQ0owYjNSaGJFRndhVXRsZVhNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOXpiV0Z5ZEdOdmJuUnlZV04wTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRnS0lDQWdJQzh2SUhSb2FYTXVkRzkwWVd4QmNHbExaWGx6TG5aaGJIVmxJRDBnZEdocGN5NTBiM1JoYkVGd2FVdGxlWE11ZG1Gc2RXVWdLeUF4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZmMyMWhjblJqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV4Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdKMEZRU1NCclpYa2djbVZuYVhOMFpYSmxaQ0JtYjNJZ2QyRnNiR1YwT2lBbklDc2dkMkZzYkdWMFFXUmtjbVZ6Y3lBcklDY2dkR2xsY2pvZ0p5QXJJSFJwWlhJS0lDQWdJSEIxYzJoaWVYUmxjeUFpUVZCSklHdGxlU0J5WldkcGMzUmxjbVZrSUdadmNpQjNZV3hzWlhRNklDSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpQjBhV1Z5T2lBaUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6YldGeWRHTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rRnNaMjlEY21Wa2FYUlFiR0YwWm05eWJWUmxjM1JPWlhRdVoyVjBRWEJwUzJWNVEyOTFiblFvS1NBdFBpQjFhVzUwTmpRNkNtZGxkRUZ3YVV0bGVVTnZkVzUwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZmMyMWhjblJqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxQ2lBZ0lDQXZMeUIwYjNSaGJFRndhVXRsZVhNZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tnTHk4Z1ZHOTBZV3dnUVZCSklHdGxlWE1nWjJWdVpYSmhkR1ZrQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nT0NBdkx5QWlkRzkwWVd4QmNHbExaWGx6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFPQW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11ZEc5MFlXeEJjR2xMWlhsekxuWmhiSFZsQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5emJXRnlkR052Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa0ZzWjI5RGNtVmthWFJRYkdGMFptOXliVlJsYzNST1pYUXVjbVZuYVhOMFpYSlRkR0Z5ZEhWd0tITjBZWEowZFhCT1lXMWxPaUJpZVhSbGN5d2dhVzVrZFhOMGNuazZJR0o1ZEdWekxDQnlaWEYxWlhOMFpXUkJiVzkxYm5RNklIVnBiblEyTkNrZ0xUNGdZbmwwWlhNNkNuSmxaMmx6ZEdWeVUzUmhjblIxY0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTnRZWEowWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTVFvZ0lDQWdMeThnY21WbmFYTjBaWEpUZEdGeWRIVndLSE4wWVhKMGRYQk9ZVzFsT2lCemRISnBibWNzSUdsdVpIVnpkSEo1T2lCemRISnBibWNzSUhKbGNYVmxjM1JsWkVGdGIzVnVkRG9nZFdsdWREWTBLVG9nYzNSeWFXNW5JSHNLSUNBZ0lIQnliM1J2SURNZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZjMjFoY25SamIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjekNpQWdJQ0F2THlCcFppQW9jbVZ4ZFdWemRHVmtRVzF2ZFc1MElEd2dNVEF3TURBd01Da2dld29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGJuUmpYeklnTHk4Z01UQXdNREF3TUFvZ0lDQWdQQW9nSUNBZ1lub2djbVZuYVhOMFpYSlRkR0Z5ZEhWd1gyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZmMyMWhjblJqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamMwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdKMDFwYm1sdGRXMGdiRzloYmlCeVpYRjFaWE4wSUdseklERWdRVXhIVHljS0lDQWdJSEIxYzJoaWVYUmxjeUFpVFdsdWFXMTFiU0JzYjJGdUlISmxjWFZsYzNRZ2FYTWdNU0JCVEVkUElnb2dJQ0FnY21WMGMzVmlDZ3B5WldkcGMzUmxjbE4wWVhKMGRYQmZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZjMjFoY25SamIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjNENpQWdJQ0F2THlCcFppQW9jbVZ4ZFdWemRHVmtRVzF2ZFc1MElENGdNVEF3TURBd01EQXdNQ2tnZXdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqSURRZ0x5OGdNVEF3TURBd01EQXdNQW9nSUNBZ1Bnb2dJQ0FnWW5vZ2NtVm5hWE4wWlhKVGRHRnlkSFZ3WDJGbWRHVnlYMmxtWDJWc2MyVkFOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzIxaGNuUmpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzVDaUFnSUNBdkx5QnlaWFIxY200Z0owMWhlR2x0ZFcwZ2JHOWhiaUJ5WlhGMVpYTjBJR2x6SURFd01EQWdRVXhIVHljS0lDQWdJSEIxYzJoaWVYUmxjeUFpVFdGNGFXMTFiU0JzYjJGdUlISmxjWFZsYzNRZ2FYTWdNVEF3TUNCQlRFZFBJZ29nSUNBZ2NtVjBjM1ZpQ2dweVpXZHBjM1JsY2xOMFlYSjBkWEJmWVdaMFpYSmZhV1pmWld4elpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzIxaGNuUmpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWUtJQ0FnSUM4dklIUnZkR0ZzVTNSaGNuUjFjSE1nUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKMGIzUmhiRk4wWVhKMGRYQnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM050WVhKMFkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE13b2dJQ0FnTHk4Z2RHaHBjeTUwYjNSaGJGTjBZWEowZFhCekxuWmhiSFZsSUQwZ2RHaHBjeTUwYjNSaGJGTjBZWEowZFhCekxuWmhiSFZsSUNzZ01Rb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJDaUFnSUNBdkx5QjBiM1JoYkZOMFlYSjBkWEJ6SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BDaUFnSUNCaWVYUmxZeUEzSUM4dklDSjBiM1JoYkZOMFlYSjBkWEJ6SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZmMyMWhjblJqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamd6Q2lBZ0lDQXZMeUIwYUdsekxuUnZkR0ZzVTNSaGNuUjFjSE11ZG1Gc2RXVWdQU0IwYUdsekxuUnZkR0ZzVTNSaGNuUjFjSE11ZG1Gc2RXVWdLeUF4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZmMyMWhjblJqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamcxQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdKMU4wWVhKMGRYQWdjbVZuYVhOMFpYSmxaQ0J6ZFdOalpYTnpablZzYkhrNklDY2dLeUJ6ZEdGeWRIVndUbUZ0WlNBcklDY2dhVzRnSnlBcklHbHVaSFZ6ZEhKNUNpQWdJQ0J3ZFhOb1lubDBaWE1nSWxOMFlYSjBkWEFnY21WbmFYTjBaWEpsWkNCemRXTmpaWE56Wm5Wc2JIazZJQ0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJaUJwYmlBaUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6YldGeWRHTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rRnNaMjlEY21Wa2FYUlFiR0YwWm05eWJWUmxjM1JPWlhRdWRHOXJaVzVwZW1WVGRHRnlkSFZ3S0hOMFlYSjBkWEJPWVcxbE9pQmllWFJsY3l3Z2RHOXJaVzVRY21salpUb2dkV2x1ZERZMExDQjBiM1JoYkZOMWNIQnNlVG9nZFdsdWREWTBMQ0JwYm1SMWMzUnllVG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3AwYjJ0bGJtbDZaVk4wWVhKMGRYQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6YldGeWRHTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9URUtJQ0FnSUM4dklIUnZhMlZ1YVhwbFUzUmhjblIxY0NoemRHRnlkSFZ3VG1GdFpUb2djM1J5YVc1bkxDQjBiMnRsYmxCeWFXTmxPaUIxYVc1ME5qUXNJSFJ2ZEdGc1UzVndjR3g1T2lCMWFXNTBOalFzSUdsdVpIVnpkSEo1T2lCemRISnBibWNwT2lCemRISnBibWNnZXdvZ0lDQWdjSEp2ZEc4Z05DQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6YldGeWRHTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UTUtJQ0FnSUM4dklHbG1JQ2gwYjJ0bGJsQnlhV05sSUR3OUlEQXBJSHNLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUR3OUNpQWdJQ0JpZWlCMGIydGxibWw2WlZOMFlYSjBkWEJmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6YldGeWRHTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UUUtJQ0FnSUM4dklISmxkSFZ5YmlBblZHOXJaVzRnY0hKcFkyVWdiWFZ6ZENCaVpTQm5jbVZoZEdWeUlIUm9ZVzRnTUNjS0lDQWdJSEIxYzJoaWVYUmxjeUFpVkc5clpXNGdjSEpwWTJVZ2JYVnpkQ0JpWlNCbmNtVmhkR1Z5SUhSb1lXNGdNQ0lLSUNBZ0lISmxkSE4xWWdvS2RHOXJaVzVwZW1WVGRHRnlkSFZ3WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVOd29nSUNBZ0x5OGdhV1lnS0hSdmRHRnNVM1Z3Y0d4NUlEdzlJREFwSUhzS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lEdzlDaUFnSUNCaWVpQjBiMnRsYm1sNlpWTjBZWEowZFhCZllXWjBaWEpmYVdaZlpXeHpaVUEwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5emJXRnlkR052Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVGdLSUNBZ0lDOHZJSEpsZEhWeWJpQW5WRzkwWVd3Z2MzVndjR3g1SUcxMWMzUWdZbVVnWjNKbFlYUmxjaUIwYUdGdUlEQW5DaUFnSUNCd2RYTm9ZbmwwWlhNZ0lsUnZkR0ZzSUhOMWNIQnNlU0J0ZFhOMElHSmxJR2R5WldGMFpYSWdkR2hoYmlBd0lnb2dJQ0FnY21WMGMzVmlDZ3AwYjJ0bGJtbDZaVk4wWVhKMGRYQmZZV1owWlhKZmFXWmZaV3h6WlVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZjMjFoY25SamIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjS0lDQWdJQzh2SUhSdmRHRnNWRzlyWlc1cGVtVmtVM1JoY25SMWNITWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBNUlDOHZJQ0owYjNSaGJGUnZhMlZ1YVhwbFpGTjBZWEowZFhCeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTnRZWEowWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURJS0lDQWdJQzh2SUhSb2FYTXVkRzkwWVd4VWIydGxibWw2WldSVGRHRnlkSFZ3Y3k1MllXeDFaU0E5SUhSb2FYTXVkRzkwWVd4VWIydGxibWw2WldSVGRHRnlkSFZ3Y3k1MllXeDFaU0FySURFS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6YldGeWRHTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk53b2dJQ0FnTHk4Z2RHOTBZV3hVYjJ0bGJtbDZaV1JUZEdGeWRIVndjeUE5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tRb2dJQ0FnWW5sMFpXTWdPU0F2THlBaWRHOTBZV3hVYjJ0bGJtbDZaV1JUZEdGeWRIVndjeUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRElLSUNBZ0lDOHZJSFJvYVhNdWRHOTBZV3hVYjJ0bGJtbDZaV1JUZEdGeWRIVndjeTUyWVd4MVpTQTlJSFJvYVhNdWRHOTBZV3hVYjJ0bGJtbDZaV1JUZEdGeWRIVndjeTUyWVd4MVpTQXJJREVLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5emJXRnlkR052Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEEwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdKMU4wWVhKMGRYQWdkRzlyWlc1cGVtVmtJSE4xWTJObGMzTm1kV3hzZVRvZ0p5QXJJSE4wWVhKMGRYQk9ZVzFsQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbE4wWVhKMGRYQWdkRzlyWlc1cGVtVmtJSE4xWTJObGMzTm1kV3hzZVRvZ0lnb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM050WVhKMFkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlFXeG5iME55WldScGRGQnNZWFJtYjNKdFZHVnpkRTVsZEM1eVpYRjFaWE4wVEc5aGJpaGhiVzkxYm5RNklIVnBiblEyTkN3Z1pIVnlZWFJwYjI0NklIVnBiblEyTkN3Z2FXNTBaWEpsYzNSU1lYUmxPaUIxYVc1ME5qUXBJQzArSUdKNWRHVnpPZ3B5WlhGMVpYTjBURzloYmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTnRZWEowWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRBS0lDQWdJQzh2SUhKbGNYVmxjM1JNYjJGdUtHRnRiM1Z1ZERvZ2RXbHVkRFkwTENCa2RYSmhkR2x2YmpvZ2RXbHVkRFkwTENCcGJuUmxjbVZ6ZEZKaGRHVTZJSFZwYm5RMk5DazZJSE4wY21sdVp5QjdDaUFnSUNCd2NtOTBieUF6SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTnRZWEowWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkFvZ0lDQWdMeThnWTI5dWRISmhZM1JCWTNScGRtVWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrZ0x5OGdNU0E5SUdGamRHbDJaU3dnTUNBOUlHbHVZV04wYVhabENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWTI5dWRISmhZM1JCWTNScGRtVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZjMjFoY25SamIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE1nb2dJQ0FnTHk4Z2FXWWdLSFJvYVhNdVkyOXVkSEpoWTNSQlkzUnBkbVV1ZG1Gc2RXVWdQVDA5SURBcElIc0tJQ0FnSUdKdWVpQnlaWEYxWlhOMFRHOWhibDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM050WVhKMFkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1UTUtJQ0FnSUM4dklISmxkSFZ5YmlBblVHeGhkR1p2Y20wZ2FYTWdZM1Z5Y21WdWRHeDVJR2x1WVdOMGFYWmxKd29nSUNBZ1lubDBaV01nTVRNZ0x5OGdJbEJzWVhSbWIzSnRJR2x6SUdOMWNuSmxiblJzZVNCcGJtRmpkR2wyWlNJS0lDQWdJSEpsZEhOMVlnb0tjbVZ4ZFdWemRFeHZZVzVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzIxaGNuUmpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhOd29nSUNBZ0x5OGdhV1lnS0dGdGIzVnVkQ0E4SURFd01EQXdNREFwSUhzS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdhVzUwWTE4eUlDOHZJREV3TURBd01EQUtJQ0FnSUR3S0lDQWdJR0o2SUhKbGNYVmxjM1JNYjJGdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZmMyMWhjblJqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4T0FvZ0lDQWdMeThnY21WMGRYSnVJQ2ROYVc1cGJYVnRJR3h2WVc0Z1lXMXZkVzUwSUdseklERWdRVXhIVHljS0lDQWdJSEIxYzJoaWVYUmxjeUFpVFdsdWFXMTFiU0JzYjJGdUlHRnRiM1Z1ZENCcGN5QXhJRUZNUjA4aUNpQWdJQ0J5WlhSemRXSUtDbkpsY1hWbGMzUk1iMkZ1WDJGbWRHVnlYMmxtWDJWc2MyVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNakVLSUNBZ0lDOHZJR2xtSUNoaGJXOTFiblFnUGlBeE1EQXdNREF3TURBd0tTQjdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdsdWRHTWdOQ0F2THlBeE1EQXdNREF3TURBd0NpQWdJQ0ErQ2lBZ0lDQmllaUJ5WlhGMVpYTjBURzloYmw5aFpuUmxjbDlwWmw5bGJITmxRRFlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNaklLSUNBZ0lDOHZJSEpsZEhWeWJpQW5UV0Y0YVcxMWJTQnNiMkZ1SUdGdGIzVnVkQ0JwY3lBeE1EQXdJRUZNUjA4bkNpQWdJQ0J3ZFhOb1lubDBaWE1nSWsxaGVHbHRkVzBnYkc5aGJpQmhiVzkxYm5RZ2FYTWdNVEF3TUNCQlRFZFBJZ29nSUNBZ2NtVjBjM1ZpQ2dweVpYRjFaWE4wVEc5aGJsOWhablJsY2w5cFpsOWxiSE5sUURZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOXpiV0Z5ZEdOdmJuUnlZV04wTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJMkNpQWdJQ0F2THlCcFppQW9aSFZ5WVhScGIyNGdQQ0F4SUh4OElHUjFjbUYwYVc5dUlENGdOakFwSUhzS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lEd0tJQ0FnSUdKdWVpQnlaWEYxWlhOMFRHOWhibDlwWmw5aWIyUjVRRGdLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2NIVnphR2x1ZENBMk1DQXZMeUEyTUFvZ0lDQWdQZ29nSUNBZ1lub2djbVZ4ZFdWemRFeHZZVzVmWVdaMFpYSmZhV1pmWld4elpVQTVDZ3B5WlhGMVpYTjBURzloYmw5cFpsOWliMlI1UURnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOXpiV0Z5ZEdOdmJuUnlZV04wTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJM0NpQWdJQ0F2THlCeVpYUjFjbTRnSjB4dllXNGdaSFZ5WVhScGIyNGdiWFZ6ZENCaVpTQmlaWFIzWldWdUlERXROakFnYlc5dWRHaHpKd29nSUNBZ2NIVnphR0o1ZEdWeklDSk1iMkZ1SUdSMWNtRjBhVzl1SUcxMWMzUWdZbVVnWW1WMGQyVmxiaUF4TFRZd0lHMXZiblJvY3lJS0lDQWdJSEpsZEhOMVlnb0tjbVZ4ZFdWemRFeHZZVzVmWVdaMFpYSmZhV1pmWld4elpVQTVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzIxaGNuUmpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpNUW9nSUNBZ0x5OGdhV1lnS0dsdWRHVnlaWE4wVW1GMFpTQThJREVnZkh3Z2FXNTBaWEpsYzNSU1lYUmxJRDRnTXpBcElIc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJRHdLSUNBZ0lHSnVlaUJ5WlhGMVpYTjBURzloYmw5cFpsOWliMlI1UURFeENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEIxYzJocGJuUWdNekFnTHk4Z016QUtJQ0FnSUQ0S0lDQWdJR0o2SUhKbGNYVmxjM1JNYjJGdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRJS0NuSmxjWFZsYzNSTWIyRnVYMmxtWDJKdlpIbEFNVEU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5emJXRnlkR052Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE15Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdKMGx1ZEdWeVpYTjBJSEpoZEdVZ2JYVnpkQ0JpWlNCaVpYUjNaV1Z1SURFdE16QWxKd29nSUNBZ2NIVnphR0o1ZEdWeklDSkpiblJsY21WemRDQnlZWFJsSUcxMWMzUWdZbVVnWW1WMGQyVmxiaUF4TFRNd0pTSUtJQ0FnSUhKbGRITjFZZ29LY21WeGRXVnpkRXh2WVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTnRZWEowWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TUFvZ0lDQWdMeThnZEc5MFlXeE1iMkZ1VW1WeGRXVnpkSE1nUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXhNQ0F2THlBaWRHOTBZV3hNYjJGdVVtVnhkV1Z6ZEhNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZmMyMWhjblJqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6TmdvZ0lDQWdMeThnZEdocGN5NTBiM1JoYkV4dllXNVNaWEYxWlhOMGN5NTJZV3gxWlNBOUlIUm9hWE11ZEc5MFlXeE1iMkZ1VW1WeGRXVnpkSE11ZG1Gc2RXVWdLeUF4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZjMjFoY25SamIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd0NpQWdJQ0F2THlCMGIzUmhiRXh2WVc1U1pYRjFaWE4wY3lBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LUW9nSUNBZ1lubDBaV01nTVRBZ0x5OGdJblJ2ZEdGc1RHOWhibEpsY1hWbGMzUnpJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzIxaGNuUmpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpOZ29nSUNBZ0x5OGdkR2hwY3k1MGIzUmhiRXh2WVc1U1pYRjFaWE4wY3k1MllXeDFaU0E5SUhSb2FYTXVkRzkwWVd4TWIyRnVVbVZ4ZFdWemRITXVkbUZzZFdVZ0t5QXhDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzIxaGNuUmpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpPQW9nSUNBZ0x5OGdjbVYwZFhKdUlDZE1iMkZ1SUhKbGNYVmxjM1FnWTNKbFlYUmxaQ0J6ZFdOalpYTnpablZzYkhrbkNpQWdJQ0J3ZFhOb1lubDBaWE1nSWt4dllXNGdjbVZ4ZFdWemRDQmpjbVZoZEdWa0lITjFZMk5sYzNObWRXeHNlU0lLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZRV3huYjBOeVpXUnBkRkJzWVhSbWIzSnRWR1Z6ZEU1bGRDNW5aWFJKYm5abGMzUnZja052ZFc1MEtDa2dMVDRnZFdsdWREWTBPZ3BuWlhSSmJuWmxjM1J2Y2tOdmRXNTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzIxaGNuUmpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVUtJQ0FnSUM4dklIUnZkR0ZzU1c1MlpYTjBiM0p6SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOaUF2THlBaWRHOTBZV3hKYm5abGMzUnZjbk1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzIxaGNuUmpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTBOZ29nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11ZEc5MFlXeEpiblpsYzNSdmNuTXVkbUZzZFdVS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTnRZWEowWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UVd4bmIwTnlaV1JwZEZCc1lYUm1iM0p0VkdWemRFNWxkQzVuWlhSVGRHRnlkSFZ3UTI5MWJuUW9LU0F0UGlCMWFXNTBOalE2Q21kbGRGTjBZWEowZFhCRGIzVnVkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJDaUFnSUNBdkx5QjBiM1JoYkZOMFlYSjBkWEJ6SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOeUF2THlBaWRHOTBZV3hUZEdGeWRIVndjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6YldGeWRHTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVTBDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTUwYjNSaGJGTjBZWEowZFhCekxuWmhiSFZsQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5emJXRnlkR052Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa0ZzWjI5RGNtVmthWFJRYkdGMFptOXliVlJsYzNST1pYUXVaMlYwVkc5clpXNXBlbVZrVTNSaGNuUjFjSE5EYjNWdWRDZ3BJQzArSUhWcGJuUTJORG9LWjJWMFZHOXJaVzVwZW1Wa1UzUmhjblIxY0hORGIzVnVkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNDaUFnSUNBdkx5QjBiM1JoYkZSdmEyVnVhWHBsWkZOMFlYSjBkWEJ6SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdPU0F2THlBaWRHOTBZV3hVYjJ0bGJtbDZaV1JUZEdGeWRIVndjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6YldGeWRHTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UWXlDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTUwYjNSaGJGUnZhMlZ1YVhwbFpGTjBZWEowZFhCekxuWmhiSFZsQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5emJXRnlkR052Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa0ZzWjI5RGNtVmthWFJRYkdGMFptOXliVlJsYzNST1pYUXVaMlYwVkc5MFlXeEpiblpsYzNSdFpXNTBjME52ZFc1MEtDa2dMVDRnZFdsdWREWTBPZ3BuWlhSVWIzUmhiRWx1ZG1WemRHMWxiblJ6UTI5MWJuUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6YldGeWRHTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USUtJQ0FnSUM4dklIUnZkR0ZzU1c1MlpYTjBiV1Z1ZEhNZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TVNBdkx5QWlkRzkwWVd4SmJuWmxjM1J0Wlc1MGN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOXpiV0Z5ZEdOdmJuUnlZV04wTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRjd0NpQWdJQ0F2THlCeVpYUjFjbTRnZEdocGN5NTBiM1JoYkVsdWRtVnpkRzFsYm5SekxuWmhiSFZsQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5emJXRnlkR052Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa0ZzWjI5RGNtVmthWFJRYkdGMFptOXliVlJsYzNST1pYUXVaMlYwVEc5aGJsSmxjWFZsYzNSRGIzVnVkQ2dwSUMwK0lIVnBiblEyTkRvS1oyVjBURzloYmxKbGNYVmxjM1JEYjNWdWREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM050WVhKMFkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1Bb2dJQ0FnTHk4Z2RHOTBZV3hNYjJGdVVtVnhkV1Z6ZEhNZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QWlkRzkwWVd4TWIyRnVVbVZ4ZFdWemRITWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZjMjFoY25SamIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFM09Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVkRzkwWVd4TWIyRnVVbVZ4ZFdWemRITXVkbUZzZFdVS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTnRZWEowWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UVd4bmIwTnlaV1JwZEZCc1lYUm1iM0p0VkdWemRFNWxkQzVwYm5abGMzUkpibE4wWVhKMGRYQW9jM1JoY25SMWNFbGtPaUIxYVc1ME5qUXNJR2x1ZG1WemRHMWxiblJCYlc5MWJuUTZJSFZwYm5RMk5Dd2dkRzlyWlc1QmJXOTFiblE2SUhWcGJuUTJOQ2tnTFQ0Z1lubDBaWE02Q21sdWRtVnpkRWx1VTNSaGNuUjFjRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPRFFLSUNBZ0lDOHZJR2x1ZG1WemRFbHVVM1JoY25SMWNDaHpkR0Z5ZEhWd1NXUTZJSFZwYm5RMk5Dd2dhVzUyWlhOMGJXVnVkRUZ0YjNWdWREb2dkV2x1ZERZMExDQjBiMnRsYmtGdGIzVnVkRG9nZFdsdWREWTBLVG9nYzNSeWFXNW5JSHNLSUNBZ0lIQnliM1J2SURNZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZjMjFoY25SamIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNE5nb2dJQ0FnTHk4Z2FXWWdLR2x1ZG1WemRHMWxiblJCYlc5MWJuUWdQRDBnTUNrZ2V3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdQRDBLSUNBZ0lHSjZJR2x1ZG1WemRFbHVVM1JoY25SMWNGOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTnRZWEowWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T0RjS0lDQWdJQzh2SUhKbGRIVnliaUFuU1c1MlpYTjBiV1Z1ZENCaGJXOTFiblFnYlhWemRDQmlaU0JuY21WaGRHVnlJSFJvWVc0Z01DY0tJQ0FnSUdKNWRHVmpJREUwSUM4dklDSkpiblpsYzNSdFpXNTBJR0Z0YjNWdWRDQnRkWE4wSUdKbElHZHlaV0YwWlhJZ2RHaGhiaUF3SWdvZ0lDQWdjbVYwYzNWaUNncHBiblpsYzNSSmJsTjBZWEowZFhCZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZmMyMWhjblJqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU1TUFvZ0lDQWdMeThnYVdZZ0tIUnZhMlZ1UVcxdmRXNTBJRHc5SURBcElIc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJRHc5Q2lBZ0lDQmllaUJwYm5abGMzUkpibE4wWVhKMGRYQmZZV1owWlhKZmFXWmZaV3h6WlVBMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOXpiV0Z5ZEdOdmJuUnlZV04wTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRreENpQWdJQ0F2THlCeVpYUjFjbTRnSjFSdmEyVnVJR0Z0YjNWdWRDQnRkWE4wSUdKbElHZHlaV0YwWlhJZ2RHaGhiaUF3SndvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pVYjJ0bGJpQmhiVzkxYm5RZ2JYVnpkQ0JpWlNCbmNtVmhkR1Z5SUhSb1lXNGdNQ0lLSUNBZ0lISmxkSE4xWWdvS2FXNTJaWE4wU1c1VGRHRnlkSFZ3WDJGbWRHVnlYMmxtWDJWc2MyVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPVFFLSUNBZ0lDOHZJR2xtSUNoemRHRnlkSFZ3U1dRZ1BEMGdNQ2tnZXdvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1BEMEtJQ0FnSUdKNklHbHVkbVZ6ZEVsdVUzUmhjblIxY0Y5aFpuUmxjbDlwWmw5bGJITmxRRFlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPVFVLSUNBZ0lDOHZJSEpsZEhWeWJpQW5TVzUyWVd4cFpDQnpkR0Z5ZEhWd0lFbEVKd29nSUNBZ2NIVnphR0o1ZEdWeklDSkpiblpoYkdsa0lITjBZWEowZFhBZ1NVUWlDaUFnSUNCeVpYUnpkV0lLQ21sdWRtVnpkRWx1VTNSaGNuUjFjRjloWm5SbGNsOXBabDlsYkhObFFEWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6YldGeWRHTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUUtJQ0FnSUM4dklHTnZiblJ5WVdOMFFXTjBhWFpsSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BJQzh2SURFZ1BTQmhZM1JwZG1Vc0lEQWdQU0JwYm1GamRHbDJaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltTnZiblJ5WVdOMFFXTjBhWFpsSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPVGtLSUNBZ0lDOHZJR2xtSUNoMGFHbHpMbU52Ym5SeVlXTjBRV04wYVhabExuWmhiSFZsSUQwOVBTQXdLU0I3Q2lBZ0lDQmlibm9nYVc1MlpYTjBTVzVUZEdGeWRIVndYMkZtZEdWeVgybG1YMlZzYzJWQU9Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZjMjFoY25SamIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJd01Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUNkUWJHRjBabTl5YlNCcGN5QmpkWEp5Wlc1MGJIa2dhVzVoWTNScGRtVW5DaUFnSUNCaWVYUmxZeUF4TXlBdkx5QWlVR3hoZEdadmNtMGdhWE1nWTNWeWNtVnVkR3g1SUdsdVlXTjBhWFpsSWdvZ0lDQWdjbVYwYzNWaUNncHBiblpsYzNSSmJsTjBZWEowZFhCZllXWjBaWEpmYVdaZlpXeHpaVUE0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZmMyMWhjblJqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5Q2lBZ0lDQXZMeUIwYjNSaGJFbHVkbVZ6ZEcxbGJuUnpJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01URWdMeThnSW5SdmRHRnNTVzUyWlhOMGJXVnVkSE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzIxaGNuUmpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXdOQW9nSUNBZ0x5OGdkR2hwY3k1MGIzUmhiRWx1ZG1WemRHMWxiblJ6TG5aaGJIVmxJRDBnZEdocGN5NTBiM1JoYkVsdWRtVnpkRzFsYm5SekxuWmhiSFZsSUNzZ01Rb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNZ29nSUNBZ0x5OGdkRzkwWVd4SmJuWmxjM1J0Wlc1MGN5QTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1FvZ0lDQWdZbmwwWldNZ01URWdMeThnSW5SdmRHRnNTVzUyWlhOMGJXVnVkSE1pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5emJXRnlkR052Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakEwQ2lBZ0lDQXZMeUIwYUdsekxuUnZkR0ZzU1c1MlpYTjBiV1Z1ZEhNdWRtRnNkV1VnUFNCMGFHbHpMblJ2ZEdGc1NXNTJaWE4wYldWdWRITXVkbUZzZFdVZ0t5QXhDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzIxaGNuUmpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qa0tJQ0FnSUM4dklIUnZkR0ZzUm5WdVpITkpiblpsYzNSbFpDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblJ2ZEdGc1JuVnVaSE5KYm5abGMzUmxaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6YldGeWRHTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qQTFDaUFnSUNBdkx5QjBhR2x6TG5SdmRHRnNSblZ1WkhOSmJuWmxjM1JsWkM1MllXeDFaU0E5SUhSb2FYTXVkRzkwWVd4R2RXNWtjMGx1ZG1WemRHVmtMblpoYkhWbElDc2dhVzUyWlhOMGJXVnVkRUZ0YjNWdWRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0FyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5emJXRnlkR052Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPUW9nSUNBZ0x5OGdkRzkwWVd4R2RXNWtjMGx1ZG1WemRHVmtJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMGIzUmhiRVoxYm1SelNXNTJaWE4wWldRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOXpiV0Z5ZEdOdmJuUnlZV04wTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpBMUNpQWdJQ0F2THlCMGFHbHpMblJ2ZEdGc1JuVnVaSE5KYm5abGMzUmxaQzUyWVd4MVpTQTlJSFJvYVhNdWRHOTBZV3hHZFc1a2MwbHVkbVZ6ZEdWa0xuWmhiSFZsSUNzZ2FXNTJaWE4wYldWdWRFRnRiM1Z1ZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTnRZWEowWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXdvZ0lDQWdMeThnY0d4aGRHWnZjbTFHWldWeklEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWljR3hoZEdadmNtMUdaV1Z6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNRGdLSUNBZ0lDOHZJSFJvYVhNdWNHeGhkR1p2Y20xR1pXVnpMblpoYkhWbElEMGdkR2hwY3k1d2JHRjBabTl5YlVabFpYTXVkbUZzZFdVZ0t5QW9hVzUyWlhOMGJXVnVkRUZ0YjNWdWRDQXZJRFV3S1FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdOVEFLSUNBZ0lDOEtJQ0FnSUNzS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTnRZWEowWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXdvZ0lDQWdMeThnY0d4aGRHWnZjbTFHWldWeklEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p3YkdGMFptOXliVVpsWlhNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOXpiV0Z5ZEdOdmJuUnlZV04wTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpBNENpQWdJQ0F2THlCMGFHbHpMbkJzWVhSbWIzSnRSbVZsY3k1MllXeDFaU0E5SUhSb2FYTXVjR3hoZEdadmNtMUdaV1Z6TG5aaGJIVmxJQ3NnS0dsdWRtVnpkRzFsYm5SQmJXOTFiblFnTHlBMU1Da0tJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6YldGeWRHTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qRXdDaUFnSUNBdkx5QnlaWFIxY200Z0owbHVkbVZ6ZEcxbGJuUWdjM1ZqWTJWemMyWjFiQ0JwYmlCemRHRnlkSFZ3SndvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pKYm5abGMzUnRaVzUwSUhOMVkyTmxjM05tZFd3Z2FXNGdjM1JoY25SMWNDSUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM050WVhKMFkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlFXeG5iME55WldScGRGQnNZWFJtYjNKdFZHVnpkRTVsZEM1eVpXRnNSR1Z3YjNOcGRDZ3BJQzArSUdKNWRHVnpPZ3B5WldGc1JHVndiM05wZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTnRZWEowWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80Q2lBZ0lDQXZMeUIwYjNSaGJFWjFibVJ6UkdWd2IzTnBkR1ZrSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWRHOTBZV3hHZFc1a2MwUmxjRzl6YVhSbFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOXpiV0Z5ZEdOdmJuUnlZV04wTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpJMUNpQWdJQ0F2THlCMGFHbHpMblJ2ZEdGc1JuVnVaSE5FWlhCdmMybDBaV1F1ZG1Gc2RXVWdQU0IwYUdsekxuUnZkR0ZzUm5WdVpITkVaWEJ2YzJsMFpXUXVkbUZzZFdVZ0t5QXhNREF3TURBd0NpQWdJQ0JwYm5Salh6SWdMeThnTVRBd01EQXdNQW9nSUNBZ0t3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZjMjFoY25SamIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnS0lDQWdJQzh2SUhSdmRHRnNSblZ1WkhORVpYQnZjMmwwWldRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJblJ2ZEdGc1JuVnVaSE5FWlhCdmMybDBaV1FpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5emJXRnlkR052Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakkxQ2lBZ0lDQXZMeUIwYUdsekxuUnZkR0ZzUm5WdVpITkVaWEJ2YzJsMFpXUXVkbUZzZFdVZ1BTQjBhR2x6TG5SdmRHRnNSblZ1WkhORVpYQnZjMmwwWldRdWRtRnNkV1VnS3lBeE1EQXdNREF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZmMyMWhjblJqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl5TndvZ0lDQWdMeThnY21WMGRYSnVJQ2RTWldGc0lHUmxjRzl6YVhRZ2NISnZZMlZ6YzJWa09pQXhJRUZNUjA4bkNpQWdJQ0J3ZFhOb1lubDBaWE1nSWxKbFlXd2daR1Z3YjNOcGRDQndjbTlqWlhOelpXUTZJREVnUVV4SFR5SUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM050WVhKMFkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlFXeG5iME55WldScGRGQnNZWFJtYjNKdFZHVnpkRTVsZEM1emFXMTFiR0YwWlVSbGNHOXphWFFvWVcxdmRXNTBPaUIxYVc1ME5qUXBJQzArSUdKNWRHVnpPZ3B6YVcxMWJHRjBaVVJsY0c5emFYUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6YldGeWRHTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qTXpDaUFnSUNBdkx5QnphVzExYkdGMFpVUmxjRzl6YVhRb1lXMXZkVzUwT2lCMWFXNTBOalFwT2lCemRISnBibWNnZXdvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6YldGeWRHTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qTTFDaUFnSUNBdkx5QnBaaUFvWVcxdmRXNTBJRHc5SURBcElIc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJRHc5Q2lBZ0lDQmllaUJ6YVcxMWJHRjBaVVJsY0c5emFYUmZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOXpiV0Z5ZEdOdmJuUnlZV04wTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpNMkNpQWdJQ0F2THlCeVpYUjFjbTRnSjBGdGIzVnVkQ0J0ZFhOMElHSmxJR2R5WldGMFpYSWdkR2hoYmlBd0p3b2dJQ0FnY0hWemFHSjVkR1Z6SUNKQmJXOTFiblFnYlhWemRDQmlaU0JuY21WaGRHVnlJSFJvWVc0Z01DSUtJQ0FnSUhKbGRITjFZZ29LYzJsdGRXeGhkR1ZFWlhCdmMybDBYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM050WVhKMFkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5EQUtJQ0FnSUM4dklHbG1JQ2hoYlc5MWJuUWdQQ0F4TURBd01EQXBJSHNLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FXNTBZeUExSUM4dklERXdNREF3TUFvZ0lDQWdQQW9nSUNBZ1lub2djMmx0ZFd4aGRHVkVaWEJ2YzJsMFgyRm1kR1Z5WDJsbVgyVnNjMlZBTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZmMyMWhjblJqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkwTVFvZ0lDQWdMeThnY21WMGRYSnVJQ2ROYVc1cGJYVnRJR1JsY0c5emFYUWdhWE1nTUM0eElFRk1SMDhuQ2lBZ0lDQndkWE5vWW5sMFpYTWdJazFwYm1sdGRXMGdaR1Z3YjNOcGRDQnBjeUF3TGpFZ1FVeEhUeUlLSUNBZ0lISmxkSE4xWWdvS2MybHRkV3hoZEdWRVpYQnZjMmwwWDJGbWRHVnlYMmxtWDJWc2MyVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRDaUFnSUNBdkx5QjBiM1JoYkVaMWJtUnpSR1Z3YjNOcGRHVmtJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpZEc5MFlXeEdkVzVrYzBSbGNHOXphWFJsWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5emJXRnlkR052Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalExQ2lBZ0lDQXZMeUIwYUdsekxuUnZkR0ZzUm5WdVpITkVaWEJ2YzJsMFpXUXVkbUZzZFdVZ1BTQjBhR2x6TG5SdmRHRnNSblZ1WkhORVpYQnZjMmwwWldRdWRtRnNkV1VnS3lCaGJXOTFiblFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ0t3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZjMjFoY25SamIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnS0lDQWdJQzh2SUhSdmRHRnNSblZ1WkhORVpYQnZjMmwwWldRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJblJ2ZEdGc1JuVnVaSE5FWlhCdmMybDBaV1FpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5emJXRnlkR052Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalExQ2lBZ0lDQXZMeUIwYUdsekxuUnZkR0ZzUm5WdVpITkVaWEJ2YzJsMFpXUXVkbUZzZFdVZ1BTQjBhR2x6TG5SdmRHRnNSblZ1WkhORVpYQnZjMmwwWldRdWRtRnNkV1VnS3lCaGJXOTFiblFLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5emJXRnlkR052Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalEzQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdKMFJsY0c5emFYUWdjMmx0ZFd4aGRHVmtJSE4xWTJObGMzTm1kV3hzZVNjS0lDQWdJSEIxYzJoaWVYUmxjeUFpUkdWd2IzTnBkQ0J6YVcxMWJHRjBaV1FnYzNWalkyVnpjMloxYkd4NUlnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZjMjFoY25SamIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwQmJHZHZRM0psWkdsMFVHeGhkR1p2Y20xVVpYTjBUbVYwTG5KbFlXeFhhWFJvWkhKaGR5aGhiVzkxYm5RNklIVnBiblEyTkNrZ0xUNGdZbmwwWlhNNkNuSmxZV3hYYVhSb1pISmhkem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOVE1LSUNBZ0lDOHZJSEpsWVd4WGFYUm9aSEpoZHloaGJXOTFiblE2SUhWcGJuUTJOQ2s2SUhOMGNtbHVaeUI3Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM050WVhKMFkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5UVUtJQ0FnSUM4dklHbG1JQ2hoYlc5MWJuUWdQRDBnTUNrZ2V3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdQRDBLSUNBZ0lHSjZJSEpsWVd4WGFYUm9aSEpoZDE5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOVFlLSUNBZ0lDOHZJSEpsZEhWeWJpQW5WMmwwYUdSeVlYZGhiQ0JoYlc5MWJuUWdiWFZ6ZENCaVpTQm5jbVZoZEdWeUlIUm9ZVzRnTUNjS0lDQWdJSEIxYzJoaWVYUmxjeUFpVjJsMGFHUnlZWGRoYkNCaGJXOTFiblFnYlhWemRDQmlaU0JuY21WaGRHVnlJSFJvWVc0Z01DSUtJQ0FnSUhKbGRITjFZZ29LY21WaGJGZHBkR2hrY21GM1gyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTnRZWEowWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80Q2lBZ0lDQXZMeUIwYjNSaGJFWjFibVJ6UkdWd2IzTnBkR1ZrSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWRHOTBZV3hHZFc1a2MwUmxjRzl6YVhSbFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOXpiV0Z5ZEdOdmJuUnlZV04wTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1FvZ0lDQWdMeThnZEc5MFlXeEdkVzVrYzBsdWRtVnpkR1ZrSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWRHOTBZV3hHZFc1a2MwbHVkbVZ6ZEdWa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTnRZWEowWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TmpBS0lDQWdJQzh2SUdsbUlDaGhiVzkxYm5RZ1BpQjBhR2x6TG5SdmRHRnNSblZ1WkhORVpYQnZjMmwwWldRdWRtRnNkV1VnTFNCMGFHbHpMblJ2ZEdGc1JuVnVaSE5KYm5abGMzUmxaQzUyWVd4MVpTa2dld29nSUNBZ0xRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0E4Q2lBZ0lDQmllaUJ5WldGc1YybDBhR1J5WVhkZllXWjBaWEpmYVdaZlpXeHpaVUEwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5emJXRnlkR052Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNall4Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdKMGx1YzNWbVptbGphV1Z1ZENCamIyNTBjbUZqZENCbWRXNWtjeUJtYjNJZ2QybDBhR1J5WVhkaGJDY0tJQ0FnSUhCMWMyaGllWFJsY3lBaVNXNXpkV1ptYVdOcFpXNTBJR052Ym5SeVlXTjBJR1oxYm1SeklHWnZjaUIzYVhSb1pISmhkMkZzSWdvZ0lDQWdjbVYwYzNWaUNncHlaV0ZzVjJsMGFHUnlZWGRmWVdaMFpYSmZhV1pmWld4elpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzIxaGNuUmpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTJOUW9nSUNBZ0x5OGdhV1lnS0dGdGIzVnVkQ0E4SURFd01EQXdNQ2tnZXdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqSURVZ0x5OGdNVEF3TURBd0NpQWdJQ0E4Q2lBZ0lDQmllaUJ5WldGc1YybDBhR1J5WVhkZllXWjBaWEpmYVdaZlpXeHpaVUEyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5emJXRnlkR052Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalkyQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdKMDFwYm1sdGRXMGdkMmwwYUdSeVlYZGhiQ0JwY3lBd0xqRWdRVXhIVHljS0lDQWdJSEIxYzJoaWVYUmxjeUFpVFdsdWFXMTFiU0IzYVhSb1pISmhkMkZzSUdseklEQXVNU0JCVEVkUElnb2dJQ0FnY21WMGMzVmlDZ3B5WldGc1YybDBhR1J5WVhkZllXWjBaWEpmYVdaZlpXeHpaVUEyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZmMyMWhjblJqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamdLSUNBZ0lDOHZJSFJ2ZEdGc1JuVnVaSE5FWlhCdmMybDBaV1FnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKMGIzUmhiRVoxYm1SelJHVndiM05wZEdWa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTnRZWEowWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TnpBS0lDQWdJQzh2SUhSb2FYTXVkRzkwWVd4R2RXNWtjMFJsY0c5emFYUmxaQzUyWVd4MVpTQTlJSFJvYVhNdWRHOTBZV3hHZFc1a2MwUmxjRzl6YVhSbFpDNTJZV3gxWlNBdElHRnRiM1Z1ZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQXRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6YldGeWRHTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9Bb2dJQ0FnTHk4Z2RHOTBZV3hHZFc1a2MwUmxjRzl6YVhSbFpDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpZEc5MFlXeEdkVzVrYzBSbGNHOXphWFJsWkNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTnRZWEowWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TnpBS0lDQWdJQzh2SUhSb2FYTXVkRzkwWVd4R2RXNWtjMFJsY0c5emFYUmxaQzUyWVd4MVpTQTlJSFJvYVhNdWRHOTBZV3hHZFc1a2MwUmxjRzl6YVhSbFpDNTJZV3gxWlNBdElHRnRiM1Z1ZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTnRZWEowWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TnpVS0lDQWdJQzh2SUhKbGRIVnliaUFuVW1WaGJDQjNhWFJvWkhKaGQyRnNJSEJ5YjJObGMzTmxaQ0J6ZFdOalpYTnpablZzYkhrbkNpQWdJQ0J3ZFhOb1lubDBaWE1nSWxKbFlXd2dkMmwwYUdSeVlYZGhiQ0J3Y205alpYTnpaV1FnYzNWalkyVnpjMloxYkd4NUlnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZjMjFoY25SamIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwQmJHZHZRM0psWkdsMFVHeGhkR1p2Y20xVVpYTjBUbVYwTG5OcGJYVnNZWFJsU1c1MlpYTjBiV1Z1ZENoaGJXOTFiblE2SUhWcGJuUTJOQ2tnTFQ0Z1lubDBaWE02Q25OcGJYVnNZWFJsU1c1MlpYTjBiV1Z1ZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTnRZWEowWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T0RFS0lDQWdJQzh2SUhOcGJYVnNZWFJsU1c1MlpYTjBiV1Z1ZENoaGJXOTFiblE2SUhWcGJuUTJOQ2s2SUhOMGNtbHVaeUI3Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM050WVhKMFkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9ETUtJQ0FnSUM4dklHbG1JQ2hoYlc5MWJuUWdQRDBnTUNrZ2V3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdQRDBLSUNBZ0lHSjZJSE5wYlhWc1lYUmxTVzUyWlhOMGJXVnVkRjloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM050WVhKMFkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9EUUtJQ0FnSUM4dklISmxkSFZ5YmlBblNXNTJaWE4wYldWdWRDQmhiVzkxYm5RZ2JYVnpkQ0JpWlNCbmNtVmhkR1Z5SUhSb1lXNGdNQ2NLSUNBZ0lHSjVkR1ZqSURFMElDOHZJQ0pKYm5abGMzUnRaVzUwSUdGdGIzVnVkQ0J0ZFhOMElHSmxJR2R5WldGMFpYSWdkR2hoYmlBd0lnb2dJQ0FnY21WMGMzVmlDZ3B6YVcxMWJHRjBaVWx1ZG1WemRHMWxiblJmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzIxaGNuUmpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZ0tJQ0FnSUM4dklIUnZkR0ZzUm5WdVpITkVaWEJ2YzJsMFpXUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0owYjNSaGJFWjFibVJ6UkdWd2IzTnBkR1ZrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVDaUFnSUNBdkx5QjBiM1JoYkVaMWJtUnpTVzUyWlhOMFpXUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0owYjNSaGJFWjFibVJ6U1c1MlpYTjBaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzIxaGNuUmpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTRPQW9nSUNBZ0x5OGdhV1lnS0dGdGIzVnVkQ0ErSUhSb2FYTXVkRzkwWVd4R2RXNWtjMFJsY0c5emFYUmxaQzUyWVd4MVpTQXRJSFJvYVhNdWRHOTBZV3hHZFc1a2MwbHVkbVZ6ZEdWa0xuWmhiSFZsS1NCN0NpQWdJQ0F0Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lEd0tJQ0FnSUdKNklITnBiWFZzWVhSbFNXNTJaWE4wYldWdWRGOWhablJsY2w5cFpsOWxiSE5sUURRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTnRZWEowWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T0RrS0lDQWdJQzh2SUhKbGRIVnliaUFuU1c1emRXWm1hV05wWlc1MElHRjJZV2xzWVdKc1pTQm1kVzVrY3lCbWIzSWdhVzUyWlhOMGJXVnVkQ2NLSUNBZ0lIQjFjMmhpZVhSbGN5QWlTVzV6ZFdabWFXTnBaVzUwSUdGMllXbHNZV0pzWlNCbWRXNWtjeUJtYjNJZ2FXNTJaWE4wYldWdWRDSUtJQ0FnSUhKbGRITjFZZ29LYzJsdGRXeGhkR1ZKYm5abGMzUnRaVzUwWDJGbWRHVnlYMmxtWDJWc2MyVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVDaUFnSUNBdkx5QjBiM1JoYkVaMWJtUnpTVzUyWlhOMFpXUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0owYjNSaGJFWjFibVJ6U1c1MlpYTjBaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzIxaGNuUmpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTVNd29nSUNBZ0x5OGdkR2hwY3k1MGIzUmhiRVoxYm1SelNXNTJaWE4wWldRdWRtRnNkV1VnUFNCMGFHbHpMblJ2ZEdGc1JuVnVaSE5KYm5abGMzUmxaQzUyWVd4MVpTQXJJR0Z0YjNWdWRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0FyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5emJXRnlkR052Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPUW9nSUNBZ0x5OGdkRzkwWVd4R2RXNWtjMGx1ZG1WemRHVmtJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMGIzUmhiRVoxYm1SelNXNTJaWE4wWldRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOXpiV0Z5ZEdOdmJuUnlZV04wTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWprekNpQWdJQ0F2THlCMGFHbHpMblJ2ZEdGc1JuVnVaSE5KYm5abGMzUmxaQzUyWVd4MVpTQTlJSFJvYVhNdWRHOTBZV3hHZFc1a2MwbHVkbVZ6ZEdWa0xuWmhiSFZsSUNzZ1lXMXZkVzUwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZmMyMWhjblJqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakk1TlFvZ0lDQWdMeThnY21WMGRYSnVJQ2RKYm5abGMzUnRaVzUwSUdGc2JHOWpZWFJsWkNCemRXTmpaWE56Wm5Wc2JIa25DaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrbHVkbVZ6ZEcxbGJuUWdZV3hzYjJOaGRHVmtJSE4xWTJObGMzTm1kV3hzZVNJS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTnRZWEowWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UVd4bmIwTnlaV1JwZEZCc1lYUm1iM0p0VkdWemRFNWxkQzVuWlhSQmRtRnBiR0ZpYkdWR2RXNWtjeWdwSUMwK0lIVnBiblEyTkRvS1oyVjBRWFpoYVd4aFlteGxSblZ1WkhNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOXpiV0Z5ZEdOdmJuUnlZV04wTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0FvZ0lDQWdMeThnZEc5MFlXeEdkVzVrYzBSbGNHOXphWFJsWkNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0luUnZkR0ZzUm5WdVpITkVaWEJ2YzJsMFpXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZjMjFoY25SamIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prS0lDQWdJQzh2SUhSdmRHRnNSblZ1WkhOSmJuWmxjM1JsWkNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0luUnZkR0ZzUm5WdVpITkpiblpsYzNSbFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOXpiV0Z5ZEdOdmJuUnlZV04wTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpBeUNpQWdJQ0F2THlCeVpYUjFjbTRnZEdocGN5NTBiM1JoYkVaMWJtUnpSR1Z3YjNOcGRHVmtMblpoYkhWbElDMGdkR2hwY3k1MGIzUmhiRVoxYm1SelNXNTJaWE4wWldRdWRtRnNkV1VLSUNBZ0lDMEtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM050WVhKMFkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlFXeG5iME55WldScGRGQnNZWFJtYjNKdFZHVnpkRTVsZEM1blpYUlViM1JoYkVSbGNHOXphWFJsWkNncElDMCtJSFZwYm5RMk5Eb0taMlYwVkc5MFlXeEVaWEJ2YzJsMFpXUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6YldGeWRHTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9Bb2dJQ0FnTHk4Z2RHOTBZV3hHZFc1a2MwUmxjRzl6YVhSbFpDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJblJ2ZEdGc1JuVnVaSE5FWlhCdmMybDBaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzIxaGNuUmpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXdPUW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11ZEc5MFlXeEdkVzVrYzBSbGNHOXphWFJsWkM1MllXeDFaUW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzIxaGNuUmpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEJiR2R2UTNKbFpHbDBVR3hoZEdadmNtMVVaWE4wVG1WMExtZGxkRlJ2ZEdGc1NXNTJaWE4wWldRb0tTQXRQaUIxYVc1ME5qUTZDbWRsZEZSdmRHRnNTVzUyWlhOMFpXUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6YldGeWRHTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9Rb2dJQ0FnTHk4Z2RHOTBZV3hHZFc1a2MwbHVkbVZ6ZEdWa0lEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlkRzkwWVd4R2RXNWtjMGx1ZG1WemRHVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM050WVhKMFkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1UWUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMblJ2ZEdGc1JuVnVaSE5KYm5abGMzUmxaQzUyWVd4MVpRb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZjMjFoY25SamIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwQmJHZHZRM0psWkdsMFVHeGhkR1p2Y20xVVpYTjBUbVYwTG1kbGRGQnNZWFJtYjNKdFJtVmxjeWdwSUMwK0lIVnBiblEyTkRvS1oyVjBVR3hoZEdadmNtMUdaV1Z6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZmMyMWhjblJqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6Q2lBZ0lDQXZMeUJ3YkdGMFptOXliVVpsWlhNZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSndiR0YwWm05eWJVWmxaWE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzIxaGNuUmpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXlNd29nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11Y0d4aGRHWnZjbTFHWldWekxuWmhiSFZsQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5emJXRnlkR052Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa0ZzWjI5RGNtVmthWFJRYkdGMFptOXliVlJsYzNST1pYUXVaMlYwVUd4aGRHWnZjbTFUZEdGMGN5Z3BJQzArSUdKNWRHVnpPZ3BuWlhSUWJHRjBabTl5YlZOMFlYUnpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzIxaGNuUmpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXlPUW9nSUNBZ0x5OGdaMlYwVUd4aGRHWnZjbTFUZEdGMGN5Z3BPaUJ6ZEhKcGJtY2dld29nSUNBZ2NISnZkRzhnTUNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOXpiV0Z5ZEdOdmJuUnlZV04wTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlFvZ0lDQWdMeThnZEc5MFlXeEpiblpsYzNSdmNuTWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMklDOHZJQ0owYjNSaGJFbHVkbVZ6ZEc5eWN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOXpiV0Z5ZEdOdmJuUnlZV04wTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmdvZ0lDQWdMeThnZEc5MFlXeFRkR0Z5ZEhWd2N5QTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJblJ2ZEdGc1UzUmhjblIxY0hNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZjMjFoY25SamIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNek13b2dJQ0FnTHk4Z2FXWWdLR2x1ZG1WemRHOXljeUE5UFQwZ01DQW1KaUJ6ZEdGeWRIVndjeUE5UFQwZ01Da2dld29nSUNBZ1ltNTZJR2RsZEZCc1lYUm1iM0p0VTNSaGRITmZZV1owWlhKZmFXWmZaV3h6WlVBekNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdZbTU2SUdkbGRGQnNZWFJtYjNKdFUzUmhkSE5mWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6YldGeWRHTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16TTBDaUFnSUNBdkx5QnlaWFIxY200Z0owRnNaMjlEY21Wa2FYUWdVR3hoZEdadmNtMDZJRkpsWVdSNUlHWnZjaUIxYzJWeWN5Y0tJQ0FnSUhCMWMyaGllWFJsY3lBaVFXeG5iME55WldScGRDQlFiR0YwWm05eWJUb2dVbVZoWkhrZ1ptOXlJSFZ6WlhKeklnb2dJQ0FnYzNkaGNBb2dJQ0FnY21WMGMzVmlDZ3BuWlhSUWJHRjBabTl5YlZOMFlYUnpYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM050WVhKMFkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek16Y0tJQ0FnSUM4dklISmxkSFZ5YmlBblFXeG5iME55WldScGRDQlFiR0YwWm05eWJUb2dRV04wYVhabEp3b2dJQ0FnY0hWemFHSjVkR1Z6SUNKQmJHZHZRM0psWkdsMElGQnNZWFJtYjNKdE9pQkJZM1JwZG1VaUNpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOXpiV0Z5ZEdOdmJuUnlZV04wTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tGc1oyOURjbVZrYVhSUWJHRjBabTl5YlZSbGMzUk9aWFF1Y21WaGJFeHZZVzVHZFc1a2FXNW5LR3h2WVc1SlpEb2dkV2x1ZERZMExDQmhiVzkxYm5RNklIVnBiblEyTkNrZ0xUNGdZbmwwWlhNNkNuSmxZV3hNYjJGdVJuVnVaR2x1WnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTnRZWEowWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TlRBS0lDQWdJQzh2SUhKbFlXeE1iMkZ1Um5WdVpHbHVaeWhzYjJGdVNXUTZJSFZwYm5RMk5Dd2dZVzF2ZFc1ME9pQjFhVzUwTmpRcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnY0hKdmRHOGdNaUF4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5emJXRnlkR052Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNelV5Q2lBZ0lDQXZMeUJwWmlBb1lXMXZkVzUwSUR3OUlEQXBJSHNLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUR3OUNpQWdJQ0JpZWlCeVpXRnNURzloYmtaMWJtUnBibWRmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6YldGeWRHTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16VXpDaUFnSUNBdkx5QnlaWFIxY200Z0owWjFibVJwYm1jZ1lXMXZkVzUwSUcxMWMzUWdZbVVnWjNKbFlYUmxjaUIwYUdGdUlEQW5DaUFnSUNCaWVYUmxZeUF4TlNBdkx5QWlSblZ1WkdsdVp5QmhiVzkxYm5RZ2JYVnpkQ0JpWlNCbmNtVmhkR1Z5SUhSb1lXNGdNQ0lLSUNBZ0lISmxkSE4xWWdvS2NtVmhiRXh2WVc1R2RXNWthVzVuWDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOVFlLSUNBZ0lDOHZJR2xtSUNoc2IyRnVTV1FnUEQwZ01Da2dld29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnUEQwS0lDQWdJR0o2SUhKbFlXeE1iMkZ1Um5WdVpHbHVaMTloWm5SbGNsOXBabDlsYkhObFFEUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM050WVhKMFkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5UY0tJQ0FnSUM4dklISmxkSFZ5YmlBblNXNTJZV3hwWkNCc2IyRnVJRWxFSndvZ0lDQWdZbmwwWldNZ01UWWdMeThnSWtsdWRtRnNhV1FnYkc5aGJpQkpSQ0lLSUNBZ0lISmxkSE4xWWdvS2NtVmhiRXh2WVc1R2RXNWthVzVuWDJGbWRHVnlYMmxtWDJWc2MyVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRDaUFnSUNBdkx5QjBiM1JoYkVaMWJtUnpSR1Z3YjNOcGRHVmtJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpZEc5MFlXeEdkVzVrYzBSbGNHOXphWFJsWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5emJXRnlkR052Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPUW9nSUNBZ0x5OGdkRzkwWVd4R2RXNWtjMGx1ZG1WemRHVmtJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpZEc5MFlXeEdkVzVrYzBsdWRtVnpkR1ZrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOakVLSUNBZ0lDOHZJR2xtSUNoaGJXOTFiblFnUGlCMGFHbHpMblJ2ZEdGc1JuVnVaSE5FWlhCdmMybDBaV1F1ZG1Gc2RXVWdMU0IwYUdsekxuUnZkR0ZzUm5WdVpITkpiblpsYzNSbFpDNTJZV3gxWlNrZ2V3b2dJQ0FnTFFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQThDaUFnSUNCaWVpQnlaV0ZzVEc5aGJrWjFibVJwYm1kZllXWjBaWEpmYVdaZlpXeHpaVUEyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5emJXRnlkR052Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNell5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdKMGx1YzNWbVptbGphV1Z1ZENCaGRtRnBiR0ZpYkdVZ1puVnVaSE1uQ2lBZ0lDQmllWFJsWXlBeE55QXZMeUFpU1c1emRXWm1hV05wWlc1MElHRjJZV2xzWVdKc1pTQm1kVzVrY3lJS0lDQWdJSEpsZEhOMVlnb0tjbVZoYkV4dllXNUdkVzVrYVc1blgyRm1kR1Z5WDJsbVgyVnNjMlZBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTnRZWEowWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81Q2lBZ0lDQXZMeUIwYjNSaGJFWjFibVJ6U1c1MlpYTjBaV1FnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMGIzUmhiRVoxYm1SelNXNTJaWE4wWldRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZmMyMWhjblJqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0yTmdvZ0lDQWdMeThnZEdocGN5NTBiM1JoYkVaMWJtUnpTVzUyWlhOMFpXUXVkbUZzZFdVZ1BTQjBhR2x6TG5SdmRHRnNSblZ1WkhOSmJuWmxjM1JsWkM1MllXeDFaU0FySUdGdGIzVnVkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBckNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOXpiV0Z5ZEdOdmJuUnlZV04wTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1FvZ0lDQWdMeThnZEc5MFlXeEdkVzVrYzBsdWRtVnpkR1ZrSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBiM1JoYkVaMWJtUnpTVzUyWlhOMFpXUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6YldGeWRHTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16WTJDaUFnSUNBdkx5QjBhR2x6TG5SdmRHRnNSblZ1WkhOSmJuWmxjM1JsWkM1MllXeDFaU0E5SUhSb2FYTXVkRzkwWVd4R2RXNWtjMGx1ZG1WemRHVmtMblpoYkhWbElDc2dZVzF2ZFc1MENpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZjMjFoY25SamIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeENpQWdJQ0F2THlCMGIzUmhiRUZqZEdsMlpVeHZZVzV6SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOU0F2THlBaWRHOTBZV3hCWTNScGRtVk1iMkZ1Y3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5emJXRnlkR052Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNelkzQ2lBZ0lDQXZMeUIwYUdsekxuUnZkR0ZzUVdOMGFYWmxURzloYm5NdWRtRnNkV1VnUFNCMGFHbHpMblJ2ZEdGc1FXTjBhWFpsVEc5aGJuTXVkbUZzZFdVZ0t5QXhDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZmMyMWhjblJqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4Q2lBZ0lDQXZMeUIwYjNSaGJFRmpkR2wyWlV4dllXNXpJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncENpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKMGIzUmhiRUZqZEdsMlpVeHZZVzV6SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZmMyMWhjblJqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0yTndvZ0lDQWdMeThnZEdocGN5NTBiM1JoYkVGamRHbDJaVXh2WVc1ekxuWmhiSFZsSUQwZ2RHaHBjeTUwYjNSaGJFRmpkR2wyWlV4dllXNXpMblpoYkhWbElDc2dNUW9nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNd29nSUNBZ0x5OGdjR3hoZEdadmNtMUdaV1Z6SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWNHeGhkR1p2Y20xR1pXVnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM050WVhKMFkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek56QUtJQ0FnSUM4dklIUm9hWE11Y0d4aGRHWnZjbTFHWldWekxuWmhiSFZsSUQwZ2RHaHBjeTV3YkdGMFptOXliVVpsWlhNdWRtRnNkV1VnS3lBb1lXMXZkVzUwSUM4Z05UQXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNeUF2THlBMU1Bb2dJQ0FnTHdvZ0lDQWdLd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzIxaGNuUmpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpDaUFnSUNBdkx5QndiR0YwWm05eWJVWmxaWE1nUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0luQnNZWFJtYjNKdFJtVmxjeUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOekFLSUNBZ0lDOHZJSFJvYVhNdWNHeGhkR1p2Y20xR1pXVnpMblpoYkhWbElEMGdkR2hwY3k1d2JHRjBabTl5YlVabFpYTXVkbUZzZFdVZ0t5QW9ZVzF2ZFc1MElDOGdOVEFwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZmMyMWhjblJqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0zTlFvZ0lDQWdMeThnY21WMGRYSnVJQ2RTWldGc0lHeHZZVzRnWm5WdVpHbHVaeUJ3Y205alpYTnpaV1FnYzNWalkyVnpjMloxYkd4NUp3b2dJQ0FnY0hWemFHSjVkR1Z6SUNKU1pXRnNJR3h2WVc0Z1puVnVaR2x1WnlCd2NtOWpaWE56WldRZ2MzVmpZMlZ6YzJaMWJHeDVJZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzIxaGNuUmpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEJiR2R2UTNKbFpHbDBVR3hoZEdadmNtMVVaWE4wVG1WMExuTnBiWFZzWVhSbFRHOWhia1oxYm1ScGJtY29iRzloYmtsa09pQjFhVzUwTmpRc0lHRnRiM1Z1ZERvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3pvS2MybHRkV3hoZEdWTWIyRnVSblZ1WkdsdVp6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM050WVhKMFkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek9ERUtJQ0FnSUM4dklITnBiWFZzWVhSbFRHOWhia1oxYm1ScGJtY29iRzloYmtsa09pQjFhVzUwTmpRc0lHRnRiM1Z1ZERvZ2RXbHVkRFkwS1RvZ2MzUnlhVzVuSUhzS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzIxaGNuUmpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTRNd29nSUNBZ0x5OGdhV1lnS0dGdGIzVnVkQ0E4UFNBd0tTQjdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0E4UFFvZ0lDQWdZbm9nYzJsdGRXeGhkR1ZNYjJGdVJuVnVaR2x1WjE5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pPRFFLSUNBZ0lDOHZJSEpsZEhWeWJpQW5SblZ1WkdsdVp5QmhiVzkxYm5RZ2JYVnpkQ0JpWlNCbmNtVmhkR1Z5SUhSb1lXNGdNQ2NLSUNBZ0lHSjVkR1ZqSURFMUlDOHZJQ0pHZFc1a2FXNW5JR0Z0YjNWdWRDQnRkWE4wSUdKbElHZHlaV0YwWlhJZ2RHaGhiaUF3SWdvZ0lDQWdjbVYwYzNWaUNncHphVzExYkdGMFpVeHZZVzVHZFc1a2FXNW5YMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM050WVhKMFkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek9EY0tJQ0FnSUM4dklHbG1JQ2hzYjJGdVNXUWdQRDBnTUNrZ2V3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdQRDBLSUNBZ0lHSjZJSE5wYlhWc1lYUmxURzloYmtaMWJtUnBibWRmWVdaMFpYSmZhV1pmWld4elpVQTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6YldGeWRHTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16ZzRDaUFnSUNBdkx5QnlaWFIxY200Z0owbHVkbUZzYVdRZ2JHOWhiaUJKUkNjS0lDQWdJR0o1ZEdWaklERTJJQzh2SUNKSmJuWmhiR2xrSUd4dllXNGdTVVFpQ2lBZ0lDQnlaWFJ6ZFdJS0NuTnBiWFZzWVhSbFRHOWhia1oxYm1ScGJtZGZZV1owWlhKZmFXWmZaV3h6WlVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZjMjFoY25SamIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnS0lDQWdJQzh2SUhSdmRHRnNSblZ1WkhORVpYQnZjMmwwWldRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSjBiM1JoYkVaMWJtUnpSR1Z3YjNOcGRHVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM050WVhKMFkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNUNpQWdJQ0F2THlCMGIzUmhiRVoxYm1SelNXNTJaWE4wWldRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBiM1JoYkVaMWJtUnpTVzUyWlhOMFpXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZjMjFoY25SamIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNNU1nb2dJQ0FnTHk4Z2FXWWdLR0Z0YjNWdWRDQStJSFJvYVhNdWRHOTBZV3hHZFc1a2MwUmxjRzl6YVhSbFpDNTJZV3gxWlNBdElIUm9hWE11ZEc5MFlXeEdkVzVrYzBsdWRtVnpkR1ZrTG5aaGJIVmxLU0I3Q2lBZ0lDQXRDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUR3S0lDQWdJR0o2SUhOcGJYVnNZWFJsVEc5aGJrWjFibVJwYm1kZllXWjBaWEpmYVdaZlpXeHpaVUEyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5emJXRnlkR052Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNemt6Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdKMGx1YzNWbVptbGphV1Z1ZENCaGRtRnBiR0ZpYkdVZ1puVnVaSE1uQ2lBZ0lDQmllWFJsWXlBeE55QXZMeUFpU1c1emRXWm1hV05wWlc1MElHRjJZV2xzWVdKc1pTQm1kVzVrY3lJS0lDQWdJSEpsZEhOMVlnb0tjMmx0ZFd4aGRHVk1iMkZ1Um5WdVpHbHVaMTloWm5SbGNsOXBabDlsYkhObFFEWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6YldGeWRHTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9Rb2dJQ0FnTHk4Z2RHOTBZV3hHZFc1a2MwbHVkbVZ6ZEdWa0lEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlkRzkwWVd4R2RXNWtjMGx1ZG1WemRHVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM050WVhKMFkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek9UY0tJQ0FnSUM4dklIUm9hWE11ZEc5MFlXeEdkVzVrYzBsdWRtVnpkR1ZrTG5aaGJIVmxJRDBnZEdocGN5NTBiM1JoYkVaMWJtUnpTVzUyWlhOMFpXUXVkbUZzZFdVZ0t5QmhiVzkxYm5RS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdLd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzIxaGNuUmpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qa0tJQ0FnSUM4dklIUnZkR0ZzUm5WdVpITkpiblpsYzNSbFpDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpZEc5MFlXeEdkVzVrYzBsdWRtVnpkR1ZrSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZmMyMWhjblJqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak01TndvZ0lDQWdMeThnZEdocGN5NTBiM1JoYkVaMWJtUnpTVzUyWlhOMFpXUXVkbUZzZFdVZ1BTQjBhR2x6TG5SdmRHRnNSblZ1WkhOSmJuWmxjM1JsWkM1MllXeDFaU0FySUdGdGIzVnVkQW9nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNUW9nSUNBZ0x5OGdkRzkwWVd4QlkzUnBkbVZNYjJGdWN5QTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJblJ2ZEdGc1FXTjBhWFpsVEc5aGJuTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZjMjFoY25SamIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNNU9Bb2dJQ0FnTHk4Z2RHaHBjeTUwYjNSaGJFRmpkR2wyWlV4dllXNXpMblpoYkhWbElEMGdkR2hwY3k1MGIzUmhiRUZqZEdsMlpVeHZZVzV6TG5aaGJIVmxJQ3NnTVFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM050WVhKMFkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1Rb2dJQ0FnTHk4Z2RHOTBZV3hCWTNScGRtVk1iMkZ1Y3lBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LUW9nSUNBZ1lubDBaV01nTlNBdkx5QWlkRzkwWVd4QlkzUnBkbVZNYjJGdWN5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM050WVhKMFkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek9UZ0tJQ0FnSUM4dklIUm9hWE11ZEc5MFlXeEJZM1JwZG1WTWIyRnVjeTUyWVd4MVpTQTlJSFJvYVhNdWRHOTBZV3hCWTNScGRtVk1iMkZ1Y3k1MllXeDFaU0FySURFS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOXpiV0Z5ZEdOdmJuUnlZV04wTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNS0lDQWdJQzh2SUhCc1lYUm1iM0p0Um1WbGN5QTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbkJzWVhSbWIzSnRSbVZsY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5emJXRnlkR052Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOREF4Q2lBZ0lDQXZMeUIwYUdsekxuQnNZWFJtYjNKdFJtVmxjeTUyWVd4MVpTQTlJSFJvYVhNdWNHeGhkR1p2Y20xR1pXVnpMblpoYkhWbElDc2dLR0Z0YjNWdWRDQXZJRFV3S1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqWHpNZ0x5OGdOVEFLSUNBZ0lDOEtJQ0FnSUNzS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTnRZWEowWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXdvZ0lDQWdMeThnY0d4aGRHWnZjbTFHWldWeklEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p3YkdGMFptOXliVVpsWlhNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOXpiV0Z5ZEdOdmJuUnlZV04wTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRBeENpQWdJQ0F2THlCMGFHbHpMbkJzWVhSbWIzSnRSbVZsY3k1MllXeDFaU0E5SUhSb2FYTXVjR3hoZEdadmNtMUdaV1Z6TG5aaGJIVmxJQ3NnS0dGdGIzVnVkQ0F2SURVd0tRb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM050WVhKMFkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME1ETUtJQ0FnSUM4dklISmxkSFZ5YmlBblRHOWhiaUJtZFc1a2FXNW5JSE5wYlhWc1lYUmxaQ0J6ZFdOalpYTnpablZzYkhrbkNpQWdJQ0J3ZFhOb1lubDBaWE1nSWt4dllXNGdablZ1WkdsdVp5QnphVzExYkdGMFpXUWdjM1ZqWTJWemMyWjFiR3g1SWdvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZmMyMWhjblJqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBCYkdkdlEzSmxaR2wwVUd4aGRHWnZjbTFVWlhOMFRtVjBMbWRsZEVGamRHbDJaVXh2WVc1elEyOTFiblFvS1NBdFBpQjFhVzUwTmpRNkNtZGxkRUZqZEdsMlpVeHZZVzV6UTI5MWJuUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6YldGeWRHTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URUtJQ0FnSUM4dklIUnZkR0ZzUVdOMGFYWmxURzloYm5NZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUExSUM4dklDSjBiM1JoYkVGamRHbDJaVXh2WVc1eklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTnRZWEowWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTVRrS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxuUnZkR0ZzUVdOMGFYWmxURzloYm5NdWRtRnNkV1VLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZRV3huYjBOeVpXUnBkRkJzWVhSbWIzSnRWR1Z6ZEU1bGRDNTBiMmRuYkdWUWJHRjBabTl5YlZOMFlYUjFjeWdwSUMwK0lHSjVkR1Z6T2dwMGIyZG5iR1ZRYkdGMFptOXliVk4wWVhSMWN6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM050WVhKMFkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSQlkzUnBkbVVnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDa2dMeThnTVNBOUlHRmpkR2wyWlN3Z01DQTlJR2x1WVdOMGFYWmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVkyOXVkSEpoWTNSQlkzUnBkbVVpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzIxaGNuUmpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXlOZ29nSUNBZ0x5OGdhV1lnS0hSb2FYTXVZMjl1ZEhKaFkzUkJZM1JwZG1VdWRtRnNkV1VnUFQwOUlERXBJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWW5vZ2RHOW5aMnhsVUd4aGRHWnZjbTFUZEdGMGRYTmZaV3h6WlY5aWIyUjVRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUkJZM1JwZG1VZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tnTHk4Z01TQTlJR0ZqZEdsMlpTd2dNQ0E5SUdsdVlXTjBhWFpsQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0pqYjI1MGNtRmpkRUZqZEdsMlpTSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM050WVhKMFkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME1qY0tJQ0FnSUM4dklIUm9hWE11WTI5dWRISmhZM1JCWTNScGRtVXVkbUZzZFdVZ1BTQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM050WVhKMFkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME1qZ0tJQ0FnSUM4dklISmxkSFZ5YmlBblVHeGhkR1p2Y20wZ1pHVmhZM1JwZG1GMFpXUW5DaUFnSUNCd2RYTm9ZbmwwWlhNZ0lsQnNZWFJtYjNKdElHUmxZV04wYVhaaGRHVmtJZ29nSUNBZ2NtVjBjM1ZpQ2dwMGIyZG5iR1ZRYkdGMFptOXliVk4wWVhSMWMxOWxiSE5sWDJKdlpIbEFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUkJZM1JwZG1VZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tnTHk4Z01TQTlJR0ZqZEdsMlpTd2dNQ0E5SUdsdVlXTjBhWFpsQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0pqYjI1MGNtRmpkRUZqZEdsMlpTSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM050WVhKMFkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME16QUtJQ0FnSUM4dklIUm9hWE11WTI5dWRISmhZM1JCWTNScGRtVXVkbUZzZFdVZ1BTQXhDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM050WVhKMFkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME16RUtJQ0FnSUM4dklISmxkSFZ5YmlBblVHeGhkR1p2Y20wZ1lXTjBhWFpoZEdWa0p3b2dJQ0FnY0hWemFHSjVkR1Z6SUNKUWJHRjBabTl5YlNCaFkzUnBkbUYwWldRaUNpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOXpiV0Z5ZEdOdmJuUnlZV04wTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tGc1oyOURjbVZrYVhSUWJHRjBabTl5YlZSbGMzUk9aWFF1WTI5c2JHVmpkRkJzWVhSbWIzSnRSbVZsY3lncElDMCtJR0o1ZEdWek9ncGpiMnhzWldOMFVHeGhkR1p2Y20xR1pXVnpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzIxaGNuUmpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpDaUFnSUNBdkx5QndiR0YwWm05eWJVWmxaWE1nUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKd2JHRjBabTl5YlVabFpYTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZjMjFoY25SamIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRME1Rb2dJQ0FnTHk4Z2FXWWdLR1psWlhNZ1BEMGdNQ2tnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lEdzlDaUFnSUNCaWVpQmpiMnhzWldOMFVHeGhkR1p2Y20xR1pXVnpYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZjMjFoY25SamIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRME1nb2dJQ0FnTHk4Z2NtVjBkWEp1SUNkT2J5Qm1aV1Z6SUdGMllXbHNZV0pzWlNCbWIzSWdZMjlzYkdWamRHbHZiaWNLSUNBZ0lIQjFjMmhpZVhSbGN5QWlUbThnWm1WbGN5QmhkbUZwYkdGaWJHVWdabTl5SUdOdmJHeGxZM1JwYjI0aUNpQWdJQ0J5WlhSemRXSUtDbU52Ykd4bFkzUlFiR0YwWm05eWJVWmxaWE5mWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmYzIxaGNuUmpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpDaUFnSUNBdkx5QndiR0YwWm05eWJVWmxaWE1nUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0luQnNZWFJtYjNKdFJtVmxjeUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDNOdFlYSjBZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBORFlLSUNBZ0lDOHZJSFJvYVhNdWNHeGhkR1p2Y20xR1pXVnpMblpoYkhWbElEMGdNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTl6YldGeWRHTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EVXhDaUFnSUNBdkx5QnlaWFIxY200Z0oxQnNZWFJtYjNKdElHWmxaWE1nWTI5c2JHVmpkR1ZrSUhOMVkyTmxjM05tZFd4c2VTY0tJQ0FnSUhCMWMyaGllWFJsY3lBaVVHeGhkR1p2Y20wZ1ptVmxjeUJqYjJ4c1pXTjBaV1FnYzNWalkyVnpjMloxYkd4NUlnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZjMjFoY25SamIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwQmJHZHZRM0psWkdsMFVHeGhkR1p2Y20xVVpYTjBUbVYwTG1kbGRGQnNZWFJtYjNKdFJtVmxjMEZ0YjNWdWRDZ3BJQzArSUhWcGJuUTJORG9LWjJWMFVHeGhkR1p2Y20xR1pXVnpRVzF2ZFc1ME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZjMjFoY25SamIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFekNpQWdJQ0F2THlCd2JHRjBabTl5YlVabFpYTWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p3YkdGMFptOXliVVpsWlhNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZmMyMWhjblJqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalExT0FvZ0lDQWdMeThnY21WMGRYSnVJSFJvYVhNdWNHeGhkR1p2Y20xR1pXVnpMblpoYkhWbENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOXpiV0Z5ZEdOdmJuUnlZV04wTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tGc1oyOURjbVZrYVhSUWJHRjBabTl5YlZSbGMzUk9aWFF1ZEdWemRGQnNZWFJtYjNKdEtDa2dMVDRnWW5sMFpYTTZDblJsYzNSUWJHRjBabTl5YlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgzTnRZWEowWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkFvZ0lDQWdMeThnWTI5dWRISmhZM1JCWTNScGRtVWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrZ0x5OGdNU0E5SUdGamRHbDJaU3dnTUNBOUlHbHVZV04wYVhabENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWTI5dWRISmhZM1JCWTNScGRtVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZjMjFoY25SamIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRMk5nb2dJQ0FnTHk4Z2FXWWdLR0ZqZEdsMlpTQTlQVDBnTVNrZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmllaUIwWlhOMFVHeGhkR1p2Y20xZlpXeHpaVjlpYjJSNVFESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYM050WVhKMFkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME5qY0tJQ0FnSUM4dklISmxkSFZ5YmlBblFXeG5iME55WldScGRDQlFiR0YwWm05eWJTQjBaWE4wSUhOMVkyTmxjM05tZFd3Z0xTQkJRMVJKVmtVbkNpQWdJQ0J3ZFhOb1lubDBaWE1nSWtGc1oyOURjbVZrYVhRZ1VHeGhkR1p2Y20wZ2RHVnpkQ0J6ZFdOalpYTnpablZzSUMwZ1FVTlVTVlpGSWdvZ0lDQWdjbVYwYzNWaUNncDBaWE4wVUd4aGRHWnZjbTFmWld4elpWOWliMlI1UURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOXpiV0Z5ZEdOdmJuUnlZV04wTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRZNUNpQWdJQ0F2THlCeVpYUjFjbTRnSjBGc1oyOURjbVZrYVhRZ1VHeGhkR1p2Y20wZ2RHVnpkQ0J6ZFdOalpYTnpablZzSUMwZ1NVNUJRMVJKVmtVbkNpQWdJQ0J3ZFhOb1lubDBaWE1nSWtGc1oyOURjbVZrYVhRZ1VHeGhkR1p2Y20wZ2RHVnpkQ0J6ZFdOalpYTnpablZzSUMwZ1NVNUJRMVJKVmtVaUNpQWdJQ0J5WlhSemRXSUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUdBQUhBaEQweWdKVHIzQU9nalFZbUVnUVZIM3gxRW5SdmRHRnNSblZ1WkhOSmJuWmxjM1JsWkJOMGIzUmhiRVoxYm1SelJHVndiM05wZEdWa0RIQnNZWFJtYjNKdFJtVmxjdzVqYjI1MGNtRmpkRUZqZEdsMlpSQjBiM1JoYkVGamRHbDJaVXh2WVc1ekRuUnZkR0ZzU1c1MlpYTjBiM0p6RFhSdmRHRnNVM1JoY25SMWNITU1kRzkwWVd4QmNHbExaWGx6Rm5SdmRHRnNWRzlyWlc1cGVtVmtVM1JoY25SMWNITVJkRzkwWVd4TWIyRnVVbVZ4ZFdWemRITVFkRzkwWVd4SmJuWmxjM1J0Wlc1MGN3d1ZIM3gxQUFBQUFBQUFBQUVlVUd4aGRHWnZjbTBnYVhNZ1kzVnljbVZ1ZEd4NUlHbHVZV04wYVhabEtFbHVkbVZ6ZEcxbGJuUWdZVzF2ZFc1MElHMTFjM1FnWW1VZ1ozSmxZWFJsY2lCMGFHRnVJREFsUm5WdVpHbHVaeUJoYlc5MWJuUWdiWFZ6ZENCaVpTQm5jbVZoZEdWeUlIUm9ZVzRnTUE5SmJuWmhiR2xrSUd4dllXNGdTVVFjU1c1emRXWm1hV05wWlc1MElHRjJZV2xzWVdKc1pTQm1kVzVrY3pFYlFRUWZnaUFFQXI3T0VRVDBNb2VyQklnZXRhOEVubVFZRndTVThPcUpCSDZzSEtFRUgxSThkQVQvaERmckJQV2NmT3dFZjZEY29BU2hTNmFkQkdUaXUzZ0VwWHhqUGdTYTFBckxCSmdreHdJRUd5bE56QVI1RHpyNEJFWGhuNmtFeTBXb3R3UlllcVZ6Qk9SMjBZSUU3bGZJTEFRUkkzdElCTDVlY3FBRTE2ZWNMd1RGM0swL0JJb2RyRXNFWEk3bDBnVHVlbjBFQlBaY3duY0VDY1BWL1FTQVVpRmVOaG9BamlBREdnTDRBczRDdlFLeEFva0NYUUk1QWlnQ0Z3SUdBZlVCNUFIQUFhZ0JqQUZ3QVZRQlF3RXlBU0VCRUFENEFMZ0FtQUI0QUd3QVd3QkRBQ3NBR2dBQ0lrTXhHUlJFTVJoRWlBcTdTUlVXVndZQ1RGQW9URkN3STBNeEdSUkVNUmhFaUFxZUZpaE1VTEFqUXpFWkZFUXhHRVNJQ2pkSkZSWlhCZ0pNVUNoTVVMQWpRekVaRkVReEdFU0lDZUZKRlJaWEJnSk1VQ2hNVUxBalF6RVpGRVF4R0VTSUNjTVdLRXhRc0NORE1Sa1VSREVZUkNjTXNDTkRNUmtVUkRFWVJEWWFBUmMyR2dJWGlBa3VTUlVXVndZQ1RGQW9URkN3STBNeEdSUkVNUmhFTmhvQkZ6WWFBaGVJQ0psSkZSWlhCZ0pNVUNoTVVMQWpRekVaRkVReEdFU0FOQlVmZkhVQUxrRnNaMjlEY21Wa2FYUWdVR3hoZEdadmNtMGdkak11TUNBdElGSmxZV3dnVUdGNWJXVnVkSE1nVW1WaFpIbXdJME14R1JSRU1SaEVpQWZpU1JVV1Z3WUNURkFvVEZDd0kwTXhHUlJFTVJoRWlBZkZGaWhNVUxBalF6RVpGRVF4R0VTSUI2OFdLRXhRc0NORE1Sa1VSREVZUklnSG1SWW9URkN3STBNeEdSUkVNUmhFaUFkK0ZpaE1VTEFqUXpFWkZFUXhHRVEyR2dFWGlBYnhTUlVXVndZQ1RGQW9URkN3STBNeEdSUkVNUmhFTmhvQkY0Z0dDRWtWRmxjR0FreFFLRXhRc0NORE1Sa1VSREVZUkRZYUFSZUlCWEZKRlJaWEJnSk1VQ2hNVUxBalF6RVpGRVF4R0VTSUJTOUpGUlpYQmdKTVVDaE1VTEFqUXpFWkZFUXhHRVEyR2dFWE5ob0NGellhQXhlSUJHWkpGUlpYQmdKTVVDaE1VTEFqUXpFWkZFUXhHRVNJQkVnV0tFeFFzQ05ETVJrVVJERVlSSWdFTVJZb1RGQ3dJME14R1JSRU1SaEVpQVFhRmloTVVMQWpRekVaRkVReEdFU0lCQU1XS0V4UXNDTkRNUmtVUkRFWVJJZ0Q3QllvVEZDd0kwTXhHUlJFTVJoRU5ob0JGellhQWhjMkdnTVhpQUxRU1JVV1Z3WUNURkFvVEZDd0kwTXhHUlJFTVJoRU5ob0JWd0lBTmhvQ0Z6WWFBeGMyR2dSWEFnQ0lBaGRKRlJaWEJnSk1VQ2hNVUxBalF6RVpGRVF4R0VRMkdnRlhBZ0EyR2dKWEFnQTJHZ01YaUFGY1NSVVdWd1lDVEZBb1RGQ3dJME14R1JSRU1SaEVKd3l3STBNeEdSUkVNUmhFaUFFeUZpaE1VTEFqUXpFWkZFUXhHRVEyR2dGWEFnQTJHZ0pYQWdBMkdnTlhBZ0NJQU05SkZSWlhCZ0pNVUNoTVVMQWpRekVaRkVReEdFUTJHZ0ZYQWdBMkdnSVhpQUJIU1JVV1Z3WUNURkFvVEZDd0kwTXhHUlJFTVJoRU5ob0JWd0lBaUFBWlNSVVdWd1lDVEZBb1RGQ3dJME14R1VEOHd6RVlGRVFqUTRvQkFZQUhTR1ZzYkc4c0lJdi9VSW1LQWdHTC95TU1RQUFJaS8rQkNnMUJBQ2FBSTFKcGMyc2diR1YyWld3Z2JYVnpkQ0JpWlNCaVpYUjNaV1Z1SURFZ1lXNWtJREV3aVNJbkJtVkVJd2duQmt4bmdDQkpiblpsYzNSdmNpQnlaV2RwYzNSbGNtVmtJSE4xWTJObGMzTm1kV3hzZVltS0F3RWlKd2hsUkNNSUp3aE1aNEFmUVZCSklHdGxlU0J5WldkcGMzUmxjbVZrSUdadmNpQjNZV3hzWlhRNklJdjlVSUFISUhScFpYSTZJRkNMLzFDSklpY0laVVNKaWdNQmkvOGtERUVBSVlBZVRXbHVhVzExYlNCc2IyRnVJSEpsY1hWbGMzUWdhWE1nTVNCQlRFZFBpWXYvSVFRTlFRQWtnQ0ZOWVhocGJYVnRJR3h2WVc0Z2NtVnhkV1Z6ZENCcGN5QXhNREF3SUVGTVIwK0pJaWNIWlVRakNDY0hUR2VBSVZOMFlYSjBkWEFnY21WbmFYTjBaWEpsWkNCemRXTmpaWE56Wm5Wc2JIazZJSXY5VUlBRUlHbHVJRkNML2xDSmlnUUJpLzBpRGtFQUpZQWlWRzlyWlc0Z2NISnBZMlVnYlhWemRDQmlaU0JuY21WaGRHVnlJSFJvWVc0Z01JbUwvaUlPUVFBbWdDTlViM1JoYkNCemRYQndiSGtnYlhWemRDQmlaU0JuY21WaGRHVnlJSFJvWVc0Z01Ja2lKd2xsUkNNSUp3bE1aNEFnVTNSaGNuUjFjQ0IwYjJ0bGJtbDZaV1FnYzNWalkyVnpjMloxYkd4NU9pQ0wvRkNKaWdNQklpY0VaVVJBQUFNbkRZbUwvU1FNUVFBZ2dCMU5hVzVwYlhWdElHeHZZVzRnWVcxdmRXNTBJR2x6SURFZ1FVeEhUNG1ML1NFRURVRUFJNEFnVFdGNGFXMTFiU0JzYjJGdUlHRnRiM1Z1ZENCcGN5QXhNREF3SUVGTVIwK0ppLzRqREVBQUNJditnVHdOUVFBc2dDbE1iMkZ1SUdSMWNtRjBhVzl1SUcxMWMzUWdZbVVnWW1WMGQyVmxiaUF4TFRZd0lHMXZiblJvYzRtTC95TU1RQUFJaS8rQkhnMUJBQ2FBSTBsdWRHVnlaWE4wSUhKaGRHVWdiWFZ6ZENCaVpTQmlaWFIzWldWdUlERXRNekFsaVNJbkNtVkVJd2duQ2t4bmdDRk1iMkZ1SUhKbGNYVmxjM1FnWTNKbFlYUmxaQ0J6ZFdOalpYTnpablZzYkhtSklpY0daVVNKSWljSFpVU0pJaWNKWlVTSklpY0xaVVNKSWljS1pVU0ppZ01CaS80aURrRUFBeWNPaVl2L0lnNUJBQ2FBSTFSdmEyVnVJR0Z0YjNWdWRDQnRkWE4wSUdKbElHZHlaV0YwWlhJZ2RHaGhiaUF3aVl2OUlnNUJBQldBRWtsdWRtRnNhV1FnYzNSaGNuUjFjQ0JKUklraUp3UmxSRUFBQXljTmlTSW5DMlZFSXdnbkMweG5JaWxsUkl2K0NDbE1aeUlyWlVTTC9pVUtDQ3RNWjRBZ1NXNTJaWE4wYldWdWRDQnpkV05qWlhOelpuVnNJR2x1SUhOMFlYSjBkWENKSWlwbFJDUUlLa3huZ0I1U1pXRnNJR1JsY0c5emFYUWdjSEp2WTJWemMyVmtPaUF4SUVGTVIwK0ppZ0VCaS84aURrRUFJSUFkUVcxdmRXNTBJRzExYzNRZ1ltVWdaM0psWVhSbGNpQjBhR0Z1SURDSmkvOGhCUXhCQUI2QUcwMXBibWx0ZFcwZ1pHVndiM05wZENCcGN5QXdMakVnUVV4SFQ0a2lLbVZFaS84SUtreG5nQjVFWlhCdmMybDBJSE5wYlhWc1lYUmxaQ0J6ZFdOalpYTnpablZzYkhtSmlnRUJpLzhpRGtFQUs0QW9WMmwwYUdSeVlYZGhiQ0JoYlc5MWJuUWdiWFZ6ZENCaVpTQm5jbVZoZEdWeUlIUm9ZVzRnTUlraUttVkVJaWxsUkFtTC93eEJBQzJBS2tsdWMzVm1abWxqYVdWdWRDQmpiMjUwY21GamRDQm1kVzVrY3lCbWIzSWdkMmwwYUdSeVlYZGhiSW1ML3lFRkRFRUFJWUFlVFdsdWFXMTFiU0IzYVhSb1pISmhkMkZzSUdseklEQXVNU0JCVEVkUGlTSXFaVVNML3drcVRHZUFKbEpsWVd3Z2QybDBhR1J5WVhkaGJDQndjbTlqWlhOelpXUWdjM1ZqWTJWemMyWjFiR3g1aVlvQkFZdi9JZzVCQUFNbkRva2lLbVZFSWlsbFJBbUwvd3hCQUM2QUswbHVjM1ZtWm1samFXVnVkQ0JoZG1GcGJHRmliR1VnWm5WdVpITWdabTl5SUdsdWRtVnpkRzFsYm5TSklpbGxSSXYvQ0NsTVo0QWhTVzUyWlhOMGJXVnVkQ0JoYkd4dlkyRjBaV1FnYzNWalkyVnpjMloxYkd4NWlTSXFaVVFpS1dWRUNZa2lLbVZFaVNJcFpVU0pJaXRsUkltS0FBRWlKd1psUkNJbkIyVk1UZ0pFUUFBdGl3QkFBQ2lBSkVGc1oyOURjbVZrYVhRZ1VHeGhkR1p2Y20wNklGSmxZV1I1SUdadmNpQjFjMlZ5YzB5SmdCdEJiR2R2UTNKbFpHbDBJRkJzWVhSbWIzSnRPaUJCWTNScGRtVk1pWW9DQVl2L0lnNUJBQU1uRDRtTC9pSU9RUUFESnhDSklpcGxSQ0lwWlVRSmkvOE1RUUFESnhHSklpbGxSSXYvQ0NsTVp5SW5CV1ZFSXdnbkJVeG5JaXRsUkl2L0pRb0lLMHhuZ0NoU1pXRnNJR3h2WVc0Z1puVnVaR2x1WnlCd2NtOWpaWE56WldRZ2MzVmpZMlZ6YzJaMWJHeDVpWW9DQVl2L0lnNUJBQU1uRDRtTC9pSU9RUUFESnhDSklpcGxSQ0lwWlVRSmkvOE1RUUFESnhHSklpbGxSSXYvQ0NsTVp5SW5CV1ZFSXdnbkJVeG5JaXRsUkl2L0pRb0lLMHhuZ0NOTWIyRnVJR1oxYm1ScGJtY2djMmx0ZFd4aGRHVmtJSE4xWTJObGMzTm1kV3hzZVlraUp3VmxSSWtpSndSbFJDTVNRUUFiSndRaVo0QVVVR3hoZEdadmNtMGdaR1ZoWTNScGRtRjBaV1NKSndRalo0QVNVR3hoZEdadmNtMGdZV04wYVhaaGRHVmtpU0lyWlVRaURrRUFJNEFnVG04Z1ptVmxjeUJoZG1GcGJHRmliR1VnWm05eUlHTnZiR3hsWTNScGIyNkpLeUpuZ0NSUWJHRjBabTl5YlNCbVpXVnpJR052Ykd4bFkzUmxaQ0J6ZFdOalpYTnpablZzYkhtSklpdGxSSWtpSndSbFJDTVNRUUF2Z0N4QmJHZHZRM0psWkdsMElGQnNZWFJtYjNKdElIUmxjM1FnYzNWalkyVnpjMloxYkNBdElFRkRWRWxXUlltQUxrRnNaMjlEY21Wa2FYUWdVR3hoZEdadmNtMGdkR1Z6ZENCemRXTmpaWE56Wm5Wc0lDMGdTVTVCUTFSSlZrV0oiLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo3LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
