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

namespace Arc56.Generated.SparshMishra09.ai_oracle.AIOracle_3e7da83b
{


    public class AIOracleProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AIOracleProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///A user posts a question and locks a bounty.
        ///</summary>
        /// <param name="question"> </param>
        /// <param name="payment"> </param>
        public async Task RequestData(PaymentTransaction payment, string question, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 164, 32, 253, 120 };
            var questionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); questionAbi.From(question);

            var result = await base.CallApp(new List<object> { abiHandle, questionAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RequestData_Transactions(PaymentTransaction payment, string question, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 164, 32, 253, 120 };
            var questionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); questionAbi.From(question);

            return await base.MakeTransactionList(new List<object> { abiHandle, questionAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///An AI agent provides an answer to the current question.
        ///</summary>
        /// <param name="answer"> </param>
        public async Task SubmitAnswer(string answer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 75, 95, 251 };
            var answerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); answerAbi.From(answer);

            var result = await base.CallApp(new List<object> { abiHandle, answerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SubmitAnswer_Transactions(string answer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 75, 95, 251 };
            var answerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); answerAbi.From(answer);

            return await base.MakeTransactionList(new List<object> { abiHandle, answerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///The requester approves the answer and pays the AI agent.
        ///</summary>
        public async Task ApproveAndPay(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 94, 110, 101 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ApproveAndPay_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 94, 110, 101 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQUlPcmFjbGUiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoicmVxdWVzdF9kYXRhIiwiZGVzYyI6IkEgdXNlciBwb3N0cyBhIHF1ZXN0aW9uIGFuZCBsb2NrcyBhIGJvdW50eS4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicXVlc3Rpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3VibWl0X2Fuc3dlciIsImRlc2MiOiJBbiBBSSBhZ2VudCBwcm92aWRlcyBhbiBhbnN3ZXIgdG8gdGhlIGN1cnJlbnQgcXVlc3Rpb24uIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFuc3dlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcHByb3ZlX2FuZF9wYXkiLCJkZXNjIjoiVGhlIHJlcXVlc3RlciBhcHByb3ZlcyB0aGUgYW5zd2VyIGFuZCBwYXlzIHRoZSBBSSBhZ2VudC4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjIsImJ5dGVzIjo0fSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxNzhdLCJlcnJvck1lc3NhZ2UiOiJCb3VudHkgbXVzdCBiZSBncmVhdGVyIHRoYW4gMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2Nl0sImVycm9yTWVzc2FnZSI6IkNvbnRyYWN0IGlzIG5vdCBJZGxlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQxXSwiZXJyb3JNZXNzYWdlIjoiQ29udHJhY3QgaXMgbm90IGluIEFuc3dlcmVkIHN0YXRlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjIwXSwiZXJyb3JNZXNzYWdlIjoiQ29udHJhY3QgaXMgbm90IGluIFJlcXVlc3RlZCBzdGF0ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0OV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgdGhlIHJlcXVlc3RlciBjYW4gYXBwcm92ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3M10sImVycm9yTWVzc2FnZSI6IlBheW1lbnQgbXVzdCBiZSBzZW50IHRvIGNvbnRyYWN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjU5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5ib3VudHkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjU1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5wcm92aWRlciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnJlcXVlc3RlciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjQsMjE3LDIzOF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuc3RhdHVzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0MCwyMDNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDcsMjEwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2MF0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdNZ29nSUNBZ1lubDBaV05pYkc5amF5QWljM1JoZEhWeklpQWlJaUFpWW05MWJuUjVJaUFpY21WeGRXVnpkR1Z5SWlBaWNISnZkbWxrWlhJaUlDSnhkV1Z6ZEdsdmJpSWdJbUZ1YzNkbGNpSUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYVY5dmNtRmpiR1V2WTI5dWRISmhZM1F1Y0hrNk5nb2dJQ0FnTHk4Z2MyVnNaaTV5WlhGMVpYTjBaWElnUFNCSGJHOWlZV3hUZEdGMFpTaEJZMk52ZFc1MEtDa3NJR1JsYzJOeWFYQjBhVzl1UFNKQlpHUnlaWE56SUc5bUlIUm9aU0IxYzJWeUlHRnphMmx1WnlCMGFHVWdjWFZsYzNScGIyNGlLUW9nSUNBZ1lubDBaV05mTXlBdkx5QWljbVZ4ZFdWemRHVnlJZ29nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGcFgyOXlZV05zWlM5amIyNTBjbUZqZEM1d2VUbzNDaUFnSUNBdkx5QnpaV3htTG5CeWIzWnBaR1Z5SUQwZ1IyeHZZbUZzVTNSaGRHVW9RV05qYjNWdWRDZ3BMQ0JrWlhOamNtbHdkR2x2YmowaVFXUmtjbVZ6Y3lCdlppQjBhR1VnUVVrZ1lXZGxiblFnY0hKdmRtbGthVzVuSUhSb1pTQmhibk4zWlhJaUtRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWNISnZkbWxrWlhJaUNpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2xmYjNKaFkyeGxMMk52Ym5SeVlXTjBMbkI1T2pnS0lDQWdJQzh2SUhObGJHWXVjWFZsYzNScGIyNGdQU0JIYkc5aVlXeFRkR0YwWlNoVGRISnBibWNvS1N3Z1pHVnpZM0pwY0hScGIyNDlJbFJvWlNCa1lYUmhJR0psYVc1bklISmxjWFZsYzNSbFpDSXBDaUFnSUNCaWVYUmxZeUExSUM4dklDSnhkV1Z6ZEdsdmJpSUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0lpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXbGZiM0poWTJ4bEwyTnZiblJ5WVdOMExuQjVPamtLSUNBZ0lDOHZJSE5sYkdZdVlXNXpkMlZ5SUQwZ1IyeHZZbUZzVTNSaGRHVW9VM1J5YVc1bktDa3NJR1JsYzJOeWFYQjBhVzl1UFNKVWFHVWdaR0YwWVNCd2NtOTJhV1JsWkNCaWVTQjBhR1VnUVVraUtRb2dJQ0FnWW5sMFpXTWdOaUF2THlBaVlXNXpkMlZ5SWdvZ0lDQWdZbmwwWldOZk1TQXZMeUFpSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYVY5dmNtRmpiR1V2WTI5dWRISmhZM1F1Y0hrNk1UQUtJQ0FnSUM4dklITmxiR1l1WW05MWJuUjVJRDBnUjJ4dlltRnNVM1JoZEdVb1ZVbHVkRFkwS0RBcExDQmtaWE5qY21sd2RHbHZiajBpVkdobElHRnRiM1Z1ZENCdlppQkJURWRQSUd4dlkydGxaQ0JwYmlCbGMyTnliM2NpS1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWW05MWJuUjVJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXbGZiM0poWTJ4bEwyTnZiblJ5WVdOMExuQjVPakV4Q2lBZ0lDQXZMeUJ6Wld4bUxuTjBZWFIxY3lBOUlFZHNiMkpoYkZOMFlYUmxLRlZKYm5RMk5DZ3dLU3dnWkdWelkzSnBjSFJwYjI0OUlqQTZJRWxrYkdVc0lERTZJRkpsY1hWbGMzUmxaQ3dnTWpvZ1FXNXpkMlZ5WldRaUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWMzUmhkSFZ6SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGFWOXZjbUZqYkdVdlkyOXVkSEpoWTNRdWNIazZOQW9nSUNBZ0x5OGdZMnhoYzNNZ1FVbFBjbUZqYkdVb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURFeUNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhoaE5ESXdabVEzT0NBd2VHSTFOR0kxWm1aaUlEQjRaRGsxWlRabE5qVWdMeThnYldWMGFHOWtJQ0p5WlhGMVpYTjBYMlJoZEdFb2MzUnlhVzVuTEhCaGVTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKemRXSnRhWFJmWVc1emQyVnlLSE4wY21sdVp5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKaGNIQnliM1psWDJGdVpGOXdZWGtvS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J5WlhGMVpYTjBYMlJoZEdFZ2MzVmliV2wwWDJGdWMzZGxjaUJoY0hCeWIzWmxYMkZ1WkY5d1lYa0tJQ0FnSUdWeWNnb0tiV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF4TWpvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbUZwWDI5eVlXTnNaUzVqYjI1MGNtRmpkQzVCU1U5eVlXTnNaUzV5WlhGMVpYTjBYMlJoZEdGYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHlaWEYxWlhOMFgyUmhkR0U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2xmYjNKaFkyeGxMMk52Ym5SeVlXTjBMbkI1T2pFekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eElDOHZJSEJoZVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBjbUZ1YzJGamRHbHZiaUIwZVhCbElHbHpJSEJoZVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZwWDI5eVlXTnNaUzlqYjI1MGNtRmpkQzV3ZVRveE9DMHhPUW9nSUNBZ0x5OGdJeUF4TGlCVFpXTjFjbWwwZVNCRGFHVmphem9nUTI5dWRISmhZM1FnYlhWemRDQmlaU0JKWkd4bENpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNXpkR0YwZFhNdWRtRnNkV1VnUFQwZ1ZVbHVkRFkwS0RBcExDQWlRMjl1ZEhKaFkzUWdhWE1nYm05MElFbGtiR1VpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWljM1JoZEhWeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1Mbk4wWVhSMWN5QmxlR2x6ZEhNS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkRiMjUwY21GamRDQnBjeUJ1YjNRZ1NXUnNaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnBYMjl5WVdOc1pTOWpiMjUwY21GamRDNXdlVG95TVMweU1nb2dJQ0FnTHk4Z0l5QXlMaUJXWlhKcFpua2dVR0Y1YldWdWREb2dVR0Y1YldWdWRDQnRkWE4wSUdKbElITmxiblFnZEc4Z2RHaGxJR052Ym5SeVlXTjBJR0ZrWkhKbGMzTUtJQ0FnSUM4dklHRnpjMlZ5ZENCd1lYbHRaVzUwTG5KbFkyVnBkbVZ5SUQwOUlFZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0lDSlFZWGx0Wlc1MElHMTFjM1FnWW1VZ2MyVnVkQ0IwYnlCamIyNTBjbUZqZENJS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1VtVmpaV2wyWlhJS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRkJoZVcxbGJuUWdiWFZ6ZENCaVpTQnpaVzUwSUhSdklHTnZiblJ5WVdOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdsZmIzSmhZMnhsTDJOdmJuUnlZV04wTG5CNU9qSXpDaUFnSUNBdkx5QmhjM05sY25RZ2NHRjViV1Z1ZEM1aGJXOTFiblFnUGlCVlNXNTBOalFvTUNrc0lDSkNiM1Z1ZEhrZ2JYVnpkQ0JpWlNCbmNtVmhkR1Z5SUhSb1lXNGdNQ0lLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDaUFnSUNCa2RYQUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzVnVkSGtnYlhWemRDQmlaU0JuY21WaGRHVnlJSFJvWVc0Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGcFgyOXlZV05zWlM5amIyNTBjbUZqZEM1d2VUb3lOUzB5TmdvZ0lDQWdMeThnSXlBekxpQlRkRzl5WlNCU1pYRjFaWE4wQ2lBZ0lDQXZMeUJ6Wld4bUxuSmxjWFZsYzNSbGNpNTJZV3gxWlNBOUlIQmhlVzFsYm5RdWMyVnVaR1Z5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQm5kSGh1Y3lCVFpXNWtaWElLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbkpsY1hWbGMzUmxjaUlLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2xmYjNKaFkyeGxMMk52Ym5SeVlXTjBMbkI1T2pJM0NpQWdJQ0F2THlCelpXeG1MbkYxWlhOMGFXOXVMblpoYkhWbElEMGdjWFZsYzNScGIyNEtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0luRjFaWE4wYVc5dUlnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZwWDI5eVlXTnNaUzlqYjI1MGNtRmpkQzV3ZVRveU9Bb2dJQ0FnTHk4Z2MyVnNaaTVpYjNWdWRIa3VkbUZzZFdVZ1BTQndZWGx0Wlc1MExtRnRiM1Z1ZEFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWW05MWJuUjVJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhhVjl2Y21GamJHVXZZMjl1ZEhKaFkzUXVjSGs2TWprS0lDQWdJQzh2SUhObGJHWXVjM1JoZEhWekxuWmhiSFZsSUQwZ1ZVbHVkRFkwS0RFcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKemRHRjBkWE1pQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhhVjl2Y21GamJHVXZZMjl1ZEhKaFkzUXVjSGs2TVRNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtRnBYMjl5WVdOc1pTNWpiMjUwY21GamRDNUJTVTl5WVdOc1pTNXpkV0p0YVhSZllXNXpkMlZ5VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MzVmliV2wwWDJGdWMzZGxjam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhhVjl2Y21GamJHVXZZMjl1ZEhKaFkzUXVjSGs2TXpFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGcFgyOXlZV05zWlM5amIyNTBjbUZqZEM1d2VUb3pOaTB6TndvZ0lDQWdMeThnSXlBeExpQlRaV04xY21sMGVTQkRhR1ZqYXpvZ1EyOXVkSEpoWTNRZ2JYVnpkQ0JpWlNCcGJpQlNaWEYxWlhOMFpXUWdjM1JoZEdVS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxuTjBZWFIxY3k1MllXeDFaU0E5UFNCVlNXNTBOalFvTVNrc0lDSkRiMjUwY21GamRDQnBjeUJ1YjNRZ2FXNGdVbVZ4ZFdWemRHVmtJSE4wWVhSbElnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5OMFlYUjFjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1emRHRjBkWE1nWlhocGMzUnpDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJEYjI1MGNtRmpkQ0JwY3lCdWIzUWdhVzRnVW1WeGRXVnpkR1ZrSUhOMFlYUmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXbGZiM0poWTJ4bEwyTnZiblJ5WVdOMExuQjVPak01TFRRd0NpQWdJQ0F2THlBaklESXVJRk4wYjNKbElFRnVjM2RsY2dvZ0lDQWdMeThnYzJWc1ppNXdjbTkyYVdSbGNpNTJZV3gxWlNBOUlGUjRiaTV6Wlc1a1pYSUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0luQnliM1pwWkdWeUlnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYVY5dmNtRmpiR1V2WTI5dWRISmhZM1F1Y0hrNk5ERUtJQ0FnSUM4dklITmxiR1l1WVc1emQyVnlMblpoYkhWbElEMGdZVzV6ZDJWeUNpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKaGJuTjNaWElpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZwWDI5eVlXTnNaUzlqYjI1MGNtRmpkQzV3ZVRvME1nb2dJQ0FnTHk4Z2MyVnNaaTV6ZEdGMGRYTXVkbUZzZFdVZ1BTQlZTVzUwTmpRb01pa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luTjBZWFIxY3lJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZwWDI5eVlXTnNaUzlqYjI1MGNtRmpkQzV3ZVRvek1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZV2xmYjNKaFkyeGxMbU52Ym5SeVlXTjBMa0ZKVDNKaFkyeGxMbUZ3Y0hKdmRtVmZZVzVrWDNCaGVWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUZ3Y0hKdmRtVmZZVzVrWDNCaGVUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGFWOXZjbUZqYkdVdlkyOXVkSEpoWTNRdWNIazZORGt0TlRBS0lDQWdJQzh2SUNNZ01TNGdVMlZqZFhKcGRIa2dRMmhsWTJzNklFTnZiblJ5WVdOMElHMTFjM1FnWW1VZ2FXNGdRVzV6ZDJWeVpXUWdjM1JoZEdVS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxuTjBZWFIxY3k1MllXeDFaU0E5UFNCVlNXNTBOalFvTWlrc0lDSkRiMjUwY21GamRDQnBjeUJ1YjNRZ2FXNGdRVzV6ZDJWeVpXUWdjM1JoZEdVaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYzNSaGRIVnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5OMFlYUjFjeUJsZUdsemRITUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRU52Ym5SeVlXTjBJR2x6SUc1dmRDQnBiaUJCYm5OM1pYSmxaQ0J6ZEdGMFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGcFgyOXlZV05zWlM5amIyNTBjbUZqZEM1d2VUbzFNaTAxTXdvZ0lDQWdMeThnSXlBeUxpQlRaV04xY21sMGVTQkRhR1ZqYXpvZ1QyNXNlU0IwYUdVZ2NtVnhkV1Z6ZEdWeUlHTmhiaUJoY0hCeWIzWmxDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0J6Wld4bUxuSmxjWFZsYzNSbGNpNTJZV3gxWlN3Z0lrOXViSGtnZEdobElISmxjWFZsYzNSbGNpQmpZVzRnWVhCd2NtOTJaU0lLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKeVpYRjFaWE4wWlhJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjbVZ4ZFdWemRHVnlJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlIUm9aU0J5WlhGMVpYTjBaWElnWTJGdUlHRndjSEp2ZG1VS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYVY5dmNtRmpiR1V2WTI5dWRISmhZM1F1Y0hrNk5UVXROakFLSUNBZ0lDOHZJQ01nTXk0Z1VHVnlabTl5YlNCUVlYbHZkWFFnZG1saElFbHVibVZ5SUZSeVlXNXpZV04wYVc5dUNpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk5YzJWc1ppNXdjbTkyYVdSbGNpNTJZV3gxWlN3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROWMyVnNaaTVpYjNWdWRIa3VkbUZzZFdVc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFRBc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2xmYjNKaFkyeGxMMk52Ym5SeVlXTjBMbkI1T2pVM0NpQWdJQ0F2THlCeVpXTmxhWFpsY2oxelpXeG1MbkJ5YjNacFpHVnlMblpoYkhWbExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSW5CeWIzWnBaR1Z5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuQnliM1pwWkdWeUlHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZwWDI5eVlXTnNaUzlqYjI1MGNtRmpkQzV3ZVRvMU9Bb2dJQ0FnTHk4Z1lXMXZkVzUwUFhObGJHWXVZbTkxYm5SNUxuWmhiSFZsTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbUp2ZFc1MGVTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVpYjNWdWRIa2daWGhwYzNSekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGcFgyOXlZV05zWlM5amIyNTBjbUZqZEM1d2VUbzFOUzAxTmdvZ0lDQWdMeThnSXlBekxpQlFaWEptYjNKdElGQmhlVzkxZENCMmFXRWdTVzV1WlhJZ1ZISmhibk5oWTNScGIyNEtJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lHbHVkR05mTVNBdkx5QndZWGtLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGFWOXZjbUZqYkdVdlkyOXVkSEpoWTNRdWNIazZOVGtLSUNBZ0lDOHZJR1psWlQwd0xBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdsZmIzSmhZMnhsTDJOdmJuUnlZV04wTG5CNU9qVTFMVFl3Q2lBZ0lDQXZMeUFqSURNdUlGQmxjbVp2Y20wZ1VHRjViM1YwSUhacFlTQkpibTVsY2lCVWNtRnVjMkZqZEdsdmJnb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5UFhObGJHWXVjSEp2ZG1sa1pYSXVkbUZzZFdVc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBYTmxiR1l1WW05MWJuUjVMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQWdJR1psWlQwd0xBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYVY5dmNtRmpiR1V2WTI5dWRISmhZM1F1Y0hrNk5qSXROak1LSUNBZ0lDOHZJQ01nTkM0Z1VtVnpaWFFnVTNSaGRHVUtJQ0FnSUM4dklITmxiR1l1YzNSaGRIVnpMblpoYkhWbElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnpkR0YwZFhNaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYVY5dmNtRmpiR1V2WTI5dWRISmhZM1F1Y0hrNk5qUXROalVLSUNBZ0lDOHZJQ01nVDNCMGFXOXVZV3c2SUVOc1pXRnlJRzkwYUdWeUlHWnBaV3hrY3lCMGJ5QnpZWFpsSUhOd1lXTmxMMmRoY3lCdmNpQnFkWE4wSUd4bFlYWmxJSFJvWlcwZ1lYTWdkR2hsZVNkc2JDQmlaU0J2ZG1WeWQzSnBkSFJsYmdvZ0lDQWdMeThnYzJWc1ppNXhkV1Z6ZEdsdmJpNTJZV3gxWlNBOUlGTjBjbWx1WnlnaUlpa0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z0luRjFaWE4wYVc5dUlnb2dJQ0FnWW5sMFpXTmZNU0F2THlBaUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGFWOXZjbUZqYkdVdlkyOXVkSEpoWTNRdWNIazZOallLSUNBZ0lDOHZJSE5sYkdZdVlXNXpkMlZ5TG5aaGJIVmxJRDBnVTNSeWFXNW5LQ0lpS1FvZ0lDQWdZbmwwWldNZ05pQXZMeUFpWVc1emQyVnlJZ29nSUNBZ1lubDBaV05mTVNBdkx5QWlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhhVjl2Y21GamJHVXZZMjl1ZEhKaFkzUXVjSGs2TmpjS0lDQWdJQzh2SUhObGJHWXVZbTkxYm5SNUxuWmhiSFZsSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKaWIzVnVkSGtpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhhVjl2Y21GamJHVXZZMjl1ZEhKaFkzUXVjSGs2TkRRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QURBQUVDSmdjR2MzUmhkSFZ6QUFaaWIzVnVkSGtKY21WeGRXVnpkR1Z5Q0hCeWIzWnBaR1Z5Q0hGMVpYTjBhVzl1Qm1GdWMzZGxjakVZUUFBWEt6SURaeWNFTWdObkp3VXBaeWNHS1djcUltY29JbWN4RzBFQUpERVpGRVF4R0VTQ0F3U2tJUDE0QkxWTFgvc0UyVjV1WlRZYUFJNERBQWtBU0FCdEFERVpGREVZRkJCRE5ob0JTU0paSkFoTEFSVVNSRmNDQURFV0l3bEpPQkFqRWtRaUtHVkVGRVJKT0FjeUNoSkVTVGdJU1VSTU9BQXJUR2NuQlU4Q1p5cE1aeWdqWnlORE5ob0JTU0paSkFoTEFSVVNSRmNDQUNJb1pVUWpFa1FuQkRFQVp5Y0dUR2NvSkdjalF5SW9aVVFrRWtReEFDSXJaVVFTUkxFaUp3UmxSQ0lxWlVTeUNMSUhJN0lRSXJJQnN5Z2laeWNGS1djbkJpbG5LaUpuSTBNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
