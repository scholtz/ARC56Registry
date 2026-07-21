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

namespace Arc56.Generated.VJLIVE.TrustFundX.GetFund_a08e72fd
{


    public class GetFundProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public GetFundProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="team"> </param>
        /// <param name="required_votes"> </param>
        /// <param name="milestone_count"> </param>
        public async Task Create(Algorand.Address team, ulong required_votes, ulong milestone_count, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 248, 165, 131, 88 };
            var teamAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); teamAbi.From(team);
            var required_votesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); required_votesAbi.From(required_votes);
            var milestone_countAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); milestone_countAbi.From(milestone_count);

            var result = await base.CallApp(new List<object> { abiHandle, teamAbi, required_votesAbi, milestone_countAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Algorand.Address team, ulong required_votes, ulong milestone_count, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 248, 165, 131, 88 };
            var teamAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); teamAbi.From(team);
            var required_votesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); required_votesAbi.From(required_votes);
            var milestone_countAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); milestone_countAbi.From(milestone_count);

            return await base.MakeTransactionList(new List<object> { abiHandle, teamAbi, required_votesAbi, milestone_countAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="voter"> </param>
        public async Task InitVoter(Algorand.Address voter, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 173, 172, 11, 149 };
            var voterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voterAbi.From(voter);

            var result = await base.CallApp(new List<object> { abiHandle, voterAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> InitVoter_Transactions(Algorand.Address voter, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 173, 172, 11, 149 };
            var voterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voterAbi.From(voter);

            return await base.MakeTransactionList(new List<object> { abiHandle, voterAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="milestone_id"> </param>
        /// <param name="amount"> </param>
        public async Task InitMilestone(ulong milestone_id, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 176, 147, 172 };
            var milestone_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); milestone_idAbi.From(milestone_id);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, milestone_idAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> InitMilestone_Transactions(ulong milestone_id, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 176, 147, 172 };
            var milestone_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); milestone_idAbi.From(milestone_id);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, milestone_idAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="milestone_id"> </param>
        public async Task Approve(ulong milestone_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 173, 214, 48, 110 };
            var milestone_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); milestone_idAbi.From(milestone_id);

            var result = await base.CallApp(new List<object> { abiHandle, milestone_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Approve_Transactions(ulong milestone_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 173, 214, 48, 110 };
            var milestone_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); milestone_idAbi.From(milestone_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, milestone_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Fund(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 233, 137, 43, 239 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Fund_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 233, 137, 43, 239 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiR2V0RnVuZCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRlYW0iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlcXVpcmVkX3ZvdGVzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtaWxlc3RvbmVfY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaW5pdF92b3RlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidm90ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaW5pdF9taWxlc3RvbmUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWlsZXN0b25lX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXBwcm92ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtaWxlc3RvbmVfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZnVuZCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjJ9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzI5OV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubWlsZXN0b25lcyBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMjVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnJlcXVpcmVkX3ZvdGVzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5OSwyMzEsMzgxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5zcG9uc29yIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzNF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudGVhbSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnZvdGVycyBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzQsMTkzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0MiwxNTAsMjE3LDIyNSwyNjJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ09DQXpNZ29nSUNBZ1lubDBaV05pYkc5amF5QWljM0J2Ym5OdmNpSWdNSGd3TURBd01EQXdNREF3TURBd01EQXhJQ0owWldGdElpQWljbVZ4ZFdseVpXUmZkbTkwWlhNaUlDSjJiM1JsY25NaUlDSnRhV3hsYzNSdmJtVnpJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGxkR1oxYm1RdlkyOXVkSEpoWTNRdWNIazZOUW9nSUNBZ0x5OGdZMnhoYzNNZ1IyVjBSblZ1WkNoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2Y0hsZlpHVm1ZWFZzZEY5amNtVmhkR1ZBTVRRS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZUdZNFlUVTRNelU0SURCNFlXUmhZekJpT1RVZ01IZzJaR0l3T1ROaFl5QXdlR0ZrWkRZek1EWmxJREI0WlRrNE9USmlaV1lnTHk4Z2JXVjBhRzlrSUNKamNtVmhkR1VvWVdSa2NtVnpjeXgxYVc1ME5qUXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1sdWFYUmZkbTkwWlhJb1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0pwYm1sMFgyMXBiR1Z6ZEc5dVpTaDFhVzUwTmpRc2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbUZ3Y0hKdmRtVW9kV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1aMWJtUW9LWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmpjbVZoZEdVZ2FXNXBkRjkyYjNSbGNpQnBibWwwWDIxcGJHVnpkRzl1WlNCaGNIQnliM1psSUdaMWJtUUtJQ0FnSUdWeWNnb0tiV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF4TkRvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbWRsZEdaMWJtUXVZMjl1ZEhKaFkzUXVSMlYwUm5WdVpDNWpjbVZoZEdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpjbVZoZEdVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJWMFpuVnVaQzlqYjI1MGNtRmpkQzV3ZVRveU5TMHlPQW9nSUNBZ0x5OGdJeUF0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRDaUFnSUNBdkx5QWpJRU55WldGMFpRb2dJQ0FnTHk4Z0l5QXRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkbGRHWjFibVF2WTI5dWRISmhZM1F1Y0hrNk16VUtJQ0FnSUM4dklITmxiR1l1YzNCdmJuTnZjaTUyWVd4MVpTQTlJRlI0Ymk1elpXNWtaWElLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbk53YjI1emIzSWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkbGRHWjFibVF2WTI5dWRISmhZM1F1Y0hrNk16WUtJQ0FnSUM4dklITmxiR1l1ZEdWaGJTNTJZV3gxWlNBOUlIUmxZVzBLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJblJsWVcwaUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMlYwWm5WdVpDOWpiMjUwY21GamRDNXdlVG96TndvZ0lDQWdMeThnYzJWc1ppNXlaWEYxYVhKbFpGOTJiM1JsY3k1MllXeDFaU0E5SUhKbGNYVnBjbVZrWDNadmRHVnpMbTVoZEdsMlpRb2dJQ0FnYzNkaGNBb2dJQ0FnWW5SdmFRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWNtVnhkV2x5WldSZmRtOTBaWE1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRsZEdaMWJtUXZZMjl1ZEhKaFkzUXVjSGs2TXpnS0lDQWdJQzh2SUhObGJHWXViV2xzWlhOMGIyNWxYMk52ZFc1MExuWmhiSFZsSUQwZ2JXbHNaWE4wYjI1bFgyTnZkVzUwTG01aGRHbDJaUW9nSUNBZ1luUnZhUW9nSUNBZ2NIVnphR0o1ZEdWeklDSnRhV3hsYzNSdmJtVmZZMjkxYm5RaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkbGRHWjFibVF2WTI5dWRISmhZM1F1Y0hrNk1qVXRNamdLSUNBZ0lDOHZJQ01nTFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUW9nSUNBZ0x5OGdJeUJEY21WaGRHVUtJQ0FnSUM4dklDTWdMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExRb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtZGxkR1oxYm1RdVkyOXVkSEpoWTNRdVIyVjBSblZ1WkM1cGJtbDBYM1p2ZEdWeVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0thVzVwZEY5MmIzUmxjam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5aWFJtZFc1a0wyTnZiblJ5WVdOMExuQjVPalF3TFRRekNpQWdJQ0F2THlBaklDMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwS0lDQWdJQzh2SUNNZ1VtVm5hWE4wWlhJZ1ZtOTBaWElLSUNBZ0lDOHZJQ01nTFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWlhSbWRXNWtMMk52Ym5SeVlXTjBMbkI1T2pRMUNpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQnpaV3htTG5Od2IyNXpiM0l1ZG1Gc2RXVUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p6Y0c5dWMyOXlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5Od2IyNXpiM0lnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyVjBablZ1WkM5amIyNTBjbUZqZEM1d2VUbzBOZ29nSUNBZ0x5OGdjMlZzWmk1MmIzUmxjbk5iZG05MFpYSmRJRDBnWVhKak5DNVZTVzUwTmpRb01Ta0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0luWnZkR1Z5Y3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURFS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5blpYUm1kVzVrTDJOdmJuUnlZV04wTG5CNU9qUXdMVFF6Q2lBZ0lDQXZMeUFqSUMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzBLSUNBZ0lDOHZJQ01nVW1WbmFYTjBaWElnVm05MFpYSUtJQ0FnSUM4dklDTWdMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExRb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtZGxkR1oxYm1RdVkyOXVkSEpoWTNRdVIyVjBSblZ1WkM1cGJtbDBYMjFwYkdWemRHOXVaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21sdWFYUmZiV2xzWlhOMGIyNWxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGxkR1oxYm1RdlkyOXVkSEpoWTNRdWNIazZORGd0TlRFS0lDQWdJQzh2SUNNZ0xTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFFvZ0lDQWdMeThnSXlCSmJtbDBhV0ZzYVhwbElFMXBiR1Z6ZEc5dVpRb2dJQ0FnTHk4Z0l5QXRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5blpYUm1kVzVrTDJOdmJuUnlZV04wTG5CNU9qVTRDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0J6Wld4bUxuTndiMjV6YjNJdWRtRnNkV1VLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKemNHOXVjMjl5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuTndiMjV6YjNJZ1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMlYwWm5WdVpDOWpiMjUwY21GamRDNXdlVG8yTWdvZ0lDQWdMeThnWVcxdmRXNTBMbTVoZEdsMlpTd0tJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5blpYUm1kVzVrTDJOdmJuUnlZV04wTG5CNU9qWXdMVFkxQ2lBZ0lDQXZMeUFqSUNoaGJXOTFiblFzSUdGd2NISnZkbUZzY3l3Z2NHRnBaQ2tLSUNBZ0lDOHZJSE5sYkdZdWJXbHNaWE4wYjI1bGMxdHRhV3hsYzNSdmJtVmZhV1F1Ym1GMGFYWmxYU0E5SUdGeVl6UXVWSFZ3YkdVb0tBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWRDNXVZWFJwZG1Vc0NpQWdJQ0F2THlBZ0lDQWdWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNrcENpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJWMFpuVnVaQzlqYjI1MGNtRmpkQzV3ZVRvMk13b2dJQ0FnTHk4Z1ZVbHVkRFkwS0RBcExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWlhSbWRXNWtMMk52Ym5SeVlXTjBMbkI1T2pZd0xUWTFDaUFnSUNBdkx5QWpJQ2hoYlc5MWJuUXNJR0Z3Y0hKdmRtRnNjeXdnY0dGcFpDa0tJQ0FnSUM4dklITmxiR1l1Yldsc1pYTjBiMjVsYzF0dGFXeGxjM1J2Ym1WZmFXUXVibUYwYVhabFhTQTlJR0Z5WXpRdVZIVndiR1VvS0FvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEM1dVlYUnBkbVVzQ2lBZ0lDQXZMeUFnSUNBZ1ZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJRlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ2twQ2lBZ0lDQnBkRzlpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5blpYUm1kVzVrTDJOdmJuUnlZV04wTG5CNU9qWXdMVFl4Q2lBZ0lDQXZMeUFqSUNoaGJXOTFiblFzSUdGd2NISnZkbUZzY3l3Z2NHRnBaQ2tLSUNBZ0lDOHZJSE5sYkdZdWJXbHNaWE4wYjI1bGMxdHRhV3hsYzNSdmJtVmZhV1F1Ym1GMGFYWmxYU0E5SUdGeVl6UXVWSFZ3YkdVb0tBb2dJQ0FnYzNkaGNBb2dJQ0FnWW5SdmFRb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTWdOU0F2THlBaWJXbHNaWE4wYjI1bGN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGxkR1oxYm1RdlkyOXVkSEpoWTNRdWNIazZOakF0TmpVS0lDQWdJQzh2SUNNZ0tHRnRiM1Z1ZEN3Z1lYQndjbTkyWVd4ekxDQndZV2xrS1FvZ0lDQWdMeThnYzJWc1ppNXRhV3hsYzNSdmJtVnpXMjFwYkdWemRHOXVaVjlwWkM1dVlYUnBkbVZkSUQwZ1lYSmpOQzVVZFhCc1pTZ29DaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBMbTVoZEdsMlpTd0tJQ0FnSUM4dklDQWdJQ0JWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1ZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0tTa0tJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5aWFJtZFc1a0wyTnZiblJ5WVdOMExuQjVPalE0TFRVeENpQWdJQ0F2THlBaklDMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwS0lDQWdJQzh2SUNNZ1NXNXBkR2xoYkdsNlpTQk5hV3hsYzNSdmJtVUtJQ0FnSUM4dklDTWdMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExRb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtZGxkR1oxYm1RdVkyOXVkSEpoWTNRdVIyVjBSblZ1WkM1aGNIQnliM1psVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1lYQndjbTkyWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWlhSbWRXNWtMMk52Ym5SeVlXTjBMbkI1T2pZM0xUY3dDaUFnSUNBdkx5QWpJQzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMEtJQ0FnSUM4dklDTWdRWEJ3Y205MlpTQk5hV3hsYzNSdmJtVUtJQ0FnSUM4dklDTWdMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExRb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJWMFpuVnVaQzlqYjI1MGNtRmpkQzV3ZVRvM015MDNOQW9nSUNBZ0x5OGdJeUJ0ZFhOMElHSmxJSEpsWjJsemRHVnlaV1FnZG05MFpYSUtJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1Mblp2ZEdWeWMxdFVlRzR1YzJWdVpHVnlYU0E5UFNCaGNtTTBMbFZKYm5RMk5DZ3hLUW9nSUNBZ1lubDBaV01nTkNBdkx5QWlkbTkwWlhKeklnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTJiM1JsY25NZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01Rb2dJQ0FnWWowOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5blpYUm1kVzVrTDJOdmJuUnlZV04wTG5CNU9qYzJMVGMzQ2lBZ0lDQXZMeUFqSUhCeVpYWmxiblFnWkc5MVlteGxJSFp2ZEdVS0lDQWdJQzh2SUhadmRHVmZhMlY1SUQwZ1lYSmpOQzVVZFhCc1pTZ29iV2xzWlhOMGIyNWxYMmxrTENCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtwS1FvZ0lDQWdaSFZ3Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5aWFJtZFc1a0wyTnZiblJ5WVdOMExuQjVPamM0Q2lBZ0lDQXZMeUJoYzNObGNuUWdibTkwSUhObGJHWXVkbTkwWlhNdWJXRjVZbVVvZG05MFpWOXJaWGtwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJblp2ZEdWeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyVjBablZ1WkM5amIyNTBjbUZqZEM1d2VUbzRNQW9nSUNBZ0x5OGdiV2xzWlhOMGIyNWxYMlJoZEdFZ1BTQnpaV3htTG0xcGJHVnpkRzl1WlhOYmJXbHNaWE4wYjI1bFgybGtMbTVoZEdsMlpWMEtJQ0FnSUhOM1lYQUtJQ0FnSUdKMGIya0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltMXBiR1Z6ZEc5dVpYTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJXbHNaWE4wYjI1bGN5QmxiblJ5ZVNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5aWFJtZFc1a0wyTnZiblJ5WVdOMExuQjVPamd4Q2lBZ0lDQXZMeUJoYlc5MWJuUWdQU0J0YVd4bGMzUnZibVZmWkdGMFlWc3dYUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5aWFJtZFc1a0wyTnZiblJ5WVdOMExuQjVPamd5Q2lBZ0lDQXZMeUJoY0hCeWIzWmhiSE1nUFNCdGFXeGxjM1J2Ym1WZlpHRjBZVnN4WFFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5aWFJtZFc1a0wyTnZiblJ5WVdOMExuQjVPamd6Q2lBZ0lDQXZMeUJ3WVdsa0lEMGdiV2xzWlhOMGIyNWxYMlJoZEdGYk1sMEtJQ0FnSUhOM1lYQUtJQ0FnSUhCMWMyaHBiblFnTVRZS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJWMFpuVnVaQzlqYjI1MGNtRmpkQzV3ZVRvNE5Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhCaGFXUWdQVDBnVlVsdWREWTBLREFwQ2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5aWFJtZFc1a0wyTnZiblJ5WVdOMExuQjVPamczQ2lBZ0lDQXZMeUJoY0hCeWIzWmhiSE1nUFNCaGNIQnliM1poYkhNZ0t5QlZTVzUwTmpRb01Ta0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWlhSbWRXNWtMMk52Ym5SeVlXTjBMbkI1T2pnNUNpQWdJQ0F2THlCelpXeG1Mblp2ZEdWelczWnZkR1ZmYTJWNVhTQTlJR0Z5WXpRdVZVbHVkRFkwS0RFcENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TVFvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkbGRHWjFibVF2WTI5dWRISmhZM1F1Y0hrNk9URUtJQ0FnSUM4dklHbG1JR0Z3Y0hKdmRtRnNjeUErUFNCelpXeG1MbkpsY1hWcGNtVmtYM1p2ZEdWekxuWmhiSFZsT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbkpsY1hWcGNtVmtYM1p2ZEdWeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbkpsY1hWcGNtVmtYM1p2ZEdWeklHVjRhWE4wY3dvZ0lDQWdQajBLSUNBZ0lHSjZJR0Z3Y0hKdmRtVmZaV3h6WlY5aWIyUjVRRFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5aWFJtZFc1a0wyTnZiblJ5WVdOMExuQjVPamt6TFRrMkNpQWdJQ0F2THlCUVlYbHRaVzUwS0FvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeVBYTmxiR1l1ZEdWaGJTNTJZV3gxWlN3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROVlXMXZkVzUwTEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGxkR1oxYm1RdlkyOXVkSEpoWTNRdWNIazZPVFFLSUNBZ0lDOHZJSEpsWTJWcGRtVnlQWE5sYkdZdWRHVmhiUzUyWVd4MVpTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKMFpXRnRJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SbFlXMGdaWGhwYzNSekNpQWdJQ0JrYVdjZ013b2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGxkR1oxYm1RdlkyOXVkSEpoWTNRdWNIazZPVE1LSUNBZ0lDOHZJRkJoZVcxbGJuUW9DaUFnSUNCcGJuUmpYekVnTHk4Z2NHRjVDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWlhSbWRXNWtMMk52Ym5SeVlXTjBMbkI1T2prekxUazJDaUFnSUNBdkx5QlFZWGx0Wlc1MEtBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlQWE5sYkdZdWRHVmhiUzUyWVd4MVpTd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTlZVzF2ZFc1MExBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWlhSbWRXNWtMMk52Ym5SeVlXTjBMbkI1T2prNExURXdNZ29nSUNBZ0x5OGdjMlZzWmk1dGFXeGxjM1J2Ym1WelcyMXBiR1Z6ZEc5dVpWOXBaQzV1WVhScGRtVmRJRDBnWVhKak5DNVVkWEJzWlNnb0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJR0Z3Y0hKdmRtRnNjeXdLSUNBZ0lDOHZJQ0FnSUNCVlNXNTBOalFvTVNrc0NpQWdJQ0F2THlBcEtRb2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWlhSbWRXNWtMMk52Ym5SeVlXTjBMbkI1T2pFd01Rb2dJQ0FnTHk4Z1ZVbHVkRFkwS0RFcExBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWlhSbWRXNWtMMk52Ym5SeVlXTjBMbkI1T2prNExURXdNZ29nSUNBZ0x5OGdjMlZzWmk1dGFXeGxjM1J2Ym1WelcyMXBiR1Z6ZEc5dVpWOXBaQzV1WVhScGRtVmRJRDBnWVhKak5DNVVkWEJzWlNnb0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJR0Z3Y0hKdmRtRnNjeXdLSUNBZ0lDOHZJQ0FnSUNCVlNXNTBOalFvTVNrc0NpQWdJQ0F2THlBcEtRb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZjSFYwQ2dwaGNIQnliM1psWDJGbWRHVnlYMmxtWDJWc2MyVkFOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5aWFJtZFc1a0wyTnZiblJ5WVdOMExuQjVPalkzTFRjd0NpQWdJQ0F2THlBaklDMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwS0lDQWdJQzh2SUNNZ1FYQndjbTkyWlNCTmFXeGxjM1J2Ym1VS0lDQWdJQzh2SUNNZ0xTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3BoY0hCeWIzWmxYMlZzYzJWZlltOWtlVUEwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRsZEdaMWJtUXZZMjl1ZEhKaFkzUXVjSGs2TVRBMExURXdPQW9nSUNBZ0x5OGdjMlZzWmk1dGFXeGxjM1J2Ym1WelcyMXBiR1Z6ZEc5dVpWOXBaQzV1WVhScGRtVmRJRDBnWVhKak5DNVVkWEJzWlNnb0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJR0Z3Y0hKdmRtRnNjeXdLSUNBZ0lDOHZJQ0FnSUNCVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBcEtRb2dJQ0FnWkdsbklESUtJQ0FnSUdsMGIySUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJWMFpuVnVaQzlqYjI1MGNtRmpkQzV3ZVRveE1EY0tJQ0FnSUM4dklGVkpiblEyTkNnd0tTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJWMFpuVnVaQzlqYjI1MGNtRmpkQzV3ZVRveE1EUXRNVEE0Q2lBZ0lDQXZMeUJ6Wld4bUxtMXBiR1Z6ZEc5dVpYTmJiV2xzWlhOMGIyNWxYMmxrTG01aGRHbDJaVjBnUFNCaGNtTTBMbFIxY0d4bEtDZ0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnWVhCd2NtOTJZV3h6TEFvZ0lDQWdMeThnSUNBZ0lGVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDa3BDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJR0lnWVhCd2NtOTJaVjloWm5SbGNsOXBabDlsYkhObFFEVUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WjJWMFpuVnVaQzVqYjI1MGNtRmpkQzVIWlhSR2RXNWtMbVoxYm1SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG1kVzVrT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRsZEdaMWJtUXZZMjl1ZEhKaFkzUXVjSGs2TVRFMkxURXhOd29nSUNBZ0x5OGdJeUJ0ZFhOMElHSmxJSE53YjI1emIzSUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdWMzQnZibk52Y2k1MllXeDFaUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5Od2IyNXpiM0lpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWMzQnZibk52Y2lCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5aWFJtZFc1a0wyTnZiblJ5WVdOMExuQjVPakV4T1MweE1qQUtJQ0FnSUM4dklDTWdiWFZ6ZENCelpXNWtJSEJ2YzJsMGFYWmxJSEJoZVcxbGJuUWdZVzF2ZFc1MENpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxtRnRiM1Z1ZENBK0lGVkpiblEyTkNnd0tRb2dJQ0FnZEhodUlFRnRiM1Z1ZEFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJWMFpuVnVaQzlqYjI1MGNtRmpkQzV3ZVRveE1UQXRNVEV6Q2lBZ0lDQXZMeUFqSUMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzBLSUNBZ0lDOHZJQ01nUm5WdVpDQkRiMjUwY21GamRBb2dJQ0FnTHk4Z0l5QXRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUlJQ1lHQjNOd2IyNXpiM0lJQUFBQUFBQUFBQUVFZEdWaGJRNXlaWEYxYVhKbFpGOTJiM1JsY3daMmIzUmxjbk1LYldsc1pYTjBiMjVsY3pFYlFRQXlNUmtVUkRFWVJJSUZCUGlsZzFnRXJhd0xsUVJ0c0pPc0JLM1dNRzRFNllrcjd6WWFBSTRGQUFrQVJBQmNBSWtCQWdBeEdSUXhHQlFRUXpZYUFVa1ZKUkpFTmhvQ1NSVWtFa1EyR2dOSkZTUVNSQ2d4QUdjcVR3Tm5UQmNyVEdjWGdBOXRhV3hsYzNSdmJtVmZZMjkxYm5STVp5TkROaG9CU1JVbEVrUXhBQ0lvWlVRU1JDY0VURkFwdnlORE5ob0JTUlVrRWtRMkdnSkpGU1FTUkRFQUlpaGxSQkpFRnhZaUZreExBVkJNVUV3WEZpY0ZURkJNdnlORE5ob0JTUlVrRWtRbkJERUFVTDVFS2FoRVNURUFVSUFGZG05MFpYTk1VQ0pFVEJjV0p3Vk1VRWxPQXI1RVNTSmJUZ05KSkZ0TWdSQmJGRVFqQ0VsT0Ewd3B2eUlyWlVRUFFRQWdzU0lxWlVSTEEwbE9BcklJc2djanNoQWlzZ0d6Rms4Q0ZsQWpGbEMvSTBOTEFoWlBBaFpRSWhaUXYwTC84REVBSWlobFJCSkVNUWhFSTBNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
