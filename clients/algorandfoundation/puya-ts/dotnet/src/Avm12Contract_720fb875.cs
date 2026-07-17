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

namespace Arc56.Generated.algorandfoundation.puya_ts.Avm12Contract_720fb875
{


    public class Avm12ContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public Avm12ContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
            byte[] abiHandle = { 2, 244, 165, 1 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestFalconVerify_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 244, 165, 1 };

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
            byte[] abiHandle = { 164, 83, 186, 144 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestRejectVersion_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 164, 83, 186, 144 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXZtMTJDb250cmFjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0ZXN0RmFsY29uVmVyaWZ5IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RSZWplY3RWZXJzaW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTE2LDIwMl0sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExOF0sImVycm9yTWVzc2FnZSI6InNob3VsZCBiZSB2ZXJzaW9uIDAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDVdLCJlcnJvck1lc3NhZ2UiOiJzaG91bGQgYmUgdmVyc2lvbiAxIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXlDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURZS0lDQWdJR0o1ZEdWallteHZZMnNnWW1GelpUWTBLRVJKUlVKUmR6MDlLUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRjJiVEV5TG1Gc1oyOHVkSE02TVRRdE1UVUtJQ0FnSUM4dklFQmpiMjUwY21GamRDaDdJR0YyYlZabGNuTnBiMjQ2SURFeUlIMHBDaUFnSUNBdkx5QmpiR0Z6Y3lCQmRtMHhNa052Ym5SeVlXTjBJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURBeVpqUmhOVEF4SURCNFlUUTFNMkpoT1RBZ0x5OGdiV1YwYUc5a0lDSjBaWE4wUm1Gc1kyOXVWbVZ5YVdaNUtDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKMFpYTjBVbVZxWldOMFZtVnljMmx2YmlncGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZkR1Z6ZEVaaGJHTnZibFpsY21sbWVWOXliM1YwWlVBMElHMWhhVzVmZEdWemRGSmxhbVZqZEZabGNuTnBiMjVmY205MWRHVkFOUW9nSUNBZ1pYSnlDZ3B0WVdsdVgzUmxjM1JTWldwbFkzUldaWEp6YVc5dVgzSnZkWFJsUURVNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhadE1USXVZV3huYnk1MGN6b3lNZ29nSUNBZ0x5OGdZMjl1YzNRZ2RqQlVlRzRnUFNCamIyMXdhV3hsWkZZd0xtSmhjbVZEY21WaGRHVW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGMmJURXlMbUZzWjI4dWRITTZNakVLSUNBZ0lDOHZJR052Ym5OMElHTnZiWEJwYkdWa1ZqQWdQU0JoY21NMExtTnZiWEJwYkdWQmNtTTBLRU52Ym5SeVlXTjBWakFwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJR0poYzJVMk5DaEVTVVZDVVhjOVBTa0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyeGxZWEpUZEdGMFpWQnliMmR5WVcxUVlXZGxjd29nSUNBZ2NIVnphR0o1ZEdWeklHSmhjMlUyTkNoRVJFVmlVVkZCWjJkQlUyYzJRbWg1VG1odlFXcG5SVUZCVVVGNFIxbEZSVVZxUlZsRlJWRjRVa2xGUWtWclUwSkJWVTE0UjFKUmVFZENVVkZSZHowOUtRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnliM1poYkZCeWIyZHlZVzFRWVdkbGN3b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGMmJURXlMbUZzWjI4dWRITTZNaklLSUNBZ0lDOHZJR052Ym5OMElIWXdWSGh1SUQwZ1kyOXRjR2xzWldSV01DNWlZWEpsUTNKbFlYUmxLQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh5SUM4dklHRndjR3dLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1EzSmxZWFJsWkVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGRtMHhNaTVoYkdkdkxuUnpPakkwQ2lBZ0lDQXZMeUJoYzNObGNuUW9ZWEJ3TG5abGNuTnBiMjRnUFQwOUlEQXNJQ2R6YUc5MWJHUWdZbVVnZG1WeWMybHZiaUF3SnlrS0lDQWdJR1IxY0FvZ0lDQWdZWEJ3WDNCaGNtRnRjMTluWlhRZ1FYQndWbVZ5YzJsdmJnb2dJQ0FnWVhOelpYSjBJQzh2SUdGd2NHeHBZMkYwYVc5dUlHVjRhWE4wY3dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklITm9iM1ZzWkNCaVpTQjJaWEp6YVc5dUlEQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGRtMHhNaTVoYkdkdkxuUnpPakk0TFRNMUNpQWdJQ0F2THlCamIyNXpkQ0IyTVZSNGJpQTlJR052YlhCcGJHVmtWakF1WTJGc2JDNTFjR1JoZEdVb2V3b2dJQ0FnTHk4Z0lDQnlaV3BsWTNSV1pYSnphVzl1T2lBeExBb2dJQ0FnTHk4Z0lDQmhjSEJKWkRvZ1lYQndMQW9nSUNBZ0x5OGdJQ0J2YmtOdmJYQnNaWFJwYjI0NklFOXVRMjl0Y0d4bGRHVkJZM1JwYjI0dVZYQmtZWFJsUVhCd2JHbGpZWFJwYjI0c0NpQWdJQ0F2THlBZ0lHRndjSEp2ZG1Gc1VISnZaM0poYlRvZ1kyOXRjR2xzWldSV01TNWhjSEJ5YjNaaGJGQnliMmR5WVcwc0NpQWdJQ0F2THlBZ0lHTnNaV0Z5VTNSaGRHVlFjbTluY21GdE9pQmpiMjF3YVd4bFpGWXhMbU5zWldGeVUzUmhkR1ZRY205bmNtRnRMQW9nSUNBZ0x5OGdJQ0JsZUhSeVlWQnliMmR5WVcxUVlXZGxjem9nWTI5dGNHbHNaV1JXTVM1bGVIUnlZVkJ5YjJkeVlXMVFZV2RsY3l3S0lDQWdJQzh2SUgwcENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWFp0TVRJdVlXeG5ieTUwY3pveU5nb2dJQ0FnTHk4Z1kyOXVjM1FnWTI5dGNHbHNaV1JXTVNBOUlHRnlZelF1WTI5dGNHbHNaVUZ5WXpRb1EyOXVkSEpoWTNSV01Ta0tJQ0FnSUdKNWRHVmpYekFnTHk4Z1ltRnpaVFkwS0VSSlJVSlJkejA5S1FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYkdWaGNsTjBZWFJsVUhKdlozSmhiVkJoWjJWekNpQWdJQ0J3ZFhOb1lubDBaWE1nWW1GelpUWTBLRVJFUldKUlVVRm5aMEZSYTA0ME1EaE9hRzlCYW1kRlFVRlJRWGhIV1VWR1JXcEZXVVZGVVhoU1NVVkRSV3RUUWtGVlRYaEhVbEY0UjBKUlVWRjNQVDBwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0hKdmRtRnNVSEp2WjNKaGJWQmhaMlZ6Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWFp0TVRJdVlXeG5ieTUwY3pvek1Rb2dJQ0FnTHk4Z2IyNURiMjF3YkdWMGFXOXVPaUJQYmtOdmJYQnNaWFJsUVdOMGFXOXVMbFZ3WkdGMFpVRndjR3hwWTJGMGFXOXVMQW9nSUNBZ2NIVnphR2x1ZENBMENpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnWkhWd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGRtMHhNaTVoYkdkdkxuUnpPakk1Q2lBZ0lDQXZMeUJ5WldwbFkzUldaWEp6YVc5dU9pQXhMQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVnFaV04wVm1WeWMybHZiZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRjJiVEV5TG1Gc1oyOHVkSE02TWpndE16VUtJQ0FnSUM4dklHTnZibk4wSUhZeFZIaHVJRDBnWTI5dGNHbHNaV1JXTUM1allXeHNMblZ3WkdGMFpTaDdDaUFnSUNBdkx5QWdJSEpsYW1WamRGWmxjbk5wYjI0NklERXNDaUFnSUNBdkx5QWdJR0Z3Y0Vsa09pQmhjSEFzQ2lBZ0lDQXZMeUFnSUc5dVEyOXRjR3hsZEdsdmJqb2dUMjVEYjIxd2JHVjBaVUZqZEdsdmJpNVZjR1JoZEdWQmNIQnNhV05oZEdsdmJpd0tJQ0FnSUM4dklDQWdZWEJ3Y205MllXeFFjbTluY21GdE9pQmpiMjF3YVd4bFpGWXhMbUZ3Y0hKdmRtRnNVSEp2WjNKaGJTd0tJQ0FnSUM4dklDQWdZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMDZJR052YlhCcGJHVmtWakV1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBzQ2lBZ0lDQXZMeUFnSUdWNGRISmhVSEp2WjNKaGJWQmhaMlZ6T2lCamIyMXdhV3hsWkZZeExtVjRkSEpoVUhKdlozSmhiVkJoWjJWekxBb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VHRXdaVGd4T0RjeUlDOHZJRzFsZEdodlpDQWlkWEJrWVhSbEtDbDJiMmxrSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsdWRHTmZNaUF2THlCaGNIQnNDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGRtMHhNaTVoYkdkdkxuUnpPak0yQ2lBZ0lDQXZMeUJoYzNObGNuUW9kakZVZUc0dWFYUjRiaTVoY0hCSlpDNTJaWEp6YVc5dUlEMDlQU0F4TENBbmMyaHZkV3hrSUdKbElIWmxjbk5wYjI0Z01TY3BDaUFnSUNCaGNIQmZjR0Z5WVcxelgyZGxkQ0JCY0hCV1pYSnphVzl1Q2lBZ0lDQmhjM05sY25RZ0x5OGdZWEJ3YkdsallYUnBiMjRnWlhocGMzUnpDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ6YUc5MWJHUWdZbVVnZG1WeWMybHZiaUF4Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWFp0TVRJdVlXeG5ieTUwY3pvek9DMDBOUW9nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdVlYQndiR2xqWVhScGIyNURZV3hzS0hzS0lDQWdJQzh2SUNBZ0lDQmhjSEJCY21kek9pQmJZWEpqTkM1dFpYUm9iMlJUWld4bFkzUnZjaWhEYjI1MGNtRmpkRll4TG5CeWIzUnZkSGx3WlM1a1pXeGxkR1VwWFN3S0lDQWdJQzh2SUNBZ0lDQnZia052YlhCc1pYUnBiMjQ2SUU5dVEyOXRjR3hsZEdWQlkzUnBiMjR1UkdWc1pYUmxRWEJ3YkdsallYUnBiMjRzQ2lBZ0lDQXZMeUFnSUNBZ1lYQndTV1E2SUdGd2NDd0tJQ0FnSUM4dklDQWdJQ0J5WldwbFkzUldaWEp6YVc5dU9pQXlMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdMeThnSUNBdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhkbTB4TWk1aGJHZHZMblJ6T2pRekNpQWdJQ0F2THlCeVpXcGxZM1JXWlhKemFXOXVPaUF5TEFvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNCcGRIaHVYMlpwWld4a0lGSmxhbVZqZEZabGNuTnBiMjRLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkYyYlRFeUxtRnNaMjh1ZEhNNk5ERUtJQ0FnSUM4dklHOXVRMjl0Y0d4bGRHbHZiam9nVDI1RGIyMXdiR1YwWlVGamRHbHZiaTVFWld4bGRHVkJjSEJzYVdOaGRHbHZiaXdLSUNBZ0lIQjFjMmhwYm5RZ05Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGRtMHhNaTVoYkdkdkxuUnpPalF3Q2lBZ0lDQXZMeUJoY0hCQmNtZHpPaUJiWVhKak5DNXRaWFJvYjJSVFpXeGxZM1J2Y2loRGIyNTBjbUZqZEZZeExuQnliM1J2ZEhsd1pTNWtaV3hsZEdVcFhTd0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VESTBNemM0WkROaklDOHZJRzFsZEdodlpDQWlaR1ZzWlhSbEtDbDJiMmxrSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGRtMHhNaTVoYkdkdkxuUnpPak00TFRRMENpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzVoY0hCc2FXTmhkR2x2YmtOaGJHd29ld29nSUNBZ0x5OGdJQ0FnSUdGd2NFRnlaM002SUZ0aGNtTTBMbTFsZEdodlpGTmxiR1ZqZEc5eUtFTnZiblJ5WVdOMFZqRXVjSEp2ZEc5MGVYQmxMbVJsYkdWMFpTbGRMQW9nSUNBZ0x5OGdJQ0FnSUc5dVEyOXRjR3hsZEdsdmJqb2dUMjVEYjIxd2JHVjBaVUZqZEdsdmJpNUVaV3hsZEdWQmNIQnNhV05oZEdsdmJpd0tJQ0FnSUM4dklDQWdJQ0JoY0hCSlpEb2dZWEJ3TEFvZ0lDQWdMeThnSUNBZ0lISmxhbVZqZEZabGNuTnBiMjQ2SURJc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNCcGJuUmpYeklnTHk4Z05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWFp0TVRJdVlXeG5ieTUwY3pvek9DMDBOUW9nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdVlYQndiR2xqWVhScGIyNURZV3hzS0hzS0lDQWdJQzh2SUNBZ0lDQmhjSEJCY21kek9pQmJZWEpqTkM1dFpYUm9iMlJUWld4bFkzUnZjaWhEYjI1MGNtRmpkRll4TG5CeWIzUnZkSGx3WlM1a1pXeGxkR1VwWFN3S0lDQWdJQzh2SUNBZ0lDQnZia052YlhCc1pYUnBiMjQ2SUU5dVEyOXRjR3hsZEdWQlkzUnBiMjR1UkdWc1pYUmxRWEJ3YkdsallYUnBiMjRzQ2lBZ0lDQXZMeUFnSUNBZ1lYQndTV1E2SUdGd2NDd0tJQ0FnSUM4dklDQWdJQ0J5WldwbFkzUldaWEp6YVc5dU9pQXlMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdMeThnSUNBdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWFp0TVRJdVlXeG5ieTUwY3pveU1Bb2dJQ0FnTHk4Z2RHVnpkRkpsYW1WamRGWmxjbk5wYjI0b0tTQjdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjM1JHWVd4amIyNVdaWEpwWm5sZmNtOTFkR1ZBTkRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloZG0weE1pNWhiR2R2TG5Sek9qRTNDaUFnSUNBdkx5QmhjM05sY25Rb0lXOXdMbVpoYkdOdmJsWmxjbWxtZVNoQ2VYUmxjeWdwTENCQ2VYUmxjeWdwTENCdmNDNWllbVZ5YnlneE56a3pLU2twQ2lBZ0lDQndkWE5vYVc1MElERTNPVE1LSUNBZ0lHSjZaWEp2Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGdLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JtWVd4amIyNWZkbVZ5YVdaNUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloZG0weE1pNWhiR2R2TG5Sek9qRTJDaUFnSUNBdkx5QjBaWE4wUm1Gc1kyOXVWbVZ5YVdaNUtDa2dld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU9Ub0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGRtMHhNaTVoYkdkdkxuUnpPakUwTFRFMUNpQWdJQ0F2THlCQVkyOXVkSEpoWTNRb2V5QmhkbTFXWlhKemFXOXVPaUF4TWlCOUtRb2dJQ0FnTHk4Z1kyeGhjM01nUVhadE1USkRiMjUwY21GamRDQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNBbUpnb2dJQ0FnY21WMGRYSnVDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXlDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiRENBREFBRUdKZ0VFRElFQlF6RWJRUURtTVJrVVJERVlSSUlDQkFMMHBRRUVwRk82a0RZYUFJNENBTHdBQVFDeEtMSkNnQzRNTVJ0QkFDQ0FCS0RvR0hJMkdnQ09BUUFCQURFWmdRUVNNUmdRUkRGRWdRRVNSSUVCUXpFWkZERVlGQkJEc2tBaXNoa2tzaEFpc2dHenREMUpjZ2xFRkVTeEtMSkNnQzRNTVJ0QkFDQ0FCQ1EzalR3MkdnQ09BUUFCQURFWmdRVVNNUmdRUkRGRWdRSVNSSUVCUXpFWkZERVlGQkJEc2tDQkJMSVpTYklZSTdKRWdBU2c2Qmh5c2hva3NoQWlzZ0d6dEJoeUNVUWpFa1N4Z1FLeVJMSVlnUVd5R1lBRUpEZU5QTElhSkxJUUlySUJzeU5EZ1lFT3I0QUFTVThDaFJSRUkwTXhHUlF4R0JRUVF3PT0iLCJjbGVhciI6IkRJRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
