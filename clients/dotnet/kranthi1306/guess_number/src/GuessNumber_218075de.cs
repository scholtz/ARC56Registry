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

namespace Arc56.Generated.kranthi1306.guess_number.GuessNumber_218075de
{


    public class GuessNumberProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public GuessNumberProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="hidden_number"> </param>
        public async Task GeneratedNumber(ulong hidden_number, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 131, 62, 232 };
            var hidden_numberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hidden_numberAbi.From(hidden_number);

            var result = await base.CallApp(new List<object> { abiHandle, hidden_numberAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GeneratedNumber_Transactions(ulong hidden_number, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 131, 62, 232 };
            var hidden_numberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hidden_numberAbi.From(hidden_number);

            return await base.MakeTransactionList(new List<object> { abiHandle, hidden_numberAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="user_guess"> </param>
        public async Task<string> Guess(ulong user_guess, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 171, 224, 249, 206 };
            var user_guessAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); user_guessAbi.From(user_guess);

            var result = await base.CallApp(new List<object> { abiHandle, user_guessAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Guess_Transactions(ulong user_guess, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 171, 224, 249, 206 };
            var user_guessAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); user_guessAbi.From(user_guess);

            return await base.MakeTransactionList(new List<object> { abiHandle, user_guessAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> GetWinner(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 243, 208, 41, 218 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> GetWinner_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 243, 208, 41, 218 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiR3Vlc3NOdW1iZXIiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiZ2VuZXJhdGVkX251bWJlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJoaWRkZW5fbnVtYmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Imd1ZXNzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXJfZ3Vlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfd2lubmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6Mn0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTcwXSwiZXJyb3JNZXNzYWdlIjoiR2FtZSBhbHJlYWR5IHdvbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MF0sImVycm9yTWVzc2FnZSI6Ik51bWJlciBtdXN0IGJlIHBvc2l0aXZlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzAsODYsMTA1XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM2XSwiZXJyb3JNZXNzYWdlIjoiT25seSBjcmVhdG9yIGNhbiBzZXQgbnVtYmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI1XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzMsODksMTA4XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3NCwyMjFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmd1ZXNzX251bWJlciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjYsMjU4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi53aW5uZXIgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ0luZHBibTVsY2lJZ0ltZDFaWE56WDI1MWJXSmxjaUlnTUhneE5URm1OMk0zTlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmQxWlhOelgyNTFiV0psY2k5amIyNTBjbUZqZEM1d2VUb3pDaUFnSUNBdkx5QmpiR0Z6Y3lCSGRXVnpjMDUxYldKbGNpaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZZbUZ5WlY5eWIzVjBhVzVuUURnS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhneU5EZ3pNMlZsT0NBd2VHRmlaVEJtT1dObElEQjRaak5rTURJNVpHRWdMeThnYldWMGFHOWtJQ0puWlc1bGNtRjBaV1JmYm5WdFltVnlLSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKbmRXVnpjeWgxYVc1ME5qUXBjM1J5YVc1bklpd2diV1YwYUc5a0lDSm5aWFJmZDJsdWJtVnlLQ2xoWkdSeVpYTnpJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOW5aVzVsY21GMFpXUmZiblZ0WW1WeVgzSnZkWFJsUURNZ2JXRnBibDluZFdWemMxOXliM1YwWlVBMElHMWhhVzVmWjJWMFgzZHBibTVsY2w5eWIzVjBaVUExQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1USTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlozVmxjM05mYm5WdFltVnlMMk52Ym5SeVlXTjBMbkI1T2pNS0lDQWdJQzh2SUdOc1lYTnpJRWQxWlhOelRuVnRZbVZ5S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRjkzYVc1dVpYSmZjbTkxZEdWQU5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bmRXVnpjMTl1ZFcxaVpYSXZZMjl1ZEhKaFkzUXVjSGs2TWpVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBYM2RwYm01bGNnb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5bmRXVnpjMTl5YjNWMFpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZDFaWE56WDI1MWJXSmxjaTlqYjI1MGNtRmpkQzV3ZVRveE5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmQxWlhOelgyNTFiV0psY2k5amIyNTBjbUZqZEM1d2VUb3pDaUFnSUNBdkx5QmpiR0Z6Y3lCSGRXVnpjMDUxYldKbGNpaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmQxWlhOelgyNTFiV0psY2k5amIyNTBjbUZqZEM1d2VUb3hOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnWjNWbGMzTUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVnVaWEpoZEdWa1gyNTFiV0psY2w5eWIzVjBaVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmQxWlhOelgyNTFiV0psY2k5amIyNTBjbUZqZEM1d2VUbzNDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjNWbGMzTmZiblZ0WW1WeUwyTnZiblJ5WVdOMExuQjVPak1LSUNBZ0lDOHZJR05zWVhOeklFZDFaWE56VG5WdFltVnlLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjNWbGMzTmZiblZ0WW1WeUwyTnZiblJ5WVdOMExuQjVPamNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUdkbGJtVnlZWFJsWkY5dWRXMWlaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZbUZ5WlY5eWIzVjBhVzVuUURnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjNWbGMzTmZiblZ0WW1WeUwyTnZiblJ5WVdOMExuQjVPak1LSUNBZ0lDOHZJR05zWVhOeklFZDFaWE56VG5WdFltVnlLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREV5Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1bmRXVnpjMTl1ZFcxaVpYSXVZMjl1ZEhKaFkzUXVSM1ZsYzNOT2RXMWlaWEl1WjJWdVpYSmhkR1ZrWDI1MWJXSmxjaWhvYVdSa1pXNWZiblZ0WW1WeU9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS1oyVnVaWEpoZEdWa1gyNTFiV0psY2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluZFdWemMxOXVkVzFpWlhJdlkyOXVkSEpoWTNRdWNIazZOeTA0Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdaR1ZtSUdkbGJtVnlZWFJsWkY5dWRXMWlaWElvYzJWc1ppd2dhR2xrWkdWdVgyNTFiV0psY2pvZ1lYSmpOQzVWU1c1ME5qUXBJQzArSUU1dmJtVTZDaUFnSUNCd2NtOTBieUF4SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluZFdWemMxOXVkVzFpWlhJdlkyOXVkSEpoWTNRdWNIazZPUW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnUjJ4dlltRnNMbU55WldGMGIzSmZZV1JrY21WemN5d2dJazl1YkhrZ1kzSmxZWFJ2Y2lCallXNGdjMlYwSUc1MWJXSmxjaUlLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdkc2IySmhiQ0JEY21WaGRHOXlRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHTnlaV0YwYjNJZ1kyRnVJSE5sZENCdWRXMWlaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5kV1Z6YzE5dWRXMWlaWEl2WTI5dWRISmhZM1F1Y0hrNk1UQUtJQ0FnSUM4dklHRnpjMlZ5ZENCb2FXUmtaVzVmYm5WdFltVnlJRDRnWVhKak5DNVZTVzUwTmpRb01Da3NJQ0pPZFcxaVpYSWdiWFZ6ZENCaVpTQndiM05wZEdsMlpTSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZajRLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk9kVzFpWlhJZ2JYVnpkQ0JpWlNCd2IzTnBkR2wyWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmQxWlhOelgyNTFiV0psY2k5amIyNTBjbUZqZEM1d2VUb3hNUW9nSUNBZ0x5OGdjMlZzWmk1bmRXVnpjMTl1ZFcxaVpYSWdQU0JvYVdSa1pXNWZiblZ0WW1WeUNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKbmRXVnpjMTl1ZFcxaVpYSWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlozVmxjM05mYm5WdFltVnlMMk52Ym5SeVlXTjBMbkI1T2pFeUNpQWdJQ0F2THlCelpXeG1MbmRwYm01bGNpQTlJR0Z5WXpRdVFXUmtjbVZ6Y3loSGJHOWlZV3d1ZW1WeWIxOWhaR1J5WlhOektTQWdJeUJRY205d1pYSnNlU0JoYzNOcFoyNGdlbVZ5YnlCaFpHUnlaWE56Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ozYVc1dVpYSWlDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WjNWbGMzTmZiblZ0WW1WeUxtTnZiblJ5WVdOMExrZDFaWE56VG5WdFltVnlMbWQxWlhOektIVnpaWEpmWjNWbGMzTTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0taM1ZsYzNNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjNWbGMzTmZiblZ0WW1WeUwyTnZiblJ5WVdOMExuQjVPakUwTFRFMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnWkdWbUlHZDFaWE56S0hObGJHWXNJSFZ6WlhKZlozVmxjM002SUdGeVl6UXVWVWx1ZERZMEtTQXRQaUJoY21NMExsTjBjbWx1WnpvS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZDFaWE56WDI1MWJXSmxjaTlqYjI1MGNtRmpkQzV3ZVRveE5nb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVkMmx1Ym1WeUlEMDlZWEpqTkM1QlpHUnlaWE56S0Vkc2IySmhiQzU2WlhKdlgyRmtaSEpsYzNNcExDQWlSMkZ0WlNCaGJISmxZV1I1SUhkdmJpSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKM2FXNXVaWElpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWQybHVibVZ5SUdWNGFYTjBjd29nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRWRoYldVZ1lXeHlaV0ZrZVNCM2IyNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bmRXVnpjMTl1ZFcxaVpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRjS0lDQWdJQzh2SUdsbUlIVnpaWEpmWjNWbGMzTWdQVDBnYzJWc1ppNW5kV1Z6YzE5dWRXMWlaWEk2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlaM1ZsYzNOZmJuVnRZbVZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtZDFaWE56WDI1MWJXSmxjaUJsZUdsemRITUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWWowOUNpQWdJQ0JpZWlCbmRXVnpjMTlsYkhObFgySnZaSGxBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmQxWlhOelgyNTFiV0psY2k5amIyNTBjbUZqZEM1d2VUb3hPQW9nSUNBZ0x5OGdjMlZzWmk1M2FXNXVaWElnUFNCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtnSUNNZ1EyOXVkbVZ5ZENCelpXNWtaWElnZEc4Z1FXUmtjbVZ6Y3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZDJsdWJtVnlJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bmRXVnpjMTl1ZFcxaVpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRrS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExsTjBjbWx1WnlnaVEyOXljbVZqZENFZ1dXOTFJR0Z5WlNCMGFHVWdkMmx1Ym1WeUlTSXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREZqTkRNMlpqY3lOekkyTlRZek56UXlNVEl3TlRrMlpqYzFNakEyTVRjeU5qVXlNRGMwTmpnMk5USXdOemMyT1RabE5tVTJOVGN5TWpFS0lDQWdJSEpsZEhOMVlnb0taM1ZsYzNOZlpXeHpaVjlpYjJSNVFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlozVmxjM05mYm5WdFltVnlMMk52Ym5SeVlXTjBMbkI1T2pJd0NpQWdJQ0F2THlCbGJHbG1JSFZ6WlhKZlozVmxjM01nUENCelpXeG1MbWQxWlhOelgyNTFiV0psY2pvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0puZFdWemMxOXVkVzFpWlhJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVaM1ZsYzNOZmJuVnRZbVZ5SUdWNGFYTjBjd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaVBnb2dJQ0FnWW5vZ1ozVmxjM05mWld4elpWOWliMlI1UURRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluZFdWemMxOXVkVzFpWlhJdlkyOXVkSEpoWTNRdWNIazZNakVLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGxOMGNtbHVaeWdpVkc5dklHeHZkeUVpS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd09EVTBObVkyWmpJd05tTTJaamMzTWpFS0lDQWdJSEpsZEhOMVlnb0taM1ZsYzNOZlpXeHpaVjlpYjJSNVFEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlozVmxjM05mYm5WdFltVnlMMk52Ym5SeVlXTjBMbkI1T2pJekNpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNVRkSEpwYm1jb0lsUnZieUJvYVdkb0lTSXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREE1TlRRMlpqWm1NakEyT0RZNU5qYzJPREl4Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVaM1ZsYzNOZmJuVnRZbVZ5TG1OdmJuUnlZV04wTGtkMVpYTnpUblZ0WW1WeUxtZGxkRjkzYVc1dVpYSW9LU0F0UGlCaWVYUmxjem9LWjJWMFgzZHBibTVsY2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluZFdWemMxOXVkVzFpWlhJdlkyOXVkSEpoWTNRdWNIazZNamNLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG5kcGJtNWxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0luZHBibTVsY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTNhVzV1WlhJZ1pYaHBjM1J6Q2lBZ0lDQnlaWFJ6ZFdJSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFDQUFFbUF3WjNhVzV1WlhJTVozVmxjM05mYm5WdFltVnlCQlVmZkhVeEcwRUFVSUlEQkNTRFB1Z0VxK0Q1emdUejBDbmFOaG9BamdNQUpRQVNBQUlpUXpFWkZFUXhHRVNJQUxJcVRGQ3dJME14R1JSRU1SaEVOaG9CaUFCQUtreFFzQ05ETVJrVVJERVlSRFlhQVlnQURTTkRNUmxBLzhjeEdCUkVJME9LQVFBeEFESUpFa1NMLzRBSUFBQUFBQUFBQUFDbFJDbUwvMmNvTWdObmlZb0JBU0lvWlVReUF4SkVJaWxsUkl2L3FFRUFKU2d4QUdlQUhnQWNRMjl5Y21WamRDRWdXVzkxSUdGeVpTQjBhR1VnZDJsdWJtVnlJWWtpS1dWRWkvK2xRUUFOZ0FvQUNGUnZieUJzYjNjaGlZQUxBQWxVYjI4Z2FHbG5hQ0dKSWlobFJJaz0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
