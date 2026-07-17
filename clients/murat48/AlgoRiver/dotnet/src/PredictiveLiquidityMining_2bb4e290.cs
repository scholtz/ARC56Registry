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

namespace Arc56.Generated.murat48.AlgoRiver.PredictiveLiquidityMining_2bb4e290
{


    //
    // Predictive Liquidity Mining Platform Smart Contract
    //Features: AI-powered predictions, dynamic rewards, risk scoring, Data-Donor DAO
    //
    public class PredictiveLiquidityMiningProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PredictiveLiquidityMiningProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Create a new liquidity pool with AI prediction capabilities
        ///</summary>
        /// <param name="poolName"> </param>
        /// <param name="initialAPY"> </param>
        /// <param name="riskLevel"> </param>
        /// <param name="minStake"> </param>
        public async Task<string> CreatePool(string poolName, string initialAPY, string riskLevel, string minStake, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 195, 185, 146, 42 };
            var poolNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); poolNameAbi.From(poolName);
            var initialAPYAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); initialAPYAbi.From(initialAPY);
            var riskLevelAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); riskLevelAbi.From(riskLevel);
            var minStakeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); minStakeAbi.From(minStake);

            var result = await base.CallApp(new List<object> { abiHandle, poolNameAbi, initialAPYAbi, riskLevelAbi, minStakeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> CreatePool_Transactions(string poolName, string initialAPY, string riskLevel, string minStake, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 195, 185, 146, 42 };
            var poolNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); poolNameAbi.From(poolName);
            var initialAPYAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); initialAPYAbi.From(initialAPY);
            var riskLevelAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); riskLevelAbi.From(riskLevel);
            var minStakeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); minStakeAbi.From(minStake);

            return await base.MakeTransactionList(new List<object> { abiHandle, poolNameAbi, initialAPYAbi, riskLevelAbi, minStakeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Stake tokens in a specific pool
        ///</summary>
        /// <param name="poolId"> </param>
        /// <param name="amount"> </param>
        /// <param name="userAddress"> </param>
        public async Task<string> StakeInPool(string poolId, string amount, string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 150, 206, 171, 169 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); poolIdAbi.From(poolId);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); amountAbi.From(amount);
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            var result = await base.CallApp(new List<object> { abiHandle, poolIdAbi, amountAbi, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> StakeInPool_Transactions(string poolId, string amount, string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 150, 206, 171, 169 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); poolIdAbi.From(poolId);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); amountAbi.From(amount);
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, poolIdAbi, amountAbi, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Unstake tokens from a specific pool
        ///</summary>
        /// <param name="poolId"> </param>
        /// <param name="amount"> </param>
        /// <param name="userAddress"> </param>
        public async Task<string> UnstakeFromPool(string poolId, string amount, string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 90, 65, 183, 161 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); poolIdAbi.From(poolId);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); amountAbi.From(amount);
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            var result = await base.CallApp(new List<object> { abiHandle, poolIdAbi, amountAbi, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> UnstakeFromPool_Transactions(string poolId, string amount, string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 90, 65, 183, 161 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); poolIdAbi.From(poolId);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); amountAbi.From(amount);
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, poolIdAbi, amountAbi, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Emergency withdraw (with potential penalties)
        ///</summary>
        /// <param name="poolId"> </param>
        /// <param name="userAddress"> </param>
        public async Task<string> EmergencyWithdraw(string poolId, string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 231, 25, 189, 189 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); poolIdAbi.From(poolId);
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            var result = await base.CallApp(new List<object> { abiHandle, poolIdAbi, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> EmergencyWithdraw_Transactions(string poolId, string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 231, 25, 189, 189 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); poolIdAbi.From(poolId);
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, poolIdAbi, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get user's staked amount in a pool
        ///</summary>
        /// <param name="poolId"> </param>
        /// <param name="userAddress"> </param>
        public async Task<string> GetUserStake(string poolId, string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 11, 119, 47 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); poolIdAbi.From(poolId);
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            var result = await base.CallApp(new List<object> { abiHandle, poolIdAbi, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetUserStake_Transactions(string poolId, string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 11, 119, 47 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); poolIdAbi.From(poolId);
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, poolIdAbi, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update AI prediction for a pool (admin/oracle function)
        ///</summary>
        /// <param name="poolId"> </param>
        /// <param name="newAPY"> </param>
        /// <param name="confidence"> </param>
        /// <param name="timeframe"> </param>
        public async Task<string> UpdateAiPrediction(string poolId, string newAPY, string confidence, string timeframe, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 216, 66, 31, 29 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); poolIdAbi.From(poolId);
            var newAPYAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); newAPYAbi.From(newAPY);
            var confidenceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); confidenceAbi.From(confidence);
            var timeframeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); timeframeAbi.From(timeframe);

            var result = await base.CallApp(new List<object> { abiHandle, poolIdAbi, newAPYAbi, confidenceAbi, timeframeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> UpdateAiPrediction_Transactions(string poolId, string newAPY, string confidence, string timeframe, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 216, 66, 31, 29 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); poolIdAbi.From(poolId);
            var newAPYAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); newAPYAbi.From(newAPY);
            var confidenceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); confidenceAbi.From(confidence);
            var timeframeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); timeframeAbi.From(timeframe);

            return await base.MakeTransactionList(new List<object> { abiHandle, poolIdAbi, newAPYAbi, confidenceAbi, timeframeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Submit training data for AI models (Data-Donor DAO)
        ///</summary>
        /// <param name="contributor"> </param>
        /// <param name="dataType"> </param>
        /// <param name="dataHash"> </param>
        /// <param name="poolId"> </param>
        public async Task<string> SubmitTrainingData(string contributor, string dataType, string dataHash, string poolId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 100, 18, 72 };
            var contributorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); contributorAbi.From(contributor);
            var dataTypeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); dataTypeAbi.From(dataType);
            var dataHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); dataHashAbi.From(dataHash);
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); poolIdAbi.From(poolId);

            var result = await base.CallApp(new List<object> { abiHandle, contributorAbi, dataTypeAbi, dataHashAbi, poolIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> SubmitTrainingData_Transactions(string contributor, string dataType, string dataHash, string poolId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 100, 18, 72 };
            var contributorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); contributorAbi.From(contributor);
            var dataTypeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); dataTypeAbi.From(dataType);
            var dataHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); dataHashAbi.From(dataHash);
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); poolIdAbi.From(poolId);

            return await base.MakeTransactionList(new List<object> { abiHandle, contributorAbi, dataTypeAbi, dataHashAbi, poolIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Vote on DAO governance proposals
        ///</summary>
        /// <param name="proposalId"> </param>
        /// <param name="vote"> </param>
        /// <param name="voter"> </param>
        public async Task<string> VoteOnProposal(string proposalId, bool vote, string voter, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 198, 31, 239 };
            var proposalIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); proposalIdAbi.From(proposalId);
            var voteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); voteAbi.From(vote);
            var voterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); voterAbi.From(voter);

            var result = await base.CallApp(new List<object> { abiHandle, proposalIdAbi, voteAbi, voterAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> VoteOnProposal_Transactions(string proposalId, bool vote, string voter, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 198, 31, 239 };
            var proposalIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); proposalIdAbi.From(proposalId);
            var voteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); voteAbi.From(vote);
            var voterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); voterAbi.From(voter);

            return await base.MakeTransactionList(new List<object> { abiHandle, proposalIdAbi, voteAbi, voterAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Calculate user's risk score based on behavior and portfolio
        ///</summary>
        /// <param name="userAddress"> </param>
        /// <param name="portfolioValue"> </param>
        /// <param name="tradingFrequency"> </param>
        public async Task<string> CalculateUserRiskScore(string userAddress, string portfolioValue, string tradingFrequency, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 236, 201, 14 };
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);
            var portfolioValueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); portfolioValueAbi.From(portfolioValue);
            var tradingFrequencyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); tradingFrequencyAbi.From(tradingFrequency);

            var result = await base.CallApp(new List<object> { abiHandle, userAddressAbi, portfolioValueAbi, tradingFrequencyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> CalculateUserRiskScore_Transactions(string userAddress, string portfolioValue, string tradingFrequency, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 236, 201, 14 };
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);
            var portfolioValueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); portfolioValueAbi.From(portfolioValue);
            var tradingFrequencyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); tradingFrequencyAbi.From(tradingFrequency);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAddressAbi, portfolioValueAbi, tradingFrequencyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Claim rewards with AI-enhanced calculations
        ///</summary>
        /// <param name="userAddress"> </param>
        /// <param name="poolId"> </param>
        public async Task<string> ClaimRewards(string userAddress, string poolId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 99, 183, 68, 37 };
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); poolIdAbi.From(poolId);

            var result = await base.CallApp(new List<object> { abiHandle, userAddressAbi, poolIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> ClaimRewards_Transactions(string userAddress, string poolId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 99, 183, 68, 37 };
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); poolIdAbi.From(poolId);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAddressAbi, poolIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get pool statistics with AI predictions
        ///</summary>
        /// <param name="poolId"> </param>
        public async Task<string> GetPoolStats(string poolId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 221, 250, 159, 40 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); poolIdAbi.From(poolId);

            var result = await base.CallApp(new List<object> { abiHandle, poolIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetPoolStats_Transactions(string poolId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 221, 250, 159, 40 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); poolIdAbi.From(poolId);

            return await base.MakeTransactionList(new List<object> { abiHandle, poolIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Emergency pause mechanism for security
        ///</summary>
        public async Task<string> EmergencyPause(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 5, 29, 122 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> EmergencyPause_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 5, 29, 122 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get user portfolio summary
        ///</summary>
        /// <param name="userAddress"> </param>
        public async Task<string> GetUserPortfolio(string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 11, 78, 99 };
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            var result = await base.CallApp(new List<object> { abiHandle, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetUserPortfolio_Transactions(string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 11, 78, 99 };
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get platform analytics
        ///</summary>
        public async Task<string> GetPlatformAnalytics(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 193, 137, 52, 251 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetPlatformAnalytics_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 193, 137, 52, 251 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUHJlZGljdGl2ZUxpcXVpZGl0eU1pbmluZyIsImRlc2MiOiJQcmVkaWN0aXZlIExpcXVpZGl0eSBNaW5pbmcgUGxhdGZvcm0gU21hcnQgQ29udHJhY3RcbkZlYXR1cmVzOiBBSS1wb3dlcmVkIHByZWRpY3Rpb25zLCBkeW5hbWljIHJld2FyZHMsIHJpc2sgc2NvcmluZywgRGF0YS1Eb25vciBEQU8iLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlUG9vbCIsImRlc2MiOiJDcmVhdGUgYSBuZXcgbGlxdWlkaXR5IHBvb2wgd2l0aCBBSSBwcmVkaWN0aW9uIGNhcGFiaWxpdGllcyIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwb29sTmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5pdGlhbEFQWSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmlza0xldmVsIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtaW5TdGFrZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InN0YWtlSW5Qb29sIiwiZGVzYyI6IlN0YWtlIHRva2VucyBpbiBhIHNwZWNpZmljIHBvb2wiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicG9vbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXJBZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidW5zdGFrZUZyb21Qb29sIiwiZGVzYyI6IlVuc3Rha2UgdG9rZW5zIGZyb20gYSBzcGVjaWZpYyBwb29sIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBvb2xJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyQWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImVtZXJnZW5jeVdpdGhkcmF3IiwiZGVzYyI6IkVtZXJnZW5jeSB3aXRoZHJhdyAod2l0aCBwb3RlbnRpYWwgcGVuYWx0aWVzKSIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwb29sSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXJBZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0VXNlclN0YWtlIiwiZGVzYyI6IkdldCB1c2VyJ3Mgc3Rha2VkIGFtb3VudCBpbiBhIHBvb2wiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicG9vbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyQWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZUFJUHJlZGljdGlvbiIsImRlc2MiOiJVcGRhdGUgQUkgcHJlZGljdGlvbiBmb3IgYSBwb29sIChhZG1pbi9vcmFjbGUgZnVuY3Rpb24pIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBvb2xJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3QVBZIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjb25maWRlbmNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0aW1lZnJhbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzdWJtaXRUcmFpbmluZ0RhdGEiLCJkZXNjIjoiU3VibWl0IHRyYWluaW5nIGRhdGEgZm9yIEFJIG1vZGVscyAoRGF0YS1Eb25vciBEQU8pIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvbnRyaWJ1dG9yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhVHlwZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YUhhc2giLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBvb2xJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZvdGVPblByb3Bvc2FsIiwiZGVzYyI6IlZvdGUgb24gREFPIGdvdmVybmFuY2UgcHJvcG9zYWxzIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb3Bvc2FsSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2b3RlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2b3RlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhbGN1bGF0ZVVzZXJSaXNrU2NvcmUiLCJkZXNjIjoiQ2FsY3VsYXRlIHVzZXIncyByaXNrIHNjb3JlIGJhc2VkIG9uIGJlaGF2aW9yIGFuZCBwb3J0Zm9saW8iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlckFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBvcnRmb2xpb1ZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0cmFkaW5nRnJlcXVlbmN5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2xhaW1SZXdhcmRzIiwiZGVzYyI6IkNsYWltIHJld2FyZHMgd2l0aCBBSS1lbmhhbmNlZCBjYWxjdWxhdGlvbnMiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlckFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBvb2xJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFBvb2xTdGF0cyIsImRlc2MiOiJHZXQgcG9vbCBzdGF0aXN0aWNzIHdpdGggQUkgcHJlZGljdGlvbnMiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicG9vbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZW1lcmdlbmN5UGF1c2UiLCJkZXNjIjoiRW1lcmdlbmN5IHBhdXNlIG1lY2hhbmlzbSBmb3Igc2VjdXJpdHkiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRVc2VyUG9ydGZvbGlvIiwiZGVzYyI6IkdldCB1c2VyIHBvcnRmb2xpbyBzdW1tYXJ5IiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXJBZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0UGxhdGZvcm1BbmFseXRpY3MiLCJkZXNjIjoiR2V0IHBsYXRmb3JtIGFuYWx5dGljcyIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTQzLDMxMywzNDMsNDE5LDQ0OSw0ODUsNTI3LDU2OCw2MTYsNjY0LDcwMCw3MzYsNzc4LDgyMF0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg3M10sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0NiwzMTYsMzQ2LDQyMiw0NTIsNDg4LDUzMCw1NzEsNjE5LDY2Nyw3MDMsNzM5LDc4MSw4MjNdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0TVRVeFpqZGpOelVnSWxCdmIyd2dJaUFpSUdKNUlIVnpaWElnSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamNLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCUWNtVmthV04wYVhabFRHbHhkV2xrYVhSNVRXbHVhVzVuSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZZbUZ5WlY5eWIzVjBhVzVuUURFNUNpQWdJQ0J3ZFhOb1lubDBaWE56SURCNFl6TmlPVGt5TW1FZ01IZzVObU5sWVdKaE9TQXdlRFZoTkRGaU4yRXhJREI0WlRjeE9XSmtZbVFnTUhoaE9UQmlOemN5WmlBd2VHUTROREl4WmpGa0lEQjRObU0yTkRFeU5EZ2dNSGd6TUdNMk1XWmxaaUF3ZURrd1pXTmpPVEJsSURCNE5qTmlOelEwTWpVZ01IaGtaR1poT1dZeU9DQXdlREJrTURVeFpEZGhJREI0Wm1Jd1lqUmxOak1nTUhoak1UZzVNelJtWWlBdkx5QnRaWFJvYjJRZ0ltTnlaV0YwWlZCdmIyd29jM1J5YVc1bkxITjBjbWx1Wnl4emRISnBibWNzYzNSeWFXNW5LWE4wY21sdVp5SXNJRzFsZEdodlpDQWljM1JoYTJWSmJsQnZiMndvYzNSeWFXNW5MSE4wY21sdVp5eHpkSEpwYm1jcGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKMWJuTjBZV3RsUm5KdmJWQnZiMndvYzNSeWFXNW5MSE4wY21sdVp5eHpkSEpwYm1jcGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKbGJXVnlaMlZ1WTNsWGFYUm9aSEpoZHloemRISnBibWNzYzNSeWFXNW5LWE4wY21sdVp5SXNJRzFsZEdodlpDQWlaMlYwVlhObGNsTjBZV3RsS0hOMGNtbHVaeXh6ZEhKcGJtY3BjM1J5YVc1bklpd2diV1YwYUc5a0lDSjFjR1JoZEdWQlNWQnlaV1JwWTNScGIyNG9jM1J5YVc1bkxITjBjbWx1Wnl4emRISnBibWNzYzNSeWFXNW5LWE4wY21sdVp5SXNJRzFsZEdodlpDQWljM1ZpYldsMFZISmhhVzVwYm1kRVlYUmhLSE4wY21sdVp5eHpkSEpwYm1jc2MzUnlhVzVuTEhOMGNtbHVaeWx6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJblp2ZEdWUGJsQnliM0J2YzJGc0tITjBjbWx1Wnl4aWIyOXNMSE4wY21sdVp5bHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0ltTmhiR04xYkdGMFpWVnpaWEpTYVhOclUyTnZjbVVvYzNSeWFXNW5MSE4wY21sdVp5eHpkSEpwYm1jcGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKamJHRnBiVkpsZDJGeVpITW9jM1J5YVc1bkxITjBjbWx1WnlsemRISnBibWNpTENCdFpYUm9iMlFnSW1kbGRGQnZiMnhUZEdGMGN5aHpkSEpwYm1jcGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKbGJXVnlaMlZ1WTNsUVlYVnpaU2dwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0puWlhSVmMyVnlVRzl5ZEdadmJHbHZLSE4wY21sdVp5bHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0ltZGxkRkJzWVhSbWIzSnRRVzVoYkhsMGFXTnpLQ2x6ZEhKcGJtY2lDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgyTnlaV0YwWlZCdmIyeGZjbTkxZEdWQU15QnRZV2x1WDNOMFlXdGxTVzVRYjI5c1gzSnZkWFJsUURRZ2JXRnBibDkxYm5OMFlXdGxSbkp2YlZCdmIyeGZjbTkxZEdWQU5TQnRZV2x1WDJWdFpYSm5aVzVqZVZkcGRHaGtjbUYzWDNKdmRYUmxRRFlnYldGcGJsOW5aWFJWYzJWeVUzUmhhMlZmY205MWRHVkFOeUJ0WVdsdVgzVndaR0YwWlVGSlVISmxaR2xqZEdsdmJsOXliM1YwWlVBNElHMWhhVzVmYzNWaWJXbDBWSEpoYVc1cGJtZEVZWFJoWDNKdmRYUmxRRGtnYldGcGJsOTJiM1JsVDI1UWNtOXdiM05oYkY5eWIzVjBaVUF4TUNCdFlXbHVYMk5oYkdOMWJHRjBaVlZ6WlhKU2FYTnJVMk52Y21WZmNtOTFkR1ZBTVRFZ2JXRnBibDlqYkdGcGJWSmxkMkZ5WkhOZmNtOTFkR1ZBTVRJZ2JXRnBibDluWlhSUWIyOXNVM1JoZEhOZmNtOTFkR1ZBTVRNZ2JXRnBibDlsYldWeVoyVnVZM2xRWVhWelpWOXliM1YwWlVBeE5DQnRZV2x1WDJkbGRGVnpaWEpRYjNKMFptOXNhVzlmY205MWRHVkFNVFVnYldGcGJsOW5aWFJRYkdGMFptOXliVUZ1WVd4NWRHbGpjMTl5YjNWMFpVQXhOZ29LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlFjbVZrYVdOMGFYWmxUR2x4ZFdsa2FYUjVUV2x1YVc1bklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUlFiR0YwWm05eWJVRnVZV3g1ZEdsamMxOXliM1YwWlVBeE5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5qRUtJQ0FnSUM4dklHZGxkRkJzWVhSbWIzSnRRVzVoYkhsMGFXTnpLQ2s2SUhOMGNtbHVaeUI3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFNREE1TnpVd05tTTJNVGMwTmpZMlpqY3lObVF5TURReE5tVTJNVFpqTnprM05EWTVOak0zTXpOaE1qQTFORFptTnpRMk1UWmpNakEzTURabU5tWTJZemN6TTJFeU1ETTBNemN5WXpJd05ERTJNemMwTmprM05qWTFNakEyWkRZNU5tVTJOVGN5TnpNellUSXdNekV5WXpNeU16TXpOREpqTWpBMU5EWm1OelEyTVRaak1qQTNNalkxTnpjMk1UY3lOalEzTXpJd05qUTJPVGN6TnpRM01qWTVOakkzTlRjME5qVTJORE5oTWpBek1UTXlNelV5WXpNd016QXpNREl3TnpRMlpqWmlOalUyWlRjek1tTXlNRFF4TnpZMk5UY3lOakUyTnpZMU1qQTBNVFV3TlRrellUSXdNekV6TWpKbE16VXlOVEpqTWpBME1UUTVNakEzTURjeU5qVTJORFk1TmpNM05EWTVObVkyWlRJd05qRTJNell6TnpVM01qWXhOak0zT1ROaE1qQXpPRE0zTW1Vek16STFDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBWWE5sY2xCdmNuUm1iMnhwYjE5eWIzVjBaVUF4TlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlRRS0lDQWdJQzh2SUdkbGRGVnpaWEpRYjNKMFptOXNhVzhvZFhObGNrRmtaSEpsYzNNNklITjBjbWx1WnlrNklITjBjbWx1WnlCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1VISmxaR2xqZEdsMlpVeHBjWFZwWkdsMGVVMXBibWx1WnlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFUwQ2lBZ0lDQXZMeUJuWlhSVmMyVnlVRzl5ZEdadmJHbHZLSFZ6WlhKQlpHUnlaWE56T2lCemRISnBibWNwT2lCemRISnBibWNnZXdvZ0lDQWdZMkZzYkhOMVlpQm5aWFJWYzJWeVVHOXlkR1p2YkdsdkNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlsYldWeVoyVnVZM2xRWVhWelpWOXliM1YwWlVBeE5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5EY0tJQ0FnSUM4dklHVnRaWEpuWlc1amVWQmhkWE5sS0NrNklITjBjbWx1WnlCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxTURBellUVXdObU0yTVRjME5qWTJaamN5Tm1ReU1EY3dOakUzTlRjek5qVTJOREl3TmpZMlpqY3lNakEyWkRZeE5qazJaVGMwTmpVMlpUWXhObVUyTXpZMU1tVXlNRFF4Tm1NMll6SXdObVkzTURZMU56STJNVGMwTmprMlpqWmxOek15TURjek56VTNNemN3TmpVMlpUWTBOalUyTkRKbENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFVHOXZiRk4wWVhSelgzSnZkWFJsUURFek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFek9Rb2dJQ0FnTHk4Z1oyVjBVRzl2YkZOMFlYUnpLSEJ2YjJ4SlpEb2djM1J5YVc1bktUb2djM1J5YVc1bklIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlFjbVZrYVdOMGFYWmxUR2x4ZFdsa2FYUjVUV2x1YVc1bklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXprS0lDQWdJQzh2SUdkbGRGQnZiMnhUZEdGMGN5aHdiMjlzU1dRNklITjBjbWx1WnlrNklITjBjbWx1WnlCN0NpQWdJQ0JqWVd4c2MzVmlJR2RsZEZCdmIyeFRkR0YwY3dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZMnhoYVcxU1pYZGhjbVJ6WDNKdmRYUmxRREV5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5TmkweE1qa0tJQ0FnSUM4dklHTnNZV2x0VW1WM1lYSmtjeWdLSUNBZ0lDOHZJQ0FnSUNCMWMyVnlRV1JrY21WemN6b2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJSEJ2YjJ4SlpEb2djM1J5YVc1bkNpQWdJQ0F2THlBcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TndvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGQnlaV1JwWTNScGRtVk1hWEYxYVdScGRIbE5hVzVwYm1jZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNall0TVRJNUNpQWdJQ0F2THlCamJHRnBiVkpsZDJGeVpITW9DaUFnSUNBdkx5QWdJQ0FnZFhObGNrRmtaSEpsYzNNNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQndiMjlzU1dRNklITjBjbWx1WndvZ0lDQWdMeThnS1RvZ2MzUnlhVzVuSUhzS0lDQWdJR05oYkd4emRXSWdZMnhoYVcxU1pYZGhjbVJ6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWpZV3hqZFd4aGRHVlZjMlZ5VW1semExTmpiM0psWDNKdmRYUmxRREV4T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4TkMweE1UZ0tJQ0FnSUM4dklHTmhiR04xYkdGMFpWVnpaWEpTYVhOclUyTnZjbVVvQ2lBZ0lDQXZMeUFnSUNBZ2RYTmxja0ZrWkhKbGMzTTZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdJQ0J3YjNKMFptOXNhVzlXWVd4MVpUb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJSFJ5WVdScGJtZEdjbVZ4ZFdWdVkzazZJSE4wY21sdVp3b2dJQ0FnTHk4Z0tUb2djM1J5YVc1bklIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlFjbVZrYVdOMGFYWmxUR2x4ZFdsa2FYUjVUV2x1YVc1bklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhOQzB4TVRnS0lDQWdJQzh2SUdOaGJHTjFiR0YwWlZWelpYSlNhWE5yVTJOdmNtVW9DaUFnSUNBdkx5QWdJQ0FnZFhObGNrRmtaSEpsYzNNNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQndiM0owWm05c2FXOVdZV3gxWlRvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNBZ0lIUnlZV1JwYm1kR2NtVnhkV1Z1WTNrNklITjBjbWx1WndvZ0lDQWdMeThnS1RvZ2MzUnlhVzVuSUhzS0lDQWdJR05oYkd4emRXSWdZMkZzWTNWc1lYUmxWWE5sY2xKcGMydFRZMjl5WlFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkbTkwWlU5dVVISnZjRzl6WVd4ZmNtOTFkR1ZBTVRBNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBeUxURXdOZ29nSUNBZ0x5OGdkbTkwWlU5dVVISnZjRzl6WVd3b0NpQWdJQ0F2THlBZ0lDQWdjSEp2Y0c5ellXeEpaRG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0FnSUhadmRHVTZJR0p2YjJ4bFlXNHNDaUFnSUNBdkx5QWdJQ0FnZG05MFpYSTZJSE4wY21sdVp3b2dJQ0FnTHk4Z0tUb2djM1J5YVc1bklIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlFjbVZrYVdOMGFYWmxUR2x4ZFdsa2FYUjVUV2x1YVc1bklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEF5TFRFd05nb2dJQ0FnTHk4Z2RtOTBaVTl1VUhKdmNHOXpZV3dvQ2lBZ0lDQXZMeUFnSUNBZ2NISnZjRzl6WVd4SlpEb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJSFp2ZEdVNklHSnZiMnhsWVc0c0NpQWdJQ0F2THlBZ0lDQWdkbTkwWlhJNklITjBjbWx1WndvZ0lDQWdMeThnS1RvZ2MzUnlhVzVuSUhzS0lDQWdJR05oYkd4emRXSWdkbTkwWlU5dVVISnZjRzl6WVd3S0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM04xWW0xcGRGUnlZV2x1YVc1blJHRjBZVjl5YjNWMFpVQTVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzRMVGd6Q2lBZ0lDQXZMeUJ6ZFdKdGFYUlVjbUZwYm1sdVowUmhkR0VvQ2lBZ0lDQXZMeUFnSUNBZ1kyOXVkSEpwWW5WMGIzSTZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdJQ0JrWVhSaFZIbHdaVG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0FnSUdSaGRHRklZWE5vT2lCemRISnBibWNzQ2lBZ0lDQXZMeUFnSUNBZ2NHOXZiRWxrT2lCemRISnBibWNLSUNBZ0lDOHZJQ2s2SUhOMGNtbHVaeUI3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVUhKbFpHbGpkR2wyWlV4cGNYVnBaR2wwZVUxcGJtbHVaeUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOemd0T0RNS0lDQWdJQzh2SUhOMVltMXBkRlJ5WVdsdWFXNW5SR0YwWVNnS0lDQWdJQzh2SUNBZ0lDQmpiMjUwY21saWRYUnZjam9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0FnSUdSaGRHRlVlWEJsT2lCemRISnBibWNzQ2lBZ0lDQXZMeUFnSUNBZ1pHRjBZVWhoYzJnNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQndiMjlzU1dRNklITjBjbWx1WndvZ0lDQWdMeThnS1RvZ2MzUnlhVzVuSUhzS0lDQWdJR05oYkd4emRXSWdjM1ZpYldsMFZISmhhVzVwYm1kRVlYUmhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MWNHUmhkR1ZCU1ZCeVpXUnBZM1JwYjI1ZmNtOTFkR1ZBT0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTmkwM01Rb2dJQ0FnTHk4Z2RYQmtZWFJsUVVsUWNtVmthV04wYVc5dUtBb2dJQ0FnTHk4Z0lDQWdJSEJ2YjJ4SlpEb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJRzVsZDBGUVdUb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJR052Ym1acFpHVnVZMlU2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCMGFXMWxabkpoYldVNklITjBjbWx1WndvZ0lDQWdMeThnS1RvZ2MzUnlhVzVuSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamNLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCUWNtVmthV04wYVhabFRHbHhkV2xrYVhSNVRXbHVhVzVuSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTmkwM01Rb2dJQ0FnTHk4Z2RYQmtZWFJsUVVsUWNtVmthV04wYVc5dUtBb2dJQ0FnTHk4Z0lDQWdJSEJ2YjJ4SlpEb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJRzVsZDBGUVdUb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJR052Ym1acFpHVnVZMlU2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCMGFXMWxabkpoYldVNklITjBjbWx1WndvZ0lDQWdMeThnS1RvZ2MzUnlhVzVuSUhzS0lDQWdJR05oYkd4emRXSWdkWEJrWVhSbFFVbFFjbVZrYVdOMGFXOXVDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUlZjMlZ5VTNSaGEyVmZjbTkxZEdWQU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU5pMDFPUW9nSUNBZ0x5OGdaMlYwVlhObGNsTjBZV3RsS0FvZ0lDQWdMeThnSUNBZ0lIQnZiMnhKWkRvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNBZ0lIVnpaWEpCWkdSeVpYTnpPaUJ6ZEhKcGJtY0tJQ0FnSUM4dklDazZJSE4wY21sdVp5QjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM0NpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdVSEpsWkdsamRHbDJaVXhwY1hWcFpHbDBlVTFwYm1sdVp5QmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUyTFRVNUNpQWdJQ0F2THlCblpYUlZjMlZ5VTNSaGEyVW9DaUFnSUNBdkx5QWdJQ0FnY0c5dmJFbGtPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnZFhObGNrRmtaSEpsYzNNNklITjBjbWx1WndvZ0lDQWdMeThnS1RvZ2MzUnlhVzVuSUhzS0lDQWdJR05oYkd4emRXSWdaMlYwVlhObGNsTjBZV3RsQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWxiV1Z5WjJWdVkzbFhhWFJvWkhKaGQxOXliM1YwWlVBMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRMkxUUTVDaUFnSUNBdkx5QmxiV1Z5WjJWdVkzbFhhWFJvWkhKaGR5Z0tJQ0FnSUM4dklDQWdJQ0J3YjI5c1NXUTZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdJQ0IxYzJWeVFXUmtjbVZ6Y3pvZ2MzUnlhVzVuQ2lBZ0lDQXZMeUFwT2lCemRISnBibWNnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOd29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZCeVpXUnBZM1JwZG1WTWFYRjFhV1JwZEhsTmFXNXBibWNnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME5pMDBPUW9nSUNBZ0x5OGdaVzFsY21kbGJtTjVWMmwwYUdSeVlYY29DaUFnSUNBdkx5QWdJQ0FnY0c5dmJFbGtPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnZFhObGNrRmtaSEpsYzNNNklITjBjbWx1WndvZ0lDQWdMeThnS1RvZ2MzUnlhVzVuSUhzS0lDQWdJR05oYkd4emRXSWdaVzFsY21kbGJtTjVWMmwwYUdSeVlYY0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNWdWMzUmhhMlZHY205dFVHOXZiRjl5YjNWMFpVQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTFMVE01Q2lBZ0lDQXZMeUIxYm5OMFlXdGxSbkp2YlZCdmIyd29DaUFnSUNBdkx5QWdJQ0FnY0c5dmJFbGtPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnZFhObGNrRmtaSEpsYzNNNklITjBjbWx1WndvZ0lDQWdMeThnS1RvZ2MzUnlhVzVuSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamNLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCUWNtVmthV04wYVhabFRHbHhkV2xrYVhSNVRXbHVhVzVuSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNMUxUTTVDaUFnSUNBdkx5QjFibk4wWVd0bFJuSnZiVkJ2YjJ3b0NpQWdJQ0F2THlBZ0lDQWdjRzl2YkVsa09pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1ME9pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDQWdkWE5sY2tGa1pISmxjM002SUhOMGNtbHVad29nSUNBZ0x5OGdLVG9nYzNSeWFXNW5JSHNLSUNBZ0lHTmhiR3h6ZFdJZ2RXNXpkR0ZyWlVaeWIyMVFiMjlzQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXpkR0ZyWlVsdVVHOXZiRjl5YjNWMFpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTBMVEk0Q2lBZ0lDQXZMeUJ6ZEdGclpVbHVVRzl2YkNnS0lDQWdJQzh2SUNBZ0lDQndiMjlzU1dRNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5RNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQjFjMlZ5UVdSa2NtVnpjem9nYzNSeWFXNW5DaUFnSUNBdkx5QXBPaUJ6ZEhKcGJtY2dld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk53b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRkJ5WldScFkzUnBkbVZNYVhGMWFXUnBkSGxOYVc1cGJtY2daWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalF0TWpnS0lDQWdJQzh2SUhOMFlXdGxTVzVRYjI5c0tBb2dJQ0FnTHk4Z0lDQWdJSEJ2YjJ4SlpEb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJSFZ6WlhKQlpHUnlaWE56T2lCemRISnBibWNLSUNBZ0lDOHZJQ2s2SUhOMGNtbHVaeUI3Q2lBZ0lDQmpZV3hzYzNWaUlITjBZV3RsU1c1UWIyOXNDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5amNtVmhkR1ZRYjI5c1gzSnZkWFJsUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJdE1UY0tJQ0FnSUM4dklHTnlaV0YwWlZCdmIyd29DaUFnSUNBdkx5QWdJQ0FnY0c5dmJFNWhiV1U2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCcGJtbDBhV0ZzUVZCWk9pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDQWdjbWx6YTB4bGRtVnNPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnYldsdVUzUmhhMlU2SUhOMGNtbHVad29nSUNBZ0x5OGdLVG9nYzNSeWFXNW5JSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY0tJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJRY21Wa2FXTjBhWFpsVEdseGRXbGthWFI1VFdsdWFXNW5JR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNaTB4TndvZ0lDQWdMeThnWTNKbFlYUmxVRzl2YkNnS0lDQWdJQzh2SUNBZ0lDQndiMjlzVG1GdFpUb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJR2x1YVhScFlXeEJVRms2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCeWFYTnJUR1YyWld3NklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQnRhVzVUZEdGclpUb2djM1J5YVc1bkNpQWdJQ0F2THlBcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnWTJGc2JITjFZaUJqY21WaGRHVlFiMjlzQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWlZWEpsWDNKdmRYUnBibWRBTVRrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TndvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGQnlaV1JwWTNScGRtVk1hWEYxYVdScGRIbE5hVzVwYm1jZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREl6Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlVISmxaR2xqZEdsMlpVeHBjWFZwWkdsMGVVMXBibWx1Wnk1amNtVmhkR1ZRYjI5c0tIQnZiMnhPWVcxbE9pQmllWFJsY3l3Z2FXNXBkR2xoYkVGUVdUb2dZbmwwWlhNc0lISnBjMnRNWlhabGJEb2dZbmwwWlhNc0lHMXBibE4wWVd0bE9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNtTnlaV0YwWlZCdmIydzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USXRNVGNLSUNBZ0lDOHZJR055WldGMFpWQnZiMndvQ2lBZ0lDQXZMeUFnSUNBZ2NHOXZiRTVoYldVNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQnBibWwwYVdGc1FWQlpPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnY21semEweGxkbVZzT2lCemRISnBibWNzQ2lBZ0lDQXZMeUFnSUNBZ2JXbHVVM1JoYTJVNklITjBjbWx1WndvZ0lDQWdMeThnS1RvZ2MzUnlhVzVuSUhzS0lDQWdJSEJ5YjNSdklEUWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTRDaUFnSUNBdkx5QnlaWFIxY200Z1lGQnZiMndnSkh0d2IyOXNUbUZ0WlgwZ1kzSmxZWFJsWkNCM2FYUm9JQ1I3YVc1cGRHbGhiRUZRV1gwbElFRlFXU3dnY21semF5QnNaWFpsYkRvZ0pIdHlhWE5yVEdWMlpXeDlMQ0J0YVc1cGJYVnRJSE4wWVd0bE9pQWtlMjFwYmxOMFlXdGxmU0J0YVdOeWIwRnNaMjl6WUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpVUc5dmJDQWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklDSWdZM0psWVhSbFpDQjNhWFJvSUNJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBaUpTQkJVRmtzSUhKcGMyc2diR1YyWld3NklDSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlMQ0J0YVc1cGJYVnRJSE4wWVd0bE9pQWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJaUJ0YVdOeWIwRnNaMjl6SWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xCeVpXUnBZM1JwZG1WTWFYRjFhV1JwZEhsTmFXNXBibWN1YzNSaGEyVkpibEJ2YjJ3b2NHOXZiRWxrT2lCaWVYUmxjeXdnWVcxdmRXNTBPaUJpZVhSbGN5d2dkWE5sY2tGa1pISmxjM002SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LYzNSaGEyVkpibEJ2YjJ3NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpRdE1qZ0tJQ0FnSUM4dklITjBZV3RsU1c1UWIyOXNLQW9nSUNBZ0x5OGdJQ0FnSUhCdmIyeEpaRG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0FnSUhWelpYSkJaR1J5WlhOek9pQnpkSEpwYm1jS0lDQWdJQzh2SUNrNklITjBjbWx1WnlCN0NpQWdJQ0J3Y205MGJ5QXpJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPUW9nSUNBZ0x5OGdjbVYwZFhKdUlHQlRkV05qWlhOelpuVnNiSGtnYzNSaGEyVmtJQ1I3WVcxdmRXNTBmU0J0YVdOeWIwRnNaMjl6SUdsdUlIQnZiMndnSkh0d2IyOXNTV1I5SUdKNUlIVnpaWElnSkh0MWMyVnlRV1JrY21WemMzMWdDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lsTjFZMk5sYzNObWRXeHNlU0J6ZEdGclpXUWdJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlJRzFwWTNKdlFXeG5iM01nYVc0Z2NHOXZiQ0FpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNJZ1lua2dkWE5sY2lBaUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sQnlaV1JwWTNScGRtVk1hWEYxYVdScGRIbE5hVzVwYm1jdWRXNXpkR0ZyWlVaeWIyMVFiMjlzS0hCdmIyeEpaRG9nWW5sMFpYTXNJR0Z0YjNWdWREb2dZbmwwWlhNc0lIVnpaWEpCWkdSeVpYTnpPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDblZ1YzNSaGEyVkdjbTl0VUc5dmJEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5TMHpPUW9nSUNBZ0x5OGdkVzV6ZEdGclpVWnliMjFRYjI5c0tBb2dJQ0FnTHk4Z0lDQWdJSEJ2YjJ4SlpEb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJSFZ6WlhKQlpHUnlaWE56T2lCemRISnBibWNLSUNBZ0lDOHZJQ2s2SUhOMGNtbHVaeUI3Q2lBZ0lDQndjbTkwYnlBeklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME1Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUdCVGRXTmpaWE56Wm5Wc2JIa2dkVzV6ZEdGclpXUWdKSHRoYlc5MWJuUjlJRzFwWTNKdlFXeG5iM01nWm5KdmJTQndiMjlzSUNSN2NHOXZiRWxrZlNCaWVTQjFjMlZ5SUNSN2RYTmxja0ZrWkhKbGMzTjlZQW9nSUNBZ2NIVnphR0o1ZEdWeklDSlRkV05qWlhOelpuVnNiSGtnZFc1emRHRnJaV1FnSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUFpSUcxcFkzSnZRV3huYjNNZ1puSnZiU0J3YjI5c0lDSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJaUJpZVNCMWMyVnlJQ0lLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VUhKbFpHbGpkR2wyWlV4cGNYVnBaR2wwZVUxcGJtbHVaeTVsYldWeVoyVnVZM2xYYVhSb1pISmhkeWh3YjI5c1NXUTZJR0o1ZEdWekxDQjFjMlZ5UVdSa2NtVnpjem9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BsYldWeVoyVnVZM2xYYVhSb1pISmhkem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOaTAwT1FvZ0lDQWdMeThnWlcxbGNtZGxibU41VjJsMGFHUnlZWGNvQ2lBZ0lDQXZMeUFnSUNBZ2NHOXZiRWxrT2lCemRISnBibWNzQ2lBZ0lDQXZMeUFnSUNBZ2RYTmxja0ZrWkhKbGMzTTZJSE4wY21sdVp3b2dJQ0FnTHk4Z0tUb2djM1J5YVc1bklIc0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV3Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZRVZ0WlhKblpXNWplU0IzYVhSb1pISmhkMkZzSUdWNFpXTjFkR1ZrSUdadmNpQWtlM1Z6WlhKQlpHUnlaWE56ZlNCbWNtOXRJSEJ2YjJ3Z0pIdHdiMjlzU1dSOUxpQlFaVzVoYkhScFpYTWdiV0Y1SUdGd2NHeDVMbUFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlSVzFsY21kbGJtTjVJSGRwZEdoa2NtRjNZV3dnWlhobFkzVjBaV1FnWm05eUlDSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpQm1jbTl0SUhCdmIyd2dJZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0l1SUZCbGJtRnNkR2xsY3lCdFlYa2dZWEJ3YkhrdUlnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sQnlaV1JwWTNScGRtVk1hWEYxYVdScGRIbE5hVzVwYm1jdVoyVjBWWE5sY2xOMFlXdGxLSEJ2YjJ4SlpEb2dZbmwwWlhNc0lIVnpaWEpCWkdSeVpYTnpPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbWRsZEZWelpYSlRkR0ZyWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTmkwMU9Rb2dJQ0FnTHk4Z1oyVjBWWE5sY2xOMFlXdGxLQW9nSUNBZ0x5OGdJQ0FnSUhCdmIyeEpaRG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0FnSUhWelpYSkJaR1J5WlhOek9pQnpkSEpwYm1jS0lDQWdJQzh2SUNrNklITjBjbWx1WnlCN0NpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJNQW9nSUNBZ0x5OGdjbVYwZFhKdUlHQlZjMlZ5SUNSN2RYTmxja0ZrWkhKbGMzTjlJR2hoY3lCemRHRnJaV1FnWVcxdmRXNTBJR2x1SUhCdmIyd2dKSHR3YjI5c1NXUjlPaUF4TERVd01Dd3dNREFnYldsamNtOUJiR2R2YzJBS0lDQWdJSEIxYzJoaWVYUmxjeUFpVlhObGNpQWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklDSWdhR0Z6SUhOMFlXdGxaQ0JoYlc5MWJuUWdhVzRnY0c5dmJDQWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJam9nTVN3MU1EQXNNREF3SUcxcFkzSnZRV3huYjNNaUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlVISmxaR2xqZEdsMlpVeHBjWFZwWkdsMGVVMXBibWx1Wnk1MWNHUmhkR1ZCU1ZCeVpXUnBZM1JwYjI0b2NHOXZiRWxrT2lCaWVYUmxjeXdnYm1WM1FWQlpPaUJpZVhSbGN5d2dZMjl1Wm1sa1pXNWpaVG9nWW5sMFpYTXNJSFJwYldWbWNtRnRaVG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3AxY0dSaGRHVkJTVkJ5WldScFkzUnBiMjQ2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOall0TnpFS0lDQWdJQzh2SUhWd1pHRjBaVUZKVUhKbFpHbGpkR2x2YmlnS0lDQWdJQzh2SUNBZ0lDQndiMjlzU1dRNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQnVaWGRCVUZrNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQmpiMjVtYVdSbGJtTmxPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnZEdsdFpXWnlZVzFsT2lCemRISnBibWNLSUNBZ0lDOHZJQ2s2SUhOMGNtbHVaeUI3Q2lBZ0lDQndjbTkwYnlBMElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM01nb2dJQ0FnTHk4Z2NtVjBkWEp1SUdCUWIyOXNJQ1I3Y0c5dmJFbGtmU0JCU1NCd2NtVmthV04wYVc5dUlIVndaR0YwWldRNklDUjdibVYzUVZCWmZTVWdRVkJaSUhkcGRHZ2dKSHRqYjI1bWFXUmxibU5sZlNVZ1kyOXVabWxrWlc1alpTQm1iM0lnSkh0MGFXMWxabkpoYldWOVlBb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVVHOXZiQ0FpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lnUVVrZ2NISmxaR2xqZEdsdmJpQjFjR1JoZEdWa09pQWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJaVVnUVZCWklIZHBkR2dnSWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SUNJbElHTnZibVpwWkdWdVkyVWdabTl5SUNJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlVISmxaR2xqZEdsMlpVeHBjWFZwWkdsMGVVMXBibWx1Wnk1emRXSnRhWFJVY21GcGJtbHVaMFJoZEdFb1kyOXVkSEpwWW5WMGIzSTZJR0o1ZEdWekxDQmtZWFJoVkhsd1pUb2dZbmwwWlhNc0lHUmhkR0ZJWVhOb09pQmllWFJsY3l3Z2NHOXZiRWxrT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q25OMVltMXBkRlJ5WVdsdWFXNW5SR0YwWVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zT0MwNE13b2dJQ0FnTHk4Z2MzVmliV2wwVkhKaGFXNXBibWRFWVhSaEtBb2dJQ0FnTHk4Z0lDQWdJR052Ym5SeWFXSjFkRzl5T2lCemRISnBibWNzQ2lBZ0lDQXZMeUFnSUNBZ1pHRjBZVlI1Y0dVNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQmtZWFJoU0dGemFEb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJSEJ2YjJ4SlpEb2djM1J5YVc1bkNpQWdJQ0F2THlBcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnY0hKdmRHOGdOQ0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVE1LSUNBZ0lDOHZJR2xtSUNoa1lYUmhWSGx3WlNBOVBUMGdKMjFoY210bGRGOWtZWFJoSnlrZ2NtVjBkWEp1SUNjeE1EQW5DaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUhCMWMyaGllWFJsY3lBaWJXRnlhMlYwWDJSaGRHRWlDaUFnSUNBOVBRb2dJQ0FnWW5vZ2MzVmliV2wwVkhKaGFXNXBibWRFWVhSaFgyRm1kR1Z5WDJsbVgyVnNjMlZBTXdvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0l4TURBaUNncHpkV0p0YVhSVWNtRnBibWx1WjBSaGRHRmZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xCeVpXUnBZM1JwZG1WTWFYRjFhV1JwZEhsTmFXNXBibWN1WTJGc1kzVnNZWFJsUkdGMFlWSmxkMkZ5WkVBNE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnMUNpQWdJQ0F2THlCeVpYUjFjbTRnWUVSaGRHRWdjM1ZpYldsMGRHVmtJR0o1SUNSN1kyOXVkSEpwWW5WMGIzSjlJR1p2Y2lCd2IyOXNJQ1I3Y0c5dmJFbGtmUzRnUkdGMFlTQm9ZWE5vT2lBa2UyUmhkR0ZJWVhOb2ZTNGdSMjkyWlhKdVlXNWpaU0J5WlhkaGNtUTZJQ1I3Y21WM1lYSmtRVzF2ZFc1MGZTQjBiMnRsYm5NdVlBb2dJQ0FnY0hWemFHSjVkR1Z6SUNKRVlYUmhJSE4xWW0xcGRIUmxaQ0JpZVNBaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRRS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SUNJZ1ptOXlJSEJ2YjJ3Z0lnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklDSXVJRVJoZEdFZ2FHRnphRG9nSWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SUNJdUlFZHZkbVZ5Ym1GdVkyVWdjbVYzWVhKa09pQWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lnZEc5clpXNXpMaUlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjbVYwYzNWaUNncHpkV0p0YVhSVWNtRnBibWx1WjBSaGRHRmZZV1owWlhKZmFXWmZaV3h6WlVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prMENpQWdJQ0F2THlCcFppQW9aR0YwWVZSNWNHVWdQVDA5SUNkc2FYRjFhV1JwZEhsZlpHRjBZU2NwSUhKbGRIVnliaUFuTVRVd0p3b2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0J3ZFhOb1lubDBaWE1nSW14cGNYVnBaR2wwZVY5a1lYUmhJZ29nSUNBZ1BUMEtJQ0FnSUdKNklITjFZbTFwZEZSeVlXbHVhVzVuUkdGMFlWOWhablJsY2w5cFpsOWxiSE5sUURVS0lDQWdJSEIxYzJoaWVYUmxjeUFpTVRVd0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnMENpQWdJQ0F2THlCamIyNXpkQ0J5WlhkaGNtUkJiVzkxYm5RZ1BTQjBhR2x6TG1OaGJHTjFiR0YwWlVSaGRHRlNaWGRoY21Rb1pHRjBZVlI1Y0dVcENpQWdJQ0JpSUhOMVltMXBkRlJ5WVdsdWFXNW5SR0YwWVY5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVSEpsWkdsamRHbDJaVXhwY1hWcFpHbDBlVTFwYm1sdVp5NWpZV3hqZFd4aGRHVkVZWFJoVW1WM1lYSmtRRGdLQ25OMVltMXBkRlJ5WVdsdWFXNW5SR0YwWVY5aFpuUmxjbDlwWmw5bGJITmxRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVFVLSUNBZ0lDOHZJR2xtSUNoa1lYUmhWSGx3WlNBOVBUMGdKM1Z6WlhKZlltVm9ZWFpwYjNJbktTQnlaWFIxY200Z0p6SXdNQ2NLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2NIVnphR0o1ZEdWeklDSjFjMlZ5WDJKbGFHRjJhVzl5SWdvZ0lDQWdQVDBLSUNBZ0lHSjZJSE4xWW0xcGRGUnlZV2x1YVc1blJHRjBZVjloWm5SbGNsOXBabDlsYkhObFFEY0tJQ0FnSUhCMWMyaGllWFJsY3lBaU1qQXdJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZzBDaUFnSUNBdkx5QmpiMjV6ZENCeVpYZGhjbVJCYlc5MWJuUWdQU0IwYUdsekxtTmhiR04xYkdGMFpVUmhkR0ZTWlhkaGNtUW9aR0YwWVZSNWNHVXBDaUFnSUNCaUlITjFZbTFwZEZSeVlXbHVhVzVuUkdGMFlWOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VUhKbFpHbGpkR2wyWlV4cGNYVnBaR2wwZVUxcGJtbHVaeTVqWVd4amRXeGhkR1ZFWVhSaFVtVjNZWEprUURnS0NuTjFZbTFwZEZSeVlXbHVhVzVuUkdGMFlWOWhablJsY2w5cFpsOWxiSE5sUURjNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RZS0lDQWdJQzh2SUhKbGRIVnliaUFuTlRBbklDOHZJRVJsWm1GMWJIUWdjbVYzWVhKa0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWpVd0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnMENpQWdJQ0F2THlCamIyNXpkQ0J5WlhkaGNtUkJiVzkxYm5RZ1BTQjBhR2x6TG1OaGJHTjFiR0YwWlVSaGRHRlNaWGRoY21Rb1pHRjBZVlI1Y0dVcENpQWdJQ0JpSUhOMVltMXBkRlJ5WVdsdWFXNW5SR0YwWVY5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVSEpsWkdsamRHbDJaVXhwY1hWcFpHbDBlVTFwYm1sdVp5NWpZV3hqZFd4aGRHVkVZWFJoVW1WM1lYSmtRRGdLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sQnlaV1JwWTNScGRtVk1hWEYxYVdScGRIbE5hVzVwYm1jdWRtOTBaVTl1VUhKdmNHOXpZV3dvY0hKdmNHOXpZV3hKWkRvZ1lubDBaWE1zSUhadmRHVTZJSFZwYm5RMk5Dd2dkbTkwWlhJNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS2RtOTBaVTl1VUhKdmNHOXpZV3c2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEF5TFRFd05nb2dJQ0FnTHk4Z2RtOTBaVTl1VUhKdmNHOXpZV3dvQ2lBZ0lDQXZMeUFnSUNBZ2NISnZjRzl6WVd4SlpEb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJSFp2ZEdVNklHSnZiMnhsWVc0c0NpQWdJQ0F2THlBZ0lDQWdkbTkwWlhJNklITjBjbWx1WndvZ0lDQWdMeThnS1RvZ2MzUnlhVzVuSUhzS0lDQWdJSEJ5YjNSdklETWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdOd29nSUNBZ0x5OGdZMjl1YzNRZ2RtOTBaVk4wY21sdVp5QTlJSFp2ZEdVZ1B5QW5SazlTSnlBNklDZEJSMEZKVGxOVUp3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JpZWlCMmIzUmxUMjVRY205d2IzTmhiRjkwWlhKdVlYSjVYMlpoYkhObFFESUtJQ0FnSUhCMWMyaGllWFJsY3lBaVJrOVNJZ29LZG05MFpVOXVVSEp2Y0c5ellXeGZkR1Z5Ym1GeWVWOXRaWEpuWlVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd09Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUdCV2IzUmxJR05oYzNRZ2IyNGdjSEp2Y0c5ellXd2dKSHR3Y205d2IzTmhiRWxrZlNCaWVTQWtlM1p2ZEdWeWZUb2dKSHQyYjNSbFUzUnlhVzVuZldBS0lDQWdJSEIxYzJoaWVYUmxjeUFpVm05MFpTQmpZWE4wSUc5dUlIQnliM0J2YzJGc0lDSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpQmllU0FpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nSWpvZ0lnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lISmxkSE4xWWdvS2RtOTBaVTl1VUhKdmNHOXpZV3hmZEdWeWJtRnllVjltWVd4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdOd29nSUNBZ0x5OGdZMjl1YzNRZ2RtOTBaVk4wY21sdVp5QTlJSFp2ZEdVZ1B5QW5SazlTSnlBNklDZEJSMEZKVGxOVUp3b2dJQ0FnY0hWemFHSjVkR1Z6SUNKQlIwRkpUbE5VSWdvZ0lDQWdZaUIyYjNSbFQyNVFjbTl3YjNOaGJGOTBaWEp1WVhKNVgyMWxjbWRsUURNS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbEJ5WldScFkzUnBkbVZNYVhGMWFXUnBkSGxOYVc1cGJtY3VZMkZzWTNWc1lYUmxWWE5sY2xKcGMydFRZMjl5WlNoMWMyVnlRV1JrY21WemN6b2dZbmwwWlhNc0lIQnZjblJtYjJ4cGIxWmhiSFZsT2lCaWVYUmxjeXdnZEhKaFpHbHVaMFp5WlhGMVpXNWplVG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BqWVd4amRXeGhkR1ZWYzJWeVVtbHphMU5qYjNKbE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE5DMHhNVGdLSUNBZ0lDOHZJR05oYkdOMWJHRjBaVlZ6WlhKU2FYTnJVMk52Y21Vb0NpQWdJQ0F2THlBZ0lDQWdkWE5sY2tGa1pISmxjM002SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCd2IzSjBabTlzYVc5V1lXeDFaVG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0FnSUhSeVlXUnBibWRHY21WeGRXVnVZM2s2SUhOMGNtbHVad29nSUNBZ0x5OGdLVG9nYzNSeWFXNW5JSHNLSUNBZ0lIQnliM1J2SURNZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeU1Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUdCU2FYTnJJSE5qYjNKbElHWnZjaUFrZTNWelpYSkJaR1J5WlhOemZUb2dOalV2TVRBd0lHSmhjMlZrSUc5dUlIQnZjblJtYjJ4cGJ5QjJZV3gxWlNBa2UzQnZjblJtYjJ4cGIxWmhiSFZsZlNCaGJtUWdkSEpoWkdsdVp5Qm1jbVZ4ZFdWdVkza2dKSHQwY21Ga2FXNW5SbkpsY1hWbGJtTjVmV0FLSUNBZ0lIQjFjMmhpZVhSbGN5QWlVbWx6YXlCelkyOXlaU0JtYjNJZ0lnb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBaU9pQTJOUzh4TURBZ1ltRnpaV1FnYjI0Z2NHOXlkR1p2YkdsdklIWmhiSFZsSUNJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBaUlHRnVaQ0IwY21Ga2FXNW5JR1p5WlhGMVpXNWplU0FpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xCeVpXUnBZM1JwZG1WTWFYRjFhV1JwZEhsTmFXNXBibWN1WTJ4aGFXMVNaWGRoY21SektIVnpaWEpCWkdSeVpYTnpPaUJpZVhSbGN5d2djRzl2YkVsa09pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNtTnNZV2x0VW1WM1lYSmtjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNall0TVRJNUNpQWdJQ0F2THlCamJHRnBiVkpsZDJGeVpITW9DaUFnSUNBdkx5QWdJQ0FnZFhObGNrRmtaSEpsYzNNNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQndiMjlzU1dRNklITjBjbWx1WndvZ0lDQWdMeThnS1RvZ2MzUnlhVzVuSUhzS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpNd29nSUNBZ0x5OGdjbVYwZFhKdUlHQWtlM1Z6WlhKQlpHUnlaWE56ZlNCamJHRnBiV1ZrSUNSN2RHOTBZV3hTWlhkaGNtUnpmU0IwYjJ0bGJuTWdabkp2YlNCd2IyOXNJQ1I3Y0c5dmJFbGtmUzRnVW1WM1lYSmtjeUJqWVd4amRXeGhkR1ZrSUhWemFXNW5JRUZKTFhCdmQyVnlaV1FnWkhsdVlXMXBZeUJ6ZVhOMFpXMHVZQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpQmpiR0ZwYldWa0lDSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpNUW9nSUNBZ0x5OGdZMjl1YzNRZ2RHOTBZV3hTWlhkaGNtUnpJRDBnSnpFeU1DY0tJQ0FnSUhCMWMyaGllWFJsY3lBaU1USXdJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpNd29nSUNBZ0x5OGdjbVYwZFhKdUlHQWtlM1Z6WlhKQlpHUnlaWE56ZlNCamJHRnBiV1ZrSUNSN2RHOTBZV3hTWlhkaGNtUnpmU0IwYjJ0bGJuTWdabkp2YlNCd2IyOXNJQ1I3Y0c5dmJFbGtmUzRnVW1WM1lYSmtjeUJqWVd4amRXeGhkR1ZrSUhWemFXNW5JRUZKTFhCdmQyVnlaV1FnWkhsdVlXMXBZeUJ6ZVhOMFpXMHVZQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJaUIwYjJ0bGJuTWdabkp2YlNCd2IyOXNJQ0lLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUFpTGlCU1pYZGhjbVJ6SUdOaGJHTjFiR0YwWldRZ2RYTnBibWNnUVVrdGNHOTNaWEpsWkNCa2VXNWhiV2xqSUhONWMzUmxiUzRpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VUhKbFpHbGpkR2wyWlV4cGNYVnBaR2wwZVUxcGJtbHVaeTVuWlhSUWIyOXNVM1JoZEhNb2NHOXZiRWxrT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q21kbGRGQnZiMnhUZEdGMGN6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE16a0tJQ0FnSUM4dklHZGxkRkJ2YjJ4VGRHRjBjeWh3YjI5c1NXUTZJSE4wY21sdVp5azZJSE4wY21sdVp5QjdDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkRFS0lDQWdJQzh2SUhKbGRIVnliaUJnVUc5dmJDQWtlM0J2YjJ4SlpIMDZJRU4xY25KbGJuUWdRVkJaSURFMUxqVWxMQ0JRY21Wa2FXTjBaV1FnUVZCWklERTRMaklsSUNnNE55VWdZMjl1Wm1sa1pXNWpaU2tzSUZSV1REb2dNU3cxTURBc01EQXdJRzFwWTNKdlFXeG5iM05nQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pRYjI5c0lDSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lqb2dRM1Z5Y21WdWRDQkJVRmtnTVRVdU5TVXNJRkJ5WldScFkzUmxaQ0JCVUZrZ01UZ3VNaVVnS0RnM0pTQmpiMjVtYVdSbGJtTmxLU3dnVkZaTU9pQXhMRFV3TUN3d01EQWdiV2xqY205QmJHZHZjeUlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBRY21Wa2FXTjBhWFpsVEdseGRXbGthWFI1VFdsdWFXNW5MbWRsZEZWelpYSlFiM0owWm05c2FXOG9kWE5sY2tGa1pISmxjM002SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LWjJWMFZYTmxjbEJ2Y25SbWIyeHBiem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOVFFLSUNBZ0lDOHZJR2RsZEZWelpYSlFiM0owWm05c2FXOG9kWE5sY2tGa1pISmxjM002SUhOMGNtbHVaeWs2SUhOMGNtbHVaeUI3Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5UVUtJQ0FnSUM4dklISmxkSFZ5YmlCZ1VHOXlkR1p2YkdsdklHWnZjaUFrZTNWelpYSkJaR1J5WlhOemZUb2dRV04wYVhabElIQnZjMmwwYVc5dWN5QjBjbUZqYTJWa0xDQnlaWGRoY21SeklHRjJZV2xzWVdKc1pTd2djbWx6YXlCaGMzTmxjM050Wlc1MElHTnZiWEJzWlhSbFpHQUtJQ0FnSUhCMWMyaGllWFJsY3lBaVVHOXlkR1p2YkdsdklHWnZjaUFpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0k2SUVGamRHbDJaU0J3YjNOcGRHbHZibk1nZEhKaFkydGxaQ3dnY21WM1lYSmtjeUJoZG1GcGJHRmliR1VzSUhKcGMyc2dZWE56WlhOemJXVnVkQ0JqYjIxd2JHVjBaV1FpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEpsZEhOMVlnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUNBUUFtQXdRVkgzeDFCVkJ2YjJ3Z0NTQmllU0IxYzJWeUlERWJRUU5BZ2c0RXc3bVNLZ1NXenF1cEJGcEJ0NkVFNXhtOXZRU3BDM2N2Qk5oQ0h4MEViR1FTU0FRd3hoL3ZCSkRzeVE0RVk3ZEVKUVRkK3A4b0JBMEZIWG9FK3d0T1l3VEJpVFQ3TmhvQWpnNENwd0o5QWxNQ0x3SUxBZHNCcXdHQ0FWZ0JOQUVXQU1vQXJBQUNJME14R1JSRU1SaEVnSjBCRlI5OGRRQ1hVR3hoZEdadmNtMGdRVzVoYkhsMGFXTnpPaUJVYjNSaGJDQndiMjlzY3pvZ05EY3NJRUZqZEdsMlpTQnRhVzVsY25NNklERXNNak0wTENCVWIzUmhiQ0J5WlhkaGNtUnpJR1JwYzNSeWFXSjFkR1ZrT2lBeE1qVXNNREF3SUhSdmEyVnVjeXdnUVhabGNtRm5aU0JCVUZrNklERXlMalVsTENCQlNTQndjbVZrYVdOMGFXOXVJR0ZqWTNWeVlXTjVPaUE0Tnk0ekpiQWlRekVaRkVReEdFUTJHZ0ZYQWdDSUJnNUpGUlpYQmdKTVVDaE1VTEFpUXpFWkZFUXhHRVNBUUJVZmZIVUFPbEJzWVhSbWIzSnRJSEJoZFhObFpDQm1iM0lnYldGcGJuUmxibUZ1WTJVdUlFRnNiQ0J2Y0dWeVlYUnBiMjV6SUhOMWMzQmxibVJsWkM2d0lrTXhHUlJFTVJoRU5ob0JWd0lBaUFWRlNSVVdWd1lDVEZBb1RGQ3dJa014R1JSRU1SaEVOaG9CVndJQU5ob0NWd0lBaUFTNVNSVVdWd1lDVEZBb1RGQ3dJa014R1JSRU1SaEVOaG9CVndJQU5ob0NWd0lBTmhvRFZ3SUFpQVF5U1JVV1Z3WUNURkFvVEZDd0lrTXhHUlJFTVJoRU5ob0JWd0lBTmhvQ0kxTTJHZ05YQWdDSUE4TkpGUlpYQmdKTVVDaE1VTEFpUXpFWkZFUXhHRVEyR2dGWEFnQTJHZ0pYQWdBMkdnTlhBZ0EyR2dSWEFnQ0lBdFpKRlJaWEJnSk1VQ2hNVUxBaVF6RVpGRVF4R0VRMkdnRlhBZ0EyR2dKWEFnQTJHZ05YQWdBMkdnUlhBZ0NJQWxoSkZSWlhCZ0pNVUNoTVVMQWlRekVaRkVReEdFUTJHZ0ZYQWdBMkdnSlhBZ0NJQWV4SkZSWlhCZ0pNVUNoTVVMQWlRekVaRkVReEdFUTJHZ0ZYQWdBMkdnSlhBZ0NJQVhOSkZSWlhCZ0pNVUNoTVVMQWlRekVaRkVReEdFUTJHZ0ZYQWdBMkdnSlhBZ0EyR2dOWEFnQ0lBUWxKRlJaWEJnSk1VQ2hNVUxBaVF6RVpGRVF4R0VRMkdnRlhBZ0EyR2dKWEFnQTJHZ05YQWdDSUFLTkpGUlpYQmdKTVVDaE1VTEFpUXpFWkZFUXhHRVEyR2dGWEFnQTJHZ0pYQWdBMkdnTlhBZ0EyR2dSWEFnQ0lBQmxKRlJaWEJnSk1VQ2hNVUxBaVF6RVpRUDBrTVJnVVJDSkRpZ1FCS1l2OFVJQU9JR055WldGMFpXUWdkMmwwYUNCUWkvMVFnQk1sSUVGUVdTd2djbWx6YXlCc1pYWmxiRG9nVUl2K1VJQVJMQ0J0YVc1cGJYVnRJSE4wWVd0bE9pQlFpLzlRZ0FzZ2JXbGpjbTlCYkdkdmMxQ0ppZ01CZ0JSVGRXTmpaWE56Wm5Wc2JIa2djM1JoYTJWa0lJditVSUFVSUcxcFkzSnZRV3huYjNNZ2FXNGdjRzl2YkNCUWkvMVFLbENMLzFDSmlnTUJnQlpUZFdOalpYTnpablZzYkhrZ2RXNXpkR0ZyWldRZ2kvNVFnQllnYldsamNtOUJiR2R2Y3lCbWNtOXRJSEJ2YjJ3Z1VJdjlVQ3BRaS85UWlZb0NBWUFpUlcxbGNtZGxibU41SUhkcGRHaGtjbUYzWVd3Z1pYaGxZM1YwWldRZ1ptOXlJSXYvVUlBTElHWnliMjBnY0c5dmJDQlFpLzVRZ0JZdUlGQmxibUZzZEdsbGN5QnRZWGtnWVhCd2JIa3VVSW1LQWdHQUJWVnpaWElnaS85UWdCc2dhR0Z6SUhOMFlXdGxaQ0JoYlc5MWJuUWdhVzRnY0c5dmJDQlFpLzVRZ0JZNklERXNOVEF3TERBd01DQnRhV055YjBGc1oyOXpVSW1LQkFFcGkveFFnQmdnUVVrZ2NISmxaR2xqZEdsdmJpQjFjR1JoZEdWa09pQlFpLzFRZ0FzbElFRlFXU0IzYVhSb0lGQ0wvbENBRVNVZ1kyOXVabWxrWlc1alpTQm1iM0lnVUl2L1VJbUtCQUdML1lBTGJXRnlhMlYwWDJSaGRHRVNRUUJsZ0FNeE1EQ0FFa1JoZEdFZ2MzVmliV2wwZEdWa0lHSjVJSXY4VUlBS0lHWnZjaUJ3YjI5c0lGQ0wvMUNBRFM0Z1JHRjBZU0JvWVhOb09pQlFpLzVRZ0JVdUlFZHZkbVZ5Ym1GdVkyVWdjbVYzWVhKa09pQlFURkNBQ0NCMGIydGxibk11VUltTC9ZQU9iR2x4ZFdsa2FYUjVYMlJoZEdFU1FRQUlnQU14TlRCQy80S0wvWUFOZFhObGNsOWlaV2hoZG1sdmNoSkJBQWlBQXpJd01FTC9aWUFDTlRCQy8xNktBd0dML2tFQU1vQURSazlTZ0JaV2IzUmxJR05oYzNRZ2IyNGdjSEp2Y0c5ellXd2dpLzFRZ0FRZ1lua2dVSXYvVUlBQ09pQlFURkNKZ0FkQlIwRkpUbE5VUXYvSGlnTUJnQTlTYVhOcklITmpiM0psSUdadmNpQ0wvVkNBSWpvZ05qVXZNVEF3SUdKaGMyVmtJRzl1SUhCdmNuUm1iMnhwYnlCMllXeDFaU0JRaS81UWdCY2dZVzVrSUhSeVlXUnBibWNnWm5KbGNYVmxibU41SUZDTC8xQ0ppZ0lCaS82QUNTQmpiR0ZwYldWa0lGQ0FBekV5TUZDQUVpQjBiMnRsYm5NZ1puSnZiU0J3YjI5c0lGQ0wvMUNBTlM0Z1VtVjNZWEprY3lCallXeGpkV3hoZEdWa0lIVnphVzVuSUVGSkxYQnZkMlZ5WldRZ1pIbHVZVzFwWXlCemVYTjBaVzB1VUltS0FRRXBpLzlRZ0ZRNklFTjFjbkpsYm5RZ1FWQlpJREUxTGpVbExDQlFjbVZrYVdOMFpXUWdRVkJaSURFNExqSWxJQ2c0TnlVZ1kyOXVabWxrWlc1alpTa3NJRlJXVERvZ01TdzFNREFzTURBd0lHMXBZM0p2UVd4bmIzTlFpWW9CQVlBT1VHOXlkR1p2YkdsdklHWnZjaUNMLzFDQVNEb2dRV04wYVhabElIQnZjMmwwYVc5dWN5QjBjbUZqYTJWa0xDQnlaWGRoY21SeklHRjJZV2xzWVdKc1pTd2djbWx6YXlCaGMzTmxjM050Wlc1MElHTnZiWEJzWlhSbFpGQ0oiLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo3LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
