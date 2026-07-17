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

namespace Arc56.Generated.algorandfoundation.puya_ts_demo.ZkWhitelistContract_cf061af1
{


    public class ZkWhitelistContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ZkWhitelistContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        public async Task Create(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 223, 58, 84 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 223, 58, 84 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Update(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 232, 24, 114 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Update_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 232, 24, 114 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task OptInOrOut(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 147, 0, 170, 226 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptInOrOut_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 147, 0, 170, 226 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="address"> </param>
        /// <param name="proof"> </param>
        public async Task<string> AddAddressToWhitelist(Algorand.Address address, Algorand.Address[] proof, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 203, 119, 192, 122 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);
            var proofAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); proofAbi.From(proof);

            var result = await base.CallApp(new List<object> { abiHandle, addressAbi, proofAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> AddAddressToWhitelist_Transactions(Algorand.Address address, Algorand.Address[] proof, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 203, 119, 192, 122 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);
            var proofAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); proofAbi.From(proof);

            return await base.MakeTransactionList(new List<object> { abiHandle, addressAbi, proofAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="address"> </param>
        public async Task<bool> IsOnWhitelist(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 81, 118, 55, 198 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            var result = await base.CallApp(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsOnWhitelist_Transactions(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 81, 118, 55, 198 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            return await base.MakeTransactionList(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="appId"> </param>
        /// <param name="proof"> </param>
        /// <param name="publicInputs"> </param>
        public async Task<bool> VerifyProof(ulong appId, Algorand.Address[] proof, Algorand.Address[] publicInputs, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 7, 115, 241 };
            var appIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appIdAbi.From(appId);
            var proofAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); proofAbi.From(proof);
            var publicInputsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); publicInputsAbi.From(publicInputs);

            var result = await base.CallApp(new List<object> { abiHandle, appIdAbi, proofAbi, publicInputsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifyProof_Transactions(ulong appId, Algorand.Address[] proof, Algorand.Address[] publicInputs, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 7, 115, 241 };
            var appIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appIdAbi.From(appId);
            var proofAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); proofAbi.From(proof);
            var publicInputsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); publicInputsAbi.From(publicInputs);

            return await base.MakeTransactionList(new List<object> { abiHandle, appIdAbi, proofAbi, publicInputsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiWmtXaGl0ZWxpc3RDb250cmFjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJVcGRhdGVBcHBsaWNhdGlvbiIsIkRlbGV0ZUFwcGxpY2F0aW9uIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3B0SW5Pck91dCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk9wdEluIiwiQ2xvc2VPdXQiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhZGRBZGRyZXNzVG9XaGl0ZWxpc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3NbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb29mIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaXNPbldoaXRlbGlzdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2ZXJpZnlQcm9vZiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHBJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzc1tdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvb2YiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3NbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InB1YmxpY0lucHV0cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjoxLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzQyNF0sImVycm9yTWVzc2FnZSI6IkJ5dGVzIGhhcyB2YWxpZCBwcmVmaXgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNF0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4Ml0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIG9uZSBvZiBPcHRJbiwgQ2xvc2VPdXQgJiYgY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkzXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgb25lIG9mIFVwZGF0ZUFwcGxpY2F0aW9uLCBEZWxldGVBcHBsaWNhdGlvbiAmJiBjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzQ4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgTG9jYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJjYmxvY2tzIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQXdJRFlnVkUxUVRGOVdSVkpKUmtsRlVsOUJVRkJmU1VRS0lDQWdJR0o1ZEdWallteHZZMnNnTUhneE5URm1OMk0zTlNBd2VEQTJPREV3TVNBaWQyaHBkR1ZNYVhOMElpQXdlREF3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12ZW1zdGQyaHBkR1ZzYVhOMEwzcHJMWGRvYVhSbGJHbHpkQzVoYkdkdkxuUnpPakk1Q2lBZ0lDQXZMeUJsZUhCdmNuUWdaR1ZtWVhWc2RDQmpiR0Z6Y3lCYWExZG9hWFJsYkdsemRFTnZiblJ5WVdOMElHVjRkR1Z1WkhNZ1lYSmpOQzVEYjI1MGNtRmpkQ0I3Q2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0WVRCbE9ERTROeklnTUhnNU16QXdZV0ZsTWlBdkx5QnRaWFJvYjJRZ0luVndaR0YwWlNncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYjNCMFNXNVBjazkxZENncGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZkWEJrWVhSbFgzSnZkWFJsUURJZ2JXRnBibDl2Y0hSSmJrOXlUM1YwWDNKdmRYUmxRRE1LQ20xaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQTBPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM3ByTFhkb2FYUmxiR2x6ZEM5NmF5MTNhR2wwWld4cGMzUXVZV3huYnk1MGN6b3lPUW9nSUNBZ0x5OGdaWGh3YjNKMElHUmxabUYxYkhRZ1kyeGhjM01nV210WGFHbDBaV3hwYzNSRGIyNTBjbUZqZENCbGVIUmxibVJ6SUdGeVl6UXVRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJ0ZFhOMElHSmxJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVpQnRZV2x1WDJOeVpXRjBaVjlPYjA5d1FERXdDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRZMkkzTjJNd04yRWdNSGcxTVRjMk16ZGpOaUF3ZUdZeE1EYzNNMll4SUM4dklHMWxkR2h2WkNBaVlXUmtRV1JrY21WemMxUnZWMmhwZEdWc2FYTjBLR0ZrWkhKbGMzTXNZV1JrY21WemMxdGRLWE4wY21sdVp5SXNJRzFsZEdodlpDQWlhWE5QYmxkb2FYUmxiR2x6ZENoaFpHUnlaWE56S1dKdmIyd2lMQ0J0WlhSb2IyUWdJblpsY21sbWVWQnliMjltS0hWcGJuUTJOQ3hoWkdSeVpYTnpXMTBzWVdSa2NtVnpjMXRkS1dKdmIyd2lDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JoWkdSQlpHUnlaWE56Vkc5WGFHbDBaV3hwYzNRZ2FYTlBibGRvYVhSbGJHbHpkQ0IyWlhKcFpubFFjbTl2WmdvZ0lDQWdaWEp5Q2dwdFlXbHVYMk55WldGMFpWOU9iMDl3UURFd09nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzcHJMWGRvYVhSbGJHbHpkQzk2YXkxM2FHbDBaV3hwYzNRdVlXeG5ieTUwY3pveU9Rb2dJQ0FnTHk4Z1pYaHdiM0owSUdSbFptRjFiSFFnWTJ4aGMzTWdXbXRYYUdsMFpXeHBjM1JEYjI1MGNtRmpkQ0JsZUhSbGJtUnpJR0Z5WXpRdVEyOXVkSEpoWTNRZ2V3b2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1qQmtaak5oTlRRZ0x5OGdiV1YwYUc5a0lDSmpjbVZoZEdVb2MzUnlhVzVuS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JqY21WaGRHVUtJQ0FnSUdWeWNnb0tiV0ZwYmw5dmNIUkpiazl5VDNWMFgzSnZkWFJsUURNNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmVtc3RkMmhwZEdWc2FYTjBMM3ByTFhkb2FYUmxiR2x6ZEM1aGJHZHZMblJ6T2pRMUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2dZV3hzYjNkQlkzUnBiMjV6T2lCYklrOXdkRWx1SWl3Z0lrTnNiM05sVDNWMElsMGdmU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnphR3dLSUNBZ0lHbHVkR05mTWlBdkx5QTJDaUFnSUNBbUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0ppWUtJQ0FnSUhKbGRIVnliaUF2THlCdmJpQmxjbkp2Y2pvZ1QyNURiMjF3YkdWMGFXOXVJRzExYzNRZ1ltVWdiMjVsSUc5bUlFOXdkRWx1TENCRGJHOXpaVTkxZENBbUppQmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2dwdFlXbHVYM1Z3WkdGMFpWOXliM1YwWlVBeU9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzcHJMWGRvYVhSbGJHbHpkQzk2YXkxM2FHbDBaV3hwYzNRdVlXeG5ieTUwY3pvek9Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ1d5SlZjR1JoZEdWQmNIQnNhV05oZEdsdmJpSXNJQ0pFWld4bGRHVkJjSEJzYVdOaGRHbHZiaUpkSUgwcENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYzJoc0NpQWdJQ0J3ZFhOb2FXNTBJRFE0SUM4dklEUTRDaUFnSUNBbUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdiWFZ6ZENCaVpTQnZibVVnYjJZZ1ZYQmtZWFJsUVhCd2JHbGpZWFJwYjI0c0lFUmxiR1YwWlVGd2NHeHBZMkYwYVc5dUlDWW1JR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJR0lnZFhCa1lYUmxDZ29LTHk4Z1kyOXVkSEpoWTNSekwzcHJMWGRvYVhSbGJHbHpkQzk2YXkxM2FHbDBaV3hwYzNRdVlXeG5ieTUwY3pvNldtdFhhR2wwWld4cGMzUkRiMjUwY21GamRDNWpjbVZoZEdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpjbVZoZEdVNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmVtc3RkMmhwZEdWc2FYTjBMM3ByTFhkb2FYUmxiR2x6ZEM1aGJHZHZMblJ6T2pNd0NpQWdJQ0F2THlCaGNIQk9ZVzFsSUQwZ1IyeHZZbUZzVTNSaGRHVThZWEpqTkM1VGRISStLSHQ5S1RzS0lDQWdJSEIxYzJoaWVYUmxjeUFpWVhCd1RtRnRaU0lLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTk2YXkxM2FHbDBaV3hwYzNRdmVtc3RkMmhwZEdWc2FYTjBMbUZzWjI4dWRITTZNek1LSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCdmJrTnlaV0YwWlRvZ0luSmxjWFZwY21VaUlIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNBdkx5QmpiMjUwY21GamRITXZlbXN0ZDJocGRHVnNhWE4wTDNwckxYZG9hWFJsYkdsemRDNWhiR2R2TG5Sek9qTTJDaUFnSUNBdkx5QjBhR2x6TG1Gd2NFNWhiV1V1ZG1Gc2RXVWdQU0J1WVcxbE93b2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OTZheTEzYUdsMFpXeHBjM1F2ZW1zdGQyaHBkR1ZzYVhOMExtRnNaMjh1ZEhNNk16TUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ2YmtOeVpXRjBaVG9nSW5KbGNYVnBjbVVpSUgwcENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTI5dWRISmhZM1J6TDNwckxYZG9hWFJsYkdsemRDOTZheTEzYUdsMFpXeHBjM1F1WVd4bmJ5NTBjem82V210WGFHbDBaV3hwYzNSRGIyNTBjbUZqZEM1MWNHUmhkR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMWNHUmhkR1U2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12ZW1zdGQyaHBkR1ZzYVhOMEwzcHJMWGRvYVhSbGJHbHpkQzVoYkdkdkxuUnpPalF5Q2lBZ0lDQXZMeUJoYzNObGNuUW9SMnh2WW1Gc0xtTnlaV0YwYjNKQlpHUnlaWE56SUQwOVBTQlVlRzR1YzJWdVpHVnlLVHNLSUNBZ0lHZHNiMkpoYkNCRGNtVmhkRzl5UVdSa2NtVnpjd29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnUFQwS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5NmF5MTNhR2wwWld4cGMzUXZlbXN0ZDJocGRHVnNhWE4wTG1Gc1oyOHVkSE02TXprS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QmhiR3h2ZDBGamRHbHZibk02SUZzaVZYQmtZWFJsUVhCd2JHbGpZWFJwYjI0aUxDQWlSR1ZzWlhSbFFYQndiR2xqWVhScGIyNGlYU0I5S1FvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTI5dWRISmhZM1J6TDNwckxYZG9hWFJsYkdsemRDOTZheTEzYUdsMFpXeHBjM1F1WVd4bmJ5NTBjem82V210WGFHbDBaV3hwYzNSRGIyNTBjbUZqZEM1aFpHUkJaR1J5WlhOelZHOVhhR2wwWld4cGMzUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BoWkdSQlpHUnlaWE56Vkc5WGFHbDBaV3hwYzNRNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmVtc3RkMmhwZEdWc2FYTjBMM3ByTFhkb2FYUmxiR2x6ZEM1aGJHZHZMblJ6T2pVeENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtDbUZrWkVGa1pISmxjM05VYjFkb2FYUmxiR2x6ZEY5M2FHbHNaVjkwYjNCQU9Eb0tJQ0FnSUhCMWMyaHBiblFnTVRRMU1ERXdJQzh2SURFME5UQXhNQW9nSUNBZ1oyeHZZbUZzSUU5d1kyOWtaVUoxWkdkbGRBb2dJQ0FnUGdvZ0lDQWdZbm9nWVdSa1FXUmtjbVZ6YzFSdlYyaHBkR1ZzYVhOMFgyRm1kR1Z5WDNkb2FXeGxRREV6Q2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCcGJuUmpYeklnTHk4Z1lYQndiQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnY0hWemFHbHVkQ0ExSUM4dklFUmxiR1YwWlVGd2NHeHBZMkYwYVc5dUNpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQTJPREV3TVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCeWIzWmhiRkJ5YjJkeVlXMEtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dOamd4TURFS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdJZ1lXUmtRV1JrY21WemMxUnZWMmhwZEdWc2FYTjBYM2RvYVd4bFgzUnZjRUE0Q2dwaFpHUkJaR1J5WlhOelZHOVhhR2wwWld4cGMzUmZZV1owWlhKZmQyaHBiR1ZBTVRNNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmVtc3RkMmhwZEdWc2FYTjBMM3ByTFhkb2FYUmxiR2x6ZEM1aGJHZHZMblJ6T2pZMkNpQWdJQ0F2THlCdmNDNWllbVZ5Ynlnek1pa3VZbWwwZDJselpVOXlLRUo1ZEdWektFSnBaMVZwYm5Rb1lXUmtjbVZ6Y3k1aWVYUmxjeWtnSlNCamRYSjJaVTF2WkNrcExBb2dJQ0FnY0hWemFHbHVkQ0F6TWlBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHUnBaeUF5Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd6TURZME5HVTNNbVV4TXpGaE1ESTVZamcxTURRMVlqWTRNVGd4TlRnMVpESTRNek5sT0RRNE56bGlPVGN3T1RFME0yVXhaalU1TTJZd01EQXdNREF4Q2lBZ0lDQmlKUW9nSUNBZ1lud0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OTZheTEzYUdsMFpXeHBjM1F2ZW1zdGQyaHBkR1ZzYVhOMExtRnNaMjh1ZEhNNk56TUtJQ0FnSUM4dklHNWxkeUJoY21NMExrUjVibUZ0YVdOQmNuSmhlU2hoWkdSeVpYTnpUVzlrS1N3S0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01ERUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM3ByTFhkb2FYUmxiR2x6ZEM5NmF5MTNhR2wwWld4cGMzUXVZV3huYnk1MGN6bzNNUW9nSUNBZ0x5OGdWR1Z0Y0d4aGRHVldZWEk4ZFdsdWREWTBQaWdpVmtWU1NVWkpSVkpmUVZCUVgwbEVJaWtzQ2lBZ0lDQnBiblJqWHpNZ0x5OGdWRTFRVEY5V1JWSkpSa2xGVWw5QlVGQmZTVVFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTk2YXkxM2FHbDBaV3hwYzNRdmVtc3RkMmhwZEdWc2FYTjBMbUZzWjI4dWRITTZOekF0TnpRS0lDQWdJQzh2SUdOdmJuTjBJSFpsY21sbWFXVmtJRDBnZEdocGN5NTJaWEpwWm5sUWNtOXZaaWdLSUNBZ0lDOHZJQ0FnVkdWdGNHeGhkR1ZXWVhJOGRXbHVkRFkwUGlnaVZrVlNTVVpKUlZKZlFWQlFYMGxFSWlrc0NpQWdJQ0F2THlBZ0lIQnliMjltTEFvZ0lDQWdMeThnSUNCdVpYY2dZWEpqTkM1RWVXNWhiV2xqUVhKeVlYa29ZV1JrY21WemMwMXZaQ2tzQ2lBZ0lDQXZMeUFwT3dvZ0lDQWdaR2xuSURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyRnNiSE4xWWlCamIyNTBjbUZqZEhNdmVtc3RkMmhwZEdWc2FYTjBMM3ByTFhkb2FYUmxiR2x6ZEM1aGJHZHZMblJ6T2pwYWExZG9hWFJsYkdsemRFTnZiblJ5WVdOMExuWmxjbWxtZVZCeWIyOW1DaUFnSUNCd2IzQnVJRElLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTk2YXkxM2FHbDBaV3hwYzNRdmVtc3RkMmhwZEdWc2FYTjBMbUZzWjI4dWRITTZOelVLSUNBZ0lDOHZJR2xtSUNnaGRtVnlhV1pwWldRdWJtRjBhWFpsS1NCN0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0JpYm5vZ1lXUmtRV1JrY21WemMxUnZWMmhwZEdWc2FYTjBYMkZtZEdWeVgybG1YMlZzYzJWQU13b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzcHJMWGRvYVhSbGJHbHpkQzk2YXkxM2FHbDBaV3hwYzNRdVlXeG5ieTUwY3pvM05nb2dJQ0FnTHk4Z2NtVjBkWEp1SUc1bGR5QmhjbU0wTGxOMGNpZ2lVSEp2YjJZZ2RtVnlhV1pwWTJGMGFXOXVJR1poYVd4bFpDSXBPd29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF4T1RVd056STJaalptTmpZeU1EYzJOalUzTWpZNU5qWTJPVFl6TmpFM05EWTVObVkyWlRJd05qWTJNVFk1Tm1NMk5UWTBDZ3BoWkdSQlpHUnlaWE56Vkc5WGFHbDBaV3hwYzNSZllXWjBaWEpmYVc1c2FXNWxaRjlqYjI1MGNtRmpkSE12ZW1zdGQyaHBkR1ZzYVhOMEwzcHJMWGRvYVhSbGJHbHpkQzVoYkdkdkxuUnpPanBhYTFkb2FYUmxiR2x6ZEVOdmJuUnlZV04wTG1Ga1pFRmtaSEpsYzNOVWIxZG9hWFJsYkdsemRFQTJPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM3ByTFhkb2FYUmxiR2x6ZEM5NmF5MTNhR2wwWld4cGMzUXVZV3huYnk1MGN6bzFNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwaFpHUkJaR1J5WlhOelZHOVhhR2wwWld4cGMzUmZZV1owWlhKZmFXWmZaV3h6WlVBek9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzcHJMWGRvYVhSbGJHbHpkQzk2YXkxM2FHbDBaV3hwYzNRdVlXeG5ieTUwY3pvNE1Bb2dJQ0FnTHk4Z2FXWWdLRlI0Ymk1elpXNWtaWElnSVQwOUlHRmpZMjkxYm5RcElIc0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1JwWnlBeUNpQWdJQ0FoUFFvZ0lDQWdZbm9nWVdSa1FXUmtjbVZ6YzFSdlYyaHBkR1ZzYVhOMFgyRm1kR1Z5WDJsbVgyVnNjMlZBTlFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNwckxYZG9hWFJsYkdsemRDOTZheTEzYUdsMFpXeHBjM1F1WVd4bmJ5NTBjem80TVFvZ0lDQWdMeThnY21WMGRYSnVJRzVsZHlCaGNtTTBMbE4wY2lnaVUyVnVaR1Z5SUdGa1pISmxjM01nWkc5bGN5QnViM1FnYldGMFkyZ2dZWFYwYUc5eWFYcGxaQ0JoWkdSeVpYTnpJaWs3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURNd05UTTJOVFpsTmpRMk5UY3lNakEyTVRZME5qUTNNalkxTnpNM016SXdOalEyWmpZMU56TXlNRFpsTm1ZM05ESXdObVEyTVRjME5qTTJPREl3TmpFM05UYzBOamcyWmpjeU5qazNZVFkxTmpReU1EWXhOalEyTkRjeU5qVTNNemN6Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12ZW1zdGQyaHBkR1ZzYVhOMEwzcHJMWGRvYVhSbGJHbHpkQzVoYkdkdkxuUnpPalV4Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR0lnWVdSa1FXUmtjbVZ6YzFSdlYyaHBkR1ZzYVhOMFgyRm1kR1Z5WDJsdWJHbHVaV1JmWTI5dWRISmhZM1J6TDNwckxYZG9hWFJsYkdsemRDOTZheTEzYUdsMFpXeHBjM1F1WVd4bmJ5NTBjem82V210WGFHbDBaV3hwYzNSRGIyNTBjbUZqZEM1aFpHUkJaR1J5WlhOelZHOVhhR2wwWld4cGMzUkFOZ29LWVdSa1FXUmtjbVZ6YzFSdlYyaHBkR1ZzYVhOMFgyRm1kR1Z5WDJsbVgyVnNjMlZBTlRvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5NmF5MTNhR2wwWld4cGMzUXZlbXN0ZDJocGRHVnNhWE4wTG1Gc1oyOHVkSE02T0RNS0lDQWdJQzh2SUhSb2FYTXVkMmhwZEdWTWFYTjBLR0ZqWTI5MWJuUXBMblpoYkhWbElEMGdkSEoxWlRzS0lDQWdJR1JwWnlBeENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmVtc3RkMmhwZEdWc2FYTjBMM3ByTFhkb2FYUmxiR2x6ZEM1aGJHZHZMblJ6T2pNeENpQWdJQ0F2THlCM2FHbDBaVXhwYzNRZ1BTQk1iMk5oYkZOMFlYUmxQR0p2YjJ4bFlXNCtLQ2s3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0ozYUdsMFpVeHBjM1FpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12ZW1zdGQyaHBkR1ZzYVhOMEwzcHJMWGRvYVhSbGJHbHpkQzVoYkdkdkxuUnpPamd6Q2lBZ0lDQXZMeUIwYUdsekxuZG9hWFJsVEdsemRDaGhZMk52ZFc1MEtTNTJZV3gxWlNBOUlIUnlkV1U3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1lYQndYMnh2WTJGc1gzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM3ByTFhkb2FYUmxiR2x6ZEM5NmF5MTNhR2wwWld4cGMzUXVZV3huYnk1MGN6bzROQW9nSUNBZ0x5OGdjbVYwZFhKdUlHNWxkeUJoY21NMExsTjBjaWdpSWlrN0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdDaUFnSUNBdkx5QmpiMjUwY21GamRITXZlbXN0ZDJocGRHVnNhWE4wTDNwckxYZG9hWFJsYkdsemRDNWhiR2R2TG5Sek9qVXhDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHSWdZV1JrUVdSa2NtVnpjMVJ2VjJocGRHVnNhWE4wWDJGbWRHVnlYMmx1YkdsdVpXUmZZMjl1ZEhKaFkzUnpMM3ByTFhkb2FYUmxiR2x6ZEM5NmF5MTNhR2wwWld4cGMzUXVZV3huYnk1MGN6bzZXbXRYYUdsMFpXeHBjM1JEYjI1MGNtRmpkQzVoWkdSQlpHUnlaWE56Vkc5WGFHbDBaV3hwYzNSQU5nb0tDaTh2SUdOdmJuUnlZV04wY3k5NmF5MTNhR2wwWld4cGMzUXZlbXN0ZDJocGRHVnNhWE4wTG1Gc1oyOHVkSE02T2xwclYyaHBkR1ZzYVhOMFEyOXVkSEpoWTNRdWFYTlBibGRvYVhSbGJHbHpkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21selQyNVhhR2wwWld4cGMzUTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZlbXN0ZDJocGRHVnNhWE4wTDNwckxYZG9hWFJsYkdsemRDNWhiR2R2TG5Sek9qZzNDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM3ByTFhkb2FYUmxiR2x6ZEM5NmF5MTNhR2wwWld4cGMzUXVZV3huYnk1MGN6bzVNUW9nSUNBZ0x5OGdZMjl1YzNRZ2IzQjBaV1JKYmlBOUlHOXdMbUZ3Y0U5d2RHVmtTVzRvWVdOamIzVnVkQ3dnUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia2xrS1RzS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYQndYMjl3ZEdWa1gybHVDaUFnSUNBdkx5QmpiMjUwY21GamRITXZlbXN0ZDJocGRHVnNhWE4wTDNwckxYZG9hWFJsYkdsemRDNWhiR2R2TG5Sek9qa3lDaUFnSUNBdkx5QnBaaUFvSVc5d2RHVmtTVzRwSUhzS0lDQWdJR0p1ZWlCcGMwOXVWMmhwZEdWc2FYTjBYMkZtZEdWeVgybG1YMlZzYzJWQU13b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzcHJMWGRvYVhSbGJHbHpkQzk2YXkxM2FHbDBaV3hwYzNRdVlXeG5ieTUwY3pvNU13b2dJQ0FnTHk4Z2NtVjBkWEp1SUc1bGR5QmhjbU0wTGtKdmIyd29abUZzYzJVcE93b2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEQXdDZ3BwYzA5dVYyaHBkR1ZzYVhOMFgyRm1kR1Z5WDJsdWJHbHVaV1JmWTI5dWRISmhZM1J6TDNwckxYZG9hWFJsYkdsemRDOTZheTEzYUdsMFpXeHBjM1F1WVd4bmJ5NTBjem82V210WGFHbDBaV3hwYzNSRGIyNTBjbUZqZEM1cGMwOXVWMmhwZEdWc2FYTjBRRFE2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12ZW1zdGQyaHBkR1ZzYVhOMEwzcHJMWGRvYVhSbGJHbHpkQzVoYkdkdkxuUnpPamczQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtbHpUMjVYYUdsMFpXeHBjM1JmWVdaMFpYSmZhV1pmWld4elpVQXpPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM3ByTFhkb2FYUmxiR2x6ZEM5NmF5MTNhR2wwWld4cGMzUXVZV3huYnk1MGN6bzVOUW9nSUNBZ0x5OGdZMjl1YzNRZ2QyaHBkR1ZzYVhOMFpXUWdQU0IwYUdsekxuZG9hWFJsVEdsemRDaGhZMk52ZFc1MEtTNTJZV3gxWlRzS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTk2YXkxM2FHbDBaV3hwYzNRdmVtc3RkMmhwZEdWc2FYTjBMbUZzWjI4dWRITTZNekVLSUNBZ0lDOHZJSGRvYVhSbFRHbHpkQ0E5SUV4dlkyRnNVM1JoZEdVOFltOXZiR1ZoYmo0b0tUc0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0luZG9hWFJsVEdsemRDSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OTZheTEzYUdsMFpXeHBjM1F2ZW1zdGQyaHBkR1ZzYVhOMExtRnNaMjh1ZEhNNk9UVUtJQ0FnSUM4dklHTnZibk4wSUhkb2FYUmxiR2x6ZEdWa0lEMGdkR2hwY3k1M2FHbDBaVXhwYzNRb1lXTmpiM1Z1ZENrdWRtRnNkV1U3Q2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dURzlqWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OTZheTEzYUdsMFpXeHBjM1F2ZW1zdGQyaHBkR1ZzYVhOMExtRnNaMjh1ZEhNNk9UWUtJQ0FnSUM4dklISmxkSFZ5YmlCdVpYY2dZWEpqTkM1Q2IyOXNLSGRvYVhSbGJHbHpkR1ZrS1RzS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12ZW1zdGQyaHBkR1ZzYVhOMEwzcHJMWGRvYVhSbGJHbHpkQzVoYkdkdkxuUnpPamczQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR0lnYVhOUGJsZG9hWFJsYkdsemRGOWhablJsY2w5cGJteHBibVZrWDJOdmJuUnlZV04wY3k5NmF5MTNhR2wwWld4cGMzUXZlbXN0ZDJocGRHVnNhWE4wTG1Gc1oyOHVkSE02T2xwclYyaHBkR1ZzYVhOMFEyOXVkSEpoWTNRdWFYTlBibGRvYVhSbGJHbHpkRUEwQ2dvS0x5OGdZMjl1ZEhKaFkzUnpMM3ByTFhkb2FYUmxiR2x6ZEM5NmF5MTNhR2wwWld4cGMzUXVZV3huYnk1MGN6bzZXbXRYYUdsMFpXeHBjM1JEYjI1MGNtRmpkQzUyWlhKcFpubFFjbTl2Wmx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuWmxjbWxtZVZCeWIyOW1PZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM3ByTFhkb2FYUmxiR2x6ZEM5NmF5MTNhR2wwWld4cGMzUXVZV3huYnk1MGN6bzVPUzB4TURNS0lDQWdJQzh2SUhabGNtbG1lVkJ5YjI5bUtBb2dJQ0FnTHk4Z0lDQmhjSEJKWkRvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCd2NtOXZaam9nWVhKak5DNUVlVzVoYldsalFYSnlZWGs4WVhKak5DNUJaR1J5WlhOelBpd0tJQ0FnSUM4dklDQWdjSFZpYkdsalNXNXdkWFJ6T2lCaGNtTTBMa1I1Ym1GdGFXTkJjbkpoZVR4aGNtTTBMa0ZrWkhKbGMzTStMQW9nSUNBZ0x5OGdLVG9nWVhKak5DNUNiMjlzSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR05oYkd4emRXSWdZMjl1ZEhKaFkzUnpMM3ByTFhkb2FYUmxiR2x6ZEM5NmF5MTNhR2wwWld4cGMzUXVZV3huYnk1MGN6bzZXbXRYYUdsMFpXeHBjM1JEYjI1MGNtRmpkQzUyWlhKcFpubFFjbTl2WmdvZ0lDQWdjRzl3YmlBeUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTI5dWRISmhZM1J6TDNwckxYZG9hWFJsYkdsemRDOTZheTEzYUdsMFpXeHBjM1F1WVd4bmJ5NTBjem82V210WGFHbDBaV3hwYzNSRGIyNTBjbUZqZEM1MlpYSnBabmxRY205dlppaGhjSEJKWkRvZ2RXbHVkRFkwTENCd2NtOXZaam9nWW5sMFpYTXNJSEIxWW14cFkwbHVjSFYwY3pvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6TENCaWVYUmxjeXdnWW5sMFpYTTZDbU52Ym5SeVlXTjBjeTk2YXkxM2FHbDBaV3hwYzNRdmVtc3RkMmhwZEdWc2FYTjBMbUZzWjI4dWRITTZPbHByVjJocGRHVnNhWE4wUTI5dWRISmhZM1F1ZG1WeWFXWjVVSEp2YjJZNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmVtc3RkMmhwZEdWc2FYTjBMM3ByTFhkb2FYUmxiR2x6ZEM1aGJHZHZMblJ6T2prNUxURXdNd29nSUNBZ0x5OGdkbVZ5YVdaNVVISnZiMllvQ2lBZ0lDQXZMeUFnSUdGd2NFbGtPaUIxYVc1ME5qUXNDaUFnSUNBdkx5QWdJSEJ5YjI5bU9pQmhjbU0wTGtSNWJtRnRhV05CY25KaGVUeGhjbU0wTGtGa1pISmxjM00rTEFvZ0lDQWdMeThnSUNCd2RXSnNhV05KYm5CMWRITTZJR0Z5WXpRdVJIbHVZVzFwWTBGeWNtRjVQR0Z5WXpRdVFXUmtjbVZ6Y3o0c0NpQWdJQ0F2THlBcE9pQmhjbU0wTGtKdmIyd2dld29nSUNBZ2NISnZkRzhnTXlBekNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmVtc3RkMmhwZEdWc2FYTjBMM3ByTFhkb2FYUmxiR2x6ZEM1aGJHZHZMblJ6T2pFd05TMHhNVFlLSUNBZ0lDOHZJR052Ym5OMElIWmxjbWxtYVdWa0lEMGdhWFI0YmdvZ0lDQWdMeThnSUNBdVlYQndiR2xqWVhScGIyNURZV3hzS0hzS0lDQWdJQzh2SUNBZ0lDQmhjSEJKWkRvZ1lYQndTV1FzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxPaUF3TEFvZ0lDQWdMeThnSUNBZ0lHRndjRUZ5WjNNNklGc0tJQ0FnSUM4dklDQWdJQ0FnSUdGeVl6UXViV1YwYUc5a1UyVnNaV04wYjNJb0luWmxjbWxtZVNoaWVYUmxXek15WFZ0ZExHSjVkR1ZiTXpKZFcxMHBZbTl2YkNJcExBb2dJQ0FnTHk4Z0lDQWdJQ0FnWTJ4dmJtVW9jSEp2YjJZcExBb2dJQ0FnTHk4Z0lDQWdJQ0FnWTJ4dmJtVW9jSFZpYkdsalNXNXdkWFJ6S1N3S0lDQWdJQzh2SUNBZ0lDQmRMQW9nSUNBZ0x5OGdJQ0FnSUc5dVEyOXRjR3hsZEdsdmJqb2dUMjVEYjIxd2JHVjBaVUZqZEdsdmJpNU9iMDl3TEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnTHk4Z0lDQXVjM1ZpYldsMEtDa3ViR0Z6ZEV4dlp6c0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5NmF5MTNhR2wwWld4cGMzUXZlbXN0ZDJocGRHVnNhWE4wTG1Gc1oyOHVkSE02TVRFMENpQWdJQ0F2THlCdmJrTnZiWEJzWlhScGIyNDZJRTl1UTI5dGNHeGxkR1ZCWTNScGIyNHVUbTlQY0N3S0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNwckxYZG9hWFJsYkdsemRDOTZheTEzYUdsMFpXeHBjM1F1WVd4bmJ5NTBjem94TVRBS0lDQWdJQzh2SUdGeVl6UXViV1YwYUc5a1UyVnNaV04wYjNJb0luWmxjbWxtZVNoaWVYUmxXek15WFZ0ZExHSjVkR1ZiTXpKZFcxMHBZbTl2YkNJcExBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE9HRXpZMlZqTjJFZ0x5OGdiV1YwYUc5a0lDSjJaWEpwWm5rb1lubDBaVnN6TWwxYlhTeGllWFJsV3pNeVhWdGRLV0p2YjJ3aUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OTZheTEzYUdsMFpXeHBjM1F2ZW1zdGQyaHBkR1ZzYVhOMExtRnNaMjh1ZEhNNk1UQTFMVEV4TlFvZ0lDQWdMeThnWTI5dWMzUWdkbVZ5YVdacFpXUWdQU0JwZEhodUNpQWdJQ0F2THlBZ0lDNWhjSEJzYVdOaGRHbHZia05oYkd3b2V3b2dJQ0FnTHk4Z0lDQWdJR0Z3Y0Vsa09pQmhjSEJKWkN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U2SURBc0NpQWdJQ0F2THlBZ0lDQWdZWEJ3UVhKbmN6b2dXd29nSUNBZ0x5OGdJQ0FnSUNBZ1lYSmpOQzV0WlhSb2IyUlRaV3hsWTNSdmNpZ2lkbVZ5YVdaNUtHSjVkR1ZiTXpKZFcxMHNZbmwwWlZzek1sMWJYU2xpYjI5c0lpa3NDaUFnSUNBdkx5QWdJQ0FnSUNCamJHOXVaU2h3Y205dlppa3NDaUFnSUNBdkx5QWdJQ0FnSUNCamJHOXVaU2h3ZFdKc2FXTkpibkIxZEhNcExBb2dJQ0FnTHk4Z0lDQWdJRjBzQ2lBZ0lDQXZMeUFnSUNBZ2IyNURiMjF3YkdWMGFXOXVPaUJQYmtOdmJYQnNaWFJsUVdOMGFXOXVMazV2VDNBc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNCcGJuUmpYeklnTHk4Z05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNwckxYZG9hWFJsYkdsemRDOTZheTEzYUdsMFpXeHBjM1F1WVd4bmJ5NTBjem94TURnS0lDQWdJQzh2SUdabFpUb2dNQ3dLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM3ByTFhkb2FYUmxiR2x6ZEM5NmF5MTNhR2wwWld4cGMzUXVZV3huYnk1MGN6b3hNRFV0TVRFMkNpQWdJQ0F2THlCamIyNXpkQ0IyWlhKcFptbGxaQ0E5SUdsMGVHNEtJQ0FnSUM4dklDQWdMbUZ3Y0d4cFkyRjBhVzl1UTJGc2JDaDdDaUFnSUNBdkx5QWdJQ0FnWVhCd1NXUTZJR0Z3Y0Vsa0xBb2dJQ0FnTHk4Z0lDQWdJR1psWlRvZ01Dd0tJQ0FnSUM4dklDQWdJQ0JoY0hCQmNtZHpPaUJiQ2lBZ0lDQXZMeUFnSUNBZ0lDQmhjbU0wTG0xbGRHaHZaRk5sYkdWamRHOXlLQ0oyWlhKcFpua29ZbmwwWlZzek1sMWJYU3hpZVhSbFd6TXlYVnRkS1dKdmIyd2lLU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lHTnNiMjVsS0hCeWIyOW1LU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lHTnNiMjVsS0hCMVlteHBZMGx1Y0hWMGN5a3NDaUFnSUNBdkx5QWdJQ0FnWFN3S0lDQWdJQzh2SUNBZ0lDQnZia052YlhCc1pYUnBiMjQ2SUU5dVEyOXRjR3hsZEdWQlkzUnBiMjR1VG05UGNDd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lDOHZJQ0FnTG5OMVltMXBkQ2dwTG14aGMzUk1iMmM3Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM3ByTFhkb2FYUmxiR2x6ZEM5NmF5MTNhR2wwWld4cGMzUXVZV3huYnk1MGN6b3hNVFlLSUNBZ0lDOHZJQzV6ZFdKdGFYUW9LUzVzWVhOMFRHOW5Pd29nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNBdkx5QmpiMjUwY21GamRITXZlbXN0ZDJocGRHVnNhWE4wTDNwckxYZG9hWFJsYkdsemRDNWhiR2R2TG5Sek9qRXhOeTB4TWpBS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExtTnZiblpsY25SQ2VYUmxjenhoY21NMExrSnZiMncrS0habGNtbG1hV1ZrTENCN0NpQWdJQ0F2THlBZ0lIQnlaV1pwZURvZ0lteHZaeUlzQ2lBZ0lDQXZMeUFnSUhOMGNtRjBaV2Q1T2lBaWRXNXpZV1psTFdOaGMzUWlMQW9nSUNBZ0x5OGdmU2s3Q2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ05DQXdDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wSURBZ05Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzcHJMWGRvYVhSbGJHbHpkQzk2YXkxM2FHbDBaV3hwYzNRdVlXeG5ieTUwY3pveE1UZ0tJQ0FnSUM4dklIQnlaV1pwZURvZ0lteHZaeUlzQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTk2YXkxM2FHbDBaV3hwYzNRdmVtc3RkMmhwZEdWc2FYTjBMbUZzWjI4dWRITTZNVEUzTFRFeU1Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVZMjl1ZG1WeWRFSjVkR1Z6UEdGeVl6UXVRbTl2YkQ0b2RtVnlhV1pwWldRc0lIc0tJQ0FnSUM4dklDQWdjSEpsWm1sNE9pQWliRzluSWl3S0lDQWdJQzh2SUNBZ2MzUnlZWFJsWjNrNklDSjFibk5oWm1VdFkyRnpkQ0lzQ2lBZ0lDQXZMeUI5S1RzS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRbmwwWlhNZ2FHRnpJSFpoYkdsa0lIQnlaV1pwZUFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lISmxkSE4xWWdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRUFRQUdBQ1lFQkJVZmZIVURCb0VCQ1hkb2FYUmxUR2x6ZEFFQWdnSUVvT2dZY2dTVEFLcmlOaG9BamdJQVBnQTBNUmtVUkRFWVFRQWRnZ01FeTNmQWVnUlJkamZHQlBFSGMvRTJHZ0NPQXdBOEFRMEJLd0NBQkNEZk9sUTJHZ0NPQVFBWkFDSXhHWkFrR2pFWUVFTWlNUm1RZ1RBYU1SZ1FSRUlBRDRBSFlYQndUbUZ0WlRZYUFXY2lReklKTVFBU1F6WWFBVFlhQW9IeTdBZ3lEQTFCQUJXeEpMSVFnUVd5R1NteUhpbXlIeU95QWJOQy8rR0JJSzlMQW9BZ01HUk9jdUV4b0NtNFVFVzJnWUZZWFNnejZFaDV1WENSUStIMWsvQUFBQUdxcTRBQ0FBRk1VQ1ZMQWs4Q2lBQ29SZ0lqVTBBQUk0QWJBQmxRY205dlppQjJaWEpwWm1sallYUnBiMjRnWm1GcGJHVmtLRXhRc0NKRE1RQkxBaE5CQURlQU1nQXdVMlZ1WkdWeUlHRmtaSEpsYzNNZ1pHOWxjeUJ1YjNRZ2JXRjBZMmdnWVhWMGFHOXlhWHBsWkNCaFpHUnlaWE56UXYrN1N3RXFJbWFBQWdBQVF2K3ZOaG9CU1RJSVlVQUFCeXNvVEZDd0lrTkpJeXBqUkNzalR3SlVRdi90TmhvQkZ6WWFBallhQTRnQUNFWUNLRXhRc0NKRGlnTURzU095R1lBRWlqenNlcklhaS82eUdvdi9zaHFML2JJWUpMSVFJN0lCczdRK1NWY0VBRXhYQUFRb0VrU0wvb3YvaVE9PSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjAsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7IlZFUklGSUVSX0FQUF9JRCI6eyJ0eXBlIjoiQVZNVWludDY0IiwidmFsdWUiOm51bGx9fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
