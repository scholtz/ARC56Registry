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

namespace Arc56.Generated.orinx_org.orinx_contracts_algorand.OrinxAnnouncer_ca02e89d
{


    public class OrinxAnnouncerProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public OrinxAnnouncerProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="admin"> </param>
        public async Task CreateApplication(Algorand.Address admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 36, 190, 164 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);

            var result = await base.CallApp(new List<object> { abiHandle, adminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Algorand.Address admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 36, 190, 164 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);

            return await base.MakeTransactionList(new List<object> { abiHandle, adminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="ephemeralPubKey"> </param>
        /// <param name="ciphertext"> </param>
        /// <param name="targetStealthAddress"> </param>
        public async Task AnnounceStealthPayment(byte[] ephemeralPubKey, byte[] ciphertext, Algorand.Address targetStealthAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 114, 237, 48 };
            var ephemeralPubKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); ephemeralPubKeyAbi.From(ephemeralPubKey);
            var ciphertextAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); ciphertextAbi.From(ciphertext);
            var targetStealthAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetStealthAddressAbi.From(targetStealthAddress);

            var result = await base.CallApp(new List<object> { abiHandle, ephemeralPubKeyAbi, ciphertextAbi, targetStealthAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AnnounceStealthPayment_Transactions(byte[] ephemeralPubKey, byte[] ciphertext, Algorand.Address targetStealthAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 114, 237, 48 };
            var ephemeralPubKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); ephemeralPubKeyAbi.From(ephemeralPubKey);
            var ciphertextAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); ciphertextAbi.From(ciphertext);
            var targetStealthAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetStealthAddressAbi.From(targetStealthAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, ephemeralPubKeyAbi, ciphertextAbi, targetStealthAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="assetId"> </param>
        /// <param name="ephemeralPubKey"> </param>
        /// <param name="ciphertext"> </param>
        /// <param name="targetStealthAddress"> </param>
        public async Task AnnounceAsaStealthPayment(ulong assetId, byte[] ephemeralPubKey, byte[] ciphertext, Algorand.Address targetStealthAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 15, 149, 114, 51 };
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetIdAbi.From(assetId);
            var ephemeralPubKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); ephemeralPubKeyAbi.From(ephemeralPubKey);
            var ciphertextAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); ciphertextAbi.From(ciphertext);
            var targetStealthAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetStealthAddressAbi.From(targetStealthAddress);

