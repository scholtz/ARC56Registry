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

namespace Arc56.Generated.aorumbayev.puya.Contract_f6adb9f7
{


    public class ContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task TestNewOps(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 184, 221, 138 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestNewOps_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 184, 221, 138 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ29udHJhY3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoidGVzdF9uZXdfb3BzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjhdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MV0sImVycm9yTWVzc2FnZSI6ImJvbnVzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzZdLCJlcnJvck1lc3NhZ2UiOiJicmFuY2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NV0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgzXSwiZXJyb3JNZXNzYWdlIjoiZmVlIHNpbmsiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2N10sImVycm9yTWVzc2FnZSI6ImZlZXMgY29sbGVjdGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTldLCJlcnJvck1lc3NhZ2UiOiJwYXlvdXRzX2VuYWJsZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDJdLCJlcnJvck1lc3NhZ2UiOiJwYXlvdXRzX2dvX29ubGluZV9mZWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTFdLCJlcnJvck1lc3NhZ2UiOiJwYXlvdXRzX21heF9iYWxhbmNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA4XSwiZXJyb3JNZXNzYWdlIjoicGF5b3V0c19taW5fYmFsYW5jZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNV0sImVycm9yTWVzc2FnZSI6InBheW91dHNfcGVyY2VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYzXSwiZXJyb3JNZXNzYWdlIjoicHJvcG9zZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5Nl0sImVycm9yTWVzc2FnZSI6InByb3Bvc2VyIHBheW91dCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg4XSwiZXJyb3JNZXNzYWdlIjoicHJvdG9jb2wiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5Ml0sImVycm9yTWVzc2FnZSI6InR4biBjb3VudGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERUtJQ0FnSUM4dklHRjJiVjh4TVM5amIyNTBjbUZqZEM1d2VUbzBDaUFnSUNBdkx5QmpiR0Z6Y3lCRGIyNTBjbUZqZENoQlVrTTBRMjl1ZEhKaFkzUXNJR0YyYlY5MlpYSnphVzl1UFRFeEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDJKaGNtVmZjbTkxZEdsdVowQTJDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGpNbUk0WkdRNFlTQXZMeUJ0WlhSb2IyUWdJblJsYzNSZmJtVjNYMjl3Y3lncGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZkR1Z6ZEY5dVpYZGZiM0J6WDNKdmRYUmxRRE1LQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE1Eb0tJQ0FnSUM4dklHRjJiVjh4TVM5amIyNTBjbUZqZEM1d2VUbzBDaUFnSUNBdkx5QmpiR0Z6Y3lCRGIyNTBjbUZqZENoQlVrTTBRMjl1ZEhKaFkzUXNJR0YyYlY5MlpYSnphVzl1UFRFeEtUb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnpkRjl1WlhkZmIzQnpYM0p2ZFhSbFFETTZDaUFnSUNBdkx5QmhkbTFmTVRFdlkyOXVkSEpoWTNRdWNIazZOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEY5dVpYZGZiM0J6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkpoY21WZmNtOTFkR2x1WjBBMk9nb2dJQ0FnTHk4Z1lYWnRYekV4TDJOdmJuUnlZV04wTG5CNU9qUUtJQ0FnSUM4dklHTnNZWE56SUVOdmJuUnlZV04wS0VGU1F6UkRiMjUwY21GamRDd2dZWFp0WDNabGNuTnBiMjQ5TVRFcE9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TUFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnWTNKbFlYUnBibWNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMbUYyYlY4eE1TNWpiMjUwY21GamRDNURiMjUwY21GamRDNTBaWE4wWDI1bGQxOXZjSE1vS1NBdFBpQjJiMmxrT2dwMFpYTjBYMjVsZDE5dmNITTZDaUFnSUNBdkx5QmhkbTFmTVRFdlkyOXVkSEpoWTNRdWNIazZOeTA0Q2lBZ0lDQXZMeUFqSUc5d0lHWjFibU4wYVc5dWN3b2dJQ0FnTHk4Z1lYTnpaWEowSUc5d0xtOXViR2x1WlY5emRHRnJaU2dwQ2lBZ0lDQnZibXhwYm1WZmMzUmhhMlVLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnWVhadFh6RXhMMk52Ym5SeVlXTjBMbkI1T2prS0lDQWdJQzh2SUdGemMyVnlkQ0J2Y0M1dGFXMWpLRzl3TGsxcFRVTkRiMjVtYVdkMWNtRjBhVzl1Y3k1Q1RqSTFORTF3TVRFd0xDQnZjQzVpZW1WeWJ5Z3pNaWtwQ2lBZ0lDQndkWE5vYVc1MElETXlJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnYldsdFl5QkNUakkxTkUxd01URXdDaUFnSUNCc1pXNEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdZWFp0WHpFeEwyTnZiblJ5WVdOMExuQjVPakUyTFRFM0NpQWdJQ0F2THlBaklFSnNiMk5yQ2lBZ0lDQXZMeUJoYzNObGNuUWdibTkwSUc5d0xrSnNiMk5yTG1Kc2ExOXdjbTl3YjNObGNpZ3dLU3dnSW5CeWIzQnZjMlZ5SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSnNiMk5ySUVKc2ExQnliM0J2YzJWeUNpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2NISnZjRzl6WlhJS0lDQWdJQzh2SUdGMmJWOHhNUzlqYjI1MGNtRmpkQzV3ZVRveE9Bb2dJQ0FnTHk4Z1lYTnpaWEowSUc5d0xrSnNiMk5yTG1Kc2ExOW1aV1Z6WDJOdmJHeGxZM1JsWkNnd0tTd2dJbVpsWlhNZ1kyOXNiR1ZqZEdWa0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0pzYjJOcklFSnNhMFpsWlhORGIyeHNaV04wWldRS0lDQWdJR0Z6YzJWeWRDQXZMeUJtWldWeklHTnZiR3hsWTNSbFpBb2dJQ0FnTHk4Z1lYWnRYekV4TDJOdmJuUnlZV04wTG5CNU9qRTVDaUFnSUNBdkx5QmhjM05sY25RZ2IzQXVRbXh2WTJzdVlteHJYMkp2Ym5WektEQXBMQ0FpWW05dWRYTWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW14dlkyc2dRbXhyUW05dWRYTUtJQ0FnSUdGemMyVnlkQ0F2THlCaWIyNTFjd29nSUNBZ0x5OGdZWFp0WHpFeEwyTnZiblJ5WVdOMExuQjVPakl3Q2lBZ0lDQXZMeUJoYzNObGNuUWdiM0F1UW14dlkyc3VZbXhyWDJKeVlXNWphQ2d3S1N3Z0ltSnlZVzVqYUNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmliRzlqYXlCQ2JHdENjbUZ1WTJnS0lDQWdJR3hsYmdvZ0lDQWdZWE56WlhKMElDOHZJR0p5WVc1amFBb2dJQ0FnTHk4Z1lYWnRYekV4TDJOdmJuUnlZV04wTG5CNU9qSXhDaUFnSUNBdkx5QmhjM05sY25RZ2IzQXVRbXh2WTJzdVlteHJYMlpsWlY5emFXNXJLREFwTENBaVptVmxJSE5wYm1zaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbXh2WTJzZ1FteHJSbVZsVTJsdWF3b2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowSUM4dklHWmxaU0J6YVc1ckNpQWdJQ0F2THlCaGRtMWZNVEV2WTI5dWRISmhZM1F1Y0hrNk1qSUtJQ0FnSUM4dklHRnpjMlZ5ZENCdmNDNUNiRzlqYXk1aWJHdGZjSEp2ZEc5amIyd29NQ2tzSUNKd2NtOTBiMk52YkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmliRzlqYXlCQ2JHdFFjbTkwYjJOdmJBb2dJQ0FnYkdWdUNpQWdJQ0JoYzNObGNuUWdMeThnY0hKdmRHOWpiMndLSUNBZ0lDOHZJR0YyYlY4eE1TOWpiMjUwY21GamRDNXdlVG95TXdvZ0lDQWdMeThnWVhOelpYSjBJRzl3TGtKc2IyTnJMbUpzYTE5MGVHNWZZMjkxYm5SbGNpZ3dLU3dnSW5SNGJpQmpiM1Z1ZEdWeUlnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0pzYjJOcklFSnNhMVI0YmtOdmRXNTBaWElLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBlRzRnWTI5MWJuUmxjZ29nSUNBZ0x5OGdZWFp0WHpFeEwyTnZiblJ5WVdOMExuQjVPakkwQ2lBZ0lDQXZMeUJoYzNObGNuUWdiM0F1UW14dlkyc3VZbXhyWDNCeWIzQnZjMlZ5WDNCaGVXOTFkQ2d3S1N3Z0luQnliM0J2YzJWeUlIQmhlVzkxZENJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmliRzlqYXlCQ2JHdFFjbTl3YjNObGNsQmhlVzkxZEFvZ0lDQWdZWE56WlhKMElDOHZJSEJ5YjNCdmMyVnlJSEJoZVc5MWRBb2dJQ0FnTHk4Z1lYWnRYekV4TDJOdmJuUnlZV04wTG5CNU9qSTJMVEkzQ2lBZ0lDQXZMeUFqSUVkc2IySmhiQW9nSUNBZ0x5OGdZWE56WlhKMElHOXdMa2RzYjJKaGJDNXdZWGx2ZFhSelgyVnVZV0pzWldRc0lDSndZWGx2ZFhSelgyVnVZV0pzWldRaUNpQWdJQ0JuYkc5aVlXd2dVR0Y1YjNWMGMwVnVZV0pzWldRS0lDQWdJR0Z6YzJWeWRDQXZMeUJ3WVhsdmRYUnpYMlZ1WVdKc1pXUUtJQ0FnSUM4dklHRjJiVjh4TVM5amIyNTBjbUZqZEM1d2VUb3lPQW9nSUNBZ0x5OGdZWE56WlhKMElHOXdMa2RzYjJKaGJDNXdZWGx2ZFhSelgyZHZYMjl1YkdsdVpWOW1aV1VzSUNKd1lYbHZkWFJ6WDJkdlgyOXViR2x1WlY5bVpXVWlDaUFnSUNCbmJHOWlZV3dnVUdGNWIzVjBjMGR2VDI1c2FXNWxSbVZsQ2lBZ0lDQmhjM05sY25RZ0x5OGdjR0Y1YjNWMGMxOW5iMTl2Ym14cGJtVmZabVZsQ2lBZ0lDQXZMeUJoZG0xZk1URXZZMjl1ZEhKaFkzUXVjSGs2TWprS0lDQWdJQzh2SUdGemMyVnlkQ0J2Y0M1SGJHOWlZV3d1Y0dGNWIzVjBjMTl3WlhKalpXNTBMQ0FpY0dGNWIzVjBjMTl3WlhKalpXNTBJZ29nSUNBZ1oyeHZZbUZzSUZCaGVXOTFkSE5RWlhKalpXNTBDaUFnSUNCaGMzTmxjblFnTHk4Z2NHRjViM1YwYzE5d1pYSmpaVzUwQ2lBZ0lDQXZMeUJoZG0xZk1URXZZMjl1ZEhKaFkzUXVjSGs2TXpBS0lDQWdJQzh2SUdGemMyVnlkQ0J2Y0M1SGJHOWlZV3d1Y0dGNWIzVjBjMTl0YVc1ZlltRnNZVzVqWlN3Z0luQmhlVzkxZEhOZmJXbHVYMkpoYkdGdVkyVWlDaUFnSUNCbmJHOWlZV3dnVUdGNWIzVjBjMDFwYmtKaGJHRnVZMlVLSUNBZ0lHRnpjMlZ5ZENBdkx5QndZWGx2ZFhSelgyMXBibDlpWVd4aGJtTmxDaUFnSUNBdkx5QmhkbTFmTVRFdlkyOXVkSEpoWTNRdWNIazZNekVLSUNBZ0lDOHZJR0Z6YzJWeWRDQnZjQzVIYkc5aVlXd3VjR0Y1YjNWMGMxOXRZWGhmWW1Gc1lXNWpaU3dnSW5CaGVXOTFkSE5mYldGNFgySmhiR0Z1WTJVaUNpQWdJQ0JuYkc5aVlXd2dVR0Y1YjNWMGMwMWhlRUpoYkdGdVkyVUtJQ0FnSUdGemMyVnlkQ0F2THlCd1lYbHZkWFJ6WDIxaGVGOWlZV3hoYm1ObENpQWdJQ0F2THlCaGRtMWZNVEV2WTI5dWRISmhZM1F1Y0hrNk16TXRNelFLSUNBZ0lDOHZJQ01nVm05MFpYSWdjR0Z5WVcxekNpQWdJQ0F2THlCbkxDQm9JRDBnYjNBdVZtOTBaWEpRWVhKaGJYTkhaWFF1ZG05MFpYSmZZbUZzWVc1alpTZ3dLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhadmRHVnlYM0JoY21GdGMxOW5aWFFnVm05MFpYSkNZV3hoYm1ObENpQWdJQ0J3YjNCdUlESUtJQ0FnSUM4dklHRjJiVjh4TVM5amIyNTBjbUZqZEM1d2VUb3pOUW9nSUNBZ0x5OGdhU3dnYWlBOUlHOXdMbFp2ZEdWeVVHRnlZVzF6UjJWMExuWnZkR1Z5WDJsdVkyVnVkR2wyWlY5bGJHbG5hV0pzWlNnd0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFp2ZEdWeVgzQmhjbUZ0YzE5blpYUWdWbTkwWlhKSmJtTmxiblJwZG1WRmJHbG5hV0pzWlFvZ0lDQWdjRzl3YmlBeUNpQWdJQ0J5WlhSemRXSUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBQ0FBRXhHMEVBRzRBRXdyamRpallhQUk0QkFBSWlRekVaRkVReEdFU0lBQTBqUXpFWlFQL3RNUmdVUkNORGRVU0JJSy9tQUJWRUl0RUNNZ01TUkNMUkEwUWkwUVJFSXRFRkZVUWkwUVl5QXhORUl0RUhGVVFpMFFoRUl0RUpSRElTUkRJVFJESVVSRElWUkRJV1JDSjBBRVlDSW5RQlJnS0oiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjk5LCJtaW5vciI6OTksInBhdGNoIjo5OSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
