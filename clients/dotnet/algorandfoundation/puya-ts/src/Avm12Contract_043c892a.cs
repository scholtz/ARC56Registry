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

namespace Arc56.Generated.algorandfoundation.puya_ts.Avm12Contract_043c892a
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXZtMTJDb250cmFjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0ZXN0RmFsY29uVmVyaWZ5IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RSZWplY3RWZXJzaW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTQxLDIzMF0sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0M10sImVycm9yTWVzc2FnZSI6InNob3VsZCBiZSB2ZXJzaW9uIDAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzNdLCJlcnJvck1lc3NhZ2UiOiJzaG91bGQgYmUgdmVyc2lvbiAxIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXlDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3SURZS0lDQWdJR0o1ZEdWallteHZZMnNnWW1GelpUWTBLRVJKUlVKUmR6MDlLUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRjJiVEV5TG1Gc1oyOHVkSE02TVRRdE1UVUtJQ0FnSUM4dklFQmpiMjUwY21GamRDaDdJR0YyYlZabGNuTnBiMjQ2SURFeUlIMHBDaUFnSUNBdkx5QmpiR0Z6Y3lCQmRtMHhNa052Ym5SeVlXTjBJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURBeVpqUmhOVEF4SURCNFlUUTFNMkpoT1RBZ0x5OGdiV1YwYUc5a0lDSjBaWE4wUm1Gc1kyOXVWbVZ5YVdaNUtDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKMFpYTjBVbVZxWldOMFZtVnljMmx2YmlncGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUhSbGMzUkdZV3hqYjI1V1pYSnBabmtnZEdWemRGSmxhbVZqZEZabGNuTnBiMjRLSUNBZ0lHVnljZ29LYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU9Ub0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGRtMHhNaTVoYkdkdkxuUnpPakUwTFRFMUNpQWdJQ0F2THlCQVkyOXVkSEpoWTNRb2V5QmhkbTFXWlhKemFXOXVPaUF4TWlCOUtRb2dJQ0FnTHk4Z1kyeGhjM01nUVhadE1USkRiMjUwY21GamRDQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNBbUpnb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGMmJURXlMbUZzWjI4dWRITTZPa0YyYlRFeVEyOXVkSEpoWTNRdWRHVnpkRVpoYkdOdmJsWmxjbWxtZVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuUmxjM1JHWVd4amIyNVdaWEpwWm5rNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhadE1USXVZV3huYnk1MGN6b3hOd29nSUNBZ0x5OGdZWE56WlhKMEtDRnZjQzVtWVd4amIyNVdaWEpwWm5rb1FubDBaWE1vS1N3Z1FubDBaWE1vS1N3Z2IzQXVZbnBsY204b01UYzVNeWtwS1FvZ0lDQWdjSFZ6YUdsdWRDQXhOemt6Q2lBZ0lDQmllbVZ5YndvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0Q2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWm1Gc1kyOXVYM1psY21sbWVRb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhadE1USXVZV3huYnk1MGN6b3hOZ29nSUNBZ0x5OGdkR1Z6ZEVaaGJHTnZibFpsY21sbWVTZ3BJSHNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYWnRNVEl1WVd4bmJ5NTBjem82UVhadE1USkRiMjUwY21GamRDNTBaWE4wVW1WcVpXTjBWbVZ5YzJsdmJsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblJsYzNSU1pXcGxZM1JXWlhKemFXOXVPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRjJiVEV5TG1Gc1oyOHVkSE02TWpJS0lDQWdJQzh2SUdOdmJuTjBJSFl3VkhodUlEMGdZMjl0Y0dsc1pXUldNQzVpWVhKbFEzSmxZWFJsS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhkbTB4TWk1aGJHZHZMblJ6T2pJeENpQWdJQ0F2THlCamIyNXpkQ0JqYjIxd2FXeGxaRll3SUQwZ1lYSmpOQzVqYjIxd2FXeGxRWEpqTkNoRGIyNTBjbUZqZEZZd0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlCaVlYTmxOalFvUkVsRlFsRjNQVDBwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRU5zWldGeVUzUmhkR1ZRY205bmNtRnRVR0ZuWlhNS0lDQWdJSEIxYzJoaWVYUmxjeUJpWVhObE5qUW9SRVJGWWxGUlFXRm5RVk5uTmtKb2VVNW9iMEZxWjBWQlFWRkJlRWRaUlVWRmFrVlpSVVZTUTBGQlozaEhVbEY0UjBKUlVWRjZSa1ZuVVVWVFVrbEZRbEYzUFQwcENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NISnZkbUZzVUhKdlozSmhiVkJoWjJWekNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhadE1USXVZV3huYnk1MGN6b3lNZ29nSUNBZ0x5OGdZMjl1YzNRZ2RqQlVlRzRnUFNCamIyMXdhV3hsWkZZd0xtSmhjbVZEY21WaGRHVW9LUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYeklnTHk4Z1lYQndiQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCRGNtVmhkR1ZrUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGMmJURXlMbUZzWjI4dWRITTZNalFLSUNBZ0lDOHZJR0Z6YzJWeWRDaGhjSEF1ZG1WeWMybHZiaUE5UFQwZ01Dd2dKM05vYjNWc1pDQmlaU0IyWlhKemFXOXVJREFuS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmhjSEJmY0dGeVlXMXpYMmRsZENCQmNIQldaWEp6YVc5dUNpQWdJQ0JoYzNObGNuUWdMeThnWVhCd2JHbGpZWFJwYjI0Z1pYaHBjM1J6Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z2MyaHZkV3hrSUdKbElIWmxjbk5wYjI0Z01Bb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGMmJURXlMbUZzWjI4dWRITTZNamd0TXpVS0lDQWdJQzh2SUdOdmJuTjBJSFl4VkhodUlEMGdZMjl0Y0dsc1pXUldNQzVqWVd4c0xuVndaR0YwWlNoN0NpQWdJQ0F2THlBZ0lISmxhbVZqZEZabGNuTnBiMjQ2SURFc0NpQWdJQ0F2THlBZ0lHRndjRWxrT2lCaGNIQXNDaUFnSUNBdkx5QWdJRzl1UTI5dGNHeGxkR2x2YmpvZ1QyNURiMjF3YkdWMFpVRmpkR2x2Ymk1VmNHUmhkR1ZCY0hCc2FXTmhkR2x2Yml3S0lDQWdJQzh2SUNBZ1lYQndjbTkyWVd4UWNtOW5jbUZ0T2lCamIyMXdhV3hsWkZZeExtRndjSEp2ZG1Gc1VISnZaM0poYlN3S0lDQWdJQzh2SUNBZ1kyeGxZWEpUZEdGMFpWQnliMmR5WVcwNklHTnZiWEJwYkdWa1ZqRXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMHNDaUFnSUNBdkx5QWdJR1Y0ZEhKaFVISnZaM0poYlZCaFoyVnpPaUJqYjIxd2FXeGxaRll4TG1WNGRISmhVSEp2WjNKaGJWQmhaMlZ6TEFvZ0lDQWdMeThnZlNrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhkbTB4TWk1aGJHZHZMblJ6T2pJMkNpQWdJQ0F2THlCamIyNXpkQ0JqYjIxd2FXeGxaRll4SUQwZ1lYSmpOQzVqYjIxd2FXeGxRWEpqTkNoRGIyNTBjbUZqZEZZeEtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlCaVlYTmxOalFvUkVsRlFsRjNQVDBwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRU5zWldGeVUzUmhkR1ZRY205bmNtRnRVR0ZuWlhNS0lDQWdJSEIxYzJoaWVYUmxjeUJpWVhObE5qUW9SRVJGWWxGUlFXRm5RVkZyVGpRd09FNW9iMEZxWjBWQlFWRkJlRWRaUlVaRmFrVlpSVVZTUTBGQlozaEhVbEY0UjBKUlVWRjZSa1ZuVVVsVFVrbEZRbEYzUFQwcENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NISnZkbUZzVUhKdlozSmhiVkJoWjJWekNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhadE1USXVZV3huYnk1MGN6b3pNUW9nSUNBZ0x5OGdiMjVEYjIxd2JHVjBhVzl1T2lCUGJrTnZiWEJzWlhSbFFXTjBhVzl1TGxWd1pHRjBaVUZ3Y0d4cFkyRjBhVzl1TEFvZ0lDQWdjSFZ6YUdsdWRDQTBDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ1pIVndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhkbTB4TWk1aGJHZHZMblJ6T2pJNUNpQWdJQ0F2THlCeVpXcGxZM1JXWlhKemFXOXVPaUF4TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZxWldOMFZtVnljMmx2YmdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkYyYlRFeUxtRnNaMjh1ZEhNNk1qZ3RNelVLSUNBZ0lDOHZJR052Ym5OMElIWXhWSGh1SUQwZ1kyOXRjR2xzWldSV01DNWpZV3hzTG5Wd1pHRjBaU2g3Q2lBZ0lDQXZMeUFnSUhKbGFtVmpkRlpsY25OcGIyNDZJREVzQ2lBZ0lDQXZMeUFnSUdGd2NFbGtPaUJoY0hBc0NpQWdJQ0F2THlBZ0lHOXVRMjl0Y0d4bGRHbHZiam9nVDI1RGIyMXdiR1YwWlVGamRHbHZiaTVWY0dSaGRHVkJjSEJzYVdOaGRHbHZiaXdLSUNBZ0lDOHZJQ0FnWVhCd2NtOTJZV3hRY205bmNtRnRPaUJqYjIxd2FXeGxaRll4TG1Gd2NISnZkbUZzVUhKdlozSmhiU3dLSUNBZ0lDOHZJQ0FnWTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzA2SUdOdmJYQnBiR1ZrVmpFdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwc0NpQWdJQ0F2THlBZ0lHVjRkSEpoVUhKdlozSmhiVkJoWjJWek9pQmpiMjF3YVd4bFpGWXhMbVY0ZEhKaFVISnZaM0poYlZCaFoyVnpMQW9nSUNBZ0x5OGdmU2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR0V3WlRneE9EY3lJQzh2SUcxbGRHaHZaQ0FpZFhCa1lYUmxLQ2wyYjJsa0lnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbHVkR05mTWlBdkx5QmhjSEJzQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhkbTB4TWk1aGJHZHZMblJ6T2pNMkNpQWdJQ0F2THlCaGMzTmxjblFvZGpGVWVHNHVhWFI0Ymk1aGNIQkpaQzUyWlhKemFXOXVJRDA5UFNBeExDQW5jMmh2ZFd4a0lHSmxJSFpsY25OcGIyNGdNU2NwQ2lBZ0lDQmhjSEJmY0dGeVlXMXpYMmRsZENCQmNIQldaWEp6YVc5dUNpQWdJQ0JoYzNObGNuUWdMeThnWVhCd2JHbGpZWFJwYjI0Z1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCemFHOTFiR1FnWW1VZ2RtVnljMmx2YmlBeENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhadE1USXVZV3huYnk1MGN6b3pPQzAwTlFvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVZWEJ3YkdsallYUnBiMjVEWVd4c0tIc0tJQ0FnSUM4dklDQWdJQ0JoY0hCQmNtZHpPaUJiWVhKak5DNXRaWFJvYjJSVFpXeGxZM1J2Y2loRGIyNTBjbUZqZEZZeExuQnliM1J2ZEhsd1pTNWtaV3hsZEdVcFhTd0tJQ0FnSUM4dklDQWdJQ0J2YmtOdmJYQnNaWFJwYjI0NklFOXVRMjl0Y0d4bGRHVkJZM1JwYjI0dVJHVnNaWFJsUVhCd2JHbGpZWFJwYjI0c0NpQWdJQ0F2THlBZ0lDQWdZWEJ3U1dRNklHRndjQ3dLSUNBZ0lDOHZJQ0FnSUNCeVpXcGxZM1JXWlhKemFXOXVPaUF5TEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnTHk4Z0lDQXVjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloZG0weE1pNWhiR2R2TG5Sek9qUXpDaUFnSUNBdkx5QnlaV3BsWTNSV1pYSnphVzl1T2lBeUxBb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRkpsYW1WamRGWmxjbk5wYjI0S0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGMmJURXlMbUZzWjI4dWRITTZOREVLSUNBZ0lDOHZJRzl1UTI5dGNHeGxkR2x2YmpvZ1QyNURiMjF3YkdWMFpVRmpkR2x2Ymk1RVpXeGxkR1ZCY0hCc2FXTmhkR2x2Yml3S0lDQWdJSEIxYzJocGJuUWdOUW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhkbTB4TWk1aGJHZHZMblJ6T2pRd0NpQWdJQ0F2THlCaGNIQkJjbWR6T2lCYllYSmpOQzV0WlhSb2IyUlRaV3hsWTNSdmNpaERiMjUwY21GamRGWXhMbkJ5YjNSdmRIbHdaUzVrWld4bGRHVXBYU3dLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREkwTXpjNFpETmpJQzh2SUcxbGRHaHZaQ0FpWkdWc1pYUmxLQ2wyYjJsa0lnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhkbTB4TWk1aGJHZHZMblJ6T2pNNExUUTBDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1aGNIQnNhV05oZEdsdmJrTmhiR3dvZXdvZ0lDQWdMeThnSUNBZ0lHRndjRUZ5WjNNNklGdGhjbU0wTG0xbGRHaHZaRk5sYkdWamRHOXlLRU52Ym5SeVlXTjBWakV1Y0hKdmRHOTBlWEJsTG1SbGJHVjBaU2xkTEFvZ0lDQWdMeThnSUNBZ0lHOXVRMjl0Y0d4bGRHbHZiam9nVDI1RGIyMXdiR1YwWlVGamRHbHZiaTVFWld4bGRHVkJjSEJzYVdOaGRHbHZiaXdLSUNBZ0lDOHZJQ0FnSUNCaGNIQkpaRG9nWVhCd0xBb2dJQ0FnTHk4Z0lDQWdJSEpsYW1WamRGWmxjbk5wYjI0NklESXNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdOZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhadE1USXVZV3huYnk1MGN6b3pPQzAwTlFvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVZWEJ3YkdsallYUnBiMjVEWVd4c0tIc0tJQ0FnSUM4dklDQWdJQ0JoY0hCQmNtZHpPaUJiWVhKak5DNXRaWFJvYjJSVFpXeGxZM1J2Y2loRGIyNTBjbUZqZEZZeExuQnliM1J2ZEhsd1pTNWtaV3hsZEdVcFhTd0tJQ0FnSUM4dklDQWdJQ0J2YmtOdmJYQnNaWFJwYjI0NklFOXVRMjl0Y0d4bGRHVkJZM1JwYjI0dVJHVnNaWFJsUVhCd2JHbGpZWFJwYjI0c0NpQWdJQ0F2THlBZ0lDQWdZWEJ3U1dRNklHRndjQ3dLSUNBZ0lDOHZJQ0FnSUNCeVpXcGxZM1JXWlhKemFXOXVPaUF5TEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnTHk4Z0lDQXVjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhadE1USXVZV3huYnk1MGN6b3lNQW9nSUNBZ0x5OGdkR1Z6ZEZKbGFtVmpkRlpsY25OcGIyNG9LU0I3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV5Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkRDQURBUUFHSmdFRURJRUJRekViUVFBZE1Sa1VSREVZUklJQ0JBTDBwUUVFcEZPNmtEWWFBSTRDQUFrQUZ3QXhHUlF4R0JRUVE0R0JEcStBQUVsUEFvVVVSQ0pEc1NpeVFvQXhEREViUVFBYWdBU2c2Qmh5TmhvQWpnRUFBUUF4R1lFRUVqRVlFRVJDQUFneEdSUXhHQlFRUXpGRWdRRVNSSUVCUTdKQUk3SVpKTElRSTdJQnM3UTlTWElKUkJSRXNTaXlRb0F4RERFYlFRQWFnQVFrTjQwOE5ob0FqZ0VBQVFBeEdZRUZFakVZRUVSQ0FBZ3hHUlF4R0JRUVF6RkVnUUlTUklFQlE3SkFnUVN5R1VteUdDS3lSSUFFb09nWWNySWFKTElRSTdJQnM3UVljZ2xFSWhKRXNZRUNza1N5R0lFRnNobUFCQ1EzalR5eUdpU3lFQ095QWJNaVF3PT0iLCJjbGVhciI6IkRJRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
