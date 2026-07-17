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

namespace Arc56.Generated.algorandfoundation.puya.CreateAndTransferContract_a2e6bbfa
{


    public class CreateAndTransferContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CreateAndTransferContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task CreateAndTransfer(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 72, 233, 237, 124 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateAndTransfer_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 72, 233, 237, 124 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ3JlYXRlQW5kVHJhbnNmZXJDb250cmFjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVfYW5kX3RyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbODZdLCJlcnJvck1lc3NhZ2UiOiJhc3NldCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFd01EQUtJQ0FnSUM4dklHbHVibVZ5WDNSeVlXNXpZV04wYVc5dWN5OWhjM05sZEY5MGNtRnVjMlpsY2k1d2VUb3hNQW9nSUNBZ0x5OGdZMnhoYzNNZ1EzSmxZWFJsUVc1a1ZISmhibk5tWlhKRGIyNTBjbUZqZENoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2Y0hsZlpHVm1ZWFZzZEY5amNtVmhkR1ZBTlFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TkRobE9XVmtOMk1nTHk4Z2JXVjBhRzlrSUNKamNtVmhkR1ZmWVc1a1gzUnlZVzV6Wm1WeUtDbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDlqY21WaGRHVmZZVzVrWDNSeVlXNXpabVZ5WDNKdmRYUmxRRE1LSUNBZ0lHVnljZ29LYldGcGJsOWpjbVZoZEdWZllXNWtYM1J5WVc1elptVnlYM0p2ZFhSbFFETTZDaUFnSUNBdkx5QnBibTVsY2w5MGNtRnVjMkZqZEdsdmJuTXZZWE56WlhSZmRISmhibk5tWlhJdWNIazZNVEVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdKaVlLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdZaUJqY21WaGRHVmZZVzVrWDNSeVlXNXpabVZ5Q2dwdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFEVTZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1JmWTJGelpYTXVhVzV1WlhKZmRISmhibk5oWTNScGIyNXpMbUZ6YzJWMFgzUnlZVzV6Wm1WeUxrTnlaV0YwWlVGdVpGUnlZVzV6Wm1WeVEyOXVkSEpoWTNRdVkzSmxZWFJsWDJGdVpGOTBjbUZ1YzJabGNsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU55WldGMFpWOWhibVJmZEhKaGJuTm1aWEk2Q2lBZ0lDQXZMeUJwYm01bGNsOTBjbUZ1YzJGamRHbHZibk12WVhOelpYUmZkSEpoYm5ObVpYSXVjSGs2TVRVdE1qTUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUkRiMjVtYVdjb0NpQWdJQ0F2THlBZ0lDQWdkRzkwWVd3OU1UQXdNQ3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl1WVcxbFBTSjBaWE4wSWl3S0lDQWdJQzh2SUNBZ0lDQjFibWwwWDI1aGJXVTlJbFJUVkNJc0NpQWdJQ0F2THlBZ0lDQWdaR1ZqYVcxaGJITTlNQ3dLSUNBZ0lDOHZJQ0FnSUNCdFlXNWhaMlZ5UFc5d0xrZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdZMnhoZDJKaFkyczliM0F1UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ2tLSUNBZ0lDOHZJQzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2FXNXVaWEpmZEhKaGJuTmhZM1JwYjI1ekwyRnpjMlYwWDNSeVlXNXpabVZ5TG5CNU9qSXdDaUFnSUNBdkx5QnRZVzVoWjJWeVBXOXdMa2RzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ0x5OGdhVzV1WlhKZmRISmhibk5oWTNScGIyNXpMMkZ6YzJWMFgzUnlZVzV6Wm1WeUxuQjVPakl4Q2lBZ0lDQXZMeUJqYkdGM1ltRmphejF2Y0M1SGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdaSFZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwUTJ4aGQySmhZMnNLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJOWVc1aFoyVnlDaUFnSUNBdkx5QnBibTVsY2w5MGNtRnVjMkZqZEdsdmJuTXZZWE56WlhSZmRISmhibk5tWlhJdWNIazZNVGtLSUNBZ0lDOHZJR1JsWTJsdFlXeHpQVEFzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRVJsWTJsdFlXeHpDaUFnSUNBdkx5QnBibTVsY2w5MGNtRnVjMkZqZEdsdmJuTXZZWE56WlhSZmRISmhibk5tWlhJdWNIazZNVGdLSUNBZ0lDOHZJSFZ1YVhSZmJtRnRaVDBpVkZOVUlpd0tJQ0FnSUhCMWMyaGllWFJsY3lBaVZGTlVJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRlZ1YVhST1lXMWxDaUFnSUNBdkx5QnBibTVsY2w5MGNtRnVjMkZqZEdsdmJuTXZZWE56WlhSZmRISmhibk5tWlhJdWNIazZNVGNLSUNBZ0lDOHZJR0Z6YzJWMFgyNWhiV1U5SW5SbGMzUWlMQW9nSUNBZ2NIVnphR0o1ZEdWeklDSjBaWE4wSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEU1aGJXVUtJQ0FnSUM4dklHbHVibVZ5WDNSeVlXNXpZV04wYVc5dWN5OWhjM05sZEY5MGNtRnVjMlpsY2k1d2VUb3hOZ29nSUNBZ0x5OGdkRzkwWVd3OU1UQXdNQ3dLSUNBZ0lHbHVkR05mTVNBdkx5QXhNREF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwVkc5MFlXd0tJQ0FnSUM4dklHbHVibVZ5WDNSeVlXNXpZV04wYVc5dWN5OWhjM05sZEY5MGNtRnVjMlpsY2k1d2VUb3hOUW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRU52Ym1acFp5Z0tJQ0FnSUhCMWMyaHBiblFnTXlBdkx5QmhZMlpuQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklHbHVibVZ5WDNSeVlXNXpZV04wYVc5dWN5OWhjM05sZEY5MGNtRnVjMlpsY2k1d2VUb3hOUzB5TXdvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEVOdmJtWnBaeWdLSUNBZ0lDOHZJQ0FnSUNCMGIzUmhiRDB4TURBd0xBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyNWhiV1U5SW5SbGMzUWlMQW9nSUNBZ0x5OGdJQ0FnSUhWdWFYUmZibUZ0WlQwaVZGTlVJaXdLSUNBZ0lDOHZJQ0FnSUNCa1pXTnBiV0ZzY3owd0xBb2dJQ0FnTHk4Z0lDQWdJRzFoYm1GblpYSTliM0F1UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCamJHRjNZbUZqYXoxdmNDNUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0tRb2dJQ0FnTHk4Z0xuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYVc1dVpYSmZkSEpoYm5OaFkzUnBiMjV6TDJGemMyVjBYM1J5WVc1elptVnlMbkI1T2pFMUxUSTBDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBRMjl1Wm1sbktBb2dJQ0FnTHk4Z0lDQWdJSFJ2ZEdGc1BURXdNREFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmYm1GdFpUMGlkR1Z6ZENJc0NpQWdJQ0F2THlBZ0lDQWdkVzVwZEY5dVlXMWxQU0pVVTFRaUxBb2dJQ0FnTHk4Z0lDQWdJR1JsWTJsdFlXeHpQVEFzQ2lBZ0lDQXZMeUFnSUNBZ2JXRnVZV2RsY2oxdmNDNUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR05zWVhkaVlXTnJQVzl3TGtkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFwQ2lBZ0lDQXZMeUF1YzNWaWJXbDBLQ2tLSUNBZ0lDOHZJQzVqY21WaGRHVmtYMkZ6YzJWMENpQWdJQ0JwZEhodUlFTnlaV0YwWldSQmMzTmxkRWxFQ2lBZ0lDQXZMeUJwYm01bGNsOTBjbUZ1YzJGamRHbHZibk12WVhOelpYUmZkSEpoYm5ObVpYSXVjSGs2TWpjdE16TUtJQ0FnSUM4dklDTWdkSEpoYm5ObVpYSUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXpaVzVrWlhJOWJtVjNYMkZ6YzJWMExtTnlaV0YwYjNJc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5aGJXOTFiblE5TVRBd01Dd0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVgyRnpjMlYwUFc1bGQxOWhjM05sZEN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJR2x1Ym1WeVgzUnlZVzV6WVdOMGFXOXVjeTloYzNObGRGOTBjbUZ1YzJabGNpNXdlVG95T1FvZ0lDQWdMeThnWVhOelpYUmZjMlZ1WkdWeVBXNWxkMTloYzNObGRDNWpjbVZoZEc5eUxBb2dJQ0FnWkhWd0NpQWdJQ0JoYzNObGRGOXdZWEpoYlhOZloyVjBJRUZ6YzJWMFEzSmxZWFJ2Y2dvZ0lDQWdZWE56WlhKMElDOHZJR0Z6YzJWMElHVjRhWE4wY3dvZ0lDQWdMeThnYVc1dVpYSmZkSEpoYm5OaFkzUnBiMjV6TDJGemMyVjBYM1J5WVc1elptVnlMbkI1T2pNd0NpQWdJQ0F2THlCaGMzTmxkRjl5WldObGFYWmxjajFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCWVptVnlRWE56WlhRS0lDQWdJQzh2SUdsdWJtVnlYM1J5WVc1ellXTjBhVzl1Y3k5aGMzTmxkRjkwY21GdWMyWmxjaTV3ZVRvek1Rb2dJQ0FnTHk4Z1lYTnpaWFJmWVcxdmRXNTBQVEV3TURBc0NpQWdJQ0JwYm5Salh6RWdMeThnTVRBd01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRUZ0YjNWdWRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRkpsWTJWcGRtVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwVTJWdVpHVnlDaUFnSUNBdkx5QnBibTVsY2w5MGNtRnVjMkZqZEdsdmJuTXZZWE56WlhSZmRISmhibk5tWlhJdWNIazZNamN0TWpnS0lDQWdJQzh2SUNNZ2RISmhibk5tWlhJS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJSEIxYzJocGJuUWdOQ0F2THlCaGVHWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCcGJtNWxjbDkwY21GdWMyRmpkR2x2Ym5NdllYTnpaWFJmZEhKaGJuTm1aWEl1Y0hrNk1qY3RNek1LSUNBZ0lDOHZJQ01nZEhKaGJuTm1aWElLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl6Wlc1a1pYSTlibVYzWDJGemMyVjBMbU55WldGMGIzSXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZjbVZqWldsMlpYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOWhiVzkxYm5ROU1UQXdNQ3dLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBXNWxkMTloYzNObGRDd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCcGJtNWxjbDkwY21GdWMyRmpkR2x2Ym5NdllYTnpaWFJmZEhKaGJuTm1aWEl1Y0hrNk1URUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUNBT2dITVJ0QkFCaUFCRWpwN1h3MkdnQ09BUUFCQURFWkZERVlFRVJDQUFneEdSUXhHQlFRUTdFeUNrbXlMTElwSXJJamdBTlVVMVN5SllBRWRHVnpkTEltSTdJaWdRT3lFQ0t5QWJPMFBMRkpjUXRFTWdwUEFySVJJN0lTc2hTeUU0RUVzaEFpc2dHemdRRkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjk5LCJtaW5vciI6OTksInBhdGNoIjo5OSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
