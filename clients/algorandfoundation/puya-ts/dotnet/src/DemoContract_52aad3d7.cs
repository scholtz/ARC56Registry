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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRGVtb0NvbnRyYWN0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6InJ1biIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0X3NpZGVfZWZmZWN0cyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3Rfbm9uX3RyaXZpYWxfdGVybWluYXRpb25fb2ZfY2xhdXNlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE2NV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgdHdvIGZ1bmN0aW9ucyBzaG91bGQgYmUgZXZhbHVhdGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYyLDE4NF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY5LDgxLDEyNV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBNElEQWdNZ29nSUNBZ1lubDBaV05pYkc5amF5QWlaWFpoYkVOdmRXNTBJZ29nSUNBZ2NIVnphR0o1ZEdWeklDSWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmMzZHBkR05vTFhOMFlYUmxiV1Z1ZEhNdVlXeG5ieTUwY3pvMENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdSR1Z0YjBOdmJuUnlZV04wSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFERXdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IaGhObVptT1RRMFlTQXdlRGszWkRSalpqQXdJREI0WVRneFlUUTNZV0lnTHk4Z2JXVjBhRzlrSUNKeWRXNG9LWFp2YVdRaUxDQnRaWFJvYjJRZ0luUmxjM1JmYzJsa1pWOWxabVpsWTNSektIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0owWlhOMFgyNXZibDkwY21sMmFXRnNYM1JsY20xcGJtRjBhVzl1WDI5bVgyTnNZWFZ6WlNoMWFXNTBOalFzZFdsdWREWTBLWFZwYm5RMk5DSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZmNuVnVYM0p2ZFhSbFFEUWdiV0ZwYmw5MFpYTjBYM05wWkdWZlpXWm1aV04wYzE5eWIzVjBaVUExSUcxaGFXNWZkR1Z6ZEY5dWIyNWZkSEpwZG1saGJGOTBaWEp0YVc1aGRHbHZibDl2Wmw5amJHRjFjMlZmY205MWRHVkFOZ29nSUNBZ1pYSnlDZ3B0WVdsdVgzUmxjM1JmYm05dVgzUnlhWFpwWVd4ZmRHVnliV2x1WVhScGIyNWZiMlpmWTJ4aGRYTmxYM0p2ZFhSbFFEWTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmMzZHBkR05vTFhOMFlYUmxiV1Z1ZEhNdVlXeG5ieTUwY3pvNE13b2dJQ0FnTHk4Z2NIVmliR2xqSUhSbGMzUmZibTl1WDNSeWFYWnBZV3hmZEdWeWJXbHVZWFJwYjI1ZmIyWmZZMnhoZFhObEtHNDZJSFZwYm5RMk5Dd2dlVG9nZFdsdWREWTBLVG9nZFdsdWREWTBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCemQyRndDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmMzZHBkR05vTFhOMFlYUmxiV1Z1ZEhNdVlXeG5ieTUwY3pvNE5Rb2dJQ0FnTHk4Z1kyRnpaU0F4T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lEMDlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmMzZHBkR05vTFhOMFlYUmxiV1Z1ZEhNdVlXeG5ieTUwY3pvNE5TMDVNQW9nSUNBZ0x5OGdZMkZ6WlNBeE9nb2dJQ0FnTHk4Z0lDQnBaaUFvZVNBbElESWdQVDA5SURBcElIc0tJQ0FnSUM4dklDQWdJQ0J5WlhSMWNtNGdlUW9nSUNBZ0x5OGdJQ0I5SUdWc2MyVWdld29nSUNBZ0x5OGdJQ0FnSUhKbGRIVnliaUJ1Q2lBZ0lDQXZMeUFnSUgwS0lDQWdJR0o2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE53b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNOM2FYUmphQzF6ZEdGMFpXMWxiblJ6TG1Gc1oyOHVkSE02T0RZS0lDQWdJQzh2SUdsbUlDaDVJQ1VnTWlBOVBUMGdNQ2tnZXdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0pRb2dJQ0FnWW01NklHMWhhVzVmWld4elpWOWliMlI1UURFMkNncHRZV2x1WDJGbWRHVnlYMmx1YkdsdVpXUmZkR1Z6ZEhNdllYQndjbTkyWVd4ekwzTjNhWFJqYUMxemRHRjBaVzFsYm5SekxtRnNaMjh1ZEhNNk9rUmxiVzlEYjI1MGNtRmpkQzUwWlhOMFgyNXZibDkwY21sMmFXRnNYM1JsY20xcGJtRjBhVzl1WDI5bVgyTnNZWFZ6WlVBeE9Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5emQybDBZMmd0YzNSaGRHVnRaVzUwY3k1aGJHZHZMblJ6T2pnekNpQWdJQ0F2THlCd2RXSnNhV01nZEdWemRGOXViMjVmZEhKcGRtbGhiRjkwWlhKdGFXNWhkR2x2Ymw5dlpsOWpiR0YxYzJVb2Jqb2dkV2x1ZERZMExDQjVPaUIxYVc1ME5qUXBPaUIxYVc1ME5qUWdld29nSUNBZ2FYUnZZZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyVnNjMlZmWW05a2VVQXhOam9LSUNBZ0lIQnZjQW9nSUNBZ1pIVndDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmMzZHBkR05vTFhOMFlYUmxiV1Z1ZEhNdVlXeG5ieTUwY3pvNE13b2dJQ0FnTHk4Z2NIVmliR2xqSUhSbGMzUmZibTl1WDNSeWFYWnBZV3hmZEdWeWJXbHVZWFJwYjI1ZmIyWmZZMnhoZFhObEtHNDZJSFZwYm5RMk5Dd2dlVG9nZFdsdWREWTBLVG9nZFdsdWREWTBJSHNLSUNBZ0lHSWdiV0ZwYmw5aFpuUmxjbDlwYm14cGJtVmtYM1JsYzNSekwyRndjSEp2ZG1Gc2N5OXpkMmwwWTJndGMzUmhkR1Z0Wlc1MGN5NWhiR2R2TG5Sek9qcEVaVzF2UTI5dWRISmhZM1F1ZEdWemRGOXViMjVmZEhKcGRtbGhiRjkwWlhKdGFXNWhkR2x2Ymw5dlpsOWpiR0YxYzJWQU1UZ0tDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TnpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl6ZDJsMFkyZ3RjM1JoZEdWdFpXNTBjeTVoYkdkdkxuUnpPamt5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdlU0FxSUc0S0lDQWdJR1JwWnlBeENpQWdJQ0FxQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjM2RwZEdOb0xYTjBZWFJsYldWdWRITXVZV3huYnk1MGN6bzRNd29nSUNBZ0x5OGdjSFZpYkdsaklIUmxjM1JmYm05dVgzUnlhWFpwWVd4ZmRHVnliV2x1WVhScGIyNWZiMlpmWTJ4aGRYTmxLRzQ2SUhWcGJuUTJOQ3dnZVRvZ2RXbHVkRFkwS1RvZ2RXbHVkRFkwSUhzS0lDQWdJR0lnYldGcGJsOWhablJsY2w5cGJteHBibVZrWDNSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl6ZDJsMFkyZ3RjM1JoZEdWdFpXNTBjeTVoYkdkdkxuUnpPanBFWlcxdlEyOXVkSEpoWTNRdWRHVnpkRjl1YjI1ZmRISnBkbWxoYkY5MFpYSnRhVzVoZEdsdmJsOXZabDlqYkdGMWMyVkFNVGdLQ20xaGFXNWZkR1Z6ZEY5emFXUmxYMlZtWm1WamRITmZjbTkxZEdWQU5Ub0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5emQybDBZMmd0YzNSaGRHVnRaVzUwY3k1aGJHZHZMblJ6T2pZNENpQWdJQ0F2THlCd2RXSnNhV01nZEdWemRGOXphV1JsWDJWbVptVmpkSE1vYmpvZ2RXbHVkRFkwS1NCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzTjNhWFJqYUMxemRHRjBaVzFsYm5SekxtRnNaMjh1ZEhNNk5qRUtJQ0FnSUM4dklHVjJZV3hEYjNWdWRDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWlhaaGJFTnZkVzUwSWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMM04zYVhSamFDMXpkR0YwWlcxbGJuUnpMbUZzWjI4dWRITTZOamtLSUNBZ0lDOHZJSFJvYVhNdVpYWmhiRU52ZFc1MExuWmhiSFZsSUQwZ01Bb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YzNkcGRHTm9MWE4wWVhSbGJXVnVkSE11WVd4bmJ5NTBjem8zTWdvZ0lDQWdMeThnWTJGelpTQjBhR2x6TG1sdVkzSmxZWE5sUlhaaGJFRnVaRkpsZEhWeWJpaHVJQzBnTVNrNkNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCallXeHNjM1ZpSUdsdVkzSmxZWE5sUlhaaGJFRnVaRkpsZEhWeWJnb2dJQ0FnUFQwS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl6ZDJsMFkyZ3RjM1JoZEdWdFpXNTBjeTVoYkdkdkxuUnpPamN5TFRjekNpQWdJQ0F2THlCallYTmxJSFJvYVhNdWFXNWpjbVZoYzJWRmRtRnNRVzVrVW1WMGRYSnVLRzRnTFNBeEtUb0tJQ0FnSUM4dklDQWdZbkpsWVdzS0lDQWdJR0p1ZWlCdFlXbHVYMkpzYjJOclFESXpDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmMzZHBkR05vTFhOMFlYUmxiV1Z1ZEhNdVlXeG5ieTUwY3pvM05Bb2dJQ0FnTHk4Z1kyRnpaU0IwYUdsekxtbHVZM0psWVhObFJYWmhiRUZ1WkZKbGRIVnliaWh1S1RvS0lDQWdJR1IxY0c0Z01nb2dJQ0FnWTJGc2JITjFZaUJwYm1OeVpXRnpaVVYyWVd4QmJtUlNaWFIxY200S0lDQWdJRDA5Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjM2RwZEdOb0xYTjBZWFJsYldWdWRITXVZV3huYnk1MGN6bzNOQzAzTlFvZ0lDQWdMeThnWTJGelpTQjBhR2x6TG1sdVkzSmxZWE5sUlhaaGJFRnVaRkpsZEhWeWJpaHVLVG9LSUNBZ0lDOHZJQ0FnWW5KbFlXc0tJQ0FnSUdKdWVpQnRZV2x1WDJKc2IyTnJRREl6Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjM2RwZEdOb0xYTjBZWFJsYldWdWRITXVZV3huYnk1MGN6bzNOZ29nSUNBZ0x5OGdZMkZ6WlNCMGFHbHpMbWx1WTNKbFlYTmxSWFpoYkVGdVpGSmxkSFZ5YmlodUlDc2dNU2s2Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JqWVd4c2MzVmlJR2x1WTNKbFlYTmxSWFpoYkVGdVpGSmxkSFZ5YmdvZ0lDQWdjRzl3Q2dwdFlXbHVYMkpzYjJOclFESXpPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzTjNhWFJqYUMxemRHRjBaVzFsYm5SekxtRnNaMjh1ZEhNNk9EQUtJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbVYyWVd4RGIzVnVkQzUyWVd4MVpTQTlQVDBnTWl3Z0owOXViSGtnZEhkdklHWjFibU4wYVc5dWN5QnphRzkxYkdRZ1ltVWdaWFpoYkhWaGRHVmtKeWtLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmMzZHBkR05vTFhOMFlYUmxiV1Z1ZEhNdVlXeG5ieTUwY3pvMk1Rb2dJQ0FnTHk4Z1pYWmhiRU52ZFc1MElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0psZG1Gc1EyOTFiblFpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjM2RwZEdOb0xYTjBZWFJsYldWdWRITXVZV3huYnk1MGN6bzRNQW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WlhaaGJFTnZkVzUwTG5aaGJIVmxJRDA5UFNBeUxDQW5UMjVzZVNCMGQyOGdablZ1WTNScGIyNXpJSE5vYjNWc1pDQmlaU0JsZG1Gc2RXRjBaV1FuS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2dkSGR2SUdaMWJtTjBhVzl1Y3lCemFHOTFiR1FnWW1VZ1pYWmhiSFZoZEdWa0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YzNkcGRHTm9MWE4wWVhSbGJXVnVkSE11WVd4bmJ5NTBjem8yT0FvZ0lDQWdMeThnY0hWaWJHbGpJSFJsYzNSZmMybGtaVjlsWm1abFkzUnpLRzQ2SUhWcGJuUTJOQ2tnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl5ZFc1ZmNtOTFkR1ZBTkRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl6ZDJsMFkyZ3RjM1JoZEdWdFpXNTBjeTVoYkdkdkxuUnpPalVLSUNBZ0lDOHZJSEoxYmlncElIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURFd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNOM2FYUmphQzF6ZEdGMFpXMWxiblJ6TG1Gc1oyOHVkSE02TkFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFUmxiVzlEYjI1MGNtRmpkQ0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzTjNhWFJqYUMxemRHRjBaVzFsYm5SekxtRnNaMjh1ZEhNNk9rUmxiVzlEYjI1MGNtRmpkQzVwYm1OeVpXRnpaVVYyWVd4QmJtUlNaWFIxY200b2Jqb2dkV2x1ZERZMEtTQXRQaUIxYVc1ME5qUTZDbWx1WTNKbFlYTmxSWFpoYkVGdVpGSmxkSFZ5YmpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl6ZDJsMFkyZ3RjM1JoZEdWdFpXNTBjeTVoYkdkdkxuUnpPall6Q2lBZ0lDQXZMeUJ3Y21sMllYUmxJR2x1WTNKbFlYTmxSWFpoYkVGdVpGSmxkSFZ5YmlodU9pQjFhVzUwTmpRcElIc0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMM04zYVhSamFDMXpkR0YwWlcxbGJuUnpMbUZzWjI4dWRITTZOalFLSUNBZ0lDOHZJSFJvYVhNdVpYWmhiRU52ZFc1MExuWmhiSFZsS3lzS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjM2RwZEdOb0xYTjBZWFJsYldWdWRITXVZV3huYnk1MGN6bzJNUW9nSUNBZ0x5OGdaWFpoYkVOdmRXNTBJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKbGRtRnNRMjkxYm5RaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YzNkcGRHTm9MWE4wWVhSbGJXVnVkSE11WVd4bmJ5NTBjem8yTkFvZ0lDQWdMeThnZEdocGN5NWxkbUZzUTI5MWJuUXVkbUZzZFdVckt3b2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmMzZHBkR05vTFhOMFlYUmxiV1Z1ZEhNdVlXeG5ieTUwY3pvMk1Rb2dJQ0FnTHk4Z1pYWmhiRU52ZFc1MElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0psZG1Gc1EyOTFiblFpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjM2RwZEdOb0xYTjBZWFJsYldWdWRITXVZV3huYnk1MGN6bzJOQW9nSUNBZ0x5OGdkR2hwY3k1bGRtRnNRMjkxYm5RdWRtRnNkV1VyS3dvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl6ZDJsMFkyZ3RjM1JoZEdWdFpXNTBjeTVoYkdkdkxuUnpPalkxQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdiZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFRZ0FBaVlCQ1dWMllXeERiM1Z1ZElBQU1SdEJBSkF4R1JSRU1SaEVnZ01FcHYrVVNnU1gxTThBQktnYVI2czJHZ0NPQXdCckFEa0FBUUEyR2dGSkZTTVNSQmRKUlFJMkdnSkpGU01TUkJkTUloSkJBQmRKSlJoQUFBd1dnQVFWSDN4MVRGQ3dJa05JU1VMLzcwc0JDMEwvNlRZYUFVa1ZJeEpFRjBsRkFpZ2taMGtpQ1lnQUp4SkFBQkJIQW9nQUhoSkFBQWRKSWdpSUFCUklKQ2hsUkNVU1JDSkRJa014R1JReEdCUVFRNG9CQVNRb1pVUWlDQ2hNWjR2L2lRPT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
