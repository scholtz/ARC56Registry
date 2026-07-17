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

namespace Arc56.Generated.scholtz.TestUint256.TestUint_792cb349
{


    public class TestUintProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TestUintProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="n"> </param>
        public async Task<ulong> Uint256Touint64(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 n, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 205, 207, 244 };

            var result = await base.SimApp(new List<object> { abiHandle, n }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Uint256Touint64_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 n, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 205, 207, 244 };

            return await base.MakeTransactionList(new List<object> { abiHandle, n }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="n"> </param>
        public async Task<ulong> Uint256ToUintN64(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 n, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 223, 43, 176, 41 };

            var result = await base.SimApp(new List<object> { abiHandle, n }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Uint256ToUintN64_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 n, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 223, 43, 176, 41 };

            return await base.MakeTransactionList(new List<object> { abiHandle, n }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="n"> </param>
        public async Task<ulong> SafeConversion(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 n, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 218, 11, 96, 243 };

            var result = await base.SimApp(new List<object> { abiHandle, n }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SafeConversion_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 n, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 218, 11, 96, 243 };

            return await base.MakeTransactionList(new List<object> { abiHandle, n }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="n"> </param>
        public async Task<ulong> ConvertToUintN64UsingInterpretAsArc4(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 n, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 188, 87, 115, 26 };

            var result = await base.SimApp(new List<object> { abiHandle, n }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ConvertToUintN64UsingInterpretAsArc4_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 n, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 188, 87, 115, 26 };

            return await base.MakeTransactionList(new List<object> { abiHandle, n }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVGVzdFVpbnQiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoidWludDI1NlRvdWludDY0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1aW50MjU2VG9VaW50TjY0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzYWZlQ29udmVyc2lvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiQ29udmVydFRvVWludE42NFVzaW5nSW50ZXJwcmV0QXNBcmM0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzIwMSwyMDldLCJlcnJvck1lc3NhZ2UiOiJCdWZmZXIgb3ZlcmZsb3cgLSBwYXJ0MSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxN10sImVycm9yTWVzc2FnZSI6IkJ1ZmZlciBvdmVyZmxvdyAtIHBhcnQzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTgsNzcsOTYsMTE1XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQwXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjEsODAsOTksMTE4XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0NywxNTksMTg2XSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQTRJREFLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGd4TlRGbU4yTTNOUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUmxjM1JmZFdsdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJVWlhOMFZXbHVkQ0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgySmhjbVZmY205MWRHbHVaMEE1Q2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0TWpkalpHTm1aalFnTUhoa1pqSmlZakF5T1NBd2VHUmhNR0kyTUdZeklEQjRZbU0xTnpjek1XRWdMeThnYldWMGFHOWtJQ0oxYVc1ME1qVTJWRzkxYVc1ME5qUW9kV2x1ZERJMU5pbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0luVnBiblF5TlRaVWIxVnBiblJPTmpRb2RXbHVkREkxTmlsMWFXNTBOalFpTENCdFpYUm9iMlFnSW5OaFptVkRiMjUyWlhKemFXOXVLSFZwYm5ReU5UWXBkV2x1ZERZMElpd2diV1YwYUc5a0lDSkRiMjUyWlhKMFZHOVZhVzUwVGpZMFZYTnBibWRKYm5SbGNuQnlaWFJCYzBGeVl6UW9kV2x1ZERJMU5pbDFhVzUwTmpRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDNWcGJuUXlOVFpVYjNWcGJuUTJORjl5YjNWMFpVQXpJRzFoYVc1ZmRXbHVkREkxTmxSdlZXbHVkRTQyTkY5eWIzVjBaVUEwSUcxaGFXNWZjMkZtWlVOdmJuWmxjbk5wYjI1ZmNtOTFkR1ZBTlNCdFlXbHVYME52Ym5abGNuUlViMVZwYm5ST05qUlZjMmx1WjBsdWRHVnljSEpsZEVGelFYSmpORjl5YjNWMFpVQTJDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdWemRGOTFhVzUwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGUmxjM1JWYVc1MElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5RGIyNTJaWEowVkc5VmFXNTBUalkwVlhOcGJtZEpiblJsY25CeVpYUkJjMEZ5WXpSZmNtOTFkR1ZBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwWlhOMFgzVnBiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TndvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwWlhOMFgzVnBiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1ZHVnpkRlZwYm5RZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdWemRGOTFhVzUwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpjS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnWTJGc2JITjFZaUJEYjI1MlpYSjBWRzlWYVc1MFRqWTBWWE5wYm1kSmJuUmxjbkJ5WlhSQmMwRnlZelFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZjMkZtWlVOdmJuWmxjbk5wYjI1ZmNtOTFkR1ZBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwWlhOMFgzVnBiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwWlhOMFgzVnBiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1ZHVnpkRlZwYm5RZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdWemRGOTFhVzUwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnWTJGc2JITjFZaUJ6WVdabFEyOXVkbVZ5YzJsdmJnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MWFXNTBNalUyVkc5VmFXNTBUalkwWDNKdmRYUmxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR1Z6ZEY5MWFXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBaWE4wWDNWcGJuUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVkdWemRGVnBiblFnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR1Z6ZEY5MWFXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQmpZV3hzYzNWaUlIVnBiblF5TlRaVWIxVnBiblJPTmpRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmZFdsdWRESTFObFJ2ZFdsdWREWTBYM0p2ZFhSbFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHVnpkRjkxYVc1MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MFpYTjBYM1ZwYm5RdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdWR1Z6ZEZWcGJuUWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHVnpkRjkxYVc1MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCallXeHNjM1ZpSUhWcGJuUXlOVFpVYjNWcGJuUTJOQW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWlZWEpsWDNKdmRYUnBibWRBT1RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwWlhOMFgzVnBiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1ZHVnpkRlZwYm5RZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREV6Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MFpYTjBYM1ZwYm5RdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlZHVnpkRlZwYm5RdWRXbHVkREkxTmxSdmRXbHVkRFkwS0c0NklHSjVkR1Z6S1NBdFBpQjFhVzUwTmpRNkNuVnBiblF5TlRaVWIzVnBiblEyTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwWlhOMFgzVnBiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTFRZS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnTHk4Z2RXbHVkREkxTmxSdmRXbHVkRFkwS0c0NklGVnBiblJPTWpVMktUb2dkV2x1ZERZMElIc0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JsYzNSZmRXbHVkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamNLSUNBZ0lDOHZJSEpsZEhWeWJpQnVaWGNnVldsdWRFNDJOQ2h1TG01aGRHbDJaU2t1Ym1GMGFYWmxDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1lucGxjbThLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lud0tJQ0FnSUdKMGIya0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MFpYTjBYM1ZwYm5RdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlZHVnpkRlZwYm5RdWRXbHVkREkxTmxSdlZXbHVkRTQyTkNodU9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNuVnBiblF5TlRaVWIxVnBiblJPTmpRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdWemRGOTFhVzUwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1MweE1Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNBdkx5QjFhVzUwTWpVMlZHOVZhVzUwVGpZMEtHNDZJRlZwYm5ST01qVTJLVG9nVldsdWRFNDJOQ0I3Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MFpYTjBYM1ZwYm5RdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUc1bGR5QlZhVzUwVGpZMEtHNHVibUYwYVhabEtRb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUdKNlpYSnZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdKOENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdWemRGOTFhVzUwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xSbGMzUlZhVzUwTG5OaFptVkRiMjUyWlhKemFXOXVLRzQ2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LYzJGbVpVTnZiblpsY25OcGIyNDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHVnpkRjkxYVc1MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UTXRNVFFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdMeThnYzJGbVpVTnZiblpsY25OcGIyNG9iam9nVldsdWRFNHlOVFlwT2lCVmFXNTBUalkwSUhzS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUmxjM1JmZFdsdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXhDaUFnSUNBdkx5QmpiMjV6ZENCc2IzZGxjalkwT2lCaWFXZDFhVzUwSUQwZ2JtRjBhWFpsTWpVMklDWWdLQ2d4YmlBOFBDQTJORzRwSUMwZ01XNHBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHWm1abVptWm1abVptWm1abVptWm1ZS0lDQWdJR0ltQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR1Z6ZEY5MWFXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalFLSUNBZ0lDOHZJR052Ym5OMElIVnBiblEyTkNBOUlHNWxkeUJWYVc1MFRqWTBLR3h2ZDJWeU5qUXBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0JpZW1WeWJ3b2dJQ0FnWW53S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwWlhOMFgzVnBiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TlFvZ0lDQWdMeThnY21WMGRYSnVJSFZwYm5RMk5Bb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSbGMzUmZkV2x1ZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwVVpYTjBWV2x1ZEM1RGIyNTJaWEowVkc5VmFXNTBUalkwVlhOcGJtZEpiblJsY25CeVpYUkJjMEZ5WXpRb2Jqb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncERiMjUyWlhKMFZHOVZhVzUwVGpZMFZYTnBibWRKYm5SbGNuQnlaWFJCYzBGeVl6UTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHVnpkRjkxYVc1MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qY3RNamdLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdMeThnUTI5dWRtVnlkRlJ2VldsdWRFNDJORlZ6YVc1blNXNTBaWEp3Y21WMFFYTkJjbU0wS0c0NklGVnBiblJPTWpVMktUb2dWV2x1ZEU0Mk5DQjdDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwWlhOMFgzVnBiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TXdvZ0lDQWdMeThnWTI5dWMzUWdjR0Z5ZERFZ1BTQmhjbU0wTG1sdWRHVnljSEpsZEVGelFYSmpORHhoY21NMExsVnBiblJPTmpRK0tHSjVkR1Z6TG5Oc2FXTmxLREFzSURncExDQW5ibTl1WlNjcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSE4xWW5OMGNtbHVaeUF3SURnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwWlhOMFgzVnBiblF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TkFvZ0lDQWdMeThnWVhOelpYSjBLSEJoY25ReExtNWhkR2wyWlNBOVBUMGdNQ3dnSjBKMVptWmxjaUJ2ZG1WeVpteHZkeUF0SUhCaGNuUXhKeWtLSUNBZ0lHSjBiMmtLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2RXWm1aWElnYjNabGNtWnNiM2NnTFNCd1lYSjBNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUmxjM1JmZFdsdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTJDaUFnSUNBdkx5QmpiMjV6ZENCd1lYSjBNaUE5SUdGeVl6UXVhVzUwWlhKd2NtVjBRWE5CY21NMFBHRnlZelF1VldsdWRFNDJORDRvWW5sMFpYTXVjMnhwWTJVb09Dd2dNVFlwTENBbmJtOXVaU2NwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lITjFZbk4wY21sdVp5QTRJREUyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR1Z6ZEY5MWFXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNemNLSUNBZ0lDOHZJR0Z6YzJWeWRDaHdZWEowTWk1dVlYUnBkbVVnUFQwOUlEQXNJQ2RDZFdabVpYSWdiM1psY21ac2IzY2dMU0J3WVhKME1TY3BDaUFnSUNCaWRHOXBDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnUW5WbVptVnlJRzkyWlhKbWJHOTNJQzBnY0dGeWRERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MFpYTjBYM1ZwYm5RdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek9Rb2dJQ0FnTHk4Z1kyOXVjM1FnY0dGeWRETWdQU0JoY21NMExtbHVkR1Z5Y0hKbGRFRnpRWEpqTkR4aGNtTTBMbFZwYm5ST05qUStLR0o1ZEdWekxuTnNhV05sS0RFMkxDQXlOQ2tzSUNkdWIyNWxKeWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2MzVmljM1J5YVc1bklERTJJREkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR1Z6ZEY5MWFXNTBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOREFLSUNBZ0lDOHZJR0Z6YzJWeWRDaHdZWEowTXk1dVlYUnBkbVVnUFQwOUlEQXNJQ2RDZFdabVpYSWdiM1psY21ac2IzY2dMU0J3WVhKME15Y3BDaUFnSUNCaWRHOXBDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnUW5WbVptVnlJRzkyWlhKbWJHOTNJQzBnY0dGeWRETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MFpYTjBYM1ZwYm5RdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME1nb2dJQ0FnTHk4Z1kyOXVjM1FnZFdsdWREWTBRbmwwWlhNZ1BTQmllWFJsY3k1emJHbGpaU2d5TkN3Z016SXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhOMVluTjBjbWx1WnlBeU5DQXpNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUmxjM1JmZFdsdWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXpDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVwYm5SbGNuQnlaWFJCYzBGeVl6UThZWEpqTkM1VmFXNTBUalkwUGloMWFXNTBOalJDZVhSbGN5d2dKMjV2Ym1VbktRb2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFEQVFnQUpnRUVGUjk4ZFRFYlFRQnlnZ1FFSjgzUDlBVGZLN0FwQk5vTFlQTUV2RmR6R2pZYUFJNEVBRHNBS0FBVkFBSWtRekVaRkVReEdFUTJHZ0dJQUhzb1RGQ3dJa014R1JSRU1SaEVOaG9CaUFCUEtFeFFzQ0pETVJrVVJERVlSRFlhQVlnQU1TaE1VTEFpUXpFWkZFUXhHRVEyR2dHSUFCSVdLRXhRc0NKRE1SbEEvNnd4R0JSRUlrT0tBUUVrUkNPdmkvK3JGNG1LQVFFa1JDT3ZpLytyaVlvQkFZdi9nQWovLy8vLy8vLy8vNnhKRlNNT1JDT3ZxNG1LQVFHTC8xRUFDQmNVUkl2L1VRZ1FGeFJFaS85UkVCZ1hGRVNMLzFFWUlJaz0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo3LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
