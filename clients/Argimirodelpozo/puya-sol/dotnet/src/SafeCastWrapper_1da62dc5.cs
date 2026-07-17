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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.SafeCastWrapper_1da62dc5
{


    public class SafeCastWrapperProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SafeCastWrapperProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="x"> </param>
        public async Task<ulong> ToUint8(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 34, 100, 45, 113 };

            var result = await base.SimApp(new List<object> { abiHandle, x }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ToUint8_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 34, 100, 45, 113 };

            return await base.MakeTransactionList(new List<object> { abiHandle, x }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="x"> </param>
        public async Task<ulong> ToUint16(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 140, 206, 80, 187 };

            var result = await base.SimApp(new List<object> { abiHandle, x }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ToUint16_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 140, 206, 80, 187 };

            return await base.MakeTransactionList(new List<object> { abiHandle, x }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="x"> </param>
        public async Task<ulong> ToUint32(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 201, 159, 240 };

            var result = await base.SimApp(new List<object> { abiHandle, x }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ToUint32_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 201, 159, 240 };

            return await base.MakeTransactionList(new List<object> { abiHandle, x }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="x"> </param>
        public async Task<ulong> ToUint64(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 158, 125, 209, 188 };

            var result = await base.SimApp(new List<object> { abiHandle, x }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ToUint64_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 158, 125, 209, 188 };

            return await base.MakeTransactionList(new List<object> { abiHandle, x }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="x"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> ToUint128(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 66, 143, 96 };

            var result = await base.SimApp(new List<object> { abiHandle, x }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> ToUint128_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 66, 143, 96 };

            return await base.MakeTransactionList(new List<object> { abiHandle, x }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="x"> </param>
        public async Task<ulong> ToInt8(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 65, 192, 18, 71 };

            var result = await base.SimApp(new List<object> { abiHandle, x }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ToInt8_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 65, 192, 18, 71 };

            return await base.MakeTransactionList(new List<object> { abiHandle, x }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="x"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> ToInt256(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 90, 74, 198 };

            var result = await base.SimApp(new List<object> { abiHandle, x }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> ToInt256_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 90, 74, 198 };

            return await base.MakeTransactionList(new List<object> { abiHandle, x }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="x"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> ToUint256(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 62, 127, 253 };

            var result = await base.SimApp(new List<object> { abiHandle, x }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> ToUint256_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 62, 127, 253 };

            return await base.MakeTransactionList(new List<object> { abiHandle, x }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU2FmZUNhc3RXcmFwcGVyIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6InRvVWludDgiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6IngiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRvVWludDE2IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0b1VpbnQzMiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoieCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidG9VaW50NjQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6IngiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRvVWludDEyOCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoieCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRvSW50OCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoieCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidG9JbnQyNTYiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6IngiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0b1VpbnQyNTYiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6IngiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzQ2MCw0ODQsNTA4LDUzMiw1NTYsNTg3LDYxMSw2NDJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50MjU2IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTcwLDYyNSw2NTZdLCJlcnJvck1lc3NhZ2UiOiJvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ1Ml0sImVycm9yTWVzc2FnZSI6InJldmVydCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12YzI5c1lXUjVMMkYxZUMxM2NtRndjR1Z5Y3kxMGJ5MWtaWEJzYjNrdlUyRm1aVU5oYzNSWGNtRndjR1Z5TG5OdmJDNVRZV1psUTJGemRGZHlZWEJ3WlhJdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF6TWlBd0lEZ2dNU0F5TURBd0NpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE1UVXhaamRqTnpVZ01IZzRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdJREI0TURZNE1UQXhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0JwYm5Salh6TWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlREl5TmpReVpEY3hJREI0T0dOalpUVXdZbUlnTUhnelltTTVPV1ptTUNBd2VEbGxOMlJrTVdKaklEQjRZMlUwTWpobU5qQWdNSGcwTVdNd01USTBOeUF3ZUdFNU5XRTBZV00ySURCNFlUWXpaVGRtWm1RZ0x5OGdiV1YwYUc5a0lDSjBiMVZwYm5RNEtIVnBiblF5TlRZcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKMGIxVnBiblF4TmloMWFXNTBNalUyS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpZEc5VmFXNTBNeklvZFdsdWRESTFOaWwxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJblJ2VldsdWREWTBLSFZwYm5ReU5UWXBkV2x1ZERZMElpd2diV1YwYUc5a0lDSjBiMVZwYm5ReE1qZ29kV2x1ZERJMU5pbDFhVzUwTWpVMklpd2diV1YwYUc5a0lDSjBiMGx1ZERnb2RXbHVkREkxTmlsMWFXNTBOalFpTENCdFpYUm9iMlFnSW5SdlNXNTBNalUyS0hWcGJuUXlOVFlwZFdsdWRESTFOaUlzSUcxbGRHaHZaQ0FpZEc5VmFXNTBNalUyS0hWcGJuUXlOVFlwZFdsdWRESTFOaUlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUhSdlZXbHVkRGdnZEc5VmFXNTBNVFlnZEc5VmFXNTBNeklnZEc5VmFXNTBOalFnZEc5VmFXNTBNVEk0SUhSdlNXNTBPQ0IwYjBsdWRESTFOaUIwYjFWcGJuUXlOVFlLSUNBZ0lHVnljZ29LQ2k4dklGOXdkWGxoWDJ4cFlpNTFkR2xzTG1WdWMzVnlaVjlpZFdSblpYUW9jbVZ4ZFdseVpXUmZZblZrWjJWME9pQjFhVzUwTmpRc0lHWmxaVjl6YjNWeVkyVTZJSFZwYm5RMk5Da2dMVDRnZG05cFpEb0taVzV6ZFhKbFgySjFaR2RsZERvS0lDQWdJSEJ5YjNSdklESWdNQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCd2RYTm9hVzUwSURFd0NpQWdJQ0FyQ2dwbGJuTjFjbVZmWW5Wa1oyVjBYM2RvYVd4bFgzUnZjRUF4T2dvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHZHNiMkpoYkNCUGNHTnZaR1ZDZFdSblpYUUtJQ0FnSUQ0S0lDQWdJR0o2SUdWdWMzVnlaVjlpZFdSblpYUmZZV1owWlhKZmQyaHBiR1ZBTmdvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2NIVnphR2x1ZENBMklDOHZJR0Z3Y0d3S0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lIQjFjMmhwYm5RZ05TQXZMeUJFWld4bGRHVkJjSEJzYVdOaGRHbHZiZ29nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TmpneE1ERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndjbTkyWVd4UWNtOW5jbUZ0Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURZNE1UQXhDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnNaV0Z5VTNSaGRHVlFjbTluY21GdENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSE4zYVhSamFDQmxibk4xY21WZlluVmtaMlYwWDNOM2FYUmphRjlqWVhObFh6QkFNeUJsYm5OMWNtVmZZblZrWjJWMFgzTjNhWFJqYUY5allYTmxYekZBTkFvS1pXNXpkWEpsWDJKMVpHZGxkRjl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRRFU2Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ1lpQmxibk4xY21WZlluVmtaMlYwWDNkb2FXeGxYM1J2Y0VBeENncGxibk4xY21WZlluVmtaMlYwWDNOM2FYUmphRjlqWVhObFh6RkFORG9LSUNBZ0lHZHNiMkpoYkNCTmFXNVVlRzVHWldVS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JpSUdWdWMzVnlaVjlpZFdSblpYUmZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQTFDZ3BsYm5OMWNtVmZZblZrWjJWMFgzTjNhWFJqYUY5allYTmxYekJBTXpvS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdZaUJsYm5OMWNtVmZZblZrWjJWMFgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU5Rb0taVzV6ZFhKbFgySjFaR2RsZEY5aFpuUmxjbDkzYUdsc1pVQTJPZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzTnZiR0ZrZVM5aGRYZ3RkM0poY0hCbGNuTXRkRzh0WkdWd2JHOTVMMU5oWm1WRFlYTjBWM0poY0hCbGNpNXpiMnd1VTJGbVpVTmhjM1JNYVdJdWRHOVZhVzUwT0NoNE9pQmllWFJsY3lrZ0xUNGdkV2x1ZERZME9ncFRZV1psUTJGemRFeHBZaTUwYjFWcGJuUTRPZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0J3ZFhOb2FXNTBJREkxTmdvZ0lDQWdhWFJ2WWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmlQRDBLSUNBZ0lHSjZJRk5oWm1WRFlYTjBUR2xpTG5SdlZXbHVkRGhmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNCaUlGTmhabVZEWVhOMFRHbGlMbDl5WlhabGNuUlBkbVZ5Wm14dmR3b0tVMkZtWlVOaGMzUk1hV0l1ZEc5VmFXNTBPRjloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJQzBLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZjMjlzWVdSNUwyRjFlQzEzY21Gd2NHVnljeTEwYnkxa1pYQnNiM2t2VTJGbVpVTmhjM1JYY21Gd2NHVnlMbk52YkM1VFlXWmxRMkZ6ZEV4cFlpNTBiMVZwYm5ReE5paDRPaUJpZVhSbGN5a2dMVDRnZFdsdWREWTBPZ3BUWVdabFEyRnpkRXhwWWk1MGIxVnBiblF4TmpvS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ2NIVnphR2x1ZENBMk5UVXpOZ29nSUNBZ2FYUnZZZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaVBEMEtJQ0FnSUdKNklGTmhabVZEWVhOMFRHbGlMblJ2VldsdWRERTJYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnWWlCVFlXWmxRMkZ6ZEV4cFlpNWZjbVYyWlhKMFQzWmxjbVpzYjNjS0NsTmhabVZEWVhOMFRHbGlMblJ2VldsdWRERTJYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0JpZW1WeWJ3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdMUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXpiMnhoWkhrdllYVjRMWGR5WVhCd1pYSnpMWFJ2TFdSbGNHeHZlUzlUWVdabFEyRnpkRmR5WVhCd1pYSXVjMjlzTGxOaFptVkRZWE4wVEdsaUxuUnZWV2x1ZERNeUtIZzZJR0o1ZEdWektTQXRQaUIxYVc1ME5qUTZDbE5oWm1WRFlYTjBUR2xpTG5SdlZXbHVkRE15T2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNCd2RYTm9hVzUwSURReU9UUTVOamN5T1RZS0lDQWdJR2wwYjJJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZanc5Q2lBZ0lDQmllaUJUWVdabFEyRnpkRXhwWWk1MGIxVnBiblF6TWw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lHSWdVMkZtWlVOaGMzUk1hV0l1WDNKbGRtVnlkRTkyWlhKbWJHOTNDZ3BUWVdabFEyRnpkRXhwWWk1MGIxVnBiblF6TWw5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1lucGxjbThLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUMwS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12YzI5c1lXUjVMMkYxZUMxM2NtRndjR1Z5Y3kxMGJ5MWtaWEJzYjNrdlUyRm1aVU5oYzNSWGNtRndjR1Z5TG5OdmJDNVRZV1psUTJGemRFeHBZaTUwYjFWcGJuUTJOQ2g0T2lCaWVYUmxjeWtnTFQ0Z2RXbHVkRFkwT2dwVFlXWmxRMkZ6ZEV4cFlpNTBiMVZwYm5RMk5Eb0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSStQUW9nSUNBZ1lub2dVMkZtWlVOaGMzUk1hV0l1ZEc5VmFXNTBOalJmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNCaUlGTmhabVZEWVhOMFRHbGlMbDl5WlhabGNuUlBkbVZ5Wm14dmR3b0tVMkZtWlVOaGMzUk1hV0l1ZEc5VmFXNTBOalJmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUdKNlpYSnZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0F0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM052YkdGa2VTOWhkWGd0ZDNKaGNIQmxjbk10ZEc4dFpHVndiRzk1TDFOaFptVkRZWE4wVjNKaGNIQmxjaTV6YjJ3dVUyRm1aVU5oYzNSTWFXSXVkRzlWYVc1ME1USTRLSGc2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LVTJGbVpVTmhjM1JNYVdJdWRHOVZhVzUwTVRJNE9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJK1BRb2dJQ0FnWW5vZ1UyRm1aVU5oYzNSTWFXSXVkRzlWYVc1ME1USTRYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnWWlCVFlXWmxRMkZ6ZEV4cFlpNWZjbVYyWlhKMFQzWmxjbVpzYjNjS0NsTmhabVZEWVhOMFRHbGlMblJ2VldsdWRERXlPRjloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptQ2lBZ0lDQmlKZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzTnZiR0ZrZVM5aGRYZ3RkM0poY0hCbGNuTXRkRzh0WkdWd2JHOTVMMU5oWm1WRFlYTjBWM0poY0hCbGNpNXpiMnd1VTJGbVpVTmhjM1JNYVdJdWRHOUpiblE0S0RFcFh6QW9lRG9nWW5sMFpYTXBJQzArSUhWcGJuUTJORG9LVTJGbVpVTmhjM1JNYVdJdWRHOUpiblE0T2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNCd2RYTm9hVzUwSURFeU9Bb2dJQ0FnYVhSdllnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpS3dvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREV3TUFvZ0lDQWdZaThLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRHOWlDaUFnSUNCaVBUMEtJQ0FnSUdKNklGTmhabVZEWVhOMFRHbGlMbDl5WlhabGNuUlBkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJR0o2WlhKdkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQXRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzTnZiR0ZrZVM5aGRYZ3RkM0poY0hCbGNuTXRkRzh0WkdWd2JHOTVMMU5oWm1WRFlYTjBWM0poY0hCbGNpNXpiMnd1VTJGbVpVTmhjM1JNYVdJdWRHOUpiblF5TlRZb2VEb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncFRZV1psUTJGemRFeHBZaTUwYjBsdWRESTFOam9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE9EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWw0S0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpUGowS0lDQWdJR0o2SUZOaFptVkRZWE4wVEdsaUxsOXlaWFpsY25SUGRtVnlabXh2ZHdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZjMjlzWVdSNUwyRjFlQzEzY21Gd2NHVnljeTEwYnkxa1pYQnNiM2t2VTJGbVpVTmhjM1JYY21Gd2NHVnlMbk52YkM1VFlXWmxRMkZ6ZEV4cFlpNTBiMVZwYm5ReU5UWW9lRG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BUWVdabFEyRnpkRXhwWWk1MGIxVnBiblF5TlRZNkNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlRGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSmVDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRPREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lqNDlDaUFnSUNCaWVpQlRZV1psUTJGemRFeHBZaTVmY21WMlpYSjBUM1psY21ac2IzY0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNOdmJHRmtlUzloZFhndGQzSmhjSEJsY25NdGRHOHRaR1Z3Ykc5NUwxTmhabVZEWVhOMFYzSmhjSEJsY2k1emIyd3VVMkZtWlVOaGMzUk1hV0l1WDNKbGRtVnlkRTkyWlhKbWJHOTNLQ2tnTFQ0Z2RtOXBaRG9LVTJGbVpVTmhjM1JNYVdJdVgzSmxkbVZ5ZEU5MlpYSm1iRzkzT2dvZ0lDQWdaWEp5SUM4dklISmxkbVZ5ZEFvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXpiMnhoWkhrdllYVjRMWGR5WVhCd1pYSnpMWFJ2TFdSbGNHeHZlUzlUWVdabFEyRnpkRmR5WVhCd1pYSXVjMjlzTGxOaFptVkRZWE4wVjNKaGNIQmxjaTUwYjFWcGJuUTRXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZEc5VmFXNTBPRG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnYVc1MFl5QTBJQzh2SURJd01EQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JqWVd4c2MzVmlJR1Z1YzNWeVpWOWlkV1JuWlhRS0lDQWdJR05oYkd4emRXSWdVMkZtWlVOaGMzUk1hV0l1ZEc5VmFXNTBPQW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh6SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5emIyeGhaSGt2WVhWNExYZHlZWEJ3WlhKekxYUnZMV1JsY0d4dmVTOVRZV1psUTJGemRGZHlZWEJ3WlhJdWMyOXNMbE5oWm1WRFlYTjBWM0poY0hCbGNpNTBiMVZwYm5ReE5sdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblJ2VldsdWRERTJPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0JwYm5SaklEUWdMeThnTWpBd01Bb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR05oYkd4emRXSWdaVzV6ZFhKbFgySjFaR2RsZEFvZ0lDQWdZMkZzYkhOMVlpQlRZV1psUTJGemRFeHBZaTUwYjFWcGJuUXhOZ29nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh6SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5emIyeGhaSGt2WVhWNExYZHlZWEJ3WlhKekxYUnZMV1JsY0d4dmVTOVRZV1psUTJGemRGZHlZWEJ3WlhJdWMyOXNMbE5oWm1WRFlYTjBWM0poY0hCbGNpNTBiMVZwYm5Rek1sdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblJ2VldsdWRETXlPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0JwYm5SaklEUWdMeThnTWpBd01Bb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR05oYkd4emRXSWdaVzV6ZFhKbFgySjFaR2RsZEFvZ0lDQWdZMkZzYkhOMVlpQlRZV1psUTJGemRFeHBZaTUwYjFWcGJuUXpNZ29nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh6SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5emIyeGhaSGt2WVhWNExYZHlZWEJ3WlhKekxYUnZMV1JsY0d4dmVTOVRZV1psUTJGemRGZHlZWEJ3WlhJdWMyOXNMbE5oWm1WRFlYTjBWM0poY0hCbGNpNTBiMVZwYm5RMk5GdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblJ2VldsdWREWTBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0JwYm5SaklEUWdMeThnTWpBd01Bb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR05oYkd4emRXSWdaVzV6ZFhKbFgySjFaR2RsZEFvZ0lDQWdZMkZzYkhOMVlpQlRZV1psUTJGemRFeHBZaTUwYjFWcGJuUTJOQW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh6SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5emIyeGhaSGt2WVhWNExYZHlZWEJ3WlhKekxYUnZMV1JsY0d4dmVTOVRZV1psUTJGemRGZHlZWEJ3WlhJdWMyOXNMbE5oWm1WRFlYTjBWM0poY0hCbGNpNTBiMVZwYm5ReE1qaGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AwYjFWcGJuUXhNamc2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUdsdWRHTWdOQ0F2THlBeU1EQXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWTJGc2JITjFZaUJsYm5OMWNtVmZZblZrWjJWMENpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WRFlYTjBUR2xpTG5SdlZXbHVkREV5T0FvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZbndLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTXlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmMyOXNZV1I1TDJGMWVDMTNjbUZ3Y0dWeWN5MTBieTFrWlhCc2Iza3ZVMkZtWlVOaGMzUlhjbUZ3Y0dWeUxuTnZiQzVUWVdabFEyRnpkRmR5WVhCd1pYSXVkRzlKYm5RNFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkRzlKYm5RNE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQnBiblJqSURRZ0x5OGdNakF3TUFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHTmhiR3h6ZFdJZ1pXNXpkWEpsWDJKMVpHZGxkQW9nSUNBZ1kyRnNiSE4xWWlCVFlXWmxRMkZ6ZEV4cFlpNTBiMGx1ZERnS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk15QXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZjMjlzWVdSNUwyRjFlQzEzY21Gd2NHVnljeTEwYnkxa1pYQnNiM2t2VTJGbVpVTmhjM1JYY21Gd2NHVnlMbk52YkM1VFlXWmxRMkZ6ZEZkeVlYQndaWEl1ZEc5SmJuUXlOVFpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMGIwbHVkREkxTmpvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ2FXNTBZeUEwSUM4dklESXdNREFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCallXeHNjM1ZpSUdWdWMzVnlaVjlpZFdSblpYUUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVTmhjM1JNYVdJdWRHOUpiblF5TlRZS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR0o4Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzTnZiR0ZrZVM5aGRYZ3RkM0poY0hCbGNuTXRkRzh0WkdWd2JHOTVMMU5oWm1WRFlYTjBWM0poY0hCbGNpNXpiMnd1VTJGbVpVTmhjM1JYY21Gd2NHVnlMblJ2VldsdWRESTFObHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25SdlZXbHVkREkxTmpvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ2FXNTBZeUEwSUM4dklESXdNREFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCallXeHNjM1ZpSUdWdWMzVnlaVjlpZFdSblpYUUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVTmhjM1JNYVdJdWRHOVZhVzUwTWpVMkNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JpZkFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eklDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12YzI5c1lXUjVMMkYxZUMxM2NtRndjR1Z5Y3kxMGJ5MWtaWEJzYjNrdlUyRm1aVU5oYzNSWGNtRndjR1Z5TG5OdmJDNVRZV1psUTJGemRGZHlZWEJ3WlhJdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFGSUFBSUFkQVBKZ01FRlI5OGRTQ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFNR2dRRXhHRUFBQWlWRE1Sa1VSREVZUklJSUJDSmtMWEVFak01UXV3UTd5Wi93Qko1OTBid0V6a0tQWUFSQndCSkhCS2xhU3NZRXBqNS8vVFlhQUk0SUFVTUJXd0Z6QVlzQm93SENBZG9CK1FDS0FnQ0wvb0VLQ0lzQU1nd05RUUFvc1lFR3NoQ0JCYklaS3JJZUtySWZpLytOQWdBTEFBU3pRdi9kTWdDeUFVTC85U095QVVMLzc0bUtBUUdCZ0FJV2kvK21RUUFEUWdENEpLK0wvMUJKRlNRSlc0bUtBUUdCZ0lBRUZvdi9wa0VBQTBJQTNDU3ZpLzlRU1JVa0NWdUppZ0VCZ1lDQWdJQVFGb3YvcGtFQUEwSUF2aVN2aS85UVNSVWtDVnVKaWdFQmkvK0FDUUVBQUFBQUFBQUFBS2RCQUFOQ0FKd2tyNHYvVUVrVkpBbGJpWW9CQVl2L2dCRUJBQUFBQUFBQUFBQUFBQUFBQUFBQUFLZEJBQU5DQUhLTC80QVEvLy8vLy8vLy8vLy8vLy8vLy8vLy82eUppZ0VCZ1lBQkZvdi9vSUFnQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFRQ2lJeGFvUVFBcEpLK0wvMUJKRlNRSlc0bUtBUUdML3ltdEthZEJBQktMLzRtS0FRR0wveW10S2FkQkFBT0wvNGtBTmhvQlNSVWlFa1FoQkNPSS9yQ0kvdVlXS0V4UXNDVkROaG9CU1JVaUVrUWhCQ09JL3BpSS91a1dLRXhRc0NWRE5ob0JTUlVpRWtRaEJDT0kvb0NJL3UwV0tFeFFzQ1ZETmhvQlNSVWlFa1FoQkNPSS9taUkvdk1XS0V4UXNDVkROaG9CU1JVaUVrUWhCQ09JL2xDSS92MUpGU0lPUkNLdnF5aE1VTEFsUXpZYUFVa1ZJaEpFSVFRamlQNHhpUDhURmloTVVMQWxRellhQVVrVkloSkVJUVFqaVA0WmlQODVTUlVpRGtRaXI2c29URkN3SlVNMkdnRkpGU0lTUkNFRUk0ajkrb2ovS1VrVklnNUVJcStyS0V4UXNDVkQiLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo3LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
