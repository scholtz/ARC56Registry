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

namespace Arc56.Generated.SimonYuvarlak.Algorand_Course.VestingVault_1020df8b
{


    //
    // And here’s our main contract class.
    //
    //If you remember the Python example from earlier, this should feel familiar:
    //we’ve got a clean class, a couple of fields, a setup function, and a claim function.
    //
    //The idea of this contract is simple:
    //we define a vesting schedule up front…
    //and then later, the user calls `claim()` to withdraw any unlocked but unclaimed tokens.
    //
    public class VestingVaultProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public VestingVaultProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="startTime"> </param>
        /// <param name="amountPerStage"> </param>
        public async Task SetupSchedule(ulong startTime, ulong amountPerStage, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 209, 102, 20, 131 };
            var startTimeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); startTimeAbi.From(startTime);
            var amountPerStageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountPerStageAbi.From(amountPerStage);

            var result = await base.CallApp(new List<object> { abiHandle, startTimeAbi, amountPerStageAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetupSchedule_Transactions(ulong startTime, ulong amountPerStage, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 209, 102, 20, 131 };
            var startTimeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); startTimeAbi.From(startTime);
            var amountPerStageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountPerStageAbi.From(amountPerStage);

            return await base.MakeTransactionList(new List<object> { abiHandle, startTimeAbi, amountPerStageAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> Claim(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 204, 130, 171, 153 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Claim_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 204, 130, 171, 153 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVmVzdGluZ1ZhdWx0IiwiZGVzYyI6IkFuZCBoZXJl4oCZcyBvdXIgbWFpbiBjb250cmFjdCBjbGFzcy5cblxuSWYgeW91IHJlbWVtYmVyIHRoZSBQeXRob24gZXhhbXBsZSBmcm9tIGVhcmxpZXIsIHRoaXMgc2hvdWxkIGZlZWwgZmFtaWxpYXI6XG53ZeKAmXZlIGdvdCBhIGNsZWFuIGNsYXNzLCBhIGNvdXBsZSBvZiBmaWVsZHMsIGEgc2V0dXAgZnVuY3Rpb24sIGFuZCBhIGNsYWltIGZ1bmN0aW9uLlxuXG5UaGUgaWRlYSBvZiB0aGlzIGNvbnRyYWN0IGlzIHNpbXBsZTpcbndlIGRlZmluZSBhIHZlc3Rpbmcgc2NoZWR1bGUgdXAgZnJvbnTigKZcbmFuZCB0aGVuIGxhdGVyLCB0aGUgdXNlciBjYWxscyBgY2xhaW0oKWAgdG8gd2l0aGRyYXcgYW55IHVubG9ja2VkIGJ1dCB1bmNsYWltZWQgdG9rZW5zLiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJzZXR1cFNjaGVkdWxlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0YXJ0VGltZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50UGVyU3RhZ2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2xhaW0iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE3N10sImVycm9yTWVzc2FnZSI6IkJveCBtdXN0IGhhdmUgdmFsdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOF0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AgJiYgY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAwLDExMywxMjcsMTQxLDE5NiwyMzldLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcxLDgwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3SURnZ01UY0tJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZ3dNQ0FpYzJOb1pXUjFiR1VpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbVZ6ZEdsdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVXlDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVm1WemRHbHVaMVpoZFd4MElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRRGtLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYlhWemRDQmlaU0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0WkRFMk5qRTBPRE1nTUhoall6Z3lZV0k1T1NBdkx5QnRaWFJvYjJRZ0luTmxkSFZ3VTJOb1pXUjFiR1VvZFdsdWREWTBMSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKamJHRnBiU2dwZFdsdWREWTBJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYzJWMGRYQlRZMmhsWkhWc1pTQmpiR0ZwYlFvZ0lDQWdaWEp5Q2dwdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQTVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzWmxjM1JwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1nb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRlpsYzNScGJtZFdZWFZzZENCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCdGRYTjBJR0psSUU1dlQzQWdKaVlnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUdOeVpXRjBhVzVuQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzWmxjM1JwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlZtVnpkR2x1WjFaaGRXeDBMbk5sZEhWd1UyTm9aV1IxYkdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHpaWFIxY0ZOamFHVmtkV3hsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1psYzNScGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJPQW9nSUNBZ0x5OGdjSFZpYkdsaklITmxkSFZ3VTJOb1pXUjFiR1VvYzNSaGNuUlVhVzFsT2lCMWFXNTBOalFzSUdGdGIzVnVkRkJsY2xOMFlXZGxPaUIxYVc1ME5qUXBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyWlhOMGFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPREFLSUNBZ0lDOHZJR052Ym5OMElHNWxkMU5qYUdWa2RXeGxJRDBnYm1WM0lFWnBlR1ZrUVhKeVlYazhWbVZ6ZEdsdVoxTjBZV2RsTENBMFBpZ3BPd29nSUNBZ2NIVnphR2x1ZENBMk9DQXZMeUEyT0FvZ0lDQWdZbnBsY204S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyWlhOMGFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRE10T0RjS0lDQWdJQzh2SUc1bGQxTmphR1ZrZFd4bFd6QmRJRDBnZXdvZ0lDQWdMeThnSUNCMWJteHZZMnRVYVcxbE9pQnpkR0Z5ZEZScGJXVXNDaUFnSUNBdkx5QWdJR0Z0YjNWdWREb2dZVzF2ZFc1MFVHVnlVM1JoWjJVc0NpQWdJQ0F2THlBZ0lHbHpRMnhoYVcxbFpEb2dabUZzYzJVS0lDQWdJQzh2SUgwN0NpQWdJQ0JrYVdjZ01nb2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhCc1lXTmxNaUF3SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzWmxjM1JwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU1Rb2dJQ0FnTHk4Z2RXNXNiMk5yVkdsdFpUb2djM1JoY25SVWFXMWxJQ3NnVldsdWREWTBLREV3TUNrc0NpQWdJQ0JrYVdjZ01nb2dJQ0FnY0hWemFHbHVkQ0F4TURBZ0x5OGdNVEF3Q2lBZ0lDQXJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtVnpkR2x1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prd0xUazBDaUFnSUNBdkx5QnVaWGRUWTJobFpIVnNaVnN4WFNBOUlIc0tJQ0FnSUM4dklDQWdkVzVzYjJOclZHbHRaVG9nYzNSaGNuUlVhVzFsSUNzZ1ZXbHVkRFkwS0RFd01Da3NDaUFnSUNBdkx5QWdJR0Z0YjNWdWREb2dZVzF2ZFc1MFVHVnlVM1JoWjJVc0NpQWdJQ0F2THlBZ0lHbHpRMnhoYVcxbFpEb2dabUZzYzJVS0lDQWdJQzh2SUgwN0NpQWdJQ0JwZEc5aUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjbVZ3YkdGalpUSWdNVGNnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtVnpkR2x1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prNENpQWdJQ0F2THlCMWJteHZZMnRVYVcxbE9pQnpkR0Z5ZEZScGJXVWdLeUJWYVc1ME5qUW9NakF3S1N3S0lDQWdJR1JwWnlBeUNpQWdJQ0J3ZFhOb2FXNTBJREl3TUNBdkx5QXlNREFLSUNBZ0lDc0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MlpYTjBhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RjdE1UQXhDaUFnSUNBdkx5QnVaWGRUWTJobFpIVnNaVnN5WFNBOUlIc0tJQ0FnSUM4dklDQWdkVzVzYjJOclZHbHRaVG9nYzNSaGNuUlVhVzFsSUNzZ1ZXbHVkRFkwS0RJd01Da3NDaUFnSUNBdkx5QWdJR0Z0YjNWdWREb2dZVzF2ZFc1MFVHVnlVM1JoWjJVc0NpQWdJQ0F2THlBZ0lHbHpRMnhoYVcxbFpEb2dabUZzYzJVS0lDQWdJQzh2SUgwN0NpQWdJQ0JwZEc5aUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjbVZ3YkdGalpUSWdNelFnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtVnpkR2x1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd05Rb2dJQ0FnTHk4Z2RXNXNiMk5yVkdsdFpUb2djM1JoY25SVWFXMWxJQ3NnVldsdWREWTBLRE13TUNrc0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lIQjFjMmhwYm5RZ016QXdJQzh2SURNd01Bb2dJQ0FnS3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1psYzNScGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRFF0TVRBNENpQWdJQ0F2THlCdVpYZFRZMmhsWkhWc1pWc3pYU0E5SUhzS0lDQWdJQzh2SUNBZ2RXNXNiMk5yVkdsdFpUb2djM1JoY25SVWFXMWxJQ3NnVldsdWREWTBLRE13TUNrc0NpQWdJQ0F2THlBZ0lHRnRiM1Z1ZERvZ1lXMXZkVzUwVUdWeVUzUmhaMlVzQ2lBZ0lDQXZMeUFnSUdselEyeGhhVzFsWkRvZ1ptRnNjMlVLSUNBZ0lDOHZJSDA3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEpsY0d4aFkyVXlJRFV4SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzWmxjM1JwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk5nb2dJQ0FnTHk4Z2MyTm9aV1IxYkdVZ1BTQkNiM2c4Um1sNFpXUkJjbkpoZVR4V1pYTjBhVzVuVTNSaFoyVXNJRFErUGloN0lHdGxlVG9nUW5sMFpYTW9Jbk5qYUdWa2RXeGxJaWtnZlNrN0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKelkyaGxaSFZzWlNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyWlhOMGFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEUzQ2lBZ0lDQXZMeUIwYUdsekxuTmphR1ZrZFd4bExuWmhiSFZsSUQwZ1kyeHZibVVvYm1WM1UyTm9aV1IxYkdVcE93b2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzWmxjM1JwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1Ua0tJQ0FnSUM4dklHeHZaeWhDZVhSbGN5Z2lVMk5vWldSMWJHVWdTVzVwZEdsaGJHbDZaV1FpS1NrN0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWxOamFHVmtkV3hsSUVsdWFYUnBZV3hwZW1Wa0lnb2dJQ0FnYkc5bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG1WemRHbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalk0Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjMlYwZFhCVFkyaGxaSFZzWlNoemRHRnlkRlJwYldVNklIVnBiblEyTkN3Z1lXMXZkVzUwVUdWeVUzUmhaMlU2SUhWcGJuUTJOQ2s2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MlpYTjBhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xabGMzUnBibWRXWVhWc2RDNWpiR0ZwYlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnNZV2x0T2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzWmxjM1JwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE16Z0tJQ0FnSUM4dklHeGxkQ0IwYjNSaGJFTnNZV2x0WVdKc1pUb2dkV2x1ZERZMElEMGdNRHNLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtVnpkR2x1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZMkNpQWdJQ0F2THlCelkyaGxaSFZzWlNBOUlFSnZlRHhHYVhobFpFRnljbUY1UEZabGMzUnBibWRUZEdGblpTd2dORDQrS0hzZ2EyVjVPaUJDZVhSbGN5Z2ljMk5vWldSMWJHVWlLU0I5S1RzS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5OamFHVmtkV3hsSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1psYzNScGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOREVLSUNBZ0lDOHZJR052Ym5OMElHTjFjbkpsYm5SVFkyaGxaSFZzWlNBOUlHTnNiMjVsS0hSb2FYTXVjMk5vWldSMWJHVXVkbUZzZFdVcE93b2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MlpYTjBhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRVd0NpQWdJQ0F2THlCbWIzSWdLR3hsZENCcElEMGdWV2x1ZERZMEtEQXBPeUJwSUR3Z2JHVnVaM1JvT3lCcEt5c3BJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXdDZ3BqYkdGcGJWOTNhR2xzWlY5MGIzQkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTJaWE4wYVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVXdDaUFnSUNBdkx5Qm1iM0lnS0d4bGRDQnBJRDBnVldsdWREWTBLREFwT3lCcElEd2diR1Z1WjNSb095QnBLeXNwSUhzS0lDQWdJR1IxY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1psYzNScGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hORElLSUNBZ0lDOHZJR052Ym5OMElHeGxibWQwYURvZ2RXbHVkRFkwSUQwZ1kzVnljbVZ1ZEZOamFHVmtkV3hsTG14bGJtZDBhRHNLSUNBZ0lIQjFjMmhwYm5RZ05DQXZMeUEwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbVZ6ZEdsdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFNQW9nSUNBZ0x5OGdabTl5SUNoc1pYUWdhU0E5SUZWcGJuUTJOQ2d3S1RzZ2FTQThJR3hsYm1kMGFEc2dhU3NyS1NCN0NpQWdJQ0E4Q2lBZ0lDQmllaUJqYkdGcGJWOWhablJsY2w5M2FHbHNaVUEzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbVZ6ZEdsdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFOZ29nSUNBZ0x5OGdZMjl1YzNRZ2MzUmhaMlVnUFNCamJHOXVaU2hqZFhKeVpXNTBVMk5vWldSMWJHVmJhVjBwT3dvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNVGNLSUNBZ0lDb0tJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQTFDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh6SUM4dklERTNDaUFnSUNCbGVIUnlZV04wTXlBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0EyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbVZ6ZEdsdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFPUW9nSUNBZ0x5OGdhV1lnS0Vkc2IySmhiQzVzWVhSbGMzUlVhVzFsYzNSaGJYQWdQajBnYzNSaFoyVXVkVzVzYjJOclZHbHRaU0FtSmlBaGMzUmhaMlV1YVhORGJHRnBiV1ZrS1NCN0NpQWdJQ0JuYkc5aVlXd2dUR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJRDQ5Q2lBZ0lDQmllaUJqYkdGcGJWOWhablJsY2w5cFpsOWxiSE5sUURZS0lDQWdJR1JwWnlBMENpQWdJQ0J3ZFhOb2FXNTBJREV5T0NBdkx5QXhNamdLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdZbTU2SUdOc1lXbHRYMkZtZEdWeVgybG1YMlZzYzJWQU5nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNabGMzUnBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TmpBS0lDQWdJQzh2SUhSdmRHRnNRMnhoYVcxaFlteGxJRDBnZEc5MFlXeERiR0ZwYldGaWJHVWdLeUJ6ZEdGblpTNWhiVzkxYm5RN0NpQWdJQ0JrYVdjZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1JwWnlBMENpQWdJQ0FyQ2lBZ0lDQmlkWEo1SURRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyWlhOMGFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFl6Q2lBZ0lDQXZMeUJ6ZEdGblpTNXBjME5zWVdsdFpXUWdQU0IwY25WbE93b2dJQ0FnY0hWemFHbHVkQ0F4TWpnZ0x5OGdNVEk0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2MyVjBZbWwwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbVZ6ZEdsdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJOZ29nSUNBZ0x5OGdZM1Z5Y21WdWRGTmphR1ZrZFd4bFcybGRJRDBnWTJ4dmJtVW9jM1JoWjJVcE93b2dJQ0FnWkdsbklESUtJQ0FnSUdScFp5QTFDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSEpsY0d4aFkyVXpJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWW5WeWVTQXlDZ3BqYkdGcGJWOWhablJsY2w5cFpsOWxiSE5sUURZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG1WemRHbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxTUFvZ0lDQWdMeThnWm05eUlDaHNaWFFnYVNBOUlGVnBiblEyTkNnd0tUc2dhU0E4SUd4bGJtZDBhRHNnYVNzcktTQjdDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmlkWEo1SURFS0lDQWdJR0lnWTJ4aGFXMWZkMmhwYkdWZmRHOXdRRElLQ21Oc1lXbHRYMkZtZEdWeVgzZG9hV3hsUURjNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG1WemRHbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzTkFvZ0lDQWdMeThnYVdZZ0tIUnZkR0ZzUTJ4aGFXMWhZbXhsSUQ0Z01Da2dld29nSUNBZ1pHbG5JRElLSUNBZ0lHSjZJR05zWVdsdFgyRm1kR1Z5WDJsbVgyVnNjMlZBT1FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1psYzNScGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJOZ29nSUNBZ0x5OGdjMk5vWldSMWJHVWdQU0JDYjNnOFJtbDRaV1JCY25KaGVUeFdaWE4wYVc1blUzUmhaMlVzSURRK1BpaDdJR3RsZVRvZ1FubDBaWE1vSW5OamFHVmtkV3hsSWlrZ2ZTazdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnpZMmhsWkhWc1pTSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MlpYTjBhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRjMUNpQWdJQ0F2THlCMGFHbHpMbk5qYUdWa2RXeGxMblpoYkhWbElEMGdZMnh2Ym1Vb1kzVnljbVZ1ZEZOamFHVmtkV3hsS1RzS0lDQWdJR1JwWnlBeUNpQWdJQ0JpYjNoZmNIVjBDZ3BqYkdGcGJWOWhablJsY2w5cFpsOWxiSE5sUURrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG1WemRHbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzT1FvZ0lDQWdMeThnYkc5bktFSjVkR1Z6S0NKVWIzUmhiQ0JEYkdGcGJXVmtPaUlwS1RzS0lDQWdJSEIxYzJoaWVYUmxjeUFpVkc5MFlXd2dRMnhoYVcxbFpEb2lDaUFnSUNCc2IyY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MlpYTjBhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRnd0NpQWdJQ0F2THlCc2IyY29iM0F1YVhSdllpaDBiM1JoYkVOc1lXbHRZV0pzWlNrcE93b2dJQ0FnWkdsbklESUtJQ0FnSUdsMGIySUtJQ0FnSUdSMWNBb2dJQ0FnYkc5bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG1WemRHbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5TWdvZ0lDQWdMeThnY0hWaWJHbGpJR05zWVdsdEtDazZJSFZwYm5RMk5DQjdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBUUFJRVNZQ0FRQUljMk5vWldSMWJHVXhHMEVBSFRFWkZFUXhHRVNDQWdUUlpoU0RCTXlDcTVrMkdnQ09BZ0FMQUhZQU1Sa1VNUmdVRUVRaVF6WWFBVWtWSkJKRUZ6WWFBa2tWSkJKRUY0RkVyMHNDRms4Q0ZreExBVkFvVUU4Q1RGd0FTd0tCWkFnV1N3SlFLRkJjRVVzQ2djZ0JDQlpMQWxBb1VGd2lUd0tCckFJSUZrOENVQ2hRWERNcFRMK0FGRk5qYUdWa2RXeGxJRWx1YVhScFlXeHBlbVZrc0NKREk0QUFJeW0rUkNOSmdRUU1RUUJBU1NVTFNVVUZTd0pNSlZoSlJRWXlCMHdqV3c5QkFDRkxCSUdBQVZOQUFCaExCRWtrVzBzRUNFVUVnWUFCSWxSTEFrc0ZUd0pkUlFKSklnaEZBVUwvdVVzQ1FRQUVLVXNDdjRBT1ZHOTBZV3dnUTJ4aGFXMWxaRHF3U3dJV1NiQ0FCQlVmZkhWTVVMQWlRdz09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MywicGF0Y2giOjIsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
