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

namespace Arc56.Generated.harsh_a_parihar.Hackpay.PlatformFeeManagerContract_322b43ec
{


    //
    // Platform Fee Manager Contract
    //Handles automated fee collection and treasury management
    //
    public class PlatformFeeManagerContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PlatformFeeManagerContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Initialize the fee manager
        ///PRODUCTION READY: Configurable platform owner instead of hardcoded deployer
        ///</summary>
        /// <param name="treasuryAddress"> </param>
        /// <param name="assetId"> </param>
        /// <param name="withdrawalDelaySeconds"> </param>
        /// <param name="platformOwnerAddress"> </param>
        /// <param name="basisPointsDiv"> </param>
        /// <param name="maxFeePct"> </param>
        public async Task Initialize(byte[] treasuryAddress, ulong assetId, ulong withdrawalDelaySeconds, byte[] platformOwnerAddress, ulong basisPointsDiv, ulong maxFeePct, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 29, 36, 222, 162 };
            var treasuryAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); treasuryAddressAbi.From(treasuryAddress);
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetIdAbi.From(assetId);
            var withdrawalDelaySecondsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); withdrawalDelaySecondsAbi.From(withdrawalDelaySeconds);
            var platformOwnerAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); platformOwnerAddressAbi.From(platformOwnerAddress);
            var basisPointsDivAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); basisPointsDivAbi.From(basisPointsDiv);
            var maxFeePctAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); maxFeePctAbi.From(maxFeePct);

            var result = await base.CallApp(new List<object> { abiHandle, treasuryAddressAbi, assetIdAbi, withdrawalDelaySecondsAbi, platformOwnerAddressAbi, basisPointsDivAbi, maxFeePctAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Initialize_Transactions(byte[] treasuryAddress, ulong assetId, ulong withdrawalDelaySeconds, byte[] platformOwnerAddress, ulong basisPointsDiv, ulong maxFeePct, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 29, 36, 222, 162 };
            var treasuryAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); treasuryAddressAbi.From(treasuryAddress);
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetIdAbi.From(assetId);
            var withdrawalDelaySecondsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); withdrawalDelaySecondsAbi.From(withdrawalDelaySeconds);
            var platformOwnerAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); platformOwnerAddressAbi.From(platformOwnerAddress);
            var basisPointsDivAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); basisPointsDivAbi.From(basisPointsDiv);
            var maxFeePctAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); maxFeePctAbi.From(maxFeePct);

            return await base.MakeTransactionList(new List<object> { abiHandle, treasuryAddressAbi, assetIdAbi, withdrawalDelaySecondsAbi, platformOwnerAddressAbi, basisPointsDivAbi, maxFeePctAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Change platform owner (governance)
        ///PRODUCTION READY: Allows authority transfer for governance
        ///</summary>
        /// <param name="newOwner"> </param>
        public async Task ChangePlatformOwner(byte[] newOwner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 153, 169, 244, 232 };
            var newOwnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); newOwnerAbi.From(newOwner);

            var result = await base.CallApp(new List<object> { abiHandle, newOwnerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ChangePlatformOwner_Transactions(byte[] newOwner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 153, 169, 244, 232 };
            var newOwnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); newOwnerAbi.From(newOwner);

            return await base.MakeTransactionList(new List<object> { abiHandle, newOwnerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update basis points divisor (owner only)
        ///PRODUCTION READY: Allows fee calculation updates
        ///</summary>
        /// <param name="newDivisor"> </param>
        public async Task UpdateBasisPointsDivisor(ulong newDivisor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 128, 202, 150, 95 };
            var newDivisorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newDivisorAbi.From(newDivisor);

            var result = await base.CallApp(new List<object> { abiHandle, newDivisorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateBasisPointsDivisor_Transactions(ulong newDivisor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 128, 202, 150, 95 };
            var newDivisorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newDivisorAbi.From(newDivisor);

            return await base.MakeTransactionList(new List<object> { abiHandle, newDivisorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update maximum fee percentage (owner only)
        ///PRODUCTION READY: Allows fee limit updates
        ///</summary>
        /// <param name="newMaxFee"> </param>
        public async Task UpdateMaxFeePercentage(ulong newMaxFee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 123, 39, 146, 30 };
            var newMaxFeeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newMaxFeeAbi.From(newMaxFee);

            var result = await base.CallApp(new List<object> { abiHandle, newMaxFeeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateMaxFeePercentage_Transactions(ulong newMaxFee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 123, 39, 146, 30 };
            var newMaxFeeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newMaxFeeAbi.From(newMaxFee);

            return await base.MakeTransactionList(new List<object> { abiHandle, newMaxFeeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Collect fees from a distribution
        ///</summary>
        /// <param name="amount"> </param>
        /// <param name="feePercentageBps"> </param>
        public async Task CollectFees(ulong amount, ulong feePercentageBps, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 64, 216, 129 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var feePercentageBpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); feePercentageBpsAbi.From(feePercentageBps);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi, feePercentageBpsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CollectFees_Transactions(ulong amount, ulong feePercentageBps, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 64, 216, 129 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var feePercentageBpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); feePercentageBpsAbi.From(feePercentageBps);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi, feePercentageBpsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Request withdrawal (starts delay timer)
        ///</summary>
        public async Task RequestWithdrawal(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 145, 255, 193, 41 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RequestWithdrawal_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 145, 255, 193, 41 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get total fees collected
        ///</summary>
        public async Task<ulong> GetTotalFeesCollected(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 188, 4, 166, 73 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalFeesCollected_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 188, 4, 166, 73 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Calculate fee for a given amount and percentage
        ///</summary>
        /// <param name="amount"> </param>
        /// <param name="feePercentageBps"> </param>
        public async Task<ulong> CalculateFee(ulong amount, ulong feePercentageBps, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 129, 87, 69, 136 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var feePercentageBpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); feePercentageBpsAbi.From(feePercentageBps);

            var result = await base.SimApp(new List<object> { abiHandle, amountAbi, feePercentageBpsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CalculateFee_Transactions(ulong amount, ulong feePercentageBps, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 129, 87, 69, 136 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var feePercentageBpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); feePercentageBpsAbi.From(feePercentageBps);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi, feePercentageBpsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get treasury address
        ///</summary>
        public async Task<byte[]> GetTreasuryAddress(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 30, 200, 193, 207 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> GetTreasuryAddress_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 30, 200, 193, 207 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get withdrawal delay
        ///</summary>
        public async Task<ulong> GetWithdrawalDelay(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 117, 223, 35, 20 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetWithdrawalDelay_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 117, 223, 35, 20 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Hello method for testing
        ///</summary>
        /// <param name="name"> </param>
        public async Task<byte[]> Hello(byte[] name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 224, 131, 139, 186 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); nameAbi.From(name);

            var result = await base.SimApp(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> Hello_Transactions(byte[] name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 224, 131, 139, 186 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); nameAbi.From(name);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUGxhdGZvcm1GZWVNYW5hZ2VyQ29udHJhY3QiLCJkZXNjIjoiUGxhdGZvcm0gRmVlIE1hbmFnZXIgQ29udHJhY3RcbkhhbmRsZXMgYXV0b21hdGVkIGZlZSBjb2xsZWN0aW9uIGFuZCB0cmVhc3VyeSBtYW5hZ2VtZW50IiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImluaXRpYWxpemUiLCJkZXNjIjoiSW5pdGlhbGl6ZSB0aGUgZmVlIG1hbmFnZXJcblBST0RVQ1RJT04gUkVBRFk6IENvbmZpZ3VyYWJsZSBwbGF0Zm9ybSBvd25lciBpbnN0ZWFkIG9mIGhhcmRjb2RlZCBkZXBsb3llciIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0cmVhc3VyeUFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0SWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndpdGhkcmF3YWxEZWxheVNlY29uZHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBsYXRmb3JtT3duZXJBZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiYXNpc1BvaW50c0RpdiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWF4RmVlUGN0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNoYW5nZVBsYXRmb3JtT3duZXIiLCJkZXNjIjoiQ2hhbmdlIHBsYXRmb3JtIG93bmVyIChnb3Zlcm5hbmNlKVxuUFJPRFVDVElPTiBSRUFEWTogQWxsb3dzIGF1dGhvcml0eSB0cmFuc2ZlciBmb3IgZ292ZXJuYW5jZSIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdPd25lciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVCYXNpc1BvaW50c0Rpdmlzb3IiLCJkZXNjIjoiVXBkYXRlIGJhc2lzIHBvaW50cyBkaXZpc29yIChvd25lciBvbmx5KVxuUFJPRFVDVElPTiBSRUFEWTogQWxsb3dzIGZlZSBjYWxjdWxhdGlvbiB1cGRhdGVzIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld0Rpdmlzb3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlTWF4RmVlUGVyY2VudGFnZSIsImRlc2MiOiJVcGRhdGUgbWF4aW11bSBmZWUgcGVyY2VudGFnZSAob3duZXIgb25seSlcblBST0RVQ1RJT04gUkVBRFk6IEFsbG93cyBmZWUgbGltaXQgdXBkYXRlcyIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdNYXhGZWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY29sbGVjdEZlZXMiLCJkZXNjIjoiQ29sbGVjdCBmZWVzIGZyb20gYSBkaXN0cmlidXRpb24iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmZWVQZXJjZW50YWdlQnBzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlcXVlc3RXaXRoZHJhd2FsIiwiZGVzYyI6IlJlcXVlc3Qgd2l0aGRyYXdhbCAoc3RhcnRzIGRlbGF5IHRpbWVyKSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRUb3RhbEZlZXNDb2xsZWN0ZWQiLCJkZXNjIjoiR2V0IHRvdGFsIGZlZXMgY29sbGVjdGVkIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYWxjdWxhdGVGZWUiLCJkZXNjIjoiQ2FsY3VsYXRlIGZlZSBmb3IgYSBnaXZlbiBhbW91bnQgYW5kIHBlcmNlbnRhZ2UiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmZWVQZXJjZW50YWdlQnBzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRUcmVhc3VyeUFkZHJlc3MiLCJkZXNjIjoiR2V0IHRyZWFzdXJ5IGFkZHJlc3MiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFdpdGhkcmF3YWxEZWxheSIsImRlc2MiOiJHZXQgd2l0aGRyYXdhbCBkZWxheSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaGVsbG8iLCJkZXNjIjoiSGVsbG8gbWV0aG9kIGZvciB0ZXN0aW5nIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjo2LCJieXRlcyI6Mn0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNDgxLDU4N10sImVycm9yTWVzc2FnZSI6IkJhc2lzIHBvaW50cyBkaXZpc29yIG11c3QgYmUgZ3JlYXRlciB0aGFuIDAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0OTUsNjE3XSwiZXJyb3JNZXNzYWdlIjoiTWF4IGZlZSBwZXJjZW50YWdlIG11c3QgYmUgYmV0d2VlbiAxIGFuZCAxMDAwMCBiYXNpcyBwb2ludHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NjBdLCJlcnJvck1lc3NhZ2UiOiJOZXcgb3duZXIgYWRkcmVzcyBjYW5ub3QgYmUgZW1wdHkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NjhdLCJlcnJvck1lc3NhZ2UiOiJOZXcgb3duZXIgbXVzdCBiZSBkaWZmZXJlbnQgZnJvbSBjdXJyZW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjI1LDI1MiwyNjksMjkzLDMxOCwzMzUsMzQ3LDM2NywzODMsMzk5LDQxN10sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU1Nl0sImVycm9yTWVzc2FnZSI6Ik9ubHkgY3VycmVudCBwbGF0Zm9ybSBvd25lciBjYW4gY2hhbmdlIG93bmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjM4XSwiZXJyb3JNZXNzYWdlIjoiT25seSBwbGF0Zm9ybSBvd25lciBjYW4gY29sbGVjdCBmZWVzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjY1XSwiZXJyb3JNZXNzYWdlIjoiT25seSBwbGF0Zm9ybSBvd25lciBjYW4gcmVxdWVzdCB3aXRoZHJhd2FsIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTg0XSwiZXJyb3JNZXNzYWdlIjoiT25seSBwbGF0Zm9ybSBvd25lciBjYW4gdXBkYXRlIGJhc2lzIHBvaW50cyBkaXZpc29yIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjAzXSwiZXJyb3JNZXNzYWdlIjoiT25seSBwbGF0Zm9ybSBvd25lciBjYW4gdXBkYXRlIG1heCBmZWUgcGVyY2VudGFnZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ3NV0sImVycm9yTWVzc2FnZSI6IlBsYXRmb3JtIG93bmVyIGFkZHJlc3MgY2Fubm90IGJlIGVtcHR5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDcxXSwiZXJyb3JNZXNzYWdlIjoiVHJlYXN1cnkgYWRkcmVzcyBjYW5ub3QgYmUgZW1wdHkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NzhdLCJlcnJvck1lc3NhZ2UiOiJXaXRoZHJhd2FsIGRlbGF5IG11c3QgYmUgZ3JlYXRlciB0aGFuIDAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NjJdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjgsMjU1LDI3MiwyOTYsMzIxLDMzOCwzNTAsMzcwLDM4Niw0MDIsNDIwXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU1NCw1NjQsNTgyLDYwMSw2MzYsNjQ3LDY1Miw2NjMsNjc0LDY4Nyw2OTQsNzAwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURFd01EQXdDaUFnSUNCaWVYUmxZMkpzYjJOcklDSndiR0YwWm05eWJVOTNibVZ5SWlBd2VERTFNV1kzWXpjMUlDSjBiM1JoYkVabFpYTkRiMnhzWldOMFpXUWlJQ0ppWVhOcGMxQnZhVzUwYzBScGRtbHpiM0lpSUNKd2JHRjBabTl5YlZSeVpXRnpkWEo1SWlBaWQybDBhR1J5WVhkaGJFUmxiR0Y1SWlBaWJHRnpkRmRwZEdoa2NtRjNZV3dpSUNKdFlYaEdaV1ZRWlhKalpXNTBZV2RsSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JzWVhSbWIzSnRYMlpsWlY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TndvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGQnNZWFJtYjNKdFJtVmxUV0Z1WVdkbGNrTnZiblJ5WVdOMElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWW1GeVpWOXliM1YwYVc1blFERTJDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRNV1F5TkdSbFlUSWdNSGc1T1dFNVpqUmxPQ0F3ZURnd1kyRTVOalZtSURCNE4ySXlOemt5TVdVZ01IaG1OVFF3WkRnNE1TQXdlRGt4Wm1aak1USTVJREI0WW1Nd05HRTJORGtnTUhnNE1UVTNORFU0T0NBd2VERmxZemhqTVdObUlEQjROelZrWmpJek1UUWdNSGhsTURnek9HSmlZU0F2THlCdFpYUm9iMlFnSW1sdWFYUnBZV3hwZW1Vb1lubDBaVnRkTEhWcGJuUTJOQ3gxYVc1ME5qUXNZbmwwWlZ0ZExIVnBiblEyTkN4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlZMmhoYm1kbFVHeGhkR1p2Y20xUGQyNWxjaWhpZVhSbFcxMHBkbTlwWkNJc0lHMWxkR2h2WkNBaWRYQmtZWFJsUW1GemFYTlFiMmx1ZEhORWFYWnBjMjl5S0hWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSjFjR1JoZEdWTllYaEdaV1ZRWlhKalpXNTBZV2RsS0hWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSmpiMnhzWldOMFJtVmxjeWgxYVc1ME5qUXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW5KbGNYVmxjM1JYYVhSb1pISmhkMkZzS0NsMmIybGtJaXdnYldWMGFHOWtJQ0puWlhSVWIzUmhiRVpsWlhORGIyeHNaV04wWldRb0tYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVkyRnNZM1ZzWVhSbFJtVmxLSFZwYm5RMk5DeDFhVzUwTmpRcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKblpYUlVjbVZoYzNWeWVVRmtaSEpsYzNNb0tXSjVkR1ZiWFNJc0lHMWxkR2h2WkNBaVoyVjBWMmwwYUdSeVlYZGhiRVJsYkdGNUtDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltaGxiR3h2S0dKNWRHVmJYU2xpZVhSbFcxMGlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgybHVhWFJwWVd4cGVtVmZjbTkxZEdWQU15QnRZV2x1WDJOb1lXNW5aVkJzWVhSbWIzSnRUM2R1WlhKZmNtOTFkR1ZBTkNCdFlXbHVYM1Z3WkdGMFpVSmhjMmx6VUc5cGJuUnpSR2wyYVhOdmNsOXliM1YwWlVBMUlHMWhhVzVmZFhCa1lYUmxUV0Y0Um1WbFVHVnlZMlZ1ZEdGblpWOXliM1YwWlVBMklHMWhhVzVmWTI5c2JHVmpkRVpsWlhOZmNtOTFkR1ZBTnlCdFlXbHVYM0psY1hWbGMzUlhhWFJvWkhKaGQyRnNYM0p2ZFhSbFFEZ2diV0ZwYmw5blpYUlViM1JoYkVabFpYTkRiMnhzWldOMFpXUmZjbTkxZEdWQU9TQnRZV2x1WDJOaGJHTjFiR0YwWlVabFpWOXliM1YwWlVBeE1DQnRZV2x1WDJkbGRGUnlaV0Z6ZFhKNVFXUmtjbVZ6YzE5eWIzVjBaVUF4TVNCdFlXbHVYMmRsZEZkcGRHaGtjbUYzWVd4RVpXeGhlVjl5YjNWMFpVQXhNaUJ0WVdsdVgyaGxiR3h2WDNKdmRYUmxRREV6Q2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHeGhkR1p2Y20xZlptVmxYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVUd4aGRHWnZjbTFHWldWTllXNWhaMlZ5UTI5dWRISmhZM1FnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmhsYkd4dlgzSnZkWFJsUURFek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc1lYUm1iM0p0WDJabFpWOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVTJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4aGRHWnZjbTFmWm1WbFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM0NpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdVR3hoZEdadmNtMUdaV1ZOWVc1aFoyVnlRMjl1ZEhKaFkzUWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc1lYUm1iM0p0WDJabFpWOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVTJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFYybDBhR1J5WVhkaGJFUmxiR0Y1WDNKdmRYUmxRREV5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JzWVhSbWIzSnRYMlpsWlY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRRNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmpZV3hzYzNWaUlHZGxkRmRwZEdoa2NtRjNZV3hFWld4aGVRb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUlVjbVZoYzNWeWVVRmtaSEpsYzNOZmNtOTFkR1ZBTVRFNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4aGRHWnZjbTFmWm1WbFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5EQUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJR05oYkd4emRXSWdaMlYwVkhKbFlYTjFjbmxCWkdSeVpYTnpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5allXeGpkV3hoZEdWR1pXVmZjbTkxZEdWQU1UQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHeGhkR1p2Y20xZlptVmxYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNeklLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JHRjBabTl5YlY5bVpXVmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY0tJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJRYkdGMFptOXliVVpsWlUxaGJtRm5aWEpEYjI1MGNtRmpkQ0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiR0YwWm05eWJWOW1aV1ZmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6TWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lHTmhiR3h6ZFdJZ1kyRnNZM1ZzWVhSbFJtVmxDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRlJ2ZEdGc1JtVmxjME52Ykd4bFkzUmxaRjl5YjNWMFpVQTVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnNZWFJtYjNKdFgyWmxaVjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEkwQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUdkbGRGUnZkR0ZzUm1WbGMwTnZiR3hsWTNSbFpBb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5eVpYRjFaWE4wVjJsMGFHUnlZWGRoYkY5eWIzVjBaVUE0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JzWVhSbWIzSnRYMlpsWlY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmpZV3hzYzNWaUlISmxjWFZsYzNSWGFYUm9aSEpoZDJGc0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJOdmJHeGxZM1JHWldWelgzSnZkWFJsUURjNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4aGRHWnZjbTFmWm1WbFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU9Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JzWVhSbWIzSnRYMlpsWlY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TndvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGQnNZWFJtYjNKdFJtVmxUV0Z1WVdkbGNrTnZiblJ5WVdOMElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc1lYUm1iM0p0WDJabFpWOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UZ0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JqWVd4c2MzVmlJR052Ykd4bFkzUkdaV1Z6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1Z3WkdGMFpVMWhlRVpsWlZCbGNtTmxiblJoWjJWZmNtOTFkR1ZBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YkdGMFptOXliVjltWldWZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3hoZEdadmNtMWZabVZsWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1VHeGhkR1p2Y20xR1pXVk5ZVzVoWjJWeVEyOXVkSEpoWTNRZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4aGRHWnZjbTFmWm1WbFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR05oYkd4emRXSWdkWEJrWVhSbFRXRjRSbVZsVUdWeVkyVnVkR0ZuWlFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkxY0dSaGRHVkNZWE5wYzFCdmFXNTBjMFJwZG1semIzSmZjbTkxZEdWQU5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JHRjBabTl5YlY5bVpXVmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY3hDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4aGRHWnZjbTFmWm1WbFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM0NpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdVR3hoZEdadmNtMUdaV1ZOWVc1aFoyVnlRMjl1ZEhKaFkzUWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHeGhkR1p2Y20xZlptVmxYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnZFhCa1lYUmxRbUZ6YVhOUWIybHVkSE5FYVhacGMyOXlDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyTm9ZVzVuWlZCc1lYUm1iM0p0VDNkdVpYSmZjbTkxZEdWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JHRjBabTl5YlY5bVpXVmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4aGRHWnZjbTFmWm1WbFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM0NpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdVR3hoZEdadmNtMUdaV1ZOWVc1aFoyVnlRMjl1ZEhKaFkzUWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc1lYUm1iM0p0WDJabFpWOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UWUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JqWVd4c2MzVmlJR05vWVc1blpWQnNZWFJtYjNKdFQzZHVaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZhVzVwZEdsaGJHbDZaVjl5YjNWMFpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnNZWFJtYjNKdFgyWmxaVjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JHRjBabTl5YlY5bVpXVmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY0tJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJRYkdGMFptOXliVVpsWlUxaGJtRm5aWEpEYjI1MGNtRmpkQ0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Rb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05nb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc1lYUm1iM0p0WDJabFpWOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qUUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JqWVd4c2MzVmlJR2x1YVhScFlXeHBlbVVLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZbUZ5WlY5eWIzVjBhVzVuUURFMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc1lYUm1iM0p0WDJabFpWOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk53b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRkJzWVhSbWIzSnRSbVZsVFdGdVlXZGxja052Ym5SeVlXTjBJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU1Bb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z1kzSmxZWFJwYm1jS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3hoZEdadmNtMWZabVZsWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VUd4aGRHWnZjbTFHWldWTllXNWhaMlZ5UTI5dWRISmhZM1F1YVc1cGRHbGhiR2w2WlNoMGNtVmhjM1Z5ZVVGa1pISmxjM002SUdKNWRHVnpMQ0JoYzNObGRFbGtPaUIxYVc1ME5qUXNJSGRwZEdoa2NtRjNZV3hFWld4aGVWTmxZMjl1WkhNNklIVnBiblEyTkN3Z2NHeGhkR1p2Y20xUGQyNWxja0ZrWkhKbGMzTTZJR0o1ZEdWekxDQmlZWE5wYzFCdmFXNTBjMFJwZGpvZ2RXbHVkRFkwTENCdFlYaEdaV1ZRWTNRNklIVnBiblEyTkNrZ0xUNGdkbTlwWkRvS2FXNXBkR2xoYkdsNlpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JHRjBabTl5YlY5bVpXVmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTBMVE15Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdhVzVwZEdsaGJHbDZaU2dLSUNBZ0lDOHZJQ0FnZEhKbFlYTjFjbmxCWkdSeVpYTnpPaUJpZVhSbGN5d0tJQ0FnSUM4dklDQWdZWE56WlhSSlpEb2dkV2x1ZERZMExBb2dJQ0FnTHk4Z0lDQjNhWFJvWkhKaGQyRnNSR1ZzWVhsVFpXTnZibVJ6T2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFnSUhCc1lYUm1iM0p0VDNkdVpYSkJaR1J5WlhOek9pQmllWFJsY3l3S0lDQWdJQzh2SUNBZ1ltRnphWE5RYjJsdWRITkVhWFk2SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ0FnYldGNFJtVmxVR04wT2lCMWFXNTBOalFLSUNBZ0lDOHZJQ2s2SUhadmFXUWdld29nSUNBZ2NISnZkRzhnTmlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4aGRHWnZjbTFmWm1WbFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5Bb2dJQ0FnTHk4Z1lYTnpaWEowS0hSeVpXRnpkWEo1UVdSa2NtVnpjeTVzWlc1bmRHZ2dQaUF3TENBblZISmxZWE4xY25rZ1lXUmtjbVZ6Y3lCallXNXViM1FnWW1VZ1pXMXdkSGtuS1RzS0lDQWdJR1p5WVcxbFgyUnBaeUF0TmdvZ0lDQWdiR1Z1Q2lBZ0lDQmhjM05sY25RZ0x5OGdWSEpsWVhOMWNua2dZV1JrY21WemN5QmpZVzV1YjNRZ1ltVWdaVzF3ZEhrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YkdGMFptOXliVjltWldWZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNMUNpQWdJQ0F2THlCaGMzTmxjblFvY0d4aGRHWnZjbTFQZDI1bGNrRmtaSEpsYzNNdWJHVnVaM1JvSUQ0Z01Dd2dKMUJzWVhSbWIzSnRJRzkzYm1WeUlHRmtaSEpsYzNNZ1kyRnVibTkwSUdKbElHVnRjSFI1SnlrN0NpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR3hsYmdvZ0lDQWdZWE56WlhKMElDOHZJRkJzWVhSbWIzSnRJRzkzYm1WeUlHRmtaSEpsYzNNZ1kyRnVibTkwSUdKbElHVnRjSFI1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3hoZEdadmNtMWZabVZsWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TmdvZ0lDQWdMeThnWVhOelpYSjBLSGRwZEdoa2NtRjNZV3hFWld4aGVWTmxZMjl1WkhNZ1BpQXdMQ0FuVjJsMGFHUnlZWGRoYkNCa1pXeGhlU0J0ZFhOMElHSmxJR2R5WldGMFpYSWdkR2hoYmlBd0p5azdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUdGemMyVnlkQ0F2THlCWGFYUm9aSEpoZDJGc0lHUmxiR0Y1SUcxMWMzUWdZbVVnWjNKbFlYUmxjaUIwYUdGdUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JHRjBabTl5YlY5bVpXVmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTNDaUFnSUNBdkx5QmhjM05sY25Rb1ltRnphWE5RYjJsdWRITkVhWFlnUGlBd0xDQW5RbUZ6YVhNZ2NHOXBiblJ6SUdScGRtbHpiM0lnYlhWemRDQmlaU0JuY21WaGRHVnlJSFJvWVc0Z01DY3BPd29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCaGMzTmxjblFnTHk4Z1FtRnphWE1nY0c5cGJuUnpJR1JwZG1semIzSWdiWFZ6ZENCaVpTQm5jbVZoZEdWeUlIUm9ZVzRnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JzWVhSbWIzSnRYMlpsWlY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpnS0lDQWdJQzh2SUdGemMyVnlkQ2h0WVhoR1pXVlFZM1FnUGlBd0lDWW1JRzFoZUVabFpWQmpkQ0E4UFNBeE1EQXdNQ3dnSjAxaGVDQm1aV1VnY0dWeVkyVnVkR0ZuWlNCdGRYTjBJR0psSUdKbGRIZGxaVzRnTVNCaGJtUWdNVEF3TURBZ1ltRnphWE1nY0c5cGJuUnpKeWs3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSjZJR2x1YVhScFlXeHBlbVZmWW05dmJGOW1ZV3h6WlVBekNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2x1ZEdOZk1pQXZMeUF4TURBd01Bb2dJQ0FnUEQwS0lDQWdJR0o2SUdsdWFYUnBZV3hwZW1WZlltOXZiRjltWVd4elpVQXpDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb0thVzVwZEdsaGJHbDZaVjlpYjI5c1gyMWxjbWRsUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4aGRHWnZjbTFmWm1WbFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek9Bb2dJQ0FnTHk4Z1lYTnpaWEowS0cxaGVFWmxaVkJqZENBK0lEQWdKaVlnYldGNFJtVmxVR04wSUR3OUlERXdNREF3TENBblRXRjRJR1psWlNCd1pYSmpaVzUwWVdkbElHMTFjM1FnWW1VZ1ltVjBkMlZsYmlBeElHRnVaQ0F4TURBd01DQmlZWE5wY3lCd2IybHVkSE1uS1RzS0lDQWdJR0Z6YzJWeWRDQXZMeUJOWVhnZ1ptVmxJSEJsY21ObGJuUmhaMlVnYlhWemRDQmlaU0JpWlhSM1pXVnVJREVnWVc1a0lERXdNREF3SUdKaGMybHpJSEJ2YVc1MGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc1lYUm1iM0p0WDJabFpWOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9Rb2dJQ0FnTHk4Z2NHeGhkR1p2Y20xVWNtVmhjM1Z5ZVNBOUlFZHNiMkpoYkZOMFlYUmxQR0o1ZEdWelBpZ3BPd29nSUNBZ1lubDBaV01nTkNBdkx5QWljR3hoZEdadmNtMVVjbVZoYzNWeWVTSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JHRjBabTl5YlY5bVpXVmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXdDaUFnSUNBdkx5QjBhR2x6TG5Cc1lYUm1iM0p0VkhKbFlYTjFjbmt1ZG1Gc2RXVWdQU0IwY21WaGMzVnllVUZrWkhKbGMzTTdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUWUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHeGhkR1p2Y20xZlptVmxYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNUW9nSUNBZ0x5OGdabVZsUVhOelpYUkpaQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tUc0tJQ0FnSUhCMWMyaGllWFJsY3lBaVptVmxRWE56WlhSSlpDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JHRjBabTl5YlY5bVpXVmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXhDaUFnSUNBdkx5QjBhR2x6TG1abFpVRnpjMlYwU1dRdWRtRnNkV1VnUFNCaGMzTmxkRWxrT3dvZ0lDQWdabkpoYldWZlpHbG5JQzAxQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JzWVhSbWIzSnRYMlpsWlY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJS0lDQWdJQzh2SUhkcGRHaGtjbUYzWVd4RVpXeGhlU0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tUc2dMeThnVTJWamIyNWtjd29nSUNBZ1lubDBaV01nTlNBdkx5QWlkMmwwYUdSeVlYZGhiRVJsYkdGNUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc1lYUm1iM0p0WDJabFpWOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5ESUtJQ0FnSUM4dklIUm9hWE11ZDJsMGFHUnlZWGRoYkVSbGJHRjVMblpoYkhWbElEMGdkMmwwYUdSeVlYZGhiRVJsYkdGNVUyVmpiMjVrY3pzS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YkdGMFptOXliVjltWldWZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd0NpQWdJQ0F2THlCMGIzUmhiRVpsWlhORGIyeHNaV04wWldRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2s3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0owYjNSaGJFWmxaWE5EYjJ4c1pXTjBaV1FpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3hoZEdadmNtMWZabVZsWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTXdvZ0lDQWdMeThnZEdocGN5NTBiM1JoYkVabFpYTkRiMnhzWldOMFpXUXVkbUZzZFdVZ1BTQXdPd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHeGhkR1p2Y20xZlptVmxYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNd29nSUNBZ0x5OGdiR0Z6ZEZkcGRHaGtjbUYzWVd3Z1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2s3Q2lBZ0lDQmllWFJsWXlBMklDOHZJQ0pzWVhOMFYybDBhR1J5WVhkaGJDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JHRjBabTl5YlY5bVpXVmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTBDaUFnSUNBdkx5QjBhR2x6TG14aGMzUlhhWFJvWkhKaGQyRnNMblpoYkhWbElEMGdNRHNLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnNZWFJtYjNKdFgyWmxaVjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFFLSUNBZ0lDOHZJSEJzWVhSbWIzSnRUM2R1WlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhpZVhSbGN6NG9LVHNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbkJzWVhSbWIzSnRUM2R1WlhJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4aGRHWnZjbTFmWm1WbFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME5Rb2dJQ0FnTHk4Z2RHaHBjeTV3YkdGMFptOXliVTkzYm1WeUxuWmhiSFZsSUQwZ2NHeGhkR1p2Y20xUGQyNWxja0ZrWkhKbGMzTTdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHeGhkR1p2Y20xZlptVmxYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOd29nSUNBZ0x5OGdZbUZ6YVhOUWIybHVkSE5FYVhacGMyOXlJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncE95QXZMeUJFWldaaGRXeDBPaUF4TURBd01DQW9NVEF3TGpBd0pTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltSmhjMmx6VUc5cGJuUnpSR2wyYVhOdmNpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JHRjBabTl5YlY5bVpXVmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTRDaUFnSUNBdkx5QjBhR2x6TG1KaGMybHpVRzlwYm5SelJHbDJhWE52Y2k1MllXeDFaU0E5SUdKaGMybHpVRzlwYm5SelJHbDJPd29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnNZWFJtYjNKdFgyWmxaVjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGdLSUNBZ0lDOHZJRzFoZUVabFpWQmxjbU5sYm5SaFoyVWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrN0lDOHZJRTFoZUdsdGRXMGdZV3hzYjNkbFpDQm1aV1VnY0dWeVkyVnVkR0ZuWlFvZ0lDQWdZbmwwWldNZ055QXZMeUFpYldGNFJtVmxVR1Z5WTJWdWRHRm5aU0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiR0YwWm05eWJWOW1aV1ZmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalE1Q2lBZ0lDQXZMeUIwYUdsekxtMWhlRVpsWlZCbGNtTmxiblJoWjJVdWRtRnNkV1VnUFNCdFlYaEdaV1ZRWTNRN0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0J5WlhSemRXSUtDbWx1YVhScFlXeHBlbVZmWW05dmJGOW1ZV3h6WlVBek9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnYVc1cGRHbGhiR2w2WlY5aWIyOXNYMjFsY21kbFFEUUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4aGRHWnZjbTFmWm1WbFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlVHeGhkR1p2Y20xR1pXVk5ZVzVoWjJWeVEyOXVkSEpoWTNRdVkyaGhibWRsVUd4aGRHWnZjbTFQZDI1bGNpaHVaWGRQZDI1bGNqb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNtTm9ZVzVuWlZCc1lYUm1iM0p0VDNkdVpYSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHeGhkR1p2Y20xZlptVmxYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFOaTAxT1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lDOHZJR05vWVc1blpWQnNZWFJtYjNKdFQzZHVaWElvQ2lBZ0lDQXZMeUFnSUc1bGQwOTNibVZ5T2lCaWVYUmxjd29nSUNBZ0x5OGdLVG9nZG05cFpDQjdDaUFnSUNCd2NtOTBieUF4SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YkdGMFptOXliVjltWldWZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZd0NpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2k1aWVYUmxjeUE5UFQwZ2RHaHBjeTV3YkdGMFptOXliVTkzYm1WeUxuWmhiSFZsTENBblQyNXNlU0JqZFhKeVpXNTBJSEJzWVhSbWIzSnRJRzkzYm1WeUlHTmhiaUJqYUdGdVoyVWdiM2R1WlhJbktUc0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YkdGMFptOXliVjltWldWZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMENpQWdJQ0F2THlCd2JHRjBabTl5YlU5M2JtVnlJRDBnUjJ4dlltRnNVM1JoZEdVOFlubDBaWE0rS0NrN0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpY0d4aGRHWnZjbTFQZDI1bGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4aGRHWnZjbTFmWm1WbFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk1Bb2dJQ0FnTHk4Z1lYTnpaWEowS0ZSNGJpNXpaVzVrWlhJdVlubDBaWE1nUFQwOUlIUm9hWE11Y0d4aGRHWnZjbTFQZDI1bGNpNTJZV3gxWlN3Z0owOXViSGtnWTNWeWNtVnVkQ0J3YkdGMFptOXliU0J2ZDI1bGNpQmpZVzRnWTJoaGJtZGxJRzkzYm1WeUp5azdDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2dZM1Z5Y21WdWRDQndiR0YwWm05eWJTQnZkMjVsY2lCallXNGdZMmhoYm1kbElHOTNibVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3hoZEdadmNtMWZabVZsWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTVFvZ0lDQWdMeThnWVhOelpYSjBLRzVsZDA5M2JtVnlMbXhsYm1kMGFDQStJREFzSUNkT1pYY2diM2R1WlhJZ1lXUmtjbVZ6Y3lCallXNXViM1FnWW1VZ1pXMXdkSGtuS1RzS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdiR1Z1Q2lBZ0lDQmhjM05sY25RZ0x5OGdUbVYzSUc5M2JtVnlJR0ZrWkhKbGMzTWdZMkZ1Ym05MElHSmxJR1Z0Y0hSNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4aGRHWnZjbTFmWm1WbFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5Bb2dJQ0FnTHk4Z2NHeGhkR1p2Y20xUGQyNWxjaUE5SUVkc2IySmhiRk4wWVhSbFBHSjVkR1Z6UGlncE93b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5Cc1lYUm1iM0p0VDNkdVpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc1lYUm1iM0p0WDJabFpWOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qSUtJQ0FnSUM4dklHRnpjMlZ5ZENodVpYZFBkMjVsY2lBaFBUMGdkR2hwY3k1d2JHRjBabTl5YlU5M2JtVnlMblpoYkhWbExDQW5UbVYzSUc5M2JtVnlJRzExYzNRZ1ltVWdaR2xtWm1WeVpXNTBJR1p5YjIwZ1kzVnljbVZ1ZENjcE93b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0FoUFFvZ0lDQWdZWE56WlhKMElDOHZJRTVsZHlCdmQyNWxjaUJ0ZFhOMElHSmxJR1JwWm1abGNtVnVkQ0JtY205dElHTjFjbkpsYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YkdGMFptOXliVjltWldWZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMENpQWdJQ0F2THlCd2JHRjBabTl5YlU5M2JtVnlJRDBnUjJ4dlltRnNVM1JoZEdVOFlubDBaWE0rS0NrN0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKd2JHRjBabTl5YlU5M2JtVnlJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnNZWFJtYjNKdFgyWmxaVjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOalFLSUNBZ0lDOHZJSFJvYVhNdWNHeGhkR1p2Y20xUGQyNWxjaTUyWVd4MVpTQTlJRzVsZDA5M2JtVnlPd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnNZWFJtYjNKdFgyWmxaVjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbEJzWVhSbWIzSnRSbVZsVFdGdVlXZGxja052Ym5SeVlXTjBMblZ3WkdGMFpVSmhjMmx6VUc5cGJuUnpSR2wyYVhOdmNpaHVaWGRFYVhacGMyOXlPaUIxYVc1ME5qUXBJQzArSUhadmFXUTZDblZ3WkdGMFpVSmhjMmx6VUc5cGJuUnpSR2wyYVhOdmNqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JHRjBabTl5YlY5bVpXVmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY3hMVGMwQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdkWEJrWVhSbFFtRnphWE5RYjJsdWRITkVhWFpwYzI5eUtBb2dJQ0FnTHk4Z0lDQnVaWGRFYVhacGMyOXlPaUIxYVc1ME5qUUtJQ0FnSUM4dklDazZJSFp2YVdRZ2V3b2dJQ0FnY0hKdmRHOGdNU0F3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3hoZEdadmNtMWZabVZsWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTlFvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWEl1WW5sMFpYTWdQVDA5SUhSb2FYTXVjR3hoZEdadmNtMVBkMjVsY2k1MllXeDFaU3dnSjA5dWJIa2djR3hoZEdadmNtMGdiM2R1WlhJZ1kyRnVJSFZ3WkdGMFpTQmlZWE5wY3lCd2IybHVkSE1nWkdsMmFYTnZjaWNwT3dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnNZWFJtYjNKdFgyWmxaVjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFFLSUNBZ0lDOHZJSEJzWVhSbWIzSnRUM2R1WlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhpZVhSbGN6NG9LVHNLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSndiR0YwWm05eWJVOTNibVZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiR0YwWm05eWJWOW1aV1ZmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamMxQ2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaTVpZVhSbGN5QTlQVDBnZEdocGN5NXdiR0YwWm05eWJVOTNibVZ5TG5aaGJIVmxMQ0FuVDI1c2VTQndiR0YwWm05eWJTQnZkMjVsY2lCallXNGdkWEJrWVhSbElHSmhjMmx6SUhCdmFXNTBjeUJrYVhacGMyOXlKeWs3Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnY0d4aGRHWnZjbTBnYjNkdVpYSWdZMkZ1SUhWd1pHRjBaU0JpWVhOcGN5QndiMmx1ZEhNZ1pHbDJhWE52Y2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JzWVhSbWIzSnRYMlpsWlY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpZS0lDQWdJQzh2SUdGemMyVnlkQ2h1WlhkRWFYWnBjMjl5SUQ0Z01Dd2dKMEpoYzJseklIQnZhVzUwY3lCa2FYWnBjMjl5SUcxMWMzUWdZbVVnWjNKbFlYUmxjaUIwYUdGdUlEQW5LVHNLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lYTnpaWEowSUM4dklFSmhjMmx6SUhCdmFXNTBjeUJrYVhacGMyOXlJRzExYzNRZ1ltVWdaM0psWVhSbGNpQjBhR0Z1SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YkdGMFptOXliVjltWldWZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFM0NpQWdJQ0F2THlCaVlYTnBjMUJ2YVc1MGMwUnBkbWx6YjNJZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2s3SUM4dklFUmxabUYxYkhRNklERXdNREF3SUNneE1EQXVNREFsS1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpWW1GemFYTlFiMmx1ZEhORWFYWnBjMjl5SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JzWVhSbWIzSnRYMlpsWlY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpnS0lDQWdJQzh2SUhSb2FYTXVZbUZ6YVhOUWIybHVkSE5FYVhacGMyOXlMblpoYkhWbElEMGdibVYzUkdsMmFYTnZjanNLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiR0YwWm05eWJWOW1aV1ZmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBRYkdGMFptOXliVVpsWlUxaGJtRm5aWEpEYjI1MGNtRmpkQzUxY0dSaGRHVk5ZWGhHWldWUVpYSmpaVzUwWVdkbEtHNWxkMDFoZUVabFpUb2dkV2x1ZERZMEtTQXRQaUIyYjJsa09ncDFjR1JoZEdWTllYaEdaV1ZRWlhKalpXNTBZV2RsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JzWVhSbWIzSnRYMlpsWlY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RVdE9EZ0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCMWNHUmhkR1ZOWVhoR1pXVlFaWEpqWlc1MFlXZGxLQW9nSUNBZ0x5OGdJQ0J1WlhkTllYaEdaV1U2SUhWcGJuUTJOQW9nSUNBZ0x5OGdLVG9nZG05cFpDQjdDaUFnSUNCd2NtOTBieUF4SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YkdGMFptOXliVjltWldWZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnNUNpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2k1aWVYUmxjeUE5UFQwZ2RHaHBjeTV3YkdGMFptOXliVTkzYm1WeUxuWmhiSFZsTENBblQyNXNlU0J3YkdGMFptOXliU0J2ZDI1bGNpQmpZVzRnZFhCa1lYUmxJRzFoZUNCbVpXVWdjR1Z5WTJWdWRHRm5aU2NwT3dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnNZWFJtYjNKdFgyWmxaVjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFFLSUNBZ0lDOHZJSEJzWVhSbWIzSnRUM2R1WlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhpZVhSbGN6NG9LVHNLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSndiR0YwWm05eWJVOTNibVZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiR0YwWm05eWJWOW1aV1ZmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamc1Q2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaTVpZVhSbGN5QTlQVDBnZEdocGN5NXdiR0YwWm05eWJVOTNibVZ5TG5aaGJIVmxMQ0FuVDI1c2VTQndiR0YwWm05eWJTQnZkMjVsY2lCallXNGdkWEJrWVhSbElHMWhlQ0JtWldVZ2NHVnlZMlZ1ZEdGblpTY3BPd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJSEJzWVhSbWIzSnRJRzkzYm1WeUlHTmhiaUIxY0dSaGRHVWdiV0Y0SUdabFpTQndaWEpqWlc1MFlXZGxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHeGhkR1p2Y20xZlptVmxYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVNQW9nSUNBZ0x5OGdZWE56WlhKMEtHNWxkMDFoZUVabFpTQStJREFnSmlZZ2JtVjNUV0Y0Um1WbElEdzlJREV3TURBd0xDQW5UV0Y0SUdabFpTQndaWEpqWlc1MFlXZGxJRzExYzNRZ1ltVWdZbVYwZDJWbGJpQXhJR0Z1WkNBeE1EQXdNQ0JpWVhOcGN5QndiMmx1ZEhNbktUc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWW5vZ2RYQmtZWFJsVFdGNFJtVmxVR1Z5WTJWdWRHRm5aVjlpYjI5c1gyWmhiSE5sUURNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhVzUwWTE4eUlDOHZJREV3TURBd0NpQWdJQ0E4UFFvZ0lDQWdZbm9nZFhCa1lYUmxUV0Y0Um1WbFVHVnlZMlZ1ZEdGblpWOWliMjlzWDJaaGJITmxRRE1LSUNBZ0lHbHVkR05mTVNBdkx5QXhDZ3AxY0dSaGRHVk5ZWGhHWldWUVpYSmpaVzUwWVdkbFgySnZiMnhmYldWeVoyVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiR0YwWm05eWJWOW1aV1ZmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamt3Q2lBZ0lDQXZMeUJoYzNObGNuUW9ibVYzVFdGNFJtVmxJRDRnTUNBbUppQnVaWGROWVhoR1pXVWdQRDBnTVRBd01EQXNJQ2ROWVhnZ1ptVmxJSEJsY21ObGJuUmhaMlVnYlhWemRDQmlaU0JpWlhSM1pXVnVJREVnWVc1a0lERXdNREF3SUdKaGMybHpJSEJ2YVc1MGN5Y3BPd29nSUNBZ1lYTnpaWEowSUM4dklFMWhlQ0JtWldVZ2NHVnlZMlZ1ZEdGblpTQnRkWE4wSUdKbElHSmxkSGRsWlc0Z01TQmhibVFnTVRBd01EQWdZbUZ6YVhNZ2NHOXBiblJ6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3hoZEdadmNtMWZabVZsWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T0FvZ0lDQWdMeThnYldGNFJtVmxVR1Z5WTJWdWRHRm5aU0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tUc2dMeThnVFdGNGFXMTFiU0JoYkd4dmQyVmtJR1psWlNCd1pYSmpaVzUwWVdkbENpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKdFlYaEdaV1ZRWlhKalpXNTBZV2RsSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JzWVhSbWIzSnRYMlpsWlY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RJS0lDQWdJQzh2SUhSb2FYTXViV0Y0Um1WbFVHVnlZMlZ1ZEdGblpTNTJZV3gxWlNBOUlHNWxkMDFoZUVabFpUc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUhKbGRITjFZZ29LZFhCa1lYUmxUV0Y0Um1WbFVHVnlZMlZ1ZEdGblpWOWliMjlzWDJaaGJITmxRRE02Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQjFjR1JoZEdWTllYaEdaV1ZRWlhKalpXNTBZV2RsWDJKdmIyeGZiV1Z5WjJWQU5Bb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YkdGMFptOXliVjltWldWZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwUWJHRjBabTl5YlVabFpVMWhibUZuWlhKRGIyNTBjbUZqZEM1amIyeHNaV04wUm1WbGN5aGhiVzkxYm5RNklIVnBiblEyTkN3Z1ptVmxVR1Z5WTJWdWRHRm5aVUp3Y3pvZ2RXbHVkRFkwS1NBdFBpQjJiMmxrT2dwamIyeHNaV04wUm1WbGN6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JHRjBabTl5YlY5bVpXVmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qazRMVEV3TWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lDOHZJR052Ykd4bFkzUkdaV1Z6S0FvZ0lDQWdMeThnSUNCaGJXOTFiblE2SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ0FnWm1WbFVHVnlZMlZ1ZEdGblpVSndjem9nZFdsdWREWTBDaUFnSUNBdkx5QXBPaUIyYjJsa0lIc0tJQ0FnSUhCeWIzUnZJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JzWVhSbWIzSnRYMlpsWlY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBMENpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2k1aWVYUmxjeUE5UFQwZ2RHaHBjeTV3YkdGMFptOXliVTkzYm1WeUxuWmhiSFZsTENBblQyNXNlU0J3YkdGMFptOXliU0J2ZDI1bGNpQmpZVzRnWTI5c2JHVmpkQ0JtWldWekp5azdDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4aGRHWnZjbTFmWm1WbFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5Bb2dJQ0FnTHk4Z2NHeGhkR1p2Y20xUGQyNWxjaUE5SUVkc2IySmhiRk4wWVhSbFBHSjVkR1Z6UGlncE93b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5Cc1lYUm1iM0p0VDNkdVpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc1lYUm1iM0p0WDJabFpWOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQTBDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbk5sYm1SbGNpNWllWFJsY3lBOVBUMGdkR2hwY3k1d2JHRjBabTl5YlU5M2JtVnlMblpoYkhWbExDQW5UMjVzZVNCd2JHRjBabTl5YlNCdmQyNWxjaUJqWVc0Z1kyOXNiR1ZqZENCbVpXVnpKeWs3Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnY0d4aGRHWnZjbTBnYjNkdVpYSWdZMkZ1SUdOdmJHeGxZM1FnWm1WbGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc1lYUm1iM0p0WDJabFpWOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQTJDaUFnSUNBdkx5QmpiMjV6ZENCbVpXVkJiVzkxYm5RNklIVnBiblEyTkNBOUlDaGhiVzkxYm5RZ0tpQm1aV1ZRWlhKalpXNTBZV2RsUW5CektTQXZJSFJvYVhNdVltRnphWE5RYjJsdWRITkVhWFpwYzI5eUxuWmhiSFZsT3dvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lDb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JHRjBabTl5YlY5bVpXVmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTNDaUFnSUNBdkx5QmlZWE5wYzFCdmFXNTBjMFJwZG1semIzSWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrN0lDOHZJRVJsWm1GMWJIUTZJREV3TURBd0lDZ3hNREF1TURBbEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1KaGMybHpVRzlwYm5SelJHbDJhWE52Y2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3hoZEdadmNtMWZabVZsWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURZS0lDQWdJQzh2SUdOdmJuTjBJR1psWlVGdGIzVnVkRG9nZFdsdWREWTBJRDBnS0dGdGIzVnVkQ0FxSUdabFpWQmxjbU5sYm5SaFoyVkNjSE1wSUM4Z2RHaHBjeTVpWVhOcGMxQnZhVzUwYzBScGRtbHpiM0l1ZG1Gc2RXVTdDaUFnSUNBdkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4aGRHWnZjbTFmWm1WbFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1Bb2dJQ0FnTHk4Z2RHOTBZV3hHWldWelEyOXNiR1ZqZEdWa0lEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwT3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJblJ2ZEdGc1JtVmxjME52Ykd4bFkzUmxaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHeGhkR1p2Y20xZlptVmxYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRGNLSUNBZ0lDOHZJSFJvYVhNdWRHOTBZV3hHWldWelEyOXNiR1ZqZEdWa0xuWmhiSFZsSUQwZ2RHaHBjeTUwYjNSaGJFWmxaWE5EYjJ4c1pXTjBaV1F1ZG1Gc2RXVWdLeUJtWldWQmJXOTFiblE3Q2lBZ0lDQXJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHeGhkR1p2Y20xZlptVmxYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNQW9nSUNBZ0x5OGdkRzkwWVd4R1pXVnpRMjlzYkdWamRHVmtJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncE93b2dJQ0FnWW5sMFpXTmZNaUF2THlBaWRHOTBZV3hHWldWelEyOXNiR1ZqZEdWa0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc1lYUm1iM0p0WDJabFpWOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQTNDaUFnSUNBdkx5QjBhR2x6TG5SdmRHRnNSbVZsYzBOdmJHeGxZM1JsWkM1MllXeDFaU0E5SUhSb2FYTXVkRzkwWVd4R1pXVnpRMjlzYkdWamRHVmtMblpoYkhWbElDc2dabVZsUVcxdmRXNTBPd29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiR0YwWm05eWJWOW1aV1ZmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBRYkdGMFptOXliVVpsWlUxaGJtRm5aWEpEYjI1MGNtRmpkQzV5WlhGMVpYTjBWMmwwYUdSeVlYZGhiQ2dwSUMwK0lIWnZhV1E2Q25KbGNYVmxjM1JYYVhSb1pISmhkMkZzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JzWVhSbWIzSnRYMlpsWlY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFMkNpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2k1aWVYUmxjeUE5UFQwZ2RHaHBjeTV3YkdGMFptOXliVTkzYm1WeUxuWmhiSFZsTENBblQyNXNlU0J3YkdGMFptOXliU0J2ZDI1bGNpQmpZVzRnY21WeGRXVnpkQ0IzYVhSb1pISmhkMkZzSnlrN0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3hoZEdadmNtMWZabVZsWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkFvZ0lDQWdMeThnY0d4aGRHWnZjbTFQZDI1bGNpQTlJRWRzYjJKaGJGTjBZWFJsUEdKNWRHVnpQaWdwT3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbkJzWVhSbWIzSnRUM2R1WlhJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JzWVhSbWIzSnRYMlpsWlY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFMkNpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2k1aWVYUmxjeUE5UFQwZ2RHaHBjeTV3YkdGMFptOXliVTkzYm1WeUxuWmhiSFZsTENBblQyNXNlU0J3YkdGMFptOXliU0J2ZDI1bGNpQmpZVzRnY21WeGRXVnpkQ0IzYVhSb1pISmhkMkZzSnlrN0NpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ2NHeGhkR1p2Y20wZ2IzZHVaWElnWTJGdUlISmxjWFZsYzNRZ2QybDBhR1J5WVhkaGJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc1lYUm1iM0p0WDJabFpWOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UTUtJQ0FnSUM4dklHeGhjM1JYYVhSb1pISmhkMkZzSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BPd29nSUNBZ1lubDBaV01nTmlBdkx5QWliR0Z6ZEZkcGRHaGtjbUYzWVd3aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4aGRHWnZjbTFmWm1WbFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1UZ0tJQ0FnSUM4dklIUm9hWE11YkdGemRGZHBkR2hrY21GM1lXd3VkbUZzZFdVZ1BTQXdPeUF2THlCU1pYTmxkQ0IwYnlCemRHRnlkQ0J1WlhjZ1pHVnNZWGtLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnNZWFJtYjNKdFgyWmxaVjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbEJzWVhSbWIzSnRSbVZsVFdGdVlXZGxja052Ym5SeVlXTjBMbWRsZEZSdmRHRnNSbVZsYzBOdmJHeGxZM1JsWkNncElDMCtJSFZwYm5RMk5Eb0taMlYwVkc5MFlXeEdaV1Z6UTI5c2JHVmpkR1ZrT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JzWVhSbWIzSnRYMlpsWlY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBS0lDQWdJQzh2SUhSdmRHRnNSbVZsYzBOdmJHeGxZM1JsWkNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LVHNLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSjBiM1JoYkVabFpYTkRiMnhzWldOMFpXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc1lYUm1iM0p0WDJabFpWOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USTJDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTUwYjNSaGJFWmxaWE5EYjJ4c1pXTjBaV1F1ZG1Gc2RXVTdDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHeGhkR1p2Y20xZlptVmxYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVR3hoZEdadmNtMUdaV1ZOWVc1aFoyVnlRMjl1ZEhKaFkzUXVZMkZzWTNWc1lYUmxSbVZsS0dGdGIzVnVkRG9nZFdsdWREWTBMQ0JtWldWUVpYSmpaVzUwWVdkbFFuQnpPaUIxYVc1ME5qUXBJQzArSUhWcGJuUTJORG9LWTJGc1kzVnNZWFJsUm1WbE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc1lYUm1iM0p0WDJabFpWOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UTXlMVEV6TXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lDOHZJR05oYkdOMWJHRjBaVVpsWlNoaGJXOTFiblE2SUhWcGJuUTJOQ3dnWm1WbFVHVnlZMlZ1ZEdGblpVSndjem9nZFdsdWREWTBLVG9nZFdsdWREWTBJSHNLSUNBZ0lIQnliM1J2SURJZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc1lYUm1iM0p0WDJabFpWOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UTTBDaUFnSUNBdkx5QnlaWFIxY200Z0tHRnRiM1Z1ZENBcUlHWmxaVkJsY21ObGJuUmhaMlZDY0hNcElDOGdkR2hwY3k1aVlYTnBjMUJ2YVc1MGMwUnBkbWx6YjNJdWRtRnNkV1U3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ0tnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc1lYUm1iM0p0WDJabFpWOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UY0tJQ0FnSUM4dklHSmhjMmx6VUc5cGJuUnpSR2wyYVhOdmNpQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1RzZ0x5OGdSR1ZtWVhWc2REb2dNVEF3TURBZ0tERXdNQzR3TUNVcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUFpWW1GemFYTlFiMmx1ZEhORWFYWnBjMjl5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiR0YwWm05eWJWOW1aV1ZmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6TkFvZ0lDQWdMeThnY21WMGRYSnVJQ2hoYlc5MWJuUWdLaUJtWldWUVpYSmpaVzUwWVdkbFFuQnpLU0F2SUhSb2FYTXVZbUZ6YVhOUWIybHVkSE5FYVhacGMyOXlMblpoYkhWbE93b2dJQ0FnTHdvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JzWVhSbWIzSnRYMlpsWlY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xCc1lYUm1iM0p0Um1WbFRXRnVZV2RsY2tOdmJuUnlZV04wTG1kbGRGUnlaV0Z6ZFhKNVFXUmtjbVZ6Y3lncElDMCtJR0o1ZEdWek9ncG5aWFJVY21WaGMzVnllVUZrWkhKbGMzTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHeGhkR1p2Y20xZlptVmxYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVDaUFnSUNBdkx5QndiR0YwWm05eWJWUnlaV0Z6ZFhKNUlEMGdSMnh2WW1Gc1UzUmhkR1U4WW5sMFpYTStLQ2s3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QWljR3hoZEdadmNtMVVjbVZoYzNWeWVTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4aGRHWnZjbTFmWm1WbFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5ESUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbkJzWVhSbWIzSnRWSEpsWVhOMWNua3VkbUZzZFdVN0NpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4aGRHWnZjbTFmWm1WbFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlVHeGhkR1p2Y20xR1pXVk5ZVzVoWjJWeVEyOXVkSEpoWTNRdVoyVjBWMmwwYUdSeVlYZGhiRVJsYkdGNUtDa2dMVDRnZFdsdWREWTBPZ3BuWlhSWGFYUm9aSEpoZDJGc1JHVnNZWGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3hoZEdadmNtMWZabVZsWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWdvZ0lDQWdMeThnZDJsMGFHUnlZWGRoYkVSbGJHRjVJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncE95QXZMeUJUWldOdmJtUnpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOU0F2THlBaWQybDBhR1J5WVhkaGJFUmxiR0Y1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiR0YwWm05eWJWOW1aV1ZmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxTUFvZ0lDQWdMeThnY21WMGRYSnVJSFJvYVhNdWQybDBhR1J5WVhkaGJFUmxiR0Y1TG5aaGJIVmxPd29nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBREFBR1FUaVlJRFhCc1lYUm1iM0p0VDNkdVpYSUVGUjk4ZFJKMGIzUmhiRVpsWlhORGIyeHNaV04wWldRU1ltRnphWE5RYjJsdWRITkVhWFpwYzI5eUVIQnNZWFJtYjNKdFZISmxZWE4xY25rUGQybDBhR1J5WVhkaGJFUmxiR0Y1RG14aGMzUlhhWFJvWkhKaGQyRnNFRzFoZUVabFpWQmxjbU5sYm5SaFoyVXhHMEVCUG9JTEJCMGszcUlFbWFuMDZBU0F5cFpmQkhzbmtoNEU5VURZZ1FTUi84RXBCTHdFcGtrRWdWZEZpQVFleU1IUEJIWGZJeFFFNElPTHVqWWFBSTRMQU1JQXNBQ2dBSkFBZkFCd0FGOEFSZ0F1QUIwQUFpSkRNUmtVUkRFWVJEWWFBVmNDQUVrVkZsY0dBa3hRS1V4UXNDTkRNUmtVUkRFWVJJZ0J0UllwVEZDd0kwTXhHUlJFTVJoRWlBR2VTUlVXVndZQ1RGQXBURkN3STBNeEdSUkVNUmhFTmhvQkZ6WWFBaGVJQVhBV0tVeFFzQ05ETVJrVVJERVlSSWdCV2hZcFRGQ3dJME14R1JSRU1SaEVpQUU4STBNeEdSUkVNUmhFTmhvQkZ6WWFBaGVJQVFvalF6RVpGRVF4R0VRMkdnRVhpQURYSTBNeEdSUkVNUmhFTmhvQkY0Z0F0Q05ETVJrVVJERVlSRFlhQVZjQ0FJZ0FoaU5ETVJrVVJERVlSRFlhQVZjQ0FEWWFBaGMyR2dNWE5ob0VWd0lBTmhvRkZ6WWFCaGVJQUEwalF6RVpRUDhSTVJnVVJDTkRpZ1lBaS9vVlJJdjlGVVNML0VTTC9rU0wvMEVBTjR2L0pBNUJBREFqUkNjRWkvcG5nQXBtWldWQmMzTmxkRWxraS90bkp3V0wvR2NxSW1jbkJpSm5LSXY5Wnl1TC9tY25CNHYvWjRraVF2L05pZ0VBTVFBaUtHVkVFa1NML3hWRUlpaGxSSXYvRTBRb2kvOW5pWW9CQURFQUlpaGxSQkpFaS85RUs0di9aNG1LQVFBeEFDSW9aVVFTUkl2L1FRQVBpLzhrRGtFQUNDTkVKd2VMLzJlSklrTC85WW9DQURFQUlpaGxSQkpFaS82TC93c2lLMlZFQ2lJcVpVUUlLa3huaVRFQUlpaGxSQkpFSndZaVo0a2lLbVZFaVlvQ0FZditpLzhMSWl0bFJBcUpJaWNFWlVTSklpY0ZaVVNKIiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6NywicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
