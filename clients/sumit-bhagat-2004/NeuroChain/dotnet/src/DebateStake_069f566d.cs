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

namespace Arc56.Generated.sumit_bhagat_2004.NeuroChain.DebateStake_069f566d
{


    public class DebateStakeProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public DebateStakeProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="debate_id"> </param>
        public async Task Initialize(string debate_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 243, 57, 231 };
            var debate_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); debate_idAbi.From(debate_id);

            var result = await base.CallApp(new List<object> { abiHandle, debate_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Initialize_Transactions(string debate_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 243, 57, 231 };
            var debate_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); debate_idAbi.From(debate_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, debate_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="stance_node_id"> </param>
        public async Task Stake(string stance_node_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 200, 17, 102 };
            var stance_node_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); stance_node_idAbi.From(stance_node_id);

            var result = await base.CallApp(new List<object> { abiHandle, stance_node_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Stake_Transactions(string stance_node_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 200, 17, 102 };
            var stance_node_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); stance_node_idAbi.From(stance_node_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, stance_node_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="winner_node_id"> </param>
        public async Task Settle(string winner_node_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 223, 234, 83 };
            var winner_node_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); winner_node_idAbi.From(winner_node_id);

            var result = await base.CallApp(new List<object> { abiHandle, winner_node_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Settle_Transactions(string winner_node_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 223, 234, 83 };
            var winner_node_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); winner_node_idAbi.From(winner_node_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, winner_node_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Claim(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 87, 119, 38 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Claim_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 87, 119, 38 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetPoolInfo(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 197, 170, 91, 157 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetPoolInfo_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 197, 170, 91, 157 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> GetWinner(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 178, 255, 139, 39 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetWinner_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 178, 255, 139, 39 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRGViYXRlU3Rha2UiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiaW5pdGlhbGl6ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZWJhdGVfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3Rha2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RhbmNlX25vZGVfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0dGxlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Indpbm5lcl9ub2RlX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNsYWltIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9wb29sX2luZm8iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF93aW5uZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6NH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMzE3XSwiZXJyb3JNZXNzYWdlIjoiQWxyZWFkeSBjbGFpbWVkIG9yIHplcm8gc3Rha2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjRdLCJlcnJvck1lc3NhZ2UiOiJBbHJlYWR5IHNldHRsZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTBdLCJlcnJvck1lc3NhZ2UiOiJBbHJlYWR5IHN0YWtlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3N10sImVycm9yTWVzc2FnZSI6IkRlYmF0ZSBhbHJlYWR5IHNldHRsZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDhdLCJlcnJvck1lc3NhZ2UiOiJNdXN0IHNlbmQgQUxHTyB0byBzdGFrZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5M10sImVycm9yTWVzc2FnZSI6Ik5vIHN0YWtlIGZvdW5kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzAzXSwiZXJyb3JNZXNzYWdlIjoiTm8gc3RhbmNlIGZvdW5kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjgxLDM1OF0sImVycm9yTWVzc2FnZSI6Ik5vdCBzZXR0bGVkIHlldCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1N10sImVycm9yTWVzc2FnZSI6Ik9ubHkgb3duZXIgY2FuIHNldHRsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwM10sImVycm9yTWVzc2FnZSI6IlBheSBtdXN0IGdvIHRvIGNvbnRyYWN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzExXSwiZXJyb3JNZXNzYWdlIjoiWW91IGJhY2tlZCB0aGUgd3Jvbmcgc2lkZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3NCwyNjEsMjc4LDM1NV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuaXNfc2V0dGxlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm93bmVyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyOSwzNDNdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX3Bvb2wgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzA5LDM2Ml0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYud2lubmVyX25vZGVfaWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE4LDE2MywyNDFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjUsMTcwLDI0OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTZdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnTWdvZ0lDQWdZbmwwWldOaWJHOWpheUFpYzJWMGRHeGxaQ0lnTUhnd01DQWljRzl2YkNJZ0luZHBibTVsY2lJZ0ltOTNibVZ5SWlBaWMxOGlJQ0owWHlJZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbFltRjBaVjl6ZEdGclpTOWpiMjUwY21GamRDNXdlVG94TlFvZ0lDQWdMeThnWTJ4aGMzTWdSR1ZpWVhSbFUzUmhhMlVvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o2SUcxaGFXNWZZM0psWVhSbFgwNXZUM0JBTVRFS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhobU5XTTRNVEUyTmlBd2VEWXdaR1psWVRVeklEQjRaakUxTnpjM01qWWdNSGhqTldGaE5XSTVaQ0F3ZUdJeVptWTRZakkzSUM4dklHMWxkR2h2WkNBaWMzUmhhMlVvYzNSeWFXNW5LWFp2YVdRaUxDQnRaWFJvYjJRZ0luTmxkSFJzWlNoemRISnBibWNwZG05cFpDSXNJRzFsZEdodlpDQWlZMnhoYVcwb0tYWnZhV1FpTENCdFpYUm9iMlFnSW1kbGRGOXdiMjlzWDJsdVptOG9LWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlaMlYwWDNkcGJtNWxjaWdwYzNSeWFXNW5JZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYzNSaGEyVWdjMlYwZEd4bElHTnNZV2x0SUdkbGRGOXdiMjlzWDJsdVptOGdaMlYwWDNkcGJtNWxjZ29nSUNBZ1pYSnlDZ3B0WVdsdVgyTnlaV0YwWlY5T2IwOXdRREV4T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsWW1GMFpWOXpkR0ZyWlM5amIyNTBjbUZqZEM1d2VUb3hOUW9nSUNBZ0x5OGdZMnhoYzNNZ1JHVmlZWFJsVTNSaGEyVW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdWalpqTXpPV1UzSUM4dklHMWxkR2h2WkNBaWFXNXBkR2xoYkdsNlpTaHpkSEpwYm1jcGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdsdWFYUnBZV3hwZW1VS0lDQWdJR1Z5Y2dvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWtaV0poZEdWZmMzUmhhMlV1WTI5dWRISmhZM1F1UkdWaVlYUmxVM1JoYTJVdWFXNXBkR2xoYkdsNlpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWx1YVhScFlXeHBlbVU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1ZpWVhSbFgzTjBZV3RsTDJOdmJuUnlZV04wTG5CNU9qSTJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb1lXeHNiM2RmWVdOMGFXOXVjejFiSWs1dlQzQWlYU3dnWTNKbFlYUmxQU0p5WlhGMWFYSmxJaWtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXSmhkR1ZmYzNSaGEyVXZZMjl1ZEhKaFkzUXVjSGs2TWpnS0lDQWdJQzh2SUhObGJHWXVaR1ZpWVhSbFgybGtMblpoYkhWbElEMGdaR1ZpWVhSbFgybGtDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltUmxZbUYwWlY5cFpDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVmlZWFJsWDNOMFlXdGxMMk52Ym5SeVlXTjBMbkI1T2pJNUNpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gzQnZiMnd1ZG1Gc2RXVWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbkJ2YjJ3aUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWldKaGRHVmZjM1JoYTJVdlkyOXVkSEpoWTNRdWNIazZNekFLSUNBZ0lDOHZJSE5sYkdZdWFYTmZjMlYwZEd4bFpDNTJZV3gxWlNBOUlHRnlZelF1UW05dmJDaEdZV3h6WlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5ObGRIUnNaV1FpQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWaVlYUmxYM04wWVd0bEwyTnZiblJ5WVdOMExuQjVPak14Q2lBZ0lDQXZMeUJ6Wld4bUxuZHBibTVsY2w5dWIyUmxYMmxrTG5aaGJIVmxJRDBnWVhKak5DNVRkSEpwYm1jb0lpSXBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSjNhVzV1WlhJaUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxZbUYwWlY5emRHRnJaUzlqYjI1MGNtRmpkQzV3ZVRvek1nb2dJQ0FnTHk4Z2MyVnNaaTV2ZDI1bGNpNTJZV3gxWlNBOUlGUjRiaTV6Wlc1a1pYSUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltOTNibVZ5SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaV0poZEdWZmMzUmhhMlV2WTI5dWRISmhZM1F1Y0hrNk1qWUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoaGJHeHZkMTloWTNScGIyNXpQVnNpVG05UGNDSmRMQ0JqY21WaGRHVTlJbkpsY1hWcGNtVWlLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1a1pXSmhkR1ZmYzNSaGEyVXVZMjl1ZEhKaFkzUXVSR1ZpWVhSbFUzUmhhMlV1YzNSaGEyVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6ZEdGclpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXSmhkR1ZmYzNSaGEyVXZZMjl1ZEhKaFkzUXVjSGs2TXpRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbFltRjBaVjl6ZEdGclpTOWpiMjUwY21GamRDNXdlVG96TmdvZ0lDQWdMeThnWVhOelpYSjBJRzV2ZENCelpXeG1MbWx6WDNObGRIUnNaV1F1ZG1Gc2RXVXNJQ0pFWldKaGRHVWdZV3h5WldGa2VTQnpaWFIwYkdWa0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5ObGRIUnNaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWFYTmZjMlYwZEd4bFpDQmxlR2x6ZEhNS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJFWldKaGRHVWdZV3h5WldGa2VTQnpaWFIwYkdWa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWaVlYUmxYM04wWVd0bEwyTnZiblJ5WVdOMExuQjVPak0zQ2lBZ0lDQXZMeUJqWVd4c1pYSWdQU0JoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWldKaGRHVmZjM1JoYTJVdlkyOXVkSEpoWTNRdWNIazZNemdLSUNBZ0lDOHZJR0Z6YzJWeWRDQmpZV3hzWlhJZ2JtOTBJR2x1SUhObGJHWXVjM1JoYTJWekxDQWlRV3h5WldGa2VTQnpkR0ZyWldRaUNpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKelh5SUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdRV3h5WldGa2VTQnpkR0ZyWldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWldKaGRHVmZjM1JoYTJVdlkyOXVkSEpoWTNRdWNIazZNemtLSUNBZ0lDOHZJSEJoZVNBOUlHZDBlRzR1VUdGNWJXVnVkRlJ5WVc1ellXTjBhVzl1S0RBcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1TQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1ZpWVhSbFgzTjBZV3RsTDJOdmJuUnlZV04wTG5CNU9qUXdDaUFnSUNBdkx5QmhjM05sY25RZ2NHRjVMbkpsWTJWcGRtVnlJRDA5SUVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zSUNKUVlYa2diWFZ6ZENCbmJ5QjBieUJqYjI1MGNtRmpkQ0lLSUNBZ0lHZDBlRzV6SUZKbFkyVnBkbVZ5Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlFZWGtnYlhWemRDQm5ieUIwYnlCamIyNTBjbUZqZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsWW1GMFpWOXpkR0ZyWlM5amIyNTBjbUZqZEM1d2VUb3pPUW9nSUNBZ0x5OGdjR0Y1SUQwZ1ozUjRiaTVRWVhsdFpXNTBWSEpoYm5OaFkzUnBiMjRvTUNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1ZpWVhSbFgzTjBZV3RsTDJOdmJuUnlZV04wTG5CNU9qUXhDaUFnSUNBdkx5QmhjM05sY25RZ2NHRjVMbUZ0YjNWdWRDQStJRlZKYm5RMk5DZ3dLU3dnSWsxMWMzUWdjMlZ1WkNCQlRFZFBJSFJ2SUhOMFlXdGxJZ29nSUNBZ1ozUjRibk1nUVcxdmRXNTBDaUFnSUNCa2RYQUtJQ0FnSUdGemMyVnlkQ0F2THlCTmRYTjBJSE5sYm1RZ1FVeEhUeUIwYnlCemRHRnJaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxZbUYwWlY5emRHRnJaUzlqYjI1MGNtRmpkQzV3ZVRvME1nb2dJQ0FnTHk4Z2MyVnNaaTV6ZEdGclpYTmJZMkZzYkdWeVhTQTlJSEJoZVM1aGJXOTFiblFLSUNBZ0lHUjFjQW9nSUNBZ2FYUnZZZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVmlZWFJsWDNOMFlXdGxMMk52Ym5SeVlXTjBMbkI1T2pRekNpQWdJQ0F2THlCelpXeG1Mbk4wWVc1alpYTmJZMkZzYkdWeVhTQTlJSE4wWVc1alpWOXViMlJsWDJsa0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKMFh5SUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWaVlYUmxYM04wWVd0bEwyTnZiblJ5WVdOMExuQjVPalEwQ2lBZ0lDQXZMeUJ6Wld4bUxuUnZkR0ZzWDNCdmIyd3VkbUZzZFdVZ1BTQnpaV3htTG5SdmRHRnNYM0J2YjJ3dWRtRnNkV1VnS3lCd1lYa3VZVzF2ZFc1MENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpY0c5dmJDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjNSaGJGOXdiMjlzSUdWNGFYTjBjd29nSUNBZ0t3b2dJQ0FnWW5sMFpXTmZNaUF2THlBaWNHOXZiQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1ZpWVhSbFgzTjBZV3RsTDJOdmJuUnlZV04wTG5CNU9qTTBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVaR1ZpWVhSbFgzTjBZV3RsTG1OdmJuUnlZV04wTGtSbFltRjBaVk4wWVd0bExuTmxkSFJzWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkSFJzWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWldKaGRHVmZjM1JoYTJVdlkyOXVkSEpoWTNRdWNIazZORFlLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsWW1GMFpWOXpkR0ZyWlM5amIyNTBjbUZqZEM1d2VUbzBPQW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNXZkMjVsY2k1MllXeDFaU3dnSWs5dWJIa2diM2R1WlhJZ1kyRnVJSE5sZEhSc1pTSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0p2ZDI1bGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV2ZDI1bGNpQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCdmQyNWxjaUJqWVc0Z2MyVjBkR3hsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1ZpWVhSbFgzTjBZV3RsTDJOdmJuUnlZV04wTG5CNU9qUTVDaUFnSUNBdkx5QmhjM05sY25RZ2JtOTBJSE5sYkdZdWFYTmZjMlYwZEd4bFpDNTJZV3gxWlN3Z0lrRnNjbVZoWkhrZ2MyVjBkR3hsWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p6WlhSMGJHVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1selgzTmxkSFJzWldRZ1pYaHBjM1J6Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURBS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRV3h5WldGa2VTQnpaWFIwYkdWa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWaVlYUmxYM04wWVd0bEwyTnZiblJ5WVdOMExuQjVPalV3Q2lBZ0lDQXZMeUJ6Wld4bUxtbHpYM05sZEhSc1pXUXVkbUZzZFdVZ1BTQmhjbU0wTGtKdmIyd29WSEoxWlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5ObGRIUnNaV1FpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGc0TUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWldKaGRHVmZjM1JoYTJVdlkyOXVkSEpoWTNRdWNIazZOVEVLSUNBZ0lDOHZJSE5sYkdZdWQybHVibVZ5WDI1dlpHVmZhV1F1ZG1Gc2RXVWdQU0IzYVc1dVpYSmZibTlrWlY5cFpBb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWQybHVibVZ5SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWldKaGRHVmZjM1JoYTJVdlkyOXVkSEpoWTNRdWNIazZORFlLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVrWldKaGRHVmZjM1JoYTJVdVkyOXVkSEpoWTNRdVJHVmlZWFJsVTNSaGEyVXVZMnhoYVcxYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpiR0ZwYlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWldKaGRHVmZjM1JoYTJVdlkyOXVkSEpoWTNRdWNIazZOVFVLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG1selgzTmxkSFJzWldRdWRtRnNkV1VzSUNKT2IzUWdjMlYwZEd4bFpDQjVaWFFpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWljMlYwZEd4bFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVwYzE5elpYUjBiR1ZrSUdWNGFYTjBjd29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3Q2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowSUM4dklFNXZkQ0J6WlhSMGJHVmtJSGxsZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsWW1GMFpWOXpkR0ZyWlM5amIyNTBjbUZqZEM1d2VUbzFOZ29nSUNBZ0x5OGdZMkZzYkdWeUlEMGdZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1ZpWVhSbFgzTjBZV3RsTDJOdmJuUnlZV04wTG5CNU9qVTNDaUFnSUNBdkx5QmhjM05sY25RZ1kyRnNiR1Z5SUdsdUlITmxiR1l1YzNSaGEyVnpMQ0FpVG04Z2MzUmhhMlVnWm05MWJtUWlDaUFnSUNCaWVYUmxZeUExSUM4dklDSnpYeUlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1RtOGdjM1JoYTJVZ1ptOTFibVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaV0poZEdWZmMzUmhhMlV2WTI5dWRISmhZM1F1Y0hrNk5UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCallXeHNaWElnYVc0Z2MyVnNaaTV6ZEdGdVkyVnpMQ0FpVG04Z2MzUmhibU5sSUdadmRXNWtJZ29nSUNBZ1lubDBaV01nTmlBdkx5QWlkRjhpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJPYnlCemRHRnVZMlVnWm05MWJtUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXSmhkR1ZmYzNSaGEyVXZZMjl1ZEhKaFkzUXVjSGs2TlRrS0lDQWdJQzh2SUdOaGJHeGxjbDl6ZEdGdVkyVmZZbmwwWlhNZ1BTQnpaV3htTG5OMFlXNWpaWE5iWTJGc2JHVnlYUzVpZVhSbGN3b2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVmlZWFJsWDNOMFlXdGxMMk52Ym5SeVlXTjBMbkI1T2pZd0NpQWdJQ0F2THlCM2FXNXVaWEpmWW5sMFpYTWdQU0J6Wld4bUxuZHBibTVsY2w5dWIyUmxYMmxrTG5aaGJIVmxMbUo1ZEdWekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUFpZDJsdWJtVnlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5kcGJtNWxjbDl1YjJSbFgybGtJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbFltRjBaVjl6ZEdGclpTOWpiMjUwY21GamRDNXdlVG8yTVFvZ0lDQWdMeThnWVhOelpYSjBJR05oYkd4bGNsOXpkR0Z1WTJWZllubDBaWE1nUFQwZ2QybHVibVZ5WDJKNWRHVnpMQ0FpV1c5MUlHSmhZMnRsWkNCMGFHVWdkM0p2Ym1jZ2MybGtaU0lLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1dXOTFJR0poWTJ0bFpDQjBhR1VnZDNKdmJtY2djMmxrWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsWW1GMFpWOXpkR0ZyWlM5amIyNTBjbUZqZEM1d2VUbzJNZ29nSUNBZ0x5OGdZMkZzYkdWeVgzTjBZV3RsSUQwZ2MyVnNaaTV6ZEdGclpYTmJZMkZzYkdWeVhRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXSmhkR1ZmYzNSaGEyVXZZMjl1ZEhKaFkzUXVjSGs2TmpNS0lDQWdJQzh2SUdGemMyVnlkQ0JqWVd4c1pYSmZjM1JoYTJVZ1BpQlZTVzUwTmpRb01Da3NJQ0pCYkhKbFlXUjVJR05zWVdsdFpXUWdiM0lnZW1WeWJ5QnpkR0ZyWlNJS0lDQWdJR1IxY0FvZ0lDQWdZWE56WlhKMElDOHZJRUZzY21WaFpIa2dZMnhoYVcxbFpDQnZjaUI2WlhKdklITjBZV3RsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1ZpWVhSbFgzTjBZV3RsTDJOdmJuUnlZV04wTG5CNU9qWTBDaUFnSUNBdkx5QnpaV3htTG5OMFlXdGxjMXRqWVd4c1pYSmRJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUnZZZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVmlZWFJsWDNOMFlXdGxMMk52Ym5SeVlXTjBMbkI1T2pZMUxUWTVDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJOVZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTlZMkZzYkdWeVgzTjBZV3RsTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVmlZWFJsWDNOMFlXdGxMMk52Ym5SeVlXTjBMbkI1T2pZMkNpQWdJQ0F2THlCeVpXTmxhWFpsY2oxVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJiVzkxYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWldKaGRHVmZjM1JoYTJVdlkyOXVkSEpoWTNRdWNIazZOalVLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJR2x1ZEdOZk1TQXZMeUJ3WVhrS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaV0poZEdWZmMzUmhhMlV2WTI5dWRISmhZM1F1Y0hrNk5qZ0tJQ0FnSUM4dklHWmxaVDFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaV0poZEdWZmMzUmhhMlV2WTI5dWRISmhZM1F1Y0hrNk5qVXROamtLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqMVVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDFqWVd4c1pYSmZjM1JoYTJVc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1ZpWVhSbFgzTjBZV3RsTDJOdmJuUnlZV04wTG5CNU9qVXpDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVaR1ZpWVhSbFgzTjBZV3RsTG1OdmJuUnlZV04wTGtSbFltRjBaVk4wWVd0bExtZGxkRjl3YjI5c1gybHVabTliY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZjRzl2YkY5cGJtWnZPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxZbUYwWlY5emRHRnJaUzlqYjI1MGNtRmpkQzV3ZVRvM013b2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1ZEc5MFlXeGZjRzl2YkM1MllXeDFaU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSndiMjlzSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnZkR0ZzWDNCdmIyd2daWGhwYzNSekNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWaVlYUmxYM04wWVd0bEwyTnZiblJ5WVdOMExuQjVPamN4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0o1ZEdWaklEY2dMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVaR1ZpWVhSbFgzTjBZV3RsTG1OdmJuUnlZV04wTGtSbFltRjBaVk4wWVd0bExtZGxkRjkzYVc1dVpYSmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZmQybHVibVZ5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsWW1GMFpWOXpkR0ZyWlM5amIyNTBjbUZqZEM1d2VUbzNOd29nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1YVhOZmMyVjBkR3hsWkM1MllXeDFaU3dnSWs1dmRDQnpaWFIwYkdWa0lIbGxkQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnpaWFIwYkdWa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbWx6WDNObGRIUnNaV1FnWlhocGMzUnpDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREFLSUNBZ0lDRTlDaUFnSUNCaGMzTmxjblFnTHk4Z1RtOTBJSE5sZEhSc1pXUWdlV1YwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1ZpWVhSbFgzTjBZV3RsTDJOdmJuUnlZV04wTG5CNU9qYzRDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVUZEhKcGJtY3Vabkp2YlY5aWVYUmxjeWh6Wld4bUxuZHBibTVsY2w5dWIyUmxYMmxrTG5aaGJIVmxMbUo1ZEdWektRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5kcGJtNWxjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1M2FXNXVaWEpmYm05a1pWOXBaQ0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXSmhkR1ZmYzNSaGEyVXZZMjl1ZEhKaFkzUXVjSGs2TnpVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWW5sMFpXTWdOeUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFEQUFFQ0pnZ0hjMlYwZEd4bFpBRUFCSEJ2YjJ3R2QybHVibVZ5Qlc5M2JtVnlBbk5mQW5SZkJCVWZmSFV4R1JSRU1SaEJBQ3VDQlFUMXlCRm1CR0RmNmxNRThWZDNKZ1RGcWx1ZEJMTC9peWMyR2dDT0JRQThBSW9Bc1FEeUFQNEFnQVRzOHpubk5ob0FqZ0VBQVFBMkdnRkpJbGtrQ0VzQkZSSkVnQWxrWldKaGRHVmZhV1JNWnlvaVp5Z3BaeXVBQWdBQVp5Y0VNUUJuSTBNMkdnRkpJbGtrQ0VzQkZSSkVJaWhsUkNrU1JERUFKd1ZMQVZCSnZVVUJGRVFpT0JBakVrUWlPQWN5Q2hKRUlqZ0lTVVJKRms4Q1RMOG5CazhDVUVtOFNFOEN2eUlxWlVRSUtreG5JME0yR2dGSklsa2tDRXNCRlJKRU1RQWlKd1JsUkJKRUlpaGxSQ2tTUkNpQUFZQm5LMHhuSTBNaUtHVkVLUk5FTVFBbkJVc0JVRW05UlFGRUp3WlBBbEJKdlVVQlJMNUlJaXRsUkJKRVNiNUlGMGxFSWhaUEFreS9zVEVBc2dleUNDT3lFQ0t5QWJNalF5SXFaVVFXSndkTVVMQWpReUlvWlVRcEUwUWlLMlZFSndkTVVMQWpRdz09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
