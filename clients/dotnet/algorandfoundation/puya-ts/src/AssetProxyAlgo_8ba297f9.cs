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

namespace Arc56.Generated.algorandfoundation.puya_ts.AssetProxyAlgo_8ba297f9
{


    public class AssetProxyAlgoProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AssetProxyAlgoProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        public async Task TestAsset(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 3, 236, 71 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestAsset_Transactions(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 3, 236, 71 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXNzZXRQcm94eUFsZ28iLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoidGVzdEFzc2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTIwLDEyOF0sImVycm9yTWVzc2FnZSI6ImFjY291bnQgb3B0ZWQgaW50byBhc3NldCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU0LDYwLDY2LDcyLDc3LDgyLDg3LDkyLDk3LDEwMiwxMDcsMTEyXSwiZXJyb3JNZXNzYWdlIjoiYXNzZXQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYTnpaWFF0Y0hKdmVIa3VZV3huYnk1MGN6bzBDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUVhOelpYUlFjbTk0ZVVGc1oyOGdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTlFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WkRNd00yVmpORGNnTHk4Z2JXVjBhRzlrSUNKMFpYTjBRWE56WlhRb2RXbHVkRFkwS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgzUmxjM1JCYzNObGRGOXliM1YwWlVBekNpQWdJQ0JsY25JS0NtMWhhVzVmZEdWemRFRnpjMlYwWDNKdmRYUmxRRE02Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWE56WlhRdGNISnZlSGt1WVd4bmJ5NTBjem8xQ2lBZ0lDQXZMeUIwWlhOMFFYTnpaWFFvWVhOelpYUTZJRUZ6YzJWMEtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQW9nSUNBZ1lpQjBaWE4wUVhOelpYUUtDbTFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURVNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhOelpYUXRjSEp2ZUhrdVlXeG5ieTUwY3pvMENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRWE56WlhSUWNtOTRlVUZzWjI4Z1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloYzNObGRDMXdjbTk0ZVM1aGJHZHZMblJ6T2pwQmMzTmxkRkJ5YjNoNVFXeG5ieTUwWlhOMFFYTnpaWFJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMFpYTjBRWE56WlhRNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhOelpYUXRjSEp2ZUhrdVlXeG5ieTUwY3pvMUNpQWdJQ0F2THlCMFpYTjBRWE56WlhRb1lYTnpaWFE2SUVGemMyVjBLVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMlYwTFhCeWIzaDVMbUZzWjI4dWRITTZOZ29nSUNBZ0x5OGdiRzluS0dGemMyVjBMbWxrS1FvZ0lDQWdaSFZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjM05sZEMxd2NtOTRlUzVoYkdkdkxuUnpPamNLSUNBZ0lDOHZJR3h2WnloaGMzTmxkQzUwYjNSaGJDa0tJQ0FnSUdSMWNBb2dJQ0FnWVhOelpYUmZjR0Z5WVcxelgyZGxkQ0JCYzNObGRGUnZkR0ZzQ2lBZ0lDQmhjM05sY25RZ0x5OGdZWE56WlhRZ1pYaHBjM1J6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjM05sZEMxd2NtOTRlUzVoYkdkdkxuUnpPamdLSUNBZ0lDOHZJR3h2WnloaGMzTmxkQzVrWldOcGJXRnNjeWtLSUNBZ0lHUjFjQW9nSUNBZ1lYTnpaWFJmY0dGeVlXMXpYMmRsZENCQmMzTmxkRVJsWTJsdFlXeHpDaUFnSUNCaGMzTmxjblFnTHk4Z1lYTnpaWFFnWlhocGMzUnpDaUFnSUNCcGRHOWlDaUFnSUNCc2IyY0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGMzTmxkQzF3Y205NGVTNWhiR2R2TG5Sek9qa0tJQ0FnSUM4dklHeHZaeWhoYzNObGRDNWtaV1poZFd4MFJuSnZlbVZ1S1FvZ0lDQWdaSFZ3Q2lBZ0lDQmhjM05sZEY5d1lYSmhiWE5mWjJWMElFRnpjMlYwUkdWbVlYVnNkRVp5YjNwbGJnb2dJQ0FnWVhOelpYSjBJQzh2SUdGemMyVjBJR1Y0YVhOMGN3b2dJQ0FnYVhSdllnb2dJQ0FnYkc5bkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhOelpYUXRjSEp2ZUhrdVlXeG5ieTUwY3pveE1Bb2dJQ0FnTHk4Z2JHOW5LR0Z6YzJWMExuVnVhWFJPWVcxbEtRb2dJQ0FnWkhWd0NpQWdJQ0JoYzNObGRGOXdZWEpoYlhOZloyVjBJRUZ6YzJWMFZXNXBkRTVoYldVS0lDQWdJR0Z6YzJWeWRDQXZMeUJoYzNObGRDQmxlR2x6ZEhNS0lDQWdJR3h2WndvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ6YzJWMExYQnliM2g1TG1Gc1oyOHVkSE02TVRFS0lDQWdJQzh2SUd4dlp5aGhjM05sZEM1dVlXMWxLUW9nSUNBZ1pIVndDaUFnSUNCaGMzTmxkRjl3WVhKaGJYTmZaMlYwSUVGemMyVjBUbUZ0WlFvZ0lDQWdZWE56WlhKMElDOHZJR0Z6YzJWMElHVjRhWE4wY3dvZ0lDQWdiRzluQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWE56WlhRdGNISnZlSGt1WVd4bmJ5NTBjem94TWdvZ0lDQWdMeThnYkc5bktHRnpjMlYwTG5WeWJDa0tJQ0FnSUdSMWNBb2dJQ0FnWVhOelpYUmZjR0Z5WVcxelgyZGxkQ0JCYzNObGRGVlNUQW9nSUNBZ1lYTnpaWEowSUM4dklHRnpjMlYwSUdWNGFYTjBjd29nSUNBZ2JHOW5DaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYTnpaWFF0Y0hKdmVIa3VZV3huYnk1MGN6b3hNd29nSUNBZ0x5OGdiRzluS0dGemMyVjBMbTFsZEdGa1lYUmhTR0Z6YUNrS0lDQWdJR1IxY0FvZ0lDQWdZWE56WlhSZmNHRnlZVzF6WDJkbGRDQkJjM05sZEUxbGRHRmtZWFJoU0dGemFBb2dJQ0FnWVhOelpYSjBJQzh2SUdGemMyVjBJR1Y0YVhOMGN3b2dJQ0FnYkc5bkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhOelpYUXRjSEp2ZUhrdVlXeG5ieTUwY3pveE5Bb2dJQ0FnTHk4Z2JHOW5LR0Z6YzJWMExtMWhibUZuWlhJcENpQWdJQ0JrZFhBS0lDQWdJR0Z6YzJWMFgzQmhjbUZ0YzE5blpYUWdRWE56WlhSTllXNWhaMlZ5Q2lBZ0lDQmhjM05sY25RZ0x5OGdZWE56WlhRZ1pYaHBjM1J6Q2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjM05sZEMxd2NtOTRlUzVoYkdkdkxuUnpPakUxQ2lBZ0lDQXZMeUJzYjJjb1lYTnpaWFF1Y21WelpYSjJaU2tLSUNBZ0lHUjFjQW9nSUNBZ1lYTnpaWFJmY0dGeVlXMXpYMmRsZENCQmMzTmxkRkpsYzJWeWRtVUtJQ0FnSUdGemMyVnlkQ0F2THlCaGMzTmxkQ0JsZUdsemRITUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGemMyVjBMWEJ5YjNoNUxtRnNaMjh1ZEhNNk1UWUtJQ0FnSUM4dklHeHZaeWhoYzNObGRDNW1jbVZsZW1VcENpQWdJQ0JrZFhBS0lDQWdJR0Z6YzJWMFgzQmhjbUZ0YzE5blpYUWdRWE56WlhSR2NtVmxlbVVLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjM05sZENCbGVHbHpkSE1LSUNBZ0lHeHZad29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMlYwTFhCeWIzaDVMbUZzWjI4dWRITTZNVGNLSUNBZ0lDOHZJR3h2WnloaGMzTmxkQzVqYkdGM1ltRmpheWtLSUNBZ0lHUjFjQW9nSUNBZ1lYTnpaWFJmY0dGeVlXMXpYMmRsZENCQmMzTmxkRU5zWVhkaVlXTnJDaUFnSUNCaGMzTmxjblFnTHk4Z1lYTnpaWFFnWlhocGMzUnpDaUFnSUNCc2IyY0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGMzTmxkQzF3Y205NGVTNWhiR2R2TG5Sek9qRTRDaUFnSUNBdkx5QnNiMmNvWVhOelpYUXVZM0psWVhSdmNpa0tJQ0FnSUdSMWNBb2dJQ0FnWVhOelpYUmZjR0Z5WVcxelgyZGxkQ0JCYzNObGRFTnlaV0YwYjNJS0lDQWdJR0Z6YzJWeWRDQXZMeUJoYzNObGRDQmxlR2x6ZEhNS0lDQWdJR3h2WndvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ6YzJWMExYQnliM2g1TG1Gc1oyOHVkSE02TWpBS0lDQWdJQzh2SUd4dlp5aGhjM05sZEM1aVlXeGhibU5sS0ZSNGJpNXpaVzVrWlhJcEtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaR2xuSURFS0lDQWdJR0Z6YzJWMFgyaHZiR1JwYm1kZloyVjBJRUZ6YzJWMFFtRnNZVzVqWlFvZ0lDQWdZWE56WlhKMElDOHZJR0ZqWTI5MWJuUWdiM0IwWldRZ2FXNTBieUJoYzNObGRBb2dJQ0FnYVhSdllnb2dJQ0FnYkc5bkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhOelpYUXRjSEp2ZUhrdVlXeG5ieTUwY3pveU1Rb2dJQ0FnTHk4Z2JHOW5LR0Z6YzJWMExtWnliM3BsYmloVWVHNHVjMlZ1WkdWeUtTa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJSE4zWVhBS0lDQWdJR0Z6YzJWMFgyaHZiR1JwYm1kZloyVjBJRUZ6YzJWMFJuSnZlbVZ1Q2lBZ0lDQmhjM05sY25RZ0x5OGdZV05qYjNWdWRDQnZjSFJsWkNCcGJuUnZJR0Z6YzJWMENpQWdJQ0JwZEc5aUNpQWdJQ0JzYjJjS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloYzNObGRDMXdjbTk0ZVM1aGJHZHZMblJ6T2pVS0lDQWdJQzh2SUhSbGMzUkJjM05sZENoaGMzTmxkRG9nUVhOelpYUXBPaUIyYjJsa0lIc0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDekViUVFBWWdBVFRBK3hITmhvQWpnRUFBUUF4R1JReEdCQkVRZ0FJTVJrVU1SZ1VFRU0yR2dGSkZZRUlFa1FYU1Jhd1NYRUFSQmF3U1hFQlJCYXdTWEVDUkJhd1NYRURSTEJKY1FSRXNFbHhCVVN3U1hFR1JMQkpjUWRFc0VseENFU3dTWEVKUkxCSmNRcEVzRWx4QzBTd01RQkxBWEFBUkJhd01RQk1jQUZFRnJDQkFVTT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
