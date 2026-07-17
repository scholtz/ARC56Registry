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

namespace Arc56.Generated.SimonYuvarlak.Algorand_Course.TypesDemo_1ee3c38c
{


    public class TypesDemoProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TypesDemoProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task DemonstrateTypes(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 6, 195, 17, 213 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DemonstrateTypes_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 6, 195, 17, 213 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVHlwZXNEZW1vIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImRlbW9uc3RyYXRlX3R5cGVzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMzddLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wICYmIGNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCAmJiBjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGVYQmxjeTlqYjI1MGNtRmpkQzV3ZVRveE5nb2dJQ0FnTHk4Z1kyeGhjM01nVkhsd1pYTkVaVzF2S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUExQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3Tm1Nek1URmtOU0F2THlCdFpYUm9iMlFnSW1SbGJXOXVjM1J5WVhSbFgzUjVjR1Z6S0NsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOWtaVzF2Ym5OMGNtRjBaVjkwZVhCbGMxOXliM1YwWlVBekNpQWdJQ0JsY25JS0NtMWhhVzVmWkdWdGIyNXpkSEpoZEdWZmRIbHdaWE5mY205MWRHVkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBlWEJsY3k5amIyNTBjbUZqZEM1d2VUb3hPQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ1ltQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUcxMWMzUWdZbVVnVG05UGNDQW1KaUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JpSUdSbGJXOXVjM1J5WVhSbFgzUjVjR1Z6Q2dwdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFEVTZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdiWFZ6ZENCaVpTQk9iMDl3SUNZbUlHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQmpjbVZoZEdsdVp3b2dJQ0FnY0hWemFHbHVkQ0F4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1MGVYQmxjeTVqYjI1MGNtRmpkQzVVZVhCbGMwUmxiVzh1WkdWdGIyNXpkSEpoZEdWZmRIbHdaWE5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwa1pXMXZibk4wY21GMFpWOTBlWEJsY3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwZVhCbGN5OWpiMjUwY21GamRDNXdlVG95TmdvZ0lDQWdMeThnYkc5bktFSjVkR1Z6S0dJaUxTMHRJRlZKYm5RMk5DQkVSVTFQSUMwdExTSXBLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNbVF5WkRKa01qQTFOVFE1Tm1VM05ETTJNelF5TURRME5EVTBaRFJtTWpBeVpESmtNbVFLSUNBZ0lHeHZad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qSXdMVEl6Q2lBZ0lDQXZMeUFqSUQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQUW9nSUNBZ0x5OGdJeUF4TGlCVlNXNTBOalFnS0ZSb1pTQk5iMjVsZVNCVWVYQmxLUW9nSUNBZ0x5OGdJeUE5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMEtJQ0FnSUM4dklHMTVYM05qYjNKbElEMGdWVWx1ZERZMEtERXdNQ2tLSUNBZ0lIQjFjMmhwYm5RZ01UQXdJQzh2SURFd01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSNWNHVnpMMk52Ym5SeVlXTjBMbkI1T2pJM0NpQWdJQ0F2THlCc2IyY29iM0F1YVhSdllpaHRlVjl6WTI5eVpTa3BDaUFnSUNCcGRHOWlDaUFnSUNCc2IyY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGVYQmxjeTlqYjI1MGNtRmpkQzV3ZVRvME1Rb2dJQ0FnTHk4Z2JHOW5LRUo1ZEdWektHSWlMUzB0SUVKWlZFVlRJRVJGVFU4Z0xTMHRJaWtwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd5WkRKa01tUXlNRFF5TlRrMU5EUTFOVE15TURRME5EVTBaRFJtTWpBeVpESmtNbVFLSUNBZ0lHeHZad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qTTFMVE0yQ2lBZ0lDQXZMeUFqSUNkdmNDNWpiMjVqWVhRbklIZHZjbXR6SUdadmNpQnFiMmx1YVc1bkNpQWdJQ0F2THlCdFpYTnpZV2RsSUQwZ2IzQXVZMjl1WTJGMEtHZHlaV1YwYVc1bkxDQnVZVzFsS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TkRnMk5UWmpObU0yWmpReE5tTTJOelptTnpJMk1UWmxOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBlWEJsY3k5amIyNTBjbUZqZEM1d2VUbzBNZ29nSUNBZ0x5OGdiRzluS0cxbGMzTmhaMlVwQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBlWEJsY3k5amIyNTBjbUZqZEM1d2VUb3pPQzB6T1FvZ0lDQWdMeThnSXlCR1NWZzZJRlZ6WlNBdWJHVnVaM1JvSUhCeWIzQmxjblI1SUdadmNpQkNlWFJsY3dvZ0lDQWdMeThnYkdWdVozUm9JRDBnYldWemMyRm5aUzVzWlc1bmRHZ0tJQ0FnSUhCMWMyaHBiblFnTVRNZ0x5OGdNVE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBlWEJsY3k5amIyNTBjbUZqZEM1d2VUbzBNd29nSUNBZ0x5OGdiRzluS0c5d0xtbDBiMklvYkdWdVozUm9LU2tLSUNBZ0lHbDBiMklLSUNBZ0lHeHZad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qUTFMVFE0Q2lBZ0lDQXZMeUFqSUQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQUW9nSUNBZ0x5OGdJeUF6TGlCU1pXWmxjbVZ1WTJVZ1ZIbHdaWE1nS0VOb1lXbHVJRVZ1ZEdsMGFXVnpLUW9nSUNBZ0x5OGdJeUE5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMEtJQ0FnSUM4dklIVnpaWEk2SUVGalkyOTFiblFnUFNCVWVHNHVjMlZ1WkdWeUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSGx3WlhNdlkyOXVkSEpoWTNRdWNIazZOVFFLSUNBZ0lDOHZJR3h2WnloQ2VYUmxjeWhpSWkwdExTQlNSVVpGVWtWT1EwVWdSRVZOVHlBdExTMGlLU2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREprTW1ReVpESXdOVEkwTlRRMk5EVTFNalExTkdVME16UTFNakEwTkRRMU5HUTBaakl3TW1ReVpESmtDaUFnSUNCc2IyY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGVYQmxjeTlqYjI1MGNtRmpkQzV3ZVRvMU1nb2dJQ0FnTHk4Z2JYbGZZWEJ3SUQwZ1FYQndiR2xqWVhScGIyNG9PVGs1S1FvZ0lDQWdjSFZ6YUdsdWRDQTVPVGtnTHk4Z09UazVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRIbHdaWE12WTI5dWRISmhZM1F1Y0hrNk5UWXROVGNLSUNBZ0lDOHZJQ01nUTJobFkyc2dUM0IwTFVsdUlITjBZWFIxY3dvZ0lDQWdMeThnYVdZZ2IzQXVZWEJ3WDI5d2RHVmtYMmx1S0hWelpYSXNJRzE1WDJGd2NDazZDaUFnSUNCaGNIQmZiM0IwWldSZmFXNEtJQ0FnSUdKNklHUmxiVzl1YzNSeVlYUmxYM1I1Y0dWelgyVnNjMlZmWW05a2VVQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRIbHdaWE12WTI5dWRISmhZM1F1Y0hrNk5UZ0tJQ0FnSUM4dklHeHZaeWhDZVhSbGN5aGlJbFZ6WlhJZ2FYTWdiM0IwWldRZ2FXNGhJaWtwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcxTlRjek5qVTNNakl3TmprM016SXdObVkzTURjME5qVTJOREl3TmprMlpUSXhDaUFnSUNCc2IyY0tDbVJsYlc5dWMzUnlZWFJsWDNSNWNHVnpYMkZtZEdWeVgybG1YMlZzYzJWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGVYQmxjeTlqYjI1MGNtRmpkQzV3ZVRveE9Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnY0hWemFHbHVkQ0F4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LWkdWdGIyNXpkSEpoZEdWZmRIbHdaWE5mWld4elpWOWliMlI1UURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhsd1pYTXZZMjl1ZEhKaFkzUXVjSGs2TmpBS0lDQWdJQzh2SUd4dlp5aENlWFJsY3loaUlsVnpaWElnYVhNZ1RrOVVJRzl3ZEdWa0lHbHVMaUlwS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TlRVM016WTFOekl5TURZNU56TXlNRFJsTkdZMU5ESXdObVkzTURjME5qVTJOREl3TmprMlpUSmxDaUFnSUNCc2IyY0tJQ0FnSUdJZ1pHVnRiMjV6ZEhKaGRHVmZkSGx3WlhOZllXWjBaWEpmYVdaZlpXeHpaVUEwQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDekViUVFBWWdBUUd3eEhWTmhvQWpnRUFBUUF4R1JReEdCQkVRZ0FMTVJrVU1SZ1VFRVNCQVVPQUV5MHRMU0JWU1c1ME5qUWdSRVZOVHlBdExTMndnV1FXc0lBU0xTMHRJRUpaVkVWVElFUkZUVThnTFMwdHNJQU5TR1ZzYkc5QmJHZHZjbUZ1WkxDQkRSYXdNUUNBRmkwdExTQlNSVVpGVWtWT1EwVWdSRVZOVHlBdExTMndnZWNIWVVFQUY0QVJWWE5sY2lCcGN5QnZjSFJsWkNCcGJpR3dnUUZEZ0JWVmMyVnlJR2x6SUU1UFZDQnZjSFJsWkNCcGJpNndRdi9pIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
