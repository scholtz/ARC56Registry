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

namespace Arc56.Generated.algorandfoundation.puya.MutableParams2_2c2bdf4e
{


    public class MutableParams2Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MutableParams2Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task TestArrayRebinding(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 106, 196, 165, 87 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestArrayRebinding_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 106, 196, 165, 87 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTXV0YWJsZVBhcmFtczIiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoidGVzdF9hcnJheV9yZWJpbmRpbmciLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBeElEQUtJQ0FnSUM4dklHRnlZelJmZEhsd1pYTXZiWFYwWVdKc1pWOXdZWEpoYlhNeUxuQjVPalFLSUNBZ0lDOHZJR05zWVhOeklFMTFkR0ZpYkdWUVlYSmhiWE15S0dGeVl6UXVRVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFEVUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEWmhZelJoTlRVM0lDOHZJRzFsZEdodlpDQWlkR1Z6ZEY5aGNuSmhlVjl5WldKcGJtUnBibWNvS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgzUmxjM1JmWVhKeVlYbGZjbVZpYVc1a2FXNW5YM0p2ZFhSbFFETUtJQ0FnSUdWeWNnb0tiV0ZwYmw5MFpYTjBYMkZ5Y21GNVgzSmxZbWx1WkdsdVoxOXliM1YwWlVBek9nb2dJQ0FnTHk4Z1lYSmpORjkwZVhCbGN5OXRkWFJoWW14bFgzQmhjbUZ0Y3pJdWNIazZOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQW1KZ29nSUNBZ1lYTnpaWEowQ2lBZ0lDQmlJSFJsYzNSZllYSnlZWGxmY21WaWFXNWthVzVuQ2dwdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFEVTZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1JmWTJGelpYTXVZWEpqTkY5MGVYQmxjeTV0ZFhSaFlteGxYM0JoY21GdGN6SXVUWFYwWVdKc1pWQmhjbUZ0Y3pJdWRHVnpkRjloY25KaGVWOXlaV0pwYm1ScGJtZGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AwWlhOMFgyRnljbUY1WDNKbFltbHVaR2x1WnpvS0lDQWdJQzh2SUdGeVl6UmZkSGx3WlhNdmJYVjBZV0pzWlY5d1lYSmhiWE15TG5CNU9qY0tJQ0FnSUM4dklHRWdQU0JoY21NMExrUjVibUZ0YVdOQ2VYUmxjeWd3S1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01UQXdDaUFnSUNBdkx5QmhjbU0wWDNSNWNHVnpMMjExZEdGaWJHVmZjR0Z5WVcxek1pNXdlVG80Q2lBZ0lDQXZMeUJ6Wld4bUxtMWhlV0psWDIxdlpHbG1lVjloY25KaGVTaGhMQ0JoYzNOcFoyNWZiRzlqWVd3OVZISjFaU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCallXeHNjM1ZpSUcxaGVXSmxYMjF2WkdsbWVWOWhjbkpoZVFvZ0lDQWdMeThnWVhKak5GOTBlWEJsY3k5dGRYUmhZbXhsWDNCaGNtRnRjekl1Y0hrNk9Rb2dJQ0FnTHk4Z1lYTnpaWEowSUdFZ1BUMGdZWEpqTkM1RWVXNWhiV2xqUW5sMFpYTW9NQ3dnTVNrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01ESXdNREF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJoY21NMFgzUjVjR1Z6TDIxMWRHRmliR1ZmY0dGeVlXMXpNaTV3ZVRveE1Rb2dJQ0FnTHk4Z1lTQTlJR0Z5WXpRdVJIbHVZVzFwWTBKNWRHVnpLREVwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBeE1ERUtJQ0FnSUM4dklHRnlZelJmZEhsd1pYTXZiWFYwWVdKc1pWOXdZWEpoYlhNeUxuQjVPakV5Q2lBZ0lDQXZMeUJ6Wld4bUxtMWhlV0psWDIxdlpHbG1lVjloY25KaGVTaGhMQ0JoYzNOcFoyNWZiRzlqWVd3OVJtRnNjMlVwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1kyRnNiSE4xWWlCdFlYbGlaVjl0YjJScFpubGZZWEp5WVhrS0lDQWdJQzh2SUdGeVl6UmZkSGx3WlhNdmJYVjBZV0pzWlY5d1lYSmhiWE15TG5CNU9qRXpDaUFnSUNBdkx5QmhjM05sY25RZ1lTQTlQU0JoY21NMExrUjVibUZ0YVdOQ2VYUmxjeWd4TENBME1pd2dOQ2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURNd01USmhNRFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJR0Z5WXpSZmRIbHdaWE12YlhWMFlXSnNaVjl3WVhKaGJYTXlMbkI1T2pVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTVoY21NMFgzUjVjR1Z6TG0xMWRHRmliR1ZmY0dGeVlXMXpNaTVOZFhSaFlteGxVR0Z5WVcxek1pNXRZWGxpWlY5dGIyUnBabmxmWVhKeVlYa29ZVG9nWW5sMFpYTXNJR0Z6YzJsbmJsOXNiMk5oYkRvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3pvS2JXRjVZbVZmYlc5a2FXWjVYMkZ5Y21GNU9nb2dJQ0FnTHk4Z1lYSmpORjkwZVhCbGN5OXRkWFJoWW14bFgzQmhjbUZ0Y3pJdWNIazZNVFV0TVRZS0lDQWdJQzh2SUVCemRXSnliM1YwYVc1bENpQWdJQ0F2THlCa1pXWWdiV0Y1WW1WZmJXOWthV1o1WDJGeWNtRjVLSE5sYkdZc0lHRTZJR0Z5WXpRdVJIbHVZVzFwWTBKNWRHVnpMQ0FxTENCaGMzTnBaMjVmYkc5allXdzZJR0p2YjJ3cElDMCtJRTV2Ym1VNklDQWpJSFl3Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMeThnWVhKak5GOTBlWEJsY3k5dGRYUmhZbXhsWDNCaGNtRnRjekl1Y0hrNk1UY0tJQ0FnSUM4dklHbG1JR0Z6YzJsbmJsOXNiMk5oYkRvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZbm9nYldGNVltVmZiVzlrYVdaNVgyRnljbUY1WDJWc2MyVmZZbTlrZVVBeE1Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJQzh2SUdGeVl6UmZkSGx3WlhNdmJYVjBZV0pzWlY5d1lYSmhiWE15TG5CNU9qRTRDaUFnSUNBdkx5QmhMbUZ3Y0dWdVpDaGhjbU0wTGtKNWRHVW9NU2twSUNBaklIWXhPaUJ0YjJScFpua2diM1YwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdjM2RoY0FvZ0lDQWdjbVZ3YkdGalpUSWdNQW9nSUNBZ0x5OGdZWEpqTkY5MGVYQmxjeTl0ZFhSaFlteGxYM0JoY21GdGN6SXVjSGs2TVRnS0lDQWdJQzh2SUdFdVlYQndaVzVrS0dGeVl6UXVRbmwwWlNneEtTa2dJQ01nZGpFNklHMXZaR2xtZVNCdmRYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJKMWNua2dMVElLSUNBZ0lDOHZJR0Z5WXpSZmRIbHdaWE12YlhWMFlXSnNaVjl3WVhKaGJYTXlMbkI1T2pJeENpQWdJQ0F2THlCaElEMGdZWEpqTkM1RWVXNWhiV2xqUW5sMFpYTW9NU3dnTWl3Z05Da2dJQ01nZGpRNklHeHZZMkZzSUc5dWJIa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNRE13TVRBeU1EUUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJQzB5Q2dwdFlYbGlaVjl0YjJScFpubGZZWEp5WVhsZllXWjBaWEpmYVdaZlpXeHpaVUF4TXpvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQXZMeUJoY21NMFgzUjVjR1Z6TDIxMWRHRmliR1ZmY0dGeVlXMXpNaTV3ZVRveU5Rb2dJQ0FnTHk4Z1lTNWhjSEJsYm1Rb1lYSmpOQzVDZVhSbEtEUXBLU0FnSXlCMk5qb2diVzlrYVdaNUlHOTFkQ0JKUmlCdWIzUWdZaUJGVEZORklHeHZZMkZzSUc5dWJIa0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCemQyRndDaUFnSUNCeVpYQnNZV05sTWlBd0NpQWdJQ0F2THlCaGNtTTBYM1I1Y0dWekwyMTFkR0ZpYkdWZmNHRnlZVzF6TWk1d2VUb3lOUW9nSUNBZ0x5OGdZUzVoY0hCbGJtUW9ZWEpqTkM1Q2VYUmxLRFFwS1NBZ0l5QjJOam9nYlc5a2FXWjVJRzkxZENCSlJpQnViM1FnWWlCRlRGTkZJR3h2WTJGc0lHOXViSGtLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgySjFjbmtnTFRJS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQmllaUJ0WVhsaVpWOXRiMlJwWm5sZllYSnlZWGxmWVdaMFpYSmZhV1pmWld4elpVQXhOUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtDbTFoZVdKbFgyMXZaR2xtZVY5aGNuSmhlVjloWm5SbGNsOXBabDlsYkhObFFERTFPZ29nSUNBZ2NtVjBjM1ZpQ2dwdFlYbGlaVjl0YjJScFpubGZZWEp5WVhsZlpXeHpaVjlpYjJSNVFERXdPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUM4dklHRnlZelJmZEhsd1pYTXZiWFYwWVdKc1pWOXdZWEpoYlhNeUxuQjVPakl6Q2lBZ0lDQXZMeUJoTG1Gd2NHVnVaQ2hoY21NMExrSjVkR1VvTkRJcEtTQWdJeUIyTlRvZ2JXOWthV1o1SUc5MWRBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUhOM1lYQUtJQ0FnSUhKbGNHeGhZMlV5SURBS0lDQWdJQzh2SUdGeVl6UmZkSGx3WlhNdmJYVjBZV0pzWlY5d1lYSmhiWE15TG5CNU9qSXpDaUFnSUNBdkx5QmhMbUZ3Y0dWdVpDaGhjbU0wTGtKNWRHVW9ORElwS1NBZ0l5QjJOVG9nYlc5a2FXWjVJRzkxZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TW1FS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SUMweUNpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJR0lnYldGNVltVmZiVzlrYVdaNVgyRnljbUY1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVE1LIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBQ0FRQXhHMEVBR0lBRWFzU2xWellhQUk0QkFBRUFNUmtVTVJnUVJFSUFDREVaRkRFWUZCQkRnQU1BQVFBaWlBQWNnQVFBQWdBQkVrU0FBd0FCQVNPSUFBdUFCUUFEQVNvRUVrUWlRNG9DQVNNaWkvOUJBRVNML2lOWklnZ1dWd1lBaS81TVhBQ0FBUUZRalA2QUJRQURBUUlFSTR3QmkvNk1BSXoraS80aldTSUlGbGNHQUl2K1RGd0FnQUVFVUl6K2l3RkJBQVNML293QWlZditJMWtpQ0JaWEJnQ0wva3hjQUlBQktsQkpqUDZNQUVML3hnPT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjk5LCJtaW5vciI6OTksInBhdGNoIjo5OSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
