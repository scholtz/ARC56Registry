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

namespace Arc56.Generated.algorandfoundation.puya_ts.ForLoopsAlgo_2ecf6383
{


    public class ForLoopsAlgoProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ForLoopsAlgoProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="start"> </param>
        /// <param name="stop"> </param>
        /// <param name="step"> </param>
        public async Task<ulong> TestForLoop(ulong start, ulong stop, ulong step, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 248, 101, 79, 115 };
            var startAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); startAbi.From(start);
            var stopAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stopAbi.From(stop);
            var stepAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stepAbi.From(step);

            var result = await base.CallApp(new List<object> { abiHandle, startAbi, stopAbi, stepAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TestForLoop_Transactions(ulong start, ulong stop, ulong step, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 248, 101, 79, 115 };
            var startAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); startAbi.From(start);
            var stopAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stopAbi.From(stop);
            var stepAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stepAbi.From(step);

            return await base.MakeTransactionList(new List<object> { abiHandle, startAbi, stopAbi, stepAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="start"> </param>
        /// <param name="stop"> </param>
        /// <param name="step"> </param>
        public async Task<ulong> TestForLoopBreak(ulong start, ulong stop, ulong step, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 40, 127, 76, 2 };
            var startAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); startAbi.From(start);
            var stopAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stopAbi.From(stop);
            var stepAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stepAbi.From(step);

            var result = await base.CallApp(new List<object> { abiHandle, startAbi, stopAbi, stepAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TestForLoopBreak_Transactions(ulong start, ulong stop, ulong step, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 40, 127, 76, 2 };
            var startAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); startAbi.From(start);
            var stopAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stopAbi.From(stop);
            var stepAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stepAbi.From(step);

            return await base.MakeTransactionList(new List<object> { abiHandle, startAbi, stopAbi, stepAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="start"> </param>
        /// <param name="stop"> </param>
        /// <param name="step"> </param>
        public async Task<ulong> TestForLoopContinue(ulong start, ulong stop, ulong step, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 75, 215, 119, 140 };
            var startAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); startAbi.From(start);
            var stopAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stopAbi.From(stop);
            var stepAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stepAbi.From(step);

            var result = await base.CallApp(new List<object> { abiHandle, startAbi, stopAbi, stepAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TestForLoopContinue_Transactions(ulong start, ulong stop, ulong step, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 75, 215, 119, 140 };
            var startAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); startAbi.From(start);
            var stopAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stopAbi.From(stop);
            var stepAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stepAbi.From(step);

            return await base.MakeTransactionList(new List<object> { abiHandle, startAbi, stopAbi, stepAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="start"> </param>
        /// <param name="stop"> </param>
        /// <param name="step"> </param>
        public async Task<ulong> TestForLoopLabelled(ulong start, ulong stop, ulong step, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 103, 94, 6 };
            var startAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); startAbi.From(start);
            var stopAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stopAbi.From(stop);
            var stepAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stepAbi.From(step);

            var result = await base.CallApp(new List<object> { abiHandle, startAbi, stopAbi, stepAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TestForLoopLabelled_Transactions(ulong start, ulong stop, ulong step, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 103, 94, 6 };
            var startAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); startAbi.From(start);
            var stopAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stopAbi.From(stop);
            var stepAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stepAbi.From(step);

            return await base.MakeTransactionList(new List<object> { abiHandle, startAbi, stopAbi, stepAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRm9yTG9vcHNBbGdvIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6InRlc3RfZm9yX2xvb3AiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RhcnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0b3AiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0ZXAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0X2Zvcl9sb29wX2JyZWFrIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0YXJ0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdG9wIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdGVwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdF9mb3JfbG9vcF9jb250aW51ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdGFydCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RvcCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RlcCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RfZm9yX2xvb3BfbGFiZWxsZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RhcnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0b3AiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0ZXAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzcyLDg0LDk1LDE4MCwxODksMjAwLDI1NiwyNjUsMjc2LDMzMSwzNDAsMzUxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dPQ0F3SURFS0lDQWdJR0o1ZEdWallteHZZMnNnTUhneE5URm1OMk0zTlFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lpQ2lBZ0lDQmtkWEJ1SURVS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTltYjNJdGJHOXZjSE11WVd4bmJ5NTBjem8wQ2lBZ0lDQXZMeUJqYkdGemN5QkdiM0pNYjI5d2MwRnNaMjhnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1URUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VHWTROalUwWmpjeklEQjRNamczWmpSak1ESWdNSGcwWW1RM056YzRZeUF3ZURNek5qYzFaVEEySUM4dklHMWxkR2h2WkNBaWRHVnpkRjltYjNKZmJHOXZjQ2gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkNsMWFXNTBOalFpTENCdFpYUm9iMlFnSW5SbGMzUmZabTl5WDJ4dmIzQmZZbkpsWVdzb2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXBkV2x1ZERZMElpd2diV1YwYUc5a0lDSjBaWE4wWDJadmNsOXNiMjl3WDJOdmJuUnBiblZsS0hWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaWRHVnpkRjltYjNKZmJHOXZjRjlzWVdKbGJHeGxaQ2gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkNsMWFXNTBOalFpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYM1JsYzNSZlptOXlYMnh2YjNCZmNtOTFkR1ZBTkNCdFlXbHVYM1JsYzNSZlptOXlYMnh2YjNCZlluSmxZV3RmY205MWRHVkFOU0J0WVdsdVgzUmxjM1JmWm05eVgyeHZiM0JmWTI5dWRHbHVkV1ZmY205MWRHVkFOaUJ0WVdsdVgzUmxjM1JmWm05eVgyeHZiM0JmYkdGaVpXeHNaV1JmY205MWRHVkFOd29nSUNBZ1pYSnlDZ3B0WVdsdVgzUmxjM1JmWm05eVgyeHZiM0JmYkdGaVpXeHNaV1JmY205MWRHVkFOem9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW1iM0l0Ykc5dmNITXVZV3huYnk1MGN6b3pNZ29nSUNBZ0x5OGdkR1Z6ZEY5bWIzSmZiRzl2Y0Y5c1lXSmxiR3hsWkNoemRHRnlkRG9nZFdsdWREWTBMQ0J6ZEc5d09pQjFhVzUwTmpRc0lITjBaWEE2SUhWcGJuUTJOQ2tnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlEVUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lHSjFjbmtnTXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnWW5WeWVTQTBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMV3h2YjNCekxtRnNaMjh1ZEhNNk16TUtJQ0FnSUM4dklHeGxkQ0IwYjNSaGJDQTlJRlZwYm5RMk5DZ3dLUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKMWNua2dNZ29nSUNBZ1luVnllU0EyQ2dwdFlXbHVYM2RvYVd4bFgzUnZjRUF4TlRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTltYjNJdGJHOXZjSE11WVd4bmJ5NTBjem96TkFvZ0lDQWdMeThnYjNWMFpYSTZJR1p2Y2lBb2JHVjBJR2tnUFNCemRHRnlkRHNnYVNBOElITjBiM0E3SUdrZ0t6MGdjM1JsY0NrZ2V3b2dJQ0FnWkdsbklEVUtJQ0FnSUdScFp5QXlDaUFnSUNBOENpQWdJQ0JpZWlCdFlXbHVYMkpzYjJOclFESXpDaUFnSUNCa2FXY2dNd29nSUNBZ1luVnllU0ExQ2dwdFlXbHVYM2RvYVd4bFgzUnZjRUF4TnpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTltYjNJdGJHOXZjSE11WVd4bmJ5NTBjem96TlFvZ0lDQWdMeThnWm05eUlDaHNaWFFnYWlBOUlITjBZWEowT3lCcUlEd2djM1J2Y0RzZ2FpQXJQU0J6ZEdWd0tTQjdDaUFnSUNCa2FXY2dOQW9nSUNBZ1pHbG5JRElLSUNBZ0lEd0tJQ0FnSUdKNklHMWhhVzVmWVdaMFpYSmZkMmhwYkdWQU1qRUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiRzl2Y0hNdVlXeG5ieTUwY3pvek5nb2dJQ0FnTHk4Z2RHOTBZV3dnS3owZ2FTQXJJR29LSUNBZ0lHUnBaeUExQ2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUEyQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJQ3NLSUNBZ0lHUnBaeUF6Q2lBZ0lDQXJDaUFnSUNCaWRYSjVJRE1LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW1iM0l0Ykc5dmNITXVZV3huYnk1MGN6b3pPQW9nSUNBZ0x5OGdhV1lnS0drZ0tpQnFJRDRnYzNSdmNDa2dZbkpsWVdzZ2IzVjBaWElLSUNBZ0lDb0tJQ0FnSUdScFp5QXlDaUFnSUNBK0NpQWdJQ0JpYm5vZ2JXRnBibDlpYkc5amEwQXlNd29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTFzYjI5d2N5NWhiR2R2TG5Sek9qTTFDaUFnSUNBdkx5Qm1iM0lnS0d4bGRDQnFJRDBnYzNSaGNuUTdJR29nUENCemRHOXdPeUJxSUNzOUlITjBaWEFwSUhzS0lDQWdJR1JwWnlBMENpQWdJQ0JrYVdjZ013b2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBMUNpQWdJQ0JpSUcxaGFXNWZkMmhwYkdWZmRHOXdRREUzQ2dwdFlXbHVYMkpzYjJOclFESXpPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTFzYjI5d2N5NWhiR2R2TG5Sek9qTXlDaUFnSUNBdkx5QjBaWE4wWDJadmNsOXNiMjl3WDJ4aFltVnNiR1ZrS0hOMFlYSjBPaUIxYVc1ME5qUXNJSE4wYjNBNklIVnBiblEyTkN3Z2MzUmxjRG9nZFdsdWREWTBLU0I3Q2lBZ0lDQmtkWEFLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZV1owWlhKZmQyaHBiR1ZBTWpFNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXeHZiM0J6TG1Gc1oyOHVkSE02TXpRS0lDQWdJQzh2SUc5MWRHVnlPaUJtYjNJZ0tHeGxkQ0JwSUQwZ2MzUmhjblE3SUdrZ1BDQnpkRzl3T3lCcElDczlJSE4wWlhBcElIc0tJQ0FnSUdScFp5QTFDaUFnSUNCa2FXY2dNd29nSUNBZ0t3b2dJQ0FnWW5WeWVTQTJDaUFnSUNCaUlHMWhhVzVmZDJocGJHVmZkRzl3UURFMUNncHRZV2x1WDNSbGMzUmZabTl5WDJ4dmIzQmZZMjl1ZEdsdWRXVmZjbTkxZEdWQU5qb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiRzl2Y0hNdVlXeG5ieTUwY3pveU5Bb2dJQ0FnTHk4Z2RHVnpkRjltYjNKZmJHOXZjRjlqYjI1MGFXNTFaU2h6ZEdGeWREb2dkV2x1ZERZMExDQnpkRzl3T2lCMWFXNTBOalFzSUhOMFpYQTZJSFZwYm5RMk5Da2dld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnWW5WeWVTQXpDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmlkWEo1SURRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTltYjNJdGJHOXZjSE11WVd4bmJ5NTBjem95TlFvZ0lDQWdMeThnYkdWMElIUnZkR0ZzSUQwZ1ZXbHVkRFkwS0RBcENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZblZ5ZVNBeUNpQWdJQ0JpZFhKNUlEWUtDbTFoYVc1ZmQyaHBiR1ZmZEc5d1FESTJPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTFzYjI5d2N5NWhiR2R2TG5Sek9qSTJDaUFnSUNBdkx5Qm1iM0lnS0d4bGRDQnBJRDBnYzNSaGNuUTdJR2tnUENCemRHOXdPeUJwSUNzOUlITjBaWEFwSUhzS0lDQWdJR1JwWnlBMUNpQWdJQ0JrYVdjZ01nb2dJQ0FnUEFvZ0lDQWdZbm9nYldGcGJsOWhablJsY2w5M2FHbHNaVUF6TVFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlp2Y2kxc2IyOXdjeTVoYkdkdkxuUnpPakkzQ2lBZ0lDQXZMeUJwWmlBb2FTQWxJRFVnUFQwOUlEQXBJR052Ym5ScGJuVmxDaUFnSUNCa2FXY2dOUW9nSUNBZ2NIVnphR2x1ZENBMUNpQWdJQ0FsQ2lBZ0lDQmllaUJ0WVdsdVgySnNiMk5yUURNd0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXeHZiM0J6TG1Gc1oyOHVkSE02TWpnS0lDQWdJQzh2SUhSdmRHRnNJQ3M5SUdrS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURZS0lDQWdJQ3NLSUNBZ0lHSjFjbmtnTVFvS2JXRnBibDlpYkc5amEwQXpNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW1iM0l0Ykc5dmNITXVZV3huYnk1MGN6b3lOZ29nSUNBZ0x5OGdabTl5SUNoc1pYUWdhU0E5SUhOMFlYSjBPeUJwSUR3Z2MzUnZjRHNnYVNBclBTQnpkR1Z3S1NCN0NpQWdJQ0JrYVdjZ05Rb2dJQ0FnWkdsbklETUtJQ0FnSUNzS0lDQWdJR0oxY25rZ05nb2dJQ0FnWWlCdFlXbHVYM2RvYVd4bFgzUnZjRUF5TmdvS2JXRnBibDloWm5SbGNsOTNhR2xzWlVBek1Ub0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiRzl2Y0hNdVlXeG5ieTUwY3pveU5Bb2dJQ0FnTHk4Z2RHVnpkRjltYjNKZmJHOXZjRjlqYjI1MGFXNTFaU2h6ZEdGeWREb2dkV2x1ZERZMExDQnpkRzl3T2lCMWFXNTBOalFzSUhOMFpYQTZJSFZwYm5RMk5Da2dld29nSUNBZ1pIVndDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjM1JmWm05eVgyeHZiM0JmWW5KbFlXdGZjbTkxZEdWQU5Ub0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiRzl2Y0hNdVlXeG5ieTUwY3pveE13b2dJQ0FnTHk4Z2RHVnpkRjltYjNKZmJHOXZjRjlpY21WaGF5aHpkR0Z5ZERvZ2RXbHVkRFkwTENCemRHOXdPaUIxYVc1ME5qUXNJSE4wWlhBNklIVnBiblEyTkNrZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdZblZ5ZVNBekNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCaWRYSjVJRFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW1iM0l0Ykc5dmNITXVZV3huYnk1MGN6b3hOQW9nSUNBZ0x5OGdiR1YwSUhSdmRHRnNJRDBnVldsdWREWTBLREFwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1luVnllU0F5Q2lBZ0lDQmlkWEo1SURZS0NtMWhhVzVmZDJocGJHVmZkRzl3UURNME9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJadmNpMXNiMjl3Y3k1aGJHZHZMblJ6T2pFMUNpQWdJQ0F2THlCbWIzSWdLR3hsZENCcElEMGdjM1JoY25RN0lHa2dQQ0J6ZEc5d095QnBJQ3M5SUhOMFpYQXBJSHNLSUNBZ0lHUnBaeUExQ2lBZ0lDQmthV2NnTWdvZ0lDQWdQQW9nSUNBZ1lub2diV0ZwYmw5aWJHOWphMEF6T1FvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlp2Y2kxc2IyOXdjeTVoYkdkdkxuUnpPakUyQ2lBZ0lDQXZMeUIwYjNSaGJDQXJQU0JwQ2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUEyQ2lBZ0lDQXJDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTFzYjI5d2N5NWhiR2R2TG5Sek9qRTNDaUFnSUNBdkx5QnBaaUFvZEc5MFlXd2dQaUF4TUNrZ2V3b2dJQ0FnY0hWemFHbHVkQ0F4TUFvZ0lDQWdQZ29nSUNBZ1ltNTZJRzFoYVc1ZllteHZZMnRBTXprS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTltYjNJdGJHOXZjSE11WVd4bmJ5NTBjem94TlFvZ0lDQWdMeThnWm05eUlDaHNaWFFnYVNBOUlITjBZWEowT3lCcElEd2djM1J2Y0RzZ2FTQXJQU0J6ZEdWd0tTQjdDaUFnSUNCa2FXY2dOUW9nSUNBZ1pHbG5JRE1LSUNBZ0lDc0tJQ0FnSUdKMWNua2dOZ29nSUNBZ1lpQnRZV2x1WDNkb2FXeGxYM1J2Y0VBek5Bb0tiV0ZwYmw5aWJHOWphMEF6T1RvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTltYjNJdGJHOXZjSE11WVd4bmJ5NTBjem94TXdvZ0lDQWdMeThnZEdWemRGOW1iM0pmYkc5dmNGOWljbVZoYXloemRHRnlkRG9nZFdsdWREWTBMQ0J6ZEc5d09pQjFhVzUwTmpRc0lITjBaWEE2SUhWcGJuUTJOQ2tnZXdvZ0lDQWdaSFZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1JsYzNSZlptOXlYMnh2YjNCZmNtOTFkR1ZBTkRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTltYjNJdGJHOXZjSE11WVd4bmJ5NTBjem8xQ2lBZ0lDQXZMeUIwWlhOMFgyWnZjbDlzYjI5d0tITjBZWEowT2lCMWFXNTBOalFzSUhOMGIzQTZJSFZwYm5RMk5Dd2djM1JsY0RvZ2RXbHVkRFkwS1NCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmlkWEo1SURNS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUdKMWNua2dOQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTFzYjI5d2N5NWhiR2R2TG5Sek9qWUtJQ0FnSUM4dklHeGxkQ0IwYjNSaGJDQTlJRlZwYm5RMk5DZ3dLUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKMWNua2dNZ29nSUNBZ1luVnllU0EyQ2dwdFlXbHVYM2RvYVd4bFgzUnZjRUEwTWpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTltYjNJdGJHOXZjSE11WVd4bmJ5NTBjem8zQ2lBZ0lDQXZMeUJtYjNJZ0tHeGxkQ0JwSUQwZ2MzUmhjblE3SUdrZ1BDQnpkRzl3T3lCcElDczlJSE4wWlhBcElIc0tJQ0FnSUdScFp5QTFDaUFnSUNCa2FXY2dNZ29nSUNBZ1BBb2dJQ0FnWW5vZ2JXRnBibDloWm5SbGNsOTNhR2xzWlVBME5Bb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJadmNpMXNiMjl3Y3k1aGJHZHZMblJ6T2pnS0lDQWdJQzh2SUhSdmRHRnNJQ3M5SUdrS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURZS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBeUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXeHZiM0J6TG1Gc1oyOHVkSE02TndvZ0lDQWdMeThnWm05eUlDaHNaWFFnYVNBOUlITjBZWEowT3lCcElEd2djM1J2Y0RzZ2FTQXJQU0J6ZEdWd0tTQjdDaUFnSUNCa2FXY2dNd29nSUNBZ0t3b2dJQ0FnWW5WeWVTQTJDaUFnSUNCaUlHMWhhVzVmZDJocGJHVmZkRzl3UURReUNncHRZV2x1WDJGbWRHVnlYM2RvYVd4bFFEUTBPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTFzYjI5d2N5NWhiR2R2TG5Sek9qVUtJQ0FnSUM4dklIUmxjM1JmWm05eVgyeHZiM0FvYzNSaGNuUTZJSFZwYm5RMk5Dd2djM1J2Y0RvZ2RXbHVkRFkwTENCemRHVndPaUIxYVc1ME5qUXBJSHNLSUNBZ0lHUjFjQW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1URTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMV3h2YjNCekxtRnNaMjh1ZEhNNk5Bb2dJQ0FnTHk4Z1kyeGhjM01nUm05eVRHOXZjSE5CYkdkdklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFEQ0FBQkpnRUVGUjk4ZFlBQVJ3VXhHMEVCY3pFWkZFUXhHRVNDQkFUNFpVOXpCQ2gvVEFJRVM5ZDNqQVF6WjE0R05ob0FqZ1FCQkFDNUFHMEFBUUEyR2dGSkZTSVNSQmRKUlFVMkdnSkpGU0lTUkJkRkF6WWFBMGtWSWhKRUYwVUVJMFVDUlFaTEJVc0NERUVBSzBzRFJRVkxCRXNDREVFQUowc0ZTVXNHU1U0RENFc0RDRVVEQzBzQ0RVQUFDa3NFU3dNSVJRVkMvOWxKRmloTVVMQWtRMHNGU3dNSVJRWkMvN3MyR2dGSkZTSVNSQmMyR2dKSkZTSVNSQmRGQXpZYUEwa1ZJaEpFRjBVRUkwVUNSUVpMQlVzQ0RFRUFHRXNGZ1FVWVFRQUdTVXNHQ0VVQlN3VkxBd2hGQmtMLzRFa1dLRXhRc0NSRE5ob0JTUlVpRWtRWE5ob0NTUlVpRWtRWFJRTTJHZ05KRlNJU1JCZEZCQ05GQWtVR1N3VkxBZ3hCQUJkSlN3WUlTVVVDZ1FvTlFBQUtTd1ZMQXdoRkJrTC80VWtXS0V4UXNDUkROaG9CU1JVaUVrUVhOaG9DU1JVaUVrUVhSUU0yR2dOSkZTSVNSQmRGQkNORkFrVUdTd1ZMQWd4QkFCRkpTd1pKVGdJSVJRSkxBd2hGQmtMLzUwa1dLRXhRc0NSRE1Sa1VNUmdVRUVNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
