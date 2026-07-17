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

namespace Arc56.Generated.DevMaan707.escrow_blockchain.HelloWorld_000577fb
{


    public class HelloWorldProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public HelloWorldProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Test connectivity
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
        ///Register agency with wallet address for escrow
        ///</summary>
        /// <param name="agency_name"> </param>
        /// <param name="description"> </param>
        /// <param name="contact_info"> </param>
        /// <param name="wallet_address"> </param>
        public async Task<string> RegisterAgency(string agency_name, string description, string contact_info, string wallet_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 170, 144, 74, 202 };
            var agency_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); agency_nameAbi.From(agency_name);
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);
            var contact_infoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); contact_infoAbi.From(contact_info);
            var wallet_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); wallet_addressAbi.From(wallet_address);

            var result = await base.CallApp(new List<object> { abiHandle, agency_nameAbi, descriptionAbi, contact_infoAbi, wallet_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> RegisterAgency_Transactions(string agency_name, string description, string contact_info, string wallet_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 170, 144, 74, 202 };
            var agency_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); agency_nameAbi.From(agency_name);
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);
            var contact_infoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); contact_infoAbi.From(contact_info);
            var wallet_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); wallet_addressAbi.From(wallet_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, agency_nameAbi, descriptionAbi, contact_infoAbi, wallet_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Search agencies by name or service
        ///</summary>
        /// <param name="search_term"> </param>
        public async Task<string> SearchAgencies(string search_term, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 152, 255, 157, 135 };
            var search_termAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); search_termAbi.From(search_term);

            var result = await base.CallApp(new List<object> { abiHandle, search_termAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> SearchAgencies_Transactions(string search_term, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 152, 255, 157, 135 };
            var search_termAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); search_termAbi.From(search_term);

            return await base.MakeTransactionList(new List<object> { abiHandle, search_termAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get all registered agencies
        ///</summary>
        public async Task<string> GetAllAgencies(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 146, 206, 86, 95 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetAllAgencies_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 146, 206, 86, 95 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get service statistics
        ///</summary>
        public async Task<string> GetStats(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 20, 152, 157, 43 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetStats_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 20, 152, 157, 43 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get service information
        ///</summary>
        public async Task<string> GetServiceInfo(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 224, 157, 132, 192 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetServiceInfo_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 224, 157, 132, 192 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiSGVsbG9Xb3JsZCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJoZWxsbyIsImRlc2MiOiJUZXN0IGNvbm5lY3Rpdml0eSIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVnaXN0ZXJfYWdlbmN5IiwiZGVzYyI6IlJlZ2lzdGVyIGFnZW5jeSB3aXRoIHdhbGxldCBhZGRyZXNzIGZvciBlc2Nyb3ciLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbmN5X25hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlc2NyaXB0aW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjb250YWN0X2luZm8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldF9hZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2VhcmNoX2FnZW5jaWVzIiwiZGVzYyI6IlNlYXJjaCBhZ2VuY2llcyBieSBuYW1lIG9yIHNlcnZpY2UiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VhcmNoX3Rlcm0iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfYWxsX2FnZW5jaWVzIiwiZGVzYyI6IkdldCBhbGwgcmVnaXN0ZXJlZCBhZ2VuY2llcyIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9zdGF0cyIsImRlc2MiOiJHZXQgc2VydmljZSBzdGF0aXN0aWNzIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3NlcnZpY2VfaW5mbyIsImRlc2MiOiJHZXQgc2VydmljZSBpbmZvcm1hdGlvbiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6M30sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTM2LDIyMCwyNDQsMjY4LDI5OCwzNDZdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODFdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzksMjIzLDI0NywyNzEsMzAxLDM0OV0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NjEsNjA0LDY2MF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYWdlbmNpZXNfbGlzdCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NzQsNjgyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hZ2VuY3lfY291bnQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTkwLDcxOF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuc2VhcmNoX2NvdW50IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11YUdWc2JHOWZkMjl5YkdRdVkyOXVkSEpoWTNRdVNHVnNiRzlYYjNKc1pDNWZYMkZzWjI5d2VWOWxiblJ5ZVhCdmFXNTBYM2RwZEdoZmFXNXBkQ2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJbUZuWlc1amVWOWpiM1Z1ZENJZ0luTmxZWEpqYUY5amIzVnVkQ0lnSW1GblpXNWphV1Z6WDJ4cGMzUWlJREI0TVRVeFpqZGpOelVnSWpBaUlDSXhJaUFpZkNJZ0lqSWlDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdWNIazZOeTA0Q2lBZ0lDQXZMeUFqSUZWelpTQlRkSEpwYm1jZ1ptOXlJR052ZFc1MFpYSnpJSFJ2SUdGMmIybGtJRlZKYm5RMk5DQm1jbTl1ZEdWdVpDQnBjM04xWlhNS0lDQWdJQzh2SUhObGJHWXVZV2RsYm1ONVgyTnZkVzUwSUQwZ1IyeHZZbUZzVTNSaGRHVW9VM1J5YVc1bktDSXdJaWtwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0poWjJWdVkzbGZZMjkxYm5RaUNpQWdJQ0JpZVhSbFl5QTBJQzh2SUNJd0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNXdlVG81Q2lBZ0lDQXZMeUJ6Wld4bUxuTmxZWEpqYUY5amIzVnVkQ0E5SUVkc2IySmhiRk4wWVhSbEtGTjBjbWx1WnlnaU1DSXBLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWljMlZoY21Ob1gyTnZkVzUwSWdvZ0lDQWdZbmwwWldNZ05DQXZMeUFpTUNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdWNIazZNVEV0TVRJS0lDQWdJQzh2SUNNZ1UzUnZjbVVnWVdkbGJtTnBaWE1nWVhNNklHNWhiV1Y4WkdWelkzSnBjSFJwYjI1OFkyOXVkR0ZqZEh4aFpHUnlaWE56T3dvZ0lDQWdMeThnYzJWc1ppNWhaMlZ1WTJsbGMxOXNhWE4wSUQwZ1IyeHZZbUZzVTNSaGRHVW9VM1J5YVc1bktDSWlLU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbUZuWlc1amFXVnpYMnhwYzNRaUNpQWdJQ0J3ZFhOb1lubDBaWE1nSWlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzV3ZVRvMUNpQWdJQ0F2THlCamJHRnpjeUJJWld4c2IxZHZjbXhrS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5aVlYSmxYM0p2ZFhScGJtZEFNVEVLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGd3TW1KbFkyVXhNU0F3ZUdGaE9UQTBZV05oSURCNE9UaG1aamxrT0RjZ01IZzVNbU5sTlRZMVppQXdlREUwT1RnNVpESmlJREI0WlRBNVpEZzBZekFnTHk4Z2JXVjBhRzlrSUNKb1pXeHNieWh6ZEhKcGJtY3BjM1J5YVc1bklpd2diV1YwYUc5a0lDSnlaV2RwYzNSbGNsOWhaMlZ1WTNrb2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3NjM1J5YVc1bktYTjBjbWx1WnlJc0lHMWxkR2h2WkNBaWMyVmhjbU5vWDJGblpXNWphV1Z6S0hOMGNtbHVaeWx6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJbWRsZEY5aGJHeGZZV2RsYm1OcFpYTW9LWE4wY21sdVp5SXNJRzFsZEdodlpDQWlaMlYwWDNOMFlYUnpLQ2x6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJbWRsZEY5elpYSjJhV05sWDJsdVptOG9LWE4wY21sdVp5SUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZmFHVnNiRzlmY205MWRHVkFOU0J0WVdsdVgzSmxaMmx6ZEdWeVgyRm5aVzVqZVY5eWIzVjBaVUEySUcxaGFXNWZjMlZoY21Ob1gyRm5aVzVqYVdWelgzSnZkWFJsUURjZ2JXRnBibDluWlhSZllXeHNYMkZuWlc1amFXVnpYM0p2ZFhSbFFEZ2diV0ZwYmw5blpYUmZjM1JoZEhOZmNtOTFkR1ZBT1NCdFlXbHVYMmRsZEY5elpYSjJhV05sWDJsdVptOWZjbTkxZEdWQU1UQUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1d2VUbzFDaUFnSUNBdkx5QmpiR0Z6Y3lCSVpXeHNiMWR2Y214a0tFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEY5elpYSjJhV05sWDJsdVptOWZjbTkxZEdWQU1UQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVjSGs2TnpRS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlRBd05ESTBNVFpqTmpjMlpqY3lOakUyWlRZME1qQTBOVGN6TmpNM01qWm1OemN5TURVek5qVTNNamMyTmprMk16WTFNakF5WkRJd05ETTJaalpsTm1VMk5UWXpOelEyT1RabE5qY3lNRFF6Tm1NMk9UWTFObVUzTkRjek1qQTNOelk1TnpRMk9ESXdOVFEzTWpjMU56TTNORFkxTmpReU1EUXhOamMyTlRabE5qTTJPVFkxTnpNS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSZmMzUmhkSE5mY205MWRHVkFPVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzV3ZVRvMk9Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFgzTjBZWFJ6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJmWVd4c1gyRm5aVzVqYVdWelgzSnZkWFJsUURnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdWNIazZOalFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmpZV3hzYzNWaUlHZGxkRjloYkd4ZllXZGxibU5wWlhNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM05sWVhKamFGOWhaMlZ1WTJsbGMxOXliM1YwWlVBM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExuQjVPalE0Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG5CNU9qVUtJQ0FnSUM4dklHTnNZWE56SUVobGJHeHZWMjl5YkdRb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVjSGs2TkRnS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUJ6WldGeVkyaGZZV2RsYm1OcFpYTUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNKbFoybHpkR1Z5WDJGblpXNWplVjl5YjNWMFpVQTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbkI1T2pFNUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExuQjVPalVLSUNBZ0lDOHZJR05zWVhOeklFaGxiR3h2VjI5eWJHUW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdWNIazZNVGtLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMkZzYkhOMVlpQnlaV2RwYzNSbGNsOWhaMlZ1WTNrS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmhsYkd4dlgzSnZkWFJsUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdWNIazZNVFFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1Y0hrNk5Rb2dJQ0FnTHk4Z1kyeGhjM01nU0dWc2JHOVhiM0pzWkNoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNXdlVG94TkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JqWVd4c2MzVmlJR2hsYkd4dkNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlpWVhKbFgzSnZkWFJwYm1kQU1URTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVjSGs2TlFvZ0lDQWdMeThnWTJ4aGMzTWdTR1ZzYkc5WGIzSnNaQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TXdvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnWTNKbFlYUnBibWNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWFHVnNiRzlmZDI5eWJHUXVZMjl1ZEhKaFkzUXVTR1ZzYkc5WGIzSnNaQzVvWld4c2J5aHVZVzFsT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q21obGJHeHZPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbkI1T2pFMExURTFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lDOHZJR1JsWmlCb1pXeHNieWh6Wld4bUxDQnVZVzFsT2lCVGRISnBibWNwSUMwK0lGTjBjbWx1WnpvS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbkI1T2pFM0NpQWdJQ0F2THlCeVpYUjFjbTRnVTNSeWFXNW5LQ0pJWld4c2J5QWlLU0FySUc1aGJXVWdLeUJUZEhKcGJtY29JaUF0SUZkbGJHTnZiV1VnZEc4Z1JYTmpjbTkzSUZObGNuWnBZMlVoSWlrS0lDQWdJSEIxYzJoaWVYUmxjeUFpU0dWc2JHOGdJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlJQzBnVjJWc1kyOXRaU0IwYnlCRmMyTnliM2NnVTJWeWRtbGpaU0VpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVvWld4c2IxOTNiM0pzWkM1amIyNTBjbUZqZEM1SVpXeHNiMWR2Y214a0xuSmxaMmx6ZEdWeVgyRm5aVzVqZVNoaFoyVnVZM2xmYm1GdFpUb2dZbmwwWlhNc0lHUmxjMk55YVhCMGFXOXVPaUJpZVhSbGN5d2dZMjl1ZEdGamRGOXBibVp2T2lCaWVYUmxjeXdnZDJGc2JHVjBYMkZrWkhKbGMzTTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tjbVZuYVhOMFpYSmZZV2RsYm1ONU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExuQjVPakU1TFRJMkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUM4dklHUmxaaUJ5WldkcGMzUmxjbDloWjJWdVkza29DaUFnSUNBdkx5QWdJQ0FnYzJWc1ppd0tJQ0FnSUM4dklDQWdJQ0JoWjJWdVkzbGZibUZ0WlRvZ1UzUnlhVzVuTEFvZ0lDQWdMeThnSUNBZ0lHUmxjMk55YVhCMGFXOXVPaUJUZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnWTI5dWRHRmpkRjlwYm1adk9pQlRkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDQWdkMkZzYkdWMFgyRmtaSEpsYzNNNklGTjBjbWx1WndvZ0lDQWdMeThnS1NBdFBpQlRkSEpwYm1jNkNpQWdJQ0J3Y205MGJ5QTBJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzV3ZVRveU9DMHlPUW9nSUNBZ0x5OGdJeUJEY21WaGRHVWdZV2RsYm1ONUlHVnVkSEo1T2lCdVlXMWxmR1JsYzJOeWFYQjBhVzl1ZkdOdmJuUmhZM1I4WVdSa2NtVnpjenNLSUNBZ0lDOHZJR0ZuWlc1amVWOWxiblJ5ZVNBOUlHRm5aVzVqZVY5dVlXMWxJQ3NnVTNSeWFXNW5LQ0o4SWlrZ0t5QmtaWE5qY21sd2RHbHZiaUFySUZOMGNtbHVaeWdpZkNJcElDc2dZMjl1ZEdGamRGOXBibVp2SUNzZ1UzUnlhVzVuS0NKOElpa2dLeUIzWVd4c1pYUmZZV1JrY21WemN5QXJJRk4wY21sdVp5Z2lPeUlwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbndpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKOElnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV01nTmlBdkx5QWlmQ0lLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUFpT3lJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExuQjVPak14TFRNeUNpQWdJQ0F2THlBaklFRmtaQ0IwYnlCaFoyVnVZMmxsY3lCc2FYTjBDaUFnSUNBdkx5QmpkWEp5Wlc1MFgyeHBjM1FnUFNCelpXeG1MbUZuWlc1amFXVnpYMnhwYzNRdWRtRnNkV1VLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmhaMlZ1WTJsbGMxOXNhWE4wSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRm5aVzVqYVdWelgyeHBjM1FnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVjSGs2TXpNS0lDQWdJQzh2SUhObGJHWXVZV2RsYm1OcFpYTmZiR2x6ZEM1MllXeDFaU0E5SUdOMWNuSmxiblJmYkdsemRDQXJJR0ZuWlc1amVWOWxiblJ5ZVFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKaFoyVnVZMmxsYzE5c2FYTjBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzV3ZVRvek5TMHpOZ29nSUNBZ0x5OGdJeUJKYm1OeVpXMWxiblFnWTI5MWJuUmxjaUFvYzJsdGNHeHBabWxsWkNrS0lDQWdJQzh2SUdOMWNuSmxiblJmWTI5MWJuUWdQU0J6Wld4bUxtRm5aVzVqZVY5amIzVnVkQzUyWVd4MVpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1GblpXNWplVjlqYjNWdWRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVlXZGxibU41WDJOdmRXNTBJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExuQjVPak0zQ2lBZ0lDQXZMeUJwWmlCamRYSnlaVzUwWDJOdmRXNTBJRDA5SUZOMGNtbHVaeWdpTUNJcE9nb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaU1DSUtJQ0FnSUQwOUNpQWdJQ0JpZWlCeVpXZHBjM1JsY2w5aFoyVnVZM2xmWld4elpWOWliMlI1UURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1d2VUb3pPQW9nSUNBZ0x5OGdjMlZzWmk1aFoyVnVZM2xmWTI5MWJuUXVkbUZzZFdVZ1BTQlRkSEpwYm1jb0lqRWlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZV2RsYm1ONVgyTnZkVzUwSWdvZ0lDQWdZbmwwWldNZ05TQXZMeUFpTVNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncHlaV2RwYzNSbGNsOWhaMlZ1WTNsZllXWjBaWEpmYVdaZlpXeHpaVUE1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG5CNU9qUTJDaUFnSUNBdkx5QnlaWFIxY200Z1UzUnlhVzVuS0NKVFZVTkRSVk5UT2tGblpXNWplU0FpS1NBcklHRm5aVzVqZVY5dVlXMWxJQ3NnVTNSeWFXNW5LQ0lnY21WbmFYTjBaWEpsWkNCbWIzSWdaWE5qY205M0lITmxjblpwWTJVaUtRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKVFZVTkRSVk5UT2tGblpXNWplU0FpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lnY21WbmFYTjBaWEpsWkNCbWIzSWdaWE5qY205M0lITmxjblpwWTJVaUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUhKbGRITjFZZ29LY21WbmFYTjBaWEpmWVdkbGJtTjVYMlZzYzJWZlltOWtlVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG5CNU9qTTVDaUFnSUNBdkx5QmxiR2xtSUdOMWNuSmxiblJmWTI5MWJuUWdQVDBnVTNSeWFXNW5LQ0l4SWlrNkNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpTVNJS0lDQWdJRDA5Q2lBZ0lDQmllaUJ5WldkcGMzUmxjbDloWjJWdVkzbGZaV3h6WlY5aWIyUjVRRFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzV3ZVRvME1Bb2dJQ0FnTHk4Z2MyVnNaaTVoWjJWdVkzbGZZMjkxYm5RdWRtRnNkV1VnUFNCVGRISnBibWNvSWpJaUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVlXZGxibU41WDJOdmRXNTBJZ29nSUNBZ1lubDBaV01nTnlBdkx5QWlNaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmlJSEpsWjJsemRHVnlYMkZuWlc1amVWOWhablJsY2w5cFpsOWxiSE5sUURrS0NuSmxaMmx6ZEdWeVgyRm5aVzVqZVY5bGJITmxYMkp2WkhsQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNXdlVG8wTVFvZ0lDQWdMeThnWld4cFppQmpkWEp5Wlc1MFgyTnZkVzUwSUQwOUlGTjBjbWx1WnlnaU1pSXBPZ29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0lqSWlDaUFnSUNBOVBRb2dJQ0FnWW5vZ2NtVm5hWE4wWlhKZllXZGxibU41WDJWc2MyVmZZbTlrZVVBMkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdWNIazZORElLSUNBZ0lDOHZJSE5sYkdZdVlXZGxibU41WDJOdmRXNTBMblpoYkhWbElEMGdVM1J5YVc1bktDSXpJaWtLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUZuWlc1amVWOWpiM1Z1ZENJS0lDQWdJSEIxYzJoaWVYUmxjeUFpTXlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpSUhKbFoybHpkR1Z5WDJGblpXNWplVjloWm5SbGNsOXBabDlsYkhObFFEa0tDbkpsWjJsemRHVnlYMkZuWlc1amVWOWxiSE5sWDJKdlpIbEFOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzV3ZVRvME5Bb2dJQ0FnTHk4Z2MyVnNaaTVoWjJWdVkzbGZZMjkxYm5RdWRtRnNkV1VnUFNCVGRISnBibWNvSWpNcklpa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltRm5aVzVqZVY5amIzVnVkQ0lLSUNBZ0lIQjFjMmhpZVhSbGN5QWlNeXNpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZaUJ5WldkcGMzUmxjbDloWjJWdVkzbGZZV1owWlhKZmFXWmZaV3h6WlVBNUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbWhsYkd4dlgzZHZjbXhrTG1OdmJuUnlZV04wTGtobGJHeHZWMjl5YkdRdWMyVmhjbU5vWDJGblpXNWphV1Z6S0hObFlYSmphRjkwWlhKdE9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNuTmxZWEpqYUY5aFoyVnVZMmxsY3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1d2VUbzBPQzAwT1FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCa1pXWWdjMlZoY21Ob1gyRm5aVzVqYVdWektITmxiR1lzSUhObFlYSmphRjkwWlhKdE9pQlRkSEpwYm1jcElDMCtJRk4wY21sdVp6b0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG5CNU9qVXhMVFV5Q2lBZ0lDQXZMeUFqSUVsdVkzSmxiV1Z1ZENCelpXRnlZMmdnWTI5MWJuUmxjZ29nSUNBZ0x5OGdZM1Z5Y21WdWRGOWpiM1Z1ZENBOUlITmxiR1l1YzJWaGNtTm9YMk52ZFc1MExuWmhiSFZsQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWljMlZoY21Ob1gyTnZkVzUwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUhOM1lYQUtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV6WldGeVkyaGZZMjkxYm5RZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1Y0hrNk5UTUtJQ0FnSUM4dklHbG1JR04xY25KbGJuUmZZMjkxYm5RZ1BUMGdVM1J5YVc1bktDSXdJaWs2Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0l3SWdvZ0lDQWdQVDBLSUNBZ0lHSjZJSE5sWVhKamFGOWhaMlZ1WTJsbGMxOWxiSE5sWDJKdlpIbEFNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbkI1T2pVMENpQWdJQ0F2THlCelpXeG1Mbk5sWVhKamFGOWpiM1Z1ZEM1MllXeDFaU0E5SUZOMGNtbHVaeWdpTVNJcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKelpXRnlZMmhmWTI5MWJuUWlDaUFnSUNCaWVYUmxZeUExSUM4dklDSXhJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLQ25ObFlYSmphRjloWjJWdVkybGxjMTloWm5SbGNsOXBabDlsYkhObFFEWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVjSGs2TmpBdE5qRUtJQ0FnSUM4dklDTWdVbVYwZFhKdUlHRnNiQ0JoWjJWdVkybGxjeUIzYVhSb0lITmxZWEpqYUNCdFlYSnJaWElLSUNBZ0lDOHZJR0ZuWlc1amFXVnpYMlJoZEdFZ1BTQnpaV3htTG1GblpXNWphV1Z6WDJ4cGMzUXVkbUZzZFdVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0poWjJWdVkybGxjMTlzYVhOMElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUZuWlc1amFXVnpYMnhwYzNRZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1Y0hrNk5qSUtJQ0FnSUM4dklISmxkSFZ5YmlCVGRISnBibWNvSWxORlFWSkRTRjlTUlZOVlRGUlRPaUlwSUNzZ2MyVmhjbU5vWDNSbGNtMGdLeUJUZEhKcGJtY29Jam9pS1NBcklHRm5aVzVqYVdWelgyUmhkR0VLSUNBZ0lIQjFjMmhpZVhSbGN5QWlVMFZCVWtOSVgxSkZVMVZNVkZNNklnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBaU9pSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWFJ6ZFdJS0NuTmxZWEpqYUY5aFoyVnVZMmxsYzE5bGJITmxYMkp2WkhsQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNXdlVG8xTlFvZ0lDQWdMeThnWld4cFppQmpkWEp5Wlc1MFgyTnZkVzUwSUQwOUlGTjBjbWx1WnlnaU1TSXBPZ29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0lqRWlDaUFnSUNBOVBRb2dJQ0FnWW5vZ2MyVmhjbU5vWDJGblpXNWphV1Z6WDJWc2MyVmZZbTlrZVVBMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdWNIazZOVFlLSUNBZ0lDOHZJSE5sYkdZdWMyVmhjbU5vWDJOdmRXNTBMblpoYkhWbElEMGdVM1J5YVc1bktDSXlJaWtLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbk5sWVhKamFGOWpiM1Z1ZENJS0lDQWdJR0o1ZEdWaklEY2dMeThnSWpJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWWlCelpXRnlZMmhmWVdkbGJtTnBaWE5mWVdaMFpYSmZhV1pmWld4elpVQTJDZ3B6WldGeVkyaGZZV2RsYm1OcFpYTmZaV3h6WlY5aWIyUjVRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1Y0hrNk5UZ0tJQ0FnSUM4dklITmxiR1l1YzJWaGNtTm9YMk52ZFc1MExuWmhiSFZsSUQwZ1UzUnlhVzVuS0NJeUt5SXBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnpaV0Z5WTJoZlkyOTFiblFpQ2lBZ0lDQndkWE5vWW5sMFpYTWdJaklySWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0lnYzJWaGNtTm9YMkZuWlc1amFXVnpYMkZtZEdWeVgybG1YMlZzYzJWQU5nb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVvWld4c2IxOTNiM0pzWkM1amIyNTBjbUZqZEM1SVpXeHNiMWR2Y214a0xtZGxkRjloYkd4ZllXZGxibU5wWlhNb0tTQXRQaUJpZVhSbGN6b0taMlYwWDJGc2JGOWhaMlZ1WTJsbGN6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNXdlVG8yTndvZ0lDQWdMeThnY21WMGRYSnVJRk4wY21sdVp5Z2lRVXhNWDBGSFJVNURTVVZUT2lJcElDc2djMlZzWmk1aFoyVnVZMmxsYzE5c2FYTjBMblpoYkhWbENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWVdkbGJtTnBaWE5mYkdsemRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVoWjJWdVkybGxjMTlzYVhOMElHVjRhWE4wY3dvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pCVEV4ZlFVZEZUa05KUlZNNklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWFHVnNiRzlmZDI5eWJHUXVZMjl1ZEhKaFkzUXVTR1ZzYkc5WGIzSnNaQzVuWlhSZmMzUmhkSE1vS1NBdFBpQmllWFJsY3pvS1oyVjBYM04wWVhSek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExuQjVPamN5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdVM1J5YVc1bktDSlRWRUZVVXpwQloyVnVZMmxsY3pvaUtTQXJJSE5sYkdZdVlXZGxibU41WDJOdmRXNTBMblpoYkhWbElDc2dVM1J5YVc1bktDSTZVMlZoY21Ob1pYTTZJaWtnS3lCelpXeG1Mbk5sWVhKamFGOWpiM1Z1ZEM1MllXeDFaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltRm5aVzVqZVY5amIzVnVkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aFoyVnVZM2xmWTI5MWJuUWdaWGhwYzNSekNpQWdJQ0J3ZFhOb1lubDBaWE1nSWxOVVFWUlRPa0ZuWlc1amFXVnpPaUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0k2VTJWaGNtTm9aWE02SWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYzJWaGNtTm9YMk52ZFc1MElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1Mbk5sWVhKamFGOWpiM1Z1ZENCbGVHbHpkSE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQ0FBRW1DQXhoWjJWdVkzbGZZMjkxYm5RTWMyVmhjbU5vWDJOdmRXNTBEV0ZuWlc1amFXVnpYMnhwYzNRRUZSOThkUUV3QVRFQmZBRXlNUmhBQUF3b0p3Um5LU2NFWnlxQUFHY3hHMEVCSTRJR0JBSyt6aEVFcXBCS3lnU1kvNTJIQkpMT1ZsOEVGSmlkS3dUZ25ZVEFOaG9BamdZQTFBQ2tBSVlBYmdCV0FBSWlRekVaRkVReEdFU0FTQlVmZkhVQVFrRnNaMjl5WVc1a0lFVnpZM0p2ZHlCVFpYSjJhV05sSUMwZ1EyOXVibVZqZEdsdVp5QkRiR2xsYm5SeklIZHBkR2dnVkhKMWMzUmxaQ0JCWjJWdVkybGxjN0FqUXpFWkZFUXhHRVNJQWNSSkZSWlhCZ0pNVUN0TVVMQWpRekVaRkVReEdFU0lBWlpKRlJaWEJnSk1VQ3RNVUxBalF6RVpGRVF4R0VRMkdnRlhBZ0NJQVN0SkZSWlhCZ0pNVUN0TVVMQWpRekVaRkVReEdFUTJHZ0ZYQWdBMkdnSlhBZ0EyR2dOWEFnQTJHZ1JYQWdDSUFHWkpGUlpYQmdKTVVDdE1VTEFqUXpFWkZFUXhHRVEyR2dGWEFnQ0lBQmxKRlJaWEJnSk1VQ3RNVUxBalF6RVpRUDhKTVJnVVJDTkRpZ0VCZ0FaSVpXeHNieUNMLzFDQUhTQXRJRmRsYkdOdmJXVWdkRzhnUlhOamNtOTNJRk5sY25acFkyVWhVSW1LQkFHTC9DY0dVSXY5VUNjR1VJditVQ2NHVUl2L1VJQUJPMUFpS21WRVRGQXFUR2NpS0dWTVNVOENSQ2NFRWtFQU95Z25CV2VBRDFOVlEwTkZVMU02UVdkbGJtTjVJSXY4VUlBZUlISmxaMmx6ZEdWeVpXUWdabTl5SUdWelkzSnZkeUJ6WlhKMmFXTmxVRXlKaXdBbkJSSkJBQWNvSndkblF2KzZpd0FuQnhKQkFBZ29nQUV6WjBML3FpaUFBak1yWjBML29Zb0JBU0lwWlV4SlR3SkVKd1FTUVFBa0tTY0ZaeUlxWlVTQUQxTkZRVkpEU0Y5U1JWTlZURlJUT292L1VJQUJPbEJNVUV5Sml3QW5CUkpCQUFjcEp3ZG5Rdi9SS1lBQ01pdG5Rdi9JSWlwbFJJQU5RVXhNWDBGSFJVNURTVVZUT2t4UWlTSW9aVVNBRDFOVVFWUlRPa0ZuWlc1amFXVnpPa3hRZ0FvNlUyVmhjbU5vWlhNNlVDSXBaVVJRaVE9PSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
