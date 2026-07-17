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

namespace Arc56.Generated.gabrielkuettel.security_best_practice_guide.SafeClearContract_ff2feabb
{


    public class SafeClearContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SafeClearContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task OptInToApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 163, 163, 255 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptInToApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 163, 163, 255 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="amount"> </param>
        public async Task SetBalance(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 205, 120, 168 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetBalance_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 205, 120, 168 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetBalance(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 43, 105, 164, 23 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetBalance_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 43, 105, 164, 23 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetForfeited(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 150, 172, 86, 76 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetForfeited_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 150, 172, 86, 76 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU2FmZUNsZWFyQ29udHJhY3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3B0SW5Ub0FwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiT3B0SW4iXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRCYWxhbmNlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRCYWxhbmNlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0Rm9yZmVpdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls0Ml0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDNdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBPcHRJbiAmJiBjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgTG9jYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjhdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyM10sImVycm9yTWVzc2FnZSI6ImNoZWNrIExvY2FsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0NpQWdJQ0JpZVhSbFkySnNiMk5ySUNKaVlXd2lJQ0ptYjNKbVpXbDBaV1FpSURCNE1UVXhaamRqTnpVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGMFpWOXRZVzVoWjJWdFpXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOUW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZOaFptVkRiR1ZoY2tOdmJuUnlZV04wSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURGaE0yRXpabVlnTHk4Z2JXVjBhRzlrSUNKdmNIUkpibFJ2UVhCd2JHbGpZWFJwYjI0b0tYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMjl3ZEVsdVZHOUJjSEJzYVdOaGRHbHZibDl5YjNWMFpVQXlDZ3B0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRjBaVjl0WVc1aFoyVnRaVzUwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGTmhabVZEYkdWaGNrTnZiblJ5WVdOMElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnRkWE4wSUdKbElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZWlCdFlXbHVYMk55WldGMFpWOU9iMDl3UURrS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhoaU1XTmtOemhoT0NBd2VESmlOamxoTkRFM0lEQjRPVFpoWXpVMk5HTWdMeThnYldWMGFHOWtJQ0p6WlhSQ1lXeGhibU5sS0hWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSm5aWFJDWVd4aGJtTmxLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbWRsZEVadmNtWmxhWFJsWkNncGRXbHVkRFkwSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2MyVjBRbUZzWVc1alpTQm5aWFJDWVd4aGJtTmxJR2RsZEVadmNtWmxhWFJsWkFvZ0lDQWdaWEp5Q2dwdFlXbHVYMk55WldGMFpWOU9iMDl3UURrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVmZiV0Z1WVdkbGJXVnVkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalVLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCVFlXWmxRMnhsWVhKRGIyNTBjbUZqZENCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdJNE5EUTNZak0ySUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsUVhCd2JHbGpZWFJwYjI0b0tYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMk55WldGMFpVRndjR3hwWTJGMGFXOXVYM0p2ZFhSbFFERXdDaUFnSUNCbGNuSUtDbTFoYVc1ZlkzSmxZWFJsUVhCd2JHbGpZWFJwYjI1ZmNtOTFkR1ZBTVRBNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVmZiV0Z1WVdkbGJXVnVkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamNLSUNBZ0lDOHZJR1p2Y21abGFYUmxaRVoxYm1SeklEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUd0bGVUb2dKMlp2Y21abGFYUmxaQ2NnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1admNtWmxhWFJsWkNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGMFpWOXRZVzVoWjJWdFpXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEFLSUNBZ0lDOHZJSFJvYVhNdVptOXlabVZwZEdWa1JuVnVaSE11ZG1Gc2RXVWdQU0F3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0YwWlY5dFlXNWhaMlZ0Wlc1MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9Rb2dJQ0FnTHk4Z2NIVmliR2xqSUdOeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1S0NrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl2Y0hSSmJsUnZRWEJ3YkdsallYUnBiMjVmY205MWRHVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0YwWlY5dFlXNWhaMlZ0Wlc1MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UTUtJQ0FnSUM4dklIQjFZbXhwWXlCdmNIUkpibFJ2UVhCd2JHbGpZWFJwYjI0b0tUb2dkbTlwWkNCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z1QzQjBTVzRLSUNBZ0lEMDlDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdKaVlLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYlhWemRDQmlaU0JQY0hSSmJpQW1KaUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JpSUc5d2RFbHVWRzlCY0hCc2FXTmhkR2x2YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0YwWlY5dFlXNWhaMlZ0Wlc1MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sTmhabVZEYkdWaGNrTnZiblJ5WVdOMExtOXdkRWx1Vkc5QmNIQnNhV05oZEdsdmJsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbTl3ZEVsdVZHOUJjSEJzYVdOaGRHbHZiam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0YwWlY5dFlXNWhaMlZ0Wlc1MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUUtJQ0FnSUM4dklIUm9hWE11ZFhObGNrSmhiR0Z1WTJVb1ZIaHVMbk5sYm1SbGNpa3VkbUZzZFdVZ1BTQXdDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVmZiV0Z1WVdkbGJXVnVkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPallLSUNBZ0lDOHZJSFZ6WlhKQ1lXeGhibU5sSUQwZ1RHOWpZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhMlY1T2lBblltRnNKeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW1Gc0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlYUmxYMjFoYm1GblpXMWxiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkFvZ0lDQWdMeThnZEdocGN5NTFjMlZ5UW1Gc1lXNWpaU2hVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU0E5SURBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoZEdWZmJXRnVZV2RsYldWdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpDaUFnSUNBdkx5QndkV0pzYVdNZ2IzQjBTVzVVYjBGd2NHeHBZMkYwYVc5dUtDazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGMFpWOXRZVzVoWjJWdFpXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbE5oWm1WRGJHVmhja052Ym5SeVlXTjBMbk5sZEVKaGJHRnVZMlZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwelpYUkNZV3hoYm1ObE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlYUmxYMjFoYm1GblpXMWxiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TndvZ0lDQWdMeThnY0hWaWJHbGpJSE5sZEVKaGJHRnVZMlVvWVcxdmRXNTBPaUIxYVc1ME5qUXBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGdnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGMFpWOXRZVzVoWjJWdFpXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGdLSUNBZ0lDOHZJSFJvYVhNdWRYTmxja0poYkdGdVkyVW9WSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVWdQU0JoYlc5MWJuUUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGMFpWOXRZVzVoWjJWdFpXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOZ29nSUNBZ0x5OGdkWE5sY2tKaGJHRnVZMlVnUFNCTWIyTmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkaVlXd25JSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppWVd3aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVmZiV0Z1WVdkbGJXVnVkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU0Q2lBZ0lDQXZMeUIwYUdsekxuVnpaWEpDWVd4aGJtTmxLRlI0Ymk1elpXNWtaWElwTG5aaGJIVmxJRDBnWVcxdmRXNTBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGMFpWOXRZVzVoWjJWdFpXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGNLSUNBZ0lDOHZJSEIxWW14cFl5QnpaWFJDWVd4aGJtTmxLR0Z0YjNWdWREb2dkV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVhSbFgyMWhibUZuWlcxbGJuUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVMkZtWlVOc1pXRnlRMjl1ZEhKaFkzUXVaMlYwUW1Gc1lXNWpaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRFSmhiR0Z1WTJVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVmZiV0Z1WVdkbGJXVnVkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1MWMyVnlRbUZzWVc1alpTaFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0YwWlY5dFlXNWhaMlZ0Wlc1MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5nb2dJQ0FnTHk4Z2RYTmxja0poYkdGdVkyVWdQU0JNYjJOaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ2RpWVd3bklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmlZV3dpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoZEdWZmJXRnVZV2RsYldWdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXlDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTUxYzJWeVFtRnNZVzVqWlNoVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlFvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRXh2WTJGc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhkR1ZmYldGdVlXZGxiV1Z1ZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJeENpQWdJQ0F2THlCd2RXSnNhV01nWjJWMFFtRnNZVzVqWlNncE9pQjFhVzUwTmpRZ2V3b2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGMFpWOXRZVzVoWjJWdFpXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbE5oWm1WRGJHVmhja052Ym5SeVlXTjBMbWRsZEVadmNtWmxhWFJsWkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRVp2Y21abGFYUmxaRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0YwWlY5dFlXNWhaMlZ0Wlc1MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qWUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbVp2Y21abGFYUmxaRVoxYm1SekxuWmhiSFZsQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZWFJsWDIxaGJtRm5aVzFsYm5RdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM0NpQWdJQ0F2THlCbWIzSm1aV2wwWldSR2RXNWtjeUE5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkbWIzSm1aV2wwWldRbklIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSm1iM0ptWldsMFpXUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhkR1ZmYldGdVlXZGxiV1Z1ZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJMkNpQWdJQ0F2THlCeVpYUjFjbTRnZEdocGN5NW1iM0ptWldsMFpXUkdkVzVrY3k1MllXeDFaUW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRjBaVjl0WVc1aFoyVnRaVzUwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpVS0lDQWdJQzh2SUhCMVlteHBZeUJuWlhSR2IzSm1aV2wwWldRb0tUb2dkV2x1ZERZMElIc0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhkR1ZmYldGdVlXZGxiV1Z1ZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwVFlXWmxRMnhsWVhKRGIyNTBjbUZqZEM1amJHVmhjbE4wWVhSbFVISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR0o1ZEdWallteHZZMnNnSW1admNtWmxhWFJsWkNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGMFpWOXRZVzVoWjJWdFpXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNekFLSUNBZ0lDOHZJR052Ym5OMElHSmhiR0Z1WTJVNklIVnBiblEyTkNBOUlIUm9hWE11ZFhObGNrSmhiR0Z1WTJVb1ZIaHVMbk5sYm1SbGNpa3VkbUZzZFdVS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lIQjFjMmhwYm5RZ01DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoZEdWZmJXRnVZV2RsYldWdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWUtJQ0FnSUM4dklIVnpaWEpDWVd4aGJtTmxJRDBnVEc5allXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFuWW1Gc0p5QjlLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSmlZV3dpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoZEdWZmJXRnVZV2RsYldWdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXdDaUFnSUNBdkx5QmpiMjV6ZENCaVlXeGhibU5sT2lCMWFXNTBOalFnUFNCMGFHbHpMblZ6WlhKQ1lXeGhibU5sS0ZSNGJpNXpaVzVrWlhJcExuWmhiSFZsQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dURzlqWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRjBaVjl0WVc1aFoyVnRaVzUwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpFS0lDQWdJQzh2SUhSb2FYTXVabTl5Wm1WcGRHVmtSblZ1WkhNdWRtRnNkV1VnUFNCMGFHbHpMbVp2Y21abGFYUmxaRVoxYm1SekxuWmhiSFZsSUNzZ1ltRnNZVzVqWlFvZ0lDQWdjSFZ6YUdsdWRDQXdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGMFpWOXRZVzVoWjJWdFpXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOd29nSUNBZ0x5OGdabTl5Wm1WcGRHVmtSblZ1WkhNZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQW5abTl5Wm1WcGRHVmtKeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWm05eVptVnBkR1ZrSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVhSbFgyMWhibUZuWlcxbGJuUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNUW9nSUNBZ0x5OGdkR2hwY3k1bWIzSm1aV2wwWldSR2RXNWtjeTUyWVd4MVpTQTlJSFJvYVhNdVptOXlabVZwZEdWa1JuVnVaSE11ZG1Gc2RXVWdLeUJpWVd4aGJtTmxDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnS3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVhSbFgyMWhibUZuWlcxbGJuUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNDaUFnSUNBdkx5Qm1iM0ptWldsMFpXUkdkVzVrY3lBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJyWlhrNklDZG1iM0ptWldsMFpXUW5JSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ptYjNKbVpXbDBaV1FpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoZEdWZmJXRnVZV2RsYldWdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXhDaUFnSUNBdkx5QjBhR2x6TG1admNtWmxhWFJsWkVaMWJtUnpMblpoYkhWbElEMGdkR2hwY3k1bWIzSm1aV2wwWldSR2RXNWtjeTUyWVd4MVpTQXJJR0poYkdGdVkyVUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhkR1ZmYldGdVlXZGxiV1Z1ZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNeUNpQWdJQ0F2THlCeVpYUjFjbTRnZEhKMVpRb2dJQ0FnY0hWemFHbHVkQ0F4SUM4dklERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBQ0FRQW1Bd05pWVd3SlptOXlabVZwZEdWa0JCVWZmSFdBQkFHam8vODJHZ0NPQVFBNU1Sa1VSREVZUVFBZGdnTUVzYzE0cUFRcmFhUVhCSmFzVmt3MkdnQ09Bd0FtQURnQVJRQ0FCTGhFZXpZMkdnQ09BUUFCQUNralp5SkRNUmtpRWpFWUVFUkNBQUF4QUNnalppSkROaG9CU1JXQkNCSkVGekVBS0U4Q1ppSkRNUUFqS0dORUZpcE1VTEFpUXlNcFpVUVdLa3hRc0NKRCIsImNsZWFyIjoiQ3lZQkNXWnZjbVpsYVhSbFpERUFnUUNBQTJKaGJHTkVnUUFvWlVRSUtFeG5nUUZEIn0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjozLCJwYXRjaCI6MiwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
