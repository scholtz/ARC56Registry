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

namespace Arc56.Generated.atsoc1993.Populate_App_Resources_Bug_Example_algokit_utils_python_library.TestPopResources_95a87b69
{


    public class TestPopResourcesProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TestPopResourcesProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="mbr_payment"> </param>
        public async Task PopulateTest(PaymentTransaction mbr_payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_payment });
            byte[] abiHandle = { 76, 64, 138, 209 };

            var result = await base.CallApp(new List<object> { abiHandle, mbr_payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PopulateTest_Transactions(PaymentTransaction mbr_payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_payment });
            byte[] abiHandle = { 76, 64, 138, 209 };

            return await base.MakeTransactionList(new List<object> { abiHandle, mbr_payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task ArbitraryAppCall(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 105, 243, 198, 228 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ArbitraryAppCall_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 105, 243, 198, 228 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVGVzdFBvcFJlc291cmNlcyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJwb3B1bGF0ZVRlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWJyX3BheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJiaXRyYXJ5X2FwcF9jYWxsIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNDYsNTVdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MiwxODBdLCJlcnJvck1lc3NhZ2UiOiJhY2NvdW50IGZ1bmRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgyXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDksNThdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjhdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCamIyNTBjbUZqZEM1VVpYTjBVRzl3VW1WemIzVnlZMlZ6TGw5ZllXeG5iM0I1WDJWdWRISjVjRzlwYm5SZmQybDBhRjlwYm1sMEtDa2dMVDRnZFdsdWREWTBPZ3B0WVdsdU9nb2dJQ0FnYVc1MFkySnNiMk5ySURFZ01Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VETXhJQ0l5SWlBaU15SWdJalFpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveE5nb2dJQ0FnTHk4Z1kyeGhjM01nVkdWemRGQnZjRkpsYzI5MWNtTmxjeWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWW1GeVpWOXliM1YwYVc1blFEY0tJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZzBZelF3T0dGa01TQXdlRFk1WmpOak5tVTBJQzh2SUcxbGRHaHZaQ0FpY0c5d2RXeGhkR1ZVWlhOMEtIQmhlU2wyYjJsa0lpd2diV1YwYUc5a0lDSmhjbUpwZEhKaGNubGZZWEJ3WDJOaGJHd29LWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDNCdmNIVnNZWFJsVkdWemRGOXliM1YwWlVBMUlHMWhhVzVmWVhKaWFYUnlZWEo1WDJGd2NGOWpZV3hzWDNKdmRYUmxRRFlLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBNU9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNVFlLSUNBZ0lDOHZJR05zWVhOeklGUmxjM1JRYjNCU1pYTnZkWEpqWlhNb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZWEppYVhSeVlYSjVYMkZ3Y0Y5allXeHNYM0p2ZFhSbFFEWTZDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG8yTUFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM0J2Y0hWc1lYUmxWR1Z6ZEY5eWIzVjBaVUExT2dvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk1qQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNVFlLSUNBZ0lDOHZJR05zWVhOeklGUmxjM1JRYjNCU1pYTnZkWEpqWlhNb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SUhCaGVRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUhCaGVRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNakFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lHTmhiR3h6ZFdJZ2NHOXdkV3hoZEdWVVpYTjBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgySmhjbVZmY205MWRHbHVaMEEzT2dvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk1UWUtJQ0FnSUM4dklHTnNZWE56SUZSbGMzUlFiM0JTWlhOdmRYSmpaWE1vUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBT1FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnWTNKbFlYUnBibWNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpiMjUwY21GamRDNVVaWE4wVUc5d1VtVnpiM1Z5WTJWekxuQnZjSFZzWVhSbFZHVnpkQ2h0WW5KZmNHRjViV1Z1ZERvZ2RXbHVkRFkwS1NBdFBpQjJiMmxrT2dwd2IzQjFiR0YwWlZSbGMzUTZDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG95TUMweU1Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnTHk4Z1pHVm1JSEJ2Y0hWc1lYUmxWR1Z6ZENoelpXeG1MQ0J0WW5KZmNHRjViV1Z1ZERvZ1ozUjRiaTVRWVhsdFpXNTBWSEpoYm5OaFkzUnBiMjRwSUMwK0lFNXZibVU2Q2lBZ0lDQndjbTkwYnlBeElEQUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPamNLSUNBZ0lDOHZJSEpsZEhWeWJpQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxtMXBibDlpWVd4aGJtTmxDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1lXTmpkRjl3WVhKaGJYTmZaMlYwSUVGalkzUk5hVzVDWVd4aGJtTmxDaUFnSUNCaGMzTmxjblFnTHk4Z1lXTmpiM1Z1ZENCbWRXNWtaV1FLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pJekNpQWdJQ0F2THlCaU1TQTlJRUp2ZUZKbFppaHJaWGs5SnpFbktRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaU1TSUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPak0xQ2lBZ0lDQXZMeUJpTVM1amNtVmhkR1VvYzJsNlpUMHhLUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdKdmVGOWpjbVZoZEdVS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk1qUUtJQ0FnSUM4dklHSXlJRDBnUW05NFVtVm1LR3RsZVQwbk1pY3BDaUFnSUNCaWVYUmxZMTh4SUM4dklDSXlJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TXpZS0lDQWdJQzh2SUdJeUxtTnlaV0YwWlNoemFYcGxQVEVwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1ltOTRYMk55WldGMFpRb2dJQ0FnY0c5d0NpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3lOUW9nSUNBZ0x5OGdZak1nUFNCQ2IzaFNaV1lvYTJWNVBTY3pKeWtLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJak1pQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvek53b2dJQ0FnTHk4Z1lqTXVZM0psWVhSbEtITnBlbVU5TVNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQmliM2hmWTNKbFlYUmxDaUFnSUNCd2IzQUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakkyQ2lBZ0lDQXZMeUJpTkNBOUlFSnZlRkpsWmloclpYazlKelFuS1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpTkNJS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qTTRDaUFnSUNBdkx5QmlOQzVqY21WaGRHVW9jMmw2WlQweEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR0p2ZUY5amNtVmhkR1VLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TWpjS0lDQWdJQzh2SUdJMUlEMGdRbTk0VW1WbUtHdGxlVDBuTlNjcENpQWdJQ0J3ZFhOb1lubDBaWE1nSWpVaUNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3pPUW9nSUNBZ0x5OGdZalV1WTNKbFlYUmxLSE5wZW1VOU1Ta0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0JpYjNoZlkzSmxZWFJsQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pJNENpQWdJQ0F2THlCaU5pQTlJRUp2ZUZKbFppaHJaWGs5SnpZbktRb2dJQ0FnY0hWemFHSjVkR1Z6SUNJMklnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZOREFLSUNBZ0lDOHZJR0kyTG1OeVpXRjBaU2h6YVhwbFBURXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnWW05NFgyTnlaV0YwWlFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveU9Rb2dJQ0FnTHk4Z1lqY2dQU0JDYjNoU1pXWW9hMlY1UFNjM0p5a0tJQ0FnSUhCMWMyaGllWFJsY3lBaU55SUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPalF4Q2lBZ0lDQXZMeUJpTnk1amNtVmhkR1VvYzJsNlpUMHhLUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdKdmVGOWpjbVZoZEdVS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk16QUtJQ0FnSUM4dklHSTRJRDBnUW05NFVtVm1LR3RsZVQwbk9DY3BDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lqZ2lDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG8wTWdvZ0lDQWdMeThnWWpndVkzSmxZWFJsS0hOcGVtVTlNU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCaWIzaGZZM0psWVhSbENpQWdJQ0J3YjNBS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qTXhDaUFnSUNBdkx5QmlPU0E5SUVKdmVGSmxaaWhyWlhrOUp6a25LUW9nSUNBZ2NIVnphR0o1ZEdWeklDSTVJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TkRNS0lDQWdJQzh2SUdJNUxtTnlaV0YwWlNoemFYcGxQVEVwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1ltOTRYMk55WldGMFpRb2dJQ0FnY0c5d0NpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3lNd29nSUNBZ0x5OGdZakVnUFNCQ2IzaFNaV1lvYTJWNVBTY3hKeWtLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJakVpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvME5Rb2dJQ0FnTHk4Z1lqRXVjSFYwS0dJbk1TY3BDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pJMENpQWdJQ0F2THlCaU1pQTlJRUp2ZUZKbFppaHJaWGs5SnpJbktRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaU1pSUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPalEyQ2lBZ0lDQXZMeUJpTWk1d2RYUW9ZaWN4SnlrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnek1Rb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TWpVS0lDQWdJQzh2SUdJeklEMGdRbTk0VW1WbUtHdGxlVDBuTXljcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNJeklnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZORGNLSUNBZ0lDOHZJR0l6TG5CMWRDaGlKekVuS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURNeENpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG95TmdvZ0lDQWdMeThnWWpRZ1BTQkNiM2hTWldZb2EyVjVQU2MwSnlrS0lDQWdJR0o1ZEdWalh6TWdMeThnSWpRaUNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUbzBPQW9nSUNBZ0x5OGdZalF1Y0hWMEtHSW5NU2NwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TXpFS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakkzQ2lBZ0lDQXZMeUJpTlNBOUlFSnZlRkpsWmloclpYazlKelVuS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0kxSWdvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk5Ea0tJQ0FnSUM4dklHSTFMbkIxZENoaUp6RW5LUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlRE14Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3lPQW9nSUNBZ0x5OGdZallnUFNCQ2IzaFNaV1lvYTJWNVBTYzJKeWtLSUNBZ0lIQjFjMmhpZVhSbGN5QWlOaUlLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pVd0NpQWdJQ0F2THlCaU5pNXdkWFFvWWljeEp5a0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3pNUW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk1qa0tJQ0FnSUM4dklHSTNJRDBnUW05NFVtVm1LR3RsZVQwbk55Y3BDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lqY2lDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG8xTVFvZ0lDQWdMeThnWWpjdWNIVjBLR0luTVNjcENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE16RUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pNd0NpQWdJQ0F2THlCaU9DQTlJRUp2ZUZKbFppaHJaWGs5SnpnbktRb2dJQ0FnY0hWemFHSjVkR1Z6SUNJNElnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZOVElLSUNBZ0lDOHZJR0k0TG5CMWRDaGlKekVuS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURNeENpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG96TVFvZ0lDQWdMeThnWWprZ1BTQkNiM2hTWldZb2EyVjVQU2M1SnlrS0lDQWdJSEIxYzJoaWVYUmxjeUFpT1NJS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qVXpDaUFnSUNBdkx5QmlPUzV3ZFhRb1lpY3hKeWtLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd6TVFvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZOd29nSUNBZ0x5OGdjbVYwZFhKdUlFZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNdWJXbHVYMkpoYkdGdVkyVUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCaFkyTjBYM0JoY21GdGMxOW5aWFFnUVdOamRFMXBia0poYkdGdVkyVUtJQ0FnSUdGemMyVnlkQ0F2THlCaFkyTnZkVzUwSUdaMWJtUmxaQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TlRZS0lDQWdJQzh2SUcxaWNsOWthV1ptSUQwZ2NHOXpkRjl0WW5JZ0xTQndjbVZmYldKeUNpQWdJQ0J6ZDJGd0NpQWdJQ0F0Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvMU53b2dJQ0FnTHk4Z1pYaGpaWE56SUQwZ2JXSnlYM0JoZVcxbGJuUXVZVzF2ZFc1MElDMGdiV0p5WDJScFptWUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENpQWdJQ0J6ZDJGd0NpQWdJQ0F0Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveE1TMHhOQW9nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeVBWUjRiaTV6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBQV1Y0WTJWemN3b2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk1USUtJQ0FnSUM4dklISmxZMlZwZG1WeVBWUjRiaTV6Wlc1a1pYSXNDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZKbFkyVnBkbVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ0YjNWdWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNVEVLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJR2x1ZEdOZk1DQXZMeUJ3WVhrS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TVRFdE1UUUtJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2oxVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMWxlR05sYzNNS0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnlaWFJ6ZFdJSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFDQVFBbUJBRXhBVElCTXdFME1SdEJBRGFDQWdSTVFJclJCR256eHVRMkdnQ09BZ0FMQUFJalF6RVpGRVF4R0VRaVF6RVpGRVF4R0VReEZpSUpTVGdRSWhKRWlBQU5Ja014R1VELzJqRVlGRVFpUTRvQkFESUtjd0ZFS0NLNVNDa2l1VWdxSXJsSUt5SzVTSUFCTlNLNVNJQUJOaUs1U0lBQk55SzVTSUFCT0NLNVNJQUJPU0s1U0NoSnZ5a292eW9vdnlzb3Y0QUJOU2kvZ0FFMktMK0FBVGNvdjRBQk9DaS9nQUU1S0w4eUNuTUJSRXdKaS84NENFd0pzVEVBc2dleUNDS3lFQ095QWJPSiIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjEwLCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
