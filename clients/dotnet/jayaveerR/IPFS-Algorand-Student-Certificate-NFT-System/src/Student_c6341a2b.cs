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

namespace Arc56.Generated.jayaveerR.IPFS_Algorand_Student_Certificate_NFT_System.Student_c6341a2b
{


    public class StudentProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public StudentProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset_name"> </param>
        /// <param name="unit_name"> </param>
        /// <param name="url"> </param>
        public async Task<ulong> Mint(string asset_name, string unit_name, string url, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 82, 199, 139, 222 };
            var asset_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); asset_nameAbi.From(asset_name);
            var unit_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); unit_nameAbi.From(unit_name);
            var urlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); urlAbi.From(url);

            var result = await base.CallApp(new List<object> { abiHandle, asset_nameAbi, unit_nameAbi, urlAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Mint_Transactions(string asset_name, string unit_name, string url, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 82, 199, 139, 222 };
            var asset_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); asset_nameAbi.From(asset_name);
            var unit_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); unit_nameAbi.From(unit_name);
            var urlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); urlAbi.From(url);

            return await base.MakeTransactionList(new List<object> { abiHandle, asset_nameAbi, unit_nameAbi, urlAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3R1ZGVudCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJtaW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0X25hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVuaXRfbmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXJsIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls0OCw2NCw4MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU1LDcxLDg3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJRElnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wZFdSbGJuUXZZMjl1ZEhKaFkzUXVjSGs2TXdvZ0lDQWdMeThnWTJ4aGMzTWdVM1IxWkdWdWRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU5Rb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5USmpOemhpWkdVZ0x5OGdiV1YwYUc5a0lDSnRhVzUwS0hOMGNtbHVaeXh6ZEhKcGJtY3NjM1J5YVc1bktYVnBiblEyTkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmYldsdWRGOXliM1YwWlVBekNpQWdJQ0JsY25JS0NtMWhhVzVmYldsdWRGOXliM1YwWlVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMGRXUmxiblF2WTI5dWRISmhZM1F1Y0hrNk5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnWWlCdGFXNTBDZ3B0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURVNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV6ZEhWa1pXNTBMbU52Ym5SeVlXTjBMbE4wZFdSbGJuUXViV2x1ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtMXBiblE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1IxWkdWdWRDOWpiMjUwY21GamRDNXdlVG8wQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkSFZrWlc1MEwyTnZiblJ5WVdOMExuQjVPall0TVRnS0lDQWdJQzh2SUNNZ1EzSmxZWFJsSUhSb1pTQmpaWEowYVdacFkyRjBaU0JPUmxRS0lDQWdJQzh2SUNNZ1FYTnphV2R1SUcxaGJtRm5aVzFsYm5RZ2EyVjVjeUIwYnlCMGFHVWdjMlZ1WkdWeUlDaEpjM04xWlhJcElITnZJSFJvWlhrZ2FHRjJaU0JqYjI1MGNtOXNDaUFnSUNBdkx5QmpjbVZoZEdWa1gyRnpjMlYwSUQwZ2FYUjRiaTVCYzNObGRFTnZibVpwWnlnS0lDQWdJQzh2SUNBZ0lDQjBiM1JoYkQweExBb2dJQ0FnTHk4Z0lDQWdJR1JsWTJsdFlXeHpQVEFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmYm1GdFpUMWhjM05sZEY5dVlXMWxMQW9nSUNBZ0x5OGdJQ0FnSUhWdWFYUmZibUZ0WlQxMWJtbDBYMjVoYldVc0NpQWdJQ0F2THlBZ0lDQWdkWEpzUFhWeWJDd0tJQ0FnSUM4dklDQWdJQ0J0WVc1aFoyVnlQVlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ2NtVnpaWEoyWlQxVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR1p5WldWNlpUMVVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUdOc1lYZGlZV05yUFZSNGJpNXpaVzVrWlhJc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncExtTnlaV0YwWldSZllYTnpaWFFLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRIVmtaVzUwTDJOdmJuUnlZV04wTG5CNU9qRTBDaUFnSUNBdkx5QnRZVzVoWjJWeVBWUjRiaTV6Wlc1a1pYSXNDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSMVpHVnVkQzlqYjI1MGNtRmpkQzV3ZVRveE5TMHhOd29nSUNBZ0x5OGdjbVZ6WlhKMlpUMVVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdabkpsWlhwbFBWUjRiaTV6Wlc1a1pYSXNDaUFnSUNBdkx5QmpiR0YzWW1GamF6MVVlRzR1YzJWdVpHVnlMQW9nSUNBZ1pIVndiaUF6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwUTJ4aGQySmhZMnNLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJHY21WbGVtVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUlNaWE5sY25abENpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFRXRnVZV2RsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEZWU1RBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRGVnVhWFJPWVcxbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFRtRnRaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBkV1JsYm5RdlkyOXVkSEpoWTNRdWNIazZNVEFLSUNBZ0lDOHZJR1JsWTJsdFlXeHpQVEFzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRVJsWTJsdFlXeHpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUjFaR1Z1ZEM5amIyNTBjbUZqZEM1d2VUbzVDaUFnSUNBdkx5QjBiM1JoYkQweExBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSVWIzUmhiQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBkV1JsYm5RdlkyOXVkSEpoWTNRdWNIazZOaTA0Q2lBZ0lDQXZMeUFqSUVOeVpXRjBaU0IwYUdVZ1kyVnlkR2xtYVdOaGRHVWdUa1pVQ2lBZ0lDQXZMeUFqSUVGemMybG5iaUJ0WVc1aFoyVnRaVzUwSUd0bGVYTWdkRzhnZEdobElITmxibVJsY2lBb1NYTnpkV1Z5S1NCemJ5QjBhR1Y1SUdoaGRtVWdZMjl1ZEhKdmJBb2dJQ0FnTHk4Z1kzSmxZWFJsWkY5aGMzTmxkQ0E5SUdsMGVHNHVRWE56WlhSRGIyNW1hV2NvQ2lBZ0lDQndkWE5vYVc1MElETWdMeThnWVdObVp3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1IxWkdWdWRDOWpiMjUwY21GamRDNXdlVG8yTFRFNENpQWdJQ0F2THlBaklFTnlaV0YwWlNCMGFHVWdZMlZ5ZEdsbWFXTmhkR1VnVGtaVUNpQWdJQ0F2THlBaklFRnpjMmxuYmlCdFlXNWhaMlZ0Wlc1MElHdGxlWE1nZEc4Z2RHaGxJSE5sYm1SbGNpQW9TWE56ZFdWeUtTQnpieUIwYUdWNUlHaGhkbVVnWTI5dWRISnZiQW9nSUNBZ0x5OGdZM0psWVhSbFpGOWhjM05sZENBOUlHbDBlRzR1UVhOelpYUkRiMjVtYVdjb0NpQWdJQ0F2THlBZ0lDQWdkRzkwWVd3OU1Td0tJQ0FnSUM4dklDQWdJQ0JrWldOcGJXRnNjejB3TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDI1aGJXVTlZWE56WlhSZmJtRnRaU3dLSUNBZ0lDOHZJQ0FnSUNCMWJtbDBYMjVoYldVOWRXNXBkRjl1WVcxbExBb2dJQ0FnTHk4Z0lDQWdJSFZ5YkQxMWNtd3NDaUFnSUNBdkx5QWdJQ0FnYldGdVlXZGxjajFVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNBZ0lISmxjMlZ5ZG1VOVZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0JtY21WbGVtVTlWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCamJHRjNZbUZqYXoxVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tTNWpjbVZoZEdWa1gyRnpjMlYwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJEY21WaGRHVmtRWE56WlhSSlJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMGRXUmxiblF2WTI5dWRISmhZM1F1Y0hrNk5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBkRzlpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBREFBSUJNUnRCQUJpQUJGTEhpOTQyR2dDT0FRQUJBREVaRkRFWUVFUkNBQWd4R1JReEdCUVFRellhQVVraVdTTUlTd0VWRWtSWEFnQTJHZ0pKSWxrakNFc0JGUkpFVndJQU5ob0RTU0paSXdoTEFSVVNSRmNDQUxFeEFFY0RzaXl5SzdJcXNpbXlKN0lsc2lZaXNpTWtzaUtCQTdJUUlySUJzN1E4Rm9BRUZSOThkVXhRc0NSRCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
