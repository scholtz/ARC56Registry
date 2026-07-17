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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.C_d9fe6cec
{


    public class CProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="__arc4_y"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Exp2(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 104, 188, 40, 116 };

            var result = await base.CallApp(new List<object> { abiHandle, __arc4_y }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Exp2_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 104, 188, 40, 116 };

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_y }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="__arc4_y"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> ExpMinus2(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 246, 45, 80, 248 };

            var result = await base.CallApp(new List<object> { abiHandle, __arc4_y }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> ExpMinus2_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 246, 45, 80, 248 };

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_y }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="__arc4_y"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> ExpUintMax(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 250, 63, 214, 97 };

            var result = await base.CallApp(new List<object> { abiHandle, __arc4_y }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> ExpUintMax_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 250, 63, 214, 97 };

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_y }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="__arc4_y"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> ExpIntMax(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 71, 206, 75, 129 };

            var result = await base.CallApp(new List<object> { abiHandle, __arc4_y }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> ExpIntMax_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 71, 206, 75, 129 };

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_y }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="__arc4_y"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Exp5(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 6, 66, 153, 209 };

            var result = await base.CallApp(new List<object> { abiHandle, __arc4_y }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Exp5_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 6, 66, 153, 209 };

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_y }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="__arc4_y"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> ExpMinus5(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 34, 157, 100 };

            var result = await base.CallApp(new List<object> { abiHandle, __arc4_y }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> ExpMinus5_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 34, 157, 100 };

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_y }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="__arc4_y"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Exp256(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 147, 92, 251, 141 };

            var result = await base.CallApp(new List<object> { abiHandle, __arc4_y }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Exp256_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 147, 92, 251, 141 };

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_y }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="__arc4_y"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> ExpMinus256(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 60, 3, 180, 10 };

            var result = await base.CallApp(new List<object> { abiHandle, __arc4_y }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> ExpMinus256_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 60, 3, 180, 10 };

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_y }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJleHBfMiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X3kiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZXhwX21pbnVzXzIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF95IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImV4cF91aW50X21heCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X3kiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZXhwX2ludF9tYXgiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF95IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImV4cF81IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfeSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJleHBfbWludXNfNSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X3kiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZXhwXzI1NiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X3kiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZXhwX21pbnVzXzI1NiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X3kiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyMjgsMzY4LDQ2MSw2MDIsNjk2LDgzNSw5NjAsMTA5OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQyNTYiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDEsMzgxLDQ3NCw2MTUsNzA5LDg0OCw5NzMsMTExMl0sImVycm9yTWVzc2FnZSI6Im5vdCBwYXlhYmxlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzMyLDQzNyw1NjYsNjcyLDc5OSw5MzYsMTA2MywxMTY3XSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDgsNTQyLDc3NSwxMDM5XSwiZXJyb3JNZXNzYWdlIjoic2lnbmVkIGV4cCBvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2ZEdWemRITXZjMjlzYVdScGRIa3RjMlZ0WVc1MGFXTXRkR1Z6ZEhNdmRHVnpkSE12ZG1saFdYVnNMMlY0Y0Y5c2FYUmxjbUZzYzE5emRXTmpaWE56TG5OdmJDNURMbUZ3Y0hKdmRtRnNYM0J5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ016SWdNU0F3Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0SURCNE1ERWdNSGd3TWlBd2VEZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQWdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBZ01IZ3hOVEZtTjJNM05TQXdlREF4TURBS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmtkWEJ1SURFeUNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNJaUNpQWdJQ0J3ZFhOb2FXNTBJRFF3T1RZS0lDQWdJR0o2WlhKdkNpQWdJQ0JrZFhBS0lDQWdJSE4wYjNKbElEVUtJQ0FnSUhOMGIzSmxJREFLSUNBZ0lHeHZZV1FnTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREE0TUFvZ0lDQWdjbVZ3YkdGalpUSWdOalFLSUNBZ0lITjBiM0psSURBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE5qaGlZekk0TnpRZ01IaG1OakprTlRCbU9DQXdlR1poTTJaa05qWXhJREI0TkRkalpUUmlPREVnTUhnd05qUXlPVGxrTVNBd2VHUTVNakk1WkRZMElEQjRPVE0xWTJaaU9HUWdNSGd6WXpBellqUXdZU0F2THlCdFpYUm9iMlFnSW1WNGNGOHlLSFZwYm5ReU5UWXBkV2x1ZERJMU5pSXNJRzFsZEdodlpDQWlaWGh3WDIxcGJuVnpYeklvZFdsdWRESTFOaWwxYVc1ME1qVTJJaXdnYldWMGFHOWtJQ0psZUhCZmRXbHVkRjl0WVhnb2RXbHVkREkxTmlsMWFXNTBNalUySWl3Z2JXVjBhRzlrSUNKbGVIQmZhVzUwWDIxaGVDaDFhVzUwTWpVMktYVnBiblF5TlRZaUxDQnRaWFJvYjJRZ0ltVjRjRjgxS0hWcGJuUXlOVFlwZFdsdWRESTFOaUlzSUcxbGRHaHZaQ0FpWlhod1gyMXBiblZ6WHpVb2RXbHVkREkxTmlsMWFXNTBNalUySWl3Z2JXVjBhRzlrSUNKbGVIQmZNalUyS0hWcGJuUXlOVFlwZFdsdWRESTFOaUlzSUcxbGRHaHZaQ0FpWlhod1gyMXBiblZ6WHpJMU5paDFhVzUwTWpVMktYVnBiblF5TlRZaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDJWNGNGOHlYM0p2ZFhSbFFEVWdiV0ZwYmw5bGVIQmZiV2x1ZFhOZk1sOXliM1YwWlVBMklHMWhhVzVmWlhod1gzVnBiblJmYldGNFgzSnZkWFJsUURjZ2JXRnBibDlsZUhCZmFXNTBYMjFoZUY5eWIzVjBaVUE0SUcxaGFXNWZaWGh3WHpWZmNtOTFkR1ZBT1NCdFlXbHVYMlY0Y0Y5dGFXNTFjMTgxWDNKdmRYUmxRREV3SUcxaGFXNWZaWGh3WHpJMU5sOXliM1YwWlVBeE1TQnRZV2x1WDJWNGNGOXRhVzUxYzE4eU5UWmZjbTkxZEdWQU1USUtJQ0FnSUdWeWNnb0tiV0ZwYmw5bGVIQmZiV2x1ZFhOZk1qVTJYM0p2ZFhSbFFERXlPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREUxQ2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREU0Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREU1T2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREVLSUNBZ0lHSjFjbmtnTWdvZ0lDQWdZbmwwWldNZ05pQXZMeUF3ZURBeE1EQUtJQ0FnSUdKMWNua2dNVEFLSUNBZ0lHUnBaeUF4TXdvZ0lDQWdZblZ5ZVNBMkNncHRZV2x1WDNkb2FXeGxYM1J2Y0VBeU1Ub0tJQ0FnSUdScFp5QTFDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaVBnb2dJQ0FnWW5vZ2JXRnBibDloWm5SbGNsOTNhR2xzWlVBeU5Rb2dJQ0FnWkdsbklEVUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNUW9nSUNBZ1lpWUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdJaFBRb2dJQ0FnWW5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTBDaUFnSUNCa2FXY2dNUW9nSUNBZ1pHbG5JREV3Q2lBZ0lDQmlLZ29nSUNBZ1luVnllU0F5Q2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qUTZDaUFnSUNCa2FXY2dOUW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF5Q2lBZ0lDQmlMd29nSUNBZ1luVnllU0EyQ2lBZ0lDQmthV2NnT1FvZ0lDQWdaSFZ3Q2lBZ0lDQmlLZ29nSUNBZ1luVnllU0F4TUFvZ0lDQWdZaUJ0WVdsdVgzZG9hV3hsWDNSdmNFQXlNUW9LYldGcGJsOWhablJsY2w5M2FHbHNaVUF5TlRvS0lDQWdJR1JwWnlBeE13b2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXlDaUFnSUNCaUpRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWWlFOUNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01nb2dJQ0FnWW5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFESTNDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRPREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1pHbG5JRElLSUNBZ0lHSThDaUFnSUNBaENncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNamc2Q2lBZ0lDQmhjM05sY25RZ0x5OGdjMmxuYm1Wa0lHVjRjQ0J2ZG1WeVpteHZkd29nSUNBZ1pIVndDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNekVLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmlQVDBLSUNBZ0lHSnVlaUJ0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTXpFS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdScFp5QXlDaUFnSUNCaUxRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF6TWpvS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR0o4Q2lBZ0lDQmllWFJsWXlBMUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU16RTZDaUFnSUNCa2FXY2dNUW9nSUNBZ1lpQnRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNeklLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeU56b0tJQ0FnSUdScFp5QXhDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRPREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lqd0tJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFESTRDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTVRnNkNpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTVRrS0NtMWhhVzVmWlhod1h6STFObDl5YjNWMFpVQXhNVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F4TlFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF6TmdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF6TnpvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF4Q2lBZ0lDQmlkWEo1SURJS0lDQWdJR0o1ZEdWaklEWWdMeThnTUhnd01UQXdDaUFnSUNCaWRYSjVJREV3Q2lBZ0lDQmthV2NnTVRNS0lDQWdJR0oxY25rZ05nb0tiV0ZwYmw5M2FHbHNaVjkwYjNCQU16ZzZDaUFnSUNCa2FXY2dOUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lqNEtJQ0FnSUdKNklHMWhhVzVmWVdaMFpYSmZkMmhwYkdWQU5ESUtJQ0FnSUdScFp5QTFDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREVLSUNBZ0lHSW1DaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaUlUMEtJQ0FnSUdKNklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQTBNUW9nSUNBZ1pHbG5JREVLSUNBZ0lHUnBaeUF4TUFvZ0lDQWdZaW9LSUNBZ0lHSjFjbmtnTWdvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFEUXhPZ29nSUNBZ1pHbG5JRFVLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TWdvZ0lDQWdZaThLSUNBZ0lHSjFjbmtnTmdvZ0lDQWdaR2xuSURrS0lDQWdJR1IxY0FvZ0lDQWdZaW9LSUNBZ0lHSjFjbmtnTVRBS0lDQWdJR0lnYldGcGJsOTNhR2xzWlY5MGIzQkFNemdLQ20xaGFXNWZZV1owWlhKZmQyaHBiR1ZBTkRJNkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWW53S0lDQWdJR0o1ZEdWaklEVWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXpOam9LSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXpOd29LYldGcGJsOWxlSEJmYldsdWRYTmZOVjl5YjNWMFpVQXhNRG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F4TlFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUEwTmdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUEwTnpvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF4Q2lBZ0lDQmlkWEo1SURNS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBMUNpQWdJQ0JpZFhKNUlERXhDaUFnSUNCa2FXY2dNVE1LSUNBZ0lHSjFjbmtnTndvS2JXRnBibDkzYUdsc1pWOTBiM0JBTkRrNkNpQWdJQ0JrYVdjZ05nb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWWo0S0lDQWdJR0o2SUcxaGFXNWZZV1owWlhKZmQyaHBiR1ZBTlRNS0lDQWdJR1JwWnlBMkNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1ERUtJQ0FnSUdJbUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpSVQwS0lDQWdJR0o2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBMU1nb2dJQ0FnWkdsbklESUtJQ0FnSUdScFp5QXhNUW9nSUNBZ1lpb0tJQ0FnSUdKMWNua2dNd29LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURVeU9nb2dJQ0FnWkdsbklEWUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNZ29nSUNBZ1lpOEtJQ0FnSUdKMWNua2dOd29nSUNBZ1pHbG5JREV3Q2lBZ0lDQmtkWEFLSUNBZ0lHSXFDaUFnSUNCaWRYSjVJREV4Q2lBZ0lDQmlJRzFoYVc1ZmQyaHBiR1ZmZEc5d1FEUTVDZ3B0WVdsdVgyRm1kR1Z5WDNkb2FXeGxRRFV6T2dvZ0lDQWdaR2xuSURFekNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1ESUtJQ0FnSUdJbENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpSVQwS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeUNpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU5UVUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZzRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCa2FXY2dNd29nSUNBZ1lqd0tJQ0FnSUNFS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTFOam9LSUNBZ0lHRnpjMlZ5ZENBdkx5QnphV2R1WldRZ1pYaHdJRzkyWlhKbWJHOTNDaUFnSUNCa2RYQUtJQ0FnSUdKNklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQTFPUW9nSUNBZ1pHbG5JRElLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHSTlQUW9nSUNBZ1ltNTZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUExT1FvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWkdsbklETUtJQ0FnSUdJdENpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUpRb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRFl3T2dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZbndLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBMU9Ub0tJQ0FnSUdScFp5QXlDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTJNQW9LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURVMU9nb2dJQ0FnWkdsbklESUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZzRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaVBBb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU5UWUtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUEwTmpvS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUEwTndvS2JXRnBibDlsZUhCZk5WOXliM1YwWlVBNU9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERTFDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnWW5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEWTBDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFEWTFPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1ERUtJQ0FnSUdKMWNua2dNd29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNRFVLSUNBZ0lHSjFjbmtnTVRFS0lDQWdJR1JwWnlBeE13b2dJQ0FnWW5WeWVTQTNDZ3B0WVdsdVgzZG9hV3hsWDNSdmNFQTJOam9LSUNBZ0lHUnBaeUEyQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmlQZ29nSUNBZ1lub2diV0ZwYmw5aFpuUmxjbDkzYUdsc1pVQTNNQW9nSUNBZ1pHbG5JRFlLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TVFvZ0lDQWdZaVlLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHSWhQUW9nSUNBZ1lub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRFk1Q2lBZ0lDQmthV2NnTWdvZ0lDQWdaR2xuSURFeENpQWdJQ0JpS2dvZ0lDQWdZblZ5ZVNBekNncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFOams2Q2lBZ0lDQmthV2NnTmdvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURBeUNpQWdJQ0JpTHdvZ0lDQWdZblZ5ZVNBM0NpQWdJQ0JrYVdjZ01UQUtJQ0FnSUdSMWNBb2dJQ0FnWWlvS0lDQWdJR0oxY25rZ01URUtJQ0FnSUdJZ2JXRnBibDkzYUdsc1pWOTBiM0JBTmpZS0NtMWhhVzVmWVdaMFpYSmZkMmhwYkdWQU56QTZDaUFnSUNCa2FXY2dNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1lud0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUEyTkRvS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUEyTlFvS2JXRnBibDlsZUhCZmFXNTBYMjFoZUY5eWIzVjBaVUE0T2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURFMUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURjMENpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURjMU9nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURFS0lDQWdJR0oxY25rZ05Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdKMWNua2dNVElLSUNBZ0lHUnBaeUF4TXdvZ0lDQWdZblZ5ZVNBNENncHRZV2x1WDNkb2FXeGxYM1J2Y0VBM056b0tJQ0FnSUdScFp5QTNDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaVBnb2dJQ0FnWW5vZ2JXRnBibDloWm5SbGNsOTNhR2xzWlVBNE1Rb2dJQ0FnWkdsbklEY0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNUW9nSUNBZ1lpWUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdJaFBRb2dJQ0FnWW5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFEZ3dDaUFnSUNCa2FXY2dNd29nSUNBZ1pHbG5JREV5Q2lBZ0lDQmlLZ29nSUNBZ1luVnllU0EwQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU9EQTZDaUFnSUNCa2FXY2dOd29nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF5Q2lBZ0lDQmlMd29nSUNBZ1luVnllU0E0Q2lBZ0lDQmthV2NnTVRFS0lDQWdJR1IxY0FvZ0lDQWdZaW9LSUNBZ0lHSjFjbmtnTVRJS0lDQWdJR0lnYldGcGJsOTNhR2xzWlY5MGIzQkFOemNLQ20xaGFXNWZZV1owWlhKZmQyaHBiR1ZBT0RFNkNpQWdJQ0JrYVdjZ01UTUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNZ29nSUNBZ1lpVUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdJaFBRb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlESUtJQ0FnSUdKNklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQTRNd29nSUNBZ1lubDBaV05mTXlBdkx5QXdlRGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmlQQW9nSUNBZ0lRb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRGcwT2dvZ0lDQWdZWE56WlhKMElDOHZJSE5wWjI1bFpDQmxlSEFnYjNabGNtWnNiM2NLSUNBZ0lHUjFjQW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRGczQ2lBZ0lDQmthV2NnTXdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZajA5Q2lBZ0lDQmlibm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURnM0NpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCa2FXY2dOQW9nSUNBZ1lpMEtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBT0RnNkNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JpZkFvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEZzNPZ29nSUNBZ1pHbG5JRE1LSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRGc0Q2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU9ETTZDaUFnSUNCa2FXY2dNd29nSUNBZ1lubDBaV05mTXlBdkx5QXdlRGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSThDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTROQW9LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURjME9nb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR0lnYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURjMUNncHRZV2x1WDJWNGNGOTFhVzUwWDIxaGVGOXliM1YwWlVBM09nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERTFDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnWW5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEa3lDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFEa3pPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1ERUtJQ0FnSUdKMWNua2dOQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1aZ29nSUNBZ1luVnllU0F4TWdvZ0lDQWdaR2xuSURFekNpQWdJQ0JpZFhKNUlEZ0tDbTFoYVc1ZmQyaHBiR1ZmZEc5d1FEazBPZ29nSUNBZ1pHbG5JRGNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHSStDaUFnSUNCaWVpQnRZV2x1WDJGbWRHVnlYM2RvYVd4bFFEazRDaUFnSUNCa2FXY2dOd29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF4Q2lBZ0lDQmlKZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lpRTlDaUFnSUNCaWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFPVGNLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmthV2NnTVRJS0lDQWdJR0lxQ2lBZ0lDQmlkWEo1SURRS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQTVOem9LSUNBZ0lHUnBaeUEzQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURJS0lDQWdJR0l2Q2lBZ0lDQmlkWEo1SURnS0lDQWdJR1JwWnlBeE1Rb2dJQ0FnWkhWd0NpQWdJQ0JpS2dvZ0lDQWdZblZ5ZVNBeE1nb2dJQ0FnWWlCdFlXbHVYM2RvYVd4bFgzUnZjRUE1TkFvS2JXRnBibDloWm5SbGNsOTNhR2xzWlVBNU9Eb0tJQ0FnSUdScFp5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCaWZBb2dJQ0FnWW5sMFpXTWdOU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRGt5T2dvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRGt6Q2dwdFlXbHVYMlY0Y0Y5dGFXNTFjMTh5WDNKdmRYUmxRRFk2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTVRVS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQmllaUJ0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTVRBeUNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURFd016b0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBeENpQWdJQ0JpZFhKNUlEVUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNZ29nSUNBZ1luVnllU0F4TXdvZ0lDQWdaR2xuSURFekNpQWdJQ0JpZFhKNUlEa0tDbTFoYVc1ZmQyaHBiR1ZmZEc5d1FERXdOVG9LSUNBZ0lHUnBaeUE0Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmlQZ29nSUNBZ1lub2diV0ZwYmw5aFpuUmxjbDkzYUdsc1pVQXhNRGtLSUNBZ0lHUnBaeUE0Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURFS0lDQWdJR0ltQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmlJVDBLSUNBZ0lHSjZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TURnS0lDQWdJR1JwWnlBMENpQWdJQ0JrYVdjZ01UTUtJQ0FnSUdJcUNpQWdJQ0JpZFhKNUlEVUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TURnNkNpQWdJQ0JrYVdjZ09Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXlDaUFnSUNCaUx3b2dJQ0FnWW5WeWVTQTVDaUFnSUNCa2FXY2dNVElLSUNBZ0lHUjFjQW9nSUNBZ1lpb0tJQ0FnSUdKMWNua2dNVE1LSUNBZ0lHSWdiV0ZwYmw5M2FHbHNaVjkwYjNCQU1UQTFDZ3B0WVdsdVgyRm1kR1Z5WDNkb2FXeGxRREV3T1RvS0lDQWdJR1JwWnlBeE13b2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXlDaUFnSUNCaUpRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWWlFOUNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01nb2dJQ0FnWW5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFERXhNUW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlRGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHUnBaeUExQ2lBZ0lDQmlQQW9nSUNBZ0lRb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREV4TWpvS0lDQWdJR0Z6YzJWeWRDQXZMeUJ6YVdkdVpXUWdaWGh3SUc5MlpYSm1iRzkzQ2lBZ0lDQmtkWEFLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TVRVS0lDQWdJR1JwWnlBMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpUFQwS0lDQWdJR0p1ZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1URTFDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmthV2NnTlFvZ0lDQWdZaTBLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1URTJPZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1lud0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TVRVNkNpQWdJQ0JrYVdjZ05Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1URTJDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTVRFeE9nb2dJQ0FnWkdsbklEUUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZzRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaVBBb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1URXlDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTVRBeU9nb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR0lnYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURFd013b0tiV0ZwYmw5bGVIQmZNbDl5YjNWMFpVQTFPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREUxQ2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREV5TUFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TWpFNkNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUhCaGVXRmliR1VLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TVFvZ0lDQWdZblZ5ZVNBMUNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1ESUtJQ0FnSUdKMWNua2dNVE1LSUNBZ0lHUnBaeUF4TXdvZ0lDQWdZblZ5ZVNBNUNncHRZV2x1WDNkb2FXeGxYM1J2Y0VBeE1qSTZDaUFnSUNCa2FXY2dPQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lqNEtJQ0FnSUdKNklHMWhhVzVmWVdaMFpYSmZkMmhwYkdWQU1USTJDaUFnSUNCa2FXY2dPQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF4Q2lBZ0lDQmlKZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lpRTlDaUFnSUNCaWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVEkxQ2lBZ0lDQmthV2NnTkFvZ0lDQWdaR2xuSURFekNpQWdJQ0JpS2dvZ0lDQWdZblZ5ZVNBMUNncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVEkxT2dvZ0lDQWdaR2xuSURnS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnd01nb2dJQ0FnWWk4S0lDQWdJR0oxY25rZ09Rb2dJQ0FnWkdsbklERXlDaUFnSUNCa2RYQUtJQ0FnSUdJcUNpQWdJQ0JpZFhKNUlERXpDaUFnSUNCaUlHMWhhVzVmZDJocGJHVmZkRzl3UURFeU1nb0tiV0ZwYmw5aFpuUmxjbDkzYUdsc1pVQXhNalk2Q2lBZ0lDQmthV2NnTkFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZbndLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE1qQTZDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1USXhDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZkR1Z6ZEhNdmMyOXNhV1JwZEhrdGMyVnRZVzUwYVdNdGRHVnpkSE12ZEdWemRITXZkbWxoV1hWc0wyVjRjRjlzYVhSbGNtRnNjMTl6ZFdOalpYTnpMbk52YkM1RExtTnNaV0Z5WDNOMFlYUmxYM0J5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFESUFFQUpnY0FBUUVCQWlDQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQ0VCQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUVGUjk4ZFFJQkFDUkhEQ2lCZ0NDdlNUVUZOUUEwQUlBZ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBSUJjUURVQU1SaEFBQUlqUXpFWkZFUXhHRVNDQ0FSb3ZDaDBCUFl0VVBnRStqL1dZUVJIemt1QkJBWkNtZEVFMlNLZFpBU1RYUHVOQkR3RHRBbzJHZ0NPQ0FOb0F0MENZQUhWQVhjQTZnQ05BQUVBTmhvQlNVVVBGU0lTUkRFV1FRQjVNUllqQ1RnSUZFUXBSUUluQmtVS1N3MUZCa3NGS0tWQkFCOUxCU21zS0tsQkFBZExBVXNLbzBVQ1N3VXFva1VHU3dsSm8wVUtRdi9hU3cwcXFpaXBTVVVDUVFBdEswc0NwQlJFU1VFQUhrc0JLS2hBQUJjbkJFc0NvU2NFcWtrVklnNUVJcStySndWTVVMQWpRMHNCUXYvc1N3RXJwRUwvMFNSQy80azJHZ0ZKUlE4VkloSkVNUlpCQUVveEZpTUpPQWdVUkNsRkFpY0dSUXBMRFVVR1N3VW9wVUVBSDBzRkthd29xVUVBQjBzQlN3cWpSUUpMQlNxaVJRWkxDVW1qUlFwQy85cExBVWtWSWc1RUlxK3JKd1ZNVUxBalF5UkMvN2cyR2dGSlJROFZJaEpFTVJaQkFIb3hGaU1KT0FnVVJDbEZBNEFCQlVVTFN3MUZCMHNHS0tWQkFCOUxCaW1zS0tsQkFBZExBa3NMbzBVRFN3WXFva1VIU3dwSm8wVUxRdi9hU3cwcXFpaXBTVVVDUVFBdEswc0RwQlJFU1VFQUhrc0NLS2hBQUJjbkJFc0RvU2NFcWtrVklnNUVJcStySndWTVVMQWpRMHNDUXYvc1N3SXJwRUwvMFNSQy80ZzJHZ0ZKUlE4VkloSkVNUlpCQUVzeEZpTUpPQWdVUkNsRkE0QUJCVVVMU3cxRkIwc0dLS1ZCQUI5TEJpbXNLS2xCQUFkTEFrc0xvMFVEU3dZcW9rVUhTd3BKbzBVTFF2L2FTd0pKRlNJT1JDS3ZxeWNGVEZDd0kwTWtRdiszTmhvQlNVVVBGU0lTUkRFV1FRQjRNUllqQ1RnSUZFUXBSUVFyUlF4TERVVUlTd2NvcFVFQUgwc0hLYXdvcVVFQUIwc0RTd3lqUlFSTEJ5cWlSUWhMQzBtalJReEMvOXBMRFNxcUtLbEpSUUpCQUMwclN3U2tGRVJKUVFBZVN3TW9xRUFBRnljRVN3U2hKd1NxU1JVaURrUWlyNnNuQlV4UXNDTkRTd05DLyt4TEF5dWtRdi9SSkVML2lqWWFBVWxGRHhVaUVrUXhGa0VBYWpFV0l3azRDQlJFS1VVRWdDRC8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLzBVTVN3MUZDRXNIS0tWQkFCOUxCeW1zS0tsQkFBZExBMHNNbzBVRVN3Y3Fva1VJU3d0Sm8wVU1Rdi9hU3dOSkZTSU9SQ0t2cXljRlRGQ3dJME1rUXYrWU5ob0JTVVVQRlNJU1JERVdRUUI0TVJZakNUZ0lGRVFwUlFVcVJRMUxEVVVKU3dnb3BVRUFIMHNJS2F3b3FVRUFCMHNFU3cyalJRVkxDQ3FpUlFsTERFbWpSUTFDLzlwTERTcXFLS2xKUlFKQkFDMHJTd1drRkVSSlFRQWVTd1FvcUVBQUZ5Y0VTd1doSndTcVNSVWlEa1FpcjZzbkJVeFFzQ05EU3dSQy8reExCQ3VrUXYvUkpFTC9pallhQVVsRkR4VWlFa1F4RmtFQVNURVdJd2s0Q0JSRUtVVUZLa1VOU3cxRkNVc0lLS1ZCQUI5TENDbXNLS2xCQUFkTEJFc05vMFVGU3dncW9rVUpTd3hKbzBVTlF2L2FTd1JKRlNJT1JDS3ZxeWNGVEZDd0kwTWtRdis1IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
