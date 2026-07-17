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

namespace Arc56.Generated.RahulScripts.LiveHack.CarbonCreditContract_155ab92e
{


    public class CarbonCreditContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CarbonCreditContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="manager"> </param>
        /// <param name="reserve"> </param>
        /// <param name="freeze"> </param>
        /// <param name="clawback"> </param>
        /// <param name="total_supply"> </param>
        /// <param name="asset_name"> </param>
        /// <param name="unit_name"> </param>
        /// <param name="decimals"> </param>
        /// <param name="url"> </param>
        public async Task<ulong> Initialize(Address manager, Address reserve, Address freeze, Address clawback, ulong total_supply, string asset_name, string unit_name, ulong decimals, string url, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { manager, reserve, freeze, clawback });
            byte managerRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte reserveRefIndex = (byte)(_acctRefBase + 1 + 1);
            byte freezeRefIndex = (byte)(_acctRefBase + 2 + 1);
            byte clawbackRefIndex = (byte)(_acctRefBase + 3 + 1);
            byte[] abiHandle = { 157, 177, 113, 5 };
            var managerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); managerAbi.From(manager);
            var reserveAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); reserveAbi.From(reserve);
            var freezeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); freezeAbi.From(freeze);
            var clawbackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); clawbackAbi.From(clawback);
            var total_supplyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); total_supplyAbi.From(total_supply);
            var asset_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); asset_nameAbi.From(asset_name);
            var unit_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); unit_nameAbi.From(unit_name);
            var decimalsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); decimalsAbi.From(decimals);
            var urlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); urlAbi.From(url);

            var result = await base.CallApp(new List<object> { abiHandle, managerRefIndex, reserveRefIndex, freezeRefIndex, clawbackRefIndex, total_supplyAbi, asset_nameAbi, unit_nameAbi, decimalsAbi, urlAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Initialize_Transactions(Address manager, Address reserve, Address freeze, Address clawback, ulong total_supply, string asset_name, string unit_name, ulong decimals, string url, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { manager, reserve, freeze, clawback });
            byte managerRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte reserveRefIndex = (byte)(_acctRefBase + 1 + 1);
            byte freezeRefIndex = (byte)(_acctRefBase + 2 + 1);
            byte clawbackRefIndex = (byte)(_acctRefBase + 3 + 1);
            byte[] abiHandle = { 157, 177, 113, 5 };
            var managerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); managerAbi.From(manager);
            var reserveAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); reserveAbi.From(reserve);
            var freezeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); freezeAbi.From(freeze);
            var clawbackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); clawbackAbi.From(clawback);
            var total_supplyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); total_supplyAbi.From(total_supply);
            var asset_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); asset_nameAbi.From(asset_name);
            var unit_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); unit_nameAbi.From(unit_name);
            var decimalsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); decimalsAbi.From(decimals);
            var urlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); urlAbi.From(url);

            return await base.MakeTransactionList(new List<object> { abiHandle, managerRefIndex, reserveRefIndex, freezeRefIndex, clawbackRefIndex, total_supplyAbi, asset_nameAbi, unit_nameAbi, decimalsAbi, urlAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="address"> </param>
        public async Task SetWhitelist(Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { address });
            byte addressRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 163, 216, 15, 66 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            var result = await base.CallApp(new List<object> { abiHandle, addressRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetWhitelist_Transactions(Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { address });
            byte addressRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 163, 216, 15, 66 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            return await base.MakeTransactionList(new List<object> { abiHandle, addressRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        public async Task OptInUser(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 165, 153, 166, 110 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, assetRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptInUser_Transactions(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 165, 153, 166, 110 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="user"> </param>
        public async Task<bool> IsUserOptedIn(Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { user });
            byte userRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 223, 31, 167, 90 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            var result = await base.SimApp(new List<object> { abiHandle, userRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsUserOptedIn_Transactions(Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { user });
            byte userRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 223, 31, 167, 90 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            return await base.MakeTransactionList(new List<object> { abiHandle, userRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="amount"> </param>
        /// <param name="receiver"> </param>
        public async Task MintToken(Address receiver, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { receiver });
            byte receiverRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 225, 170, 145, 131 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi, receiverRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> MintToken_Transactions(Address receiver, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { receiver });
            byte receiverRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 225, 170, 145, 131 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi, receiverRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="amount"> </param>
        /// <param name="receiver"> </param>
        public async Task TransferToken(Address receiver, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { receiver });
            byte receiverRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 3, 128, 229, 101 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi, receiverRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TransferToken_Transactions(Address receiver, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { receiver });
            byte receiverRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 3, 128, 229, 101 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi, receiverRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="amount"> </param>
        public async Task RedeemToken(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 248, 157, 214, 125 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RedeemToken_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 248, 157, 214, 125 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="user_id"> </param>
        public async Task RecoverToken(string user_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 150, 11, 96, 228 };
            var user_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); user_idAbi.From(user_id);

            var result = await base.CallApp(new List<object> { abiHandle, user_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RecoverToken_Transactions(string user_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 150, 11, 96, 228 };
            var user_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); user_idAbi.From(user_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, user_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="account"> </param>
        public async Task<ulong> GetBalance(Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { account });
            byte accountRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 202, 136, 25, 118 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, accountRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetBalance_Transactions(Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { account });
            byte accountRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 202, 136, 25, 118 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetTotalSupply(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 144, 147, 85 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalSupply_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 144, 147, 85 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="target"> </param>
        public async Task FreezeAccount(Address target, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { target });
            byte targetRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 168, 181, 119, 210 };
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);

            var result = await base.CallApp(new List<object> { abiHandle, targetRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> FreezeAccount_Transactions(Address target, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { target });
            byte targetRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 168, 181, 119, 210 };
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);

            return await base.MakeTransactionList(new List<object> { abiHandle, targetRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="target"> </param>
        /// <param name="amount"> </param>
        public async Task ClawbackTokens(Address target, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { target });
            byte targetRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 74, 86, 114, 247 };
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, targetRefIndex, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ClawbackTokens_Transactions(Address target, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { target });
            byte targetRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 74, 86, 114, 247 };
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, targetRefIndex, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="user"> </param>
        public async Task<ulong> GetUserRedemptions(Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { user });
            byte userRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 171, 118, 213, 164 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            var result = await base.CallApp(new List<object> { abiHandle, userRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetUserRedemptions_Transactions(Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { user });
            byte userRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 171, 118, 213, 164 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            return await base.MakeTransactionList(new List<object> { abiHandle, userRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="user"> </param>
        public async Task<ulong> GetUserMintCount(Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { user });
            byte userRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 109, 39, 61, 103 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            var result = await base.CallApp(new List<object> { abiHandle, userRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetUserMintCount_Transactions(Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { user });
            byte userRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 109, 39, 61, 103 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            return await base.MakeTransactionList(new List<object> { abiHandle, userRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ2FyYm9uQ3JlZGl0Q29udHJhY3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiaW5pdGlhbGl6ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhY2NvdW50Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWFuYWdlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlc2VydmUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmcmVlemUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjbGF3YmFjayIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG90YWxfc3VwcGx5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldF9uYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1bml0X25hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlY2ltYWxzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1cmwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfd2hpdGVsaXN0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im9wdF9pbl91c2VyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFzc2V0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaXNfdXNlcl9vcHRlZF9pbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhY2NvdW50Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1pbnRfdG9rZW4iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhY2NvdW50Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjZWl2ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidHJhbnNmZXJfdG9rZW4iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhY2NvdW50Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjZWl2ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVkZWVtX3Rva2VuIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWNvdmVyX3Rva2VuIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXJfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2JhbGFuY2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdG90YWxfc3VwcGx5IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZnJlZXplX2FjY291bnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRhcmdldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjbGF3YmFja190b2tlbnMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRhcmdldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF91c2VyX3JlZGVtcHRpb25zIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3VzZXJfbWludF9jb3VudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhY2NvdW50Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjo0LCJieXRlcyI6NX0sImxvY2FsIjp7ImludHMiOjUsImJ5dGVzIjoxfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbOTE2XSwiZXJyb3JNZXNzYWdlIjoiQWRkcmVzcyBub3Qgd2hpdGVsaXN0ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MzRdLCJlcnJvck1lc3NhZ2UiOiJBbHJlYWR5IGluaXRpYWxpemVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODIwXSwiZXJyb3JNZXNzYWdlIjoiQW1vdW50IG11c3QgYmUgcG9zaXRpdmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDY1XSwiZXJyb3JNZXNzYWdlIjoiQ29vbGRvd24gYWN0aXZlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTMxLDk4Ml0sImVycm9yTWVzc2FnZSI6Ikluc3VmZmljaWVudCBiYWxhbmNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODQzXSwiZXJyb3JNZXNzYWdlIjoiTWludCBjb29sZG93biBhY3RpdmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzksMzAyLDMyNSwzNDcsMzY1LDM4Miw0MDUsNDIzLDQzOSw0NjEsNDgzLDUwNSw1MjMsNTQxXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTEzNl0sImVycm9yTWVzc2FnZSI6Ik9ubHkgY2xhd2JhY2siLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MjRdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGNyZWF0b3IgY2FuIGluaXRpYWxpemUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTIxXSwiZXJyb3JNZXNzYWdlIjoiT25seSBmcmVlemUgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgxN10sImVycm9yTWVzc2FnZSI6Ik9ubHkgbWFuYWdlciBjYW4gbWludCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY5Nl0sImVycm9yTWVzc2FnZSI6Ik9ubHkgbWFuYWdlciBjYW4gc2V0IHdoaXRlbGlzdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgwNl0sImVycm9yTWVzc2FnZSI6IlJlY2VpdmVyIG5vdCBvcHRlZCBpbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNTBdLCJlcnJvck1lc3NhZ2UiOiJSZWNvdmVyeSBsaW1pdCByZWFjaGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjEzXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjgyLDMwNSwzMjgsMzUwLDM2OCwzODUsNDA4LDQyNiw0NDIsNDY0LDQ4Niw1MDgsNTI2LDU0NF0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWRHOXJaVzV6TG1OdmJuUnlZV04wTGtOaGNtSnZia055WldScGRFTnZiblJ5WVdOMExsOWZZV3huYjNCNVgyVnVkSEo1Y0c5cGJuUmZkMmwwYUY5cGJtbDBLQ2tnTFQ0Z2RXbHVkRFkwT2dwdFlXbHVPZ29nSUNBZ2FXNTBZMkpzYjJOcklEQWdNU0E0TmpRd01Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBaVltRnNZVzVqWlNJZ01IZ3hOVEZtTjJNM05TQWlkRzkwWVd4ZmMzVndjR3g1SWlBaWJXbHVkRjlqYjNWdWRDSWdJbkpsWkdWbGJXVmtJaUFpZEc5clpXNWZZWE56WlhSZmFXUWlJQ0p0WVc1aFoyVnlJaUFpWTJGeVltOXVYMk55WldScGRGOXBiblJsY25aaGJDSWdNSGd3TUNBaWJHRnpkRjl0YVc1MElpQWlabkpsWlhwbElpQWlZMnhoZDJKaFkyc2lJQ0ozYUdsMFpXeHBjM1FpSUNKdmNIUmxaRjlwYmlJZ0lteGhjM1JmYldsdWRGOTBhVzFsSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J2YTJWdWN5OWpiMjUwY21GamRDNXdlVG8wQ2lBZ0lDQXZMeUJqYkdGemN5QkRZWEppYjI1RGNtVmthWFJEYjI1MGNtRmpkQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWW1GeVpWOXliM1YwYVc1blFERTVDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRPV1JpTVRjeE1EVWdNSGhoTTJRNE1HWTBNaUF3ZUdFMU9UbGhOalpsSURCNFpHWXhabUUzTldFZ01IaGxNV0ZoT1RFNE15QXdlREF6T0RCbE5UWTFJREI0WmpnNVpHUTJOMlFnTUhnNU5qQmlOakJsTkNBd2VHTmhPRGd4T1RjMklEQjRORFk1TURrek5UVWdNSGhoT0dJMU56ZGtNaUF3ZURSaE5UWTNNbVkzSURCNFlXSTNObVExWVRRZ01IZzJaREkzTTJRMk55QXZMeUJ0WlhSb2IyUWdJbWx1YVhScFlXeHBlbVVvWVdOamIzVnVkQ3hoWTJOdmRXNTBMR0ZqWTI5MWJuUXNZV05qYjNWdWRDeDFhVzUwTmpRc2MzUnlhVzVuTEhOMGNtbHVaeXgxYVc1ME5qUXNjM1J5YVc1bktYVnBiblEyTkNJc0lHMWxkR2h2WkNBaWMyVjBYM2RvYVhSbGJHbHpkQ2hoWTJOdmRXNTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltOXdkRjlwYmw5MWMyVnlLR0Z6YzJWMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1selgzVnpaWEpmYjNCMFpXUmZhVzRvWVdOamIzVnVkQ2xpYjI5c0lpd2diV1YwYUc5a0lDSnRhVzUwWDNSdmEyVnVLSFZwYm5RMk5DeGhZMk52ZFc1MEtYWnZhV1FpTENCdFpYUm9iMlFnSW5SeVlXNXpabVZ5WDNSdmEyVnVLSFZwYm5RMk5DeGhZMk52ZFc1MEtYWnZhV1FpTENCdFpYUm9iMlFnSW5KbFpHVmxiVjkwYjJ0bGJpaDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpY21WamIzWmxjbDkwYjJ0bGJpaHpkSEpwYm1jcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWjJWMFgySmhiR0Z1WTJVb1lXTmpiM1Z1ZENsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGRGOTBiM1JoYkY5emRYQndiSGtvS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWm5KbFpYcGxYMkZqWTI5MWJuUW9ZV05qYjNWdWRDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKamJHRjNZbUZqYTE5MGIydGxibk1vWVdOamIzVnVkQ3gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaVoyVjBYM1Z6WlhKZmNtVmtaVzF3ZEdsdmJuTW9ZV05qYjNWdWRDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltZGxkRjkxYzJWeVgyMXBiblJmWTI5MWJuUW9ZV05qYjNWdWRDbDFhVzUwTmpRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDJsdWFYUnBZV3hwZW1WZmNtOTFkR1ZBTlNCdFlXbHVYM05sZEY5M2FHbDBaV3hwYzNSZmNtOTFkR1ZBTmlCdFlXbHVYMjl3ZEY5cGJsOTFjMlZ5WDNKdmRYUmxRRGNnYldGcGJsOXBjMTkxYzJWeVgyOXdkR1ZrWDJsdVgzSnZkWFJsUURnZ2JXRnBibDl0YVc1MFgzUnZhMlZ1WDNKdmRYUmxRRGtnYldGcGJsOTBjbUZ1YzJabGNsOTBiMnRsYmw5eWIzVjBaVUF4TUNCdFlXbHVYM0psWkdWbGJWOTBiMnRsYmw5eWIzVjBaVUF4TVNCdFlXbHVYM0psWTI5MlpYSmZkRzlyWlc1ZmNtOTFkR1ZBTVRJZ2JXRnBibDluWlhSZlltRnNZVzVqWlY5eWIzVjBaVUF4TXlCdFlXbHVYMmRsZEY5MGIzUmhiRjl6ZFhCd2JIbGZjbTkxZEdWQU1UUWdiV0ZwYmw5bWNtVmxlbVZmWVdOamIzVnVkRjl5YjNWMFpVQXhOU0J0WVdsdVgyTnNZWGRpWVdOclgzUnZhMlZ1YzE5eWIzVjBaVUF4TmlCdFlXbHVYMmRsZEY5MWMyVnlYM0psWkdWdGNIUnBiMjV6WDNKdmRYUmxRREUzSUcxaGFXNWZaMlYwWDNWelpYSmZiV2x1ZEY5amIzVnVkRjl5YjNWMFpVQXhPQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJeE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSdmEyVnVjeTlqYjI1MGNtRmpkQzV3ZVRvMENpQWdJQ0F2THlCamJHRnpjeUJEWVhKaWIyNURjbVZrYVhSRGIyNTBjbUZqZENoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJmZFhObGNsOXRhVzUwWDJOdmRXNTBYM0p2ZFhSbFFERTRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnZhMlZ1Y3k5amIyNTBjbUZqZEM1d2VUb3hOVGtLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnZhMlZ1Y3k5amIyNTBjbUZqZEM1d2VUbzBDaUFnSUNBdkx5QmpiR0Z6Y3lCRFlYSmliMjVEY21Wa2FYUkRiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVhNZ1FXTmpiM1Z1ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYjJ0bGJuTXZZMjl1ZEhKaFkzUXVjSGs2TVRVNUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0JqWVd4c2MzVmlJR2RsZEY5MWMyVnlYMjFwYm5SZlkyOTFiblFLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwWDNWelpYSmZjbVZrWlcxd2RHbHZibk5mY205MWRHVkFNVGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlyWlc1ekwyTnZiblJ5WVdOMExuQjVPakUxTlFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlyWlc1ekwyTnZiblJ5WVdOMExuQjVPalFLSUNBZ0lDOHZJR05zWVhOeklFTmhjbUp2YmtOeVpXUnBkRU52Ym5SeVlXTjBLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aGN5QkJZMk52ZFc1MGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSdmEyVnVjeTlqYjI1MGNtRmpkQzV3ZVRveE5UVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUdOaGJHeHpkV0lnWjJWMFgzVnpaWEpmY21Wa1pXMXdkR2x2Ym5NS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWTJ4aGQySmhZMnRmZEc5clpXNXpYM0p2ZFhSbFFERTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnZhMlZ1Y3k5amIyNTBjbUZqZEM1d2VUb3hOVEFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnZhMlZ1Y3k5amIyNTBjbUZqZEM1d2VUbzBDaUFnSUNBdkx5QmpiR0Z6Y3lCRFlYSmliMjVEY21Wa2FYUkRiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVhNZ1FXTmpiM1Z1ZEhNS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYjJ0bGJuTXZZMjl1ZEhKaFkzUXVjSGs2TVRVd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0JqWVd4c2MzVmlJR05zWVhkaVlXTnJYM1J2YTJWdWN3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5bWNtVmxlbVZmWVdOamIzVnVkRjl5YjNWMFpVQXhOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBiMnRsYm5NdlkyOXVkSEpoWTNRdWNIazZNVFExQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBiMnRsYm5NdlkyOXVkSEpoWTNRdWNIazZOQW9nSUNBZ0x5OGdZMnhoYzNNZ1EyRnlZbTl1UTNKbFpHbDBRMjl1ZEhKaFkzUW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1GeklFRmpZMjkxYm5SekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEc5clpXNXpMMk52Ym5SeVlXTjBMbkI1T2pFME5Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnWTJGc2JITjFZaUJtY21WbGVtVmZZV05qYjNWdWRBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUmZkRzkwWVd4ZmMzVndjR3g1WDNKdmRYUmxRREUwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J2YTJWdWN5OWpiMjUwY21GamRDNXdlVG94TkRFS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQm5aWFJmZEc5MFlXeGZjM1Z3Y0d4NUNpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGOWlZV3hoYm1ObFgzSnZkWFJsUURFek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSdmEyVnVjeTlqYjI1MGNtRmpkQzV3ZVRveE16Y0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSdmEyVnVjeTlqYjI1MGNtRmpkQzV3ZVRvMENpQWdJQ0F2THlCamJHRnpjeUJEWVhKaWIyNURjbVZrYVhSRGIyNTBjbUZqZENoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZWE1nUVdOamIzVnVkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBiMnRsYm5NdlkyOXVkSEpoWTNRdWNIazZNVE0zQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQmpZV3hzYzNWaUlHZGxkRjlpWVd4aGJtTmxDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzSmxZMjkyWlhKZmRHOXJaVzVmY205MWRHVkFNVEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlyWlc1ekwyTnZiblJ5WVdOMExuQjVPakV5TkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlyWlc1ekwyTnZiblJ5WVdOMExuQjVPalFLSUNBZ0lDOHZJR05zWVhOeklFTmhjbUp2YmtOeVpXUnBkRU52Ym5SeVlXTjBLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J2YTJWdWN5OWpiMjUwY21GamRDNXdlVG94TWpRS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRS0lDQWdJR05oYkd4emRXSWdjbVZqYjNabGNsOTBiMnRsYmdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl5WldSbFpXMWZkRzlyWlc1ZmNtOTFkR1ZBTVRFNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEc5clpXNXpMMk52Ym5SeVlXTjBMbkI1T2pFeE13b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEc5clpXNXpMMk52Ym5SeVlXTjBMbkI1T2pRS0lDQWdJQzh2SUdOc1lYTnpJRU5oY21KdmJrTnlaV1JwZEVOdmJuUnlZV04wS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzV6TDJOdmJuUnlZV04wTG5CNU9qRXhNd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ1kyRnNiSE4xWWlCeVpXUmxaVzFmZEc5clpXNEtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRISmhibk5tWlhKZmRHOXJaVzVmY205MWRHVkFNVEE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlyWlc1ekwyTnZiblJ5WVdOMExuQjVPams1Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBiMnRsYm5NdlkyOXVkSEpoWTNRdWNIazZOQW9nSUNBZ0x5OGdZMnhoYzNNZ1EyRnlZbTl1UTNKbFpHbDBRMjl1ZEhKaFkzUW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1GeklFRmpZMjkxYm5SekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEc5clpXNXpMMk52Ym5SeVlXTjBMbkI1T2prNUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0JqWVd4c2MzVmlJSFJ5WVc1elptVnlYM1J2YTJWdUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDIxcGJuUmZkRzlyWlc1ZmNtOTFkR1ZBT1RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYjJ0bGJuTXZZMjl1ZEhKaFkzUXVjSGs2T0RBS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J2YTJWdWN5OWpiMjUwY21GamRDNXdlVG8wQ2lBZ0lDQXZMeUJqYkdGemN5QkRZWEppYjI1RGNtVmthWFJEYjI1MGNtRmpkQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlYTWdRV05qYjNWdWRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGIydGxibk12WTI5dWRISmhZM1F1Y0hrNk9EQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUdOaGJHeHpkV0lnYldsdWRGOTBiMnRsYmdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlwYzE5MWMyVnlYMjl3ZEdWa1gybHVYM0p2ZFhSbFFEZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzV6TDJOdmJuUnlZV04wTG5CNU9qYzFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYjJ0bGJuTXZZMjl1ZEhKaFkzUXVjSGs2TkFvZ0lDQWdMeThnWTJ4aGMzTWdRMkZ5WW05dVEzSmxaR2wwUTI5dWRISmhZM1FvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRnpJRUZqWTI5MWJuUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzV6TDJOdmJuUnlZV04wTG5CNU9qYzFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JqWVd4c2MzVmlJR2x6WDNWelpYSmZiM0IwWldSZmFXNEtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmIzQjBYMmx1WDNWelpYSmZjbTkxZEdWQU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGIydGxibk12WTI5dWRISmhZM1F1Y0hrNk5UUUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSdmEyVnVjeTlqYjI1MGNtRmpkQzV3ZVRvMENpQWdJQ0F2THlCamJHRnpjeUJEWVhKaWIyNURjbVZrYVhSRGIyNTBjbUZqZENoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZWE1nUVhOelpYUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzV6TDJOdmJuUnlZV04wTG5CNU9qVTBDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCallXeHNjM1ZpSUc5d2RGOXBibDkxYzJWeUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNObGRGOTNhR2wwWld4cGMzUmZjbTkxZEdWQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGIydGxibk12WTI5dWRISmhZM1F1Y0hrNk5Ea0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSdmEyVnVjeTlqYjI1MGNtRmpkQzV3ZVRvMENpQWdJQ0F2THlCamJHRnpjeUJEWVhKaWIyNURjbVZrYVhSRGIyNTBjbUZqZENoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZWE1nUVdOamIzVnVkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBiMnRsYm5NdlkyOXVkSEpoWTNRdWNIazZORGtLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lHTmhiR3h6ZFdJZ2MyVjBYM2RvYVhSbGJHbHpkQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXBibWwwYVdGc2FYcGxYM0p2ZFhSbFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzV6TDJOdmJuUnlZV04wTG5CNU9qSTFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGIydGxibk12WTI5dWRISmhZM1F1Y0hrNk5Bb2dJQ0FnTHk4Z1kyeGhjM01nUTJGeVltOXVRM0psWkdsMFEyOXVkSEpoWTNRb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUZ6SUVGalkyOTFiblJ6Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoY3lCQlkyTnZkVzUwY3dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVhNZ1FXTmpiM1Z1ZEhNS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1GeklFRmpZMjkxYm5SekNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMUNpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMkNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTndvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRGdLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRGtLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzV6TDJOdmJuUnlZV04wTG5CNU9qSTFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCallXeHNjM1ZpSUdsdWFYUnBZV3hwZW1VS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWW1GeVpWOXliM1YwYVc1blFERTVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnZhMlZ1Y3k5amIyNTBjbUZqZEM1d2VUbzBDaUFnSUNBdkx5QmpiR0Z6Y3lCRFlYSmliMjVEY21Wa2FYUkRiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlNUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdZM0psWVhScGJtY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11ZEc5clpXNXpMbU52Ym5SeVlXTjBMa05oY21KdmJrTnlaV1JwZEVOdmJuUnlZV04wTG1sdWFYUnBZV3hwZW1Vb2JXRnVZV2RsY2pvZ1lubDBaWE1zSUhKbGMyVnlkbVU2SUdKNWRHVnpMQ0JtY21WbGVtVTZJR0o1ZEdWekxDQmpiR0YzWW1GamF6b2dZbmwwWlhNc0lIUnZkR0ZzWDNOMWNIQnNlVG9nZFdsdWREWTBMQ0JoYzNObGRGOXVZVzFsT2lCaWVYUmxjeXdnZFc1cGRGOXVZVzFsT2lCaWVYUmxjeXdnWkdWamFXMWhiSE02SUhWcGJuUTJOQ3dnZFhKc09pQmllWFJsY3lrZ0xUNGdkV2x1ZERZME9ncHBibWwwYVdGc2FYcGxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnZhMlZ1Y3k5amIyNTBjbUZqZEM1d2VUb3lOUzB6TndvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdMeThnWkdWbUlHbHVhWFJwWVd4cGVtVW9DaUFnSUNBdkx5QWdJQ0FnYzJWc1ppd0tJQ0FnSUM4dklDQWdJQ0J0WVc1aFoyVnlPaUJCWTJOdmRXNTBMQW9nSUNBZ0x5OGdJQ0FnSUhKbGMyVnlkbVU2SUVGalkyOTFiblFzQ2lBZ0lDQXZMeUFnSUNBZ1puSmxaWHBsT2lCQlkyTnZkVzUwTEFvZ0lDQWdMeThnSUNBZ0lHTnNZWGRpWVdOck9pQkJZMk52ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJSFJ2ZEdGc1gzTjFjSEJzZVRvZ1ZVbHVkRFkwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDI1aGJXVTZJRk4wY21sdVp5d0tJQ0FnSUM4dklDQWdJQ0IxYm1sMFgyNWhiV1U2SUZOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCa1pXTnBiV0ZzY3pvZ1ZVbHVkRFkwTEFvZ0lDQWdMeThnSUNBZ0lIVnliRG9nVTNSeWFXNW5DaUFnSUNBdkx5QXBJQzArSUZWSmJuUTJORG9LSUNBZ0lIQnliM1J2SURrZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSdmEyVnVjeTlqYjI1MGNtRmpkQzV3ZVRvek9Bb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdSMnh2WW1Gc0xtTnlaV0YwYjNKZllXUmtjbVZ6Y3l3Z0lrOXViSGtnWTNKbFlYUnZjaUJqWVc0Z2FXNXBkR2xoYkdsNlpTSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2RzYjJKaGJDQkRjbVZoZEc5eVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUdOeVpXRjBiM0lnWTJGdUlHbHVhWFJwWVd4cGVtVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGIydGxibk12WTI5dWRISmhZM1F1Y0hrNk16a0tJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MblJ2YTJWdVgyRnpjMlYwWDJsa0xtZGxkQ2hWU1c1ME5qUW9NQ2twSUQwOUlGVkpiblEyTkNnd0tTd2dJa0ZzY21WaFpIa2dhVzVwZEdsaGJHbDZaV1FpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTlNBdkx5QWlkRzlyWlc1ZllYTnpaWFJmYVdRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFRnNjbVZoWkhrZ2FXNXBkR2xoYkdsNlpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGIydGxibk12WTI5dWRISmhZM1F1Y0hrNk5ERUtJQ0FnSUM4dklITmxiR1l1ZEc5clpXNWZZWE56WlhSZmFXUXVkbUZzZFdVZ1BTQlZTVzUwTmpRb01Ta0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z0luUnZhMlZ1WDJGemMyVjBYMmxrSWdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlyWlc1ekwyTnZiblJ5WVdOMExuQjVPalF5Q2lBZ0lDQXZMeUJ6Wld4bUxuUnZkR0ZzWDNOMWNIQnNlUzUyWVd4MVpTQTlJSFJ2ZEdGc1gzTjFjSEJzZVFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpZEc5MFlXeGZjM1Z3Y0d4NUlnb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSdmEyVnVjeTlqYjI1MGNtRmpkQzV3ZVRvME13b2dJQ0FnTHk4Z2MyVnNaaTV0WVc1aFoyVnlMblpoYkhWbElEMGdiV0Z1WVdkbGNnb2dJQ0FnWW5sMFpXTWdOaUF2THlBaWJXRnVZV2RsY2lJS0lDQWdJR1p5WVcxbFgyUnBaeUF0T1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYjJ0bGJuTXZZMjl1ZEhKaFkzUXVjSGs2TkRRS0lDQWdJQzh2SUhObGJHWXVjbVZ6WlhKMlpTNTJZV3gxWlNBOUlISmxjMlZ5ZG1VS0lDQWdJSEIxYzJoaWVYUmxjeUFpY21WelpYSjJaU0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRPQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBiMnRsYm5NdlkyOXVkSEpoWTNRdWNIazZORFVLSUNBZ0lDOHZJSE5sYkdZdVpuSmxaWHBsTG5aaGJIVmxJRDBnWm5KbFpYcGxDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QWlabkpsWlhwbElnb2dJQ0FnWm5KaGJXVmZaR2xuSUMwM0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSdmEyVnVjeTlqYjI1MGNtRmpkQzV3ZVRvME5nb2dJQ0FnTHk4Z2MyVnNaaTVqYkdGM1ltRmpheTUyWVd4MVpTQTlJR05zWVhkaVlXTnJDaUFnSUNCaWVYUmxZeUF4TVNBdkx5QWlZMnhoZDJKaFkyc2lDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUWUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzV6TDJOdmJuUnlZV04wTG5CNU9qUTNDaUFnSUNBdkx5QnpaV3htTG1OaGNtSnZibDlqY21Wa2FYUmZhVzUwWlhKMllXd3VkbUZzZFdVZ1BTQlZTVzUwTmpRb09EWTBNREFwQ2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0pqWVhKaWIyNWZZM0psWkdsMFgybHVkR1Z5ZG1Gc0lnb2dJQ0FnYVc1MFkxOHlJQzh2SURnMk5EQXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnZhMlZ1Y3k5amIyNTBjbUZqZEM1d2VUbzBPQW9nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1ZEc5clpXNWZZWE56WlhSZmFXUXVaMlYwS0ZWSmJuUTJOQ2d3S1NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0owYjJ0bGJsOWhjM05sZEY5cFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11ZEc5clpXNXpMbU52Ym5SeVlXTjBMa05oY21KdmJrTnlaV1JwZEVOdmJuUnlZV04wTG5ObGRGOTNhR2wwWld4cGMzUW9ZV1JrY21WemN6b2dZbmwwWlhNcElDMCtJSFp2YVdRNkNuTmxkRjkzYUdsMFpXeHBjM1E2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlyWlc1ekwyTnZiblJ5WVdOMExuQjVPalE1TFRVd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0F2THlCa1pXWWdjMlYwWDNkb2FYUmxiR2x6ZENoelpXeG1MQ0JoWkdSeVpYTnpPaUJCWTJOdmRXNTBLU0F0UGlCT2IyNWxPZ29nSUNBZ2NISnZkRzhnTVNBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEc5clpXNXpMMk52Ym5SeVlXTjBMbkI1T2pVeENpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQnpaV3htTG0xaGJtRm5aWEl1WjJWMEtFRmpZMjkxYm5Rb0tTa3NJQ0pQYm14NUlHMWhibUZuWlhJZ1kyRnVJSE5sZENCM2FHbDBaV3hwYzNRaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKdFlXNWhaMlZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUhObGJHVmpkQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJRzFoYm1GblpYSWdZMkZ1SUhObGRDQjNhR2wwWld4cGMzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGIydGxibk12WTI5dWRISmhZM1F1Y0hrNk5USUtJQ0FnSUM4dklITmxiR1l1ZDJocGRHVnNhWE4wTG5aaGJIVmxJRDBnWVdSa2NtVnpjd29nSUNBZ1lubDBaV01nTVRJZ0x5OGdJbmRvYVhSbGJHbHpkQ0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NTBiMnRsYm5NdVkyOXVkSEpoWTNRdVEyRnlZbTl1UTNKbFpHbDBRMjl1ZEhKaFkzUXViM0IwWDJsdVgzVnpaWElvWVhOelpYUTZJSFZwYm5RMk5Da2dMVDRnZG05cFpEb0tiM0IwWDJsdVgzVnpaWEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlyWlc1ekwyTnZiblJ5WVdOMExuQjVPalUwTFRVMUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0F2THlCa1pXWWdiM0IwWDJsdVgzVnpaWElvYzJWc1ppd2dZWE56WlhRNklFRnpjMlYwS1NBdFBpQk9iMjVsT2dvZ0lDQWdjSEp2ZEc4Z01TQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzV6TDJOdmJuUnlZV04wTG5CNU9qVTJDaUFnSUNBdkx5QnpaVzVrWlhJZ1BTQlVlRzR1YzJWdVpHVnlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYjJ0bGJuTXZZMjl1ZEhKaFkzUXVjSGs2TlRndE5Ua0tJQ0FnSUM4dklDTWdTVzVwZEdsaGJHbDZaU0IxYzJWeUozTWdiRzlqWVd3Z2MzUmhkR1VnYVdZZ2JtOTBJR0ZzY21WaFpIa2daRzl1WlFvZ0lDQWdMeThnYVdZZ2JtOTBJSE5sYkdZdWIzQjBaV1JmYVc0dVoyVjBLSE5sYm1SbGNpd2dRbTl2YkNoR1lXeHpaU2twT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFeklDOHZJQ0p2Y0hSbFpGOXBiaUlLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR0o1ZEdWaklEZ2dMeThnTUhnd01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmllWFJsWXlBNElDOHZJREI0TURBS0lDQWdJRDA5Q2lBZ0lDQmllaUJ2Y0hSZmFXNWZkWE5sY2w5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBiMnRsYm5NdlkyOXVkSEpoWTNRdWNIazZOakFLSUNBZ0lDOHZJSE5sYkdZdWRYTmxjbDlpWVd4aGJtTmxXM05sYm1SbGNsMGdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCa2RYQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSmhiR0Z1WTJVaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J2YTJWdWN5OWpiMjUwY21GamRDNXdlVG8yTVFvZ0lDQWdMeThnYzJWc1ppNTFjMlZ5WDJ4aGMzUmZiV2x1ZEZ0elpXNWtaWEpkSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JrZFhBS0lDQWdJR0o1ZEdWaklEa2dMeThnSW14aGMzUmZiV2x1ZENJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlyWlc1ekwyTnZiblJ5WVdOMExuQjVPall5Q2lBZ0lDQXZMeUJ6Wld4bUxuVnpaWEpmYldsdWRGOWpiM1Z1ZEZ0elpXNWtaWEpkSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JrZFhBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW0xcGJuUmZZMjkxYm5RaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J2YTJWdWN5OWpiMjUwY21GamRDNXdlVG8yTXdvZ0lDQWdMeThnYzJWc1ppNTFjMlZ5WDNKbFpHVnRjSFJwYjI1ZlkyOTFiblJiYzJWdVpHVnlYU0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdaSFZ3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0p5WldSbFpXMWxaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzV6TDJOdmJuUnlZV04wTG5CNU9qWTBDaUFnSUNBdkx5QnpaV3htTG5WelpYSmZkRzlyWlc1ZmFHbHpkRzl5ZVZ0elpXNWtaWEpkSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJoaWVYUmxjeUFpYUdsemRHOXllU0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzV6TDJOdmJuUnlZV04wTG5CNU9qWTFDaUFnSUNBdkx5QnpaV3htTG05d2RHVmtYMmx1VzNObGJtUmxjbDBnUFNCQ2IyOXNLRlJ5ZFdVcENpQWdJQ0JpZVhSbFl5QXhNeUF2THlBaWIzQjBaV1JmYVc0aUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnNE1Bb2dJQ0FnWVhCd1gyeHZZMkZzWDNCMWRBb0tiM0IwWDJsdVgzVnpaWEpmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnZhMlZ1Y3k5amIyNTBjbUZqZEM1d2VUbzJOeTAzTXdvZ0lDQWdMeThnSXlCRGNtVmhkR1VnWVhOelpYUWdiM0IwTFdsdUlIUnlZVzV6WVdOMGFXOXVDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZjbVZqWldsMlpYSTljMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKZllYTnpaWFE5WVhOelpYUXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZZVzF2ZFc1MFBWVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0JtWldVOVZVbHVkRFkwS0RBcENpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlyWlc1ekwyTnZiblJ5WVdOMExuQjVPamN4Q2lBZ0lDQXZMeUJoYzNObGRGOWhiVzkxYm5ROVZVbHVkRFkwS0RBcExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUkJiVzkxYm5RS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JZWm1WeVFYTnpaWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwVW1WalpXbDJaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBiMnRsYm5NdlkyOXVkSEpoWTNRdWNIazZOamN0TmpnS0lDQWdJQzh2SUNNZ1EzSmxZWFJsSUdGemMyVjBJRzl3ZEMxcGJpQjBjbUZ1YzJGamRHbHZiZ29nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ2NIVnphR2x1ZENBMElDOHZJR0Y0Wm1WeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlyWlc1ekwyTnZiblJ5WVdOMExuQjVPamN5Q2lBZ0lDQXZMeUJtWldVOVZVbHVkRFkwS0RBcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYjJ0bGJuTXZZMjl1ZEhKaFkzUXVjSGs2TmpjdE56TUtJQ0FnSUM4dklDTWdRM0psWVhSbElHRnpjMlYwSUc5d2RDMXBiaUIwY21GdWMyRmpkR2x2YmdvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDNKbFkyVnBkbVZ5UFhObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBXRnpjMlYwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVlZKYm5RMk5DZ3dLUW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1MGIydGxibk11WTI5dWRISmhZM1F1UTJGeVltOXVRM0psWkdsMFEyOXVkSEpoWTNRdWFYTmZkWE5sY2w5dmNIUmxaRjlwYmloMWMyVnlPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbWx6WDNWelpYSmZiM0IwWldSZmFXNDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzV6TDJOdmJuUnlZV04wTG5CNU9qYzFMVGMyQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNBdkx5QmtaV1lnYVhOZmRYTmxjbDl2Y0hSbFpGOXBiaWh6Wld4bUxDQjFjMlZ5T2lCQlkyTnZkVzUwS1NBdFBpQkNiMjlzT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzV6TDJOdmJuUnlZV04wTG5CNU9qYzNMVGM0Q2lBZ0lDQXZMeUFqSUVOb1pXTnJJR2xtSUhSb1pTQjFjMlZ5SUdseklHOXdkR1ZrSUdsdUlIUnZJSFJvWlNCaGNIQnNhV05oZEdsdmJnb2dJQ0FnTHk4Z2NtVjBkWEp1SUVKdmIyd29iM0F1WVhCd1gyOXdkR1ZrWDJsdUtIVnpaWElzSUVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJsa0tTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjSEJmYjNCMFpXUmZhVzRLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWRHOXJaVzV6TG1OdmJuUnlZV04wTGtOaGNtSnZia055WldScGRFTnZiblJ5WVdOMExtMXBiblJmZEc5clpXNG9ZVzF2ZFc1ME9pQjFhVzUwTmpRc0lISmxZMlZwZG1WeU9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS2JXbHVkRjkwYjJ0bGJqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGIydGxibk12WTI5dWRISmhZM1F1Y0hrNk9EQXRPREVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lDOHZJR1JsWmlCdGFXNTBYM1J2YTJWdUtITmxiR1lzSUdGdGIzVnVkRG9nVlVsdWREWTBMQ0J5WldObGFYWmxjam9nUVdOamIzVnVkQ2tnTFQ0Z1RtOXVaVG9LSUNBZ0lIQnliM1J2SURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSdmEyVnVjeTlqYjI1MGNtRmpkQzV3ZVRvNE1pMDRNd29nSUNBZ0x5OGdJeUJGYm5OMWNtVWdjbVZqWldsMlpYSWdhWE1nYjNCMFpXUWdhVzRnZEc4Z2RHaGxJR0Z3Y0d4cFkyRjBhVzl1Q2lBZ0lDQXZMeUJoYzNObGNuUWdiM0F1WVhCd1gyOXdkR1ZrWDJsdUtISmxZMlZwZG1WeUxDQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOXBaQ2tzSUNKU1pXTmxhWFpsY2lCdWIzUWdiM0IwWldRZ2FXNGlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWEJ3WDI5d2RHVmtYMmx1Q2lBZ0lDQmhjM05sY25RZ0x5OGdVbVZqWldsMlpYSWdibTkwSUc5d2RHVmtJR2x1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlyWlc1ekwyTnZiblJ5WVdOMExuQjVPamcwQ2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCelpXeG1MbTFoYm1GblpYSXVaMlYwS0VGalkyOTFiblFvS1Nrc0lDSlBibXg1SUcxaGJtRm5aWElnWTJGdUlHMXBiblFpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMklDOHZJQ0p0WVc1aFoyVnlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJSE5sYkdWamRBb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHMWhibUZuWlhJZ1kyRnVJRzFwYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYjJ0bGJuTXZZMjl1ZEhKaFkzUXVjSGs2T0RVS0lDQWdJQzh2SUdGemMyVnlkQ0JoYlc5MWJuUWdQaUJWU1c1ME5qUW9NQ2tzSUNKQmJXOTFiblFnYlhWemRDQmlaU0J3YjNOcGRHbDJaU0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1lYTnpaWEowSUM4dklFRnRiM1Z1ZENCdGRYTjBJR0psSUhCdmMybDBhWFpsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlyWlc1ekwyTnZiblJ5WVdOMExuQjVPamczQ2lBZ0lDQXZMeUJqZFhKeVpXNTBYM1JwYldVZ1BTQkhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0FvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J2YTJWdWN5OWpiMjUwY21GamRDNXdlVG80T0FvZ0lDQWdMeThnYkdGemRGOXRhVzUwSUQwZ2MyVnNaaTVzWVhOMFgyMXBiblJmZEdsdFpTNW5aWFFvVlVsdWREWTBLREFwS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFMElDOHZJQ0pzWVhOMFgyMXBiblJmZEdsdFpTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEc5clpXNXpMMk52Ym5SeVlXTjBMbkI1T2pnNUNpQWdJQ0F2THlCcGJuUmxjblpoYkNBOUlITmxiR1l1WTJGeVltOXVYMk55WldScGRGOXBiblJsY25aaGJDNW5aWFFvVlVsdWREWTBLRGcyTkRBd0tTa2dJQ01nWm1Gc2JHSmhZMnNnWkdWbVlYVnNkQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0ltTmhjbUp2Ymw5amNtVmthWFJmYVc1MFpYSjJZV3dpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnYVc1MFkxOHlJQzh2SURnMk5EQXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYjJ0bGJuTXZZMjl1ZEhKaFkzUXVjSGs2T1RBS0lDQWdJQzh2SUdGemMyVnlkQ0JqZFhKeVpXNTBYM1JwYldVZ1BqMGdiR0Z6ZEY5dGFXNTBJQ3NnYVc1MFpYSjJZV3dzSUNKTmFXNTBJR052YjJ4a2IzZHVJR0ZqZEdsMlpTSUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRTFwYm5RZ1kyOXZiR1J2ZDI0Z1lXTjBhWFpsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlyWlc1ekwyTnZiblJ5WVdOMExuQjVPamt5Q2lBZ0lDQXZMeUJ1WlhkZmMzVndjR3g1SUQwZ2MyVnNaaTUwYjNSaGJGOXpkWEJ3YkhrdVoyVjBLRlZKYm5RMk5DZ3dLU2tnS3lCaGJXOTFiblFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSjBiM1JoYkY5emRYQndiSGtpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNBckNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEc5clpXNXpMMk52Ym5SeVlXTjBMbkI1T2prekNpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gzTjFjSEJzZVM1MllXeDFaU0E5SUc1bGQxOXpkWEJ3YkhrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5SdmRHRnNYM04xY0hCc2VTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzV6TDJOdmJuUnlZV04wTG5CNU9qazBDaUFnSUNBdkx5QnpaV3htTG14aGMzUmZiV2x1ZEY5MGFXMWxMblpoYkhWbElEMGdZM1Z5Y21WdWRGOTBhVzFsQ2lBZ0lDQmllWFJsWXlBeE5DQXZMeUFpYkdGemRGOXRhVzUwWDNScGJXVWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnZhMlZ1Y3k5amIyNTBjbUZqZEM1d2VUbzVOZ29nSUNBZ0x5OGdZbUZzWVc1alpTQTlJSE5sYkdZdWRYTmxjbDlpWVd4aGJtTmxMbWRsZENoeVpXTmxhWFpsY2l3Z1ZVbHVkRFkwS0RBcEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW1Gc1lXNWpaU0lLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGIydGxibk12WTI5dWRISmhZM1F1Y0hrNk9UY0tJQ0FnSUM4dklITmxiR1l1ZFhObGNsOWlZV3hoYm1ObFczSmxZMlZwZG1WeVhTQTlJR0poYkdGdVkyVWdLeUJoYlc5MWJuUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnS3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppWVd4aGJtTmxJZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoY0hCZmJHOWpZV3hmY0hWMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11ZEc5clpXNXpMbU52Ym5SeVlXTjBMa05oY21KdmJrTnlaV1JwZEVOdmJuUnlZV04wTG5SeVlXNXpabVZ5WDNSdmEyVnVLR0Z0YjNWdWREb2dkV2x1ZERZMExDQnlaV05sYVhabGNqb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNuUnlZVzV6Wm1WeVgzUnZhMlZ1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J2YTJWdWN5OWpiMjUwY21GamRDNXdlVG81T1MweE1EQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUM4dklHUmxaaUIwY21GdWMyWmxjbDkwYjJ0bGJpaHpaV3htTENCaGJXOTFiblE2SUZWSmJuUTJOQ3dnY21WalpXbDJaWEk2SUVGalkyOTFiblFwSUMwK0lFNXZibVU2Q2lBZ0lDQndjbTkwYnlBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGIydGxibk12WTI5dWRISmhZM1F1Y0hrNk1UQXhDaUFnSUNBdkx5QnpaVzVrWlhJZ1BTQlVlRzR1YzJWdVpHVnlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEc5clpXNXpMMk52Ym5SeVlXTjBMbkI1T2pFd01nb2dJQ0FnTHk4Z2QyaHBkR1ZzYVhOMElEMGdjMlZzWmk1M2FHbDBaV3hwYzNRdVoyVjBLRUZqWTI5MWJuUW9LU2tLSUNBZ0lHZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERXlJQzh2SUNKM2FHbDBaV3hwYzNRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ2MyVnNaV04wQ2lBZ0lDQmtkWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBiMnRsYm5NdlkyOXVkSEpoWTNRdWNIazZNVEF6Q2lBZ0lDQXZMeUJwWmlCM2FHbDBaV3hwYzNRNkNpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lDRTlDaUFnSUNCaWVpQjBjbUZ1YzJabGNsOTBiMnRsYmw5aFpuUmxjbDlwWmw5bGJITmxRRFlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBiMnRsYm5NdlkyOXVkSEpoWTNRdWNIazZNVEEwQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZ1WkdWeUlEMDlJSGRvYVhSbGJHbHpkQ0J2Y2lCeVpXTmxhWFpsY2lBOVBTQjNhR2wwWld4cGMzUXNJQ0pCWkdSeVpYTnpJRzV2ZENCM2FHbDBaV3hwYzNSbFpDSUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdQVDBLSUNBZ0lHSnVlaUIwY21GdWMyWmxjbDkwYjJ0bGJsOWliMjlzWDNSeWRXVkFNd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnUFQwS0lDQWdJR0o2SUhSeVlXNXpabVZ5WDNSdmEyVnVYMkp2YjJ4ZlptRnNjMlZBTkFvS2RISmhibk5tWlhKZmRHOXJaVzVmWW05dmJGOTBjblZsUURNNkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvS2RISmhibk5tWlhKZmRHOXJaVzVmWW05dmJGOXRaWEpuWlVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSdmEyVnVjeTlqYjI1MGNtRmpkQzV3ZVRveE1EUUtJQ0FnSUM4dklHRnpjMlZ5ZENCelpXNWtaWElnUFQwZ2QyaHBkR1ZzYVhOMElHOXlJSEpsWTJWcGRtVnlJRDA5SUhkb2FYUmxiR2x6ZEN3Z0lrRmtaSEpsYzNNZ2JtOTBJSGRvYVhSbGJHbHpkR1ZrSWdvZ0lDQWdZWE56WlhKMElDOHZJRUZrWkhKbGMzTWdibTkwSUhkb2FYUmxiR2x6ZEdWa0NncDBjbUZ1YzJabGNsOTBiMnRsYmw5aFpuUmxjbDlwWmw5bGJITmxRRFk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlyWlc1ekwyTnZiblJ5WVdOMExuQjVPakV3TmdvZ0lDQWdMeThnYzJWdVpHVnlYMkpoYkdGdVkyVWdQU0J6Wld4bUxuVnpaWEpmWW1Gc1lXNWpaUzVuWlhRb2MyVnVaR1Z5TENCVlNXNTBOalFvTUNrcENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZbUZzWVc1alpTSUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYjJ0bGJuTXZZMjl1ZEhKaFkzUXVjSGs2TVRBM0NpQWdJQ0F2THlCaGMzTmxjblFnYzJWdVpHVnlYMkpoYkdGdVkyVWdQajBnWVcxdmRXNTBMQ0FpU1c1emRXWm1hV05wWlc1MElHSmhiR0Z1WTJVaUNpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdQajBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qkpibk4xWm1acFkybGxiblFnWW1Gc1lXNWpaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnZhMlZ1Y3k5amIyNTBjbUZqZEM1d2VUb3hNRGtLSUNBZ0lDOHZJSEpsWTJWcGRtVnlYMkpoYkdGdVkyVWdQU0J6Wld4bUxuVnpaWEpmWW1Gc1lXNWpaUzVuWlhRb2NtVmpaV2wyWlhJc0lGVkpiblEyTkNnd0tTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KaGJHRnVZMlVpQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzV6TDJOdmJuUnlZV04wTG5CNU9qRXhNQW9nSUNBZ0x5OGdjMlZzWmk1MWMyVnlYMkpoYkdGdVkyVmJjMlZ1WkdWeVhTQTlJSE5sYm1SbGNsOWlZV3hoYm1ObElDMGdZVzF2ZFc1MENpQWdJQ0J6ZDJGd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJQzBLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltRnNZVzVqWlNJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lYQndYMnh2WTJGc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnZhMlZ1Y3k5amIyNTBjbUZqZEM1d2VUb3hNVEVLSUNBZ0lDOHZJSE5sYkdZdWRYTmxjbDlpWVd4aGJtTmxXM0psWTJWcGRtVnlYU0E5SUhKbFkyVnBkbVZ5WDJKaGJHRnVZMlVnS3lCaGJXOTFiblFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ0t3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaVlXeGhibU5sSWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ25SeVlXNXpabVZ5WDNSdmEyVnVYMkp2YjJ4ZlptRnNjMlZBTkRvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJSFJ5WVc1elptVnlYM1J2YTJWdVgySnZiMnhmYldWeVoyVkFOUW9LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1MGIydGxibk11WTI5dWRISmhZM1F1UTJGeVltOXVRM0psWkdsMFEyOXVkSEpoWTNRdWNtVmtaV1Z0WDNSdmEyVnVLR0Z0YjNWdWREb2dkV2x1ZERZMEtTQXRQaUIyYjJsa09ncHlaV1JsWlcxZmRHOXJaVzQ2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlyWlc1ekwyTnZiblJ5WVdOMExuQjVPakV4TXkweE1UUUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUM4dklHUmxaaUJ5WldSbFpXMWZkRzlyWlc0b2MyVnNaaXdnWVcxdmRXNTBPaUJWU1c1ME5qUXBJQzArSUU1dmJtVTZDaUFnSUNCd2NtOTBieUF4SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYjJ0bGJuTXZZMjl1ZEhKaFkzUXVjSGs2TVRFMUNpQWdJQ0F2THlCelpXNWtaWElnUFNCVWVHNHVjMlZ1WkdWeUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlyWlc1ekwyTnZiblJ5WVdOMExuQjVPakV4TmdvZ0lDQWdMeThnWW1Gc1lXNWpaU0E5SUhObGJHWXVkWE5sY2w5aVlXeGhibU5sTG1kbGRDaHpaVzVrWlhJc0lGVkpiblEyTkNnd0tTa0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KaGJHRnVZMlVpQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzV6TDJOdmJuUnlZV04wTG5CNU9qRXhOd29nSUNBZ0x5OGdZWE56WlhKMElHSmhiR0Z1WTJVZ1BqMGdZVzF2ZFc1MExDQWlTVzV6ZFdabWFXTnBaVzUwSUdKaGJHRnVZMlVpQ2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1BqMEtJQ0FnSUdGemMyVnlkQ0F2THlCSmJuTjFabVpwWTJsbGJuUWdZbUZzWVc1alpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSdmEyVnVjeTlqYjI1MGNtRmpkQzV3ZVRveE1Ua0tJQ0FnSUM4dklITmxiR1l1ZFhObGNsOWlZV3hoYm1ObFczTmxibVJsY2wwZ1BTQmlZV3hoYm1ObElDMGdZVzF2ZFc1MENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJQzBLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppWVd4aGJtTmxJZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoY0hCZmJHOWpZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEc5clpXNXpMMk52Ym5SeVlXTjBMbkI1T2pFeU1Bb2dJQ0FnTHk4Z2NtVmtaV1Z0WldRZ1BTQnpaV3htTG5WelpYSmZjbVZrWlcxd2RHbHZibDlqYjNWdWRDNW5aWFFvYzJWdVpHVnlMQ0JWU1c1ME5qUW9NQ2twQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSnlaV1JsWlcxbFpDSUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYjJ0bGJuTXZZMjl1ZEhKaFkzUXVjSGs2TVRJeENpQWdJQ0F2THlCelpXeG1MblZ6WlhKZmNtVmtaVzF3ZEdsdmJsOWpiM1Z1ZEZ0elpXNWtaWEpkSUQwZ2NtVmtaV1Z0WldRZ0t5QmhiVzkxYm5RS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdLd29nSUNBZ1lubDBaV01nTkNBdkx5QWljbVZrWldWdFpXUWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzV6TDJOdmJuUnlZV04wTG5CNU9qRXlNZ29nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjl6ZFhCd2JIa3VkbUZzZFdVZ1BTQnpaV3htTG5SdmRHRnNYM04xY0hCc2VTNW5aWFFvVlVsdWREWTBLREFwS1NBdElHRnRiM1Z1ZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJblJ2ZEdGc1gzTjFjSEJzZVNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lDMEtJQ0FnSUdKNWRHVmpYeklnTHk4Z0luUnZkR0ZzWDNOMWNIQnNlU0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVkRzlyWlc1ekxtTnZiblJ5WVdOMExrTmhjbUp2YmtOeVpXUnBkRU52Ym5SeVlXTjBMbkpsWTI5MlpYSmZkRzlyWlc0b2RYTmxjbDlwWkRvZ1lubDBaWE1wSUMwK0lIWnZhV1E2Q25KbFkyOTJaWEpmZEc5clpXNDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzV6TDJOdmJuUnlZV04wTG5CNU9qRXlOQzB4TWpVS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRS0lDQWdJQzh2SUdSbFppQnlaV052ZG1WeVgzUnZhMlZ1S0hObGJHWXNJSFZ6WlhKZmFXUTZJRk4wY21sdVp5a2dMVDRnVG05dVpUb0tJQ0FnSUhCeWIzUnZJREVnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J2YTJWdWN5OWpiMjUwY21GamRDNXdlVG94TWpZS0lDQWdJQzh2SUhObGJtUmxjaUE5SUZSNGJpNXpaVzVrWlhJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBiMnRsYm5NdlkyOXVkSEpoWTNRdWNIazZNVEkzQ2lBZ0lDQXZMeUJ0YVc1MFgyTnZkVzUwSUQwZ2MyVnNaaTUxYzJWeVgyMXBiblJmWTI5MWJuUXVaMlYwS0hObGJtUmxjaXdnVlVsdWREWTBLREFwS1FvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWliV2x1ZEY5amIzVnVkQ0lLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGIydGxibk12WTI5dWRISmhZM1F1Y0hrNk1USTRDaUFnSUNBdkx5QnNZWE4wWDIxcGJuUWdQU0J6Wld4bUxuVnpaWEpmYkdGemRGOXRhVzUwTG1kbGRDaHpaVzVrWlhJc0lGVkpiblEyTkNnd0tTa0tJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdPU0F2THlBaWJHRnpkRjl0YVc1MElnb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J2YTJWdWN5OWpiMjUwY21GamRDNXdlVG94TWprS0lDQWdJQzh2SUdGemMyVnlkQ0J0YVc1MFgyTnZkVzUwSUR3Z1ZVbHVkRFkwS0RJcExDQWlVbVZqYjNabGNua2diR2x0YVhRZ2NtVmhZMmhsWkNJS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJRElnTHk4Z01nb2dJQ0FnUEFvZ0lDQWdZWE56WlhKMElDOHZJRkpsWTI5MlpYSjVJR3hwYldsMElISmxZV05vWldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYjJ0bGJuTXZZMjl1ZEhKaFkzUXVjSGs2TVRNd0NpQWdJQ0F2THlCamIyOXNaRzkzYmlBOUlITmxiR1l1WTJGeVltOXVYMk55WldScGRGOXBiblJsY25aaGJDNW5aWFFvVlVsdWREWTBLRGcyTkRBd0tTa2dJQ01nWm1Gc2JHSmhZMnNnZEc4Z09EWTBNREFnYVdZZ2JtOTBJSGxsZENCelpYUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKallYSmliMjVmWTNKbFpHbDBYMmx1ZEdWeWRtRnNJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR2x1ZEdOZk1pQXZMeUE0TmpRd01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlyWlc1ekwyTnZiblJ5WVdOMExuQjVPakV6TVFvZ0lDQWdMeThnWVhOelpYSjBJRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0lENDlJR3hoYzNSZmJXbHVkQ0FySUdOdmIyeGtiM2R1TENBaVEyOXZiR1J2ZDI0Z1lXTjBhWFpsSWdvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnS3dvZ0lDQWdQajBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkRiMjlzWkc5M2JpQmhZM1JwZG1VS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYjJ0bGJuTXZZMjl1ZEhKaFkzUXVjSGs2TVRNekNpQWdJQ0F2THlCelpXeG1MbTFwYm5SZmRHOXJaVzRvVlVsdWREWTBLREV3TUNrc0lITmxibVJsY2lrS0lDQWdJSEIxYzJocGJuUWdNVEF3SUM4dklERXdNQW9nSUNBZ1pHbG5JRElLSUNBZ0lHTmhiR3h6ZFdJZ2JXbHVkRjkwYjJ0bGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSdmEyVnVjeTlqYjI1MGNtRmpkQzV3ZVRveE16UUtJQ0FnSUM4dklITmxiR1l1ZFhObGNsOXRhVzUwWDJOdmRXNTBXM05sYm1SbGNsMGdQU0J0YVc1MFgyTnZkVzUwSUNzZ1ZVbHVkRFkwS0RFcENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbTFwYm5SZlkyOTFiblFpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGd2NGOXNiMk5oYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGIydGxibk12WTI5dWRISmhZM1F1Y0hrNk1UTTFDaUFnSUNBdkx5QnpaV3htTG5WelpYSmZiR0Z6ZEY5dGFXNTBXM05sYm1SbGNsMGdQU0JIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNBb2dJQ0FnWW5sMFpXTWdPU0F2THlBaWJHRnpkRjl0YVc1MElnb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnWVhCd1gyeHZZMkZzWDNCMWRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5SdmEyVnVjeTVqYjI1MGNtRmpkQzVEWVhKaWIyNURjbVZrYVhSRGIyNTBjbUZqZEM1blpYUmZZbUZzWVc1alpTaGhZMk52ZFc1ME9pQmllWFJsY3lrZ0xUNGdkV2x1ZERZME9ncG5aWFJmWW1Gc1lXNWpaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBiMnRsYm5NdlkyOXVkSEpoWTNRdWNIazZNVE0zTFRFek9Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnTHk4Z1pHVm1JR2RsZEY5aVlXeGhibU5sS0hObGJHWXNJR0ZqWTI5MWJuUTZJRUZqWTI5MWJuUXBJQzArSUZWSmJuUTJORG9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSdmEyVnVjeTlqYjI1MGNtRmpkQzV3ZVRveE16a0tJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MblZ6WlhKZlltRnNZVzVqWlM1blpYUW9ZV05qYjNWdWRDd2dWVWx1ZERZMEtEQXBLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltRnNZVzVqWlNJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NTBiMnRsYm5NdVkyOXVkSEpoWTNRdVEyRnlZbTl1UTNKbFpHbDBRMjl1ZEhKaFkzUXVaMlYwWDNSdmRHRnNYM04xY0hCc2VTZ3BJQzArSUhWcGJuUTJORG9LWjJWMFgzUnZkR0ZzWDNOMWNIQnNlVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBiMnRsYm5NdlkyOXVkSEpoWTNRdWNIazZNVFF6Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1MGIzUmhiRjl6ZFhCd2JIa3VaMlYwS0ZWSmJuUTJOQ2d3S1NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0owYjNSaGJGOXpkWEJ3YkhraUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMblJ2YTJWdWN5NWpiMjUwY21GamRDNURZWEppYjI1RGNtVmthWFJEYjI1MGNtRmpkQzVtY21WbGVtVmZZV05qYjNWdWRDaDBZWEpuWlhRNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwbWNtVmxlbVZmWVdOamIzVnVkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBiMnRsYm5NdlkyOXVkSEpoWTNRdWNIazZNVFExTFRFME5nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnTHk4Z1pHVm1JR1p5WldWNlpWOWhZMk52ZFc1MEtITmxiR1lzSUhSaGNtZGxkRG9nUVdOamIzVnVkQ2tnTFQ0Z1RtOXVaVG9LSUNBZ0lIQnliM1J2SURFZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSdmEyVnVjeTlqYjI1MGNtRmpkQzV3ZVRveE5EY0tJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdVpuSmxaWHBsTG1kbGRDaEJZMk52ZFc1MEtDa3BMQ0FpVDI1c2VTQm1jbVZsZW1VZ1lXTmpiM1Z1ZENJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERXdJQzh2SUNKbWNtVmxlbVVpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnYzJWc1pXTjBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2dabkpsWlhwbElHRmpZMjkxYm5RS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTUwYjJ0bGJuTXVZMjl1ZEhKaFkzUXVRMkZ5WW05dVEzSmxaR2wwUTI5dWRISmhZM1F1WTJ4aGQySmhZMnRmZEc5clpXNXpLSFJoY21kbGREb2dZbmwwWlhNc0lHRnRiM1Z1ZERvZ2RXbHVkRFkwS1NBdFBpQjJiMmxrT2dwamJHRjNZbUZqYTE5MGIydGxibk02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlyWlc1ekwyTnZiblJ5WVdOMExuQjVPakUxTUMweE5URUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUM4dklHUmxaaUJqYkdGM1ltRmphMTkwYjJ0bGJuTW9jMlZzWml3Z2RHRnlaMlYwT2lCQlkyTnZkVzUwTENCaGJXOTFiblE2SUZWSmJuUTJOQ2tnTFQ0Z1RtOXVaVG9LSUNBZ0lIQnliM1J2SURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSdmEyVnVjeTlqYjI1MGNtRmpkQzV3ZVRveE5USUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdVkyeGhkMkpoWTJzdVoyVjBLRUZqWTI5MWJuUW9LU2tzSUNKUGJteDVJR05zWVhkaVlXTnJJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRFZ0x5OGdJbU5zWVhkaVlXTnJJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJSE5sYkdWamRBb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHTnNZWGRpWVdOckNpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11ZEc5clpXNXpMbU52Ym5SeVlXTjBMa05oY21KdmJrTnlaV1JwZEVOdmJuUnlZV04wTG1kbGRGOTFjMlZ5WDNKbFpHVnRjSFJwYjI1ektIVnpaWEk2SUdKNWRHVnpLU0F0UGlCMWFXNTBOalE2Q21kbGRGOTFjMlZ5WDNKbFpHVnRjSFJwYjI1ek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSdmEyVnVjeTlqYjI1MGNtRmpkQzV3ZVRveE5UVXRNVFUyQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQXZMeUJrWldZZ1oyVjBYM1Z6WlhKZmNtVmtaVzF3ZEdsdmJuTW9jMlZzWml3Z2RYTmxjam9nUVdOamIzVnVkQ2tnTFQ0Z1ZVbHVkRFkwT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzV6TDJOdmJuUnlZV04wTG5CNU9qRTFOd29nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1ZFhObGNsOXlaV1JsYlhCMGFXOXVYMk52ZFc1MExtZGxkQ2gxYzJWeUxDQlZTVzUwTmpRb01Da3BDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKeVpXUmxaVzFsWkNJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NTBiMnRsYm5NdVkyOXVkSEpoWTNRdVEyRnlZbTl1UTNKbFpHbDBRMjl1ZEhKaFkzUXVaMlYwWDNWelpYSmZiV2x1ZEY5amIzVnVkQ2gxYzJWeU9pQmllWFJsY3lrZ0xUNGdkV2x1ZERZME9ncG5aWFJmZFhObGNsOXRhVzUwWDJOdmRXNTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnZhMlZ1Y3k5amIyNTBjbUZqZEM1d2VUb3hOVGt0TVRZd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0F2THlCa1pXWWdaMlYwWDNWelpYSmZiV2x1ZEY5amIzVnVkQ2h6Wld4bUxDQjFjMlZ5T2lCQlkyTnZkVzUwS1NBdFBpQlZTVzUwTmpRNkNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBiMnRsYm5NdlkyOXVkSEpoWTNRdWNIazZNVFl4Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1MWMyVnlYMjFwYm5SZlkyOTFiblF1WjJWMEtIVnpaWElzSUZWSmJuUTJOQ2d3S1NrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbTFwYm5SZlkyOTFiblFpQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQURBQUdBb3dVbUR3ZGlZV3hoYm1ObEJCVWZmSFVNZEc5MFlXeGZjM1Z3Y0d4NUNtMXBiblJmWTI5MWJuUUljbVZrWldWdFpXUU9kRzlyWlc1ZllYTnpaWFJmYVdRSGJXRnVZV2RsY2haallYSmliMjVmWTNKbFpHbDBYMmx1ZEdWeWRtRnNBUUFKYkdGemRGOXRhVzUwQm1aeVpXVjZaUWhqYkdGM1ltRmphd2wzYUdsMFpXeHBjM1FJYjNCMFpXUmZhVzRPYkdGemRGOXRhVzUwWDNScGJXVXhHMEVCdElJT0JKMnhjUVVFbzlnUFFnU2xtYVp1Qk44ZnAxb0U0YXFSZ3dRRGdPVmxCUGlkMW4wRWxndGc1QVRLaUJsMkJFYVFrMVVFcUxWMzBnUktWbkwzQkt0MjFhUUViU2M5WnpZYUFJNE9BUWdBOWdEa0FNNEF1QUNpQUpJQWdBQnBBRmdBUmdBd0FCa0FBaUpETVJrVVJERVlSRFlhQVJmQUhJZ0RYQllwVEZDd0kwTXhHUlJFTVJoRU5ob0JGOEFjaUFNM0ZpbE1VTEFqUXpFWkZFUXhHRVEyR2dFWHdCdzJHZ0lYaUFNTkkwTXhHUlJFTVJoRU5ob0JGOEFjaUFMc0kwTXhHUlJFTVJoRWlBTFlGaWxNVUxBalF6RVpGRVF4R0VRMkdnRVh3QnlJQXJRV0tVeFFzQ05ETVJrVVJERVlSRFlhQVZjQ0FJZ0NYQ05ETVJrVVJERVlSRFlhQVJlSUFoTWpRekVaRkVReEdFUTJHZ0VYTmhvQ0Y4QWNpQUdvSTBNeEdSUkVNUmhFTmhvQkZ6WWFBaGZBSElnQlFDTkRNUmtVUkRFWVJEWWFBUmZBSElnQkh5bE1VTEFqUXpFWkZFUXhHRVEyR2dFWHdEQ0lBTGtqUXpFWkZFUXhHRVEyR2dFWHdCeUlBSk1qUXpFWkZFUXhHRVEyR2dFWHdCdzJHZ0lYd0J3MkdnTVh3QncyR2dRWHdCdzJHZ1VYTmhvR1Z3SUFOaG9IVndJQU5ob0lGellhQ1ZjQ0FJZ0FFaFlwVEZDd0kwTXhHVUQrc0RFWUZFUWpRNG9KQVRFQU1na1NSQ0luQldVaVRnSk5GRVFuQlNObktvdjdaeWNHaS9kbmdBZHlaWE5sY25abGkvaG5Kd3FMK1djbkM0djZaeWNISkdjaUp3VmxJazRDVFltS0FRQXhBRElESWljR1pVMFNSQ2NNaS85bmlZb0JBREVBU1NJbkRXTW5DRTRDVFNjSUVrRUFKb3NBU1NnaVpra25DU0ptU1NzaVpra25CQ0ptU1lBSGFHbHpkRzl5ZVNKbUp3MkFBWUJtc1NLeUVvdi9zaEdMQUxJVWdRU3lFQ0t5QWJPSmlnRUJpLzh5Q0dFbkNDSlBBbFNKaWdJQWkvOHlDR0ZFTVFBeUF5SW5CbVZORWtTTC9rUXlCeUluRG1VaVRnSk5JaWNIWlNST0FrMElTd0VPUkNJcVpTSk9BazJML2dncVRHY25Ea3huaS84aUtHTWlUZ0pOaS80SWkvOG9Ud0ptaVlvQ0FERUFNZ01pSnd4bFRVa3lBeE5CQUJLTEFJc0JFa0FBQ0l2L2l3RVNRUUF1STBTTEFFa2lLR01pVGdKTlNZditEMFNML3lJb1l5Sk9BazFNaS80SlR3SW9Ud0ptaS80SWkvOG9Ud0ptaVNKQy84K0tBUUF4QUVraUtHTWlUZ0pOU1l2L0QwU0wvd2xMQVNoUEFtWkpJaWNFWXlKT0FrMkwvd2duQkV4bUlpcGxJazRDVFl2L0NTcE1aNG1LQVFBeEFFa2lLMk1pVGdKTlN3RWlKd2xqSWs0Q1RVc0JnUUlNUkNJbkIyVWtUZ0pOTWdkT0FnZ1BSSUZrU3dLSS91MGpDRXNCSzA4Q1ppY0pNZ2RtaVlvQkFZdi9JaWhqSWs0Q1RZa2lLbVVpVGdKTmlZb0JBREVBTWdNaUp3cGxUUkpFaVlvQ0FERUFNZ01pSnd0bFRSSkVpWW9CQVl2L0lpY0VZeUpPQWsySmlnRUJpLzhpSzJNaVRnSk5pUT09IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
