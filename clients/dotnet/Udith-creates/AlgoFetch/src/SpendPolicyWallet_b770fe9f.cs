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

namespace Arc56.Generated.Udith_creates.AlgoFetch.SpendPolicyWallet_b770fe9f
{


    public class SpendPolicyWalletProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SpendPolicyWalletProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Initialize the smart wallet and set the spend policy hard cap.
        ///</summary>
        /// <param name="hard_cap"> </param>
        public async Task Create(ulong hard_cap, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 13, 47, 103 };
            var hard_capAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hard_capAbi.From(hard_cap);

            var result = await base.CallApp(new List<object> { abiHandle, hard_capAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(ulong hard_cap, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 13, 47, 103 };
            var hard_capAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hard_capAbi.From(hard_cap);

            return await base.MakeTransactionList(new List<object> { abiHandle, hard_capAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Execute a payment subject to ARC-58 spend policies.
        ///</summary>
        /// <param name="recipient"> </param>
        /// <param name="amount"> </param>
        /// <param name="note"> </param>
        public async Task ExecutePayment(Algorand.Address recipient, ulong amount, byte[] note, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 201, 10, 80 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var noteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); noteAbi.From(note);

            var result = await base.CallApp(new List<object> { abiHandle, recipientAbi, amountAbi, noteAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ExecutePayment_Transactions(Algorand.Address recipient, ulong amount, byte[] note, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 201, 10, 80 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var noteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); noteAbi.From(note);

            return await base.MakeTransactionList(new List<object> { abiHandle, recipientAbi, amountAbi, noteAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Reset the spend limit (manual trigger for this demo).
        ///</summary>
        public async Task ResetSpend(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 103, 49, 253, 149 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ResetSpend_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 103, 49, 253, 149 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3BlbmRQb2xpY3lXYWxsZXQiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6IkluaXRpYWxpemUgdGhlIHNtYXJ0IHdhbGxldCBhbmQgc2V0IHRoZSBzcGVuZCBwb2xpY3kgaGFyZCBjYXAuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImhhcmRfY2FwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImV4ZWN1dGVfcGF5bWVudCIsImRlc2MiOiJFeGVjdXRlIGEgcGF5bWVudCBzdWJqZWN0IHRvIEFSQy01OCBzcGVuZCBwb2xpY2llcy4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2lwaWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub3RlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlc2V0X3NwZW5kIiwiZGVzYyI6IlJlc2V0IHRoZSBzcGVuZCBsaW1pdCAobWFudWFsIHRyaWdnZXIgZm9yIHRoaXMgZGVtbykuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjozLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTcxXSwiZXJyb3JNZXNzYWdlIjoiQVZNIExvZ2ljIEVycm9yOiBIYXJkIGNhcCBleGNlZWRlZCBmb3IgdGhlIGRheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2NF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgb3duZXIgY2FuIHJlc2V0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU2XSwiZXJyb3JNZXNzYWdlIjoiT25seSBvd25lciBjYW4gc3BlbmQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmRhaWx5X3NwZW50IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2N10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuaGFyZF9jYXAgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU0LDIxMiwzNjJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm93bmVyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3OF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfcHVyY2hhc2VzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzN10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTcsMTMwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdPQW9nSUNBZ1lubDBaV05pYkc5amF5QWliM2R1WlhJaUlDSnpjR1Z1ZENJZ0luUnZkR0ZzWDNCMWNtTm9ZWE5sY3lJZ0ltaGhjbVJmWTJGd0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd1pXNWtYM0J2YkdsamVTOWpiMjUwY21GamRDNXdlVG96Q2lBZ0lDQXZMeUJqYkdGemN5QlRjR1Z1WkZCdmJHbGplVmRoYkd4bGRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lub2diV0ZwYmw5amNtVmhkR1ZmVG05UGNFQTRDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRObVZqT1RCaE5UQWdNSGcyTnpNeFptUTVOU0F2THlCdFpYUm9iMlFnSW1WNFpXTjFkR1ZmY0dGNWJXVnVkQ2hoWkdSeVpYTnpMSFZwYm5RMk5DeGllWFJsVzEwcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpY21WelpYUmZjM0JsYm1Rb0tYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCbGVHVmpkWFJsWDNCaGVXMWxiblFnY21WelpYUmZjM0JsYm1RS0lDQWdJR1Z5Y2dvS2JXRnBibDlqY21WaGRHVmZUbTlQY0VBNE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd1pXNWtYM0J2YkdsamVTOWpiMjUwY21GamRDNXdlVG96Q2lBZ0lDQXZMeUJqYkdGemN5QlRjR1Z1WkZCdmJHbGplVmRoYkd4bGRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TWpRd1pESm1OamNnTHk4Z2JXVjBhRzlrSUNKamNtVmhkR1VvZFdsdWREWTBLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmpjbVZoZEdVS0lDQWdJR1Z5Y2dvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXpjR1Z1WkY5d2IyeHBZM2t1WTI5dWRISmhZM1F1VTNCbGJtUlFiMnhwWTNsWFlXeHNaWFF1WTNKbFlYUmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTNKbFlYUmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndaVzVrWDNCdmJHbGplUzlqYjI1MGNtRmpkQzV3ZVRveE1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0dOeVpXRjBaVDBpY21WeGRXbHlaU0lwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCbGJtUmZjRzlzYVdONUwyTnZiblJ5WVdOMExuQjVPakV6Q2lBZ0lDQXZMeUJ6Wld4bUxtOTNibVZ5TG5aaGJIVmxJRDBnVkhodUxuTmxibVJsY2dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYjNkdVpYSWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd1pXNWtYM0J2YkdsamVTOWpiMjUwY21GamRDNXdlVG94TkFvZ0lDQWdMeThnYzJWc1ppNW9ZWEprWDJOaGNDNTJZV3gxWlNBOUlHaGhjbVJmWTJGd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKb1lYSmtYMk5oY0NJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCbGJtUmZjRzlzYVdONUwyTnZiblJ5WVdOMExuQjVPakUxQ2lBZ0lDQXZMeUJ6Wld4bUxtUmhhV3g1WDNOd1pXNTBMblpoYkhWbElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnpjR1Z1ZENJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053Wlc1a1gzQnZiR2xqZVM5amIyNTBjbUZqZEM1d2VUb3hOZ29nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjl3ZFhKamFHRnpaWE11ZG1Gc2RXVWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJblJ2ZEdGc1gzQjFjbU5vWVhObGN5SUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd1pXNWtYM0J2YkdsamVTOWpiMjUwY21GamRDNXdlVG94TUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLR055WldGMFpUMGljbVZ4ZFdseVpTSXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5Od1pXNWtYM0J2YkdsamVTNWpiMjUwY21GamRDNVRjR1Z1WkZCdmJHbGplVmRoYkd4bGRDNWxlR1ZqZFhSbFgzQmhlVzFsYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGxlR1ZqZFhSbFgzQmhlVzFsYm5RNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCbGJtUmZjRzlzYVdONUwyTnZiblJ5WVdOMExuQjVPakU0Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndaVzVrWDNCdmJHbGplUzlqYjI1MGNtRmpkQzV3ZVRveU1Rb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdjMlZzWmk1dmQyNWxjaTUyWVd4MVpTd2dJazl1YkhrZ2IzZHVaWElnWTJGdUlITndaVzVrSWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltOTNibVZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtOTNibVZ5SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJRzkzYm1WeUlHTmhiaUJ6Y0dWdVpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd1pXNWtYM0J2YkdsamVTOWpiMjUwY21GamRDNXdlVG95TWdvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdVpHRnBiSGxmYzNCbGJuUXVkbUZzZFdVZ0t5QmhiVzkxYm5RZ1BEMGdjMlZzWmk1b1lYSmtYMk5oY0M1MllXeDFaU3dnSWtGV1RTQk1iMmRwWXlCRmNuSnZjam9nU0dGeVpDQmpZWEFnWlhoalpXVmtaV1FnWm05eUlIUm9aU0JrWVhraUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYzNCbGJuUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WkdGcGJIbGZjM0JsYm5RZ1pYaHBjM1J6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdLd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltaGhjbVJmWTJGd0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbWhoY21SZlkyRndJR1Y0YVhOMGN3b2dJQ0FnWkdsbklERUtJQ0FnSUQ0OUNpQWdJQ0JoYzNObGNuUWdMeThnUVZaTklFeHZaMmxqSUVWeWNtOXlPaUJJWVhKa0lHTmhjQ0JsZUdObFpXUmxaQ0JtYjNJZ2RHaGxJR1JoZVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053Wlc1a1gzQnZiR2xqZVM5amIyNTBjbUZqZEM1d2VUb3lOQzB5TlFvZ0lDQWdMeThnSXlCRmJtWnZjbU5sSUc5dUxXTm9ZV2x1SUhCdmJHbGplU0JqYUdWamF3b2dJQ0FnTHk4Z2MyVnNaaTVrWVdsc2VWOXpjR1Z1ZEM1MllXeDFaU0FyUFNCaGJXOTFiblFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbk53Wlc1MElnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emNHVnVaRjl3YjJ4cFkza3ZZMjl1ZEhKaFkzUXVjSGs2TWpZS0lDQWdJQzh2SUhObGJHWXVkRzkwWVd4ZmNIVnlZMmhoYzJWekxuWmhiSFZsSUNzOUlERUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKMGIzUmhiRjl3ZFhKamFHRnpaWE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOTBZV3hmY0hWeVkyaGhjMlZ6SUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5SdmRHRnNYM0IxY21Ob1lYTmxjeUlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053Wlc1a1gzQnZiR2xqZVM5amIyNTBjbUZqZEM1d2VUb3lPQzB6TXdvZ0lDQWdMeThnSXlCQlVrTXROVGdnYzNSNWJHVWdhVzV1WlhJZ2RISmhibk5oWTNScGIyNEtJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2oxeVpXTnBjR2xsYm5Rc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBXRnRiM1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQnViM1JsUFc1dmRHVUtJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJSE4zWVhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVG05MFpRb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmJXOTFiblFLSUNBZ0lITjNZWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZqWldsMlpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emNHVnVaRjl3YjJ4cFkza3ZZMjl1ZEhKaFkzUXVjSGs2TWpndE1qa0tJQ0FnSUM4dklDTWdRVkpETFRVNElITjBlV3hsSUdsdWJtVnlJSFJ5WVc1ellXTjBhVzl1Q2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0JwYm5Salh6RWdMeThnY0dGNUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR1Z1WkY5d2IyeHBZM2t2WTI5dWRISmhZM1F1Y0hrNk1qZ3RNek1LSUNBZ0lDOHZJQ01nUVZKRExUVTRJSE4wZVd4bElHbHVibVZ5SUhSeVlXNXpZV04wYVc5dUNpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk5Y21WamFYQnBaVzUwTEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQxaGJXOTFiblFzQ2lBZ0lDQXZMeUFnSUNBZ2JtOTBaVDF1YjNSbENpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053Wlc1a1gzQnZiR2xqZVM5amIyNTBjbUZqZEM1d2VUb3pOUzB6TmdvZ0lDQWdMeThnSXlCTmFXeGxjM1J2Ym1VZ1RHVjJaV3d0VlhBNklFMXBiblFnWVNCeVpXRnNJRTVHVkNCdmJpQjBhR1VnTlhSb0lITjFZMk5sYzNObWRXd2djSFZ5WTJoaGMyVWdLR0Z1WkNCaVpYbHZibVFnYVdZZ2JtOTBJSGxsZENCdGFXNTBaV1FwQ2lBZ0lDQXZMeUJwWmlCelpXeG1MblJ2ZEdGc1gzQjFjbU5vWVhObGN5NTJZV3gxWlNBK1BTQTFPZ29nSUNBZ2NIVnphR2x1ZENBMUNpQWdJQ0ErUFFvZ0lDQWdZbm9nWlhobFkzVjBaVjl3WVhsdFpXNTBYMkZtZEdWeVgybG1YMlZzYzJWQU5Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd1pXNWtYM0J2YkdsamVTOWpiMjUwY21GamRDNXdlVG96TnkwMU1Bb2dJQ0FnTHk4Z0l5QlhaU0IwY21sbloyVnlJSFJvWlNCamIyNW1hV2QxY21GMGFXOXVJSFJ5WVc1ellXTjBhVzl1Q2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwUTI5dVptbG5LQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMjVoYldVOUlrRnNaMjlHWlhSamFDQkZiR2wwWlNCTVpYWmxiQ0F5SWl3S0lDQWdJQzh2SUNBZ0lDQjFibWwwWDI1aGJXVTlJa0ZHUlV3eUlpd0tJQ0FnSUM4dklDQWdJQ0IwYjNSaGJEMHhMQW9nSUNBZ0x5OGdJQ0FnSUdSbFkybHRZV3h6UFRBc0NpQWdJQ0F2THlBZ0lDQWdiV0Z1WVdkbGNqMXpaV3htTG05M2JtVnlMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQWdJSEpsYzJWeWRtVTljMlZzWmk1dmQyNWxjaTUyWVd4MVpTd0tJQ0FnSUM4dklDQWdJQ0JtY21WbGVtVTljMlZzWmk1dmQyNWxjaTUyWVd4MVpTd0tJQ0FnSUM4dklDQWdJQ0JqYkdGM1ltRmphejF6Wld4bUxtOTNibVZ5TG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0FnSUhWeWJEMGlhSFIwY0RvdkwyeHZZMkZzYUc5emREbzROVEF4TDNKbGQyRnlaSE12YkdWMlpXd3lMbXB6YjI0aUxBb2dJQ0FnTHk4Z0lDQWdJRzFsZEdGa1lYUmhYMmhoYzJnOVFubDBaWE1vWWlJd0lpQXFJRE15S1N3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5TUNBaklGQnZiMnhsWkNCbWNtOXRJSEJoY21WdWRDQjBjbUZ1YzJGamRHbHZiZ29nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOd1pXNWtYM0J2YkdsamVTOWpiMjUwY21GamRDNXdlVG8wTXdvZ0lDQWdMeThnYldGdVlXZGxjajF6Wld4bUxtOTNibVZ5TG5aaGJIVmxMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltOTNibVZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtOTNibVZ5SUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndaVzVrWDNCdmJHbGplUzlqYjI1MGNtRmpkQzV3ZVRvME9Bb2dJQ0FnTHk4Z2JXVjBZV1JoZEdGZmFHRnphRDFDZVhSbGN5aGlJakFpSUNvZ016SXBMQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNekF6TURNd016QXpNRE13TXpBek1ETXdNekF6TURNd016QXpNRE13TXpBek1ETXdNekF6TURNd016QXpNRE13TXpBek1ETXdNekF6TURNd016QXpNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRTFsZEdGa1lYUmhTR0Z6YUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM053Wlc1a1gzQnZiR2xqZVM5amIyNTBjbUZqZEM1d2VUbzBOd29nSUNBZ0x5OGdkWEpzUFNKb2RIUndPaTh2Ykc5allXeG9iM04wT2pnMU1ERXZjbVYzWVhKa2N5OXNaWFpsYkRJdWFuTnZiaUlzQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbWgwZEhBNkx5OXNiMk5oYkdodmMzUTZPRFV3TVM5eVpYZGhjbVJ6TDJ4bGRtVnNNaTVxYzI5dUlnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRGVlNUQW9nSUNBZ1pIVndDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBRMnhoZDJKaFkyc0tJQ0FnSUdSMWNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRFWnlaV1Y2WlFvZ0lDQWdaSFZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwVW1WelpYSjJaUW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRTFoYm1GblpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emNHVnVaRjl3YjJ4cFkza3ZZMjl1ZEhKaFkzUXVjSGs2TkRJS0lDQWdJQzh2SUdSbFkybHRZV3h6UFRBc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEVSbFkybHRZV3h6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JsYm1SZmNHOXNhV041TDJOdmJuUnlZV04wTG5CNU9qUXhDaUFnSUNBdkx5QjBiM1JoYkQweExBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSVWIzUmhiQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTndaVzVrWDNCdmJHbGplUzlqYjI1MGNtRmpkQzV3ZVRvME1Bb2dJQ0FnTHk4Z2RXNXBkRjl1WVcxbFBTSkJSa1ZNTWlJc0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWtGR1JVd3lJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRlZ1YVhST1lXMWxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzQmxibVJmY0c5c2FXTjVMMk52Ym5SeVlXTjBMbkI1T2pNNUNpQWdJQ0F2THlCaGMzTmxkRjl1WVcxbFBTSkJiR2R2Um1WMFkyZ2dSV3hwZEdVZ1RHVjJaV3dnTWlJc0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWtGc1oyOUdaWFJqYUNCRmJHbDBaU0JNWlhabGJDQXlJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRTVoYldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0dWdVpGOXdiMnhwWTNrdlkyOXVkSEpoWTNRdWNIazZNemN0TXpnS0lDQWdJQzh2SUNNZ1YyVWdkSEpwWjJkbGNpQjBhR1VnWTI5dVptbG5kWEpoZEdsdmJpQjBjbUZ1YzJGamRHbHZiZ29nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRU52Ym1acFp5Z0tJQ0FnSUhCMWMyaHBiblFnTXlBdkx5QmhZMlpuQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzQmxibVJmY0c5c2FXTjVMMk52Ym5SeVlXTjBMbkI1T2pRNUNpQWdJQ0F2THlCbVpXVTlNQ0FqSUZCdmIyeGxaQ0JtY205dElIQmhjbVZ1ZENCMGNtRnVjMkZqZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNCbGJtUmZjRzlzYVdONUwyTnZiblJ5WVdOMExuQjVPak0zTFRVd0NpQWdJQ0F2THlBaklGZGxJSFJ5YVdkblpYSWdkR2hsSUdOdmJtWnBaM1Z5WVhScGIyNGdkSEpoYm5OaFkzUnBiMjRLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJEYjI1bWFXY29DaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZibUZ0WlQwaVFXeG5iMFpsZEdOb0lFVnNhWFJsSUV4bGRtVnNJRElpTEFvZ0lDQWdMeThnSUNBZ0lIVnVhWFJmYm1GdFpUMGlRVVpGVERJaUxBb2dJQ0FnTHk4Z0lDQWdJSFJ2ZEdGc1BURXNDaUFnSUNBdkx5QWdJQ0FnWkdWamFXMWhiSE05TUN3S0lDQWdJQzh2SUNBZ0lDQnRZVzVoWjJWeVBYTmxiR1l1YjNkdVpYSXVkbUZzZFdVc0NpQWdJQ0F2THlBZ0lDQWdjbVZ6WlhKMlpUMXpaV3htTG05M2JtVnlMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQWdJR1p5WldWNlpUMXpaV3htTG05M2JtVnlMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQWdJR05zWVhkaVlXTnJQWE5sYkdZdWIzZHVaWEl1ZG1Gc2RXVXNDaUFnSUNBdkx5QWdJQ0FnZFhKc1BTSm9kSFJ3T2k4dmJHOWpZV3hvYjNOME9qZzFNREV2Y21WM1lYSmtjeTlzWlhabGJESXVhbk52YmlJc0NpQWdJQ0F2THlBZ0lDQWdiV1YwWVdSaGRHRmZhR0Z6YUQxQ2VYUmxjeWhpSWpBaUlDb2dNeklwTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDB3SUNNZ1VHOXZiR1ZrSUdaeWIyMGdjR0Z5Wlc1MElIUnlZVzV6WVdOMGFXOXVDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb0taWGhsWTNWMFpWOXdZWGx0Wlc1MFgyRm1kR1Z5WDJsbVgyVnNjMlZBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0dWdVpGOXdiMnhwWTNrdlkyOXVkSEpoWTNRdWNIazZNVGdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV6Y0dWdVpGOXdiMnhwWTNrdVkyOXVkSEpoWTNRdVUzQmxibVJRYjJ4cFkzbFhZV3hzWlhRdWNtVnpaWFJmYzNCbGJtUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WlhObGRGOXpjR1Z1WkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Y0dWdVpGOXdiMnhwWTNrdlkyOXVkSEpoWTNRdWNIazZOVFVLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUhObGJHWXViM2R1WlhJdWRtRnNkV1VzSUNKUGJteDVJRzkzYm1WeUlHTmhiaUJ5WlhObGRDSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p2ZDI1bGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV2ZDI1bGNpQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCdmQyNWxjaUJqWVc0Z2NtVnpaWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpjR1Z1WkY5d2IyeHBZM2t2WTI5dWRISmhZM1F1Y0hrNk5UWUtJQ0FnSUM4dklITmxiR1l1WkdGcGJIbGZjM0JsYm5RdWRtRnNkV1VnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5Od1pXNTBJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzQmxibVJmY0c5c2FXTjVMMk52Ym5SeVlXTjBMbkI1T2pVM0NpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gzQjFjbU5vWVhObGN5NTJZV3gxWlNBOUlGVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWRHOTBZV3hmY0hWeVkyaGhjMlZ6SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM0JsYm1SZmNHOXNhV041TDJOdmJuUnlZV04wTG5CNU9qVXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QURBQUVJSmdRRmIzZHVaWElGYzNCbGJuUVBkRzkwWVd4ZmNIVnlZMmhoYzJWekNHaGhjbVJmWTJGd01Sa1VSREVZUVFBV2dnSUVic2tLVUFSbk1mMlZOaG9BamdJQUp3RWFBSUFFSkEwdlp6WWFBSTRCQUFFQU5ob0JTUlVrRWtRWEtERUFaeXRNWnlraVp5b2laeU5ETmhvQlNSV0JJQkpFTmhvQ1NSVWtFa1FYTmhvRFNTSlpnUUlJU3dFVkVrUlhBZ0F4QUNJb1pVUVNSQ0lwWlVSTEFnZ2lLMlZFU3dFUFJDbE1aeUlxWlVRakNDcExBV2V4VExJRlRMSUlUTElISTdJUUlySUJzNEVGRDBFQWs3RWlLR1ZFZ0NBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNTElvZ0Nsb2RIUndPaTh2Ykc5allXeG9iM04wT2pnMU1ERXZjbVYzWVhKa2N5OXNaWFpsYkRJdWFuTnZickluU2JJc1NiSXJTYklxc2lraXNpTWpzaUtBQlVGR1JVd3lzaVdBRjBGc1oyOUdaWFJqYUNCRmJHbDBaU0JNWlhabGJDQXlzaWFCQTdJUUlySUJzeU5ETVFBaUtHVkVFa1FwSW1jcUltY2pRdz09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
