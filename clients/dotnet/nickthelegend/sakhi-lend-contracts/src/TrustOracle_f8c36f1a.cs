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

namespace Arc56.Generated.nickthelegend.sakhi_lend_contracts.TrustOracle_f8c36f1a
{


    public class TrustOracleProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TrustOracleProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Attests to a user's creditworthiness with a TTF score.
        ///Admin only. Requires MBR payment for boxes.
        ///</summary>
        /// <param name="user"> </param>
        /// <param name="score"> </param>
        /// <param name="mbrPayment"> </param>
        public async Task Attest(PaymentTransaction mbrPayment, Algorand.Address user, ulong score, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment });
            byte[] abiHandle = { 239, 83, 17, 156 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); scoreAbi.From(score);

            var result = await base.CallApp(new List<object> { abiHandle, userAbi, scoreAbi, mbrPayment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Attest_Transactions(PaymentTransaction mbrPayment, Algorand.Address user, ulong score, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment });
            byte[] abiHandle = { 239, 83, 17, 156 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); scoreAbi.From(score);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi, scoreAbi, mbrPayment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Revokes a user's verification status.
        ///Admin only.
        ///</summary>
        /// <param name="user"> </param>
        public async Task RevokeAttestation(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 102, 2, 249 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            var result = await base.CallApp(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RevokeAttestation_Transactions(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 102, 2, 249 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns a user's score.
        ///</summary>
        /// <param name="user"> </param>
        public async Task<ulong> GetScore(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 131, 69, 209 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            var result = await base.CallApp(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetScore_Transactions(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 131, 69, 209 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns whether a user is verified.
        ///</summary>
        /// <param name="user"> </param>
        public async Task<bool> IsVerified(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 30, 212, 116 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            var result = await base.CallApp(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsVerified_Transactions(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 30, 212, 116 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVHJ1c3RPcmFjbGUiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXR0ZXN0IiwiZGVzYyI6IkF0dGVzdHMgdG8gYSB1c2VyJ3MgY3JlZGl0d29ydGhpbmVzcyB3aXRoIGEgVFRGIHNjb3JlLlxuQWRtaW4gb25seS4gUmVxdWlyZXMgTUJSIHBheW1lbnQgZm9yIGJveGVzLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2NvcmUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1iclBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmV2b2tlQXR0ZXN0YXRpb24iLCJkZXNjIjoiUmV2b2tlcyBhIHVzZXIncyB2ZXJpZmljYXRpb24gc3RhdHVzLlxuQWRtaW4gb25seS4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0U2NvcmUiLCJkZXNjIjoiUmV0dXJucyBhIHVzZXIncyBzY29yZS4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc1ZlcmlmaWVkIiwiZGVzYyI6IlJldHVybnMgd2hldGhlciBhIHVzZXIgaXMgdmVyaWZpZWQuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTcwLDI4M10sImVycm9yTWVzc2FnZSI6IkFkbWluIG9ubHkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDZdLCJlcnJvck1lc3NhZ2UiOiJJbnN1ZmZpY2llbnQgTUJSIGZvciBib3hlcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5OF0sImVycm9yTWVzc2FnZSI6Ik1CUiB0byBvcmFjbGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzddLCJlcnJvck1lc3NhZ2UiOiJTY29yZSBtdXN0IGJlIDw9IDEwMDAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTcsMjcwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTMxLDI2NCwzMzUsMzYyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MV0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3SURNeUNpQWdJQ0JpZVhSbFkySnNiMk5ySUNKamNtVmhkRzl5SWlBaWN5SWdJbllpSUdKaGMyVXpNaWhNUlVkRlRrUk5VVkZLU2xkVFVWWklVa1pMTXpaRlVEZEhWRTB6VFZSSk0xWkVNMGRPTWpWWlRVdEtOazFGUWxJek5VcFJLU0F3ZURFMU1XWTNZemMxQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmIzSmhZMnhsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRZS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlVjblZ6ZEU5eVlXTnNaU0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYlhWemRDQmlaU0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lub2diV0ZwYmw5amNtVmhkR1ZmVG05UGNFQTRDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRaV1kxTXpFeE9XTWdNSGhpT0RZMk1ESm1PU0F3ZURrM09ETTBOV1F4SURCNFpUTXhaV1EwTnpRZ0x5OGdiV1YwYUc5a0lDSmhkSFJsYzNRb1lXUmtjbVZ6Y3l4MWFXNTBOalFzY0dGNUtYWnZhV1FpTENCdFpYUm9iMlFnSW5KbGRtOXJaVUYwZEdWemRHRjBhVzl1S0dGa1pISmxjM01wZG05cFpDSXNJRzFsZEdodlpDQWlaMlYwVTJOdmNtVW9ZV1JrY21WemN5bDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltbHpWbVZ5YVdacFpXUW9ZV1JrY21WemN5bGliMjlzSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1lYUjBaWE4wSUhKbGRtOXJaVUYwZEdWemRHRjBhVzl1SUdkbGRGTmpiM0psSUdselZtVnlhV1pwWldRS0lDQWdJR1Z5Y2dvS2JXRnBibDlqY21WaGRHVmZUbTlQY0VBNE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYMjl5WVdOc1pTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVkhKMWMzUlBjbUZqYkdVZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoaU9EUTBOMkl6TmlBdkx5QnRaWFJvYjJRZ0ltTnlaV0YwWlVGd2NHeHBZMkYwYVc5dUtDbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1kzSmxZWFJsUVhCd2JHbGpZWFJwYjI0S0lDQWdJR1Z5Y2dvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5dmNtRmpiR1V2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VkhKMWMzUlBjbUZqYkdVdVkzSmxZWFJsUVhCd2JHbGpZWFJwYjI1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpjbVZoZEdWQmNIQnNhV05oZEdsdmJqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjl2Y21GamJHVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPQW9nSUNBZ0x5OGdjSFZpYkdsaklHTnlaV0YwYjNJZ1BTQkhiRzlpWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWdwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pqY21WaGRHOXlJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDI5eVlXTnNaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak13Q2lBZ0lDQXZMeUIwYUdsekxtTnlaV0YwYjNJdWRtRnNkV1VnUFNCVWVHNHVjMlZ1WkdWeUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgyOXlZV05zWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNUNpQWdJQ0F2THlCd2RXSnNhV01nWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRvS1RvZ2RtOXBaQ0I3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDI5eVlXTnNaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBVY25WemRFOXlZV05zWlM1aGRIUmxjM1JiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaGRIUmxjM1E2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDI5eVlXTnNaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0zQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZWFIwWlhOMEtIVnpaWEk2SUVGalkyOTFiblFzSUhOamIzSmxPaUIxYVc1ME5qUXNJRzFpY2xCaGVXMWxiblE2SUdkMGVHNHVVR0Y1YldWdWRGUjRiaWs2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QndZWGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QndZWGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5dmNtRmpiR1V2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96T0FvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlIUm9hWE11WTNKbFlYUnZjaTUyWVd4MVpTQjhmQ0JVZUc0dWMyVnVaR1Z5SUQwOVBTQnVaWGNnWVhKak5DNUJaR1J5WlhOektDSk1SVWRGVGtSTlVWRktTbGRUVVZaSVVrWkxNelpGVURkSFZFMHpUVlJKTTFaRU0wZE9NalZaVFV0S05rMUZRbEl6TlVvMFUwSk9Wa1EwSWlrdWJtRjBhWFpsTENBblFXUnRhVzRnYjI1c2VTY3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgyOXlZV05zWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNENpQWdJQ0F2THlCd2RXSnNhV01nWTNKbFlYUnZjaUE5SUVkc2IySmhiRk4wWVhSbFBFRmpZMjkxYm5RK0tDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltTnlaV0YwYjNJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZiM0poWTJ4bEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16Z0tJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0IwYUdsekxtTnlaV0YwYjNJdWRtRnNkV1VnZkh3Z1ZIaHVMbk5sYm1SbGNpQTlQVDBnYm1WM0lHRnlZelF1UVdSa2NtVnpjeWdpVEVWSFJVNUVUVkZSU2twWFUxRldTRkpHU3pNMlJWQTNSMVJOTTAxVVNUTldSRE5IVGpJMVdVMUxTalpOUlVKU016VktORk5DVGxaRU5DSXBMbTVoZEdsMlpTd2dKMEZrYldsdUlHOXViSGtuS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaWJub2dZWFIwWlhOMFgySnZiMnhmZEhKMVpVQXpDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JpZVhSbFkxOHpJQzh2SUdGa1pISWdURVZIUlU1RVRWRlJTa3BYVTFGV1NGSkdTek0yUlZBM1IxUk5NMDFVU1ROV1JETkhUakkxV1UxTFNqWk5SVUpTTXpWS05GTkNUbFpFTkFvZ0lDQWdQVDBLSUNBZ0lHSjZJR0YwZEdWemRGOWliMjlzWDJaaGJITmxRRFFLQ21GMGRHVnpkRjlpYjI5c1gzUnlkV1ZBTXpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2dwaGRIUmxjM1JmWW05dmJGOXRaWEpuWlVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYMjl5WVdOc1pTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTRDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnZEdocGN5NWpjbVZoZEc5eUxuWmhiSFZsSUh4OElGUjRiaTV6Wlc1a1pYSWdQVDA5SUc1bGR5QmhjbU0wTGtGa1pISmxjM01vSWt4RlIwVk9SRTFSVVVwS1YxTlJWa2hTUmtzek5rVlFOMGRVVFROTlZFa3pWa1F6UjA0eU5WbE5TMG8yVFVWQ1VqTTFTalJUUWs1V1JEUWlLUzV1WVhScGRtVXNJQ2RCWkcxcGJpQnZibXg1SnlrS0lDQWdJR0Z6YzJWeWRDQXZMeUJCWkcxcGJpQnZibXg1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmIzSmhZMnhsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXprS0lDQWdJQzh2SUdGemMyVnlkQ2h6WTI5eVpTQThQU0F4TURBd0xDQW5VMk52Y21VZ2JYVnpkQ0JpWlNBOFBTQXhNREF3SnlrS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJREV3TURBZ0x5OGdNVEF3TUFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlRZMjl5WlNCdGRYTjBJR0psSUR3OUlERXdNREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5dmNtRmpiR1V2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TVFvZ0lDQWdMeThnY0hWaWJHbGpJSE5qYjNKbGN5QTlJRUp2ZUUxaGNEeEJZMk52ZFc1MExDQjFhVzUwTmpRK0tIc2dhMlY1VUhKbFptbDRPaUFuY3ljZ2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luTWlDaUFnSUNCa2FXY2dNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgyOXlZV05zWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pReUNpQWdJQ0F2THlCcFppQW9JWFJvYVhNdWMyTnZjbVZ6S0hWelpYSXBMbVY0YVhOMGN5a2dld29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpYm5vZ1lYUjBaWE4wWDJGbWRHVnlYMmxtWDJWc2MyVkFOd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDI5eVlXTnNaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalEwQ2lBZ0lDQXZMeUJoYzNObGNuUW9iV0p5VUdGNWJXVnVkQzV5WldObGFYWmxjaUE5UFQwZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zSUNkTlFsSWdkRzhnYjNKaFkyeGxKeWtLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdaM1I0Ym5NZ1VtVmpaV2wyWlhJS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTFDVWlCMGJ5QnZjbUZqYkdVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOXZjbUZqYkdVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME5Rb2dJQ0FnTHk4Z1lYTnpaWEowS0cxaWNsQmhlVzFsYm5RdVlXMXZkVzUwSUQ0OUlFSlBXRjlOUWxJZ0tpQXpMQ0FuU1c1emRXWm1hV05wWlc1MElFMUNVaUJtYjNJZ1ltOTRaWE1uS1FvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2lBZ0lDQndkWE5vYVc1MElETTROVFV3TUNBdkx5QXpPRFUxTURBS0lDQWdJRDQ5Q2lBZ0lDQmhjM05sY25RZ0x5OGdTVzV6ZFdabWFXTnBaVzUwSUUxQ1VpQm1iM0lnWW05NFpYTUtDbUYwZEdWemRGOWhablJsY2w5cFpsOWxiSE5sUURjNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZiM0poWTJ4bEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EZ0tJQ0FnSUM4dklIUm9hWE11YzJOdmNtVnpLSFZ6WlhJcExuWmhiSFZsSUQwZ2MyTnZjbVVLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnTkFvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYMjl5WVdOc1pTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXpDaUFnSUNBdkx5QndkV0pzYVdNZ2RtVnlhV1pwWldRZ1BTQkNiM2hOWVhBOFFXTmpiM1Z1ZEN3Z1ltOXZiR1ZoYmo0b2V5QnJaWGxRY21WbWFYZzZJQ2QySnlCOUtRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWRpSUtJQ0FnSUdScFp5QXpDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgyOXlZV05zWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRNUNpQWdJQ0F2THlCMGFHbHpMblpsY21sbWFXVmtLSFZ6WlhJcExuWmhiSFZsSUQwZ2RISjFaUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdsMGIySUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5dmNtRmpiR1V2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTUFvZ0lDQWdMeThnZEdocGN5NWhkSFJsYzNSbFpFRjBLSFZ6WlhJcExuWmhiSFZsSUQwZ1IyeHZZbUZzTG5KdmRXNWtDaUFnSUNCbmJHOWlZV3dnVW05MWJtUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjl2Y21GamJHVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOUW9nSUNBZ0x5OGdjSFZpYkdsaklHRjBkR1Z6ZEdWa1FYUWdQU0JDYjNoTllYQThRV05qYjNWdWRDd2dkV2x1ZERZMFBpaDdJR3RsZVZCeVpXWnBlRG9nSjJFbklIMHBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltRWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYMjl5WVdOc1pTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVXdDaUFnSUNBdkx5QjBhR2x6TG1GMGRHVnpkR1ZrUVhRb2RYTmxjaWt1ZG1Gc2RXVWdQU0JIYkc5aVlXd3VjbTkxYm1RS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjl2Y21GamJHVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFNZ29nSUNBZ0x5OGdiRzluS0NkVlUwVlNYMEZVVkVWVFZFVkVKeWtLSUNBZ0lIQjFjMmhpZVhSbGN5QWlWVk5GVWw5QlZGUkZVMVJGUkNJS0lDQWdJR3h2WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgyOXlZV05zWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNM0NpQWdJQ0F2THlCd2RXSnNhV01nWVhSMFpYTjBLSFZ6WlhJNklFRmpZMjkxYm5Rc0lITmpiM0psT2lCMWFXNTBOalFzSUcxaWNsQmhlVzFsYm5RNklHZDBlRzR1VUdGNWJXVnVkRlI0YmlrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS1lYUjBaWE4wWDJKdmIyeGZabUZzYzJWQU5Eb0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpSUdGMGRHVnpkRjlpYjI5c1gyMWxjbWRsUURVS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmIzSmhZMnhsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xSeWRYTjBUM0poWTJ4bExuSmxkbTlyWlVGMGRHVnpkR0YwYVc5dVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVYyYjJ0bFFYUjBaWE4wWVhScGIyNDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmYjNKaFkyeGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVGtLSUNBZ0lDOHZJSEIxWW14cFl5QnlaWFp2YTJWQmRIUmxjM1JoZEdsdmJpaDFjMlZ5T2lCQlkyTnZkVzUwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5dmNtRmpiR1V2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTUFvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlIUm9hWE11WTNKbFlYUnZjaTUyWVd4MVpTQjhmQ0JVZUc0dWMyVnVaR1Z5SUQwOVBTQnVaWGNnWVhKak5DNUJaR1J5WlhOektDSk1SVWRGVGtSTlVWRktTbGRUVVZaSVVrWkxNelpGVURkSFZFMHpUVlJKTTFaRU0wZE9NalZaVFV0S05rMUZRbEl6TlVvMFUwSk9Wa1EwSWlrdWJtRjBhWFpsTENBblFXUnRhVzRnYjI1c2VTY3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgyOXlZV05zWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNENpQWdJQ0F2THlCd2RXSnNhV01nWTNKbFlYUnZjaUE5SUVkc2IySmhiRk4wWVhSbFBFRmpZMjkxYm5RK0tDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltTnlaV0YwYjNJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZiM0poWTJ4bEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qQUtJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0IwYUdsekxtTnlaV0YwYjNJdWRtRnNkV1VnZkh3Z1ZIaHVMbk5sYm1SbGNpQTlQVDBnYm1WM0lHRnlZelF1UVdSa2NtVnpjeWdpVEVWSFJVNUVUVkZSU2twWFUxRldTRkpHU3pNMlJWQTNSMVJOTTAxVVNUTldSRE5IVGpJMVdVMUxTalpOUlVKU016VktORk5DVGxaRU5DSXBMbTVoZEdsMlpTd2dKMEZrYldsdUlHOXViSGtuS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaWJub2djbVYyYjJ0bFFYUjBaWE4wWVhScGIyNWZZbTl2YkY5MGNuVmxRRE1LSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdKNWRHVmpYek1nTHk4Z1lXUmtjaUJNUlVkRlRrUk5VVkZLU2xkVFVWWklVa1pMTXpaRlVEZEhWRTB6VFZSSk0xWkVNMGRPTWpWWlRVdEtOazFGUWxJek5VbzBVMEpPVmtRMENpQWdJQ0E5UFFvZ0lDQWdZbm9nY21WMmIydGxRWFIwWlhOMFlYUnBiMjVmWW05dmJGOW1ZV3h6WlVBMENncHlaWFp2YTJWQmRIUmxjM1JoZEdsdmJsOWliMjlzWDNSeWRXVkFNem9LSUNBZ0lHbHVkR05mTUNBdkx5QXhDZ3B5WlhadmEyVkJkSFJsYzNSaGRHbHZibDlpYjI5c1gyMWxjbWRsUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZiM0poWTJ4bEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qQUtJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0IwYUdsekxtTnlaV0YwYjNJdWRtRnNkV1VnZkh3Z1ZIaHVMbk5sYm1SbGNpQTlQVDBnYm1WM0lHRnlZelF1UVdSa2NtVnpjeWdpVEVWSFJVNUVUVkZSU2twWFUxRldTRkpHU3pNMlJWQTNSMVJOTTAxVVNUTldSRE5IVGpJMVdVMUxTalpOUlVKU016VktORk5DVGxaRU5DSXBMbTVoZEdsMlpTd2dKMEZrYldsdUlHOXViSGtuS1FvZ0lDQWdZWE56WlhKMElDOHZJRUZrYldsdUlHOXViSGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5dmNtRmpiR1V2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TXdvZ0lDQWdMeThnY0hWaWJHbGpJSFpsY21sbWFXVmtJRDBnUW05NFRXRndQRUZqWTI5MWJuUXNJR0p2YjJ4bFlXNCtLSHNnYTJWNVVISmxabWw0T2lBbmRpY2dmU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbllpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjl2Y21GamJHVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJNUW9nSUNBZ0x5OGdkR2hwY3k1MlpYSnBabWxsWkNoMWMyVnlLUzUyWVd4MVpTQTlJR1poYkhObENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYMjl5WVdOc1pTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXhDaUFnSUNBdkx5QndkV0pzYVdNZ2MyTnZjbVZ6SUQwZ1FtOTRUV0Z3UEVGalkyOTFiblFzSUhWcGJuUTJORDRvZXlCclpYbFFjbVZtYVhnNklDZHpKeUI5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYMjl5WVdOc1pTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWXlDaUFnSUNBdkx5QjBhR2x6TG5OamIzSmxjeWgxYzJWeUtTNTJZV3gxWlNBOUlEQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEc5aUNpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmYjNKaFkyeGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOak1LSUNBZ0lDOHZJR3h2WnlnblFWUlVSVk5VUVZSSlQwNWZVa1ZXVDB0RlJDY3BDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrRlVWRVZUVkVGVVNVOU9YMUpGVms5TFJVUWlDaUFnSUNCc2IyY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjl2Y21GamJHVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFPUW9nSUNBZ0x5OGdjSFZpYkdsaklISmxkbTlyWlVGMGRHVnpkR0YwYVc5dUtIVnpaWEk2SUVGalkyOTFiblFwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ25KbGRtOXJaVUYwZEdWemRHRjBhVzl1WDJKdmIyeGZabUZzYzJWQU5Eb0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpSUhKbGRtOXJaVUYwZEdWemRHRjBhVzl1WDJKdmIyeGZiV1Z5WjJWQU5Rb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOXZjbUZqYkdVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlZISjFjM1JQY21GamJHVXVaMlYwVTJOdmNtVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSVFkyOXlaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5dmNtRmpiR1V2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yT1FvZ0lDQWdMeThnY0hWaWJHbGpJR2RsZEZOamIzSmxLSFZ6WlhJNklFRmpZMjkxYm5RcE9pQjFhVzUwTmpRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZiM0poWTJ4bEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qRUtJQ0FnSUM4dklIQjFZbXhwWXlCelkyOXlaWE1nUFNCQ2IzaE5ZWEE4UVdOamIzVnVkQ3dnZFdsdWREWTBQaWg3SUd0bGVWQnlaV1pwZURvZ0ozTW5JSDBwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZiM0poWTJ4bEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56QUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbk5qYjNKbGN5aDFjMlZ5S1M1blpYUW9leUJrWldaaGRXeDBPaUJWYVc1ME5qUW9NQ2tnZlNrS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdKMGIya0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgyOXlZV05zWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZNUNpQWdJQ0F2THlCd2RXSnNhV01nWjJWMFUyTnZjbVVvZFhObGNqb2dRV05qYjNWdWRDazZJSFZwYm5RMk5DQjdDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYMjl5WVdOc1pTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFVjblZ6ZEU5eVlXTnNaUzVwYzFabGNtbG1hV1ZrVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2FYTldaWEpwWm1sbFpEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjl2Y21GamJHVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNOZ29nSUNBZ0x5OGdjSFZpYkdsaklHbHpWbVZ5YVdacFpXUW9kWE5sY2pvZ1FXTmpiM1Z1ZENrNklHSnZiMnhsWVc0Z2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZiM0poWTJ4bEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qTUtJQ0FnSUM4dklIQjFZbXhwWXlCMlpYSnBabWxsWkNBOUlFSnZlRTFoY0R4QlkyTnZkVzUwTENCaWIyOXNaV0Z1UGloN0lHdGxlVkJ5WldacGVEb2dKM1luSUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKMklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmYjNKaFkyeGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOemNLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TG5abGNtbG1hV1ZrS0hWelpYSXBMbWRsZENoN0lHUmxabUYxYkhRNklHWmhiSE5sSUgwcENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCemQyRndDaUFnSUNCaWRHOXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYzNkaGNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOXZjbUZqYkdVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM05nb2dJQ0FnTHk4Z2NIVmliR2xqSUdselZtVnlhV1pwWldRb2RYTmxjam9nUVdOamIzVnVkQ2s2SUdKdmIyeGxZVzRnZXdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ1lubDBaV01nTkNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFEQVFBZ0pnVUhZM0psWVhSdmNnRnpBWFlnV1F4R2paQ0NVMmxDcDRsVnZ4SC9OTm0yVFJ1bzltYnJ1R0tUNWhBeDMxTUVGUjk4ZFRFWkZFUXhHRUVBSklJRUJPOVRFWndFdUdZQytRU1hnMFhSQk9NZTFIUTJHZ0NPQkFBVkFKc0E0Z0Q5QUlBRXVFUjdOallhQUk0QkFBRUFLREVBWnlKREl6WWFBVWtWSkJKRU5ob0NTUldCQ0JKRUZ6RVdJZ2xKT0JBaUVrUXhBQ01vWlVRU1FBQUhNUUFyRWtFQVZDSkVTd0dCNkFjT1JDbExBMUJKUlFXOVJRRkFBQkJIQWpnSE1nb1NSRGdJZ2R6REZ3OUVTd0VXU3dSTXZ5cExBMGxPQWxBaUZyOHlCb0FCWVU4Q1VFd1d2NEFOVlZORlVsOUJWRlJGVTFSRlJMQWlReU5DLzZrMkdnRkpGU1FTUkRFQUl5aGxSQkpBQUFjeEFDc1NRUUFxSWtRcVN3RkpUZ0pRSXhhL0tVeFFJeGEvZ0JOQlZGUkZVMVJCVkVsUFRsOVNSVlpQUzBWRXNDSkRJMEwvMHpZYUFVa1ZKQkpFS1V4UXZrd1hJMHhQQWswV0p3Uk1VTEFpUXpZYUFVa1ZKQkpFS2t4UXZrd1hJMHhQQWsyQUFRQWpUd0pVSndSTVVMQWlRdz09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MywicGF0Y2giOjIsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
