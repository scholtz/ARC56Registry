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

namespace Arc56.Generated.Danish0703.ComplianceAudit.Bank_0e850390
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQmFuayIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJkZXBvc2l0IiwiZGVzYyI6IkFjY2VwdHMgYSBwYXltZW50IGludG8gdGhlIGFwcCBlc2Nyb3cgYW5kIHJlY29yZHMgc2VuZGVyJ3MgZGVwb3NpdGVkIGJhbGFuY2UiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibWVtbyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5X3R4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IndpdGhkcmF3IiwiZGVzYyI6IlNlbmRzIEFMR08gYmFjayB0byB0aGUgY2FsbGVyIGZyb20gdGhlaXIgcmVjb3JkZWQgYmFsYW5jZSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE0M10sImVycm9yTWVzc2FnZSI6IkRlcG9zaXQgYW1vdW50IG11c3QgYmUgZ3JlYXRlciB0aGFuIHplcm8iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDVdLCJlcnJvck1lc3NhZ2UiOiJObyBkZXBvc2l0cyBmb3VuZCBmb3IgdGhpcyBhY2NvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjUsODZdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzddLCJlcnJvck1lc3NhZ2UiOiJSZWNlaXZlciBtdXN0IGJlIHRoZSBjb250cmFjdCBhZGRyZXNzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjE0XSwiZXJyb3JNZXNzYWdlIjoiV2l0aGRyYXdhbCBhbW91bnQgZXhjZWVkcyBiYWxhbmNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjA4XSwiZXJyb3JNZXNzYWdlIjoiV2l0aGRyYXdhbCBhbW91bnQgbXVzdCBiZSBncmVhdGVyIHRoYW4gemVybyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNF0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY4LDg5XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4Ml0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZGVwb3NpdHMgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF9kZXBvc2l0IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNV0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZbUZ1YXk1amIyNTBjbUZqZEM1Q1lXNXJMbDlmWVd4bmIzQjVYMlZ1ZEhKNWNHOXBiblJmZDJsMGFGOXBibWwwS0NrZ0xUNGdkV2x1ZERZME9ncHRZV2x1T2dvZ0lDQWdhVzUwWTJKc2IyTnJJREVnTUFvZ0lDQWdZbmwwWldOaWJHOWpheUFpZEc5MFlXeGZaR1Z3YjNOcGRDSWdNSGd4TlRGbU4yTTNOUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKaGJtc3ZZMjl1ZEhKaFkzUXVjSGs2TVRFS0lDQWdJQzh2SUhObGJHWXVkRzkwWVd4ZlpHVndiM05wZENBOUlGVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRHOTBZV3hmWkdWd2IzTnBkQ0lLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1GdWF5OWpiMjUwY21GamRDNXdlVG8xQ2lBZ0lDQXZMeUJqYkdGemN5QkNZVzVyS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5aVlYSmxYM0p2ZFhScGJtZEFOd29nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRGxtTlRrM1l6TXlJREI0TXpFeU1UUXhOellnTHk4Z2JXVjBhRzlrSUNKa1pYQnZjMmwwS0hOMGNtbHVaeXh3WVhrcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKM2FYUm9aSEpoZHloMWFXNTBOalFwZFdsdWREWTBJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOWtaWEJ2YzJsMFgzSnZkWFJsUURVZ2JXRnBibDkzYVhSb1pISmhkMTl5YjNWMFpVQTJDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBT1RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpWVc1ckwyTnZiblJ5WVdOMExuQjVPalVLSUNBZ0lDOHZJR05zWVhOeklFSmhibXNvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmQybDBhR1J5WVhkZmNtOTFkR1ZBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpWVc1ckwyTnZiblJ5WVdOMExuQjVPakk0Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoYm1zdlkyOXVkSEpoWTNRdWNIazZOUW9nSUNBZ0x5OGdZMnhoYzNNZ1FtRnVheWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKaGJtc3ZZMjl1ZEhKaFkzUXVjSGs2TWpnS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUIzYVhSb1pISmhkd29nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWtaWEJ2YzJsMFgzSnZkWFJsUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1GdWF5OWpiMjUwY21GamRDNXdlVG94TXdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpWVc1ckwyTnZiblJ5WVdOMExuQjVPalVLSUNBZ0lDOHZJR05zWVhOeklFSmhibXNvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QndZWGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QndZWGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlZVzVyTDJOdmJuUnlZV04wTG5CNU9qRXpDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1pHVndiM05wZEFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlpWVhKbFgzSnZkWFJwYm1kQU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aVlXNXJMMk52Ym5SeVlXTjBMbkI1T2pVS0lDQWdJQzh2SUdOc1lYTnpJRUpoYm1zb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU9Rb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z1kzSmxZWFJwYm1jS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZbUZ1YXk1amIyNTBjbUZqZEM1Q1lXNXJMbVJsY0c5emFYUW9iV1Z0YnpvZ1lubDBaWE1zSUhCaGVWOTBlRzQ2SUhWcGJuUTJOQ2tnTFQ0Z2RXbHVkRFkwT2dwa1pYQnZjMmwwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoYm1zdlkyOXVkSEpoWTNRdWNIazZNVE10TVRRS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z1pHVm1JR1JsY0c5emFYUW9jMlZzWml3Z2JXVnRiem9nVTNSeWFXNW5MQ0J3WVhsZmRIaHVPaUJuZEhodUxsQmhlVzFsYm5SVWNtRnVjMkZqZEdsdmJpa2dMVDRnVlVsdWREWTBPZ29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1GdWF5OWpiMjUwY21GamRDNXdlVG94TmdvZ0lDQWdMeThnWVhOelpYSjBJSEJoZVY5MGVHNHVjbVZqWldsMlpYSWdQVDBnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdnSWxKbFkyVnBkbVZ5SUcxMWMzUWdZbVVnZEdobElHTnZiblJ5WVdOMElHRmtaSEpsYzNNaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2QwZUc1eklGSmxZMlZwZG1WeUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJTWldObGFYWmxjaUJ0ZFhOMElHSmxJSFJvWlNCamIyNTBjbUZqZENCaFpHUnlaWE56Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbUZ1YXk5amIyNTBjbUZqZEM1d2VUb3hOd29nSUNBZ0x5OGdZWE56WlhKMElIQmhlVjkwZUc0dVlXMXZkVzUwSUQ0Z01Dd2dJa1JsY0c5emFYUWdZVzF2ZFc1MElHMTFjM1FnWW1VZ1ozSmxZWFJsY2lCMGFHRnVJSHBsY204aUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmhjM05sY25RZ0x5OGdSR1Z3YjNOcGRDQmhiVzkxYm5RZ2JYVnpkQ0JpWlNCbmNtVmhkR1Z5SUhSb1lXNGdlbVZ5YndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoYm1zdlkyOXVkSEpoWTNRdWNIazZNVGtLSUNBZ0lDOHZJR0Z0YjNWdWRDd2daWGhwYzNSeklEMGdjMlZzWmk1a1pYQnZjMmwwY3k1dFlYbGlaU2h3WVhsZmRIaHVMbk5sYm1SbGNpa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWjNSNGJuTWdVMlZ1WkdWeUNpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdKMGIya0tJQ0FnSUhOM1lYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aVlXNXJMMk52Ym5SeVlXTjBMbkI1T2pJd0NpQWdJQ0F2THlCcFppQmxlR2x6ZEhNNkNpQWdJQ0JpZWlCa1pYQnZjMmwwWDJWc2MyVmZZbTlrZVVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1GdWF5OWpiMjUwY21GamRDNXdlVG95TVFvZ0lDQWdMeThnYzJWc1ppNWtaWEJ2YzJsMGMxdHdZWGxmZEhodUxuTmxibVJsY2wwZ1BTQmhiVzkxYm5RZ0t5QndZWGxmZEhodUxtRnRiM1Z1ZEFvZ0lDQWdabkpoYldWZlpHbG5JRElLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb0taR1Z3YjNOcGRGOWhablJsY2w5cFpsOWxiSE5sUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1GdWF5OWpiMjUwY21GamRDNXdlVG95TlFvZ0lDQWdMeThnYzJWc1ppNTBiM1JoYkY5a1pYQnZjMmwwSUNzOUlIQmhlVjkwZUc0dVlXMXZkVzUwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkRzkwWVd4ZlpHVndiM05wZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5a1pYQnZjMmwwSUdWNGFYTjBjd29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUNzS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5SdmRHRnNYMlJsY0c5emFYUWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySmhibXN2WTI5dWRISmhZM1F1Y0hrNk1qWUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbVJsY0c5emFYUnpXM0JoZVY5MGVHNHVjMlZ1WkdWeVhRb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdKMGIya0tJQ0FnSUhOM1lYQUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtUmxjRzl6YVhSeklHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ21SbGNHOXphWFJmWld4elpWOWliMlI1UURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1GdWF5OWpiMjUwY21GamRDNXdlVG95TXdvZ0lDQWdMeThnYzJWc1ppNWtaWEJ2YzJsMGMxdHdZWGxmZEhodUxuTmxibVJsY2wwZ1BTQndZWGxmZEhodUxtRnRiM1Z1ZEFvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHbDBiMklLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQmlJR1JsY0c5emFYUmZZV1owWlhKZmFXWmZaV3h6WlVBekNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbUpoYm1zdVkyOXVkSEpoWTNRdVFtRnVheTUzYVhSb1pISmhkeWhoYlc5MWJuUTZJSFZwYm5RMk5Da2dMVDRnZFdsdWREWTBPZ3AzYVhSb1pISmhkem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlZVzVyTDJOdmJuUnlZV04wTG5CNU9qSTRMVEk1Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJQzh2SUdSbFppQjNhWFJvWkhKaGR5aHpaV3htTENCaGJXOTFiblE2SUZWSmJuUTJOQ2tnTFQ0Z1ZVbHVkRFkwT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRnVheTlqYjI1MGNtRmpkQzV3ZVRvek1Rb2dJQ0FnTHk4Z1kzVnljbVZ1ZEN3Z1pYaHBjM1J6SUQwZ2MyVnNaaTVrWlhCdmMybDBjeTV0WVhsaVpTaFVlRzR1YzJWdVpHVnlLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2MzZGhjQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySmhibXN2WTI5dWRISmhZM1F1Y0hrNk16SUtJQ0FnSUM4dklHRnpjMlZ5ZENCbGVHbHpkSE1zSUNKT2J5QmtaWEJ2YzJsMGN5Qm1iM1Z1WkNCbWIzSWdkR2hwY3lCaFkyTnZkVzUwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWE56WlhKMElDOHZJRTV2SUdSbGNHOXphWFJ6SUdadmRXNWtJR1p2Y2lCMGFHbHpJR0ZqWTI5MWJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aVlXNXJMMk52Ym5SeVlXTjBMbkI1T2pNekNpQWdJQ0F2THlCaGMzTmxjblFnWVcxdmRXNTBJRDRnTUN3Z0lsZHBkR2hrY21GM1lXd2dZVzF2ZFc1MElHMTFjM1FnWW1VZ1ozSmxZWFJsY2lCMGFHRnVJSHBsY204aUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0Z6YzJWeWRDQXZMeUJYYVhSb1pISmhkMkZzSUdGdGIzVnVkQ0J0ZFhOMElHSmxJR2R5WldGMFpYSWdkR2hoYmlCNlpYSnZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRnVheTlqYjI1MGNtRmpkQzV3ZVRvek5Bb2dJQ0FnTHk4Z1lYTnpaWEowSUdGdGIzVnVkQ0E4UFNCamRYSnlaVzUwTENBaVYybDBhR1J5WVhkaGJDQmhiVzkxYm5RZ1pYaGpaV1ZrY3lCaVlXeGhibU5sSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmthV2NnTVFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlhhWFJvWkhKaGQyRnNJR0Z0YjNWdWRDQmxlR05sWldSeklHSmhiR0Z1WTJVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpWVc1ckwyTnZiblJ5WVdOMExuQjVPak0yQ2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb2NtVmpaV2wyWlhJOVZIaHVMbk5sYm1SbGNpd2dZVzF2ZFc1MFBXRnRiM1Z1ZEN3Z1ptVmxQVEFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVcxdmRXNTBDaUFnSUNCcGRIaHVYMlpwWld4a0lGSmxZMlZwZG1WeUNpQWdJQ0JwYm5Salh6QWdMeThnY0dGNUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRnVheTlqYjI1MGNtRmpkQzV3ZVRvek9Bb2dJQ0FnTHk4Z2NtVnRZV2x1YVc1bklEMGdZM1Z5Y21WdWRDQXRJR0Z0YjNWdWRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlZVzVyTDJOdmJuUnlZV04wTG5CNU9qTTVDaUFnSUNBdkx5QnBaaUJ5WlcxaGFXNXBibWNnUFQwZ1ZVbHVkRFkwS0RBcE9nb2dJQ0FnWW01NklIZHBkR2hrY21GM1gyVnNjMlZmWW05a2VVQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRnVheTlqYjI1MGNtRmpkQzV3ZVRvME1Bb2dJQ0FnTHk4Z1pHVnNJSE5sYkdZdVpHVndiM05wZEhOYlZIaHVMbk5sYm1SbGNsMEtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb0tkMmwwYUdSeVlYZGZZV1owWlhKZmFXWmZaV3h6WlVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKaGJtc3ZZMjl1ZEhKaFkzUXVjSGs2TkRRS0lDQWdJQzh2SUhKbGRIVnliaUJ5WlcxaGFXNXBibWNLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCemQyRndDaUFnSUNCeVpYUnpkV0lLQ25kcGRHaGtjbUYzWDJWc2MyVmZZbTlrZVVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKaGJtc3ZZMjl1ZEhKaFkzUXVjSGs2TkRJS0lDQWdJQzh2SUhObGJHWXVaR1Z3YjNOcGRITmJWSGh1TG5ObGJtUmxjbDBnUFNCeVpXMWhhVzVwYm1jS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCcGRHOWlDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQmlJSGRwZEdoa2NtRjNYMkZtZEdWeVgybG1YMlZzYzJWQU5Bbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQ0FRQW1BZzEwYjNSaGJGOWtaWEJ2YzJsMEJCVWZmSFV4R0VBQUF5Z2paekViUVFCTmdnSUVuMWw4TWdReElVRjJOaG9BamdJQUZ3QUNJME14R1JSRU1SaEVOaG9CRjRnQWVCWXBURkN3SWtNeEdSUkVNUmhFTmhvQlZ3SUFNUllpQ1VrNEVDSVNSSWdBRWhZcFRGQ3dJa014R1VEL3d6RVlGRVFpUTRvQ0FZdi9PQWN5Q2hKRWkvODRDRWxFaS84NEFFbStUQmRNUVFBZWl3S0xBQWdXaXdGTXZ5TW9aVVNMQUFnb1RHZUxBYjVNRjB4RWpBQ0ppd0FXaXdGTXYwTC80b29CQVRFQXZrd1hURVNMLzBTTC8wc0JEa1N4TVFDTC83SUlzZ2Npc2hBanNnR3ppLzhKU1VBQUNERUF2RWlMQUV5Sk1RQ0xBQmEvUXYveiIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjcsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
