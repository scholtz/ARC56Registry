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

namespace Arc56.Generated.algorandfoundation.puya_ts.MultiBases_5aa1a211
{


    public class MultiBasesProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MultiBasesProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> MethodMulti(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 41, 14, 186, 159 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> MethodMulti_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 41, 14, 186, 159 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> MethodCallsSuper(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 157, 150, 255 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> MethodCallsSuper_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 157, 150, 255 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> CallB2CantOverride(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 120, 202, 86 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> CallB2CantOverride_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 120, 202, 86 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> CallB2Common(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 136, 84, 126, 184 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> CallB2Common_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 136, 84, 126, 184 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> MethodOne(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 195, 37, 51, 227 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> MethodOne_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 195, 37, 51, 227 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> MethodCommon(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 69, 92, 141, 9 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> MethodCommon_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 69, 92, 141, 9 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> B2CantOverride(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 249, 245, 20, 44 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> B2CantOverride_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 249, 245, 20, 44 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> MethodTwo(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 59, 50, 158 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> MethodTwo_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 59, 50, 158 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTXVsdGlCYXNlcyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJtZXRob2RNdWx0aSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1ldGhvZENhbGxzU3VwZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYWxsQjJDYW50T3ZlcnJpZGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYWxsQjJDb21tb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJtZXRob2RPbmUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJtZXRob2RDb21tb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJiMkNhbnRPdmVycmlkZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1ldGhvZFR3byIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoyLCJieXRlcyI6Mn0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjoxfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0NpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE1UVXhaamRqTnpVZ0ltTnZiVzF2YmlJZ0ltSmhjMlV0ZEhkdklnb2dJQ0FnWWlCdFlXbHVYMkpzYjJOclFEQUtDbTFoYVc1ZllteHZZMnRBTURvS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lHSWdiV0ZwYmw5cFpsOWliMlI1UURFS0NtMWhhVzVmYVdaZlltOWtlVUF4T2dvZ0lDQWdZMkZzYkhOMVlpQmpiMjV6ZEhKMVkzUnZjZ29nSUNBZ1lpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0JpSUcxaGFXNWZZbXh2WTJ0QU13b0tiV0ZwYmw5aWJHOWphMEF6T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMbUZzWjI4dWRITTZORFVLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCTmRXeDBhVUpoYzJWeklHVjRkR1Z1WkhNZ1kyeGhjM05sY3loT1lXMWxVM1J2Y21Vc0lFSmhjMlZQYm1Vc0lFSmhjMlZVZDI4cElIc0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnSVQwS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFERTNDaUFnSUNCaUlHMWhhVzVmWVdKcFgzSnZkWFJwYm1kQU5Bb0tiV0ZwYmw5aFltbGZjbTkxZEdsdVowQTBPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFiSFJwTFdsdWFHVnlhWFJoYm1ObExtRnNaMjh1ZEhNNk5EVUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJOZFd4MGFVSmhjMlZ6SUdWNGRHVnVaSE1nWTJ4aGMzTmxjeWhPWVcxbFUzUnZjbVVzSUVKaGMyVlBibVVzSUVKaGMyVlVkMjhwSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNU0F2THlCT2IwOXdDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lDRTlDaUFnSUNCaWVpQnRZV2x1WDJOeVpXRjBaVjlPYjA5d1FERTFDaUFnSUNCaUlHMWhhVzVmWTJGc2JGOU9iMDl3UURVS0NtMWhhVzVmWTJGc2JGOU9iMDl3UURVNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWc2RHa3RhVzVvWlhKcGRHRnVZMlV1WVd4bmJ5NTBjem8wTlFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFMTFiSFJwUW1GelpYTWdaWGgwWlc1a2N5QmpiR0Z6YzJWektFNWhiV1ZUZEc5eVpTd2dRbUZ6WlU5dVpTd2dRbUZ6WlZSM2J5a2dld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNamt3WldKaE9XWWdMeThnYldWMGFHOWtJQ0p0WlhSb2IyUk5kV3gwYVNncGMzUnlhVzVuSWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0T0RNNVpEazJabVlnTHk4Z2JXVjBhRzlrSUNKdFpYUm9iMlJEWVd4c2MxTjFjR1Z5S0NsemRISnBibWNpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhoT1RjNFkyRTFOaUF2THlCdFpYUm9iMlFnSW1OaGJHeENNa05oYm5SUGRtVnljbWxrWlNncGMzUnlhVzVuSWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0T0RnMU5EZGxZamdnTHk4Z2JXVjBhRzlrSUNKallXeHNRakpEYjIxdGIyNG9LWE4wY21sdVp5SUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHTXpNalV6TTJVeklDOHZJRzFsZEdodlpDQWliV1YwYUc5a1QyNWxLQ2x6ZEhKcGJtY2lDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzBOVFZqT0dRd09TQXZMeUJ0WlhSb2IyUWdJbTFsZEdodlpFTnZiVzF2YmlncGMzUnlhVzVuSWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WmpsbU5URTBNbU1nTHk4Z2JXVjBhRzlrSUNKaU1rTmhiblJQZG1WeWNtbGtaU2dwYzNSeWFXNW5JZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNell6WWpNeU9XVWdMeThnYldWMGFHOWtJQ0p0WlhSb2IyUlVkMjhvS1hOMGNtbHVaeUlLSUNBZ0lIVnVZMjkyWlhJZ09Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5dFpYUm9iMlJOZFd4MGFWOXliM1YwWlVBMklHMWhhVzVmYldWMGFHOWtRMkZzYkhOVGRYQmxjbDl5YjNWMFpVQTNJRzFoYVc1ZlkyRnNiRUl5UTJGdWRFOTJaWEp5YVdSbFgzSnZkWFJsUURnZ2JXRnBibDlqWVd4c1FqSkRiMjF0YjI1ZmNtOTFkR1ZBT1NCdFlXbHVYMjFsZEdodlpFOXVaVjl5YjNWMFpVQXhNQ0J0WVdsdVgyMWxkR2h2WkVOdmJXMXZibDl5YjNWMFpVQXhNU0J0WVdsdVgySXlRMkZ1ZEU5MlpYSnlhV1JsWDNKdmRYUmxRREV5SUcxaGFXNWZiV1YwYUc5a1ZIZHZYM0p2ZFhSbFFERXpDaUFnSUNCaUlHMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUF4TkFvS2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRREUwT2dvZ0lDQWdZaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRZS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhOam9LSUNBZ0lHSWdiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREU0Q2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1UZzZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVnNkR2t0YVc1b1pYSnBkR0Z1WTJVdVlXeG5ieTUwY3pvME5Rb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRTExYkhScFFtRnpaWE1nWlhoMFpXNWtjeUJqYkdGemMyVnpLRTVoYldWVGRHOXlaU3dnUW1GelpVOXVaU3dnUW1GelpWUjNieWtnZXdvZ0lDQWdaWEp5Q2dwdFlXbHVYMjFsZEdodlpGUjNiMTl5YjNWMFpVQXhNem9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkV3gwYVMxcGJtaGxjbWwwWVc1alpTNWhiR2R2TG5Sek9qTXhDaUFnSUNBdkx5QnRaWFJvYjJSVWQyOG9LU0I3Q2lBZ0lDQmpZV3hzYzNWaUlHMWxkR2h2WkZSM2J3b2dJQ0FnWWlCdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFNVFFLQ20xaGFXNWZZakpEWVc1MFQzWmxjbkpwWkdWZmNtOTFkR1ZBTVRJNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWc2RHa3RhVzVvWlhKcGRHRnVZMlV1WVd4bmJ5NTBjem94TndvZ0lDQWdMeThnWWpKRFlXNTBUM1psY25KcFpHVW9LVG9nYzNSeWFXNW5JSHNLSUNBZ0lHTmhiR3h6ZFdJZ1lqSkRZVzUwVDNabGNuSnBaR1VLSUNBZ0lHSWdiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURFMENncHRZV2x1WDIxbGRHaHZaRU52YlcxdmJsOXliM1YwWlVBeE1Ub0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRXeDBhUzFwYm1obGNtbDBZVzVqWlM1aGJHZHZMblJ6T2pFekNpQWdJQ0F2THlCdFpYUm9iMlJEYjIxdGIyNG9LU0I3Q2lBZ0lDQmpZV3hzYzNWaUlHMWxkR2h2WkVOdmJXMXZiZ29nSUNBZ1lpQnRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTVRRS0NtMWhhVzVmYldWMGFHOWtUMjVsWDNKdmRYUmxRREV3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMbUZzWjI4dWRITTZNalFLSUNBZ0lDOHZJRzFsZEdodlpFOXVaU2dwSUhzS0lDQWdJR05oYkd4emRXSWdiV1YwYUc5a1QyNWxDaUFnSUNCaUlHMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUF4TkFvS2JXRnBibDlqWVd4c1FqSkRiMjF0YjI1ZmNtOTFkR1ZBT1RvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFd4MGFTMXBibWhsY21sMFlXNWpaUzVoYkdkdkxuUnpPall3Q2lBZ0lDQXZMeUJqWVd4c1FqSkRiMjF0YjI0b0tTQjdDaUFnSUNCallXeHNjM1ZpSUdOaGJHeENNa052YlcxdmJnb2dJQ0FnWWlCdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFNVFFLQ20xaGFXNWZZMkZzYkVJeVEyRnVkRTkyWlhKeWFXUmxYM0p2ZFhSbFFEZzZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVnNkR2t0YVc1b1pYSnBkR0Z1WTJVdVlXeG5ieTUwY3pvMU5nb2dJQ0FnTHk4Z1kyRnNiRUl5UTJGdWRFOTJaWEp5YVdSbEtDa2dld29nSUNBZ1kyRnNiSE4xWWlCallXeHNRakpEWVc1MFQzWmxjbkpwWkdVS0lDQWdJR0lnYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFERTBDZ3B0WVdsdVgyMWxkR2h2WkVOaGJHeHpVM1Z3WlhKZmNtOTFkR1ZBTnpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFd4MGFTMXBibWhsY21sMFlXNWpaUzVoYkdkdkxuUnpPalV5Q2lBZ0lDQXZMeUJ0WlhSb2IyUkRZV3hzYzFOMWNHVnlLQ2tnZXdvZ0lDQWdZMkZzYkhOMVlpQnRaWFJvYjJSRFlXeHNjMU4xY0dWeUNpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQXhOQW9LYldGcGJsOXRaWFJvYjJSTmRXeDBhVjl5YjNWMFpVQTJPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFiSFJwTFdsdWFHVnlhWFJoYm1ObExtRnNaMjh1ZEhNNk5EZ0tJQ0FnSUM4dklHMWxkR2h2WkUxMWJIUnBLQ2tnZXdvZ0lDQWdZMkZzYkhOMVlpQnRaWFJvYjJSTmRXeDBhUW9nSUNBZ1lpQnRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTVRRS0NtMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU1UVTZDaUFnSUNCaUlHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhOZ29LYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1UYzZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVnNkR2t0YVc1b1pYSnBkR0Z1WTJVdVlXeG5ieTUwY3pvME5Rb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRTExYkhScFFtRnpaWE1nWlhoMFpXNWtjeUJqYkdGemMyVnpLRTVoYldWVGRHOXlaU3dnUW1GelpVOXVaU3dnUW1GelpWUjNieWtnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHhJQzh2SUU1dlQzQUtJQ0FnSUQwOUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUQwOUNpQWdJQ0FtSmdvZ0lDQWdZWE56WlhKMENpQWdJQ0JqWVd4c2MzVmlJRjlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFd4MGFTMXBibWhsY21sMFlXNWpaUzVoYkdkdkxuUnpPanBOZFd4MGFVSmhjMlZ6TG0xbGRHaHZaRTExYkhScFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tiV1YwYUc5a1RYVnNkR2s2Q2lBZ0lDQmlJRzFsZEdodlpFMTFiSFJwWDJKc2IyTnJRREFLQ20xbGRHaHZaRTExYkhScFgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWc2RHa3RhVzVvWlhKcGRHRnVZMlV1WVd4bmJ5NTBjem8wT0FvZ0lDQWdMeThnYldWMGFHOWtUWFZzZEdrb0tTQjdDaUFnSUNCallXeHNjM1ZpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFd4MGFTMXBibWhsY21sMFlXNWpaUzVoYkdkdkxuUnpPanBOZFd4MGFVSmhjMlZ6TG0xbGRHaHZaRTExYkhScENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFZzZEdrdGFXNW9aWEpwZEdGdVkyVXVZV3huYnk1MGN6bzZUWFZzZEdsQ1lYTmxjeTV0WlhSb2IyUkRZV3hzYzFOMWNHVnlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYldWMGFHOWtRMkZzYkhOVGRYQmxjam9LSUNBZ0lHSWdiV1YwYUc5a1EyRnNiSE5UZFhCbGNsOWliRzlqYTBBd0NncHRaWFJvYjJSRFlXeHNjMU4xY0dWeVgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWc2RHa3RhVzVvWlhKcGRHRnVZMlV1WVd4bmJ5NTBjem8xTWdvZ0lDQWdMeThnYldWMGFHOWtRMkZzYkhOVGRYQmxjaWdwSUhzS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFiSFJwTFdsdWFHVnlhWFJoYm1ObExtRnNaMjh1ZEhNNk9rMTFiSFJwUW1GelpYTXViV1YwYUc5a1EyRnNiSE5UZFhCbGNnb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMbUZzWjI4dWRITTZPazExYkhScFFtRnpaWE11WTJGc2JFSXlRMkZ1ZEU5MlpYSnlhV1JsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kyRnNiRUl5UTJGdWRFOTJaWEp5YVdSbE9nb2dJQ0FnWWlCallXeHNRakpEWVc1MFQzWmxjbkpwWkdWZllteHZZMnRBTUFvS1kyRnNiRUl5UTJGdWRFOTJaWEp5YVdSbFgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWc2RHa3RhVzVvWlhKcGRHRnVZMlV1WVd4bmJ5NTBjem8xTmdvZ0lDQWdMeThnWTJGc2JFSXlRMkZ1ZEU5MlpYSnlhV1JsS0NrZ2V3b2dJQ0FnWTJGc2JITjFZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFZzZEdrdGFXNW9aWEpwZEdGdVkyVXVZV3huYnk1MGN6bzZUWFZzZEdsQ1lYTmxjeTVqWVd4c1FqSkRZVzUwVDNabGNuSnBaR1VLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRXeDBhUzFwYm1obGNtbDBZVzVqWlM1aGJHZHZMblJ6T2pwTmRXeDBhVUpoYzJWekxtTmhiR3hDTWtOdmJXMXZibHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OaGJHeENNa052YlcxdmJqb0tJQ0FnSUdJZ1kyRnNiRUl5UTI5dGJXOXVYMkpzYjJOclFEQUtDbU5oYkd4Q01rTnZiVzF2Ymw5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMbUZzWjI4dWRITTZOakFLSUNBZ0lDOHZJR05oYkd4Q01rTnZiVzF2YmlncElIc0tJQ0FnSUdOaGJHeHpkV0lnZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMbUZzWjI4dWRITTZPazExYkhScFFtRnpaWE11WTJGc2JFSXlRMjl0Ylc5dUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFZzZEdrdGFXNW9aWEpwZEdGdVkyVXVZV3huYnk1MGN6bzZRbUZ6WlU5dVpTNXRaWFJvYjJSUGJtVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B0WlhSb2IyUlBibVU2Q2lBZ0lDQmlJRzFsZEdodlpFOXVaVjlpYkc5amEwQXdDZ3B0WlhSb2IyUlBibVZmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkV3gwYVMxcGJtaGxjbWwwWVc1alpTNWhiR2R2TG5Sek9qSTBDaUFnSUNBdkx5QnRaWFJvYjJSUGJtVW9LU0I3Q2lBZ0lDQmpZV3hzYzNWaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRXeDBhUzFwYm1obGNtbDBZVzVqWlM1aGJHZHZMblJ6T2pwQ1lYTmxUMjVsTG0xbGRHaHZaRTl1WlFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFiSFJwTFdsdWFHVnlhWFJoYm1ObExtRnNaMjh1ZEhNNk9rTnZiVzF2YmtKaGMyVXViV1YwYUc5a1EyOXRiVzl1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2JXVjBhRzlrUTI5dGJXOXVPZ29nSUNBZ1lpQnRaWFJvYjJSRGIyMXRiMjVmWW14dlkydEFNQW9LYldWMGFHOWtRMjl0Ylc5dVgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWc2RHa3RhVzVvWlhKcGRHRnVZMlV1WVd4bmJ5NTBjem94TXdvZ0lDQWdMeThnYldWMGFHOWtRMjl0Ylc5dUtDa2dld29nSUNBZ1kyRnNiSE4xWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWc2RHa3RhVzVvWlhKcGRHRnVZMlV1WVd4bmJ5NTBjem82UTI5dGJXOXVRbUZ6WlM1dFpYUm9iMlJEYjIxdGIyNEtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFd4MGFTMXBibWhsY21sMFlXNWpaUzVoYkdkdkxuUnpPanBEYjIxdGIyNUNZWE5sTG1JeVEyRnVkRTkyWlhKeWFXUmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWWpKRFlXNTBUM1psY25KcFpHVTZDaUFnSUNCaUlHSXlRMkZ1ZEU5MlpYSnlhV1JsWDJKc2IyTnJRREFLQ21JeVEyRnVkRTkyWlhKeWFXUmxYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVnNkR2t0YVc1b1pYSnBkR0Z1WTJVdVlXeG5ieTUwY3pveE53b2dJQ0FnTHk4Z1lqSkRZVzUwVDNabGNuSnBaR1VvS1RvZ2MzUnlhVzVuSUhzS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFiSFJwTFdsdWFHVnlhWFJoYm1ObExtRnNaMjh1ZEhNNk9rTnZiVzF2YmtKaGMyVXVZakpEWVc1MFQzWmxjbkpwWkdVS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkV3gwYVMxcGJtaGxjbWwwWVc1alpTNWhiR2R2TG5Sek9qcENZWE5sVkhkdkxtMWxkR2h2WkZSM2IxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbTFsZEdodlpGUjNiem9LSUNBZ0lHSWdiV1YwYUc5a1ZIZHZYMkpzYjJOclFEQUtDbTFsZEdodlpGUjNiMTlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFiSFJwTFdsdWFHVnlhWFJoYm1ObExtRnNaMjh1ZEhNNk16RUtJQ0FnSUM4dklHMWxkR2h2WkZSM2J5Z3BJSHNLSUNBZ0lHTmhiR3h6ZFdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWJIUnBMV2x1YUdWeWFYUmhibU5sTG1Gc1oyOHVkSE02T2tKaGMyVlVkMjh1YldWMGFHOWtWSGR2Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVnNkR2t0YVc1b1pYSnBkR0Z1WTJVdVlXeG5ieTUwY3pvNlRYVnNkR2xDWVhObGN5NXRaWFJvYjJSTmRXeDBhU2dwSUMwK0lHSjVkR1Z6T2dwMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWc2RHa3RhVzVvWlhKcGRHRnVZMlV1WVd4bmJ5NTBjem82VFhWc2RHbENZWE5sY3k1dFpYUm9iMlJOZFd4MGFUb0tJQ0FnSUdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWJIUnBMV2x1YUdWeWFYUmhibU5sTG1Gc1oyOHVkSE02T2sxMWJIUnBRbUZ6WlhNdWJXVjBhRzlrVFhWc2RHbGZZbXh2WTJ0QU1Bb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFiSFJwTFdsdWFHVnlhWFJoYm1ObExtRnNaMjh1ZEhNNk9rMTFiSFJwUW1GelpYTXViV1YwYUc5a1RYVnNkR2xmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkV3gwYVMxcGJtaGxjbWwwWVc1alpTNWhiR2R2TG5Sek9qUTVDaUFnSUNBdkx5QnlaWFIxY200Z0oyMTFiSFJwTFdKaGMyVnpKd29nSUNBZ2NIVnphR0o1ZEdWeklDSnRkV3gwYVMxaVlYTmxjeUlLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkV3gwYVMxcGJtaGxjbWwwWVc1alpTNWhiR2R2TG5Sek9qcE5kV3gwYVVKaGMyVnpMbTFsZEdodlpFTmhiR3h6VTNWd1pYSW9LU0F0UGlCaWVYUmxjem9LZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMbUZzWjI4dWRITTZPazExYkhScFFtRnpaWE11YldWMGFHOWtRMkZzYkhOVGRYQmxjam9LSUNBZ0lHSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFiSFJwTFdsdWFHVnlhWFJoYm1ObExtRnNaMjh1ZEhNNk9rMTFiSFJwUW1GelpYTXViV1YwYUc5a1EyRnNiSE5UZFhCbGNsOWliRzlqYTBBd0NncDBaWE4wY3k5aGNIQnliM1poYkhNdmJYVnNkR2t0YVc1b1pYSnBkR0Z1WTJVdVlXeG5ieTUwY3pvNlRYVnNkR2xDWVhObGN5NXRaWFJvYjJSRFlXeHNjMU4xY0dWeVgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWc2RHa3RhVzVvWlhKcGRHRnVZMlV1WVd4bmJ5NTBjem8xTXdvZ0lDQWdMeThnY21WMGRYSnVJSE4xY0dWeUxtMWxkR2h2WkZSM2J5Z3BDaUFnSUNCallXeHNjM1ZpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFd4MGFTMXBibWhsY21sMFlXNWpaUzVoYkdkdkxuUnpPanBDWVhObFZIZHZMbTFsZEdodlpGUjNid29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFiSFJwTFdsdWFHVnlhWFJoYm1ObExtRnNaMjh1ZEhNNk9rMTFiSFJwUW1GelpYTXVZMkZzYkVJeVEyRnVkRTkyWlhKeWFXUmxLQ2tnTFQ0Z1lubDBaWE02Q25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFd4MGFTMXBibWhsY21sMFlXNWpaUzVoYkdkdkxuUnpPanBOZFd4MGFVSmhjMlZ6TG1OaGJHeENNa05oYm5SUGRtVnljbWxrWlRvS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMbUZzWjI4dWRITTZPazExYkhScFFtRnpaWE11WTJGc2JFSXlRMkZ1ZEU5MlpYSnlhV1JsWDJKc2IyTnJRREFLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFd4MGFTMXBibWhsY21sMFlXNWpaUzVoYkdkdkxuUnpPanBOZFd4MGFVSmhjMlZ6TG1OaGJHeENNa05oYm5SUGRtVnljbWxrWlY5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMbUZzWjI4dWRITTZOVGNLSUNBZ0lDOHZJSEpsZEhWeWJpQnpkWEJsY2k1amJHRnpjeWhDWVhObFZIZHZLUzVpTWtOaGJuUlBkbVZ5Y21sa1pTZ3BDaUFnSUNCallXeHNjM1ZpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFd4MGFTMXBibWhsY21sMFlXNWpaUzVoYkdkdkxuUnpPanBDWVhObFZIZHZMbUl5UTJGdWRFOTJaWEp5YVdSbENpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWc2RHa3RhVzVvWlhKcGRHRnVZMlV1WVd4bmJ5NTBjem82VFhWc2RHbENZWE5sY3k1allXeHNRakpEYjIxdGIyNG9LU0F0UGlCaWVYUmxjem9LZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMbUZzWjI4dWRITTZPazExYkhScFFtRnpaWE11WTJGc2JFSXlRMjl0Ylc5dU9nb2dJQ0FnWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWc2RHa3RhVzVvWlhKcGRHRnVZMlV1WVd4bmJ5NTBjem82VFhWc2RHbENZWE5sY3k1allXeHNRakpEYjIxdGIyNWZZbXh2WTJ0QU1Bb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFiSFJwTFdsdWFHVnlhWFJoYm1ObExtRnNaMjh1ZEhNNk9rMTFiSFJwUW1GelpYTXVZMkZzYkVJeVEyOXRiVzl1WDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFZzZEdrdGFXNW9aWEpwZEdGdVkyVXVZV3huYnk1MGN6bzJNUW9nSUNBZ0x5OGdjbVYwZFhKdUlITjFjR1Z5TG1Oc1lYTnpLRUpoYzJWVWQyOHBMbTFsZEdodlpFTnZiVzF2YmlncENpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkV3gwYVMxcGJtaGxjbWwwWVc1alpTNWhiR2R2TG5Sek9qcERiMjF0YjI1Q1lYTmxMbTFsZEdodlpFTnZiVzF2YmdvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMbUZzWjI4dWRITTZPa0poYzJWUGJtVXViV1YwYUc5a1QyNWxLQ2tnTFQ0Z1lubDBaWE02Q25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFd4MGFTMXBibWhsY21sMFlXNWpaUzVoYkdkdkxuUnpPanBDWVhObFQyNWxMbTFsZEdodlpFOXVaVG9LSUNBZ0lHSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFiSFJwTFdsdWFHVnlhWFJoYm1ObExtRnNaMjh1ZEhNNk9rSmhjMlZQYm1VdWJXVjBhRzlrVDI1bFgySnNiMk5yUURBS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRXeDBhUzFwYm1obGNtbDBZVzVqWlM1aGJHZHZMblJ6T2pwQ1lYTmxUMjVsTG0xbGRHaHZaRTl1WlY5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMbUZzWjI4dWRITTZNalVLSUNBZ0lDOHZJSEpsZEhWeWJpQW5ZbUZ6WlMxdmJtVW5DaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltSmhjMlV0YjI1bElnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWJIUnBMV2x1YUdWeWFYUmhibU5sTG1Gc1oyOHVkSE02T2tOdmJXMXZia0poYzJVdWJXVjBhRzlrUTI5dGJXOXVLQ2tnTFQ0Z1lubDBaWE02Q25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFd4MGFTMXBibWhsY21sMFlXNWpaUzVoYkdkdkxuUnpPanBEYjIxdGIyNUNZWE5sTG0xbGRHaHZaRU52YlcxdmJqb0tJQ0FnSUdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWJIUnBMV2x1YUdWeWFYUmhibU5sTG1Gc1oyOHVkSE02T2tOdmJXMXZia0poYzJVdWJXVjBhRzlrUTI5dGJXOXVYMkpzYjJOclFEQUtDblJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkV3gwYVMxcGJtaGxjbWwwWVc1alpTNWhiR2R2TG5Sek9qcERiMjF0YjI1Q1lYTmxMbTFsZEdodlpFTnZiVzF2Ymw5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMbUZzWjI4dWRITTZNVFFLSUNBZ0lDOHZJSEpsZEhWeWJpQW5ZMjl0Ylc5dUp3b2dJQ0FnWW5sMFpXTmZNU0F2THlBaVkyOXRiVzl1SWdvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMbUZzWjI4dWRITTZPa052YlcxdmJrSmhjMlV1WWpKRFlXNTBUM1psY25KcFpHVW9LU0F0UGlCaWVYUmxjem9LZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMbUZzWjI4dWRITTZPa052YlcxdmJrSmhjMlV1WWpKRFlXNTBUM1psY25KcFpHVTZDaUFnSUNCaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRXeDBhUzFwYm1obGNtbDBZVzVqWlM1aGJHZHZMblJ6T2pwRGIyMXRiMjVDWVhObExtSXlRMkZ1ZEU5MlpYSnlhV1JsWDJKc2IyTnJRREFLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFd4MGFTMXBibWhsY21sMFlXNWpaUzVoYkdkdkxuUnpPanBEYjIxdGIyNUNZWE5sTG1JeVEyRnVkRTkyWlhKeWFXUmxYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVnNkR2t0YVc1b1pYSnBkR0Z1WTJVdVlXeG5ieTUwY3pveE9Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUNkamIyMXRiMjRuQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pqYjIxdGIyNGlDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVnNkR2t0YVc1b1pYSnBkR0Z1WTJVdVlXeG5ieTUwY3pvNlFtRnpaVlIzYnk1dFpYUm9iMlJVZDI4b0tTQXRQaUJpZVhSbGN6b0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFiSFJwTFdsdWFHVnlhWFJoYm1ObExtRnNaMjh1ZEhNNk9rSmhjMlZVZDI4dWJXVjBhRzlrVkhkdk9nb2dJQ0FnWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWc2RHa3RhVzVvWlhKcGRHRnVZMlV1WVd4bmJ5NTBjem82UW1GelpWUjNieTV0WlhSb2IyUlVkMjlmWW14dlkydEFNQW9LZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMbUZzWjI4dWRITTZPa0poYzJWVWQyOHViV1YwYUc5a1ZIZHZYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVnNkR2t0YVc1b1pYSnBkR0Z1WTJVdVlXeG5ieTUwY3pvek1nb2dJQ0FnTHk4Z2NtVjBkWEp1SUNkaVlYTmxMWFIzYnljS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1KaGMyVXRkSGR2SWdvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMbUZzWjI4dWRITTZPa0poYzJWVWQyOHVZakpEWVc1MFQzWmxjbkpwWkdVb0tTQXRQaUJpZVhSbGN6b0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFiSFJwTFdsdWFHVnlhWFJoYm1ObExtRnNaMjh1ZEhNNk9rSmhjMlZVZDI4dVlqSkRZVzUwVDNabGNuSnBaR1U2Q2lBZ0lDQmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkV3gwYVMxcGJtaGxjbWwwWVc1alpTNWhiR2R2TG5Sek9qcENZWE5sVkhkdkxtSXlRMkZ1ZEU5MlpYSnlhV1JsWDJKc2IyTnJRREFLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFd4MGFTMXBibWhsY21sMFlXNWpaUzVoYkdkdkxuUnpPanBDWVhObFZIZHZMbUl5UTJGdWRFOTJaWEp5YVdSbFgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWc2RHa3RhVzVvWlhKcGRHRnVZMlV1WVd4bmJ5NTBjem8wTVFvZ0lDQWdMeThnY21WMGRYSnVJQ2RpWVhObExYUjNieWNLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbUpoYzJVdGRIZHZJZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFiSFJwTFdsdWFHVnlhWFJoYm1ObExtRnNaMjh1ZEhNNk9rMTFiSFJwUW1GelpYTXVYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbEtDa2dMVDRnZG05cFpEb0tYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbE9nb2dJQ0FnWWlCZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZmWW14dlkydEFNQW9LWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxYMkpzYjJOclFEQTZDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVnNkR2t0YVc1b1pYSnBkR0Z1WTJVdVlXeG5ieTUwY3pvNlRYVnNkR2xDWVhObGN5NWpiMjV6ZEhKMVkzUnZjaWdwSUMwK0lIWnZhV1E2Q21OdmJuTjBjblZqZEc5eU9nb2dJQ0FnWWlCamIyNXpkSEoxWTNSdmNsOWliRzlqYTBBd0NncGpiMjV6ZEhKMVkzUnZjbDlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFiSFJwTFdsdWFHVnlhWFJoYm1ObExtRnNaMjh1ZEhNNk5EVUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJOZFd4MGFVSmhjMlZ6SUdWNGRHVnVaSE1nWTJ4aGMzTmxjeWhPWVcxbFUzUnZjbVVzSUVKaGMyVlBibVVzSUVKaGMyVlVkMjhwSUhzS0lDQWdJR05oYkd4emRXSWdjRzlzZVhSNWNHVXZiR2xpTDNCdmJIbDBlWEJsTFcxdlpIVnNaUzVrTG5Sek9qcERiSFZ6ZEdWeVpXUkRiMjUwY21GamREeDBaWE4wY3k5aGNIQnliM1poYkhNdmJYVnNkR2t0YVc1b1pYSnBkR0Z1WTJVdVlXeG5ieTUwY3pvNlRtRnRaVk4wYjNKbExIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRXeDBhUzFwYm1obGNtbDBZVzVqWlM1aGJHZHZMblJ6T2pwQ1lYTmxUMjVsTEhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFd4MGFTMXBibWhsY21sMFlXNWpaUzVoYkdkdkxuUnpPanBDWVhObFZIZHZQaTVqYjI1emRISjFZM1J2Y2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMbUZzWjI4dWRITTZORFlLSUNBZ0lDOHZJSE4wWVhSbFRYVnNkR2tnUFNCSGJHOWlZV3hUZEdGMFpTaDdJR2x1YVhScFlXeFdZV3gxWlRvZ0owaHRiVzBuSUgwcENpQWdJQ0J3ZFhOb1lubDBaWE1nSW5OMFlYUmxUWFZzZEdraUNpQWdJQ0J3ZFhOb1lubDBaWE1nSWtodGJXMGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjRzlzZVhSNWNHVXZiR2xpTDNCdmJIbDBlWEJsTFcxdlpIVnNaUzVrTG5Sek9qcERiSFZ6ZEdWeVpXUkRiMjUwY21GamREeDBaWE4wY3k5aGNIQnliM1poYkhNdmJYVnNkR2t0YVc1b1pYSnBkR0Z1WTJVdVlXeG5ieTUwY3pvNlRtRnRaVk4wYjNKbExIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRXeDBhUzFwYm1obGNtbDBZVzVqWlM1aGJHZHZMblJ6T2pwQ1lYTmxUMjVsTEhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFd4MGFTMXBibWhsY21sMFlXNWpaUzVoYkdkdkxuUnpPanBDWVhObFZIZHZQaTVqYjI1emRISjFZM1J2Y2lncElDMCtJSFp2YVdRNkNuQnZiSGwwZVhCbEwyeHBZaTl3YjJ4NWRIbHdaUzF0YjJSMWJHVXVaQzUwY3pvNlEyeDFjM1JsY21Wa1EyOXVkSEpoWTNROGRHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWJIUnBMV2x1YUdWeWFYUmhibU5sTG1Gc1oyOHVkSE02T2s1aGJXVlRkRzl5WlN4MFpYTjBjeTloY0hCeWIzWmhiSE12YlhWc2RHa3RhVzVvWlhKcGRHRnVZMlV1WVd4bmJ5NTBjem82UW1GelpVOXVaU3gwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFZzZEdrdGFXNW9aWEpwZEdGdVkyVXVZV3huYnk1MGN6bzZRbUZ6WlZSM2J6NHVZMjl1YzNSeWRXTjBiM0k2Q2lBZ0lDQmlJSEJ2YkhsMGVYQmxMMnhwWWk5d2IyeDVkSGx3WlMxdGIyUjFiR1V1WkM1MGN6bzZRMngxYzNSbGNtVmtRMjl1ZEhKaFkzUThkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFiSFJwTFdsdWFHVnlhWFJoYm1ObExtRnNaMjh1ZEhNNk9rNWhiV1ZUZEc5eVpTeDBaWE4wY3k5aGNIQnliM1poYkhNdmJYVnNkR2t0YVc1b1pYSnBkR0Z1WTJVdVlXeG5ieTUwY3pvNlFtRnpaVTl1WlN4MFpYTjBjeTloY0hCeWIzWmhiSE12YlhWc2RHa3RhVzVvWlhKcGRHRnVZMlV1WVd4bmJ5NTBjem82UW1GelpWUjNiejR1WTI5dWMzUnlkV04wYjNKZllteHZZMnRBTUFvS2NHOXNlWFI1Y0dVdmJHbGlMM0J2YkhsMGVYQmxMVzF2WkhWc1pTNWtMblJ6T2pwRGJIVnpkR1Z5WldSRGIyNTBjbUZqZER4MFpYTjBjeTloY0hCeWIzWmhiSE12YlhWc2RHa3RhVzVvWlhKcGRHRnVZMlV1WVd4bmJ5NTBjem82VG1GdFpWTjBiM0psTEhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFd4MGFTMXBibWhsY21sMFlXNWpaUzVoYkdkdkxuUnpPanBDWVhObFQyNWxMSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkV3gwYVMxcGJtaGxjbWwwWVc1alpTNWhiR2R2TG5Sek9qcENZWE5sVkhkdlBpNWpiMjV6ZEhKMVkzUnZjbDlpYkc5amEwQXdPZ29nSUNBZ1lpQndiMng1ZEhsd1pTOXNhV0l2Y0c5c2VYUjVjR1V0Ylc5a2RXeGxMbVF1ZEhNNk9rTnNkWE4wWlhKbFpFTnZiblJ5WVdOMFBIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRXeDBhUzFwYm1obGNtbDBZVzVqWlM1aGJHZHZMblJ6T2pwT1lXMWxVM1J2Y21Vc2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWJIUnBMV2x1YUdWeWFYUmhibU5sTG1Gc1oyOHVkSE02T2tKaGMyVlBibVVzZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMbUZzWjI4dWRITTZPa0poYzJWVWQyOCtMbU52Ym5OMGNuVmpkRzl5WDJKc2IyTnJRREVLQ25CdmJIbDBlWEJsTDJ4cFlpOXdiMng1ZEhsd1pTMXRiMlIxYkdVdVpDNTBjem82UTJ4MWMzUmxjbVZrUTI5dWRISmhZM1E4ZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMbUZzWjI4dWRITTZPazVoYldWVGRHOXlaU3gwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFZzZEdrdGFXNW9aWEpwZEdGdVkyVXVZV3huYnk1MGN6bzZRbUZ6WlU5dVpTeDBaWE4wY3k5aGNIQnliM1poYkhNdmJYVnNkR2t0YVc1b1pYSnBkR0Z1WTJVdVlXeG5ieTUwY3pvNlFtRnpaVlIzYno0dVkyOXVjM1J5ZFdOMGIzSmZZbXh2WTJ0QU1Ub0tJQ0FnSUdJZ2NHOXNlWFI1Y0dVdmJHbGlMM0J2YkhsMGVYQmxMVzF2WkhWc1pTNWtMblJ6T2pwRGJIVnpkR1Z5WldSRGIyNTBjbUZqZER4MFpYTjBjeTloY0hCeWIzWmhiSE12YlhWc2RHa3RhVzVvWlhKcGRHRnVZMlV1WVd4bmJ5NTBjem82VG1GdFpWTjBiM0psTEhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFd4MGFTMXBibWhsY21sMFlXNWpaUzVoYkdkdkxuUnpPanBDWVhObFQyNWxMSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkV3gwYVMxcGJtaGxjbWwwWVc1alpTNWhiR2R2TG5Sek9qcENZWE5sVkhkdlBpNWpiMjV6ZEhKMVkzUnZjbDloWm5SbGNsOXBibXhwYm1Wa1gwQmhiR2R2Y21GdVpHWnZkVzVrWVhScGIyNHZZV3huYjNKaGJtUXRkSGx3WlhOamNtbHdkQzlpWVhObExXTnZiblJ5WVdOMExtUXVkSE02T2tKaGMyVkRiMjUwY21GamRDNWpiMjV6ZEhKMVkzUnZja0F5Q2dwd2IyeDVkSGx3WlM5c2FXSXZjRzlzZVhSNWNHVXRiVzlrZFd4bExtUXVkSE02T2tOc2RYTjBaWEpsWkVOdmJuUnlZV04wUEhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFd4MGFTMXBibWhsY21sMFlXNWpaUzVoYkdkdkxuUnpPanBPWVcxbFUzUnZjbVVzZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMbUZzWjI4dWRITTZPa0poYzJWUGJtVXNkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFiSFJwTFdsdWFHVnlhWFJoYm1ObExtRnNaMjh1ZEhNNk9rSmhjMlZVZDI4K0xtTnZibk4wY25WamRHOXlYMkZtZEdWeVgybHViR2x1WldSZlFHRnNaMjl5WVc1a1ptOTFibVJoZEdsdmJpOWhiR2R2Y21GdVpDMTBlWEJsYzJOeWFYQjBMMkpoYzJVdFkyOXVkSEpoWTNRdVpDNTBjem82UW1GelpVTnZiblJ5WVdOMExtTnZibk4wY25WamRHOXlRREk2Q2lBZ0lDQmpZV3hzYzNWaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRXeDBhUzFwYm1obGNtbDBZVzVqWlM1aGJHZHZMblJ6T2pwQ1lYTmxUMjVsTG1OdmJuTjBjblZqZEc5eUNpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkV3gwYVMxcGJtaGxjbWwwWVc1alpTNWhiR2R2TG5Sek9qcENZWE5sVkhkdkxtTnZibk4wY25WamRHOXlDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVnNkR2t0YVc1b1pYSnBkR0Z1WTJVdVlXeG5ieTUwY3pvNlFtRnpaVTl1WlM1amIyNXpkSEoxWTNSdmNpZ3BJQzArSUhadmFXUTZDblJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkV3gwYVMxcGJtaGxjbWwwWVc1alpTNWhiR2R2TG5Sek9qcENZWE5sVDI1bExtTnZibk4wY25WamRHOXlPZ29nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVnNkR2t0YVc1b1pYSnBkR0Z1WTJVdVlXeG5ieTUwY3pvNlFtRnpaVTl1WlM1amIyNXpkSEoxWTNSdmNsOWliRzlqYTBBd0NncDBaWE4wY3k5aGNIQnliM1poYkhNdmJYVnNkR2t0YVc1b1pYSnBkR0Z1WTJVdVlXeG5ieTUwY3pvNlFtRnpaVTl1WlM1amIyNXpkSEoxWTNSdmNsOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWJIUnBMV2x1YUdWeWFYUmhibU5sTG1Gc1oyOHVkSE02TWpJS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkNZWE5sVDI1bElHVjRkR1Z1WkhNZ1EyOXRiVzl1UW1GelpTQjdDaUFnSUNCallXeHNjM1ZpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFd4MGFTMXBibWhsY21sMFlXNWpaUzVoYkdkdkxuUnpPanBEYjIxdGIyNUNZWE5sTG1OdmJuTjBjblZqZEc5eUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWc2RHa3RhVzVvWlhKcGRHRnVZMlV1WVd4bmJ5NTBjem95TXdvZ0lDQWdMeThnYzNSaGRHVlBibVVnUFNCSGJHOWlZV3hUZEdGMFpTaDdJR2x1YVhScFlXeFdZV3gxWlRvZ1ZXbHVkRFkwS0RRMUtTQjlLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSnpkR0YwWlU5dVpTSUtJQ0FnSUhCMWMyaHBiblFnTkRVS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWc2RHa3RhVzVvWlhKcGRHRnVZMlV1WVd4bmJ5NTBjem82UTI5dGJXOXVRbUZ6WlM1amIyNXpkSEoxWTNSdmNpZ3BJQzArSUhadmFXUTZDblJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkV3gwYVMxcGJtaGxjbWwwWVc1alpTNWhiR2R2TG5Sek9qcERiMjF0YjI1Q1lYTmxMbU52Ym5OMGNuVmpkRzl5T2dvZ0lDQWdZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFZzZEdrdGFXNW9aWEpwZEdGdVkyVXVZV3huYnk1MGN6bzZRMjl0Ylc5dVFtRnpaUzVqYjI1emRISjFZM1J2Y2w5aWJHOWphMEF3Q2dwMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWc2RHa3RhVzVvWlhKcGRHRnVZMlV1WVd4bmJ5NTBjem82UTI5dGJXOXVRbUZ6WlM1amIyNXpkSEoxWTNSdmNsOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWJIUnBMV2x1YUdWeWFYUmhibU5sTG1Gc1oyOHVkSE02TVRBS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkRiMjF0YjI1Q1lYTmxJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVnNkR2t0YVc1b1pYSnBkR0Z1WTJVdVlXeG5ieTUwY3pvNlEyOXRiVzl1UW1GelpTNWpiMjV6ZEhKMVkzUnZjbDlpYkc5amEwQXhDZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFZzZEdrdGFXNW9aWEpwZEdGdVkyVXVZV3huYnk1MGN6bzZRMjl0Ylc5dVFtRnpaUzVqYjI1emRISjFZM1J2Y2w5aWJHOWphMEF4T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMbUZzWjI4dWRITTZNVEFLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCRGIyMXRiMjVDWVhObElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWc2RHa3RhVzVvWlhKcGRHRnVZMlV1WVd4bmJ5NTBjem82UTI5dGJXOXVRbUZ6WlM1amIyNXpkSEoxWTNSdmNsOWhablJsY2w5cGJteHBibVZrWDBCaGJHZHZjbUZ1WkdadmRXNWtZWFJwYjI0dllXeG5iM0poYm1RdGRIbHdaWE5qY21sd2RDOWlZWE5sTFdOdmJuUnlZV04wTG1RdWRITTZPa0poYzJWRGIyNTBjbUZqZEM1amIyNXpkSEoxWTNSdmNrQXlDZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFZzZEdrdGFXNW9aWEpwZEdGdVkyVXVZV3huYnk1MGN6bzZRMjl0Ylc5dVFtRnpaUzVqYjI1emRISjFZM1J2Y2w5aFpuUmxjbDlwYm14cGJtVmtYMEJoYkdkdmNtRnVaR1p2ZFc1a1lYUnBiMjR2WVd4bmIzSmhibVF0ZEhsd1pYTmpjbWx3ZEM5aVlYTmxMV052Ym5SeVlXTjBMbVF1ZEhNNk9rSmhjMlZEYjI1MGNtRmpkQzVqYjI1emRISjFZM1J2Y2tBeU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWJIUnBMV2x1YUdWeWFYUmhibU5sTG1Gc1oyOHVkSE02TVRFS0lDQWdJQzh2SUhOMFlYUmxRMjl0Ylc5dUlEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUdsdWFYUnBZV3hXWVd4MVpUb2dNVEl6SUgwcENpQWdJQ0J3ZFhOb1lubDBaWE1nSW5OMFlYUmxRMjl0Ylc5dUlnb2dJQ0FnY0hWemFHbHVkQ0F4TWpNS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWc2RHa3RhVzVvWlhKcGRHRnVZMlV1WVd4bmJ5NTBjem82UW1GelpWUjNieTVqYjI1emRISjFZM1J2Y2lncElDMCtJSFp2YVdRNkNuUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRXeDBhUzFwYm1obGNtbDBZVzVqWlM1aGJHZHZMblJ6T2pwQ1lYTmxWSGR2TG1OdmJuTjBjblZqZEc5eU9nb2dJQ0FnWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWc2RHa3RhVzVvWlhKcGRHRnVZMlV1WVd4bmJ5NTBjem82UW1GelpWUjNieTVqYjI1emRISjFZM1J2Y2w5aWJHOWphMEF3Q2dwMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWc2RHa3RhVzVvWlhKcGRHRnVZMlV1WVd4bmJ5NTBjem82UW1GelpWUjNieTVqYjI1emRISjFZM1J2Y2w5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMbUZzWjI4dWRITTZNamtLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQ1lYTmxWSGR2SUdWNGRHVnVaSE1nUTI5dGJXOXVRbUZ6WlNCN0NpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkV3gwYVMxcGJtaGxjbWwwWVc1alpTNWhiR2R2TG5Sek9qcERiMjF0YjI1Q1lYTmxMbU52Ym5OMGNuVmpkRzl5Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFZzZEdrdGFXNW9aWEpwZEdGdVkyVXVZV3huYnk1MGN6b3pNQW9nSUNBZ0x5OGdjM1JoZEdWVWQyOGdQU0JIYkc5aVlXeFRkR0YwWlNoN0lHbHVhWFJwWVd4V1lXeDFaVG9nSjBobGJHeHZKeUI5S1FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0p6ZEdGMFpWUjNieUlLSUNBZ0lIQjFjMmhpZVhSbGN5QWlTR1ZzYkc4aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQmlJRzFoYVc1ZllteHZZMnRBTUFvS2JXRnBibDlpYkc5amEwQXdPZ29nSUNBZ2NIVnphR2x1ZENBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFDQVFBbUF3UVZIM3gxQm1OdmJXMXZiZ2hpWVhObExYUjNiMElBQURFWVFBQUpRZ0FBaUFHdVFnQUFRZ0FBTVJzakUwRUFsa0lBQURFWkl4SkVNUmdqRTBFQWhFSUFBRFlhQUlBRUtRNjZuNEFFZzUyVy80QUVxWGpLVm9BRWlGUit1SUFFd3lVejQ0QUVSVnlOQ1lBRStmVVVMSUFFTmpzeW5rOElqZ2dBTkFBdUFDZ0FJZ0FjQUJZQUVBQUtRZ0FBUWdBQVFnQUFBSWdBMlVMLzg0Z0F2VUwvN1lnQW9VTC81NGdBaFVMLzRZZ0FhVUwvMjRnQVRVTC8xWWdBTVVML3o0Z0FGVUwveVVML3lURVpJeEl4R0NNU0VFU0lBUG9pUTBJQUFJZ0Fxa2tWRmxjR0FrOEJVQ2hQQVZDd0lrTkNBQUNJQUtWSkZSWlhCZ0pQQVZBb1R3RlFzQ0pEUWdBQWlBQ1dTUlVXVndZQ1R3RlFLRThCVUxBaVEwSUFBSWdBaDBrVkZsY0dBazhCVUNoUEFWQ3dJa05DQUFDSUFIaEpGUlpYQmdKUEFWQW9Ud0ZRc0NKRFFnQUFpQUJ3U1JVV1Z3WUNUd0ZRS0U4QlVMQWlRMElBQUlnQVgwa1ZGbGNHQWs4QlVDaFBBVkN3SWtOQ0FBQ0lBRTVKRlJaWEJnSlBBVkFvVHdGUXNDSkRRZ0FBZ0F0dGRXeDBhUzFpWVhObGM0bENBQUNJQUNlSlFnQUFpQUFsaVVJQUFJZ0FENGxDQUFDQUNHSmhjMlV0YjI1bGlVSUFBQ21KUWdBQUtZbENBQUFxaVVJQUFDcUpRZ0FBaVVJQUFJZ0FGSUFLYzNSaGRHVk5kV3gwYVlBRVNHMXRiV2VKUWdBQVFnQUFRZ0FBaUFBRWlBQXZpVUlBQUlnQURvQUljM1JoZEdWUGJtV0JMV2VKUWdBQVFnQUFRZ0FBZ0F0emRHRjBaVU52YlcxdmJvRjdaNGxDQUFDSS8rQ0FDSE4wWVhSbFZIZHZnQVZJWld4c2IyZUoiLCJjbGVhciI6IkMwSUFBSUVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
