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

namespace Arc56.Generated.algorandfoundation.puya_ts.ForLoopsAlgo_249ce421
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRm9yTG9vcHNBbGdvIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6InRlc3RfZm9yX2xvb3AiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RhcnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0b3AiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0ZXAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0X2Zvcl9sb29wX2JyZWFrIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0YXJ0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdG9wIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdGVwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdF9mb3JfbG9vcF9jb250aW51ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdGFydCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RvcCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RlcCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RfZm9yX2xvb3BfbGFiZWxsZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RhcnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0b3AiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0ZXAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6Wzc2LDg1LDk1LDEzOCwxNDcsMTU3LDIwNSwyMTQsMjI0LDI3NCwyODQsMjk0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dPQ0F3SURFS0lDQWdJR0o1ZEdWallteHZZMnNnTUhneE5URm1OMk0zTlFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlp2Y2kxc2IyOXdjeTVoYkdkdkxuUnpPalFLSUNBZ0lDOHZJR05zWVhOeklFWnZja3h2YjNCelFXeG5ieUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBeE1Rb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNFpqZzJOVFJtTnpNZ01IZ3lPRGRtTkdNd01pQXdlRFJpWkRjM056aGpJREI0TXpNMk56VmxNRFlnTHk4Z2JXVjBhRzlrSUNKMFpYTjBYMlp2Y2w5c2IyOXdLSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpZEdWemRGOW1iM0pmYkc5dmNGOWljbVZoYXloMWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0luUmxjM1JmWm05eVgyeHZiM0JmWTI5dWRHbHVkV1VvZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKMFpYTjBYMlp2Y2w5c2IyOXdYMnhoWW1Wc2JHVmtLSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwS1hWcGJuUTJOQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUhSbGMzUmZabTl5WDJ4dmIzQWdkR1Z6ZEY5bWIzSmZiRzl2Y0Y5aWNtVmhheUIwWlhOMFgyWnZjbDlzYjI5d1gyTnZiblJwYm5WbElIUmxjM1JmWm05eVgyeHZiM0JmYkdGaVpXeHNaV1FLSUNBZ0lHVnljZ29LYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1URTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMV3h2YjNCekxtRnNaMjh1ZEhNNk5Bb2dJQ0FnTHk4Z1kyeGhjM01nUm05eVRHOXZjSE5CYkdkdklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXeHZiM0J6TG1Gc1oyOHVkSE02T2tadmNreHZiM0J6UVd4bmJ5NTBaWE4wWDJadmNsOXNiMjl3VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHVnpkRjltYjNKZmJHOXZjRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW1iM0l0Ykc5dmNITXVZV3huYnk1MGN6bzFDaUFnSUNBdkx5QjBaWE4wWDJadmNsOXNiMjl3S0hOMFlYSjBPaUIxYVc1ME5qUXNJSE4wYjNBNklIVnBiblEyTkN3Z2MzUmxjRG9nZFdsdWREWTBLU0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCemQyRndDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZabTl5TFd4dmIzQnpMbUZzWjI4dWRITTZOZ29nSUNBZ0x5OGdiR1YwSUhSdmRHRnNJRDBnVldsdWREWTBLREFwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2MzZGhjQW9LZEdWemRGOW1iM0pmYkc5dmNGOTNhR2xzWlY5MGIzQkFNam9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW1iM0l0Ykc5dmNITXVZV3huYnk1MGN6bzNDaUFnSUNBdkx5Qm1iM0lnS0d4bGRDQnBJRDBnYzNSaGNuUTdJR2tnUENCemRHOXdPeUJwSUNzOUlITjBaWEFwSUhzS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURRS0lDQWdJRHdLSUNBZ0lHSjZJSFJsYzNSZlptOXlYMnh2YjNCZllXWjBaWEpmZDJocGJHVkFOQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTFzYjI5d2N5NWhiR2R2TG5Sek9qZ0tJQ0FnSUM4dklIUnZkR0ZzSUNzOUlHa0tJQ0FnSUdSMWNESUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ0t3b2dJQ0FnWW5WeWVTQXpDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMV3h2YjNCekxtRnNaMjh1ZEhNNk53b2dJQ0FnTHk4Z1ptOXlJQ2hzWlhRZ2FTQTlJSE4wWVhKME95QnBJRHdnYzNSdmNEc2dhU0FyUFNCemRHVndLU0I3Q2lBZ0lDQmthV2NnTXdvZ0lDQWdLd29nSUNBZ1luVnllU0F4Q2lBZ0lDQmlJSFJsYzNSZlptOXlYMnh2YjNCZmQyaHBiR1ZmZEc5d1FESUtDblJsYzNSZlptOXlYMnh2YjNCZllXWjBaWEpmZDJocGJHVkFORG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW1iM0l0Ykc5dmNITXVZV3huYnk1MGN6bzFDaUFnSUNBdkx5QjBaWE4wWDJadmNsOXNiMjl3S0hOMFlYSjBPaUIxYVc1ME5qUXNJSE4wYjNBNklIVnBiblEyTkN3Z2MzUmxjRG9nZFdsdWREWTBLU0I3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW1iM0l0Ykc5dmNITXVZV3huYnk1MGN6bzZSbTl5VEc5dmNITkJiR2R2TG5SbGMzUmZabTl5WDJ4dmIzQmZZbkpsWVd0YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBaWE4wWDJadmNsOXNiMjl3WDJKeVpXRnJPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTFzYjI5d2N5NWhiR2R2TG5Sek9qRXpDaUFnSUNBdkx5QjBaWE4wWDJadmNsOXNiMjl3WDJKeVpXRnJLSE4wWVhKME9pQjFhVzUwTmpRc0lITjBiM0E2SUhWcGJuUTJOQ3dnYzNSbGNEb2dkV2x1ZERZMEtTQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0J6ZDJGd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCemQyRndDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMV3h2YjNCekxtRnNaMjh1ZEhNNk1UUUtJQ0FnSUM4dklHeGxkQ0IwYjNSaGJDQTlJRlZwYm5RMk5DZ3dLUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhOM1lYQUtDblJsYzNSZlptOXlYMnh2YjNCZlluSmxZV3RmZDJocGJHVmZkRzl3UURJNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXeHZiM0J6TG1Gc1oyOHVkSE02TVRVS0lDQWdJQzh2SUdadmNpQW9iR1YwSUdrZ1BTQnpkR0Z5ZERzZ2FTQThJSE4wYjNBN0lHa2dLejBnYzNSbGNDa2dld29nSUNBZ1pIVndDaUFnSUNCa2FXY2dOQW9nSUNBZ1BBb2dJQ0FnWW5vZ2RHVnpkRjltYjNKZmJHOXZjRjlpY21WaGExOWliRzlqYTBBM0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXeHZiM0J6TG1Gc1oyOHVkSE02TVRZS0lDQWdJQzh2SUhSdmRHRnNJQ3M5SUdrS0lDQWdJR1IxY0RJS0lDQWdJQ3NLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F6Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZabTl5TFd4dmIzQnpMbUZzWjI4dWRITTZNVGNLSUNBZ0lDOHZJR2xtSUNoMGIzUmhiQ0ErSURFd0tTQjdDaUFnSUNCd2RYTm9hVzUwSURFd0NpQWdJQ0ErQ2lBZ0lDQmlibm9nZEdWemRGOW1iM0pmYkc5dmNGOWljbVZoYTE5aWJHOWphMEEzQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZabTl5TFd4dmIzQnpMbUZzWjI4dWRITTZNVFVLSUNBZ0lDOHZJR1p2Y2lBb2JHVjBJR2tnUFNCemRHRnlkRHNnYVNBOElITjBiM0E3SUdrZ0t6MGdjM1JsY0NrZ2V3b2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ013b2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpSUhSbGMzUmZabTl5WDJ4dmIzQmZZbkpsWVd0ZmQyaHBiR1ZmZEc5d1FESUtDblJsYzNSZlptOXlYMnh2YjNCZlluSmxZV3RmWW14dlkydEFOem9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW1iM0l0Ykc5dmNITXVZV3huYnk1MGN6b3hNd29nSUNBZ0x5OGdkR1Z6ZEY5bWIzSmZiRzl2Y0Y5aWNtVmhheWh6ZEdGeWREb2dkV2x1ZERZMExDQnpkRzl3T2lCMWFXNTBOalFzSUhOMFpYQTZJSFZwYm5RMk5Da2dld29nSUNBZ1pHbG5JREVLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMV3h2YjNCekxtRnNaMjh1ZEhNNk9rWnZja3h2YjNCelFXeG5ieTUwWlhOMFgyWnZjbDlzYjI5d1gyTnZiblJwYm5WbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkR1Z6ZEY5bWIzSmZiRzl2Y0Y5amIyNTBhVzUxWlRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTltYjNJdGJHOXZjSE11WVd4bmJ5NTBjem95TkFvZ0lDQWdMeThnZEdWemRGOW1iM0pmYkc5dmNGOWpiMjUwYVc1MVpTaHpkR0Z5ZERvZ2RXbHVkRFkwTENCemRHOXdPaUIxYVc1ME5qUXNJSE4wWlhBNklIVnBiblEyTkNrZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdjM2RoY0FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJadmNpMXNiMjl3Y3k1aGJHZHZMblJ6T2pJMUNpQWdJQ0F2THlCc1pYUWdkRzkwWVd3Z1BTQlZhVzUwTmpRb01Da0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0J6ZDJGd0NncDBaWE4wWDJadmNsOXNiMjl3WDJOdmJuUnBiblZsWDNkb2FXeGxYM1J2Y0VBeU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJadmNpMXNiMjl3Y3k1aGJHZHZMblJ6T2pJMkNpQWdJQ0F2THlCbWIzSWdLR3hsZENCcElEMGdjM1JoY25RN0lHa2dQQ0J6ZEc5d095QnBJQ3M5SUhOMFpYQXBJSHNLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRFFLSUNBZ0lEd0tJQ0FnSUdKNklIUmxjM1JmWm05eVgyeHZiM0JmWTI5dWRHbHVkV1ZmWVdaMFpYSmZkMmhwYkdWQU53b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJadmNpMXNiMjl3Y3k1aGJHZHZMblJ6T2pJM0NpQWdJQ0F2THlCcFppQW9hU0FsSURVZ1BUMDlJREFwSUdOdmJuUnBiblZsQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ05Rb2dJQ0FnSlFvZ0lDQWdZbm9nZEdWemRGOW1iM0pmYkc5dmNGOWpiMjUwYVc1MVpWOWliRzlqYTBBMkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXeHZiM0J6TG1Gc1oyOHVkSE02TWpnS0lDQWdJQzh2SUhSdmRHRnNJQ3M5SUdrS0lDQWdJR1IxY0RJS0lDQWdJQ3NLSUNBZ0lHSjFjbmtnTWdvS2RHVnpkRjltYjNKZmJHOXZjRjlqYjI1MGFXNTFaVjlpYkc5amEwQTJPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTFzYjI5d2N5NWhiR2R2TG5Sek9qSTJDaUFnSUNBdkx5Qm1iM0lnS0d4bGRDQnBJRDBnYzNSaGNuUTdJR2tnUENCemRHOXdPeUJwSUNzOUlITjBaWEFwSUhzS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURNS0lDQWdJQ3NLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZaUIwWlhOMFgyWnZjbDlzYjI5d1gyTnZiblJwYm5WbFgzZG9hV3hsWDNSdmNFQXlDZ3AwWlhOMFgyWnZjbDlzYjI5d1gyTnZiblJwYm5WbFgyRm1kR1Z5WDNkb2FXeGxRRGM2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZabTl5TFd4dmIzQnpMbUZzWjI4dWRITTZNalFLSUNBZ0lDOHZJSFJsYzNSZlptOXlYMnh2YjNCZlkyOXVkR2x1ZFdVb2MzUmhjblE2SUhWcGJuUTJOQ3dnYzNSdmNEb2dkV2x1ZERZMExDQnpkR1Z3T2lCMWFXNTBOalFwSUhzS0lDQWdJR1JwWnlBeENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlp2Y2kxc2IyOXdjeTVoYkdkdkxuUnpPanBHYjNKTWIyOXdjMEZzWjI4dWRHVnpkRjltYjNKZmJHOXZjRjlzWVdKbGJHeGxaRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25SbGMzUmZabTl5WDJ4dmIzQmZiR0ZpWld4c1pXUTZDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiRzl2Y0hNdVlXeG5ieTUwY3pvek1nb2dJQ0FnTHk4Z2RHVnpkRjltYjNKZmJHOXZjRjlzWVdKbGJHeGxaQ2h6ZEdGeWREb2dkV2x1ZERZMExDQnpkRzl3T2lCMWFXNTBOalFzSUhOMFpYQTZJSFZwYm5RMk5Da2dld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdaSFZ3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0J6ZDJGd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCemQyRndDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMV3h2YjNCekxtRnNaMjh1ZEhNNk16TUtJQ0FnSUM4dklHeGxkQ0IwYjNSaGJDQTlJRlZwYm5RMk5DZ3dLUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhOM1lYQUtDblJsYzNSZlptOXlYMnh2YjNCZmJHRmlaV3hzWldSZmQyaHBiR1ZmZEc5d1FESTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMV3h2YjNCekxtRnNaMjh1ZEhNNk16UUtJQ0FnSUM4dklHOTFkR1Z5T2lCbWIzSWdLR3hsZENCcElEMGdjM1JoY25RN0lHa2dQQ0J6ZEc5d095QnBJQ3M5SUhOMFpYQXBJSHNLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRFFLSUNBZ0lEd0tJQ0FnSUdKNklIUmxjM1JmWm05eVgyeHZiM0JmYkdGaVpXeHNaV1JmWW14dlkydEFNVEFLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmlkWEo1SURZS0NuUmxjM1JmWm05eVgyeHZiM0JmYkdGaVpXeHNaV1JmZDJocGJHVmZkRzl3UURRNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXeHZiM0J6TG1Gc1oyOHVkSE02TXpVS0lDQWdJQzh2SUdadmNpQW9iR1YwSUdvZ1BTQnpkR0Z5ZERzZ2FpQThJSE4wYjNBN0lHb2dLejBnYzNSbGNDa2dld29nSUNBZ1pHbG5JRFVLSUNBZ0lHUnBaeUEwQ2lBZ0lDQThDaUFnSUNCaWVpQjBaWE4wWDJadmNsOXNiMjl3WDJ4aFltVnNiR1ZrWDJGbWRHVnlYM2RvYVd4bFFEZ0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiRzl2Y0hNdVlXeG5ieTUwY3pvek5nb2dJQ0FnTHk4Z2RHOTBZV3dnS3owZ2FTQXJJR29LSUNBZ0lHUjFjRzRnTWdvZ0lDQWdaR2xuSURjS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnS3dvZ0lDQWdaR2xuSURRS0lDQWdJQ3NLSUNBZ0lHSjFjbmtnTkFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlp2Y2kxc2IyOXdjeTVoYkdkdkxuUnpPak00Q2lBZ0lDQXZMeUJwWmlBb2FTQXFJR29nUGlCemRHOXdLU0JpY21WaGF5QnZkWFJsY2dvZ0lDQWdLZ29nSUNBZ1pHbG5JRFFLSUNBZ0lENEtJQ0FnSUdKdWVpQjBaWE4wWDJadmNsOXNiMjl3WDJ4aFltVnNiR1ZrWDJKc2IyTnJRREV3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZabTl5TFd4dmIzQnpMbUZzWjI4dWRITTZNelVLSUNBZ0lDOHZJR1p2Y2lBb2JHVjBJR29nUFNCemRHRnlkRHNnYWlBOElITjBiM0E3SUdvZ0t6MGdjM1JsY0NrZ2V3b2dJQ0FnWkdsbklEVUtJQ0FnSUdScFp5QXpDaUFnSUNBckNpQWdJQ0JpZFhKNUlEWUtJQ0FnSUdJZ2RHVnpkRjltYjNKZmJHOXZjRjlzWVdKbGJHeGxaRjkzYUdsc1pWOTBiM0JBTkFvS2RHVnpkRjltYjNKZmJHOXZjRjlzWVdKbGJHeGxaRjlpYkc5amEwQXhNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW1iM0l0Ykc5dmNITXVZV3huYnk1MGN6b3pNZ29nSUNBZ0x5OGdkR1Z6ZEY5bWIzSmZiRzl2Y0Y5c1lXSmxiR3hsWkNoemRHRnlkRG9nZFdsdWREWTBMQ0J6ZEc5d09pQjFhVzUwTmpRc0lITjBaWEE2SUhWcGJuUTJOQ2tnZXdvZ0lDQWdaR2xuSURFS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NuUmxjM1JmWm05eVgyeHZiM0JmYkdGaVpXeHNaV1JmWVdaMFpYSmZkMmhwYkdWQU9Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiRzl2Y0hNdVlXeG5ieTUwY3pvek5Bb2dJQ0FnTHk4Z2IzVjBaWEk2SUdadmNpQW9iR1YwSUdrZ1BTQnpkR0Z5ZERzZ2FTQThJSE4wYjNBN0lHa2dLejBnYzNSbGNDa2dld29nSUNBZ1pIVndDaUFnSUNCa2FXY2dNd29nSUNBZ0t3b2dJQ0FnWW5WeWVTQXhDaUFnSUNCaUlIUmxjM1JmWm05eVgyeHZiM0JmYkdGaVpXeHNaV1JmZDJocGJHVmZkRzl3UURJSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QURDQUFCSmdFRUZSOThkVEViUVFBck1Sa1VSREVZUklJRUJQaGxUM01FS0g5TUFnUkwxM2VNQkROblhnWTJHZ0NPQkFBSkFFY0FpZ0ROQURFWkZERVlGQkJETmhvQlNSVWlFa1FYTmhvQ1NSVWlFa1FYVERZYUEwa1ZJaEpFRjB3alRFbExCQXhCQUE5S1NVNENDRVVEU3dNSVJRRkMvK3BMQVJZb1RGQ3dKRU0yR2dGSkZTSVNSQmMyR2dKSkZTSVNSQmRNTmhvRFNSVWlFa1FYVENOTVNVc0VERUVBRkVvSVNVVURnUW9OUUFBSlNVc0RDRVVCUXYvbFN3RVdLRXhRc0NSRE5ob0JTUlVpRWtRWE5ob0NTUlVpRWtRWFREWWFBMGtWSWhKRUYwd2pURWxMQkF4QkFCUkpnUVVZUVFBRVNnaEZBa2xMQXdoRkFVTC81VXNCRmloTVVMQWtRNEFBTmhvQlNSVWlFa1FYU1RZYUFra1ZJaEpFRjB3MkdnTkpGU0lTUkJkTUkweEpTd1FNUVFBcVN3UkZCa3NGU3dRTVFRQW5Sd0pMQjBsT0F3aExCQWhGQkF0TEJBMUFBQXBMQlVzRENFVUdRdi9hU3dFV0tFeFFzQ1JEU1VzRENFVUJRdis5IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
