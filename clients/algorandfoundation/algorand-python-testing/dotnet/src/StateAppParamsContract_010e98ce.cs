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

namespace Arc56.Generated.algorandfoundation.algorand_python_testing.StateAppParamsContract_010e98ce
{


    public class StateAppParamsContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public StateAppParamsContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        public async Task<byte[]> VerifyAppParamsGetApprovalProgram(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 209, 60, 27 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> VerifyAppParamsGetApprovalProgram_Transactions(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 209, 60, 27 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<byte[]> VerifyAppParamsGetClearStateProgram(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 229, 195, 200, 137 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> VerifyAppParamsGetClearStateProgram_Transactions(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 229, 195, 200, 137 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<ulong> VerifyAppParamsGetGlobalNumUint(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 238, 78, 123, 42 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifyAppParamsGetGlobalNumUint_Transactions(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 238, 78, 123, 42 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<ulong> VerifyAppParamsGetGlobalNumByteSlice(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 162, 52, 203 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifyAppParamsGetGlobalNumByteSlice_Transactions(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 162, 52, 203 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<ulong> VerifyAppParamsGetLocalNumUint(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 25, 247, 116, 57 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifyAppParamsGetLocalNumUint_Transactions(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 25, 247, 116, 57 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<ulong> VerifyAppParamsGetLocalNumByteSlice(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 146, 197, 114, 170 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifyAppParamsGetLocalNumByteSlice_Transactions(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 146, 197, 114, 170 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<ulong> VerifyAppParamsGetExtraProgramPages(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 174, 156, 110, 251 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifyAppParamsGetExtraProgramPages_Transactions(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 174, 156, 110, 251 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<Algorand.Address> VerifyAppParamsGetCreator(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 110, 215, 5 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> VerifyAppParamsGetCreator_Transactions(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 110, 215, 5 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<Algorand.Address> VerifyAppParamsGetAddress(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 140, 102, 168, 66 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> VerifyAppParamsGetAddress_Transactions(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 140, 102, 168, 66 };
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3RhdGVBcHBQYXJhbXNDb250cmFjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJ2ZXJpZnlfYXBwX3BhcmFtc19nZXRfYXBwcm92YWxfcHJvZ3JhbSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmVyaWZ5X2FwcF9wYXJhbXNfZ2V0X2NsZWFyX3N0YXRlX3Byb2dyYW0iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZlcmlmeV9hcHBfcGFyYW1zX2dldF9nbG9iYWxfbnVtX3VpbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZlcmlmeV9hcHBfcGFyYW1zX2dldF9nbG9iYWxfbnVtX2J5dGVfc2xpY2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZlcmlmeV9hcHBfcGFyYW1zX2dldF9sb2NhbF9udW1fdWludCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmVyaWZ5X2FwcF9wYXJhbXNfZ2V0X2xvY2FsX251bV9ieXRlX3NsaWNlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2ZXJpZnlfYXBwX3BhcmFtc19nZXRfZXh0cmFfcHJvZ3JhbV9wYWdlcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmVyaWZ5X2FwcF9wYXJhbXNfZ2V0X2NyZWF0b3IiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2ZXJpZnlfYXBwX3BhcmFtc19nZXRfYWRkcmVzcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTIxLDE1NSwxODksMjE2LDI0MywyNzAsMjk3LDMyNCwzNTBdLCJlcnJvck1lc3NhZ2UiOiJleHBlY3RlZCBleGlzdHMgYnkgaW5kZXggdG8gbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTksMTUzLDE4NywyMTQsMjQxLDI2OCwyOTUsMzIyLDM0OF0sImVycm9yTWVzc2FnZSI6ImV4cGVjdGVkIHZhbHVlIGJ5IGluZGV4IHRvIG1hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBeENpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE1UVXhaamRqTnpVS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRveU56VUtJQ0FnSUM4dklHTnNZWE56SUZOMFlYUmxRWEJ3VUdGeVlXMXpRMjl1ZEhKaFkzUW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFERTJDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IaGlPV1F4TTJNeFlpQXdlR1UxWXpOak9EZzVJREI0WldVMFpUZGlNbUVnTUhnM1ptRXlNelJqWWlBd2VERTVaamMzTkRNNUlEQjRPVEpqTlRjeVlXRWdNSGhoWlRsak5tVm1ZaUF3ZUdVek5tVmtOekExSURCNE9HTTJObUU0TkRJZ0x5OGdiV1YwYUc5a0lDSjJaWEpwWm5sZllYQndYM0JoY21GdGMxOW5aWFJmWVhCd2NtOTJZV3hmY0hKdlozSmhiU2gxYVc1ME5qUXBZbmwwWlZ0ZElpd2diV1YwYUc5a0lDSjJaWEpwWm5sZllYQndYM0JoY21GdGMxOW5aWFJmWTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNoMWFXNTBOalFwWW5sMFpWdGRJaXdnYldWMGFHOWtJQ0oyWlhKcFpubGZZWEJ3WDNCaGNtRnRjMTluWlhSZloyeHZZbUZzWDI1MWJWOTFhVzUwS0hWcGJuUTJOQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJblpsY21sbWVWOWhjSEJmY0dGeVlXMXpYMmRsZEY5bmJHOWlZV3hmYm5WdFgySjVkR1ZmYzJ4cFkyVW9kV2x1ZERZMEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaWRtVnlhV1o1WDJGd2NGOXdZWEpoYlhOZloyVjBYMnh2WTJGc1gyNTFiVjkxYVc1MEtIVnBiblEyTkNsMWFXNTBOalFpTENCdFpYUm9iMlFnSW5abGNtbG1lVjloY0hCZmNHRnlZVzF6WDJkbGRGOXNiMk5oYkY5dWRXMWZZbmwwWlY5emJHbGpaU2gxYVc1ME5qUXBkV2x1ZERZMElpd2diV1YwYUc5a0lDSjJaWEpwWm5sZllYQndYM0JoY21GdGMxOW5aWFJmWlhoMGNtRmZjSEp2WjNKaGJWOXdZV2RsY3loMWFXNTBOalFwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0oyWlhKcFpubGZZWEJ3WDNCaGNtRnRjMTluWlhSZlkzSmxZWFJ2Y2loMWFXNTBOalFwWVdSa2NtVnpjeUlzSUcxbGRHaHZaQ0FpZG1WeWFXWjVYMkZ3Y0Y5d1lYSmhiWE5mWjJWMFgyRmtaSEpsYzNNb2RXbHVkRFkwS1dGa1pISmxjM01pQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCMlpYSnBabmxmWVhCd1gzQmhjbUZ0YzE5blpYUmZZWEJ3Y205MllXeGZjSEp2WjNKaGJTQjJaWEpwWm5sZllYQndYM0JoY21GdGMxOW5aWFJmWTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNCMlpYSnBabmxmWVhCd1gzQmhjbUZ0YzE5blpYUmZaMnh2WW1Gc1gyNTFiVjkxYVc1MElIWmxjbWxtZVY5aGNIQmZjR0Z5WVcxelgyZGxkRjluYkc5aVlXeGZiblZ0WDJKNWRHVmZjMnhwWTJVZ2RtVnlhV1o1WDJGd2NGOXdZWEpoYlhOZloyVjBYMnh2WTJGc1gyNTFiVjkxYVc1MElIWmxjbWxtZVY5aGNIQmZjR0Z5WVcxelgyZGxkRjlzYjJOaGJGOXVkVzFmWW5sMFpWOXpiR2xqWlNCMlpYSnBabmxmWVhCd1gzQmhjbUZ0YzE5blpYUmZaWGgwY21GZmNISnZaM0poYlY5d1lXZGxjeUIyWlhKcFpubGZZWEJ3WDNCaGNtRnRjMTluWlhSZlkzSmxZWFJ2Y2lCMlpYSnBabmxmWVhCd1gzQmhjbUZ0YzE5blpYUmZZV1JrY21WemN3b2dJQ0FnWlhKeUNncHRZV2x1WDE5ZllXeG5iM0I1WDJSbFptRjFiSFJmWTNKbFlYUmxRREUyT2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5NWhjblJwWm1GamRITXVVM1JoZEdWUGNITXVZMjl1ZEhKaFkzUXVVM1JoZEdWQmNIQlFZWEpoYlhORGIyNTBjbUZqZEM1MlpYSnBabmxmWVhCd1gzQmhjbUZ0YzE5blpYUmZZWEJ3Y205MllXeGZjSEp2WjNKaGJWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblpsY21sbWVWOWhjSEJmY0dGeVlXMXpYMmRsZEY5aGNIQnliM1poYkY5d2NtOW5jbUZ0T2dvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMU4wWVhSbFQzQnpMMk52Ym5SeVlXTjBMbkI1T2pJM05nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRveU56Z0tJQ0FnSUM4dklIWmhiSFZsTENCbGVHbHpkSE1nUFNCdmNDNUJjSEJRWVhKaGJYTkhaWFF1WVhCd1gyRndjSEp2ZG1Gc1gzQnliMmR5WVcwb1lTa0tJQ0FnSUdGd2NGOXdZWEpoYlhOZloyVjBJRUZ3Y0VGd2NISnZkbUZzVUhKdlozSmhiUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPakkwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdiM0F1WW5SdmFTaFVlRzR1WVhCd2JHbGpZWFJwYjI1ZllYSm5jeWd4S1NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRveU56a0tJQ0FnSUM4dklIWmhiSFZsWDJsdVpHVjRMQ0JsZUdsemRITmZhVzVrWlhnZ1BTQnZjQzVCY0hCUVlYSmhiWE5IWlhRdVlYQndYMkZ3Y0hKdmRtRnNYM0J5YjJkeVlXMG9YMmRsZEY4eGMzUmZjbVZtWDJsdVpHVjRLQ2twQ2lBZ0lDQmhjSEJmY0dGeVlXMXpYMmRsZENCQmNIQkJjSEJ5YjNaaGJGQnliMmR5WVcwS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRveU9EQUtJQ0FnSUM4dklHRnpjMlZ5ZENCMllXeDFaU0E5UFNCMllXeDFaVjlwYm1SbGVDd2dJbVY0Y0dWamRHVmtJSFpoYkhWbElHSjVJR2x1WkdWNElIUnZJRzFoZEdOb0lnb2dJQ0FnWkdsbklETUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmxlSEJsWTNSbFpDQjJZV3gxWlNCaWVTQnBibVJsZUNCMGJ5QnRZWFJqYUFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMU4wWVhSbFQzQnpMMk52Ym5SeVlXTjBMbkI1T2pJNE1Rb2dJQ0FnTHk4Z1lYTnpaWEowSUdWNGFYTjBjeUE5UFNCbGVHbHpkSE5mYVc1a1pYZ3NJQ0psZUhCbFkzUmxaQ0JsZUdsemRITWdZbmtnYVc1a1pYZ2dkRzhnYldGMFkyZ2lDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdWNGNHVmpkR1ZrSUdWNGFYTjBjeUJpZVNCcGJtUmxlQ0IwYnlCdFlYUmphQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPakkzTmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE11WVhKMGFXWmhZM1J6TGxOMFlYUmxUM0J6TG1OdmJuUnlZV04wTGxOMFlYUmxRWEJ3VUdGeVlXMXpRMjl1ZEhKaFkzUXVkbVZ5YVdaNVgyRndjRjl3WVhKaGJYTmZaMlYwWDJOc1pXRnlYM04wWVhSbFgzQnliMmR5WVcxYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDJaWEpwWm5sZllYQndYM0JoY21GdGMxOW5aWFJmWTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRveU9EUUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12VTNSaGRHVlBjSE12WTI5dWRISmhZM1F1Y0hrNk1qZzJDaUFnSUNBdkx5QjJZV3gxWlN3Z1pYaHBjM1J6SUQwZ2IzQXVRWEJ3VUdGeVlXMXpSMlYwTG1Gd2NGOWpiR1ZoY2w5emRHRjBaVjl3Y205bmNtRnRLR0VwQ2lBZ0lDQmhjSEJmY0dGeVlXMXpYMmRsZENCQmNIQkRiR1ZoY2xOMFlYUmxVSEp2WjNKaGJRb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qSTBDaUFnSUNBdkx5QnlaWFIxY200Z2IzQXVZblJ2YVNoVWVHNHVZWEJ3YkdsallYUnBiMjVmWVhKbmN5Z3hLU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG95T0RjS0lDQWdJQzh2SUhaaGJIVmxYMmx1WkdWNExDQmxlR2x6ZEhOZmFXNWtaWGdnUFNCdmNDNUJjSEJRWVhKaGJYTkhaWFF1WVhCd1gyTnNaV0Z5WDNOMFlYUmxYM0J5YjJkeVlXMG9YMmRsZEY4eGMzUmZjbVZtWDJsdVpHVjRLQ2twQ2lBZ0lDQmhjSEJmY0dGeVlXMXpYMmRsZENCQmNIQkRiR1ZoY2xOMFlYUmxVSEp2WjNKaGJRb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qSTRPQW9nSUNBZ0x5OGdZWE56WlhKMElIWmhiSFZsSUQwOUlIWmhiSFZsWDJsdVpHVjRMQ0FpWlhod1pXTjBaV1FnZG1Gc2RXVWdZbmtnYVc1a1pYZ2dkRzhnYldGMFkyZ2lDaUFnSUNCa2FXY2dNd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR1Y0Y0dWamRHVmtJSFpoYkhWbElHSjVJR2x1WkdWNElIUnZJRzFoZEdOb0NpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12VTNSaGRHVlBjSE12WTI5dWRISmhZM1F1Y0hrNk1qZzVDaUFnSUNBdkx5QmhjM05sY25RZ1pYaHBjM1J6SUQwOUlHVjRhWE4wYzE5cGJtUmxlQ3dnSW1WNGNHVmpkR1ZrSUdWNGFYTjBjeUJpZVNCcGJtUmxlQ0IwYnlCdFlYUmphQ0lLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1pYaHdaV04wWldRZ1pYaHBjM1J6SUdKNUlHbHVaR1Y0SUhSdklHMWhkR05vQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TWpnMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k1aGNuUnBabUZqZEhNdVUzUmhkR1ZQY0hNdVkyOXVkSEpoWTNRdVUzUmhkR1ZCY0hCUVlYSmhiWE5EYjI1MGNtRmpkQzUyWlhKcFpubGZZWEJ3WDNCaGNtRnRjMTluWlhSZloyeHZZbUZzWDI1MWJWOTFhVzUwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RtVnlhV1o1WDJGd2NGOXdZWEpoYlhOZloyVjBYMmRzYjJKaGJGOXVkVzFmZFdsdWREb0tJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5VGRHRjBaVTl3Y3k5amIyNTBjbUZqZEM1d2VUb3lPVElLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZNamswQ2lBZ0lDQXZMeUIyWVd4MVpTd2daWGhwYzNSeklEMGdiM0F1UVhCd1VHRnlZVzF6UjJWMExtRndjRjluYkc5aVlXeGZiblZ0WDNWcGJuUW9ZU2tLSUNBZ0lHRndjRjl3WVhKaGJYTmZaMlYwSUVGd2NFZHNiMkpoYkU1MWJWVnBiblFLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG95TkFvZ0lDQWdMeThnY21WMGRYSnVJRzl3TG1KMGIya29WSGh1TG1Gd2NHeHBZMkYwYVc5dVgyRnlaM01vTVNrcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12VTNSaGRHVlBjSE12WTI5dWRISmhZM1F1Y0hrNk1qazFDaUFnSUNBdkx5QjJZV3gxWlY5cGJtUmxlQ3dnWlhocGMzUnpYMmx1WkdWNElEMGdiM0F1UVhCd1VHRnlZVzF6UjJWMExtRndjRjluYkc5aVlXeGZiblZ0WDNWcGJuUW9YMmRsZEY4eGMzUmZjbVZtWDJsdVpHVjRLQ2twQ2lBZ0lDQmhjSEJmY0dGeVlXMXpYMmRsZENCQmNIQkhiRzlpWVd4T2RXMVZhVzUwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TWprMkNpQWdJQ0F2THlCaGMzTmxjblFnZG1Gc2RXVWdQVDBnZG1Gc2RXVmZhVzVrWlhnc0lDSmxlSEJsWTNSbFpDQjJZV3gxWlNCaWVTQnBibVJsZUNCMGJ5QnRZWFJqYUNJS0lDQWdJR1JwWnlBekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1pYaHdaV04wWldRZ2RtRnNkV1VnWW5rZ2FXNWtaWGdnZEc4Z2JXRjBZMmdLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG95T1RjS0lDQWdJQzh2SUdGemMyVnlkQ0JsZUdsemRITWdQVDBnWlhocGMzUnpYMmx1WkdWNExDQWlaWGh3WldOMFpXUWdaWGhwYzNSeklHSjVJR2x1WkdWNElIUnZJRzFoZEdOb0lnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJsZUhCbFkzUmxaQ0JsZUdsemRITWdZbmtnYVc1a1pYZ2dkRzhnYldGMFkyZ0tJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5VGRHRjBaVTl3Y3k5amIyNTBjbUZqZEM1d2VUb3lPVElLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE11WVhKMGFXWmhZM1J6TGxOMFlYUmxUM0J6TG1OdmJuUnlZV04wTGxOMFlYUmxRWEJ3VUdGeVlXMXpRMjl1ZEhKaFkzUXVkbVZ5YVdaNVgyRndjRjl3WVhKaGJYTmZaMlYwWDJkc2IySmhiRjl1ZFcxZllubDBaVjl6YkdsalpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblpsY21sbWVWOWhjSEJmY0dGeVlXMXpYMmRsZEY5bmJHOWlZV3hmYm5WdFgySjVkR1ZmYzJ4cFkyVTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZNekF3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPak13TWdvZ0lDQWdMeThnZG1Gc2RXVXNJR1Y0YVhOMGN5QTlJRzl3TGtGd2NGQmhjbUZ0YzBkbGRDNWhjSEJmWjJ4dlltRnNYMjUxYlY5aWVYUmxYM05zYVdObEtHRXBDaUFnSUNCaGNIQmZjR0Z5WVcxelgyZGxkQ0JCY0hCSGJHOWlZV3hPZFcxQ2VYUmxVMnhwWTJVS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRveU5Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUc5d0xtSjBiMmtvVkhodUxtRndjR3hwWTJGMGFXOXVYMkZ5WjNNb01Ta3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZNekF6Q2lBZ0lDQXZMeUIyWVd4MVpWOXBibVJsZUN3Z1pYaHBjM1J6WDJsdVpHVjRJRDBnYjNBdVFYQndVR0Z5WVcxelIyVjBMbUZ3Y0Y5bmJHOWlZV3hmYm5WdFgySjVkR1ZmYzJ4cFkyVW9YMmRsZEY4eGMzUmZjbVZtWDJsdVpHVjRLQ2twQ2lBZ0lDQmhjSEJmY0dGeVlXMXpYMmRsZENCQmNIQkhiRzlpWVd4T2RXMUNlWFJsVTJ4cFkyVUtJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5VGRHRjBaVTl3Y3k5amIyNTBjbUZqZEM1d2VUb3pNRFFLSUNBZ0lDOHZJR0Z6YzJWeWRDQjJZV3gxWlNBOVBTQjJZV3gxWlY5cGJtUmxlQ3dnSW1WNGNHVmpkR1ZrSUhaaGJIVmxJR0o1SUdsdVpHVjRJSFJ2SUcxaGRHTm9JZ29nSUNBZ1pHbG5JRE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJsZUhCbFkzUmxaQ0IyWVd4MVpTQmllU0JwYm1SbGVDQjBieUJ0WVhSamFBb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qTXdOUW9nSUNBZ0x5OGdZWE56WlhKMElHVjRhWE4wY3lBOVBTQmxlR2x6ZEhOZmFXNWtaWGdzSUNKbGVIQmxZM1JsWkNCbGVHbHpkSE1nWW5rZ2FXNWtaWGdnZEc4Z2JXRjBZMmdpQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHVjRjR1ZqZEdWa0lHVjRhWE4wY3lCaWVTQnBibVJsZUNCMGJ5QnRZWFJqYUFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMU4wWVhSbFQzQnpMMk52Ym5SeVlXTjBMbkI1T2pNd01Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5NWhjblJwWm1GamRITXVVM1JoZEdWUGNITXVZMjl1ZEhKaFkzUXVVM1JoZEdWQmNIQlFZWEpoYlhORGIyNTBjbUZqZEM1MlpYSnBabmxmWVhCd1gzQmhjbUZ0YzE5blpYUmZiRzlqWVd4ZmJuVnRYM1ZwYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDJaWEpwWm5sZllYQndYM0JoY21GdGMxOW5aWFJmYkc5allXeGZiblZ0WDNWcGJuUTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZNekE0Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPak14TUFvZ0lDQWdMeThnZG1Gc2RXVXNJR1Y0YVhOMGN5QTlJRzl3TGtGd2NGQmhjbUZ0YzBkbGRDNWhjSEJmYkc5allXeGZiblZ0WDNWcGJuUW9ZU2tLSUNBZ0lHRndjRjl3WVhKaGJYTmZaMlYwSUVGd2NFeHZZMkZzVG5WdFZXbHVkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPakkwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdiM0F1WW5SdmFTaFVlRzR1WVhCd2JHbGpZWFJwYjI1ZllYSm5jeWd4S1NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRvek1URUtJQ0FnSUM4dklIWmhiSFZsWDJsdVpHVjRMQ0JsZUdsemRITmZhVzVrWlhnZ1BTQnZjQzVCY0hCUVlYSmhiWE5IWlhRdVlYQndYMnh2WTJGc1gyNTFiVjkxYVc1MEtGOW5aWFJmTVhOMFgzSmxabDlwYm1SbGVDZ3BLUW9nSUNBZ1lYQndYM0JoY21GdGMxOW5aWFFnUVhCd1RHOWpZV3hPZFcxVmFXNTBDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZNekV5Q2lBZ0lDQXZMeUJoYzNObGNuUWdkbUZzZFdVZ1BUMGdkbUZzZFdWZmFXNWtaWGdzSUNKbGVIQmxZM1JsWkNCMllXeDFaU0JpZVNCcGJtUmxlQ0IwYnlCdFlYUmphQ0lLSUNBZ0lHUnBaeUF6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnWlhod1pXTjBaV1FnZG1Gc2RXVWdZbmtnYVc1a1pYZ2dkRzhnYldGMFkyZ0tJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5VGRHRjBaVTl3Y3k5amIyNTBjbUZqZEM1d2VUb3pNVE1LSUNBZ0lDOHZJR0Z6YzJWeWRDQmxlR2x6ZEhNZ1BUMGdaWGhwYzNSelgybHVaR1Y0TENBaVpYaHdaV04wWldRZ1pYaHBjM1J6SUdKNUlHbHVaR1Y0SUhSdklHMWhkR05vSWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmxlSEJsWTNSbFpDQmxlR2x6ZEhNZ1lua2dhVzVrWlhnZ2RHOGdiV0YwWTJnS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRvek1EZ0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXVZWEowYVdaaFkzUnpMbE4wWVhSbFQzQnpMbU52Ym5SeVlXTjBMbE4wWVhSbFFYQndVR0Z5WVcxelEyOXVkSEpoWTNRdWRtVnlhV1o1WDJGd2NGOXdZWEpoYlhOZloyVjBYMnh2WTJGc1gyNTFiVjlpZVhSbFgzTnNhV05sVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RtVnlhV1o1WDJGd2NGOXdZWEpoYlhOZloyVjBYMnh2WTJGc1gyNTFiVjlpZVhSbFgzTnNhV05sT2dvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMU4wWVhSbFQzQnpMMk52Ym5SeVlXTjBMbkI1T2pNeE5nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRvek1UZ0tJQ0FnSUM4dklIWmhiSFZsTENCbGVHbHpkSE1nUFNCdmNDNUJjSEJRWVhKaGJYTkhaWFF1WVhCd1gyeHZZMkZzWDI1MWJWOWllWFJsWDNOc2FXTmxLR0VwQ2lBZ0lDQmhjSEJmY0dGeVlXMXpYMmRsZENCQmNIQk1iMk5oYkU1MWJVSjVkR1ZUYkdsalpRb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qSTBDaUFnSUNBdkx5QnlaWFIxY200Z2IzQXVZblJ2YVNoVWVHNHVZWEJ3YkdsallYUnBiMjVmWVhKbmN5Z3hLU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG96TVRrS0lDQWdJQzh2SUhaaGJIVmxYMmx1WkdWNExDQmxlR2x6ZEhOZmFXNWtaWGdnUFNCdmNDNUJjSEJRWVhKaGJYTkhaWFF1WVhCd1gyeHZZMkZzWDI1MWJWOWllWFJsWDNOc2FXTmxLRjluWlhSZk1YTjBYM0psWmw5cGJtUmxlQ2dwS1FvZ0lDQWdZWEJ3WDNCaGNtRnRjMTluWlhRZ1FYQndURzlqWVd4T2RXMUNlWFJsVTJ4cFkyVUtJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5VGRHRjBaVTl3Y3k5amIyNTBjbUZqZEM1d2VUb3pNakFLSUNBZ0lDOHZJR0Z6YzJWeWRDQjJZV3gxWlNBOVBTQjJZV3gxWlY5cGJtUmxlQ3dnSW1WNGNHVmpkR1ZrSUhaaGJIVmxJR0o1SUdsdVpHVjRJSFJ2SUcxaGRHTm9JZ29nSUNBZ1pHbG5JRE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJsZUhCbFkzUmxaQ0IyWVd4MVpTQmllU0JwYm1SbGVDQjBieUJ0WVhSamFBb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qTXlNUW9nSUNBZ0x5OGdZWE56WlhKMElHVjRhWE4wY3lBOVBTQmxlR2x6ZEhOZmFXNWtaWGdzSUNKbGVIQmxZM1JsWkNCbGVHbHpkSE1nWW5rZ2FXNWtaWGdnZEc4Z2JXRjBZMmdpQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHVjRjR1ZqZEdWa0lHVjRhWE4wY3lCaWVTQnBibVJsZUNCMGJ5QnRZWFJqYUFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMU4wWVhSbFQzQnpMMk52Ym5SeVlXTjBMbkI1T2pNeE5nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5NWhjblJwWm1GamRITXVVM1JoZEdWUGNITXVZMjl1ZEhKaFkzUXVVM1JoZEdWQmNIQlFZWEpoYlhORGIyNTBjbUZqZEM1MlpYSnBabmxmWVhCd1gzQmhjbUZ0YzE5blpYUmZaWGgwY21GZmNISnZaM0poYlY5d1lXZGxjMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25abGNtbG1lVjloY0hCZmNHRnlZVzF6WDJkbGRGOWxlSFJ5WVY5d2NtOW5jbUZ0WDNCaFoyVnpPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPak15TkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG96TWpZS0lDQWdJQzh2SUhaaGJIVmxMQ0JsZUdsemRITWdQU0J2Y0M1QmNIQlFZWEpoYlhOSFpYUXVZWEJ3WDJWNGRISmhYM0J5YjJkeVlXMWZjR0ZuWlhNb1lTa0tJQ0FnSUdGd2NGOXdZWEpoYlhOZloyVjBJRUZ3Y0VWNGRISmhVSEp2WjNKaGJWQmhaMlZ6Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TWpRS0lDQWdJQzh2SUhKbGRIVnliaUJ2Y0M1aWRHOXBLRlI0Ymk1aGNIQnNhV05oZEdsdmJsOWhjbWR6S0RFcEtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qTXlOd29nSUNBZ0x5OGdkbUZzZFdWZmFXNWtaWGdzSUdWNGFYTjBjMTlwYm1SbGVDQTlJRzl3TGtGd2NGQmhjbUZ0YzBkbGRDNWhjSEJmWlhoMGNtRmZjSEp2WjNKaGJWOXdZV2RsY3loZloyVjBYekZ6ZEY5eVpXWmZhVzVrWlhnb0tTa0tJQ0FnSUdGd2NGOXdZWEpoYlhOZloyVjBJRUZ3Y0VWNGRISmhVSEp2WjNKaGJWQmhaMlZ6Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TXpJNENpQWdJQ0F2THlCaGMzTmxjblFnZG1Gc2RXVWdQVDBnZG1Gc2RXVmZhVzVrWlhnc0lDSmxlSEJsWTNSbFpDQjJZV3gxWlNCaWVTQnBibVJsZUNCMGJ5QnRZWFJqYUNJS0lDQWdJR1JwWnlBekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1pYaHdaV04wWldRZ2RtRnNkV1VnWW5rZ2FXNWtaWGdnZEc4Z2JXRjBZMmdLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG96TWprS0lDQWdJQzh2SUdGemMyVnlkQ0JsZUdsemRITWdQVDBnWlhocGMzUnpYMmx1WkdWNExDQWlaWGh3WldOMFpXUWdaWGhwYzNSeklHSjVJR2x1WkdWNElIUnZJRzFoZEdOb0lnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJsZUhCbFkzUmxaQ0JsZUdsemRITWdZbmtnYVc1a1pYZ2dkRzhnYldGMFkyZ0tJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5VGRHRjBaVTl3Y3k5amIyNTBjbUZqZEM1d2VUb3pNalFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE11WVhKMGFXWmhZM1J6TGxOMFlYUmxUM0J6TG1OdmJuUnlZV04wTGxOMFlYUmxRWEJ3VUdGeVlXMXpRMjl1ZEhKaFkzUXVkbVZ5YVdaNVgyRndjRjl3WVhKaGJYTmZaMlYwWDJOeVpXRjBiM0piY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMlpYSnBabmxmWVhCd1gzQmhjbUZ0YzE5blpYUmZZM0psWVhSdmNqb0tJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5VGRHRjBaVTl3Y3k5amIyNTBjbUZqZEM1d2VUb3pNeklLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZNek0wQ2lBZ0lDQXZMeUIyWVd4MVpTd2daWGhwYzNSeklEMGdiM0F1UVhCd1VHRnlZVzF6UjJWMExtRndjRjlqY21WaGRHOXlLR0VwQ2lBZ0lDQmhjSEJmY0dGeVlXMXpYMmRsZENCQmNIQkRjbVZoZEc5eUNpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12VTNSaGRHVlBjSE12WTI5dWRISmhZM1F1Y0hrNk1qUUtJQ0FnSUM4dklISmxkSFZ5YmlCdmNDNWlkRzlwS0ZSNGJpNWhjSEJzYVdOaGRHbHZibDloY21kektERXBLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPak16TlFvZ0lDQWdMeThnZG1Gc2RXVmZhVzVrWlhnc0lHVjRhWE4wYzE5cGJtUmxlQ0E5SUc5d0xrRndjRkJoY21GdGMwZGxkQzVoY0hCZlkzSmxZWFJ2Y2loZloyVjBYekZ6ZEY5eVpXWmZhVzVrWlhnb0tTa0tJQ0FnSUdGd2NGOXdZWEpoYlhOZloyVjBJRUZ3Y0VOeVpXRjBiM0lLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG96TXpZS0lDQWdJQzh2SUdGemMyVnlkQ0IyWVd4MVpTQTlQU0IyWVd4MVpWOXBibVJsZUN3Z0ltVjRjR1ZqZEdWa0lIWmhiSFZsSUdKNUlHbHVaR1Y0SUhSdklHMWhkR05vSWdvZ0lDQWdaR2xuSURNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCbGVIQmxZM1JsWkNCMllXeDFaU0JpZVNCcGJtUmxlQ0IwYnlCdFlYUmphQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPak16TndvZ0lDQWdMeThnWVhOelpYSjBJR1Y0YVhOMGN5QTlQU0JsZUdsemRITmZhVzVrWlhnc0lDSmxlSEJsWTNSbFpDQmxlR2x6ZEhNZ1lua2dhVzVrWlhnZ2RHOGdiV0YwWTJnaUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR1Y0Y0dWamRHVmtJR1Y0YVhOMGN5QmllU0JwYm1SbGVDQjBieUJ0WVhSamFBb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qTXpNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTVoY25ScFptRmpkSE11VTNSaGRHVlBjSE11WTI5dWRISmhZM1F1VTNSaGRHVkJjSEJRWVhKaGJYTkRiMjUwY21GamRDNTJaWEpwWm5sZllYQndYM0JoY21GdGMxOW5aWFJmWVdSa2NtVnpjMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25abGNtbG1lVjloY0hCZmNHRnlZVzF6WDJkbGRGOWhaR1J5WlhOek9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qTTBNQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5VGRHRjBaVTl3Y3k5amIyNTBjbUZqZEM1d2VUb3pORElLSUNBZ0lDOHZJSFpoYkhWbExDQmxlR2x6ZEhNZ1BTQnZjQzVCY0hCUVlYSmhiWE5IWlhRdVlYQndYMkZrWkhKbGMzTW9ZU2tLSUNBZ0lHRndjRjl3WVhKaGJYTmZaMlYwSUVGd2NFRmtaSEpsYzNNS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRveU5Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUc5d0xtSjBiMmtvVkhodUxtRndjR3hwWTJGMGFXOXVYMkZ5WjNNb01Ta3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZNelF6Q2lBZ0lDQXZMeUIyWVd4MVpWOXBibVJsZUN3Z1pYaHBjM1J6WDJsdVpHVjRJRDBnYjNBdVFYQndVR0Z5WVcxelIyVjBMbUZ3Y0Y5aFpHUnlaWE56S0Y5blpYUmZNWE4wWDNKbFpsOXBibVJsZUNncEtRb2dJQ0FnWVhCd1gzQmhjbUZ0YzE5blpYUWdRWEJ3UVdSa2NtVnpjd29nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPak0wTkFvZ0lDQWdMeThnWVhOelpYSjBJSFpoYkhWbElEMDlJSFpoYkhWbFgybHVaR1Y0TENBaVpYaHdaV04wWldRZ2RtRnNkV1VnWW5rZ2FXNWtaWGdnZEc4Z2JXRjBZMmdpQ2lBZ0lDQmthV2NnTXdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdWNGNHVmpkR1ZrSUhaaGJIVmxJR0o1SUdsdVpHVjRJSFJ2SUcxaGRHTm9DaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZNelExQ2lBZ0lDQXZMeUJoYzNObGNuUWdaWGhwYzNSeklEMDlJR1Y0YVhOMGMxOXBibVJsZUN3Z0ltVjRjR1ZqZEdWa0lHVjRhWE4wY3lCaWVTQnBibVJsZUNCMGJ5QnRZWFJqYUNJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdaWGh3WldOMFpXUWdaWGhwYzNSeklHSjVJR2x1WkdWNElIUnZJRzFoZEdOb0NpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12VTNSaGRHVlBjSE12WTI5dWRISmhZM1F1Y0hrNk16UXdDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFCQVNZQkJCVWZmSFV4RzBFQVRqRVpGRVF4R0VTQ0NRUzUwVHdiQk9YRHlJa0U3azU3S2dSL29qVExCQm4zZERrRWtzVnlxZ1N1bkc3N0JPTnUxd1VFakdhb1FqWWFBSTRKQUFrQUt3Qk5BR2dBZ3dDZUFMa0ExQUR1QURFWkZERVlGQkJETmhvQkYzSUFOaG9CRjNJQVN3TlBBaEpFRWtSSkZSWlhCZ0pNVUNoTVVMQWlRellhQVJkeUFUWWFBUmR5QVVzRFR3SVNSQkpFU1JVV1Z3WUNURkFvVEZDd0lrTTJHZ0VYY2dJMkdnRVhjZ0pMQTA4Q0VrUVNSQllvVEZDd0lrTTJHZ0VYY2dNMkdnRVhjZ05MQTA4Q0VrUVNSQllvVEZDd0lrTTJHZ0VYY2dRMkdnRVhjZ1JMQTA4Q0VrUVNSQllvVEZDd0lrTTJHZ0VYY2dVMkdnRVhjZ1ZMQTA4Q0VrUVNSQllvVEZDd0lrTTJHZ0VYY2dZMkdnRVhjZ1pMQTA4Q0VrUVNSQllvVEZDd0lrTTJHZ0VYY2djMkdnRVhjZ2RMQTA4Q0VrUVNSQ2hNVUxBaVF6WWFBUmR5Q0RZYUFSZHlDRXNEVHdJU1JCSkVLRXhRc0NKRCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
