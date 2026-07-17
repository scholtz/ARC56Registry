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

namespace Arc56.Generated.algorandfoundation.puya.ArrayUInt64_99e30fa4
{


    public class ArrayUInt64Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ArrayUInt64Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task Bootstrap(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 199, 109, 135 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Bootstrap_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 199, 109, 135 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task Append(ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 52, 40, 255, 234 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Append_Transactions(ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 52, 40, 255, 234 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="array"> </param>
        public async Task Concat(ulong[] array, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 73, 206, 93 };
            var arrayAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); arrayAbi.From(array);

            var result = await base.CallApp(new List<object> { abiHandle, arrayAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Concat_Transactions(ulong[] array, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 73, 206, 93 };
            var arrayAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); arrayAbi.From(array);

            return await base.MakeTransactionList(new List<object> { abiHandle, arrayAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> Pop(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 37, 161, 66 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Pop_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 37, 161, 66 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="idx"> </param>
        public async Task<ulong> Get(ulong idx, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 54, 156, 54 };
            var idxAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idxAbi.From(idx);

            var result = await base.CallApp(new List<object> { abiHandle, idxAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Get_Transactions(ulong idx, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 54, 156, 54 };
            var idxAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idxAbi.From(idx);

            return await base.MakeTransactionList(new List<object> { abiHandle, idxAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="idx"> </param>
        /// <param name="value"> </param>
        public async Task Set(ulong idx, ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 209, 189, 198 };
            var idxAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idxAbi.From(idx);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, idxAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Set_Transactions(ulong idx, ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 209, 189, 198 };
            var idxAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idxAbi.From(idx);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, idxAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="expected"> </param>
        public async Task Verify(ulong[] expected, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 49, 122, 62, 3 };
            var expectedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); expectedAbi.From(expected);

            var result = await base.CallApp(new List<object> { abiHandle, expectedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Verify_Transactions(ulong[] expected, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 49, 122, 62, 3 };
            var expectedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); expectedAbi.From(expected);

            return await base.MakeTransactionList(new List<object> { abiHandle, expectedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXJyYXlVSW50NjQiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiYm9vdHN0cmFwIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFwcGVuZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjb25jYXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcnJheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwb3AiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaWR4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlkeCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmVyaWZ5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXhwZWN0ZWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyMjFdLCJlcnJvck1lc3NhZ2UiOiJjYW5ub3QgcG9wIGZyb20gZW1wdHkgYXJyYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzEsMjgwLDMxMywzNjFdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg4LDMyMl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5OCwzMzVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PHVpbnQ2ND4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjksMjcxLDI5NCwzMDNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUE0SURJZ01TQXdDaUFnSUNCaWVYUmxZMkpzYjJOcklDSmliM2dpSURCNE1UVXhaamRqTnpVS0lDQWdJQzh2SUd4aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekwyRnljbUY1WDNWcGJuUTJOQzV3ZVRveE1Bb2dJQ0FnTHk4Z1kyeGhjM01nUVhKeVlYbFZTVzUwTmpRb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURFMkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhoaVpXTTNObVE0TnlBd2VETTBNamhtWm1WaElEQjROVGswT1dObE5XUWdNSGhpT0RJMVlURTBNaUF3ZUdJME16WTVZek0ySURCNFkyVmtNV0prWXpZZ01IZ3pNVGRoTTJVd015QXZMeUJ0WlhSb2IyUWdJbUp2YjNSemRISmhjQ2dwZG05cFpDSXNJRzFsZEdodlpDQWlZWEJ3Wlc1a0tIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0pqYjI1allYUW9kV2x1ZERZMFcxMHBkbTlwWkNJc0lHMWxkR2h2WkNBaWNHOXdLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbWRsZENoMWFXNTBOalFwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0p6WlhRb2RXbHVkRFkwTEhWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSjJaWEpwWm5rb2RXbHVkRFkwVzEwcGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdKdmIzUnpkSEpoY0NCaGNIQmxibVFnWTI5dVkyRjBJSEJ2Y0NCblpYUWdjMlYwSUhabGNtbG1lUW9nSUNBZ1pYSnlDZ3B0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURFMk9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEtDZ292THlCZmNIVjVZVjlzYVdJdVltOTRYMkZ5WXpRdVltOTRYMlI1Ym1GdGFXTmZZWEp5WVhsZlkyOXVZMkYwWDJacGVHVmtLR0p2ZUY5clpYazZJR0o1ZEdWekxDQmhjbkpoZVY5dlptWnpaWFE2SUhWcGJuUTJOQ3dnYm1WM1gybDBaVzF6WDJKNWRHVnpPaUJpZVhSbGN5d2dibVYzWDJsMFpXMXpYMk52ZFc1ME9pQjFhVzUwTmpRc0lHWnBlR1ZrWDJWc1pXMWxiblJmYzJsNlpUb2dkV2x1ZERZMEtTQXRQaUIyYjJsa09ncGliM2hmWkhsdVlXMXBZMTloY25KaGVWOWpiMjVqWVhSZlptbDRaV1E2Q2lBZ0lDQndjbTkwYnlBMUlEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHSjBiMmtLSUNBZ0lHWnlZVzFsWDJScFp5QXROUW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdjRzl3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ0tnb2dJQ0FnS3dvZ0lDQWdabkpoYldWZlpHbG5JQzAxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY21WemFYcGxDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHWnlZVzFsWDJScFp5QXROUW9nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0p2ZUY5eVpYQnNZV05sQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJQ29LSUNBZ0lDc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Rb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHpJQzh2SURBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZbTk0WDNOd2JHbGpaUW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEY5allYTmxjeTVzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k1aGNuSmhlVjkxYVc1ME5qUXVRWEp5WVhsVlNXNTBOalF1WW05dmRITjBjbUZ3VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1ltOXZkSE4wY21Gd09nb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZZWEp5WVhsZmRXbHVkRFkwTG5CNU9qRTJDaUFnSUNBdkx5QnpaV3htTG1KdmVDNTJZV3gxWlNBOUlFRnljbUY1VlRZMEtDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdllYSnlZWGxmZFdsdWREWTBMbkI1T2pFMENpQWdJQ0F2THlCQWNIVmliR2xqQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTVzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k1aGNuSmhlVjkxYVc1ME5qUXVRWEp5WVhsVlNXNTBOalF1WVhCd1pXNWtXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWVhCd1pXNWtPZ29nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12WVhKeVlYbGZkV2x1ZERZMExuQjVPakU0Q2lBZ0lDQXZMeUJBY0hWaWJHbGpDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5aGNuSmhlVjkxYVc1ME5qUXVjSGs2TWpBS0lDQWdJQzh2SUhObGJHWXVZbTk0TG5aaGJIVmxMbUZ3Y0dWdVpDaDJZV3gxWlNrS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVDSUtJQ0FnSUdsdWRHTmZNeUF2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnWTJGc2JITjFZaUJpYjNoZlpIbHVZVzFwWTE5aGNuSmhlVjlqYjI1allYUmZabWw0WldRS0lDQWdJQzh2SUd4aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekwyRnljbUY1WDNWcGJuUTJOQzV3ZVRveE9Bb2dJQ0FnTHk4Z1FIQjFZbXhwWXdvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSZlkyRnpaWE11YkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdVlYSnlZWGxmZFdsdWREWTBMa0Z5Y21GNVZVbHVkRFkwTG1OdmJtTmhkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OdmJtTmhkRG9LSUNBZ0lDOHZJR3hoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TDJGeWNtRjVYM1ZwYm5RMk5DNXdlVG95TWdvZ0lDQWdMeThnUUhCMVlteHBZd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYek1nTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ0tnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeDFhVzUwTmpRK0NpQWdJQ0F2THlCc1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5OWhjbkpoZVY5MWFXNTBOalF1Y0hrNk1qUUtJQ0FnSUM4dklITmxiR1l1WW05NExuWmhiSFZsTG1WNGRHVnVaQ2hoY25KaGVTa0tJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWIzZ2lDaUFnSUNCcGJuUmpYek1nTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JqWVd4c2MzVmlJR0p2ZUY5a2VXNWhiV2xqWDJGeWNtRjVYMk52Ym1OaGRGOW1hWGhsWkFvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdllYSnlZWGxmZFdsdWREWTBMbkI1T2pJeUNpQWdJQ0F2THlCQWNIVmliR2xqQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTVzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k1aGNuSmhlVjkxYVc1ME5qUXVRWEp5WVhsVlNXNTBOalF1Y0c5d1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjRzl3T2dvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdllYSnlZWGxmZFdsdWREWTBMbkI1T2pJNENpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNWliM2d1ZG1Gc2RXVXVjRzl3S0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVDSUtJQ0FnSUdsdWRHTmZNeUF2THlBd0NpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHSjBiMmtLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBdElDOHZJRzl1SUdWeWNtOXlPaUJqWVc1dWIzUWdjRzl3SUdaeWIyMGdaVzF3ZEhrZ1lYSnlZWGtLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUNvS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmliM2dpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTloY25KaGVWOTFhVzUwTmpRdWNIazZNamdLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG1KdmVDNTJZV3gxWlM1d2IzQW9LUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdhVzUwWTE4eklDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWW05NFgzSmxjR3hoWTJVS0lDQWdJQzh2SUd4aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekwyRnljbUY1WDNWcGJuUTJOQzV3ZVRveU9Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVZbTk0TG5aaGJIVmxMbkJ2Y0NncENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWIzZ2lDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJQzh2SUd4aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekwyRnljbUY1WDNWcGJuUTJOQzV3ZVRveU9Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVZbTk0TG5aaGJIVmxMbkJ2Y0NncENpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0Q2lBZ0lDQmliM2hmYzNCc2FXTmxDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTloY25KaGVWOTFhVzUwTmpRdWNIazZNamdLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG1KdmVDNTJZV3gxWlM1d2IzQW9LUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnY0c5d0NpQWdJQ0F2THlCc1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5OWhjbkpoZVY5MWFXNTBOalF1Y0hrNk1qZ0tJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbUp2ZUM1MllXeDFaUzV3YjNBb0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJQzBLSUNBZ0lDOHZJR3hoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TDJGeWNtRjVYM1ZwYm5RMk5DNXdlVG95T0FvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdVltOTRMblpoYkhWbExuQnZjQ2dwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppYjNnaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNtVnphWHBsQ2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5aGNuSmhlVjkxYVc1ME5qUXVjSGs2TWpZS0lDQWdJQzh2SUVCd2RXSnNhV01LSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMbXhoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TG1GeWNtRjVYM1ZwYm5RMk5DNUJjbkpoZVZWSmJuUTJOQzVuWlhSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFE2Q2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5aGNuSmhlVjkxYVc1ME5qUXVjSGs2TXpBS0lDQWdJQzh2SUVCd2RXSnNhV01LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUd4aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekwyRnljbUY1WDNWcGJuUTJOQzV3ZVRvek1nb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVZbTk0TG5aaGJIVmxXMmxrZUYwS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTloY25KaGVWOTFhVzUwTmpRdWNIazZNekFLSUNBZ0lDOHZJRUJ3ZFdKc2FXTUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxteGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMbUZ5Y21GNVgzVnBiblEyTkM1QmNuSmhlVlZKYm5RMk5DNXpaWFJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwelpYUTZDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTloY25KaGVWOTFhVzUwTmpRdWNIazZNelFLSUNBZ0lDOHZJRUJ3ZFdKc2FXTUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJQzh2SUd4aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekwyRnljbUY1WDNWcGJuUTJOQzV3ZVRvek5nb2dJQ0FnTHk4Z2MyVnNaaTVpYjNndWRtRnNkV1ZiYVdSNFhTQTlJSFpoYkhWbENpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNzS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVDSUtJQ0FnSUhOM1lYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZbTk0WDNKbGNHeGhZMlVnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklHeGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMMkZ5Y21GNVgzVnBiblEyTkM1d2VUb3pOQW9nSUNBZ0x5OGdRSEIxWW14cFl3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdWJHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXVZWEp5WVhsZmRXbHVkRFkwTGtGeWNtRjVWVWx1ZERZMExuWmxjbWxtZVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuWmxjbWxtZVRvS0lDQWdJQzh2SUd4aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekwyRnljbUY1WDNWcGJuUTJOQzV3ZVRvek9Bb2dJQ0FnTHk4Z1FIQjFZbXhwWXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JwYm5Salh6TWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNBcUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHgxYVc1ME5qUStDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTloY25KaGVWOTFhVzUwTmpRdWNIazZOREF0TkRJS0lDQWdJQzh2SUNNZ2NtRjBhR1Z5SUhSb1lXNGdZWE56WlhKMGFXNW5JR0p2ZUM1MllXeDFaU0JrYVhKbFkzUnNlU0FvZDJocFkyZ2dkMjkxYkdRZ1lYUjBaVzF3ZENCMGJ5QnNiMkZrSUhSb1pTQjNhRzlzWlNCaWIzZ3BDaUFnSUNBdkx5QWpJR0Z6YzJWeWRDQjBhR1VnYkdWdVozUm9JR0Z1WkNCcGJtUnBkbWxrZFdGc0lHbDBaVzF6Q2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1aWIzZ3VkbUZzZFdVdWJHVnVaM1JvSUQwOUlHVjRjR1ZqZEdWa0xteGxibWQwYUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnYVc1MFkxOHpJQzh2SURBS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12WVhKeVlYbGZkV2x1ZERZMExuQjVPalF6Q2lBZ0lDQXZMeUJtYjNJZ2FTQnBiaUIxY21GdVoyVW9aWGh3WldOMFpXUXViR1Z1WjNSb0tUb0tJQ0FnSUdsdWRHTmZNeUF2THlBd0NncDJaWEpwWm5sZlptOXlYMmhsWVdSbGNrQXlPZ29nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12WVhKeVlYbGZkV2x1ZERZMExuQjVPalF6Q2lBZ0lDQXZMeUJtYjNJZ2FTQnBiaUIxY21GdVoyVW9aWGh3WldOMFpXUXViR1Z1WjNSb0tUb0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklESUtJQ0FnSUR3S0lDQWdJR0o2SUhabGNtbG1lVjloWm5SbGNsOW1iM0pBTlFvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdllYSnlZWGxmZFdsdWREWTBMbkI1T2pRMENpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNWliM2d1ZG1Gc2RXVmJhVjBnUFQwZ1pYaHdaV04wWldSYmFWMEtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJQ29LSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNCa2FXY2dNUW9nSUNBZ0t3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQmthV2NnTkFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklHeGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMMkZ5Y21GNVgzVnBiblEyTkM1d2VUbzBNd29nSUNBZ0x5OGdabTl5SUdrZ2FXNGdkWEpoYm1kbEtHVjRjR1ZqZEdWa0xteGxibWQwYUNrNkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdLd29nSUNBZ1lpQjJaWEpwWm5sZlptOXlYMmhsWVdSbGNrQXlDZ3AyWlhKcFpubGZZV1owWlhKZlptOXlRRFU2Q2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5aGNuSmhlVjkxYVc1ME5qUXVjSGs2TXpnS0lDQWdJQzh2SUVCd2RXSnNhV01LSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUNBSUJBQ1lDQTJKdmVBUVZIM3gxTVJ0QkFFQXhHUlJFTVJoRWdnY0V2c2R0aHdRMEtQL3FCRmxKemwwRXVDV2hRZ1MwTnB3MkJNN1J2Y1lFTVhvK0F6WWFBSTRIQUVFQVRBQmhBSUVBc2dESkFPWUFNUmtVTVJnVUVFT0tCUUNMKzR2OEk3b1hpL3U5U0l2K2kvOExDSXY3VE5OSmkvNElGbGNHQW92N2kveFBBcnVML0NNSVRJdi9Dd2lMKzB3bGkvM1NpU2k4U0NpQUFnQUF2eVJETmhvQlNSVWlFa1FYRmlnbFR3SWtJb2ovcWlSRE5ob0JTU1ZaU1NJTEl3aExBaFVTUkV4WEFnQW9KVThDVHdNaWlQK0tKRU1vSlNPNkZ5UUpTU0lMSXdnb1N3RWl1azhDRmxjR0FpZ2xUd0s3S0U4Q0lvQUEwaWk5U0NJSktFelRLVXhRc0NSRE5ob0JTUlVpRWtRWElnc2pDQ2hNSXJvcFRGQ3dKRU0yR2dGSkZTSVNSQmMyR2dKSkZTSVNSRXdpQ3lNSUtFeFBBcnNrUXpZYUFVY0NKVmxKVGdKSklnc2pDRThDRlJKRUtDVWp1aGNTUkNWSlN3SU1RUUFiU1NJTEkwc0JDQ2hNSXJvWFN3UlhBZ0JQQWxzU1JDUUlRdi9lSkVNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6OTksIm1pbm9yIjo5OSwicGF0Y2giOjk5LCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
