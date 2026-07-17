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

namespace Arc56.Generated.algorandfoundation.puya_ts_demo.Simple_da331480
{


    public class SimpleProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SimpleProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        ///
        ///</summary>
        /// <param name="i"> </param>
        public async Task Incr(ulong i, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 159, 171, 134, 16 };
            var iAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); iAbi.From(i);

            var result = await base.CallApp(new List<object> { abiHandle, iAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Incr_Transactions(ulong i, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 159, 171, 134, 16 };
            var iAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); iAbi.From(i);

            return await base.MakeTransactionList(new List<object> { abiHandle, iAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="i"> </param>
        public async Task Decr(ulong i, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 46, 12, 90, 71 };
            var iAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); iAbi.From(i);

            var result = await base.CallApp(new List<object> { abiHandle, iAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Decr_Transactions(ulong i, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 46, 12, 90, 71 };
            var iAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); iAbi.From(i);

            return await base.MakeTransactionList(new List<object> { abiHandle, iAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Add(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 a, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 151, 110, 2 };

            var result = await base.CallApp(new List<object> { abiHandle, a, b }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Add_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 a, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 151, 110, 2 };

            return await base.MakeTransactionList(new List<object> { abiHandle, a, b }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Sub(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 a, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 9, 27, 50, 167 };

            var result = await base.CallApp(new List<object> { abiHandle, a, b }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Sub_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 a, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 9, 27, 50, 167 };

            return await base.MakeTransactionList(new List<object> { abiHandle, a, b }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU2ltcGxlIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImluY3IiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWNyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWRkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzdWIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMzJdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTcsMTExXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTMwLDE1MV0sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBek1pQXdDaUFnSUNCaWVYUmxZMkpzYjJOcklDSmpiM1Z1ZEdWeUlpQXdlREUxTVdZM1l6YzFDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmMybHRjR3hsTDNOcGJYQnNaUzVoYkdkdkxuUnpPakV3Q2lBZ0lDQXZMeUJqYjNWdWRHVnlJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHdGxlVG9nSW1OdmRXNTBaWElpTENCcGJtbDBhV0ZzVm1Gc2RXVTZJREFnZlNrN0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKamIzVnVkR1Z5SWdvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXphVzF3YkdVdmMybHRjR3hsTG1Gc1oyOHVkSE02T1FvZ0lDQWdMeThnWlhod2IzSjBJR1JsWm1GMWJIUWdZMnhoYzNNZ1UybHRjR3hsSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCdGRYTjBJR0psSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllaUJ0WVdsdVgyTnlaV0YwWlY5T2IwOXdRREV3Q2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0T1daaFlqZzJNVEFnTUhneVpUQmpOV0UwTnlBd2VHRmpPVGMyWlRBeUlEQjRNRGt4WWpNeVlUY2dMeThnYldWMGFHOWtJQ0pwYm1OeUtIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0prWldOeUtIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0poWkdRb2RXbHVkREkxTml4MWFXNTBNalUyS1hWcGJuUXlOVFlpTENCdFpYUm9iMlFnSW5OMVlpaDFhVzUwTWpVMkxIVnBiblF5TlRZcGRXbHVkREkxTmlJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHbHVZM0lnWkdWamNpQmhaR1FnYzNWaUNpQWdJQ0JsY25JS0NtMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU1UQTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjMmx0Y0d4bEwzTnBiWEJzWlM1aGJHZHZMblJ6T2prS0lDQWdJQzh2SUdWNGNHOXlkQ0JrWldaaGRXeDBJR05zWVhOeklGTnBiWEJzWlNCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdJNE5EUTNZak0ySUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsUVhCd2JHbGpZWFJwYjI0b0tYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMk55WldGMFpVRndjR3hwWTJGMGFXOXVYM0p2ZFhSbFFERXhDaUFnSUNCbGNuSUtDbTFoYVc1ZlkzSmxZWFJsUVhCd2JHbGpZWFJwYjI1ZmNtOTFkR1ZBTVRFNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmMybHRjR3hsTDNOcGJYQnNaUzVoYkdkdkxuUnpPakUyQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2IyNURjbVZoZEdVNklDSnlaWEYxYVhKbElpQjlLUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTnZiblJ5WVdOMGN5OXphVzF3YkdVdmMybHRjR3hsTG1Gc1oyOHVkSE02T2xOcGJYQnNaUzVwYm1OeVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0thVzVqY2pvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5emFXMXdiR1V2YzJsdGNHeGxMbUZzWjI4dWRITTZNVGtLSUNBZ0lDOHZJR2x1WTNJb2FUb2dkV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmMybHRjR3hsTDNOcGJYQnNaUzVoYkdkdkxuUnpPakV6Q2lBZ0lDQXZMeUIwYUdsekxtTnZkVzUwWlhJdWRtRnNkV1VnUFNCMGFHbHpMbU52ZFc1MFpYSXVkbUZzZFdVZ0t5QnBPd29nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXphVzF3YkdVdmMybHRjR3hsTG1Gc1oyOHVkSE02TVRBS0lDQWdJQzh2SUdOdmRXNTBaWElnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhMlY1T2lBaVkyOTFiblJsY2lJc0lHbHVhWFJwWVd4V1lXeDFaVG9nTUNCOUtUc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltTnZkVzUwWlhJaUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmMybHRjR3hsTDNOcGJYQnNaUzVoYkdkdkxuUnpPakV6Q2lBZ0lDQXZMeUIwYUdsekxtTnZkVzUwWlhJdWRtRnNkV1VnUFNCMGFHbHpMbU52ZFc1MFpYSXVkbUZzZFdVZ0t5QnBPd29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUNzS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5emFXMXdiR1V2YzJsdGNHeGxMbUZzWjI4dWRITTZNVEFLSUNBZ0lDOHZJR052ZFc1MFpYSWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFpWTI5MWJuUmxjaUlzSUdsdWFYUnBZV3hXWVd4MVpUb2dNQ0I5S1RzS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1OdmRXNTBaWElpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YzJsdGNHeGxMM05wYlhCc1pTNWhiR2R2TG5Sek9qRXpDaUFnSUNBdkx5QjBhR2x6TG1OdmRXNTBaWEl1ZG1Gc2RXVWdQU0IwYUdsekxtTnZkVzUwWlhJdWRtRnNkV1VnS3lCcE93b2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXphVzF3YkdVdmMybHRjR3hsTG1Gc1oyOHVkSE02TVRrS0lDQWdJQzh2SUdsdVkzSW9hVG9nZFdsdWREWTBLVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1kyOXVkSEpoWTNSekwzTnBiWEJzWlM5emFXMXdiR1V1WVd4bmJ5NTBjem82VTJsdGNHeGxMbVJsWTNKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGtaV055T2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNOcGJYQnNaUzl6YVcxd2JHVXVZV3huYnk1MGN6b3lNd29nSUNBZ0x5OGdaR1ZqY2locE9pQjFhVzUwTmpRcE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5emFXMXdiR1V2YzJsdGNHeGxMbUZzWjI4dWRITTZNalFLSUNBZ0lDOHZJSFJvYVhNdVkyOTFiblJsY2k1MllXeDFaU0E5SUhSb2FYTXVZMjkxYm5SbGNpNTJZV3gxWlNBdElHazdDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzTnBiWEJzWlM5emFXMXdiR1V1WVd4bmJ5NTBjem94TUFvZ0lDQWdMeThnWTI5MWJuUmxjaUE5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNKamIzVnVkR1Z5SWl3Z2FXNXBkR2xoYkZaaGJIVmxPaUF3SUgwcE93b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVkyOTFiblJsY2lJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5emFXMXdiR1V2YzJsdGNHeGxMbUZzWjI4dWRITTZNalFLSUNBZ0lDOHZJSFJvYVhNdVkyOTFiblJsY2k1MllXeDFaU0E5SUhSb2FYTXVZMjkxYm5SbGNpNTJZV3gxWlNBdElHazdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnYzNkaGNBb2dJQ0FnTFFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNOcGJYQnNaUzl6YVcxd2JHVXVZV3huYnk1MGN6b3hNQW9nSUNBZ0x5OGdZMjkxYm5SbGNpQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ0pqYjNWdWRHVnlJaXdnYVc1cGRHbGhiRlpoYkhWbE9pQXdJSDBwT3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWTI5MWJuUmxjaUlLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl6YVcxd2JHVXZjMmx0Y0d4bExtRnNaMjh1ZEhNNk1qUUtJQ0FnSUM4dklIUm9hWE11WTI5MWJuUmxjaTUyWVd4MVpTQTlJSFJvYVhNdVkyOTFiblJsY2k1MllXeDFaU0F0SUdrN0NpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzTnBiWEJzWlM5emFXMXdiR1V1WVd4bmJ5NTBjem95TXdvZ0lDQWdMeThnWkdWamNpaHBPaUIxYVc1ME5qUXBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCamIyNTBjbUZqZEhNdmMybHRjR3hsTDNOcGJYQnNaUzVoYkdkdkxuUnpPanBUYVcxd2JHVXVZV1JrVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1lXUmtPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM05wYlhCc1pTOXphVzF3YkdVdVlXeG5ieTUwY3pveU53b2dJQ0FnTHk4Z1lXUmtLR0U2SUZWcGJuUXlOVFlzSUdJNklGVnBiblF5TlRZcE9pQlZhVzUwTWpVMklIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXphVzF3YkdVdmMybHRjR3hsTG1Gc1oyOHVkSE02TWpnS0lDQWdJQzh2SUhKbGRIVnliaUJ1WlhjZ1ZXbHVkREkxTmloaExtRnpRbWxuVldsdWRDZ3BJQ3NnWWk1aGMwSnBaMVZwYm5Rb0tTazdDaUFnSUNCaUt3b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWW53S0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5emFXMXdiR1V2YzJsdGNHeGxMbUZzWjI4dWRITTZNamNLSUNBZ0lDOHZJR0ZrWkNoaE9pQlZhVzUwTWpVMkxDQmlPaUJWYVc1ME1qVTJLVG9nVldsdWRESTFOaUI3Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZMjl1ZEhKaFkzUnpMM05wYlhCc1pTOXphVzF3YkdVdVlXeG5ieTUwY3pvNlUybHRjR3hsTG5OMVlsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk4xWWpvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5emFXMXdiR1V2YzJsdGNHeGxMbUZzWjI4dWRITTZNekVLSUNBZ0lDOHZJSE4xWWloaE9pQlZhVzUwTWpVMkxDQmlPaUJWYVc1ME1qVTJLVG9nVldsdWRESTFOaUI3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YzJsdGNHeGxMM05wYlhCc1pTNWhiR2R2TG5Sek9qTXlDaUFnSUNBdkx5QnlaWFIxY200Z2JtVjNJRlZwYm5ReU5UWW9ZUzVoYzBKcFoxVnBiblFvS1NBdElHSXVZWE5DYVdkVmFXNTBLQ2twT3dvZ0lDQWdZaTBLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHSjhDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjMmx0Y0d4bEwzTnBiWEJzWlM1aGJHZHZMblJ6T2pNeENpQWdJQ0F2THlCemRXSW9ZVG9nVldsdWRESTFOaXdnWWpvZ1ZXbHVkREkxTmlrNklGVnBiblF5TlRZZ2V3b2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmpiMjUwY21GamRITXZjMmx0Y0d4bEwzTnBiWEJzWlM1aGJHZHZMblJ6T2pwVGFXMXdiR1V1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0pqYjNWdWRHVnlJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM05wYlhCc1pTOXphVzF3YkdVdVlXeG5ieTUwY3pveE13b2dJQ0FnTHk4Z2RHaHBjeTVqYjNWdWRHVnlMblpoYkhWbElEMGdkR2hwY3k1amIzVnVkR1Z5TG5aaGJIVmxJQ3NnYVRzS0lDQWdJSEIxYzJocGJuUWdNQ0F2THlBd0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmMybHRjR3hsTDNOcGJYQnNaUzVoYkdkdkxuUnpPakV3Q2lBZ0lDQXZMeUJqYjNWdWRHVnlJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHdGxlVG9nSW1OdmRXNTBaWElpTENCcGJtbDBhV0ZzVm1Gc2RXVTZJREFnZlNrN0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKamIzVnVkR1Z5SWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNOcGJYQnNaUzl6YVcxd2JHVXVZV3huYnk1MGN6b3hNd29nSUNBZ0x5OGdkR2hwY3k1amIzVnVkR1Z5TG5aaGJIVmxJRDBnZEdocGN5NWpiM1Z1ZEdWeUxuWmhiSFZsSUNzZ2FUc0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmMybHRjR3hsTDNOcGJYQnNaUzVoYkdkdkxuUnpPak0yQ2lBZ0lDQXZMeUIwYUdsekxtbHVZM0psYldWdWRFTnZkVzUwWlhJb01TazdDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM05wYlhCc1pTOXphVzF3YkdVdVlXeG5ieTUwY3pveE13b2dJQ0FnTHk4Z2RHaHBjeTVqYjNWdWRHVnlMblpoYkhWbElEMGdkR2hwY3k1amIzVnVkR1Z5TG5aaGJIVmxJQ3NnYVRzS0lDQWdJQ3NLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl6YVcxd2JHVXZjMmx0Y0d4bExtRnNaMjh1ZEhNNk1UQUtJQ0FnSUM4dklHTnZkVzUwWlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQWlZMjkxYm5SbGNpSXNJR2x1YVhScFlXeFdZV3gxWlRvZ01DQjlLVHNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbU52ZFc1MFpYSWlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjMmx0Y0d4bEwzTnBiWEJzWlM1aGJHZHZMblJ6T2pFekNpQWdJQ0F2THlCMGFHbHpMbU52ZFc1MFpYSXVkbUZzZFdVZ1BTQjBhR2x6TG1OdmRXNTBaWEl1ZG1Gc2RXVWdLeUJwT3dvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5emFXMXdiR1V2YzJsdGNHeGxMbUZzWjI4dWRITTZNemNLSUNBZ0lDOHZJSEpsZEhWeWJpQjBjblZsT3dvZ0lDQWdjSFZ6YUdsdWRDQXhJQzh2SURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFEQVNBQUpnSUhZMjkxYm5SbGNnUVZIM3gxTVJoQUFBTW9KR2N4R1JSRU1SaEJBQ1NDQkFTZnE0WVFCQzRNV2tjRXJKZHVBZ1FKR3pLbk5ob0FqZ1FBRVFBZkFDNEFRd0NBQkxoRWV6WTJHZ0NPQVFBQkFDSkROaG9CRnlRb1pVUUlLRXhuSWtNMkdnRVhKQ2hsUkV3SktFeG5Ja00yR2dFMkdnS2dTUlVqRGtRanI2c3BURkN3SWtNMkdnRTJHZ0toU1JVakRrUWpyNnNwVEZDd0lrTT0iLCJjbGVhciI6IkNpWUJCMk52ZFc1MFpYS0JBQ2hsUklFQkNDaE1aNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
