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

namespace Arc56.Generated.CiottiGiorgio.lib_pcg_avm.LibPCG64TestHarnessAlgoPy_ae4677ee
{


    public class LibPCG64TestHarnessAlgoPyProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public LibPCG64TestHarnessAlgoPyProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="seed"> </param>
        /// <param name="lower_bound"> </param>
        /// <param name="upper_bound"> </param>
        /// <param name="length"> </param>
        public async Task<ulong[]> GetPcg64SequenceArc4Uint64Return(byte[] seed, ulong lower_bound, ulong upper_bound, ushort length, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 95, 138, 225, 129 };
            var seedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(16, "byte"); seedAbi.From(seed);
            var lower_boundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lower_boundAbi.From(lower_bound);
            var upper_boundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); upper_boundAbi.From(upper_bound);
            var lengthAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); lengthAbi.From(length);

            var result = await base.CallApp(new List<object> { abiHandle, seedAbi, lower_boundAbi, upper_boundAbi, lengthAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.Select(v => (ulong)v.ToValue()).ToArray();

        }

        public async Task<List<Transaction>> GetPcg64SequenceArc4Uint64Return_Transactions(byte[] seed, ulong lower_bound, ulong upper_bound, ushort length, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 95, 138, 225, 129 };
            var seedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(16, "byte"); seedAbi.From(seed);
            var lower_boundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lower_boundAbi.From(lower_bound);
            var upper_boundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); upper_boundAbi.From(upper_bound);
            var lengthAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); lengthAbi.From(length);

            return await base.MakeTransactionList(new List<object> { abiHandle, seedAbi, lower_boundAbi, upper_boundAbi, lengthAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task RuntimeAssertsPcg64StackArray(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 202, 111, 72, 56 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RuntimeAssertsPcg64StackArray_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 202, 111, 72, 56 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task RuntimeFailureStackBytesliceOverflow(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 11, 72, 152 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RuntimeFailureStackBytesliceOverflow_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 11, 72, 152 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTGliUENHNjRUZXN0SGFybmVzc0FsZ29QeSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJnZXRfcGNnNjRfc2VxdWVuY2VfYXJjNF91aW50NjRfcmV0dXJuIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbMTZdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VlZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibG93ZXJfYm91bmQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVwcGVyX2JvdW5kIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsZW5ndGgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJ1bnRpbWVfYXNzZXJ0c19wY2c2NF9zdGFja19hcnJheSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJydW50aW1lX2ZhaWx1cmVfc3RhY2tfYnl0ZXNsaWNlX292ZXJmbG93IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNDc5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDE2PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUwNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQxNiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ4OCw0OTddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjRdLCJlcnJvck1lc3NhZ2UiOiJvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJREFnTVRZZ05qTTJOREV6TmpJeU16ZzBOamM1TXpBd05TQTBNamswT1RZM01qazFJREUwTkRJMk9UVXdOREE0T0RnNU5qTTBNRGNnTVRRME1qWTVOVEEwTURnNE9EazJNelF3T1FvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1UQUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEVm1PR0ZsTVRneElEQjRZMkUyWmpRNE16Z2dNSGcyWXpCaU5EZzVPQ0F2THlCdFpYUm9iMlFnSW1kbGRGOXdZMmMyTkY5elpYRjFaVzVqWlY5aGNtTTBYM1ZwYm5RMk5GOXlaWFIxY200b1lubDBaVnN4Tmwwc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME1UWXBkV2x1ZERZMFcxMGlMQ0J0WlhSb2IyUWdJbkoxYm5ScGJXVmZZWE56WlhKMGMxOXdZMmMyTkY5emRHRmphMTloY25KaGVTZ3BkbTlwWkNJc0lHMWxkR2h2WkNBaWNuVnVkR2x0WlY5bVlXbHNkWEpsWDNOMFlXTnJYMko1ZEdWemJHbGpaVjl2ZG1WeVpteHZkeWdwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JR2RsZEY5d1kyYzJORjl6WlhGMVpXNWpaVjloY21NMFgzVnBiblEyTkY5eVpYUjFjbTRnY25WdWRHbHRaVjloYzNObGNuUnpYM0JqWnpZMFgzTjBZV05yWDJGeWNtRjVJSEoxYm5ScGJXVmZabUZwYkhWeVpWOXpkR0ZqYTE5aWVYUmxjMnhwWTJWZmIzWmxjbVpzYjNjS0lDQWdJR1Z5Y2dvS2JXRnBibDlmWDJGc1oyOXdlVjlrWldaaGRXeDBYMk55WldGMFpVQXhNRG9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdiR2xpWDNCalp5NXdZMmMyTkM1d1kyYzJORjlwYm1sMEtITmxaV1E2SUdKNWRHVnpLU0F0UGlCMWFXNTBOalFzSUhWcGJuUTJORG9LY0dObk5qUmZhVzVwZERvS0lDQWdJSEJ5YjNSdklERWdNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBeE5nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdOak0yTkRFek5qSXlNemcwTmpjNU16QXdOUW9nSUNBZ2JYVnNkd29nSUNBZ1luVnllU0F4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR01nTlNBdkx5QXhORFF5TmprMU1EUXdPRGc0T1RZek5EQTNDaUFnSUNCaFpHUjNDaUFnSUNCaWRYSjVJREVLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWVdSa2R3b2dJQ0FnWW5WeWVTQXhDaUFnSUNCcGJuUmpYek1nTHk4Z05qTTJOREV6TmpJeU16ZzBOamM1TXpBd05Rb2dJQ0FnYlhWc2R3b2dJQ0FnWW5WeWVTQXhDaUFnSUNCcGJuUmpJRFVnTHk4Z01UUTBNalk1TlRBME1EZzRPRGsyTXpRd053b2dJQ0FnWVdSa2R3b2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2NHOXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdNZ05pQXZMeUF4TkRReU5qazFNRFF3T0RnNE9UWXpOREE1Q2lBZ0lDQmhaR1IzQ2lBZ0lDQmlkWEo1SURFS0lDQWdJR0ZrWkhjS0lDQWdJR0oxY25rZ01Rb2dJQ0FnYVc1MFkxOHpJQzh2SURZek5qUXhNell5TWpNNE5EWTNPVE13TURVS0lDQWdJRzExYkhjS0lDQWdJR0oxY25rZ01Rb2dJQ0FnYVc1MFl5QTJJQzh2SURFME5ESTJPVFV3TkRBNE9EZzVOak0wTURrS0lDQWdJR0ZrWkhjS0lDQWdJR0oxY25rZ01Rb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2JHbGlYM0JqWnk1d1kyYzJOQzV3WTJjMk5GOXlZVzVrYjIwb2MzUmhkR1V1TURvZ2RXbHVkRFkwTENCemRHRjBaUzR4T2lCMWFXNTBOalFzSUd4dmQyVnlYMkp2ZFc1a09pQjFhVzUwTmpRc0lIVndjR1Z5WDJKdmRXNWtPaUIxYVc1ME5qUXNJR3hsYm1kMGFEb2dkV2x1ZERZMEtTQXRQaUIxYVc1ME5qUXNJSFZwYm5RMk5Dd2dZbmwwWlhNNkNuQmpaelkwWDNKaGJtUnZiVG9LSUNBZ0lIQnliM1J2SURVZ013b2dJQ0FnY0hWemFHSjVkR1Z6SUNJaUNpQWdJQ0JrZFhCdUlETUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVhSdllnb2dJQ0FnWkhWd0NpQWdJQ0JpYVhSc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBeE5nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWW01NklIQmpaelkwWDNKaGJtUnZiVjlsYkhObFgySnZaSGxBTndvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmlibm9nY0dObk5qUmZjbUZ1Wkc5dFgyVnNjMlZmWW05a2VVQTNDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeUNncHdZMmMyTkY5eVlXNWtiMjFmWm05eVgyaGxZV1JsY2tBek9nb2dJQ0FnWm5KaGJXVmZaR2xuSURJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdQQW9nSUNBZ1lub2djR05uTmpSZmNtRnVaRzl0WDJGbWRHVnlYMmxtWDJWc2MyVkFNakFLSUNBZ0lHWnlZVzFsWDJScFp5QXROUW9nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCallXeHNjM1ZpSUY5ZmNHTm5OalJmZFc1aWIzVnVaR1ZrWDNKaGJtUnZiUW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdabkpoYldWZlluVnllU0F0TkFvZ0lDQWdabkpoYldWZlluVnllU0F0TlFvZ0lDQWdhWFJ2WWdvZ0lDQWdabkpoYldWZlpHbG5JRFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlluVnllU0EwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNzS0lDQWdJR1p5WVcxbFgySjFjbmtnTWdvZ0lDQWdZaUJ3WTJjMk5GOXlZVzVrYjIxZlptOXlYMmhsWVdSbGNrQXpDZ3B3WTJjMk5GOXlZVzVrYjIxZllXWjBaWEpmYVdaZlpXeHpaVUF5TURvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TlFvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dOQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXlDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ3B3WTJjMk5GOXlZVzVrYjIxZlpXeHpaVjlpYjJSNVFEYzZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdKNklIQmpaelkwWDNKaGJtUnZiVjlsYkhObFgySnZaSGxBT1FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1Bnb2dJQ0FnWVhOelpYSjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lENEtJQ0FnSUdGemMyVnlkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUMwS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvS2NHTm5OalJmY21GdVpHOXRYMkZtZEdWeVgybG1YMlZzYzJWQU1UQTZDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWkhWd0NpQWdJQ0IrQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1lXUmtkd29nSUNBZ1luVnllU0F4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQWxDaUFnSUNCbWNtRnRaVjlpZFhKNUlETUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURJS0NuQmpaelkwWDNKaGJtUnZiVjltYjNKZmFHVmhaR1Z5UURFeE9nb2dJQ0FnWm5KaGJXVmZaR2xuSURJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdQQW9nSUNBZ1lub2djR05uTmpSZmNtRnVaRzl0WDJGbWRHVnlYMmxtWDJWc2MyVkFNakFLQ25Calp6WTBYM0poYm1SdmJWOTNhR2xzWlY5MGIzQkFNVE02Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFVLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1kyRnNiSE4xWWlCZlgzQmpaelkwWDNWdVltOTFibVJsWkY5eVlXNWtiMjBLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTXdvZ0lDQWdabkpoYldWZlluVnllU0F4Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJQzAwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJQzAxQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNd29nSUNBZ1BqMEtJQ0FnSUdKNklIQmpaelkwWDNKaGJtUnZiVjkzYUdsc1pWOTBiM0JBTVRNS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ0pRb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dOQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRFFLSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdabkpoYldWZlluVnllU0F5Q2lBZ0lDQmlJSEJqWnpZMFgzSmhibVJ2YlY5bWIzSmZhR1ZoWkdWeVFERXhDZ3B3WTJjMk5GOXlZVzVrYjIxZlpXeHpaVjlpYjJSNVFEazZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUhCMWMyaHBiblFnTVRnME5EWTNORFF3TnpNM01EazFOVEUyTVRVS0lDQWdJRHdLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lITjNZWEFLSUNBZ0lHSXRDaUFnSUNCaWRHOXBDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUdJZ2NHTm5OalJmY21GdVpHOXRYMkZtZEdWeVgybG1YMlZzYzJWQU1UQUtDZ292THlCc2FXSmZjR05uTG5Calp6WTBMbDlmY0dObk5qUmZkVzVpYjNWdVpHVmtYM0poYm1SdmJTaHpkR0YwWlM0d09pQjFhVzUwTmpRc0lITjBZWFJsTGpFNklIVnBiblEyTkNrZ0xUNGdkV2x1ZERZMExDQjFhVzUwTmpRc0lIVnBiblEyTkRvS1gxOXdZMmMyTkY5MWJtSnZkVzVrWldSZmNtRnVaRzl0T2dvZ0lDQWdjSEp2ZEc4Z01pQXpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdsdWRHTmZNeUF2THlBMk16WTBNVE0yTWpJek9EUTJOemt6TURBMUNpQWdJQ0J0ZFd4M0NpQWdJQ0JpZFhKNUlERUtJQ0FnSUdsdWRHTWdOU0F2THlBeE5EUXlOamsxTURRd09EZzRPVFl6TkRBM0NpQWdJQ0JoWkdSM0NpQWdJQ0JpZFhKNUlERUtJQ0FnSUdSMWNBb2dJQ0FnSVFvZ0lDQWdhVzUwWXlBMklDOHZJREUwTkRJMk9UVXdOREE0T0RnNU5qTTBNRGtLSUNBZ0lITjNZWEFLSUNBZ0lITm9iQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGJuUmpYek1nTHk4Z05qTTJOREV6TmpJeU16ZzBOamM1TXpBd05Rb2dJQ0FnYlhWc2R3b2dJQ0FnWW5WeWVTQXhDaUFnSUNCaFpHUjNDaUFnSUNCaWRYSjVJREVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2NIVnphR2x1ZENBeE9Bb2dJQ0FnYzJoeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJRjRLSUNBZ0lIQjFjMmhwYm5RZ01qY0tJQ0FnSUhOb2Nnb2dJQ0FnYVc1MFl5QTBJQzh2SURReU9UUTVOamN5T1RVS0lDQWdJQ1lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2NIVnphR2x1ZENBMU9Rb2dJQ0FnYzJoeUNpQWdJQ0JrZFhBeUNpQWdJQ0J6YUhJS0lDQWdJSE4zWVhBS0lDQWdJSDRLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCaFpHUjNDaUFnSUNCaWRYSjVJREVLSUNBZ0lIQjFjMmhwYm5RZ016RUtJQ0FnSUNZS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ2MyaHNDaUFnSUNCcGJuUmpJRFFnTHk4Z05ESTVORGsyTnpJNU5Rb2dJQ0FnSmdvZ0lDQWdmQW9nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnYzJoc0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEIxYzJocGJuUWdNVGdLSUNBZ0lITm9jZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCZUNpQWdJQ0J3ZFhOb2FXNTBJREkzQ2lBZ0lDQnphSElLSUNBZ0lHbHVkR01nTkNBdkx5QTBNamswT1RZM01qazFDaUFnSUNBbUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEIxYzJocGJuUWdOVGtLSUNBZ0lITm9jZ29nSUNBZ1pIVndNZ29nSUNBZ2MyaHlDaUFnSUNCemQyRndDaUFnSUNCK0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdZV1JrZHdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0J3ZFhOb2FXNTBJRE14Q2lBZ0lDQW1DaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJSE5vYkFvZ0lDQWdhVzUwWXlBMElDOHZJRFF5T1RRNU5qY3lPVFVLSUNBZ0lDWUtJQ0FnSUh3S0lDQWdJSHdLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXNhV0pmY0dObk5qUmZkR1Z6ZEY5b1lYSnVaWE56TG1OdmJuUnlZV04wTGt4cFlsQkRSelkwVkdWemRFaGhjbTVsYzNOQmJHZHZVSGt1WjJWMFgzQmpaelkwWDNObGNYVmxibU5sWDJGeVl6UmZkV2x1ZERZMFgzSmxkSFZ5Ymx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRjl3WTJjMk5GOXpaWEYxWlc1alpWOWhjbU0wWDNWcGJuUTJORjl5WlhSMWNtNDZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURFMkNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBeE5qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNVFlLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTJGc2JITjFZaUJ3WTJjMk5GOXBibWwwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdKMGIya0tJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCaWRHOXBDaUFnSUNCallXeHNjM1ZpSUhCalp6WTBYM0poYm1SdmJRb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2NHOXdiaUF5Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWJHbGlYM0JqWnpZMFgzUmxjM1JmYUdGeWJtVnpjeTVqYjI1MGNtRmpkQzVNYVdKUVEwYzJORlJsYzNSSVlYSnVaWE56UVd4bmIxQjVMbkoxYm5ScGJXVmZZWE56WlhKMGMxOXdZMmMyTkY5emRHRmphMTloY25KaGVWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkoxYm5ScGJXVmZZWE56WlhKMGMxOXdZMmMyTkY5emRHRmphMTloY25KaGVUb0tJQ0FnSUdsdWRHTmZNaUF2THlBeE5nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdOaGJHeHpkV0lnY0dObk5qUmZhVzVwZEFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBMU1URUtJQ0FnSUdOaGJHeHpkV0lnY0dObk5qUmZjbUZ1Wkc5dENpQWdJQ0J3YjNCdUlETUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11YkdsaVgzQmpaelkwWDNSbGMzUmZhR0Z5Ym1WemN5NWpiMjUwY21GamRDNU1hV0pRUTBjMk5GUmxjM1JJWVhKdVpYTnpRV3huYjFCNUxuSjFiblJwYldWZlptRnBiSFZ5WlY5emRHRmphMTlpZVhSbGMyeHBZMlZmYjNabGNtWnNiM2RiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweWRXNTBhVzFsWDJaaGFXeDFjbVZmYzNSaFkydGZZbmwwWlhOc2FXTmxYMjkyWlhKbWJHOTNPZ29nSUNBZ2FXNTBZMTh5SUM4dklERTJDaUFnSUNCaWVtVnlid29nSUNBZ1kyRnNiSE4xWWlCd1kyYzJORjlwYm1sMENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElEVXhNZ29nSUNBZ1kyRnNiSE4xWWlCd1kyYzJORjl5WVc1a2IyMEtJQ0FnSUhCdmNHNGdNd29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBSEFRQVFyZjdWNU5TRi9haFkvLy8vL3cvUGdwNjc3Ky9lZ2hUUmdwNjc3Ky9lZ2hReEcwRUFKREVaRkVReEdFU0NBd1JmaXVHQkJNcHZTRGdFYkF0SW1EWWFBSTREQVlvQnpRSGVBREVaRkRFWUZCQkRpZ0VDaS84VkpCSkVpLzhqV3lNbEhVVUJTU0VGSGtVQlR3SWVSUUVsSFVVQklRVWVUZ0pJaS8rQkNGdE1JUVllUlFFZVJRRWxIVVVCSVFZZVJRR0ppZ1VEZ0FCSEE0di9Ga21USkE1RVZ3WUNpLzFBQURxTC9rQUFOU09NQW9zQ2kvOE1RUUFkaS91TC9JZ0FwazRDalB5TSt4YUxCRXhRakFTTEFpSUlqQUpDLzl1TCs0djhpd1NNQW93QmpBQ0ppLzVCQUZtTC9pSU5SSXYrSWdtTC9RMUVpLzZML1FtTUFJc0FTUndpSGtVQlRCaU1BeU9NQW9zQ2kvOE1RZi9EaS91TC9JZ0FURWxPQTR3QmpQeU0rNHNERDBILzZvc0Jpd0FZaS8wSUZvc0VURkNNQklzQ0lnaU1Ba0wveW92OWdmLy8vLy8vLy8vLy93RU1SSXY5Rm9BSkFRQUFBQUFBQUFBQVRLRVhqQUJDLzVhS0FnT0wvaVVkUlFFaEJSNUZBVWtVSVFaTWtJdi9KUjFGQVI1RkFZditnUktSaS80YmdSdVJJUVFhaS82Qk81RktrVXdjSWg1RkFZRWZHazhDVEpBaEJCb1pnU0NRaS8rQkVwR0wveHVCRzVFaEJCcUwvNEU3a1VxUlRCd2lIa1VCZ1I4YVR3Sk1rQ0VFR2hrWmlUWWFBVWtWSkJKRU5ob0NTUldCQ0JKRU5ob0RTUldCQ0JKRU5ob0VTUldCQWhKRVR3T0kvbGRQQkJkUEJCZFBCQmVJL29wT0FrWUNnQVFWSDN4MVRGQ3dJa01rcjRqK055TkpnZjhEaVA1dVJnTWlReVN2aVA0bUkwbUJnQVNJL2wxR0F5SkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo4LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
