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

namespace Arc56.Generated.codewithyuvi.VAttend_Blockchain.AttendenceTracker_030235b2
{


    public class AttendenceTrackerProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AttendenceTrackerProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        /// <param name="end"> </param>
        public async Task CreateEvent(ulong start, ulong end, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 11, 53, 9, 158 };
            var startAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); startAbi.From(start);
            var endAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); endAbi.From(end);

            var result = await base.CallApp(new List<object> { abiHandle, startAbi, endAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateEvent_Transactions(ulong start, ulong end, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 11, 53, 9, 158 };
            var startAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); startAbi.From(start);
            var endAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); endAbi.From(end);

            return await base.MakeTransactionList(new List<object> { abiHandle, startAbi, endAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task CloseEvent(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 238, 227, 236 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CloseEvent_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 238, 227, 236 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="hash"> </param>
        public async Task CheckIn(byte[] hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 47, 171, 76, 6 };
            var hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); hashAbi.From(hash);

            var result = await base.CallApp(new List<object> { abiHandle, hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CheckIn_Transactions(byte[] hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 47, 171, 76, 6 };
            var hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); hashAbi.From(hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXR0ZW5kZW5jZVRyYWNrZXIiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlX2V2ZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0YXJ0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlbmQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2xvc2VfZXZlbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2hlY2tfaW4iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6NCwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjoxLCJieXRlcyI6MX19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzkzXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzM10sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AgJiYgY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTcxLDE5NiwyMjQsMjMzLDI0MiwyODFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQzLDE1Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElEZ0tJQ0FnSUdKNWRHVmpZbXh2WTJzZ0ltbHVjM1J5ZFdOMGIzSWlJQ0poZEhSbGJtUmhibU5sWDJOdmRXNTBJaUFpWlhabGJuUmZZV04wYVhabElpQWljM1JoY25SZmRHbHRaU0lnSW1WdVpGOTBhVzFsSWlBaVlYUjBaVzVrWVc1alpWOW9ZWE5vSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkYwZEdWdVpHVnVZMlZmZEhKaFkydGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1FYUjBaVzVrWlc1alpWUnlZV05yWlhJZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVkFNVEFLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYlhWemRDQmlaU0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0TUdJek5UQTVPV1VnTUhnNE9XVmxaVE5sWXlBd2VESm1ZV0kwWXpBMklDOHZJRzFsZEdodlpDQWlZM0psWVhSbFgyVjJaVzUwS0hWcGJuUTJOQ3gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaVkyeHZjMlZmWlhabGJuUW9LWFp2YVdRaUxDQnRaWFJvYjJRZ0ltTm9aV05yWDJsdUtHSjVkR1ZiWFNsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWTNKbFlYUmxYMlYyWlc1MElHTnNiM05sWDJWMlpXNTBJR05vWldOclgybHVDaUFnSUNCbGNuSUtDbTFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURFd09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGMGRHVnVaR1Z1WTJWZmRISmhZMnRsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeUNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRWFIwWlc1a1pXNWpaVlJ5WVdOclpYSWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdiWFZ6ZENCaVpTQk9iMDl3SUNZbUlHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQmpjbVZoZEdsdVp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloZEhSbGJtUmxibU5sWDNSeVlXTnJaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UVhSMFpXNWtaVzVqWlZSeVlXTnJaWEl1WTNKbFlYUmxYMlYyWlc1MFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZM0psWVhSbFgyVjJaVzUwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkYwZEdWdVpHVnVZMlZmZEhKaFkydGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkyQ2lBZ0lDQXZMeUJqY21WaGRHVmZaWFpsYm5Rb2MzUmhjblE2SUhWcGJuUTJOQ3dnWlc1a09pQjFhVzUwTmpRcE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhkSFJsYm1SbGJtTmxYM1J5WVdOclpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPQW9nSUNBZ0x5OGdhV1lnS0NGMGFHbHpMbWx1YzNSeWRXTjBiM0l1YUdGelZtRnNkV1VwSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWFIwWlc1a1pXNWpaVjkwY21GamEyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFVLSUNBZ0lDOHZJR2x1YzNSeWRXTjBiM0lnUFNCSGJHOWlZV3hUZEdGMFpUeEJZMk52ZFc1MFBpaDdJR3RsZVRvZ0oybHVjM1J5ZFdOMGIzSW5JSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pwYm5OMGNuVmpkRzl5SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkYwZEdWdVpHVnVZMlZmZEhKaFkydGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakk0Q2lBZ0lDQXZMeUJwWmlBb0lYUm9hWE11YVc1emRISjFZM1J2Y2k1b1lYTldZV3gxWlNrZ2V3b2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbTU2SUdOeVpXRjBaVjlsZG1WdWRGOWhablJsY2w5cFpsOWxiSE5sUURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloZEhSbGJtUmxibU5sWDNSeVlXTnJaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlFvZ0lDQWdMeThnYVc1emRISjFZM1J2Y2lBOUlFZHNiMkpoYkZOMFlYUmxQRUZqWTI5MWJuUStLSHNnYTJWNU9pQW5hVzV6ZEhKMVkzUnZjaWNnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1sdWMzUnlkV04wYjNJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhSMFpXNWtaVzVqWlY5MGNtRmphMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWprS0lDQWdJQzh2SUhSb2FYTXVhVzV6ZEhKMVkzUnZjaTUyWVd4MVpTQTlJRlI0Ymk1elpXNWtaWElLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDZ3BqY21WaGRHVmZaWFpsYm5SZllXWjBaWEpmYVdaZlpXeHpaVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkYwZEdWdVpHVnVZMlZmZEhKaFkydGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak15Q2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ2RHaHBjeTVwYm5OMGNuVmpkRzl5TG5aaGJIVmxLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloZEhSbGJtUmxibU5sWDNSeVlXTnJaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlFvZ0lDQWdMeThnYVc1emRISjFZM1J2Y2lBOUlFZHNiMkpoYkZOMFlYUmxQRUZqWTI5MWJuUStLSHNnYTJWNU9pQW5hVzV6ZEhKMVkzUnZjaWNnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1sdWMzUnlkV04wYjNJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhSMFpXNWtaVzVqWlY5MGNtRmphMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpJS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQjBhR2x6TG1sdWMzUnlkV04wYjNJdWRtRnNkV1VwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRjBkR1Z1WkdWdVkyVmZkSEpoWTJ0bGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJDaUFnSUNBdkx5QnpkR0Z5ZEZScGJXVWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFuYzNSaGNuUmZkR2x0WlNjZ2ZTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0luTjBZWEowWDNScGJXVWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYUjBaVzVrWlc1alpWOTBjbUZqYTJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16UUtJQ0FnSUM4dklIUm9hWE11YzNSaGNuUlVhVzFsTG5aaGJIVmxJRDBnYzNSaGNuUUtJQ0FnSUdScFp5QXlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRjBkR1Z1WkdWdVkyVmZkSEpoWTJ0bGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTNDaUFnSUNBdkx5QmxibVJVYVcxbElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUd0bGVUb2dKMlZ1WkY5MGFXMWxKeUI5S1FvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWlc1a1gzUnBiV1VpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWFIwWlc1a1pXNWpaVjkwY21GamEyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNelVLSUNBZ0lDOHZJSFJvYVhNdVpXNWtWR2x0WlM1MllXeDFaU0E5SUdWdVpBb2dJQ0FnWkdsbklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYUjBaVzVrWlc1alpWOTBjbUZqYTJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UZ0tJQ0FnSUM4dklHRjBkR1Z1WkdGdVkyVkRiM1Z1ZENBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJyWlhrNklDZGhkSFJsYm1SaGJtTmxYMk52ZFc1MEp5QjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZWFIwWlc1a1lXNWpaVjlqYjNWdWRDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGRIUmxibVJsYm1ObFgzUnlZV05yWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek53b2dJQ0FnTHk4Z2RHaHBjeTVoZEhSbGJtUmhibU5sUTI5MWJuUXVkbUZzZFdVZ1BTQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGRIUmxibVJsYm1ObFgzUnlZV05yWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9Rb2dJQ0FnTHk4Z1pYWmxiblJCWTNScGRtVWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFuWlhabGJuUmZZV04wYVhabEp5QjlLU0F2THlBeElEMGdiM0JsYml3Z01DQTlJR05zYjNObFpBb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVpYWmxiblJmWVdOMGFYWmxJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRjBkR1Z1WkdWdVkyVmZkSEpoWTJ0bGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTRDaUFnSUNBdkx5QjBhR2x6TG1WMlpXNTBRV04wYVhabExuWmhiSFZsSUQwZ01Rb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhSMFpXNWtaVzVqWlY5MGNtRmphMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpZS0lDQWdJQzh2SUdOeVpXRjBaVjlsZG1WdWRDaHpkR0Z5ZERvZ2RXbHVkRFkwTENCbGJtUTZJSFZwYm5RMk5DazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloZEhSbGJtUmxibU5sWDNSeVlXTnJaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UVhSMFpXNWtaVzVqWlZSeVlXTnJaWEl1WTJ4dmMyVmZaWFpsYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpiRzl6WlY5bGRtVnVkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhkSFJsYm1SbGJtTmxYM1J5WVdOclpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBNd29nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdQVDA5SUhSb2FYTXVhVzV6ZEhKMVkzUnZjaTUyWVd4MVpTa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWFIwWlc1a1pXNWpaVjkwY21GamEyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFVLSUNBZ0lDOHZJR2x1YzNSeWRXTjBiM0lnUFNCSGJHOWlZV3hUZEdGMFpUeEJZMk52ZFc1MFBpaDdJR3RsZVRvZ0oybHVjM1J5ZFdOMGIzSW5JSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pwYm5OMGNuVmpkRzl5SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkYwZEdWdVpHVnVZMlZmZEhKaFkydGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalF6Q2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ2RHaHBjeTVwYm5OMGNuVmpkRzl5TG5aaGJIVmxLUW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGRIUmxibVJsYm1ObFgzUnlZV05yWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9Rb2dJQ0FnTHk4Z1pYWmxiblJCWTNScGRtVWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFuWlhabGJuUmZZV04wYVhabEp5QjlLU0F2THlBeElEMGdiM0JsYml3Z01DQTlJR05zYjNObFpBb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVpYWmxiblJmWVdOMGFYWmxJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRjBkR1Z1WkdWdVkyVmZkSEpoWTJ0bGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTBDaUFnSUNBdkx5QjBhR2x6TG1WMlpXNTBRV04wYVhabExuWmhiSFZsSUQwZ01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhSMFpXNWtaVzVqWlY5MGNtRmphMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRJS0lDQWdJQzh2SUdOc2IzTmxYMlYyWlc1MEtDazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloZEhSbGJtUmxibU5sWDNSeVlXTnJaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UVhSMFpXNWtaVzVqWlZSeVlXTnJaWEl1WTJobFkydGZhVzViY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamFHVmphMTlwYmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloZEhSbGJtUmxibU5sWDNSeVlXTnJaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wT0FvZ0lDQWdMeThnWTJobFkydGZhVzRvYUdGemFEb2dZbmwwWlhNcE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWFIwWlc1a1pXNWpaVjkwY21GamEyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVEVLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1WMlpXNTBRV04wYVhabExuWmhiSFZsSUQwOVBTQXhLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGRIUmxibVJsYm1ObFgzUnlZV05yWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9Rb2dJQ0FnTHk4Z1pYWmxiblJCWTNScGRtVWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFuWlhabGJuUmZZV04wYVhabEp5QjlLU0F2THlBeElEMGdiM0JsYml3Z01DQTlJR05zYjNObFpBb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVpYWmxiblJmWVdOMGFYWmxJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRjBkR1Z1WkdWdVkyVmZkSEpoWTJ0bGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVXhDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVsZG1WdWRFRmpkR2wyWlM1MllXeDFaU0E5UFQwZ01Ta0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkYwZEdWdVpHVnVZMlZmZEhKaFkydGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV6Q2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG1acGNuTjBWbUZzYVdRZ1BqMGdkR2hwY3k1emRHRnlkRlJwYldVdWRtRnNkV1VwQ2lBZ0lDQjBlRzRnUm1seWMzUldZV3hwWkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhkSFJsYm1SbGJtTmxYM1J5WVdOclpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOZ29nSUNBZ0x5OGdjM1JoY25SVWFXMWxJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHdGxlVG9nSjNOMFlYSjBYM1JwYldVbklIMHBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSnpkR0Z5ZEY5MGFXMWxJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRjBkR1Z1WkdWdVkyVmZkSEpoWTJ0bGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVXpDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbVpwY25OMFZtRnNhV1FnUGowZ2RHaHBjeTV6ZEdGeWRGUnBiV1V1ZG1Gc2RXVXBDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnUGowS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGMGRHVnVaR1Z1WTJWZmRISmhZMnRsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVMENpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxtWnBjbk4wVm1Gc2FXUWdQRDBnZEdocGN5NWxibVJVYVcxbExuWmhiSFZsS1FvZ0lDQWdkSGh1SUVacGNuTjBWbUZzYVdRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWFIwWlc1a1pXNWpaVjkwY21GamEyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGNLSUNBZ0lDOHZJR1Z1WkZScGJXVWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFuWlc1a1gzUnBiV1VuSUgwcENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKbGJtUmZkR2x0WlNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloZEhSbGJtUmxibU5sWDNSeVlXTnJaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTkFvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1bWFYSnpkRlpoYkdsa0lEdzlJSFJvYVhNdVpXNWtWR2x0WlM1MllXeDFaU2tLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYUjBaVzVrWlc1alpWOTBjbUZqYTJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UWUtJQ0FnSUM4dklHRnpjMlZ5ZENnaGRHaHBjeTVoZEhSbGJtUmhibU5sU0dGemFDaFVlRzR1YzJWdVpHVnlLUzVvWVhOV1lXeDFaU2tLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhSMFpXNWtaVzVqWlY5MGNtRmphMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpJS0lDQWdJQzh2SUdGMGRHVnVaR0Z1WTJWSVlYTm9JRDBnVEc5allXeFRkR0YwWlR4aWVYUmxjejRvZXlCclpYazZJQ2RoZEhSbGJtUmhibU5sWDJoaGMyZ25JSDBwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0poZEhSbGJtUmhibU5sWDJoaGMyZ2lDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYUjBaVzVrWlc1alpWOTBjbUZqYTJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UWUtJQ0FnSUM4dklHRnpjMlZ5ZENnaGRHaHBjeTVoZEhSbGJtUmhibU5sU0dGemFDaFVlRzR1YzJWdVpHVnlLUzVvWVhOV1lXeDFaU2tLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR0oxY25rZ01Rb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhSMFpXNWtaVzVqWlY5MGNtRmphMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRnS0lDQWdJQzh2SUhSb2FYTXVZWFIwWlc1a1lXNWpaVWhoYzJnb1ZIaHVMbk5sYm1SbGNpa3VkbUZzZFdVZ1BTQm9ZWE5vQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYUjBaVzVrWlc1alpWOTBjbUZqYTJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qSUtJQ0FnSUM4dklHRjBkR1Z1WkdGdVkyVklZWE5vSUQwZ1RHOWpZV3hUZEdGMFpUeGllWFJsY3o0b2V5QnJaWGs2SUNkaGRIUmxibVJoYm1ObFgyaGhjMmduSUgwcENpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKaGRIUmxibVJoYm1ObFgyaGhjMmdpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWFIwWlc1a1pXNWpaVjkwY21GamEyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVGdLSUNBZ0lDOHZJSFJvYVhNdVlYUjBaVzVrWVc1alpVaGhjMmdvVkhodUxuTmxibVJsY2lrdWRtRnNkV1VnUFNCb1lYTm9DaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloZEhSbGJtUmxibU5sWDNSeVlXTnJaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xT1FvZ0lDQWdMeThnZEdocGN5NWphR1ZqYTJsdVZHbHRaWE4wWVcxd0tGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbElEMGdWSGh1TG1acGNuTjBWbUZzYVdRS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhkSFJsYm1SbGJtTmxYM1J5WVdOclpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNd29nSUNBZ0x5OGdZMmhsWTJ0cGJsUnBiV1Z6ZEdGdGNDQTlJRXh2WTJGc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUd0bGVUb2dKM1JwYldWemRHRnRjQ2NnZlNrS0lDQWdJSEIxYzJoaWVYUmxjeUFpZEdsdFpYTjBZVzF3SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkYwZEdWdVpHVnVZMlZmZEhKaFkydGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalU1Q2lBZ0lDQXZMeUIwYUdsekxtTm9aV05yYVc1VWFXMWxjM1JoYlhBb1ZIaHVMbk5sYm1SbGNpa3VkbUZzZFdVZ1BTQlVlRzR1Wm1seWMzUldZV3hwWkFvZ0lDQWdkSGh1SUVacGNuTjBWbUZzYVdRS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloZEhSbGJtUmxibU5sWDNSeVlXTnJaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTVFvZ0lDQWdMeThnZEdocGN5NWhkSFJsYm1SaGJtTmxRMjkxYm5RdWRtRnNkV1VnUFNCMGFHbHpMbUYwZEdWdVpHRnVZMlZEYjNWdWRDNTJZV3gxWlNBcklERUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhSMFpXNWtaVzVqWlY5MGNtRmphMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRnS0lDQWdJQzh2SUdGMGRHVnVaR0Z1WTJWRGIzVnVkQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkaGRIUmxibVJoYm1ObFgyTnZkVzUwSnlCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVlYUjBaVzVrWVc1alpWOWpiM1Z1ZENJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloZEhSbGJtUmxibU5sWDNSeVlXTnJaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTVFvZ0lDQWdMeThnZEdocGN5NWhkSFJsYm1SaGJtTmxRMjkxYm5RdWRtRnNkV1VnUFNCMGFHbHpMbUYwZEdWdVpHRnVZMlZEYjNWdWRDNTJZV3gxWlNBcklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRjBkR1Z1WkdWdVkyVmZkSEpoWTJ0bGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTRDaUFnSUNBdkx5QmhkSFJsYm1SaGJtTmxRMjkxYm5RZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQW5ZWFIwWlc1a1lXNWpaVjlqYjNWdWRDY2dmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUYwZEdWdVpHRnVZMlZmWTI5MWJuUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYUjBaVzVrWlc1alpWOTBjbUZqYTJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qRUtJQ0FnSUM4dklIUm9hWE11WVhSMFpXNWtZVzVqWlVOdmRXNTBMblpoYkhWbElEMGdkR2hwY3k1aGRIUmxibVJoYm1ObFEyOTFiblF1ZG1Gc2RXVWdLeUF4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkYwZEdWdVpHVnVZMlZmZEhKaFkydGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalE0Q2lBZ0lDQXZMeUJqYUdWamExOXBiaWhvWVhOb09pQmllWFJsY3lrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBREFBRUlKZ1lLYVc1emRISjFZM1J2Y2hCaGRIUmxibVJoYm1ObFgyTnZkVzUwREdWMlpXNTBYMkZqZEdsMlpRcHpkR0Z5ZEY5MGFXMWxDR1Z1WkY5MGFXMWxEMkYwZEdWdVpHRnVZMlZmYUdGemFERWJRUUFrTVJrVVJERVlSSUlEQkFzMUNaNEVpZTdqN0FRdnEwd0dOaG9BamdNQUN3QkNBRThBTVJrVU1SZ1VFRVFqUXpZYUFVa1ZKQkpFRnpZYUFra1ZKQkpFRnlJb1pVVUJRQUFFS0RFQVp6RUFJaWhsUkJKRUswc0NaeWNFU3dGbktTSm5LaU5uSTBNeEFDSW9aVVFTUkNvaVp5TkROaG9CU1NKWmdRSUlTd0VWRWtSWEFnQWlLbVZFSXhKRU1RSWlLMlZFRDBReEFpSW5CR1ZFRGtReEFDSW5CV05GQVJSRU1RQW5CVThDWmpFQWdBbDBhVzFsYzNSaGJYQXhBbVlpS1dWRUl3Z3BUR2NqUXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjMsInBhdGNoIjoyLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
