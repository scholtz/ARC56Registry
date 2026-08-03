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

namespace Arc56.Generated.Aviiral07.Fianza.FianzaEscrow_8de96dc8
{


    //
    // 
    //    Fianza Rental Escrow Smart Contract
    //    ------------------------------------
    //    Status values:
    //      0 = UNFUNDED
    //      1 = FUNDED
    //      2 = DISPUTED
    //    
    //
    public class FianzaEscrowProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public FianzaEscrowProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Called once by the tenant to register the landlord address.
        ///</summary>
        /// <param name="landlord"> </param>
        public async Task<string> SetLandlord(Algorand.Address landlord, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 46, 253, 116, 19 };
            var landlordAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); landlordAbi.From(landlord);

            var result = await base.CallApp(new List<object> { abiHandle, landlordAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> SetLandlord_Transactions(Algorand.Address landlord, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 46, 253, 116, 19 };
            var landlordAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); landlordAbi.From(landlord);

            return await base.MakeTransactionList(new List<object> { abiHandle, landlordAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Tenant sends ALGO to lock deposit.
        ///</summary>
        public async Task<string> FundDeposit(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 162, 111, 177 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> FundDeposit_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 162, 111, 177 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Tenant stores IPFS CID on-chain.
        ///</summary>
        /// <param name="cid"> </param>
        public async Task<string> StoreCid(string cid, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 226, 186, 64, 209 };
            var cidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); cidAbi.From(cid);

            var result = await base.CallApp(new List<object> { abiHandle, cidAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> StoreCid_Transactions(string cid, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 226, 186, 64, 209 };
            var cidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); cidAbi.From(cid);

            return await base.MakeTransactionList(new List<object> { abiHandle, cidAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Landlord releases deposit back to tenant.
        ///</summary>
        public async Task<string> ReleaseDeposit(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 35, 215, 24 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> ReleaseDeposit_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 35, 215, 24 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Landlord freezes the escrow.
        ///</summary>
        public async Task<string> RaiseDispute(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 124, 63, 216, 157 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> RaiseDispute_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 124, 63, 216, 157 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns current escrow status.
        ///</summary>
        public async Task<string> GetStatus(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 135, 75, 223, 192 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetStatus_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 135, 75, 223, 192 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns locked deposit amount in microALGO.
        ///</summary>
        public async Task<ulong> GetDepositAmount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 195, 141, 92 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetDepositAmount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 195, 141, 92 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns stored IPFS CID.
        ///</summary>
        public async Task<string> GetCid(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 61, 188, 100 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetCid_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 61, 188, 100 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRmlhbnphRXNjcm93IiwiZGVzYyI6IlxuICAgIEZpYW56YSBSZW50YWwgRXNjcm93IFNtYXJ0IENvbnRyYWN0XG4gICAgLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tXG4gICAgU3RhdHVzIHZhbHVlczpcbiAgICAgIDAgPSBVTkZVTkRFRFxuICAgICAgMSA9IEZVTkRFRFxuICAgICAgMiA9IERJU1BVVEVEXG4gICAgIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6InNldF9sYW5kbG9yZCIsImRlc2MiOiJDYWxsZWQgb25jZSBieSB0aGUgdGVuYW50IHRvIHJlZ2lzdGVyIHRoZSBsYW5kbG9yZCBhZGRyZXNzLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibGFuZGxvcmQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJmdW5kX2RlcG9zaXQiLCJkZXNjIjoiVGVuYW50IHNlbmRzIEFMR08gdG8gbG9jayBkZXBvc2l0LiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InN0b3JlX2NpZCIsImRlc2MiOiJUZW5hbnQgc3RvcmVzIElQRlMgQ0lEIG9uLWNoYWluLiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWxlYXNlX2RlcG9zaXQiLCJkZXNjIjoiTGFuZGxvcmQgcmVsZWFzZXMgZGVwb3NpdCBiYWNrIHRvIHRlbmFudC4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyYWlzZV9kaXNwdXRlIiwiZGVzYyI6IkxhbmRsb3JkIGZyZWV6ZXMgdGhlIGVzY3Jvdy4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfc3RhdHVzIiwiZGVzYyI6IlJldHVybnMgY3VycmVudCBlc2Nyb3cgc3RhdHVzLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2RlcG9zaXRfYW1vdW50IiwiZGVzYyI6IlJldHVybnMgbG9ja2VkIGRlcG9zaXQgYW1vdW50IGluIG1pY3JvQUxHTy4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9jaWQiLCJkZXNjIjoiUmV0dXJucyBzdG9yZWQgSVBGUyBDSUQuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjN9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE4MiwyMzNdLCJlcnJvck1lc3NhZ2UiOiJBbHJlYWR5IGZ1bmRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4NiwzMjYsMzg5XSwiZXJyb3JNZXNzYWdlIjoiRXNjcm93IG11c3QgYmUgRlVOREVEIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQzXSwiZXJyb3JNZXNzYWdlIjoiTXVzdCBzZW5kIEFMR08iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTddLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGxhbmRsb3JkIGNhbiByYWlzZSBkaXNwdXRlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzM0XSwiZXJyb3JNZXNzYWdlIjoiT25seSBsYW5kbG9yZCBjYW4gcmVsZWFzZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5NV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgdGVuYW50IGNhbiBzdG9yZSBDSUQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzhdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmRlcG9zaXRfYW1vdW50IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzMiwzOTVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmxhbmRsb3JkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4MywzMjMsMzg2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5zdGF0dXMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjkzLDM0M10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudGVuYW50IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdNZ29nSUNBZ1lubDBaV05pYkc5amF5QWljM1JoZEhWeklpQWlaR1Z3YjNOcGRGOWhiVzkxYm5RaUlDSnNZVzVrYkc5eVpDSWdJbTF2ZG1WZmFXNWZZMmxrSWlBaWRHVnVZVzUwSWlBd2VERTFNV1kzWXpjMUlEQjRNREF3TUNBd2VEQXdNRGcxTlRSbE5EWTFOVFJsTkRRME5UUTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptbGhibnBoWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRvMUNpQWdJQ0F2THlCamJHRnpjeUJHYVdGdWVtRkZjMk55YjNjb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURFM0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhneVpXWmtOelF4TXlBd2VHRTJZVEkyWm1JeElEQjRaVEppWVRRd1pERWdNSGhpWVRJelpEY3hPQ0F3ZURkak0yWmtPRGxrSURCNE9EYzBZbVJtWXpBZ01IZzJOV016T0dRMVl5QXdlRE13TTJSaVl6WTBJQzh2SUcxbGRHaHZaQ0FpYzJWMFgyeGhibVJzYjNKa0tHRmtaSEpsYzNNcGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKbWRXNWtYMlJsY0c5emFYUW9LWE4wY21sdVp5SXNJRzFsZEdodlpDQWljM1J2Y21WZlkybGtLSE4wY21sdVp5bHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0luSmxiR1ZoYzJWZlpHVndiM05wZENncGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKeVlXbHpaVjlrYVhOd2RYUmxLQ2x6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJbWRsZEY5emRHRjBkWE1vS1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpWjJWMFgyUmxjRzl6YVhSZllXMXZkVzUwS0NsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGRGOWphV1FvS1hOMGNtbHVaeUlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUhObGRGOXNZVzVrYkc5eVpDQm1kVzVrWDJSbGNHOXphWFFnYzNSdmNtVmZZMmxrSUhKbGJHVmhjMlZmWkdWd2IzTnBkQ0J5WVdselpWOWthWE53ZFhSbElHZGxkRjl6ZEdGMGRYTWdaMlYwWDJSbGNHOXphWFJmWVcxdmRXNTBJR2RsZEY5amFXUUtJQ0FnSUdWeWNnb0tiV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF4TnpvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbVpwWVc1NllWOWxjMk55YjNjdVkyOXVkSEpoWTNRdVJtbGhibnBoUlhOamNtOTNMbk5sZEY5c1lXNWtiRzl5WkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRjlzWVc1a2JHOXlaRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1hV0Z1ZW1GZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qSXlDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm1saGJucGhYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG95TlFvZ0lDQWdMeThnYzNSaGRIVnpMQ0JsZUdsemRITWdQU0J6Wld4bUxuTjBZWFIxY3k1dFlYbGlaU2dwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWljM1JoZEhWeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm1saGJucGhYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG95TmdvZ0lDQWdMeThnYVdZZ1pYaHBjM1J6T2dvZ0lDQWdZbm9nYzJWMFgyeGhibVJzYjNKa1gyRm1kR1Z5WDJsbVgyVnNjMlZBTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlpwWVc1NllWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNamNLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpkR0YwZFhNZ1BUMGdWVWx1ZERZMEtEQXBMQ0FpUVd4eVpXRmtlU0JtZFc1a1pXUWlDaUFnSUNCa2RYQUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJCYkhKbFlXUjVJR1oxYm1SbFpBb0tjMlYwWDJ4aGJtUnNiM0prWDJGbWRHVnlYMmxtWDJWc2MyVkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1hV0Z1ZW1GZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qSTRDaUFnSUNBdkx5QnpaV3htTG14aGJtUnNiM0prTG5aaGJIVmxJRDBnYkdGdVpHeHZjbVFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbXhoYm1Sc2IzSmtJZ29nSUNBZ1pHbG5JRE1LSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabWxoYm5waFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3lPUW9nSUNBZ0x5OGdhV1lnYm05MElHVjRhWE4wY3pvS0lDQWdJR1JwWnlBeENpQWdJQ0JpYm5vZ2MyVjBYMnhoYm1Sc2IzSmtYMkZtZEdWeVgybG1YMlZzYzJWQU5Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJacFlXNTZZVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TXpBS0lDQWdJQzh2SUhObGJHWXVjM1JoZEhWekxuWmhiSFZsSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKemRHRjBkWE1pQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1hV0Z1ZW1GZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qTXhDaUFnSUNBdkx5QnpaV3htTG1SbGNHOXphWFJmWVcxdmRXNTBMblpoYkhWbElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmtaWEJ2YzJsMFgyRnRiM1Z1ZENJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlpwWVc1NllWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNeklLSUNBZ0lDOHZJSE5sYkdZdWJXOTJaVjlwYmw5amFXUXVkbUZzZFdVZ1BTQlRkSEpwYm1jb0lpSXBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSnRiM1psWDJsdVgyTnBaQ0lLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdNSGd3TURBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb0tjMlYwWDJ4aGJtUnNiM0prWDJGbWRHVnlYMmxtWDJWc2MyVkFOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1hV0Z1ZW1GZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qSXlDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05UQXdNR00wWXpZeE5tVTJORFpqTm1ZM01qWTBNakEzTXpZMU56UUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVtYVdGdWVtRmZaWE5qY205M0xtTnZiblJ5WVdOMExrWnBZVzU2WVVWelkzSnZkeTVtZFc1a1gyUmxjRzl6YVhSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG1kVzVrWDJSbGNHOXphWFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabWxoYm5waFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3pPQW9nSUNBZ0x5OGdjM1JoZEhWekxDQmxlR2x6ZEhNZ1BTQnpaV3htTG5OMFlYUjFjeTV0WVhsaVpTZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWMzUmhkSFZ6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWFXRnVlbUZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pNNUNpQWdJQ0F2THlCcFppQmxlR2x6ZEhNNkNpQWdJQ0JpZWlCbWRXNWtYMlJsY0c5emFYUmZZV1owWlhKZmFXWmZaV3h6WlVBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm1saGJucGhYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG8wTUFvZ0lDQWdMeThnWVhOelpYSjBJSE4wWVhSMWN5QTlQU0JWU1c1ME5qUW9NQ2tzSUNKQmJISmxZV1I1SUdaMWJtUmxaQ0lLSUNBZ0lHUjFjQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUVGc2NtVmhaSGtnWm5WdVpHVmtDZ3BtZFc1a1gyUmxjRzl6YVhSZllXWjBaWEpmYVdaZlpXeHpaVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlpwWVc1NllWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZOREVLSUNBZ0lDOHZJSE5sYkdZdWRHVnVZVzUwTG5aaGJIVmxJRDBnVkhodUxuTmxibVJsY2dvZ0lDQWdZbmwwWldNZ05DQXZMeUFpZEdWdVlXNTBJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWFXRnVlbUZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pReUNpQWdJQ0F2THlCd1lYa2dQU0J2Y0M1SFZIaHVMbUZ0YjNWdWRDZ3dLUW9nSUNBZ1ozUjRiaUF3SUVGdGIzVnVkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWnBZVzU2WVY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk5ETUtJQ0FnSUM4dklHRnpjMlZ5ZENCd1lYa2dQaUJWU1c1ME5qUW9NQ2tzSUNKTmRYTjBJSE5sYm1RZ1FVeEhUeUlLSUNBZ0lHUjFjQW9nSUNBZ1lYTnpaWEowSUM4dklFMTFjM1FnYzJWdVpDQkJURWRQQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabWxoYm5waFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUbzBOQW9nSUNBZ0x5OGdjMlZzWmk1a1pYQnZjMmwwWDJGdGIzVnVkQzUyWVd4MVpTQTlJSEJoZVFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWkdWd2IzTnBkRjloYlc5MWJuUWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWnBZVzU2WVY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk5EVUtJQ0FnSUM4dklITmxiR1l1YzNSaGRIVnpMblpoYkhWbElEMGdWVWx1ZERZMEtERXBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnpkR0YwZFhNaUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltYVdGdWVtRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPak0xQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0dGc2JHOTNYMkZqZEdsdmJuTTlXeUpPYjA5d0lsMHBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05UQXdNRFkwTmpVMU5HVTBORFExTkRRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NW1hV0Z1ZW1GZlpYTmpjbTkzTG1OdmJuUnlZV04wTGtacFlXNTZZVVZ6WTNKdmR5NXpkRzl5WlY5amFXUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6ZEc5eVpWOWphV1E2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabWxoYm5waFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUbzBPQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJacFlXNTZZVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TlRFS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxuTjBZWFIxY3k1MllXeDFaU0E5UFNCVlNXNTBOalFvTVNrc0lDSkZjMk55YjNjZ2JYVnpkQ0JpWlNCR1ZVNUVSVVFpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWljM1JoZEhWeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1Mbk4wWVhSMWN5QmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFVnpZM0p2ZHlCdGRYTjBJR0psSUVaVlRrUkZSQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWnBZVzU2WVY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk5USUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdWRHVnVZVzUwTG5aaGJIVmxMQ0FpVDI1c2VTQjBaVzVoYm5RZ1kyRnVJSE4wYjNKbElFTkpSQ0lLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKMFpXNWhiblFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHVnVZVzUwSUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJSFJsYm1GdWRDQmpZVzRnYzNSdmNtVWdRMGxFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabWxoYm5waFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUbzFNd29nSUNBZ0x5OGdjMlZzWmk1dGIzWmxYMmx1WDJOcFpDNTJZV3gxWlNBOUlHTnBaQW9nSUNBZ1lubDBaV05mTXlBdkx5QWliVzkyWlY5cGJsOWphV1FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlpwWVc1NllWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZORGdLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFNREF3WVRRek5EazBOREl3TnpNM05EWm1OekkyTlRZMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVabWxoYm5waFgyVnpZM0p2ZHk1amIyNTBjbUZqZEM1R2FXRnVlbUZGYzJOeWIzY3VjbVZzWldGelpWOWtaWEJ2YzJsMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVZzWldGelpWOWtaWEJ2YzJsME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJacFlXNTZZVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TlRrS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxuTjBZWFIxY3k1MllXeDFaU0E5UFNCVlNXNTBOalFvTVNrc0lDSkZjMk55YjNjZ2JYVnpkQ0JpWlNCR1ZVNUVSVVFpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWljM1JoZEhWeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1Mbk4wWVhSMWN5QmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFVnpZM0p2ZHlCdGRYTjBJR0psSUVaVlRrUkZSQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWnBZVzU2WVY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk5qQUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdWJHRnVaR3h2Y21RdWRtRnNkV1VzSUNKUGJteDVJR3hoYm1Sc2IzSmtJR05oYmlCeVpXeGxZWE5sSWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0lteGhibVJzYjNKa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbXhoYm1Sc2IzSmtJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHeGhibVJzYjNKa0lHTmhiaUJ5Wld4bFlYTmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptbGhibnBoWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRvMk1Rb2dJQ0FnTHk4Z1lXMXZkVzUwSUQwZ2MyVnNaaTVrWlhCdmMybDBYMkZ0YjNWdWRDNTJZV3gxWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbVJsY0c5emFYUmZZVzF2ZFc1MElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbVJsY0c5emFYUmZZVzF2ZFc1MElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlpwWVc1NllWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZOaklLSUNBZ0lDOHZJSFJsYm1GdWRDQTlJSE5sYkdZdWRHVnVZVzUwTG5aaGJIVmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWRHVnVZVzUwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUmxibUZ1ZENCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1hV0Z1ZW1GZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qWXpMVFkzQ2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTlkR1Z1WVc1MExBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMWhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFZWSmJuUTJOQ2d4TURBd0tTd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WalpXbDJaWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRVzF2ZFc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm1saGJucGhYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG8yTXdvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnYVc1MFkxOHhJQzh2SUhCaGVRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlpwWVc1NllWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZOallLSUNBZ0lDOHZJR1psWlQxVlNXNTBOalFvTVRBd01Da3NDaUFnSUNCd2RYTm9hVzUwSURFd01EQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptbGhibnBoWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRvMk15MDJOd29nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeVBYUmxibUZ1ZEN3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROVlXMXZkVzUwTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDFWU1c1ME5qUW9NVEF3TUNrc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlpwWVc1NllWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZOamdLSUNBZ0lDOHZJSE5sYkdZdWMzUmhkSFZ6TG5aaGJIVmxJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p6ZEdGMGRYTWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWFXRnVlbUZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pZNUNpQWdJQ0F2THlCelpXeG1MbVJsY0c5emFYUmZZVzF2ZFc1MExuWmhiSFZsSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKa1pYQnZjMmwwWDJGdGIzVnVkQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWnBZVzU2WVY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk5UWUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMU1EQXdPRFV5TkRVMFl6UTFOREUxTXpRMU5EUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVtYVdGdWVtRmZaWE5qY205M0xtTnZiblJ5WVdOMExrWnBZVzU2WVVWelkzSnZkeTV5WVdselpWOWthWE53ZFhSbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbUZwYzJWZlpHbHpjSFYwWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltYVdGdWVtRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPamMxQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1emRHRjBkWE11ZG1Gc2RXVWdQVDBnVlVsdWREWTBLREVwTENBaVJYTmpjbTkzSUcxMWMzUWdZbVVnUmxWT1JFVkVJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0luTjBZWFIxY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXpkR0YwZFhNZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCRmMyTnliM2NnYlhWemRDQmlaU0JHVlU1RVJVUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWFXRnVlbUZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pjMkNpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQnpaV3htTG14aGJtUnNiM0prTG5aaGJIVmxMQ0FpVDI1c2VTQnNZVzVrYkc5eVpDQmpZVzRnY21GcGMyVWdaR2x6Y0hWMFpTSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0pzWVc1a2JHOXlaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1c1lXNWtiRzl5WkNCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0JzWVc1a2JHOXlaQ0JqWVc0Z2NtRnBjMlVnWkdsemNIVjBaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWnBZVzU2WVY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk56Y0tJQ0FnSUM4dklITmxiR1l1YzNSaGRIVnpMblpoYkhWbElEMGdWVWx1ZERZMEtESXBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnpkR0YwZFhNaUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltYVdGdWVtRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPamN5Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOVEF3TURnME5EUTVOVE0xTURVMU5UUTBOVFEwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVptbGhibnBoWDJWelkzSnZkeTVqYjI1MGNtRmpkQzVHYVdGdWVtRkZjMk55YjNjdVoyVjBYM04wWVhSMWMxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5emRHRjBkWE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabWxoYm5waFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUbzRNd29nSUNBZ0x5OGdjM1JoZEhWekxDQmxlR2x6ZEhNZ1BTQnpaV3htTG5OMFlYUjFjeTV0WVhsaVpTZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWMzUmhkSFZ6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWFXRnVlbUZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pnMENpQWdJQ0F2THlCcFppQnViM1FnWlhocGMzUnpPZ29nSUNBZ1ltNTZJR2RsZEY5emRHRjBkWE5mWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptbGhibnBoWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRvNE5Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUZOMGNtbHVaeWdpVlU1R1ZVNUVSVVFpS1FvZ0lDQWdZbmwwWldNZ055QXZMeUF3ZURBd01EZzFOVFJsTkRZMU5UUmxORFEwTlRRMENncG5aWFJmYzNSaGRIVnpYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TG1acFlXNTZZVjlsYzJOeWIzY3VZMjl1ZEhKaFkzUXVSbWxoYm5waFJYTmpjbTkzTG1kbGRGOXpkR0YwZFhOQU9Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWFXRnVlbUZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pnd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwblpYUmZjM1JoZEhWelgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltYVdGdWVtRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPamcyQ2lBZ0lDQXZMeUJwWmlCemRHRjBkWE1nUFQwZ1ZVbHVkRFkwS0RFcE9nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHSjZJR2RsZEY5emRHRjBkWE5mWVdaMFpYSmZhV1pmWld4elpVQTFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptbGhibnBoWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRvNE53b2dJQ0FnTHk4Z2NtVjBkWEp1SUZOMGNtbHVaeWdpUmxWT1JFVkVJaWtLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURZME5qVTFOR1UwTkRRMU5EUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWFXRnVlbUZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pnd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmlJR2RsZEY5emRHRjBkWE5mWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdVptbGhibnBoWDJWelkzSnZkeTVqYjI1MGNtRmpkQzVHYVdGdWVtRkZjMk55YjNjdVoyVjBYM04wWVhSMWMwQTRDZ3BuWlhSZmMzUmhkSFZ6WDJGbWRHVnlYMmxtWDJWc2MyVkFOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1hV0Z1ZW1GZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qZzRDaUFnSUNBdkx5QnBaaUJ6ZEdGMGRYTWdQVDBnVlVsdWREWTBLRElwT2dvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ1BUMEtJQ0FnSUdKNklHZGxkRjl6ZEdGMGRYTmZZV1owWlhKZmFXWmZaV3h6WlVBM0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm1saGJucGhYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG80T1FvZ0lDQWdMeThnY21WMGRYSnVJRk4wY21sdVp5Z2lSRWxUVUZWVVJVUWlLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3T0RRME5EazFNelV3TlRVMU5EUTFORFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1hV0Z1ZW1GZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qZ3dDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JpSUdkbGRGOXpkR0YwZFhOZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXVabWxoYm5waFgyVnpZM0p2ZHk1amIyNTBjbUZqZEM1R2FXRnVlbUZGYzJOeWIzY3VaMlYwWDNOMFlYUjFjMEE0Q2dwblpYUmZjM1JoZEhWelgyRm1kR1Z5WDJsbVgyVnNjMlZBTnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltYVdGdWVtRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPamt3Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdVM1J5YVc1bktDSlZUa1pWVGtSRlJDSXBDaUFnSUNCaWVYUmxZeUEzSUM4dklEQjRNREF3T0RVMU5HVTBOalUxTkdVME5EUTFORFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1hV0Z1ZW1GZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qZ3dDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JpSUdkbGRGOXpkR0YwZFhOZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXVabWxoYm5waFgyVnpZM0p2ZHk1amIyNTBjbUZqZEM1R2FXRnVlbUZGYzJOeWIzY3VaMlYwWDNOMFlYUjFjMEE0Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtWnBZVzU2WVY5bGMyTnliM2N1WTI5dWRISmhZM1F1Um1saGJucGhSWE5qY205M0xtZGxkRjlrWlhCdmMybDBYMkZ0YjNWdWRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5a1pYQnZjMmwwWDJGdGIzVnVkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1hV0Z1ZW1GZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qazFDaUFnSUNBdkx5QmhiVzkxYm5Rc0lHVjRhWE4wY3lBOUlITmxiR1l1WkdWd2IzTnBkRjloYlc5MWJuUXViV0Y1WW1Vb0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1SbGNHOXphWFJmWVcxdmRXNTBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltYVdGdWVtRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPamsyQ2lBZ0lDQXZMeUJwWmlCdWIzUWdaWGhwYzNSek9nb2dJQ0FnWW01NklHZGxkRjlrWlhCdmMybDBYMkZ0YjNWdWRGOWhablJsY2w5cFpsOWxiSE5sUURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltYVdGdWVtRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPamszQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdWVWx1ZERZMEtEQXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb0taMlYwWDJSbGNHOXphWFJmWVcxdmRXNTBYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TG1acFlXNTZZVjlsYzJOeWIzY3VZMjl1ZEhKaFkzUXVSbWxoYm5waFJYTmpjbTkzTG1kbGRGOWtaWEJ2YzJsMFgyRnRiM1Z1ZEVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJacFlXNTZZVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2T1RJS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ21kbGRGOWtaWEJ2YzJsMFgyRnRiM1Z1ZEY5aFpuUmxjbDlwWmw5bGJITmxRRE02Q2lBZ0lDQmtkWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1hV0Z1ZW1GZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qa3lDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JpSUdkbGRGOWtaWEJ2YzJsMFgyRnRiM1Z1ZEY5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5NW1hV0Z1ZW1GZlpYTmpjbTkzTG1OdmJuUnlZV04wTGtacFlXNTZZVVZ6WTNKdmR5NW5aWFJmWkdWd2IzTnBkRjloYlc5MWJuUkFOQW9LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1bWFXRnVlbUZmWlhOamNtOTNMbU52Ym5SeVlXTjBMa1pwWVc1NllVVnpZM0p2ZHk1blpYUmZZMmxrVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBYMk5wWkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltYVdGdWVtRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakV3TXdvZ0lDQWdMeThnWTJsa0xDQmxlR2x6ZEhNZ1BTQnpaV3htTG0xdmRtVmZhVzVmWTJsa0xtMWhlV0psS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p0YjNabFgybHVYMk5wWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptbGhibnBoWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveE1EUUtJQ0FnSUM4dklHbG1JRzV2ZENCbGVHbHpkSE02Q2lBZ0lDQmlibm9nWjJWMFgyTnBaRjloWm5SbGNsOXBabDlsYkhObFFETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWFXRnVlbUZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pFd05Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUZOMGNtbHVaeWdpSWlrS0lDQWdJR0o1ZEdWaklEWWdMeThnTUhnd01EQXdDZ3BuWlhSZlkybGtYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TG1acFlXNTZZVjlsYzJOeWIzY3VZMjl1ZEhKaFkzUXVSbWxoYm5waFJYTmpjbTkzTG1kbGRGOWphV1JBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltYVdGdWVtRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakV3TUFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1lubDBaV01nTlNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LWjJWMFgyTnBaRjloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWFXRnVlbUZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pFd01Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZaUJuWlhSZlkybGtYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TG1acFlXNTZZVjlsYzJOeWIzY3VZMjl1ZEhKaFkzUXVSbWxoYm5waFJYTmpjbTkzTG1kbGRGOWphV1JBTkFvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QURBQUVDSmdnR2MzUmhkSFZ6RG1SbGNHOXphWFJmWVcxdmRXNTBDR3hoYm1Sc2IzSmtDMjF2ZG1WZmFXNWZZMmxrQm5SbGJtRnVkQVFWSDN4MUFnQUFDZ0FJVlU1R1ZVNUVSVVF4RzBFQVJ6RVpGRVF4R0VTQ0NBUXUvWFFUQkthaWI3RUU0cnBBMFFTNkk5Y1lCSHcvMkowRWgwdmZ3QVJsdzQxY0JEQTl2R1EyR2dDT0NBQUpBRWtBY3dDb0FPY0JEQUZJQVZzQU1Sa1VNUmdVRUVNMkdnRkpGWUVnRWtRaUtHVkpUd0pNUVFBRFNSUkVLa3NEWjBzQlFBQUtLQ0puS1NKbkt5Y0daNEFTRlI5OGRRQU1UR0Z1Wkd4dmNtUWdjMlYwc0NORElpaGxRUUFEU1JSRUp3UXhBR2N6QUFoSlJDbE1aeWdqWjRBTUZSOThkUUFHUmxWT1JFVkVzQ05ETmhvQlNTSlpKQWhMQVJVU1JDSW9aVVFqRWtReEFDSW5CR1ZFRWtRclRHZUFFQlVmZkhVQUNrTkpSQ0J6ZEc5eVpXU3dJME1pS0dWRUl4SkVNUUFpS21WRUVrUWlLV1ZFSWljRVpVU3hzZ2V5Q0NPeUVJSG9CN0lCc3lnaVp5a2laNEFPRlI5OGRRQUlVa1ZNUlVGVFJVU3dJME1pS0dWRUl4SkVNUUFpS21WRUVrUW9KR2VBRGhVZmZIVUFDRVJKVTFCVlZFVkVzQ05ESWlobFFBQUpKd2NuQlV4UXNDTkRTU01TUVFBTmdBZ0FCa1pWVGtSRlJFTC81a2trRWtFQUQ0QUtBQWhFU1ZOUVZWUkZSRUwvMFNjSFF2L01JaWxsUUFBSkloWW5CVXhRc0NORFNVTC85Q0lyWlVBQUNTY0dKd1ZNVUxBalEwbEMvL1U9IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
