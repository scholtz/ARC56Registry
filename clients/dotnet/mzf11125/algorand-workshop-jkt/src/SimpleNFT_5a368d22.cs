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

namespace Arc56.Generated.mzf11125.algorand_workshop_jkt.SimpleNFT_5a368d22
{


    //
    // 
    //    A complete NFT contract on Algorand using ARC4
    //    Implements full NFT functionality: mint, burn, transfer, and ownership tracking
    //    Follows ERC-721-like standards for Algorand
    //    
    //
    public class SimpleNFTProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SimpleNFTProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Initialize the NFT contract with metadata and minter address
        ///</summary>
        /// <param name="name"> </param>
        /// <param name="symbol"> </param>
        /// <param name="uri"> </param>
        /// <param name="minter"> </param>
        public async Task Initialize(string name, string symbol, string uri, Algorand.Address minter, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 125, 2, 254 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var symbolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); symbolAbi.From(symbol);
            var uriAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); uriAbi.From(uri);
            var minterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); minterAbi.From(minter);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi, symbolAbi, uriAbi, minterAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Initialize_Transactions(string name, string symbol, string uri, Algorand.Address minter, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 125, 2, 254 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var symbolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); symbolAbi.From(symbol);
            var uriAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); uriAbi.From(uri);
            var minterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); minterAbi.From(minter);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi, symbolAbi, uriAbi, minterAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Mint a new NFT to the specified address
        ///Returns the created token ID
        ///</summary>
        /// <param name="to"> </param>
        /// <param name="metadata"> </param>
        public async Task<ulong> Mint(Algorand.Address to, string metadata, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 221, 109, 50, 120 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);
            var metadataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); metadataAbi.From(metadata);

            var result = await base.CallApp(new List<object> { abiHandle, toAbi, metadataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Mint_Transactions(Algorand.Address to, string metadata, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 221, 109, 50, 120 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);
            var metadataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); metadataAbi.From(metadata);

            return await base.MakeTransactionList(new List<object> { abiHandle, toAbi, metadataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Burn an NFT (destroy it)
        ///Only the owner can burn their NFT
        ///</summary>
        /// <param name="token_id"> </param>
        public async Task Burn(ulong token_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 29, 67, 225 };
            var token_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); token_idAbi.From(token_id);

            var result = await base.CallApp(new List<object> { abiHandle, token_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Burn_Transactions(ulong token_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 29, 67, 225 };
            var token_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); token_idAbi.From(token_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, token_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Transfer an NFT to another account
        ///</summary>
        /// <param name="to"> </param>
        /// <param name="token_id"> </param>
        public async Task Transfer(Algorand.Address to, ulong token_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 159, 238, 116, 24 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);
            var token_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); token_idAbi.From(token_id);

            var result = await base.CallApp(new List<object> { abiHandle, toAbi, token_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Transfer_Transactions(Algorand.Address to, ulong token_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 159, 238, 116, 24 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);
            var token_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); token_idAbi.From(token_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, toAbi, token_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Transfer NFT from one account to another (approved transfer)
        ///</summary>
        /// <param name="from_account"> </param>
        /// <param name="to"> </param>
        /// <param name="token_id"> </param>
        public async Task TransferFrom(Algorand.Address from_account, Algorand.Address to, ulong token_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 88, 155, 195, 250 };
            var from_accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); from_accountAbi.From(from_account);
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);
            var token_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); token_idAbi.From(token_id);

            var result = await base.CallApp(new List<object> { abiHandle, from_accountAbi, toAbi, token_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TransferFrom_Transactions(Algorand.Address from_account, Algorand.Address to, ulong token_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 88, 155, 195, 250 };
            var from_accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); from_accountAbi.From(from_account);
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);
            var token_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); token_idAbi.From(token_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, from_accountAbi, toAbi, token_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the NFT balance of an account
        ///Returns 1 if they own the NFT, 0 otherwise
        ///</summary>
        /// <param name="account"> </param>
        public async Task<ulong> BalanceOf(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 119, 120, 57 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> BalanceOf_Transactions(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 119, 120, 57 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the owner of a specific NFT
        ///</summary>
        /// <param name="token_id"> </param>
        public async Task<Algorand.Address> OwnerOf(ulong token_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 207, 246, 87, 126 };
            var token_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); token_idAbi.From(token_id);

            var result = await base.CallApp(new List<object> { abiHandle, token_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> OwnerOf_Transactions(ulong token_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 207, 246, 87, 126 };
            var token_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); token_idAbi.From(token_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, token_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the NFT name
        ///</summary>
        public async Task<string> GetName(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 66, 148, 148, 143 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetName_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 66, 148, 148, 143 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the NFT symbol
        ///</summary>
        public async Task<string> GetSymbol(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 6, 220, 95, 9 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetSymbol_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 6, 220, 95, 9 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the NFT metadata URI for a specific token
        ///</summary>
        /// <param name="token_id"> </param>
        public async Task<string> GetUri(ulong token_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 5, 247, 214, 85 };
            var token_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); token_idAbi.From(token_id);

            var result = await base.CallApp(new List<object> { abiHandle, token_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetUri_Transactions(ulong token_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 5, 247, 214, 85 };
            var token_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); token_idAbi.From(token_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, token_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the total supply of NFTs
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
        ///Set a new minter (only current minter can do this)
        ///</summary>
        /// <param name="new_minter"> </param>
        public async Task SetMinter(Algorand.Address new_minter, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 153, 206, 46, 247 };
            var new_minterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_minterAbi.From(new_minter);

            var result = await base.CallApp(new List<object> { abiHandle, new_minterAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetMinter_Transactions(Algorand.Address new_minter, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 153, 206, 46, 247 };
            var new_minterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_minterAbi.From(new_minter);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_minterAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the current token ID
        ///</summary>
        public async Task<ulong> GetCurrentTokenId(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 233, 46, 130, 16 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetCurrentTokenId_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 233, 46, 130, 16 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check if a token exists
        ///</summary>
        /// <param name="token_id"> </param>
        public async Task<bool> Exists(ulong token_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 73, 105, 159, 116 };
            var token_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); token_idAbi.From(token_id);

            var result = await base.CallApp(new List<object> { abiHandle, token_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Exists_Transactions(ulong token_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 73, 105, 159, 116 };
            var token_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); token_idAbi.From(token_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, token_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU2ltcGxlTkZUIiwiZGVzYyI6IlxuICAgIEEgY29tcGxldGUgTkZUIGNvbnRyYWN0IG9uIEFsZ29yYW5kIHVzaW5nIEFSQzRcbiAgICBJbXBsZW1lbnRzIGZ1bGwgTkZUIGZ1bmN0aW9uYWxpdHk6IG1pbnQsIGJ1cm4sIHRyYW5zZmVyLCBhbmQgb3duZXJzaGlwIHRyYWNraW5nXG4gICAgRm9sbG93cyBFUkMtNzIxLWxpa2Ugc3RhbmRhcmRzIGZvciBBbGdvcmFuZFxuICAgICIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJpbml0aWFsaXplIiwiZGVzYyI6IkluaXRpYWxpemUgdGhlIE5GVCBjb250cmFjdCB3aXRoIG1ldGFkYXRhIGFuZCBtaW50ZXIgYWRkcmVzcyIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzeW1ib2wiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVyaSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1pbnRlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJtaW50IiwiZGVzYyI6Ik1pbnQgYSBuZXcgTkZUIHRvIHRoZSBzcGVjaWZpZWQgYWRkcmVzc1xuUmV0dXJucyB0aGUgY3JlYXRlZCB0b2tlbiBJRCIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1ldGFkYXRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYnVybiIsImRlc2MiOiJCdXJuIGFuIE5GVCAoZGVzdHJveSBpdClcbk9ubHkgdGhlIG93bmVyIGNhbiBidXJuIHRoZWlyIE5GVCIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbl9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0cmFuc2ZlciIsImRlc2MiOiJUcmFuc2ZlciBhbiBORlQgdG8gYW5vdGhlciBhY2NvdW50IiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5faWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidHJhbnNmZXJfZnJvbSIsImRlc2MiOiJUcmFuc2ZlciBORlQgZnJvbSBvbmUgYWNjb3VudCB0byBhbm90aGVyIChhcHByb3ZlZCB0cmFuc2ZlcikiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb21fYWNjb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbl9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJiYWxhbmNlX29mIiwiZGVzYyI6IkdldCB0aGUgTkZUIGJhbGFuY2Ugb2YgYW4gYWNjb3VudFxuUmV0dXJucyAxIGlmIHRoZXkgb3duIHRoZSBORlQsIDAgb3RoZXJ3aXNlIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3duZXJfb2YiLCJkZXNjIjoiR2V0IHRoZSBvd25lciBvZiBhIHNwZWNpZmljIE5GVCIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbl9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfbmFtZSIsImRlc2MiOiJHZXQgdGhlIE5GVCBuYW1lIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3N5bWJvbCIsImRlc2MiOiJHZXQgdGhlIE5GVCBzeW1ib2wiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdXJpIiwiZGVzYyI6IkdldCB0aGUgTkZUIG1ldGFkYXRhIFVSSSBmb3IgYSBzcGVjaWZpYyB0b2tlbiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbl9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF90b3RhbF9zdXBwbHkiLCJkZXNjIjoiR2V0IHRoZSB0b3RhbCBzdXBwbHkgb2YgTkZUcyIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF9taW50ZXIiLCJkZXNjIjoiU2V0IGEgbmV3IG1pbnRlciAob25seSBjdXJyZW50IG1pbnRlciBjYW4gZG8gdGhpcykiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19taW50ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2N1cnJlbnRfdG9rZW5faWQiLCJkZXNjIjoiR2V0IHRoZSBjdXJyZW50IHRva2VuIElEIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZXhpc3RzIiwiZGVzYyI6IkNoZWNrIGlmIGEgdG9rZW4gZXhpc3RzIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2VuX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjozLCJieXRlcyI6NX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMzk4XSwiZXJyb3JNZXNzYWdlIjoiQ2Fubm90IG1pbnQgdG8gemVybyBhZGRyZXNzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODAzXSwiZXJyb3JNZXNzYWdlIjoiQ2Fubm90IHNldCBtaW50ZXIgdG8gemVybyBhZGRyZXNzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTM2LDYxNV0sImVycm9yTWVzc2FnZSI6IkNhbm5vdCB0cmFuc2ZlciB0byBzYW1lIGFkZHJlc3MiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MjQsNTg0XSwiZXJyb3JNZXNzYWdlIjoiQ2Fubm90IHRyYW5zZmVyIHRvIHplcm8gYWRkcmVzcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU3OF0sImVycm9yTWVzc2FnZSI6IkZyb20gYWNjb3VudCBpcyBub3QgdGhlIG93bmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDY3LDUzMiw1OTAsNjc5LDc0N10sImVycm9yTWVzc2FnZSI6IkludmFsaWQgdG9rZW4gSUQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2ODRdLCJlcnJvck1lc3NhZ2UiOiJORlQgZG9lcyBub3QgZXhpc3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MDddLCJlcnJvck1lc3NhZ2UiOiJOZXcgbWludGVyIG11c3QgYmUgZGlmZmVyZW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDcyXSwiZXJyb3JNZXNzYWdlIjoiTm8gTkZUcyB0byBidXJuIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjA5XSwiZXJyb3JNZXNzYWdlIjoiTm90IGF1dGhvcml6ZWQgdG8gdHJhbnNmZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTVdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzk3XSwiZXJyb3JNZXNzYWdlIjoiT25seSBjdXJyZW50IG1pbnRlciBjYW4gc2V0IG5ldyBtaW50ZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTNdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IG1pbnRlciBjYW4gbWludCBORlRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDYxXSwiZXJyb3JNZXNzYWdlIjoiT25seSBvd25lciBjYW4gYnVybiBORlQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MThdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IG93bmVyIGNhbiB0cmFuc2ZlciBORlQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MDRdLCJlcnJvck1lc3NhZ2UiOiJUaGlzIGNvbnRyYWN0IHN1cHBvcnRzIHNpbmdsZSBORlQgb25seSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYzN10sImVycm9yTWVzc2FnZSI6Ilplcm8gYWRkcmVzcyBoYXMgbm8gYmFsYW5jZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ1OSw1MTMsNTc0LDY0MSw2ODhdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmN1cnJlbnRfb3duZXIgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDY1LDUyOCw1ODgsNjc3LDc0NSw4MTcsODM3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5jdXJyZW50X3Rva2VuX2lkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM5MSw2MDMsNzkyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5taW50ZXIgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDA5LDQzMV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubmV4dF90b2tlbl9pZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2OTldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRva2VuX25hbWUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzE4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b2tlbl9zeW1ib2wgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzUyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b2tlbl91cmkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDAyLDQyMSw0NzEsNDgzLDY0OSw2ODMsNzcwLDg0NV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfc3VwcGx5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3OSwyOTYsMzEzLDM3N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4NywzMDQsMzIxLDM4NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzIsMzcxLDQ5OCw1NTAsNTYxLDYzMiw3ODVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDUyLDUwNiw1NjksNjcyLDc0MCw4MzJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ016SWdPQW9nSUNBZ1lubDBaV05pYkc5amF5QWlkRzkwWVd4ZmMzVndjR3g1SWlBaVkzVnljbVZ1ZEY5MGIydGxibDlwWkNJZ0ltTjFjbkpsYm5SZmIzZHVaWElpSURCNE1UVXhaamRqTnpVZ0ltMXBiblJsY2lJZ0ltNWxlSFJmZEc5clpXNWZhV1FpSUNKMGIydGxibDl1WVcxbElpQWlkRzlyWlc1ZmMzbHRZbTlzSWlBaWRHOXJaVzVmZFhKcElnb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sYzNOcGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRNdE1UUUtJQ0FnSUM4dklDTWdRMjl1ZEhKaFkzUWdiV1YwWVdSaGRHRUtJQ0FnSUM4dklITmxiR1l1ZEc5clpXNWZibUZ0WlNBOUlGTjBjbWx1WnlncENpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKMGIydGxibDl1WVcxbElnb2dJQ0FnY0hWemFHSjVkR1Z6SUNJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObGMzTnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UVUtJQ0FnSUM4dklITmxiR1l1ZEc5clpXNWZjM2x0WW05c0lEMGdVM1J5YVc1bktDa0tJQ0FnSUdKNWRHVmpJRGNnTHk4Z0luUnZhMlZ1WDNONWJXSnZiQ0lLSUNBZ0lIQjFjMmhpZVhSbGN5QWlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaWE56YVc5dUwyTnZiblJ5WVdOMExuQjVPakUyQ2lBZ0lDQXZMeUJ6Wld4bUxuUnZhMlZ1WDNWeWFTQTlJRk4wY21sdVp5Z3BDaUFnSUNCaWVYUmxZeUE0SUM4dklDSjBiMnRsYmw5MWNta2lDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVnpjMmx2Ymk5amIyNTBjbUZqZEM1d2VUb3hPQzB4T1FvZ0lDQWdMeThnSXlCT1JsUWdiV0Z1WVdkbGJXVnVkQW9nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjl6ZFhCd2JIa2dQU0JWU1c1ME5qUW9LUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkRzkwWVd4ZmMzVndjR3g1SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZ6YzJsdmJpOWpiMjUwY21GamRDNXdlVG95TUFvZ0lDQWdMeThnYzJWc1ppNXVaWGgwWDNSdmEyVnVYMmxrSUQwZ1ZVbHVkRFkwS0RFcElDQWpJRk4wWVhKMElHWnliMjBnZEc5clpXNGdTVVFnTVFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpYm1WNGRGOTBiMnRsYmw5cFpDSUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObGMzTnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1qSXRNak1LSUNBZ0lDOHZJQ01nUVdOalpYTnpJR052Ym5SeWIyd0tJQ0FnSUM4dklITmxiR1l1YldsdWRHVnlJRDBnUVdOamIzVnVkQ2dwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0p0YVc1MFpYSWlDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWemMybHZiaTlqYjI1MGNtRmpkQzV3ZVRveU5TMHlOZ29nSUNBZ0x5OGdJeUJKYm1ScGRtbGtkV0ZzSUhSdmEyVnVJRzkzYm1WeWMyaHBjQ0FvYzJsdGNHeHBabWxsWkNCbWIzSWdjMmx1WjJ4bElFNUdWQ2tLSUNBZ0lDOHZJSE5sYkdZdVkzVnljbVZ1ZEY5dmQyNWxjaUE5SUVGalkyOTFiblFvS1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWTNWeWNtVnVkRjl2ZDI1bGNpSUtJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WlhOemFXOXVMMk52Ym5SeVlXTjBMbkI1T2pJM0NpQWdJQ0F2THlCelpXeG1MbU4xY25KbGJuUmZkRzlyWlc1ZmFXUWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbU4xY25KbGJuUmZkRzlyWlc1ZmFXUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sYzNOcGIyNHZZMjl1ZEhKaFkzUXVjSGs2TlFvZ0lDQWdMeThnWTJ4aGMzTWdVMmx0Y0d4bFRrWlVLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHMTFjM1FnWW1VZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o2SUcxaGFXNWZZM0psWVhSbFgwNXZUM0JBTVRrS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhoa1pEWmtNekkzT0NBd2VEZG1NV1EwTTJVeElEQjRPV1psWlRjME1UZ2dNSGcxT0RsaVl6Tm1ZU0F3ZURoaE56YzNPRE01SURCNFkyWm1OalUzTjJVZ01IZzBNamswT1RRNFppQXdlREEyWkdNMVpqQTVJREI0TURWbU4yUTJOVFVnTUhnME5qa3dPVE0xTlNBd2VEazVZMlV5WldZM0lEQjRaVGt5WlRneU1UQWdNSGcwT1RZNU9XWTNOQ0F2THlCdFpYUm9iMlFnSW0xcGJuUW9ZV1JrY21WemN5eHpkSEpwYm1jcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKaWRYSnVLSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKMGNtRnVjMlpsY2loaFpHUnlaWE56TEhWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSjBjbUZ1YzJabGNsOW1jbTl0S0dGa1pISmxjM01zWVdSa2NtVnpjeXgxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaVltRnNZVzVqWlY5dlppaGhaR1J5WlhOektYVnBiblEyTkNJc0lHMWxkR2h2WkNBaWIzZHVaWEpmYjJZb2RXbHVkRFkwS1dGa1pISmxjM01pTENCdFpYUm9iMlFnSW1kbGRGOXVZVzFsS0NsemRISnBibWNpTENCdFpYUm9iMlFnSW1kbGRGOXplVzFpYjJ3b0tYTjBjbWx1WnlJc0lHMWxkR2h2WkNBaVoyVjBYM1Z5YVNoMWFXNTBOalFwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0puWlhSZmRHOTBZV3hmYzNWd2NHeDVLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbk5sZEY5dGFXNTBaWElvWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSm5aWFJmWTNWeWNtVnVkRjkwYjJ0bGJsOXBaQ2dwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0psZUdsemRITW9kV2x1ZERZMEtXSnZiMndpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdGFXNTBJR0oxY200Z2RISmhibk5tWlhJZ2RISmhibk5tWlhKZlpuSnZiU0JpWVd4aGJtTmxYMjltSUc5M2JtVnlYMjltSUdkbGRGOXVZVzFsSUdkbGRGOXplVzFpYjJ3Z1oyVjBYM1Z5YVNCblpYUmZkRzkwWVd4ZmMzVndjR3g1SUhObGRGOXRhVzUwWlhJZ1oyVjBYMk4xY25KbGJuUmZkRzlyWlc1ZmFXUWdaWGhwYzNSekNpQWdJQ0JsY25JS0NtMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU1UazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVnpjMmx2Ymk5amIyNTBjbUZqZEM1d2VUbzFDaUFnSUNBdkx5QmpiR0Z6Y3lCVGFXMXdiR1ZPUmxRb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR1ZtTjJRd01tWmxJQzh2SUcxbGRHaHZaQ0FpYVc1cGRHbGhiR2w2WlNoemRISnBibWNzYzNSeWFXNW5MSE4wY21sdVp5eGhaR1J5WlhOektYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCcGJtbDBhV0ZzYVhwbENpQWdJQ0JsY25JS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjMlZ6YzJsdmJpNWpiMjUwY21GamRDNVRhVzF3YkdWT1JsUXVhVzVwZEdsaGJHbDZaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21sdWFYUnBZV3hwZW1VNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWemMybHZiaTlqYjI1MGNtRmpkQzV3ZVRveU9Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaGhiR3h2ZDE5aFkzUnBiMjV6UFZzaVRtOVBjQ0pkTENCamNtVmhkR1U5SW5KbGNYVnBjbVVpS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0F5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQndkWE5vYVc1MElESWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWemMybHZiaTlqYjI1MGNtRmpkQzV3ZVRvek5DMHpOZ29nSUNBZ0x5OGdJeUJPYjNSbE9pQlRkSEpwYm1jZ2RtRnNhV1JoZEdsdmJpQnBjeUJrYjI1bElHSjVJSFJvWlNCQlVrTTBJR1p5WVcxbGQyOXlhd29nSUNBZ0x5OGdJeUJGYlhCMGVTQnpkSEpwYm1keklIZHBiR3dnWW1VZ1kyRjFaMmgwSUdKNUlIUm9aU0JtY21GdFpYZHZjbXNnZG1Gc2FXUmhkR2x2YmdvZ0lDQWdMeThnYzJWc1ppNTBiMnRsYmw5dVlXMWxJRDBnYm1GdFpRb2dJQ0FnWW5sMFpXTWdOaUF2THlBaWRHOXJaVzVmYm1GdFpTSUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WlhOemFXOXVMMk52Ym5SeVlXTjBMbkI1T2pNM0NpQWdJQ0F2THlCelpXeG1MblJ2YTJWdVgzTjViV0p2YkNBOUlITjViV0p2YkFvZ0lDQWdZbmwwWldNZ055QXZMeUFpZEc5clpXNWZjM2x0WW05c0lnb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sYzNOcGIyNHZZMjl1ZEhKaFkzUXVjSGs2TXpnS0lDQWdJQzh2SUhObGJHWXVkRzlyWlc1ZmRYSnBJRDBnZFhKcENpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKMGIydGxibDkxY21raUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZ6YzJsdmJpOWpiMjUwY21GamRDNXdlVG96T1FvZ0lDQWdMeThnYzJWc1ppNXRhVzUwWlhJZ1BTQnRhVzUwWlhJS0lDQWdJR0o1ZEdWaklEUWdMeThnSW0xcGJuUmxjaUlLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZ6YzJsdmJpOWpiMjUwY21GamRDNXdlVG8wTVMwME1nb2dJQ0FnTHk4Z0l5QkpibWwwYVdGc2FYcGxJR052ZFc1MFpYSnpDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYM04xY0hCc2VTQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkRzkwWVd4ZmMzVndjR3g1SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZ6YzJsdmJpOWpiMjUwY21GamRDNXdlVG8wTXdvZ0lDQWdMeThnYzJWc1ppNXVaWGgwWDNSdmEyVnVYMmxrSUQwZ1ZVbHVkRFkwS0RFcENpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKdVpYaDBYM1J2YTJWdVgybGtJZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVnpjMmx2Ymk5amIyNTBjbUZqZEM1d2VUbzBOQW9nSUNBZ0x5OGdjMlZzWmk1amRYSnlaVzUwWDNSdmEyVnVYMmxrSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKamRYSnlaVzUwWDNSdmEyVnVYMmxrSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZ6YzJsdmJpOWpiMjUwY21GamRDNXdlVG95T1FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoaGJHeHZkMTloWTNScGIyNXpQVnNpVG05UGNDSmRMQ0JqY21WaGRHVTlJbkpsY1hWcGNtVWlLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1elpYTnphVzl1TG1OdmJuUnlZV04wTGxOcGJYQnNaVTVHVkM1dGFXNTBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYldsdWREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpYTnphVzl1TDJOdmJuUnlZV04wTG5CNU9qUTJDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdjSFZ6YUdsdWRDQXlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVnpjMmx2Ymk5amIyNTBjbUZqZEM1d2VUbzFNZ29nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNXRhVzUwWlhJc0lDSlBibXg1SUcxcGJuUmxjaUJqWVc0Z2JXbHVkQ0JPUmxSeklnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbTFwYm5SbGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV0YVc1MFpYSWdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ2JXbHVkR1Z5SUdOaGJpQnRhVzUwSUU1R1ZITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpYTnphVzl1TDJOdmJuUnlZV04wTG5CNU9qVXpDaUFnSUNBdkx5QmhjM05sY25RZ2RHOGdJVDBnUVdOamIzVnVkQ2dwTENBaVEyRnVibTkwSUcxcGJuUWdkRzhnZW1WeWJ5QmhaR1J5WlhOeklnb2dJQ0FnWkhWd0NpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lDRTlDaUFnSUNCaGMzTmxjblFnTHk4Z1EyRnVibTkwSUcxcGJuUWdkRzhnZW1WeWJ5QmhaR1J5WlhOekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWemMybHZiaTlqYjI1MGNtRmpkQzV3ZVRvMU5pMDFOd29nSUNBZ0x5OGdJeUJEYUdWamF5QnBaaUIzWlNCaGJISmxZV1I1SUdoaGRtVWdZVzRnVGtaVUlDaG1iM0lnYzJsdVoyeGxJRTVHVkNCcGJYQnNaVzFsYm5SaGRHbHZiaWtLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG5SdmRHRnNYM04xY0hCc2VTQTlQU0JWU1c1ME5qUW9NQ2tzSUNKVWFHbHpJR052Ym5SeVlXTjBJSE4xY0hCdmNuUnpJSE5wYm1kc1pTQk9SbFFnYjI1c2VTSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMGIzUmhiRjl6ZFhCd2JIa2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5MFlXeGZjM1Z3Y0d4NUlHVjRhWE4wY3dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklGUm9hWE1nWTI5dWRISmhZM1FnYzNWd2NHOXlkSE1nYzJsdVoyeGxJRTVHVkNCdmJteDVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVnpjMmx2Ymk5amIyNTBjbUZqZEM1d2VUbzFPUzAyTUFvZ0lDQWdMeThnSXlCQmMzTnBaMjRnZEc5clpXNGdTVVFLSUNBZ0lDOHZJSFJ2YTJWdVgybGtJRDBnYzJWc1ppNXVaWGgwWDNSdmEyVnVYMmxrQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTlNBdkx5QWlibVY0ZEY5MGIydGxibDlwWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXVaWGgwWDNSdmEyVnVYMmxrSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxjM05wYjI0dlkyOXVkSEpoWTNRdWNIazZOakl0TmpNS0lDQWdJQzh2SUNNZ1ZYQmtZWFJsSUhOMFlYUmxDaUFnSUNBdkx5QnpaV3htTG1OMWNuSmxiblJmYjNkdVpYSWdQU0IwYndvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWTNWeWNtVnVkRjl2ZDI1bGNpSUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WlhOemFXOXVMMk52Ym5SeVlXTjBMbkI1T2pZMENpQWdJQ0F2THlCelpXeG1MbU4xY25KbGJuUmZkRzlyWlc1ZmFXUWdQU0IwYjJ0bGJsOXBaQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZM1Z5Y21WdWRGOTBiMnRsYmw5cFpDSUtJQ0FnSUdScFp5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxjM05wYjI0dlkyOXVkSEpoWTNRdWNIazZOalVLSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmYzNWd2NHeDVJRDBnYzJWc1ppNTBiM1JoYkY5emRYQndiSGtnS3lCVlNXNTBOalFvTVNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0owYjNSaGJGOXpkWEJ3YkhraUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkRzkwWVd4ZmMzVndjR3g1SUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5SdmRHRnNYM04xY0hCc2VTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVnpjMmx2Ymk5amIyNTBjbUZqZEM1d2VUbzJOZ29nSUNBZ0x5OGdjMlZzWmk1dVpYaDBYM1J2YTJWdVgybGtJRDBnYzJWc1ppNXVaWGgwWDNSdmEyVnVYMmxrSUNzZ1ZVbHVkRFkwS0RFcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpYm1WNGRGOTBiMnRsYmw5cFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV1WlhoMFgzUnZhMlZ1WDJsa0lHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltNWxlSFJmZEc5clpXNWZhV1FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sYzNOcGIyNHZZMjl1ZEhKaFkzUXVjSGs2TkRZS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV6WlhOemFXOXVMbU52Ym5SeVlXTjBMbE5wYlhCc1pVNUdWQzVpZFhKdVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZblZ5YmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WlhOemFXOXVMMk52Ym5SeVlXTjBMbkI1T2pjd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaWE56YVc5dUwyTnZiblJ5WVdOMExuQjVPamMyQ2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCelpXeG1MbU4xY25KbGJuUmZiM2R1WlhJc0lDSlBibXg1SUc5M2JtVnlJR05oYmlCaWRYSnVJRTVHVkNJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmpkWEp5Wlc1MFgyOTNibVZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtTjFjbkpsYm5SZmIzZHVaWElnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2diM2R1WlhJZ1kyRnVJR0oxY200Z1RrWlVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVnpjMmx2Ymk5amIyNTBjbUZqZEM1d2VUbzNOd29nSUNBZ0x5OGdZWE56WlhKMElIUnZhMlZ1WDJsa0lEMDlJSE5sYkdZdVkzVnljbVZ1ZEY5MGIydGxibDlwWkN3Z0lrbHVkbUZzYVdRZ2RHOXJaVzRnU1VRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWTNWeWNtVnVkRjkwYjJ0bGJsOXBaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1amRYSnlaVzUwWDNSdmEyVnVYMmxrSUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCSmJuWmhiR2xrSUhSdmEyVnVJRWxFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZ6YzJsdmJpOWpiMjUwY21GamRDNXdlVG8zT0FvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdWRHOTBZV3hmYzNWd2NHeDVJRDRnVlVsdWREWTBLREFwTENBaVRtOGdUa1pVY3lCMGJ5QmlkWEp1SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblJ2ZEdGc1gzTjFjSEJzZVNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5emRYQndiSGtnWlhocGMzUnpDaUFnSUNCaGMzTmxjblFnTHk4Z1RtOGdUa1pVY3lCMGJ5QmlkWEp1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZ6YzJsdmJpOWpiMjUwY21GamRDNXdlVG80TUMwNE1Rb2dJQ0FnTHk4Z0l5QlZjR1JoZEdVZ2MzUmhkR1VLSUNBZ0lDOHZJSE5sYkdZdVkzVnljbVZ1ZEY5dmQyNWxjaUE5SUVGalkyOTFiblFvS1NBZ0l5QlNaWE5sZENCMGJ5QjZaWEp2SUdGa1pISmxjM01LSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbU4xY25KbGJuUmZiM2R1WlhJaUNpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZ6YzJsdmJpOWpiMjUwY21GamRDNXdlVG80TWdvZ0lDQWdMeThnYzJWc1ppNWpkWEp5Wlc1MFgzUnZhMlZ1WDJsa0lEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmpkWEp5Wlc1MFgzUnZhMlZ1WDJsa0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWemMybHZiaTlqYjI1MGNtRmpkQzV3ZVRvNE13b2dJQ0FnTHk4Z2MyVnNaaTUwYjNSaGJGOXpkWEJ3YkhrZ1BTQnpaV3htTG5SdmRHRnNYM04xY0hCc2VTQXRJRlZKYm5RMk5DZ3hLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0luUnZkR0ZzWDNOMWNIQnNlU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIzUmhiRjl6ZFhCd2JIa2daWGhwYzNSekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkRzkwWVd4ZmMzVndjR3g1SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WlhOemFXOXVMMk52Ym5SeVlXTjBMbkI1T2pjd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11YzJWemMybHZiaTVqYjI1MGNtRmpkQzVUYVcxd2JHVk9SbFF1ZEhKaGJuTm1aWEpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMGNtRnVjMlpsY2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WlhOemFXOXVMMk52Ym5SeVlXTjBMbkI1T2pnMUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxjM05wYjI0dlkyOXVkSEpoWTNRdWNIazZPVEFLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUhObGJHWXVZM1Z5Y21WdWRGOXZkMjVsY2l3Z0lrOXViSGtnYjNkdVpYSWdZMkZ1SUhSeVlXNXpabVZ5SUU1R1ZDSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0pqZFhKeVpXNTBYMjkzYm1WeUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbU4xY25KbGJuUmZiM2R1WlhJZ1pYaHBjM1J6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUc5M2JtVnlJR05oYmlCMGNtRnVjMlpsY2lCT1JsUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpYTnphVzl1TDJOdmJuUnlZV04wTG5CNU9qa3hDaUFnSUNBdkx5QmhjM05sY25RZ2RHOGdJVDBnUVdOamIzVnVkQ2dwTENBaVEyRnVibTkwSUhSeVlXNXpabVZ5SUhSdklIcGxjbThnWVdSa2NtVnpjeUlLSUNBZ0lHUnBaeUF5Q2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtJQ0FnSUNFOUNpQWdJQ0JoYzNObGNuUWdMeThnUTJGdWJtOTBJSFJ5WVc1elptVnlJSFJ2SUhwbGNtOGdZV1JrY21WemN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObGMzTnBiMjR2WTI5dWRISmhZM1F1Y0hrNk9USUtJQ0FnSUM4dklHRnpjMlZ5ZENCMGIydGxibDlwWkNBOVBTQnpaV3htTG1OMWNuSmxiblJmZEc5clpXNWZhV1FzSUNKSmJuWmhiR2xrSUhSdmEyVnVJRWxFSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbU4xY25KbGJuUmZkRzlyWlc1ZmFXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WTNWeWNtVnVkRjkwYjJ0bGJsOXBaQ0JsZUdsemRITUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkpiblpoYkdsa0lIUnZhMlZ1SUVsRUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWemMybHZiaTlqYjI1MGNtRmpkQzV3ZVRvNU13b2dJQ0FnTHk4Z1lYTnpaWEowSUhSdklDRTlJSE5sYkdZdVkzVnljbVZ1ZEY5dmQyNWxjaXdnSWtOaGJtNXZkQ0IwY21GdWMyWmxjaUIwYnlCellXMWxJR0ZrWkhKbGMzTWlDaUFnSUNCa2FXY2dNUW9nSUNBZ0lUMEtJQ0FnSUdGemMyVnlkQ0F2THlCRFlXNXViM1FnZEhKaGJuTm1aWElnZEc4Z2MyRnRaU0JoWkdSeVpYTnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVnpjMmx2Ymk5amIyNTBjbUZqZEM1d2VUbzVOUzA1TmdvZ0lDQWdMeThnSXlCVmNHUmhkR1VnYjNkdVpYSnphR2x3Q2lBZ0lDQXZMeUJ6Wld4bUxtTjFjbkpsYm5SZmIzZHVaWElnUFNCMGJ3b2dJQ0FnWW5sMFpXTmZNaUF2THlBaVkzVnljbVZ1ZEY5dmQyNWxjaUlLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZ6YzJsdmJpOWpiMjUwY21GamRDNXdlVG80TlFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbk5sYzNOcGIyNHVZMjl1ZEhKaFkzUXVVMmx0Y0d4bFRrWlVMblJ5WVc1elptVnlYMlp5YjIxYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBjbUZ1YzJabGNsOW1jbTl0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sYzNOcGIyNHZZMjl1ZEhKaFkzUXVjSGs2T1RnS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd2JpQXlDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sYzNOcGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRBekNpQWdJQ0F2THlCaGMzTmxjblFnWm5KdmJWOWhZMk52ZFc1MElEMDlJSE5sYkdZdVkzVnljbVZ1ZEY5dmQyNWxjaXdnSWtaeWIyMGdZV05qYjNWdWRDQnBjeUJ1YjNRZ2RHaGxJRzkzYm1WeUlnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1OMWNuSmxiblJmYjNkdVpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WTNWeWNtVnVkRjl2ZDI1bGNpQmxlR2x6ZEhNS0lDQWdJR1JwWnlBekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRVp5YjIwZ1lXTmpiM1Z1ZENCcGN5QnViM1FnZEdobElHOTNibVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZ6YzJsdmJpOWpiMjUwY21GamRDNXdlVG94TURRS0lDQWdJQzh2SUdGemMyVnlkQ0IwYnlBaFBTQkJZMk52ZFc1MEtDa3NJQ0pEWVc1dWIzUWdkSEpoYm5ObVpYSWdkRzhnZW1WeWJ5QmhaR1J5WlhOeklnb2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUNFOUNpQWdJQ0JoYzNObGNuUWdMeThnUTJGdWJtOTBJSFJ5WVc1elptVnlJSFJ2SUhwbGNtOGdZV1JrY21WemN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObGMzTnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UQTFDaUFnSUNBdkx5QmhjM05sY25RZ2RHOXJaVzVmYVdRZ1BUMGdjMlZzWmk1amRYSnlaVzUwWDNSdmEyVnVYMmxrTENBaVNXNTJZV3hwWkNCMGIydGxiaUJKUkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pqZFhKeVpXNTBYM1J2YTJWdVgybGtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1OMWNuSmxiblJmZEc5clpXNWZhV1FnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVsdWRtRnNhV1FnZEc5clpXNGdTVVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaWE56YVc5dUwyTnZiblJ5WVdOMExuQjVPakV3TmdvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ1puSnZiVjloWTJOdmRXNTBJRzl5SUZSNGJpNXpaVzVrWlhJZ1BUMGdjMlZzWmk1dGFXNTBaWElzSUNKT2IzUWdZWFYwYUc5eWFYcGxaQ0IwYnlCMGNtRnVjMlpsY2lJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaWJub2dkSEpoYm5ObVpYSmZabkp2YlY5aWIyOXNYM1J5ZFdWQU13b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbTFwYm5SbGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV0YVc1MFpYSWdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZbm9nZEhKaGJuTm1aWEpmWm5KdmJWOWliMjlzWDJaaGJITmxRRFFLQ25SeVlXNXpabVZ5WDJaeWIyMWZZbTl2YkY5MGNuVmxRRE02Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9LZEhKaGJuTm1aWEpmWm5KdmJWOWliMjlzWDIxbGNtZGxRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZ6YzJsdmJpOWpiMjUwY21GamRDNXdlVG94TURZS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlHWnliMjFmWVdOamIzVnVkQ0J2Y2lCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdWJXbHVkR1Z5TENBaVRtOTBJR0YxZEdodmNtbDZaV1FnZEc4Z2RISmhibk5tWlhJaUNpQWdJQ0JoYzNObGNuUWdMeThnVG05MElHRjFkR2h2Y21sNlpXUWdkRzhnZEhKaGJuTm1aWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaWE56YVc5dUwyTnZiblJ5WVdOMExuQjVPakV3TndvZ0lDQWdMeThnWVhOelpYSjBJSFJ2SUNFOUlHWnliMjFmWVdOamIzVnVkQ3dnSWtOaGJtNXZkQ0IwY21GdWMyWmxjaUIwYnlCellXMWxJR0ZrWkhKbGMzTWlDaUFnSUNCa2RYQnVJRElLSUNBZ0lHUnBaeUF6Q2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowSUM4dklFTmhibTV2ZENCMGNtRnVjMlpsY2lCMGJ5QnpZVzFsSUdGa1pISmxjM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaWE56YVc5dUwyTnZiblJ5WVdOMExuQjVPakV3T1MweE1UQUtJQ0FnSUM4dklDTWdWWEJrWVhSbElHOTNibVZ5YzJocGNBb2dJQ0FnTHk4Z2MyVnNaaTVqZFhKeVpXNTBYMjkzYm1WeUlEMGdkRzhLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbU4xY25KbGJuUmZiM2R1WlhJaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObGMzTnBiMjR2WTI5dWRISmhZM1F1Y0hrNk9UZ0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LZEhKaGJuTm1aWEpmWm5KdmJWOWliMjlzWDJaaGJITmxRRFE2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQjBjbUZ1YzJabGNsOW1jbTl0WDJKdmIyeGZiV1Z5WjJWQU5Rb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV6WlhOemFXOXVMbU52Ym5SeVlXTjBMbE5wYlhCc1pVNUdWQzVpWVd4aGJtTmxYMjltVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1ltRnNZVzVqWlY5dlpqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpYTnphVzl1TDJOdmJuUnlZV04wTG5CNU9qRXhNZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaWE56YVc5dUwyTnZiblJ5WVdOMExuQjVPakV4T0FvZ0lDQWdMeThnWVhOelpYSjBJR0ZqWTI5MWJuUWdJVDBnUVdOamIzVnVkQ2dwTENBaVdtVnlieUJoWkdSeVpYTnpJR2hoY3lCdWJ5QmlZV3hoYm1ObElnb2dJQ0FnWkhWd0NpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lDRTlDaUFnSUNCaGMzTmxjblFnTHk4Z1dtVnlieUJoWkdSeVpYTnpJR2hoY3lCdWJ5QmlZV3hoYm1ObENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWemMybHZiaTlqYjI1MGNtRmpkQzV3ZVRveE1qQUtJQ0FnSUM4dklHbG1JR0ZqWTI5MWJuUWdQVDBnYzJWc1ppNWpkWEp5Wlc1MFgyOTNibVZ5SUdGdVpDQnpaV3htTG5SdmRHRnNYM04xY0hCc2VTQStJRlZKYm5RMk5DZ3dLVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmpkWEp5Wlc1MFgyOTNibVZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtTjFjbkpsYm5SZmIzZHVaWElnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWW5vZ1ltRnNZVzVqWlY5dlpsOWhablJsY2w5cFpsOWxiSE5sUURRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0owYjNSaGJGOXpkWEJ3YkhraUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkRzkwWVd4ZmMzVndjR3g1SUdWNGFYTjBjd29nSUNBZ1lub2dZbUZzWVc1alpWOXZabDloWm5SbGNsOXBabDlsYkhObFFEUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpYTnphVzl1TDJOdmJuUnlZV04wTG5CNU9qRXlNUW9nSUNBZ0x5OGdjbVYwZFhKdUlGVkpiblEyTkNneEtRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0NtSmhiR0Z1WTJWZmIyWmZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE11YzJWemMybHZiaTVqYjI1MGNtRmpkQzVUYVcxd2JHVk9SbFF1WW1Gc1lXNWpaVjl2WmtBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObGMzTnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1URXlDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ21KaGJHRnVZMlZmYjJaZllXWjBaWEpmYVdaZlpXeHpaVUEwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sYzNOcGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRJeUNpQWdJQ0F2THlCeVpYUjFjbTRnVlVsdWREWTBLREFwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxjM05wYjI0dlkyOXVkSEpoWTNRdWNIazZNVEV5Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR0lnWW1Gc1lXNWpaVjl2Wmw5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5NXpaWE56YVc5dUxtTnZiblJ5WVdOMExsTnBiWEJzWlU1R1ZDNWlZV3hoYm1ObFgyOW1RRFVLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWMyVnpjMmx2Ymk1amIyNTBjbUZqZEM1VGFXMXdiR1ZPUmxRdWIzZHVaWEpmYjJaYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHZkMjVsY2w5dlpqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpYTnphVzl1TDJOdmJuUnlZV04wTG5CNU9qRXlOQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWemMybHZiaTlqYjI1MGNtRmpkQzV3ZVRveE1qa0tJQ0FnSUM4dklHRnpjMlZ5ZENCMGIydGxibDlwWkNBOVBTQnpaV3htTG1OMWNuSmxiblJmZEc5clpXNWZhV1FzSUNKSmJuWmhiR2xrSUhSdmEyVnVJRWxFSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbU4xY25KbGJuUmZkRzlyWlc1ZmFXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WTNWeWNtVnVkRjkwYjJ0bGJsOXBaQ0JsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnU1c1MllXeHBaQ0IwYjJ0bGJpQkpSQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxjM05wYjI0dlkyOXVkSEpoWTNRdWNIazZNVE13Q2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1MGIzUmhiRjl6ZFhCd2JIa2dQaUJWU1c1ME5qUW9NQ2tzSUNKT1JsUWdaRzlsY3lCdWIzUWdaWGhwYzNRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZEc5MFlXeGZjM1Z3Y0d4NUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gzTjFjSEJzZVNCbGVHbHpkSE1LSUNBZ0lHRnpjMlZ5ZENBdkx5Qk9SbFFnWkc5bGN5QnViM1FnWlhocGMzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpYTnphVzl1TDJOdmJuUnlZV04wTG5CNU9qRXpNZ29nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1WTNWeWNtVnVkRjl2ZDI1bGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1OMWNuSmxiblJmYjNkdVpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WTNWeWNtVnVkRjl2ZDI1bGNpQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WlhOemFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFeU5Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5ObGMzTnBiMjR1WTI5dWRISmhZM1F1VTJsdGNHeGxUa1pVTG1kbGRGOXVZVzFsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBYMjVoYldVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWemMybHZiaTlqYjI1MGNtRmpkQzV3ZVRveE16Y0tJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MblJ2YTJWdVgyNWhiV1VLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEySUM4dklDSjBiMnRsYmw5dVlXMWxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SdmEyVnVYMjVoYldVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZ6YzJsdmJpOWpiMjUwY21GamRDNXdlVG94TXpRS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjMlZ6YzJsdmJpNWpiMjUwY21GamRDNVRhVzF3YkdWT1JsUXVaMlYwWDNONWJXSnZiRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGOXplVzFpYjJ3NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWemMybHZiaTlqYjI1MGNtRmpkQzV3ZVRveE5ESUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MblJ2YTJWdVgzTjViV0p2YkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJblJ2YTJWdVgzTjViV0p2YkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiMnRsYmw5emVXMWliMndnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVnpjMmx2Ymk5amIyNTBjbUZqZEM1d2VUb3hNemtLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWMyVnpjMmx2Ymk1amIyNTBjbUZqZEM1VGFXMXdiR1ZPUmxRdVoyVjBYM1Z5YVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRjkxY21rNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWemMybHZiaTlqYjI1MGNtRmpkQzV3ZVRveE5EUUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sYzNOcGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRRM0NpQWdJQ0F2THlCaGMzTmxjblFnZEc5clpXNWZhV1FnUFQwZ2MyVnNaaTVqZFhKeVpXNTBYM1J2YTJWdVgybGtMQ0FpU1c1MllXeHBaQ0IwYjJ0bGJpQkpSQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmpkWEp5Wlc1MFgzUnZhMlZ1WDJsa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbU4xY25KbGJuUmZkRzlyWlc1ZmFXUWdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRWx1ZG1Gc2FXUWdkRzlyWlc0Z1NVUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpYTnphVzl1TDJOdmJuUnlZV04wTG5CNU9qRTBPQW9nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1ZEc5clpXNWZkWEpwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nT0NBdkx5QWlkRzlyWlc1ZmRYSnBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SdmEyVnVYM1Z5YVNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaWE56YVc5dUwyTnZiblJ5WVdOMExuQjVPakUwTkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXpaWE56YVc5dUxtTnZiblJ5WVdOMExsTnBiWEJzWlU1R1ZDNW5aWFJmZEc5MFlXeGZjM1Z3Y0d4NVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwWDNSdmRHRnNYM04xY0hCc2VUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpYTnphVzl1TDJOdmJuUnlZV04wTG5CNU9qRTFNd29nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1ZEc5MFlXeGZjM1Z3Y0d4NUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZEc5MFlXeGZjM1Z3Y0d4NUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gzTjFjSEJzZVNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaWE56YVc5dUwyTnZiblJ5WVdOMExuQjVPakUxTUFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbk5sYzNOcGIyNHVZMjl1ZEhKaFkzUXVVMmx0Y0d4bFRrWlVMbk5sZEY5dGFXNTBaWEpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwelpYUmZiV2x1ZEdWeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObGMzTnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UVTFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxjM05wYjI0dlkyOXVkSEpoWTNRdWNIazZNVFl3Q2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCelpXeG1MbTFwYm5SbGNpd2dJazl1YkhrZ1kzVnljbVZ1ZENCdGFXNTBaWElnWTJGdUlITmxkQ0J1WlhjZ2JXbHVkR1Z5SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltMXBiblJsY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXRhVzUwWlhJZ1pYaHBjM1J6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUdOMWNuSmxiblFnYldsdWRHVnlJR05oYmlCelpYUWdibVYzSUcxcGJuUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxjM05wYjI0dlkyOXVkSEpoWTNRdWNIazZNVFl4Q2lBZ0lDQXZMeUJoYzNObGNuUWdibVYzWDIxcGJuUmxjaUFoUFNCQlkyTnZkVzUwS0Nrc0lDSkRZVzV1YjNRZ2MyVjBJRzFwYm5SbGNpQjBieUI2WlhKdklHRmtaSEpsYzNNaUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowSUM4dklFTmhibTV2ZENCelpYUWdiV2x1ZEdWeUlIUnZJSHBsY204Z1lXUmtjbVZ6Y3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sYzNOcGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRZeUNpQWdJQ0F2THlCaGMzTmxjblFnYm1WM1gyMXBiblJsY2lBaFBTQnpaV3htTG0xcGJuUmxjaXdnSWs1bGR5QnRhVzUwWlhJZ2JYVnpkQ0JpWlNCa2FXWm1aWEpsYm5RaUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnSVQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJPWlhjZ2JXbHVkR1Z5SUcxMWMzUWdZbVVnWkdsbVptVnlaVzUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZ6YzJsdmJpOWpiMjUwY21GamRDNXdlVG94TmpRS0lDQWdJQzh2SUhObGJHWXViV2x1ZEdWeUlEMGdibVYzWDIxcGJuUmxjZ29nSUNBZ1lubDBaV01nTkNBdkx5QWliV2x1ZEdWeUlnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpYTnphVzl1TDJOdmJuUnlZV04wTG5CNU9qRTFOUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuTmxjM05wYjI0dVkyOXVkSEpoWTNRdVUybHRjR3hsVGtaVUxtZGxkRjlqZFhKeVpXNTBYM1J2YTJWdVgybGtXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgyTjFjbkpsYm5SZmRHOXJaVzVmYVdRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWemMybHZiaTlqYjI1MGNtRmpkQzV3ZVRveE5qa0tJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbU4xY25KbGJuUmZkRzlyWlc1ZmFXUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKamRYSnlaVzUwWDNSdmEyVnVYMmxrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtTjFjbkpsYm5SZmRHOXJaVzVmYVdRZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZ6YzJsdmJpOWpiMjUwY21GamRDNXdlVG94TmpZS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV6WlhOemFXOXVMbU52Ym5SeVlXTjBMbE5wYlhCc1pVNUdWQzVsZUdsemRITmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BsZUdsemRITTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVnpjMmx2Ymk5amIyNTBjbUZqZEM1d2VUb3hOekVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObGMzTnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UYzBDaUFnSUNBdkx5QnlaWFIxY200Z2RHOXJaVzVmYVdRZ1BUMGdjMlZzWmk1amRYSnlaVzUwWDNSdmEyVnVYMmxrSUdGdVpDQnpaV3htTG5SdmRHRnNYM04xY0hCc2VTQStJRlZKYm5RMk5DZ3dLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltTjFjbkpsYm5SZmRHOXJaVzVmYVdRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZM1Z5Y21WdWRGOTBiMnRsYmw5cFpDQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmllaUJsZUdsemRITmZZbTl2YkY5bVlXeHpaVUEwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkRzkwWVd4ZmMzVndjR3g1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnZkR0ZzWDNOMWNIQnNlU0JsZUdsemRITUtJQ0FnSUdKNklHVjRhWE4wYzE5aWIyOXNYMlpoYkhObFFEUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENncGxlR2x6ZEhOZlltOXZiRjl0WlhKblpVQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxjM05wYjI0dlkyOXVkSEpoWTNRdWNIazZNVGN4Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ21WNGFYTjBjMTlpYjI5c1gyWmhiSE5sUURRNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJsZUdsemRITmZZbTl2YkY5dFpYSm5aVUExQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFZ0NDWUpESFJ2ZEdGc1gzTjFjSEJzZVJCamRYSnlaVzUwWDNSdmEyVnVYMmxrRFdOMWNuSmxiblJmYjNkdVpYSUVGUjk4ZFFadGFXNTBaWElOYm1WNGRGOTBiMnRsYmw5cFpBcDBiMnRsYmw5dVlXMWxESFJ2YTJWdVgzTjViV0p2YkFsMGIydGxibDkxY21reEdFQUFJaWNHZ0FCbkp3ZUFBR2NuQ0lBQVp5Z2laeWNGSTJjbkJESURaeW95QTJjcEltY3hHUlJFTVJoQkFHT0NEUVRkYlRKNEJIOGRRK0VFbis1MEdBUlltOFA2QklwM2VEa0V6L1pYZmdSQ2xKU1BCQWJjWHdrRUJmZldWUVJHa0pOVkJKbk9MdmNFNlM2Q0VBUkphWjkwTmhvQWpnMEFhUUM2QU9nQkd3RnVBWllCdEFISEFkb0IvQUlIQWlzQ05nQ0FCTzk5QXY0MkdnQ09BUUFCQURZYUFVa2lXWUVDQ0VzQkZSSkVWd0lBTmhvQ1NTSlpnUUlJU3dFVkVrUlhBZ0EyR2dOSklsbUJBZ2hMQVJVU1JGY0NBRFlhQkVrVkpCSkVKd1pQQkdjbkIwOERaeWNJVHdKbkp3Uk1aeWdpWnljRkkyY3BJbWNqUXpZYUFVa1ZKQkpFTmhvQ1NTSlpnUUlJVEJVU1JERUFJaWNFWlVRU1JFa3lBeE5FSWlobFJCUkVJaWNGWlVRcVR3Sm5LVXNCWnlJb1pVUWpDQ2hNWnlJbkJXVkVJd2duQlV4bkZpdE1VTEFqUXpZYUFVa1ZKUkpFRnpFQUlpcGxSQkpFSWlsbFJCSkVJaWhsUkVRcU1nTm5LU0puSWlobFJDTUpLRXhuSTBNMkdnRkpGU1FTUkRZYUFra1ZKUkpFRnpFQUlpcGxSRXhMQVJKRVN3SXlBeE5FSWlsbFJFOENFa1JMQVJORUtreG5JME0yR2dGSEFoVWtFa1EyR2dKSlRnSkpGU1FTUkRZYUEwa1ZKUkpFRnlJcVpVUkxBeEpFTWdOUEFoTkVJaWxsUkJKRU1RQVNRQUFMTVFBaUp3UmxSQkpCQUEwalJFY0NTd01UUkNwTVp5TkRJa0wvOERZYUFVa1ZKQkpFU1RJREUwUWlLbVZFRWtFQUR5SW9aVVJCQUFnakZpdE1VTEFqUXlKQy8vVTJHZ0ZKRlNVU1JCY2lLV1ZFRWtRaUtHVkVSQ0lxWlVRclRGQ3dJME1pSndabFJFa1ZGbGNHQWt4UUsweFFzQ05ESWljSFpVUkpGUlpYQmdKTVVDdE1VTEFqUXpZYUFVa1ZKUkpFRnlJcFpVUVNSQ0luQ0dWRVNSVVdWd1lDVEZBclRGQ3dJME1pS0dWRUZpdE1VTEFqUXpZYUFVa1ZKQkpFTVFBaUp3UmxSRXhMQVJKRVN3RXlBeE5FU3dFVFJDY0VUR2NqUXlJcFpVUVdLMHhRc0NORE5ob0JTUlVsRWtRWElpbGxSQkpCQUJVaUtHVkVRUUFPSTRBQkFDSlBBbFFyVEZDd0kwTWlRdi92IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
