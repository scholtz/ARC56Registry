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

namespace Arc56.Generated.algorandfoundation.devportal_code_examples.MyCounter_f3a03156
{


    //
    // A contract that maintains a per-account counter in local state
    //Accounts must opt in to use the counter
    //
    public class MyCounterProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MyCounterProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Initialize the counter when an account opts in
        ///</summary>
        public async Task OptIn(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 41, 49, 77, 149 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptIn_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 41, 49, 77, 149 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Increment the counter for the sender and return its new value
        ///</summary>
        public async Task<ulong> IncrementMyCounter(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 230, 219, 237, 127 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IncrementMyCounter_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 230, 219, 237, 127 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTXlDb3VudGVyIiwiZGVzYyI6IkEgY29udHJhY3QgdGhhdCBtYWludGFpbnMgYSBwZXItYWNjb3VudCBjb3VudGVyIGluIGxvY2FsIHN0YXRlXG5BY2NvdW50cyBtdXN0IG9wdCBpbiB0byB1c2UgdGhlIGNvdW50ZXIiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoib3B0SW4iLCJkZXNjIjoiSW5pdGlhbGl6ZSB0aGUgY291bnRlciB3aGVuIGFuIGFjY291bnQgb3B0cyBpbiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk9wdEluIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaW5jcmVtZW50TXlDb3VudGVyIiwiZGVzYyI6IkluY3JlbWVudCB0aGUgY291bnRlciBmb3IgdGhlIHNlbmRlciBhbmQgcmV0dXJuIGl0cyBuZXcgdmFsdWUiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiVGhlIG5ldyBjb3VudGVyIHZhbHVlIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls4Nl0sImVycm9yTWVzc2FnZSI6IkFjY291bnQgbXVzdCBvcHQgaW4gdG8gY29udHJhY3QgZmlyc3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3M10sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AgJiYgY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTFdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wICYmIGNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2Ml0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE9wdEluICYmIGNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MiwxMDZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBMb2NhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0NpQWdJQ0JpZVhSbFkySnNiMk5ySUNKdGVWOWpiM1Z1ZEdWeUlnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxSmxabVZ5Wlc1alpVRmpZMjkxYm5SQmNIQXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNUW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUUxNVEyOTFiblJsY2lCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQTJDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRNamt6TVRSa09UVWdNSGhsTm1SaVpXUTNaaUF2THlCdFpYUm9iMlFnSW05d2RFbHVLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnBibU55WlcxbGJuUk5lVU52ZFc1MFpYSW9LWFZwYm5RMk5DSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZmIzQjBTVzVmY205MWRHVkFNeUJ0WVdsdVgybHVZM0psYldWdWRFMTVRMjkxYm5SbGNsOXliM1YwWlVBMENpQWdJQ0JsY25JS0NtMWhhVzVmYVc1amNtVnRaVzUwVFhsRGIzVnVkR1Z5WDNKdmRYUmxRRFE2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VW1WbVpYSmxibU5sUVdOamIzVnVkRUZ3Y0M5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNM0NpQWdJQ0F2THlCd2RXSnNhV01nYVc1amNtVnRaVzUwVFhsRGIzVnVkR1Z5S0NrNklIVnBiblEyTkNCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdiWFZ6ZENCaVpTQk9iMDl3SUNZbUlHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lHSWdhVzVqY21WdFpXNTBUWGxEYjNWdWRHVnlDZ3B0WVdsdVgyOXdkRWx1WDNKdmRYUmxRRE02Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VW1WbVpYSmxibU5sUVdOamIzVnVkRUZ3Y0M5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2dZV3hzYjNkQlkzUnBiMjV6T2lBblQzQjBTVzRuSUgwcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z1QzQjBTVzRLSUNBZ0lEMDlDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdKaVlLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYlhWemRDQmlaU0JQY0hSSmJpQW1KaUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JpSUc5d2RFbHVDZ3B0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBMk9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxSmxabVZ5Wlc1alpVRmpZMjkxYm5SQmNIQXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNUW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUUxNVEyOTFiblJsY2lCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdjbVYwZFhKdUlDOHZJRzl1SUdWeWNtOXlPaUJQYmtOdmJYQnNaWFJwYjI0Z2JYVnpkQ0JpWlNCT2IwOXdJQ1ltSUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCamNtVmhkR2x1WndvS0NpOHZJR052Ym5SeVlXTjBjeTlTWldabGNtVnVZMlZCWTJOdmRXNTBRWEJ3TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2sxNVEyOTFiblJsY2k1dmNIUkpibHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q205d2RFbHVPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMUpsWm1WeVpXNWpaVUZqWTI5MWJuUkJjSEF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TUFvZ0lDQWdMeThnZEdocGN5NXRlVU52ZFc1MFpYSW9WSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVWdQU0F3Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVbVZtWlhKbGJtTmxRV05qYjNWdWRFRndjQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl6Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdiWGxEYjNWdWRHVnlJRDBnVEc5allXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFuYlhsZlkyOTFiblJsY2ljZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltMTVYMk52ZFc1MFpYSWlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVbVZtWlhKbGJtTmxRV05qYjNWdWRFRndjQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak13Q2lBZ0lDQXZMeUIwYUdsekxtMTVRMjkxYm5SbGNpaFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTQTlJREFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVbVZtWlhKbGJtTmxRV05qYjNWdWRFRndjQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakk0Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ1lXeHNiM2RCWTNScGIyNXpPaUFuVDNCMFNXNG5JSDBwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZMjl1ZEhKaFkzUnpMMUpsWm1WeVpXNWpaVUZqWTI5MWJuUkJjSEF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VFhsRGIzVnVkR1Z5TG1sdVkzSmxiV1Z1ZEUxNVEyOTFiblJsY2x0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtbHVZM0psYldWdWRFMTVRMjkxYm5SbGNqb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVNaV1psY21WdVkyVkJZMk52ZFc1MFFYQndMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNemdLSUNBZ0lDOHZJR0Z6YzJWeWRDaFVlRzR1YzJWdVpHVnlMbWx6VDNCMFpXUkpiaWhIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVTV1FwTENBblFXTmpiM1Z1ZENCdGRYTjBJRzl3ZENCcGJpQjBieUJqYjI1MGNtRmpkQ0JtYVhKemRDY3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRndjRjl2Y0hSbFpGOXBiZ29nSUNBZ1lYTnpaWEowSUM4dklFRmpZMjkxYm5RZ2JYVnpkQ0J2Y0hRZ2FXNGdkRzhnWTI5dWRISmhZM1FnWm1seWMzUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVNaV1psY21WdVkyVkJZMk52ZFc1MFFYQndMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOREFLSUNBZ0lDOHZJSFJvYVhNdWJYbERiM1Z1ZEdWeUtGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbElEMGdkR2hwY3k1dGVVTnZkVzUwWlhJb1ZIaHVMbk5sYm1SbGNpa3VkbUZzZFdVZ0t5QXhDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFKbFptVnlaVzVqWlVGalkyOTFiblJCY0hBdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU13b2dJQ0FnTHk4Z2NIVmliR2xqSUcxNVEyOTFiblJsY2lBOUlFeHZZMkZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR3RsZVRvZ0oyMTVYMk52ZFc1MFpYSW5JSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p0ZVY5amIzVnVkR1Z5SWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFKbFptVnlaVzVqWlVGalkyOTFiblJCY0hBdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME1Bb2dJQ0FnTHk4Z2RHaHBjeTV0ZVVOdmRXNTBaWElvVkhodUxuTmxibVJsY2lrdWRtRnNkV1VnUFNCMGFHbHpMbTE1UTI5MWJuUmxjaWhVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU0FySURFS0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJNYjJOaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNzS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlTWldabGNtVnVZMlZCWTJOdmRXNTBRWEJ3TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpNS0lDQWdJQzh2SUhCMVlteHBZeUJ0ZVVOdmRXNTBaWElnUFNCTWIyTmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkdGVWOWpiM1Z1ZEdWeUp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWliWGxmWTI5MWJuUmxjaUlLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlTWldabGNtVnVZMlZCWTJOdmRXNTBRWEJ3TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRBS0lDQWdJQzh2SUhSb2FYTXViWGxEYjNWdWRHVnlLRlI0Ymk1elpXNWtaWElwTG5aaGJIVmxJRDBnZEdocGN5NXRlVU52ZFc1MFpYSW9WSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVWdLeUF4Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGd2NGOXNiMk5oYkY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVNaV1psY21WdVkyVkJZMk52ZFc1MFFYQndMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORElLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TG0xNVEyOTFiblJsY2loVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVNaV1psY21WdVkyVkJZMk52ZFc1MFFYQndMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNak1LSUNBZ0lDOHZJSEIxWW14cFl5QnRlVU52ZFc1MFpYSWdQU0JNYjJOaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ2R0ZVY5amIzVnVkR1Z5SnlCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWJYbGZZMjkxYm5SbGNpSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVNaV1psY21WdVkyVkJZMk52ZFc1MFFYQndMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORElLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TG0xNVEyOTFiblJsY2loVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlFvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRXh2WTJGc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVbVZtWlhKbGJtTmxRV05qYjNWdWRFRndjQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0zQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdhVzVqY21WdFpXNTBUWGxEYjNWdWRHVnlLQ2s2SUhWcGJuUTJOQ0I3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFDQVFBbUFRcHRlVjlqYjNWdWRHVnlNUnRCQUN1Q0FnUXBNVTJWQk9iYjdYODJHZ0NPQWdBTEFBRUFNUmtVTVJnUVJFSUFHakVaSWhJeEdCQkVRZ0FJTVJrVU1SZ1VFRU14QUNnalppSkRNUUF5Q0dGRU1RQWpLR05FSWdneEFDaFBBbVl4QUNNb1kwUVdnQVFWSDN4MVRGQ3dJa009IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
