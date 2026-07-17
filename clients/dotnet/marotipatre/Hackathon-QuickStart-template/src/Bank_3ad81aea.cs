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

namespace Arc56.Generated.marotipatre.Hackathon_QuickStart_template.Bank_3ad81aea
{


    public class BankProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public BankProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Accepts a payment into the app escrow and records sender's deposited balance
        ///</summary>
        /// <param name="memo"> </param>
        /// <param name="pay_txn"> </param>
        public async Task<ulong> Deposit(PaymentTransaction pay_txn, string memo, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay_txn });
            byte[] abiHandle = { 159, 89, 124, 50 };
            var memoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); memoAbi.From(memo);

            var result = await base.CallApp(new List<object> { abiHandle, memoAbi, pay_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Deposit_Transactions(PaymentTransaction pay_txn, string memo, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay_txn });
            byte[] abiHandle = { 159, 89, 124, 50 };
            var memoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); memoAbi.From(memo);

            return await base.MakeTransactionList(new List<object> { abiHandle, memoAbi, pay_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Sends ALGO back to the caller from their recorded balance
        ///</summary>
        /// <param name="amount"> </param>
        public async Task<ulong> Withdraw(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 49, 33, 65, 118 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Withdraw_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 49, 33, 65, 118 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQmFuayIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJkZXBvc2l0IiwiZGVzYyI6IkFjY2VwdHMgYSBwYXltZW50IGludG8gdGhlIGFwcCBlc2Nyb3cgYW5kIHJlY29yZHMgc2VuZGVyJ3MgZGVwb3NpdGVkIGJhbGFuY2UiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibWVtbyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5X3R4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IndpdGhkcmF3IiwiZGVzYyI6IlNlbmRzIEFMR08gYmFjayB0byB0aGUgY2FsbGVyIGZyb20gdGhlaXIgcmVjb3JkZWQgYmFsYW5jZSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzExMl0sImVycm9yTWVzc2FnZSI6IkRlcG9zaXQgYW1vdW50IG11c3QgYmUgZ3JlYXRlciB0aGFuIHplcm8iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODBdLCJlcnJvck1lc3NhZ2UiOiJObyBkZXBvc2l0cyBmb3VuZCBmb3IgdGhpcyBhY2NvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDJdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzVdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wICYmIGNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNV0sImVycm9yTWVzc2FnZSI6IlJlY2VpdmVyIG11c3QgYmUgdGhlIGNvbnRyYWN0IGFkZHJlc3MiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODZdLCJlcnJvck1lc3NhZ2UiOiJXaXRoZHJhd2FsIGFtb3VudCBleGNlZWRzIGJhbGFuY2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODNdLCJlcnJvck1lc3NhZ2UiOiJXaXRoZHJhd2FsIGFtb3VudCBtdXN0IGJlIGdyZWF0ZXIgdGhhbiB6ZXJvIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5kZXBvc2l0cyBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX2RlcG9zaXQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgKGxlbit1dGY4W10pIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTcyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk4XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF4SURBS0lDQWdJR0o1ZEdWallteHZZMnNnSW5SdmRHRnNYMlJsY0c5emFYUWlJREI0TVRVeFpqZGpOelVLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aVlXNXJMMk52Ym5SeVlXTjBMbkI1T2pFeENpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gyUmxjRzl6YVhRZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luUnZkR0ZzWDJSbGNHOXphWFFpQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKaGJtc3ZZMjl1ZEhKaFkzUXVjSGs2TlFvZ0lDQWdMeThnWTJ4aGMzTWdRbUZ1YXloQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2Y0hsZlpHVm1ZWFZzZEY5amNtVmhkR1ZBTVRFS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2JYVnpkQ0JpWlNCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE9XWTFPVGRqTXpJZ01IZ3pNVEl4TkRFM05pQXZMeUJ0WlhSb2IyUWdJbVJsY0c5emFYUW9jM1J5YVc1bkxIQmhlU2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbmRwZEdoa2NtRjNLSFZwYm5RMk5DbDFhVzUwTmpRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmtaWEJ2YzJsMElIZHBkR2hrY21GM0NpQWdJQ0JsY25JS0NtMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFNVEU2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdKaVlLSUNBZ0lISmxkSFZ5YmlBdkx5QnZiaUJsY25KdmNqb2dUMjVEYjIxd2JHVjBhVzl1SUcxMWMzUWdZbVVnVG05UGNDQW1KaUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnWTNKbFlYUnBibWNLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVltRnVheTVqYjI1MGNtRmpkQzVDWVc1ckxtUmxjRzl6YVhSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGtaWEJ2YzJsME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKaGJtc3ZZMjl1ZEhKaFkzUXVjSGs2TVRNS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJSEIxYzJocGJuUWdNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlDaHNaVzRyZFhSbU9GdGRLUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnY0dGNUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nY0dGNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1GdWF5OWpiMjUwY21GamRDNXdlVG94TmdvZ0lDQWdMeThnWVhOelpYSjBJSEJoZVY5MGVHNHVjbVZqWldsMlpYSWdQVDBnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdnSWxKbFkyVnBkbVZ5SUcxMWMzUWdZbVVnZEdobElHTnZiblJ5WVdOMElHRmtaSEpsYzNNaUNpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGSmxZMlZwZG1WeUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJTWldObGFYWmxjaUJ0ZFhOMElHSmxJSFJvWlNCamIyNTBjbUZqZENCaFpHUnlaWE56Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbUZ1YXk5amIyNTBjbUZqZEM1d2VUb3hOd29nSUNBZ0x5OGdZWE56WlhKMElIQmhlVjkwZUc0dVlXMXZkVzUwSUQ0Z01Dd2dJa1JsY0c5emFYUWdZVzF2ZFc1MElHMTFjM1FnWW1VZ1ozSmxZWFJsY2lCMGFHRnVJSHBsY204aUNpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JoYzNObGNuUWdMeThnUkdWd2IzTnBkQ0JoYlc5MWJuUWdiWFZ6ZENCaVpTQm5jbVZoZEdWeUlIUm9ZVzRnZW1WeWJ3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKaGJtc3ZZMjl1ZEhKaFkzUXVjSGs2TVRrS0lDQWdJQzh2SUdGdGIzVnVkQ3dnWlhocGMzUnpJRDBnYzJWc1ppNWtaWEJ2YzJsMGN5NXRZWGxpWlNod1lYbGZkSGh1TG5ObGJtUmxjaWtLSUNBZ0lHZDBlRzV6SUZObGJtUmxjZ29nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbUZ1YXk5amIyNTBjbUZqZEM1d2VUb3lNQW9nSUNBZ0x5OGdhV1lnWlhocGMzUnpPZ29nSUNBZ1lub2daR1Z3YjNOcGRGOWxiSE5sWDJKdlpIbEFNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySmhibXN2WTI5dWRISmhZM1F1Y0hrNk1qRUtJQ0FnSUM4dklITmxiR1l1WkdWd2IzTnBkSE5iY0dGNVgzUjRiaTV6Wlc1a1pYSmRJRDBnWVcxdmRXNTBJQ3NnY0dGNVgzUjRiaTVoYlc5MWJuUUtJQ0FnSUdSMWNBb2dJQ0FnWkdsbklETUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDZ3BrWlhCdmMybDBYMkZtZEdWeVgybG1YMlZzYzJWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aVlXNXJMMk52Ym5SeVlXTjBMbkI1T2pJMUNpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gyUmxjRzl6YVhRZ0t6MGdjR0Y1WDNSNGJpNWhiVzkxYm5RS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0owYjNSaGJGOWtaWEJ2YzJsMElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gyUmxjRzl6YVhRZ1pYaHBjM1J6Q2lBZ0lDQmthV2NnTXdvZ0lDQWdLd29nSUNBZ1lubDBaV05mTUNBdkx5QWlkRzkwWVd4ZlpHVndiM05wZENJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1GdWF5OWpiMjUwY21GamRDNXdlVG95TmdvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdVpHVndiM05wZEhOYmNHRjVYM1I0Ymk1elpXNWtaWEpkQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVpHVndiM05wZEhNZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRnVheTlqYjI1MGNtRmpkQzV3ZVRveE13b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3BrWlhCdmMybDBYMlZzYzJWZlltOWtlVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoYm1zdlkyOXVkSEpoWTNRdWNIazZNak1LSUNBZ0lDOHZJSE5sYkdZdVpHVndiM05wZEhOYmNHRjVYM1I0Ymk1elpXNWtaWEpkSUQwZ2NHRjVYM1I0Ymk1aGJXOTFiblFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnWWlCa1pYQnZjMmwwWDJGbWRHVnlYMmxtWDJWc2MyVkFOQW9LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1aVlXNXJMbU52Ym5SeVlXTjBMa0poYm1zdWQybDBhR1J5WVhkYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDNhWFJvWkhKaGR6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aVlXNXJMMk52Ym5SeVlXTjBMbkI1T2pJNENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGdnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRnVheTlqYjI1MGNtRmpkQzV3ZVRvek1Rb2dJQ0FnTHk4Z1kzVnljbVZ1ZEN3Z1pYaHBjM1J6SUQwZ2MyVnNaaTVrWlhCdmMybDBjeTV0WVhsaVpTaFVlRzR1YzJWdVpHVnlLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2MzZGhjQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySmhibXN2WTI5dWRISmhZM1F1Y0hrNk16SUtJQ0FnSUM4dklHRnpjMlZ5ZENCbGVHbHpkSE1zSUNKT2J5QmtaWEJ2YzJsMGN5Qm1iM1Z1WkNCbWIzSWdkR2hwY3lCaFkyTnZkVzUwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWE56WlhKMElDOHZJRTV2SUdSbGNHOXphWFJ6SUdadmRXNWtJR1p2Y2lCMGFHbHpJR0ZqWTI5MWJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aVlXNXJMMk52Ym5SeVlXTjBMbkI1T2pNekNpQWdJQ0F2THlCaGMzTmxjblFnWVcxdmRXNTBJRDRnTUN3Z0lsZHBkR2hrY21GM1lXd2dZVzF2ZFc1MElHMTFjM1FnWW1VZ1ozSmxZWFJsY2lCMGFHRnVJSHBsY204aUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUZkcGRHaGtjbUYzWVd3Z1lXMXZkVzUwSUcxMWMzUWdZbVVnWjNKbFlYUmxjaUIwYUdGdUlIcGxjbThLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlZVzVyTDJOdmJuUnlZV04wTG5CNU9qTTBDaUFnSUNBdkx5QmhjM05sY25RZ1lXMXZkVzUwSUR3OUlHTjFjbkpsYm5Rc0lDSlhhWFJvWkhKaGQyRnNJR0Z0YjNWdWRDQmxlR05sWldSeklHSmhiR0Z1WTJVaUNpQWdJQ0JrZFhBeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRmRwZEdoa2NtRjNZV3dnWVcxdmRXNTBJR1Y0WTJWbFpITWdZbUZzWVc1alpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKaGJtc3ZZMjl1ZEhKaFkzUXVjSGs2TXpZS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDaHlaV05sYVhabGNqMVVlRzR1YzJWdVpHVnlMQ0JoYlc5MWJuUTlZVzF2ZFc1MExDQm1aV1U5TUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdScFp5QXlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoYm1zdlkyOXVkSEpoWTNRdWNIazZNemdLSUNBZ0lDOHZJSEpsYldGcGJtbHVaeUE5SUdOMWNuSmxiblFnTFNCaGJXOTFiblFLSUNBZ0lITjNZWEFLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKaGJtc3ZZMjl1ZEhKaFkzUXVjSGs2TXprS0lDQWdJQzh2SUdsbUlISmxiV0ZwYm1sdVp5QTlQU0JWU1c1ME5qUW9NQ2s2Q2lBZ0lDQmlibm9nZDJsMGFHUnlZWGRmWld4elpWOWliMlI1UURRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpWVc1ckwyTnZiblJ5WVdOMExuQjVPalF3Q2lBZ0lDQXZMeUJrWld3Z2MyVnNaaTVrWlhCdmMybDBjMXRVZUc0dWMyVnVaR1Z5WFFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2dwM2FYUm9aSEpoZDE5aFpuUmxjbDlwWmw5bGJITmxRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbUZ1YXk5amIyNTBjbUZqZEM1d2VUb3lPQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmtkWEFLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ25kcGRHaGtjbUYzWDJWc2MyVmZZbTlrZVVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKaGJtc3ZZMjl1ZEhKaFkzUXVjSGs2TkRJS0lDQWdJQzh2SUhObGJHWXVaR1Z3YjNOcGRITmJWSGh1TG5ObGJtUmxjbDBnUFNCeVpXMWhhVzVwYm1jS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmliM2hmY0hWMENpQWdJQ0JpSUhkcGRHaGtjbUYzWDJGbWRHVnlYMmxtWDJWc2MyVkFOUW89IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUNBUUFtQWcxMGIzUmhiRjlrWlhCdmMybDBCQlVmZkhVeEdFQUFBeWdqWnpFYlFRQWRNUmtVUkRFWVJJSUNCSjlaZkRJRU1TRkJkallhQUk0Q0FBa0FZUUF4R1JReEdCUVFRellhQVVraldZRUNDRXdWRWtReEZpSUpTVGdRSWhKRVNUZ0hNZ29TUkVrNENFbE9Ba1E0QUVtK1RCZE1RUUFmU1VzRENCWkxBa3kvSXlobFJFc0RDQ2hNWjBzQnZrUVhGaWxNVUxBaVEwc0NGa3NDVEw5Qy8rQTJHZ0ZKRllFSUVrUVhNUUMrVEJkTVJFc0JSRW9PUkxFeEFFc0NzZ2l5QnlLeUVDT3lBYk5NQ1VsQUFBd3hBTHhJU1JZcFRGQ3dJa014QUVzQkZyOUMvKzg9IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MiwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
