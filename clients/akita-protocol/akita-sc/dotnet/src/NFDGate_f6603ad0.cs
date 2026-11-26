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

namespace Arc56.Generated.akita_protocol.akita_sc.NFDGate_f6603ad0
{


    public class NFDGateProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public NFDGateProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="version"> </param>
        /// <param name="akitaDAO"> </param>
        public async Task Create(string version, ulong akitaDAO, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 205, 154, 214, 126 };
            var versionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); versionAbi.From(version);
            var akitaDAOAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); akitaDAOAbi.From(akitaDAO);

            var result = await base.CallApp(new List<object> { abiHandle, versionAbi, akitaDAOAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(string version, ulong akitaDAO, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 205, 154, 214, 126 };
            var versionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); versionAbi.From(version);
            var akitaDAOAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); akitaDAOAbi.From(akitaDAO);

            return await base.MakeTransactionList(new List<object> { abiHandle, versionAbi, akitaDAOAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="args"> </param>
        public async Task<ulong> Cost(byte[] args, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 50, 159, 4, 238 };
            var argsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); argsAbi.From(args);

            var result = await base.CallApp(new List<object> { abiHandle, argsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Cost_Transactions(byte[] args, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 50, 159, 4, 238 };
            var argsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); argsAbi.From(args);

            return await base.MakeTransactionList(new List<object> { abiHandle, argsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="mbrPayment"> </param>
        /// <param name="args"> </param>
        public async Task<ulong> Register(PaymentTransaction mbrPayment, byte[] args, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment });
            byte[] abiHandle = { 119, 187, 121, 185 };
            var argsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); argsAbi.From(args);

            var result = await base.CallApp(new List<object> { abiHandle, mbrPayment, argsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Register_Transactions(PaymentTransaction mbrPayment, byte[] args, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment });
            byte[] abiHandle = { 119, 187, 121, 185 };
            var argsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); argsAbi.From(args);

            return await base.MakeTransactionList(new List<object> { abiHandle, mbrPayment, argsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="caller"> </param>
        /// <param name="registryID"> </param>
        /// <param name="args"> </param>
        public async Task<bool> Check(Algorand.Address caller, ulong registryID, byte[] args, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 3, 245, 10 };
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);
            var registryIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryIDAbi.From(registryID);
            var argsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); argsAbi.From(args);

            var result = await base.CallApp(new List<object> { abiHandle, callerAbi, registryIDAbi, argsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Check_Transactions(Algorand.Address caller, ulong registryID, byte[] args, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 3, 245, 10 };
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);
            var registryIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryIDAbi.From(registryID);
            var argsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); argsAbi.From(args);

            return await base.MakeTransactionList(new List<object> { abiHandle, callerAbi, registryIDAbi, argsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="shape"> </param>
        public async Task<ulong> GetCheckShape(ulong shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 184, 211, 113 };
            var shapeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); shapeAbi.From(shape);

            var result = await base.CallApp(new List<object> { abiHandle, shapeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetCheckShape_Transactions(ulong shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 184, 211, 113 };
            var shapeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); shapeAbi.From(shape);

            return await base.MakeTransactionList(new List<object> { abiHandle, shapeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="registryID"> </param>
        public async Task<byte[]> GetEntry(ulong registryID, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 212, 250, 93 };
            var registryIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryIDAbi.From(registryID);

            var result = await base.SimApp(new List<object> { abiHandle, registryIDAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> GetEntry_Transactions(ulong registryID, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 212, 250, 93 };
            var registryIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryIDAbi.From(registryID);

            return await base.MakeTransactionList(new List<object> { abiHandle, registryIDAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="akitaDAO"> </param>
        public async Task UpdateAkitaDao(ulong akitaDAO, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 233, 44, 148 };
            var akitaDAOAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); akitaDAOAbi.From(akitaDAO);

            var result = await base.CallApp(new List<object> { abiHandle, akitaDAOAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateAkitaDao_Transactions(ulong akitaDAO, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 233, 44, 148 };
            var akitaDAOAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); akitaDAOAbi.From(akitaDAO);

            return await base.MakeTransactionList(new List<object> { abiHandle, akitaDAOAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task OpUp(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 77, 237, 224 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OpUp_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 77, 237, 224 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTkZER2F0ZSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmVyc2lvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWtpdGFEQU8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY29zdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcmdzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVnaXN0ZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWJyUGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXJncyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNoZWNrIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYWxsZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZ2lzdHJ5SUQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFyZ3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0Q2hlY2tTaGFwZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaGFwZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEVudHJ5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZ2lzdHJ5SUQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZUFraXRhREFPIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFraXRhREFPIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im9wVXAiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjozfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls0NjUsNTMyXSwiZXJyb3JNZXNzYWdlIjoiQnl0ZXMgaGFzIHZhbGlkIHByZWZpeCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwNiwzNTVdLCJlcnJvck1lc3NhZ2UiOiJFUlI6ZXJySWFyZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4OSwyOThdLCJlcnJvck1lc3NhZ2UiOiJFUlI6ZXJySXBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM3NF0sImVycm9yTWVzc2FnZSI6IkVSUjplcnJJcmdhIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjk2XSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVyck5kYW8iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NzddLCJlcnJvck1lc3NhZ2UiOiJhcHBsaWNhdGlvbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MjAsNjY0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk4LDI0MCwyNjcsMzM0LDUzNV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwNSwyNDYsMjc0LDM0MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjE2LDMyNyw2MjUsNjM4LDY1N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ3MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBib29sIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTQxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGJ5dGVzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjYxXSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRGdnTWdvZ0lDQWdZbmwwWldOaWJHOWpheUFpWVd0cGRHRmZaR0Z2SWlBd2VERTFNV1kzWXpjMUlEQjRNVFV4Wmpkak56VXdNREF3TURBd01EQXdNREF3TURBd0lDSkZVbEk2WlhKeVNYQmhlU0lnSWtWU1VqcGxjbkpKWVhKbklnb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXVabVF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TUFvZ0lDQWdMeThnY21WbmFYTjBjbUYwYVc5dVUyaGhjR1VnUFNCSGJHOWlZV3hUZEdGMFpUeHpkSEpwYm1jK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lBbkp5d2dhMlY1T2lCSFlYUmxSMnh2WW1Gc1UzUmhkR1ZMWlhsU1pXZHBjM1J5WVhScGIyNVRhR0Z3WlNCOUtRb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBaWNtVm5hWE4wY21GMGFXOXVYM05vWVhCbElpQWlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmJtWmtMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNaklLSUNBZ0lDOHZJR05vWldOclUyaGhjR1VnUFNCSGJHOWlZV3hUZEdGMFpUeHpkSEpwYm1jK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lBbmRXbHVkRFkwSnl3Z2EyVjVPaUJIWVhSbFIyeHZZbUZzVTNSaGRHVkxaWGxEYUdWamExTm9ZWEJsSUgwcENpQWdJQ0J3ZFhOb1lubDBaWE56SUNKamFHVmphMTl6YUdGd1pTSWdJblZwYm5RMk5DSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZibVprTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRVS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5Qk9Sa1JIWVhSbElHVjRkR1Z1WkhNZ1FXdHBkR0ZDWVhObFEyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbm9nYldGcGJsOWpjbVZoZEdWZlRtOVBjRUF4TXdvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURNeU9XWXdOR1ZsSURCNE56ZGlZamM1WWprZ01IZzJaVEF6WmpVd1lTQXdlRGhoWWpoa016Y3hJREI0T1RCa05HWmhOV1FnTUhnek0yVTVNbU01TkNBd2VEZzFOR1JsWkdVd0lDOHZJRzFsZEdodlpDQWlZMjl6ZENoaWVYUmxXMTBwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0p5WldkcGMzUmxjaWh3WVhrc1lubDBaVnRkS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWTJobFkyc29ZV1JrY21WemN5eDFhVzUwTmpRc1lubDBaVnRkS1dKdmIyd2lMQ0J0WlhSb2IyUWdJbWRsZEVOb1pXTnJVMmhoY0dVb2RXbHVkRFkwS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWjJWMFJXNTBjbmtvZFdsdWREWTBLV0o1ZEdWYlhTSXNJRzFsZEdodlpDQWlkWEJrWVhSbFFXdHBkR0ZFUVU4b2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbTl3VlhBb0tYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCamIzTjBJSEpsWjJsemRHVnlJR05vWldOcklHZGxkRU5vWldOclUyaGhjR1VnWjJWMFJXNTBjbmtnZFhCa1lYUmxRV3RwZEdGRVFVOGdiV0ZwYmw5dmNGVndYM0p2ZFhSbFFERXhDaUFnSUNCbGNuSUtDbTFoYVc1ZmIzQlZjRjl5YjNWMFpVQXhNVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTkxY0dkeVlXUmxZV0pzWlM1MGN6b3pNQW9nSUNBZ0x5OGdiM0JWY0NncE9pQjJiMmxrSUhzZ2ZRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5amNtVmhkR1ZmVG05UGNFQXhNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmJtWmtMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFVLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCT1JrUkhZWFJsSUdWNGRHVnVaSE1nUVd0cGRHRkNZWE5sUTI5dWRISmhZM1FnZXdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WTJRNVlXUTJOMlVnTHk4Z2JXVjBhRzlrSUNKamNtVmhkR1VvYzNSeWFXNW5MSFZwYm5RMk5DbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1kzSmxZWFJsQ2lBZ0lDQmxjbklLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDI1bVpDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcE9Sa1JIWVhSbExtTnlaV0YwWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnlaV0YwWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZibVprTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRnS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnZia055WldGMFpUb2dKM0psY1hWcGNtVW5JSDBwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMM1Z3WjNKaFpHVmhZbXhsTG5Sek9qRTBDaUFnSUNBdkx5QjJaWEp6YVc5dUlEMGdSMnh2WW1Gc1UzUmhkR1U4YzNSeWFXNW5QaWg3SUd0bGVUb2dSMnh2WW1Gc1UzUmhkR1ZMWlhsV1pYSnphVzl1SUgwcENpQWdJQ0J3ZFhOb1lubDBaWE1nSW5abGNuTnBiMjRpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwyNW1aQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall3Q2lBZ0lDQXZMeUIwYUdsekxuWmxjbk5wYjI0dWRtRnNkV1VnUFNCMlpYSnphVzl1Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZkWEJuY21Ga1pXRmliR1V1ZEhNNk1UWUtJQ0FnSUM4dklHRnJhWFJoUkVGUElEMGdSMnh2WW1Gc1UzUmhkR1U4UVhCd2JHbGpZWFJwYjI0K0tIc2dhMlY1T2lCSGJHOWlZV3hUZEdGMFpVdGxlVUZyYVhSaFJFRlBJSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0poYTJsMFlWOWtZVzhpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwyNW1aQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall4Q2lBZ0lDQXZMeUIwYUdsekxtRnJhWFJoUkVGUExuWmhiSFZsSUQwZ1FYQndiR2xqWVhScGIyNG9ZV3RwZEdGRVFVOHBDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5dVptUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFPQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUc5dVEzSmxZWFJsT2lBbmNtVnhkV2x5WlNjZ2ZTa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMjVtWkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwT1JrUkhZWFJsTG1OdmMzUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqYjNOME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl1Wm1RdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk5nb2dJQ0FnTHk4Z1kyOXpkQ2hoY21kek9pQmllWFJsY3lrNklIVnBiblEyTkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOVEF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZibVprTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2s1R1JFZGhkR1V1Y21WbmFYTjBaWEpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpXZHBjM1JsY2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZibVprTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpBS0lDQWdJQzh2SUhKbFoybHpkR1Z5S0cxaWNsQmhlVzFsYm5RNklHZDBlRzR1VUdGNWJXVnVkRlI0Yml3Z1lYSm5jem9nWW5sMFpYTXBPaUIxYVc1ME5qUWdld29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JrZFhCdUlESUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekVnTHk4Z2NHRjVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ2NHRjVDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXVabVF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTVFvZ0lDQWdMeThnYkc5bloyVmtRWE56WlhKMEtHMWljbEJoZVcxbGJuUXVjbVZqWldsMlpYSWdQVDA5SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQ0JsY25KSmJuWmhiR2xrVUdGNWJXVnVkQ2tLSUNBZ0lHZDBlRzV6SUZKbFkyVnBkbVZ5Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJ5WldkcGMzUmxjbDloWm5SbGNsOWhjM05sY25SQU13b2dJQ0FnWW5sMFpXTmZNeUF2THlBaVJWSlNPbVZ5Y2tsd1lYa2lDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNlpYSnlTWEJoZVFvS2NtVm5hWE4wWlhKZllXWjBaWEpmWVhOelpYSjBRRE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwyNW1aQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamN5Q2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb2JXSnlVR0Y1YldWdWRDNWhiVzkxYm5RZ1BUMDlJREFzSUdWeWNrbHVkbUZzYVdSUVlYbHRaVzUwS1FvZ0lDQWdjM2RoY0FvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2lBZ0lDQmllaUJ5WldkcGMzUmxjbDloWm5SbGNsOWhjM05sY25SQU5Rb2dJQ0FnWW5sMFpXTmZNeUF2THlBaVJWSlNPbVZ5Y2tsd1lYa2lDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNlpYSnlTWEJoZVFvS2NtVm5hWE4wWlhKZllXWjBaWEpmWVhOelpYSjBRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwyNW1aQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamN6Q2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb1lYSm5jeTVzWlc1bmRHZ2dQVDA5SURBc0lHVnlja2x1ZG1Gc2FXUkJjbWREYjNWdWRDa0tJQ0FnSUd4bGJnb2dJQ0FnWW5vZ2NtVm5hWE4wWlhKZllXWjBaWEpmWVhOelpYSjBRRGNLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJa1ZTVWpwbGNuSkpZWEpuSWdvZ0lDQWdiRzluQ2lBZ0lDQmxjbklnTHk4Z1JWSlNPbVZ5Y2tsaGNtY0tDbkpsWjJsemRHVnlYMkZtZEdWeVgyRnpjMlZ5ZEVBM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl1Wm1RdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM01Bb2dJQ0FnTHk4Z2NtVm5hWE4wWlhJb2JXSnlVR0Y1YldWdWREb2daM1I0Ymk1UVlYbHRaVzUwVkhodUxDQmhjbWR6T2lCaWVYUmxjeWs2SUhWcGJuUTJOQ0I3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelV3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMjVtWkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwT1JrUkhZWFJsTG1Ob1pXTnJXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTJobFkyczZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDI1bVpDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzRDaUFnSUNBdkx5QmphR1ZqYXloallXeHNaWEk2SUVGalkyOTFiblFzSUhKbFoybHpkSEo1U1VRNklIVnBiblEyTkN3Z1lYSm5jem9nWW5sMFpYTXBPaUJpYjI5c1pXRnVJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZibVprTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnprS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaGhjbWR6TG14bGJtZDBhQ0E5UFQwZ1ZXbHVkRFkwUW5sMFpVeGxibWQwYUN3Z1pYSnlTVzUyWVd4cFpFRnlaME52ZFc1MEtRb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJqYUdWamExOWhablJsY2w5aGMzTmxjblJBTXdvZ0lDQWdZbmwwWldNZ05DQXZMeUFpUlZKU09tVnlja2xoY21jaUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2WlhKeVNXRnlad29LWTJobFkydGZZV1owWlhKZllYTnpaWEowUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMjVtWkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnd0NpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9jbVZuYVhOMGNubEpSQ0E5UFQwZ01Dd2daWEp5U1c1MllXeHBaRkpsWjJsemRISjVRWEpuS1FvZ0lDQWdjM2RoY0FvZ0lDQWdZbm9nWTJobFkydGZZV1owWlhKZllYTnpaWEowUURVS0lDQWdJSEIxYzJoaWVYUmxjeUFpUlZKU09tVnlja2x5WjJFaUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2WlhKeVNYSm5ZUW9LWTJobFkydGZZV1owWlhKZllYTnpaWEowUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMjVtWkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pneENpQWdJQ0F2THlCeVpYUjFjbTRnZEdocGN5NXVabVJIWVhSbEtHTmhiR3hsY2l3Z1luUnZhU2hoY21kektTa0tJQ0FnSUdKMGIya0tJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl1Wm1RdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU53b2dJQ0FnTHk4Z1kyOXVjM1FnVzI1bVpFNWhiV1VzSUdoaGMwNWhiV1ZkSUQwZ2IzQXVRWEJ3UjJ4dlltRnNMbWRsZEVWNFFubDBaWE1vWVhCd1NVUXNJRUo1ZEdWektFNUdSRWRzYjJKaGJGTjBZWFJsUzJWNWMwNWhiV1VwS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pwTG01aGJXVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXVabVF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T0FvZ0lDQWdMeThnYVdZZ0tDRm9ZWE5PWVcxbEtTQjdDaUFnSUNCaWJub2dZMmhsWTJ0ZllXWjBaWEpmYVdaZlpXeHpaVUE0Q2lBZ0lDQndiM0J1SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZibVprTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWprS0lDQWdJQzh2SUhKbGRIVnliaUJtWVd4elpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0NtTm9aV05yWDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5dVptUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZUa1pFUjJGMFpTNXVabVJIWVhSbFFERTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5dVptUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNPQW9nSUNBZ0x5OGdZMmhsWTJzb1kyRnNiR1Z5T2lCQlkyTnZkVzUwTENCeVpXZHBjM1J5ZVVsRU9pQjFhVzUwTmpRc0lHRnlaM002SUdKNWRHVnpLVG9nWW05dmJHVmhiaUI3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3BqYUdWamExOWhablJsY2w5cFpsOWxiSE5sUURnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMjVtWkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNeUxUTTFDaUFnSUNBdkx5QmpiMjV6ZENCMlpYSnBabWxsWkNBOUlHRmlhVU5oYkd3OGRIbHdaVzltSUU1R1JGSmxaMmx6ZEhKNUxuQnliM1J2ZEhsd1pTNXBjMVpoYkdsa1RtWmtRWEJ3U1dRK0tIc0tJQ0FnSUM4dklDQWdZWEJ3U1dRNklHZGxkRTkwYUdWeVFYQndUR2x6ZENoMGFHbHpMbUZyYVhSaFJFRlBMblpoYkhWbEtTNXVabVJTWldkcGMzUnllU3dLSUNBZ0lDOHZJQ0FnWVhKbmN6b2dXMU4wY21sdVp5aHVabVJPWVcxbEtTd2dZWEJ3U1VSZExBb2dJQ0FnTHk4Z2ZTa3VjbVYwZFhKdVZtRnNkV1VLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12Ym1aa0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16UUtJQ0FnSUM4dklHRnlaM002SUZ0VGRISnBibWNvYm1aa1RtRnRaU2tzSUdGd2NFbEVYU3dLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNUW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5dVptUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNd29nSUNBZ0x5OGdZWEJ3U1dRNklHZGxkRTkwYUdWeVFYQndUR2x6ZENoMGFHbHpMbUZyYVhSaFJFRlBMblpoYkhWbEtTNXVabVJTWldkcGMzUnllU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZkWEJuY21Ga1pXRmliR1V1ZEhNNk1UWUtJQ0FnSUM4dklHRnJhWFJoUkVGUElEMGdSMnh2WW1Gc1UzUmhkR1U4UVhCd2JHbGpZWFJwYjI0K0tIc2dhMlY1T2lCSGJHOWlZV3hUZEdGMFpVdGxlVUZyYVhSaFJFRlBJSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0poYTJsMFlWOWtZVzhpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwyNW1aQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak16Q2lBZ0lDQXZMeUJoY0hCSlpEb2daMlYwVDNSb1pYSkJjSEJNYVhOMEtIUm9hWE11WVd0cGRHRkVRVTh1ZG1Gc2RXVXBMbTVtWkZKbFoybHpkSEo1TEFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZNakl4Q2lBZ0lDQXZMeUJqYjI1emRDQmJiM1JvWlhKQmNIQk1hWE4wUW5sMFpYTmRJRDBnYjNBdVFYQndSMnh2WW1Gc0xtZGxkRVY0UW5sMFpYTW9ZV3RwZEdGRVFVOHNJRUo1ZEdWektFRnJhWFJoUkVGUFIyeHZZbUZzVTNSaGRHVkxaWGx6VDNSb1pYSkJjSEJNYVhOMEtTa0tJQ0FnSUhCMWMyaGllWFJsY3lBaWIyRnNJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXVabVF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TXdvZ0lDQWdMeThnWVhCd1NXUTZJR2RsZEU5MGFHVnlRWEJ3VEdsemRDaDBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxLUzV1Wm1SU1pXZHBjM1J5ZVN3S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMjVtWkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNeUxUTTFDaUFnSUNBdkx5QmpiMjV6ZENCMlpYSnBabWxsWkNBOUlHRmlhVU5oYkd3OGRIbHdaVzltSUU1R1JGSmxaMmx6ZEhKNUxuQnliM1J2ZEhsd1pTNXBjMVpoYkdsa1RtWmtRWEJ3U1dRK0tIc0tJQ0FnSUM4dklDQWdZWEJ3U1dRNklHZGxkRTkwYUdWeVFYQndUR2x6ZENoMGFHbHpMbUZyYVhSaFJFRlBMblpoYkhWbEtTNXVabVJTWldkcGMzUnllU3dLSUNBZ0lDOHZJQ0FnWVhKbmN6b2dXMU4wY21sdVp5aHVabVJPWVcxbEtTd2dZWEJ3U1VSZExBb2dJQ0FnTHk4Z2ZTa3VjbVYwZFhKdVZtRnNkV1VLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFJpWlRJeVptTTJJQzh2SUcxbGRHaHZaQ0FpYVhOV1lXeHBaRTVtWkVGd2NFbGtLSE4wY21sdVp5eDFhVzUwTmpRcFltOXZiQ0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSEIxYzJocGJuUWdOaUF2THlCaGNIQnNDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUV4aGMzUk1iMmNLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBMElEQUtJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1FnTUNBMENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRbmwwWlhNZ2FHRnpJSFpoYkdsa0lIQnlaV1pwZUFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaWIyOXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDI1bVpDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTNDaUFnSUNBdkx5QnBaaUFvSVhabGNtbG1hV1ZrS1NCN0NpQWdJQ0JpYm5vZ1kyaGxZMnRmWVdaMFpYSmZhV1pmWld4elpVQXhNQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDI1bVpDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTRDaUFnSUNBdkx5QnlaWFIxY200Z1ptRnNjMlVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDI1bVpDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZ3hDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTV1Wm1SSFlYUmxLR05oYkd4bGNpd2dZblJ2YVNoaGNtZHpLU2tLSUNBZ0lHSWdZMmhsWTJ0ZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwyNW1aQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBPUmtSSFlYUmxMbTVtWkVkaGRHVkFNVFlLQ21Ob1pXTnJYMkZtZEdWeVgybG1YMlZzYzJWQU1UQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDI1bVpDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXhMVFEwQ2lBZ0lDQXZMeUJqYjI1emRDQmpZVUZzWjI5RVlYUmhJRDBnWVdKcFEyRnNiRHgwZVhCbGIyWWdUa1pFTG5CeWIzUnZkSGx3WlM1eVpXRmtSbWxsYkdRK0tIc0tJQ0FnSUM4dklDQWdZWEJ3U1dRNklHRndjRWxFTEFvZ0lDQWdMeThnSUNCaGNtZHpPaUJiUW5sMFpYTW9Ua1pFVFdWMFlVdGxlVlpsY21sbWFXVmtRV1JrY21WemMyVnpLVjBzQ2lBZ0lDQXZMeUI5S1M1eVpYUjFjbTVXWVd4MVpRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnMll6RXpaV1JsTkNBdkx5QnRaWFJvYjJRZ0luSmxZV1JHYVdWc1pDaGllWFJsVzEwcFlubDBaVnRkSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12Ym1aa0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5ETUtJQ0FnSUM4dklHRnlaM002SUZ0Q2VYUmxjeWhPUmtSTlpYUmhTMlY1Vm1WeWFXWnBaV1JCWkdSeVpYTnpaWE1wWFN3S0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01HUTNOakpsTmpNMk1UUXhObU0yTnpabU1tVXpNREpsTmpFM013b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmJtWmtMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOREV0TkRRS0lDQWdJQzh2SUdOdmJuTjBJR05oUVd4bmIwUmhkR0VnUFNCaFltbERZV3hzUEhSNWNHVnZaaUJPUmtRdWNISnZkRzkwZVhCbExuSmxZV1JHYVdWc1pENG9ld29nSUNBZ0x5OGdJQ0JoY0hCSlpEb2dZWEJ3U1VRc0NpQWdJQ0F2THlBZ0lHRnlaM002SUZ0Q2VYUmxjeWhPUmtSTlpYUmhTMlY1Vm1WeWFXWnBaV1JCWkdSeVpYTnpaWE1wWFN3S0lDQWdJQzh2SUgwcExuSmxkSFZ5YmxaaGJIVmxDaUFnSUNCd2RYTm9hVzUwSURZZ0x5OGdZWEJ3YkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdaWGgwY21GamRDQXdJRFFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCQ2VYUmxjeUJvWVhNZ2RtRnNhV1FnY0hKbFptbDRDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJpZVhSbGN3b2dJQ0FnWlhoMGNtRmpkQ0EySURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZibVprTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRjS0lDQWdJQzh2SUdadmNpQW9iR1YwSUdrNklIVnBiblEyTkNBOUlEQTdJR2tnS3lBek1pQThQU0JqWVVGc1oyOUVZWFJoTG14bGJtZDBhRHNnYVNBclBTQXpNaWtnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLQ21Ob1pXTnJYM2RvYVd4bFgzUnZjRUF4TVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZibVprTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRjS0lDQWdJQzh2SUdadmNpQW9iR1YwSUdrNklIVnBiblEyTkNBOUlEQTdJR2tnS3lBek1pQThQU0JqWVVGc1oyOUVZWFJoTG14bGJtZDBhRHNnYVNBclBTQXpNaWtnZXdvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElETXlDaUFnSUNBckNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdScFp5QXpDaUFnSUNCc1pXNEtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1BEMEtJQ0FnSUdKNklHTm9aV05yWDJGbWRHVnlYM2RvYVd4bFFERTFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDI1bVpDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTRDaUFnSUNBdkx5QnBaaUFvWTJGQmJHZHZSR0YwWVM1emJHbGpaU2hwTENCcElDc2dNeklwSUQwOVBTQjFjMlZ5TG1KNWRHVnpLU0I3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQStQUW9nSUNBZ1pHbG5JRElLSUNBZ0lITjNZWEFLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdaR2xuSURJS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURNS0lDQWdJRDQ5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBeUNpQWdJQ0E4Q2lBZ0lDQmthV2NnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdjMlZzWldOMENpQWdJQ0JrYVdjZ013b2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWkdsbklETUtJQ0FnSUQwOUNpQWdJQ0JpZWlCamFHVmphMTloWm5SbGNsOXBabDlsYkhObFFERTBDaUFnSUNCd2IzQnVJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdmJtWmtMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORGtLSUNBZ0lDOHZJSEpsZEhWeWJpQjBjblZsQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5dVptUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRNUW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11Ym1aa1IyRjBaU2hqWVd4c1pYSXNJR0owYjJrb1lYSm5jeWtwQ2lBZ0lDQmlJR05vWldOclgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OXVabVF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VGtaRVIyRjBaUzV1Wm1SSFlYUmxRREUyQ2dwamFHVmphMTloWm5SbGNsOXBabDlsYkhObFFERTBPZ29nSUNBZ1lpQmphR1ZqYTE5M2FHbHNaVjkwYjNCQU1URUtDbU5vWldOclgyRm1kR1Z5WDNkb2FXeGxRREUxT2dvZ0lDQWdjRzl3YmlBMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMjVtWkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVekNpQWdJQ0F2THlCeVpYUjFjbTRnWm1Gc2MyVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMjVtWkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pneENpQWdJQ0F2THlCeVpYUjFjbTRnZEdocGN5NXVabVJIWVhSbEtHTmhiR3hsY2l3Z1luUnZhU2hoY21kektTa0tJQ0FnSUdJZ1kyaGxZMnRmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDI1bVpDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcE9Sa1JIWVhSbExtNW1aRWRoZEdWQU1UWUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMjVtWkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwT1JrUkhZWFJsTG1kbGRFTm9aV05yVTJoaGNHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSRGFHVmphMU5vWVhCbE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTl1Wm1RdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE5Bb2dJQ0FnTHk4Z1oyVjBRMmhsWTJ0VGFHRndaU2h6YUdGd1pUb2dkV2x1ZERZMEtUb2dkV2x1ZERZMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDI1bVpDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcE9Sa1JIWVhSbExtZGxkRVZ1ZEhKNVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwUlc1MGNuazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDI1bVpDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZzRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlRBd01EQUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OWlZWE5sTFdOdmJuUnlZV04wY3k5MWNHZHlZV1JsWVdKc1pTNTBjem82UVd0cGRHRkNZWE5sUTI5dWRISmhZM1F1ZFhCa1lYUmxRV3RwZEdGRVFVOWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AxY0dSaGRHVkJhMmwwWVVSQlR6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OTFjR2R5WVdSbFlXSnNaUzUwY3pveU5Rb2dJQ0FnTHk4Z2RYQmtZWFJsUVd0cGRHRkVRVThvWVd0cGRHRkVRVTg2SUVGd2NHeHBZMkYwYVc5dUtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZkWEJuY21Ga1pXRmliR1V1ZEhNNk1qWUtJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQjBhR2x6TG1kbGRFRnJhWFJoUkVGUFYyRnNiR1YwS0NrdVlXUmtjbVZ6Y3l3Z1pYSnlUbTkwUVd0cGRHRkVZVzhwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZkWEJuY21Ga1pXRmliR1V1ZEhNNk1Ua0tJQ0FnSUM4dklHTnZibk4wSUZ0M1lXeHNaWFJKUkYwZ1BTQnZjQzVCY0hCSGJHOWlZV3d1WjJWMFJYaFZhVzUwTmpRb2RHaHBjeTVoYTJsMFlVUkJUeTUyWVd4MVpTd2dRbmwwWlhNb1FXdHBkR0ZFUVU5SGJHOWlZV3hUZEdGMFpVdGxlWE5YWVd4c1pYUXBLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OTFjR2R5WVdSbFlXSnNaUzUwY3pveE5nb2dJQ0FnTHk4Z1lXdHBkR0ZFUVU4Z1BTQkhiRzlpWVd4VGRHRjBaVHhCY0hCc2FXTmhkR2x2Ymo0b2V5QnJaWGs2SUVkc2IySmhiRk4wWVhSbFMyVjVRV3RwZEdGRVFVOGdmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUZyYVhSaFgyUmhieUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTkxY0dkeVlXUmxZV0pzWlM1MGN6b3hPUW9nSUNBZ0x5OGdZMjl1YzNRZ1czZGhiR3hsZEVsRVhTQTlJRzl3TGtGd2NFZHNiMkpoYkM1blpYUkZlRlZwYm5RMk5DaDBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxMQ0JDZVhSbGN5aEJhMmwwWVVSQlQwZHNiMkpoYkZOMFlYUmxTMlY1YzFkaGJHeGxkQ2twQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ2NIVnphR0o1ZEdWeklDSjNZV3hzWlhRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZkWEJuY21Ga1pXRmliR1V1ZEhNNk1qWUtJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQjBhR2x6TG1kbGRFRnJhWFJoUkVGUFYyRnNiR1YwS0NrdVlXUmtjbVZ6Y3l3Z1pYSnlUbTkwUVd0cGRHRkVZVzhwQ2lBZ0lDQmhjSEJmY0dGeVlXMXpYMmRsZENCQmNIQkJaR1J5WlhOekNpQWdJQ0JoYzNObGNuUWdMeThnWVhCd2JHbGpZWFJwYjI0Z1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1ltNTZJSFZ3WkdGMFpVRnJhWFJoUkVGUFgyRm1kR1Z5WDJGemMyVnlkRUF6Q2lBZ0lDQndkWE5vWW5sMFpYTWdJa1ZTVWpwbGNuSk9aR0Z2SWdvZ0lDQWdiRzluQ2lBZ0lDQmxjbklnTHk4Z1JWSlNPbVZ5Y2s1a1lXOEtDblZ3WkdGMFpVRnJhWFJoUkVGUFgyRm1kR1Z5WDJGemMyVnlkRUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDNWd1ozSmhaR1ZoWW14bExuUnpPakUyQ2lBZ0lDQXZMeUJoYTJsMFlVUkJUeUE5SUVkc2IySmhiRk4wWVhSbFBFRndjR3hwWTJGMGFXOXVQaWg3SUd0bGVUb2dSMnh2WW1Gc1UzUmhkR1ZMWlhsQmEybDBZVVJCVHlCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVlXdHBkR0ZmWkdGdklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwzVndaM0poWkdWaFlteGxMblJ6T2pJM0NpQWdJQ0F2THlCMGFHbHpMbUZyYVhSaFJFRlBMblpoYkhWbElEMGdZV3RwZEdGRVFVOEtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZkWEJuY21Ga1pXRmliR1V1ZEhNNk1qVUtJQ0FnSUM4dklIVndaR0YwWlVGcmFYUmhSRUZQS0dGcmFYUmhSRUZQT2lCQmNIQnNhV05oZEdsdmJpazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFSUFpWUZDV0ZyYVhSaFgyUmhid1FWSDN4MURCVWZmSFVBQUFBQUFBQUFBQXRGVWxJNlpYSnlTWEJoZVF0RlVsSTZaWEp5U1dGeVp6RVlRQUF0Z2dJU2NtVm5hWE4wY21GMGFXOXVYM05vWVhCbEFHZUNBZ3RqYUdWamExOXphR0Z3WlFaMWFXNTBOalJuTVJrVVJERVlRUUE3Z2djRU1wOEU3Z1IzdTNtNUJHNEQ5UW9FaXJqVGNRU1ExUHBkQkRQcExKUUVoVTN0NERZYUFJNEhBRHNBU3dDSEFib0J5QUhhQUFFQUkwT0FCTTJhMW40MkdnQ09BUUFCQURZYUFVa2lXU1VJU3dFVkVrUlhBZ0EyR2dKSkZTUVNSQmVBQjNabGNuTnBiMjVQQW1jb1RHY2pRellhQVVraVdTVUlUQlVTUkNxd0kwTXhGaU1KUndJNEVDTVNSRFlhQVVraVdTVUlTd0VWRWtSWEFnQk1PQWN5Q2hKQUFBTXJzQUJNT0FoQkFBTXJzQUFWUVFBRUp3U3dBQ3F3STBNMkdnRkpGWUVnRWtRMkdnSkpGU1FTUkJjMkdnTkpJbGtsQ0VzQkZSSkVWd0lBU1JVa0VrQUFCQ2NFc0FCTVFRQVBnQXRGVWxJNlpYSnlTWEpuWWJBQUYwbUFCbWt1Ym1GdFpXVkFBQkJHQWlLQUFRQWlUd0pVS1V4UXNDTkRzVWtWRmxjR0FreFFTd0VXSWlobFJJQURiMkZzWlVna1c3SVlnQVJMNGkvR3NocE1zaHF5R29FR3NoQWlzZ0d6dEQ1SlZ3UUFURmNBQkNrU1JFa1ZJeEpFSWxOQUFBVklJa0wvcDdHeUdJQUViQlB0NUxJYWdBOEFEWFl1WTJGQmJHZHZMakF1WVhPeUdvRUdzaEFpc2dHenRENUpWd1FBU3dGWEFBUXBFa1JKSWxrbENFd1ZFa1JYQmdBaVNZRWdDRWxPQWtzREZVbE9BZzVCQURGTVNVc0NEMHNDVEUxTEFrbExBdzlNVHdOUEFrMUpTd0lNU3dKTVRVc0RUZ0pTU3dNU1FRQUdSZ0lqUXY4blF2KytSZ1FpUXY4ZU5ob0JTUlVrRWtRcFRGQ3dJME0yR2dFVkpCSkVnQVlWSDN4MUFBQ3dJME0yR2dGSkZTUVNSQmN4QUNJb1pVU0FCbmRoYkd4bGRHVkljZ2hFRWtBQUQ0QUxSVkpTT21WeWNrNWtZVyt3QUNoTVp5TkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjoxMCwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
