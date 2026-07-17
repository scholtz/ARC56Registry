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

namespace Arc56.Generated.algorandfoundation.puya_ts.TuplesAlgo_dedc56ce
{


    public class TuplesAlgoProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TuplesAlgoProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        /// <param name="c"> </param>
        public async Task Test(ulong a, ulong b, ulong c, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 55, 231, 206, 135 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cAbi.From(c);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi, cAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Test_Transactions(ulong a, ulong b, ulong c, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 55, 231, 206, 135 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cAbi.From(c);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi, cAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVHVwbGVzQWxnbyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0ZXN0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls4Niw5NCwxMDJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ09DQXdJREVnTVRZS0lDQWdJR0lnYldGcGJsOWliRzlqYTBBd0NncHRZV2x1WDJKc2IyTnJRREE2Q2lBZ0lDQmlJRzFoYVc1ZllteHZZMnRBTVFvS2JXRnBibDlpYkc5amEwQXhPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzUjFjR3hsY3k1aGJHZHZMblJ6T2pZS0lDQWdJQzh2SUdOc1lYTnpJRlIxY0d4bGMwRnNaMjhnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lDRTlDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUExQ2lBZ0lDQmlJRzFoYVc1ZllXSnBYM0p2ZFhScGJtZEFNZ29LYldGcGJsOWhZbWxmY205MWRHbHVaMEF5T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMM1IxY0d4bGN5NWhiR2R2TG5Sek9qWUtJQ0FnSUM4dklHTnNZWE56SUZSMWNHeGxjMEZzWjI4Z1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnek4yVTNZMlU0TnlBdkx5QnRaWFJvYjJRZ0luUmxjM1FvZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRcGRtOXBaQ0lLSUNBZ0lIVnVZMjkyWlhJZ01Rb2dJQ0FnYldGMFkyZ2diV0ZwYmw5MFpYTjBYM0p2ZFhSbFFETUtJQ0FnSUdJZ2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRRFFLQ20xaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQTBPZ29nSUNBZ1lpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFOZ29LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURZNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12ZEhWd2JHVnpMbUZzWjI4dWRITTZOZ29nSUNBZ0x5OGdZMnhoYzNNZ1ZIVndiR1Z6UVd4bmJ5QmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUdWeWNnb0tiV0ZwYmw5MFpYTjBYM0p2ZFhSbFFETTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmRIVndiR1Z6TG1Gc1oyOHVkSE02TndvZ0lDQWdMeThnZEdWemRDaGhPaUJWYVc1ME5qUXNJR0k2SUZWcGJuUTJOQ3dnWXpvZ1ZXbHVkRFkwS1NCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekVnTHk4Z1RtOVBjQW9nSUNBZ1BUMEtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0lUMEtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUdOaGJHeHpkV0lnZEdWemRBb2dJQ0FnWWlCdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFOQW9LYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU5Ub0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5MGRYQnNaWE11WVd4bmJ5NTBjem8yQ2lBZ0lDQXZMeUJqYkdGemN5QlVkWEJzWlhOQmJHZHZJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4eElDOHZJRTV2VDNBS0lDQWdJRDA5Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJRDA5Q2lBZ0lDQW1KZ29nSUNBZ1lYTnpaWEowQ2lBZ0lDQmpZV3hzYzNWaUlGOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OTBkWEJzWlhNdVlXeG5ieTUwY3pvNlZIVndiR1Z6UVd4bmJ5NTBaWE4wVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHVnpkRG9LSUNBZ0lHSWdkR1Z6ZEY5aWJHOWphMEF3Q2dwMFpYTjBYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmRIVndiR1Z6TG1Gc1oyOHVkSE02TndvZ0lDQWdMeThnZEdWemRDaGhPaUJWYVc1ME5qUXNJR0k2SUZWcGJuUTJOQ3dnWXpvZ1ZXbHVkRFkwS1NCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpZV3hzYzNWaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5MGRYQnNaWE11WVd4bmJ5NTBjem82VkhWd2JHVnpRV3huYnk1MFpYTjBDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNSMWNHeGxjeTVoYkdkdkxuUnpPanBVZFhCc1pYTkJiR2R2TG5SbGMzUW9ZVG9nWW5sMFpYTXNJR0k2SUdKNWRHVnpMQ0JqT2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LZEdWemRITXZZWEJ3Y205MllXeHpMM1IxY0d4bGN5NWhiR2R2TG5Sek9qcFVkWEJzWlhOQmJHZHZMblJsYzNRNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12ZEhWd2JHVnpMbUZzWjI4dWRITTZOd29nSUNBZ0x5OGdkR1Z6ZENoaE9pQlZhVzUwTmpRc0lHSTZJRlZwYm5RMk5Dd2dZem9nVldsdWREWTBLU0I3Q2lBZ0lDQndjbTkwYnlBeklEQUtJQ0FnSUdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDNSMWNHeGxjeTVoYkdkdkxuUnpPanBVZFhCc1pYTkJiR2R2TG5SbGMzUmZZbXh2WTJ0QU1Bb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwzUjFjR3hsY3k1aGJHZHZMblJ6T2pwVWRYQnNaWE5CYkdkdkxuUmxjM1JmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OTBkWEJzWlhNdVlXeG5ieTUwY3pvNENpQWdJQ0F2THlCamIyNXpkQ0J5WldGa2IyNXNlVlIxY0d4bElEMGdXMkVzSUdJc0lHTmRJR0Z6SUdOdmJuTjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12ZEhWd2JHVnpMbUZzWjI4dWRITTZNVEFLSUNBZ0lDOHZJR052Ym5OMElHMTFkR0ZpYkdWVWRYQnNaVG9nVzFWcGJuUTJOQ3dnVldsdWREWTBMQ0JWYVc1ME5qUmRJRDBnVzJFc0lHSXNJR05kQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGdLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTkwZFhCc1pYTXVZV3huYnk1MGN6b3hNZ29nSUNBZ0x5OGdZMjl1YzNRZ1lYSmpORlIxY0d4bElEMGdibVYzSUZSMWNHeGxLR0VzSUdJc0lHTXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHTnZkbVZ5SURFS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTkwZFhCc1pYTXVZV3huYnk1MGN6b3hOQW9nSUNBZ0x5OGdkR2hwY3k1eVpXTmxhWFpsVW1WaFpHOXViSGtvY21WaFpHOXViSGxVZFhCc1pTa0tJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR05oYkd4emRXSWdjbVZqWldsMlpWSmxZV1J2Ym14NUNpQWdJQ0J3YjNBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTkwZFhCc1pYTXVZV3huYnk1MGN6b3hOUW9nSUNBZ0x5OGdkR2hwY3k1eVpXTmxhWFpsVW1WaFpHOXViSGtvYlhWMFlXSnNaVlIxY0d4bEtRb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JqYjNabGNpQXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdOdmRtVnlJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh6SUM4dklERTJDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOaGJHeHpkV0lnY21WalpXbDJaVkpsWVdSdmJteDVDaUFnSUNCd2IzQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5MGRYQnNaWE11WVd4bmJ5NTBjem94TmdvZ0lDQWdMeThnZEdocGN5NXlaV05sYVhabFVtVmhaRzl1Ykhrb1lYSmpORlIxY0d4bExtNWhkR2wyWlNrS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JqYjNabGNpQXhDaUFnSUNCa2FXY2dNZ29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1kyOTJaWElnTVFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCcGJuUmpYek1nTHk4Z01UWUtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjNabGNpQXhDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTJGc2JITjFZaUJ5WldObGFYWmxVbVZoWkc5dWJIa0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNSMWNHeGxjeTVoYkdkdkxuUnpPakU0Q2lBZ0lDQXZMeUIwYUdsekxuSmxZMlZwZG1WTmRYUmhZbXhsS0cxMWRHRmliR1ZVZFhCc1pTa0tJQ0FnSUdOaGJHeHpkV0lnY21WalpXbDJaVTExZEdGaWJHVUtJQ0FnSUhCdmNBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNSMWNHeGxjeTVoYkdkdkxuUnpPanBVZFhCc1pYTkJiR2R2TG5KbFkyVnBkbVZTWldGa2IyNXNlU2hoY21jdU1Eb2dZbmwwWlhNc0lHRnlaeTR4T2lCaWVYUmxjeXdnWVhKbkxqSTZJR0o1ZEdWektTQXRQaUIxYVc1ME5qUTZDbkpsWTJWcGRtVlNaV0ZrYjI1c2VUb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5MGRYQnNaWE11WVd4bmJ5NTBjem95T0FvZ0lDQWdMeThnY0hKcGRtRjBaU0J5WldObGFYWmxVbVZoWkc5dWJIa29ZWEpuT2lCeVpXRmtiMjVzZVNCYlZXbHVkRFkwTENCVmFXNTBOalFzSUZWcGJuUTJORjBwT2lCMWFXNTBOalFnZXdvZ0lDQWdjSEp2ZEc4Z015QXhDaUFnSUNCaUlISmxZMlZwZG1WU1pXRmtiMjVzZVY5aWJHOWphMEF3Q2dweVpXTmxhWFpsVW1WaFpHOXViSGxmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OTBkWEJzWlhNdVlXeG5ieTUwY3pveU9Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVp5NXNaVzVuZEdnS0lDQWdJSEIxYzJocGJuUWdNd29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzUjFjR3hsY3k1aGJHZHZMblJ6T2pwVWRYQnNaWE5CYkdkdkxuSmxZMlZwZG1WTmRYUmhZbXhsS0dGeVp6b2dZbmwwWlhNcElDMCtJSFZwYm5RMk5Eb0tjbVZqWldsMlpVMTFkR0ZpYkdVNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12ZEhWd2JHVnpMbUZzWjI4dWRITTZNeklLSUNBZ0lDOHZJSEJ5YVhaaGRHVWdjbVZqWldsMlpVMTFkR0ZpYkdVb1lYSm5PaUJiVldsdWREWTBMQ0JWYVc1ME5qUXNJRlZwYm5RMk5GMHBPaUIxYVc1ME5qUWdld29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0JpSUhKbFkyVnBkbVZOZFhSaFlteGxYMkpzYjJOclFEQUtDbkpsWTJWcGRtVk5kWFJoWW14bFgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12ZEhWd2JHVnpMbUZzWjI4dWRITTZNelFLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbWN1YkdWdVozUm9DaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTkwZFhCc1pYTXVZV3huYnk1MGN6bzZWSFZ3YkdWelFXeG5ieTVmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVW9LU0F0UGlCMmIybGtPZ3BmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVTZDaUFnSUNCaUlGOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlY5aWJHOWphMEF3Q2dwZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZmWW14dlkydEFNRG9LSUNBZ0lISmxkSE4xWWdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JpSUcxaGFXNWZZbXh2WTJ0QU1Bb0tiV0ZwYmw5aWJHOWphMEF3T2dvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUNBQUJFRUlBQUVJQUFERWJJeE5CQUNsQ0FBQTJHZ0NBQkRmbnpvZFBBWTRCQUFkQ0FBQkNBQUFBTVJrakVqRVlJeE1RUklnQUVrTC83REVaSXhJeEdDTVNFRVNJQUt3a1EwSUFBRFlhQVVrVkloSkVOaG9DU1JVaUVrUTJHZ05KRlNJU1JFOENUd0pQQW9nQUFpUkRpZ01BUWdBQWkvMkwvb3YvZ0FDTC9WQ0wvbENMLzFDQUFJdjlVSXYrVUl2L1VFNEJUd1JQQkU4RWlBQkZTRWtqSWxoT0FVa2lJbGhPQVVrbElsaFBBMDhEVHdLSUFDdElTd0VqSWxoT0FVc0NJaUpZVGdGUEF5VWlXRThEVGdGUEEwOEJUd0pQQWs4Q2lBQUdTSWdBQzBpSmlnTUJRZ0FBZ1FPSmlnRUJRZ0FBZ1FPSlFnQUFpUT09IiwiY2xlYXIiOiJDMElBQUlFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
