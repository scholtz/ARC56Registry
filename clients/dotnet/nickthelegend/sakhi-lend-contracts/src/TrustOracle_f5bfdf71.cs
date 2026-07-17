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

namespace Arc56.Generated.nickthelegend.sakhi_lend_contracts.TrustOracle_f5bfdf71
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

        ///<summary>
        ///Allows the admin to delete the application.
        ///</summary>
        public async Task DeleteApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 135, 195, 44 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 135, 195, 44 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVHJ1c3RPcmFjbGUiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXR0ZXN0IiwiZGVzYyI6IkF0dGVzdHMgdG8gYSB1c2VyJ3MgY3JlZGl0d29ydGhpbmVzcyB3aXRoIGEgVFRGIHNjb3JlLlxuQWRtaW4gb25seS4gUmVxdWlyZXMgTUJSIHBheW1lbnQgZm9yIGJveGVzLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2NvcmUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1iclBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmV2b2tlQXR0ZXN0YXRpb24iLCJkZXNjIjoiUmV2b2tlcyBhIHVzZXIncyB2ZXJpZmljYXRpb24gc3RhdHVzLlxuQWRtaW4gb25seS4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0U2NvcmUiLCJkZXNjIjoiUmV0dXJucyBhIHVzZXIncyBzY29yZS4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc1ZlcmlmaWVkIiwiZGVzYyI6IlJldHVybnMgd2hldGhlciBhIHVzZXIgaXMgdmVyaWZpZWQuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlbGV0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6IkFsbG93cyB0aGUgYWRtaW4gdG8gZGVsZXRlIHRoZSBhcHBsaWNhdGlvbi4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJEZWxldGVBcHBsaWNhdGlvbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTk1LDMwOCw0MzFdLCJlcnJvck1lc3NhZ2UiOiJBZG1pbiBvbmx5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjMxXSwiZXJyb3JNZXNzYWdlIjoiSW5zdWZmaWNpZW50IE1CUiBmb3IgYm94ZXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjNdLCJlcnJvck1lc3NhZ2UiOiJNQlIgdG8gb3JhY2xlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM4XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgRGVsZXRlQXBwbGljYXRpb24gJiYgY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc0XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwMl0sImVycm9yTWVzc2FnZSI6IlNjb3JlIG11c3QgYmUgPD0gMTAwMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4MiwyOTUsNDE4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU2LDI4OSwzNjAsMzg3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3Nl0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3SURNeUNpQWdJQ0JpZVhSbFkySnNiMk5ySUNKamNtVmhkRzl5SWlCaVlYTmxNeklvVEVWSFJVNUVUVkZSU2twWFUxRldTRkpHU3pNMlJWQTNSMVJOTTAxVVNUTldSRE5IVGpJMVdVMUxTalpOUlVKU016VktVU2tnSW5NaUlDSjJJaUF3ZURFMU1XWTNZemMxQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmIzSmhZMnhsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRZS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlVjblZ6ZEU5eVlXTnNaU0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREkwT0Rkak16SmpJQzh2SUcxbGRHaHZaQ0FpWkdWc1pYUmxRWEJ3YkdsallYUnBiMjRvS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgyUmxiR1YwWlVGd2NHeHBZMkYwYVc5dVgzSnZkWFJsUURJS0NtMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgyOXlZV05zWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMkNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdWSEoxYzNSUGNtRmpiR1VnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUcxMWMzUWdZbVVnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjZJRzFoYVc1ZlkzSmxZWFJsWDA1dlQzQkFNVEFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGhsWmpVek1URTVZeUF3ZUdJNE5qWXdNbVk1SURCNE9UYzRNelExWkRFZ01IaGxNekZsWkRRM05DQXZMeUJ0WlhSb2IyUWdJbUYwZEdWemRDaGhaR1J5WlhOekxIVnBiblEyTkN4d1lYa3BkbTlwWkNJc0lHMWxkR2h2WkNBaWNtVjJiMnRsUVhSMFpYTjBZWFJwYjI0b1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0puWlhSVFkyOXlaU2hoWkdSeVpYTnpLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlhWE5XWlhKcFptbGxaQ2hoWkdSeVpYTnpLV0p2YjJ3aUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmhkSFJsYzNRZ2NtVjJiMnRsUVhSMFpYTjBZWFJwYjI0Z1oyVjBVMk52Y21VZ2FYTldaWEpwWm1sbFpBb2dJQ0FnWlhKeUNncHRZV2x1WDJOeVpXRjBaVjlPYjA5d1FERXdPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDI5eVlXTnNaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUyQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1ZISjFjM1JQY21GamJHVWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGlPRFEwTjJJek5pQXZMeUJ0WlhSb2IyUWdJbU55WldGMFpVRndjR3hwWTJGMGFXOXVLQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dZM0psWVhSbFFYQndiR2xqWVhScGIyNEtJQ0FnSUdWeWNnb0tiV0ZwYmw5a1pXeGxkR1ZCY0hCc2FXTmhkR2x2Ymw5eWIzVjBaVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgyOXlZV05zWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnekNpQWdJQ0F2THlCd2RXSnNhV01nWkdWc1pYUmxRWEJ3YkdsallYUnBiMjRvS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0J3ZFhOb2FXNTBJRFVnTHk4Z1JHVnNaWFJsUVhCd2JHbGpZWFJwYjI0S0lDQWdJRDA5Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2JYVnpkQ0JpWlNCRVpXeGxkR1ZCY0hCc2FXTmhkR2x2YmlBbUppQmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmlJR1JsYkdWMFpVRndjR3hwWTJGMGFXOXVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYMjl5WVdOc1pTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFVjblZ6ZEU5eVlXTnNaUzVqY21WaGRHVkJjSEJzYVdOaGRHbHZibHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgyOXlZV05zWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNENpQWdJQ0F2THlCd2RXSnNhV01nWTNKbFlYUnZjaUE5SUVkc2IySmhiRk4wWVhSbFBFRmpZMjkxYm5RK0tDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltTnlaV0YwYjNJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZiM0poWTJ4bEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16QUtJQ0FnSUM4dklIUm9hWE11WTNKbFlYUnZjaTUyWVd4MVpTQTlJRlI0Ymk1elpXNWtaWElLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmYjNKaFkyeGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamtLSUNBZ0lDOHZJSEIxWW14cFl5QmpjbVZoZEdWQmNIQnNhV05oZEdsdmJpZ3BPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZiM0poWTJ4bEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sUnlkWE4wVDNKaFkyeGxMbUYwZEdWemRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUYwZEdWemREb0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZiM0poWTJ4bEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16Y0tJQ0FnSUM4dklIQjFZbXhwWXlCaGRIUmxjM1FvZFhObGNqb2dRV05qYjNWdWRDd2djMk52Y21VNklIVnBiblEyTkN3Z2JXSnlVR0Y1YldWdWREb2daM1I0Ymk1UVlYbHRaVzUwVkhodUtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEZ2dMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SUhCaGVRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUhCaGVRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYMjl5WVdOc1pTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTRDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnZEdocGN5NWpjbVZoZEc5eUxuWmhiSFZsSUh4OElGUjRiaTV6Wlc1a1pYSWdQVDA5SUc1bGR5QmhjbU0wTGtGa1pISmxjM01vSWt4RlIwVk9SRTFSVVVwS1YxTlJWa2hTUmtzek5rVlFOMGRVVFROTlZFa3pWa1F6UjA0eU5WbE5TMG8yVFVWQ1VqTTFTalJUUWs1V1JEUWlLUzV1WVhScGRtVXNJQ2RCWkcxcGJpQnZibXg1SnlrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmYjNKaFkyeGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGdLSUNBZ0lDOHZJSEIxWW14cFl5QmpjbVZoZEc5eUlEMGdSMnh2WW1Gc1UzUmhkR1U4UVdOamIzVnVkRDRvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWTNKbFlYUnZjaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5dmNtRmpiR1V2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96T0FvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlIUm9hWE11WTNKbFlYUnZjaTUyWVd4MVpTQjhmQ0JVZUc0dWMyVnVaR1Z5SUQwOVBTQnVaWGNnWVhKak5DNUJaR1J5WlhOektDSk1SVWRGVGtSTlVWRktTbGRUVVZaSVVrWkxNelpGVURkSFZFMHpUVlJKTTFaRU0wZE9NalZaVFV0S05rMUZRbEl6TlVvMFUwSk9Wa1EwSWlrdWJtRjBhWFpsTENBblFXUnRhVzRnYjI1c2VTY3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0p1ZWlCaGRIUmxjM1JmWW05dmJGOTBjblZsUURNS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdZV1JrY2lCTVJVZEZUa1JOVVZGS1NsZFRVVlpJVWtaTE16WkZVRGRIVkUwelRWUkpNMVpFTTBkT01qVlpUVXRLTmsxRlFsSXpOVW8wVTBKT1ZrUTBDaUFnSUNBOVBRb2dJQ0FnWW5vZ1lYUjBaWE4wWDJKdmIyeGZabUZzYzJWQU5Bb0tZWFIwWlhOMFgySnZiMnhmZEhKMVpVQXpPZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtDbUYwZEdWemRGOWliMjlzWDIxbGNtZGxRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmIzSmhZMnhsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpnS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQjBhR2x6TG1OeVpXRjBiM0l1ZG1Gc2RXVWdmSHdnVkhodUxuTmxibVJsY2lBOVBUMGdibVYzSUdGeVl6UXVRV1JrY21WemN5Z2lURVZIUlU1RVRWRlJTa3BYVTFGV1NGSkdTek0yUlZBM1IxUk5NMDFVU1ROV1JETkhUakkxV1UxTFNqWk5SVUpTTXpWS05GTkNUbFpFTkNJcExtNWhkR2wyWlN3Z0owRmtiV2x1SUc5dWJIa25LUW9nSUNBZ1lYTnpaWEowSUM4dklFRmtiV2x1SUc5dWJIa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjl2Y21GamJHVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pPUW9nSUNBZ0x5OGdZWE56WlhKMEtITmpiM0psSUR3OUlERXdNREFzSUNkVFkyOXlaU0J0ZFhOMElHSmxJRHc5SURFd01EQW5LUW9nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ01UQXdNQ0F2THlBeE1EQXdDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUZOamIzSmxJRzExYzNRZ1ltVWdQRDBnTVRBd01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYMjl5WVdOc1pTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXhDaUFnSUNBdkx5QndkV0pzYVdNZ2MyTnZjbVZ6SUQwZ1FtOTRUV0Z3UEVGalkyOTFiblFzSUhWcGJuUTJORDRvZXlCclpYbFFjbVZtYVhnNklDZHpKeUI5S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpY3lJS0lDQWdJR1JwWnlBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQTFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmYjNKaFkyeGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORElLSUNBZ0lDOHZJR2xtSUNnaGRHaHBjeTV6WTI5eVpYTW9kWE5sY2lrdVpYaHBjM1J6S1NCN0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSnVlaUJoZEhSbGMzUmZZV1owWlhKZmFXWmZaV3h6WlVBM0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZiM0poWTJ4bEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EUUtJQ0FnSUM4dklHRnpjMlZ5ZENodFluSlFZWGx0Wlc1MExuSmxZMlZwZG1WeUlEMDlQU0JIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d2dKMDFDVWlCMGJ5QnZjbUZqYkdVbktRb2dJQ0FnWkhWd2JpQXlDaUFnSUNCbmRIaHVjeUJTWldObGFYWmxjZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1RVSlNJSFJ2SUc5eVlXTnNaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDI5eVlXTnNaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalExQ2lBZ0lDQXZMeUJoYzNObGNuUW9iV0p5VUdGNWJXVnVkQzVoYlc5MWJuUWdQajBnUWs5WVgwMUNVaUFxSURNc0lDZEpibk4xWm1acFkybGxiblFnVFVKU0lHWnZjaUJpYjNobGN5Y3BDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtJQ0FnSUhCMWMyaHBiblFnTXpnMU5UQXdJQzh2SURNNE5UVXdNQW9nSUNBZ1BqMEtJQ0FnSUdGemMyVnlkQ0F2THlCSmJuTjFabVpwWTJsbGJuUWdUVUpTSUdadmNpQmliM2hsY3dvS1lYUjBaWE4wWDJGbWRHVnlYMmxtWDJWc2MyVkFOem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5dmNtRmpiR1V2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wT0FvZ0lDQWdMeThnZEdocGN5NXpZMjl5WlhNb2RYTmxjaWt1ZG1Gc2RXVWdQU0J6WTI5eVpRb2dJQ0FnWkdsbklERUtJQ0FnSUdsMGIySUtJQ0FnSUdScFp5QTBDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmIzSmhZMnhsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpNS0lDQWdJQzh2SUhCMVlteHBZeUIyWlhKcFptbGxaQ0E5SUVKdmVFMWhjRHhCWTJOdmRXNTBMQ0JpYjI5c1pXRnVQaWg3SUd0bGVWQnlaV1pwZURvZ0ozWW5JSDBwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0oySWdvZ0lDQWdaR2xuSURNS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmYjNKaFkyeGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORGtLSUNBZ0lDOHZJSFJvYVhNdWRtVnlhV1pwWldRb2RYTmxjaWt1ZG1Gc2RXVWdQU0IwY25WbENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYMjl5WVdOc1pTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVXdDaUFnSUNBdkx5QjBhR2x6TG1GMGRHVnpkR1ZrUVhRb2RYTmxjaWt1ZG1Gc2RXVWdQU0JIYkc5aVlXd3VjbTkxYm1RS0lDQWdJR2RzYjJKaGJDQlNiM1Z1WkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgyOXlZV05zWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJMUNpQWdJQ0F2THlCd2RXSnNhV01nWVhSMFpYTjBaV1JCZENBOUlFSnZlRTFoY0R4QlkyTnZkVzUwTENCMWFXNTBOalErS0hzZ2EyVjVVSEpsWm1sNE9pQW5ZU2NnZlNrS0lDQWdJSEIxYzJoaWVYUmxjeUFpWVNJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmIzSmhZMnhsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRBS0lDQWdJQzh2SUhSb2FYTXVZWFIwWlhOMFpXUkJkQ2gxYzJWeUtTNTJZV3gxWlNBOUlFZHNiMkpoYkM1eWIzVnVaQW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgyOXlZV05zWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVeUNpQWdJQ0F2THlCc2IyY29KMVZUUlZKZlFWUlVSVk5VUlVRbktRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKVlUwVlNYMEZVVkVWVFZFVkVJZ29nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmYjNKaFkyeGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNemNLSUNBZ0lDOHZJSEIxWW14cFl5QmhkSFJsYzNRb2RYTmxjam9nUVdOamIzVnVkQ3dnYzJOdmNtVTZJSFZwYm5RMk5Dd2diV0p5VUdGNWJXVnVkRG9nWjNSNGJpNVFZWGx0Wlc1MFZIaHVLVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3BoZEhSbGMzUmZZbTl2YkY5bVlXeHpaVUEwT2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSWdZWFIwWlhOMFgySnZiMnhmYldWeVoyVkFOUW9LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjl2Y21GamJHVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZWSEoxYzNSUGNtRmpiR1V1Y21WMmIydGxRWFIwWlhOMFlYUnBiMjViY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpYWnZhMlZCZEhSbGMzUmhkR2x2YmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOXZjbUZqYkdVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU9Rb2dJQ0FnTHk4Z2NIVmliR2xqSUhKbGRtOXJaVUYwZEdWemRHRjBhVzl1S0hWelpYSTZJRUZqWTI5MWJuUXBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYMjl5WVdOc1pTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWXdDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnZEdocGN5NWpjbVZoZEc5eUxuWmhiSFZsSUh4OElGUjRiaTV6Wlc1a1pYSWdQVDA5SUc1bGR5QmhjbU0wTGtGa1pISmxjM01vSWt4RlIwVk9SRTFSVVVwS1YxTlJWa2hTUmtzek5rVlFOMGRVVFROTlZFa3pWa1F6UjA0eU5WbE5TMG8yVFVWQ1VqTTFTalJUUWs1V1JEUWlLUzV1WVhScGRtVXNJQ2RCWkcxcGJpQnZibXg1SnlrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmYjNKaFkyeGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGdLSUNBZ0lDOHZJSEIxWW14cFl5QmpjbVZoZEc5eUlEMGdSMnh2WW1Gc1UzUmhkR1U4UVdOamIzVnVkRDRvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWTNKbFlYUnZjaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5dmNtRmpiR1V2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTUFvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlIUm9hWE11WTNKbFlYUnZjaTUyWVd4MVpTQjhmQ0JVZUc0dWMyVnVaR1Z5SUQwOVBTQnVaWGNnWVhKak5DNUJaR1J5WlhOektDSk1SVWRGVGtSTlVWRktTbGRUVVZaSVVrWkxNelpGVURkSFZFMHpUVlJKTTFaRU0wZE9NalZaVFV0S05rMUZRbEl6TlVvMFUwSk9Wa1EwSWlrdWJtRjBhWFpsTENBblFXUnRhVzRnYjI1c2VTY3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0p1ZWlCeVpYWnZhMlZCZEhSbGMzUmhkR2x2Ymw5aWIyOXNYM1J5ZFdWQU13b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZbmwwWldOZk1TQXZMeUJoWkdSeUlFeEZSMFZPUkUxUlVVcEtWMU5SVmtoU1Jrc3pOa1ZRTjBkVVRUTk5WRWt6VmtRelIwNHlOVmxOUzBvMlRVVkNVak0xU2pSVFFrNVdSRFFLSUNBZ0lEMDlDaUFnSUNCaWVpQnlaWFp2YTJWQmRIUmxjM1JoZEdsdmJsOWliMjlzWDJaaGJITmxRRFFLQ25KbGRtOXJaVUYwZEdWemRHRjBhVzl1WDJKdmIyeGZkSEoxWlVBek9nb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0NuSmxkbTlyWlVGMGRHVnpkR0YwYVc5dVgySnZiMnhmYldWeVoyVkFOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5dmNtRmpiR1V2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTUFvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlIUm9hWE11WTNKbFlYUnZjaTUyWVd4MVpTQjhmQ0JVZUc0dWMyVnVaR1Z5SUQwOVBTQnVaWGNnWVhKak5DNUJaR1J5WlhOektDSk1SVWRGVGtSTlVWRktTbGRUVVZaSVVrWkxNelpGVURkSFZFMHpUVlJKTTFaRU0wZE9NalZaVFV0S05rMUZRbEl6TlVvMFUwSk9Wa1EwSWlrdWJtRjBhWFpsTENBblFXUnRhVzRnYjI1c2VTY3BDaUFnSUNCaGMzTmxjblFnTHk4Z1FXUnRhVzRnYjI1c2VRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYMjl5WVdOc1pTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXpDaUFnSUNBdkx5QndkV0pzYVdNZ2RtVnlhV1pwWldRZ1BTQkNiM2hOWVhBOFFXTmpiM1Z1ZEN3Z1ltOXZiR1ZoYmo0b2V5QnJaWGxRY21WbWFYZzZJQ2QySnlCOUtRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWRpSUtJQ0FnSUdScFp5QXhDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgyOXlZV05zWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZeENpQWdJQ0F2THlCMGFHbHpMblpsY21sbWFXVmtLSFZ6WlhJcExuWmhiSFZsSUQwZ1ptRnNjMlVLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRHOWlDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmIzSmhZMnhsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpFS0lDQWdJQzh2SUhCMVlteHBZeUJ6WTI5eVpYTWdQU0JDYjNoTllYQThRV05qYjNWdWRDd2dkV2x1ZERZMFBpaDdJR3RsZVZCeVpXWnBlRG9nSjNNbklIMHBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmIzSmhZMnhsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpJS0lDQWdJQzh2SUhSb2FYTXVjMk52Y21WektIVnpaWElwTG5aaGJIVmxJRDBnTUFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbDBiMklLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOXZjbUZqYkdVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk13b2dJQ0FnTHk4Z2JHOW5LQ2RCVkZSRlUxUkJWRWxQVGw5U1JWWlBTMFZFSnlrS0lDQWdJSEIxYzJoaWVYUmxjeUFpUVZSVVJWTlVRVlJKVDA1ZlVrVldUMHRGUkNJS0lDQWdJR3h2WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgyOXlZV05zWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVNUNpQWdJQ0F2THlCd2RXSnNhV01nY21WMmIydGxRWFIwWlhOMFlYUnBiMjRvZFhObGNqb2dRV05qYjNWdWRDazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tjbVYyYjJ0bFFYUjBaWE4wWVhScGIyNWZZbTl2YkY5bVlXeHpaVUEwT2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSWdjbVYyYjJ0bFFYUjBaWE4wWVhScGIyNWZZbTl2YkY5dFpYSm5aVUExQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDI5eVlXTnNaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBVY25WemRFOXlZV05zWlM1blpYUlRZMjl5WlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRk5qYjNKbE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYMjl5WVdOc1pTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTVDaUFnSUNBdkx5QndkV0pzYVdNZ1oyVjBVMk52Y21Vb2RYTmxjam9nUVdOamIzVnVkQ2s2SUhWcGJuUTJOQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5dmNtRmpiR1V2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TVFvZ0lDQWdMeThnY0hWaWJHbGpJSE5qYjNKbGN5QTlJRUp2ZUUxaGNEeEJZMk52ZFc1MExDQjFhVzUwTmpRK0tIc2dhMlY1VUhKbFptbDRPaUFuY3ljZ2ZTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0luTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5dmNtRmpiR1V2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTUFvZ0lDQWdMeThnY21WMGRYSnVJSFJvYVhNdWMyTnZjbVZ6S0hWelpYSXBMbWRsZENoN0lHUmxabUYxYkhRNklGVnBiblEyTkNnd0tTQjlLUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZblJ2YVFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmYjNKaFkyeGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOamtLSUNBZ0lDOHZJSEIxWW14cFl5Qm5aWFJUWTI5eVpTaDFjMlZ5T2lCQlkyTnZkVzUwS1RvZ2RXbHVkRFkwSUhzS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmIzSmhZMnhsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xSeWRYTjBUM0poWTJ4bExtbHpWbVZ5YVdacFpXUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BwYzFabGNtbG1hV1ZrT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgyOXlZV05zWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjMkNpQWdJQ0F2THlCd2RXSnNhV01nYVhOV1pYSnBabWxsWkNoMWMyVnlPaUJCWTJOdmRXNTBLVG9nWW05dmJHVmhiaUI3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5dmNtRmpiR1V2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TXdvZ0lDQWdMeThnY0hWaWJHbGpJSFpsY21sbWFXVmtJRDBnUW05NFRXRndQRUZqWTI5MWJuUXNJR0p2YjJ4bFlXNCtLSHNnYTJWNVVISmxabWw0T2lBbmRpY2dmU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbllpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOXZjbUZqYkdVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM053b2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVkbVZ5YVdacFpXUW9kWE5sY2lrdVoyVjBLSHNnWkdWbVlYVnNkRG9nWm1Gc2MyVWdmU2tLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSE4zWVhBS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDI5eVlXTnNaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamMyQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdhWE5XWlhKcFptbGxaQ2gxYzJWeU9pQkJZMk52ZFc1MEtUb2dZbTl2YkdWaGJpQjdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgyOXlZV05zWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwVWNuVnpkRTl5WVdOc1pTNWtaV3hsZEdWQmNIQnNhV05oZEdsdmJsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbVJsYkdWMFpVRndjR3hwWTJGMGFXOXVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDI5eVlXTnNaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamcwQ2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ2RHaHBjeTVqY21WaGRHOXlMblpoYkhWbElIeDhJRlI0Ymk1elpXNWtaWElnUFQwOUlHNWxkeUJoY21NMExrRmtaSEpsYzNNb0lreEZSMFZPUkUxUlVVcEtWMU5SVmtoU1Jrc3pOa1ZRTjBkVVRUTk5WRWt6VmtRelIwNHlOVmxOUzBvMlRVVkNVak0xU2pSVFFrNVdSRFFpS1M1dVlYUnBkbVVzSUNKQlpHMXBiaUJ2Ym14NUlpa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmIzSmhZMnhsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRnS0lDQWdJQzh2SUhCMVlteHBZeUJqY21WaGRHOXlJRDBnUjJ4dlltRnNVM1JoZEdVOFFXTmpiM1Z1ZEQ0b0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVkzSmxZWFJ2Y2lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOXZjbUZqYkdVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE5Bb2dJQ0FnTHk4Z1lYTnpaWEowS0ZSNGJpNXpaVzVrWlhJZ1BUMDlJSFJvYVhNdVkzSmxZWFJ2Y2k1MllXeDFaU0I4ZkNCVWVHNHVjMlZ1WkdWeUlEMDlQU0J1WlhjZ1lYSmpOQzVCWkdSeVpYTnpLQ0pNUlVkRlRrUk5VVkZLU2xkVFVWWklVa1pMTXpaRlVEZEhWRTB6VFZSSk0xWkVNMGRPTWpWWlRVdEtOazFGUWxJek5VbzBVMEpPVmtRMElpa3VibUYwYVhabExDQWlRV1J0YVc0Z2IyNXNlU0lwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdKdWVpQmtaV3hsZEdWQmNIQnNhV05oZEdsdmJsOWliMjlzWDNSeWRXVkFNd29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWW5sMFpXTmZNU0F2THlCaFpHUnlJRXhGUjBWT1JFMVJVVXBLVjFOUlZraFNSa3N6TmtWUU4wZFVUVE5OVkVrelZrUXpSMDR5TlZsTlMwbzJUVVZDVWpNMVNqUlRRazVXUkRRS0lDQWdJRDA5Q2lBZ0lDQmllaUJrWld4bGRHVkJjSEJzYVdOaGRHbHZibDlpYjI5c1gyWmhiSE5sUURRS0NtUmxiR1YwWlVGd2NHeHBZMkYwYVc5dVgySnZiMnhmZEhKMVpVQXpPZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtDbVJsYkdWMFpVRndjR3hwWTJGMGFXOXVYMkp2YjJ4ZmJXVnlaMlZBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOXZjbUZqYkdVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE5Bb2dJQ0FnTHk4Z1lYTnpaWEowS0ZSNGJpNXpaVzVrWlhJZ1BUMDlJSFJvYVhNdVkzSmxZWFJ2Y2k1MllXeDFaU0I4ZkNCVWVHNHVjMlZ1WkdWeUlEMDlQU0J1WlhjZ1lYSmpOQzVCWkdSeVpYTnpLQ0pNUlVkRlRrUk5VVkZLU2xkVFVWWklVa1pMTXpaRlVEZEhWRTB6VFZSSk0xWkVNMGRPTWpWWlRVdEtOazFGUWxJek5VbzBVMEpPVmtRMElpa3VibUYwYVhabExDQWlRV1J0YVc0Z2IyNXNlU0lwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRV1J0YVc0Z2IyNXNlUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDI5eVlXTnNaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamd6Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdaR1ZzWlhSbFFYQndiR2xqWVhScGIyNG9LVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3BrWld4bGRHVkJjSEJzYVdOaGRHbHZibDlpYjI5c1gyWmhiSE5sUURRNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZaUJrWld4bGRHVkJjSEJzYVdOaGRHbHZibDlpYjI5c1gyMWxjbWRsUURVSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBREFRQWdKZ1VIWTNKbFlYUnZjaUJaREVhTmtJSlRhVUtuaVZXL0VmODAyYlpORzZqMlp1dTRZcFBtRURIZlV3RnpBWFlFRlI5OGRZQUVKSWZETERZYUFJNEJBRHN4R1JSRU1SaEJBQ1NDQkFUdlV4R2NCTGhtQXZrRWw0TkYwUVRqSHRSME5ob0FqZ1FBSVFDbkFPNEJDUUNBQkxoRWV6WTJHZ0NPQVFBTkFERVpnUVVTTVJnUVJFSUJEeWd4QUdjaVF5TTJHZ0ZKRlNRU1JEWWFBa2tWZ1FnU1JCY3hGaUlKU1RnUUloSkVNUUFqS0dWRUVrQUFCekVBS1JKQkFGUWlSRXNCZ2VnSERrUXFTd05RU1VVRnZVVUJRQUFRUndJNEJ6SUtFa1E0Q0lIY3d4Y1BSRXNCRmtzRVRMOHJTd05KVGdKUUloYS9NZ2FBQVdGUEFsQk1GcitBRFZWVFJWSmZRVlJVUlZOVVJVU3dJa01qUXYrcE5ob0JTUlVrRWtReEFDTW9aVVFTUUFBSE1RQXBFa0VBS2lKRUswc0JTVTRDVUNNV3Z5cE1VQ01XdjRBVFFWUlVSVk5VUVZSSlQwNWZVa1ZXVDB0RlJMQWlReU5DLzlNMkdnRkpGU1FTUkNwTVVMNU1GeU5NVHdKTkZpY0VURkN3SWtNMkdnRkpGU1FTUkN0TVVMNU1GeU5NVHdKTmdBRUFJMDhDVkNjRVRGQ3dJa014QUNNb1pVUVNRQUFITVFBcEVrRUFCQ0pFSWtNalF2LzUiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjozLCJwYXRjaCI6MiwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
