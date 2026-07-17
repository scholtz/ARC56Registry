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

namespace Arc56.Generated.algorandfoundation.algorand_python_testing.Contract_89894114
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
        public async Task TestFalconVerify(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 86, 73, 156 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestFalconVerify_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 86, 73, 156 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task TestRejectVersion(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 138, 171, 66 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestRejectVersion_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 138, 171, 66 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ29udHJhY3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoidGVzdF9mYWxjb25fdmVyaWZ5IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RfcmVqZWN0X3ZlcnNpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxMzgsMjI2XSwiZXJyb3JNZXNzYWdlIjoiYXBwbGljYXRpb24gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQwXSwiZXJyb3JNZXNzYWdlIjoic2hvdWxkIGJlIHZlcnNpb24gMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyOV0sImVycm9yTWVzc2FnZSI6InNob3VsZCBiZSB2ZXJzaW9uIDEiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeUNpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF4SURZZ01Bb2dJQ0FnWW5sMFpXTmliRzlqYXlCaVlYTmxOalFvUkVsRlFsRjNQVDBwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZRVlpOTVRJdlkyOXVkSEpoWTNRdWNIazZOQW9nSUNBZ0x5OGdZMnhoYzNNZ1EyOXVkSEpoWTNRb1FWSkRORU52Ym5SeVlXTjBMQ0JoZG0xZmRtVnljMmx2YmoweE1pazZDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUE1Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGhpWlRVMk5EazVZeUF3ZUdGak9HRmhZalF5SUM4dklHMWxkR2h2WkNBaWRHVnpkRjltWVd4amIyNWZkbVZ5YVdaNUtDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKMFpYTjBYM0psYW1WamRGOTJaWEp6YVc5dUtDbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2RHVnpkRjltWVd4amIyNWZkbVZ5YVdaNUlIUmxjM1JmY21WcVpXTjBYM1psY25OcGIyNEtJQ0FnSUdWeWNnb0tiV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUE1T2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5NWhjblJwWm1GamRITXVRVlpOTVRJdVkyOXVkSEpoWTNRdVEyOXVkSEpoWTNRdWRHVnpkRjltWVd4amIyNWZkbVZ5YVdaNVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkR1Z6ZEY5bVlXeGpiMjVmZG1WeWFXWjVPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwRldUVEV5TDJOdmJuUnlZV04wTG5CNU9qY0tJQ0FnSUM4dklHRnpjMlZ5ZENCdWIzUWdiM0F1Wm1Gc1kyOXVYM1psY21sbWVTaGlJaUlzSUdJaUlpd2diM0F1WW5wbGNtOG9NVGM1TXlrcENpQWdJQ0J3ZFhOb2FXNTBJREUzT1RNS0lDQWdJR0o2WlhKdkNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCbVlXeGpiMjVmZG1WeWFXWjVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5QlZrMHhNaTlqYjI1MGNtRmpkQzV3ZVRvMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k1aGNuUnBabUZqZEhNdVFWWk5NVEl1WTI5dWRISmhZM1F1UTI5dWRISmhZM1F1ZEdWemRGOXlaV3BsWTNSZmRtVnljMmx2Ymx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuUmxjM1JmY21WcVpXTjBYM1psY25OcGIyNDZDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlFWWk5NVEl2WTI5dWRISmhZM1F1Y0hrNk1URUtJQ0FnSUM4dklHRndjRjkyTUY5MGVHNGdQU0JoY21NMExtRnlZelJmWTNKbFlYUmxLRU52Ym5SeVlXTjBWakFwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCaWVYUmxZMTh3SUM4dklHSmhjMlUyTkNoRVNVVkNVWGM5UFNrS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzFRWVdkbGN3b2dJQ0FnY0hWemFHSjVkR1Z6SUdKaGMyVTJOQ2hFUkVWaVVWRkJZV2RCVTJjMlFtaDVUbWh2UVdwblJVRkJVVUY0UjFsRlJVVnFSVmxGUlZKRFFVRm5lRWRTVVhoSFFsRlJVWHBHUldkUlJWTlNTVVZDVVhjOVBTa0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndjbTkyWVd4UWNtOW5jbUZ0VUdGblpYTUtJQ0FnSUdsdWRHTmZNU0F2THlCaGNIQnNDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUVOeVpXRjBaV1JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UVZaTk1USXZZMjl1ZEhKaFkzUXVjSGs2TVRNS0lDQWdJQzh2SUdGemMyVnlkQ0JoY0hBdWRtVnljMmx2YmlBOVBTQXdMQ0FpYzJodmRXeGtJR0psSUhabGNuTnBiMjRnTUNJS0lDQWdJR1IxY0FvZ0lDQWdZWEJ3WDNCaGNtRnRjMTluWlhRZ1FYQndWbVZ5YzJsdmJnb2dJQ0FnWVhOelpYSjBJQzh2SUdGd2NHeHBZMkYwYVc5dUlHVjRhWE4wY3dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklITm9iM1ZzWkNCaVpTQjJaWEp6YVc5dUlEQUtJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5QlZrMHhNaTlqYjI1MGNtRmpkQzV3ZVRveE5TMHhOd29nSUNBZ0x5OGdZWEpqTkM1aGNtTTBYM1Z3WkdGMFpTZ0tJQ0FnSUM4dklDQWdJQ0JEYjI1MGNtRmpkRll3TG5Wd1pHRjBaU3dnWVhCd1gybGtQV0Z3Y0N3Z2NtVnFaV04wWDNabGNuTnBiMjQ5TVN3Z1kyOXRjR2xzWldROVkyOXRjR2xzWlY5amIyNTBjbUZqZENoRGIyNTBjbUZqZEZZeEtRb2dJQ0FnTHk4Z0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMEZXVFRFeUwyTnZiblJ5WVdOMExuQjVPakUyQ2lBZ0lDQXZMeUJEYjI1MGNtRmpkRll3TG5Wd1pHRjBaU3dnWVhCd1gybGtQV0Z3Y0N3Z2NtVnFaV04wWDNabGNuTnBiMjQ5TVN3Z1kyOXRjR2xzWldROVkyOXRjR2xzWlY5amIyNTBjbUZqZENoRGIyNTBjbUZqZEZZeEtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlCaVlYTmxOalFvUkVsRlFsRjNQVDBwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRU5zWldGeVUzUmhkR1ZRY205bmNtRnRVR0ZuWlhNS0lDQWdJSEIxYzJoaWVYUmxjeUJpWVhObE5qUW9SRVJGWWxGUlFXRm5RVkZyVGpRd09FNW9iMEZxWjBWQlFWRkJlRWRaUlVaRmFrVlpSVVZTUTBGQlozaEhVbEY0UjBKUlVWRjZSa1ZuVVVsVFVrbEZRbEYzUFQwcENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NISnZkbUZzVUhKdlozSmhiVkJoWjJWekNpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UVZaTk1USXZZMjl1ZEhKaFkzUXVjSGs2TVRVdE1UY0tJQ0FnSUM4dklHRnlZelF1WVhKak5GOTFjR1JoZEdVb0NpQWdJQ0F2THlBZ0lDQWdRMjl1ZEhKaFkzUldNQzUxY0dSaGRHVXNJR0Z3Y0Y5cFpEMWhjSEFzSUhKbGFtVmpkRjkyWlhKemFXOXVQVEVzSUdOdmJYQnBiR1ZrUFdOdmJYQnBiR1ZmWTI5dWRISmhZM1FvUTI5dWRISmhZM1JXTVNrS0lDQWdJQzh2SUNrS0lDQWdJSEIxYzJocGJuUWdOQ0F2THlCVmNHUmhkR1ZCY0hCc2FXTmhkR2x2YmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlCVmsweE1pOWpiMjUwY21GamRDNXdlVG94TmdvZ0lDQWdMeThnUTI5dWRISmhZM1JXTUM1MWNHUmhkR1VzSUdGd2NGOXBaRDFoY0hBc0lISmxhbVZqZEY5MlpYSnphVzl1UFRFc0lHTnZiWEJwYkdWa1BXTnZiWEJwYkdWZlkyOXVkSEpoWTNRb1EyOXVkSEpoWTNSV01Ta0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUZKbGFtVmpkRlpsY25OcGIyNEtJQ0FnSUdSMWNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGhNR1U0TVRnM01pQXZMeUJ0WlhSb2IyUWdJblZ3WkdGMFpTZ3BkbTlwWkNJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlFWWk5NVEl2WTI5dWRISmhZM1F1Y0hrNk1UVXRNVGNLSUNBZ0lDOHZJR0Z5WXpRdVlYSmpORjkxY0dSaGRHVW9DaUFnSUNBdkx5QWdJQ0FnUTI5dWRISmhZM1JXTUM1MWNHUmhkR1VzSUdGd2NGOXBaRDFoY0hBc0lISmxhbVZqZEY5MlpYSnphVzl1UFRFc0lHTnZiWEJwYkdWa1BXTnZiWEJwYkdWZlkyOXVkSEpoWTNRb1EyOXVkSEpoWTNSV01Ta0tJQ0FnSUM4dklDa0tJQ0FnSUdsdWRHTmZNU0F2THlCaGNIQnNDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZRVlpOTVRJdlkyOXVkSEpoWTNRdWNIazZNVGdLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhjSEF1ZG1WeWMybHZiaUE5UFNBeExDQWljMmh2ZFd4a0lHSmxJSFpsY25OcGIyNGdNU0lLSUNBZ0lHUjFjQW9nSUNBZ1lYQndYM0JoY21GdGMxOW5aWFFnUVhCd1ZtVnljMmx2YmdvZ0lDQWdZWE56WlhKMElDOHZJR0Z3Y0d4cFkyRjBhVzl1SUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYzJodmRXeGtJR0psSUhabGNuTnBiMjRnTVFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMEZXVFRFeUwyTnZiblJ5WVdOMExuQjVPakl3TFRJNUNpQWdJQ0F2THlCcGRIaHVMa0Z3Y0d4cFkyRjBhVzl1UTJGc2JDZ0tJQ0FnSUM4dklDQWdJQ0JoY0hCZllYSm5jejBvQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJR0Z5WXpRdVlYSmpORjl6YVdkdVlYUjFjbVVvQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJQ0FnSUNCRGIyNTBjbUZqZEZZeExtUmxiR1YwWlN3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnS1N3S0lDQWdJQzh2SUNBZ0lDQXBMQW9nSUNBZ0x5OGdJQ0FnSUc5dVgyTnZiWEJzWlhScGIyNDlUMjVEYjIxd2JHVjBaVUZqZEdsdmJpNUVaV3hsZEdWQmNIQnNhV05oZEdsdmJpd0tJQ0FnSUM4dklDQWdJQ0JoY0hCZmFXUTlZWEJ3TEFvZ0lDQWdMeThnSUNBZ0lISmxhbVZqZEY5MlpYSnphVzl1UFRJc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZRVlpOTVRJdlkyOXVkSEpoWTNRdWNIazZNamdLSUNBZ0lDOHZJSEpsYW1WamRGOTJaWEp6YVc5dVBUSXNDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WcVpXTjBWbVZ5YzJsdmJnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlFWWk5NVEl2WTI5dWRISmhZM1F1Y0hrNk1qWUtJQ0FnSUM4dklHOXVYMk52YlhCc1pYUnBiMjQ5VDI1RGIyMXdiR1YwWlVGamRHbHZiaTVFWld4bGRHVkJjSEJzYVdOaGRHbHZiaXdLSUNBZ0lIQjFjMmhwYm5RZ05TQXZMeUJFWld4bGRHVkJjSEJzYVdOaGRHbHZiZ29nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OUJWazB4TWk5amIyNTBjbUZqZEM1d2VUb3lNaTB5TkFvZ0lDQWdMeThnWVhKak5DNWhjbU0wWDNOcFoyNWhkSFZ5WlNnS0lDQWdJQzh2SUNBZ0lDQkRiMjUwY21GamRGWXhMbVJsYkdWMFpTd0tJQ0FnSUM4dklDa3NDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3lORE0zT0dRell5QXZMeUJ0WlhSb2IyUWdJbVJsYkdWMFpTZ3BkbTlwWkNJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlFWWk5NVEl2WTI5dWRISmhZM1F1Y0hrNk1qQUtJQ0FnSUM4dklHbDBlRzR1UVhCd2JHbGpZWFJwYjI1RFlXeHNLQW9nSUNBZ2FXNTBZMTh4SUM4dklHRndjR3dLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGV1RURXlMMk52Ym5SeVlXTjBMbkI1T2pJd0xUSTVDaUFnSUNBdkx5QnBkSGh1TGtGd2NHeHBZMkYwYVc5dVEyRnNiQ2dLSUNBZ0lDOHZJQ0FnSUNCaGNIQmZZWEpuY3owb0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUdGeVl6UXVZWEpqTkY5emFXZHVZWFIxY21Vb0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUNBZ0lDQkRiMjUwY21GamRGWXhMbVJsYkdWMFpTd0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ0tTd0tJQ0FnSUM4dklDQWdJQ0FwTEFvZ0lDQWdMeThnSUNBZ0lHOXVYMk52YlhCc1pYUnBiMjQ5VDI1RGIyMXdiR1YwWlVGamRHbHZiaTVFWld4bGRHVkJjSEJzYVdOaGRHbHZiaXdLSUNBZ0lDOHZJQ0FnSUNCaGNIQmZhV1E5WVhCd0xBb2dJQ0FnTHk4Z0lDQWdJSEpsYW1WamRGOTJaWEp6YVc5dVBUSXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGV1RURXlMMk52Ym5SeVlXTjBMbkI1T2prS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXlDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiRENBREFRWUFKZ0VFRElFQlF6RWJRUUFkTVJrVVJERVlSSUlDQkw1V1Nad0VySXFyUWpZYUFJNENBQWtBRndBeEdSUXhHQlFRUTRHQkRxK0FBRWxQQW9VVVJDSkRzU2l5UW9BeERERWJRUUFhZ0FTZzZCaHlOaG9BamdFQUFRQXhHWUVFRWpFWUVFUkNBQWd4R1JReEdCUVFRekZFZ1FFU1JJRUJRN0pBSTdJUUpMSUJzN1E5U1hJSlJCUkVzU2l5UW9BeERERWJRUUFhZ0FRa040MDhOaG9BamdFQUFRQXhHWUVGRWpFWUVFUkNBQWd4R1JReEdCUVFRekZFZ1FJU1JJRUJRN0pBZ1FTeUdTS3lSRW15R0lBRW9PZ1ljcklhSTdJUUpMSUJzMGx5Q1VRaUVrU3hnUUt5UkxJWWdRV3lHWUFFSkRlTlBMSWFJN0lRSkxJQnN5SkQiLCJjbGVhciI6IkRJRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo4LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
