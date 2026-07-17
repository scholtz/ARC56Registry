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

namespace Arc56.Generated.LachTTT.ClaimCap.ClaimCap_2de92bf9
{


    public class ClaimCapProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ClaimCapProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="amount"> </param>
        public async Task<string> BuyNft(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 178, 15, 168, 118 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> BuyNft_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 178, 15, 168, 118 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="buyer"> </param>
        public async Task<string> SellNft(Algorand.Address buyer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 188, 126, 26, 73 };
            var buyerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); buyerAbi.From(buyer);

            var result = await base.CallApp(new List<object> { abiHandle, buyerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> SellNft_Transactions(Algorand.Address buyer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 188, 126, 26, 73 };
            var buyerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); buyerAbi.From(buyer);

            return await base.MakeTransactionList(new List<object> { abiHandle, buyerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> CheckHoldDays(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 173, 138, 228 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CheckHoldDays_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 173, 138, 228 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetClaimCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 50, 226, 141 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetClaimCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 50, 226, 141 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="name"> </param>
        public async Task<string> Hello(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 190, 206, 17 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Hello_Transactions(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 190, 206, 17 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ2xhaW1DYXAiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiYnV5X25mdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZWxsX25mdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYnV5ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjaGVja19ob2xkX2RheXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfY2xhaW1fY291bnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJoZWxsbyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjQsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls5NV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDldLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wICYmIGNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQzN10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuSE9MRF9QRVJJT0QgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjczXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5NQVhfQ0xBSU1TIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3MF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuUFJJQ0UgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjY5LDMwOCw1NTRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmNsYWltX2NvdW50IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzMiwzODEsNTMzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5vd25lcnMgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTY3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTc0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM3NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFS0lDQWdJR0o1ZEdWallteHZZMnNnSW1Oc1lXbHRYMk52ZFc1MElpQXdlREUxTVdZM1l6YzFJQ0p2ZDI1bGNuTWlJQ0pOUVZoZlEweEJTVTFUSWlBaVVGSkpRMFVpSUNKSVQweEVYMUJGVWtsUFJDSUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYkdGcGJXTmhjQzlqYjI1MGNtRmpkQzV3ZVRvNENpQWdJQ0F2THlCelpXeG1MbU5zWVdsdFgyTnZkVzUwSUQwZ1ZVbHVkRFkwS0RBcElDQWdJQ01nWTI5MWJuUmxjZ29nSUNBZ1lubDBaV05mTUNBdkx5QWlZMnhoYVcxZlkyOTFiblFpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiR0ZwYldOaGNDOWpiMjUwY21GamRDNXdlVG94TUFvZ0lDQWdMeThnYzJWc1ppNU5RVmhmUTB4QlNVMVRJRDBnVlVsdWREWTBLREV3TUNrS0lDQWdJR0o1ZEdWalh6TWdMeThnSWsxQldGOURURUZKVFZNaUNpQWdJQ0J3ZFhOb2FXNTBJREV3TUNBdkx5QXhNREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMnhoYVcxallYQXZZMjl1ZEhKaFkzUXVjSGs2TVRFS0lDQWdJQzh2SUhObGJHWXVVRkpKUTBVZ1BTQlZTVzUwTmpRb01UQXdNREF3S1FvZ0lDQWdZbmwwWldNZ05DQXZMeUFpVUZKSlEwVWlDaUFnSUNCd2RYTm9hVzUwSURFd01EQXdNQ0F2THlBeE1EQXdNREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMnhoYVcxallYQXZZMjl1ZEhKaFkzUXVjSGs2TVRJS0lDQWdJQzh2SUhObGJHWXVTRTlNUkY5UVJWSkpUMFFnUFNCVlNXNTBOalFvTXpBZ0tpQXlOQ0FxSURZd0lDb2dOakFwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0pJVDB4RVgxQkZVa2xQUkNJS0lDQWdJSEIxYzJocGJuUWdNalU1TWpBd01DQXZMeUF5TlRreU1EQXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJ4aGFXMWpZWEF2WTI5dWRISmhZM1F1Y0hrNk5Rb2dJQ0FnTHk4Z1kyeGhjM01nUTJ4aGFXMURZWEFvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM0I1WDJSbFptRjFiSFJmWTNKbFlYUmxRREUwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUcxMWMzUWdZbVVnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZUdJeU1HWmhPRGMySURCNFltTTNaVEZoTkRrZ01IaGlaR0ZrT0dGbE5DQXdlRFV3TXpKbE1qaGtJREI0TURKaVpXTmxNVEVnTHk4Z2JXVjBhRzlrSUNKaWRYbGZibVowS0hWcGJuUTJOQ2x6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJbk5sYkd4ZmJtWjBLR0ZrWkhKbGMzTXBjM1J5YVc1bklpd2diV1YwYUc5a0lDSmphR1ZqYTE5b2IyeGtYMlJoZVhNb0tYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVoyVjBYMk5zWVdsdFgyTnZkVzUwS0NsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1obGJHeHZLSE4wY21sdVp5bHpkSEpwYm1jaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmlkWGxmYm1aMElITmxiR3hmYm1aMElHTm9aV05yWDJodmJHUmZaR0Y1Y3lCblpYUmZZMnhoYVcxZlkyOTFiblFnYUdWc2JHOEtJQ0FnSUdWeWNnb0tiV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF4TkRvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCdGRYTjBJR0psSUU1dlQzQWdKaVlnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUdOeVpXRjBhVzVuQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtTnNZV2x0WTJGd0xtTnZiblJ5WVdOMExrTnNZV2x0UTJGd0xtSjFlVjl1Wm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGlkWGxmYm1aME9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYkdGcGJXTmhjQzlqYjI1MGNtRmpkQzV3ZVRveE5Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJ4aGFXMWpZWEF2WTI5dWRISmhZM1F1Y0hrNk1UWUtJQ0FnSUM4dklITmxibVJsY2lBOUlGUjRiaTV6Wlc1a1pYSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYkdGcGJXTmhjQzlqYjI1MGNtRmpkQzV3ZVRveE9Bb2dJQ0FnTHk4Z2FXWWdZVzF2ZFc1MElEd2djMlZzWmk1UVVrbERSVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSlFVa2xEUlNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNVFVa2xEUlNCbGVHbHpkSE1LSUNBZ0lEd0tJQ0FnSUdKNklHSjFlVjl1Wm5SZllXWjBaWEpmYVdaZlpXeHpaVUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMnhoYVcxallYQXZZMjl1ZEhKaFkzUXVjSGs2TVRrS0lDQWdJQzh2SUhKbGRIVnliaUJUZEhKcGJtY29JaUJPWldWa0lIUnZJSEJoZVNBd0xqRWdRVXhIVHlCMGJ5QmlkWGtnVGtaVUlTSXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpQk9aV1ZrSUhSdklIQmhlU0F3TGpFZ1FVeEhUeUIwYnlCaWRYa2dUa1pVSVNJS0NtSjFlVjl1Wm5SZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXVZMnhoYVcxallYQXVZMjl1ZEhKaFkzUXVRMnhoYVcxRFlYQXVZblY1WDI1bWRFQTRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnNZV2x0WTJGd0wyTnZiblJ5WVdOMExuQjVPakUwQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwaWRYbGZibVowWDJGbWRHVnlYMmxtWDJWc2MyVkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiR0ZwYldOaGNDOWpiMjUwY21GamRDNXdlVG95TVFvZ0lDQWdMeThnYVdZZ2MyVnNaaTV2ZDI1bGNuTmJjMlZ1WkdWeVhTQWhQU0JWU1c1ME5qUW9NQ2s2Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p2ZDI1bGNuTWlDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTXdvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWIzZHVaWEp6SUdWdWRISjVJR1Y0YVhOMGN3b2dJQ0FnWW5SdmFRb2dJQ0FnWW5vZ1luVjVYMjVtZEY5aFpuUmxjbDlwWmw5bGJITmxRRFVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiR0ZwYldOaGNDOWpiMjUwY21GamRDNXdlVG95TWdvZ0lDQWdMeThnY21WMGRYSnVJRk4wY21sdVp5Z2lJRmx2ZFNCaGJISmxZV1I1SUc5M2JpQmhiaUJPUmxRaElpa0tJQ0FnSUhCMWMyaGllWFJsY3lBaUlGbHZkU0JoYkhKbFlXUjVJRzkzYmlCaGJpQk9SbFFoSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5zWVdsdFkyRndMMk52Ym5SeVlXTjBMbkI1T2pFMENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdJZ1luVjVYMjVtZEY5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5NWpiR0ZwYldOaGNDNWpiMjUwY21GamRDNURiR0ZwYlVOaGNDNWlkWGxmYm1aMFFEZ0tDbUoxZVY5dVpuUmZZV1owWlhKZmFXWmZaV3h6WlVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOc1lXbHRZMkZ3TDJOdmJuUnlZV04wTG5CNU9qSTBDaUFnSUNBdkx5QmpiM1Z1ZENBOUlITmxiR1l1WTJ4aGFXMWZZMjkxYm5RS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pqYkdGcGJWOWpiM1Z1ZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWpiR0ZwYlY5amIzVnVkQ0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amJHRnBiV05oY0M5amIyNTBjbUZqZEM1d2VUb3lOUW9nSUNBZ0x5OGdhV1lnWTI5MWJuUWdQajBnYzJWc1ppNU5RVmhmUTB4QlNVMVRPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0lrMUJXRjlEVEVGSlRWTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1VFVGWVgwTk1RVWxOVXlCbGVHbHpkSE1LSUNBZ0lENDlDaUFnSUNCaWVpQmlkWGxmYm1aMFgyRm1kR1Z5WDJsbVgyVnNjMlZBTndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5zWVdsdFkyRndMMk52Ym5SeVlXTjBMbkI1T2pJMkNpQWdJQ0F2THlCeVpYUjFjbTRnVTNSeWFXNW5LQ0lnUVd4c0lFNUdWSE1nYzI5c1pDRWlLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSWdRV3hzSUU1R1ZITWdjMjlzWkNFaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJ4aGFXMWpZWEF2WTI5dWRISmhZM1F1Y0hrNk1UUUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ1lpQmlkWGxmYm1aMFgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbU5zWVdsdFkyRndMbU52Ym5SeVlXTjBMa05zWVdsdFEyRndMbUoxZVY5dVpuUkFPQW9LWW5WNVgyNW1kRjloWm5SbGNsOXBabDlsYkhObFFEYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyeGhhVzFqWVhBdlkyOXVkSEpoWTNRdWNIazZNamdLSUNBZ0lDOHZJSE5sYkdZdWIzZHVaWEp6VzNObGJtUmxjbDBnUFNCSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQW9nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ2FYUnZZZ29nSUNBZ1pHbG5JRElLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYkdGcGJXTmhjQzlqYjI1MGNtRmpkQzV3ZVRveU9Rb2dJQ0FnTHk4Z2MyVnNaaTVqYkdGcGJWOWpiM1Z1ZENBclBTQXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVkyeGhhVzFmWTI5MWJuUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WTJ4aGFXMWZZMjkxYm5RZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVkyeGhhVzFmWTI5MWJuUWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnNZV2x0WTJGd0wyTnZiblJ5WVdOMExuQjVPak15Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdVM1J5YVc1bktDSWdUa1pVSUhCMWNtTm9ZWE5sWkNFZ1dXOTFJRzExYzNRZ2FHOXNaQ0JwZENCbWIzSWdNekFnWkdGNWN5NGlLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSWdUa1pVSUhCMWNtTm9ZWE5sWkNFZ1dXOTFJRzExYzNRZ2FHOXNaQ0JwZENCbWIzSWdNekFnWkdGNWN5NGlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyeGhhVzFqWVhBdlkyOXVkSEpoWTNRdWNIazZNVFFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZaUJpZFhsZmJtWjBYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TG1Oc1lXbHRZMkZ3TG1OdmJuUnlZV04wTGtOc1lXbHRRMkZ3TG1KMWVWOXVablJBT0FvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWpiR0ZwYldOaGNDNWpiMjUwY21GamRDNURiR0ZwYlVOaGNDNXpaV3hzWDI1bWRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sYkd4ZmJtWjBPZ29nSUNBZ2NIVnphR0o1ZEdWeklDSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyeGhhVzFqWVhBdlkyOXVkSEpoWTNRdWNIazZNelFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ016SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOc1lXbHRZMkZ3TDJOdmJuUnlZV04wTG5CNU9qTTRDaUFnSUNBdkx5QndkWEpqYUdGelpWOTBhVzFsSUQwZ2MyVnNaaTV2ZDI1bGNuTmJjMlZ1WkdWeVhRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWIzZHVaWEp6SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5zWVdsdFkyRndMMk52Ym5SeVlXTjBMbkI1T2pNMkNpQWdJQ0F2THlCelpXNWtaWElnUFNCVWVHNHVjMlZ1WkdWeUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMnhoYVcxallYQXZZMjl1ZEhKaFkzUXVjSGs2TXpnS0lDQWdJQzh2SUhCMWNtTm9ZWE5sWDNScGJXVWdQU0J6Wld4bUxtOTNibVZ5YzF0elpXNWtaWEpkQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWIzZHVaWEp6SUdWdWRISjVJR1Y0YVhOMGN3b2dJQ0FnWW5SdmFRb2dJQ0FnWkhWd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJ4aGFXMWpZWEF2WTI5dWRISmhZM1F1Y0hrNk5EQUtJQ0FnSUM4dklHbG1JSEIxY21Ob1lYTmxYM1JwYldVZ1BUMGdWVWx1ZERZMEtEQXBPZ29nSUNBZ1ltNTZJSE5sYkd4ZmJtWjBYMkZtZEdWeVgybG1YMlZzYzJWQU13b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOc1lXbHRZMkZ3TDJOdmJuUnlZV04wTG5CNU9qUXhDaUFnSUNBdkx5QnlaWFIxY200Z1UzUnlhVzVuS0NJZ1dXOTFJR1J2YmlkMElHOTNiaUJoYmlCT1JsUXVJaWtLSUNBZ0lIQjFjMmhpZVhSbGN5QWlJRmx2ZFNCa2IyNG5kQ0J2ZDI0Z1lXNGdUa1pVTGlJS0NuTmxiR3hmYm1aMFgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbU5zWVdsdFkyRndMbU52Ym5SeVlXTjBMa05zWVdsdFEyRndMbk5sYkd4ZmJtWjBRRFk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMnhoYVcxallYQXZZMjl1ZEhKaFkzUXVjSGs2TXpRS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NuTmxiR3hmYm1aMFgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYkdGcGJXTmhjQzlqYjI1MGNtRmpkQzV3ZVRvME13b2dJQ0FnTHk4Z2JtOTNJRDBnUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQUtJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQTFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyeGhhVzFqWVhBdlkyOXVkSEpoWTNRdWNIazZORFFLSUNBZ0lDOHZJR2xtSUc1dmR5QXRJSEIxY21Ob1lYTmxYM1JwYldVZ1BDQnpaV3htTGtoUFRFUmZVRVZTU1U5RU9nb2dJQ0FnWkdsbklERUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0pJVDB4RVgxQkZVa2xQUkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNUlUMHhFWDFCRlVrbFBSQ0JsZUdsemRITUtJQ0FnSUR3S0lDQWdJR0o2SUhObGJHeGZibVowWDJGbWRHVnlYMmxtWDJWc2MyVkFOUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnNZV2x0WTJGd0wyTnZiblJ5WVdOMExuQjVPalExQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdVM1J5YVc1bktDSWdTRzlzWkNCd1pYSnBiMlFnS0RNd0lHUmhlWE1wSUc1dmRDQm1hVzVwYzJobFpDQjVaWFFoSWlrS0lDQWdJSEIxYzJoaWVYUmxjeUFpSUVodmJHUWdjR1Z5YVc5a0lDZ3pNQ0JrWVhsektTQnViM1FnWm1sdWFYTm9aV1FnZVdWMElTSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amJHRnBiV05oY0M5amIyNTBjbUZqZEM1d2VUb3pOQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmlJSE5sYkd4ZmJtWjBYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TG1Oc1lXbHRZMkZ3TG1OdmJuUnlZV04wTGtOc1lXbHRRMkZ3TG5ObGJHeGZibVowUURZS0NuTmxiR3hmYm1aMFgyRm1kR1Z5WDJsbVgyVnNjMlZBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYkdGcGJXTmhjQzlqYjI1MGNtRmpkQzV3ZVRvME53b2dJQ0FnTHk4Z2MyVnNaaTV2ZDI1bGNuTmJZblY1WlhKZllubDBaWE5kSUQwZ2JtOTNDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnZkMjVsY25NaUNpQWdJQ0JrYVdjZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dOQW9nSUNBZ2FYUnZZZ29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5zWVdsdFkyRndMMk52Ym5SeVlXTjBMbkI1T2pRNENpQWdJQ0F2THlCelpXeG1MbTkzYm1WeWMxdHpaVzVrWlhKZElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSdllnb2dJQ0FnWkdsbklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiR0ZwYldOaGNDOWpiMjUwY21GamRDNXdlVG8wT1FvZ0lDQWdMeThnY21WMGRYSnVJRk4wY21sdVp5Z2lUa1pVSUhOdmJHUWdjM1ZqWTJWemMyWjFiR3g1SVNJcENpQWdJQ0J3ZFhOb1lubDBaWE1nSWs1R1ZDQnpiMnhrSUhOMVkyTmxjM05tZFd4c2VTRWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyeGhhVzFqWVhBdlkyOXVkSEpoWTNRdWNIazZNelFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZaUJ6Wld4c1gyNW1kRjloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k1amJHRnBiV05oY0M1amIyNTBjbUZqZEM1RGJHRnBiVU5oY0M1elpXeHNYMjVtZEVBMkNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbU5zWVdsdFkyRndMbU52Ym5SeVlXTjBMa05zWVdsdFEyRndMbU5vWldOclgyaHZiR1JmWkdGNWMxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU5vWldOclgyaHZiR1JmWkdGNWN6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amJHRnBiV05oY0M5amIyNTBjbUZqZEM1d2VUbzFOQW9nSUNBZ0x5OGdjSFZ5WTJoaGMyVmZkR2x0WlNBOUlITmxiR1l1YjNkdVpYSnpXM05sYm1SbGNsMEtJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltOTNibVZ5Y3lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYkdGcGJXTmhjQzlqYjI1MGNtRmpkQzV3ZVRvMU13b2dJQ0FnTHk4Z2MyVnVaR1Z5SUQwZ1ZIaHVMbk5sYm1SbGNnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5zWVdsdFkyRndMMk52Ym5SeVlXTjBMbkI1T2pVMENpQWdJQ0F2THlCd2RYSmphR0Z6WlY5MGFXMWxJRDBnYzJWc1ppNXZkMjVsY25OYmMyVnVaR1Z5WFFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXZkMjVsY25NZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNCaWRHOXBDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amJHRnBiV05oY0M5amIyNTBjbUZqZEM1d2VUbzFOUW9nSUNBZ0x5OGdhV1lnY0hWeVkyaGhjMlZmZEdsdFpTQTlQU0JWU1c1ME5qUW9NQ2s2Q2lBZ0lDQmlibm9nWTJobFkydGZhRzlzWkY5a1lYbHpYMkZtZEdWeVgybG1YMlZzYzJWQU13b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOc1lXbHRZMkZ3TDJOdmJuUnlZV04wTG5CNU9qVTJDaUFnSUNBdkx5QnlaWFIxY200Z1ZVbHVkRFkwS0RBcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvS1kyaGxZMnRmYUc5c1pGOWtZWGx6WDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekxtTnNZV2x0WTJGd0xtTnZiblJ5WVdOMExrTnNZV2x0UTJGd0xtTm9aV05yWDJodmJHUmZaR0Y1YzBBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOc1lXbHRZMkZ3TDJOdmJuUnlZV04wTG5CNU9qVXhDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ21Ob1pXTnJYMmh2YkdSZlpHRjVjMTloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amJHRnBiV05oY0M5amIyNTBjbUZqZEM1d2VUbzFNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmlJR05vWldOclgyaHZiR1JmWkdGNWMxOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTVqYkdGcGJXTmhjQzVqYjI1MGNtRmpkQzVEYkdGcGJVTmhjQzVqYUdWamExOW9iMnhrWDJSaGVYTkFOQW9LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1amJHRnBiV05oY0M1amIyNTBjbUZqZEM1RGJHRnBiVU5oY0M1blpYUmZZMnhoYVcxZlkyOTFiblJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZZMnhoYVcxZlkyOTFiblE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMnhoYVcxallYQXZZMjl1ZEhKaFkzUXVjSGs2TmpFS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxtTnNZV2x0WDJOdmRXNTBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVkyeGhhVzFmWTI5MWJuUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WTJ4aGFXMWZZMjkxYm5RZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMnhoYVcxallYQXZZMjl1ZEhKaFkzUXVjSGs2TlRrS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVqYkdGcGJXTmhjQzVqYjI1MGNtRmpkQzVEYkdGcGJVTmhjQzVvWld4c2IxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWhsYkd4dk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOc1lXbHRZMkZ3TDJOdmJuUnlZV04wTG5CNU9qWXpDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VXdNREk1TkRnMk5UWmpObU0yWmpJd04ySTJaVFl4Tm1RMk5UZGtNakV5TURVM05qVTJZell6Tm1ZMlpEWTFNakEzTkRabU1qQTBNelpqTmpFMk9UWmtORE0yTVRjd01qQTBaRFl4TnpJMllqWTFOelF5TUFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFDQUFFbUJndGpiR0ZwYlY5amIzVnVkQVFWSDN4MUJtOTNibVZ5Y3dwTlFWaGZRMHhCU1UxVEJWQlNTVU5GQzBoUFRFUmZVRVZTU1U5RU1SaEFBQllvSW1jcmdXUm5Kd1NCb0kwR1p5Y0ZnWUNhbmdGbk1SdEJBREl4R1JSRU1SaEVnZ1VFc2crb2RnUzhmaHBKQkwydGl1UUVVRExpalFRQ3ZzNFJOaG9BamdVQUN3RGZBWU1CbWdHbEFERVpGREVZRkJCRUkwTWlOaG9CU1JXQkNCSkVGekVBVENJbkJHVkVERUVBTVlBaElFNWxaV1FnZEc4Z2NHRjVJREF1TVNCQlRFZFBJSFJ2SUdKMWVTQk9SbFFoU1JVV1Z3WUNURkFwVEZDd0kwTXFTd0ZRU1VVRHZrUVhRUUFkZ0JnZ1dXOTFJR0ZzY21WaFpIa2diM2R1SUdGdUlFNUdWQ0ZDLzhnaUtHVkVJaXRsUkE5QkFCU0FEeUJCYkd3Z1RrWlVjeUJ6YjJ4a0lVTC9xRElIRmtzQ1RMOGlLR1ZFSXdnb1RHZUFMU0JPUmxRZ2NIVnlZMmhoYzJWa0lTQlpiM1VnYlhWemRDQm9iMnhrSUdsMElHWnZjaUF6TUNCa1lYbHpMa0wvWm9BQU5ob0JTUldCSUJKRUtqRUFVRW0rUkJkSlFBQW1nQllnV1c5MUlHUnZiaWQwSUc5M2JpQmhiaUJPUmxRdVNSVVdWd1lDVEZBcFRGQ3dJME15QjBsRkJVc0JDU0luQldWRURFRUFMWUFvSUVodmJHUWdjR1Z5YVc5a0lDZ3pNQ0JrWVhsektTQnViM1FnWm1sdWFYTm9aV1FnZVdWMElVTC90Q3BMQTFCTEJCYS9JaFpMQWt5L2dCWk9SbFFnYzI5c1pDQnpkV05qWlhOelpuVnNiSGtoUXYrTEtqRUFVTDVFRjBsQUFBZ2lGaWxNVUxBalEwbEMvL1VpS0dWRUZpbE1VTEFqUXpZYUFVa2lXWUVDQ0V3VkVrU0FMeFVmZkhVQUtVaGxiR3h2SUh0dVlXMWxmU0VnVjJWc1kyOXRaU0IwYnlCRGJHRnBiVU5oY0NCTllYSnJaWFFnc0NORCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjQsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
