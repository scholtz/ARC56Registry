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

namespace Arc56.Generated.algorandfoundation.puya_ts.ContractOne_bd052ef9
{


    public class ContractOneProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ContractOneProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> Test(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 158, 60, 196 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Test_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 158, 60, 196 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> SomeMethod(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 233, 89, 110 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SomeMethod_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 233, 89, 110 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task TestReferenceTypes(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 107, 72, 213, 34 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestReferenceTypes_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 107, 72, 213, 34 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ29udHJhY3RPbmUiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoidGVzdCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzb21lTWV0aG9kIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdFJlZmVyZW5jZVR5cGVzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeENpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE1UVXhaamRqTnpVZ01IZzBNemhqTmpSbU15QXdlRFprTmpJd1lXTTBJREI0TkRZNU5qRXhPVElLSUNBZ0lHSWdiV0ZwYmw5aWJHOWphMEF3Q2dwdFlXbHVYMkpzYjJOclFEQTZDaUFnSUNCaUlHMWhhVzVmWW14dlkydEFNUW9LYldGcGJsOWliRzlqYTBBeE9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRiV1YwYUc5a0xYTmxiR1ZqZEc5eUxtRnNaMjh1ZEhNNk5Rb2dJQ0FnTHk4Z1kyeGhjM01nUTI5dWRISmhZM1JQYm1VZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQ0U5Q2lBZ0lDQmllaUJ0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBeE1Bb2dJQ0FnWWlCdFlXbHVYMkZpYVY5eWIzVjBhVzVuUURJS0NtMWhhVzVmWVdKcFgzSnZkWFJwYm1kQU1qb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMVzFsZEdodlpDMXpaV3hsWTNSdmNpNWhiR2R2TG5Sek9qVUtJQ0FnSUM4dklHTnNZWE56SUVOdmJuUnlZV04wVDI1bElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklFNXZUM0FLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdJVDBLSUNBZ0lHSjZJRzFoYVc1ZlkzSmxZWFJsWDA1dlQzQkFPQW9nSUNBZ1lpQnRZV2x1WDJOaGJHeGZUbTlQY0VBekNncHRZV2x1WDJOaGJHeGZUbTlQY0VBek9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRiV1YwYUc5a0xYTmxiR1ZqZEc5eUxtRnNaMjh1ZEhNNk5Rb2dJQ0FnTHk4Z1kyeGhjM01nUTI5dWRISmhZM1JQYm1VZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhobU5UbGxNMk5qTkNBdkx5QnRaWFJvYjJRZ0luUmxjM1FvS1dKdmIyd2lDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGpNbVU1TlRrMlpTQXZMeUJ0WlhSb2IyUWdJbk52YldWTlpYUm9iMlFvS1hWcGJuUTJOQ0lLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFppTkRoa05USXlJQzh2SUcxbGRHaHZaQ0FpZEdWemRGSmxabVZ5Wlc1alpWUjVjR1Z6S0NsMmIybGtJZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0J0WVhSamFDQnRZV2x1WDNSbGMzUmZjbTkxZEdWQU5DQnRZV2x1WDNOdmJXVk5aWFJvYjJSZmNtOTFkR1ZBTlNCdFlXbHVYM1JsYzNSU1pXWmxjbVZ1WTJWVWVYQmxjMTl5YjNWMFpVQTJDaUFnSUNCaUlHMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUEzQ2dwdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFOem9LSUNBZ0lHSWdiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRGtLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBNU9nb2dJQ0FnWWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1URUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TVRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExXMWxkR2h2WkMxelpXeGxZM1J2Y2k1aGJHZHZMblJ6T2pVS0lDQWdJQzh2SUdOc1lYTnpJRU52Ym5SeVlXTjBUMjVsSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdaWEp5Q2dwdFlXbHVYM1JsYzNSU1pXWmxjbVZ1WTJWVWVYQmxjMTl5YjNWMFpVQTJPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0YldWMGFHOWtMWE5sYkdWamRHOXlMbUZzWjI4dWRITTZNVE1LSUNBZ0lDOHZJSFJsYzNSU1pXWmxjbVZ1WTJWVWVYQmxjeWdwSUhzS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEZKbFptVnlaVzVqWlZSNWNHVnpDaUFnSUNCaUlHMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUEzQ2dwdFlXbHVYM052YldWTlpYUm9iMlJmY205MWRHVkFOVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFcxbGRHaHZaQzF6Wld4bFkzUnZjaTVoYkdkdkxuUnpPamtLSUNBZ0lDOHZJSE52YldWTlpYUm9iMlFvS1NCN0NpQWdJQ0JqWVd4c2MzVmlJSE52YldWTlpYUm9iMlFLSUNBZ0lHSWdiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURjS0NtMWhhVzVmZEdWemRGOXliM1YwWlVBME9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRiV1YwYUc5a0xYTmxiR1ZqZEc5eUxtRnNaMjh1ZEhNNk5nb2dJQ0FnTHk4Z2RHVnpkQ2dwSUhzS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEFvZ0lDQWdZaUJ0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU53b0tiV0ZwYmw5amNtVmhkR1ZmVG05UGNFQTRPZ29nSUNBZ1lpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFPUW9LYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1UQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzF0WlhSb2IyUXRjMlZzWldOMGIzSXVZV3huYnk1MGN6bzFDaUFnSUNBdkx5QmpiR0Z6Y3lCRGIyNTBjbUZqZEU5dVpTQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5Qk9iMDl3Q2lBZ0lDQTlQUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQTlQUW9nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQW9nSUNBZ1kyRnNiSE4xWWlCZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1VLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzF0WlhSb2IyUXRjMlZzWldOMGIzSXVZV3huYnk1MGN6bzZRMjl1ZEhKaFkzUlBibVV1ZEdWemRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblJsYzNRNkNpQWdJQ0JpSUhSbGMzUmZZbXh2WTJ0QU1Bb0tkR1Z6ZEY5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdGJXVjBhRzlrTFhObGJHVmpkRzl5TG1Gc1oyOHVkSE02TmdvZ0lDQWdMeThnZEdWemRDZ3BJSHNLSUNBZ0lHTmhiR3h6ZFdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRiV1YwYUc5a0xYTmxiR1ZqZEc5eUxtRnNaMjh1ZEhNNk9rTnZiblJ5WVdOMFQyNWxMblJsYzNRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExXMWxkR2h2WkMxelpXeGxZM1J2Y2k1aGJHZHZMblJ6T2pwRGIyNTBjbUZqZEU5dVpTNXpiMjFsVFdWMGFHOWtXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzI5dFpVMWxkR2h2WkRvS0lDQWdJR0lnYzI5dFpVMWxkR2h2WkY5aWJHOWphMEF3Q2dwemIyMWxUV1YwYUc5a1gySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXRaWFJvYjJRdGMyVnNaV04wYjNJdVlXeG5ieTUwY3pvNUNpQWdJQ0F2THlCemIyMWxUV1YwYUc5a0tDa2dld29nSUNBZ1kyRnNiSE4xWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXRaWFJvYjJRdGMyVnNaV04wYjNJdVlXeG5ieTUwY3pvNlEyOXVkSEpoWTNSUGJtVXVjMjl0WlUxbGRHaHZaQW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdGJXVjBhRzlrTFhObGJHVmpkRzl5TG1Gc1oyOHVkSE02T2tOdmJuUnlZV04wVDI1bExuUmxjM1JTWldabGNtVnVZMlZVZVhCbGMxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblJsYzNSU1pXWmxjbVZ1WTJWVWVYQmxjem9LSUNBZ0lHSWdkR1Z6ZEZKbFptVnlaVzVqWlZSNWNHVnpYMkpzYjJOclFEQUtDblJsYzNSU1pXWmxjbVZ1WTJWVWVYQmxjMTlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0YldWMGFHOWtMWE5sYkdWamRHOXlMbUZzWjI4dWRITTZNVE1LSUNBZ0lDOHZJSFJsYzNSU1pXWmxjbVZ1WTJWVWVYQmxjeWdwSUhzS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0YldWMGFHOWtMWE5sYkdWamRHOXlMbUZzWjI4dWRITTZPa052Ym5SeVlXTjBUMjVsTG5SbGMzUlNaV1psY21WdVkyVlVlWEJsY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFcxbGRHaHZaQzF6Wld4bFkzUnZjaTVoYkdkdkxuUnpPanBEYjI1MGNtRmpkRTl1WlM1MFpYTjBLQ2tnTFQ0Z2RXbHVkRFkwT2dwMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXRaWFJvYjJRdGMyVnNaV04wYjNJdVlXeG5ieTUwY3pvNlEyOXVkSEpoWTNSUGJtVXVkR1Z6ZERvS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdGJXVjBhRzlrTFhObGJHVmpkRzl5TG1Gc1oyOHVkSE02T2tOdmJuUnlZV04wVDI1bExuUmxjM1JmWW14dlkydEFNQW9LZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdGJXVjBhRzlrTFhObGJHVmpkRzl5TG1Gc1oyOHVkSE02T2tOdmJuUnlZV04wVDI1bExuUmxjM1JmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFcxbGRHaHZaQzF6Wld4bFkzUnZjaTVoYkdkdkxuUnpPamNLSUNBZ0lDOHZJSEpsZEhWeWJpQnRaWFJvYjJSVFpXeGxZM1J2Y2loRGIyNTBjbUZqZEZSM2J5NXdjbTkwYjNSNWNHVXVjMjl0WlUxbGRHaHZaQ2tnUFQwOUlHMWxkR2h2WkZObGJHVmpkRzl5S0NkeVpXNWhiV1ZrVTI5dFpVMWxkR2h2WkNncGRtOXBaQ2NwQ2lBZ0lDQmllWFJsWTE4eElDOHZJRzFsZEdodlpDQWljbVZ1WVcxbFpGTnZiV1ZOWlhSb2IyUW9LWFp2YVdRaUNpQWdJQ0JpZVhSbFkxOHhJQzh2SUcxbGRHaHZaQ0FpY21WdVlXMWxaRk52YldWTlpYUm9iMlFvS1hadmFXUWlDaUFnSUNBOVBRb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRiV1YwYUc5a0xYTmxiR1ZqZEc5eUxtRnNaMjh1ZEhNNk9rTnZiblJ5WVdOMFQyNWxMbk52YldWTlpYUm9iMlFvS1NBdFBpQjFhVzUwTmpRNkNuUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMVzFsZEdodlpDMXpaV3hsWTNSdmNpNWhiR2R2TG5Sek9qcERiMjUwY21GamRFOXVaUzV6YjIxbFRXVjBhRzlrT2dvZ0lDQWdZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxdFpYUm9iMlF0YzJWc1pXTjBiM0l1WVd4bmJ5NTBjem82UTI5dWRISmhZM1JQYm1VdWMyOXRaVTFsZEdodlpGOWliRzlqYTBBd0NncDBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzF0WlhSb2IyUXRjMlZzWldOMGIzSXVZV3huYnk1MGN6bzZRMjl1ZEhKaFkzUlBibVV1YzI5dFpVMWxkR2h2WkY5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdGJXVjBhRzlrTFhObGJHVmpkRzl5TG1Gc1oyOHVkSE02TVRBS0lDQWdJQzh2SUhKbGRIVnliaUJ6YjIxbFEyOXVjM1FLSUNBZ0lIQjFjMmhwYm5RZ01USXpDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzF0WlhSb2IyUXRjMlZzWldOMGIzSXVZV3huYnk1MGN6bzZRMjl1ZEhKaFkzUlBibVV1ZEdWemRGSmxabVZ5Wlc1alpWUjVjR1Z6S0NrZ0xUNGdkbTlwWkRvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRiV1YwYUc5a0xYTmxiR1ZqZEc5eUxtRnNaMjh1ZEhNNk9rTnZiblJ5WVdOMFQyNWxMblJsYzNSU1pXWmxjbVZ1WTJWVWVYQmxjem9LSUNBZ0lHSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0YldWMGFHOWtMWE5sYkdWamRHOXlMbUZzWjI4dWRITTZPa052Ym5SeVlXTjBUMjVsTG5SbGMzUlNaV1psY21WdVkyVlVlWEJsYzE5aWJHOWphMEF3Q2dwMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXRaWFJvYjJRdGMyVnNaV04wYjNJdVlXeG5ieTUwY3pvNlEyOXVkSEpoWTNSUGJtVXVkR1Z6ZEZKbFptVnlaVzVqWlZSNWNHVnpYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzF0WlhSb2IyUXRjMlZzWldOMGIzSXVZV3huYnk1MGN6b3hOUW9nSUNBZ0x5OGdiV1YwYUc5a1UyVnNaV04wYjNJb1EyOXVkSEpoWTNSVWQyOHVjSEp2ZEc5MGVYQmxMbkpsWm1WeVpXNWpaVlI1Y0dWelNXNWtaWGdwSUQwOVBRb2dJQ0FnWW5sMFpXTmZNaUF2THlCdFpYUm9iMlFnSW5KbFptVnlaVzVqWlZSNWNHVnpTVzVrWlhnb2NHRjVMR0Z6YzJWMExHRmpZMjkxYm5Rc1lYQndiR2xqWVhScGIyNHNZWEJ3YkNsMmIybGtJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0YldWMGFHOWtMWE5sYkdWamRHOXlMbUZzWjI4dWRITTZNVFlLSUNBZ0lDOHZJRzFsZEdodlpGTmxiR1ZqZEc5eUtDZHlaV1psY21WdVkyVlVlWEJsYzBsdVpHVjRLSEJoZVN4aGMzTmxkQ3hoWTJOdmRXNTBMR0Z3Y0d4cFkyRjBhVzl1TEdGd2NHd3BkbTlwWkNjcExBb2dJQ0FnWW5sMFpXTmZNaUF2THlCdFpYUm9iMlFnSW5KbFptVnlaVzVqWlZSNWNHVnpTVzVrWlhnb2NHRjVMR0Z6YzJWMExHRmpZMjkxYm5Rc1lYQndiR2xqWVhScGIyNHNZWEJ3YkNsMmIybGtJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0YldWMGFHOWtMWE5sYkdWamRHOXlMbUZzWjI4dWRITTZNVFV0TVRZS0lDQWdJQzh2SUcxbGRHaHZaRk5sYkdWamRHOXlLRU52Ym5SeVlXTjBWSGR2TG5CeWIzUnZkSGx3WlM1eVpXWmxjbVZ1WTJWVWVYQmxjMGx1WkdWNEtTQTlQVDBLSUNBZ0lDOHZJQ0FnYldWMGFHOWtVMlZzWldOMGIzSW9KM0psWm1WeVpXNWpaVlI1Y0dWelNXNWtaWGdvY0dGNUxHRnpjMlYwTEdGalkyOTFiblFzWVhCd2JHbGpZWFJwYjI0c1lYQndiQ2wyYjJsa0p5a3NDaUFnSUNBOVBRb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRiV1YwYUc5a0xYTmxiR1ZqZEc5eUxtRnNaMjh1ZEhNNk1UUXRNVGNLSUNBZ0lDOHZJR0Z6YzJWeWRDZ0tJQ0FnSUM4dklDQWdiV1YwYUc5a1UyVnNaV04wYjNJb1EyOXVkSEpoWTNSVWQyOHVjSEp2ZEc5MGVYQmxMbkpsWm1WeVpXNWpaVlI1Y0dWelNXNWtaWGdwSUQwOVBRb2dJQ0FnTHk4Z0lDQWdJRzFsZEdodlpGTmxiR1ZqZEc5eUtDZHlaV1psY21WdVkyVlVlWEJsYzBsdVpHVjRLSEJoZVN4aGMzTmxkQ3hoWTJOdmRXNTBMR0Z3Y0d4cFkyRjBhVzl1TEdGd2NHd3BkbTlwWkNjcExBb2dJQ0FnTHk4Z0tRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzF0WlhSb2IyUXRjMlZzWldOMGIzSXVZV3huYnk1MGN6b3hPUW9nSUNBZ0x5OGdiV1YwYUc5a1UyVnNaV04wYjNJb1EyOXVkSEpoWTNSVWQyOHVjSEp2ZEc5MGVYQmxMbkpsWm1WeVpXNWpaVlI1Y0dWelZtRnNkV1VwSUQwOVBRb2dJQ0FnWW5sMFpXTmZNeUF2THlCdFpYUm9iMlFnSW5KbFptVnlaVzVqWlZSNWNHVnpWbUZzZFdVb2NHRjVMSFZwYm5RMk5DeGhaR1J5WlhOekxIVnBiblEyTkN4aGNIQnNLWFp2YVdRaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXRaWFJvYjJRdGMyVnNaV04wYjNJdVlXeG5ieTUwY3pveU1Bb2dJQ0FnTHk4Z2JXVjBhRzlrVTJWc1pXTjBiM0lvSjNKbFptVnlaVzVqWlZSNWNHVnpWbUZzZFdVb2NHRjVMSFZwYm5RMk5DeGhaR1J5WlhOekxIVnBiblEyTkN4aGNIQnNLWFp2YVdRbktTd0tJQ0FnSUdKNWRHVmpYek1nTHk4Z2JXVjBhRzlrSUNKeVpXWmxjbVZ1WTJWVWVYQmxjMVpoYkhWbEtIQmhlU3gxYVc1ME5qUXNZV1JrY21WemN5eDFhVzUwTmpRc1lYQndiQ2wyYjJsa0lnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRiV1YwYUc5a0xYTmxiR1ZqZEc5eUxtRnNaMjh1ZEhNNk1Ua3RNakFLSUNBZ0lDOHZJRzFsZEdodlpGTmxiR1ZqZEc5eUtFTnZiblJ5WVdOMFZIZHZMbkJ5YjNSdmRIbHdaUzV5WldabGNtVnVZMlZVZVhCbGMxWmhiSFZsS1NBOVBUMEtJQ0FnSUM4dklDQWdiV1YwYUc5a1UyVnNaV04wYjNJb0ozSmxabVZ5Wlc1alpWUjVjR1Z6Vm1Gc2RXVW9jR0Y1TEhWcGJuUTJOQ3hoWkdSeVpYTnpMSFZwYm5RMk5DeGhjSEJzS1hadmFXUW5LU3dLSUNBZ0lEMDlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzF0WlhSb2IyUXRjMlZzWldOMGIzSXVZV3huYnk1MGN6b3hPQzB5TVFvZ0lDQWdMeThnWVhOelpYSjBLQW9nSUNBZ0x5OGdJQ0J0WlhSb2IyUlRaV3hsWTNSdmNpaERiMjUwY21GamRGUjNieTV3Y205MGIzUjVjR1V1Y21WbVpYSmxibU5sVkhsd1pYTldZV3gxWlNrZ1BUMDlDaUFnSUNBdkx5QWdJQ0FnYldWMGFHOWtVMlZzWldOMGIzSW9KM0psWm1WeVpXNWpaVlI1Y0dWelZtRnNkV1VvY0dGNUxIVnBiblEyTkN4aFpHUnlaWE56TEhWcGJuUTJOQ3hoY0hCc0tYWnZhV1FuS1N3S0lDQWdJQzh2SUNrS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRiV1YwYUc5a0xYTmxiR1ZqZEc5eUxtRnNaMjh1ZEhNNk9rTnZiblJ5WVdOMFQyNWxMbDlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpTZ3BJQzArSUhadmFXUTZDbDlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpUb0tJQ0FnSUdJZ1gxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsWDJKc2IyTnJRREFLQ2w5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVjlpYkc5amEwQXdPZ29nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JpSUcxaGFXNWZZbXh2WTJ0QU1Bb0tiV0ZwYmw5aWJHOWphMEF3T2dvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBQ0FBRW1CQVFWSDN4MUJFT01aUE1FYldJS3hBUkdsaEdTUWdBQVFnQUFNUnNpRTBFQVVFSUFBREVaSWhKRU1SZ2lFMEVBUGtJQUFEWWFBSUFFOVo0OHhJQUV3dWxaYm9BRWEwalZJazhEamdNQUZnQVFBQXBDQUFCQ0FBQkNBQUFBaUFCRFF2L3ppQUF2UXYvdGlBQVZRdi9uUXYvbk1Sa2lFakVZSWhJUVJJZ0FSU05EUWdBQWlBQWtnQUVBSWs4Q1ZDaFBBVkN3STBOQ0FBQ0lBQmNXS0U4QlVMQWpRMElBQUlnQUR5TkRRZ0FBS1NrU2lVSUFBSUY3aVVJQUFDb3FFa1FyS3hKRWlVSUFBSWs9IiwiY2xlYXIiOiJDMElBQUlFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