            var result = await base.CallApp(new List<object> { abiHandle, assetIdAbi, ephemeralPubKeyAbi, ciphertextAbi, targetStealthAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AnnounceAsaStealthPayment_Transactions(ulong assetId, byte[] ephemeralPubKey, byte[] ciphertext, Algorand.Address targetStealthAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 15, 149, 114, 51 };
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetIdAbi.From(assetId);
            var ephemeralPubKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); ephemeralPubKeyAbi.From(ephemeralPubKey);
            var ciphertextAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); ciphertextAbi.From(ciphertext);
            var targetStealthAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetStealthAddressAbi.From(targetStealthAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetIdAbi, ephemeralPubKeyAbi, ciphertextAbi, targetStealthAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task TogglePause(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 215, 156, 184, 131 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TogglePause_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 215, 156, 184, 131 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="bps"> </param>
        public async Task SetFee(ulong bps, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 173, 207, 232 };
            var bpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bpsAbi.From(bps);

            var result = await base.CallApp(new List<object> { abiHandle, bpsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetFee_Transactions(ulong bps, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 173, 207, 232 };
            var bpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bpsAbi.From(bps);

            return await base.MakeTransactionList(new List<object> { abiHandle, bpsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="receiver"> </param>
        public async Task SetFeeReceiver(Algorand.Address receiver, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 163, 194, 230, 127 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);

            var result = await base.CallApp(new List<object> { abiHandle, receiverAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetFeeReceiver_Transactions(Algorand.Address receiver, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 163, 194, 230, 127 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);

            return await base.MakeTransactionList(new List<object> { abiHandle, receiverAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="newAdmin"> </param>
        public async Task SetAdmin(Algorand.Address newAdmin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 23, 134, 105, 18 };
            var newAdminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newAdminAbi.From(newAdmin);

            var result = await base.CallApp(new List<object> { abiHandle, newAdminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetAdmin_Transactions(Algorand.Address newAdmin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 23, 134, 105, 18 };
            var newAdminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newAdminAbi.From(newAdmin);

            return await base.MakeTransactionList(new List<object> { abiHandle, newAdminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> GetAdmin(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 139, 36, 222 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> GetAdmin_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 139, 36, 222 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetFee(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 92, 117, 88, 131 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetFee_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 92, 117, 88, 131 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> GetFeeReceiver(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 230, 56, 136 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> GetFeeReceiver_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 230, 56, 136 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> IsPaused(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 155, 76, 7, 218 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsPaused_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 155, 76, 7, 218 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> Version(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 200, 140, 190, 133 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Version_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 200, 140, 190, 133 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiT3JpbnhBbm5vdW5jZXIiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkbWluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFubm91bmNlU3RlYWx0aFBheW1lbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlcGhlbWVyYWxQdWJLZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNpcGhlcnRleHQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXRTdGVhbHRoQWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhbm5vdW5jZUFTQVN0ZWFsdGhQYXltZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0SWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXBoZW1lcmFsUHViS2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjaXBoZXJ0ZXh0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0U3RlYWx0aEFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidG9nZ2xlUGF1c2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0RmVlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJwcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRGZWVSZWNlaXZlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjZWl2ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0QWRtaW4iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld0FkbWluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEFkbWluIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0RmVlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRGZWVSZWNlaXZlciIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImlzUGF1c2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmVyc2lvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjo0fSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyNDEsMzIwXSwiZXJyb3JNZXNzYWdlIjoiQ29udHJhY3QgaXMgcGF1c2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDE2XSwiZXJyb3JNZXNzYWdlIjoiRmVlIGV4Y2VlZHMgbWF4aW11bSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ2OV0sImVycm9yTWVzc2FnZSI6IkludmFsaWQgYWRtaW4gYWRkcmVzcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyNV0sImVycm9yTWVzc2FnZSI6IkludmFsaWQgYXNzZXQgSUQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NDNdLCJlcnJvck1lc3NhZ2UiOiJJbnZhbGlkIHJlY2VpdmVyIGFkZHJlc3MiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDYsMzMxXSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZCB0YXJnZXQgYWRkcmVzcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ5XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ2NF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgYWRtaW4gY2FuIGNoYW5nZSBhZG1pbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwOV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgYWRtaW4gY2FuIHNldCBmZWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MzhdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGFkbWluIGNhbiBzZXQgZmVlIHJlY2VpdmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzczXSwiZXJyb3JNZXNzYWdlIjoiT25seSBhZG1pbiBjYW4gdG9nZ2xlIHBhdXNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjM3LDMxNiwzNzEsMzc3LDQwNyw0MzYsNDYyLDQ3OCw0ODksNDk5LDUwOV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxOCwyOTddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjUsMzA0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3NywyMTIsMjMzLDI5MSwzMTIsNDMwLDQ1Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODMsNDAxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURNeUlESUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ0ltRmtiV2x1SWlBaWNHRjFjMlZrSWlBd2VERTFNV1kzWXpjMUlDSm1aV1ZTWldObGFYWmxjaUlnSW1abFpVSndjeUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZjbWx1ZUY5aGJtNXZkVzVqWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRTl5YVc1NFFXNXViM1Z1WTJWeUlHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnRkWE4wSUdKbElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZWlCdFlXbHVYMk55WldGMFpWOU9iMDl3UURFMUNpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE16WTNNbVZrTXpBZ01IZ3daamsxTnpJek15QXdlR1EzT1dOaU9EZ3pJREI0WkRsaFpHTm1aVGdnTUhoaE0yTXlaVFkzWmlBd2VERTNPRFkyT1RFeUlEQjRZV000WWpJMFpHVWdNSGcxWXpjMU5UZzRNeUF3ZURkaFpUWXpPRGc0SURCNE9XSTBZekEzWkdFZ01IaGpPRGhqWW1VNE5TQXZMeUJ0WlhSb2IyUWdJbUZ1Ym05MWJtTmxVM1JsWVd4MGFGQmhlVzFsYm5Rb1lubDBaVnN6TWwwc1lubDBaVnRkTEdGa1pISmxjM01wZG05cFpDSXNJRzFsZEdodlpDQWlZVzV1YjNWdVkyVkJVMEZUZEdWaGJIUm9VR0Y1YldWdWRDaDFhVzUwTmpRc1lubDBaVnN6TWwwc1lubDBaVnRkTEdGa1pISmxjM01wZG05cFpDSXNJRzFsZEdodlpDQWlkRzluWjJ4bFVHRjFjMlVvS1hadmFXUWlMQ0J0WlhSb2IyUWdJbk5sZEVabFpTaDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYzJWMFJtVmxVbVZqWldsMlpYSW9ZV1JrY21WemN5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKelpYUkJaRzFwYmloaFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJbWRsZEVGa2JXbHVLQ2xoWkdSeVpYTnpJaXdnYldWMGFHOWtJQ0puWlhSR1pXVW9LWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlaMlYwUm1WbFVtVmpaV2wyWlhJb0tXRmtaSEpsYzNNaUxDQnRaWFJvYjJRZ0ltbHpVR0YxYzJWa0tDbGliMjlzSWl3Z2JXVjBhRzlrSUNKMlpYSnphVzl1S0NsemRISnBibWNpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCaGJtNXZkVzVqWlZOMFpXRnNkR2hRWVhsdFpXNTBJR0Z1Ym05MWJtTmxRVk5CVTNSbFlXeDBhRkJoZVcxbGJuUWdkRzluWjJ4bFVHRjFjMlVnYzJWMFJtVmxJSE5sZEVabFpWSmxZMlZwZG1WeUlITmxkRUZrYldsdUlHZGxkRUZrYldsdUlHZGxkRVpsWlNCblpYUkdaV1ZTWldObGFYWmxjaUJwYzFCaGRYTmxaQ0J0WVdsdVgzWmxjbk5wYjI1ZmNtOTFkR1ZBTVRNS0lDQWdJR1Z5Y2dvS2JXRnBibDkyWlhKemFXOXVYM0p2ZFhSbFFERXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlhVzU0WDJGdWJtOTFibU5sY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFek53b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05UQXdNRFV6TVRKbE16QXlaVE13Q2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZM0psWVhSbFgwNXZUM0JBTVRVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjNKcGJuaGZZVzV1YjNWdVkyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakFLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCUGNtbHVlRUZ1Ym05MWJtTmxjaUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR1F6TWpSaVpXRTBJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRvWVdSa2NtVnpjeWwyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dZM0psWVhSbFFYQndiR2xqWVhScGIyNEtJQ0FnSUdWeWNnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21sdWVGOWhibTV2ZFc1alpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZUM0pwYm5oQmJtNXZkVzVqWlhJdVkzSmxZWFJsUVhCd2JHbGpZWFJwYjI1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpjbVZoZEdWQmNIQnNhV05oZEdsdmJqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtbHVlRjloYm01dmRXNWpaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T0FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHOXVRM0psWVhSbE9pQW5jbVZ4ZFdseVpTY2dmU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlhVzU0WDJGdWJtOTFibU5sY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJeUNpQWdJQ0F2THlCaFpHMXBiaUE5SUVkc2IySmhiRk4wWVhSbFBHRnlZelF1UVdSa2NtVnpjejRvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWVdSdGFXNGlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSnBibmhmWVc1dWIzVnVZMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpBS0lDQWdJQzh2SUhSb2FYTXVZV1J0YVc0dWRtRnNkV1VnUFNCaFpHMXBiZ29nSUNBZ1pHbG5JREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0pwYm5oZllXNXViM1Z1WTJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qUUtJQ0FnSUM4dklHWmxaVkpsWTJWcGRtVnlJRDBnUjJ4dlltRnNVM1JoZEdVOFlYSmpOQzVCWkdSeVpYTnpQaWdwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0ptWldWU1pXTmxhWFpsY2lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21sdWVGOWhibTV2ZFc1alpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNUW9nSUNBZ0x5OGdkR2hwY3k1bVpXVlNaV05sYVhabGNpNTJZV3gxWlNBOUlHRmtiV2x1Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5YVc1NFgyRnVibTkxYm1ObGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXpDaUFnSUNBdkx5Qm1aV1ZDY0hNZ1BTQkhiRzlpWVd4VGRHRjBaVHhoY21NMExsVnBiblEyTkQ0b0tRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVptVmxRbkJ6SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5YVc1NFgyRnVibTkxYm1ObGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXlDaUFnSUNBdkx5QjBhR2x6TG1abFpVSndjeTUyWVd4MVpTQTlJRzVsZHlCaGNtTTBMbFZwYm5RMk5DZ3dLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtbHVlRjloYm01dmRXNWpaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TlFvZ0lDQWdMeThnY0dGMWMyVmtJRDBnUjJ4dlltRnNVM1JoZEdVOFlYSmpOQzVDYjI5c1BpZ3BDaUFnSUNCaWVYUmxZMTh4SUM4dklDSndZWFZ6WldRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjNKcGJuaGZZVzV1YjNWdVkyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNek1LSUNBZ0lDOHZJSFJvYVhNdWNHRjFjMlZrTG5aaGJIVmxJRDBnYm1WM0lHRnlZelF1UW05dmJDaG1ZV3h6WlNrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eWFXNTRYMkZ1Ym05MWJtTmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakk0Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2IyNURjbVZoZEdVNklDZHlaWEYxYVhKbEp5QjlLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtbHVlRjloYm01dmRXNWpaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VDNKcGJuaEJibTV2ZFc1alpYSXVZVzV1YjNWdVkyVlRkR1ZoYkhSb1VHRjViV1Z1ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtRnVibTkxYm1ObFUzUmxZV3gwYUZCaGVXMWxiblE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0pwYm5oZllXNXViM1Z1WTJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16Y0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21sdWVGOWhibTV2ZFc1alpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBNd29nSUNBZ0x5OGdZWE56WlhKMEtDRjBhR2x6TG5CaGRYTmxaQzUyWVd4MVpTNXVZWFJwZG1Vc0lDZERiMjUwY21GamRDQnBjeUJ3WVhWelpXUW5LUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtbHVlRjloYm01dmRXNWpaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TlFvZ0lDQWdMeThnY0dGMWMyVmtJRDBnUjJ4dlltRnNVM1JoZEdVOFlYSmpOQzVDYjI5c1BpZ3BDaUFnSUNCaWVYUmxZMTh4SUM4dklDSndZWFZ6WldRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjNKcGJuaGZZVzV1YjNWdVkyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORE1LSUNBZ0lDOHZJR0Z6YzJWeWRDZ2hkR2hwY3k1d1lYVnpaV1F1ZG1Gc2RXVXVibUYwYVhabExDQW5RMjl1ZEhKaFkzUWdhWE1nY0dGMWMyVmtKeWtLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnUTI5dWRISmhZM1FnYVhNZ2NHRjFjMlZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0pwYm5oZllXNXViM1Z1WTJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EUUtJQ0FnSUM4dklHRnpjMlZ5ZENoMFlYSm5aWFJUZEdWaGJIUm9RV1JrY21WemN5NXVZWFJwZG1VZ0lUMDlJRWRzYjJKaGJDNTZaWEp2UVdSa2NtVnpjeXdnSjBsdWRtRnNhV1FnZEdGeVoyVjBJR0ZrWkhKbGMzTW5LUW9nSUNBZ1pIVndDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RZ0x5OGdTVzUyWVd4cFpDQjBZWEpuWlhRZ1lXUmtjbVZ6Y3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5YVc1NFgyRnVibTkxYm1ObGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTRDaUFnSUNBdkx5QnNaWFFnYkc5blJHRjBZU0E5SUVKNWRHVnpLQ0pQY21sdWVGQmhlVzFsYm5RNklpa0tJQ0FnSUhCMWMyaGllWFJsY3lBaVQzSnBibmhRWVhsdFpXNTBPaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZjbWx1ZUY5aGJtNXZkVzVqWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME9Rb2dJQ0FnTHk4Z2JHOW5SR0YwWVNBOUlHeHZaMFJoZEdFdVkyOXVZMkYwS0hSaGNtZGxkRk4wWldGc2RHaEJaR1J5WlhOekxtSjVkR1Z6S1FvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjNKcGJuaGZZVzV1YjNWdVkyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVEFLSUNBZ0lDOHZJR3h2WjBSaGRHRWdQU0JzYjJkRVlYUmhMbU52Ym1OaGRDaGxjR2hsYldWeVlXeFFkV0pMWlhrdWJtRjBhWFpsS1FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZjbWx1ZUY5aGJtNXZkVzVqWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1Rb2dJQ0FnTHk4Z2JHOW5SR0YwWVNBOUlHeHZaMFJoZEdFdVkyOXVZMkYwS0dOcGNHaGxjblJsZUhRdWJtRjBhWFpsS1FvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5YVc1NFgyRnVibTkxYm1ObGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVXpDaUFnSUNBdkx5QnNiMmNvYkc5blJHRjBZU2tnTHk4Z1NXNWtaWGhsY2lCM2FXeHNJSEpsWVdRZ2RHaHBjeUJtYjNJZ2NHRjViV1Z1ZENCelkyRnVibWx1WndvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0pwYm5oZllXNXViM1Z1WTJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16Y0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtbHVlRjloYm01dmRXNWpaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VDNKcGJuaEJibTV2ZFc1alpYSXVZVzV1YjNWdVkyVkJVMEZUZEdWaGJIUm9VR0Y1YldWdWRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUZ1Ym05MWJtTmxRVk5CVTNSbFlXeDBhRkJoZVcxbGJuUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSnBibmhmWVc1dWIzVnVZMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRjS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdPQ0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtbHVlRjloYm01dmRXNWpaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTkFvZ0lDQWdMeThnWVhOelpYSjBLQ0YwYUdsekxuQmhkWE5sWkM1MllXeDFaUzV1WVhScGRtVXNJQ2REYjI1MGNtRmpkQ0JwY3lCd1lYVnpaV1FuS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZjbWx1ZUY5aGJtNXZkVzVqWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5Rb2dJQ0FnTHk4Z2NHRjFjMlZrSUQwZ1IyeHZZbUZzVTNSaGRHVThZWEpqTkM1Q2IyOXNQaWdwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p3WVhWelpXUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSnBibmhmWVc1dWIzVnVZMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpRS0lDQWdJQzh2SUdGemMyVnlkQ2doZEdocGN5NXdZWFZ6WldRdWRtRnNkV1V1Ym1GMGFYWmxMQ0FuUTI5dWRISmhZM1FnYVhNZ2NHRjFjMlZrSnlrS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1EyOXVkSEpoWTNRZ2FYTWdjR0YxYzJWa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjNKcGJuaGZZVzV1YjNWdVkyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOalVLSUNBZ0lDOHZJR0Z6YzJWeWRDaGhjM05sZEVsa0xtRnpWV2x1ZERZMEtDa2dQaUF3TENBblNXNTJZV3hwWkNCaGMzTmxkQ0JKUkNjcENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHSjBiMmtLSUNBZ0lHUjFjQW9nSUNBZ1lYTnpaWEowSUM4dklFbHVkbUZzYVdRZ1lYTnpaWFFnU1VRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21sdWVGOWhibTV2ZFc1alpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJOZ29nSUNBZ0x5OGdZWE56WlhKMEtIUmhjbWRsZEZOMFpXRnNkR2hCWkdSeVpYTnpMbTVoZEdsMlpTQWhQVDBnUjJ4dlltRnNMbnBsY205QlpHUnlaWE56TENBblNXNTJZV3hwWkNCMFlYSm5aWFFnWVdSa2NtVnpjeWNwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdaMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDaUFnSUNBaFBRb2dJQ0FnWVhOelpYSjBJQzh2SUVsdWRtRnNhV1FnZEdGeVoyVjBJR0ZrWkhKbGMzTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtbHVlRjloYm01dmRXNWpaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTVFvZ0lDQWdMeThnYkc5blJHRjBZU0E5SUd4dlowUmhkR0V1WTI5dVkyRjBLRUo1ZEdWektHRnpjMlYwU1dRdVlYTlZhVzUwTmpRb0tTa3BDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSnBibmhmWVc1dWIzVnVZMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpBS0lDQWdJQzh2SUd4bGRDQnNiMmRFWVhSaElEMGdRbmwwWlhNb0lrOXlhVzU0UVZOQlVHRjViV1Z1ZERvaUtRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKUGNtbHVlRUZUUVZCaGVXMWxiblE2SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5YVc1NFgyRnVibTkxYm1ObGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY3hDaUFnSUNBdkx5QnNiMmRFWVhSaElEMGdiRzluUkdGMFlTNWpiMjVqWVhRb1FubDBaWE1vWVhOelpYUkpaQzVoYzFWcGJuUTJOQ2dwS1NrS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eWFXNTRYMkZ1Ym05MWJtTmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamN5Q2lBZ0lDQXZMeUJzYjJkRVlYUmhJRDBnYkc5blJHRjBZUzVqYjI1allYUW9kR0Z5WjJWMFUzUmxZV3gwYUVGa1pISmxjM011WW5sMFpYTXBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZjbWx1ZUY5aGJtNXZkVzVqWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM013b2dJQ0FnTHk4Z2JHOW5SR0YwWVNBOUlHeHZaMFJoZEdFdVkyOXVZMkYwS0dWd2FHVnRaWEpoYkZCMVlrdGxlUzV1WVhScGRtVXBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eWFXNTRYMkZ1Ym05MWJtTmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamMwQ2lBZ0lDQXZMeUJzYjJkRVlYUmhJRDBnYkc5blJHRjBZUzVqYjI1allYUW9ZMmx3YUdWeWRHVjRkQzV1WVhScGRtVXBDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSnBibmhmWVc1dWIzVnVZMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpZS0lDQWdJQzh2SUd4dlp5aHNiMmRFWVhSaEtTQXZMeUJKYm1SbGVHVnlJSGRwYkd3Z2NtVmhaQ0IwYUdseklHWnZjaUJ3WVhsdFpXNTBJSE5qWVc1dWFXNW5DaUFnSUNCc2IyY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtbHVlRjloYm01dmRXNWpaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTndvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5YVc1NFgyRnVibTkxYm1ObGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFBjbWx1ZUVGdWJtOTFibU5sY2k1MGIyZG5iR1ZRWVhWelpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblJ2WjJkc1pWQmhkWE5sT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5YVc1NFgyRnVibTkxYm1ObGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZ3pDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnZEdocGN5NWhaRzFwYmk1MllXeDFaUzV1WVhScGRtVXNJQ2RQYm14NUlHRmtiV2x1SUdOaGJpQjBiMmRuYkdVZ2NHRjFjMlVuS1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtbHVlRjloYm01dmRXNWpaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TWdvZ0lDQWdMeThnWVdSdGFXNGdQU0JIYkc5aVlXeFRkR0YwWlR4aGNtTTBMa0ZrWkhKbGMzTStLQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUZrYldsdUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eWFXNTRYMkZ1Ym05MWJtTmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamd6Q2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ2RHaHBjeTVoWkcxcGJpNTJZV3gxWlM1dVlYUnBkbVVzSUNkUGJteDVJR0ZrYldsdUlHTmhiaUIwYjJkbmJHVWdjR0YxYzJVbktRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCaFpHMXBiaUJqWVc0Z2RHOW5aMnhsSUhCaGRYTmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSnBibmhmWVc1dWIzVnVZMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RRS0lDQWdJQzh2SUhSb2FYTXVjR0YxYzJWa0xuWmhiSFZsSUQwZ2JtVjNJR0Z5WXpRdVFtOXZiQ2doZEdocGN5NXdZWFZ6WldRdWRtRnNkV1V1Ym1GMGFYWmxLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtbHVlRjloYm01dmRXNWpaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TlFvZ0lDQWdMeThnY0dGMWMyVmtJRDBnUjJ4dlltRnNVM1JoZEdVOFlYSmpOQzVDYjI5c1BpZ3BDaUFnSUNCaWVYUmxZMTh4SUM4dklDSndZWFZ6WldRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjNKcGJuaGZZVzV1YjNWdVkyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRFFLSUNBZ0lDOHZJSFJvYVhNdWNHRjFjMlZrTG5aaGJIVmxJRDBnYm1WM0lHRnlZelF1UW05dmJDZ2hkR2hwY3k1d1lYVnpaV1F1ZG1Gc2RXVXVibUYwYVhabEtRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJQ0VLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtbHVlRjloYm01dmRXNWpaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TlFvZ0lDQWdMeThnY0dGMWMyVmtJRDBnUjJ4dlltRnNVM1JoZEdVOFlYSmpOQzVDYjI5c1BpZ3BDaUFnSUNCaWVYUmxZMTh4SUM4dklDSndZWFZ6WldRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjNKcGJuaGZZVzV1YjNWdVkyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRFFLSUNBZ0lDOHZJSFJvYVhNdWNHRjFjMlZrTG5aaGJIVmxJRDBnYm1WM0lHRnlZelF1UW05dmJDZ2hkR2hwY3k1d1lYVnpaV1F1ZG1Gc2RXVXVibUYwYVhabEtRb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtbHVlRjloYm01dmRXNWpaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TVFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5YVc1NFgyRnVibTkxYm1ObGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFBjbWx1ZUVGdWJtOTFibU5sY2k1elpYUkdaV1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwelpYUkdaV1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0pwYm5oZllXNXViM1Z1WTJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9EZ0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0NBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eWFXNTRYMkZ1Ym05MWJtTmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamt3Q2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ2RHaHBjeTVoWkcxcGJpNTJZV3gxWlM1dVlYUnBkbVVzSUNkUGJteDVJR0ZrYldsdUlHTmhiaUJ6WlhRZ1ptVmxKeWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjNKcGJuaGZZVzV1YjNWdVkyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNaklLSUNBZ0lDOHZJR0ZrYldsdUlEMGdSMnh2WW1Gc1UzUmhkR1U4WVhKak5DNUJaR1J5WlhOelBpZ3BDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmhaRzFwYmlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21sdWVGOWhibTV2ZFc1alpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVNQW9nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdQVDA5SUhSb2FYTXVZV1J0YVc0dWRtRnNkV1V1Ym1GMGFYWmxMQ0FuVDI1c2VTQmhaRzFwYmlCallXNGdjMlYwSUdabFpTY3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHRmtiV2x1SUdOaGJpQnpaWFFnWm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjNKcGJuaGZZVzV1YjNWdVkyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVEVLSUNBZ0lDOHZJR0Z6YzJWeWRDaGljSE11WVhOVmFXNTBOalFvS1NBOFBTQk5RVmhmUmtWRlgwSlFVeXdnSjBabFpTQmxlR05sWldSeklHMWhlR2x0ZFcwbktRb2dJQ0FnWkhWd0NpQWdJQ0JpZEc5cENpQWdJQ0J3ZFhOb2FXNTBJRFV3TUNBdkx5QTFNREFLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z1JtVmxJR1Y0WTJWbFpITWdiV0Y0YVcxMWJRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eWFXNTRYMkZ1Ym05MWJtTmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl6Q2lBZ0lDQXZMeUJtWldWQ2NITWdQU0JIYkc5aVlXeFRkR0YwWlR4aGNtTTBMbFZwYm5RMk5ENG9LUW9nSUNBZ1lubDBaV01nTkNBdkx5QWlabVZsUW5Ceklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eWFXNTRYMkZ1Ym05MWJtTmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamt5Q2lBZ0lDQXZMeUIwYUdsekxtWmxaVUp3Y3k1MllXeDFaU0E5SUdKd2N3b2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtbHVlRjloYm01dmRXNWpaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80T0FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5YVc1NFgyRnVibTkxYm1ObGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFBjbWx1ZUVGdWJtOTFibU5sY2k1elpYUkdaV1ZTWldObGFYWmxjbHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25ObGRFWmxaVkpsWTJWcGRtVnlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlhVzU0WDJGdWJtOTFibU5sY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prMkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eWFXNTRYMkZ1Ym05MWJtTmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPams0Q2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ2RHaHBjeTVoWkcxcGJpNTJZV3gxWlM1dVlYUnBkbVVzSUNkUGJteDVJR0ZrYldsdUlHTmhiaUJ6WlhRZ1ptVmxJSEpsWTJWcGRtVnlKeWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjNKcGJuaGZZVzV1YjNWdVkyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNaklLSUNBZ0lDOHZJR0ZrYldsdUlEMGdSMnh2WW1Gc1UzUmhkR1U4WVhKak5DNUJaR1J5WlhOelBpZ3BDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmhaRzFwYmlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21sdWVGOWhibTV2ZFc1alpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVPQW9nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdQVDA5SUhSb2FYTXVZV1J0YVc0dWRtRnNkV1V1Ym1GMGFYWmxMQ0FuVDI1c2VTQmhaRzFwYmlCallXNGdjMlYwSUdabFpTQnlaV05sYVhabGNpY3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHRmtiV2x1SUdOaGJpQnpaWFFnWm1WbElISmxZMlZwZG1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjNKcGJuaGZZVzV1YjNWdVkyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVGtLSUNBZ0lDOHZJR0Z6YzJWeWRDaHlaV05sYVhabGNpNXVZWFJwZG1VZ0lUMDlJRWRzYjJKaGJDNTZaWEp2UVdSa2NtVnpjeXdnSjBsdWRtRnNhV1FnY21WalpXbDJaWElnWVdSa2NtVnpjeWNwQ2lBZ0lDQmtkWEFLSUNBZ0lHZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2dJQ0FnSVQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJKYm5aaGJHbGtJSEpsWTJWcGRtVnlJR0ZrWkhKbGMzTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtbHVlRjloYm01dmRXNWpaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TkFvZ0lDQWdMeThnWm1WbFVtVmpaV2wyWlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhoY21NMExrRmtaSEpsYzNNK0tDa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltWmxaVkpsWTJWcGRtVnlJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlhVzU0WDJGdWJtOTFibU5sY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd01Bb2dJQ0FnTHk4Z2RHaHBjeTVtWldWU1pXTmxhWFpsY2k1MllXeDFaU0E5SUhKbFkyVnBkbVZ5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5YVc1NFgyRnVibTkxYm1ObGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qazJDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSnBibmhmWVc1dWIzVnVZMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2s5eWFXNTRRVzV1YjNWdVkyVnlMbk5sZEVGa2JXbHVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzJWMFFXUnRhVzQ2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0pwYm5oZllXNXViM1Z1WTJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQTBDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlhVzU0WDJGdWJtOTFibU5sY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd05nb2dJQ0FnTHk4Z1lYTnpaWEowS0ZSNGJpNXpaVzVrWlhJZ1BUMDlJSFJvYVhNdVlXUnRhVzR1ZG1Gc2RXVXVibUYwYVhabExDQW5UMjVzZVNCaFpHMXBiaUJqWVc0Z1kyaGhibWRsSUdGa2JXbHVKeWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjNKcGJuaGZZVzV1YjNWdVkyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNaklLSUNBZ0lDOHZJR0ZrYldsdUlEMGdSMnh2WW1Gc1UzUmhkR1U4WVhKak5DNUJaR1J5WlhOelBpZ3BDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmhaRzFwYmlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21sdWVGOWhibTV2ZFc1alpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRFlLSUNBZ0lDOHZJR0Z6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCMGFHbHpMbUZrYldsdUxuWmhiSFZsTG01aGRHbDJaU3dnSjA5dWJIa2dZV1J0YVc0Z1kyRnVJR05vWVc1blpTQmhaRzFwYmljcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUdGa2JXbHVJR05oYmlCamFHRnVaMlVnWVdSdGFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtbHVlRjloYm01dmRXNWpaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURjS0lDQWdJQzh2SUdGemMyVnlkQ2h1WlhkQlpHMXBiaTV1WVhScGRtVWdJVDA5SUVkc2IySmhiQzU2WlhKdlFXUmtjbVZ6Y3l3Z0owbHVkbUZzYVdRZ1lXUnRhVzRnWVdSa2NtVnpjeWNwQ2lBZ0lDQmtkWEFLSUNBZ0lHZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2dJQ0FnSVQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJKYm5aaGJHbGtJR0ZrYldsdUlHRmtaSEpsYzNNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21sdWVGOWhibTV2ZFc1alpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNZ29nSUNBZ0x5OGdZV1J0YVc0Z1BTQkhiRzlpWVd4VGRHRjBaVHhoY21NMExrRmtaSEpsYzNNK0tDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5YVc1NFgyRnVibTkxYm1ObGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdPQW9nSUNBZ0x5OGdkR2hwY3k1aFpHMXBiaTUyWVd4MVpTQTlJRzVsZDBGa2JXbHVDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlhVzU0WDJGdWJtOTFibU5sY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd05Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eWFXNTRYMkZ1Ym05MWJtTmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBQY21sdWVFRnVibTkxYm1ObGNpNW5aWFJCWkcxcGJsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEVGa2JXbHVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlhVzU0WDJGdWJtOTFibU5sY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE5Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVZV1J0YVc0dWRtRnNkV1VLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSnBibmhmWVc1dWIzVnVZMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpJS0lDQWdJQzh2SUdGa2JXbHVJRDBnUjJ4dlltRnNVM1JoZEdVOFlYSmpOQzVCWkdSeVpYTnpQaWdwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0poWkcxcGJpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtbHVlRjloYm01dmRXNWpaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRVS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxtRmtiV2x1TG5aaGJIVmxDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eWFXNTRYMkZ1Ym05MWJtTmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4TXdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5YVc1NFgyRnVibTkxYm1ObGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFBjbWx1ZUVGdWJtOTFibU5sY2k1blpYUkdaV1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUkdaV1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0pwYm5oZllXNXViM1Z1WTJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USXhDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTVtWldWQ2NITXVkbUZzZFdVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0pwYm5oZllXNXViM1Z1WTJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qTUtJQ0FnSUM4dklHWmxaVUp3Y3lBOUlFZHNiMkpoYkZOMFlYUmxQR0Z5WXpRdVZXbHVkRFkwUGlncENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKbVpXVkNjSE1pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0pwYm5oZllXNXViM1Z1WTJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USXhDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTVtWldWQ2NITXVkbUZzZFdVS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0pwYm5oZllXNXViM1Z1WTJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URTVDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSnBibmhmWVc1dWIzVnVZMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2s5eWFXNTRRVzV1YjNWdVkyVnlMbWRsZEVabFpWSmxZMlZwZG1WeVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwUm1WbFVtVmpaV2wyWlhJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjNKcGJuaGZZVzV1YjNWdVkyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEkzQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1bVpXVlNaV05sYVhabGNpNTJZV3gxWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZjbWx1ZUY5aGJtNXZkVzVqWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5Bb2dJQ0FnTHk4Z1ptVmxVbVZqWldsMlpYSWdQU0JIYkc5aVlXeFRkR0YwWlR4aGNtTTBMa0ZrWkhKbGMzTStLQ2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbVpsWlZKbFkyVnBkbVZ5SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5YVc1NFgyRnVibTkxYm1ObGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlOd29nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11Wm1WbFVtVmpaV2wyWlhJdWRtRnNkV1VLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSnBibmhmWVc1dWIzVnVZMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJMUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjNKcGJuaGZZVzV1YjNWdVkyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPazl5YVc1NFFXNXViM1Z1WTJWeUxtbHpVR0YxYzJWa1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0thWE5RWVhWelpXUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSnBibmhmWVc1dWIzVnVZMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNekNpQWdJQ0F2THlCeVpYUjFjbTRnZEdocGN5NXdZWFZ6WldRdWRtRnNkV1VLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSnBibmhmWVc1dWIzVnVZMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpVS0lDQWdJQzh2SUhCaGRYTmxaQ0E5SUVkc2IySmhiRk4wWVhSbFBHRnlZelF1UW05dmJENG9LUW9nSUNBZ1lubDBaV05mTVNBdkx5QWljR0YxYzJWa0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eWFXNTRYMkZ1Ym05MWJtTmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6TXdvZ0lDQWdMeThnY21WMGRYSnVJSFJvYVhNdWNHRjFjMlZrTG5aaGJIVmxDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eWFXNTRYMkZ1Ym05MWJtTmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6TVFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUVnQWlZRkJXRmtiV2x1Qm5CaGRYTmxaQVFWSDN4MUMyWmxaVkpsWTJWcGRtVnlCbVpsWlVKd2N6RVpGRVF4R0VFQVpZSUxCRFp5N1RBRUQ1VnlNd1RYbkxpREJObXR6K2dFbzhMbWZ3UVhobWtTQkt5TEpONEVYSFZZZ3dSNjVqaUlCSnRNQjlvRXlJeStoVFlhQUk0TEFFSUFpQURqQVA0QkhBRTJBVkFCV2dGbEFXOEFBUUNBQ3hVZmZIVUFCVEV1TUM0d3NDTkRnQVRUSkw2a05ob0FqZ0VBQVFBMkdnRkpGU1FTUkNoTEFXY3JUR2NuQklBSUFBQUFBQUFBQUFCbktZQUJBR2NqUXpZYUFVa1ZKQkpFTmhvQ1NTSlpKUWhMQVJVU1JEWWFBMGtWSkJKRUlpbGxSQ0pURkVSSk1nTVRSSUFOVDNKcGJuaFFZWGx0Wlc1ME9reFFUd0pRVEZjQ0FGQ3dJME0yR2dGSkZZRUlFa1EyR2dKSkZTUVNSRFlhQTBraVdTVUlTd0VWRWtRMkdnUkpGU1FTUkNJcFpVUWlVeFJFVHdNWFNVUkxBVElERTBRV2dCQlBjbWx1ZUVGVFFWQmhlVzFsYm5RNlRGQk1VRThDVUV4WEFnQlFzQ05ETVFBaUtHVkVFa1FpS1dWRUlsTVVnQUVBSWs4Q1ZDbE1aeU5ETmhvQlNSV0JDQkpFTVFBaUtHVkVFa1JKRjRIMEF3NUVKd1JNWnlORE5ob0JTUlVrRWtReEFDSW9aVVFTUkVreUF4TkVLMHhuSTBNMkdnRkpGU1FTUkRFQUlpaGxSQkpFU1RJREUwUW9UR2NqUXlJb1pVUXFURkN3STBNaUp3UmxSQ3BNVUxBalF5SXJaVVFxVEZDd0kwTWlLV1ZFS2t4UXNDTkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjozLCJwYXRjaCI6MiwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
