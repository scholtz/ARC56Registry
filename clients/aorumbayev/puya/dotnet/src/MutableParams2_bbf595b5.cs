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

namespace Arc56.Generated.aorumbayev.puya.MutableParams2_bbf595b5
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTXV0YWJsZVBhcmFtczIiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoidGVzdF9hcnJheV9yZWJpbmRpbmciLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyOF0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ1XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzFdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERUtJQ0FnSUM4dklHRnlZelJmZEhsd1pYTXZiWFYwWVdKc1pWOXdZWEpoYlhNeUxuQjVPalFLSUNBZ0lDOHZJR05zWVhOeklFMTFkR0ZpYkdWUVlYSmhiWE15S0dGeVl6UXVRVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMkpoY21WZmNtOTFkR2x1WjBBMkNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnMllXTTBZVFUxTnlBdkx5QnRaWFJvYjJRZ0luUmxjM1JmWVhKeVlYbGZjbVZpYVc1a2FXNW5LQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5MFpYTjBYMkZ5Y21GNVgzSmxZbWx1WkdsdVoxOXliM1YwWlVBekNncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVEE2Q2lBZ0lDQXZMeUJoY21NMFgzUjVjR1Z6TDIxMWRHRmliR1ZmY0dGeVlXMXpNaTV3ZVRvMENpQWdJQ0F2THlCamJHRnpjeUJOZFhSaFlteGxVR0Z5WVcxek1paGhjbU0wTGtGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjM1JmWVhKeVlYbGZjbVZpYVc1a2FXNW5YM0p2ZFhSbFFETTZDaUFnSUNBdkx5QmhjbU0wWDNSNWNHVnpMMjExZEdGaWJHVmZjR0Z5WVcxek1pNXdlVG8xQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUhSbGMzUmZZWEp5WVhsZmNtVmlhVzVrYVc1bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJKaGNtVmZjbTkxZEdsdVowQTJPZ29nSUNBZ0x5OGdZWEpqTkY5MGVYQmxjeTl0ZFhSaFlteGxYM0JoY21GdGN6SXVjSGs2TkFvZ0lDQWdMeThnWTJ4aGMzTWdUWFYwWVdKc1pWQmhjbUZ0Y3pJb1lYSmpOQzVCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TUFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnWTNKbFlYUnBibWNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMbUZ5WXpSZmRIbHdaWE11YlhWMFlXSnNaVjl3WVhKaGJYTXlMazExZEdGaWJHVlFZWEpoYlhNeUxuUmxjM1JmWVhKeVlYbGZjbVZpYVc1a2FXNW5LQ2tnTFQ0Z2RtOXBaRG9LZEdWemRGOWhjbkpoZVY5eVpXSnBibVJwYm1jNkNpQWdJQ0F2THlCaGNtTTBYM1I1Y0dWekwyMTFkR0ZpYkdWZmNHRnlZVzF6TWk1d2VUbzNDaUFnSUNBdkx5QmhJRDBnWVhKak5DNUVlVzVoYldsalFubDBaWE1vTUNrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01ERXdNQW9nSUNBZ0x5OGdZWEpqTkY5MGVYQmxjeTl0ZFhSaFlteGxYM0JoY21GdGN6SXVjSGs2T0FvZ0lDQWdMeThnYzJWc1ppNXRZWGxpWlY5dGIyUnBabmxmWVhKeVlYa29ZU3dnWVhOemFXZHVYMnh2WTJGc1BWUnlkV1VwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1kyRnNiSE4xWWlCdFlYbGlaVjl0YjJScFpubGZZWEp5WVhrS0lDQWdJQzh2SUdGeVl6UmZkSGx3WlhNdmJYVjBZV0pzWlY5d1lYSmhiWE15TG5CNU9qa0tJQ0FnSUM4dklHRnpjMlZ5ZENCaElEMDlJR0Z5WXpRdVJIbHVZVzFwWTBKNWRHVnpLREFzSURFcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXlNREF3TVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnWVhKak5GOTBlWEJsY3k5dGRYUmhZbXhsWDNCaGNtRnRjekl1Y0hrNk1URUtJQ0FnSUM4dklHRWdQU0JoY21NMExrUjVibUZ0YVdOQ2VYUmxjeWd4S1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01UQXhDaUFnSUNBdkx5QmhjbU0wWDNSNWNHVnpMMjExZEdGaWJHVmZjR0Z5WVcxek1pNXdlVG94TWdvZ0lDQWdMeThnYzJWc1ppNXRZWGxpWlY5dGIyUnBabmxmWVhKeVlYa29ZU3dnWVhOemFXZHVYMnh2WTJGc1BVWmhiSE5sS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHTmhiR3h6ZFdJZ2JXRjVZbVZmYlc5a2FXWjVYMkZ5Y21GNUNpQWdJQ0F2THlCaGNtTTBYM1I1Y0dWekwyMTFkR0ZpYkdWZmNHRnlZVzF6TWk1d2VUb3hNd29nSUNBZ0x5OGdZWE56WlhKMElHRWdQVDBnWVhKak5DNUVlVzVoYldsalFubDBaWE1vTVN3Z05ESXNJRFFwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBek1ERXlZVEEwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG1GeVl6UmZkSGx3WlhNdWJYVjBZV0pzWlY5d1lYSmhiWE15TGsxMWRHRmliR1ZRWVhKaGJYTXlMbTFoZVdKbFgyMXZaR2xtZVY5aGNuSmhlU2hoT2lCaWVYUmxjeXdnWVhOemFXZHVYMnh2WTJGc09pQjFhVzUwTmpRcElDMCtJR0o1ZEdWek9ncHRZWGxpWlY5dGIyUnBabmxmWVhKeVlYazZDaUFnSUNBdkx5QmhjbU0wWDNSNWNHVnpMMjExZEdGaWJHVmZjR0Z5WVcxek1pNXdlVG94TlMweE5nb2dJQ0FnTHk4Z1FITjFZbkp2ZFhScGJtVUtJQ0FnSUM4dklHUmxaaUJ0WVhsaVpWOXRiMlJwWm5sZllYSnlZWGtvYzJWc1ppd2dZVG9nWVhKak5DNUVlVzVoYldsalFubDBaWE1zSUNvc0lHRnpjMmxuYmw5c2IyTmhiRG9nWW05dmJDa2dMVDRnVG05dVpUb2dJQ01nZGpBS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F2THlCaGNtTTBYM1I1Y0dWekwyMTFkR0ZpYkdWZmNHRnlZVzF6TWk1d2VUb3hOd29nSUNBZ0x5OGdhV1lnWVhOemFXZHVYMnh2WTJGc09nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpZWlCdFlYbGlaVjl0YjJScFpubGZZWEp5WVhsZlpXeHpaVjlpYjJSNVFERXdDaUFnSUNBdkx5QmhjbU0wWDNSNWNHVnpMMjExZEdGaWJHVmZjR0Z5WVcxek1pNXdlVG94T0FvZ0lDQWdMeThnWVM1aGNIQmxibVFvWVhKak5DNUNlWFJsS0RFcEtTQWdJeUIyTVRvZ2JXOWthV1o1SUc5MWRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgySjFjbmtnTFRJS0lDQWdJQzh2SUdGeVl6UmZkSGx3WlhNdmJYVjBZV0pzWlY5d1lYSmhiWE15TG5CNU9qSXhDaUFnSUNBdkx5QmhJRDBnWVhKak5DNUVlVzVoYldsalFubDBaWE1vTVN3Z01pd2dOQ2tnSUNNZ2RqUTZJR3h2WTJGc0lHOXViSGtLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURNd01UQXlNRFFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0JtY21GdFpWOWlkWEo1SUMweUNncHRZWGxpWlY5dGIyUnBabmxmWVhKeVlYbGZZV1owWlhKZmFXWmZaV3h6WlVBeE16b0tJQ0FnSUM4dklHRnlZelJmZEhsd1pYTXZiWFYwWVdKc1pWOXdZWEpoYlhNeUxuQjVPakkxQ2lBZ0lDQXZMeUJoTG1Gd2NHVnVaQ2hoY21NMExrSjVkR1VvTkNrcElDQWpJSFkyT2lCdGIyUnBabmtnYjNWMElFbEdJRzV2ZENCaUlFVk1VMFVnYkc5allXd2diMjVzZVFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJKMWNua2dMVElLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCaWVpQnRZWGxpWlY5dGIyUnBabmxmWVhKeVlYbGZZV1owWlhKZmFXWmZaV3h6WlVBeE5Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0NtMWhlV0psWDIxdlpHbG1lVjloY25KaGVWOWhablJsY2w5cFpsOWxiSE5sUURFMU9nb2dJQ0FnY21WMGMzVmlDZ3B0WVhsaVpWOXRiMlJwWm5sZllYSnlZWGxmWld4elpWOWliMlI1UURFd09nb2dJQ0FnTHk4Z1lYSmpORjkwZVhCbGN5OXRkWFJoWW14bFgzQmhjbUZ0Y3pJdWNIazZNak1LSUNBZ0lDOHZJR0V1WVhCd1pXNWtLR0Z5WXpRdVFubDBaU2cwTWlrcElDQWpJSFkxT2lCdGIyUnBabmtnYjNWMENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd5WVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JtY21GdFpWOWlkWEo1SUMweUNpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJR1p5WVcxbFgySjFjbmtnTFRJS0lDQWdJR0lnYldGNVltVmZiVzlrYVdaNVgyRnljbUY1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVE1LIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUNBQUV4RzBFQUc0QUVhc1NsVnpZYUFJNEJBQUlpUXpFWkZFUXhHRVNJQUEwalF6RVpRUC90TVJnVVJDTkRnQU1BQVFBamlBQWJnQVFBQWdBQkVrU0FBd0FCQVNLSUFBcUFCUUFEQVNvRUVrU0ppZ0lCSWlPTC8wRUFRSXYrVndJQWdBRUJVRWtWRmxjR0FreFFqUDZBQlFBREFRSUVJb3dCaS82TUFJeitpLzVYQWdDQUFRUlFTUlVXVndZQ1RGQ00vb3NCUVFBRWkvNk1BSW1ML2xjQ0FJQUJLbEJKRlJaWEJnSk1VRWNDalA2TUFJeitRdi9IIiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo5OSwibWlub3IiOjk5LCJwYXRjaCI6OTksImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
