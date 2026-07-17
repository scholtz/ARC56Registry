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

namespace Arc56.Generated.algorandfoundation.puya_ts.DemoContract_52aad3d7
{


    public class DemoContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public DemoContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task Run(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 255, 148, 74 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Run_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 255, 148, 74 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="n"> </param>
        public async Task TestSideEffects(ulong n, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 212, 207, 0 };
            var nAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nAbi.From(n);

            var result = await base.CallApp(new List<object> { abiHandle, nAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestSideEffects_Transactions(ulong n, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 212, 207, 0 };
            var nAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nAbi.From(n);

            return await base.MakeTransactionList(new List<object> { abiHandle, nAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="n"> </param>
        /// <param name="y"> </param>
        public async Task<ulong> TestNonTrivialTerminationOfClause(ulong n, ulong y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 168, 26, 71, 171 };
            var nAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nAbi.From(n);
            var yAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); yAbi.From(y);

            var result = await base.CallApp(new List<object> { abiHandle, nAbi, yAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TestNonTrivialTerminationOfClause_Transactions(ulong n, ulong y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 168, 26, 71, 171 };
            var nAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nAbi.From(n);
            var yAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); yAbi.From(y);

            return await base.MakeTransactionList(new List<object> { abiHandle, nAbi, yAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRGVtb0NvbnRyYWN0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6InJ1biIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0X3NpZGVfZWZmZWN0cyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3Rfbm9uX3RyaXZpYWxfdGVybWluYXRpb25fb2ZfY2xhdXNlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE3MV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgdHdvIGZ1bmN0aW9ucyBzaG91bGQgYmUgZXZhbHVhdGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY4LDE5MF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcwLDgyLDEyOV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBNElEQWdNZ29nSUNBZ1lubDBaV05pYkc5amF5QWlaWFpoYkVOdmRXNTBJZ29nSUNBZ2NIVnphR0o1ZEdWeklDSWlDaUFnSUNCa2RYQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5emQybDBZMmd0YzNSaGRHVnRaVzUwY3k1aGJHZHZMblJ6T2pRS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkVaVzF2UTI5dWRISmhZM1FnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1UQUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VHRTJabVk1TkRSaElEQjRPVGRrTkdObU1EQWdNSGhoT0RGaE5EZGhZaUF2THlCdFpYUm9iMlFnSW5KMWJpZ3BkbTlwWkNJc0lHMWxkR2h2WkNBaWRHVnpkRjl6YVdSbFgyVm1abVZqZEhNb2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJblJsYzNSZmJtOXVYM1J5YVhacFlXeGZkR1Z5YldsdVlYUnBiMjVmYjJaZlkyeGhkWE5sS0hWcGJuUTJOQ3gxYVc1ME5qUXBkV2x1ZERZMElnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5eWRXNWZjbTkxZEdWQU5DQnRZV2x1WDNSbGMzUmZjMmxrWlY5bFptWmxZM1J6WDNKdmRYUmxRRFVnYldGcGJsOTBaWE4wWDI1dmJsOTBjbWwyYVdGc1gzUmxjbTFwYm1GMGFXOXVYMjltWDJOc1lYVnpaVjl5YjNWMFpVQTJDaUFnSUNCbGNuSUtDbTFoYVc1ZmRHVnpkRjl1YjI1ZmRISnBkbWxoYkY5MFpYSnRhVzVoZEdsdmJsOXZabDlqYkdGMWMyVmZjbTkxZEdWQU5qb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5emQybDBZMmd0YzNSaGRHVnRaVzUwY3k1aGJHZHZMblJ6T2pnekNpQWdJQ0F2THlCd2RXSnNhV01nZEdWemRGOXViMjVmZEhKcGRtbGhiRjkwWlhKdGFXNWhkR2x2Ymw5dlpsOWpiR0YxYzJVb2Jqb2dkV2x1ZERZMExDQjVPaUIxYVc1ME5qUXBPaUIxYVc1ME5qUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURNS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUdKMWNua2dNZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzTjNhWFJqYUMxemRHRjBaVzFsYm5SekxtRnNaMjh1ZEhNNk9EVUtJQ0FnSUM4dklHTmhjMlVnTVRvS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzTjNhWFJqYUMxemRHRjBaVzFsYm5SekxtRnNaMjh1ZEhNNk9EVXRPVEFLSUNBZ0lDOHZJR05oYzJVZ01Ub0tJQ0FnSUM4dklDQWdhV1lnS0hrZ0pTQXlJRDA5UFNBd0tTQjdDaUFnSUNBdkx5QWdJQ0FnY21WMGRYSnVJSGtLSUNBZ0lDOHZJQ0FnZlNCbGJITmxJSHNLSUNBZ0lDOHZJQ0FnSUNCeVpYUjFjbTRnYmdvZ0lDQWdMeThnSUNCOUNpQWdJQ0JpZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1UY0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5emQybDBZMmd0YzNSaGRHVnRaVzUwY3k1aGJHZHZMblJ6T2pnMkNpQWdJQ0F2THlCcFppQW9lU0FsSURJZ1BUMDlJREFwSUhzS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDVUtJQ0FnSUdKdWVpQnRZV2x1WDJWc2MyVmZZbTlrZVVBeE5nb2dJQ0FnWkhWd0NncHRZV2x1WDJGbWRHVnlYMmx1YkdsdVpXUmZkR1Z6ZEhNdllYQndjbTkyWVd4ekwzTjNhWFJqYUMxemRHRjBaVzFsYm5SekxtRnNaMjh1ZEhNNk9rUmxiVzlEYjI1MGNtRmpkQzUwWlhOMFgyNXZibDkwY21sMmFXRnNYM1JsY20xcGJtRjBhVzl1WDI5bVgyTnNZWFZ6WlVBeE9Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5emQybDBZMmd0YzNSaGRHVnRaVzUwY3k1aGJHZHZMblJ6T2pnekNpQWdJQ0F2THlCd2RXSnNhV01nZEdWemRGOXViMjVmZEhKcGRtbGhiRjkwWlhKdGFXNWhkR2x2Ymw5dlpsOWpiR0YxYzJVb2Jqb2dkV2x1ZERZMExDQjVPaUIxYVc1ME5qUXBPaUIxYVc1ME5qUWdld29nSUNBZ2FYUnZZZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyVnNjMlZmWW05a2VVQXhOam9LSUNBZ0lHUnBaeUF4Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjM2RwZEdOb0xYTjBZWFJsYldWdWRITXVZV3huYnk1MGN6bzRNd29nSUNBZ0x5OGdjSFZpYkdsaklIUmxjM1JmYm05dVgzUnlhWFpwWVd4ZmRHVnliV2x1WVhScGIyNWZiMlpmWTJ4aGRYTmxLRzQ2SUhWcGJuUTJOQ3dnZVRvZ2RXbHVkRFkwS1RvZ2RXbHVkRFkwSUhzS0lDQWdJR0lnYldGcGJsOWhablJsY2w5cGJteHBibVZrWDNSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl6ZDJsMFkyZ3RjM1JoZEdWdFpXNTBjeTVoYkdkdkxuUnpPanBFWlcxdlEyOXVkSEpoWTNRdWRHVnpkRjl1YjI1ZmRISnBkbWxoYkY5MFpYSnRhVzVoZEdsdmJsOXZabDlqYkdGMWMyVkFNVGdLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE56b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5emQybDBZMmd0YzNSaGRHVnRaVzUwY3k1aGJHZHZMblJ6T2preUNpQWdJQ0F2THlCeVpYUjFjbTRnZVNBcUlHNEtJQ0FnSUdSMWNBb2dJQ0FnWkdsbklESUtJQ0FnSUNvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl6ZDJsMFkyZ3RjM1JoZEdWdFpXNTBjeTVoYkdkdkxuUnpPamd6Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkR1Z6ZEY5dWIyNWZkSEpwZG1saGJGOTBaWEp0YVc1aGRHbHZibDl2Wmw5amJHRjFjMlVvYmpvZ2RXbHVkRFkwTENCNU9pQjFhVzUwTmpRcE9pQjFhVzUwTmpRZ2V3b2dJQ0FnWWlCdFlXbHVYMkZtZEdWeVgybHViR2x1WldSZmRHVnpkSE12WVhCd2NtOTJZV3h6TDNOM2FYUmphQzF6ZEdGMFpXMWxiblJ6TG1Gc1oyOHVkSE02T2tSbGJXOURiMjUwY21GamRDNTBaWE4wWDI1dmJsOTBjbWwyYVdGc1gzUmxjbTFwYm1GMGFXOXVYMjltWDJOc1lYVnpaVUF4T0FvS2JXRnBibDkwWlhOMFgzTnBaR1ZmWldabVpXTjBjMTl5YjNWMFpVQTFPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzTjNhWFJqYUMxemRHRjBaVzFsYm5SekxtRnNaMjh1ZEhNNk5qZ0tJQ0FnSUM4dklIQjFZbXhwWXlCMFpYTjBYM05wWkdWZlpXWm1aV04wY3lodU9pQjFhVzUwTmpRcElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F6Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjM2RwZEdOb0xYTjBZWFJsYldWdWRITXVZV3huYnk1MGN6bzJNUW9nSUNBZ0x5OGdaWFpoYkVOdmRXNTBJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKbGRtRnNRMjkxYm5RaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YzNkcGRHTm9MWE4wWVhSbGJXVnVkSE11WVd4bmJ5NTBjem8yT1FvZ0lDQWdMeThnZEdocGN5NWxkbUZzUTI5MWJuUXVkbUZzZFdVZ1BTQXdDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5emQybDBZMmd0YzNSaGRHVnRaVzUwY3k1aGJHZHZMblJ6T2pjeUNpQWdJQ0F2THlCallYTmxJSFJvYVhNdWFXNWpjbVZoYzJWRmRtRnNRVzVrVW1WMGRYSnVLRzRnTFNBeEtUb0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzBLSUNBZ0lHTmhiR3h6ZFdJZ2FXNWpjbVZoYzJWRmRtRnNRVzVrVW1WMGRYSnVDaUFnSUNBOVBRb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNOM2FYUmphQzF6ZEdGMFpXMWxiblJ6TG1Gc1oyOHVkSE02TnpJdE56TUtJQ0FnSUM4dklHTmhjMlVnZEdocGN5NXBibU55WldGelpVVjJZV3hCYm1SU1pYUjFjbTRvYmlBdElERXBPZ29nSUNBZ0x5OGdJQ0JpY21WaGF3b2dJQ0FnWW01NklHMWhhVzVmWW14dlkydEFNak1LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXpkMmwwWTJndGMzUmhkR1Z0Wlc1MGN5NWhiR2R2TG5Sek9qYzBDaUFnSUNBdkx5QmpZWE5sSUhSb2FYTXVhVzVqY21WaGMyVkZkbUZzUVc1a1VtVjBkWEp1S0c0cE9nb2dJQ0FnWkdsbklERUtJQ0FnSUdSMWNBb2dJQ0FnWTJGc2JITjFZaUJwYm1OeVpXRnpaVVYyWVd4QmJtUlNaWFIxY200S0lDQWdJRDA5Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjM2RwZEdOb0xYTjBZWFJsYldWdWRITXVZV3huYnk1MGN6bzNOQzAzTlFvZ0lDQWdMeThnWTJGelpTQjBhR2x6TG1sdVkzSmxZWE5sUlhaaGJFRnVaRkpsZEhWeWJpaHVLVG9LSUNBZ0lDOHZJQ0FnWW5KbFlXc0tJQ0FnSUdKdWVpQnRZV2x1WDJKc2IyTnJRREl6Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjM2RwZEdOb0xYTjBZWFJsYldWdWRITXVZV3huYnk1MGN6bzNOZ29nSUNBZ0x5OGdZMkZ6WlNCMGFHbHpMbWx1WTNKbFlYTmxSWFpoYkVGdVpGSmxkSFZ5YmlodUlDc2dNU2s2Q2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDc0tJQ0FnSUdOaGJHeHpkV0lnYVc1amNtVmhjMlZGZG1Gc1FXNWtVbVYwZFhKdUNpQWdJQ0J3YjNBS0NtMWhhVzVmWW14dlkydEFNak02Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjM2RwZEdOb0xYTjBZWFJsYldWdWRITXVZV3huYnk1MGN6bzRNQW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WlhaaGJFTnZkVzUwTG5aaGJIVmxJRDA5UFNBeUxDQW5UMjVzZVNCMGQyOGdablZ1WTNScGIyNXpJSE5vYjNWc1pDQmlaU0JsZG1Gc2RXRjBaV1FuS1FvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXpkMmwwWTJndGMzUmhkR1Z0Wlc1MGN5NWhiR2R2TG5Sek9qWXhDaUFnSUNBdkx5QmxkbUZzUTI5MWJuUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1WMllXeERiM1Z1ZENJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl6ZDJsMFkyZ3RjM1JoZEdWdFpXNTBjeTVoYkdkdkxuUnpPamd3Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1bGRtRnNRMjkxYm5RdWRtRnNkV1VnUFQwOUlESXNJQ2RQYm14NUlIUjNieUJtZFc1amRHbHZibk1nYzJodmRXeGtJR0psSUdWMllXeDFZWFJsWkNjcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0IwZDI4Z1puVnVZM1JwYjI1eklITm9iM1ZzWkNCaVpTQmxkbUZzZFdGMFpXUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5emQybDBZMmd0YzNSaGRHVnRaVzUwY3k1aGJHZHZMblJ6T2pZNENpQWdJQ0F2THlCd2RXSnNhV01nZEdWemRGOXphV1JsWDJWbVptVmpkSE1vYmpvZ2RXbHVkRFkwS1NCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNKMWJsOXliM1YwWlVBME9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNOM2FYUmphQzF6ZEdGMFpXMWxiblJ6TG1Gc1oyOHVkSE02TlFvZ0lDQWdMeThnY25WdUtDa2dld29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1UQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmMzZHBkR05vTFhOMFlYUmxiV1Z1ZEhNdVlXeG5ieTUwY3pvMENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdSR1Z0YjBOdmJuUnlZV04wSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjM2RwZEdOb0xYTjBZWFJsYldWdWRITXVZV3huYnk1MGN6bzZSR1Z0YjBOdmJuUnlZV04wTG1sdVkzSmxZWE5sUlhaaGJFRnVaRkpsZEhWeWJpaHVPaUIxYVc1ME5qUXBJQzArSUhWcGJuUTJORG9LYVc1amNtVmhjMlZGZG1Gc1FXNWtVbVYwZFhKdU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNOM2FYUmphQzF6ZEdGMFpXMWxiblJ6TG1Gc1oyOHVkSE02TmpNS0lDQWdJQzh2SUhCeWFYWmhkR1VnYVc1amNtVmhjMlZGZG1Gc1FXNWtVbVYwZFhKdUtHNDZJSFZwYm5RMk5Da2dld29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YzNkcGRHTm9MWE4wWVhSbGJXVnVkSE11WVd4bmJ5NTBjem8yTkFvZ0lDQWdMeThnZEdocGN5NWxkbUZzUTI5MWJuUXVkbUZzZFdVckt3b2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl6ZDJsMFkyZ3RjM1JoZEdWdFpXNTBjeTVoYkdkdkxuUnpPall4Q2lBZ0lDQXZMeUJsZG1Gc1EyOTFiblFnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltVjJZV3hEYjNWdWRDSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5emQybDBZMmd0YzNSaGRHVnRaVzUwY3k1aGJHZHZMblJ6T2pZMENpQWdJQ0F2THlCMGFHbHpMbVYyWVd4RGIzVnVkQzUyWVd4MVpTc3JDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ3NLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXpkMmwwWTJndGMzUmhkR1Z0Wlc1MGN5NWhiR2R2TG5Sek9qWXhDaUFnSUNBdkx5QmxkbUZzUTI5MWJuUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1WMllXeERiM1Z1ZENJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl6ZDJsMFkyZ3RjM1JoZEdWdFpXNTBjeTVoYkdkdkxuUnpPalkwQ2lBZ0lDQXZMeUIwYUdsekxtVjJZV3hEYjNWdWRDNTJZV3gxWlNzckNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNOM2FYUmphQzF6ZEdGMFpXMWxiblJ6TG1Gc1oyOHVkSE02TmpVS0lDQWdJQzh2SUhKbGRIVnliaUJ1Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lISmxkSE4xWWdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBUWdBQWlZQkNXVjJZV3hEYjNWdWRJQUFTVEViUVFDVk1Sa1VSREVZUklJREJLYi9sRW9FbDlUUEFBU29Ha2VyTmhvQWpnTUFjQUE4QUFFQU5ob0JTUlVqRWtRWFNVVUROaG9DU1JVakVrUVhSUUlpRWtFQUdFa2xHRUFBRFVrV2dBUVZIM3gxVEZDd0lrTkxBVUwvNzBsTEFndEMvK2cyR2dGSkZTTVNSQmRKUlFNb0pHZEpJZ21JQUNrU1FBQVNTd0ZKaUFBZkVrQUFDRXNCSWdpSUFCUklKQ2hsUkNVU1JDSkRJa014R1JReEdCUVFRNG9CQVNRb1pVUWlDQ2hNWjR2L2lRPT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
