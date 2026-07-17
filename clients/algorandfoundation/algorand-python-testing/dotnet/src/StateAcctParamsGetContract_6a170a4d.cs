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

namespace Arc56.Generated.algorandfoundation.algorand_python_testing.StateAcctParamsGetContract_6a170a4d
{


    public class StateAcctParamsGetContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public StateAcctParamsGetContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        public async Task<ulong> VerifyAcctBalance(Address a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { a });
            byte aRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 95, 91, 67, 228 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifyAcctBalance_Transactions(Address a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { a });
            byte aRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 95, 91, 67, 228 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<ulong> VerifyAcctMinBalance(Address a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { a });
            byte aRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 115, 220, 147, 199 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifyAcctMinBalance_Transactions(Address a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { a });
            byte aRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 115, 220, 147, 199 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<Algorand.Address> VerifyAcctAuthAddr(Address a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { a });
            byte aRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 86, 38, 223, 235 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> VerifyAcctAuthAddr_Transactions(Address a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { a });
            byte aRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 86, 38, 223, 235 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<ulong> VerifyAcctTotalNumUint(Address a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { a });
            byte aRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 220, 138, 37, 191 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifyAcctTotalNumUint_Transactions(Address a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { a });
            byte aRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 220, 138, 37, 191 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<ulong> VerifyAcctTotalNumByteSlice(Address a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { a });
            byte aRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 25, 142, 189, 140 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifyAcctTotalNumByteSlice_Transactions(Address a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { a });
            byte aRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 25, 142, 189, 140 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<ulong> VerifyAcctTotalExtraAppPages(Address a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { a });
            byte aRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 35, 1, 171, 38 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifyAcctTotalExtraAppPages_Transactions(Address a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { a });
            byte aRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 35, 1, 171, 38 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<ulong> VerifyAcctTotalAppsCreated(Address a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { a });
            byte aRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 159, 104, 252, 166 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifyAcctTotalAppsCreated_Transactions(Address a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { a });
            byte aRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 159, 104, 252, 166 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<ulong> VerifyAcctTotalAppsOptedIn(Address a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { a });
            byte aRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 169, 117, 194, 209 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifyAcctTotalAppsOptedIn_Transactions(Address a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { a });
            byte aRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 169, 117, 194, 209 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<ulong> VerifyAcctTotalAssetsCreated(Address a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { a });
            byte aRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 209, 224, 72, 1 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifyAcctTotalAssetsCreated_Transactions(Address a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { a });
            byte aRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 209, 224, 72, 1 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<ulong> VerifyAcctTotalAssets(Address a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { a });
            byte aRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 182, 150, 107, 229 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifyAcctTotalAssets_Transactions(Address a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { a });
            byte aRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 182, 150, 107, 229 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<ulong> VerifyAcctTotalBoxes(Address a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { a });
            byte aRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 25, 93, 84, 24 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifyAcctTotalBoxes_Transactions(Address a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { a });
            byte aRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 25, 93, 84, 24 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<ulong> VerifyAcctTotalBoxBytes(Address a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { a });
            byte aRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 106, 218, 227, 241 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifyAcctTotalBoxBytes_Transactions(Address a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { a });
            byte aRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 106, 218, 227, 241 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<bool> VerifyAcctIncentiveEligible(Address a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { a });
            byte aRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 223, 140, 254, 229 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifyAcctIncentiveEligible_Transactions(Address a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { a });
            byte aRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 223, 140, 254, 229 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<ulong> VerifyAcctLastHeartbeat(Address a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { a });
            byte aRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 106, 215, 13, 33 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifyAcctLastHeartbeat_Transactions(Address a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { a });
            byte aRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 106, 215, 13, 33 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<ulong> VerifyAcctLastProposed(Address a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { a });
            byte aRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 23, 53, 253, 34 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifyAcctLastProposed_Transactions(Address a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { a });
            byte aRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 23, 53, 253, 34 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3RhdGVBY2N0UGFyYW1zR2V0Q29udHJhY3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoidmVyaWZ5X2FjY3RfYmFsYW5jZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhY2NvdW50Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZlcmlmeV9hY2N0X21pbl9iYWxhbmNlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmVyaWZ5X2FjY3RfYXV0aF9hZGRyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZlcmlmeV9hY2N0X3RvdGFsX251bV91aW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmVyaWZ5X2FjY3RfdG90YWxfbnVtX2J5dGVfc2xpY2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2ZXJpZnlfYWNjdF90b3RhbF9leHRyYV9hcHBfcGFnZXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2ZXJpZnlfYWNjdF90b3RhbF9hcHBzX2NyZWF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2ZXJpZnlfYWNjdF90b3RhbF9hcHBzX29wdGVkX2luIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmVyaWZ5X2FjY3RfdG90YWxfYXNzZXRzX2NyZWF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2ZXJpZnlfYWNjdF90b3RhbF9hc3NldHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2ZXJpZnlfYWNjdF90b3RhbF9ib3hlcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhY2NvdW50Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZlcmlmeV9hY2N0X3RvdGFsX2JveF9ieXRlcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhY2NvdW50Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZlcmlmeV9hY2N0X2luY2VudGl2ZV9lbGlnaWJsZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhY2NvdW50Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2ZXJpZnlfYWNjdF9sYXN0X2hlYXJ0YmVhdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhY2NvdW50Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZlcmlmeV9hY2N0X2xhc3RfcHJvcG9zZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE3MSwyMjVdLCJlcnJvck1lc3NhZ2UiOiJhY2NvdW50IGZ1bmRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3NV0sImVycm9yTWVzc2FnZSI6ImV4cGVjdGVkIEFjY291bnQgYmFsYW5jZSB0byBtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyOV0sImVycm9yTWVzc2FnZSI6ImV4cGVjdGVkIEFjY291bnQgbWluX2JhbGFuY2UgdG8gbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjYsMjIwLDI3MywzMDEsMzMwLDM1OSwzODgsNDE3LDQ0Niw0NzUsNTA0LDUzMyw1NjIsNTk4LDYyN10sImVycm9yTWVzc2FnZSI6ImV4cGVjdGVkIGZ1bmRlZCBieSBpbmRleCB0byBtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5MF0sImVycm9yTWVzc2FnZSI6ImV4cGVjdGVkIG9wLmJhbGFuY2UgYnkgaW5kZXggdG8gbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODFdLCJlcnJvck1lc3NhZ2UiOiJleHBlY3RlZCBvcC5iYWxhbmNlIHRvIG1hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQ0XSwiZXJyb3JNZXNzYWdlIjoiZXhwZWN0ZWQgb3AubWluX2JhbGFuY2UgYnkgaW5kZXggdG8gbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzVdLCJlcnJvck1lc3NhZ2UiOiJleHBlY3RlZCBvcC5taW5fYmFsYW5jZSB0byBtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2NCwyMTgsMjcxLDI5OSwzMjgsMzU3LDM4Niw0MTUsNDQ0LDQ3Myw1MDIsNTMxLDU2MCw1OTYsNjI1XSwiZXJyb3JNZXNzYWdlIjoiZXhwZWN0ZWQgdmFsdWUgYnkgaW5kZXggdG8gbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF4Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0TVRVeFpqZGpOelVLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG95TndvZ0lDQWdMeThnWTJ4aGMzTWdVM1JoZEdWQlkyTjBVR0Z5WVcxelIyVjBRMjl1ZEhKaFkzUW9RVkpETkVOdmJuUnlZV04wTENCaGRtMWZkbVZ5YzJsdmJqMHhNU2s2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBeU1nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE5XWTFZalF6WlRRZ01IZzNNMlJqT1ROak55QXdlRFUyTWpaa1ptVmlJREI0WkdNNFlUSTFZbVlnTUhneE9UaGxZbVE0WXlBd2VESXpNREZoWWpJMklEQjRPV1kyT0daallUWWdNSGhoT1RjMVl6SmtNU0F3ZUdReFpUQTBPREF4SURCNFlqWTVOalppWlRVZ01IZ3hPVFZrTlRReE9DQXdlRFpoWkdGbE0yWXhJREI0WkdZNFkyWmxaVFVnTUhnMllXUTNNR1F5TVNBd2VERTNNelZtWkRJeUlDOHZJRzFsZEdodlpDQWlkbVZ5YVdaNVgyRmpZM1JmWW1Gc1lXNWpaU2hoWTJOdmRXNTBLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlkbVZ5YVdaNVgyRmpZM1JmYldsdVgySmhiR0Z1WTJVb1lXTmpiM1Z1ZENsMWFXNTBOalFpTENCdFpYUm9iMlFnSW5abGNtbG1lVjloWTJOMFgyRjFkR2hmWVdSa2NpaGhZMk52ZFc1MEtXRmtaSEpsYzNNaUxDQnRaWFJvYjJRZ0luWmxjbWxtZVY5aFkyTjBYM1J2ZEdGc1gyNTFiVjkxYVc1MEtHRmpZMjkxYm5RcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKMlpYSnBabmxmWVdOamRGOTBiM1JoYkY5dWRXMWZZbmwwWlY5emJHbGpaU2hoWTJOdmRXNTBLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlkbVZ5YVdaNVgyRmpZM1JmZEc5MFlXeGZaWGgwY21GZllYQndYM0JoWjJWektHRmpZMjkxYm5RcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKMlpYSnBabmxmWVdOamRGOTBiM1JoYkY5aGNIQnpYMk55WldGMFpXUW9ZV05qYjNWdWRDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0luWmxjbWxtZVY5aFkyTjBYM1J2ZEdGc1gyRndjSE5mYjNCMFpXUmZhVzRvWVdOamIzVnVkQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJblpsY21sbWVWOWhZMk4wWDNSdmRHRnNYMkZ6YzJWMGMxOWpjbVZoZEdWa0tHRmpZMjkxYm5RcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKMlpYSnBabmxmWVdOamRGOTBiM1JoYkY5aGMzTmxkSE1vWVdOamIzVnVkQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJblpsY21sbWVWOWhZMk4wWDNSdmRHRnNYMkp2ZUdWektHRmpZMjkxYm5RcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKMlpYSnBabmxmWVdOamRGOTBiM1JoYkY5aWIzaGZZbmwwWlhNb1lXTmpiM1Z1ZENsMWFXNTBOalFpTENCdFpYUm9iMlFnSW5abGNtbG1lVjloWTJOMFgybHVZMlZ1ZEdsMlpWOWxiR2xuYVdKc1pTaGhZMk52ZFc1MEtXSnZiMndpTENCdFpYUm9iMlFnSW5abGNtbG1lVjloWTJOMFgyeGhjM1JmYUdWaGNuUmlaV0YwS0dGalkyOTFiblFwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0oyWlhKcFpubGZZV05qZEY5c1lYTjBYM0J5YjNCdmMyVmtLR0ZqWTI5MWJuUXBkV2x1ZERZMElnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dkbVZ5YVdaNVgyRmpZM1JmWW1Gc1lXNWpaU0IyWlhKcFpubGZZV05qZEY5dGFXNWZZbUZzWVc1alpTQjJaWEpwWm5sZllXTmpkRjloZFhSb1gyRmtaSElnZG1WeWFXWjVYMkZqWTNSZmRHOTBZV3hmYm5WdFgzVnBiblFnZG1WeWFXWjVYMkZqWTNSZmRHOTBZV3hmYm5WdFgySjVkR1ZmYzJ4cFkyVWdkbVZ5YVdaNVgyRmpZM1JmZEc5MFlXeGZaWGgwY21GZllYQndYM0JoWjJWeklIWmxjbWxtZVY5aFkyTjBYM1J2ZEdGc1gyRndjSE5mWTNKbFlYUmxaQ0IyWlhKcFpubGZZV05qZEY5MGIzUmhiRjloY0hCelgyOXdkR1ZrWDJsdUlIWmxjbWxtZVY5aFkyTjBYM1J2ZEdGc1gyRnpjMlYwYzE5amNtVmhkR1ZrSUhabGNtbG1lVjloWTJOMFgzUnZkR0ZzWDJGemMyVjBjeUIyWlhKcFpubGZZV05qZEY5MGIzUmhiRjlpYjNobGN5QjJaWEpwWm5sZllXTmpkRjkwYjNSaGJGOWliM2hmWW5sMFpYTWdkbVZ5YVdaNVgyRmpZM1JmYVc1alpXNTBhWFpsWDJWc2FXZHBZbXhsSUhabGNtbG1lVjloWTJOMFgyeGhjM1JmYUdWaGNuUmlaV0YwSUhabGNtbG1lVjloWTJOMFgyeGhjM1JmY0hKdmNHOXpaV1FLSUNBZ0lHVnljZ29LYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBeU1qb0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNBbUpnb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE11WVhKMGFXWmhZM1J6TGxOMFlYUmxUM0J6TG1OdmJuUnlZV04wTGxOMFlYUmxRV05qZEZCaGNtRnRjMGRsZEVOdmJuUnlZV04wTG5abGNtbG1lVjloWTJOMFgySmhiR0Z1WTJWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDJaWEpwWm5sZllXTmpkRjlpWVd4aGJtTmxPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPakk0Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZ6YjNWeVkyVmZaVzVqYjJScGJtYzlJbWx1WkdWNElpa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRnpJRUZqWTI5MWJuUnpDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZNekFLSUNBZ0lDOHZJSFpoYkhWbExDQm1kVzVrWldRZ1BTQnZjQzVCWTJOMFVHRnlZVzF6UjJWMExtRmpZM1JmWW1Gc1lXNWpaU2hoS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmhZMk4wWDNCaGNtRnRjMTluWlhRZ1FXTmpkRUpoYkdGdVkyVUtJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5VGRHRjBaVTl3Y3k5amIyNTBjbUZqZEM1d2VUb3lOQW9nSUNBZ0x5OGdjbVYwZFhKdUlHOXdMbUowYjJrb1ZIaHVMbUZ3Y0d4cFkyRjBhVzl1WDJGeVozTW9NU2twQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TXpFS0lDQWdJQzh2SUhaaGJIVmxYMmx1WkdWNExDQm1kVzVrWldSZmFXNWtaWGdnUFNCdmNDNUJZMk4wVUdGeVlXMXpSMlYwTG1GalkzUmZZbUZzWVc1alpTaGZaMlYwWHpGemRGOXlaV1pmYVc1a1pYZ29LU2tLSUNBZ0lHRmpZM1JmY0dGeVlXMXpYMmRsZENCQlkyTjBRbUZzWVc1alpRb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qTXlDaUFnSUNBdkx5QmhjM05sY25RZ2RtRnNkV1VnUFQwZ2RtRnNkV1ZmYVc1a1pYZ3NJQ0psZUhCbFkzUmxaQ0IyWVd4MVpTQmllU0JwYm1SbGVDQjBieUJ0WVhSamFDSUtJQ0FnSUdScFp5QXpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdaWGh3WldOMFpXUWdkbUZzZFdVZ1lua2dhVzVrWlhnZ2RHOGdiV0YwWTJnS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRvek13b2dJQ0FnTHk4Z1lYTnpaWEowSUdaMWJtUmxaQ0E5UFNCbWRXNWtaV1JmYVc1a1pYZ3NJQ0psZUhCbFkzUmxaQ0JtZFc1a1pXUWdZbmtnYVc1a1pYZ2dkRzhnYldGMFkyZ2lDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdWNGNHVmpkR1ZrSUdaMWJtUmxaQ0JpZVNCcGJtUmxlQ0IwYnlCdFlYUmphQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPak0wQ2lBZ0lDQXZMeUJoYzNObGNuUWdkbUZzZFdVZ1BUMGdZUzVpWVd4aGJtTmxMQ0FpWlhod1pXTjBaV1FnUVdOamIzVnVkQ0JpWVd4aGJtTmxJSFJ2SUcxaGRHTm9JZ29nSUNBZ1pHbG5JREVLSUNBZ0lHRmpZM1JmY0dGeVlXMXpYMmRsZENCQlkyTjBRbUZzWVc1alpRb2dJQ0FnWVhOelpYSjBJQzh2SUdGalkyOTFiblFnWm5WdVpHVmtDaUFnSUNCa2FXY2dNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCbGVIQmxZM1JsWkNCQlkyTnZkVzUwSUdKaGJHRnVZMlVnZEc4Z2JXRjBZMmdLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG96TlFvZ0lDQWdMeThnWVhOelpYSjBJSFpoYkhWbElEMDlJR0ZzWjI5d2VTNXZjQzVpWVd4aGJtTmxLR0VwTENBaVpYaHdaV04wWldRZ2IzQXVZbUZzWVc1alpTQjBieUJ0WVhSamFDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdKaGJHRnVZMlVLSUNBZ0lHUnBaeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHVjRjR1ZqZEdWa0lHOXdMbUpoYkdGdVkyVWdkRzhnYldGMFkyZ0tJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5VGRHRjBaVTl3Y3k5amIyNTBjbUZqZEM1d2VUb3lOQW9nSUNBZ0x5OGdjbVYwZFhKdUlHOXdMbUowYjJrb1ZIaHVMbUZ3Y0d4cFkyRjBhVzl1WDJGeVozTW9NU2twQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TXpZdE16Z0tJQ0FnSUM4dklHRnpjMlZ5ZENCMllXeDFaU0E5UFNCaGJHZHZjSGt1YjNBdVltRnNZVzVqWlNnS0lDQWdJQzh2SUNBZ0lDQmZaMlYwWHpGemRGOXlaV1pmYVc1a1pYZ29LUW9nSUNBZ0x5OGdLU3dnSW1WNGNHVmpkR1ZrSUc5d0xtSmhiR0Z1WTJVZ1lua2dhVzVrWlhnZ2RHOGdiV0YwWTJnaUNpQWdJQ0JpWVd4aGJtTmxDaUFnSUNCa2FXY2dNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCbGVIQmxZM1JsWkNCdmNDNWlZV3hoYm1ObElHSjVJR2x1WkdWNElIUnZJRzFoZEdOb0NpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12VTNSaGRHVlBjSE12WTI5dWRISmhZM1F1Y0hrNk1qZ0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpYTnZkWEpqWlY5bGJtTnZaR2x1WnowaWFXNWtaWGdpS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekxtRnlkR2xtWVdOMGN5NVRkR0YwWlU5d2N5NWpiMjUwY21GamRDNVRkR0YwWlVGalkzUlFZWEpoYlhOSFpYUkRiMjUwY21GamRDNTJaWEpwWm5sZllXTmpkRjl0YVc1ZlltRnNZVzVqWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuWmxjbWxtZVY5aFkyTjBYMjFwYmw5aVlXeGhibU5sT2dvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMU4wWVhSbFQzQnpMMk52Ym5SeVlXTjBMbkI1T2pReENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WemIzVnlZMlZmWlc1amIyUnBibWM5SW1sdVpHVjRJaWtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUZ6SUVGalkyOTFiblJ6Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TkRNS0lDQWdJQzh2SUhaaGJIVmxMQ0JtZFc1a1pXUWdQU0J2Y0M1QlkyTjBVR0Z5WVcxelIyVjBMbUZqWTNSZmJXbHVYMkpoYkdGdVkyVW9ZU2tLSUNBZ0lHUjFjQW9nSUNBZ1lXTmpkRjl3WVhKaGJYTmZaMlYwSUVGalkzUk5hVzVDWVd4aGJtTmxDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZNalFLSUNBZ0lDOHZJSEpsZEhWeWJpQnZjQzVpZEc5cEtGUjRiaTVoY0hCc2FXTmhkR2x2Ymw5aGNtZHpLREVwS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMU4wWVhSbFQzQnpMMk52Ym5SeVlXTjBMbkI1T2pRMENpQWdJQ0F2THlCMllXeDFaVjlwYm1SbGVDd2dablZ1WkdWa1gybHVaR1Y0SUQwZ2IzQXVRV05qZEZCaGNtRnRjMGRsZEM1aFkyTjBYMjFwYmw5aVlXeGhibU5sS0Y5blpYUmZNWE4wWDNKbFpsOXBibVJsZUNncEtRb2dJQ0FnWVdOamRGOXdZWEpoYlhOZloyVjBJRUZqWTNSTmFXNUNZV3hoYm1ObENpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12VTNSaGRHVlBjSE12WTI5dWRISmhZM1F1Y0hrNk5EVUtJQ0FnSUM4dklHRnpjMlZ5ZENCMllXeDFaU0E5UFNCMllXeDFaVjlwYm1SbGVDd2dJbVY0Y0dWamRHVmtJSFpoYkhWbElHSjVJR2x1WkdWNElIUnZJRzFoZEdOb0lnb2dJQ0FnWkdsbklETUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmxlSEJsWTNSbFpDQjJZV3gxWlNCaWVTQnBibVJsZUNCMGJ5QnRZWFJqYUFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMU4wWVhSbFQzQnpMMk52Ym5SeVlXTjBMbkI1T2pRMkNpQWdJQ0F2THlCaGMzTmxjblFnWm5WdVpHVmtJRDA5SUdaMWJtUmxaRjlwYm1SbGVDd2dJbVY0Y0dWamRHVmtJR1oxYm1SbFpDQmllU0JwYm1SbGVDQjBieUJ0WVhSamFDSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnWlhod1pXTjBaV1FnWm5WdVpHVmtJR0o1SUdsdVpHVjRJSFJ2SUcxaGRHTm9DaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZORGNLSUNBZ0lDOHZJR0Z6YzJWeWRDQjJZV3gxWlNBOVBTQmhMbTFwYmw5aVlXeGhibU5sTENBaVpYaHdaV04wWldRZ1FXTmpiM1Z1ZENCdGFXNWZZbUZzWVc1alpTQjBieUJ0WVhSamFDSUtJQ0FnSUdScFp5QXhDaUFnSUNCaFkyTjBYM0JoY21GdGMxOW5aWFFnUVdOamRFMXBia0poYkdGdVkyVUtJQ0FnSUdGemMyVnlkQ0F2THlCaFkyTnZkVzUwSUdaMWJtUmxaQW9nSUNBZ1pHbG5JREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1pYaHdaV04wWldRZ1FXTmpiM1Z1ZENCdGFXNWZZbUZzWVc1alpTQjBieUJ0WVhSamFBb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qUTRDaUFnSUNBdkx5QmhjM05sY25RZ2RtRnNkV1VnUFQwZ1lXeG5iM0I1TG05d0xtMXBibDlpWVd4aGJtTmxLR0VwTENBaVpYaHdaV04wWldRZ2IzQXViV2x1WDJKaGJHRnVZMlVnZEc4Z2JXRjBZMmdpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnRhVzVmWW1Gc1lXNWpaUW9nSUNBZ1pHbG5JREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1pYaHdaV04wWldRZ2IzQXViV2x1WDJKaGJHRnVZMlVnZEc4Z2JXRjBZMmdLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG95TkFvZ0lDQWdMeThnY21WMGRYSnVJRzl3TG1KMGIya29WSGh1TG1Gd2NHeHBZMkYwYVc5dVgyRnlaM01vTVNrcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12VTNSaGRHVlBjSE12WTI5dWRISmhZM1F1Y0hrNk5Ea3ROVEVLSUNBZ0lDOHZJR0Z6YzJWeWRDQjJZV3gxWlNBOVBTQmhiR2R2Y0hrdWIzQXViV2x1WDJKaGJHRnVZMlVvQ2lBZ0lDQXZMeUFnSUNBZ1gyZGxkRjh4YzNSZmNtVm1YMmx1WkdWNEtDa0tJQ0FnSUM4dklDa3NJQ0psZUhCbFkzUmxaQ0J2Y0M1dGFXNWZZbUZzWVc1alpTQmllU0JwYm1SbGVDQjBieUJ0WVhSamFDSUtJQ0FnSUcxcGJsOWlZV3hoYm1ObENpQWdJQ0JrYVdjZ01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJsZUhCbFkzUmxaQ0J2Y0M1dGFXNWZZbUZzWVc1alpTQmllU0JwYm1SbGVDQjBieUJ0WVhSamFBb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qUXhDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVnpiM1Z5WTJWZlpXNWpiMlJwYm1jOUltbHVaR1Y0SWlrS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5NWhjblJwWm1GamRITXVVM1JoZEdWUGNITXVZMjl1ZEhKaFkzUXVVM1JoZEdWQlkyTjBVR0Z5WVcxelIyVjBRMjl1ZEhKaFkzUXVkbVZ5YVdaNVgyRmpZM1JmWVhWMGFGOWhaR1J5VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RtVnlhV1o1WDJGalkzUmZZWFYwYUY5aFpHUnlPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPalUwQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZ6YjNWeVkyVmZaVzVqYjJScGJtYzlJbWx1WkdWNElpa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRnpJRUZqWTI5MWJuUnpDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZOVFlLSUNBZ0lDOHZJSFpoYkhWbExDQm1kVzVrWldRZ1BTQnZjQzVCWTJOMFVHRnlZVzF6UjJWMExtRmpZM1JmWVhWMGFGOWhaR1J5S0dFcENpQWdJQ0JoWTJOMFgzQmhjbUZ0YzE5blpYUWdRV05qZEVGMWRHaEJaR1J5Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TWpRS0lDQWdJQzh2SUhKbGRIVnliaUJ2Y0M1aWRHOXBLRlI0Ymk1aGNIQnNhV05oZEdsdmJsOWhjbWR6S0RFcEtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qVTNDaUFnSUNBdkx5QjJZV3gxWlY5cGJtUmxlQ3dnWm5WdVpHVmtYMmx1WkdWNElEMGdiM0F1UVdOamRGQmhjbUZ0YzBkbGRDNWhZMk4wWDJGMWRHaGZZV1JrY2loZloyVjBYekZ6ZEY5eVpXWmZhVzVrWlhnb0tTa0tJQ0FnSUdGalkzUmZjR0Z5WVcxelgyZGxkQ0JCWTJOMFFYVjBhRUZrWkhJS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRvMU9Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhaaGJIVmxJRDA5SUhaaGJIVmxYMmx1WkdWNExDQWlaWGh3WldOMFpXUWdkbUZzZFdVZ1lua2dhVzVrWlhnZ2RHOGdiV0YwWTJnaUNpQWdJQ0JrYVdjZ013b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHVjRjR1ZqZEdWa0lIWmhiSFZsSUdKNUlHbHVaR1Y0SUhSdklHMWhkR05vQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TlRrS0lDQWdJQzh2SUdGemMyVnlkQ0JtZFc1a1pXUWdQVDBnWm5WdVpHVmtYMmx1WkdWNExDQWlaWGh3WldOMFpXUWdablZ1WkdWa0lHSjVJR2x1WkdWNElIUnZJRzFoZEdOb0lnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJsZUhCbFkzUmxaQ0JtZFc1a1pXUWdZbmtnYVc1a1pYZ2dkRzhnYldGMFkyZ0tJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5VGRHRjBaVTl3Y3k5amIyNTBjbUZqZEM1d2VUbzFOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxjMjkxY21ObFgyVnVZMjlrYVc1blBTSnBibVJsZUNJcENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXVZWEowYVdaaFkzUnpMbE4wWVhSbFQzQnpMbU52Ym5SeVlXTjBMbE4wWVhSbFFXTmpkRkJoY21GdGMwZGxkRU52Ym5SeVlXTjBMblpsY21sbWVWOWhZMk4wWDNSdmRHRnNYMjUxYlY5MWFXNTBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZG1WeWFXWjVYMkZqWTNSZmRHOTBZV3hmYm5WdFgzVnBiblE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TmpJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WlhOdmRYSmpaVjlsYm1OdlpHbHVaejBpYVc1a1pYZ2lLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZWE1nUVdOamIzVnVkSE1LSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG8yTkFvZ0lDQWdMeThnZG1Gc2RXVXNJR1oxYm1SbFpDQTlJRzl3TGtGalkzUlFZWEpoYlhOSFpYUXVZV05qZEY5MGIzUmhiRjl1ZFcxZmRXbHVkQ2hoS1FvZ0lDQWdZV05qZEY5d1lYSmhiWE5mWjJWMElFRmpZM1JVYjNSaGJFNTFiVlZwYm5RS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRveU5Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUc5d0xtSjBiMmtvVkhodUxtRndjR3hwWTJGMGFXOXVYMkZ5WjNNb01Ta3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZOalVLSUNBZ0lDOHZJSFpoYkhWbFgybHVaR1Y0TENCbWRXNWtaV1JmYVc1a1pYZ2dQU0J2Y0M1QlkyTjBVR0Z5WVcxelIyVjBMbUZqWTNSZmRHOTBZV3hmYm5WdFgzVnBiblFvWDJkbGRGOHhjM1JmY21WbVgybHVaR1Y0S0NrcENpQWdJQ0JoWTJOMFgzQmhjbUZ0YzE5blpYUWdRV05qZEZSdmRHRnNUblZ0VldsdWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qWTJDaUFnSUNBdkx5QmhjM05sY25RZ2RtRnNkV1VnUFQwZ2RtRnNkV1ZmYVc1a1pYZ3NJQ0psZUhCbFkzUmxaQ0IyWVd4MVpTQmllU0JwYm1SbGVDQjBieUJ0WVhSamFDSUtJQ0FnSUdScFp5QXpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdaWGh3WldOMFpXUWdkbUZzZFdVZ1lua2dhVzVrWlhnZ2RHOGdiV0YwWTJnS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRvMk53b2dJQ0FnTHk4Z1lYTnpaWEowSUdaMWJtUmxaQ0E5UFNCbWRXNWtaV1JmYVc1a1pYZ3NJQ0psZUhCbFkzUmxaQ0JtZFc1a1pXUWdZbmtnYVc1a1pYZ2dkRzhnYldGMFkyZ2lDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdWNGNHVmpkR1ZrSUdaMWJtUmxaQ0JpZVNCcGJtUmxlQ0IwYnlCdFlYUmphQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPall5Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZ6YjNWeVkyVmZaVzVqYjJScGJtYzlJbWx1WkdWNElpa0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTVoY25ScFptRmpkSE11VTNSaGRHVlBjSE11WTI5dWRISmhZM1F1VTNSaGRHVkJZMk4wVUdGeVlXMXpSMlYwUTI5dWRISmhZM1F1ZG1WeWFXWjVYMkZqWTNSZmRHOTBZV3hmYm5WdFgySjVkR1ZmYzJ4cFkyVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AyWlhKcFpubGZZV05qZEY5MGIzUmhiRjl1ZFcxZllubDBaVjl6YkdsalpUb0tJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5VGRHRjBaVTl3Y3k5amIyNTBjbUZqZEM1d2VUbzNNQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxjMjkxY21ObFgyVnVZMjlrYVc1blBTSnBibVJsZUNJcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aGN5QkJZMk52ZFc1MGN3b2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qY3lDaUFnSUNBdkx5QjJZV3gxWlN3Z1puVnVaR1ZrSUQwZ2IzQXVRV05qZEZCaGNtRnRjMGRsZEM1aFkyTjBYM1J2ZEdGc1gyNTFiVjlpZVhSbFgzTnNhV05sS0dFcENpQWdJQ0JoWTJOMFgzQmhjbUZ0YzE5blpYUWdRV05qZEZSdmRHRnNUblZ0UW5sMFpWTnNhV05sQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TWpRS0lDQWdJQzh2SUhKbGRIVnliaUJ2Y0M1aWRHOXBLRlI0Ymk1aGNIQnNhV05oZEdsdmJsOWhjbWR6S0RFcEtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qY3pMVGMxQ2lBZ0lDQXZMeUIyWVd4MVpWOXBibVJsZUN3Z1puVnVaR1ZrWDJsdVpHVjRJRDBnYjNBdVFXTmpkRkJoY21GdGMwZGxkQzVoWTJOMFgzUnZkR0ZzWDI1MWJWOWllWFJsWDNOc2FXTmxLQW9nSUNBZ0x5OGdJQ0FnSUY5blpYUmZNWE4wWDNKbFpsOXBibVJsZUNncENpQWdJQ0F2THlBcENpQWdJQ0JoWTJOMFgzQmhjbUZ0YzE5blpYUWdRV05qZEZSdmRHRnNUblZ0UW5sMFpWTnNhV05sQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TnpZS0lDQWdJQzh2SUdGemMyVnlkQ0IyWVd4MVpTQTlQU0IyWVd4MVpWOXBibVJsZUN3Z0ltVjRjR1ZqZEdWa0lIWmhiSFZsSUdKNUlHbHVaR1Y0SUhSdklHMWhkR05vSWdvZ0lDQWdaR2xuSURNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCbGVIQmxZM1JsWkNCMllXeDFaU0JpZVNCcGJtUmxlQ0IwYnlCdFlYUmphQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPamMzQ2lBZ0lDQXZMeUJoYzNObGNuUWdablZ1WkdWa0lEMDlJR1oxYm1SbFpGOXBibVJsZUN3Z0ltVjRjR1ZqZEdWa0lHWjFibVJsWkNCaWVTQnBibVJsZUNCMGJ5QnRZWFJqYUNJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdaWGh3WldOMFpXUWdablZ1WkdWa0lHSjVJR2x1WkdWNElIUnZJRzFoZEdOb0NpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12VTNSaGRHVlBjSE12WTI5dWRISmhZM1F1Y0hrNk56QUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpYTnZkWEpqWlY5bGJtTnZaR2x1WnowaWFXNWtaWGdpS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekxtRnlkR2xtWVdOMGN5NVRkR0YwWlU5d2N5NWpiMjUwY21GamRDNVRkR0YwWlVGalkzUlFZWEpoYlhOSFpYUkRiMjUwY21GamRDNTJaWEpwWm5sZllXTmpkRjkwYjNSaGJGOWxlSFJ5WVY5aGNIQmZjR0ZuWlhOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDJaWEpwWm5sZllXTmpkRjkwYjNSaGJGOWxlSFJ5WVY5aGNIQmZjR0ZuWlhNNkNpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12VTNSaGRHVlBjSE12WTI5dWRISmhZM1F1Y0hrNk9EQUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpYTnZkWEpqWlY5bGJtTnZaR2x1WnowaWFXNWtaWGdpS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVhNZ1FXTmpiM1Z1ZEhNS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRvNE1nb2dJQ0FnTHk4Z2RtRnNkV1VzSUdaMWJtUmxaQ0E5SUc5d0xrRmpZM1JRWVhKaGJYTkhaWFF1WVdOamRGOTBiM1JoYkY5bGVIUnlZVjloY0hCZmNHRm5aWE1vWVNrS0lDQWdJR0ZqWTNSZmNHRnlZVzF6WDJkbGRDQkJZMk4wVkc5MFlXeEZlSFJ5WVVGd2NGQmhaMlZ6Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TWpRS0lDQWdJQzh2SUhKbGRIVnliaUJ2Y0M1aWRHOXBLRlI0Ymk1aGNIQnNhV05oZEdsdmJsOWhjbWR6S0RFcEtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qZ3pMVGcxQ2lBZ0lDQXZMeUIyWVd4MVpWOXBibVJsZUN3Z1puVnVaR1ZrWDJsdVpHVjRJRDBnYjNBdVFXTmpkRkJoY21GdGMwZGxkQzVoWTJOMFgzUnZkR0ZzWDJWNGRISmhYMkZ3Y0Y5d1lXZGxjeWdLSUNBZ0lDOHZJQ0FnSUNCZloyVjBYekZ6ZEY5eVpXWmZhVzVrWlhnb0tRb2dJQ0FnTHk4Z0tRb2dJQ0FnWVdOamRGOXdZWEpoYlhOZloyVjBJRUZqWTNSVWIzUmhiRVY0ZEhKaFFYQndVR0ZuWlhNS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRvNE5nb2dJQ0FnTHk4Z1lYTnpaWEowSUhaaGJIVmxJRDA5SUhaaGJIVmxYMmx1WkdWNExDQWlaWGh3WldOMFpXUWdkbUZzZFdVZ1lua2dhVzVrWlhnZ2RHOGdiV0YwWTJnaUNpQWdJQ0JrYVdjZ013b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHVjRjR1ZqZEdWa0lIWmhiSFZsSUdKNUlHbHVaR1Y0SUhSdklHMWhkR05vQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2T0RjS0lDQWdJQzh2SUdGemMyVnlkQ0JtZFc1a1pXUWdQVDBnWm5WdVpHVmtYMmx1WkdWNExDQWlaWGh3WldOMFpXUWdablZ1WkdWa0lHSjVJR2x1WkdWNElIUnZJRzFoZEdOb0lnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJsZUhCbFkzUmxaQ0JtZFc1a1pXUWdZbmtnYVc1a1pYZ2dkRzhnYldGMFkyZ0tJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5VGRHRjBaVTl3Y3k5amIyNTBjbUZqZEM1d2VUbzRNQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxjMjkxY21ObFgyVnVZMjlrYVc1blBTSnBibVJsZUNJcENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXVZWEowYVdaaFkzUnpMbE4wWVhSbFQzQnpMbU52Ym5SeVlXTjBMbE4wWVhSbFFXTmpkRkJoY21GdGMwZGxkRU52Ym5SeVlXTjBMblpsY21sbWVWOWhZMk4wWDNSdmRHRnNYMkZ3Y0hOZlkzSmxZWFJsWkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuWmxjbWxtZVY5aFkyTjBYM1J2ZEdGc1gyRndjSE5mWTNKbFlYUmxaRG9LSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG81TUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsYzI5MWNtTmxYMlZ1WTI5a2FXNW5QU0pwYm1SbGVDSXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhjeUJCWTJOdmRXNTBjd29nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPamt5Q2lBZ0lDQXZMeUIyWVd4MVpTd2dablZ1WkdWa0lEMGdiM0F1UVdOamRGQmhjbUZ0YzBkbGRDNWhZMk4wWDNSdmRHRnNYMkZ3Y0hOZlkzSmxZWFJsWkNoaEtRb2dJQ0FnWVdOamRGOXdZWEpoYlhOZloyVjBJRUZqWTNSVWIzUmhiRUZ3Y0hORGNtVmhkR1ZrQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TWpRS0lDQWdJQzh2SUhKbGRIVnliaUJ2Y0M1aWRHOXBLRlI0Ymk1aGNIQnNhV05oZEdsdmJsOWhjbWR6S0RFcEtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qa3pDaUFnSUNBdkx5QjJZV3gxWlY5cGJtUmxlQ3dnWm5WdVpHVmtYMmx1WkdWNElEMGdiM0F1UVdOamRGQmhjbUZ0YzBkbGRDNWhZMk4wWDNSdmRHRnNYMkZ3Y0hOZlkzSmxZWFJsWkNoZloyVjBYekZ6ZEY5eVpXWmZhVzVrWlhnb0tTa0tJQ0FnSUdGalkzUmZjR0Z5WVcxelgyZGxkQ0JCWTJOMFZHOTBZV3hCY0hCelEzSmxZWFJsWkFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMU4wWVhSbFQzQnpMMk52Ym5SeVlXTjBMbkI1T2prMENpQWdJQ0F2THlCaGMzTmxjblFnZG1Gc2RXVWdQVDBnZG1Gc2RXVmZhVzVrWlhnc0lDSmxlSEJsWTNSbFpDQjJZV3gxWlNCaWVTQnBibVJsZUNCMGJ5QnRZWFJqYUNJS0lDQWdJR1JwWnlBekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1pYaHdaV04wWldRZ2RtRnNkV1VnWW5rZ2FXNWtaWGdnZEc4Z2JXRjBZMmdLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG81TlFvZ0lDQWdMeThnWVhOelpYSjBJR1oxYm1SbFpDQTlQU0JtZFc1a1pXUmZhVzVrWlhnc0lDSmxlSEJsWTNSbFpDQm1kVzVrWldRZ1lua2dhVzVrWlhnZ2RHOGdiV0YwWTJnaUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR1Y0Y0dWamRHVmtJR1oxYm1SbFpDQmllU0JwYm1SbGVDQjBieUJ0WVhSamFBb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qa3dDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVnpiM1Z5WTJWZlpXNWpiMlJwYm1jOUltbHVaR1Y0SWlrS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5NWhjblJwWm1GamRITXVVM1JoZEdWUGNITXVZMjl1ZEhKaFkzUXVVM1JoZEdWQlkyTjBVR0Z5WVcxelIyVjBRMjl1ZEhKaFkzUXVkbVZ5YVdaNVgyRmpZM1JmZEc5MFlXeGZZWEJ3YzE5dmNIUmxaRjlwYmx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuWmxjbWxtZVY5aFkyTjBYM1J2ZEdGc1gyRndjSE5mYjNCMFpXUmZhVzQ2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2T1RnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WlhOdmRYSmpaVjlsYm1OdlpHbHVaejBpYVc1a1pYZ2lLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZWE1nUVdOamIzVnVkSE1LSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG94TURBS0lDQWdJQzh2SUhaaGJIVmxMQ0JtZFc1a1pXUWdQU0J2Y0M1QlkyTjBVR0Z5WVcxelIyVjBMbUZqWTNSZmRHOTBZV3hmWVhCd2MxOXZjSFJsWkY5cGJpaGhLUW9nSUNBZ1lXTmpkRjl3WVhKaGJYTmZaMlYwSUVGalkzUlViM1JoYkVGd2NITlBjSFJsWkVsdUNpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12VTNSaGRHVlBjSE12WTI5dWRISmhZM1F1Y0hrNk1qUUtJQ0FnSUM4dklISmxkSFZ5YmlCdmNDNWlkRzlwS0ZSNGJpNWhjSEJzYVdOaGRHbHZibDloY21kektERXBLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPakV3TVFvZ0lDQWdMeThnZG1Gc2RXVmZhVzVrWlhnc0lHWjFibVJsWkY5cGJtUmxlQ0E5SUc5d0xrRmpZM1JRWVhKaGJYTkhaWFF1WVdOamRGOTBiM1JoYkY5aGNIQnpYMjl3ZEdWa1gybHVLRjluWlhSZk1YTjBYM0psWmw5cGJtUmxlQ2dwS1FvZ0lDQWdZV05qZEY5d1lYSmhiWE5mWjJWMElFRmpZM1JVYjNSaGJFRndjSE5QY0hSbFpFbHVDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZNVEF5Q2lBZ0lDQXZMeUJoYzNObGNuUWdkbUZzZFdVZ1BUMGdkbUZzZFdWZmFXNWtaWGdzSUNKbGVIQmxZM1JsWkNCMllXeDFaU0JpZVNCcGJtUmxlQ0IwYnlCdFlYUmphQ0lLSUNBZ0lHUnBaeUF6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnWlhod1pXTjBaV1FnZG1Gc2RXVWdZbmtnYVc1a1pYZ2dkRzhnYldGMFkyZ0tJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5VGRHRjBaVTl3Y3k5amIyNTBjbUZqZEM1d2VUb3hNRE1LSUNBZ0lDOHZJR0Z6YzJWeWRDQm1kVzVrWldRZ1BUMGdablZ1WkdWa1gybHVaR1Y0TENBaVpYaHdaV04wWldRZ1puVnVaR1ZrSUdKNUlHbHVaR1Y0SUhSdklHMWhkR05vSWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmxlSEJsWTNSbFpDQm1kVzVrWldRZ1lua2dhVzVrWlhnZ2RHOGdiV0YwWTJnS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRvNU9Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbGMyOTFjbU5sWDJWdVkyOWthVzVuUFNKcGJtUmxlQ0lwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdVlYSjBhV1poWTNSekxsTjBZWFJsVDNCekxtTnZiblJ5WVdOMExsTjBZWFJsUVdOamRGQmhjbUZ0YzBkbGRFTnZiblJ5WVdOMExuWmxjbWxtZVY5aFkyTjBYM1J2ZEdGc1gyRnpjMlYwYzE5amNtVmhkR1ZrVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RtVnlhV1o1WDJGalkzUmZkRzkwWVd4ZllYTnpaWFJ6WDJOeVpXRjBaV1E2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TVRBMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WemIzVnlZMlZmWlc1amIyUnBibWM5SW1sdVpHVjRJaWtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUZ6SUVGalkyOTFiblJ6Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TVRBNENpQWdJQ0F2THlCMllXeDFaU3dnWm5WdVpHVmtJRDBnYjNBdVFXTmpkRkJoY21GdGMwZGxkQzVoWTJOMFgzUnZkR0ZzWDJGemMyVjBjMTlqY21WaGRHVmtLR0VwQ2lBZ0lDQmhZMk4wWDNCaGNtRnRjMTluWlhRZ1FXTmpkRlJ2ZEdGc1FYTnpaWFJ6UTNKbFlYUmxaQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPakkwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdiM0F1WW5SdmFTaFVlRzR1WVhCd2JHbGpZWFJwYjI1ZllYSm5jeWd4S1NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRveE1Ea3RNVEV4Q2lBZ0lDQXZMeUIyWVd4MVpWOXBibVJsZUN3Z1puVnVaR1ZrWDJsdVpHVjRJRDBnYjNBdVFXTmpkRkJoY21GdGMwZGxkQzVoWTJOMFgzUnZkR0ZzWDJGemMyVjBjMTlqY21WaGRHVmtLQW9nSUNBZ0x5OGdJQ0FnSUY5blpYUmZNWE4wWDNKbFpsOXBibVJsZUNncENpQWdJQ0F2THlBcENpQWdJQ0JoWTJOMFgzQmhjbUZ0YzE5blpYUWdRV05qZEZSdmRHRnNRWE56WlhSelEzSmxZWFJsWkFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMU4wWVhSbFQzQnpMMk52Ym5SeVlXTjBMbkI1T2pFeE1nb2dJQ0FnTHk4Z1lYTnpaWEowSUhaaGJIVmxJRDA5SUhaaGJIVmxYMmx1WkdWNExDQWlaWGh3WldOMFpXUWdkbUZzZFdVZ1lua2dhVzVrWlhnZ2RHOGdiV0YwWTJnaUNpQWdJQ0JrYVdjZ013b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHVjRjR1ZqZEdWa0lIWmhiSFZsSUdKNUlHbHVaR1Y0SUhSdklHMWhkR05vQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TVRFekNpQWdJQ0F2THlCaGMzTmxjblFnWm5WdVpHVmtJRDA5SUdaMWJtUmxaRjlwYm1SbGVDd2dJbVY0Y0dWamRHVmtJR1oxYm1SbFpDQmllU0JwYm1SbGVDQjBieUJ0WVhSamFDSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnWlhod1pXTjBaV1FnWm5WdVpHVmtJR0o1SUdsdVpHVjRJSFJ2SUcxaGRHTm9DaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZNVEEyQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZ6YjNWeVkyVmZaVzVqYjJScGJtYzlJbWx1WkdWNElpa0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTVoY25ScFptRmpkSE11VTNSaGRHVlBjSE11WTI5dWRISmhZM1F1VTNSaGRHVkJZMk4wVUdGeVlXMXpSMlYwUTI5dWRISmhZM1F1ZG1WeWFXWjVYMkZqWTNSZmRHOTBZV3hmWVhOelpYUnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZG1WeWFXWjVYMkZqWTNSZmRHOTBZV3hmWVhOelpYUnpPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPakV4TmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsYzI5MWNtTmxYMlZ1WTI5a2FXNW5QU0pwYm1SbGVDSXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhjeUJCWTJOdmRXNTBjd29nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPakV4T0FvZ0lDQWdMeThnZG1Gc2RXVXNJR1oxYm1SbFpDQTlJRzl3TGtGalkzUlFZWEpoYlhOSFpYUXVZV05qZEY5MGIzUmhiRjloYzNObGRITW9ZU2tLSUNBZ0lHRmpZM1JmY0dGeVlXMXpYMmRsZENCQlkyTjBWRzkwWVd4QmMzTmxkSE1LSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG95TkFvZ0lDQWdMeThnY21WMGRYSnVJRzl3TG1KMGIya29WSGh1TG1Gd2NHeHBZMkYwYVc5dVgyRnlaM01vTVNrcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12VTNSaGRHVlBjSE12WTI5dWRISmhZM1F1Y0hrNk1URTVDaUFnSUNBdkx5QjJZV3gxWlY5cGJtUmxlQ3dnWm5WdVpHVmtYMmx1WkdWNElEMGdiM0F1UVdOamRGQmhjbUZ0YzBkbGRDNWhZMk4wWDNSdmRHRnNYMkZ6YzJWMGN5aGZaMlYwWHpGemRGOXlaV1pmYVc1a1pYZ29LU2tLSUNBZ0lHRmpZM1JmY0dGeVlXMXpYMmRsZENCQlkyTjBWRzkwWVd4QmMzTmxkSE1LSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG94TWpBS0lDQWdJQzh2SUdGemMyVnlkQ0IyWVd4MVpTQTlQU0IyWVd4MVpWOXBibVJsZUN3Z0ltVjRjR1ZqZEdWa0lIWmhiSFZsSUdKNUlHbHVaR1Y0SUhSdklHMWhkR05vSWdvZ0lDQWdaR2xuSURNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCbGVIQmxZM1JsWkNCMllXeDFaU0JpZVNCcGJtUmxlQ0IwYnlCdFlYUmphQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPakV5TVFvZ0lDQWdMeThnWVhOelpYSjBJR1oxYm1SbFpDQTlQU0JtZFc1a1pXUmZhVzVrWlhnc0lDSmxlSEJsWTNSbFpDQm1kVzVrWldRZ1lua2dhVzVrWlhnZ2RHOGdiV0YwWTJnaUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR1Y0Y0dWamRHVmtJR1oxYm1SbFpDQmllU0JwYm1SbGVDQjBieUJ0WVhSamFBb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qRXhOZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxjMjkxY21ObFgyVnVZMjlrYVc1blBTSnBibVJsZUNJcENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXVZWEowYVdaaFkzUnpMbE4wWVhSbFQzQnpMbU52Ym5SeVlXTjBMbE4wWVhSbFFXTmpkRkJoY21GdGMwZGxkRU52Ym5SeVlXTjBMblpsY21sbWVWOWhZMk4wWDNSdmRHRnNYMkp2ZUdWelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkbVZ5YVdaNVgyRmpZM1JmZEc5MFlXeGZZbTk0WlhNNkNpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12VTNSaGRHVlBjSE12WTI5dWRISmhZM1F1Y0hrNk1USTBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVnpiM1Z5WTJWZlpXNWpiMlJwYm1jOUltbHVaR1Y0SWlrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1GeklFRmpZMjkxYm5SekNpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12VTNSaGRHVlBjSE12WTI5dWRISmhZM1F1Y0hrNk1USTJDaUFnSUNBdkx5QjJZV3gxWlN3Z1puVnVaR1ZrSUQwZ2IzQXVRV05qZEZCaGNtRnRjMGRsZEM1aFkyTjBYM1J2ZEdGc1gySnZlR1Z6S0dFcENpQWdJQ0JoWTJOMFgzQmhjbUZ0YzE5blpYUWdRV05qZEZSdmRHRnNRbTk0WlhNS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRveU5Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUc5d0xtSjBiMmtvVkhodUxtRndjR3hwWTJGMGFXOXVYMkZ5WjNNb01Ta3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZNVEkzQ2lBZ0lDQXZMeUIyWVd4MVpWOXBibVJsZUN3Z1puVnVaR1ZrWDJsdVpHVjRJRDBnYjNBdVFXTmpkRkJoY21GdGMwZGxkQzVoWTJOMFgzUnZkR0ZzWDJKdmVHVnpLRjluWlhSZk1YTjBYM0psWmw5cGJtUmxlQ2dwS1FvZ0lDQWdZV05qZEY5d1lYSmhiWE5mWjJWMElFRmpZM1JVYjNSaGJFSnZlR1Z6Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TVRJNENpQWdJQ0F2THlCaGMzTmxjblFnZG1Gc2RXVWdQVDBnZG1Gc2RXVmZhVzVrWlhnc0lDSmxlSEJsWTNSbFpDQjJZV3gxWlNCaWVTQnBibVJsZUNCMGJ5QnRZWFJqYUNJS0lDQWdJR1JwWnlBekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1pYaHdaV04wWldRZ2RtRnNkV1VnWW5rZ2FXNWtaWGdnZEc4Z2JXRjBZMmdLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG94TWprS0lDQWdJQzh2SUdGemMyVnlkQ0JtZFc1a1pXUWdQVDBnWm5WdVpHVmtYMmx1WkdWNExDQWlaWGh3WldOMFpXUWdablZ1WkdWa0lHSjVJR2x1WkdWNElIUnZJRzFoZEdOb0lnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJsZUhCbFkzUmxaQ0JtZFc1a1pXUWdZbmtnYVc1a1pYZ2dkRzhnYldGMFkyZ0tJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5VGRHRjBaVTl3Y3k5amIyNTBjbUZqZEM1d2VUb3hNalFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaWE52ZFhKalpWOWxibU52WkdsdVp6MGlhVzVrWlhnaUtRb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMbUZ5ZEdsbVlXTjBjeTVUZEdGMFpVOXdjeTVqYjI1MGNtRmpkQzVUZEdGMFpVRmpZM1JRWVhKaGJYTkhaWFJEYjI1MGNtRmpkQzUyWlhKcFpubGZZV05qZEY5MGIzUmhiRjlpYjNoZllubDBaWE5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMlpYSnBabmxmWVdOamRGOTBiM1JoYkY5aWIzaGZZbmwwWlhNNkNpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12VTNSaGRHVlBjSE12WTI5dWRISmhZM1F1Y0hrNk1UTXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVnpiM1Z5WTJWZlpXNWpiMlJwYm1jOUltbHVaR1Y0SWlrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1GeklFRmpZMjkxYm5SekNpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12VTNSaGRHVlBjSE12WTI5dWRISmhZM1F1Y0hrNk1UTTBDaUFnSUNBdkx5QjJZV3gxWlN3Z1puVnVaR1ZrSUQwZ2IzQXVRV05qZEZCaGNtRnRjMGRsZEM1aFkyTjBYM1J2ZEdGc1gySnZlRjlpZVhSbGN5aGhLUW9nSUNBZ1lXTmpkRjl3WVhKaGJYTmZaMlYwSUVGalkzUlViM1JoYkVKdmVFSjVkR1Z6Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TWpRS0lDQWdJQzh2SUhKbGRIVnliaUJ2Y0M1aWRHOXBLRlI0Ymk1aGNIQnNhV05oZEdsdmJsOWhjbWR6S0RFcEtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qRXpOUW9nSUNBZ0x5OGdkbUZzZFdWZmFXNWtaWGdzSUdaMWJtUmxaRjlwYm1SbGVDQTlJRzl3TGtGalkzUlFZWEpoYlhOSFpYUXVZV05qZEY5MGIzUmhiRjlpYjNoZllubDBaWE1vWDJkbGRGOHhjM1JmY21WbVgybHVaR1Y0S0NrcENpQWdJQ0JoWTJOMFgzQmhjbUZ0YzE5blpYUWdRV05qZEZSdmRHRnNRbTk0UW5sMFpYTUtJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5VGRHRjBaVTl3Y3k5amIyNTBjbUZqZEM1d2VUb3hNellLSUNBZ0lDOHZJR0Z6YzJWeWRDQjJZV3gxWlNBOVBTQjJZV3gxWlY5cGJtUmxlQ3dnSW1WNGNHVmpkR1ZrSUhaaGJIVmxJR0o1SUdsdVpHVjRJSFJ2SUcxaGRHTm9JZ29nSUNBZ1pHbG5JRE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJsZUhCbFkzUmxaQ0IyWVd4MVpTQmllU0JwYm1SbGVDQjBieUJ0WVhSamFBb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qRXpOd29nSUNBZ0x5OGdZWE56WlhKMElHWjFibVJsWkNBOVBTQm1kVzVrWldSZmFXNWtaWGdzSUNKbGVIQmxZM1JsWkNCbWRXNWtaV1FnWW5rZ2FXNWtaWGdnZEc4Z2JXRjBZMmdpQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHVjRjR1ZqZEdWa0lHWjFibVJsWkNCaWVTQnBibVJsZUNCMGJ5QnRZWFJqYUFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMU4wWVhSbFQzQnpMMk52Ym5SeVlXTjBMbkI1T2pFek1nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbGMyOTFjbU5sWDJWdVkyOWthVzVuUFNKcGJtUmxlQ0lwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdVlYSjBhV1poWTNSekxsTjBZWFJsVDNCekxtTnZiblJ5WVdOMExsTjBZWFJsUVdOamRGQmhjbUZ0YzBkbGRFTnZiblJ5WVdOMExuWmxjbWxtZVY5aFkyTjBYMmx1WTJWdWRHbDJaVjlsYkdsbmFXSnNaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25abGNtbG1lVjloWTJOMFgybHVZMlZ1ZEdsMlpWOWxiR2xuYVdKc1pUb0tJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5VGRHRjBaVTl3Y3k5amIyNTBjbUZqZEM1d2VUb3hOREFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaWE52ZFhKalpWOWxibU52WkdsdVp6MGlhVzVrWlhnaUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlYTWdRV05qYjNWdWRITUtJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5VGRHRjBaVTl3Y3k5amIyNTBjbUZqZEM1d2VUb3hORElLSUNBZ0lDOHZJSFpoYkhWbExDQm1kVzVrWldRZ1BTQnZjQzVCWTJOMFVHRnlZVzF6UjJWMExtRmpZM1JmYVc1alpXNTBhWFpsWDJWc2FXZHBZbXhsS0dFcENpQWdJQ0JoWTJOMFgzQmhjbUZ0YzE5blpYUWdRV05qZEVsdVkyVnVkR2wyWlVWc2FXZHBZbXhsQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TWpRS0lDQWdJQzh2SUhKbGRIVnliaUJ2Y0M1aWRHOXBLRlI0Ymk1aGNIQnNhV05oZEdsdmJsOWhjbWR6S0RFcEtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qRTBNd29nSUNBZ0x5OGdkbUZzZFdWZmFXNWtaWGdzSUdaMWJtUmxaRjlwYm1SbGVDQTlJRzl3TGtGalkzUlFZWEpoYlhOSFpYUXVZV05qZEY5cGJtTmxiblJwZG1WZlpXeHBaMmxpYkdVb1gyZGxkRjh4YzNSZmNtVm1YMmx1WkdWNEtDa3BDaUFnSUNCaFkyTjBYM0JoY21GdGMxOW5aWFFnUVdOamRFbHVZMlZ1ZEdsMlpVVnNhV2RwWW14bENpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12VTNSaGRHVlBjSE12WTI5dWRISmhZM1F1Y0hrNk1UUTBDaUFnSUNBdkx5QmhjM05sY25RZ2RtRnNkV1VnUFQwZ2RtRnNkV1ZmYVc1a1pYZ3NJQ0psZUhCbFkzUmxaQ0IyWVd4MVpTQmllU0JwYm1SbGVDQjBieUJ0WVhSamFDSUtJQ0FnSUdScFp5QXpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdaWGh3WldOMFpXUWdkbUZzZFdVZ1lua2dhVzVrWlhnZ2RHOGdiV0YwWTJnS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRveE5EVUtJQ0FnSUM4dklHRnpjMlZ5ZENCbWRXNWtaV1FnUFQwZ1puVnVaR1ZrWDJsdVpHVjRMQ0FpWlhod1pXTjBaV1FnWm5WdVpHVmtJR0o1SUdsdVpHVjRJSFJ2SUcxaGRHTm9JZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCbGVIQmxZM1JsWkNCbWRXNWtaV1FnWW5rZ2FXNWtaWGdnZEc4Z2JXRjBZMmdLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG94TkRBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WlhOdmRYSmpaVjlsYm1OdlpHbHVaejBpYVc1a1pYZ2lLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREFLSUNBZ0lIQjFjMmhwYm5RZ01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5NWhjblJwWm1GamRITXVVM1JoZEdWUGNITXVZMjl1ZEhKaFkzUXVVM1JoZEdWQlkyTjBVR0Z5WVcxelIyVjBRMjl1ZEhKaFkzUXVkbVZ5YVdaNVgyRmpZM1JmYkdGemRGOW9aV0Z5ZEdKbFlYUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AyWlhKcFpubGZZV05qZEY5c1lYTjBYMmhsWVhKMFltVmhkRG9LSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG94TkRnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WlhOdmRYSmpaVjlsYm1OdlpHbHVaejBpYVc1a1pYZ2lLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZWE1nUVdOamIzVnVkSE1LSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG94TlRBS0lDQWdJQzh2SUhaaGJIVmxMQ0JtZFc1a1pXUWdQU0J2Y0M1QlkyTjBVR0Z5WVcxelIyVjBMbUZqWTNSZmJHRnpkRjlvWldGeWRHSmxZWFFvWVNrS0lDQWdJR0ZqWTNSZmNHRnlZVzF6WDJkbGRDQkJZMk4wVEdGemRFaGxZWEowWW1WaGRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qSTBDaUFnSUNBdkx5QnlaWFIxY200Z2IzQXVZblJ2YVNoVWVHNHVZWEJ3YkdsallYUnBiMjVmWVhKbmN5Z3hLU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG94TlRFS0lDQWdJQzh2SUhaaGJIVmxYMmx1WkdWNExDQm1kVzVrWldSZmFXNWtaWGdnUFNCdmNDNUJZMk4wVUdGeVlXMXpSMlYwTG1GalkzUmZiR0Z6ZEY5b1pXRnlkR0psWVhRb1gyZGxkRjh4YzNSZmNtVm1YMmx1WkdWNEtDa3BDaUFnSUNCaFkyTjBYM0JoY21GdGMxOW5aWFFnUVdOamRFeGhjM1JJWldGeWRHSmxZWFFLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG94TlRJS0lDQWdJQzh2SUdGemMyVnlkQ0IyWVd4MVpTQTlQU0IyWVd4MVpWOXBibVJsZUN3Z0ltVjRjR1ZqZEdWa0lIWmhiSFZsSUdKNUlHbHVaR1Y0SUhSdklHMWhkR05vSWdvZ0lDQWdaR2xuSURNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCbGVIQmxZM1JsWkNCMllXeDFaU0JpZVNCcGJtUmxlQ0IwYnlCdFlYUmphQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPakUxTXdvZ0lDQWdMeThnWVhOelpYSjBJR1oxYm1SbFpDQTlQU0JtZFc1a1pXUmZhVzVrWlhnc0lDSmxlSEJsWTNSbFpDQm1kVzVrWldRZ1lua2dhVzVrWlhnZ2RHOGdiV0YwWTJnaUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR1Y0Y0dWamRHVmtJR1oxYm1SbFpDQmllU0JwYm1SbGVDQjBieUJ0WVhSamFBb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qRTBPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxjMjkxY21ObFgyVnVZMjlrYVc1blBTSnBibVJsZUNJcENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXVZWEowYVdaaFkzUnpMbE4wWVhSbFQzQnpMbU52Ym5SeVlXTjBMbE4wWVhSbFFXTmpkRkJoY21GdGMwZGxkRU52Ym5SeVlXTjBMblpsY21sbWVWOWhZMk4wWDJ4aGMzUmZjSEp2Y0c5elpXUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AyWlhKcFpubGZZV05qZEY5c1lYTjBYM0J5YjNCdmMyVmtPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPakUxTmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsYzI5MWNtTmxYMlZ1WTI5a2FXNW5QU0pwYm1SbGVDSXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhjeUJCWTJOdmRXNTBjd29nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPakUxT0FvZ0lDQWdMeThnZG1Gc2RXVXNJR1oxYm1SbFpDQTlJRzl3TGtGalkzUlFZWEpoYlhOSFpYUXVZV05qZEY5c1lYTjBYM0J5YjNCdmMyVmtLR0VwQ2lBZ0lDQmhZMk4wWDNCaGNtRnRjMTluWlhRZ1FXTmpkRXhoYzNSUWNtOXdiM05sWkFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMU4wWVhSbFQzQnpMMk52Ym5SeVlXTjBMbkI1T2pJMENpQWdJQ0F2THlCeVpYUjFjbTRnYjNBdVluUnZhU2hVZUc0dVlYQndiR2xqWVhScGIyNWZZWEpuY3lneEtTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5VGRHRjBaVTl3Y3k5amIyNTBjbUZqZEM1d2VUb3hOVGtLSUNBZ0lDOHZJSFpoYkhWbFgybHVaR1Y0TENCbWRXNWtaV1JmYVc1a1pYZ2dQU0J2Y0M1QlkyTjBVR0Z5WVcxelIyVjBMbUZqWTNSZmJHRnpkRjl3Y205d2IzTmxaQ2hmWjJWMFh6RnpkRjl5WldaZmFXNWtaWGdvS1NrS0lDQWdJR0ZqWTNSZmNHRnlZVzF6WDJkbGRDQkJZMk4wVEdGemRGQnliM0J2YzJWa0NpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12VTNSaGRHVlBjSE12WTI5dWRISmhZM1F1Y0hrNk1UWXdDaUFnSUNBdkx5QmhjM05sY25RZ2RtRnNkV1VnUFQwZ2RtRnNkV1ZmYVc1a1pYZ3NJQ0psZUhCbFkzUmxaQ0IyWVd4MVpTQmllU0JwYm1SbGVDQjBieUJ0WVhSamFDSUtJQ0FnSUdScFp5QXpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdaWGh3WldOMFpXUWdkbUZzZFdVZ1lua2dhVzVrWlhnZ2RHOGdiV0YwWTJnS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRveE5qRUtJQ0FnSUM4dklHRnpjMlZ5ZENCbWRXNWtaV1FnUFQwZ1puVnVaR1ZrWDJsdVpHVjRMQ0FpWlhod1pXTjBaV1FnWm5WdVpHVmtJR0o1SUdsdVpHVjRJSFJ2SUcxaGRHTm9JZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCbGVIQmxZM1JsWkNCbWRXNWtaV1FnWW5rZ2FXNWtaWGdnZEc4Z2JXRjBZMmdLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG94TlRZS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WlhOdmRYSmpaVjlsYm1OdlpHbHVaejBpYVc1a1pYZ2lLUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBQkFTWUJCQlVmZkhVeEcwRUFlREVaRkVReEdFU0NEd1JmVzBQa0JIUGNrOGNFVmliZjZ3VGNpaVcvQkJtT3ZZd0VJd0dySmdTZmFQeW1CS2wxd3RFRTBlQklBUVMybG12bEJCbGRWQmdFYXRyajhRVGZqUDdsQkdyWERTRUVGelg5SWpZYUFJNFBBQWtBUHdCMUFKRUFyZ0RMQU9nQkJRRWlBVDhCWEFGNUFaWUJ1Z0hYQURFWkZERVlGQkJETmhvQkY4QWNTWE1BTmhvQkYzTUFTd05QQWhKRUVrUkxBWE1BUkVzQkVrUk1ZRXNCRWtRMkdnRVhZRXNCRWtRV0tFeFFzQ0pETmhvQkY4QWNTWE1CTmhvQkYzTUJTd05QQWhKRUVrUkxBWE1CUkVzQkVrUk1lRXNCRWtRMkdnRVhlRXNCRWtRV0tFeFFzQ0pETmhvQkY4QWNjd0kyR2dFWGN3SkxBMDhDRWtRU1JDaE1VTEFpUXpZYUFSZkFISE1ETmhvQkYzTURTd05QQWhKRUVrUVdLRXhRc0NKRE5ob0JGOEFjY3dRMkdnRVhjd1JMQTA4Q0VrUVNSQllvVEZDd0lrTTJHZ0VYd0J4ekJUWWFBUmR6QlVzRFR3SVNSQkpFRmloTVVMQWlRellhQVJmQUhITUdOaG9CRjNNR1N3TlBBaEpFRWtRV0tFeFFzQ0pETmhvQkY4QWNjd2MyR2dFWGN3ZExBMDhDRWtRU1JCWW9URkN3SWtNMkdnRVh3Qnh6Q0RZYUFSZHpDRXNEVHdJU1JCSkVGaWhNVUxBaVF6WWFBUmZBSEhNSk5ob0JGM01KU3dOUEFoSkVFa1FXS0V4UXNDSkROaG9CRjhBY2N3bzJHZ0VYY3dwTEEwOENFa1FTUkJZb1RGQ3dJa00yR2dFWHdCeHpDellhQVJkekMwc0RUd0lTUkJKRUZpaE1VTEFpUXpZYUFSZkFISE1NTmhvQkYzTU1Td05QQWhKRUVrU0FBUUNCQUU4Q1ZDaE1VTEFpUXpZYUFSZkFISE1PTmhvQkYzTU9Td05QQWhKRUVrUVdLRXhRc0NKRE5ob0JGOEFjY3cwMkdnRVhjdzFMQTA4Q0VrUVNSQllvVEZDd0lrTT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo4LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
