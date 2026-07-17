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

namespace Arc56.Generated.algorandfoundation.algorand_python_testing.GlobalStateValidator_5d3fe8f1
{


    public class GlobalStateValidatorProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public GlobalStateValidatorProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="arg1"> </param>
        /// <param name="arg2"> </param>
        public async Task ValidateGArgs(ulong arg1, string arg2, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 235, 92, 103 };
            var arg1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); arg1Abi.From(arg1);
            var arg2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); arg2Abi.From(arg2);

            var result = await base.CallApp(new List<object> { abiHandle, arg1Abi, arg2Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateGArgs_Transactions(ulong arg1, string arg2, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 235, 92, 103 };
            var arg1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); arg1Abi.From(arg1);
            var arg2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); arg2Abi.From(arg2);

            return await base.MakeTransactionList(new List<object> { abiHandle, arg1Abi, arg2Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiR2xvYmFsU3RhdGVWYWxpZGF0b3IiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoidmFsaWRhdGVfZ19hcmdzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFyZzEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFyZzIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls3Ml0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgYXBwbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGhqTUdWaU5XTTJOd29nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwZHNiMkpoYkZOMFlYUmxWbUZzYVdSaGRHOXlMMk52Ym5SeVlXTjBMbkI1T2pRS0lDQWdJQzh2SUdOc1lYTnpJRWRzYjJKaGJGTjBZWFJsVm1Gc2FXUmhkRzl5S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUExQ2lBZ0lDQmllWFJsWTE4d0lDOHZJRzFsZEdodlpDQWlkbUZzYVdSaGRHVmZaMTloY21kektIVnBiblEyTkN4emRISnBibWNwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZmRtRnNhV1JoZEdWZloxOWhjbWR6WDNKdmRYUmxRRE1LSUNBZ0lHVnljZ29LYldGcGJsOTJZV3hwWkdGMFpWOW5YMkZ5WjNOZmNtOTFkR1ZBTXpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlIYkc5aVlXeFRkR0YwWlZaaGJHbGtZWFJ2Y2k5amIyNTBjbUZqZEM1d2VUbzFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBbUpnb2dJQ0FnWVhOelpYSjBDaUFnSUNCaUlIWmhiR2xrWVhSbFgyZGZZWEpuY3dvS2JXRnBibDlmWDJGc1oyOXdlVjlrWldaaGRXeDBYMk55WldGMFpVQTFPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lDWW1DaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k1aGNuUnBabUZqZEhNdVIyeHZZbUZzVTNSaGRHVldZV3hwWkdGMGIzSXVZMjl1ZEhKaFkzUXVSMnh2WW1Gc1UzUmhkR1ZXWVd4cFpHRjBiM0l1ZG1Gc2FXUmhkR1ZmWjE5aGNtZHpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZG1Gc2FXUmhkR1ZmWjE5aGNtZHpPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwZHNiMkpoYkZOMFlYUmxWbUZzYVdSaGRHOXlMMk52Ym5SeVlXTjBMbkI1T2pVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwZHNiMkpoYkZOMFlYUmxWbUZzYVdSaGRHOXlMMk52Ym5SeVlXTjBMbkI1T2pjS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dVlYQndiR2xqWVhScGIyNWZZWEpuY3lnd0tTQTlQU0JoY21NMExtRnlZelJmYzJsbmJtRjBkWEpsS0NKMllXeHBaR0YwWlY5blgyRnlaM01vZFdsdWREWTBMSE4wY21sdVp5bDJiMmxrSWlrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnYldWMGFHOWtJQ0oyWVd4cFpHRjBaVjluWDJGeVozTW9kV2x1ZERZMExITjBjbWx1WnlsMmIybGtJZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwZHNiMkpoYkZOMFlYUmxWbUZzYVdSaGRHOXlMMk52Ym5SeVlXTjBMbkI1T2pnS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dVlYQndiR2xqWVhScGIyNWZZWEpuY3lneEtTQTlQU0JoY21jeExtSjVkR1Z6Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmthV2NnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMGRzYjJKaGJGTjBZWFJsVm1Gc2FXUmhkRzl5TDJOdmJuUnlZV04wTG5CNU9qa0tJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVZWEJ3YkdsallYUnBiMjVmWVhKbmN5Z3lLU0E5UFNCaGNtY3lMbUo1ZEdWekNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UjJ4dlltRnNVM1JoZEdWV1lXeHBaR0YwYjNJdlkyOXVkSEpoWTNRdWNIazZNVEFLSUNBZ0lDOHZJR0Z6YzJWeWRDQm5kSGh1TGtGd2NHeHBZMkYwYVc5dVEyRnNiRlJ5WVc1ellXTjBhVzl1S0ZSNGJpNW5jbTkxY0Y5cGJtUmxlQ2t1WVhCd1gyRnlaM01vTVNrZ1BUMGdZWEpuTVM1aWVYUmxjd29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lIQjFjMmhwYm5RZ05pQXZMeUJoY0hCc0NpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nWVhCd2JBb2dJQ0FnY0hWemFHbHVkQ0F4Q2lBZ0lDQm5kSGh1YzJGeklFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdaR2xuSURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlIYkc5aVlXeFRkR0YwWlZaaGJHbGtZWFJ2Y2k5amIyNTBjbUZqZEM1d2VUb3hNUW9nSUNBZ0x5OGdZWE56WlhKMElHZDBlRzR1VkhKaGJuTmhZM1JwYjI0b1ZIaHVMbWR5YjNWd1gybHVaR1Y0S1M1aGNIQmZZWEpuY3lneEtTQTlQU0JoY21jeExtSjVkR1Z6Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNCbmRIaHVjMkZ6SUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ1pHbG5JREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OUhiRzlpWVd4VGRHRjBaVlpoYkdsa1lYUnZjaTlqYjI1MGNtRmpkQzV3ZVRveE1nb2dJQ0FnTHk4Z1lYTnpaWEowSUc5d0xrZFVlRzR1WVhCd2JHbGpZWFJwYjI1ZllYSm5jeWhVZUc0dVozSnZkWEJmYVc1a1pYZ3NJREVwSUQwOUlHRnlaekV1WW5sMFpYTUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCbmRIaHVjMkVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUnBaeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZSMnh2WW1Gc1UzUmhkR1ZXWVd4cFpHRjBiM0l2WTI5dWRISmhZM1F1Y0hrNk1UTUtJQ0FnSUM4dklHRnpjMlZ5ZENCdmNDNVVlRzR1WVhCd2JHbGpZWFJwYjI1ZllYSm5jeWd4S1NBOVBTQmhjbWN4TG1KNWRHVnpDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlIyeHZZbUZzVTNSaGRHVldZV3hwWkdGMGIzSXZZMjl1ZEhKaFkzUXVjSGs2TlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeVlCQk1EclhHY3hHMEVBRXlnMkdnQ09BUUFCQURFWkZERVlFRVJDQUFneEdSUXhHQlFRUXpZYUFUWWFBallhQUNnU1JEWWFBVXNDRWtRMkdnSVNSREVXU1RnUWdRWVNSSUVCd2hwTEFSSkVNUmFCQWNJYVN3RVNSREVXT1JvQlN3RVNSRFlhQVJKRWdRRkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo4LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
