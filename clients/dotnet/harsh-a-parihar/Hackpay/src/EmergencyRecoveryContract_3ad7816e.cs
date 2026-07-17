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

namespace Arc56.Generated.harsh_a_parihar.Hackpay.EmergencyRecoveryContract_3ad7816e
{


    //
    // Emergency Recovery Contract
    //Handles time-delayed recovery mechanisms for emergency situations
    //
    public class EmergencyRecoveryContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public EmergencyRecoveryContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Initialize the emergency recovery contract
        ///PRODUCTION READY: Configurable recovery owner with proper validation
        ///</summary>
        /// <param name="delaySeconds"> </param>
        /// <param name="threshold"> </param>
        /// <param name="recoveryAddr"> </param>
        /// <param name="recoveryOwnerAddress"> </param>
        public async Task Initialize(ulong delaySeconds, ulong threshold, byte[] recoveryAddr, byte[] recoveryOwnerAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 30, 251, 153, 172 };
            var delaySecondsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); delaySecondsAbi.From(delaySeconds);
            var thresholdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); thresholdAbi.From(threshold);
            var recoveryAddrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); recoveryAddrAbi.From(recoveryAddr);
            var recoveryOwnerAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); recoveryOwnerAddressAbi.From(recoveryOwnerAddress);

            var result = await base.CallApp(new List<object> { abiHandle, delaySecondsAbi, thresholdAbi, recoveryAddrAbi, recoveryOwnerAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Initialize_Transactions(ulong delaySeconds, ulong threshold, byte[] recoveryAddr, byte[] recoveryOwnerAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 30, 251, 153, 172 };
            var delaySecondsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); delaySecondsAbi.From(delaySeconds);
            var thresholdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); thresholdAbi.From(threshold);
            var recoveryAddrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); recoveryAddrAbi.From(recoveryAddr);
            var recoveryOwnerAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); recoveryOwnerAddressAbi.From(recoveryOwnerAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, delaySecondsAbi, thresholdAbi, recoveryAddrAbi, recoveryOwnerAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Change recovery owner (governance)
        ///PRODUCTION READY: Allows authority transfer for governance
        ///</summary>
        /// <param name="newOwner"> </param>
        public async Task ChangeRecoveryOwner(byte[] newOwner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 5, 71, 185, 232 };
            var newOwnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); newOwnerAbi.From(newOwner);

            var result = await base.CallApp(new List<object> { abiHandle, newOwnerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ChangeRecoveryOwner_Transactions(byte[] newOwner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 5, 71, 185, 232 };
            var newOwnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); newOwnerAbi.From(newOwner);

            return await base.MakeTransactionList(new List<object> { abiHandle, newOwnerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update recovery address (owner only)
        ///PRODUCTION READY: Allows recovery address updates
        ///</summary>
        /// <param name="newRecoveryAddr"> </param>
        public async Task UpdateRecoveryAddress(byte[] newRecoveryAddr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 60, 219, 111 };
            var newRecoveryAddrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); newRecoveryAddrAbi.From(newRecoveryAddr);

            var result = await base.CallApp(new List<object> { abiHandle, newRecoveryAddrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateRecoveryAddress_Transactions(byte[] newRecoveryAddr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 60, 219, 111 };
            var newRecoveryAddrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); newRecoveryAddrAbi.From(newRecoveryAddr);

            return await base.MakeTransactionList(new List<object> { abiHandle, newRecoveryAddrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update emergency threshold (owner only)
        ///PRODUCTION READY: Allows threshold updates with validation
        ///</summary>
        /// <param name="newThreshold"> </param>
        public async Task UpdateEmergencyThreshold(ulong newThreshold, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 85, 207, 136 };
            var newThresholdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newThresholdAbi.From(newThreshold);

            var result = await base.CallApp(new List<object> { abiHandle, newThresholdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateEmergencyThreshold_Transactions(ulong newThreshold, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 85, 207, 136 };
            var newThresholdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newThresholdAbi.From(newThreshold);

            return await base.MakeTransactionList(new List<object> { abiHandle, newThresholdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Request emergency recovery
        ///</summary>
        public async Task RequestRecovery(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 20, 41, 151, 171 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RequestRecovery_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 20, 41, 151, 171 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Cancel recovery request
        ///</summary>
        public async Task CancelRecovery(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 87, 10, 201, 34 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CancelRecovery_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 87, 10, 201, 34 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Execute recovery (only after delay period)
        ///</summary>
        public async Task ExecuteRecovery(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 173, 202, 242, 16 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ExecuteRecovery_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 173, 202, 242, 16 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get recovery status
        ///</summary>
        public async Task<ulong> GetRecoveryStatus(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 58, 145, 242, 247 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetRecoveryStatus_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 58, 145, 242, 247 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get recovery delay
        ///</summary>
        public async Task<ulong> GetRecoveryDelay(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 67, 64, 218, 236 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetRecoveryDelay_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 67, 64, 218, 236 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get emergency threshold
        ///</summary>
        public async Task<ulong> GetEmergencyThreshold(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 204, 162, 246 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetEmergencyThreshold_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 204, 162, 246 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get recovery address
        ///</summary>
        public async Task<byte[]> GetRecoveryAddress(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 88, 33, 204, 40 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> GetRecoveryAddress_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 88, 33, 204, 40 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRW1lcmdlbmN5UmVjb3ZlcnlDb250cmFjdCIsImRlc2MiOiJFbWVyZ2VuY3kgUmVjb3ZlcnkgQ29udHJhY3RcbkhhbmRsZXMgdGltZS1kZWxheWVkIHJlY292ZXJ5IG1lY2hhbmlzbXMgZm9yIGVtZXJnZW5jeSBzaXR1YXRpb25zIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImluaXRpYWxpemUiLCJkZXNjIjoiSW5pdGlhbGl6ZSB0aGUgZW1lcmdlbmN5IHJlY292ZXJ5IGNvbnRyYWN0XG5QUk9EVUNUSU9OIFJFQURZOiBDb25maWd1cmFibGUgcmVjb3Zlcnkgb3duZXIgd2l0aCBwcm9wZXIgdmFsaWRhdGlvbiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZWxheVNlY29uZHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRocmVzaG9sZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjb3ZlcnlBZGRyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNvdmVyeU93bmVyQWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjaGFuZ2VSZWNvdmVyeU93bmVyIiwiZGVzYyI6IkNoYW5nZSByZWNvdmVyeSBvd25lciAoZ292ZXJuYW5jZSlcblBST0RVQ1RJT04gUkVBRFk6IEFsbG93cyBhdXRob3JpdHkgdHJhbnNmZXIgZm9yIGdvdmVybmFuY2UiLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3T3duZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlUmVjb3ZlcnlBZGRyZXNzIiwiZGVzYyI6IlVwZGF0ZSByZWNvdmVyeSBhZGRyZXNzIChvd25lciBvbmx5KVxuUFJPRFVDVElPTiBSRUFEWTogQWxsb3dzIHJlY292ZXJ5IGFkZHJlc3MgdXBkYXRlcyIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdSZWNvdmVyeUFkZHIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlRW1lcmdlbmN5VGhyZXNob2xkIiwiZGVzYyI6IlVwZGF0ZSBlbWVyZ2VuY3kgdGhyZXNob2xkIChvd25lciBvbmx5KVxuUFJPRFVDVElPTiBSRUFEWTogQWxsb3dzIHRocmVzaG9sZCB1cGRhdGVzIHdpdGggdmFsaWRhdGlvbiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdUaHJlc2hvbGQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVxdWVzdFJlY292ZXJ5IiwiZGVzYyI6IlJlcXVlc3QgZW1lcmdlbmN5IHJlY292ZXJ5IiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhbmNlbFJlY292ZXJ5IiwiZGVzYyI6IkNhbmNlbCByZWNvdmVyeSByZXF1ZXN0IiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImV4ZWN1dGVSZWNvdmVyeSIsImRlc2MiOiJFeGVjdXRlIHJlY292ZXJ5IChvbmx5IGFmdGVyIGRlbGF5IHBlcmlvZCkiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0UmVjb3ZlcnlTdGF0dXMiLCJkZXNjIjoiR2V0IHJlY292ZXJ5IHN0YXR1cyIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0UmVjb3ZlcnlEZWxheSIsImRlc2MiOiJHZXQgcmVjb3ZlcnkgZGVsYXkiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEVtZXJnZW5jeVRocmVzaG9sZCIsImRlc2MiOiJHZXQgZW1lcmdlbmN5IHRocmVzaG9sZCIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0UmVjb3ZlcnlBZGRyZXNzIiwiZGVzYyI6IkdldCByZWNvdmVyeSBhZGRyZXNzIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJoZWxsbyIsImRlc2MiOiJIZWxsbyBtZXRob2QgZm9yIHRlc3RpbmciLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjQsImJ5dGVzIjoyfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls0NTcsNTQ2XSwiZXJyb3JNZXNzYWdlIjoiRW1lcmdlbmN5IHRocmVzaG9sZCBtdXN0IGJlIGdyZWF0ZXIgdGhhbiAwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDk4XSwiZXJyb3JNZXNzYWdlIjoiTmV3IG93bmVyIGFkZHJlc3MgY2Fubm90IGJlIGVtcHR5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTA2XSwiZXJyb3JNZXNzYWdlIjoiTmV3IG93bmVyIG11c3QgYmUgZGlmZmVyZW50IGZyb20gY3VycmVudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUyNl0sImVycm9yTWVzc2FnZSI6Ik5ldyByZWNvdmVyeSBhZGRyZXNzIGNhbm5vdCBiZSBlbXB0eSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYxMF0sImVycm9yTWVzc2FnZSI6Ik5vIHJlY292ZXJ5IHJlcXVlc3QgcGVuZGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU4OF0sImVycm9yTWVzc2FnZSI6Ik5vIHJlY292ZXJ5IHJlcXVlc3QgdG8gY2FuY2VsIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjExLDIzOCwyNjIsMjc5LDI5NiwzMTMsMzI1LDMzNywzNDksMzY1LDM4Myw0MDFdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0OTRdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGN1cnJlbnQgcmVjb3Zlcnkgb3duZXIgY2FuIGNoYW5nZSBvd25lciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU4MV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgcmVjb3Zlcnkgb3duZXIgY2FuIGNhbmNlbCByZWNvdmVyeSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYwM10sImVycm9yTWVzc2FnZSI6Ik9ubHkgcmVjb3Zlcnkgb3duZXIgY2FuIGV4ZWN1dGUgcmVjb3ZlcnkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NjBdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IHJlY292ZXJ5IG93bmVyIGNhbiByZXF1ZXN0IHJlY292ZXJ5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTIyXSwiZXJyb3JNZXNzYWdlIjoiT25seSByZWNvdmVyeSBvd25lciBjYW4gdXBkYXRlIHJlY292ZXJ5IGFkZHJlc3MiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NDNdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IHJlY292ZXJ5IG93bmVyIGNhbiB1cGRhdGUgdGhyZXNob2xkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDUxXSwiZXJyb3JNZXNzYWdlIjoiUmVjb3ZlcnkgYWRkcmVzcyBjYW5ub3QgYmUgZW1wdHkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NjZdLCJlcnJvck1lc3NhZ2UiOiJSZWNvdmVyeSBhbHJlYWR5IHJlcXVlc3RlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ1NF0sImVycm9yTWVzc2FnZSI6IlJlY292ZXJ5IGRlbGF5IG11c3QgYmUgZ3JlYXRlciB0aGFuIDAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NDddLCJlcnJvck1lc3NhZ2UiOiJSZWNvdmVyeSBvd25lciBhZGRyZXNzIGNhbm5vdCBiZSBlbXB0eSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQzOF0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxNCwyNDEsMjY1LDI4MiwyOTksMzE2LDMyOCwzNDAsMzUyLDM2OCwzODYsNDA0XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ5Miw1MDIsNTIwLDU0MSw1NTgsNTY0LDU3OSw1ODUsNjAxLDYwNyw2MjEsNjI3LDYzMyw2MzldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhDaUFnSUNCaWVYUmxZMkpzYjJOcklDSnlaV052ZG1WeWVVOTNibVZ5SWlBaWNtVmpiM1psY25sU1pYRjFaWE4wWldRaUlEQjRNVFV4Wmpkak56VWdJbkpsY1hWbGMzUlVhVzFsYzNSaGJYQWlJQ0psYldWeVoyVnVZM2xVYUhKbGMyaHZiR1FpSUNKeVpXTnZkbVZ5ZVVGa1pISmxjM01pSUNKeVpXTnZkbVZ5ZVVSbGJHRjVJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnRaWEpuWlc1amVWOXlaV052ZG1WeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY0tJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJGYldWeVoyVnVZM2xTWldOdmRtVnllVU52Ym5SeVlXTjBJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlltRnlaVjl5YjNWMGFXNW5RREUzQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0TVdWbVlqazVZV01nTUhnd05UUTNZamxsT0NBd2VHTXdNMk5rWWpabUlEQjROemcxTldObU9EZ2dNSGd4TkRJNU9UZGhZaUF3ZURVM01HRmpPVEl5SURCNFlXUmpZV1l5TVRBZ01IZ3pZVGt4WmpKbU55QXdlRFF6TkRCa1lXVmpJREI0TWpGalkyRXlaallnTUhnMU9ESXhZMk15T0NBd2VHVXdPRE00WW1KaElDOHZJRzFsZEdodlpDQWlhVzVwZEdsaGJHbDZaU2gxYVc1ME5qUXNkV2x1ZERZMExHSjVkR1ZiWFN4aWVYUmxXMTBwZG05cFpDSXNJRzFsZEdodlpDQWlZMmhoYm1kbFVtVmpiM1psY25sUGQyNWxjaWhpZVhSbFcxMHBkbTlwWkNJc0lHMWxkR2h2WkNBaWRYQmtZWFJsVW1WamIzWmxjbmxCWkdSeVpYTnpLR0o1ZEdWYlhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKMWNHUmhkR1ZGYldWeVoyVnVZM2xVYUhKbGMyaHZiR1FvZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0luSmxjWFZsYzNSU1pXTnZkbVZ5ZVNncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWTJGdVkyVnNVbVZqYjNabGNua29LWFp2YVdRaUxDQnRaWFJvYjJRZ0ltVjRaV04xZEdWU1pXTnZkbVZ5ZVNncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWjJWMFVtVmpiM1psY25sVGRHRjBkWE1vS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWjJWMFVtVmpiM1psY25sRVpXeGhlU2dwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0puWlhSRmJXVnlaMlZ1WTNsVWFISmxjMmh2YkdRb0tYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVoyVjBVbVZqYjNabGNubEJaR1J5WlhOektDbGllWFJsVzEwaUxDQnRaWFJvYjJRZ0ltaGxiR3h2S0dKNWRHVmJYU2xpZVhSbFcxMGlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgybHVhWFJwWVd4cGVtVmZjbTkxZEdWQU15QnRZV2x1WDJOb1lXNW5aVkpsWTI5MlpYSjVUM2R1WlhKZmNtOTFkR1ZBTkNCdFlXbHVYM1Z3WkdGMFpWSmxZMjkyWlhKNVFXUmtjbVZ6YzE5eWIzVjBaVUExSUcxaGFXNWZkWEJrWVhSbFJXMWxjbWRsYm1ONVZHaHlaWE5vYjJ4a1gzSnZkWFJsUURZZ2JXRnBibDl5WlhGMVpYTjBVbVZqYjNabGNubGZjbTkxZEdWQU55QnRZV2x1WDJOaGJtTmxiRkpsWTI5MlpYSjVYM0p2ZFhSbFFEZ2diV0ZwYmw5bGVHVmpkWFJsVW1WamIzWmxjbmxmY205MWRHVkFPU0J0WVdsdVgyZGxkRkpsWTI5MlpYSjVVM1JoZEhWelgzSnZkWFJsUURFd0lHMWhhVzVmWjJWMFVtVmpiM1psY25sRVpXeGhlVjl5YjNWMFpVQXhNU0J0WVdsdVgyZGxkRVZ0WlhKblpXNWplVlJvY21WemFHOXNaRjl5YjNWMFpVQXhNaUJ0WVdsdVgyZGxkRkpsWTI5MlpYSjVRV1JrY21WemMxOXliM1YwWlVBeE15QnRZV2x1WDJobGJHeHZYM0p2ZFhSbFFERTBDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpFNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlcxbGNtZGxibU41WDNKbFkyOTJaWEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TndvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFVnRaWEpuWlc1amVWSmxZMjkyWlhKNVEyOXVkSEpoWTNRZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJobGJHeHZYM0p2ZFhSbFFERTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnRaWEpuWlc1amVWOXlaV052ZG1WeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFOd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWdFpYSm5aVzVqZVY5eVpXTnZkbVZ5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkZiV1Z5WjJWdVkzbFNaV052ZG1WeWVVTnZiblJ5WVdOMElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYldWeVoyVnVZM2xmY21WamIzWmxjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlRjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJTWldOdmRtVnllVUZrWkhKbGMzTmZjbTkxZEdWQU1UTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpXMWxjbWRsYm1ONVgzSmxZMjkyWlhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUTVDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJR2RsZEZKbFkyOTJaWEo1UVdSa2NtVnpjd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBSVzFsY21kbGJtTjVWR2h5WlhOb2IyeGtYM0p2ZFhSbFFERXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnRaWEpuWlc1amVWOXlaV052ZG1WeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTBNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUJuWlhSRmJXVnlaMlZ1WTNsVWFISmxjMmh2YkdRS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFVtVmpiM1psY25sRVpXeGhlVjl5YjNWMFpVQXhNVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxiV1Z5WjJWdVkzbGZjbVZqYjNabGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNek1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFVtVmpiM1psY25sRVpXeGhlUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJTWldOdmRtVnllVk4wWVhSMWMxOXliM1YwWlVBeE1Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGJXVnlaMlZ1WTNsZmNtVmpiM1psY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1qVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJR05oYkd4emRXSWdaMlYwVW1WamIzWmxjbmxUZEdGMGRYTUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlpYaGxZM1YwWlZKbFkyOTJaWEo1WDNKdmRYUmxRRGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaVzFsY21kbGJtTjVYM0psWTI5MlpYSjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEV4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUdWNFpXTjFkR1ZTWldOdmRtVnllUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWpZVzVqWld4U1pXTnZkbVZ5ZVY5eWIzVjBaVUE0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ0WlhKblpXNWplVjl5WldOdmRtVnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPams1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUdOaGJtTmxiRkpsWTI5MlpYSjVDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzSmxjWFZsYzNSU1pXTnZkbVZ5ZVY5eWIzVjBaVUEzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ0WlhKblpXNWplVjl5WldOdmRtVnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamczQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUhKbGNYVmxjM1JTWldOdmRtVnllUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTFjR1JoZEdWRmJXVnlaMlZ1WTNsVWFISmxjMmh2YkdSZmNtOTFkR1ZBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYldWeVoyVnVZM2xmY21WamIzWmxjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnRaWEpuWlc1amVWOXlaV052ZG1WeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY0tJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJGYldWeVoyVnVZM2xTWldOdmRtVnllVU52Ym5SeVlXTjBJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnRaWEpuWlc1amVWOXlaV052ZG1WeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUIxY0dSaGRHVkZiV1Z5WjJWdVkzbFVhSEpsYzJodmJHUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRYQmtZWFJsVW1WamIzWmxjbmxCWkdSeVpYTnpYM0p2ZFhSbFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpXMWxjbWRsYm1ONVgzSmxZMjkyWlhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qQUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYldWeVoyVnVZM2xmY21WamIzWmxjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1JXMWxjbWRsYm1ONVVtVmpiM1psY25sRGIyNTBjbUZqZENCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaVzFsY21kbGJtTjVYM0psWTI5MlpYSjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOakFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUhWd1pHRjBaVkpsWTI5MlpYSjVRV1JrY21WemN3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5amFHRnVaMlZTWldOdmRtVnllVTkzYm1WeVgzSnZkWFJsUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlcxbGNtZGxibU41WDNKbFkyOTJaWEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxiV1Z5WjJWdVkzbGZjbVZqYjNabGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUlcxbGNtZGxibU41VW1WamIzWmxjbmxEYjI1MGNtRmpkQ0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpXMWxjbWRsYm1ONVgzSmxZMjkyWlhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JqWVd4c2MzVmlJR05vWVc1blpWSmxZMjkyWlhKNVQzZHVaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZhVzVwZEdsaGJHbDZaVjl5YjNWMFpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnRaWEpuWlc1amVWOXlaV052ZG1WeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXdDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlcxbGNtZGxibU41WDNKbFkyOTJaWEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TndvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFVnRaWEpuWlc1amVWSmxZMjkyWlhKNVEyOXVkSEpoWTNRZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxiV1Z5WjJWdVkzbGZjbVZqYjNabGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnYVc1cGRHbGhiR2w2WlFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlpWVhKbFgzSnZkWFJwYm1kQU1UYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpXMWxjbWRsYm1ONVgzSmxZMjkyWlhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk53b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRVZ0WlhKblpXNWplVkpsWTI5MlpYSjVRMjl1ZEhKaFkzUWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJeENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCamNtVmhkR2x1WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxiV1Z5WjJWdVkzbGZjbVZqYjNabGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZSVzFsY21kbGJtTjVVbVZqYjNabGNubERiMjUwY21GamRDNXBibWwwYVdGc2FYcGxLR1JsYkdGNVUyVmpiMjVrY3pvZ2RXbHVkRFkwTENCMGFISmxjMmh2YkdRNklIVnBiblEyTkN3Z2NtVmpiM1psY25sQlpHUnlPaUJpZVhSbGN5d2djbVZqYjNabGNubFBkMjVsY2tGa1pISmxjM002SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3BwYm1sMGFXRnNhWHBsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ0WlhKblpXNWplVjl5WldOdmRtVnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl3TFRJMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnYVc1cGRHbGhiR2w2WlNnS0lDQWdJQzh2SUNBZ1pHVnNZWGxUWldOdmJtUnpPaUIxYVc1ME5qUXNDaUFnSUNBdkx5QWdJSFJvY21WemFHOXNaRG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0J5WldOdmRtVnllVUZrWkhJNklHSjVkR1Z6TEFvZ0lDQWdMeThnSUNCeVpXTnZkbVZ5ZVU5M2JtVnlRV1JrY21WemN6b2dZbmwwWlhNS0lDQWdJQzh2SUNrNklIWnZhV1FnZXdvZ0lDQWdjSEp2ZEc4Z05DQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpXMWxjbWRsYm1ONVgzSmxZMjkyWlhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qZ0tJQ0FnSUM4dklHRnpjMlZ5ZENoeVpXTnZkbVZ5ZVU5M2JtVnlRV1JrY21WemN5NXNaVzVuZEdnZ1BpQXdMQ0FuVW1WamIzWmxjbmtnYjNkdVpYSWdZV1JrY21WemN5QmpZVzV1YjNRZ1ltVWdaVzF3ZEhrbktUc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYkdWdUNpQWdJQ0JoYzNObGNuUWdMeThnVW1WamIzWmxjbmtnYjNkdVpYSWdZV1JrY21WemN5QmpZVzV1YjNRZ1ltVWdaVzF3ZEhrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYldWeVoyVnVZM2xmY21WamIzWmxjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T1FvZ0lDQWdMeThnWVhOelpYSjBLSEpsWTI5MlpYSjVRV1JrY2k1c1pXNW5kR2dnUGlBd0xDQW5VbVZqYjNabGNua2dZV1JrY21WemN5QmpZVzV1YjNRZ1ltVWdaVzF3ZEhrbktUc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYkdWdUNpQWdJQ0JoYzNObGNuUWdMeThnVW1WamIzWmxjbmtnWVdSa2NtVnpjeUJqWVc1dWIzUWdZbVVnWlcxd2RIa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGJXVnlaMlZ1WTNsZmNtVmpiM1psY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1Bb2dJQ0FnTHk4Z1lYTnpaWEowS0dSbGJHRjVVMlZqYjI1a2N5QStJREFzSUNkU1pXTnZkbVZ5ZVNCa1pXeGhlU0J0ZFhOMElHSmxJR2R5WldGMFpYSWdkR2hoYmlBd0p5azdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUdGemMyVnlkQ0F2THlCU1pXTnZkbVZ5ZVNCa1pXeGhlU0J0ZFhOMElHSmxJR2R5WldGMFpYSWdkR2hoYmlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlcxbGNtZGxibU41WDNKbFkyOTJaWEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpFS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUhKbGMyaHZiR1FnUGlBd0xDQW5SVzFsY21kbGJtTjVJSFJvY21WemFHOXNaQ0J0ZFhOMElHSmxJR2R5WldGMFpYSWdkR2hoYmlBd0p5azdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdGemMyVnlkQ0F2THlCRmJXVnlaMlZ1WTNrZ2RHaHlaWE5vYjJ4a0lHMTFjM1FnWW1VZ1ozSmxZWFJsY2lCMGFHRnVJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxiV1Z5WjJWdVkzbGZjbVZqYjNabGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVDaUFnSUNBdkx5QnlaV052ZG1WeWVVOTNibVZ5SUQwZ1IyeHZZbUZzVTNSaGRHVThZbmwwWlhNK0tDazdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnlaV052ZG1WeWVVOTNibVZ5SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ0WlhKblpXNWplVjl5WldOdmRtVnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak16Q2lBZ0lDQXZMeUIwYUdsekxuSmxZMjkyWlhKNVQzZHVaWEl1ZG1Gc2RXVWdQU0J5WldOdmRtVnllVTkzYm1WeVFXUmtjbVZ6Y3pzZ0x5OGdRMjl1Wm1sbmRYSmhZbXhsSUc5M2JtVnlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpXMWxjbWRsYm1ONVgzSmxZMjkyWlhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQUtJQ0FnSUM4dklISmxZMjkyWlhKNVJHVnNZWGtnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDazdJQzh2SUZObFkyOXVaSE1LSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbkpsWTI5MlpYSjVSR1ZzWVhraUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlcxbGNtZGxibU41WDNKbFkyOTJaWEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpRS0lDQWdJQzh2SUhSb2FYTXVjbVZqYjNabGNubEVaV3hoZVM1MllXeDFaU0E5SUdSbGJHRjVVMlZqYjI1a2N6c0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGJXVnlaMlZ1WTNsZmNtVmpiM1psY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1Rb2dJQ0FnTHk4Z2NtVmpiM1psY25sU1pYRjFaWE4wWldRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2s3SUM4dklEQTlibThnY21WeGRXVnpkQ3dnTVQxeVpYRjFaWE4wWldRS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5KbFkyOTJaWEo1VW1WeGRXVnpkR1ZrSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ0WlhKblpXNWplVjl5WldOdmRtVnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0xQ2lBZ0lDQXZMeUIwYUdsekxuSmxZMjkyWlhKNVVtVnhkV1Z6ZEdWa0xuWmhiSFZsSUQwZ01Ec2dMeThnVG04Z2NtVnhkV1Z6ZENCcGJtbDBhV0ZzYkhrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ0WlhKblpXNWplVjl5WldOdmRtVnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5Q2lBZ0lDQXZMeUJ5WlhGMVpYTjBWR2x0WlhOMFlXMXdJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncE93b2dJQ0FnWW5sMFpXTmZNeUF2THlBaWNtVnhkV1Z6ZEZScGJXVnpkR0Z0Y0NJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYldWeVoyVnVZM2xmY21WamIzWmxjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TmdvZ0lDQWdMeThnZEdocGN5NXlaWEYxWlhOMFZHbHRaWE4wWVcxd0xuWmhiSFZsSUQwZ01Ec0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWdFpYSm5aVzVqZVY5eVpXTnZkbVZ5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFekNpQWdJQ0F2THlCbGJXVnlaMlZ1WTNsVWFISmxjMmh2YkdRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2s3SUM4dklFMXBibWx0ZFcwZ1lXMXZkVzUwSUhSdklIUnlhV2RuWlhJZ1pXMWxjbWRsYm1ONUNpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKbGJXVnlaMlZ1WTNsVWFISmxjMmh2YkdRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlcxbGNtZGxibU41WDNKbFkyOTJaWEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpjS0lDQWdJQzh2SUhSb2FYTXVaVzFsY21kbGJtTjVWR2h5WlhOb2IyeGtMblpoYkhWbElEMGdkR2h5WlhOb2IyeGtPd29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnRaWEpuWlc1amVWOXlaV052ZG1WeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTBDaUFnSUNBdkx5QnlaV052ZG1WeWVVRmtaSEpsYzNNZ1BTQkhiRzlpWVd4VGRHRjBaVHhpZVhSbGN6NG9LVHNLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbkpsWTI5MlpYSjVRV1JrY21WemN5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGJXVnlaMlZ1WTNsZmNtVmpiM1psY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek9Bb2dJQ0FnTHk4Z2RHaHBjeTV5WldOdmRtVnllVUZrWkhKbGMzTXVkbUZzZFdVZ1BTQnlaV052ZG1WeWVVRmtaSEk3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaVzFsY21kbGJtTjVYM0psWTI5MlpYSjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa1Z0WlhKblpXNWplVkpsWTI5MlpYSjVRMjl1ZEhKaFkzUXVZMmhoYm1kbFVtVmpiM1psY25sUGQyNWxjaWh1WlhkUGQyNWxjam9nWW5sMFpYTXBJQzArSUhadmFXUTZDbU5vWVc1blpWSmxZMjkyWlhKNVQzZHVaWEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaVzFsY21kbGJtTjVYM0psWTI5MlpYSjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFV0TkRnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUJqYUdGdVoyVlNaV052ZG1WeWVVOTNibVZ5S0FvZ0lDQWdMeThnSUNCdVpYZFBkMjVsY2pvZ1lubDBaWE1LSUNBZ0lDOHZJQ2s2SUhadmFXUWdld29nSUNBZ2NISnZkRzhnTVNBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlcxbGNtZGxibU41WDNKbFkyOTJaWEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRrS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5TG1KNWRHVnpJRDA5UFNCMGFHbHpMbkpsWTI5MlpYSjVUM2R1WlhJdWRtRnNkV1VzSUNkUGJteDVJR04xY25KbGJuUWdjbVZqYjNabGNua2diM2R1WlhJZ1kyRnVJR05vWVc1blpTQnZkMjVsY2ljcE93b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ0WlhKblpXNWplVjl5WldOdmRtVnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamtLSUNBZ0lDOHZJSEpsWTI5MlpYSjVUM2R1WlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhpZVhSbGN6NG9LVHNLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnlaV052ZG1WeWVVOTNibVZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxiV1Z5WjJWdVkzbGZjbVZqYjNabGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBPUW9nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSXVZbmwwWlhNZ1BUMDlJSFJvYVhNdWNtVmpiM1psY25sUGQyNWxjaTUyWVd4MVpTd2dKMDl1YkhrZ1kzVnljbVZ1ZENCeVpXTnZkbVZ5ZVNCdmQyNWxjaUJqWVc0Z1kyaGhibWRsSUc5M2JtVnlKeWs3Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnWTNWeWNtVnVkQ0J5WldOdmRtVnllU0J2ZDI1bGNpQmpZVzRnWTJoaGJtZGxJRzkzYm1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlcxbGNtZGxibU41WDNKbFkyOTJaWEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRBS0lDQWdJQzh2SUdGemMyVnlkQ2h1WlhkUGQyNWxjaTVzWlc1bmRHZ2dQaUF3TENBblRtVjNJRzkzYm1WeUlHRmtaSEpsYzNNZ1kyRnVibTkwSUdKbElHVnRjSFI1SnlrN0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR3hsYmdvZ0lDQWdZWE56WlhKMElDOHZJRTVsZHlCdmQyNWxjaUJoWkdSeVpYTnpJR05oYm01dmRDQmlaU0JsYlhCMGVRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWdFpYSm5aVzVqZVY5eVpXTnZkbVZ5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prS0lDQWdJQzh2SUhKbFkyOTJaWEo1VDNkdVpYSWdQU0JIYkc5aVlXeFRkR0YwWlR4aWVYUmxjejRvS1RzS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p5WldOdmRtVnllVTkzYm1WeUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYldWeVoyVnVZM2xmY21WamIzWmxjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTVFvZ0lDQWdMeThnWVhOelpYSjBLRzVsZDA5M2JtVnlJQ0U5UFNCMGFHbHpMbkpsWTI5MlpYSjVUM2R1WlhJdWRtRnNkV1VzSUNkT1pYY2diM2R1WlhJZ2JYVnpkQ0JpWlNCa2FXWm1aWEpsYm5RZ1puSnZiU0JqZFhKeVpXNTBKeWs3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lDRTlDaUFnSUNCaGMzTmxjblFnTHk4Z1RtVjNJRzkzYm1WeUlHMTFjM1FnWW1VZ1pHbG1abVZ5Wlc1MElHWnliMjBnWTNWeWNtVnVkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnRaWEpuWlc1amVWOXlaV052ZG1WeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qa0tJQ0FnSUM4dklISmxZMjkyWlhKNVQzZHVaWElnUFNCSGJHOWlZV3hUZEdGMFpUeGllWFJsY3o0b0tUc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luSmxZMjkyWlhKNVQzZHVaWElpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaVzFsY21kbGJtTjVYM0psWTI5MlpYSjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVE1LSUNBZ0lDOHZJSFJvYVhNdWNtVmpiM1psY25sUGQyNWxjaTUyWVd4MVpTQTlJRzVsZDA5M2JtVnlPd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnRaWEpuWlc1amVWOXlaV052ZG1WeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEZiV1Z5WjJWdVkzbFNaV052ZG1WeWVVTnZiblJ5WVdOMExuVndaR0YwWlZKbFkyOTJaWEo1UVdSa2NtVnpjeWh1WlhkU1pXTnZkbVZ5ZVVGa1pISTZJR0o1ZEdWektTQXRQaUIyYjJsa09ncDFjR1JoZEdWU1pXTnZkbVZ5ZVVGa1pISmxjM002Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaVzFsY21kbGJtTjVYM0psWTI5MlpYSjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOakF0TmpNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUIxY0dSaGRHVlNaV052ZG1WeWVVRmtaSEpsYzNNb0NpQWdJQ0F2THlBZ0lHNWxkMUpsWTI5MlpYSjVRV1JrY2pvZ1lubDBaWE1LSUNBZ0lDOHZJQ2s2SUhadmFXUWdld29nSUNBZ2NISnZkRzhnTVNBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlcxbGNtZGxibU41WDNKbFkyOTJaWEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpRS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5TG1KNWRHVnpJRDA5UFNCMGFHbHpMbkpsWTI5MlpYSjVUM2R1WlhJdWRtRnNkV1VzSUNkUGJteDVJSEpsWTI5MlpYSjVJRzkzYm1WeUlHTmhiaUIxY0dSaGRHVWdjbVZqYjNabGNua2dZV1JrY21WemN5Y3BPd29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWdFpYSm5aVzVqZVY5eVpXTnZkbVZ5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prS0lDQWdJQzh2SUhKbFkyOTJaWEo1VDNkdVpYSWdQU0JIYkc5aVlXeFRkR0YwWlR4aWVYUmxjejRvS1RzS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p5WldOdmRtVnllVTkzYm1WeUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYldWeVoyVnVZM2xmY21WamIzWmxjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTkFvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWEl1WW5sMFpYTWdQVDA5SUhSb2FYTXVjbVZqYjNabGNubFBkMjVsY2k1MllXeDFaU3dnSjA5dWJIa2djbVZqYjNabGNua2diM2R1WlhJZ1kyRnVJSFZ3WkdGMFpTQnlaV052ZG1WeWVTQmhaR1J5WlhOekp5azdDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2djbVZqYjNabGNua2diM2R1WlhJZ1kyRnVJSFZ3WkdGMFpTQnlaV052ZG1WeWVTQmhaR1J5WlhOekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlcxbGNtZGxibU41WDNKbFkyOTJaWEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpVS0lDQWdJQzh2SUdGemMyVnlkQ2h1WlhkU1pXTnZkbVZ5ZVVGa1pISXViR1Z1WjNSb0lENGdNQ3dnSjA1bGR5QnlaV052ZG1WeWVTQmhaR1J5WlhOeklHTmhibTV2ZENCaVpTQmxiWEIwZVNjcE93b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JzWlc0S0lDQWdJR0Z6YzJWeWRDQXZMeUJPWlhjZ2NtVmpiM1psY25rZ1lXUmtjbVZ6Y3lCallXNXViM1FnWW1VZ1pXMXdkSGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxiV1Z5WjJWdVkzbGZjbVZqYjNabGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOQW9nSUNBZ0x5OGdjbVZqYjNabGNubEJaR1J5WlhOeklEMGdSMnh2WW1Gc1UzUmhkR1U4WW5sMFpYTStLQ2s3Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0p5WldOdmRtVnllVUZrWkhKbGMzTWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpXMWxjbWRsYm1ONVgzSmxZMjkyWlhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qY0tJQ0FnSUM4dklIUm9hWE11Y21WamIzWmxjbmxCWkdSeVpYTnpMblpoYkhWbElEMGdibVYzVW1WamIzWmxjbmxCWkdSeU93b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWdFpYSm5aVzVqZVY5eVpXTnZkbVZ5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwRmJXVnlaMlZ1WTNsU1pXTnZkbVZ5ZVVOdmJuUnlZV04wTG5Wd1pHRjBaVVZ0WlhKblpXNWplVlJvY21WemFHOXNaQ2h1WlhkVWFISmxjMmh2YkdRNklIVnBiblEyTkNrZ0xUNGdkbTlwWkRvS2RYQmtZWFJsUlcxbGNtZGxibU41VkdoeVpYTm9iMnhrT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ0WlhKblpXNWplVjl5WldOdmRtVnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamMwTFRjM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnZFhCa1lYUmxSVzFsY21kbGJtTjVWR2h5WlhOb2IyeGtLQW9nSUNBZ0x5OGdJQ0J1WlhkVWFISmxjMmh2YkdRNklIVnBiblEyTkFvZ0lDQWdMeThnS1RvZ2RtOXBaQ0I3Q2lBZ0lDQndjbTkwYnlBeElEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGJXVnlaMlZ1WTNsZmNtVmpiM1psY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM09Bb2dJQ0FnTHk4Z1lYTnpaWEowS0ZSNGJpNXpaVzVrWlhJdVlubDBaWE1nUFQwOUlIUm9hWE11Y21WamIzWmxjbmxQZDI1bGNpNTJZV3gxWlN3Z0owOXViSGtnY21WamIzWmxjbmtnYjNkdVpYSWdZMkZ1SUhWd1pHRjBaU0IwYUhKbGMyaHZiR1FuS1RzS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxiV1Z5WjJWdVkzbGZjbVZqYjNabGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVDaUFnSUNBdkx5QnlaV052ZG1WeWVVOTNibVZ5SUQwZ1IyeHZZbUZzVTNSaGRHVThZbmwwWlhNK0tDazdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWNtVmpiM1psY25sUGQyNWxjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpXMWxjbWRsYm1ONVgzSmxZMjkyWlhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56Z0tJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUxtSjVkR1Z6SUQwOVBTQjBhR2x6TG5KbFkyOTJaWEo1VDNkdVpYSXVkbUZzZFdVc0lDZFBibXg1SUhKbFkyOTJaWEo1SUc5M2JtVnlJR05oYmlCMWNHUmhkR1VnZEdoeVpYTm9iMnhrSnlrN0NpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ2NtVmpiM1psY25rZ2IzZHVaWElnWTJGdUlIVndaR0YwWlNCMGFISmxjMmh2YkdRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYldWeVoyVnVZM2xmY21WamIzWmxjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zT1FvZ0lDQWdMeThnWVhOelpYSjBLRzVsZDFSb2NtVnphRzlzWkNBK0lEQXNJQ2RGYldWeVoyVnVZM2tnZEdoeVpYTm9iMnhrSUcxMWMzUWdZbVVnWjNKbFlYUmxjaUIwYUdGdUlEQW5LVHNLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lYTnpaWEowSUM4dklFVnRaWEpuWlc1amVTQjBhSEpsYzJodmJHUWdiWFZ6ZENCaVpTQm5jbVZoZEdWeUlIUm9ZVzRnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ0WlhKblpXNWplVjl5WldOdmRtVnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6Q2lBZ0lDQXZMeUJsYldWeVoyVnVZM2xVYUhKbGMyaHZiR1FnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDazdJQzh2SUUxcGJtbHRkVzBnWVcxdmRXNTBJSFJ2SUhSeWFXZG5aWElnWlcxbGNtZGxibU41Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0psYldWeVoyVnVZM2xVYUhKbGMyaHZiR1FpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaVzFsY21kbGJtTjVYM0psWTI5MlpYSjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPREVLSUNBZ0lDOHZJSFJvYVhNdVpXMWxjbWRsYm1ONVZHaHlaWE5vYjJ4a0xuWmhiSFZsSUQwZ2JtVjNWR2h5WlhOb2IyeGtPd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnRaWEpuWlc1amVWOXlaV052ZG1WeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEZiV1Z5WjJWdVkzbFNaV052ZG1WeWVVTnZiblJ5WVdOMExuSmxjWFZsYzNSU1pXTnZkbVZ5ZVNncElDMCtJSFp2YVdRNkNuSmxjWFZsYzNSU1pXTnZkbVZ5ZVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYldWeVoyVnVZM2xmY21WamIzWmxjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80T1FvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWEl1WW5sMFpYTWdQVDA5SUhSb2FYTXVjbVZqYjNabGNubFBkMjVsY2k1MllXeDFaU3dnSjA5dWJIa2djbVZqYjNabGNua2diM2R1WlhJZ1kyRnVJSEpsY1hWbGMzUWdjbVZqYjNabGNua25LVHNLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGJXVnlaMlZ1WTNsZmNtVmpiM1psY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNUNpQWdJQ0F2THlCeVpXTnZkbVZ5ZVU5M2JtVnlJRDBnUjJ4dlltRnNVM1JoZEdVOFlubDBaWE0rS0NrN0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpY21WamIzWmxjbmxQZDI1bGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlcxbGNtZGxibU41WDNKbFkyOTJaWEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RrS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5TG1KNWRHVnpJRDA5UFNCMGFHbHpMbkpsWTI5MlpYSjVUM2R1WlhJdWRtRnNkV1VzSUNkUGJteDVJSEpsWTI5MlpYSjVJRzkzYm1WeUlHTmhiaUJ5WlhGMVpYTjBJSEpsWTI5MlpYSjVKeWs3Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnY21WamIzWmxjbmtnYjNkdVpYSWdZMkZ1SUhKbGNYVmxjM1FnY21WamIzWmxjbmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxiV1Z5WjJWdVkzbGZjbVZqYjNabGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNUW9nSUNBZ0x5OGdjbVZqYjNabGNubFNaWEYxWlhOMFpXUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrN0lDOHZJREE5Ym04Z2NtVnhkV1Z6ZEN3Z01UMXlaWEYxWlhOMFpXUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKeVpXTnZkbVZ5ZVZKbGNYVmxjM1JsWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaVzFsY21kbGJtTjVYM0psWTI5MlpYSjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVEFLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG5KbFkyOTJaWEo1VW1WeGRXVnpkR1ZrTG5aaGJIVmxJRDA5UFNBd0xDQW5VbVZqYjNabGNua2dZV3h5WldGa2VTQnlaWEYxWlhOMFpXUW5LVHNLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCU1pXTnZkbVZ5ZVNCaGJISmxZV1I1SUhKbGNYVmxjM1JsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ0WlhKblpXNWplVjl5WldOdmRtVnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4Q2lBZ0lDQXZMeUJ5WldOdmRtVnllVkpsY1hWbGMzUmxaQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tUc2dMeThnTUQxdWJ5QnlaWEYxWlhOMExDQXhQWEpsY1hWbGMzUmxaQW9nSUNBZ1lubDBaV05mTVNBdkx5QWljbVZqYjNabGNubFNaWEYxWlhOMFpXUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpXMWxjbWRsYm1ONVgzSmxZMjkyWlhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9USUtJQ0FnSUM4dklIUm9hWE11Y21WamIzWmxjbmxTWlhGMVpYTjBaV1F1ZG1Gc2RXVWdQU0F4T3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaVzFsY21kbGJtTjVYM0psWTI5MlpYSjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVElLSUNBZ0lDOHZJSEpsY1hWbGMzUlVhVzFsYzNSaGJYQWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrN0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKeVpYRjFaWE4wVkdsdFpYTjBZVzF3SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ0WlhKblpXNWplVjl5WldOdmRtVnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamt6Q2lBZ0lDQXZMeUIwYUdsekxuSmxjWFZsYzNSVWFXMWxjM1JoYlhBdWRtRnNkV1VnUFNBd095QXZMeUJYYVd4c0lHSmxJSE5sZENCMGJ5QmpkWEp5Wlc1MElIUnBiV1Z6ZEdGdGNDQjNhR1Z1SUc1bFpXUmxaQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpXMWxjbWRsYm1ONVgzSmxZMjkyWlhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rVnRaWEpuWlc1amVWSmxZMjkyWlhKNVEyOXVkSEpoWTNRdVkyRnVZMlZzVW1WamIzWmxjbmtvS1NBdFBpQjJiMmxrT2dwallXNWpaV3hTWldOdmRtVnllVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxiV1Z5WjJWdVkzbGZjbVZqYjNabGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNREVLSUNBZ0lDOHZJR0Z6YzJWeWRDaFVlRzR1YzJWdVpHVnlMbUo1ZEdWeklEMDlQU0IwYUdsekxuSmxZMjkyWlhKNVQzZHVaWEl1ZG1Gc2RXVXNJQ2RQYm14NUlISmxZMjkyWlhKNUlHOTNibVZ5SUdOaGJpQmpZVzVqWld3Z2NtVmpiM1psY25rbktUc0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYldWeVoyVnVZM2xmY21WamIzWmxjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81Q2lBZ0lDQXZMeUJ5WldOdmRtVnllVTkzYm1WeUlEMGdSMnh2WW1Gc1UzUmhkR1U4WW5sMFpYTStLQ2s3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWljbVZqYjNabGNubFBkMjVsY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaVzFsY21kbGJtTjVYM0psWTI5MlpYSjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEF4Q2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaTVpZVhSbGN5QTlQVDBnZEdocGN5NXlaV052ZG1WeWVVOTNibVZ5TG5aaGJIVmxMQ0FuVDI1c2VTQnlaV052ZG1WeWVTQnZkMjVsY2lCallXNGdZMkZ1WTJWc0lISmxZMjkyWlhKNUp5azdDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2djbVZqYjNabGNua2diM2R1WlhJZ1kyRnVJR05oYm1ObGJDQnlaV052ZG1WeWVRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWdFpYSm5aVzVqZVY5eVpXTnZkbVZ5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeENpQWdJQ0F2THlCeVpXTnZkbVZ5ZVZKbGNYVmxjM1JsWkNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LVHNnTHk4Z01EMXVieUJ5WlhGMVpYTjBMQ0F4UFhKbGNYVmxjM1JsWkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbkpsWTI5MlpYSjVVbVZ4ZFdWemRHVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGJXVnlaMlZ1WTNsZmNtVmpiM1psY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1ESUtJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbkpsWTI5MlpYSjVVbVZ4ZFdWemRHVmtMblpoYkhWbElEMDlQU0F4TENBblRtOGdjbVZqYjNabGNua2djbVZ4ZFdWemRDQjBieUJqWVc1alpXd25LVHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU1dklISmxZMjkyWlhKNUlISmxjWFZsYzNRZ2RHOGdZMkZ1WTJWc0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlcxbGNtZGxibU41WDNKbFkyOTJaWEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFS0lDQWdJQzh2SUhKbFkyOTJaWEo1VW1WeGRXVnpkR1ZrSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BPeUF2THlBd1BXNXZJSEpsY1hWbGMzUXNJREU5Y21WeGRXVnpkR1ZrQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p5WldOdmRtVnllVkpsY1hWbGMzUmxaQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxiV1Z5WjJWdVkzbGZjbVZqYjNabGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRFFLSUNBZ0lDOHZJSFJvYVhNdWNtVmpiM1psY25sU1pYRjFaWE4wWldRdWRtRnNkV1VnUFNBd093b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlcxbGNtZGxibU41WDNKbFkyOTJaWEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJS0lDQWdJQzh2SUhKbGNYVmxjM1JVYVcxbGMzUmhiWEFnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDazdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSnlaWEYxWlhOMFZHbHRaWE4wWVcxd0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWdFpYSm5aVzVqZVY5eVpXTnZkbVZ5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd05Rb2dJQ0FnTHk4Z2RHaHBjeTV5WlhGMVpYTjBWR2x0WlhOMFlXMXdMblpoYkhWbElEMGdNRHNLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnRaWEpuWlc1amVWOXlaV052ZG1WeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEZiV1Z5WjJWdVkzbFNaV052ZG1WeWVVTnZiblJ5WVdOMExtVjRaV04xZEdWU1pXTnZkbVZ5ZVNncElDMCtJSFp2YVdRNkNtVjRaV04xZEdWU1pXTnZkbVZ5ZVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYldWeVoyVnVZM2xmY21WamIzWmxjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRNS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5TG1KNWRHVnpJRDA5UFNCMGFHbHpMbkpsWTI5MlpYSjVUM2R1WlhJdWRtRnNkV1VzSUNkUGJteDVJSEpsWTI5MlpYSjVJRzkzYm1WeUlHTmhiaUJsZUdWamRYUmxJSEpsWTI5MlpYSjVKeWs3Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpXMWxjbWRsYm1ONVgzSmxZMjkyWlhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9Rb2dJQ0FnTHk4Z2NtVmpiM1psY25sUGQyNWxjaUE5SUVkc2IySmhiRk4wWVhSbFBHSjVkR1Z6UGlncE93b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5KbFkyOTJaWEo1VDNkdVpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWdFpYSm5aVzVqZVY5eVpXTnZkbVZ5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE13b2dJQ0FnTHk4Z1lYTnpaWEowS0ZSNGJpNXpaVzVrWlhJdVlubDBaWE1nUFQwOUlIUm9hWE11Y21WamIzWmxjbmxQZDI1bGNpNTJZV3gxWlN3Z0owOXViSGtnY21WamIzWmxjbmtnYjNkdVpYSWdZMkZ1SUdWNFpXTjFkR1VnY21WamIzWmxjbmtuS1RzS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCeVpXTnZkbVZ5ZVNCdmQyNWxjaUJqWVc0Z1pYaGxZM1YwWlNCeVpXTnZkbVZ5ZVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ0WlhKblpXNWplVjl5WldOdmRtVnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4Q2lBZ0lDQXZMeUJ5WldOdmRtVnllVkpsY1hWbGMzUmxaQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tUc2dMeThnTUQxdWJ5QnlaWEYxWlhOMExDQXhQWEpsY1hWbGMzUmxaQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0luSmxZMjkyWlhKNVVtVnhkV1Z6ZEdWa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYldWeVoyVnVZM2xmY21WamIzWmxjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRRS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxuSmxZMjkyWlhKNVVtVnhkV1Z6ZEdWa0xuWmhiSFZsSUQwOVBTQXhMQ0FuVG04Z2NtVmpiM1psY25rZ2NtVnhkV1Z6ZENCd1pXNWthVzVuSnlrN0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk9ieUJ5WldOdmRtVnllU0J5WlhGMVpYTjBJSEJsYm1ScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGJXVnlaMlZ1WTNsZmNtVmpiM1psY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1Rb2dJQ0FnTHk4Z2NtVmpiM1psY25sU1pYRjFaWE4wWldRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2s3SUM4dklEQTlibThnY21WeGRXVnpkQ3dnTVQxeVpYRjFaWE4wWldRS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5KbFkyOTJaWEo1VW1WeGRXVnpkR1ZrSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ0WlhKblpXNWplVjl5WldOdmRtVnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4T0FvZ0lDQWdMeThnZEdocGN5NXlaV052ZG1WeWVWSmxjWFZsYzNSbFpDNTJZV3gxWlNBOUlEQTdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGJXVnlaMlZ1WTNsZmNtVmpiM1psY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1nb2dJQ0FnTHk4Z2NtVnhkV1Z6ZEZScGJXVnpkR0Z0Y0NBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LVHNLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbkpsY1hWbGMzUlVhVzFsYzNSaGJYQWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpXMWxjbWRsYm1ONVgzSmxZMjkyWlhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URTVDaUFnSUNBdkx5QjBhR2x6TG5KbGNYVmxjM1JVYVcxbGMzUmhiWEF1ZG1Gc2RXVWdQU0F3T3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaVzFsY21kbGJtTjVYM0psWTI5MlpYSjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa1Z0WlhKblpXNWplVkpsWTI5MlpYSjVRMjl1ZEhKaFkzUXVaMlYwVW1WamIzWmxjbmxUZEdGMGRYTW9LU0F0UGlCMWFXNTBOalE2Q21kbGRGSmxZMjkyWlhKNVUzUmhkSFZ6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ0WlhKblpXNWplVjl5WldOdmRtVnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4Q2lBZ0lDQXZMeUJ5WldOdmRtVnllVkpsY1hWbGMzUmxaQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tUc2dMeThnTUQxdWJ5QnlaWEYxWlhOMExDQXhQWEpsY1hWbGMzUmxaQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0luSmxZMjkyWlhKNVVtVnhkV1Z6ZEdWa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYldWeVoyVnVZM2xmY21WamIzWmxjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWpjS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxuSmxZMjkyWlhKNVVtVnhkV1Z6ZEdWa0xuWmhiSFZsT3dvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ0WlhKblpXNWplVjl5WldOdmRtVnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBGYldWeVoyVnVZM2xTWldOdmRtVnllVU52Ym5SeVlXTjBMbWRsZEZKbFkyOTJaWEo1UkdWc1lYa29LU0F0UGlCMWFXNTBOalE2Q21kbGRGSmxZMjkyWlhKNVJHVnNZWGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaVzFsY21kbGJtTjVYM0psWTI5MlpYSjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEFLSUNBZ0lDOHZJSEpsWTI5MlpYSjVSR1ZzWVhrZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2s3SUM4dklGTmxZMjl1WkhNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMklDOHZJQ0p5WldOdmRtVnllVVJsYkdGNUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYldWeVoyVnVZM2xmY21WamIzWmxjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXpVS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxuSmxZMjkyWlhKNVJHVnNZWGt1ZG1Gc2RXVTdDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpXMWxjbWRsYm1ONVgzSmxZMjkyWlhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rVnRaWEpuWlc1amVWSmxZMjkyWlhKNVEyOXVkSEpoWTNRdVoyVjBSVzFsY21kbGJtTjVWR2h5WlhOb2IyeGtLQ2tnTFQ0Z2RXbHVkRFkwT2dwblpYUkZiV1Z5WjJWdVkzbFVhSEpsYzJodmJHUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpXMWxjbWRsYm1ONVgzSmxZMjkyWlhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UTUtJQ0FnSUM4dklHVnRaWEpuWlc1amVWUm9jbVZ6YUc5c1pDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1RzZ0x5OGdUV2x1YVcxMWJTQmhiVzkxYm5RZ2RHOGdkSEpwWjJkbGNpQmxiV1Z5WjJWdVkza0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKbGJXVnlaMlZ1WTNsVWFISmxjMmh2YkdRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ0WlhKblpXNWplVjl5WldOdmRtVnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwTXdvZ0lDQWdMeThnY21WMGRYSnVJSFJvYVhNdVpXMWxjbWRsYm1ONVZHaHlaWE5vYjJ4a0xuWmhiSFZsT3dvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ0WlhKblpXNWplVjl5WldOdmRtVnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBGYldWeVoyVnVZM2xTWldOdmRtVnllVU52Ym5SeVlXTjBMbWRsZEZKbFkyOTJaWEo1UVdSa2NtVnpjeWdwSUMwK0lHSjVkR1Z6T2dwblpYUlNaV052ZG1WeWVVRmtaSEpsYzNNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlcxbGNtZGxibU41WDNKbFkyOTJaWEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRRS0lDQWdJQzh2SUhKbFkyOTJaWEo1UVdSa2NtVnpjeUE5SUVkc2IySmhiRk4wWVhSbFBHSjVkR1Z6UGlncE93b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEVWdMeThnSW5KbFkyOTJaWEo1UVdSa2NtVnpjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpXMWxjbWRsYm1ONVgzSmxZMjkyWlhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVXhDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTV5WldOdmRtVnllVUZrWkhKbGMzTXVkbUZzZFdVN0NpQWdJQ0J5WlhSemRXSUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUNBQUVtQncxeVpXTnZkbVZ5ZVU5M2JtVnlFWEpsWTI5MlpYSjVVbVZ4ZFdWemRHVmtCQlVmZkhVUWNtVnhkV1Z6ZEZScGJXVnpkR0Z0Y0JKbGJXVnlaMlZ1WTNsVWFISmxjMmh2YkdRUGNtVmpiM1psY25sQlpHUnlaWE56RFhKbFkyOTJaWEo1UkdWc1lYa3hHMEVCTzRJTUJCNzdtYXdFQlVlNTZBVEFQTnR2QkhoVno0Z0VGQ21YcXdSWENza2lCSzNLOGhBRU9wSHk5d1JEUU5yc0JDSE1vdllFV0NITUtBVGdnNHU2TmhvQWpnd0F3QUN1QUp3QWpBQ0FBSFFBYUFCWEFFWUFOUUFkQUFJaVF6RVpGRVF4R0VRMkdnRlhBZ0JKRlJaWEJnSk1VQ3BNVUxBalF6RVpGRVF4R0VTSUFZWkpGUlpYQmdKTVVDcE1VTEFqUXpFWkZFUXhHRVNJQVdnV0treFFzQ05ETVJrVVJERVlSSWdCVVJZcVRGQ3dJME14R1JSRU1SaEVpQUU3RmlwTVVMQWpRekVaRkVReEdFU0lBUlFqUXpFWkZFUXhHRVNJQVBJalF6RVpGRVF4R0VTSUFORWpRekVaRkVReEdFUTJHZ0VYaUFDdEkwTXhHUlJFTVJoRU5ob0JWd0lBaUFDR0kwTXhHUlJFTVJoRU5ob0JWd0lBaUFCWUkwTXhHUlJFTVJoRU5ob0JGellhQWhjMkdnTlhBZ0EyR2dSWEFnQ0lBQTBqUXpFWlFQOGJNUmdVUkNORGlnUUFpLzhWUkl2K0ZVU0wvRVNML1VRb2kvOW5Kd2FML0djcEltY3JJbWNuQkl2OVp5Y0ZpLzVuaVlvQkFERUFJaWhsUkJKRWkvOFZSQ0lvWlVTTC94TkVLSXYvWjRtS0FRQXhBQ0lvWlVRU1JJdi9GVVFuQll2L1o0bUtBUUF4QUNJb1pVUVNSSXYvUkNjRWkvOW5pVEVBSWlobFJCSkVJaWxsUkJSRUtTTm5LeUpuaVRFQUlpaGxSQkpFSWlsbFJDTVNSQ2tpWnlzaVo0a3hBQ0lvWlVRU1JDSXBaVVFqRWtRcEltY3JJbWVKSWlsbFJJa2lKd1psUklraUp3UmxSSWtpSndWbFJJaz0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo3LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
