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

namespace Arc56.Generated.algorandfoundation.puya.Contract_60de8619
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ29udHJhY3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoidGVzdF9mYWxjb25fdmVyaWZ5IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RfcmVqZWN0X3ZlcnNpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxMzgsMjI2XSwiZXJyb3JNZXNzYWdlIjoiYXBwbGljYXRpb24gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQwXSwiZXJyb3JNZXNzYWdlIjoic2hvdWxkIGJlIHZlcnNpb24gMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyOV0sImVycm9yTWVzc2FnZSI6InNob3VsZCBiZSB2ZXJzaW9uIDEiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeUNpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF4SURZZ01Bb2dJQ0FnWW5sMFpXTmliRzlqYXlCaVlYTmxOalFvUkVsRlFsRjNQVDBwQ2lBZ0lDQXZMeUJoZG0xZk1USXZZMjl1ZEhKaFkzUXVjSGs2TkFvZ0lDQWdMeThnWTJ4aGMzTWdRMjl1ZEhKaFkzUW9RVkpETkVOdmJuUnlZV04wTENCaGRtMWZkbVZ5YzJsdmJqMHhNaWs2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBNUNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhoaVpUVTJORGs1WXlBd2VHRmpPR0ZoWWpReUlDOHZJRzFsZEdodlpDQWlkR1Z6ZEY5bVlXeGpiMjVmZG1WeWFXWjVLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSjBaWE4wWDNKbGFtVmpkRjkyWlhKemFXOXVLQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dkR1Z6ZEY5bVlXeGpiMjVmZG1WeWFXWjVJSFJsYzNSZmNtVnFaV04wWDNabGNuTnBiMjRLSUNBZ0lHVnljZ29LYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBNU9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxtRjJiVjh4TWk1amIyNTBjbUZqZEM1RGIyNTBjbUZqZEM1MFpYTjBYMlpoYkdOdmJsOTJaWEpwWm5sYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBaWE4wWDJaaGJHTnZibDkyWlhKcFpuazZDaUFnSUNBdkx5QmhkbTFmTVRJdlkyOXVkSEpoWTNRdWNIazZOd29nSUNBZ0x5OGdZWE56WlhKMElHNXZkQ0J2Y0M1bVlXeGpiMjVmZG1WeWFXWjVLR0lpSWl3Z1lpSWlMQ0J2Y0M1aWVtVnlieWd4TnprektTa0tJQ0FnSUhCMWMyaHBiblFnTVRjNU13b2dJQ0FnWW5wbGNtOEtJQ0FnSUhCMWMyaGllWFJsY3lBd2VBb2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHWmhiR052Ymw5MlpYSnBabmtLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdZWFp0WHpFeUwyTnZiblJ5WVdOMExuQjVPalVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdVlYWnRYekV5TG1OdmJuUnlZV04wTGtOdmJuUnlZV04wTG5SbGMzUmZjbVZxWldOMFgzWmxjbk5wYjI1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBaWE4wWDNKbGFtVmpkRjkyWlhKemFXOXVPZ29nSUNBZ0x5OGdZWFp0WHpFeUwyTnZiblJ5WVdOMExuQjVPakV4Q2lBZ0lDQXZMeUJoY0hCZmRqQmZkSGh1SUQwZ1lYSmpOQzVoY21NMFgyTnlaV0YwWlNoRGIyNTBjbUZqZEZZd0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdZbmwwWldOZk1DQXZMeUJpWVhObE5qUW9SRWxGUWxGM1BUMHBDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnNaV0Z5VTNSaGRHVlFjbTluY21GdFVHRm5aWE1LSUNBZ0lIQjFjMmhpZVhSbGN5QmlZWE5sTmpRb1JFUkZZbEZSUVdGblFWTm5Oa0pvZVU1b2IwRnFaMFZCUVZGQmVFZFpSVVZGYWtWWlJVVlNRMEZCWjNoSFVsRjRSMEpSVVZGNlJrVm5VVVZUVWtsRlFsRjNQVDBwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0hKdmRtRnNVSEp2WjNKaGJWQmhaMlZ6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdZWEJ3YkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQkRjbVZoZEdWa1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0x5OGdZWFp0WHpFeUwyTnZiblJ5WVdOMExuQjVPakV6Q2lBZ0lDQXZMeUJoYzNObGNuUWdZWEJ3TG5abGNuTnBiMjRnUFQwZ01Dd2dJbk5vYjNWc1pDQmlaU0IyWlhKemFXOXVJREFpQ2lBZ0lDQmtkWEFLSUNBZ0lHRndjRjl3WVhKaGJYTmZaMlYwSUVGd2NGWmxjbk5wYjI0S0lDQWdJR0Z6YzJWeWRDQXZMeUJoY0hCc2FXTmhkR2x2YmlCbGVHbHpkSE1LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCemFHOTFiR1FnWW1VZ2RtVnljMmx2YmlBd0NpQWdJQ0F2THlCaGRtMWZNVEl2WTI5dWRISmhZM1F1Y0hrNk1UVXRNVGNLSUNBZ0lDOHZJR0Z5WXpRdVlYSmpORjkxY0dSaGRHVW9DaUFnSUNBdkx5QWdJQ0FnUTI5dWRISmhZM1JXTUM1MWNHUmhkR1VzSUdGd2NGOXBaRDFoY0hBc0lISmxhbVZqZEY5MlpYSnphVzl1UFRFc0lHTnZiWEJwYkdWa1BXTnZiWEJwYkdWZlkyOXVkSEpoWTNRb1EyOXVkSEpoWTNSV01Ta0tJQ0FnSUM4dklDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUdGMmJWOHhNaTlqYjI1MGNtRmpkQzV3ZVRveE5nb2dJQ0FnTHk4Z1EyOXVkSEpoWTNSV01DNTFjR1JoZEdVc0lHRndjRjlwWkQxaGNIQXNJSEpsYW1WamRGOTJaWEp6YVc5dVBURXNJR052YlhCcGJHVmtQV052YlhCcGJHVmZZMjl1ZEhKaFkzUW9RMjl1ZEhKaFkzUldNU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdZbUZ6WlRZMEtFUkpSVUpSZHowOUtRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGJHVmhjbE4wWVhSbFVISnZaM0poYlZCaFoyVnpDaUFnSUNCd2RYTm9ZbmwwWlhNZ1ltRnpaVFkwS0VSRVJXSlJVVUZoWjBGUmEwNDBNRGhPYUc5QmFtZEZRVUZSUVhoSFdVVkdSV3BGV1VWRlVrTkJRV2Q0UjFKUmVFZENVVkZSZWtaRloxRkpVMUpKUlVKUmR6MDlLUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJ5YjNaaGJGQnliMmR5WVcxUVlXZGxjd29nSUNBZ0x5OGdZWFp0WHpFeUwyTnZiblJ5WVdOMExuQjVPakUxTFRFM0NpQWdJQ0F2THlCaGNtTTBMbUZ5WXpSZmRYQmtZWFJsS0FvZ0lDQWdMeThnSUNBZ0lFTnZiblJ5WVdOMFZqQXVkWEJrWVhSbExDQmhjSEJmYVdROVlYQndMQ0J5WldwbFkzUmZkbVZ5YzJsdmJqMHhMQ0JqYjIxd2FXeGxaRDFqYjIxd2FXeGxYMk52Ym5SeVlXTjBLRU52Ym5SeVlXTjBWakVwQ2lBZ0lDQXZMeUFwQ2lBZ0lDQndkWE5vYVc1MElEUWdMeThnVlhCa1lYUmxRWEJ3YkdsallYUnBiMjRLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQXZMeUJoZG0xZk1USXZZMjl1ZEhKaFkzUXVjSGs2TVRZS0lDQWdJQzh2SUVOdmJuUnlZV04wVmpBdWRYQmtZWFJsTENCaGNIQmZhV1E5WVhCd0xDQnlaV3BsWTNSZmRtVnljMmx2YmoweExDQmpiMjF3YVd4bFpEMWpiMjF3YVd4bFgyTnZiblJ5WVdOMEtFTnZiblJ5WVdOMFZqRXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXcGxZM1JXWlhKemFXOXVDaUFnSUNCa2RYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRZVEJsT0RFNE56SWdMeThnYldWMGFHOWtJQ0oxY0dSaGRHVW9LWFp2YVdRaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ0x5OGdZWFp0WHpFeUwyTnZiblJ5WVdOMExuQjVPakUxTFRFM0NpQWdJQ0F2THlCaGNtTTBMbUZ5WXpSZmRYQmtZWFJsS0FvZ0lDQWdMeThnSUNBZ0lFTnZiblJ5WVdOMFZqQXVkWEJrWVhSbExDQmhjSEJmYVdROVlYQndMQ0J5WldwbFkzUmZkbVZ5YzJsdmJqMHhMQ0JqYjIxd2FXeGxaRDFqYjIxd2FXeGxYMk52Ym5SeVlXTjBLRU52Ym5SeVlXTjBWakVwQ2lBZ0lDQXZMeUFwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdZWEJ3YkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z1lYWnRYekV5TDJOdmJuUnlZV04wTG5CNU9qRTRDaUFnSUNBdkx5QmhjM05sY25RZ1lYQndMblpsY25OcGIyNGdQVDBnTVN3Z0luTm9iM1ZzWkNCaVpTQjJaWEp6YVc5dUlERWlDaUFnSUNCa2RYQUtJQ0FnSUdGd2NGOXdZWEpoYlhOZloyVjBJRUZ3Y0ZabGNuTnBiMjRLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjSEJzYVdOaGRHbHZiaUJsZUdsemRITUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSE5vYjNWc1pDQmlaU0IyWlhKemFXOXVJREVLSUNBZ0lDOHZJR0YyYlY4eE1pOWpiMjUwY21GamRDNXdlVG95TUMweU9Rb2dJQ0FnTHk4Z2FYUjRiaTVCY0hCc2FXTmhkR2x2YmtOaGJHd29DaUFnSUNBdkx5QWdJQ0FnWVhCd1gyRnlaM005S0FvZ0lDQWdMeThnSUNBZ0lDQWdJQ0JoY21NMExtRnlZelJmYzJsbmJtRjBkWEpsS0FvZ0lDQWdMeThnSUNBZ0lDQWdJQ0FnSUNBZ1EyOXVkSEpoWTNSV01TNWtaV3hsZEdVc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUNrc0NpQWdJQ0F2THlBZ0lDQWdLU3dLSUNBZ0lDOHZJQ0FnSUNCdmJsOWpiMjF3YkdWMGFXOXVQVTl1UTI5dGNHeGxkR1ZCWTNScGIyNHVSR1ZzWlhSbFFYQndiR2xqWVhScGIyNHNDaUFnSUNBdkx5QWdJQ0FnWVhCd1gybGtQV0Z3Y0N3S0lDQWdJQzh2SUNBZ0lDQnlaV3BsWTNSZmRtVnljMmx2YmoweUxBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnWVhadFh6RXlMMk52Ym5SeVlXTjBMbkI1T2pJNENpQWdJQ0F2THlCeVpXcGxZM1JmZG1WeWMybHZiajB5TEFvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNCcGRIaHVYMlpwWld4a0lGSmxhbVZqZEZabGNuTnBiMjRLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdMeThnWVhadFh6RXlMMk52Ym5SeVlXTjBMbkI1T2pJMkNpQWdJQ0F2THlCdmJsOWpiMjF3YkdWMGFXOXVQVTl1UTI5dGNHeGxkR1ZCWTNScGIyNHVSR1ZzWlhSbFFYQndiR2xqWVhScGIyNHNDaUFnSUNCd2RYTm9hVzUwSURVZ0x5OGdSR1ZzWlhSbFFYQndiR2xqWVhScGIyNEtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBdkx5QmhkbTFmTVRJdlkyOXVkSEpoWTNRdWNIazZNakl0TWpRS0lDQWdJQzh2SUdGeVl6UXVZWEpqTkY5emFXZHVZWFIxY21Vb0NpQWdJQ0F2THlBZ0lDQWdRMjl1ZEhKaFkzUldNUzVrWld4bGRHVXNDaUFnSUNBdkx5QXBMQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNalF6Tnpoa00yTWdMeThnYldWMGFHOWtJQ0prWld4bGRHVW9LWFp2YVdRaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ0x5OGdZWFp0WHpFeUwyTnZiblJ5WVdOMExuQjVPakl3Q2lBZ0lDQXZMeUJwZEhodUxrRndjR3hwWTJGMGFXOXVRMkZzYkNnS0lDQWdJR2x1ZEdOZk1TQXZMeUJoY0hCc0NpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJR0YyYlY4eE1pOWpiMjUwY21GamRDNXdlVG95TUMweU9Rb2dJQ0FnTHk4Z2FYUjRiaTVCY0hCc2FXTmhkR2x2YmtOaGJHd29DaUFnSUNBdkx5QWdJQ0FnWVhCd1gyRnlaM005S0FvZ0lDQWdMeThnSUNBZ0lDQWdJQ0JoY21NMExtRnlZelJmYzJsbmJtRjBkWEpsS0FvZ0lDQWdMeThnSUNBZ0lDQWdJQ0FnSUNBZ1EyOXVkSEpoWTNSV01TNWtaV3hsZEdVc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUNrc0NpQWdJQ0F2THlBZ0lDQWdLU3dLSUNBZ0lDOHZJQ0FnSUNCdmJsOWpiMjF3YkdWMGFXOXVQVTl1UTI5dGNHeGxkR1ZCWTNScGIyNHVSR1ZzWlhSbFFYQndiR2xqWVhScGIyNHNDaUFnSUNBdkx5QWdJQ0FnWVhCd1gybGtQV0Z3Y0N3S0lDQWdJQzh2SUNBZ0lDQnlaV3BsWTNSZmRtVnljMmx2YmoweUxBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUdGMmJWOHhNaTlqYjI1MGNtRmpkQzV3ZVRvNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXlDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiRENBREFRWUFKZ0VFRElFQlF6RWJRUUFkTVJrVVJERVlSSUlDQkw1V1Nad0VySXFyUWpZYUFJNENBQWtBRndBeEdSUXhHQlFRUTRHQkRxK0FBRWxQQW9VVVJDSkRzU2l5UW9BeERERWJRUUFhZ0FTZzZCaHlOaG9BamdFQUFRQXhHWUVFRWpFWUVFUkNBQWd4R1JReEdCUVFRekZFZ1FFU1JJRUJRN0pBSTdJUUpMSUJzN1E5U1hJSlJCUkVzU2l5UW9BeERERWJRUUFhZ0FRa040MDhOaG9BamdFQUFRQXhHWUVGRWpFWUVFUkNBQWd4R1JReEdCUVFRekZFZ1FJU1JJRUJRN0pBZ1FTeUdTS3lSRW15R0lBRW9PZ1ljcklhSTdJUUpMSUJzMGx5Q1VRaUVrU3hnUUt5UkxJWWdRV3lHWUFFSkRlTlBMSWFJN0lRSkxJQnN5SkQiLCJjbGVhciI6IkRJRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjk5LCJtaW5vciI6OTksInBhdGNoIjo5OSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
