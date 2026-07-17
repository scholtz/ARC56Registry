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

namespace Arc56.Generated.algorandfoundation.algorand_python_testing.DynamicItxnGroup_b865dfe1
{


    public class DynamicItxnGroupProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public DynamicItxnGroupProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="addresses"> </param>
        /// <param name="funds"> </param>
        /// <param name="verifier"> </param>
        public async Task TestFirstly(PaymentTransaction funds, Algorand.Address[] addresses, ulong verifier, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { funds });
            byte[] abiHandle = { 23, 57, 23, 132 };
            var addressesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); addressesAbi.From(addresses);
            var verifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); verifierAbi.From(verifier);

            var result = await base.CallApp(new List<object> { abiHandle, addressesAbi, funds, verifierAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestFirstly_Transactions(PaymentTransaction funds, Algorand.Address[] addresses, ulong verifier, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { funds });
            byte[] abiHandle = { 23, 57, 23, 132 };
            var addressesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); addressesAbi.From(addresses);
            var verifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); verifierAbi.From(verifier);

            return await base.MakeTransactionList(new List<object> { abiHandle, addressesAbi, funds, verifierAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="addresses"> </param>
        /// <param name="funds"> </param>
        /// <param name="verifier"> </param>
        public async Task TestLooply(PaymentTransaction funds, Algorand.Address[] addresses, ulong verifier, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { funds });
            byte[] abiHandle = { 63, 16, 174, 167 };
            var addressesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); addressesAbi.From(addresses);
            var verifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); verifierAbi.From(verifier);

            var result = await base.CallApp(new List<object> { abiHandle, addressesAbi, funds, verifierAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestLooply_Transactions(PaymentTransaction funds, Algorand.Address[] addresses, ulong verifier, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { funds });
            byte[] abiHandle = { 63, 16, 174, 167 };
            var addressesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); addressesAbi.From(addresses);
            var verifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); verifierAbi.From(verifier);

            return await base.MakeTransactionList(new List<object> { abiHandle, addressesAbi, funds, verifierAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRHluYW1pY0l0eG5Hcm91cCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0ZXN0X2ZpcnN0bHkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzc1tdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRkcmVzc2VzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmdW5kcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmVyaWZpZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdF9sb29wbHkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzc1tdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRkcmVzc2VzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmdW5kcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmVyaWZpZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls4NSwyMTddLCJlcnJvck1lc3NhZ2UiOiJGdW5kcyBtdXN0IGJlIHNlbnQgdG8gYXBwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQxLDI1MF0sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODksMjIwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTQsMjI1XSwiZXJyb3JNZXNzYWdlIjoibXVzdCBwcm92aWRlIHNvbWUgYWNjb3VudHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MiwyMDRdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJREFnTXpJZ05nb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VEWTFZVGxoWldOaklDSmhZbU1pQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZSSGx1WVcxcFkwbFVlRzVIY205MWNDOWpiMjUwY21GamRDNXdlVG94TXdvZ0lDQWdMeThnWTJ4aGMzTWdSSGx1WVcxcFkwbDBlRzVIY205MWNDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU9Rb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE1UY3pPVEUzT0RRZ01IZ3paakV3WVdWaE55QXZMeUJ0WlhSb2IyUWdJblJsYzNSZlptbHljM1JzZVNoaFpHUnlaWE56VzEwc2NHRjVMSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKMFpYTjBYMnh2YjNCc2VTaGhaR1J5WlhOelcxMHNjR0Y1TEhWcGJuUTJOQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dkR1Z6ZEY5bWFYSnpkR3g1SUhSbGMzUmZiRzl2Y0d4NUNpQWdJQ0JsY25JS0NtMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFPVG9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdVlYSjBhV1poWTNSekxrUjVibUZ0YVdOSlZIaHVSM0p2ZFhBdVkyOXVkSEpoWTNRdVJIbHVZVzFwWTBsMGVHNUhjbTkxY0M1MFpYTjBYMlpwY25OMGJIbGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AwWlhOMFgyWnBjbk4wYkhrNkNpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UkhsdVlXMXBZMGxVZUc1SGNtOTFjQzlqYjI1MGNtRmpkQzV3ZVRveE5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlCd1lYa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCd1lYa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdKMGIya0tJQ0FnSUdOdmRtVnlJRElLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OUVlVzVoYldsalNWUjRia2R5YjNWd0wyTnZiblJ5WVdOMExuQjVPakU0Q2lBZ0lDQXZMeUJoYzNObGNuUWdablZ1WkhNdWNtVmpaV2wyWlhJZ1BUMGdSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d2dJa1oxYm1SeklHMTFjM1FnWW1VZ2MyVnVkQ0IwYnlCaGNIQWlDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRkpsWTJWcGRtVnlDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCR2RXNWtjeUJ0ZFhOMElHSmxJSE5sYm5RZ2RHOGdZWEJ3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZSSGx1WVcxcFkwbFVlRzVIY205MWNDOWpiMjUwY21GamRDNXdlVG95TUFvZ0lDQWdMeThnWVhOelpYSjBJR0ZrWkhKbGMzTmxjeTVzWlc1bmRHZ3NJQ0p0ZFhOMElIQnliM1pwWkdVZ2MyOXRaU0JoWTJOdmRXNTBjeUlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXpDaUFnSUNCa2RYQUtJQ0FnSUdGemMyVnlkQ0F2THlCdGRYTjBJSEJ5YjNacFpHVWdjMjl0WlNCaFkyTnZkVzUwY3dvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMFI1Ym1GdGFXTkpWSGh1UjNKdmRYQXZZMjl1ZEhKaFkzUXVjSGs2TWpJS0lDQWdJQzh2SUhOb1lYSmxJRDBnWm5WdVpITXVZVzF2ZFc1MElDOHZJR0ZrWkhKbGMzTmxjeTVzWlc1bmRHZ0tJQ0FnSUhOM1lYQUtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb2dJQ0FnYzNkaGNBb2dJQ0FnTHdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UkhsdVlXMXBZMGxVZUc1SGNtOTFjQzlqYjI1MGNtRmpkQzV3ZVRveU5Bb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLR0Z0YjNWdWREMXphR0Z5WlN3Z2NtVmpaV2wyWlhJOVlXUmtjbVZ6YzJWeld6QmRMbTVoZEdsMlpTa3VjM1JoWjJVb1ltVm5hVzVmWjNKdmRYQTlWSEoxWlNrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRDQXlJRE15Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRkpsWTJWcGRtVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdhVzUwWTE4d0lDOHZJSEJoZVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlJIbHVZVzFwWTBsVWVHNUhjbTkxY0M5amIyNTBjbUZqZEM1d2VUb3lOZ29nSUNBZ0x5OGdabTl5SUdrZ2FXNGdkWEpoYm1kbEtERXNJR0ZrWkhKbGMzTmxjeTVzWlc1bmRHZ3BPZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtDblJsYzNSZlptbHljM1JzZVY5bWIzSmZhR1ZoWkdWeVFESTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlJIbHVZVzFwWTBsVWVHNUhjbTkxY0M5amIyNTBjbUZqZEM1d2VUb3lOZ29nSUNBZ0x5OGdabTl5SUdrZ2FXNGdkWEpoYm1kbEtERXNJR0ZrWkhKbGMzTmxjeTVzWlc1bmRHZ3BPZ29nSUNBZ1pIVndDaUFnSUNCa2FXY2dOQW9nSUNBZ1BBb2dJQ0FnWW5vZ2RHVnpkRjltYVhKemRHeDVYMkZtZEdWeVgyWnZja0ExQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZSSGx1WVcxcFkwbFVlRzVIY205MWNDOWpiMjUwY21GamRDNXdlVG95TndvZ0lDQWdMeThnWVdSa2NpQTlJR0ZrWkhKbGMzTmxjMXRwWFFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJQ29LSUNBZ0lHUnBaeUF6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNReklDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMFI1Ym1GdGFXTkpWSGh1UjNKdmRYQXZZMjl1ZEhKaFkzUXVjSGs2TWpnS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDaGhiVzkxYm5ROWMyaGhjbVVzSUhKbFkyVnBkbVZ5UFdGa1pISXVibUYwYVhabEtTNXpkR0ZuWlNncENpQWdJQ0JwZEhodVgyNWxlSFFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZqWldsMlpYSUtJQ0FnSUdScFp5QXpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdhVzUwWTE4d0lDOHZJSEJoZVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlJIbHVZVzFwWTBsVWVHNUhjbTkxY0M5amIyNTBjbUZqZEM1d2VUb3lOZ29nSUNBZ0x5OGdabTl5SUdrZ2FXNGdkWEpoYm1kbEtERXNJR0ZrWkhKbGMzTmxjeTVzWlc1bmRHZ3BPZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNzS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWWlCMFpYTjBYMlpwY25OMGJIbGZabTl5WDJobFlXUmxja0F5Q2dwMFpYTjBYMlpwY25OMGJIbGZZV1owWlhKZlptOXlRRFU2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZSSGx1WVcxcFkwbFVlRzVIY205MWNDOWpiMjUwY21GamRDNXdlVG96TUMwek1nb2dJQ0FnTHk4Z2FYUjRiaTVCY0hCc2FXTmhkR2x2YmtOaGJHd29DaUFnSUNBdkx5QWdJQ0FnWVhCd1gybGtQWFpsY21sbWFXVnlMbWxrTENCaGNIQmZZWEpuY3owb1lYSmpOQzVoY21NMFgzTnBaMjVoZEhWeVpTZ2lkbVZ5YVdaNUtDbDJiMmxrSWlrc0tRb2dJQ0FnTHk4Z0tTNXpkR0ZuWlNncENpQWdJQ0JwZEhodVgyNWxlSFFLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OUVlVzVoYldsalNWUjRia2R5YjNWd0wyTnZiblJ5WVdOMExuQjVPak14Q2lBZ0lDQXZMeUJoY0hCZmFXUTlkbVZ5YVdacFpYSXVhV1FzSUdGd2NGOWhjbWR6UFNoaGNtTTBMbUZ5WXpSZmMybG5ibUYwZFhKbEtDSjJaWEpwWm5rb0tYWnZhV1FpS1N3cENpQWdJQ0JpZVhSbFkxOHdJQzh2SUcxbGRHaHZaQ0FpZG1WeWFXWjVLQ2wyYjJsa0lnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHUnBaeUEwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlFZVc1aGJXbGpTVlI0YmtkeWIzVndMMk52Ym5SeVlXTjBMbkI1T2pNd0NpQWdJQ0F2THlCcGRIaHVMa0Z3Y0d4cFkyRjBhVzl1UTJGc2JDZ0tJQ0FnSUdsdWRHTmZNeUF2THlCaGNIQnNDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlFZVc1aGJXbGpTVlI0YmtkeWIzVndMMk52Ym5SeVlXTjBMbkI1T2pNMENpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFEyOXVabWxuS0dGemMyVjBYMjVoYldVOUltRmlZeUlwTG5OMFlXZGxLQ2tLSUNBZ0lHbDBlRzVmYm1WNGRBb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVlXSmpJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRTVoYldVS0lDQWdJSEIxYzJocGJuUWdNeUF2THlCaFkyWm5DaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlFZVc1aGJXbGpTVlI0YmtkeWIzVndMMk52Ym5SeVlXTjBMbkI1T2pNMkNpQWdJQ0F2THlCcGRIaHVMbk4xWW0xcGRGOXpkR0ZuWldRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlFZVc1aGJXbGpTVlI0YmtkeWIzVndMMk52Ym5SeVlXTjBMbkI1T2pFMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k1aGNuUnBabUZqZEhNdVJIbHVZVzFwWTBsVWVHNUhjbTkxY0M1amIyNTBjbUZqZEM1RWVXNWhiV2xqU1hSNGJrZHliM1Z3TG5SbGMzUmZiRzl2Y0d4NVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkR1Z6ZEY5c2IyOXdiSGs2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwUjVibUZ0YVdOSlZIaHVSM0p2ZFhBdlkyOXVkSEpoWTNRdWNIazZNemdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QndZWGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QndZWGtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHSjBiMmtLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlFZVc1aGJXbGpTVlI0YmtkeWIzVndMMk52Ym5SeVlXTjBMbkI1T2pRMUNpQWdJQ0F2THlCaGMzTmxjblFnWm5WdVpITXVjbVZqWldsMlpYSWdQVDBnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdnSWtaMWJtUnpJRzExYzNRZ1ltVWdjMlZ1ZENCMGJ5QmhjSEFpQ2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZKbFkyVnBkbVZ5Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkdkVzVrY3lCdGRYTjBJR0psSUhObGJuUWdkRzhnWVhCd0NpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UkhsdVlXMXBZMGxVZUc1SGNtOTFjQzlqYjI1MGNtRmpkQzV3ZVRvME53b2dJQ0FnTHk4Z1lYTnpaWEowSUdGa1pISmxjM05sY3k1c1pXNW5kR2dzSUNKdGRYTjBJSEJ5YjNacFpHVWdjMjl0WlNCaFkyTnZkVzUwY3lJS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHUjFjQW9nSUNBZ1lYTnpaWEowSUM4dklHMTFjM1FnY0hKdmRtbGtaU0J6YjIxbElHRmpZMjkxYm5SekNpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UkhsdVlXMXBZMGxVZUc1SGNtOTFjQzlqYjI1MGNtRmpkQzV3ZVRvME9Rb2dJQ0FnTHk4Z2MyaGhjbVVnUFNCbWRXNWtjeTVoYlc5MWJuUWdMeThnWVdSa2NtVnpjMlZ6TG14bGJtZDBhQW9nSUNBZ2MzZGhjQW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDaUFnSUNCemQyRndDaUFnSUNBdkNpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UkhsdVlXMXBZMGxVZUc1SGNtOTFjQzlqYjI1MGNtRmpkQzV3ZVRvMU1Rb2dJQ0FnTHk4Z2FYTmZabWx5YzNRZ1BTQlVjblZsQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtDblJsYzNSZmJHOXZjR3g1WDJadmNsOW9aV0ZrWlhKQU1qb0tJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5RWVXNWhiV2xqU1ZSNGJrZHliM1Z3TDJOdmJuUnlZV04wTG5CNU9qVXlDaUFnSUNBdkx5Qm1iM0lnWVdSa2NpQnBiaUJoWkdSeVpYTnpaWE02Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUEwQ2lBZ0lDQThDaUFnSUNCaWVpQjBaWE4wWDJ4dmIzQnNlVjloWm5SbGNsOW1iM0pBT0FvZ0lDQWdaR2xuSURVS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1luVnllU0EzQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZSSGx1WVcxcFkwbFVlRzVIY205MWNDOWpiMjUwY21GamRDNXdlVG8xTkFvZ0lDQWdMeThnYlhsZmRIaHVMbk4wWVdkbEtHSmxaMmx1WDJkeWIzVndQV2x6WDJacGNuTjBLUW9nSUNBZ1pHbG5JREVLSUNBZ0lHSjZJSFJsYzNSZmJHOXZjR3g1WDJsMGVHNWZibVY0ZEVBMUNpQWdJQ0JwZEhodVgySmxaMmx1Q2dwMFpYTjBYMnh2YjNCc2VWOWhablJsY2w5cGRIaHVYMkpsWjJsdVgyNWxlSFJBTmpvS0lDQWdJR1JwWnlBMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZKbFkyVnBkbVZ5Q2lBZ0lDQmthV2NnTWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5RWVXNWhiV2xqU1ZSNGJrZHliM1Z3TDJOdmJuUnlZV04wTG5CNU9qVXpDaUFnSUNBdkx5QnRlVjkwZUc0Z1BTQnBkSGh1TGxCaGVXMWxiblFvWVcxdmRXNTBQWE5vWVhKbExDQnlaV05sYVhabGNqMWhaR1J5TG01aGRHbDJaU2tLSUNBZ0lHbHVkR05mTUNBdkx5QndZWGtLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBSNWJtRnRhV05KVkhodVIzSnZkWEF2WTI5dWRISmhZM1F1Y0hrNk5UVUtJQ0FnSUM4dklHbHpYMlpwY25OMElEMGdSbUZzYzJVS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmlkWEo1SURJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKMWNua2dNUW9nSUNBZ1lpQjBaWE4wWDJ4dmIzQnNlVjltYjNKZmFHVmhaR1Z5UURJS0NuUmxjM1JmYkc5dmNHeDVYMmwwZUc1ZmJtVjRkRUExT2dvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMFI1Ym1GdGFXTkpWSGh1UjNKdmRYQXZZMjl1ZEhKaFkzUXVjSGs2TlRRS0lDQWdJQzh2SUcxNVgzUjRiaTV6ZEdGblpTaGlaV2RwYmw5bmNtOTFjRDFwYzE5bWFYSnpkQ2tLSUNBZ0lHbDBlRzVmYm1WNGRBb2dJQ0FnWWlCMFpYTjBYMnh2YjNCc2VWOWhablJsY2w5cGRIaHVYMkpsWjJsdVgyNWxlSFJBTmdvS2RHVnpkRjlzYjI5d2JIbGZZV1owWlhKZlptOXlRRGc2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZSSGx1WVcxcFkwbFVlRzVIY205MWNDOWpiMjUwY21GamRDNXdlVG8xTnkwMU9Rb2dJQ0FnTHk4Z2FYUjRiaTVCY0hCc2FXTmhkR2x2YmtOaGJHd29DaUFnSUNBdkx5QWdJQ0FnWVhCd1gybGtQWFpsY21sbWFXVnlMbWxrTENCaGNIQmZZWEpuY3owb1lYSmpOQzVoY21NMFgzTnBaMjVoZEhWeVpTZ2lkbVZ5YVdaNUtDbDJiMmxrSWlrc0tRb2dJQ0FnTHk4Z0tTNXpkR0ZuWlNncENpQWdJQ0JwZEhodVgyNWxlSFFLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OUVlVzVoYldsalNWUjRia2R5YjNWd0wyTnZiblJ5WVdOMExuQjVPalU0Q2lBZ0lDQXZMeUJoY0hCZmFXUTlkbVZ5YVdacFpYSXVhV1FzSUdGd2NGOWhjbWR6UFNoaGNtTTBMbUZ5WXpSZmMybG5ibUYwZFhKbEtDSjJaWEpwWm5rb0tYWnZhV1FpS1N3cENpQWdJQ0JpZVhSbFkxOHdJQzh2SUcxbGRHaHZaQ0FpZG1WeWFXWjVLQ2wyYjJsa0lnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHUnBaeUEwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlFZVc1aGJXbGpTVlI0YmtkeWIzVndMMk52Ym5SeVlXTjBMbkI1T2pVM0NpQWdJQ0F2THlCcGRIaHVMa0Z3Y0d4cFkyRjBhVzl1UTJGc2JDZ0tJQ0FnSUdsdWRHTmZNeUF2THlCaGNIQnNDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlFZVc1aGJXbGpTVlI0YmtkeWIzVndMMk52Ym5SeVlXTjBMbkI1T2pZeENpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFEyOXVabWxuS0dGemMyVjBYMjVoYldVOUltRmlZeUlwTG5OMFlXZGxLQ2tLSUNBZ0lHbDBlRzVmYm1WNGRBb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVlXSmpJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRTVoYldVS0lDQWdJSEIxYzJocGJuUWdNeUF2THlCaFkyWm5DaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlFZVc1aGJXbGpTVlI0YmtkeWIzVndMMk52Ym5SeVlXTjBMbkI1T2pZekNpQWdJQ0F2THlCcGRIaHVMbk4xWW0xcGRGOXpkR0ZuWldRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlFZVc1aGJXbGpTVlI0YmtkeWIzVndMMk52Ym5SeVlXTjBMbkI1T2pNNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFRQWdCaVlDQkdXcHJzd0RZV0pqTVJ0QkFCMHhHUlJFTVJoRWdnSUVGemtYaEFRL0VLNm5OaG9BamdJQUNRQ0xBREVaRkRFWUZCQkROaG9CTVJZaUNVazRFQ0lTUkRZYUFoZE9Ba2s0QnpJS0VrUkxBU05aU1U0RFNVUk1PQWhNQ2tsT0FyRkxBVmNDQUU0Q1RGY0NJTElIc2dnaXNoQWpzZ0VpU1VzRURFRUFIVWNDSkF0TEEwd2tXTGF5QjBzRHNnZ2lzaEFqc2dFaUNFVUJRdi9jdGlpeUdrc0VzaGdsc2hBanNnRzJLYkltZ1FPeUVDT3lBYk1pUXlNMkdnRkpNUllpQ1VrNEVDSVNSRFlhQWhkT0FrazRCeklLRWtSTUkxbEpUZ0pKUkV3NENFd0tJaU5KU3dRTVFRQXdTd1ZYQWdCTEFTUUxKRmhGQjBzQlFRQWFzVXNHc2dkTEFySUlJcklRSTdJQkkwVUNTU0lJUlFGQy84MjJRdi9qdGlpeUdrc0VzaGdsc2hBanNnRzJLYkltZ1FPeUVDT3lBYk1pUXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
