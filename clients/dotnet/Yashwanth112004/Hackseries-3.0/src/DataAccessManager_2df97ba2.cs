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

namespace Arc56.Generated.Yashwanth112004.Hackseries_3_0.DataAccessManager_2df97ba2
{


    public class DataAccessManagerProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public DataAccessManagerProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="consent_manager_app_id"> </param>
        /// <param name="audit_app_id"> </param>
        public async Task Bootstrap(ulong consent_manager_app_id, ulong audit_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 139, 239, 5, 14 };
            var consent_manager_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); consent_manager_app_idAbi.From(consent_manager_app_id);
            var audit_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); audit_app_idAbi.From(audit_app_id);

            var result = await base.CallApp(new List<object> { abiHandle, consent_manager_app_idAbi, audit_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Bootstrap_Transactions(ulong consent_manager_app_id, ulong audit_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 139, 239, 5, 14 };
            var consent_manager_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); consent_manager_app_idAbi.From(consent_manager_app_id);
            var audit_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); audit_app_idAbi.From(audit_app_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, consent_manager_app_idAbi, audit_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="principal"> </param>
        /// <param name="index"> </param>
        /// <param name="scope"> </param>
        /// <param name="purpose"> </param>
        public async Task AccessData(Algorand.Address principal, ulong index, string scope, string purpose, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 115, 114, 220, 152 };
            var principalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); principalAbi.From(principal);
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);
            var scopeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scopeAbi.From(scope);
            var purposeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); purposeAbi.From(purpose);

            var result = await base.CallApp(new List<object> { abiHandle, principalAbi, indexAbi, scopeAbi, purposeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AccessData_Transactions(Algorand.Address principal, ulong index, string scope, string purpose, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 115, 114, 220, 152 };
            var principalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); principalAbi.From(principal);
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);
            var scopeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scopeAbi.From(scope);
            var purposeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); purposeAbi.From(purpose);

            return await base.MakeTransactionList(new List<object> { abiHandle, principalAbi, indexAbi, scopeAbi, purposeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRGF0YUFjY2Vzc01hbmFnZXIiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiYm9vdHN0cmFwIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvbnNlbnRfbWFuYWdlcl9hcHBfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImF1ZGl0X2FwcF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhY2Nlc3NfZGF0YSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJpbmNpcGFsIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbmRleCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2NvcGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InB1cnBvc2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjIsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxOTZdLCJlcnJvck1lc3NhZ2UiOiJJbnZhbGlkIG9yIGV4cGlyZWQgY29uc2VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4NV0sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIGxvZyB2YWx1ZSBpcyBub3QgdGhlIHJlc3VsdCBvZiBhbiBBQkkgcmV0dXJuIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjA2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hdWRpdF9hcHAgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5jb25zZW50X21hbmFnZXJfYXBwIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNywxMzBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5ib29sIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI0LDEzN10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzUsODMsMTExXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lEZ2dNU0F5Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0pqYlY5aGNIQWlJQ0poZFdScGRGOWhjSEFpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZSR0YwWVVGalkyVnpjMDFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRJS0lDQWdJQzh2SUdOc1lYTnpJRVJoZEdGQlkyTmxjM05OWVc1aFoyVnlLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlmWDJGc1oyOXdlVjlrWldaaGRXeDBYMk55WldGMFpVQXhNUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRPR0psWmpBMU1HVWdNSGczTXpjeVpHTTVPQ0F2THlCdFpYUm9iMlFnSW1KdmIzUnpkSEpoY0NoMWFXNTBOalFzZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltRmpZMlZ6YzE5a1lYUmhLR0ZrWkhKbGMzTXNkV2x1ZERZMExITjBjbWx1Wnl4emRISnBibWNwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JR0p2YjNSemRISmhjQ0JoWTJObGMzTmZaR0YwWVFvZ0lDQWdaWEp5Q2dwdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFERXhPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lDWW1DaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVJHRjBZVUZqWTJWemMwMWhibUZuWlhJdVkyOXVkSEpoWTNRdVJHRjBZVUZqWTJWemMwMWhibUZuWlhJdVltOXZkSE4wY21Gd1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZbTl2ZEhOMGNtRndPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwUmhkR0ZCWTJObGMzTk5ZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPakU0Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlFWVhSaFFXTmpaWE56VFdGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRveU5Bb2dJQ0FnTHk4Z2MyVnNaaTVqYjI1elpXNTBYMjFoYm1GblpYSmZZWEJ3TG5aaGJIVmxJRDBnWTI5dWMyVnVkRjl0WVc1aFoyVnlYMkZ3Y0Y5cFpDNXVZWFJwZG1VS0lDQWdJSE4zWVhBS0lDQWdJR0owYjJrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1OdFgyRndjQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZSR0YwWVVGalkyVnpjMDFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TWpVS0lDQWdJQzh2SUhObGJHWXVZWFZrYVhSZllYQndMblpoYkhWbElEMGdZWFZrYVhSZllYQndYMmxrTG01aGRHbDJaUW9nSUNBZ1luUnZhUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZWFZrYVhSZllYQndJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUVZWFJoUVdOalpYTnpUV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG94T0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TGtSaGRHRkJZMk5sYzNOTllXNWhaMlZ5TG1OdmJuUnlZV04wTGtSaGRHRkJZMk5sYzNOTllXNWhaMlZ5TG1GalkyVnpjMTlrWVhSaFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZV05qWlhOelgyUmhkR0U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZSR0YwWVVGalkyVnpjMDFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TWpjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMFJoZEdGQlkyTmxjM05OWVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pNMUxUUXlDaUFnSUNBdkx5QWpJRlZ6WlNCdFpYUm9iMlFnYzJsbmJtRjBkWEpsSUhOMGNtbHVaeUJwYm5OMFpXRmtJRzltSUVGU1F6UkRiR2xsYm5RZ2MzUjFZZ29nSUNBZ0x5OGdhWE5mZG1Gc2FXUXNJRjkwZUc0Z1BTQmhjbU0wTG1GaWFWOWpZV3hzVzJGeVl6UXVRbTl2YkYwb0NpQWdJQ0F2THlBZ0lDQWdJblpoYkdsa1lYUmxYMk52Ym5ObGJuUW9ZV1JrY21WemN5eDFhVzUwTmpRc2MzUnlhVzVuS1dKdmIyd2lMQW9nSUNBZ0x5OGdJQ0FnSUhCeWFXNWphWEJoYkN3S0lDQWdJQzh2SUNBZ0lDQnBibVJsZUN3S0lDQWdJQzh2SUNBZ0lDQnpZMjl3WlN3S0lDQWdJQzh2SUNBZ0lDQmhjSEJmYVdROVFYQndiR2xqWVhScGIyNG9jMlZzWmk1amIyNXpaVzUwWDIxaGJtRm5aWEpmWVhCd0xuWmhiSFZsS1N3S0lDQWdJQzh2SUNrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUVZWFJoUVdOalpYTnpUV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG8wTVFvZ0lDQWdMeThnWVhCd1gybGtQVUZ3Y0d4cFkyRjBhVzl1S0hObGJHWXVZMjl1YzJWdWRGOXRZVzVoWjJWeVgyRndjQzUyWVd4MVpTa3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVkyMWZZWEJ3SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtTnZibk5sYm5SZmJXRnVZV2RsY2w5aGNIQWdaWGhwYzNSekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5RVlYUmhRV05qWlhOelRXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3pOUzAwTWdvZ0lDQWdMeThnSXlCVmMyVWdiV1YwYUc5a0lITnBaMjVoZEhWeVpTQnpkSEpwYm1jZ2FXNXpkR1ZoWkNCdlppQkJVa00wUTJ4cFpXNTBJSE4wZFdJS0lDQWdJQzh2SUdselgzWmhiR2xrTENCZmRIaHVJRDBnWVhKak5DNWhZbWxmWTJGc2JGdGhjbU0wTGtKdmIyeGRLQW9nSUNBZ0x5OGdJQ0FnSUNKMllXeHBaR0YwWlY5amIyNXpaVzUwS0dGa1pISmxjM01zZFdsdWREWTBMSE4wY21sdVp5bGliMjlzSWl3S0lDQWdJQzh2SUNBZ0lDQndjbWx1WTJsd1lXd3NDaUFnSUNBdkx5QWdJQ0FnYVc1a1pYZ3NDaUFnSUNBdkx5QWdJQ0FnYzJOdmNHVXNDaUFnSUNBdkx5QWdJQ0FnWVhCd1gybGtQVUZ3Y0d4cFkyRjBhVzl1S0hObGJHWXVZMjl1YzJWdWRGOXRZVzVoWjJWeVgyRndjQzUyWVd4MVpTa3NDaUFnSUNBdkx5QXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzBZekk0WVRWaFl5QXZMeUJ0WlhSb2IyUWdJblpoYkdsa1lYUmxYMk52Ym5ObGJuUW9ZV1JrY21WemN5eDFhVzUwTmpRc2MzUnlhVzVuS1dKdmIyd2lDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdaR2xuSURNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdjSFZ6YUdsdWRDQTJJQzh2SUdGd2NHd0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURBZ05Bb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdZWEJ3YkdsallYUnBiMjRnYkc5bklIWmhiSFZsSUdseklHNXZkQ0IwYUdVZ2NtVnpkV3gwSUc5bUlHRnVJRUZDU1NCeVpYUjFjbTRLSUNBZ0lHVjRkSEpoWTNRZ05DQXdDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVltOXZiQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwUmhkR0ZCWTJObGMzTk5ZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPalEwQ2lBZ0lDQXZMeUJoYzNObGNuUWdhWE5mZG1Gc2FXUXVibUYwYVhabExDQWlTVzUyWVd4cFpDQnZjaUJsZUhCcGNtVmtJR052Ym5ObGJuUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCaGMzTmxjblFnTHk4Z1NXNTJZV3hwWkNCdmNpQmxlSEJwY21Wa0lHTnZibk5sYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlFWVhSaFFXTmpaWE56VFdGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRvME5pMDFNd29nSUNBZ0x5OGdZWEpqTkM1aFltbGZZMkZzYkNnS0lDQWdJQzh2SUNBZ0lDQWliRzluWDJSaGRHRmZZV05qWlhOelpXUW9ZV1JrY21WemN5eGhaR1J5WlhOekxITjBjbWx1Wnl4MWFXNTBOalFwZG05cFpDSXNDaUFnSUNBdkx5QWdJQ0FnY0hKcGJtTnBjR0ZzTEFvZ0lDQWdMeThnSUNBZ0lHRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1N3S0lDQWdJQzh2SUNBZ0lDQndkWEp3YjNObExBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVZVbHVkRFkwS0c5d0xrZHNiMkpoYkM1c1lYUmxjM1JmZEdsdFpYTjBZVzF3S1N3S0lDQWdJQzh2SUNBZ0lDQmhjSEJmYVdROVFYQndiR2xqWVhScGIyNG9jMlZzWmk1aGRXUnBkRjloY0hBdWRtRnNkV1VwTEFvZ0lDQWdMeThnS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwUmhkR0ZCWTJObGMzTk5ZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPalE1Q2lBZ0lDQXZMeUJoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3NDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12UkdGMFlVRmpZMlZ6YzAxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk5URUtJQ0FnSUM4dklHRnlZelF1VlVsdWREWTBLRzl3TGtkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdLU3dLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUVZWFJoUVdOalpYTnpUV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG8xTWdvZ0lDQWdMeThnWVhCd1gybGtQVUZ3Y0d4cFkyRjBhVzl1S0hObGJHWXVZWFZrYVhSZllYQndMblpoYkhWbEtTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaGRXUnBkRjloY0hBaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZWFZrYVhSZllYQndJR1Y0YVhOMGN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlJHRjBZVUZqWTJWemMwMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZORFl0TlRNS0lDQWdJQzh2SUdGeVl6UXVZV0pwWDJOaGJHd29DaUFnSUNBdkx5QWdJQ0FnSW14dloxOWtZWFJoWDJGalkyVnpjMlZrS0dGa1pISmxjM01zWVdSa2NtVnpjeXh6ZEhKcGJtY3NkV2x1ZERZMEtYWnZhV1FpTEFvZ0lDQWdMeThnSUNBZ0lIQnlhVzVqYVhCaGJDd0tJQ0FnSUM4dklDQWdJQ0JoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3NDaUFnSUNBdkx5QWdJQ0FnY0hWeWNHOXpaU3dLSUNBZ0lDOHZJQ0FnSUNCaGNtTTBMbFZKYm5RMk5DaHZjQzVIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNDa3NDaUFnSUNBdkx5QWdJQ0FnWVhCd1gybGtQVUZ3Y0d4cFkyRjBhVzl1S0hObGJHWXVZWFZrYVhSZllYQndMblpoYkhWbEtTd0tJQ0FnSUM4dklDa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VHTTNZbVJpTkRjd0lDOHZJRzFsZEdodlpDQWliRzluWDJSaGRHRmZZV05qWlhOelpXUW9ZV1JrY21WemN5eGhaR1J5WlhOekxITjBjbWx1Wnl4MWFXNTBOalFwZG05cFpDSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYzNkaGNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0J3ZFhOb2FXNTBJRFlnTHk4Z1lYQndiQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMFJoZEdGQlkyTmxjM05OWVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pJM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBZ0JBaVlDQm1OdFgyRndjQWxoZFdScGRGOWhjSEF4RzBFQUhURVpGRVF4R0VTQ0FnU0w3d1VPQkhOeTNKZzJHZ0NPQWdBSkFDUUFNUmtVTVJnVUVFTTJHZ0ZKRlNNU1JEWWFBa2tWSXhKRVRCY29UR2NYS1V4bkpFTTJHZ0ZKRllFZ0VrUTJHZ0pKRlNNU1JEWWFBMGtpV1NVSVN3RVZFa1EyR2dSSklsa2xDRXNCRlJKRXNTSW9aVVN5R0lBRVRDaWxyTElhU3dPeUdrOENzaHBNc2hxQkJySVFJcklCczdRK1NWY0FCSUFFRlI5OGRSSkVWd1FBU1JVa0VrUWlVMFN4TVFBeUJ4WWlLV1ZFc2hpQUJNZTl0SEN5R2s4RHNocE1zaHBNc2hxeUdvRUdzaEFpc2dHekpFTT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo3LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
