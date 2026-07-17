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

namespace Arc56.Generated.algorandfoundation.puya_ts.StoreBoth_70fcbf6e
{


    public class StoreBothProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public StoreBothProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="theString"> </param>
        /// <param name="theUint"> </param>
        public async Task Test(string theString, ulong theUint, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 207, 54, 45, 105 };
            var theStringAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); theStringAbi.From(theString);
            var theUintAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); theUintAbi.From(theUint);

            var result = await base.CallApp(new List<object> { abiHandle, theStringAbi, theUintAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Test_Transactions(string theString, ulong theUint, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 207, 54, 45, 105 };
            var theStringAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); theStringAbi.From(theString);
            var theUintAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); theUintAbi.From(theUint);

            return await base.MakeTransactionList(new List<object> { abiHandle, theStringAbi, theUintAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task SetStore(string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 72, 242, 110, 133 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetStore_Transactions(string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 72, 242, 110, 133 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3RvcmVCb3RoIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6InRlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGhlU3RyaW5nIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0aGVVaW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldFN0b3JlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTIyLDE1OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzMSwxNjddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURJS0lDQWdJR0lnYldGcGJsOWliRzlqYTBBd0NncHRZV2x1WDJKc2IyTnJRREE2Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNCaUlHMWhhVzVmYVdaZlltOWtlVUF4Q2dwdFlXbHVYMmxtWDJKdlpIbEFNVG9LSUNBZ0lHTmhiR3h6ZFdJZ1kyOXVjM1J5ZFdOMGIzSUtJQ0FnSUdJZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdZaUJ0WVdsdVgySnNiMk5yUURNS0NtMWhhVzVmWW14dlkydEFNem9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkV3gwYVMxcGJtaGxjbWwwWVc1alpTMHlMbUZzWjI4dWRITTZNakVLSUNBZ0lDOHZJR05zWVhOeklGTjBiM0psUW05MGFDQmxlSFJsYm1SeklHTnNZWE56WlhNb1UzUnZjbVZUZEhKcGJtY3NJRk4wYjNKbFZXbHVkRFkwS1NCN0NpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQ0U5Q2lBZ0lDQmllaUJ0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBeE1Rb2dJQ0FnWWlCdFlXbHVYMkZpYVY5eWIzVjBhVzVuUURRS0NtMWhhVzVmWVdKcFgzSnZkWFJwYm1kQU5Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRXeDBhUzFwYm1obGNtbDBZVzVqWlMweUxtRnNaMjh1ZEhNNk1qRUtJQ0FnSUM4dklHTnNZWE56SUZOMGIzSmxRbTkwYUNCbGVIUmxibVJ6SUdOc1lYTnpaWE1vVTNSdmNtVlRkSEpwYm1jc0lGTjBiM0psVldsdWREWTBLU0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnVG05UGNBb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBaFBRb2dJQ0FnWW5vZ2JXRnBibDlqY21WaGRHVmZUbTlQY0VBNUNpQWdJQ0JpSUcxaGFXNWZZMkZzYkY5T2IwOXdRRFVLQ20xaGFXNWZZMkZzYkY5T2IwOXdRRFU2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFZzZEdrdGFXNW9aWEpwZEdGdVkyVXRNaTVoYkdkdkxuUnpPakl4Q2lBZ0lDQXZMeUJqYkdGemN5QlRkRzl5WlVKdmRHZ2daWGgwWlc1a2N5QmpiR0Z6YzJWektGTjBiM0psVTNSeWFXNW5MQ0JUZEc5eVpWVnBiblEyTkNrZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFkyWXpOakprTmprZ0x5OGdiV1YwYUc5a0lDSjBaWE4wS0hOMGNtbHVaeXgxYVc1ME5qUXBkbTlwWkNJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURRNFpqSTJaVGcxSUM4dklHMWxkR2h2WkNBaWMyVjBVM1J2Y21Vb2MzUnlhVzVuS1hadmFXUWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJRzFoZEdOb0lHMWhhVzVmZEdWemRGOXliM1YwWlVBMklHMWhhVzVmYzJWMFUzUnZjbVZmY205MWRHVkFOd29nSUNBZ1lpQnRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBT0FvS2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRRGc2Q2lBZ0lDQmlJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TUFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERXdPZ29nSUNBZ1lpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVElLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE1qb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRXeDBhUzFwYm1obGNtbDBZVzVqWlMweUxtRnNaMjh1ZEhNNk1qRUtJQ0FnSUM4dklHTnNZWE56SUZOMGIzSmxRbTkwYUNCbGVIUmxibVJ6SUdOc1lYTnpaWE1vVTNSdmNtVlRkSEpwYm1jc0lGTjBiM0psVldsdWREWTBLU0I3Q2lBZ0lDQmxjbklLQ20xaGFXNWZjMlYwVTNSdmNtVmZjbTkxZEdWQU56b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRXeDBhUzFwYm1obGNtbDBZVzVqWlMweUxtRnNaMjh1ZEhNNk9Bb2dJQ0FnTHk4Z2MyVjBVM1J2Y21Vb2RtRnNkV1U2SUhOMGNtbHVaeWtnZXdvZ0lDQWdZMkZzYkhOMVlpQnpaWFJUZEc5eVpRb2dJQ0FnWWlCdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFPQW9LYldGcGJsOTBaWE4wWDNKdmRYUmxRRFk2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFZzZEdrdGFXNW9aWEpwZEdGdVkyVXRNaTVoYkdkdkxuUnpPakl5Q2lBZ0lDQXZMeUIwWlhOMEtIUm9aVk4wY21sdVp6b2djM1J5YVc1bkxDQjBhR1ZWYVc1ME9pQjFhVzUwTmpRcElIc0tJQ0FnSUdOaGJHeHpkV0lnZEdWemRBb2dJQ0FnWWlCdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFPQW9LYldGcGJsOWpjbVZoZEdWZlRtOVBjRUE1T2dvZ0lDQWdZaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRBS0NtMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRREV4T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMVEl1WVd4bmJ5NTBjem95TVFvZ0lDQWdMeThnWTJ4aGMzTWdVM1J2Y21WQ2IzUm9JR1Y0ZEdWdVpITWdZMnhoYzNObGN5aFRkRzl5WlZOMGNtbHVaeXdnVTNSdmNtVlZhVzUwTmpRcElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5Qk9iMDl3Q2lBZ0lDQTlQUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQTlQUW9nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQW9nSUNBZ1kyRnNiSE4xWWlCZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1VLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVnNkR2t0YVc1b1pYSnBkR0Z1WTJVdE1pNWhiR2R2TG5Sek9qcFRkRzl5WlVKdmRHZ3VkR1Z6ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuUmxjM1E2Q2lBZ0lDQmlJSFJsYzNSZllteHZZMnRBTUFvS2RHVnpkRjlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFiSFJwTFdsdWFHVnlhWFJoYm1ObExUSXVZV3huYnk1MGN6b3lNZ29nSUNBZ0x5OGdkR1Z6ZENoMGFHVlRkSEpwYm1jNklITjBjbWx1Wnl3Z2RHaGxWV2x1ZERvZ2RXbHVkRFkwS1NCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkV3gwYVMxcGJtaGxjbWwwWVc1alpTMHlMbUZzWjI4dWRITTZPbE4wYjNKbFFtOTBhQzUwWlhOMENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMVEl1WVd4bmJ5NTBjem82VTNSdmNtVlRkSEpwYm1jdWMyVjBVM1J2Y21WYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHpaWFJUZEc5eVpUb0tJQ0FnSUdJZ2MyVjBVM1J2Y21WZllteHZZMnRBTUFvS2MyVjBVM1J2Y21WZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFd4MGFTMXBibWhsY21sMFlXNWpaUzB5TG1Gc1oyOHVkSE02T0FvZ0lDQWdMeThnYzJWMFUzUnZjbVVvZG1Gc2RXVTZJSE4wY21sdVp5a2dld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCallXeHNjM1ZpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFd4MGFTMXBibWhsY21sMFlXNWpaUzB5TG1Gc1oyOHVkSE02T2xOMGIzSmxVM1J5YVc1bkxuTmxkRk4wYjNKbENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMVEl1WVd4bmJ5NTBjem82VTNSdmNtVkNiM1JvTG5SbGMzUW9kR2hsVTNSeWFXNW5PaUJpZVhSbGN5d2dkR2hsVldsdWREb2dkV2x1ZERZMEtTQXRQaUIyYjJsa09ncDBaWE4wY3k5aGNIQnliM1poYkhNdmJYVnNkR2t0YVc1b1pYSnBkR0Z1WTJVdE1pNWhiR2R2TG5Sek9qcFRkRzl5WlVKdmRHZ3VkR1Z6ZERvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFd4MGFTMXBibWhsY21sMFlXNWpaUzB5TG1Gc1oyOHVkSE02TWpJS0lDQWdJQzh2SUhSbGMzUW9kR2hsVTNSeWFXNW5PaUJ6ZEhKcGJtY3NJSFJvWlZWcGJuUTZJSFZwYm5RMk5Da2dld29nSUNBZ2NISnZkRzhnTWlBd0NpQWdJQ0JpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFd4MGFTMXBibWhsY21sMFlXNWpaUzB5TG1Gc1oyOHVkSE02T2xOMGIzSmxRbTkwYUM1MFpYTjBYMkpzYjJOclFEQUtDblJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkV3gwYVMxcGJtaGxjbWwwWVc1alpTMHlMbUZzWjI4dWRITTZPbE4wYjNKbFFtOTBhQzUwWlhOMFgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWc2RHa3RhVzVvWlhKcGRHRnVZMlV0TWk1aGJHZHZMblJ6T2pJMENpQWdJQ0F2THlCMGFHbHpMbk5sZEZOMGIzSmxLSFJvWlZOMGNtbHVaeWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyRnNiSE4xWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWc2RHa3RhVzVvWlhKcGRHRnVZMlV0TWk1aGJHZHZMblJ6T2pwVGRHOXlaVk4wY21sdVp5NXpaWFJUZEc5eVpRb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWJIUnBMV2x1YUdWeWFYUmhibU5sTFRJdVlXeG5ieTUwY3pveU53b2dJQ0FnTHk4Z2MzVndaWEl1WTJ4aGMzTW9VM1J2Y21WVmFXNTBOalFwTG5ObGRGTjBiM0psS0hSb1pWVnBiblFwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTmhiR3h6ZFdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWJIUnBMV2x1YUdWeWFYUmhibU5sTFRJdVlXeG5ieTUwY3pvNlUzUnZjbVZWYVc1ME5qUXVjMlYwVTNSdmNtVUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRXeDBhUzFwYm1obGNtbDBZVzVqWlMweUxtRnNaMjh1ZEhNNk9sTjBiM0psVTNSeWFXNW5Mbk5sZEZOMGIzSmxLSFpoYkhWbE9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWJIUnBMV2x1YUdWeWFYUmhibU5sTFRJdVlXeG5ieTUwY3pvNlUzUnZjbVZUZEhKcGJtY3VjMlYwVTNSdmNtVTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVnNkR2t0YVc1b1pYSnBkR0Z1WTJVdE1pNWhiR2R2TG5Sek9qZ0tJQ0FnSUM4dklITmxkRk4wYjNKbEtIWmhiSFZsT2lCemRISnBibWNwSUhzS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVnNkR2t0YVc1b1pYSnBkR0Z1WTJVdE1pNWhiR2R2TG5Sek9qcFRkRzl5WlZOMGNtbHVaeTV6WlhSVGRHOXlaVjlpYkc5amEwQXdDZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFZzZEdrdGFXNW9aWEpwZEdGdVkyVXRNaTVoYkdkdkxuUnpPanBUZEc5eVpWTjBjbWx1Wnk1elpYUlRkRzl5WlY5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMVEl1WVd4bmJ5NTBjem8yQ2lBZ0lDQXZMeUJ6ZEhKcGJtZFRkRzl5WlNBOUlFZHNiMkpoYkZOMFlYUmxQSE4wY21sdVp6NG9LUW9nSUNBZ2NIVnphR0o1ZEdWeklDSnpkSEpwYm1kVGRHOXlaU0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkV3gwYVMxcGJtaGxjbWwwWVc1alpTMHlMbUZzWjI4dWRITTZPUW9nSUNBZ0x5OGdkR2hwY3k1emRISnBibWRUZEc5eVpTNTJZV3gxWlNBOUlIWmhiSFZsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFZzZEdrdGFXNW9aWEpwZEdGdVkyVXRNaTVoYkdkdkxuUnpPanBUZEc5eVpWVnBiblEyTkM1elpYUlRkRzl5WlNoMllXeDFaVG9nZFdsdWREWTBLU0F0UGlCMmIybGtPZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFZzZEdrdGFXNW9aWEpwZEdGdVkyVXRNaTVoYkdkdkxuUnpPanBUZEc5eVpWVnBiblEyTkM1elpYUlRkRzl5WlRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFd4MGFTMXBibWhsY21sMFlXNWpaUzB5TG1Gc1oyOHVkSE02TVRZS0lDQWdJQzh2SUhObGRGTjBiM0psS0haaGJIVmxPaUIxYVc1ME5qUXBJSHNLSUNBZ0lIQnliM1J2SURFZ01Bb2dJQ0FnWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWc2RHa3RhVzVvWlhKcGRHRnVZMlV0TWk1aGJHZHZMblJ6T2pwVGRHOXlaVlZwYm5RMk5DNXpaWFJUZEc5eVpWOWliRzlqYTBBd0NncDBaWE4wY3k5aGNIQnliM1poYkhNdmJYVnNkR2t0YVc1b1pYSnBkR0Z1WTJVdE1pNWhiR2R2TG5Sek9qcFRkRzl5WlZWcGJuUTJOQzV6WlhSVGRHOXlaVjlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFiSFJwTFdsdWFHVnlhWFJoYm1ObExUSXVZV3huYnk1MGN6b3hOQW9nSUNBZ0x5OGdkV2x1ZERZMFUzUnZjbVVnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDa0tJQ0FnSUhCMWMyaGllWFJsY3lBaWRXbHVkRFkwVTNSdmNtVWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVnNkR2t0YVc1b1pYSnBkR0Z1WTJVdE1pNWhiR2R2TG5Sek9qRTNDaUFnSUNBdkx5QjBhR2x6TG5WcGJuUTJORk4wYjNKbExuWmhiSFZsSUQwZ2RtRnNkV1VLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkV3gwYVMxcGJtaGxjbWwwWVc1alpTMHlMbUZzWjI4dWRITTZPbE4wYjNKbFFtOTBhQzVmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVW9LU0F0UGlCMmIybGtPZ3BmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVTZDaUFnSUNCaUlGOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlY5aWJHOWphMEF3Q2dwZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZmWW14dlkydEFNRG9LSUNBZ0lISmxkSE4xWWdvS0NpOHZJSEJ2YkhsMGVYQmxMMnhwWWk5d2IyeDVkSGx3WlMxdGIyUjFiR1V1WkM1MGN6bzZRMngxYzNSbGNtVmtRMjl1ZEhKaFkzUThkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFiSFJwTFdsdWFHVnlhWFJoYm1ObExUSXVZV3huYnk1MGN6bzZVM1J2Y21WVGRISnBibWNzZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMVEl1WVd4bmJ5NTBjem82VTNSdmNtVlZhVzUwTmpRK0xtTnZibk4wY25WamRHOXlLQ2tnTFQ0Z2RtOXBaRG9LWTI5dWMzUnlkV04wYjNJNkNpQWdJQ0JpSUdOdmJuTjBjblZqZEc5eVgySnNiMk5yUURBS0NtTnZibk4wY25WamRHOXlYMkpzYjJOclFEQTZDaUFnSUNCaUlHTnZibk4wY25WamRHOXlYMkpzYjJOclFERUtDbU52Ym5OMGNuVmpkRzl5WDJKc2IyTnJRREU2Q2lBZ0lDQmlJR052Ym5OMGNuVmpkRzl5WDJGbWRHVnlYMmx1YkdsdVpXUmZRR0ZzWjI5eVlXNWtabTkxYm1SaGRHbHZiaTloYkdkdmNtRnVaQzEwZVhCbGMyTnlhWEIwTDJKaGMyVXRZMjl1ZEhKaFkzUXVaQzUwY3pvNlFtRnpaVU52Ym5SeVlXTjBMbU52Ym5OMGNuVmpkRzl5UURJS0NtTnZibk4wY25WamRHOXlYMkZtZEdWeVgybHViR2x1WldSZlFHRnNaMjl5WVc1a1ptOTFibVJoZEdsdmJpOWhiR2R2Y21GdVpDMTBlWEJsYzJOeWFYQjBMMkpoYzJVdFkyOXVkSEpoWTNRdVpDNTBjem82UW1GelpVTnZiblJ5WVdOMExtTnZibk4wY25WamRHOXlRREk2Q2lBZ0lDQmlJR052Ym5OMGNuVmpkRzl5WDJKc2IyTnJRRE1LQ21OdmJuTjBjblZqZEc5eVgySnNiMk5yUURNNkNpQWdJQ0JpSUdOdmJuTjBjblZqZEc5eVgyRm1kR1Z5WDJsdWJHbHVaV1JmUUdGc1oyOXlZVzVrWm05MWJtUmhkR2x2Ymk5aGJHZHZjbUZ1WkMxMGVYQmxjMk55YVhCMEwySmhjMlV0WTI5dWRISmhZM1F1WkM1MGN6bzZRbUZ6WlVOdmJuUnlZV04wTG1OdmJuTjBjblZqZEc5eVFEUUtDbU52Ym5OMGNuVmpkRzl5WDJGbWRHVnlYMmx1YkdsdVpXUmZRR0ZzWjI5eVlXNWtabTkxYm1SaGRHbHZiaTloYkdkdmNtRnVaQzEwZVhCbGMyTnlhWEIwTDJKaGMyVXRZMjl1ZEhKaFkzUXVaQzUwY3pvNlFtRnpaVU52Ym5SeVlXTjBMbU52Ym5OMGNuVmpkRzl5UURRNkNpQWdJQ0J5WlhSemRXSUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCaUlHMWhhVzVmWW14dlkydEFNQW9LYldGcGJsOWliRzlqYTBBd09nb2dJQ0FnY0hWemFHbHVkQ0F4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QURBQUVDUWdBQU1SaEFBQWxDQUFDSUFOOUNBQUJDQUFBeEd5SVRRUUJDUWdBQU1Sa2lFa1F4R0NJVFFRQXdRZ0FBTmhvQWdBVFBOaTFwZ0FSSThtNkZUd0tPQWdBUUFBcENBQUJDQUFCQ0FBQUFpQUEvUXYvemlBQVZRdi90UXYvdE1Sa2lFakVZSWhJUVJJZ0FmeU5EUWdBQU5ob0JTU0paSXdza0NFc0JGUkpFVndJQU5ob0NTUldCQ0JKRUY0Z0FIQ05EUWdBQU5ob0JTU0paSXdza0NFc0JGUkpFVndJQWlBQVRJME9LQWdCQ0FBQ0wvb2dBQm92L2lBQVlpWW9CQUVJQUFJQUxjM1J5YVc1blUzUnZjbVdMLzJlSmlnRUFRZ0FBZ0F0MWFXNTBOalJUZEc5eVpZdi9aNGxDQUFDSlFnQUFRZ0FBUWdBQVFnQUFRZ0FBaVE9PSIsImNsZWFyIjoiQzBJQUFJRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
