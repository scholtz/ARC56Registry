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

namespace Arc56.Generated.akita_protocol.akita_sc.Arc58NfdInstanceMock_1a921e76
{


    //
    // Test-only NFD instance implementing the exact ABI and global-state surface
    //consumed by NFDPlugin.autoRenew.
    //
    public class Arc58NfdInstanceMockProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public Arc58NfdInstanceMockProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        /// <param name="owner"> </param>
        /// <param name="expiration"> </param>
        /// <param name="price"> </param>
        public async Task Create(string name, Algorand.Address owner, ulong expiration, ulong price, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 190, 119, 13 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var expirationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expirationAbi.From(expiration);
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi, ownerAbi, expirationAbi, priceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(string name, Algorand.Address owner, ulong expiration, ulong price, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 190, 119, 13 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var expirationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expirationAbi.From(expiration);
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi, ownerAbi, expirationAbi, priceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="name"> </param>
        /// <param name="owner"> </param>
        /// <param name="expiration"> </param>
        /// <param name="price"> </param>
        public async Task Configure(string name, Algorand.Address owner, ulong expiration, ulong price, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 96, 42, 43 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var expirationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expirationAbi.From(expiration);
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi, ownerAbi, expirationAbi, priceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Configure_Transactions(string name, Algorand.Address owner, ulong expiration, ulong price, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 96, 42, 43 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var expirationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expirationAbi.From(expiration);
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi, ownerAbi, expirationAbi, priceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="name"> </param>
        public async Task SetName(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 102, 247, 222, 215 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetName_Transactions(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 102, 247, 222, 215 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="owner"> </param>
        public async Task SetOwner(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 230, 24, 18 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            var result = await base.CallApp(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetOwner_Transactions(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 230, 24, 18 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="expiration"> </param>
        public async Task SetExpiration(ulong expiration, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 77, 61, 171, 143 };
            var expirationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expirationAbi.From(expiration);

            var result = await base.CallApp(new List<object> { abiHandle, expirationAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetExpiration_Transactions(ulong expiration, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 77, 61, 171, 143 };
            var expirationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expirationAbi.From(expiration);

            return await base.MakeTransactionList(new List<object> { abiHandle, expirationAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="price"> </param>
        public async Task SetPrice(ulong price, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 168, 210, 5, 162 };
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);

            var result = await base.CallApp(new List<object> { abiHandle, priceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetPrice_Transactions(ulong price, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 168, 210, 5, 162 };
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);

            return await base.MakeTransactionList(new List<object> { abiHandle, priceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="amount"> </param>
        public async Task SetSaleAmount(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 107, 125, 181 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetSaleAmount_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 107, 125, 181 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="failPrice"> </param>
        /// <param name="failRenew"> </param>
        public async Task SetFailure(bool failPrice, bool failRenew, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 18, 161, 128, 3 };
            var failPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); failPriceAbi.From(failPrice);
            var failRenewAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); failRenewAbi.From(failRenew);

            var result = await base.CallApp(new List<object> { abiHandle, failPriceAbi, failRenewAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetFailure_Transactions(bool failPrice, bool failRenew, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 18, 161, 128, 3 };
            var failPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); failPriceAbi.From(failPrice);
            var failRenewAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); failRenewAbi.From(failRenew);

            return await base.MakeTransactionList(new List<object> { abiHandle, failPriceAbi, failRenewAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetRenewPrice(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 244, 144, 194 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetRenewPrice_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 244, 144, 194 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment"> </param>
        public async Task Renew(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 119, 253, 91, 116 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Renew_Transactions(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 119, 253, 91, 116 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="_sellAmount"> </param>
        /// <param name="_reservedFor"> </param>
        public async Task OfferForSale(ulong _sellAmount, Algorand.Address _reservedFor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 118, 217, 202 };
            var _sellAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _sellAmountAbi.From(_sellAmount);
            var _reservedForAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _reservedForAbi.From(_reservedFor);

            var result = await base.CallApp(new List<object> { abiHandle, _sellAmountAbi, _reservedForAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OfferForSale_Transactions(ulong _sellAmount, Algorand.Address _reservedFor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 118, 217, 202 };
            var _sellAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _sellAmountAbi.From(_sellAmount);
            var _reservedForAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _reservedForAbi.From(_reservedFor);

            return await base.MakeTransactionList(new List<object> { abiHandle, _sellAmountAbi, _reservedForAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment"> </param>
        public async Task Purchase(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 163, 146, 174, 130 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Purchase_Transactions(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 163, 146, 174, 130 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXJjNThOZmRJbnN0YW5jZU1vY2siLCJkZXNjIjoiVGVzdC1vbmx5IE5GRCBpbnN0YW5jZSBpbXBsZW1lbnRpbmcgdGhlIGV4YWN0IEFCSSBhbmQgZ2xvYmFsLXN0YXRlIHN1cmZhY2VcbmNvbnN1bWVkIGJ5IE5GRFBsdWdpbi5hdXRvUmVuZXcuIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV4cGlyYXRpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByaWNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNvbmZpZ3VyZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV4cGlyYXRpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByaWNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldE5hbWUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRPd25lciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0RXhwaXJhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJleHBpcmF0aW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldFByaWNlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByaWNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldFNhbGVBbW91bnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldEZhaWx1cmUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZhaWxQcmljZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZhaWxSZW5ldyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRSZW5ld1ByaWNlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVuZXciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJvZmZlckZvclNhbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX3NlbGxBbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfcmVzZXJ2ZWRGb3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicHVyY2hhc2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6NywiYnl0ZXMiOjR9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzUzMyw1MzksNTY2LDU4OCw2MDAsNjI1LDY2Niw2NzddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTUsMzQwLDQyMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUwNSw1MTVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5ib29sIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjYzLDM0OCw0MjldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjc0LDM1OSw0NDYsNjIxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4MiwyOTEsMzY3LDM3Niw0NTksNDc1LDQ4OSw2MTRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NjEsNjQyXSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRGdnTXpJS0lDQWdJR0o1ZEdWallteHZZMnNnSW5SbGMzUmZjSEpwWTJVaUlDSnBMbTkzYm1WeUxtRWlJQ0p5Wlc1bGQxOWpiM1Z1ZENJZ0ltOTNibVZ5YzJocGNGOWpZV3hzY3lJZ0ltWmhhV3hmY0hKcFkyVWlJQ0ptWVdsc1gzSmxibVYzSWlBaWFTNXVZVzFsSWlBaWFTNWxlSEJwY21GMGFXOXVWR2x0WlNJZ0lteGhjM1JmY0dGNWJXVnVkQ0lnSW5CMWNtTm9ZWE5sWDJOdmRXNTBJaUFpYVM1elpXeHNZVzEwSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmJtWmtMMkYxZEc4dGNtVnVaWGN0Ylc5amF5NWhiR2R2TG5Sek9qWTBDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUVhKak5UaE9abVJKYm5OMFlXNWpaVTF2WTJzZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllaUJ0WVdsdVgyTnlaV0YwWlY5T2IwOXdRREUxQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0WldZMk1ESmhNbUlnTUhnMk5tWTNaR1ZrTnlBd2VEWTBaVFl4T0RFeUlEQjROR1F6WkdGaU9HWWdNSGhoT0dReU1EVmhNaUF3ZURNek5tSTNaR0kxSURCNE1USmhNVGd3TURNZ01IZzFNR1kwT1RCak1pQXdlRGMzWm1RMVlqYzBJREI0TlRBM05tUTVZMkVnTUhoaE16a3lZV1U0TWlBdkx5QnRaWFJvYjJRZ0ltTnZibVpwWjNWeVpTaHpkSEpwYm1jc1lXUmtjbVZ6Y3l4MWFXNTBOalFzZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0luTmxkRTVoYldVb2MzUnlhVzVuS1hadmFXUWlMQ0J0WlhSb2IyUWdJbk5sZEU5M2JtVnlLR0ZrWkhKbGMzTXBkbTlwWkNJc0lHMWxkR2h2WkNBaWMyVjBSWGh3YVhKaGRHbHZiaWgxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWMyVjBVSEpwWTJVb2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbk5sZEZOaGJHVkJiVzkxYm5Rb2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbk5sZEVaaGFXeDFjbVVvWW05dmJDeGliMjlzS1hadmFXUWlMQ0J0WlhSb2IyUWdJbWRsZEZKbGJtVjNVSEpwWTJVb0tYVnBiblEyTkNJc0lHMWxkR2h2WkNBaWNtVnVaWGNvY0dGNUtYWnZhV1FpTENCdFpYUm9iMlFnSW05bVptVnlSbTl5VTJGc1pTaDFhVzUwTmpRc1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0p3ZFhKamFHRnpaU2h3WVhrcGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdOdmJtWnBaM1Z5WlNCelpYUk9ZVzFsSUhObGRFOTNibVZ5SUhObGRFVjRjR2x5WVhScGIyNGdjMlYwVUhKcFkyVWdjMlYwVTJGc1pVRnRiM1Z1ZENCelpYUkdZV2xzZFhKbElHZGxkRkpsYm1WM1VISnBZMlVnY21WdVpYY2diMlptWlhKR2IzSlRZV3hsSUhCMWNtTm9ZWE5sQ2lBZ0lDQmxjbklLQ20xaGFXNWZZM0psWVhSbFgwNXZUM0JBTVRVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OXVabVF2WVhWMGJ5MXlaVzVsZHkxdGIyTnJMbUZzWjI4dWRITTZOalFLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQmNtTTFPRTVtWkVsdWMzUmhibU5sVFc5amF5QmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEZ3pZbVUzTnpCa0lDOHZJRzFsZEdodlpDQWlZM0psWVhSbEtITjBjbWx1Wnl4aFpHUnlaWE56TEhWcGJuUTJOQ3gxYVc1ME5qUXBkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHTnlaV0YwWlFvZ0lDQWdaWEp5Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12Ym1aa0wyRjFkRzh0Y21WdVpYY3RiVzlqYXk1aGJHZHZMblJ6T2pwQmNtTTFPRTVtWkVsdWMzUmhibU5sVFc5amF5NWpjbVZoZEdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpjbVZoZEdVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OXVabVF2WVhWMGJ5MXlaVzVsZHkxdGIyTnJMbUZzWjI4dWRITTZOemNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCdmJrTnlaV0YwWlRvZ0ozSmxjWFZwY21VbklIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZibVprTDJGMWRHOHRjbVZ1WlhjdGJXOWpheTVoYkdkdkxuUnpPalkxQ2lBZ0lDQXZMeUJ1WVcxbElEMGdSMnh2WW1Gc1UzUmhkR1U4YzNSeWFXNW5QaWg3SUd0bGVUb2dUa1pFUjJ4dlltRnNVM1JoZEdWTFpYbHpUbUZ0WlNCOUtRb2dJQ0FnWW5sMFpXTWdOaUF2THlBaWFTNXVZVzFsSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmJtWmtMMkYxZEc4dGNtVnVaWGN0Ylc5amF5NWhiR2R2TG5Sek9qYzVDaUFnSUNBdkx5QjBhR2x6TG01aGJXVXVkbUZzZFdVZ1BTQnVZVzFsQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTl1Wm1RdllYVjBieTF5Wlc1bGR5MXRiMk5yTG1Gc1oyOHVkSE02TmpZS0lDQWdJQzh2SUc5M2JtVnlJRDBnUjJ4dlltRnNVM1JoZEdVOFFXTmpiM1Z1ZEQ0b2V5QnJaWGs2SUU1R1JFZHNiMkpoYkZOMFlYUmxTMlY1VDNkdVpYSWdmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbWt1YjNkdVpYSXVZU0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDI1bVpDOWhkWFJ2TFhKbGJtVjNMVzF2WTJzdVlXeG5ieTUwY3pvNE1Bb2dJQ0FnTHk4Z2RHaHBjeTV2ZDI1bGNpNTJZV3gxWlNBOUlHOTNibVZ5Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTl1Wm1RdllYVjBieTF5Wlc1bGR5MXRiMk5yTG1Gc1oyOHVkSE02T0RFS0lDQWdJQzh2SUhSb2FYTXVaWGh3YVhKaGRHbHZiaTUyWVd4MVpTQTlJR2wwYjJJb1pYaHdhWEpoZEdsdmJpa0tJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzl3YkhWbmFXNXpMMjVtWkM5aGRYUnZMWEpsYm1WM0xXMXZZMnN1WVd4bmJ5NTBjem8yTndvZ0lDQWdMeThnWlhod2FYSmhkR2x2YmlBOUlFZHNiMkpoYkZOMFlYUmxQR0o1ZEdWelBpaDdJR3RsZVRvZ1RrWkVSMnh2WW1Gc1UzUmhkR1ZMWlhsRmVIQnBjbUYwYVc5dVZHbHRaU0I5S1FvZ0lDQWdZbmwwWldNZ055QXZMeUFpYVM1bGVIQnBjbUYwYVc5dVZHbHRaU0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDI1bVpDOWhkWFJ2TFhKbGJtVjNMVzF2WTJzdVlXeG5ieTUwY3pvNE1Rb2dJQ0FnTHk4Z2RHaHBjeTVsZUhCcGNtRjBhVzl1TG5aaGJIVmxJRDBnYVhSdllpaGxlSEJwY21GMGFXOXVLUW9nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDI1bVpDOWhkWFJ2TFhKbGJtVjNMVzF2WTJzdVlXeG5ieTUwY3pvMk9Bb2dJQ0FnTHk4Z2NISnBZMlVnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhMlY1T2lBbmRHVnpkRjl3Y21salpTY2dmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblJsYzNSZmNISnBZMlVpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5dVptUXZZWFYwYnkxeVpXNWxkeTF0YjJOckxtRnNaMjh1ZEhNNk9ESUtJQ0FnSUM4dklIUm9hWE11Y0hKcFkyVXVkbUZzZFdVZ1BTQndjbWxqWlFvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwyNW1aQzloZFhSdkxYSmxibVYzTFcxdlkyc3VZV3huYnk1MGN6bzJPUW9nSUNBZ0x5OGdjbVZ1WlhkRGIzVnVkQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkeVpXNWxkMTlqYjNWdWRDY2dmU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbkpsYm1WM1gyTnZkVzUwSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmJtWmtMMkYxZEc4dGNtVnVaWGN0Ylc5amF5NWhiR2R2TG5Sek9qZ3pDaUFnSUNBdkx5QjBhR2x6TG5KbGJtVjNRMjkxYm5RdWRtRnNkV1VnUFNBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwyNW1aQzloZFhSdkxYSmxibVYzTFcxdlkyc3VZV3huYnk1MGN6bzNNQW9nSUNBZ0x5OGdiR0Z6ZEZCaGVXMWxiblFnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhMlY1T2lBbmJHRnpkRjl3WVhsdFpXNTBKeUI5S1FvZ0lDQWdZbmwwWldNZ09DQXZMeUFpYkdGemRGOXdZWGx0Wlc1MElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZibVprTDJGMWRHOHRjbVZ1WlhjdGJXOWpheTVoYkdkdkxuUnpPamcwQ2lBZ0lDQXZMeUIwYUdsekxteGhjM1JRWVhsdFpXNTBMblpoYkhWbElEMGdNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTl1Wm1RdllYVjBieTF5Wlc1bGR5MXRiMk5yTG1Gc1oyOHVkSE02TnpFS0lDQWdJQzh2SUc5M2JtVnljMmhwY0VOaGJHeHpJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHdGxlVG9nSjI5M2JtVnljMmhwY0Y5allXeHNjeWNnZlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW05M2JtVnljMmhwY0Y5allXeHNjeUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDI1bVpDOWhkWFJ2TFhKbGJtVjNMVzF2WTJzdVlXeG5ieTUwY3pvNE5Rb2dJQ0FnTHk4Z2RHaHBjeTV2ZDI1bGNuTm9hWEJEWVd4c2N5NTJZV3gxWlNBOUlEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZibVprTDJGMWRHOHRjbVZ1WlhjdGJXOWpheTVoYkdkdkxuUnpPamN5Q2lBZ0lDQXZMeUJtWVdsc1VISnBZMlVnUFNCSGJHOWlZV3hUZEdGMFpUeGliMjlzWldGdVBpaDdJR3RsZVRvZ0oyWmhhV3hmY0hKcFkyVW5JSDBwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0ptWVdsc1gzQnlhV05sSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmJtWmtMMkYxZEc4dGNtVnVaWGN0Ylc5amF5NWhiR2R2TG5Sek9qZzJDaUFnSUNBdkx5QjBhR2x6TG1aaGFXeFFjbWxqWlM1MllXeDFaU0E5SUdaaGJITmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzl3YkhWbmFXNXpMMjVtWkM5aGRYUnZMWEpsYm1WM0xXMXZZMnN1WVd4bmJ5NTBjem8zTXdvZ0lDQWdMeThnWm1GcGJGSmxibVYzSUQwZ1IyeHZZbUZzVTNSaGRHVThZbTl2YkdWaGJqNG9leUJyWlhrNklDZG1ZV2xzWDNKbGJtVjNKeUI5S1FvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWm1GcGJGOXlaVzVsZHlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwyNW1aQzloZFhSdkxYSmxibVYzTFcxdlkyc3VZV3huYnk1MGN6bzROd29nSUNBZ0x5OGdkR2hwY3k1bVlXbHNVbVZ1WlhjdWRtRnNkV1VnUFNCbVlXeHpaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTl1Wm1RdllYVjBieTF5Wlc1bGR5MXRiMk5yTG1Gc1oyOHVkSE02TnpVS0lDQWdJQzh2SUhCMWNtTm9ZWE5sUTI5MWJuUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFuY0hWeVkyaGhjMlZmWTI5MWJuUW5JSDBwQ2lBZ0lDQmllWFJsWXlBNUlDOHZJQ0p3ZFhKamFHRnpaVjlqYjNWdWRDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzl3YkhWbmFXNXpMMjVtWkM5aGRYUnZMWEpsYm1WM0xXMXZZMnN1WVd4bmJ5NTBjem80T0FvZ0lDQWdMeThnZEdocGN5NXdkWEpqYUdGelpVTnZkVzUwTG5aaGJIVmxJRDBnTUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5dVptUXZZWFYwYnkxeVpXNWxkeTF0YjJOckxtRnNaMjh1ZEhNNk56Y0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ2YmtOeVpXRjBaVG9nSjNKbGNYVnBjbVVuSUgwcENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmJtWmtMMkYxZEc4dGNtVnVaWGN0Ylc5amF5NWhiR2R2TG5Sek9qcEJjbU0xT0U1bVpFbHVjM1JoYm1ObFRXOWpheTVqYjI1bWFXZDFjbVZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamIyNW1hV2QxY21VNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OXVabVF2WVhWMGJ5MXlaVzVsZHkxdGIyTnJMbUZzWjI4dWRITTZPVEVLSUNBZ0lDOHZJR052Ym1acFozVnlaU2h1WVcxbE9pQnpkSEpwYm1jc0lHOTNibVZ5T2lCQlkyTnZkVzUwTENCbGVIQnBjbUYwYVc5dU9pQjFhVzUwTmpRc0lIQnlhV05sT2lCMWFXNTBOalFwT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTl1Wm1RdllYVjBieTF5Wlc1bGR5MXRiMk5yTG1Gc1oyOHVkSE02TmpVS0lDQWdJQzh2SUc1aGJXVWdQU0JIYkc5aVlXeFRkR0YwWlR4emRISnBibWMrS0hzZ2EyVjVPaUJPUmtSSGJHOWlZV3hUZEdGMFpVdGxlWE5PWVcxbElIMHBDaUFnSUNCaWVYUmxZeUEySUM4dklDSnBMbTVoYldVaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OXVabVF2WVhWMGJ5MXlaVzVsZHkxdGIyTnJMbUZzWjI4dWRITTZPVElLSUNBZ0lDOHZJSFJvYVhNdWJtRnRaUzUyWVd4MVpTQTlJRzVoYldVS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDI1bVpDOWhkWFJ2TFhKbGJtVjNMVzF2WTJzdVlXeG5ieTUwY3pvMk5nb2dJQ0FnTHk4Z2IzZHVaWElnUFNCSGJHOWlZV3hUZEdGMFpUeEJZMk52ZFc1MFBpaDdJR3RsZVRvZ1RrWkVSMnh2WW1Gc1UzUmhkR1ZMWlhsUGQyNWxjaUI5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYVM1dmQyNWxjaTVoSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmJtWmtMMkYxZEc4dGNtVnVaWGN0Ylc5amF5NWhiR2R2TG5Sek9qa3pDaUFnSUNBdkx5QjBhR2x6TG05M2JtVnlMblpoYkhWbElEMGdiM2R1WlhJS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDI1bVpDOWhkWFJ2TFhKbGJtVjNMVzF2WTJzdVlXeG5ieTUwY3pvNU5Bb2dJQ0FnTHk4Z2RHaHBjeTVsZUhCcGNtRjBhVzl1TG5aaGJIVmxJRDBnYVhSdllpaGxlSEJwY21GMGFXOXVLUW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12Ym1aa0wyRjFkRzh0Y21WdVpYY3RiVzlqYXk1aGJHZHZMblJ6T2pZM0NpQWdJQ0F2THlCbGVIQnBjbUYwYVc5dUlEMGdSMnh2WW1Gc1UzUmhkR1U4WW5sMFpYTStLSHNnYTJWNU9pQk9Sa1JIYkc5aVlXeFRkR0YwWlV0bGVVVjRjR2x5WVhScGIyNVVhVzFsSUgwcENpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKcExtVjRjR2x5WVhScGIyNVVhVzFsSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmJtWmtMMkYxZEc4dGNtVnVaWGN0Ylc5amF5NWhiR2R2TG5Sek9qazBDaUFnSUNBdkx5QjBhR2x6TG1WNGNHbHlZWFJwYjI0dWRtRnNkV1VnUFNCcGRHOWlLR1Y0Y0dseVlYUnBiMjRwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmJtWmtMMkYxZEc4dGNtVnVaWGN0Ylc5amF5NWhiR2R2TG5Sek9qWTRDaUFnSUNBdkx5QndjbWxqWlNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJyWlhrNklDZDBaWE4wWDNCeWFXTmxKeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZEdWemRGOXdjbWxqWlNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwyNW1aQzloZFhSdkxYSmxibVYzTFcxdlkyc3VZV3huYnk1MGN6bzVOUW9nSUNBZ0x5OGdkR2hwY3k1d2NtbGpaUzUyWVd4MVpTQTlJSEJ5YVdObENpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZibVprTDJGMWRHOHRjbVZ1WlhjdGJXOWpheTVoYkdkdkxuUnpPalk1Q2lBZ0lDQXZMeUJ5Wlc1bGQwTnZkVzUwSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR3RsZVRvZ0ozSmxibVYzWDJOdmRXNTBKeUI5S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpY21WdVpYZGZZMjkxYm5RaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OXVabVF2WVhWMGJ5MXlaVzVsZHkxdGIyTnJMbUZzWjI4dWRITTZPVFlLSUNBZ0lDOHZJSFJvYVhNdWNtVnVaWGREYjNWdWRDNTJZV3gxWlNBOUlEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZibVprTDJGMWRHOHRjbVZ1WlhjdGJXOWpheTVoYkdkdkxuUnpPamN3Q2lBZ0lDQXZMeUJzWVhOMFVHRjViV1Z1ZENBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJyWlhrNklDZHNZWE4wWDNCaGVXMWxiblFuSUgwcENpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKc1lYTjBYM0JoZVcxbGJuUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTl1Wm1RdllYVjBieTF5Wlc1bGR5MXRiMk5yTG1Gc1oyOHVkSE02T1RjS0lDQWdJQzh2SUhSb2FYTXViR0Z6ZEZCaGVXMWxiblF1ZG1Gc2RXVWdQU0F3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDI1bVpDOWhkWFJ2TFhKbGJtVjNMVzF2WTJzdVlXeG5ieTUwY3pvM01Rb2dJQ0FnTHk4Z2IzZHVaWEp6YUdsd1EyRnNiSE1nUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhMlY1T2lBbmIzZHVaWEp6YUdsd1gyTmhiR3h6SnlCOUtRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWIzZHVaWEp6YUdsd1gyTmhiR3h6SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmJtWmtMMkYxZEc4dGNtVnVaWGN0Ylc5amF5NWhiR2R2TG5Sek9qazRDaUFnSUNBdkx5QjBhR2x6TG05M2JtVnljMmhwY0VOaGJHeHpMblpoYkhWbElEMGdNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTl1Wm1RdllYVjBieTF5Wlc1bGR5MXRiMk5yTG1Gc1oyOHVkSE02TnpJS0lDQWdJQzh2SUdaaGFXeFFjbWxqWlNBOUlFZHNiMkpoYkZOMFlYUmxQR0p2YjJ4bFlXNCtLSHNnYTJWNU9pQW5abUZwYkY5d2NtbGpaU2NnZlNrS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1aaGFXeGZjSEpwWTJVaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OXVabVF2WVhWMGJ5MXlaVzVsZHkxdGIyTnJMbUZzWjI4dWRITTZPVGtLSUNBZ0lDOHZJSFJvYVhNdVptRnBiRkJ5YVdObExuWmhiSFZsSUQwZ1ptRnNjMlVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12Ym1aa0wyRjFkRzh0Y21WdVpYY3RiVzlqYXk1aGJHZHZMblJ6T2pjekNpQWdJQ0F2THlCbVlXbHNVbVZ1WlhjZ1BTQkhiRzlpWVd4VGRHRjBaVHhpYjI5c1pXRnVQaWg3SUd0bGVUb2dKMlpoYVd4ZmNtVnVaWGNuSUgwcENpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKbVlXbHNYM0psYm1WM0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZibVprTDJGMWRHOHRjbVZ1WlhjdGJXOWpheTVoYkdkdkxuUnpPakV3TUFvZ0lDQWdMeThnZEdocGN5NW1ZV2xzVW1WdVpYY3VkbUZzZFdVZ1BTQm1ZV3h6WlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5dVptUXZZWFYwYnkxeVpXNWxkeTF0YjJOckxtRnNaMjh1ZEhNNk9URUtJQ0FnSUM4dklHTnZibVpwWjNWeVpTaHVZVzFsT2lCemRISnBibWNzSUc5M2JtVnlPaUJCWTJOdmRXNTBMQ0JsZUhCcGNtRjBhVzl1T2lCMWFXNTBOalFzSUhCeWFXTmxPaUIxYVc1ME5qUXBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OXVabVF2WVhWMGJ5MXlaVzVsZHkxdGIyTnJMbUZzWjI4dWRITTZPa0Z5WXpVNFRtWmtTVzV6ZEdGdVkyVk5iMk5yTG5ObGRFNWhiV1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwelpYUk9ZVzFsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmJtWmtMMkYxZEc4dGNtVnVaWGN0Ylc5amF5NWhiR2R2TG5Sek9qRXdNd29nSUNBZ0x5OGdjMlYwVG1GdFpTaHVZVzFsT2lCemRISnBibWNwT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmJtWmtMMkYxZEc4dGNtVnVaWGN0Ylc5amF5NWhiR2R2TG5Sek9qWTFDaUFnSUNBdkx5QnVZVzFsSUQwZ1IyeHZZbUZzVTNSaGRHVThjM1J5YVc1blBpaDdJR3RsZVRvZ1RrWkVSMnh2WW1Gc1UzUmhkR1ZMWlhselRtRnRaU0I5S1FvZ0lDQWdZbmwwWldNZ05pQXZMeUFpYVM1dVlXMWxJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12Ym1aa0wyRjFkRzh0Y21WdVpYY3RiVzlqYXk1aGJHZHZMblJ6T2pFd05Bb2dJQ0FnTHk4Z2RHaHBjeTV1WVcxbExuWmhiSFZsSUQwZ2JtRnRaUW9nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDI1bVpDOWhkWFJ2TFhKbGJtVjNMVzF2WTJzdVlXeG5ieTUwY3pveE1ETUtJQ0FnSUM4dklITmxkRTVoYldVb2JtRnRaVG9nYzNSeWFXNW5LVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZibVprTDJGMWRHOHRjbVZ1WlhjdGJXOWpheTVoYkdkdkxuUnpPanBCY21NMU9FNW1aRWx1YzNSaGJtTmxUVzlqYXk1elpYUlBkMjVsY2x0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRTkzYm1WeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZibVprTDJGMWRHOHRjbVZ1WlhjdGJXOWpheTVoYkdkdkxuUnpPakV3TndvZ0lDQWdMeThnYzJWMFQzZHVaWElvYjNkdVpYSTZJRUZqWTI5MWJuUXBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZibVprTDJGMWRHOHRjbVZ1WlhjdGJXOWpheTVoYkdkdkxuUnpPalkyQ2lBZ0lDQXZMeUJ2ZDI1bGNpQTlJRWRzYjJKaGJGTjBZWFJsUEVGalkyOTFiblErS0hzZ2EyVjVPaUJPUmtSSGJHOWlZV3hUZEdGMFpVdGxlVTkzYm1WeUlIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnBMbTkzYm1WeUxtRWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTl1Wm1RdllYVjBieTF5Wlc1bGR5MXRiMk5yTG1Gc1oyOHVkSE02TVRBNENpQWdJQ0F2THlCMGFHbHpMbTkzYm1WeUxuWmhiSFZsSUQwZ2IzZHVaWElLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5dVptUXZZWFYwYnkxeVpXNWxkeTF0YjJOckxtRnNaMjh1ZEhNNk1UQTNDaUFnSUNBdkx5QnpaWFJQZDI1bGNpaHZkMjVsY2pvZ1FXTmpiM1Z1ZENrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDI1bVpDOWhkWFJ2TFhKbGJtVjNMVzF2WTJzdVlXeG5ieTUwY3pvNlFYSmpOVGhPWm1SSmJuTjBZVzVqWlUxdlkyc3VjMlYwUlhod2FYSmhkR2x2Ymx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRVY0Y0dseVlYUnBiMjQ2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5dVptUXZZWFYwYnkxeVpXNWxkeTF0YjJOckxtRnNaMjh1ZEhNNk1URXhDaUFnSUNBdkx5QnpaWFJGZUhCcGNtRjBhVzl1S0dWNGNHbHlZWFJwYjI0NklIVnBiblEyTkNrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZibVprTDJGMWRHOHRjbVZ1WlhjdGJXOWpheTVoYkdkdkxuUnpPakV4TWdvZ0lDQWdMeThnZEdocGN5NWxlSEJwY21GMGFXOXVMblpoYkhWbElEMGdhWFJ2WWlobGVIQnBjbUYwYVc5dUtRb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZibVprTDJGMWRHOHRjbVZ1WlhjdGJXOWpheTVoYkdkdkxuUnpPalkzQ2lBZ0lDQXZMeUJsZUhCcGNtRjBhVzl1SUQwZ1IyeHZZbUZzVTNSaGRHVThZbmwwWlhNK0tIc2dhMlY1T2lCT1JrUkhiRzlpWVd4VGRHRjBaVXRsZVVWNGNHbHlZWFJwYjI1VWFXMWxJSDBwQ2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0pwTG1WNGNHbHlZWFJwYjI1VWFXMWxJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12Ym1aa0wyRjFkRzh0Y21WdVpYY3RiVzlqYXk1aGJHZHZMblJ6T2pFeE1nb2dJQ0FnTHk4Z2RHaHBjeTVsZUhCcGNtRjBhVzl1TG5aaGJIVmxJRDBnYVhSdllpaGxlSEJwY21GMGFXOXVLUW9nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDI1bVpDOWhkWFJ2TFhKbGJtVjNMVzF2WTJzdVlXeG5ieTUwY3pveE1URUtJQ0FnSUM4dklITmxkRVY0Y0dseVlYUnBiMjRvWlhod2FYSmhkR2x2YmpvZ2RXbHVkRFkwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12Ym1aa0wyRjFkRzh0Y21WdVpYY3RiVzlqYXk1aGJHZHZMblJ6T2pwQmNtTTFPRTVtWkVsdWMzUmhibU5sVFc5amF5NXpaWFJRY21salpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEZCeWFXTmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12Ym1aa0wyRjFkRzh0Y21WdVpYY3RiVzlqYXk1aGJHZHZMblJ6T2pFeE5Rb2dJQ0FnTHk4Z2MyVjBVSEpwWTJVb2NISnBZMlU2SUhWcGJuUTJOQ2s2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmJtWmtMMkYxZEc4dGNtVnVaWGN0Ylc5amF5NWhiR2R2TG5Sek9qWTRDaUFnSUNBdkx5QndjbWxqWlNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJyWlhrNklDZDBaWE4wWDNCeWFXTmxKeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZEdWemRGOXdjbWxqWlNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwyNW1aQzloZFhSdkxYSmxibVYzTFcxdlkyc3VZV3huYnk1MGN6b3hNVFlLSUNBZ0lDOHZJSFJvYVhNdWNISnBZMlV1ZG1Gc2RXVWdQU0J3Y21salpRb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzl3YkhWbmFXNXpMMjVtWkM5aGRYUnZMWEpsYm1WM0xXMXZZMnN1WVd4bmJ5NTBjem94TVRVS0lDQWdJQzh2SUhObGRGQnlhV05sS0hCeWFXTmxPaUIxYVc1ME5qUXBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OXVabVF2WVhWMGJ5MXlaVzVsZHkxdGIyTnJMbUZzWjI4dWRITTZPa0Z5WXpVNFRtWmtTVzV6ZEdGdVkyVk5iMk5yTG5ObGRGTmhiR1ZCYlc5MWJuUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6WlhSVFlXeGxRVzF2ZFc1ME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZibVprTDJGMWRHOHRjbVZ1WlhjdGJXOWpheTVoYkdkdkxuUnpPakV4T1FvZ0lDQWdMeThnYzJWMFUyRnNaVUZ0YjNWdWRDaGhiVzkxYm5RNklIVnBiblEyTkNrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZibVprTDJGMWRHOHRjbVZ1WlhjdGJXOWpheTVoYkdkdkxuUnpPakV5TUFvZ0lDQWdMeThnZEdocGN5NXpZV3hsUVcxdmRXNTBMblpoYkhWbElEMGdhWFJ2WWloaGJXOTFiblFwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5dVptUXZZWFYwYnkxeVpXNWxkeTF0YjJOckxtRnNaMjh1ZEhNNk56UUtJQ0FnSUM4dklITmhiR1ZCYlc5MWJuUWdQU0JIYkc5aVlXeFRkR0YwWlR4aWVYUmxjejRvZXlCclpYazZJRTVHUkVkc2IySmhiRk4wWVhSbFMyVjVVMkZzWlVGdGIzVnVkRXRsZVNCOUtRb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z0lta3VjMlZzYkdGdGRDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzl3YkhWbmFXNXpMMjVtWkM5aGRYUnZMWEpsYm1WM0xXMXZZMnN1WVd4bmJ5NTBjem94TWpBS0lDQWdJQzh2SUhSb2FYTXVjMkZzWlVGdGIzVnVkQzUyWVd4MVpTQTlJR2wwYjJJb1lXMXZkVzUwS1FvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwyNW1aQzloZFhSdkxYSmxibVYzTFcxdlkyc3VZV3huYnk1MGN6b3hNVGtLSUNBZ0lDOHZJSE5sZEZOaGJHVkJiVzkxYm5Rb1lXMXZkVzUwT2lCMWFXNTBOalFwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTl1Wm1RdllYVjBieTF5Wlc1bGR5MXRiMk5yTG1Gc1oyOHVkSE02T2tGeVl6VTRUbVprU1c1emRHRnVZMlZOYjJOckxuTmxkRVpoYVd4MWNtVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6WlhSR1lXbHNkWEpsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmJtWmtMMkYxZEc4dGNtVnVaWGN0Ylc5amF5NWhiR2R2TG5Sek9qRXlNd29nSUNBZ0x5OGdjMlYwUm1GcGJIVnlaU2htWVdsc1VISnBZMlU2SUdKdmIyeGxZVzRzSUdaaGFXeFNaVzVsZHpvZ1ltOXZiR1ZoYmlrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbUp2YjJ3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVpYjI5c0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OXVabVF2WVhWMGJ5MXlaVzVsZHkxdGIyTnJMbUZzWjI4dWRITTZOeklLSUNBZ0lDOHZJR1poYVd4UWNtbGpaU0E5SUVkc2IySmhiRk4wWVhSbFBHSnZiMnhsWVc0K0tIc2dhMlY1T2lBblptRnBiRjl3Y21salpTY2dmU2tLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbVpoYVd4ZmNISnBZMlVpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5dVptUXZZWFYwYnkxeVpXNWxkeTF0YjJOckxtRnNaMjh1ZEhNNk1USTBDaUFnSUNBdkx5QjBhR2x6TG1aaGFXeFFjbWxqWlM1MllXeDFaU0E5SUdaaGFXeFFjbWxqWlFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12Ym1aa0wyRjFkRzh0Y21WdVpYY3RiVzlqYXk1aGJHZHZMblJ6T2pjekNpQWdJQ0F2THlCbVlXbHNVbVZ1WlhjZ1BTQkhiRzlpWVd4VGRHRjBaVHhpYjI5c1pXRnVQaWg3SUd0bGVUb2dKMlpoYVd4ZmNtVnVaWGNuSUgwcENpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKbVlXbHNYM0psYm1WM0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZibVprTDJGMWRHOHRjbVZ1WlhjdGJXOWpheTVoYkdkdkxuUnpPakV5TlFvZ0lDQWdMeThnZEdocGN5NW1ZV2xzVW1WdVpYY3VkbUZzZFdVZ1BTQm1ZV2xzVW1WdVpYY0tJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTl1Wm1RdllYVjBieTF5Wlc1bGR5MXRiMk5yTG1Gc1oyOHVkSE02TVRJekNpQWdJQ0F2THlCelpYUkdZV2xzZFhKbEtHWmhhV3hRY21salpUb2dZbTl2YkdWaGJpd2dabUZwYkZKbGJtVjNPaUJpYjI5c1pXRnVLVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZibVprTDJGMWRHOHRjbVZ1WlhjdGJXOWpheTVoYkdkdkxuUnpPanBCY21NMU9FNW1aRWx1YzNSaGJtTmxUVzlqYXk1blpYUlNaVzVsZDFCeWFXTmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFVtVnVaWGRRY21salpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzl3YkhWbmFXNXpMMjVtWkM5aGRYUnZMWEpsYm1WM0xXMXZZMnN1WVd4bmJ5NTBjem94TWprS0lDQWdJQzh2SUdGemMyVnlkQ2doZEdocGN5NW1ZV2xzVUhKcFkyVXVkbUZzZFdVcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmJtWmtMMkYxZEc4dGNtVnVaWGN0Ylc5amF5NWhiR2R2TG5Sek9qY3lDaUFnSUNBdkx5Qm1ZV2xzVUhKcFkyVWdQU0JIYkc5aVlXeFRkR0YwWlR4aWIyOXNaV0Z1UGloN0lHdGxlVG9nSjJaaGFXeGZjSEpwWTJVbklIMHBDaUFnSUNCaWVYUmxZeUEwSUM4dklDSm1ZV2xzWDNCeWFXTmxJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12Ym1aa0wyRjFkRzh0Y21WdVpYY3RiVzlqYXk1aGJHZHZMblJ6T2pFeU9Rb2dJQ0FnTHk4Z1lYTnpaWEowS0NGMGFHbHpMbVpoYVd4UWNtbGpaUzUyWVd4MVpTa0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwyNW1aQzloZFhSdkxYSmxibVYzTFcxdlkyc3VZV3huYnk1MGN6b3hNekFLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TG5CeWFXTmxMblpoYkhWbENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmJtWmtMMkYxZEc4dGNtVnVaWGN0Ylc5amF5NWhiR2R2TG5Sek9qWTRDaUFnSUNBdkx5QndjbWxqWlNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJyWlhrNklDZDBaWE4wWDNCeWFXTmxKeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZEdWemRGOXdjbWxqWlNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwyNW1aQzloZFhSdkxYSmxibVYzTFcxdlkyc3VZV3huYnk1MGN6b3hNekFLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TG5CeWFXTmxMblpoYkhWbENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmJtWmtMMkYxZEc4dGNtVnVaWGN0Ylc5amF5NWhiR2R2TG5Sek9qRXlPQW9nSUNBZ0x5OGdaMlYwVW1WdVpYZFFjbWxqWlNncE9pQjFhVzUwTmpRZ2V3b2dJQ0FnYVhSdllnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmJtWmtMMkYxZEc4dGNtVnVaWGN0Ylc5amF5NWhiR2R2TG5Sek9qcEJjbU0xT0U1bVpFbHVjM1JoYm1ObFRXOWpheTV5Wlc1bGQxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsYm1WM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZibVprTDJGMWRHOHRjbVZ1WlhjdGJXOWpheTVoYkdkdkxuUnpPakV6TXdvZ0lDQWdMeThnY21WdVpYY29jR0Y1YldWdWREb2daM1I0Ymk1UVlYbHRaVzUwVkhodUtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTVNBdkx5QndZWGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QndZWGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDI1bVpDOWhkWFJ2TFhKbGJtVjNMVzF2WTJzdVlXeG5ieTUwY3pveE16UUtJQ0FnSUM4dklHRnpjMlZ5ZENnaGRHaHBjeTVtWVdsc1VtVnVaWGN1ZG1Gc2RXVXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZibVprTDJGMWRHOHRjbVZ1WlhjdGJXOWpheTVoYkdkdkxuUnpPamN6Q2lBZ0lDQXZMeUJtWVdsc1VtVnVaWGNnUFNCSGJHOWlZV3hUZEdGMFpUeGliMjlzWldGdVBpaDdJR3RsZVRvZ0oyWmhhV3hmY21WdVpYY25JSDBwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0ptWVdsc1gzSmxibVYzSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmJtWmtMMkYxZEc4dGNtVnVaWGN0Ylc5amF5NWhiR2R2TG5Sek9qRXpOQW9nSUNBZ0x5OGdZWE56WlhKMEtDRjBhR2x6TG1aaGFXeFNaVzVsZHk1MllXeDFaU2tLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzl3YkhWbmFXNXpMMjVtWkM5aGRYUnZMWEpsYm1WM0xXMXZZMnN1WVd4bmJ5NTBjem94TXpVS0lDQWdJQzh2SUdGemMyVnlkQ2h3WVhsdFpXNTBMbk5sYm1SbGNpQTlQVDBnVkhodUxuTmxibVJsY2lrS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1UyVnVaR1Z5Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTl1Wm1RdllYVjBieTF5Wlc1bGR5MXRiMk5yTG1Gc1oyOHVkSE02TVRNMkNpQWdJQ0F2THlCaGMzTmxjblFvY0dGNWJXVnVkQzV5WldObGFYWmxjaUE5UFQwZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01wQ2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZKbFkyVnBkbVZ5Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmJtWmtMMkYxZEc4dGNtVnVaWGN0Ylc5amF5NWhiR2R2TG5Sek9qRXpOd29nSUNBZ0x5OGdZWE56WlhKMEtIQmhlVzFsYm5RdVlXMXZkVzUwSUQwOVBTQjBhR2x6TG5CeWFXTmxMblpoYkhWbEtRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmJtWmtMMkYxZEc4dGNtVnVaWGN0Ylc5amF5NWhiR2R2TG5Sek9qWTRDaUFnSUNBdkx5QndjbWxqWlNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJyWlhrNklDZDBaWE4wWDNCeWFXTmxKeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZEdWemRGOXdjbWxqWlNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwyNW1aQzloZFhSdkxYSmxibVYzTFcxdlkyc3VZV3huYnk1MGN6b3hNemNLSUNBZ0lDOHZJR0Z6YzJWeWRDaHdZWGx0Wlc1MExtRnRiM1Z1ZENBOVBUMGdkR2hwY3k1d2NtbGpaUzUyWVd4MVpTa0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZibVprTDJGMWRHOHRjbVZ1WlhjdGJXOWpheTVoYkdkdkxuUnpPamN3Q2lBZ0lDQXZMeUJzWVhOMFVHRjViV1Z1ZENBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJyWlhrNklDZHNZWE4wWDNCaGVXMWxiblFuSUgwcENpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKc1lYTjBYM0JoZVcxbGJuUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTl1Wm1RdllYVjBieTF5Wlc1bGR5MXRiMk5yTG1Gc1oyOHVkSE02TVRNNENpQWdJQ0F2THlCMGFHbHpMbXhoYzNSUVlYbHRaVzUwTG5aaGJIVmxJRDBnY0dGNWJXVnVkQzVoYlc5MWJuUUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTl1Wm1RdllYVjBieTF5Wlc1bGR5MXRiMk5yTG1Gc1oyOHVkSE02TVRNNUNpQWdJQ0F2THlCMGFHbHpMbkpsYm1WM1EyOTFiblF1ZG1Gc2RXVWdLejBnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDI1bVpDOWhkWFJ2TFhKbGJtVjNMVzF2WTJzdVlXeG5ieTUwY3pvMk9Rb2dJQ0FnTHk4Z2NtVnVaWGREYjNWdWRDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ2R5Wlc1bGQxOWpiM1Z1ZENjZ2ZTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0luSmxibVYzWDJOdmRXNTBJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12Ym1aa0wyRjFkRzh0Y21WdVpYY3RiVzlqYXk1aGJHZHZMblJ6T2pFek9Rb2dJQ0FnTHk4Z2RHaHBjeTV5Wlc1bGQwTnZkVzUwTG5aaGJIVmxJQ3M5SURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZibVprTDJGMWRHOHRjbVZ1WlhjdGJXOWpheTVoYkdkdkxuUnpPalk1Q2lBZ0lDQXZMeUJ5Wlc1bGQwTnZkVzUwSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR3RsZVRvZ0ozSmxibVYzWDJOdmRXNTBKeUI5S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpY21WdVpYZGZZMjkxYm5RaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OXVabVF2WVhWMGJ5MXlaVzVsZHkxdGIyTnJMbUZzWjI4dWRITTZNVE01Q2lBZ0lDQXZMeUIwYUdsekxuSmxibVYzUTI5MWJuUXVkbUZzZFdVZ0t6MGdNUW9nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDI1bVpDOWhkWFJ2TFhKbGJtVjNMVzF2WTJzdVlXeG5ieTUwY3pveE16TUtJQ0FnSUM4dklISmxibVYzS0hCaGVXMWxiblE2SUdkMGVHNHVVR0Y1YldWdWRGUjRiaWs2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzl3YkhWbmFXNXpMMjVtWkM5aGRYUnZMWEpsYm1WM0xXMXZZMnN1WVd4bmJ5NTBjem82UVhKak5UaE9abVJKYm5OMFlXNWpaVTF2WTJzdWIyWm1aWEpHYjNKVFlXeGxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYjJabVpYSkdiM0pUWVd4bE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZibVprTDJGMWRHOHRjbVZ1WlhjdGJXOWpheTVoYkdkdkxuUnpPakUwTWdvZ0lDQWdMeThnYjJabVpYSkdiM0pUWVd4bEtGOXpaV3hzUVcxdmRXNTBPaUIxYVc1ME5qUXNJRjl5WlhObGNuWmxaRVp2Y2pvZ1FXTmpiM1Z1ZENrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzl3YkhWbmFXNXpMMjVtWkM5aGRYUnZMWEpsYm1WM0xXMXZZMnN1WVd4bmJ5NTBjem94TkRNS0lDQWdJQzh2SUhSb2FYTXViM2R1WlhKemFHbHdRMkZzYkhNdWRtRnNkV1VnS3owZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwyNW1aQzloZFhSdkxYSmxibVYzTFcxdlkyc3VZV3huYnk1MGN6bzNNUW9nSUNBZ0x5OGdiM2R1WlhKemFHbHdRMkZzYkhNZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQW5iM2R1WlhKemFHbHdYMk5oYkd4ekp5QjlLUW9nSUNBZ1lubDBaV05mTXlBdkx5QWliM2R1WlhKemFHbHdYMk5oYkd4eklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZibVprTDJGMWRHOHRjbVZ1WlhjdGJXOWpheTVoYkdkdkxuUnpPakUwTXdvZ0lDQWdMeThnZEdocGN5NXZkMjVsY25Ob2FYQkRZV3hzY3k1MllXeDFaU0FyUFNBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzl3YkhWbmFXNXpMMjVtWkM5aGRYUnZMWEpsYm1WM0xXMXZZMnN1WVd4bmJ5NTBjem8zTVFvZ0lDQWdMeThnYjNkdVpYSnphR2x3UTJGc2JITWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFuYjNkdVpYSnphR2x3WDJOaGJHeHpKeUI5S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpYjNkdVpYSnphR2x3WDJOaGJHeHpJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12Ym1aa0wyRjFkRzh0Y21WdVpYY3RiVzlqYXk1aGJHZHZMblJ6T2pFME13b2dJQ0FnTHk4Z2RHaHBjeTV2ZDI1bGNuTm9hWEJEWVd4c2N5NTJZV3gxWlNBclBTQXhDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12Ym1aa0wyRjFkRzh0Y21WdVpYY3RiVzlqYXk1aGJHZHZMblJ6T2pFME1nb2dJQ0FnTHk4Z2IyWm1aWEpHYjNKVFlXeGxLRjl6Wld4c1FXMXZkVzUwT2lCMWFXNTBOalFzSUY5eVpYTmxjblpsWkVadmNqb2dRV05qYjNWdWRDazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwyNW1aQzloZFhSdkxYSmxibVYzTFcxdlkyc3VZV3huYnk1MGN6bzZRWEpqTlRoT1ptUkpibk4wWVc1alpVMXZZMnN1Y0hWeVkyaGhjMlZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwd2RYSmphR0Z6WlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwyNW1aQzloZFhSdkxYSmxibVYzTFcxdlkyc3VZV3huYnk1MGN6b3hORFlLSUNBZ0lDOHZJSEIxY21Ob1lYTmxLSEJoZVcxbGJuUTZJR2QwZUc0dVVHRjViV1Z1ZEZSNGJpazZJSFp2YVdRZ2V3b2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdjR0Y1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdjR0Y1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5dVptUXZZWFYwYnkxeVpXNWxkeTF0YjJOckxtRnNaMjh1ZEhNNk1UUTNDaUFnSUNBdkx5QmhjM05sY25Rb2NHRjViV1Z1ZEM1elpXNWtaWElnUFQwOUlGUjRiaTV6Wlc1a1pYSXBDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRk5sYm1SbGNnb2dJQ0FnWkhWd0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5dVptUXZZWFYwYnkxeVpXNWxkeTF0YjJOckxtRnNaMjh1ZEhNNk1UUTRDaUFnSUNBdkx5QmhjM05sY25Rb2NHRjViV1Z1ZEM1eVpXTmxhWFpsY2lBOVBUMGdSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWjNSNGJuTWdVbVZqWldsMlpYSUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTl1Wm1RdllYVjBieTF5Wlc1bGR5MXRiMk5yTG1Gc1oyOHVkSE02TVRRNUNpQWdJQ0F2THlCaGMzTmxjblFvY0dGNWJXVnVkQzVoYlc5MWJuUWdQVDA5SUdKMGIya29kR2hwY3k1ellXeGxRVzF2ZFc1MExuWmhiSFZsS1NrS0lDQWdJSE4zWVhBS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDI1bVpDOWhkWFJ2TFhKbGJtVjNMVzF2WTJzdVlXeG5ieTUwY3pvM05Bb2dJQ0FnTHk4Z2MyRnNaVUZ0YjNWdWRDQTlJRWRzYjJKaGJGTjBZWFJsUEdKNWRHVnpQaWg3SUd0bGVUb2dUa1pFUjJ4dlltRnNVM1JoZEdWTFpYbFRZV3hsUVcxdmRXNTBTMlY1SUgwcENpQWdJQ0JpZVhSbFl5QXhNQ0F2THlBaWFTNXpaV3hzWVcxMElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZibVprTDJGMWRHOHRjbVZ1WlhjdGJXOWpheTVoYkdkdkxuUnpPakUwT1FvZ0lDQWdMeThnWVhOelpYSjBLSEJoZVcxbGJuUXVZVzF2ZFc1MElEMDlQU0JpZEc5cEtIUm9hWE11YzJGc1pVRnRiM1Z1ZEM1MllXeDFaU2twQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ1luUnZhUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12Ym1aa0wyRjFkRzh0Y21WdVpYY3RiVzlqYXk1aGJHZHZMblJ6T2pZMkNpQWdJQ0F2THlCdmQyNWxjaUE5SUVkc2IySmhiRk4wWVhSbFBFRmpZMjkxYm5RK0tIc2dhMlY1T2lCT1JrUkhiRzlpWVd4VGRHRjBaVXRsZVU5M2JtVnlJSDBwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pwTG05M2JtVnlMbUVpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5dVptUXZZWFYwYnkxeVpXNWxkeTF0YjJOckxtRnNaMjh1ZEhNNk1UVXdDaUFnSUNBdkx5QjBhR2x6TG05M2JtVnlMblpoYkhWbElEMGdjR0Y1YldWdWRDNXpaVzVrWlhJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OXVabVF2WVhWMGJ5MXlaVzVsZHkxdGIyTnJMbUZzWjI4dWRITTZNVFV4Q2lBZ0lDQXZMeUIwYUdsekxuQjFjbU5vWVhObFEyOTFiblF1ZG1Gc2RXVWdLejBnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDI1bVpDOWhkWFJ2TFhKbGJtVjNMVzF2WTJzdVlXeG5ieTUwY3pvM05Rb2dJQ0FnTHk4Z2NIVnlZMmhoYzJWRGIzVnVkQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkd2RYSmphR0Z6WlY5amIzVnVkQ2NnZlNrS0lDQWdJR0o1ZEdWaklEa2dMeThnSW5CMWNtTm9ZWE5sWDJOdmRXNTBJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12Ym1aa0wyRjFkRzh0Y21WdVpYY3RiVzlqYXk1aGJHZHZMblJ6T2pFMU1Rb2dJQ0FnTHk4Z2RHaHBjeTV3ZFhKamFHRnpaVU52ZFc1MExuWmhiSFZsSUNzOUlERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12Ym1aa0wyRjFkRzh0Y21WdVpYY3RiVzlqYXk1aGJHZHZMblJ6T2pjMUNpQWdJQ0F2THlCd2RYSmphR0Z6WlVOdmRXNTBJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHdGxlVG9nSjNCMWNtTm9ZWE5sWDJOdmRXNTBKeUI5S1FvZ0lDQWdZbmwwWldNZ09TQXZMeUFpY0hWeVkyaGhjMlZmWTI5MWJuUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTl1Wm1RdllYVjBieTF5Wlc1bGR5MXRiMk5yTG1Gc1oyOHVkSE02TVRVeENpQWdJQ0F2THlCMGFHbHpMbkIxY21Ob1lYTmxRMjkxYm5RdWRtRnNkV1VnS3owZ01Rb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzl3YkhWbmFXNXpMMjVtWkM5aGRYUnZMWEpsYm1WM0xXMXZZMnN1WVd4bmJ5NTBjem94TkRZS0lDQWdJQzh2SUhCMWNtTm9ZWE5sS0hCaGVXMWxiblE2SUdkMGVHNHVVR0Y1YldWdWRGUjRiaWs2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUlJQ1lMQ25SbGMzUmZjSEpwWTJVSmFTNXZkMjVsY2k1aEMzSmxibVYzWDJOdmRXNTBEMjkzYm1WeWMyaHBjRjlqWVd4c2N3cG1ZV2xzWDNCeWFXTmxDbVpoYVd4ZmNtVnVaWGNHYVM1dVlXMWxFR2t1Wlhod2FYSmhkR2x2YmxScGJXVU1iR0Z6ZEY5d1lYbHRaVzUwRG5CMWNtTm9ZWE5sWDJOdmRXNTBDV2t1YzJWc2JHRnRkREVaRkVReEdFRUFWWUlMQk85Z0tpc0VadmZlMXdSazVoZ1NCRTA5cTQ4RXFOSUZvZ1F6YTMyMUJCS2hnQU1FVVBTUXdnUjMvVnQwQkZCMjJjb0VvNUt1Z2pZYUFJNExBR1FBdFFETUFOa0E2UUQzQVFjQkpnRTlBWFVCamdDQUJJTytkdzAyR2dDT0FRQUJBRFlhQVVraVdZRUNDRXNCRlJKRVZ3SUFOaG9DU1JVbEVrUTJHZ05KRlNRU1JCYzJHZ1JKRlNRU1JCY25CazhFWnlsUEEyZE1GaWNIVEdjb1RHY3FJbWNuQ0NKbkt5Sm5Kd1FpWnljRkltY25DU0puSTBNMkdnRkpJbG1CQWdoTEFSVVNSRmNDQURZYUFra1ZKUkpFTmhvRFNSVWtFa1FYTmhvRVNSVWtFa1FYSndaUEJHY3BUd05uVEJZbkIweG5LRXhuS2lKbkp3Z2laeXNpWnljRUltY25CU0puSTBNMkdnRkpJbG1CQWdoTEFSVVNSRmNDQUNjR1RHY2pRellhQVVrVkpSSkVLVXhuSTBNMkdnRkpGU1FTUkJjV0p3ZE1aeU5ETmhvQlNSVWtFa1FYS0V4bkkwTTJHZ0ZKRlNRU1JCY1dKd3BNWnlORE5ob0JTUlVqRWtRaVV6WWFBa2tWSXhKRUlsTW5CRThDWnljRlRHY2pReUluQkdWRUZFUWlLR1ZFRm9BRUZSOThkVXhRc0NORE1SWWpDVWs0RUNNU1JDSW5CV1ZFRkVSSk9BQXhBQkpFU1RnSE1nb1NSRGdJSWlobFJFc0JFa1FuQ0V4bklpcGxSQ01JS2t4bkkwTTJHZ0VWSkJKRU5ob0NGU1VTUkNJclpVUWpDQ3RNWnlORE1SWWpDVWs0RUNNU1JFazRBRWt4QUJKRVN3RTRCeklLRWtSTU9BZ2lKd3BsUkJjU1JDbE1aeUluQ1dWRUl3Z25DVXhuSTBNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjEwLCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
