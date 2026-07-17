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

namespace Arc56.Generated.algorandfoundation.algorand_python_testing.StateAssetParamsContract_0639bfb6
{


    public class StateAssetParamsContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public StateAssetParamsContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<ulong> VerifyAssetParamsGetTotal(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 240, 93, 167, 164 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifyAssetParamsGetTotal_Transactions(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 240, 93, 167, 164 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<ulong> VerifyAssetParamsGetDecimals(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 233, 195, 21 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifyAssetParamsGetDecimals_Transactions(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 233, 195, 21 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<bool> VerifyAssetParamsGetDefaultFrozen(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 216, 82, 130, 115 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifyAssetParamsGetDefaultFrozen_Transactions(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 216, 82, 130, 115 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<byte[]> VerifyAssetParamsGetUnitName(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 70, 138, 217 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> VerifyAssetParamsGetUnitName_Transactions(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 70, 138, 217 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<byte[]> VerifyAssetParamsGetName(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 34, 157, 18, 247 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> VerifyAssetParamsGetName_Transactions(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 34, 157, 18, 247 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<byte[]> VerifyAssetParamsGetUrl(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 223, 83, 79, 123 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> VerifyAssetParamsGetUrl_Transactions(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 223, 83, 79, 123 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<byte[]> VerifyAssetParamsGetMetadataHash(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 224, 80, 181, 169 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> VerifyAssetParamsGetMetadataHash_Transactions(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 224, 80, 181, 169 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<Algorand.Address> VerifyAssetParamsGetManager(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 139, 42, 45, 88 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> VerifyAssetParamsGetManager_Transactions(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 139, 42, 45, 88 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<Algorand.Address> VerifyAssetParamsGetReserve(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 238, 21, 196, 247 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> VerifyAssetParamsGetReserve_Transactions(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 238, 21, 196, 247 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<Algorand.Address> VerifyAssetParamsGetFreeze(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 21, 117, 68, 255 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> VerifyAssetParamsGetFreeze_Transactions(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 21, 117, 68, 255 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<Algorand.Address> VerifyAssetParamsGetClawback(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 16, 73, 44, 7 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> VerifyAssetParamsGetClawback_Transactions(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 16, 73, 44, 7 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<Algorand.Address> VerifyAssetParamsGetCreator(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 82, 41, 250, 55 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> VerifyAssetParamsGetCreator_Transactions(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 82, 41, 250, 55 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3RhdGVBc3NldFBhcmFtc0NvbnRyYWN0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6InZlcmlmeV9hc3NldF9wYXJhbXNfZ2V0X3RvdGFsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2ZXJpZnlfYXNzZXRfcGFyYW1zX2dldF9kZWNpbWFscyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmVyaWZ5X2Fzc2V0X3BhcmFtc19nZXRfZGVmYXVsdF9mcm96ZW4iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2ZXJpZnlfYXNzZXRfcGFyYW1zX2dldF91bml0X25hbWUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZlcmlmeV9hc3NldF9wYXJhbXNfZ2V0X25hbWUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZlcmlmeV9hc3NldF9wYXJhbXNfZ2V0X3VybCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmVyaWZ5X2Fzc2V0X3BhcmFtc19nZXRfbWV0YWRhdGFfaGFzaCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmVyaWZ5X2Fzc2V0X3BhcmFtc19nZXRfbWFuYWdlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZlcmlmeV9hc3NldF9wYXJhbXNfZ2V0X3Jlc2VydmUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2ZXJpZnlfYXNzZXRfcGFyYW1zX2dldF9mcmVlemUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2ZXJpZnlfYXNzZXRfcGFyYW1zX2dldF9jbGF3YmFjayIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZlcmlmeV9hc3NldF9wYXJhbXNfZ2V0X2NyZWF0b3IiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE0MiwxNjksMTk2LDIzMCwyNjQsMjk4LDMzMiwzNjYsMzkyLDQxOCw0NDQsNDcwXSwiZXJyb3JNZXNzYWdlIjoiZXhwZWN0ZWQgZXhpc3RzIGJ5IGluZGV4IHRvIG1hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQwLDE2NywxOTQsMjI4LDI2MiwyOTYsMzMwLDM2NCwzOTAsNDE2LDQ0Miw0NjhdLCJlcnJvck1lc3NhZ2UiOiJleHBlY3RlZCB2YWx1ZSBieSBpbmRleCB0byBtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhDaUFnSUNCaWVYUmxZMkpzYjJOcklEQjRNVFV4Wmpkak56VUtJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5VGRHRjBaVTl3Y3k5amIyNTBjbUZqZEM1d2VUb3hOemNLSUNBZ0lDOHZJR05zWVhOeklGTjBZWFJsUVhOelpYUlFZWEpoYlhORGIyNTBjbUZqZENoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2Y0hsZlpHVm1ZWFZzZEY5amNtVmhkR1ZBTVRrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZUdZd05XUmhOMkUwSURCNFl6QmxPV016TVRVZ01IaGtPRFV5T0RJM015QXdlR1kwTkRZNFlXUTVJREI0TWpJNVpERXlaamNnTUhoa1pqVXpOR1kzWWlBd2VHVXdOVEJpTldFNUlEQjRPR0l5WVRKa05UZ2dNSGhsWlRFMVl6Um1OeUF3ZURFMU56VTBOR1ptSURCNE1UQTBPVEpqTURjZ01IZzFNakk1Wm1Fek55QXZMeUJ0WlhSb2IyUWdJblpsY21sbWVWOWhjM05sZEY5d1lYSmhiWE5mWjJWMFgzUnZkR0ZzS0hWcGJuUTJOQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJblpsY21sbWVWOWhjM05sZEY5d1lYSmhiWE5mWjJWMFgyUmxZMmx0WVd4ektIVnBiblEyTkNsMWFXNTBOalFpTENCdFpYUm9iMlFnSW5abGNtbG1lVjloYzNObGRGOXdZWEpoYlhOZloyVjBYMlJsWm1GMWJIUmZabkp2ZW1WdUtIVnBiblEyTkNsaWIyOXNJaXdnYldWMGFHOWtJQ0oyWlhKcFpubGZZWE56WlhSZmNHRnlZVzF6WDJkbGRGOTFibWwwWDI1aGJXVW9kV2x1ZERZMEtXSjVkR1ZiWFNJc0lHMWxkR2h2WkNBaWRtVnlhV1o1WDJGemMyVjBYM0JoY21GdGMxOW5aWFJmYm1GdFpTaDFhVzUwTmpRcFlubDBaVnRkSWl3Z2JXVjBhRzlrSUNKMlpYSnBabmxmWVhOelpYUmZjR0Z5WVcxelgyZGxkRjkxY213b2RXbHVkRFkwS1dKNWRHVmJYU0lzSUcxbGRHaHZaQ0FpZG1WeWFXWjVYMkZ6YzJWMFgzQmhjbUZ0YzE5blpYUmZiV1YwWVdSaGRHRmZhR0Z6YUNoMWFXNTBOalFwWW5sMFpWdGRJaXdnYldWMGFHOWtJQ0oyWlhKcFpubGZZWE56WlhSZmNHRnlZVzF6WDJkbGRGOXRZVzVoWjJWeUtIVnBiblEyTkNsaFpHUnlaWE56SWl3Z2JXVjBhRzlrSUNKMlpYSnBabmxmWVhOelpYUmZjR0Z5WVcxelgyZGxkRjl5WlhObGNuWmxLSFZwYm5RMk5DbGhaR1J5WlhOeklpd2diV1YwYUc5a0lDSjJaWEpwWm5sZllYTnpaWFJmY0dGeVlXMXpYMmRsZEY5bWNtVmxlbVVvZFdsdWREWTBLV0ZrWkhKbGMzTWlMQ0J0WlhSb2IyUWdJblpsY21sbWVWOWhjM05sZEY5d1lYSmhiWE5mWjJWMFgyTnNZWGRpWVdOcktIVnBiblEyTkNsaFpHUnlaWE56SWl3Z2JXVjBhRzlrSUNKMlpYSnBabmxmWVhOelpYUmZjR0Z5WVcxelgyZGxkRjlqY21WaGRHOXlLSFZwYm5RMk5DbGhaR1J5WlhOeklnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dkbVZ5YVdaNVgyRnpjMlYwWDNCaGNtRnRjMTluWlhSZmRHOTBZV3dnZG1WeWFXWjVYMkZ6YzJWMFgzQmhjbUZ0YzE5blpYUmZaR1ZqYVcxaGJITWdkbVZ5YVdaNVgyRnpjMlYwWDNCaGNtRnRjMTluWlhSZlpHVm1ZWFZzZEY5bWNtOTZaVzRnZG1WeWFXWjVYMkZ6YzJWMFgzQmhjbUZ0YzE5blpYUmZkVzVwZEY5dVlXMWxJSFpsY21sbWVWOWhjM05sZEY5d1lYSmhiWE5mWjJWMFgyNWhiV1VnZG1WeWFXWjVYMkZ6YzJWMFgzQmhjbUZ0YzE5blpYUmZkWEpzSUhabGNtbG1lVjloYzNObGRGOXdZWEpoYlhOZloyVjBYMjFsZEdGa1lYUmhYMmhoYzJnZ2RtVnlhV1o1WDJGemMyVjBYM0JoY21GdGMxOW5aWFJmYldGdVlXZGxjaUIyWlhKcFpubGZZWE56WlhSZmNHRnlZVzF6WDJkbGRGOXlaWE5sY25abElIWmxjbWxtZVY5aGMzTmxkRjl3WVhKaGJYTmZaMlYwWDJaeVpXVjZaU0IyWlhKcFpubGZZWE56WlhSZmNHRnlZVzF6WDJkbGRGOWpiR0YzWW1GamF5QjJaWEpwWm5sZllYTnpaWFJmY0dGeVlXMXpYMmRsZEY5amNtVmhkRzl5Q2lBZ0lDQmxjbklLQ20xaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1UazZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TG1GeWRHbG1ZV04wY3k1VGRHRjBaVTl3Y3k1amIyNTBjbUZqZEM1VGRHRjBaVUZ6YzJWMFVHRnlZVzF6UTI5dWRISmhZM1F1ZG1WeWFXWjVYMkZ6YzJWMFgzQmhjbUZ0YzE5blpYUmZkRzkwWVd4YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDJaWEpwWm5sZllYTnpaWFJmY0dGeVlXMXpYMmRsZEY5MGIzUmhiRG9LSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG94TnpnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TVRnd0NpQWdJQ0F2THlCMllXeDFaU3dnWlhocGMzUnpJRDBnYjNBdVFYTnpaWFJRWVhKaGJYTkhaWFF1WVhOelpYUmZkRzkwWVd3b1lTa0tJQ0FnSUdGemMyVjBYM0JoY21GdGMxOW5aWFFnUVhOelpYUlViM1JoYkFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMU4wWVhSbFQzQnpMMk52Ym5SeVlXTjBMbkI1T2pJMENpQWdJQ0F2THlCeVpYUjFjbTRnYjNBdVluUnZhU2hVZUc0dVlYQndiR2xqWVhScGIyNWZZWEpuY3lneEtTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5VGRHRjBaVTl3Y3k5amIyNTBjbUZqZEM1d2VUb3hPREVLSUNBZ0lDOHZJSFpoYkhWbFgybHVaR1Y0TENCbGVHbHpkSE5mYVc1a1pYZ2dQU0J2Y0M1QmMzTmxkRkJoY21GdGMwZGxkQzVoYzNObGRGOTBiM1JoYkNoZloyVjBYekZ6ZEY5eVpXWmZhVzVrWlhnb0tTa0tJQ0FnSUdGemMyVjBYM0JoY21GdGMxOW5aWFFnUVhOelpYUlViM1JoYkFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMU4wWVhSbFQzQnpMMk52Ym5SeVlXTjBMbkI1T2pFNE1nb2dJQ0FnTHk4Z1lYTnpaWEowSUhaaGJIVmxJRDA5SUhaaGJIVmxYMmx1WkdWNExDQWlaWGh3WldOMFpXUWdkbUZzZFdVZ1lua2dhVzVrWlhnZ2RHOGdiV0YwWTJnaUNpQWdJQ0JrYVdjZ013b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHVjRjR1ZqZEdWa0lIWmhiSFZsSUdKNUlHbHVaR1Y0SUhSdklHMWhkR05vQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TVRnekNpQWdJQ0F2THlCaGMzTmxjblFnWlhocGMzUnpJRDA5SUdWNGFYTjBjMTlwYm1SbGVDd2dJbVY0Y0dWamRHVmtJR1Y0YVhOMGN5QmllU0JwYm1SbGVDQjBieUJ0WVhSamFDSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnWlhod1pXTjBaV1FnWlhocGMzUnpJR0o1SUdsdVpHVjRJSFJ2SUcxaGRHTm9DaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZNVGM0Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TG1GeWRHbG1ZV04wY3k1VGRHRjBaVTl3Y3k1amIyNTBjbUZqZEM1VGRHRjBaVUZ6YzJWMFVHRnlZVzF6UTI5dWRISmhZM1F1ZG1WeWFXWjVYMkZ6YzJWMFgzQmhjbUZ0YzE5blpYUmZaR1ZqYVcxaGJITmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AyWlhKcFpubGZZWE56WlhSZmNHRnlZVzF6WDJkbGRGOWtaV05wYldGc2N6b0tJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5VGRHRjBaVTl3Y3k5amIyNTBjbUZqZEM1d2VUb3hPRFlLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZNVGc0Q2lBZ0lDQXZMeUIyWVd4MVpTd2daWGhwYzNSeklEMGdiM0F1UVhOelpYUlFZWEpoYlhOSFpYUXVZWE56WlhSZlpHVmphVzFoYkhNb1lTa0tJQ0FnSUdGemMyVjBYM0JoY21GdGMxOW5aWFFnUVhOelpYUkVaV05wYldGc2N3b2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qSTBDaUFnSUNBdkx5QnlaWFIxY200Z2IzQXVZblJ2YVNoVWVHNHVZWEJ3YkdsallYUnBiMjVmWVhKbmN5Z3hLU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG94T0RrS0lDQWdJQzh2SUhaaGJIVmxYMmx1WkdWNExDQmxlR2x6ZEhOZmFXNWtaWGdnUFNCdmNDNUJjM05sZEZCaGNtRnRjMGRsZEM1aGMzTmxkRjlrWldOcGJXRnNjeWhmWjJWMFh6RnpkRjl5WldaZmFXNWtaWGdvS1NrS0lDQWdJR0Z6YzJWMFgzQmhjbUZ0YzE5blpYUWdRWE56WlhSRVpXTnBiV0ZzY3dvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMU4wWVhSbFQzQnpMMk52Ym5SeVlXTjBMbkI1T2pFNU1Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhaaGJIVmxJRDA5SUhaaGJIVmxYMmx1WkdWNExDQWlaWGh3WldOMFpXUWdkbUZzZFdVZ1lua2dhVzVrWlhnZ2RHOGdiV0YwWTJnaUNpQWdJQ0JrYVdjZ013b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHVjRjR1ZqZEdWa0lIWmhiSFZsSUdKNUlHbHVaR1Y0SUhSdklHMWhkR05vQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TVRreENpQWdJQ0F2THlCaGMzTmxjblFnWlhocGMzUnpJRDA5SUdWNGFYTjBjMTlwYm1SbGVDd2dJbVY0Y0dWamRHVmtJR1Y0YVhOMGN5QmllU0JwYm1SbGVDQjBieUJ0WVhSamFDSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnWlhod1pXTjBaV1FnWlhocGMzUnpJR0o1SUdsdVpHVjRJSFJ2SUcxaGRHTm9DaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZNVGcyQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TG1GeWRHbG1ZV04wY3k1VGRHRjBaVTl3Y3k1amIyNTBjbUZqZEM1VGRHRjBaVUZ6YzJWMFVHRnlZVzF6UTI5dWRISmhZM1F1ZG1WeWFXWjVYMkZ6YzJWMFgzQmhjbUZ0YzE5blpYUmZaR1ZtWVhWc2RGOW1jbTk2Wlc1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDJaWEpwWm5sZllYTnpaWFJmY0dGeVlXMXpYMmRsZEY5a1pXWmhkV3gwWDJaeWIzcGxiam9LSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG94T1RRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TVRrMkNpQWdJQ0F2THlCMllXeDFaU3dnWlhocGMzUnpJRDBnYjNBdVFYTnpaWFJRWVhKaGJYTkhaWFF1WVhOelpYUmZaR1ZtWVhWc2RGOW1jbTk2Wlc0b1lTa0tJQ0FnSUdGemMyVjBYM0JoY21GdGMxOW5aWFFnUVhOelpYUkVaV1poZFd4MFJuSnZlbVZ1Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TWpRS0lDQWdJQzh2SUhKbGRIVnliaUJ2Y0M1aWRHOXBLRlI0Ymk1aGNIQnNhV05oZEdsdmJsOWhjbWR6S0RFcEtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qRTVOd29nSUNBZ0x5OGdkbUZzZFdWZmFXNWtaWGdzSUdWNGFYTjBjMTlwYm1SbGVDQTlJRzl3TGtGemMyVjBVR0Z5WVcxelIyVjBMbUZ6YzJWMFgyUmxabUYxYkhSZlpuSnZlbVZ1S0Y5blpYUmZNWE4wWDNKbFpsOXBibVJsZUNncEtRb2dJQ0FnWVhOelpYUmZjR0Z5WVcxelgyZGxkQ0JCYzNObGRFUmxabUYxYkhSR2NtOTZaVzRLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG94T1RnS0lDQWdJQzh2SUdGemMyVnlkQ0IyWVd4MVpTQTlQU0IyWVd4MVpWOXBibVJsZUN3Z0ltVjRjR1ZqZEdWa0lIWmhiSFZsSUdKNUlHbHVaR1Y0SUhSdklHMWhkR05vSWdvZ0lDQWdaR2xuSURNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCbGVIQmxZM1JsWkNCMllXeDFaU0JpZVNCcGJtUmxlQ0IwYnlCdFlYUmphQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPakU1T1FvZ0lDQWdMeThnWVhOelpYSjBJR1Y0YVhOMGN5QTlQU0JsZUdsemRITmZhVzVrWlhnc0lDSmxlSEJsWTNSbFpDQmxlR2x6ZEhNZ1lua2dhVzVrWlhnZ2RHOGdiV0YwWTJnaUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR1Y0Y0dWamRHVmtJR1Y0YVhOMGN5QmllU0JwYm1SbGVDQjBieUJ0WVhSamFBb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qRTVOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdDaUFnSUNCd2RYTm9hVzUwSURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdVlYSjBhV1poWTNSekxsTjBZWFJsVDNCekxtTnZiblJ5WVdOMExsTjBZWFJsUVhOelpYUlFZWEpoYlhORGIyNTBjbUZqZEM1MlpYSnBabmxmWVhOelpYUmZjR0Z5WVcxelgyZGxkRjkxYm1sMFgyNWhiV1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMlpYSnBabmxmWVhOelpYUmZjR0Z5WVcxelgyZGxkRjkxYm1sMFgyNWhiV1U2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TWpBeUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMU4wWVhSbFQzQnpMMk52Ym5SeVlXTjBMbkI1T2pJd05Bb2dJQ0FnTHk4Z2RtRnNkV1VzSUdWNGFYTjBjeUE5SUc5d0xrRnpjMlYwVUdGeVlXMXpSMlYwTG1GemMyVjBYM1Z1YVhSZmJtRnRaU2hoS1FvZ0lDQWdZWE56WlhSZmNHRnlZVzF6WDJkbGRDQkJjM05sZEZWdWFYUk9ZVzFsQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TWpRS0lDQWdJQzh2SUhKbGRIVnliaUJ2Y0M1aWRHOXBLRlI0Ymk1aGNIQnNhV05oZEdsdmJsOWhjbWR6S0RFcEtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qSXdOUW9nSUNBZ0x5OGdkbUZzZFdWZmFXNWtaWGdzSUdWNGFYTjBjMTlwYm1SbGVDQTlJRzl3TGtGemMyVjBVR0Z5WVcxelIyVjBMbUZ6YzJWMFgzVnVhWFJmYm1GdFpTaGZaMlYwWHpGemRGOXlaV1pmYVc1a1pYZ29LU2tLSUNBZ0lHRnpjMlYwWDNCaGNtRnRjMTluWlhRZ1FYTnpaWFJWYm1sMFRtRnRaUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPakl3TmdvZ0lDQWdMeThnWVhOelpYSjBJSFpoYkhWbElEMDlJSFpoYkhWbFgybHVaR1Y0TENBaVpYaHdaV04wWldRZ2RtRnNkV1VnWW5rZ2FXNWtaWGdnZEc4Z2JXRjBZMmdpQ2lBZ0lDQmthV2NnTXdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdWNGNHVmpkR1ZrSUhaaGJIVmxJR0o1SUdsdVpHVjRJSFJ2SUcxaGRHTm9DaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZNakEzQ2lBZ0lDQXZMeUJoYzNObGNuUWdaWGhwYzNSeklEMDlJR1Y0YVhOMGMxOXBibVJsZUN3Z0ltVjRjR1ZqZEdWa0lHVjRhWE4wY3lCaWVTQnBibVJsZUNCMGJ5QnRZWFJqYUNJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdaWGh3WldOMFpXUWdaWGhwYzNSeklHSjVJR2x1WkdWNElIUnZJRzFoZEdOb0NpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12VTNSaGRHVlBjSE12WTI5dWRISmhZM1F1Y0hrNk1qQXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5NWhjblJwWm1GamRITXVVM1JoZEdWUGNITXVZMjl1ZEhKaFkzUXVVM1JoZEdWQmMzTmxkRkJoY21GdGMwTnZiblJ5WVdOMExuWmxjbWxtZVY5aGMzTmxkRjl3WVhKaGJYTmZaMlYwWDI1aGJXVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AyWlhKcFpubGZZWE56WlhSZmNHRnlZVzF6WDJkbGRGOXVZVzFsT2dvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMU4wWVhSbFQzQnpMMk52Ym5SeVlXTjBMbkI1T2pJeE1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRveU1USUtJQ0FnSUM4dklIWmhiSFZsTENCbGVHbHpkSE1nUFNCdmNDNUJjM05sZEZCaGNtRnRjMGRsZEM1aGMzTmxkRjl1WVcxbEtHRXBDaUFnSUNCaGMzTmxkRjl3WVhKaGJYTmZaMlYwSUVGemMyVjBUbUZ0WlFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMU4wWVhSbFQzQnpMMk52Ym5SeVlXTjBMbkI1T2pJMENpQWdJQ0F2THlCeVpYUjFjbTRnYjNBdVluUnZhU2hVZUc0dVlYQndiR2xqWVhScGIyNWZZWEpuY3lneEtTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5VGRHRjBaVTl3Y3k5amIyNTBjbUZqZEM1d2VUb3lNVE1LSUNBZ0lDOHZJSFpoYkhWbFgybHVaR1Y0TENCbGVHbHpkSE5mYVc1a1pYZ2dQU0J2Y0M1QmMzTmxkRkJoY21GdGMwZGxkQzVoYzNObGRGOXVZVzFsS0Y5blpYUmZNWE4wWDNKbFpsOXBibVJsZUNncEtRb2dJQ0FnWVhOelpYUmZjR0Z5WVcxelgyZGxkQ0JCYzNObGRFNWhiV1VLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG95TVRRS0lDQWdJQzh2SUdGemMyVnlkQ0IyWVd4MVpTQTlQU0IyWVd4MVpWOXBibVJsZUN3Z0ltVjRjR1ZqZEdWa0lIWmhiSFZsSUdKNUlHbHVaR1Y0SUhSdklHMWhkR05vSWdvZ0lDQWdaR2xuSURNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCbGVIQmxZM1JsWkNCMllXeDFaU0JpZVNCcGJtUmxlQ0IwYnlCdFlYUmphQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPakl4TlFvZ0lDQWdMeThnWVhOelpYSjBJR1Y0YVhOMGN5QTlQU0JsZUdsemRITmZhVzVrWlhnc0lDSmxlSEJsWTNSbFpDQmxlR2x6ZEhNZ1lua2dhVzVrWlhnZ2RHOGdiV0YwWTJnaUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR1Y0Y0dWamRHVmtJR1Y0YVhOMGN5QmllU0JwYm1SbGVDQjBieUJ0WVhSamFBb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qSXhNQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXVZWEowYVdaaFkzUnpMbE4wWVhSbFQzQnpMbU52Ym5SeVlXTjBMbE4wWVhSbFFYTnpaWFJRWVhKaGJYTkRiMjUwY21GamRDNTJaWEpwWm5sZllYTnpaWFJmY0dGeVlXMXpYMmRsZEY5MWNteGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AyWlhKcFpubGZZWE56WlhSZmNHRnlZVzF6WDJkbGRGOTFjbXc2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TWpFNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMU4wWVhSbFQzQnpMMk52Ym5SeVlXTjBMbkI1T2pJeU1Bb2dJQ0FnTHk4Z2RtRnNkV1VzSUdWNGFYTjBjeUE5SUc5d0xrRnpjMlYwVUdGeVlXMXpSMlYwTG1GemMyVjBYM1Z5YkNoaEtRb2dJQ0FnWVhOelpYUmZjR0Z5WVcxelgyZGxkQ0JCYzNObGRGVlNUQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPakkwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdiM0F1WW5SdmFTaFVlRzR1WVhCd2JHbGpZWFJwYjI1ZllYSm5jeWd4S1NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRveU1qRUtJQ0FnSUM4dklIWmhiSFZsWDJsdVpHVjRMQ0JsZUdsemRITmZhVzVrWlhnZ1BTQnZjQzVCYzNObGRGQmhjbUZ0YzBkbGRDNWhjM05sZEY5MWNtd29YMmRsZEY4eGMzUmZjbVZtWDJsdVpHVjRLQ2twQ2lBZ0lDQmhjM05sZEY5d1lYSmhiWE5mWjJWMElFRnpjMlYwVlZKTUNpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12VTNSaGRHVlBjSE12WTI5dWRISmhZM1F1Y0hrNk1qSXlDaUFnSUNBdkx5QmhjM05sY25RZ2RtRnNkV1VnUFQwZ2RtRnNkV1ZmYVc1a1pYZ3NJQ0psZUhCbFkzUmxaQ0IyWVd4MVpTQmllU0JwYm1SbGVDQjBieUJ0WVhSamFDSUtJQ0FnSUdScFp5QXpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdaWGh3WldOMFpXUWdkbUZzZFdVZ1lua2dhVzVrWlhnZ2RHOGdiV0YwWTJnS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRveU1qTUtJQ0FnSUM4dklHRnpjMlZ5ZENCbGVHbHpkSE1nUFQwZ1pYaHBjM1J6WDJsdVpHVjRMQ0FpWlhod1pXTjBaV1FnWlhocGMzUnpJR0o1SUdsdVpHVjRJSFJ2SUcxaGRHTm9JZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCbGVIQmxZM1JsWkNCbGVHbHpkSE1nWW5rZ2FXNWtaWGdnZEc4Z2JXRjBZMmdLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG95TVRnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TG1GeWRHbG1ZV04wY3k1VGRHRjBaVTl3Y3k1amIyNTBjbUZqZEM1VGRHRjBaVUZ6YzJWMFVHRnlZVzF6UTI5dWRISmhZM1F1ZG1WeWFXWjVYMkZ6YzJWMFgzQmhjbUZ0YzE5blpYUmZiV1YwWVdSaGRHRmZhR0Z6YUZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuWmxjbWxtZVY5aGMzTmxkRjl3WVhKaGJYTmZaMlYwWDIxbGRHRmtZWFJoWDJoaGMyZzZDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZNakkyQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPakl5T0FvZ0lDQWdMeThnZG1Gc2RXVXNJR1Y0YVhOMGN5QTlJRzl3TGtGemMyVjBVR0Z5WVcxelIyVjBMbUZ6YzJWMFgyMWxkR0ZrWVhSaFgyaGhjMmdvWVNrS0lDQWdJR0Z6YzJWMFgzQmhjbUZ0YzE5blpYUWdRWE56WlhSTlpYUmhaR0YwWVVoaGMyZ0tJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5VGRHRjBaVTl3Y3k5amIyNTBjbUZqZEM1d2VUb3lOQW9nSUNBZ0x5OGdjbVYwZFhKdUlHOXdMbUowYjJrb1ZIaHVMbUZ3Y0d4cFkyRjBhVzl1WDJGeVozTW9NU2twQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TWpJNUNpQWdJQ0F2THlCMllXeDFaVjlwYm1SbGVDd2daWGhwYzNSelgybHVaR1Y0SUQwZ2IzQXVRWE56WlhSUVlYSmhiWE5IWlhRdVlYTnpaWFJmYldWMFlXUmhkR0ZmYUdGemFDaGZaMlYwWHpGemRGOXlaV1pmYVc1a1pYZ29LU2tLSUNBZ0lHRnpjMlYwWDNCaGNtRnRjMTluWlhRZ1FYTnpaWFJOWlhSaFpHRjBZVWhoYzJnS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRveU16QUtJQ0FnSUM4dklHRnpjMlZ5ZENCMllXeDFaU0E5UFNCMllXeDFaVjlwYm1SbGVDd2dJbVY0Y0dWamRHVmtJSFpoYkhWbElHSjVJR2x1WkdWNElIUnZJRzFoZEdOb0lnb2dJQ0FnWkdsbklETUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmxlSEJsWTNSbFpDQjJZV3gxWlNCaWVTQnBibVJsZUNCMGJ5QnRZWFJqYUFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMU4wWVhSbFQzQnpMMk52Ym5SeVlXTjBMbkI1T2pJek1Rb2dJQ0FnTHk4Z1lYTnpaWEowSUdWNGFYTjBjeUE5UFNCbGVHbHpkSE5mYVc1a1pYZ3NJQ0psZUhCbFkzUmxaQ0JsZUdsemRITWdZbmtnYVc1a1pYZ2dkRzhnYldGMFkyZ2lDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdWNGNHVmpkR1ZrSUdWNGFYTjBjeUJpZVNCcGJtUmxlQ0IwYnlCdFlYUmphQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPakl5TmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE11WVhKMGFXWmhZM1J6TGxOMFlYUmxUM0J6TG1OdmJuUnlZV04wTGxOMFlYUmxRWE56WlhSUVlYSmhiWE5EYjI1MGNtRmpkQzUyWlhKcFpubGZZWE56WlhSZmNHRnlZVzF6WDJkbGRGOXRZVzVoWjJWeVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkbVZ5YVdaNVgyRnpjMlYwWDNCaGNtRnRjMTluWlhSZmJXRnVZV2RsY2pvS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRveU16UUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12VTNSaGRHVlBjSE12WTI5dWRISmhZM1F1Y0hrNk1qTTJDaUFnSUNBdkx5QjJZV3gxWlN3Z1pYaHBjM1J6SUQwZ2IzQXVRWE56WlhSUVlYSmhiWE5IWlhRdVlYTnpaWFJmYldGdVlXZGxjaWhoS1FvZ0lDQWdZWE56WlhSZmNHRnlZVzF6WDJkbGRDQkJjM05sZEUxaGJtRm5aWElLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG95TkFvZ0lDQWdMeThnY21WMGRYSnVJRzl3TG1KMGIya29WSGh1TG1Gd2NHeHBZMkYwYVc5dVgyRnlaM01vTVNrcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12VTNSaGRHVlBjSE12WTI5dWRISmhZM1F1Y0hrNk1qTTNDaUFnSUNBdkx5QjJZV3gxWlY5cGJtUmxlQ3dnWlhocGMzUnpYMmx1WkdWNElEMGdiM0F1UVhOelpYUlFZWEpoYlhOSFpYUXVZWE56WlhSZmJXRnVZV2RsY2loZloyVjBYekZ6ZEY5eVpXWmZhVzVrWlhnb0tTa0tJQ0FnSUdGemMyVjBYM0JoY21GdGMxOW5aWFFnUVhOelpYUk5ZVzVoWjJWeUNpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12VTNSaGRHVlBjSE12WTI5dWRISmhZM1F1Y0hrNk1qTTRDaUFnSUNBdkx5QmhjM05sY25RZ2RtRnNkV1VnUFQwZ2RtRnNkV1ZmYVc1a1pYZ3NJQ0psZUhCbFkzUmxaQ0IyWVd4MVpTQmllU0JwYm1SbGVDQjBieUJ0WVhSamFDSUtJQ0FnSUdScFp5QXpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdaWGh3WldOMFpXUWdkbUZzZFdVZ1lua2dhVzVrWlhnZ2RHOGdiV0YwWTJnS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRveU16a0tJQ0FnSUM4dklHRnpjMlZ5ZENCbGVHbHpkSE1nUFQwZ1pYaHBjM1J6WDJsdVpHVjRMQ0FpWlhod1pXTjBaV1FnWlhocGMzUnpJR0o1SUdsdVpHVjRJSFJ2SUcxaGRHTm9JZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCbGVIQmxZM1JsWkNCbGVHbHpkSE1nWW5rZ2FXNWtaWGdnZEc4Z2JXRjBZMmdLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG95TXpRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdVlYSjBhV1poWTNSekxsTjBZWFJsVDNCekxtTnZiblJ5WVdOMExsTjBZWFJsUVhOelpYUlFZWEpoYlhORGIyNTBjbUZqZEM1MlpYSnBabmxmWVhOelpYUmZjR0Z5WVcxelgyZGxkRjl5WlhObGNuWmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZG1WeWFXWjVYMkZ6YzJWMFgzQmhjbUZ0YzE5blpYUmZjbVZ6WlhKMlpUb0tJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5VGRHRjBaVTl3Y3k5amIyNTBjbUZqZEM1d2VUb3lORElLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZNalEwQ2lBZ0lDQXZMeUIyWVd4MVpTd2daWGhwYzNSeklEMGdiM0F1UVhOelpYUlFZWEpoYlhOSFpYUXVZWE56WlhSZmNtVnpaWEoyWlNoaEtRb2dJQ0FnWVhOelpYUmZjR0Z5WVcxelgyZGxkQ0JCYzNObGRGSmxjMlZ5ZG1VS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRveU5Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUc5d0xtSjBiMmtvVkhodUxtRndjR3hwWTJGMGFXOXVYMkZ5WjNNb01Ta3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZNalExQ2lBZ0lDQXZMeUIyWVd4MVpWOXBibVJsZUN3Z1pYaHBjM1J6WDJsdVpHVjRJRDBnYjNBdVFYTnpaWFJRWVhKaGJYTkhaWFF1WVhOelpYUmZjbVZ6WlhKMlpTaGZaMlYwWHpGemRGOXlaV1pmYVc1a1pYZ29LU2tLSUNBZ0lHRnpjMlYwWDNCaGNtRnRjMTluWlhRZ1FYTnpaWFJTWlhObGNuWmxDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZNalEyQ2lBZ0lDQXZMeUJoYzNObGNuUWdkbUZzZFdVZ1BUMGdkbUZzZFdWZmFXNWtaWGdzSUNKbGVIQmxZM1JsWkNCMllXeDFaU0JpZVNCcGJtUmxlQ0IwYnlCdFlYUmphQ0lLSUNBZ0lHUnBaeUF6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnWlhod1pXTjBaV1FnZG1Gc2RXVWdZbmtnYVc1a1pYZ2dkRzhnYldGMFkyZ0tJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5VGRHRjBaVTl3Y3k5amIyNTBjbUZqZEM1d2VUb3lORGNLSUNBZ0lDOHZJR0Z6YzJWeWRDQmxlR2x6ZEhNZ1BUMGdaWGhwYzNSelgybHVaR1Y0TENBaVpYaHdaV04wWldRZ1pYaHBjM1J6SUdKNUlHbHVaR1Y0SUhSdklHMWhkR05vSWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmxlSEJsWTNSbFpDQmxlR2x6ZEhNZ1lua2dhVzVrWlhnZ2RHOGdiV0YwWTJnS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRveU5ESUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXVZWEowYVdaaFkzUnpMbE4wWVhSbFQzQnpMbU52Ym5SeVlXTjBMbE4wWVhSbFFYTnpaWFJRWVhKaGJYTkRiMjUwY21GamRDNTJaWEpwWm5sZllYTnpaWFJmY0dGeVlXMXpYMmRsZEY5bWNtVmxlbVZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMlpYSnBabmxmWVhOelpYUmZjR0Z5WVcxelgyZGxkRjltY21WbGVtVTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZNalV3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPakkxTWdvZ0lDQWdMeThnZG1Gc2RXVXNJR1Y0YVhOMGN5QTlJRzl3TGtGemMyVjBVR0Z5WVcxelIyVjBMbUZ6YzJWMFgyWnlaV1Y2WlNoaEtRb2dJQ0FnWVhOelpYUmZjR0Z5WVcxelgyZGxkQ0JCYzNObGRFWnlaV1Y2WlFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMU4wWVhSbFQzQnpMMk52Ym5SeVlXTjBMbkI1T2pJMENpQWdJQ0F2THlCeVpYUjFjbTRnYjNBdVluUnZhU2hVZUc0dVlYQndiR2xqWVhScGIyNWZZWEpuY3lneEtTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5VGRHRjBaVTl3Y3k5amIyNTBjbUZqZEM1d2VUb3lOVE1LSUNBZ0lDOHZJSFpoYkhWbFgybHVaR1Y0TENCbGVHbHpkSE5mYVc1a1pYZ2dQU0J2Y0M1QmMzTmxkRkJoY21GdGMwZGxkQzVoYzNObGRGOW1jbVZsZW1Vb1gyZGxkRjh4YzNSZmNtVm1YMmx1WkdWNEtDa3BDaUFnSUNCaGMzTmxkRjl3WVhKaGJYTmZaMlYwSUVGemMyVjBSbkpsWlhwbENpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12VTNSaGRHVlBjSE12WTI5dWRISmhZM1F1Y0hrNk1qVTBDaUFnSUNBdkx5QmhjM05sY25RZ2RtRnNkV1VnUFQwZ2RtRnNkV1ZmYVc1a1pYZ3NJQ0psZUhCbFkzUmxaQ0IyWVd4MVpTQmllU0JwYm1SbGVDQjBieUJ0WVhSamFDSUtJQ0FnSUdScFp5QXpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdaWGh3WldOMFpXUWdkbUZzZFdVZ1lua2dhVzVrWlhnZ2RHOGdiV0YwWTJnS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRveU5UVUtJQ0FnSUM4dklHRnpjMlZ5ZENCbGVHbHpkSE1nUFQwZ1pYaHBjM1J6WDJsdVpHVjRMQ0FpWlhod1pXTjBaV1FnWlhocGMzUnpJR0o1SUdsdVpHVjRJSFJ2SUcxaGRHTm9JZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCbGVIQmxZM1JsWkNCbGVHbHpkSE1nWW5rZ2FXNWtaWGdnZEc4Z2JXRjBZMmdLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG95TlRBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdVlYSjBhV1poWTNSekxsTjBZWFJsVDNCekxtTnZiblJ5WVdOMExsTjBZWFJsUVhOelpYUlFZWEpoYlhORGIyNTBjbUZqZEM1MlpYSnBabmxmWVhOelpYUmZjR0Z5WVcxelgyZGxkRjlqYkdGM1ltRmphMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25abGNtbG1lVjloYzNObGRGOXdZWEpoYlhOZloyVjBYMk5zWVhkaVlXTnJPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPakkxT0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG95TmpBS0lDQWdJQzh2SUhaaGJIVmxMQ0JsZUdsemRITWdQU0J2Y0M1QmMzTmxkRkJoY21GdGMwZGxkQzVoYzNObGRGOWpiR0YzWW1GamF5aGhLUW9nSUNBZ1lYTnpaWFJmY0dGeVlXMXpYMmRsZENCQmMzTmxkRU5zWVhkaVlXTnJDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZNalFLSUNBZ0lDOHZJSEpsZEhWeWJpQnZjQzVpZEc5cEtGUjRiaTVoY0hCc2FXTmhkR2x2Ymw5aGNtZHpLREVwS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMU4wWVhSbFQzQnpMMk52Ym5SeVlXTjBMbkI1T2pJMk1Rb2dJQ0FnTHk4Z2RtRnNkV1ZmYVc1a1pYZ3NJR1Y0YVhOMGMxOXBibVJsZUNBOUlHOXdMa0Z6YzJWMFVHRnlZVzF6UjJWMExtRnpjMlYwWDJOc1lYZGlZV05yS0Y5blpYUmZNWE4wWDNKbFpsOXBibVJsZUNncEtRb2dJQ0FnWVhOelpYUmZjR0Z5WVcxelgyZGxkQ0JCYzNObGRFTnNZWGRpWVdOckNpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12VTNSaGRHVlBjSE12WTI5dWRISmhZM1F1Y0hrNk1qWXlDaUFnSUNBdkx5QmhjM05sY25RZ2RtRnNkV1VnUFQwZ2RtRnNkV1ZmYVc1a1pYZ3NJQ0psZUhCbFkzUmxaQ0IyWVd4MVpTQmllU0JwYm1SbGVDQjBieUJ0WVhSamFDSUtJQ0FnSUdScFp5QXpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdaWGh3WldOMFpXUWdkbUZzZFdVZ1lua2dhVzVrWlhnZ2RHOGdiV0YwWTJnS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRveU5qTUtJQ0FnSUM4dklHRnpjMlZ5ZENCbGVHbHpkSE1nUFQwZ1pYaHBjM1J6WDJsdVpHVjRMQ0FpWlhod1pXTjBaV1FnWlhocGMzUnpJR0o1SUdsdVpHVjRJSFJ2SUcxaGRHTm9JZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCbGVIQmxZM1JsWkNCbGVHbHpkSE1nWW5rZ2FXNWtaWGdnZEc4Z2JXRjBZMmdLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG95TlRnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdVlYSjBhV1poWTNSekxsTjBZWFJsVDNCekxtTnZiblJ5WVdOMExsTjBZWFJsUVhOelpYUlFZWEpoYlhORGIyNTBjbUZqZEM1MlpYSnBabmxmWVhOelpYUmZjR0Z5WVcxelgyZGxkRjlqY21WaGRHOXlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZG1WeWFXWjVYMkZ6YzJWMFgzQmhjbUZ0YzE5blpYUmZZM0psWVhSdmNqb0tJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5VGRHRjBaVTl3Y3k5amIyNTBjbUZqZEM1d2VUb3lOallLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZNalk0Q2lBZ0lDQXZMeUIyWVd4MVpTd2daWGhwYzNSeklEMGdiM0F1UVhOelpYUlFZWEpoYlhOSFpYUXVZWE56WlhSZlkzSmxZWFJ2Y2loaEtRb2dJQ0FnWVhOelpYUmZjR0Z5WVcxelgyZGxkQ0JCYzNObGRFTnlaV0YwYjNJS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRveU5Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUc5d0xtSjBiMmtvVkhodUxtRndjR3hwWTJGMGFXOXVYMkZ5WjNNb01Ta3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZNalk1Q2lBZ0lDQXZMeUIyWVd4MVpWOXBibVJsZUN3Z1pYaHBjM1J6WDJsdVpHVjRJRDBnYjNBdVFYTnpaWFJRWVhKaGJYTkhaWFF1WVhOelpYUmZZM0psWVhSdmNpaGZaMlYwWHpGemRGOXlaV1pmYVc1a1pYZ29LU2tLSUNBZ0lHRnpjMlYwWDNCaGNtRnRjMTluWlhRZ1FYTnpaWFJEY21WaGRHOXlDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZNamN3Q2lBZ0lDQXZMeUJoYzNObGNuUWdkbUZzZFdVZ1BUMGdkbUZzZFdWZmFXNWtaWGdzSUNKbGVIQmxZM1JsWkNCMllXeDFaU0JpZVNCcGJtUmxlQ0IwYnlCdFlYUmphQ0lLSUNBZ0lHUnBaeUF6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnWlhod1pXTjBaV1FnZG1Gc2RXVWdZbmtnYVc1a1pYZ2dkRzhnYldGMFkyZ0tJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5VGRHRjBaVTl3Y3k5amIyNTBjbUZqZEM1d2VUb3lOekVLSUNBZ0lDOHZJR0Z6YzJWeWRDQmxlR2x6ZEhNZ1BUMGdaWGhwYzNSelgybHVaR1Y0TENBaVpYaHdaV04wWldRZ1pYaHBjM1J6SUdKNUlHbHVaR1Y0SUhSdklHMWhkR05vSWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmxlSEJsWTNSbFpDQmxlR2x6ZEhNZ1lua2dhVzVrWlhnZ2RHOGdiV0YwWTJnS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRveU5qWUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFCQVNZQkJCVWZmSFV4RzBFQVl6RVpGRVF4R0VTQ0RBVHdYYWVrQk1EcHd4VUUyRktDY3dUMFJvclpCQ0tkRXZjRTMxTlBld1RnVUxXcEJJc3FMVmdFN2hYRTl3UVZkVVQvQkJCSkxBY0VVaW42TnpZYUFJNE1BQWtBSkFBL0FHRUFnd0NsQU1jQTZRRURBUjBCTndGUkFERVpGREVZRkJCRE5ob0JGM0VBTmhvQkYzRUFTd05QQWhKRUVrUVdLRXhRc0NKRE5ob0JGM0VCTmhvQkYzRUJTd05QQWhKRUVrUVdLRXhRc0NKRE5ob0JGM0VDTmhvQkYzRUNTd05QQWhKRUVrU0FBUUNCQUU4Q1ZDaE1VTEFpUXpZYUFSZHhBellhQVJkeEEwc0RUd0lTUkJKRVNSVVdWd1lDVEZBb1RGQ3dJa00yR2dFWGNRUTJHZ0VYY1FSTEEwOENFa1FTUkVrVkZsY0dBa3hRS0V4UXNDSkROaG9CRjNFRk5ob0JGM0VGU3dOUEFoSkVFa1JKRlJaWEJnSk1VQ2hNVUxBaVF6WWFBUmR4QmpZYUFSZHhCa3NEVHdJU1JCSkVTUlVXVndZQ1RGQW9URkN3SWtNMkdnRVhjUWMyR2dFWGNRZExBMDhDRWtRU1JDaE1VTEFpUXpZYUFSZHhDRFlhQVJkeENFc0RUd0lTUkJKRUtFeFFzQ0pETmhvQkYzRUpOaG9CRjNFSlN3TlBBaEpFRWtRb1RGQ3dJa00yR2dFWGNRbzJHZ0VYY1FwTEEwOENFa1FTUkNoTVVMQWlRellhQVJkeEN6WWFBUmR4QzBzRFR3SVNSQkpFS0V4UXNDSkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo4LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
