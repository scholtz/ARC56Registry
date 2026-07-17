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

namespace Arc56.Generated.kranthi1306.Carbonfootprint.CarbonFootprintContract_e78b7b91
{


    public class CarbonFootprintContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CarbonFootprintContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Opt into the contract to enable local state storage
        ///</summary>
        public async Task OptIn(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 198, 213, 138 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptIn_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 198, 213, 138 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Register a new IoT device to the system
        ///</summary>
        /// <param name="device_id"> </param>
        public async Task<ulong> RegisterDevice(string device_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 10, 94, 253, 91 };
            var device_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); device_idAbi.From(device_id);

            var result = await base.CallApp(new List<object> { abiHandle, device_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RegisterDevice_Transactions(string device_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 10, 94, 253, 91 };
            var device_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); device_idAbi.From(device_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, device_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Record carbon emission data from an IoT device
        ///</summary>
        /// <param name="device_id"> </param>
        /// <param name="emission_amount"> </param>
        public async Task<ulong> RecordEmission(string device_id, ulong emission_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 191, 139, 195 };
            var device_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); device_idAbi.From(device_id);
            var emission_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); emission_amountAbi.From(emission_amount);

            var result = await base.CallApp(new List<object> { abiHandle, device_idAbi, emission_amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RecordEmission_Transactions(string device_id, ulong emission_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 191, 139, 195 };
            var device_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); device_idAbi.From(device_id);
            var emission_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); emission_amountAbi.From(emission_amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, device_idAbi, emission_amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Transfer emission credits from sender to receiver
        ///</summary>
        /// <param name="receiver"> </param>
        /// <param name="emission_amount"> </param>
        public async Task TransferEmissions(Algorand.Address receiver, ulong emission_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 55, 201, 21, 179 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var emission_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); emission_amountAbi.From(emission_amount);

            var result = await base.CallApp(new List<object> { abiHandle, receiverAbi, emission_amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TransferEmissions_Transactions(Algorand.Address receiver, ulong emission_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 55, 201, 21, 179 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var emission_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); emission_amountAbi.From(emission_amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, receiverAbi, emission_amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the total carbon emissions recorded
        ///</summary>
        public async Task<ulong> GetTotalEmissions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 83, 194, 181, 240 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalEmissions_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 83, 194, 181, 240 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get emissions for the calling device (sender)
        ///</summary>
        public async Task<ulong> GetDeviceEmissions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 21, 204, 90, 233 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetDeviceEmissions_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 21, 204, 90, 233 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get emissions for a specific account
        ///</summary>
        /// <param name="account"> </param>
        public async Task<ulong> GetEmissionsForAccount(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 168, 102, 30 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.SimApp(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetEmissionsForAccount_Transactions(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 168, 102, 30 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the total number of registered devices
        ///</summary>
        public async Task<ulong> GetDeviceCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 35, 124, 247 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetDeviceCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 35, 124, 247 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the address of the transaction sender
        ///</summary>
        public async Task<Algorand.Address> GetSenderAddress(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 210, 84, 150 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> GetSenderAddress_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 210, 84, 150 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ2FyYm9uRm9vdHByaW50Q29udHJhY3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoib3B0X2luIiwiZGVzYyI6Ik9wdCBpbnRvIHRoZSBjb250cmFjdCB0byBlbmFibGUgbG9jYWwgc3RhdGUgc3RvcmFnZSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk9wdEluIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVnaXN0ZXJfZGV2aWNlIiwiZGVzYyI6IlJlZ2lzdGVyIGEgbmV3IElvVCBkZXZpY2UgdG8gdGhlIHN5c3RlbSIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZXZpY2VfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWNvcmRfZW1pc3Npb24iLCJkZXNjIjoiUmVjb3JkIGNhcmJvbiBlbWlzc2lvbiBkYXRhIGZyb20gYW4gSW9UIGRldmljZSIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZXZpY2VfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImVtaXNzaW9uX2Ftb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRyYW5zZmVyX2VtaXNzaW9ucyIsImRlc2MiOiJUcmFuc2ZlciBlbWlzc2lvbiBjcmVkaXRzIGZyb20gc2VuZGVyIHRvIHJlY2VpdmVyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNlaXZlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZW1pc3Npb25fYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF90b3RhbF9lbWlzc2lvbnMiLCJkZXNjIjoiR2V0IHRoZSB0b3RhbCBjYXJib24gZW1pc3Npb25zIHJlY29yZGVkIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfZGV2aWNlX2VtaXNzaW9ucyIsImRlc2MiOiJHZXQgZW1pc3Npb25zIGZvciB0aGUgY2FsbGluZyBkZXZpY2UgKHNlbmRlcikiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9lbWlzc2lvbnNfZm9yX2FjY291bnQiLCJkZXNjIjoiR2V0IGVtaXNzaW9ucyBmb3IgYSBzcGVjaWZpYyBhY2NvdW50IiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfZGV2aWNlX2NvdW50IiwiZGVzYyI6IkdldCB0aGUgdG90YWwgbnVtYmVyIG9mIHJlZ2lzdGVyZWQgZGV2aWNlcyIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3NlbmRlcl9hZGRyZXNzIiwiZGVzYyI6IkdldCB0aGUgYWRkcmVzcyBvZiB0aGUgdHJhbnNhY3Rpb24gc2VuZGVyIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjIsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlszMDBdLCJlcnJvck1lc3NhZ2UiOiJJbnN1ZmZpY2llbnQgZW1pc3Npb25zIHRvIHRyYW5zZmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTJdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTc4XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCAmJiBjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjddLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBPcHRJbiAmJiBjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjAzLDM3M10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZGV2aWNlX2NvdW50IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1NywyOTMsMzA3LDMxOSwzNDIsMzYyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5kZXZpY2VfZW1pc3Npb25zIGV4aXN0cyBmb3IgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0MCwzMjldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX2VtaXNzaW9ucyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTMsMjIyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk5LDIyOF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzksMzU4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzNiwyODddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ01pQTRDaUFnSUNCaWVYUmxZMkpzYjJOcklDSmtaWFpwWTJWZlpXMXBjM05wYjI1eklpQXdlREUxTVdZM1l6YzFJQ0owYjNSaGJGOWxiV2x6YzJsdmJuTWlJQ0prWlhacFkyVmZZMjkxYm5RaUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZ5WW05dVptOXZkSEJ5YVc1MEwyTnZiblJ5WVdOMExuQjVPalV0TmdvZ0lDQWdMeThnSXlCVGRHOXlaU0IwYjNSaGJDQmpZWEppYjI0Z1pXMXBjM05wYjI1eklISmxZMjl5WkdWa0NpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gyVnRhWE56YVc5dWN5QTlJRWRzYjJKaGJGTjBZWFJsS0ZWSmJuUTJOQ2d3S1N3Z2EyVjVQU0owYjNSaGJGOWxiV2x6YzJsdmJuTWlMQ0JrWlhOamNtbHdkR2x2YmowaVZHOTBZV3dnWTJGeVltOXVJR1Z0YVhOemFXOXVjeUJtY205dElHRnNiQ0JrWlhacFkyVnpJaWtLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJblJ2ZEdGc1gyVnRhWE56YVc5dWN5SUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaGNtSnZibVp2YjNSd2NtbHVkQzlqYjI1MGNtRmpkQzV3ZVRvM0xUZ0tJQ0FnSUM4dklDTWdVM1J2Y21VZ2JuVnRZbVZ5SUc5bUlFbHZWQ0JrWlhacFkyVnpJSEpsWjJsemRHVnlaV1FLSUNBZ0lDOHZJSE5sYkdZdVpHVjJhV05sWDJOdmRXNTBJRDBnUjJ4dlltRnNVM1JoZEdVb1ZVbHVkRFkwS0RBcExDQnJaWGs5SW1SbGRtbGpaVjlqYjNWdWRDSXNJR1JsYzJOeWFYQjBhVzl1UFNKT2RXMWlaWElnYjJZZ2NtVm5hWE4wWlhKbFpDQkpiMVFnWkdWMmFXTmxjeUlwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0prWlhacFkyVmZZMjkxYm5RaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhjbUp2Ym1admIzUndjbWx1ZEM5amIyNTBjbUZqZEM1d2VUb3pDaUFnSUNBdkx5QmpiR0Z6Y3lCRFlYSmliMjVHYjI5MGNISnBiblJEYjI1MGNtRmpkQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFNVGtLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRE13WXpaa05UaGhJQzh2SUcxbGRHaHZaQ0FpYjNCMFgybHVLQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5dmNIUmZhVzVmY205MWRHVkFOUW9LYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFEWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRnlZbTl1Wm05dmRIQnlhVzUwTDJOdmJuUnlZV04wTG5CNU9qTUtJQ0FnSUM4dklHTnNZWE56SUVOaGNtSnZia1p2YjNSd2NtbHVkRU52Ym5SeVlXTjBLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHMTFjM1FnWW1VZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEQmhOV1ZtWkRWaUlEQjRPR0ZpWmpoaVl6TWdNSGd6TjJNNU1UVmlNeUF3ZURVell6SmlOV1l3SURCNE1UVmpZelZoWlRrZ01IZzNPR0U0TmpZeFpTQXdlREF4TWpNM1kyWTNJREI0WVRsa01qVTBPVFlnTHk4Z2JXVjBhRzlrSUNKeVpXZHBjM1JsY2w5a1pYWnBZMlVvYzNSeWFXNW5LWFZwYm5RMk5DSXNJRzFsZEdodlpDQWljbVZqYjNKa1gyVnRhWE56YVc5dUtITjBjbWx1Wnl4MWFXNTBOalFwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0owY21GdWMyWmxjbDlsYldsemMybHZibk1vWVdSa2NtVnpjeXgxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaVoyVjBYM1J2ZEdGc1gyVnRhWE56YVc5dWN5Z3BkV2x1ZERZMElpd2diV1YwYUc5a0lDSm5aWFJmWkdWMmFXTmxYMlZ0YVhOemFXOXVjeWdwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0puWlhSZlpXMXBjM05wYjI1elgyWnZjbDloWTJOdmRXNTBLR0ZrWkhKbGMzTXBkV2x1ZERZMElpd2diV1YwYUc5a0lDSm5aWFJmWkdWMmFXTmxYMk52ZFc1MEtDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltZGxkRjl6Wlc1a1pYSmZZV1JrY21WemN5Z3BZV1JrY21WemN5SUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JSEpsWjJsemRHVnlYMlJsZG1salpTQnlaV052Y21SZlpXMXBjM05wYjI0Z2RISmhibk5tWlhKZlpXMXBjM05wYjI1eklHZGxkRjkwYjNSaGJGOWxiV2x6YzJsdmJuTWdaMlYwWDJSbGRtbGpaVjlsYldsemMybHZibk1nWjJWMFgyVnRhWE56YVc5dWMxOW1iM0pmWVdOamIzVnVkQ0JuWlhSZlpHVjJhV05sWDJOdmRXNTBJR2RsZEY5elpXNWtaWEpmWVdSa2NtVnpjd29nSUNBZ1pYSnlDZ3B0WVdsdVgyOXdkRjlwYmw5eWIzVjBaVUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oY21KdmJtWnZiM1J3Y21sdWRDOWpiMjUwY21GamRDNXdlVG94TWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5SlBjSFJKYmlKZEtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh4SUM4dklFOXdkRWx1Q2lBZ0lDQTlQUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ1ltQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUcxMWMzUWdZbVVnVDNCMFNXNGdKaVlnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWWlCdmNIUmZhVzRLQ20xaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1UazZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdiWFZ6ZENCaVpTQk9iMDl3SUNZbUlHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQmpjbVZoZEdsdVp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVqWVhKaWIyNW1iMjkwY0hKcGJuUXVZMjl1ZEhKaFkzUXVRMkZ5WW05dVJtOXZkSEJ5YVc1MFEyOXVkSEpoWTNRdWIzQjBYMmx1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2IzQjBYMmx1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oY21KdmJtWnZiM1J3Y21sdWRDOWpiMjUwY21GamRDNXdlVG94TlMweE5nb2dJQ0FnTHk4Z0l5QkpibWwwYVdGc2FYcGxJR1JsZG1salpTQmxiV2x6YzJsdmJuTWdkRzhnTUNCM2FHVnVJRzl3ZEdsdVp5QnBiZ29nSUNBZ0x5OGdjMlZzWmk1a1pYWnBZMlZmWlcxcGMzTnBiMjV6VzFSNGJpNXpaVzVrWlhKZElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKa1pYWnBZMlZmWlcxcGMzTnBiMjV6SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZWEppYjI1bWIyOTBjSEpwYm5RdlkyOXVkSEpoWTNRdWNIazZNVElLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaGhiR3h2ZDE5aFkzUnBiMjV6UFZzaVQzQjBTVzRpWFNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZMkZ5WW05dVptOXZkSEJ5YVc1MExtTnZiblJ5WVdOMExrTmhjbUp2YmtadmIzUndjbWx1ZEVOdmJuUnlZV04wTG5KbFoybHpkR1Z5WDJSbGRtbGpaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbFoybHpkR1Z5WDJSbGRtbGpaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZWEppYjI1bWIyOTBjSEpwYm5RdlkyOXVkSEpoWTNRdWNIazZNVGdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZ5WW05dVptOXZkSEJ5YVc1MEwyTnZiblJ5WVdOMExuQjVPakl4Q2lBZ0lDQXZMeUJ6Wld4bUxtUmxkbWxqWlY5amIzVnVkQzUyWVd4MVpTQXJQU0JWU1c1ME5qUW9NU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSmtaWFpwWTJWZlkyOTFiblFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVpHVjJhV05sWDJOdmRXNTBJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbVJsZG1salpWOWpiM1Z1ZENJS0lDQWdJR1JwWnlBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaGNtSnZibVp2YjNSd2NtbHVkQzlqYjI1MGNtRmpkQzV3ZVRveU1nb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1WkdWMmFXTmxYMk52ZFc1MExuWmhiSFZsS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oY21KdmJtWnZiM1J3Y21sdWRDOWpiMjUwY21GamRDNXdlVG94T0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1OaGNtSnZibVp2YjNSd2NtbHVkQzVqYjI1MGNtRmpkQzVEWVhKaWIyNUdiMjkwY0hKcGJuUkRiMjUwY21GamRDNXlaV052Y21SZlpXMXBjM05wYjI1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHlaV052Y21SZlpXMXBjM05wYjI0NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGeVltOXVabTl2ZEhCeWFXNTBMMk52Ym5SeVlXTjBMbkI1T2pJMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCemQyRndDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhjbUp2Ym1admIzUndjbWx1ZEM5amIyNTBjbUZqZEM1d2VUb3lOeTB5T0FvZ0lDQWdMeThnSXlCVmNHUmhkR1VnZEc5MFlXd2daVzFwYzNOcGIyNXpDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYMlZ0YVhOemFXOXVjeTUyWVd4MVpTQXJQU0JsYldsemMybHZibDloYlc5MWJuUXVibUYwYVhabENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpZEc5MFlXeGZaVzFwYzNOcGIyNXpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SdmRHRnNYMlZ0YVhOemFXOXVjeUJsZUdsemRITUtJQ0FnSUhOM1lYQUtJQ0FnSUdKMGIya0tJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXhDaUFnSUNBckNpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKMGIzUmhiRjlsYldsemMybHZibk1pQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVhKaWIyNW1iMjkwY0hKcGJuUXZZMjl1ZEhKaFkzUXVjSGs2TWprdE16QUtJQ0FnSUM4dklDTWdWWEJrWVhSbElHUmxkbWxqWlMxemNHVmphV1pwWXlCbGJXbHpjMmx2Ym5NS0lDQWdJQzh2SUhObGJHWXVaR1YyYVdObFgyVnRhWE56YVc5dWMxdFVlRzR1YzJWdVpHVnlYU0FyUFNCbGJXbHpjMmx2Ymw5aGJXOTFiblF1Ym1GMGFYWmxDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0prWlhacFkyVmZaVzFwYzNOcGIyNXpJZ29nSUNBZ1lYQndYMnh2WTJGc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WkdWMmFXTmxYMlZ0YVhOemFXOXVjeUJsZUdsemRITWdabTl5SUdGalkyOTFiblFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnS3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWkdWMmFXTmxYMlZ0YVhOemFXOXVjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZWEppYjI1bWIyOTBjSEpwYm5RdlkyOXVkSEpoWTNRdWNIazZNekVLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxuUnZkR0ZzWDJWdGFYTnphVzl1Y3k1MllXeDFaU2tLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZWEppYjI1bWIyOTBjSEpwYm5RdlkyOXVkSEpoWTNRdWNIazZNalFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVqWVhKaWIyNW1iMjkwY0hKcGJuUXVZMjl1ZEhKaFkzUXVRMkZ5WW05dVJtOXZkSEJ5YVc1MFEyOXVkSEpoWTNRdWRISmhibk5tWlhKZlpXMXBjM05wYjI1elczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkSEpoYm5ObVpYSmZaVzFwYzNOcGIyNXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhjbUp2Ym1admIzUndjbWx1ZEM5amIyNTBjbUZqZEM1d2VUb3pNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXpNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZ5WW05dVptOXZkSEJ5YVc1MEwyTnZiblJ5WVdOMExuQjVPak0yTFRNM0NpQWdJQ0F2THlBaklFVnVjM1Z5WlNCelpXNWtaWElnYUdGeklHVnViM1ZuYUNCbGJXbHpjMmx2Ym5NZ2RHOGdkSEpoYm5ObVpYSUtJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbVJsZG1salpWOWxiV2x6YzJsdmJuTmJWSGh1TG5ObGJtUmxjbDBnUGowZ1pXMXBjM05wYjI1ZllXMXZkVzUwTG01aGRHbDJaU3dnSWtsdWMzVm1abWxqYVdWdWRDQmxiV2x6YzJsdmJuTWdkRzhnZEhKaGJuTm1aWElpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVpHVjJhV05sWDJWdGFYTnphVzl1Y3lJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtUmxkbWxqWlY5bGJXbHpjMmx2Ym5NZ1pYaHBjM1J6SUdadmNpQmhZMk52ZFc1MENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZEc5cENpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJKYm5OMVptWnBZMmxsYm5RZ1pXMXBjM05wYjI1eklIUnZJSFJ5WVc1elptVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRnlZbTl1Wm05dmRIQnlhVzUwTDJOdmJuUnlZV04wTG5CNU9qTTVMVFF3Q2lBZ0lDQXZMeUFqSUVSbFpIVmpkQ0JtY205dElITmxibVJsY2dvZ0lDQWdMeThnYzJWc1ppNWtaWFpwWTJWZlpXMXBjM05wYjI1elcxUjRiaTV6Wlc1a1pYSmRJQzA5SUdWdGFYTnphVzl1WDJGdGIzVnVkQzV1WVhScGRtVUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbVJsZG1salpWOWxiV2x6YzJsdmJuTWlDaUFnSUNCaGNIQmZiRzlqWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVrWlhacFkyVmZaVzFwYzNOcGIyNXpJR1Y0YVhOMGN5Qm1iM0lnWVdOamIzVnVkQW9nSUNBZ1pHbG5JRElLSUNBZ0lDMEtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltUmxkbWxqWlY5bGJXbHpjMmx2Ym5NaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZmJHOWpZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGeVltOXVabTl2ZEhCeWFXNTBMMk52Ym5SeVlXTjBMbkI1T2pReExUUXlDaUFnSUNBdkx5QWpJRUZrWkNCMGJ5QnlaV05sYVhabGNnb2dJQ0FnTHk4Z2MyVnNaaTVrWlhacFkyVmZaVzFwYzNOcGIyNXpXM0psWTJWcGRtVnlYU0FyUFNCbGJXbHpjMmx2Ymw5aGJXOTFiblF1Ym1GMGFYWmxDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltUmxkbWxqWlY5bGJXbHpjMmx2Ym5NaUNpQWdJQ0JoY0hCZmJHOWpZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWtaWFpwWTJWZlpXMXBjM05wYjI1eklHVjRhWE4wY3lCbWIzSWdZV05qYjNWdWRBb2dJQ0FnS3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWkdWMmFXTmxYMlZ0YVhOemFXOXVjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZWEppYjI1bWIyOTBjSEpwYm5RdlkyOXVkSEpoWTNRdWNIazZNek1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVqWVhKaWIyNW1iMjkwY0hKcGJuUXVZMjl1ZEhKaFkzUXVRMkZ5WW05dVJtOXZkSEJ5YVc1MFEyOXVkSEpoWTNRdVoyVjBYM1J2ZEdGc1gyVnRhWE56YVc5dWMxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5MGIzUmhiRjlsYldsemMybHZibk02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZ5WW05dVptOXZkSEJ5YVc1MEwyTnZiblJ5WVdOMExuQjVPalEzQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNTBiM1JoYkY5bGJXbHpjMmx2Ym5NdWRtRnNkV1VwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlkRzkwWVd4ZlpXMXBjM05wYjI1eklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gyVnRhWE56YVc5dWN5QmxlR2x6ZEhNS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVhKaWIyNW1iMjkwY0hKcGJuUXZZMjl1ZEhKaFkzUXVjSGs2TkRRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVqWVhKaWIyNW1iMjkwY0hKcGJuUXVZMjl1ZEhKaFkzUXVRMkZ5WW05dVJtOXZkSEJ5YVc1MFEyOXVkSEpoWTNRdVoyVjBYMlJsZG1salpWOWxiV2x6YzJsdmJuTmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZlpHVjJhV05sWDJWdGFYTnphVzl1Y3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVhKaWIyNW1iMjkwY0hKcGJuUXZZMjl1ZEhKaFkzUXVjSGs2TlRJS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExsVkpiblEyTkNoelpXeG1MbVJsZG1salpWOWxiV2x6YzJsdmJuTmJWSGh1TG5ObGJtUmxjbDBwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVpHVjJhV05sWDJWdGFYTnphVzl1Y3lJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtUmxkbWxqWlY5bGJXbHpjMmx2Ym5NZ1pYaHBjM1J6SUdadmNpQmhZMk52ZFc1MENpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGeVltOXVabTl2ZEhCeWFXNTBMMk52Ym5SeVlXTjBMbkI1T2pRNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WTJGeVltOXVabTl2ZEhCeWFXNTBMbU52Ym5SeVlXTjBMa05oY21KdmJrWnZiM1J3Y21sdWRFTnZiblJ5WVdOMExtZGxkRjlsYldsemMybHZibk5mWm05eVgyRmpZMjkxYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJmWlcxcGMzTnBiMjV6WDJadmNsOWhZMk52ZFc1ME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaGNtSnZibVp2YjNSd2NtbHVkQzlqYjI1MGNtRmpkQzV3ZVRvMU5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZ5WW05dVptOXZkSEJ5YVc1MEwyTnZiblJ5WVdOMExuQjVPalUzQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNWtaWFpwWTJWZlpXMXBjM05wYjI1elcyRmpZMjkxYm5SZEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1SbGRtbGpaVjlsYldsemMybHZibk1pQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1a1pYWnBZMlZmWlcxcGMzTnBiMjV6SUdWNGFYTjBjeUJtYjNJZ1lXTmpiM1Z1ZEFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oY21KdmJtWnZiM1J3Y21sdWRDOWpiMjUwY21GamRDNXdlVG8xTkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbU5oY21KdmJtWnZiM1J3Y21sdWRDNWpiMjUwY21GamRDNURZWEppYjI1R2IyOTBjSEpwYm5SRGIyNTBjbUZqZEM1blpYUmZaR1YyYVdObFgyTnZkVzUwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBYMlJsZG1salpWOWpiM1Z1ZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVhKaWIyNW1iMjkwY0hKcGJuUXZZMjl1ZEhKaFkzUXVjSGs2TmpJS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExsVkpiblEyTkNoelpXeG1MbVJsZG1salpWOWpiM1Z1ZEM1MllXeDFaU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSmtaWFpwWTJWZlkyOTFiblFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVpHVjJhV05sWDJOdmRXNTBJR1Y0YVhOMGN3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaGNtSnZibVp2YjNSd2NtbHVkQzlqYjI1MGNtRmpkQzV3ZVRvMU9Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1OaGNtSnZibVp2YjNSd2NtbHVkQzVqYjI1MGNtRmpkQzVEWVhKaWIyNUdiMjkwY0hKcGJuUkRiMjUwY21GamRDNW5aWFJmYzJWdVpHVnlYMkZrWkhKbGMzTmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZmMyVnVaR1Z5WDJGa1pISmxjM002Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZ5WW05dVptOXZkSEJ5YVc1MEwyTnZiblJ5WVdOMExuQjVPalkwQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oY21KdmJtWnZiM1J3Y21sdWRDOWpiMjUwY21GamRDNXdlVG8yTndvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUxtSjVkR1Z6S1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhjbUp2Ym1admIzUndjbWx1ZEM5amIyNTBjbUZqZEM1d2VUbzJOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFQ0NDWUVFR1JsZG1salpWOWxiV2x6YzJsdmJuTUVGUjk4ZFE5MGIzUmhiRjlsYldsemMybHZibk1NWkdWMmFXTmxYMk52ZFc1ME1SaEFBQVlxSW1jckltY3hHMEVBWDRBRU1NYlZpallhQUk0QkFFY3hHUlJFTVJoRWdnZ0VDbDc5V3dTS3Y0dkRCRGZKRmJNRVU4SzE4QVFWekZycEJIaW9aaDRFQVNOODl3U3AwbFNXTmhvQWpnZ0FIUUE2QUhBQXB3Q3lBTDhBMHdEZUFERVpJeEl4R0JCRVFnQUtNUmtVTVJnVUVFUWpRekVBS0NKbUkwTTJHZ0ZKSWxra0NFd1ZFa1FpSzJWRUl3Z3JTd0ZuRmlsTVVMQWpRellhQVVraVdTUUlUQlVTUkRZYUFra1ZKUkpFSWlwbFJFd1hURXNCQ0NwTEFXY3hBRWtpS0dORVR3TUlLRXhtRmlsTVVMQWpRellhQVVrVmdTQVNSRFlhQWtrVkpSSkVNUUFpS0dORVRCZE1Td0VQUkRFQVNTSW9ZMFJMQWdrb1RHWkxBU0lvWTBRSUtFeG1JME1pS21WRUZpbE1VTEFqUXpFQUlpaGpSQllwVEZDd0kwTTJHZ0ZKRllFZ0VrUWlLR05FRmlsTVVMQWpReUlyWlVRV0tVeFFzQ05ES1RFQVVMQWpRdz09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MywicGF0Y2giOjIsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
