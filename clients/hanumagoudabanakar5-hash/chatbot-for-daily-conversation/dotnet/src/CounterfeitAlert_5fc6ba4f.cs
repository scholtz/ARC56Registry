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

namespace Arc56.Generated.hanumagoudabanakar5_hash.chatbot_for_daily_conversation.CounterfeitAlert_5fc6ba4f
{


    public class CounterfeitAlertProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CounterfeitAlertProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="med_asset"> </param>
        /// <param name="holder"> </param>
        /// <param name="scanned_hash"> </param>
        /// <param name="true_hash"> </param>
        public async Task<string> VerifyAndFreeze(ulong med_asset, Algorand.Address holder, byte[] scanned_hash, byte[] true_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 107, 88, 250, 120 };
            var med_assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); med_assetAbi.From(med_asset);
            var holderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); holderAbi.From(holder);
            var scanned_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); scanned_hashAbi.From(scanned_hash);
            var true_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); true_hashAbi.From(true_hash);

            var result = await base.CallApp(new List<object> { abiHandle, med_assetAbi, holderAbi, scanned_hashAbi, true_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> VerifyAndFreeze_Transactions(ulong med_asset, Algorand.Address holder, byte[] scanned_hash, byte[] true_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 107, 88, 250, 120 };
            var med_assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); med_assetAbi.From(med_asset);
            var holderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); holderAbi.From(holder);
            var scanned_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); scanned_hashAbi.From(scanned_hash);
            var true_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); true_hashAbi.From(true_hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, med_assetAbi, holderAbi, scanned_hashAbi, true_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ291bnRlcmZlaXRBbGVydCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJ2ZXJpZnlfYW5kX2ZyZWV6ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtZWRfYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJob2xkZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNjYW5uZWRfaGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidHJ1ZV9oYXNoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls2Nyw4M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc0LDkwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lESWdNUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMME52ZFc1MFpYSm1aV2wwUVd4bGNuUXVjSGs2TWdvZ0lDQWdMeThnWTJ4aGMzTWdRMjkxYm5SbGNtWmxhWFJCYkdWeWRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU5Rb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5tSTFPR1poTnpnZ0x5OGdiV1YwYUc5a0lDSjJaWEpwWm5sZllXNWtYMlp5WldWNlpTaDFhVzUwTmpRc1lXUmtjbVZ6Y3l4aWVYUmxXMTBzWW5sMFpWdGRLWE4wY21sdVp5SUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZmRtVnlhV1o1WDJGdVpGOW1jbVZsZW1WZmNtOTFkR1ZBTXdvZ0lDQWdaWEp5Q2dwdFlXbHVYM1psY21sbWVWOWhibVJmWm5KbFpYcGxYM0p2ZFhSbFFETTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRMjkxYm5SbGNtWmxhWFJCYkdWeWRDNXdlVG96Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQW1KZ29nSUNBZ1lYTnpaWEowQ2lBZ0lDQmlJSFpsY21sbWVWOWhibVJmWm5KbFpYcGxDZ3B0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURVNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUVOdmRXNTBaWEptWldsMFFXeGxjblF1UTI5MWJuUmxjbVpsYVhSQmJHVnlkQzUyWlhKcFpubGZZVzVrWDJaeVpXVjZaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25abGNtbG1lVjloYm1SZlpuSmxaWHBsT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBOdmRXNTBaWEptWldsMFFXeGxjblF1Y0hrNk13b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRMjkxYm5SbGNtWmxhWFJCYkdWeWRDNXdlVG8xQ2lBZ0lDQXZMeUJwWmlCelkyRnVibVZrWDJoaGMyZ2dJVDBnZEhKMVpWOW9ZWE5vT2dvZ0lDQWdJVDBLSUNBZ0lHSjZJSFpsY21sbWVWOWhibVJmWm5KbFpYcGxYMkZtZEdWeVgybG1YMlZzYzJWQU5Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwTnZkVzUwWlhKbVpXbDBRV3hsY25RdWNIazZOaTB4TUFvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEVaeVpXVjZaU2dLSUNBZ0lDOHZJQ0FnSUNCbWNtVmxlbVZmWVhOelpYUTliV1ZrWDJGemMyVjBMQW9nSUNBZ0x5OGdJQ0FnSUdaeVpXVjZaVjloWTJOdmRXNTBQV2h2YkdSbGNpd0tJQ0FnSUM4dklDQWdJQ0JtY205NlpXNDlWSEoxWlFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMME52ZFc1MFpYSm1aV2wwUVd4bGNuUXVjSGs2T1FvZ0lDQWdMeThnWm5KdmVtVnVQVlJ5ZFdVS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVp5WldWNlpVRnpjMlYwUm5KdmVtVnVDaUFnSUNCa2RYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JuSmxaWHBsUVhOelpYUkJZMk52ZFc1MENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR2NtVmxlbVZCYzNObGRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwTnZkVzUwWlhKbVpXbDBRV3hsY25RdWNIazZOZ29nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRVp5WldWNlpTZ0tJQ0FnSUhCMWMyaHBiblFnTlNBdkx5Qmhabko2Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OURiM1Z1ZEdWeVptVnBkRUZzWlhKMExuQjVPall0TVRBS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSR2NtVmxlbVVvQ2lBZ0lDQXZMeUFnSUNBZ1puSmxaWHBsWDJGemMyVjBQVzFsWkY5aGMzTmxkQ3dLSUNBZ0lDOHZJQ0FnSUNCbWNtVmxlbVZmWVdOamIzVnVkRDFvYjJ4a1pYSXNDaUFnSUNBdkx5QWdJQ0FnWm5KdmVtVnVQVlJ5ZFdVS0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UTI5MWJuUmxjbVpsYVhSQmJHVnlkQzV3ZVRveE1Rb2dJQ0FnTHk4Z2JHOW5LQ0pCVEVWU1ZEb2dRMjkxYm5SbGNtWmxhWFFnWkdWMFpXTjBaV1FoSWlrS0lDQWdJSEIxYzJoaWVYUmxjeUFpUVV4RlVsUTZJRU52ZFc1MFpYSm1aV2wwSUdSbGRHVmpkR1ZrSVNJS0lDQWdJR3h2WndvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBOdmRXNTBaWEptWldsMFFXeGxjblF1Y0hrNk1USUtJQ0FnSUM4dklISmxkSFZ5YmlCVGRISnBibWNvSWtOUFZVNVVSVkpHUlVsVVgwUkZWRVZEVkVWRUlpa0tJQ0FnSUhCMWMyaGllWFJsY3lBaVEwOVZUbFJGVWtaRlNWUmZSRVZVUlVOVVJVUWlDZ3AyWlhKcFpubGZZVzVrWDJaeVpXVjZaVjloWm5SbGNsOXBibXhwYm1Wa1gwTnZkVzUwWlhKbVpXbDBRV3hsY25RdVEyOTFiblJsY21abGFYUkJiR1Z5ZEM1MlpYSnBabmxmWVc1a1gyWnlaV1Y2WlVBMU9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwTnZkVzUwWlhKbVpXbDBRV3hsY25RdWNIazZNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwMlpYSnBabmxmWVc1a1gyWnlaV1Y2WlY5aFpuUmxjbDlwWmw5bGJITmxRRFE2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UTI5MWJuUmxjbVpsYVhSQmJHVnlkQzV3ZVRveE13b2dJQ0FnTHk4Z2NtVjBkWEp1SUZOMGNtbHVaeWdpUWtGVVEwaGZSMFZPVlVsT1JTSXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrSkJWRU5JWDBkRlRsVkpUa1VpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UTI5MWJuUmxjbVpsYVhSQmJHVnlkQzV3ZVRvekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHSWdkbVZ5YVdaNVgyRnVaRjltY21WbGVtVmZZV1owWlhKZmFXNXNhVzVsWkY5RGIzVnVkR1Z5Wm1WcGRFRnNaWEowTGtOdmRXNTBaWEptWldsMFFXeGxjblF1ZG1WeWFXWjVYMkZ1WkY5bWNtVmxlbVZBTlFvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QURBQUlCTVJ0QkFCaUFCR3RZK25nMkdnQ09BUUFCQURFWkZERVlFRVJDQUFneEdSUXhHQlFRUXpZYUFVa1ZnUWdTUkJjMkdnSkpGWUVnRWtRMkdnTkpJbGtqQ0VzQkZSSkVWd0lBTmhvRVNTSlpJd2hMQVJVU1JGY0NBQk5CQUZ1eEpMSXZTYkl1U3dHeUxZRUZzaEFpc2dHemdCeEJURVZTVkRvZ1EyOTFiblJsY21abGFYUWdaR1YwWldOMFpXUWhzSUFVUTA5VlRsUkZVa1pGU1ZSZlJFVlVSVU5VUlVSSkZSWlhCZ0pNVUlBRUZSOThkVXhRc0NSRGdBMUNRVlJEU0Y5SFJVNVZTVTVGUXYvYiIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
