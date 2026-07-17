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

namespace Arc56.Generated.SimonYuvarlak.Algorand_Course.TypesDemo_4798a467
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
        ///Main demonstration method.
        ///We use 'public' so it can be called from outside (like in our deploy script).
        ///</summary>
        public async Task DemonstrateTypes(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 123, 12, 188, 105 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DemonstrateTypes_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 123, 12, 188, 105 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVHlwZXNEZW1vIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImRlbW9uc3RyYXRlVHlwZXMiLCJkZXNjIjoiTWFpbiBkZW1vbnN0cmF0aW9uIG1ldGhvZC5cbldlIHVzZSAncHVibGljJyBzbyBpdCBjYW4gYmUgY2FsbGVkIGZyb20gb3V0c2lkZSAobGlrZSBpbiBvdXIgZGVwbG95IHNjcmlwdCkuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNzJdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wICYmIGNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYxXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCAmJiBjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ4XSwiZXJyb3JNZXNzYWdlIjoiYWNjb3VudCBmdW5kZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCaWVYUmxZMkpzYjJOcklHSmhjMlV6TWloTFFsbFJNMEl6VkRWT1ZFeElUVFJOUkRkTVZVczBUVmcxTmt4UVZVeFpUa2RNTmpKVU0wUkVTVEkxVmtwVk5raE5NMEZCS1FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1I1Y0dWekwzUjVjR1Z6WDJSbGJXOHVZV3huYnk1MGN6b3hOZ29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZSNWNHVnpSR1Z0YnlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQTFDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzNZakJqWW1NMk9TQXZMeUJ0WlhSb2IyUWdJbVJsYlc5dWMzUnlZWFJsVkhsd1pYTW9LWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDJSbGJXOXVjM1J5WVhSbFZIbHdaWE5mY205MWRHVkFNd29nSUNBZ1pYSnlDZ3B0WVdsdVgyUmxiVzl1YzNSeVlYUmxWSGx3WlhOZmNtOTFkR1ZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwZVhCbGN5OTBlWEJsYzE5a1pXMXZMbUZzWjI4dWRITTZNaklLSUNBZ0lDOHZJSEIxWW14cFl5QmtaVzF2Ym5OMGNtRjBaVlI1Y0dWektDazZJSFp2YVdRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDWW1DaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJRzExYzNRZ1ltVWdUbTlQY0NBbUppQmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmlJR1JsYlc5dWMzUnlZWFJsVkhsd1pYTUtDbTFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhsd1pYTXZkSGx3WlhOZlpHVnRieTVoYkdkdkxuUnpPakUyQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1ZIbHdaWE5FWlcxdklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHMTFjM1FnWW1VZ1RtOVBjQ0FtSmlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z1kzSmxZWFJwYm1jS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhsd1pYTXZkSGx3WlhOZlpHVnRieTVoYkdkdkxuUnpPanBVZVhCbGMwUmxiVzh1WkdWdGIyNXpkSEpoZEdWVWVYQmxjMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21SbGJXOXVjM1J5WVhSbFZIbHdaWE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSGx3WlhNdmRIbHdaWE5mWkdWdGJ5NWhiR2R2TG5Sek9qTTJDaUFnSUNBdkx5QnNiMmNvUW5sMFpYTW9JaTB0TFNCVlNVNVVOalFnUkVWTlR5QXRMUzBpS1NrN0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWkwdExTQlZTVTVVTmpRZ1JFVk5UeUF0TFMwaUNpQWdJQ0JzYjJjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwZVhCbGN5OTBlWEJsYzE5a1pXMXZMbUZzWjI4dWRITTZNemNLSUNBZ0lDOHZJR3h2WnlodmNDNXBkRzlpS0cxNVUyTnZjbVVwS1RzS0lDQWdJSEIxYzJocGJuUWdNVEF3SUM4dklERXdNQW9nSUNBZ2FYUnZZZ29nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRIbHdaWE12ZEhsd1pYTmZaR1Z0Ynk1aGJHZHZMblJ6T2pVekNpQWdJQ0F2THlCc2IyY29RbmwwWlhNb0lpMHRMU0JDV1ZSRlV5QkVSVTFQSUMwdExTSXBLVHNLSUNBZ0lIQjFjMmhpZVhSbGN5QWlMUzB0SUVKWlZFVlRJRVJGVFU4Z0xTMHRJZ29nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRIbHdaWE12ZEhsd1pYTmZaR1Z0Ynk1aGJHZHZMblJ6T2pRNENpQWdJQ0F2THlCamIyNXpkQ0J0WlhOellXZGxPaUJpZVhSbGN5QTlJRzl3TG1OdmJtTmhkQ2huY21WbGRHbHVaeXdnYm1GdFpTazdJQzh2SUZKbGMzVnNkRG9nSWtobGJHeHZRV3huYjNKaGJtUWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lraGxiR3h2UVd4bmIzSmhibVFpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSGx3WlhNdmRIbHdaWE5mWkdWdGJ5NWhiR2R2TG5Sek9qVTBDaUFnSUNBdkx5QnNiMmNvYldWemMyRm5aU2s3SUNBZ0lDQWdJQ0FnSUNBdkx5Qk1iMmR6SUhKbFlXUmhZbXhsSUhSbGVIUWdhV1lnYVhRbmN5QjJZV3hwWkNCQlUwTkpTUW9nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRIbHdaWE12ZEhsd1pYTmZaR1Z0Ynk1aGJHZHZMblJ6T2pVeENpQWdJQ0F2THlCamIyNXpkQ0JzWlc1bmRHZzZJSFZwYm5RMk5DQTlJRzl3TG14bGJpaHRaWE56WVdkbEtUc0tJQ0FnSUhCMWMyaHBiblFnTVRNZ0x5OGdNVE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBlWEJsY3k5MGVYQmxjMTlrWlcxdkxtRnNaMjh1ZEhNNk5UVUtJQ0FnSUM4dklHeHZaeWh2Y0M1cGRHOWlLR3hsYm1kMGFDa3BPeUFnSUM4dklFeHZaM01nZEdobElHeGxibWQwYUNCcGJuUmxaMlZ5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBlWEJsY3k5MGVYQmxjMTlrWlcxdkxtRnNaMjh1ZEhNNk5qY0tJQ0FnSUM4dklHTnZibk4wSUdKaGJHRnVZMlU2SUhWcGJuUTJOQ0E5SUhWelpYSXVZbUZzWVc1alpUc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z1lXUmtjaUJMUWxsUk0wSXpWRFZPVkV4SVRUUk5SRGRNVlVzMFRWZzFOa3hRVlV4WlRrZE1OakpVTTBSRVNUSTFWa3BWTmtoTk0wRk5TVkpXVVVGVkNpQWdJQ0JoWTJOMFgzQmhjbUZ0YzE5blpYUWdRV05qZEVKaGJHRnVZMlVLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJR0ZqWTI5MWJuUWdablZ1WkdWa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhsd1pYTXZkSGx3WlhOZlpHVnRieTVoYkdkdkxuUnpPamMyQ2lBZ0lDQXZMeUJzYjJjb1FubDBaWE1vSWkwdExTQlNSVVpGVWtWT1EwVWdSRVZOVHlBdExTMGlLU2s3Q2lBZ0lDQndkWE5vWW5sMFpYTWdJaTB0TFNCU1JVWkZVa1ZPUTBVZ1JFVk5UeUF0TFMwaUNpQWdJQ0JzYjJjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwZVhCbGN5OTBlWEJsYzE5a1pXMXZMbUZzWjI4dWRITTZPREVLSUNBZ0lDOHZJR2xtSUNodmNDNWhjSEJQY0hSbFpFbHVLSFZ6WlhJc0lHMTVRWEJ3S1NrZ2V3b2dJQ0FnWW5sMFpXTmZNQ0F2THlCaFpHUnlJRXRDV1ZFelFqTlVOVTVVVEVoTk5FMUVOMHhWU3pSTldEVTJURkJWVEZsT1IwdzJNbFF6UkVSSk1qVldTbFUyU0UwelFVMUpVbFpSUVZVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwZVhCbGN5OTBlWEJsYzE5a1pXMXZMbUZzWjI4dWRITTZOelFLSUNBZ0lDOHZJR052Ym5OMElHMTVRWEJ3SUQwZ1FYQndiR2xqWVhScGIyNG9WV2x1ZERZMEtEazVPVzRwS1RzS0lDQWdJSEIxYzJocGJuUWdPVGs1SUM4dklEazVPUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUjVjR1Z6TDNSNWNHVnpYMlJsYlc4dVlXeG5ieTUwY3pvNE1Rb2dJQ0FnTHk4Z2FXWWdLRzl3TG1Gd2NFOXdkR1ZrU1c0b2RYTmxjaXdnYlhsQmNIQXBLU0I3Q2lBZ0lDQmhjSEJmYjNCMFpXUmZhVzRLSUNBZ0lHSjZJR1JsYlc5dWMzUnlZWFJsVkhsd1pYTmZaV3h6WlY5aWIyUjVRRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBlWEJsY3k5MGVYQmxjMTlrWlcxdkxtRnNaMjh1ZEhNNk9ESUtJQ0FnSUM4dklHeHZaeWhDZVhSbGN5Z2lWWE5sY2lCcGN5QnZjSFJsWkNCcGJpRWlLU2s3Q2lBZ0lDQndkWE5vWW5sMFpYTWdJbFZ6WlhJZ2FYTWdiM0IwWldRZ2FXNGhJZ29nSUNBZ2JHOW5DZ3BrWlcxdmJuTjBjbUYwWlZSNWNHVnpYMkZtZEdWeVgybG1YMlZzYzJWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGVYQmxjeTkwZVhCbGMxOWtaVzF2TG1Gc1oyOHVkSE02T1RVS0lDQWdJQzh2SUhOamIzSmxjMXN3WFNBOUlERXdPd29nSUNBZ2NIVnphR2x1ZENBeE1DQXZMeUF4TUFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1I1Y0dWekwzUjVjR1Z6WDJSbGJXOHVZV3huYnk1MGN6b3hNVEFLSUNBZ0lDOHZJR3h2WnloQ2VYUmxjeWdpTFMwdElFRlNVa0ZaSUVSRlRVOGdMUzB0SWlrcE93b2dJQ0FnY0hWemFHSjVkR1Z6SUNJdExTMGdRVkpTUVZrZ1JFVk5UeUF0TFMwaUNpQWdJQ0JzYjJjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwZVhCbGN5OTBlWEJsYzE5a1pXMXZMbUZzWjI4dWRITTZNVEV4Q2lBZ0lDQXZMeUJzYjJjb2IzQXVhWFJ2WWloelkyOXlaWE5iTUYwcEtUc0tJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSNWNHVnpMM1I1Y0dWelgyUmxiVzh1WVd4bmJ5NTBjem95TWdvZ0lDQWdMeThnY0hWaWJHbGpJR1JsYlc5dWMzUnlZWFJsVkhsd1pYTW9LVG9nZG05cFpDQjdDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwa1pXMXZibk4wY21GMFpWUjVjR1Z6WDJWc2MyVmZZbTlrZVVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSNWNHVnpMM1I1Y0dWelgyUmxiVzh1WVd4bmJ5NTBjem80TkFvZ0lDQWdMeThnYkc5bktFSjVkR1Z6S0NKVmMyVnlJR2x6SUU1UFZDQnZjSFJsWkNCcGJpNGlLU2s3Q2lBZ0lDQndkWE5vWW5sMFpYTWdJbFZ6WlhJZ2FYTWdUazlVSUc5d2RHVmtJR2x1TGlJS0lDQWdJR3h2WndvZ0lDQWdZaUJrWlcxdmJuTjBjbUYwWlZSNWNHVnpYMkZtZEdWeVgybG1YMlZzYzJWQU5Bbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5WUJJRkJ4RFlkejYyYXpzNHdmMTBWeGwrK1craThOTXYycDdHTkd1MVRUeDJiQU1SdEJBQmlBQkhzTXZHazJHZ0NPQVFBQkFERVpGREVZRUVSQ0FBc3hHUlF4R0JRUVJJRUJRNEFUTFMwdElGVkpUbFEyTkNCRVJVMVBJQzB0TGJDQlpCYXdnQkl0TFMwZ1FsbFVSVk1nUkVWTlR5QXRMUzJ3Z0ExSVpXeHNiMEZzWjI5eVlXNWtzSUVORnJBb2N3QkZBVVNBRmkwdExTQlNSVVpGVWtWT1EwVWdSRVZOVHlBdExTMndLSUhuQjJGQkFEQ0FFVlZ6WlhJZ2FYTWdiM0IwWldRZ2FXNGhzSUVLRm9BU0xTMHRJRUZTVWtGWklFUkZUVThnTFMwdHNMQ0JBVU9BRlZWelpYSWdhWE1nVGs5VUlHOXdkR1ZrSUdsdUxyQkMvOGs9IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MywicGF0Y2giOjIsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
