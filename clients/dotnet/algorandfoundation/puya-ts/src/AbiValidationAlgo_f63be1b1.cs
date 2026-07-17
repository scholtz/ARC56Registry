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

namespace Arc56.Generated.algorandfoundation.puya_ts.AbiValidationAlgo_f63be1b1
{


    public class AbiValidationAlgoProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AbiValidationAlgoProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task<ulong> WithValidation(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 62, 156, 51 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> WithValidation_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 62, 156, 51 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task<ulong> WithoutValidation(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 224, 224, 112, 116 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> WithoutValidation_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 224, 224, 112, 116 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task<ulong> DefaultValidation(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 160, 210, 81 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> DefaultValidation_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 160, 210, 81 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task<ulong> ManualValidation(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 230, 22, 50, 193 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ManualValidation_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 230, 22, 50, 193 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="rawBytes"> </param>
        public async Task<ulong> ManualValidationInConvert(byte[] rawBytes, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 134, 188, 0 };
            var rawBytesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); rawBytesAbi.From(rawBytes);

            var result = await base.CallApp(new List<object> { abiHandle, rawBytesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ManualValidationInConvert_Transactions(byte[] rawBytes, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 134, 188, 0 };
            var rawBytesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); rawBytesAbi.From(rawBytes);

            return await base.MakeTransactionList(new List<object> { abiHandle, rawBytesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="rawBytes"> </param>
        public async Task<ulong> ManualValidationAfterConvert(byte[] rawBytes, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 240, 93, 16 };
            var rawBytesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); rawBytesAbi.From(rawBytes);

            var result = await base.CallApp(new List<object> { abiHandle, rawBytesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ManualValidationAfterConvert_Transactions(byte[] rawBytes, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 240, 93, 16 };
            var rawBytesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); rawBytesAbi.From(rawBytes);

            return await base.MakeTransactionList(new List<object> { abiHandle, rawBytesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWJpVmFsaWRhdGlvbkFsZ28iLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoid2l0aFZhbGlkYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IndpdGhvdXRWYWxpZGF0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWZhdWx0VmFsaWRhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibWFudWFsVmFsaWRhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibWFudWFsVmFsaWRhdGlvbkluQ29udmVydCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyYXdCeXRlcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1hbnVhbFZhbGlkYXRpb25BZnRlckNvbnZlcnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmF3Qnl0ZXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzI1MCwyODJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTksMjkxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3NCwyMTMsMzQ3LDM2MywzNzddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3SURNeUlESUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnWWlCdFlXbHVYMkpzYjJOclFEQUtDbTFoYVc1ZllteHZZMnRBTURvS0lDQWdJR0lnYldGcGJsOWliRzlqYTBBeENncHRZV2x1WDJKc2IyTnJRREU2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dVlXeG5ieTUwY3pvMkNpQWdJQ0F2THlCamJHRnpjeUJCWW1sV1lXeHBaR0YwYVc5dVFXeG5ieUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0lUMEtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRREV6Q2lBZ0lDQmlJRzFoYVc1ZllXSnBYM0p2ZFhScGJtZEFNZ29LYldGcGJsOWhZbWxmY205MWRHbHVaMEF5T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxtRnNaMjh1ZEhNNk5nb2dJQ0FnTHk4Z1kyeGhjM01nUVdKcFZtRnNhV1JoZEdsdmJrRnNaMjhnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6RWdMeThnVG05UGNBb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNBaFBRb2dJQ0FnWW5vZ2JXRnBibDlqY21WaGRHVmZUbTlQY0VBeE1Rb2dJQ0FnWWlCdFlXbHVYMk5oYkd4ZlRtOVBjRUF6Q2dwdFlXbHVYMk5oYkd4ZlRtOVBjRUF6T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxtRnNaMjh1ZEhNNk5nb2dJQ0FnTHk4Z1kyeGhjM01nUVdKcFZtRnNhV1JoZEdsdmJrRnNaMjhnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd5TmpObE9XTXpNeUF2THlCdFpYUm9iMlFnSW5kcGRHaFdZV3hwWkdGMGFXOXVLR0o1ZEdWYk16SmRLWFZwYm5RMk5DSUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHVXdaVEEzTURjMElDOHZJRzFsZEdodlpDQWlkMmwwYUc5MWRGWmhiR2xrWVhScGIyNG9ZbmwwWlZzek1sMHBkV2x1ZERZMElnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5EWmhNR1F5TlRFZ0x5OGdiV1YwYUc5a0lDSmtaV1poZFd4MFZtRnNhV1JoZEdsdmJpaGllWFJsV3pNeVhTbDFhVzUwTmpRaUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhobE5qRTJNekpqTVNBdkx5QnRaWFJvYjJRZ0ltMWhiblZoYkZaaGJHbGtZWFJwYjI0b1lubDBaVnN6TWwwcGRXbHVkRFkwSWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0Wm1JNE5tSmpNREFnTHk4Z2JXVjBhRzlrSUNKdFlXNTFZV3hXWVd4cFpHRjBhVzl1U1c1RGIyNTJaWEowS0dKNWRHVmJYU2wxYVc1ME5qUWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGpNR1l3TldReE1DQXZMeUJ0WlhSb2IyUWdJbTFoYm5WaGJGWmhiR2xrWVhScGIyNUJablJsY2tOdmJuWmxjblFvWW5sMFpWdGRLWFZwYm5RMk5DSUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdiV0YwWTJnZ2JXRnBibDkzYVhSb1ZtRnNhV1JoZEdsdmJsOXliM1YwWlVBMElHMWhhVzVmZDJsMGFHOTFkRlpoYkdsa1lYUnBiMjVmY205MWRHVkFOU0J0WVdsdVgyUmxabUYxYkhSV1lXeHBaR0YwYVc5dVgzSnZkWFJsUURZZ2JXRnBibDl0WVc1MVlXeFdZV3hwWkdGMGFXOXVYM0p2ZFhSbFFEY2diV0ZwYmw5dFlXNTFZV3hXWVd4cFpHRjBhVzl1U1c1RGIyNTJaWEowWDNKdmRYUmxRRGdnYldGcGJsOXRZVzUxWVd4V1lXeHBaR0YwYVc5dVFXWjBaWEpEYjI1MlpYSjBYM0p2ZFhSbFFEa0tJQ0FnSUdJZ2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRREV3Q2dwdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFNVEE2Q2lBZ0lDQmlJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TWdvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERXlPZ29nSUNBZ1lpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVFFLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE5Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTVoYkdkdkxuUnpPallLSUNBZ0lDOHZJR05zWVhOeklFRmlhVlpoYkdsa1lYUnBiMjVCYkdkdklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnWlhKeUNncHRZV2x1WDIxaGJuVmhiRlpoYkdsa1lYUnBiMjVCWm5SbGNrTnZiblpsY25SZmNtOTFkR1ZBT1RvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpNWhiR2R2TG5Sek9qTXhDaUFnSUNBdkx5QnRZVzUxWVd4V1lXeHBaR0YwYVc5dVFXWjBaWEpEYjI1MlpYSjBLSEpoZDBKNWRHVnpPaUJpZVhSbGN5a2dld29nSUNBZ1kyRnNiSE4xWWlCdFlXNTFZV3hXWVd4cFpHRjBhVzl1UVdaMFpYSkRiMjUyWlhKMENpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQXhNQW9LYldGcGJsOXRZVzUxWVd4V1lXeHBaR0YwYVc5dVNXNURiMjUyWlhKMFgzSnZkWFJsUURnNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHVZV3huYnk1MGN6b3lOZ29nSUNBZ0x5OGdiV0Z1ZFdGc1ZtRnNhV1JoZEdsdmJrbHVRMjl1ZG1WeWRDaHlZWGRDZVhSbGN6b2dZbmwwWlhNcElIc0tJQ0FnSUdOaGJHeHpkV0lnYldGdWRXRnNWbUZzYVdSaGRHbHZia2x1UTI5dWRtVnlkQW9nSUNBZ1lpQnRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTVRBS0NtMWhhVzVmYldGdWRXRnNWbUZzYVdSaGRHbHZibDl5YjNWMFpVQTNPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TG1Gc1oyOHVkSE02TWpBS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QjJZV3hwWkdGMFpVVnVZMjlrYVc1bk9pQW5kVzV6WVdabExXUnBjMkZpYkdWa0p5QjlLUW9nSUNBZ1kyRnNiSE4xWWlCdFlXNTFZV3hXWVd4cFpHRjBhVzl1Q2lBZ0lDQmlJRzFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBeE1Bb0tiV0ZwYmw5a1pXWmhkV3gwVm1Gc2FXUmhkR2x2Ymw5eWIzVjBaVUEyT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxtRnNaMjh1ZEhNNk1UWUtJQ0FnSUM4dklHUmxabUYxYkhSV1lXeHBaR0YwYVc5dUtIWmhiSFZsT2lCaWVYUmxjend6TWo0cElIc0tJQ0FnSUdOaGJHeHpkV0lnWkdWbVlYVnNkRlpoYkdsa1lYUnBiMjRLSUNBZ0lHSWdiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURFd0NncHRZV2x1WDNkcGRHaHZkWFJXWVd4cFpHRjBhVzl1WDNKdmRYUmxRRFU2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dVlXeG5ieTUwY3pveE1Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSFpoYkdsa1lYUmxSVzVqYjJScGJtYzZJQ2QxYm5OaFptVXRaR2x6WVdKc1pXUW5JSDBwQ2lBZ0lDQmpZV3hzYzNWaUlIZHBkR2h2ZFhSV1lXeHBaR0YwYVc5dUNpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQXhNQW9LYldGcGJsOTNhWFJvVm1Gc2FXUmhkR2x2Ymw5eWIzVjBaVUEwT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxtRnNaMjh1ZEhNNk53b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSFpoYkdsa1lYUmxSVzVqYjJScGJtYzZJQ2RoY21kekp5QjlLUW9nSUNBZ1kyRnNiSE4xWWlCM2FYUm9WbUZzYVdSaGRHbHZiZ29nSUNBZ1lpQnRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTVRBS0NtMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU1URTZDaUFnSUNCaUlHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhNZ29LYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1UTTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR1WVd4bmJ5NTBjem8yQ2lBZ0lDQXZMeUJqYkdGemN5QkJZbWxXWVd4cFpHRjBhVzl1UVd4bmJ5QmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTVNBdkx5Qk9iMDl3Q2lBZ0lDQTlQUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQTlQUW9nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQW9nSUNBZ1kyRnNiSE4xWWlCZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1VLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR1WVd4bmJ5NTBjem82UVdKcFZtRnNhV1JoZEdsdmJrRnNaMjh1ZDJsMGFGWmhiR2xrWVhScGIyNWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AzYVhSb1ZtRnNhV1JoZEdsdmJqb0tJQ0FnSUdJZ2QybDBhRlpoYkdsa1lYUnBiMjVmWW14dlkydEFNQW9LZDJsMGFGWmhiR2xrWVhScGIyNWZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTVoYkdkdkxuUnpPamNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCMllXeHBaR0YwWlVWdVkyOWthVzVuT2lBbllYSm5jeWNnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdZMkZzYkhOMVlpQjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR1WVd4bmJ5NTBjem82UVdKcFZtRnNhV1JoZEdsdmJrRnNaMjh1ZDJsMGFGWmhiR2xrWVhScGIyNEtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2Ymk1aGJHZHZMblJ6T2pwQlltbFdZV3hwWkdGMGFXOXVRV3huYnk1M2FYUm9iM1YwVm1Gc2FXUmhkR2x2Ymx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuZHBkR2h2ZFhSV1lXeHBaR0YwYVc5dU9nb2dJQ0FnWWlCM2FYUm9iM1YwVm1Gc2FXUmhkR2x2Ymw5aWJHOWphMEF3Q2dwM2FYUm9iM1YwVm1Gc2FXUmhkR2x2Ymw5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxtRnNaMjh1ZEhNNk1URUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUIyWVd4cFpHRjBaVVZ1WTI5a2FXNW5PaUFuZFc1ellXWmxMV1JwYzJGaWJHVmtKeUI5S1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZMkZzYkhOMVlpQjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR1WVd4bmJ5NTBjem82UVdKcFZtRnNhV1JoZEdsdmJrRnNaMjh1ZDJsMGFHOTFkRlpoYkdsa1lYUnBiMjRLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpNWhiR2R2TG5Sek9qcEJZbWxXWVd4cFpHRjBhVzl1UVd4bmJ5NWtaV1poZFd4MFZtRnNhV1JoZEdsdmJsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbVJsWm1GMWJIUldZV3hwWkdGMGFXOXVPZ29nSUNBZ1lpQmtaV1poZFd4MFZtRnNhV1JoZEdsdmJsOWliRzlqYTBBd0NncGtaV1poZFd4MFZtRnNhV1JoZEdsdmJsOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMbUZzWjI4dWRITTZNVFlLSUNBZ0lDOHZJR1JsWm1GMWJIUldZV3hwWkdGMGFXOXVLSFpoYkhWbE9pQmllWFJsY3p3ek1qNHBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ1kyRnNiSE4xWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHVZV3huYnk1MGN6bzZRV0pwVm1Gc2FXUmhkR2x2YmtGc1oyOHVaR1ZtWVhWc2RGWmhiR2xrWVhScGIyNEtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2Ymk1aGJHZHZMblJ6T2pwQlltbFdZV3hwWkdGMGFXOXVRV3huYnk1dFlXNTFZV3hXWVd4cFpHRjBhVzl1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2JXRnVkV0ZzVm1Gc2FXUmhkR2x2YmpvS0lDQWdJR0lnYldGdWRXRnNWbUZzYVdSaGRHbHZibDlpYkc5amEwQXdDZ3B0WVc1MVlXeFdZV3hwWkdGMGFXOXVYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR1WVd4bmJ5NTBjem95TUFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lIWmhiR2xrWVhSbFJXNWpiMlJwYm1jNklDZDFibk5oWm1VdFpHbHpZV0pzWldRbklIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCallXeHNjM1ZpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpNWhiR2R2TG5Sek9qcEJZbWxXWVd4cFpHRjBhVzl1UVd4bmJ5NXRZVzUxWVd4V1lXeHBaR0YwYVc5dUNpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR1WVd4bmJ5NTBjem82UVdKcFZtRnNhV1JoZEdsdmJrRnNaMjh1YldGdWRXRnNWbUZzYVdSaGRHbHZia2x1UTI5dWRtVnlkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q20xaGJuVmhiRlpoYkdsa1lYUnBiMjVKYmtOdmJuWmxjblE2Q2lBZ0lDQmlJRzFoYm5WaGJGWmhiR2xrWVhScGIyNUpia052Ym5abGNuUmZZbXh2WTJ0QU1Bb0tiV0Z1ZFdGc1ZtRnNhV1JoZEdsdmJrbHVRMjl1ZG1WeWRGOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMbUZzWjI4dWRITTZNallLSUNBZ0lDOHZJRzFoYm5WaGJGWmhiR2xrWVhScGIyNUpia052Ym5abGNuUW9jbUYzUW5sMFpYTTZJR0o1ZEdWektTQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0tnb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdOaGJHeHpkV0lnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxtRnNaMjh1ZEhNNk9rRmlhVlpoYkdsa1lYUnBiMjVCYkdkdkxtMWhiblZoYkZaaGJHbGtZWFJwYjI1SmJrTnZiblpsY25RS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTVoYkdkdkxuUnpPanBCWW1sV1lXeHBaR0YwYVc5dVFXeG5ieTV0WVc1MVlXeFdZV3hwWkdGMGFXOXVRV1owWlhKRGIyNTJaWEowVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2JXRnVkV0ZzVm1Gc2FXUmhkR2x2YmtGbWRHVnlRMjl1ZG1WeWREb0tJQ0FnSUdJZ2JXRnVkV0ZzVm1Gc2FXUmhkR2x2YmtGbWRHVnlRMjl1ZG1WeWRGOWliRzlqYTBBd0NncHRZVzUxWVd4V1lXeHBaR0YwYVc5dVFXWjBaWEpEYjI1MlpYSjBYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR1WVd4bmJ5NTBjem96TVFvZ0lDQWdMeThnYldGdWRXRnNWbUZzYVdSaGRHbHZia0ZtZEdWeVEyOXVkbVZ5ZENoeVlYZENlWFJsY3pvZ1lubDBaWE1wSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdZMkZzYkhOMVlpQjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR1WVd4bmJ5NTBjem82UVdKcFZtRnNhV1JoZEdsdmJrRnNaMjh1YldGdWRXRnNWbUZzYVdSaGRHbHZia0ZtZEdWeVEyOXVkbVZ5ZEFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMbUZzWjI4dWRITTZPa0ZpYVZaaGJHbGtZWFJwYjI1QmJHZHZMbmRwZEdoV1lXeHBaR0YwYVc5dUtIWmhiSFZsT2lCaWVYUmxjeWtnTFQ0Z2RXbHVkRFkwT2dwMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHVZV3huYnk1MGN6bzZRV0pwVm1Gc2FXUmhkR2x2YmtGc1oyOHVkMmwwYUZaaGJHbGtZWFJwYjI0NkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHVZV3huYnk1MGN6bzNMVGdLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCMllXeHBaR0YwWlVWdVkyOWthVzVuT2lBbllYSm5jeWNnZlNrS0lDQWdJQzh2SUhkcGRHaFdZV3hwWkdGMGFXOXVLSFpoYkhWbE9pQmllWFJsY3p3ek1qNHBJSHNLSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHVZV3huYnk1MGN6bzZRV0pwVm1Gc2FXUmhkR2x2YmtGc1oyOHVkMmwwYUZaaGJHbGtZWFJwYjI1ZllteHZZMnRBTUFvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMbUZzWjI4dWRITTZPa0ZpYVZaaGJHbGtZWFJwYjI1QmJHZHZMbmRwZEdoV1lXeHBaR0YwYVc5dVgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHVZV3huYnk1MGN6bzVDaUFnSUNBdkx5QnlaWFIxY200Z2RtRnNkV1V1YkdWdVozUm9DaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUd4bGJnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMbUZzWjI4dWRITTZPa0ZpYVZaaGJHbGtZWFJwYjI1QmJHZHZMbmRwZEdodmRYUldZV3hwWkdGMGFXOXVLSFpoYkhWbE9pQmllWFJsY3lrZ0xUNGdkV2x1ZERZME9ncDBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR1WVd4bmJ5NTBjem82UVdKcFZtRnNhV1JoZEdsdmJrRnNaMjh1ZDJsMGFHOTFkRlpoYkdsa1lYUnBiMjQ2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dVlXeG5ieTUwY3pveE1TMHhNZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhaaGJHbGtZWFJsUlc1amIyUnBibWM2SUNkMWJuTmhabVV0WkdsellXSnNaV1FuSUgwcENpQWdJQ0F2THlCM2FYUm9iM1YwVm1Gc2FXUmhkR2x2YmloMllXeDFaVG9nWW5sMFpYTThNekkrS1NCN0NpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lHSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TG1Gc1oyOHVkSE02T2tGaWFWWmhiR2xrWVhScGIyNUJiR2R2TG5kcGRHaHZkWFJXWVd4cFpHRjBhVzl1WDJKc2IyTnJRREFLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpNWhiR2R2TG5Sek9qcEJZbWxXWVd4cFpHRjBhVzl1UVd4bmJ5NTNhWFJvYjNWMFZtRnNhV1JoZEdsdmJsOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMbUZzWjI4dWRITTZNVE1LSUNBZ0lDOHZJSEpsZEhWeWJpQjJZV3gxWlM1c1pXNW5kR2dLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2JHVnVDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR1WVd4bmJ5NTBjem82UVdKcFZtRnNhV1JoZEdsdmJrRnNaMjh1WkdWbVlYVnNkRlpoYkdsa1lYUnBiMjRvZG1Gc2RXVTZJR0o1ZEdWektTQXRQaUIxYVc1ME5qUTZDblJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2Ymk1aGJHZHZMblJ6T2pwQlltbFdZV3hwWkdGMGFXOXVRV3huYnk1a1pXWmhkV3gwVm1Gc2FXUmhkR2x2YmpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpNWhiR2R2TG5Sek9qRTJDaUFnSUNBdkx5QmtaV1poZFd4MFZtRnNhV1JoZEdsdmJpaDJZV3gxWlRvZ1lubDBaWE04TXpJK0tTQjdDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxtRnNaMjh1ZEhNNk9rRmlhVlpoYkdsa1lYUnBiMjVCYkdkdkxtUmxabUYxYkhSV1lXeHBaR0YwYVc5dVgySnNiMk5yUURBS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTVoYkdkdkxuUnpPanBCWW1sV1lXeHBaR0YwYVc5dVFXeG5ieTVrWldaaGRXeDBWbUZzYVdSaGRHbHZibDlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TG1Gc1oyOHVkSE02TVRjS0lDQWdJQzh2SUhKbGRIVnliaUIyWVd4MVpTNXNaVzVuZEdnS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdiR1Z1Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dVlXeG5ieTUwY3pvNlFXSnBWbUZzYVdSaGRHbHZia0ZzWjI4dWJXRnVkV0ZzVm1Gc2FXUmhkR2x2YmloMllXeDFaVG9nWW5sMFpYTXBJQzArSUhWcGJuUTJORG9LZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxtRnNaMjh1ZEhNNk9rRmlhVlpoYkdsa1lYUnBiMjVCYkdkdkxtMWhiblZoYkZaaGJHbGtZWFJwYjI0NkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHVZV3huYnk1MGN6b3lNQzB5TVFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lIWmhiR2xrWVhSbFJXNWpiMlJwYm1jNklDZDFibk5oWm1VdFpHbHpZV0pzWldRbklIMHBDaUFnSUNBdkx5QnRZVzUxWVd4V1lXeHBaR0YwYVc5dUtIWmhiSFZsT2lCaWVYUmxjend6TWo0cElIc0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dVlXeG5ieTUwY3pvNlFXSnBWbUZzYVdSaGRHbHZia0ZzWjI4dWJXRnVkV0ZzVm1Gc2FXUmhkR2x2Ymw5aWJHOWphMEF3Q2dwMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHVZV3huYnk1MGN6bzZRV0pwVm1Gc2FXUmhkR2x2YmtGc1oyOHViV0Z1ZFdGc1ZtRnNhV1JoZEdsdmJsOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMbUZzWjI4dWRITTZNaklLSUNBZ0lDOHZJSFpoYkdsa1lYUmxSVzVqYjJScGJtY29kbUZzZFdVcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpNWhiR2R2TG5Sek9qSXpDaUFnSUNBdkx5QnlaWFIxY200Z2RtRnNkV1V1YkdWdVozUm9DaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUd4bGJnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMbUZzWjI4dWRITTZPa0ZpYVZaaGJHbGtZWFJwYjI1QmJHZHZMbTFoYm5WaGJGWmhiR2xrWVhScGIyNUpia052Ym5abGNuUW9jbUYzUW5sMFpYTTZJR0o1ZEdWektTQXRQaUIxYVc1ME5qUTZDblJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2Ymk1aGJHZHZMblJ6T2pwQlltbFdZV3hwWkdGMGFXOXVRV3huYnk1dFlXNTFZV3hXWVd4cFpHRjBhVzl1U1c1RGIyNTJaWEowT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxtRnNaMjh1ZEhNNk1qWUtJQ0FnSUM4dklHMWhiblZoYkZaaGJHbGtZWFJwYjI1SmJrTnZiblpsY25Rb2NtRjNRbmwwWlhNNklHSjVkR1Z6S1NCN0NpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lHSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TG1Gc1oyOHVkSE02T2tGaWFWWmhiR2xrWVhScGIyNUJiR2R2TG0xaGJuVmhiRlpoYkdsa1lYUnBiMjVKYmtOdmJuWmxjblJmWW14dlkydEFNQW9LZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxtRnNaMjh1ZEhNNk9rRmlhVlpoYkdsa1lYUnBiMjVCYkdkdkxtMWhiblZoYkZaaGJHbGtZWFJwYjI1SmJrTnZiblpsY25SZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpNWhiR2R2TG5Sek9qSTNDaUFnSUNBdkx5QmpiMjV6ZENCMllXeDFaU0E5SUdOdmJuWmxjblJDZVhSbGN6eFRkR0YwYVdOQ2VYUmxjend6TWo0K0tISmhkMEo1ZEdWekxDQjdJSE4wY21GMFpXZDVPaUFuZG1Gc2FXUmhkR1VuSUgwcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpNWhiR2R2TG5Sek9qSTRDaUFnSUNBdkx5QnlaWFIxY200Z2RtRnNkV1V1YkdWdVozUm9DaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTVoYkdkdkxuUnpPanBCWW1sV1lXeHBaR0YwYVc5dVFXeG5ieTV0WVc1MVlXeFdZV3hwWkdGMGFXOXVRV1owWlhKRGIyNTJaWEowS0hKaGQwSjVkR1Z6T2lCaWVYUmxjeWtnTFQ0Z2RXbHVkRFkwT2dwMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHVZV3huYnk1MGN6bzZRV0pwVm1Gc2FXUmhkR2x2YmtGc1oyOHViV0Z1ZFdGc1ZtRnNhV1JoZEdsdmJrRm1kR1Z5UTI5dWRtVnlkRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2Ymk1aGJHZHZMblJ6T2pNeENpQWdJQ0F2THlCdFlXNTFZV3hXWVd4cFpHRjBhVzl1UVdaMFpYSkRiMjUyWlhKMEtISmhkMEo1ZEdWek9pQmllWFJsY3lrZ2V3b2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2Ymk1aGJHZHZMblJ6T2pwQlltbFdZV3hwWkdGMGFXOXVRV3huYnk1dFlXNTFZV3hXWVd4cFpHRjBhVzl1UVdaMFpYSkRiMjUyWlhKMFgySnNiMk5yUURBS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTVoYkdkdkxuUnpPanBCWW1sV1lXeHBaR0YwYVc5dVFXeG5ieTV0WVc1MVlXeFdZV3hwWkdGMGFXOXVRV1owWlhKRGIyNTJaWEowWDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dVlXeG5ieTUwY3pvek1nb2dJQ0FnTHk4Z1kyOXVjM1FnZG1Gc2RXVWdQU0JqYjI1MlpYSjBRbmwwWlhNOFUzUmhkR2xqUW5sMFpYTThNekkrUGloeVlYZENlWFJsY3l3Z2V5QnpkSEpoZEdWbmVUb2dKM1Z1YzJGbVpTMWpZWE4wSnlCOUtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHVZV3huYnk1MGN6b3pNd29nSUNBZ0x5OGdkbUZzYVdSaGRHVkZibU52WkdsdVp5aDJZV3gxWlNrS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpNWhiR2R2TG5Sek9qTTBDaUFnSUNBdkx5QnlaWFIxY200Z2RtRnNkV1V1YkdWdVozUm9DaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTVoYkdkdkxuUnpPanBCWW1sV1lXeHBaR0YwYVc5dVFXeG5ieTVmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVW9LU0F0UGlCMmIybGtPZ3BmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVTZDaUFnSUNCaUlGOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlY5aWJHOWphMEF3Q2dwZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZmWW14dlkydEFNRG9LSUNBZ0lISmxkSE4xWWdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JpSUcxaGFXNWZZbXh2WTJ0QU1Bb0tiV0ZwYmw5aWJHOWphMEF3T2dvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFRQWdBaVlCQkJVZmZIVkNBQUJDQUFBeEd5TVRRUUI2UWdBQU1Sa2pFa1F4R0NNVFFRQm9RZ0FBTmhvQWdBUW1QcHd6Z0FUZzRIQjBnQVJHb05KUmdBVG1GakxCZ0FUN2hyd0FnQVRBOEYwUVR3YU9CZ0FvQUNJQUhBQVdBQkFBQ2tJQUFFSUFBRUlBQUFDSUFLRkMvL09JQUh0Qy8rMklBR1JDLytlSUFFaEMvK0dJQURGQy85dUlBQlZDLzlWQy85VXhHU01TTVJnakVoQkVpQURhSWtOQ0FBQTJHZ0ZKRlNRU1JJZ0FnQllvVHdGUXNDSkRRZ0FBTmhvQmlBQjVGaWhQQVZDd0lrTkNBQUEyR2dGSkZTUVNSSWdBYlJZb1R3RlFzQ0pEUWdBQU5ob0JpQUJtRmloUEFWQ3dJa05DQUFBMkdnRkpJMWtpQ3lVSVN3RVZFa1JYQWdDSUFGWVdLRThCVUxBaVEwSUFBRFlhQVVraldTSUxKUWhMQVJVU1JGY0NBSWdBUkJZb1R3RlFzQ0pEaWdFQlFnQUFpLzhWaVlvQkFVSUFBSXYvRlltS0FRRkNBQUNML3hXSmlnRUJRZ0FBaS84VkpCSkVpLzhWaVlvQkFVSUFBSXYvRlNRU1JDU0ppZ0VCUWdBQWkvOFZKQkpFSklsQ0FBQ0oiLCJjbGVhciI6IkMwSUFBSUVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
