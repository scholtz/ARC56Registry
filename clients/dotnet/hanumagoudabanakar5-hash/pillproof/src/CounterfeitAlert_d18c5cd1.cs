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

namespace Arc56.Generated.hanumagoudabanakar5_hash.pillproof.CounterfeitAlert_d18c5cd1
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ291bnRlcmZlaXRBbGVydCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJ2ZXJpZnlfYW5kX2ZyZWV6ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtZWRfYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJob2xkZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNjYW5uZWRfaGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidHJ1ZV9oYXNoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls2Nyw4M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc0LDkwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lESWdNUW9nSUNBZ0x5OGdRMjkxYm5SbGNtWmxhWFJCYkdWeWRDNXdlVG96Q2lBZ0lDQXZMeUJqYkdGemN5QkRiM1Z1ZEdWeVptVnBkRUZzWlhKMEtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBMUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnMllqVTRabUUzT0NBdkx5QnRaWFJvYjJRZ0luWmxjbWxtZVY5aGJtUmZabkpsWlhwbEtIVnBiblEyTkN4aFpHUnlaWE56TEdKNWRHVmJYU3hpZVhSbFcxMHBjM1J5YVc1bklnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5MlpYSnBabmxmWVc1a1gyWnlaV1Y2WlY5eWIzVjBaVUF6Q2lBZ0lDQmxjbklLQ20xaGFXNWZkbVZ5YVdaNVgyRnVaRjltY21WbGVtVmZjbTkxZEdWQU16b0tJQ0FnSUM4dklFTnZkVzUwWlhKbVpXbDBRV3hsY25RdWNIazZOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQW9nSUNBZ1lpQjJaWEpwWm5sZllXNWtYMlp5WldWNlpRb0tiV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUExT2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJEYjNWdWRHVnlabVZwZEVGc1pYSjBMa052ZFc1MFpYSm1aV2wwUVd4bGNuUXVkbVZ5YVdaNVgyRnVaRjltY21WbGVtVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AyWlhKcFpubGZZVzVrWDJaeVpXVjZaVG9LSUNBZ0lDOHZJRU52ZFc1MFpYSm1aV2wwUVd4bGNuUXVjSGs2TkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCRGIzVnVkR1Z5Wm1WcGRFRnNaWEowTG5CNU9qWUtJQ0FnSUM4dklHbG1JSE5qWVc1dVpXUmZhR0Z6YUNBaFBTQjBjblZsWDJoaGMyZzZDaUFnSUNBaFBRb2dJQ0FnWW5vZ2RtVnlhV1o1WDJGdVpGOW1jbVZsZW1WZllXWjBaWEpmYVdaZlpXeHpaVUEwQ2lBZ0lDQXZMeUJEYjNWdWRHVnlabVZwZEVGc1pYSjBMbkI1T2pjdE1URUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUkdjbVZsZW1Vb0NpQWdJQ0F2THlBZ0lDQWdabkpsWlhwbFgyRnpjMlYwUFcxbFpGOWhjM05sZEN3S0lDQWdJQzh2SUNBZ0lDQm1jbVZsZW1WZllXTmpiM1Z1ZEQxb2IyeGtaWElzQ2lBZ0lDQXZMeUFnSUNBZ1puSnZlbVZ1UFZSeWRXVUtJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUVOdmRXNTBaWEptWldsMFFXeGxjblF1Y0hrNk1UQUtJQ0FnSUM4dklHWnliM3BsYmoxVWNuVmxDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR2NtVmxlbVZCYzNObGRFWnliM3BsYmdvZ0lDQWdaSFZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVp5WldWNlpVRnpjMlYwUVdOamIzVnVkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbkpsWlhwbFFYTnpaWFFLSUNBZ0lDOHZJRU52ZFc1MFpYSm1aV2wwUVd4bGNuUXVjSGs2TndvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEVaeVpXVjZaU2dLSUNBZ0lIQjFjMmhwYm5RZ05TQXZMeUJoWm5KNkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJRU52ZFc1MFpYSm1aV2wwUVd4bGNuUXVjSGs2TnkweE1Rb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRFWnlaV1Y2WlNnS0lDQWdJQzh2SUNBZ0lDQm1jbVZsZW1WZllYTnpaWFE5YldWa1gyRnpjMlYwTEFvZ0lDQWdMeThnSUNBZ0lHWnlaV1Y2WlY5aFkyTnZkVzUwUFdodmJHUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCbWNtOTZaVzQ5VkhKMVpRb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUVOdmRXNTBaWEptWldsMFFXeGxjblF1Y0hrNk1USUtJQ0FnSUM4dklHeHZaeWdpUVV4RlVsUTZJRU52ZFc1MFpYSm1aV2wwSUdSbGRHVmpkR1ZrSVNCQmMzTmxkQ0JtY205NlpXNHVJaWtLSUNBZ0lIQjFjMmhpZVhSbGN5QWlRVXhGVWxRNklFTnZkVzUwWlhKbVpXbDBJR1JsZEdWamRHVmtJU0JCYzNObGRDQm1jbTk2Wlc0dUlnb2dJQ0FnYkc5bkNpQWdJQ0F2THlCRGIzVnVkR1Z5Wm1WcGRFRnNaWEowTG5CNU9qRXpDaUFnSUNBdkx5QnlaWFIxY200Z1UzUnlhVzVuS0NKRFQxVk9WRVZTUmtWSlZGOUVSVlJGUTFSRlJDSXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrTlBWVTVVUlZKR1JVbFVYMFJGVkVWRFZFVkVJZ29LZG1WeWFXWjVYMkZ1WkY5bWNtVmxlbVZmWVdaMFpYSmZhVzVzYVc1bFpGOURiM1Z1ZEdWeVptVnBkRUZzWlhKMExrTnZkVzUwWlhKbVpXbDBRV3hsY25RdWRtVnlhV1o1WDJGdVpGOW1jbVZsZW1WQU5Ub0tJQ0FnSUM4dklFTnZkVzUwWlhKbVpXbDBRV3hsY25RdWNIazZOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwMlpYSnBabmxmWVc1a1gyWnlaV1Y2WlY5aFpuUmxjbDlwWmw5bGJITmxRRFE2Q2lBZ0lDQXZMeUJEYjNWdWRHVnlabVZwZEVGc1pYSjBMbkI1T2pFMENpQWdJQ0F2THlCeVpYUjFjbTRnVTNSeWFXNW5LQ0pDUVZSRFNGOUhSVTVWU1U1Rklpa0tJQ0FnSUhCMWMyaGllWFJsY3lBaVFrRlVRMGhmUjBWT1ZVbE9SU0lLSUNBZ0lDOHZJRU52ZFc1MFpYSm1aV2wwUVd4bGNuUXVjSGs2TkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCaUlIWmxjbWxtZVY5aGJtUmZabkpsWlhwbFgyRm1kR1Z5WDJsdWJHbHVaV1JmUTI5MWJuUmxjbVpsYVhSQmJHVnlkQzVEYjNWdWRHVnlabVZwZEVGc1pYSjBMblpsY21sbWVWOWhibVJmWm5KbFpYcGxRRFVLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBREFBSUJNUnRCQUJpQUJHdFkrbmcyR2dDT0FRQUJBREVaRkRFWUVFUkNBQWd4R1JReEdCUVFRellhQVVrVmdRZ1NSQmMyR2dKSkZZRWdFa1EyR2dOSklsa2pDRXNCRlJKRVZ3SUFOaG9FU1NKWkl3aExBUlVTUkZjQ0FCTkJBR214SkxJdlNiSXVTd0d5TFlFRnNoQWlzZ0d6Z0NwQlRFVlNWRG9nUTI5MWJuUmxjbVpsYVhRZ1pHVjBaV04wWldRaElFRnpjMlYwSUdaeWIzcGxiaTZ3Z0JSRFQxVk9WRVZTUmtWSlZGOUVSVlJGUTFSRlJFa1ZGbGNHQWt4UWdBUVZIM3gxVEZDd0pFT0FEVUpCVkVOSVgwZEZUbFZKVGtWQy85cz0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo3LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
