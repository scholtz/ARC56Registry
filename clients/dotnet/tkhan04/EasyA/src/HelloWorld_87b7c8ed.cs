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

namespace Arc56.Generated.tkhan04.EasyA.HelloWorld_87b7c8ed
{


    public class HelloWorldProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public HelloWorldProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="owner"> </param>
        /// <param name="shoeName"> </param>
        public async Task<string> Hello(string owner, string shoeName, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 86, 1, 255, 82 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); ownerAbi.From(owner);
            var shoeNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); shoeNameAbi.From(shoeName);

            var result = await base.CallApp(new List<object> { abiHandle, ownerAbi, shoeNameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Hello_Transactions(string owner, string shoeName, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 86, 1, 255, 82 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); ownerAbi.From(owner);
            var shoeNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); shoeNameAbi.From(shoeName);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi, shoeNameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiSGVsbG9Xb3JsZCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJoZWxsbyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2hvZU5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzI1XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzJdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOF0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nU0dWc2JHOVhiM0pzWkNCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMkpoY21WZmNtOTFkR2x1WjBBMkNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnMU5qQXhabVkxTWlBdkx5QnRaWFJvYjJRZ0ltaGxiR3h2S0hOMGNtbHVaeXh6ZEhKcGJtY3BjM1J5YVc1bklnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5b1pXeHNiMTl5YjNWMFpVQXpDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRBNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvekNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdTR1ZzYkc5WGIzSnNaQ0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIQjFjMmhwYm5RZ01DQXZMeUF3Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmYUdWc2JHOWZjbTkxZEdWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUUtJQ0FnSUM4dklIQjFZbXhwWXlCb1pXeHNieWh2ZDI1bGNqb2djM1J5YVc1bkxDQnphRzlsVG1GdFpUb2djM1J5YVc1bktUb2djM1J5YVc1bklIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk13b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRWhsYkd4dlYyOXliR1FnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUUtJQ0FnSUM4dklIQjFZbXhwWXlCb1pXeHNieWh2ZDI1bGNqb2djM1J5YVc1bkxDQnphRzlsVG1GdFpUb2djM1J5YVc1bktUb2djM1J5YVc1bklIc0tJQ0FnSUdOaGJHeHpkV0lnYUdWc2JHOEtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlltRnlaVjl5YjNWMGFXNW5RRFk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1NHVnNiRzlYYjNKc1pDQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUdOeVpXRjBhVzVuQ2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tobGJHeHZWMjl5YkdRdWFHVnNiRzhvYjNkdVpYSTZJR0o1ZEdWekxDQnphRzlsVG1GdFpUb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncG9aV3hzYnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRS0lDQWdJQzh2SUhCMVlteHBZeUJvWld4c2J5aHZkMjVsY2pvZ2MzUnlhVzVuTENCemFHOWxUbUZ0WlRvZ2MzUnlhVzVuS1RvZ2MzUnlhVzVuSUhzS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOUW9nSUNBZ0x5OGdjbVYwZFhKdUlHQklaV3hzYnl3Z0pIdHZkMjVsY24wZ0pIdHphRzlsVG1GdFpYMWdDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lraGxiR3h2TENBaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SUNJZ0lnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2pFYlFRQTZnQVJXQWY5U05ob0FqZ0VBQTRFQVF6RVpGRVF4R0VRMkdnRlhBZ0EyR2dKWEFnQ0lBQ0JKRlJaWEJnSk1VSUFFRlI5OGRVeFFzSUVCUXpFWlFQL09NUmdVUklFQlE0b0NBWUFIU0dWc2JHOHNJSXYrVUlBQklGQ0wvMUNKIiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6NywicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
