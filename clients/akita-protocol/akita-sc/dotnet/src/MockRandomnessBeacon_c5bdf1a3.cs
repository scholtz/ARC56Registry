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

namespace Arc56.Generated.akita_protocol.akita_sc.MockRandomnessBeacon_c5bdf1a3
{


    //
    // Mock VRF beacon for testing purposes (test-only, never deployed to a live network).
    //
    //By default it returns a fixed 32-byte seed for every round. Tests can override
    //the seed (`setSeed`) to steer the drawn ticket, make every read come back
    //empty (`setEmpty`) to exercise the beacon-failure path, or model the MainNet
    //beacon's timing (`setSubmitLag`).
    //
    public class MockRandomnessBeaconProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MockRandomnessBeaconProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Returns mock random bytes for testing.
        ///</summary>
        /// <param name="round"> </param>
        /// <param name="userData"> </param>
        public async Task<byte[]> Get(ulong round, byte[] userData, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 24, 147, 146, 197 };
            var roundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roundAbi.From(round);
            var userDataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); userDataAbi.From(userData);

            var result = await base.CallApp(new List<object> { abiHandle, roundAbi, userDataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> Get_Transactions(ulong round, byte[] userData, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 24, 147, 146, 197 };
            var roundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roundAbi.From(round);
            var userDataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); userDataAbi.From(userData);

            return await base.MakeTransactionList(new List<object> { abiHandle, roundAbi, userDataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///test helper: use `seed` for every subsequent read (empty bytes restores the default)
        ///</summary>
        /// <param name="seed"> </param>
        public async Task SetSeed(byte[] seed, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 93, 36, 178, 26 };
            var seedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); seedAbi.From(seed);

            var result = await base.CallApp(new List<object> { abiHandle, seedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetSeed_Transactions(byte[] seed, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 93, 36, 178, 26 };
            var seedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); seedAbi.From(seed);

            return await base.MakeTransactionList(new List<object> { abiHandle, seedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///test helper: make every subsequent read return empty bytes
        ///</summary>
        /// <param name="empty"> </param>
        public async Task SetEmpty(bool empty, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 234, 4, 160, 76 };
            var emptyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); emptyAbi.From(empty);

            var result = await base.CallApp(new List<object> { abiHandle, emptyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetEmpty_Transactions(bool empty, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 234, 4, 160, 76 };
            var emptyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); emptyAbi.From(empty);

            return await base.MakeTransactionList(new List<object> { abiHandle, emptyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///test helper: model the MainNet beacon's ceil-to-8 storage and submission lag (0 disables)
        ///</summary>
        /// <param name="lag"> </param>
        public async Task SetSubmitLag(ulong lag, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 249, 16, 59 };
            var lagAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lagAbi.From(lag);

            var result = await base.CallApp(new List<object> { abiHandle, lagAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetSubmitLag_Transactions(ulong lag, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 249, 16, 59 };
            var lagAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lagAbi.From(lag);

            return await base.MakeTransactionList(new List<object> { abiHandle, lagAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTW9ja1JhbmRvbW5lc3NCZWFjb24iLCJkZXNjIjoiTW9jayBWUkYgYmVhY29uIGZvciB0ZXN0aW5nIHB1cnBvc2VzICh0ZXN0LW9ubHksIG5ldmVyIGRlcGxveWVkIHRvIGEgbGl2ZSBuZXR3b3JrKS5cblxuQnkgZGVmYXVsdCBpdCByZXR1cm5zIGEgZml4ZWQgMzItYnl0ZSBzZWVkIGZvciBldmVyeSByb3VuZC4gVGVzdHMgY2FuIG92ZXJyaWRlXG50aGUgc2VlZCAoYHNldFNlZWRgKSB0byBzdGVlciB0aGUgZHJhd24gdGlja2V0LCBtYWtlIGV2ZXJ5IHJlYWQgY29tZSBiYWNrXG5lbXB0eSAoYHNldEVtcHR5YCkgdG8gZXhlcmNpc2UgdGhlIGJlYWNvbi1mYWlsdXJlIHBhdGgsIG9yIG1vZGVsIHRoZSBNYWluTmV0XG5iZWFjb24ncyB0aW1pbmcgKGBzZXRTdWJtaXRMYWdgKS4iLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiZ2V0IiwiZGVzYyI6IlJldHVybnMgbW9jayByYW5kb20gYnl0ZXMgZm9yIHRlc3RpbmcuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvdW5kIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyRGF0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldFNlZWQiLCJkZXNjIjoidGVzdCBoZWxwZXI6IHVzZSBgc2VlZGAgZm9yIGV2ZXJ5IHN1YnNlcXVlbnQgcmVhZCAoZW1wdHkgYnl0ZXMgcmVzdG9yZXMgdGhlIGRlZmF1bHQpIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlZWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0RW1wdHkiLCJkZXNjIjoidGVzdCBoZWxwZXI6IG1ha2UgZXZlcnkgc3Vic2VxdWVudCByZWFkIHJldHVybiBlbXB0eSBieXRlcyIsImFyZ3MiOlt7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZW1wdHkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0U3VibWl0TGFnIiwiZGVzYyI6InRlc3QgaGVscGVyOiBtb2RlbCB0aGUgTWFpbk5ldCBiZWFjb24ncyBjZWlsLXRvLTggc3RvcmFnZSBhbmQgc3VibWlzc2lvbiBsYWcgKDAgZGlzYWJsZXMpIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImxhZyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzEyNSwxNTIsMTY5LDE4NCwxOTJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTUsMjM4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjYxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyMSwyNDVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA4LDI3Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElEZ2dNZ29nSUNBZ1lubDBaV05pYkc5amF5QWljMlZsWkNJZ0luTjFZbTFwZEV4aFp5SWdJaUlnSW1WdGNIUjVJZ29nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMM1I1Y0dWekwyMXZZMnN0Y21GdVpHOXRibVZ6Y3kxaVpXRmpiMjR1WVd4bmJ5NTBjem94TXdvZ0lDQWdMeThnYzJWbFpDQTlJRWRzYjJKaGJGTjBZWFJsUEdKNWRHVnpQaWg3SUdsdWFYUnBZV3hXWVd4MVpUb2dRbmwwWlhNb0p5Y3BMQ0JyWlhrNklDZHpaV1ZrSnlCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWMyVmxaQ0lLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmRIbHdaWE12Ylc5amF5MXlZVzVrYjIxdVpYTnpMV0psWVdOdmJpNWhiR2R2TG5Sek9qRTFDaUFnSUNBdkx5QmxiWEIwZVNBOUlFZHNiMkpoYkZOMFlYUmxQR0p2YjJ4bFlXNCtLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQm1ZV3h6WlN3Z2EyVjVPaUFuWlcxd2RIa25JSDBwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0psYlhCMGVTSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMM1I1Y0dWekwyMXZZMnN0Y21GdVpHOXRibVZ6Y3kxaVpXRmpiMjR1WVd4bmJ5NTBjem95TVFvZ0lDQWdMeThnYzNWaWJXbDBUR0ZuSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ01Dd2dhMlY1T2lBbmMzVmliV2wwVEdGbkp5QjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWljM1ZpYldsMFRHRm5JZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OTBlWEJsY3k5dGIyTnJMWEpoYm1SdmJXNWxjM010WW1WaFkyOXVMbUZzWjI4dWRITTZNVEVLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCTmIyTnJVbUZ1Wkc5dGJtVnpjMEpsWVdOdmJpQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUF4TXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0TVRnNU16a3lZelVnTUhnMVpESTBZakl4WVNBd2VHVmhNRFJoTURSaklEQjRPVFJtT1RFd00ySWdMeThnYldWMGFHOWtJQ0puWlhRb2RXbHVkRFkwTEdKNWRHVmJYU2xpZVhSbFcxMGlMQ0J0WlhSb2IyUWdJbk5sZEZObFpXUW9ZbmwwWlZ0ZEtYWnZhV1FpTENCdFpYUm9iMlFnSW5ObGRFVnRjSFI1S0dKdmIyd3BkbTlwWkNJc0lHMWxkR2h2WkNBaWMyVjBVM1ZpYldsMFRHRm5LSFZwYm5RMk5DbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1oyVjBJSE5sZEZObFpXUWdjMlYwUlcxd2RIa2djMlYwVTNWaWJXbDBUR0ZuQ2lBZ0lDQmxjbklLQ20xaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFERXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNSNWNHVnpMMjF2WTJzdGNtRnVaRzl0Ym1WemN5MWlaV0ZqYjI0dVlXeG5ieTUwY3pveE1Rb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRTF2WTJ0U1lXNWtiMjF1WlhOelFtVmhZMjl1SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmRIbHdaWE12Ylc5amF5MXlZVzVrYjIxdVpYTnpMV0psWVdOdmJpNWhiR2R2TG5Sek9qcE5iMk5yVW1GdVpHOXRibVZ6YzBKbFlXTnZiaTVuWlhSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmRIbHdaWE12Ylc5amF5MXlZVzVrYjIxdVpYTnpMV0psWVdOdmJpNWhiR2R2TG5Sek9qSTJDaUFnSUNBdkx5Qm5aWFFvY205MWJtUTZJSFZwYm5RMk5Dd2dkWE5sY2tSaGRHRTZJR0o1ZEdWektUb2dZbmwwWlhNZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZkSGx3WlhNdmJXOWpheTF5WVc1a2IyMXVaWE56TFdKbFlXTnZiaTVoYkdkdkxuUnpPakkzQ2lBZ0lDQXZMeUJwWmlBb2RHaHBjeTVsYlhCMGVTNTJZV3gxWlNrZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OTBlWEJsY3k5dGIyTnJMWEpoYm1SdmJXNWxjM010WW1WaFkyOXVMbUZzWjI4dWRITTZNVFVLSUNBZ0lDOHZJR1Z0Y0hSNUlEMGdSMnh2WW1Gc1UzUmhkR1U4WW05dmJHVmhiajRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJR1poYkhObExDQnJaWGs2SUNkbGJYQjBlU2NnZlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1WdGNIUjVJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNSNWNHVnpMMjF2WTJzdGNtRnVaRzl0Ym1WemN5MWlaV0ZqYjI0dVlXeG5ieTUwY3pveU53b2dJQ0FnTHk4Z2FXWWdLSFJvYVhNdVpXMXdkSGt1ZG1Gc2RXVXBJSHNLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCaWVpQm5aWFJmWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12ZEhsd1pYTXZiVzlqYXkxeVlXNWtiMjF1WlhOekxXSmxZV052Ymk1aGJHZHZMblJ6T2pJNENpQWdJQ0F2THlCeVpYUjFjbTRnUW5sMFpYTW9KeWNwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0lpQ2dwblpYUmZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZkSGx3WlhNdmJXOWpheTF5WVc1a2IyMXVaWE56TFdKbFlXTnZiaTVoYkdkdkxuUnpPanBOYjJOclVtRnVaRzl0Ym1WemMwSmxZV052Ymk1blpYUkFNVEE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmRIbHdaWE12Ylc5amF5MXlZVzVrYjIxdVpYTnpMV0psWVdOdmJpNWhiR2R2TG5Sek9qSTJDaUFnSUNBdkx5Qm5aWFFvY205MWJtUTZJSFZwYm5RMk5Dd2dkWE5sY2tSaGRHRTZJR0o1ZEdWektUb2dZbmwwWlhNZ2V3b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS1oyVjBYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTkwZVhCbGN5OXRiMk5yTFhKaGJtUnZiVzVsYzNNdFltVmhZMjl1TG1Gc1oyOHVkSE02TXpFS0lDQWdJQzh2SUdsbUlDaDBhR2x6TG5OMVltMXBkRXhoWnk1MllXeDFaU0ErSURBcElIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZkSGx3WlhNdmJXOWpheTF5WVc1a2IyMXVaWE56TFdKbFlXTnZiaTVoYkdkdkxuUnpPakl4Q2lBZ0lDQXZMeUJ6ZFdKdGFYUk1ZV2NnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lBd0xDQnJaWGs2SUNkemRXSnRhWFJNWVdjbklIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnpkV0p0YVhSTVlXY2lDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12ZEhsd1pYTXZiVzlqYXkxeVlXNWtiMjF1WlhOekxXSmxZV052Ymk1aGJHZHZMblJ6T2pNeENpQWdJQ0F2THlCcFppQW9kR2hwY3k1emRXSnRhWFJNWVdjdWRtRnNkV1VnUGlBd0tTQjdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnWW5vZ1oyVjBYMkZtZEdWeVgybG1YMlZzYzJWQU53b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMM1I1Y0dWekwyMXZZMnN0Y21GdVpHOXRibVZ6Y3kxaVpXRmpiMjR1WVd4bmJ5NTBjem96TWdvZ0lDQWdMeThnWTI5dWMzUWdjM1J2Y21Wa09pQjFhVzUwTmpRZ1BTQW9jbTkxYm1RZ0t5QTNLU0F2SURnZ0tpQTRDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTndvZ0lDQWdLd29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUM4S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQXFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12ZEhsd1pYTXZiVzlqYXkxeVlXNWtiMjF1WlhOekxXSmxZV052Ymk1aGJHZHZMblJ6T2pNekNpQWdJQ0F2THlCcFppQW9SMnh2WW1Gc0xuSnZkVzVrSUR3Z2MzUnZjbVZrSUNzZ2RHaHBjeTV6ZFdKdGFYUk1ZV2N1ZG1Gc2RXVXBJSHNLSUNBZ0lHZHNiMkpoYkNCU2IzVnVaQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTkwZVhCbGN5OXRiMk5yTFhKaGJtUnZiVzVsYzNNdFltVmhZMjl1TG1Gc1oyOHVkSE02TWpFS0lDQWdJQzh2SUhOMVltMXBkRXhoWnlBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJwYm1sMGFXRnNWbUZzZFdVNklEQXNJR3RsZVRvZ0ozTjFZbTFwZEV4aFp5Y2dmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbk4xWW0xcGRFeGhaeUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5MGVYQmxjeTl0YjJOckxYSmhibVJ2Ylc1bGMzTXRZbVZoWTI5dUxtRnNaMjh1ZEhNNk16TUtJQ0FnSUM4dklHbG1JQ2hIYkc5aVlXd3VjbTkxYm1RZ1BDQnpkRzl5WldRZ0t5QjBhR2x6TG5OMVltMXBkRXhoWnk1MllXeDFaU2tnZXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnS3dvZ0lDQWdQQW9nSUNBZ1lub2daMlYwWDJGbWRHVnlYMmxtWDJWc2MyVkFOd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNSNWNHVnpMMjF2WTJzdGNtRnVaRzl0Ym1WemN5MWlaV0ZqYjI0dVlXeG5ieTUwY3pvek5Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUVKNWRHVnpLQ2NuS1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwzUjVjR1Z6TDIxdlkyc3RjbUZ1Wkc5dGJtVnpjeTFpWldGamIyNHVZV3huYnk1MGN6b3lOZ29nSUNBZ0x5OGdaMlYwS0hKdmRXNWtPaUIxYVc1ME5qUXNJSFZ6WlhKRVlYUmhPaUJpZVhSbGN5azZJR0o1ZEdWeklIc0tJQ0FnSUdJZ1oyVjBYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMM1I1Y0dWekwyMXZZMnN0Y21GdVpHOXRibVZ6Y3kxaVpXRmpiMjR1WVd4bmJ5NTBjem82VFc5amExSmhibVJ2Ylc1bGMzTkNaV0ZqYjI0dVoyVjBRREV3Q2dwblpYUmZZV1owWlhKZmFXWmZaV3h6WlVBM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMM1I1Y0dWekwyMXZZMnN0Y21GdVpHOXRibVZ6Y3kxaVpXRmpiMjR1WVd4bmJ5NTBjem96T0FvZ0lDQWdMeThnYVdZZ0tIUm9hWE11YzJWbFpDNTJZV3gxWlM1c1pXNW5kR2dnUGlBd0tTQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMM1I1Y0dWekwyMXZZMnN0Y21GdVpHOXRibVZ6Y3kxaVpXRmpiMjR1WVd4bmJ5NTBjem94TXdvZ0lDQWdMeThnYzJWbFpDQTlJRWRzYjJKaGJGTjBZWFJsUEdKNWRHVnpQaWg3SUdsdWFYUnBZV3hXWVd4MVpUb2dRbmwwWlhNb0p5Y3BMQ0JyWlhrNklDZHpaV1ZrSnlCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWMyVmxaQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5MGVYQmxjeTl0YjJOckxYSmhibVJ2Ylc1bGMzTXRZbVZoWTI5dUxtRnNaMjh1ZEhNNk16Z0tJQ0FnSUM4dklHbG1JQ2gwYUdsekxuTmxaV1F1ZG1Gc2RXVXViR1Z1WjNSb0lENGdNQ2tnZXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHeGxiZ29nSUNBZ1lub2daMlYwWDJGbWRHVnlYMmxtWDJWc2MyVkFPUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNSNWNHVnpMMjF2WTJzdGNtRnVaRzl0Ym1WemN5MWlaV0ZqYjI0dVlXeG5ieTUwY3pvek9Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVjMlZsWkM1MllXeDFaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTkwZVhCbGN5OXRiMk5yTFhKaGJtUnZiVzVsYzNNdFltVmhZMjl1TG1Gc1oyOHVkSE02TVRNS0lDQWdJQzh2SUhObFpXUWdQU0JIYkc5aVlXeFRkR0YwWlR4aWVYUmxjejRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJRUo1ZEdWektDY25LU3dnYTJWNU9pQW5jMlZsWkNjZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luTmxaV1FpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmRIbHdaWE12Ylc5amF5MXlZVzVrYjIxdVpYTnpMV0psWVdOdmJpNWhiR2R2TG5Sek9qTTVDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTV6WldWa0xuWmhiSFZsQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNSNWNHVnpMMjF2WTJzdGNtRnVaRzl0Ym1WemN5MWlaV0ZqYjI0dVlXeG5ieTUwY3pveU5nb2dJQ0FnTHk4Z1oyVjBLSEp2ZFc1a09pQjFhVzUwTmpRc0lIVnpaWEpFWVhSaE9pQmllWFJsY3lrNklHSjVkR1Z6SUhzS0lDQWdJR0lnWjJWMFgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwzUjVjR1Z6TDIxdlkyc3RjbUZ1Wkc5dGJtVnpjeTFpWldGamIyNHVZV3huYnk1MGN6bzZUVzlqYTFKaGJtUnZiVzVsYzNOQ1pXRmpiMjR1WjJWMFFERXdDZ3BuWlhSZllXWjBaWEpmYVdaZlpXeHpaVUE1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwzUjVjR1Z6TDIxdlkyc3RjbUZ1Wkc5dGJtVnpjeTFpWldGamIyNHVZV3huYnk1MGN6bzBNd29nSUNBZ0x5OGdjbVYwZFhKdUlFSjVkR1Z6TG1aeWIyMUlaWGdvSnpBeE1ESXdNekEwTURVd05qQTNNRGd3T1RCaE1HSXdZekJrTUdVd1pqRXdNVEV4TWpFek1UUXhOVEUyTVRjeE9ERTVNV0V4WWpGak1XUXhaVEZtTWpBbktRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1ERXdNakF6TURRd05UQTJNRGN3T0RBNU1HRXdZakJqTUdRd1pUQm1NVEF4TVRFeU1UTXhOREUxTVRZeE56RTRNVGt4WVRGaU1XTXhaREZsTVdZeU1Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMM1I1Y0dWekwyMXZZMnN0Y21GdVpHOXRibVZ6Y3kxaVpXRmpiMjR1WVd4bmJ5NTBjem95TmdvZ0lDQWdMeThnWjJWMEtISnZkVzVrT2lCMWFXNTBOalFzSUhWelpYSkVZWFJoT2lCaWVYUmxjeWs2SUdKNWRHVnpJSHNLSUNBZ0lHSWdaMlYwWDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNSNWNHVnpMMjF2WTJzdGNtRnVaRzl0Ym1WemN5MWlaV0ZqYjI0dVlXeG5ieTUwY3pvNlRXOWphMUpoYm1SdmJXNWxjM05DWldGamIyNHVaMlYwUURFd0Nnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwzUjVjR1Z6TDIxdlkyc3RjbUZ1Wkc5dGJtVnpjeTFpWldGamIyNHVZV3huYnk1MGN6bzZUVzlqYTFKaGJtUnZiVzVsYzNOQ1pXRmpiMjR1YzJWMFUyVmxaRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25ObGRGTmxaV1E2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmRIbHdaWE12Ylc5amF5MXlZVzVrYjIxdVpYTnpMV0psWVdOdmJpNWhiR2R2TG5Sek9qUTNDaUFnSUNBdkx5QnpaWFJUWldWa0tITmxaV1E2SUdKNWRHVnpLVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwzUjVjR1Z6TDIxdlkyc3RjbUZ1Wkc5dGJtVnpjeTFpWldGamIyNHVZV3huYnk1MGN6b3hNd29nSUNBZ0x5OGdjMlZsWkNBOUlFZHNiMkpoYkZOMFlYUmxQR0o1ZEdWelBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ1FubDBaWE1vSnljcExDQnJaWGs2SUNkelpXVmtKeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYzJWbFpDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTkwZVhCbGN5OXRiMk5yTFhKaGJtUnZiVzVsYzNNdFltVmhZMjl1TG1Gc1oyOHVkSE02TkRnS0lDQWdJQzh2SUhSb2FYTXVjMlZsWkM1MllXeDFaU0E5SUhObFpXUUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12ZEhsd1pYTXZiVzlqYXkxeVlXNWtiMjF1WlhOekxXSmxZV052Ymk1aGJHZHZMblJ6T2pRM0NpQWdJQ0F2THlCelpYUlRaV1ZrS0hObFpXUTZJR0o1ZEdWektUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwzUjVjR1Z6TDIxdlkyc3RjbUZ1Wkc5dGJtVnpjeTFpWldGamIyNHVZV3huYnk1MGN6bzZUVzlqYTFKaGJtUnZiVzVsYzNOQ1pXRmpiMjR1YzJWMFJXMXdkSGxiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwelpYUkZiWEIwZVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OTBlWEJsY3k5dGIyTnJMWEpoYm1SdmJXNWxjM010WW1WaFkyOXVMbUZzWjI4dWRITTZOVElLSUNBZ0lDOHZJSE5sZEVWdGNIUjVLR1Z0Y0hSNU9pQmliMjlzWldGdUtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WW05dmJBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMM1I1Y0dWekwyMXZZMnN0Y21GdVpHOXRibVZ6Y3kxaVpXRmpiMjR1WVd4bmJ5NTBjem94TlFvZ0lDQWdMeThnWlcxd2RIa2dQU0JIYkc5aVlXeFRkR0YwWlR4aWIyOXNaV0Z1UGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nWm1Gc2MyVXNJR3RsZVRvZ0oyVnRjSFI1SnlCOUtRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaVpXMXdkSGtpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmRIbHdaWE12Ylc5amF5MXlZVzVrYjIxdVpYTnpMV0psWVdOdmJpNWhiR2R2TG5Sek9qVXpDaUFnSUNBdkx5QjBhR2x6TG1WdGNIUjVMblpoYkhWbElEMGdaVzF3ZEhrS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZkSGx3WlhNdmJXOWpheTF5WVc1a2IyMXVaWE56TFdKbFlXTnZiaTVoYkdkdkxuUnpPalV5Q2lBZ0lDQXZMeUJ6WlhSRmJYQjBlU2hsYlhCMGVUb2dZbTl2YkdWaGJpazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OTBlWEJsY3k5dGIyTnJMWEpoYm1SdmJXNWxjM010WW1WaFkyOXVMbUZzWjI4dWRITTZPazF2WTJ0U1lXNWtiMjF1WlhOelFtVmhZMjl1TG5ObGRGTjFZbTFwZEV4aFoxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEZOMVltMXBkRXhoWnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OTBlWEJsY3k5dGIyTnJMWEpoYm1SdmJXNWxjM010WW1WaFkyOXVMbUZzWjI4dWRITTZOVGNLSUNBZ0lDOHZJSE5sZEZOMVltMXBkRXhoWnloc1lXYzZJSFZwYm5RMk5DazZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNSNWNHVnpMMjF2WTJzdGNtRnVaRzl0Ym1WemN5MWlaV0ZqYjI0dVlXeG5ieTUwY3pveU1Rb2dJQ0FnTHk4Z2MzVmliV2wwVEdGbklEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUdsdWFYUnBZV3hXWVd4MVpUb2dNQ3dnYTJWNU9pQW5jM1ZpYldsMFRHRm5KeUI5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYzNWaWJXbDBUR0ZuSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwzUjVjR1Z6TDIxdlkyc3RjbUZ1Wkc5dGJtVnpjeTFpWldGamIyNHVZV3huYnk1MGN6bzFPQW9nSUNBZ0x5OGdkR2hwY3k1emRXSnRhWFJNWVdjdWRtRnNkV1VnUFNCc1lXY0tJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12ZEhsd1pYTXZiVzlqYXkxeVlXNWtiMjF1WlhOekxXSmxZV052Ymk1aGJHZHZMblJ6T2pVM0NpQWdJQ0F2THlCelpYUlRkV0p0YVhSTVlXY29iR0ZuT2lCMWFXNTBOalFwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUlBaVlFQkhObFpXUUpjM1ZpYldsMFRHRm5BQVZsYlhCMGVURVlRQUFKS0Nwbkt5Sm5LU0puTVJ0QkFDc3hHUlJFTVJoRWdnUUVHSk9TeFFSZEpMSWFCT29Fb0V3RWxQa1FPellhQUk0RUFBa0FqUUNpQUxFQU1Sa1VNUmdVRUVNMkdnRkpGU1FTUkJjMkdnSkpJbGtsQ0V3VkVrUWlLMlZFUVFBVUtra1ZGbGNHQWt4UWdBUVZIM3gxVEZDd0kwTWlLV1ZFUVFBWlNZRUhDQ1FLSkFzeUJpSXBaVVJQQWdnTVFRQUVLa0wvelNJb1pVUVZRUUFISWlobFJFTC92b0FnQVFJREJBVUdCd2dKQ2dzTURRNFBFQkVTRXhRVkZoY1lHUm9iSEIwZUh5QkMvNWsyR2dGSklsa2xDRXNCRlJKRVZ3SUFLRXhuSTBNMkdnRkpGU01TUkNKVEsweG5JME0yR2dGSkZTUVNSQmNwVEdjalF3PT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjoxMCwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
