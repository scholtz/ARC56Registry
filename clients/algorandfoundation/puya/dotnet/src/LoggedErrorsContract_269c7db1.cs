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

namespace Arc56.Generated.algorandfoundation.puya.LoggedErrorsContract_269c7db1
{


    public class LoggedErrorsContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public LoggedErrorsContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="arg"> </param>
        public async Task TestLoggedErrs(ulong arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 64, 12, 163, 75 };
            var argAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); argAbi.From(arg);

            var result = await base.CallApp(new List<object> { abiHandle, argAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestLoggedErrs_Transactions(ulong arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 64, 12, 163, 75 };
            var argAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); argAbi.From(arg);

            return await base.MakeTransactionList(new List<object> { abiHandle, argAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTG9nZ2VkRXJyb3JzQ29udHJhY3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoidGVzdF9sb2dnZWRfZXJycyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcmciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxMTddLCJlcnJvck1lc3NhZ2UiOiJBRVI6YXJnMDMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDZdLCJlcnJvck1lc3NhZ2UiOiJBRVI6YXJnMDQ6YXJnIGlzIDQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTNdLCJlcnJvck1lc3NhZ2UiOiJBRVI6YXJnMDciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDldLCJlcnJvck1lc3NhZ2UiOiJBRVI6YXJnMDg6YXJnIGlzIGVpZ2h0ICgwOCkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2Nl0sImVycm9yTWVzc2FnZSI6IkVSUjowMSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5M10sImVycm9yTWVzc2FnZSI6IkVSUjowNjphcmcgd2FzIDYiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5N10sImVycm9yTWVzc2FnZSI6IkVSUjphcmcwMjphcmcgaXMgdHdvIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY2XSwiZXJyb3JNZXNzYWdlIjoiRVJSOmFyZzA1IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUE0SURFS0lDQWdJQzh2SUd4dloyZGxaRjlsY25KdmNuTXZZMjl1ZEhKaFkzUXVjSGs2TlFvZ0lDQWdMeThnWTJ4aGMzTWdURzluWjJWa1JYSnliM0p6UTI5dWRISmhZM1FvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM0I1WDJSbFptRjFiSFJmWTNKbFlYUmxRRFVLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFF3TUdOaE16UmlJQzh2SUcxbGRHaHZaQ0FpZEdWemRGOXNiMmRuWldSZlpYSnljeWgxYVc1ME5qUXBkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmZEdWemRGOXNiMmRuWldSZlpYSnljMTl5YjNWMFpVQXpDaUFnSUNCbGNuSUtDbTFoYVc1ZmRHVnpkRjlzYjJkblpXUmZaWEp5YzE5eWIzVjBaVUF6T2dvZ0lDQWdMeThnYkc5bloyVmtYMlZ5Y205eWN5OWpiMjUwY21GamRDNXdlVG8yQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnWWlCMFpYTjBYMnh2WjJkbFpGOWxjbkp6Q2dwdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFEVTZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1JmWTJGelpYTXViRzluWjJWa1gyVnljbTl5Y3k1amIyNTBjbUZqZEM1TWIyZG5aV1JGY25KdmNuTkRiMjUwY21GamRDNTBaWE4wWDJ4dloyZGxaRjlsY25KelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkR1Z6ZEY5c2IyZG5aV1JmWlhKeWN6b0tJQ0FnSUM4dklHeHZaMmRsWkY5bGNuSnZjbk12WTI5dWRISmhZM1F1Y0hrNk5nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ1pIVndDaUFnSUNBdkx5QnNiMmRuWldSZlpYSnliM0p6TDJOdmJuUnlZV04wTG5CNU9qZ3RPUW9nSUNBZ0x5OGdJeUFpUlZKU09qQXhJZ29nSUNBZ0x5OGdiRzluWjJWa1gyRnpjMlZ5ZENoaGNtY2dJVDBnTVN3Z0lqQXhJaWtLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBaFBRb2dJQ0FnWW01NklIUmxjM1JmYkc5bloyVmtYMlZ5Y25OZllXWjBaWEpmWVhOelpYSjBRRE1LSUNBZ0lIQjFjMmhpZVhSbGN5QWlSVkpTT2pBeElnb2dJQ0FnYkc5bkNpQWdJQ0JsY25JZ0x5OGdSVkpTT2pBeENncDBaWE4wWDJ4dloyZGxaRjlsY25KelgyRm1kR1Z5WDJGemMyVnlkRUF6T2dvZ0lDQWdMeThnYkc5bloyVmtYMlZ5Y205eWN5OWpiMjUwY21GamRDNXdlVG94TUMweE1Rb2dJQ0FnTHk4Z0l5QWlSVkpTT21GeVp6QXlPbUZ5WnlCcGN5QjBkMjhpQ2lBZ0lDQXZMeUJzYjJkblpXUmZZWE56WlhKMEtHRnlaeUFoUFNBeUxDQWlZWEpuTURJaUxDQmxjbkp2Y2w5dFpYTnpZV2RsUFNKaGNtY2dhWE1nZEhkdklpa0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQWhQUW9nSUNBZ1ltNTZJSFJsYzNSZmJHOW5aMlZrWDJWeWNuTmZZV1owWlhKZllYTnpaWEowUURVS0lDQWdJSEIxYzJoaWVYUmxjeUFpUlZKU09tRnlaekF5T21GeVp5QnBjeUIwZDI4aUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2WVhKbk1ESTZZWEpuSUdseklIUjNid29LZEdWemRGOXNiMmRuWldSZlpYSnljMTloWm5SbGNsOWhjM05sY25SQU5Ub0tJQ0FnSUM4dklHeHZaMmRsWkY5bGNuSnZjbk12WTI5dWRISmhZM1F1Y0hrNk1USXRNVE1LSUNBZ0lDOHZJQ01nSWtGRlVqcGhjbWN3TXlJS0lDQWdJQzh2SUd4dloyZGxaRjloYzNObGNuUW9ZWEpuSUNFOUlETXNJQ0poY21jd015SXNJSEJ5WldacGVEMGlRVVZTSWlrS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXpDaUFnSUNBaFBRb2dJQ0FnWW01NklIUmxjM1JmYkc5bloyVmtYMlZ5Y25OZllXWjBaWEpmWVhOelpYSjBRRGNLSUNBZ0lIQjFjMmhpZVhSbGN5QWlRVVZTT21GeVp6QXpJZ29nSUNBZ2JHOW5DaUFnSUNCbGNuSWdMeThnUVVWU09tRnlaekF6Q2dwMFpYTjBYMnh2WjJkbFpGOWxjbkp6WDJGbWRHVnlYMkZ6YzJWeWRFQTNPZ29nSUNBZ0x5OGdiRzluWjJWa1gyVnljbTl5Y3k5amIyNTBjbUZqZEM1d2VUb3hOQzB4TlFvZ0lDQWdMeThnSXlBaVFVVlNPbUZ5WnpBME9tRnlaeUJwY3lBMElnb2dJQ0FnTHk4Z2JHOW5aMlZrWDJGemMyVnlkQ2hoY21jZ0lUMGdOQ3dnSW1GeVp6QTBJaXdnWlhKeWIzSmZiV1Z6YzJGblpUMGlZWEpuSUdseklEUWlMQ0J3Y21WbWFYZzlJa0ZGVWlJcENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdOQW9nSUNBZ0lUMEtJQ0FnSUdKdWVpQjBaWE4wWDJ4dloyZGxaRjlsY25KelgyRm1kR1Z5WDJGemMyVnlkRUE1Q2lBZ0lDQndkWE5vWW5sMFpYTWdJa0ZGVWpwaGNtY3dORHBoY21jZ2FYTWdOQ0lLSUNBZ0lHeHZad29nSUNBZ1pYSnlJQzh2SUVGRlVqcGhjbWN3TkRwaGNtY2dhWE1nTkFvS2RHVnpkRjlzYjJkblpXUmZaWEp5YzE5aFpuUmxjbDloYzNObGNuUkFPVG9LSUNBZ0lDOHZJR3h2WjJkbFpGOWxjbkp2Y25NdlkyOXVkSEpoWTNRdWNIazZNVGN0TVRnS0lDQWdJQzh2SUNNZ0lrVlNVanBoY21jd05TSUtJQ0FnSUM4dklHbG1JR0Z5WnlBOVBTQTFPZ29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURVS0lDQWdJRDA5Q2lBZ0lDQmllaUIwWlhOMFgyeHZaMmRsWkY5bGNuSnpYMkZtZEdWeVgybG1YMlZzYzJWQU1URUtJQ0FnSUM4dklHeHZaMmRsWkY5bGNuSnZjbk12WTI5dWRISmhZM1F1Y0hrNk1Ua0tJQ0FnSUM4dklHeHZaMmRsWkY5bGNuSW9JbUZ5WnpBMUlpa0tJQ0FnSUhCMWMyaGllWFJsY3lBaVJWSlNPbUZ5WnpBMUlnb2dJQ0FnYkc5bkNpQWdJQ0JsY25JZ0x5OGdSVkpTT21GeVp6QTFDZ3AwWlhOMFgyeHZaMmRsWkY5bGNuSnpYMkZtZEdWeVgybG1YMlZzYzJWQU1URTZDaUFnSUNBdkx5QnNiMmRuWldSZlpYSnliM0p6TDJOdmJuUnlZV04wTG5CNU9qSXdMVEl4Q2lBZ0lDQXZMeUFqSUNKRlVsSTZZWEpuTURZNllYSm5JSGRoY3lBMklnb2dJQ0FnTHk4Z2FXWWdZWEpuSUQwOUlEWTZDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTmdvZ0lDQWdQVDBLSUNBZ0lHSjZJSFJsYzNSZmJHOW5aMlZrWDJWeWNuTmZZV1owWlhKZmFXWmZaV3h6WlVBeE13b2dJQ0FnTHk4Z2JHOW5aMlZrWDJWeWNtOXljeTlqYjI1MGNtRmpkQzV3ZVRveU1nb2dJQ0FnTHk4Z2JHOW5aMlZrWDJWeWNpZ2lNRFlpTENCbGNuSnZjbDl0WlhOellXZGxQU0poY21jZ2QyRnpJRFlpS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pGVWxJNk1EWTZZWEpuSUhkaGN5QTJJZ29nSUNBZ2JHOW5DaUFnSUNCbGNuSWdMeThnUlZKU09qQTJPbUZ5WnlCM1lYTWdOZ29LZEdWemRGOXNiMmRuWldSZlpYSnljMTloWm5SbGNsOXBabDlsYkhObFFERXpPZ29nSUNBZ0x5OGdiRzluWjJWa1gyVnljbTl5Y3k5amIyNTBjbUZqZEM1d2VUb3lNeTB5TkFvZ0lDQWdMeThnSXlBaVFVVlNPbUZ5WnpBM0lnb2dJQ0FnTHk4Z2FXWWdZWEpuSUQwOUlEYzZDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTndvZ0lDQWdQVDBLSUNBZ0lHSjZJSFJsYzNSZmJHOW5aMlZrWDJWeWNuTmZZV1owWlhKZmFXWmZaV3h6WlVBeE5Rb2dJQ0FnTHk4Z2JHOW5aMlZrWDJWeWNtOXljeTlqYjI1MGNtRmpkQzV3ZVRveU5Rb2dJQ0FnTHk4Z2JHOW5aMlZrWDJWeWNpZ2lZWEpuTURjaUxDQndjbVZtYVhnOUlrRkZVaUlwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJa0ZGVWpwaGNtY3dOeUlLSUNBZ0lHeHZad29nSUNBZ1pYSnlJQzh2SUVGRlVqcGhjbWN3TndvS2RHVnpkRjlzYjJkblpXUmZaWEp5YzE5aFpuUmxjbDlwWmw5bGJITmxRREUxT2dvZ0lDQWdMeThnYkc5bloyVmtYMlZ5Y205eWN5OWpiMjUwY21GamRDNXdlVG95TmkweU53b2dJQ0FnTHk4Z0l5QWlRVVZTT21GeVp6QTRPbUZ5WnlCcGN5QnpaWFpsYmlBb01EZ3BJZ29nSUNBZ0x5OGdhV1lnWVhKbklEMDlJRGc2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdKNklIUmxjM1JmYkc5bloyVmtYMlZ5Y25OZllXWjBaWEpmYVdaZlpXeHpaVUF4TndvZ0lDQWdMeThnYkc5bloyVmtYMlZ5Y205eWN5OWpiMjUwY21GamRDNXdlVG95T0FvZ0lDQWdMeThnYkc5bloyVmtYMlZ5Y2lnaVlYSm5NRGdpTENCbGNuSnZjbDl0WlhOellXZGxQU0poY21jZ2FYTWdaV2xuYUhRZ0tEQTRLU0lzSUhCeVpXWnBlRDBpUVVWU0lpa0tJQ0FnSUhCMWMyaGllWFJsY3lBaVFVVlNPbUZ5WnpBNE9tRnlaeUJwY3lCbGFXZG9kQ0FvTURncElnb2dJQ0FnYkc5bkNpQWdJQ0JsY25JZ0x5OGdRVVZTT21GeVp6QTRPbUZ5WnlCcGN5QmxhV2RvZENBb01EZ3BDZ3AwWlhOMFgyeHZaMmRsWkY5bGNuSnpYMkZtZEdWeVgybG1YMlZzYzJWQU1UYzZDaUFnSUNBdkx5QnNiMmRuWldSZlpYSnliM0p6TDJOdmJuUnlZV04wTG5CNU9qWUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFDQ0FFeEcwRUFHSUFFUUF5alN6WWFBSTRCQUFFQU1Sa1VNUmdRUkVJQUNERVpGREVZRkJCRE5ob0JTUlVpRWtRWFNTTVRRQUFLZ0FaRlVsSTZNREd3QUVtQkFoTkFBQmlBRkVWU1VqcGhjbWN3TWpwaGNtY2dhWE1nZEhkdnNBQkpnUU1UUUFBTmdBbEJSVkk2WVhKbk1ET3dBRW1CQkJOQUFCYUFFa0ZGVWpwaGNtY3dORHBoY21jZ2FYTWdOTEFBU1lFRkVrRUFEWUFKUlZKU09tRnlaekExc0FCSmdRWVNRUUFVZ0JCRlVsSTZNRFk2WVhKbklIZGhjeUEyc0FCSmdRY1NRUUFOZ0FsQlJWSTZZWEpuTURld0FDSVNRUUFmZ0J0QlJWSTZZWEpuTURnNllYSm5JR2x6SUdWcFoyaDBJQ2d3T0Ntd0FDTkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjk5LCJtaW5vciI6OTksInBhdGNoIjo5OSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
