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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.sender_00ba0c7a
{


    public class senderProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public senderProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task PostInit(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 204, 73, 227 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PostInit_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 204, 73, 227 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Fallback(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 249, 136, 43 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Fallback_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 249, 136, 43 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> Forward(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 11, 229, 47 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Forward_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 11, 229, 47 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> Clear(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 243, 33, 188, 61 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Clear_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 243, 33, 188, 61 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Val(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 112, 182, 90, 227 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Val_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 112, 182, 90, 227 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoic2VuZGVyIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6Il9fcG9zdEluaXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiX19mYWxsYmFjayIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJmb3J3YXJkIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNsZWFyIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZhbCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzQyOF0sImVycm9yTWVzc2FnZSI6Il9fcG9zdEluaXQgYWxyZWFkeSBjYWxsZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjIsMzcxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgcmVjIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxNywyOTIsMzI0LDUxNV0sImVycm9yTWVzc2FnZSI6Im5vdCBwYXlhYmxlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjU2XSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dmRHVnpkSE12YzI5c2FXUnBkSGt0YzJWdFlXNTBhV010ZEdWemRITXZkR1Z6ZEhNdlptRnNiR0poWTJzdlkyRnNiRjltYjNKM1lYSmtYMko1ZEdWekxuTnZiQzV6Wlc1a1pYSXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdOaUEwQ2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0p6WVhabFpFUmhkR0VpSURCNElDSmZYMk4wYjNKZmNHVnVaR2x1WnlJZ0luSmxZeUlnTUhneE5URm1OMk0zTlRnd0lGUk5VRXhmUVZCUVVrOVdRVXhmY21WalpXbDJaWElnVkUxUVRGOURURVZCVWw5eVpXTmxhWFpsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHUjFjQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlJZ29nSUNBZ1pIVndiaUF6Q2lBZ0lDQndkWE5vYVc1MElEUXdPVFlLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmtkWEFLSUNBZ0lITjBiM0psSURVS0lDQWdJSE4wYjNKbElEQUtJQ0FnSUd4dllXUWdNQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQTRNQW9nSUNBZ2NtVndiR0ZqWlRJZ05qUUtJQ0FnSUhOMGIzSmxJREFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0lsOWZZM1J2Y2w5d1pXNWthVzVuSWdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRFFLSUNBZ0lHTmhiR3h6ZFdJZ1gxOW1ZV3hzWW1GamF3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRFE2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1luVnllU0EwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVpQnRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTVRRS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhoaVlXTmpORGxsTXlBd2VERmlaams0T0RKaUlEQjRNR1F3WW1VMU1tWWdNSGhtTXpJeFltTXpaQ0F3ZURjd1lqWTFZV1V6SUM4dklHMWxkR2h2WkNBaVgxOXdiM04wU1c1cGRDZ3BkbTlwWkNJc0lHMWxkR2h2WkNBaVgxOW1ZV3hzWW1GamF5Z3BkbTlwWkNJc0lHMWxkR2h2WkNBaVptOXlkMkZ5WkNncFltOXZiQ0lzSUcxbGRHaHZaQ0FpWTJ4bFlYSW9LV0p2YjJ3aUxDQnRaWFJvYjJRZ0luWmhiQ2dwZFdsdWRESTFOaUlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZYMTl3YjNOMFNXNXBkRjl5YjNWMFpVQTVJRzFoYVc1ZlgxOW1ZV3hzWW1GamExOXliM1YwWlVBeE1DQnRZV2x1WDJadmNuZGhjbVJmY205MWRHVkFNVEVnYldGcGJsOWpiR1ZoY2w5eWIzVjBaVUF4TWlCdFlXbHVYM1poYkY5eWIzVjBaVUF4TXdvS2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRREUwT2dvZ0lDQWdaR2xuSURNS0lDQWdJR0oxY25rZ013b2dJQ0FnWkdsbklESUtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFOZ29nSUNBZ1kyRnNiSE4xWWlCZlgyWmhiR3hpWVdOckNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdZblZ5ZVNBekNncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFOam9LSUNBZ0lHUnBaeUF5Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmZG1Gc1gzSnZkWFJsUURFek9nb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdKNklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXhPUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXlNRG9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbkpsWXlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnY21WaklHVjRhWE4wY3dvZ0lDQWdjSFZ6YUdsdWRDQXlOQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR05mTWlBdkx5QTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoak5EY3pORE13WlNBdkx5QnRaWFJvYjJRZ0luSmxZMlZwZG1Wa0tDbDFhVzUwTWpVMklnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdjSFZ6YUdsdWRDQXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHSjhDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JpZFhKNUlEUUtJQ0FnSUdJZ2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRREUwQ2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1UazZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1qQUtDbTFoYVc1ZlkyeGxZWEpmY205MWRHVkFNVEk2Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURJMENpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURJMU9nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p6WVhabFpFUmhkR0VpQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5OaGRtVmtSR0YwWVNJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3hOVEZtTjJNM05UZ3dDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JpZFhKNUlEUUtJQ0FnSUdJZ2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRREUwQ2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1qUTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1qVUtDbTFoYVc1ZlptOXlkMkZ5WkY5eWIzVjBaVUF4TVRvS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1qa0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU16QTZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5OaGRtVmtSR0YwWVNJS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ0tJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURjS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHeGxiZ29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRE1LSUNBZ0lHbHVkR05mTXlBdkx5QTBDaUFnSUNBK1BRb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlESUtJQ0FnSUdKNklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXpNZ29nSUNBZ1pHbG5JRFVLSUNBZ0lHVjRkSEpoWTNRZ01DQTBDaUFnSUNCaWRYSjVJRFVLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBek16b0tJQ0FnSUdSMWNBb2dJQ0FnWW5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFETTFDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh6SUM4dklEUUtJQ0FnSUMwS0lDQWdJR1JwWnlBMkNpQWdJQ0JwYm5Salh6TWdMeThnTkFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCbGVIUnlZV04wTXdvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFETTJPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0luSmxZeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djbVZqSUdWNGFYTjBjd29nSUNBZ2NIVnphR2x1ZENBeU5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNaUF2THlBMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmthV2NnTlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ1lubDBaV01nTkNBdkx5QXdlREUxTVdZM1l6YzFPREFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdKMWNua2dOQW9nSUNBZ1lpQnRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTVRRS0NtMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXpOVG9LSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGdLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRE0yQ2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU16STZDaUFnSUNCa2FXY2dOUW9nSUNBZ1luVnllU0ExQ2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF6TXdvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFESTVPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFETXdDZ3B0WVdsdVgxOWZabUZzYkdKaFkydGZjbTkxZEdWQU1UQTZDaUFnSUNCallXeHNjM1ZpSUY5ZlptRnNiR0poWTJzS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmlkWEo1SURRS0lDQWdJR0lnYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFERTBDZ3B0WVdsdVgxOWZjRzl6ZEVsdWFYUmZjbTkxZEdWQU9Ub0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0lsOWZZM1J2Y2w5d1pXNWthVzVuSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJmWDNCdmMzUkpibWwwSUdGc2NtVmhaSGtnWTJGc2JHVmtDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmZYMk4wYjNKZmNHVnVaR2x1WnlJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ1lubDBaV01nTlNBdkx5QlVUVkJNWDBGUVVGSlBWa0ZNWDNKbFkyVnBkbVZ5Q2lBZ0lDQmllWFJsWXlBMklDOHZJRlJOVUV4ZlEweEZRVkpmY21WalpXbDJaWElLSUNBZ0lHbHVkR05mTWlBdkx5QTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0J3ZFhOb2FXNTBJREUyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRWRzYjJKaGJFNTFiVlZwYm5RS0lDQWdJSEIxYzJocGJuUWdNVFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSMnh2WW1Gc1RuVnRRbmwwWlZOc2FXTmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUhCMWMyaHBiblFnTXdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JGZUhSeVlWQnliMmR5WVcxUVlXZGxjd29nSUNBZ2FYUjRibDltYVdWc1pDQkRiR1ZoY2xOMFlYUmxVSEp2WjNKaGJRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnliM1poYkZCeWIyZHlZVzBLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRU55WldGMFpXUkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmtkWEFLSUNBZ0lHRndjRjl3WVhKaGJYTmZaMlYwSUVGd2NFRmtaSEpsYzNNS0lDQWdJSEJ2Y0FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WalpXbDJaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2NIVnphR2x1ZENBeE1EQXdNREF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ0YjNWdWRBb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5KbFl5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWW5WeWVTQTBDaUFnSUNCaUlHMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUF4TkFvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOTBaWE4wY3k5emIyeHBaR2wwZVMxelpXMWhiblJwWXkxMFpYTjBjeTkwWlhOMGN5OW1ZV3hzWW1GamF5OWpZV3hzWDJadmNuZGhjbVJmWW5sMFpYTXVjMjlzTG5ObGJtUmxjaTVmWDJaaGJHeGlZV05yS0NrZ0xUNGdkbTlwWkRvS1gxOW1ZV3hzWW1GamF6b0tJQ0FnSUhCeWIzUnZJREFnTUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHUjFjRzRnTVRRS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCZlgyWmhiR3hpWVdOclgzUmxjbTVoY25sZlptRnNjMlZBTWdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbDlmWm1Gc2JHSmhZMnRmZEdWeWJtRnllVjl0WlhKblpVQXpPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ1gxOW1ZV3hzWW1GamExOTBaWEp1WVhKNVgyWmhiSE5sUURVekNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ1gxOW1ZV3hzWW1GamExOTBaWEp1WVhKNVgyWmhiSE5sUURZS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvS1gxOW1ZV3hzWW1GamExOTBaWEp1WVhKNVgyMWxjbWRsUURjNkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJRDRLSUNBZ0lHSjZJRjlmWm1Gc2JHSmhZMnRmZEdWeWJtRnllVjltWVd4elpVQTVDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDZ3BmWDJaaGJHeGlZV05yWDNSbGNtNWhjbmxmYldWeVoyVkFNVEE2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREVLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUQ0S0lDQWdJR0o2SUY5ZlptRnNiR0poWTJ0ZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvS1gxOW1ZV3hzWW1GamExOTBaWEp1WVhKNVgyMWxjbWRsUURFek9nb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeUNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnY0hWemFHbHVkQ0F6Q2lBZ0lDQStDaUFnSUNCaWVpQmZYMlpoYkd4aVlXTnJYM1JsY201aGNubGZabUZzYzJWQU1UVUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtDbDlmWm1Gc2JHSmhZMnRmZEdWeWJtRnllVjl0WlhKblpVQXhOam9LSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNd29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHbHVkR05mTXlBdkx5QTBDaUFnSUNBK0NpQWdJQ0JpZWlCZlgyWmhiR3hpWVdOclgzUmxjbTVoY25sZlptRnNjMlZBTVRnS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0NsOWZabUZzYkdKaFkydGZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE9Ub0tJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMkoxY25rZ05Bb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUhCMWMyaHBiblFnTlFvZ0lDQWdQZ29nSUNBZ1lub2dYMTltWVd4c1ltRmphMTkwWlhKdVlYSjVYMlpoYkhObFFESXhDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTFDZ3BmWDJaaGJHeGlZV05yWDNSbGNtNWhjbmxmYldWeVoyVkFNakk2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dOQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRFVLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQnBiblJqWHpJZ0x5OGdOZ29nSUNBZ1Bnb2dJQ0FnWW5vZ1gxOW1ZV3hzWW1GamExOTBaWEp1WVhKNVgyWmhiSE5sUURJMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMkNncGZYMlpoYkd4aVlXTnJYM1JsY201aGNubGZiV1Z5WjJWQU1qVTZDaUFnSUNCbWNtRnRaVjlrYVdjZ05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlpZFhKNUlEWUtJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCd2RYTm9hVzUwSURjS0lDQWdJRDRLSUNBZ0lHSjZJRjlmWm1Gc2JHSmhZMnRmZEdWeWJtRnllVjltWVd4elpVQXlOd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOd29LWDE5bVlXeHNZbUZqYTE5MFpYSnVZWEo1WDIxbGNtZGxRREk0T2dvZ0lDQWdabkpoYldWZlpHbG5JRFlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlluVnllU0EzQ2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdjSFZ6YUdsdWRDQTRDaUFnSUNBK0NpQWdJQ0JpZWlCZlgyWmhiR3hpWVdOclgzUmxjbTVoY25sZlptRnNjMlZBTXpBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURnS0NsOWZabUZzYkdKaFkydGZkR1Z5Ym1GeWVWOXRaWEpuWlVBek1Ub0tJQ0FnSUdaeVlXMWxYMlJwWnlBM0NpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMkoxY25rZ09Bb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUhCMWMyaHBiblFnT1FvZ0lDQWdQZ29nSUNBZ1lub2dYMTltWVd4c1ltRmphMTkwWlhKdVlYSjVYMlpoYkhObFFETXpDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTVDZ3BmWDJaaGJHeGlZV05yWDNSbGNtNWhjbmxmYldWeVoyVkFNelE2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dPQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRGtLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQndkWE5vYVc1MElERXdDaUFnSUNBK0NpQWdJQ0JpZWlCZlgyWmhiR3hpWVdOclgzUmxjbTVoY25sZlptRnNjMlZBTXpZS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFd0NncGZYMlpoYkd4aVlXTnJYM1JsY201aGNubGZiV1Z5WjJWQU16YzZDaUFnSUNCbWNtRnRaVjlrYVdjZ09Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlpZFhKNUlERXdDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ2NIVnphR2x1ZENBeE1Rb2dJQ0FnUGdvZ0lDQWdZbm9nWDE5bVlXeHNZbUZqYTE5MFpYSnVZWEo1WDJaaGJITmxRRE01Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4TVFvS1gxOW1ZV3hzWW1GamExOTBaWEp1WVhKNVgyMWxjbWRsUURRd09nb2dJQ0FnWm5KaGJXVmZaR2xuSURFd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01URUtJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCd2RYTm9hVzUwSURFeUNpQWdJQ0ErQ2lBZ0lDQmllaUJmWDJaaGJHeGlZV05yWDNSbGNtNWhjbmxmWm1Gc2MyVkFORElLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREV5Q2dwZlgyWmhiR3hpWVdOclgzUmxjbTVoY25sZmJXVnlaMlZBTkRNNkNpQWdJQ0JtY21GdFpWOWthV2NnTVRFS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeE1nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUhCMWMyaHBiblFnTVRNS0lDQWdJRDRLSUNBZ0lHSjZJRjlmWm1Gc2JHSmhZMnRmZEdWeWJtRnllVjltWVd4elpVQTBOUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNVE1LQ2w5ZlptRnNiR0poWTJ0ZmRHVnlibUZ5ZVY5dFpYSm5aVUEwTmpvS0lDQWdJR1p5WVcxbFgyUnBaeUF4TWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWlkWEo1SURFekNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnY0hWemFHbHVkQ0F4TkFvZ0lDQWdQZ29nSUNBZ1lub2dYMTltWVd4c1ltRmphMTkwWlhKdVlYSjVYMlpoYkhObFFEUTRDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhOQW9LWDE5bVlXeHNZbUZqYTE5MFpYSnVZWEo1WDIxbGNtZGxRRFE1T2dvZ0lDQWdabkpoYldWZlpHbG5JREV6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgySjFjbmtnTVRRS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0J3ZFhOb2FXNTBJREUxQ2lBZ0lDQStDaUFnSUNCaWVpQmZYMlpoYkd4aVlXTnJYM1JsY201aGNubGZabUZzYzJWQU5URUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERTFDZ3BmWDJaaGJHeGlZV05yWDNSbGNtNWhjbmxmYldWeVoyVkFOVEk2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNVFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvS1gxOW1ZV3hzWW1GamExOTBaWEp1WVhKNVgyMWxjbWRsUURVME9nb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWMyRjJaV1JFWVhSaElnb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnpZWFpsWkVSaGRHRWlDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQnlaWFJ6ZFdJS0NsOWZabUZzYkdKaFkydGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBMU1Ub0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZW1WeWJ3b2dJQ0FnWWlCZlgyWmhiR3hpWVdOclgzUmxjbTVoY25sZmJXVnlaMlZBTlRJS0NsOWZabUZzYkdKaFkydGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBME9Eb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZW1WeWJ3b2dJQ0FnWWlCZlgyWmhiR3hpWVdOclgzUmxjbTVoY25sZmJXVnlaMlZBTkRrS0NsOWZabUZzYkdKaFkydGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBME5Ub0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZW1WeWJ3b2dJQ0FnWWlCZlgyWmhiR3hpWVdOclgzUmxjbTVoY25sZmJXVnlaMlZBTkRZS0NsOWZabUZzYkdKaFkydGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBME1qb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZW1WeWJ3b2dJQ0FnWWlCZlgyWmhiR3hpWVdOclgzUmxjbTVoY25sZmJXVnlaMlZBTkRNS0NsOWZabUZzYkdKaFkydGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBek9Ub0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZW1WeWJ3b2dJQ0FnWWlCZlgyWmhiR3hpWVdOclgzUmxjbTVoY25sZmJXVnlaMlZBTkRBS0NsOWZabUZzYkdKaFkydGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBek5qb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZW1WeWJ3b2dJQ0FnWWlCZlgyWmhiR3hpWVdOclgzUmxjbTVoY25sZmJXVnlaMlZBTXpjS0NsOWZabUZzYkdKaFkydGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBek16b0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZW1WeWJ3b2dJQ0FnWWlCZlgyWmhiR3hpWVdOclgzUmxjbTVoY25sZmJXVnlaMlZBTXpRS0NsOWZabUZzYkdKaFkydGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBek1Eb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZW1WeWJ3b2dJQ0FnWWlCZlgyWmhiR3hpWVdOclgzUmxjbTVoY25sZmJXVnlaMlZBTXpFS0NsOWZabUZzYkdKaFkydGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeU56b0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZW1WeWJ3b2dJQ0FnWWlCZlgyWmhiR3hpWVdOclgzUmxjbTVoY25sZmJXVnlaMlZBTWpnS0NsOWZabUZzYkdKaFkydGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeU5Eb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZW1WeWJ3b2dJQ0FnWWlCZlgyWmhiR3hpWVdOclgzUmxjbTVoY25sZmJXVnlaMlZBTWpVS0NsOWZabUZzYkdKaFkydGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeU1Ub0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZW1WeWJ3b2dJQ0FnWWlCZlgyWmhiR3hpWVdOclgzUmxjbTVoY25sZmJXVnlaMlZBTWpJS0NsOWZabUZzYkdKaFkydGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE9Eb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZW1WeWJ3b2dJQ0FnWWlCZlgyWmhiR3hpWVdOclgzUmxjbTVoY25sZmJXVnlaMlZBTVRrS0NsOWZabUZzYkdKaFkydGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE5Ub0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZW1WeWJ3b2dJQ0FnWWlCZlgyWmhiR3hpWVdOclgzUmxjbTVoY25sZmJXVnlaMlZBTVRZS0NsOWZabUZzYkdKaFkydGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE1qb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZW1WeWJ3b2dJQ0FnWWlCZlgyWmhiR3hpWVdOclgzUmxjbTVoY25sZmJXVnlaMlZBTVRNS0NsOWZabUZzYkdKaFkydGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBNU9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o2WlhKdkNpQWdJQ0JpSUY5ZlptRnNiR0poWTJ0ZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TUFvS1gxOW1ZV3hzWW1GamExOTBaWEp1WVhKNVgyWmhiSE5sUURZNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbnBsY204S0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdZaUJmWDJaaGJHeGlZV05yWDNSbGNtNWhjbmxmYldWeVoyVkFOd29LWDE5bVlXeHNZbUZqYTE5MFpYSnVZWEo1WDJaaGJITmxRRFV6T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlJRjlmWm1Gc2JHSmhZMnRmZEdWeWJtRnllVjl0WlhKblpVQTFOQW9LWDE5bVlXeHNZbUZqYTE5MFpYSnVZWEo1WDJaaGJITmxRREk2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQmZYMlpoYkd4aVlXTnJYM1JsY201aGNubGZiV1Z5WjJWQU13bz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dmRHVnpkSE12YzI5c2FXUnBkSGt0YzJWdFlXNTBhV010ZEdWemRITXZkR1Z6ZEhNdlptRnNiR0poWTJzdlkyRnNiRjltYjNKM1lYSmtYMko1ZEdWekxuTnZiQzV6Wlc1a1pYSXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRUFBRUdCQ1lIQ1hOaGRtVmtSR0YwWVFBT1gxOWpkRzl5WDNCbGJtUnBibWNEY21WakJSVWZmSFdBQmdJbzRxVURIQVlDS09LbEF4d2lTU2xIQTRHQUlLOUpOUVUxQURRQWdDQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBZ0Z4QU5RQXhHRUFBQlNvalp5TkRNUnRBQUFXSUFXNGpReUpGQkRFWkZFUXhHRUVBS29JRkJMck1TZU1FRy9tSUt3UU5DK1V2QlBNaHZEMEVjTFphNHpZYUFJNEZBTzhBNWdCOUFGMEFFa3NEUlFOTEFrQUFCb2dCS2lORkEwc0NRekVXUVFCQ01SWWpDVGdJRkVTeElpdGxSSUVZV3lTeUVDS3lHU0t5QWJJWWdBVEVjME1Pc2hxenRENVhCQUJKRllFZ0RrU0JJSytyZ0FRVkgzeDFURkN3STBVRVF2K25Ja0wvd0RFV1FRQVhNUllqQ1RnSUZFUW92RWdvS2I4bkJMQWpSUVJDLzRjaVF2L3JNUlpCQUdBeEZpTUpPQWdVUkNpK0tVNENUVWxGQjdFVlNVVURKUTlKUlFKQkFEdExCVmNBQkVVRlNVRUFMRXNCSlFsTEJpVlBBbGdpSzJWRWdSaGJKTElRSXJJWklySUJzaGhMQmJJYXNocXpKd1N3STBVRVF2OHBLVUwvMmtzRlJRVkMvOFVpUXYraWlBQk5JMFVFUXY4UkttUkVLaUpuc1NjRkp3WWtzaENCRUxJMGdSQ3lOU0t5QVlFRHNqaXlIN0llczdROVNYSUlTTEVqc2hDeUJ5S3lBWUhBaEQyeUNMT0JHSzlNRmxBclRHY2pSUVJDL3NxS0FBQWlSdzR4RmtFQmJ6RVdJd2s0Q0JSRU1SdEJBVjB4RzBFQlVUWWFBSXdBTVJzakRVRUJRRFlhQVlzQVRGQ01BVEViZ1FJTlFRRXFOaG9DaXdGTVVJd0NNUnVCQXcxQkFSUTJHZ09MQWt4UWpBTXhHeVVOUVFEL05ob0Vpd05NVUl3RU1SdUJCUTFCQU9rMkdnV0xCRXhRakFVeEd5UU5RUURVTmhvR2l3Vk1VSXdHTVJ1QkJ3MUJBTDQyR2dlTEJreFFqQWN4RzRFSURVRUFxRFlhQ0lzSFRGQ01DREViZ1FrTlFRQ1NOaG9KaXdoTVVJd0pNUnVCQ2cxQkFIdzJHZ3FMQ1V4UWpBb3hHNEVMRFVFQVpqWWFDNHNLVEZDTUN6RWJnUXdOUVFCUU5ob01pd3RNVUl3TU1SdUJEUTFCQURvMkdnMkxERXhRakEweEc0RU9EVUVBSkRZYURvc05URkNNRGpFYmdROE5RUUFPTmhvUGl3NU1VQ2k4U0NoTXY0a2lyMEwvOENLdlF2L2FJcTlDLzhRaXIwTC9yaUt2UXYrWUlxOUMvNElpcjBML2JDS3ZRdjlXSXE5Qy8wQWlyMEwvS2lLdlF2OFZJcTlDL3Y4aXIwTCs2aUt2UXY3VUlxOUMvcjRpcjR3QVF2NnRJcTlDLzZJaVF2NlQiLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo4LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6eyJBUFBST1ZBTF9yZWNlaXZlciI6eyJ0eXBlIjoiQVZNQnl0ZXMiLCJ2YWx1ZSI6IkFpamlwUU1jIn0sIkNMRUFSX3JlY2VpdmVyIjp7InR5cGUiOiJBVk1CeXRlcyIsInZhbHVlIjoiQWlqaXBRTWMifX0sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
