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

namespace Arc56.Generated.algorandfoundation.puya_ts.ConstLiteralsAlgo_cb7c7313
{


    public class ConstLiteralsAlgoProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ConstLiteralsAlgoProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> Test(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 255, 188, 57, 20 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Test_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 255, 188, 57, 20 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> Test2(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 52, 26, 55, 148 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Test2_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 52, 26, 55, 148 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> Test3(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 115, 229, 176, 199 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Test3_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 115, 229, 176, 199 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> Test4(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 52, 38, 107 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Test4_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 52, 38, 107 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt512> Test5(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 170, 218, 142, 238 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Test5_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 170, 218, 142, 238 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt512> Test6(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 78, 147, 91, 110 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Test6_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 78, 147, 91, 110 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ29uc3RMaXRlcmFsc0FsZ28iLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoidGVzdCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3QyIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdDMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0NCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3Q1IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3Q2IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjM5LDI2MF0sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3SURZMElEa3lNak16TnpJd016WTROVFEzTnpVNE1EZ0tJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnWWlCdFlXbHVYMkpzYjJOclFEQUtDbTFoYVc1ZllteHZZMnRBTURvS0lDQWdJR0lnYldGcGJsOWliRzlqYTBBeENncHRZV2x1WDJKc2IyTnJRREU2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZMjl1YzNRdGJHbDBaWEpoYkhNdVlXeG5ieTUwY3pveE5Rb2dJQ0FnTHk4Z1kyeGhjM01nUTI5dWMzUk1hWFJsY21Gc2MwRnNaMjhnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lDRTlDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUF4TXdvZ0lDQWdZaUJ0WVdsdVgyRmlhVjl5YjNWMGFXNW5RRElLQ20xaGFXNWZZV0pwWDNKdmRYUnBibWRBTWpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlqYjI1emRDMXNhWFJsY21Gc2N5NWhiR2R2TG5Sek9qRTFDaUFnSUNBdkx5QmpiR0Z6Y3lCRGIyNXpkRXhwZEdWeVlXeHpRV3huYnlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNU0F2THlCT2IwOXdDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lDRTlDaUFnSUNCaWVpQnRZV2x1WDJOeVpXRjBaVjlPYjA5d1FERXhDaUFnSUNCaUlHMWhhVzVmWTJGc2JGOU9iMDl3UURNS0NtMWhhVzVmWTJGc2JGOU9iMDl3UURNNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WTI5dWMzUXRiR2wwWlhKaGJITXVZV3huYnk1MGN6b3hOUW9nSUNBZ0x5OGdZMnhoYzNNZ1EyOXVjM1JNYVhSbGNtRnNjMEZzWjI4Z1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhobVptSmpNemt4TkNBdkx5QnRaWFJvYjJRZ0luUmxjM1FvS1hWcGJuUTJOQ0lLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRE0wTVdFek56azBJQzh2SUcxbGRHaHZaQ0FpZEdWemRESW9LWFZwYm5RMk5DSUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEY3paVFZpTUdNM0lDOHZJRzFsZEdodlpDQWlkR1Z6ZERNb0tYVnBiblEyTkNJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURVd016UXlOalppSUM4dklHMWxkR2h2WkNBaWRHVnpkRFFvS1hWcGJuUTJOQ0lLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR0ZoWkdFNFpXVmxJQzh2SUcxbGRHaHZaQ0FpZEdWemREVW9LWFZwYm5RMU1USWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzBaVGt6TldJMlpTQXZMeUJ0WlhSb2IyUWdJblJsYzNRMktDbDFhVzUwTlRFeUlnb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQnRZWFJqYUNCdFlXbHVYM1JsYzNSZmNtOTFkR1ZBTkNCdFlXbHVYM1JsYzNReVgzSnZkWFJsUURVZ2JXRnBibDkwWlhOME0xOXliM1YwWlVBMklHMWhhVzVmZEdWemREUmZjbTkxZEdWQU55QnRZV2x1WDNSbGMzUTFYM0p2ZFhSbFFEZ2diV0ZwYmw5MFpYTjBObDl5YjNWMFpVQTVDaUFnSUNCaUlHMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUF4TUFvS2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRREV3T2dvZ0lDQWdZaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRJS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhNam9LSUNBZ0lHSWdiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREUwQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1UUTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlkyOXVjM1F0YkdsMFpYSmhiSE11WVd4bmJ5NTBjem94TlFvZ0lDQWdMeThnWTJ4aGMzTWdRMjl1YzNSTWFYUmxjbUZzYzBGc1oyOGdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCbGNuSUtDbTFoYVc1ZmRHVnpkRFpmY205MWRHVkFPVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWpiMjV6ZEMxc2FYUmxjbUZzY3k1aGJHZHZMblJ6T2pReENpQWdJQ0F2THlCMFpYTjBOaWdwT2lCaWFXZDFhVzUwSUhzS0lDQWdJR05oYkd4emRXSWdkR1Z6ZERZS0lDQWdJR0lnYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFERXdDZ3B0WVdsdVgzUmxjM1ExWDNKdmRYUmxRRGc2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZMjl1YzNRdGJHbDBaWEpoYkhNdVlXeG5ieTUwY3pvek53b2dJQ0FnTHk4Z2RHVnpkRFVvS1NCN0NpQWdJQ0JqWVd4c2MzVmlJSFJsYzNRMUNpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQXhNQW9LYldGcGJsOTBaWE4wTkY5eWIzVjBaVUEzT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMk52Ym5OMExXeHBkR1Z5WVd4ekxtRnNaMjh1ZEhNNk16SUtJQ0FnSUM4dklIUmxjM1EwS0NrNklIVnBiblEyTkNCN0NpQWdJQ0JqWVd4c2MzVmlJSFJsYzNRMENpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQXhNQW9LYldGcGJsOTBaWE4wTTE5eWIzVjBaVUEyT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMk52Ym5OMExXeHBkR1Z5WVd4ekxtRnNaMjh1ZEhNNk1qVUtJQ0FnSUM4dklIUmxjM1F6S0NrNklIVnBiblEyTkNCN0NpQWdJQ0JqWVd4c2MzVmlJSFJsYzNRekNpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQXhNQW9LYldGcGJsOTBaWE4wTWw5eWIzVjBaVUExT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMk52Ym5OMExXeHBkR1Z5WVd4ekxtRnNaMjh1ZEhNNk1qQUtJQ0FnSUM4dklIUmxjM1F5S0NrZ2V3b2dJQ0FnWTJGc2JITjFZaUIwWlhOME1nb2dJQ0FnWWlCdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFNVEFLQ20xaGFXNWZkR1Z6ZEY5eWIzVjBaVUEwT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMk52Ym5OMExXeHBkR1Z5WVd4ekxtRnNaMjh1ZEhNNk1UWUtJQ0FnSUM4dklIUmxjM1FvS1RvZ2RXbHVkRFkwSUhzS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEFvZ0lDQWdZaUJ0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU1UQUtDbTFoYVc1ZlkzSmxZWFJsWDA1dlQzQkFNVEU2Q2lBZ0lDQmlJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TWdvS2JXRnBibDlmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVkFNVE02Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZMjl1YzNRdGJHbDBaWEpoYkhNdVlXeG5ieTUwY3pveE5Rb2dJQ0FnTHk4Z1kyeGhjM01nUTI5dWMzUk1hWFJsY21Gc2MwRnNaMjhnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6RWdMeThnVG05UGNBb2dJQ0FnUFQwS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnUFQwS0lDQWdJQ1ltQ2lBZ0lDQmhjM05sY25RS0lDQWdJR05oYkd4emRXSWdYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMk52Ym5OMExXeHBkR1Z5WVd4ekxtRnNaMjh1ZEhNNk9rTnZibk4wVEdsMFpYSmhiSE5CYkdkdkxuUmxjM1JiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMFpYTjBPZ29nSUNBZ1lpQjBaWE4wWDJKc2IyTnJRREFLQ25SbGMzUmZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5amIyNXpkQzFzYVhSbGNtRnNjeTVoYkdkdkxuUnpPakUyQ2lBZ0lDQXZMeUIwWlhOMEtDazZJSFZwYm5RMk5DQjdDaUFnSUNCallXeHNjM1ZpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlqYjI1emRDMXNhWFJsY21Gc2N5NWhiR2R2TG5Sek9qcERiMjV6ZEV4cGRHVnlZV3h6UVd4bmJ5NTBaWE4wQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lIVnVZMjkyWlhJZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WTI5dWMzUXRiR2wwWlhKaGJITXVZV3huYnk1MGN6bzZRMjl1YzNSTWFYUmxjbUZzYzBGc1oyOHVkR1Z6ZERKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBaWE4wTWpvS0lDQWdJR0lnZEdWemRESmZZbXh2WTJ0QU1Bb0tkR1Z6ZERKZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlqYjI1emRDMXNhWFJsY21Gc2N5NWhiR2R2TG5Sek9qSXdDaUFnSUNBdkx5QjBaWE4wTWlncElIc0tJQ0FnSUdOaGJHeHpkV0lnZEdWemRITXZZWEJ3Y205MllXeHpMMk52Ym5OMExXeHBkR1Z5WVd4ekxtRnNaMjh1ZEhNNk9rTnZibk4wVEdsMFpYSmhiSE5CYkdkdkxuUmxjM1F5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lIVnVZMjkyWlhJZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WTI5dWMzUXRiR2wwWlhKaGJITXVZV3huYnk1MGN6bzZRMjl1YzNSTWFYUmxjbUZzYzBGc1oyOHVkR1Z6ZEROYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBaWE4wTXpvS0lDQWdJR0lnZEdWemRETmZZbXh2WTJ0QU1Bb0tkR1Z6ZEROZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlqYjI1emRDMXNhWFJsY21Gc2N5NWhiR2R2TG5Sek9qSTFDaUFnSUNBdkx5QjBaWE4wTXlncE9pQjFhVzUwTmpRZ2V3b2dJQ0FnWTJGc2JITjFZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZMjl1YzNRdGJHbDBaWEpoYkhNdVlXeG5ieTUwY3pvNlEyOXVjM1JNYVhSbGNtRnNjMEZzWjI4dWRHVnpkRE1LSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlqYjI1emRDMXNhWFJsY21Gc2N5NWhiR2R2TG5Sek9qcERiMjV6ZEV4cGRHVnlZV3h6UVd4bmJ5NTBaWE4wTkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuUmxjM1EwT2dvZ0lDQWdZaUIwWlhOME5GOWliRzlqYTBBd0NncDBaWE4wTkY5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMk52Ym5OMExXeHBkR1Z5WVd4ekxtRnNaMjh1ZEhNNk16SUtJQ0FnSUM4dklIUmxjM1EwS0NrNklIVnBiblEyTkNCN0NpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWpiMjV6ZEMxc2FYUmxjbUZzY3k1aGJHZHZMblJ6T2pwRGIyNXpkRXhwZEdWeVlXeHpRV3huYnk1MFpYTjBOQW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMk52Ym5OMExXeHBkR1Z5WVd4ekxtRnNaMjh1ZEhNNk9rTnZibk4wVEdsMFpYSmhiSE5CYkdkdkxuUmxjM1ExVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHVnpkRFU2Q2lBZ0lDQmlJSFJsYzNRMVgySnNiMk5yUURBS0NuUmxjM1ExWDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZMjl1YzNRdGJHbDBaWEpoYkhNdVlXeG5ieTUwY3pvek53b2dJQ0FnTHk4Z2RHVnpkRFVvS1NCN0NpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWpiMjV6ZEMxc2FYUmxjbUZzY3k1aGJHZHZMblJ6T2pwRGIyNXpkRXhwZEdWeVlXeHpRV3huYnk1MFpYTjBOUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBMk5Bb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2FXNTBZMTh5SUM4dklEWTBDaUFnSUNCaWVtVnlid29nSUNBZ1lud0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWpiMjV6ZEMxc2FYUmxjbUZzY3k1aGJHZHZMblJ6T2pwRGIyNXpkRXhwZEdWeVlXeHpRV3huYnk1MFpYTjBObHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25SbGMzUTJPZ29nSUNBZ1lpQjBaWE4wTmw5aWJHOWphMEF3Q2dwMFpYTjBObDlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyTnZibk4wTFd4cGRHVnlZV3h6TG1Gc1oyOHVkSE02TkRFS0lDQWdJQzh2SUhSbGMzUTJLQ2s2SUdKcFozVnBiblFnZXdvZ0lDQWdZMkZzYkhOMVlpQjBaWE4wY3k5aGNIQnliM1poYkhNdlkyOXVjM1F0YkdsMFpYSmhiSE11WVd4bmJ5NTBjem82UTI5dWMzUk1hWFJsY21Gc2MwRnNaMjh1ZEdWemREWUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTmpRS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNaUF2THlBMk5Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUdKOENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlkyOXVjM1F0YkdsMFpYSmhiSE11WVd4bmJ5NTBjem82UTI5dWMzUk1hWFJsY21Gc2MwRnNaMjh1ZEdWemRDZ3BJQzArSUhWcGJuUTJORG9LZEdWemRITXZZWEJ3Y205MllXeHpMMk52Ym5OMExXeHBkR1Z5WVd4ekxtRnNaMjh1ZEhNNk9rTnZibk4wVEdsMFpYSmhiSE5CYkdkdkxuUmxjM1E2Q2lBZ0lDQmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWpiMjV6ZEMxc2FYUmxjbUZzY3k1aGJHZHZMblJ6T2pwRGIyNXpkRXhwZEdWeVlXeHpRV3huYnk1MFpYTjBYMkpzYjJOclFEQUtDblJsYzNSekwyRndjSEp2ZG1Gc2N5OWpiMjV6ZEMxc2FYUmxjbUZzY3k1aGJHZHZMblJ6T2pwRGIyNXpkRXhwZEdWeVlXeHpRV3huYnk1MFpYTjBYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlkyOXVjM1F0YkdsMFpYSmhiSE11WVd4bmJ5NTBjem94TndvZ0lDQWdMeThnY21WMGRYSnVJSGdLSUNBZ0lIQjFjMmhwYm5RZ01USXpDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlkyOXVjM1F0YkdsMFpYSmhiSE11WVd4bmJ5NTBjem82UTI5dWMzUk1hWFJsY21Gc2MwRnNaMjh1ZEdWemRESW9LU0F0UGlCMWFXNTBOalE2Q25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTlqYjI1emRDMXNhWFJsY21Gc2N5NWhiR2R2TG5Sek9qcERiMjV6ZEV4cGRHVnlZV3h6UVd4bmJ5NTBaWE4wTWpvS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMMk52Ym5OMExXeHBkR1Z5WVd4ekxtRnNaMjh1ZEhNNk9rTnZibk4wVEdsMFpYSmhiSE5CYkdkdkxuUmxjM1F5WDJKc2IyTnJRREFLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTlqYjI1emRDMXNhWFJsY21Gc2N5NWhiR2R2TG5Sek9qcERiMjV6ZEV4cGRHVnlZV3h6UVd4bmJ5NTBaWE4wTWw5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMk52Ym5OMExXeHBkR1Z5WVd4ekxtRnNaMjh1ZEhNNk1qSUtJQ0FnSUM4dklISmxkSFZ5YmlCMFpYTjBDaUFnSUNCd2RYTm9hVzUwSURRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlqYjI1emRDMXNhWFJsY21Gc2N5NWhiR2R2TG5Sek9qcERiMjV6ZEV4cGRHVnlZV3h6UVd4bmJ5NTBaWE4wTXlncElDMCtJSFZwYm5RMk5Eb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyTnZibk4wTFd4cGRHVnlZV3h6TG1Gc1oyOHVkSE02T2tOdmJuTjBUR2wwWlhKaGJITkJiR2R2TG5SbGMzUXpPZ29nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdlkyOXVjM1F0YkdsMFpYSmhiSE11WVd4bmJ5NTBjem82UTI5dWMzUk1hWFJsY21Gc2MwRnNaMjh1ZEdWemRETmZZbXh2WTJ0QU1Bb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyTnZibk4wTFd4cGRHVnlZV3h6TG1Gc1oyOHVkSE02T2tOdmJuTjBUR2wwWlhKaGJITkJiR2R2TG5SbGMzUXpYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlkyOXVjM1F0YkdsMFpYSmhiSE11WVd4bmJ5NTBjem95T1FvZ0lDQWdMeThnY21WMGRYSnVJSGdnS2lCNUNpQWdJQ0J3ZFhOb2FXNTBJREV5Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZMjl1YzNRdGJHbDBaWEpoYkhNdVlXeG5ieTUwY3pvNlEyOXVjM1JNYVhSbGNtRnNjMEZzWjI4dWRHVnpkRFFvS1NBdFBpQjFhVzUwTmpRNkNuUmxjM1J6TDJGd2NISnZkbUZzY3k5amIyNXpkQzFzYVhSbGNtRnNjeTVoYkdkdkxuUnpPanBEYjI1emRFeHBkR1Z5WVd4elFXeG5ieTUwWlhOME5Eb0tJQ0FnSUdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDJOdmJuTjBMV3hwZEdWeVlXeHpMbUZzWjI4dWRITTZPa052Ym5OMFRHbDBaWEpoYkhOQmJHZHZMblJsYzNRMFgySnNiMk5yUURBS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5amIyNXpkQzFzYVhSbGNtRnNjeTVoYkdkdkxuUnpPanBEYjI1emRFeHBkR1Z5WVd4elFXeG5ieTUwWlhOME5GOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJOdmJuTjBMV3hwZEdWeVlXeHpMbUZzWjI4dWRITTZNek1LSUNBZ0lDOHZJR0Z6YzJWeWRDaG5aWFJDYVhRb2RXNXpZV1psVG5WdFltVnlMQ0EyTXlrcENpQWdJQ0JwYm5Salh6TWdMeThnT1RJeU16TTNNakF6TmpnMU5EYzNOVGd3T0FvZ0lDQWdjSFZ6YUdsdWRDQTJNd29nSUNBZ1oyVjBZbWwwQ2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlqYjI1emRDMXNhWFJsY21Gc2N5NWhiR2R2TG5Sek9qTTBDaUFnSUNBdkx5QnlaWFIxY200Z2RXNXpZV1psVG5WdFltVnlDaUFnSUNCcGJuUmpYek1nTHk4Z09USXlNek0zTWpBek5qZzFORGMzTlRnd09Bb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJOdmJuTjBMV3hwZEdWeVlXeHpMbUZzWjI4dWRITTZPa052Ym5OMFRHbDBaWEpoYkhOQmJHZHZMblJsYzNRMUtDa2dMVDRnWW5sMFpYTTZDblJsYzNSekwyRndjSEp2ZG1Gc2N5OWpiMjV6ZEMxc2FYUmxjbUZzY3k1aGJHZHZMblJ6T2pwRGIyNXpkRXhwZEdWeVlXeHpRV3huYnk1MFpYTjBOVG9LSUNBZ0lHSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyTnZibk4wTFd4cGRHVnlZV3h6TG1Gc1oyOHVkSE02T2tOdmJuTjBUR2wwWlhKaGJITkJiR2R2TG5SbGMzUTFYMkpzYjJOclFEQUtDblJsYzNSekwyRndjSEp2ZG1Gc2N5OWpiMjV6ZEMxc2FYUmxjbUZzY3k1aGJHZHZMblJ6T2pwRGIyNXpkRXhwZEdWeVlXeHpRV3huYnk1MFpYTjBOVjlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyTnZibk4wTFd4cGRHVnlZV3h6TG1Gc1oyOHVkSE02TXpnS0lDQWdJQzh2SUhKbGRIVnliaUJDYVdkVmFXNTBLSFZ1YzJGbVpWVnBiblEyTkNrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWpiMjV6ZEMxc2FYUmxjbUZzY3k1aGJHZHZMblJ6T2pwRGIyNXpkRXhwZEdWeVlXeHpRV3huYnk1MFpYTjBOaWdwSUMwK0lHSjVkR1Z6T2dwMFpYTjBjeTloY0hCeWIzWmhiSE12WTI5dWMzUXRiR2wwWlhKaGJITXVZV3huYnk1MGN6bzZRMjl1YzNSTWFYUmxjbUZzYzBGc1oyOHVkR1Z6ZERZNkNpQWdJQ0JpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlqYjI1emRDMXNhWFJsY21Gc2N5NWhiR2R2TG5Sek9qcERiMjV6ZEV4cGRHVnlZV3h6UVd4bmJ5NTBaWE4wTmw5aWJHOWphMEF3Q2dwMFpYTjBjeTloY0hCeWIzWmhiSE12WTI5dWMzUXRiR2wwWlhKaGJITXVZV3huYnk1MGN6bzZRMjl1YzNSTWFYUmxjbUZzYzBGc1oyOHVkR1Z6ZERaZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlqYjI1emRDMXNhWFJsY21Gc2N5NWhiR2R2TG5Sek9qUXlDaUFnSUNBdkx5QnlaWFIxY200Z1lRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlkyOXVjM1F0YkdsMFpYSmhiSE11WVd4bmJ5NTBjem82UTI5dWMzUk1hWFJsY21Gc2MwRnNaMjh1WDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxLQ2tnTFQ0Z2RtOXBaRG9LWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxPZ29nSUNBZ1lpQmZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWZllteHZZMnRBTUFvS1gxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsWDJKc2IyTnJRREE2Q2lBZ0lDQnlaWFJ6ZFdJSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JpSUcxaGFXNWZZbXh2WTJ0QU1Bb0tiV0ZwYmw5aWJHOWphMEF3T2dvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFRQkFnSUNBZ0lDQWdJQ0FBU1lCQkJVZmZIVkNBQUJDQUFBeEd5TVRRUUI2UWdBQU1Sa2pFa1F4R0NNVFFRQm9RZ0FBTmhvQWdBVC92RGtVZ0FRMEdqZVVnQVJ6NWJESGdBUlFOQ1pyZ0FTcTJvN3VnQVJPazF0dVR3YU9CZ0FvQUNJQUhBQVdBQkFBQ2tJQUFFSUFBRUlBQUFDSUFJQkMvL09JQUdWQy8rMklBRkZDLytlSUFEMUMvK0dJQUNsQy85dUlBQlZDLzlWQy85VXhHU01TTVJnakVoQkVpQUMrSWtOQ0FBQ0lBRndXS0U4QlVMQWlRMElBQUlnQVZCWW9Ud0ZRc0NKRFFnQUFpQUJNRmloUEFWQ3dJa05DQUFDSUFFUVdLRThCVUxBaVEwSUFBSWdBUUVrVkpBNUVKSytyS0U4QlVMQWlRMElBQUlnQVFra1ZKQTVFSksrcktFOEJVTEFpUTBJQUFJRjdpVUlBQUlFRWlVSUFBSUVNaVVJQUFDV0JQMU5FSllsQ0FBQ0FFUUVBQUFBQUFBQUFBQUFBQUFBQUFBQUFpVUlBQUlBaEFRQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBaVVJQUFJaz0iLCJjbGVhciI6IkMwSUFBSUVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
