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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.A_694557dd
{


    public class AProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Data(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 58, 83, 163 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Data_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 58, 83, 163 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Balance(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 118, 216, 162, 143 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Balance_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 118, 216, 162, 143 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<byte[]> ExternalData(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 182, 20, 183 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> ExternalData_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 182, 20, 183 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJfX3Bvc3RJbml0IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Il9fZmFsbGJhY2siLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGF0YSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJhbGFuY2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJleHRlcm5hbERhdGEiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6Mn0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMzI5XSwiZXJyb3JNZXNzYWdlIjoiX19wb3N0SW5pdCBhbHJlYWR5IGNhbGxlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1NF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIGJhbGFuY2UgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjk0LDM1NF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIGRhdGEgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjA3LDI0OSwyOTBdLCJlcnJvck1lc3NhZ2UiOiJub3QgcGF5YWJsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1OSwyOTldLCJlcnJvck1lc3NhZ2UiOiJvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2ZEdWemRITXZjMjlzYVdScGRIa3RjMlZ0WVc1MGFXTXRkR1Z6ZEhNdmRHVnpkSE12YzIxdmEyVXZabUZzYkdKaFkyc3VjMjlzTGtFdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ016SUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZ2dJbVJoZEdFaUlDSmZYMk4wYjNKZmNHVnVaR2x1WnlJZ0ltVjRkR1Z5Ym1Gc1JHRjBZU0lnTUhneE5URm1OMk0zTlNBaVltRnNZVzVqWlNJS0lDQWdJR0o1ZEdWalh6QWdMeThnSWlJS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTBNRGsyQ2lBZ0lDQmllbVZ5YndvZ0lDQWdaSFZ3Q2lBZ0lDQnpkRzl5WlNBMUNpQWdJQ0J6ZEc5eVpTQXdDaUFnSUNCc2IyRmtJREFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdPREFLSUNBZ0lISmxjR3hoWTJVeUlEWTBDaUFnSUNCemRHOXlaU0F3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmZYMk4wYjNKZmNHVnVaR2x1WnlJS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUEwQ2lBZ0lDQmpZV3hzYzNWaUlGOWZabUZzYkdKaFkyc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUEwT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjFjbmtnTWdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lub2diV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURFMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNFltRmpZelE1WlRNZ01IZ3hZbVk1T0RneVlpQXdlR1E1TTJFMU0yRXpJREI0Tnpaa09HRXlPR1lnTUhobU1XSTJNVFJpTnlBdkx5QnRaWFJvYjJRZ0lsOWZjRzl6ZEVsdWFYUW9LWFp2YVdRaUxDQnRaWFJvYjJRZ0lsOWZabUZzYkdKaFkyc29LWFp2YVdRaUxDQnRaWFJvYjJRZ0ltUmhkR0VvS1hWcGJuUXlOVFlpTENCdFpYUm9iMlFnSW1KaGJHRnVZMlVvS1hWcGJuUXlOVFlpTENCdFpYUm9iMlFnSW1WNGRHVnlibUZzUkdGMFlTZ3BZbmwwWlZ0ZElnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5ZlgzQnZjM1JKYm1sMFgzSnZkWFJsUURrZ2JXRnBibDlmWDJaaGJHeGlZV05yWDNKdmRYUmxRREV3SUcxaGFXNWZaR0YwWVY5eWIzVjBaVUF4TVNCdFlXbHVYMkpoYkdGdVkyVmZjbTkxZEdWQU1USWdiV0ZwYmw5bGVIUmxjbTVoYkVSaGRHRmZjbTkxZEdWQU1UTUtDbTFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBeE5Eb0tJQ0FnSUdScFp5QXhDaUFnSUNCaWRYSjVJREVLSUNBZ0lHUjFjQW9nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUEyQ2lBZ0lDQmpZV3hzYzNWaUlGOWZabUZzYkdKaFkyc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JpZFhKNUlERUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUEyT2dvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJWNGRHVnlibUZzUkdGMFlWOXliM1YwWlVBeE16b0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNVGtLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNakE2Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOTBJSEJoZVdGaWJHVUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltVjRkR1Z5Ym1Gc1JHRjBZU0lLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JpZFhKNUlESUtJQ0FnSUdJZ2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRREUwQ2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1UazZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1qQUtDbTFoYVc1ZlltRnNZVzVqWlY5eWIzVjBaVUF4TWpvS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1qUUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1qVTZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0ppWVd4aGJtTmxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QmlZV3hoYm1ObElHVjRhWE4wY3dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZbndLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCaWRYSjVJRElLSUNBZ0lHSWdiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURFMENncHRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNalE2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQnRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNalVLQ20xaGFXNWZaR0YwWVY5eWIzVjBaVUF4TVRvS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1qa0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU16QTZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0prWVhSaElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCa1lYUmhJR1Y0YVhOMGN3b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWW53S0lDQWdJR0o1ZEdWaklEUWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmlkWEo1SURJS0lDQWdJR0lnYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFERTBDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTWprNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTXpBS0NtMWhhVzVmWDE5bVlXeHNZbUZqYTE5eWIzVjBaVUF4TURvS0lDQWdJR05oYkd4emRXSWdYMTltWVd4c1ltRmphd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdKMWNua2dNZ29nSUNBZ1lpQnRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTVRRS0NtMWhhVzVmWDE5d2IzTjBTVzVwZEY5eWIzVjBaVUE1T2dvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWDE5amRHOXlYM0JsYm1ScGJtY2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklGOWZjRzl6ZEVsdWFYUWdZV3h5WldGa2VTQmpZV3hzWldRS0lDQWdJR0o1ZEdWalh6SWdMeThnSWw5ZlkzUnZjbDl3Wlc1a2FXNW5JZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmtZWFJoSWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1KaGJHRnVZMlVpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHSjFjbmtnTWdvZ0lDQWdZaUJ0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU1UUUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2ZEdWemRITXZjMjlzYVdScGRIa3RjMlZ0WVc1MGFXTXRkR1Z6ZEhNdmRHVnpkSE12YzIxdmEyVXZabUZzYkdKaFkyc3VjMjlzTGtFdVgxOW1ZV3hzWW1GamF5Z3BJQzArSUhadmFXUTZDbDlmWm1Gc2JHSmhZMnM2Q2lBZ0lDQndjbTkwYnlBd0lEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JrZFhCdUlERTFDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmtZWFJoSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJrWVhSaElHVjRhWE4wY3dvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURFS0lDQWdJR0lyQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0prWVhSaElnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQmZYMlpoYkd4aVlXTnJYM1JsY201aGNubGZabUZzYzJWQU1nb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ2w5ZlptRnNiR0poWTJ0ZmRHVnlibUZ5ZVY5dFpYSm5aVUF6T2dvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWW1Gc1lXNWpaU0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nWDE5bVlXeHNZbUZqYTE5MFpYSnVZWEo1WDJaaGJITmxRRFV6Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nWDE5bVlXeHNZbUZqYTE5MFpYSnVZWEo1WDJaaGJITmxRRFlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9LWDE5bVlXeHNZbUZqYTE5MFpYSnVZWEo1WDIxbGNtZGxRRGM2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lENEtJQ0FnSUdKNklGOWZabUZzYkdKaFkydGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBNUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENncGZYMlpoYkd4aVlXTnJYM1JsY201aGNubGZiV1Z5WjJWQU1UQTZDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJRDRLSUNBZ0lHSjZJRjlmWm1Gc2JHSmhZMnRmZEdWeWJtRnllVjltWVd4elpVQXhNZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29LWDE5bVlXeHNZbUZqYTE5MFpYSnVZWEo1WDIxbGNtZGxRREV6T2dvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlluVnllU0F5Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdjSFZ6YUdsdWRDQXpDaUFnSUNBK0NpQWdJQ0JpZWlCZlgyWmhiR3hpWVdOclgzUmxjbTVoY25sZlptRnNjMlZBTVRVS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0NsOWZabUZzYkdKaFkydGZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE5qb0tJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMkoxY25rZ013b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUhCMWMyaHBiblFnTkFvZ0lDQWdQZ29nSUNBZ1lub2dYMTltWVd4c1ltRmphMTkwWlhKdVlYSjVYMlpoYkhObFFERTRDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDZ3BmWDJaaGJHeGlZV05yWDNSbGNtNWhjbmxmYldWeVoyVkFNVGs2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNd29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRFFLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQndkWE5vYVc1MElEVUtJQ0FnSUQ0S0lDQWdJR0o2SUY5ZlptRnNiR0poWTJ0ZmRHVnlibUZ5ZVY5bVlXeHpaVUF5TVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTlFvS1gxOW1ZV3hzWW1GamExOTBaWEp1WVhKNVgyMWxjbWRsUURJeU9nb2dJQ0FnWm5KaGJXVmZaR2xuSURRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBMUNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnY0hWemFHbHVkQ0EyQ2lBZ0lDQStDaUFnSUNCaWVpQmZYMlpoYkd4aVlXTnJYM1JsY201aGNubGZabUZzYzJWQU1qUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEWUtDbDlmWm1Gc2JHSmhZMnRmZEdWeWJtRnllVjl0WlhKblpVQXlOVG9LSUNBZ0lHWnlZVzFsWDJScFp5QTFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJKMWNua2dOZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lIQjFjMmhwYm5RZ053b2dJQ0FnUGdvZ0lDQWdZbm9nWDE5bVlXeHNZbUZqYTE5MFpYSnVZWEo1WDJaaGJITmxRREkzQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEzQ2dwZlgyWmhiR3hpWVdOclgzUmxjbTVoY25sZmJXVnlaMlZBTWpnNkNpQWdJQ0JtY21GdFpWOWthV2NnTmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWlkWEo1SURjS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lENEtJQ0FnSUdKNklGOWZabUZzYkdKaFkydGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBek1Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ09Bb0tYMTltWVd4c1ltRmphMTkwWlhKdVlYSjVYMjFsY21kbFFETXhPZ29nSUNBZ1puSmhiV1ZmWkdsbklEY0tJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQTRDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ2NIVnphR2x1ZENBNUNpQWdJQ0ErQ2lBZ0lDQmllaUJmWDJaaGJHeGlZV05yWDNSbGNtNWhjbmxmWm1Gc2MyVkFNek1LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRGtLQ2w5ZlptRnNiR0poWTJ0ZmRHVnlibUZ5ZVY5dFpYSm5aVUF6TkRvS0lDQWdJR1p5WVcxbFgyUnBaeUE0Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgySjFjbmtnT1FvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJSEIxYzJocGJuUWdNVEFLSUNBZ0lENEtJQ0FnSUdKNklGOWZabUZzYkdKaFkydGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBek5nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01UQUtDbDlmWm1Gc2JHSmhZMnRmZEdWeWJtRnllVjl0WlhKblpVQXpOem9LSUNBZ0lHWnlZVzFsWDJScFp5QTVDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNVEFLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQndkWE5vYVc1MElERXhDaUFnSUNBK0NpQWdJQ0JpZWlCZlgyWmhiR3hpWVdOclgzUmxjbTVoY25sZlptRnNjMlZBTXprS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFeENncGZYMlpoYkd4aVlXTnJYM1JsY201aGNubGZiV1Z5WjJWQU5EQTZDaUFnSUNCbWNtRnRaVjlrYVdjZ01UQUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXhNUW9nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lIQjFjMmhwYm5RZ01USUtJQ0FnSUQ0S0lDQWdJR0o2SUY5ZlptRnNiR0poWTJ0ZmRHVnlibUZ5ZVY5bVlXeHpaVUEwTWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVRJS0NsOWZabUZzYkdKaFkydGZkR1Z5Ym1GeWVWOXRaWEpuWlVBME16b0tJQ0FnSUdaeVlXMWxYMlJwWnlBeE1Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlpZFhKNUlERXlDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ2NIVnphR2x1ZENBeE13b2dJQ0FnUGdvZ0lDQWdZbm9nWDE5bVlXeHNZbUZqYTE5MFpYSnVZWEo1WDJaaGJITmxRRFExQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4TXdvS1gxOW1ZV3hzWW1GamExOTBaWEp1WVhKNVgyMWxjbWRsUURRMk9nb2dJQ0FnWm5KaGJXVmZaR2xuSURFeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01UTUtJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCd2RYTm9hVzUwSURFMENpQWdJQ0ErQ2lBZ0lDQmllaUJmWDJaaGJHeGlZV05yWDNSbGNtNWhjbmxmWm1Gc2MyVkFORGdLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREUwQ2dwZlgyWmhiR3hpWVdOclgzUmxjbTVoY25sZmJXVnlaMlZBTkRrNkNpQWdJQ0JtY21GdFpWOWthV2NnTVRNS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeE5Bb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUhCMWMyaHBiblFnTVRVS0lDQWdJRDRLSUNBZ0lHSjZJRjlmWm1Gc2JHSmhZMnRmZEdWeWJtRnllVjltWVd4elpVQTFNUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNVFVLQ2w5ZlptRnNiR0poWTJ0ZmRHVnlibUZ5ZVY5dFpYSm5aVUExTWpvS0lDQWdJR1p5WVcxbFgyUnBaeUF4TkFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENncGZYMlpoYkd4aVlXTnJYM1JsY201aGNubGZiV1Z5WjJWQU5UUTZDaUFnSUNCaWVYUmxZMTh6SUM4dklDSmxlSFJsY201aGJFUmhkR0VpQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1WNGRHVnlibUZzUkdGMFlTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lISmxkSE4xWWdvS1gxOW1ZV3hzWW1GamExOTBaWEp1WVhKNVgyWmhiSE5sUURVeE9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o2WlhKdkNpQWdJQ0JpSUY5ZlptRnNiR0poWTJ0ZmRHVnlibUZ5ZVY5dFpYSm5aVUExTWdvS1gxOW1ZV3hzWW1GamExOTBaWEp1WVhKNVgyWmhiSE5sUURRNE9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o2WlhKdkNpQWdJQ0JpSUY5ZlptRnNiR0poWTJ0ZmRHVnlibUZ5ZVY5dFpYSm5aVUEwT1FvS1gxOW1ZV3hzWW1GamExOTBaWEp1WVhKNVgyWmhiSE5sUURRMU9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o2WlhKdkNpQWdJQ0JpSUY5ZlptRnNiR0poWTJ0ZmRHVnlibUZ5ZVY5dFpYSm5aVUEwTmdvS1gxOW1ZV3hzWW1GamExOTBaWEp1WVhKNVgyWmhiSE5sUURReU9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o2WlhKdkNpQWdJQ0JpSUY5ZlptRnNiR0poWTJ0ZmRHVnlibUZ5ZVY5dFpYSm5aVUEwTXdvS1gxOW1ZV3hzWW1GamExOTBaWEp1WVhKNVgyWmhiSE5sUURNNU9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o2WlhKdkNpQWdJQ0JpSUY5ZlptRnNiR0poWTJ0ZmRHVnlibUZ5ZVY5dFpYSm5aVUEwTUFvS1gxOW1ZV3hzWW1GamExOTBaWEp1WVhKNVgyWmhiSE5sUURNMk9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o2WlhKdkNpQWdJQ0JpSUY5ZlptRnNiR0poWTJ0ZmRHVnlibUZ5ZVY5dFpYSm5aVUF6TndvS1gxOW1ZV3hzWW1GamExOTBaWEp1WVhKNVgyWmhiSE5sUURNek9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o2WlhKdkNpQWdJQ0JpSUY5ZlptRnNiR0poWTJ0ZmRHVnlibUZ5ZVY5dFpYSm5aVUF6TkFvS1gxOW1ZV3hzWW1GamExOTBaWEp1WVhKNVgyWmhiSE5sUURNd09nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o2WlhKdkNpQWdJQ0JpSUY5ZlptRnNiR0poWTJ0ZmRHVnlibUZ5ZVY5dFpYSm5aVUF6TVFvS1gxOW1ZV3hzWW1GamExOTBaWEp1WVhKNVgyWmhiSE5sUURJM09nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o2WlhKdkNpQWdJQ0JpSUY5ZlptRnNiR0poWTJ0ZmRHVnlibUZ5ZVY5dFpYSm5aVUF5T0FvS1gxOW1ZV3hzWW1GamExOTBaWEp1WVhKNVgyWmhiSE5sUURJME9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o2WlhKdkNpQWdJQ0JpSUY5ZlptRnNiR0poWTJ0ZmRHVnlibUZ5ZVY5dFpYSm5aVUF5TlFvS1gxOW1ZV3hzWW1GamExOTBaWEp1WVhKNVgyWmhiSE5sUURJeE9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o2WlhKdkNpQWdJQ0JpSUY5ZlptRnNiR0poWTJ0ZmRHVnlibUZ5ZVY5dFpYSm5aVUF5TWdvS1gxOW1ZV3hzWW1GamExOTBaWEp1WVhKNVgyWmhiSE5sUURFNE9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o2WlhKdkNpQWdJQ0JpSUY5ZlptRnNiR0poWTJ0ZmRHVnlibUZ5ZVY5dFpYSm5aVUF4T1FvS1gxOW1ZV3hzWW1GamExOTBaWEp1WVhKNVgyWmhiSE5sUURFMU9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o2WlhKdkNpQWdJQ0JpSUY5ZlptRnNiR0poWTJ0ZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TmdvS1gxOW1ZV3hzWW1GamExOTBaWEp1WVhKNVgyWmhiSE5sUURFeU9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o2WlhKdkNpQWdJQ0JpSUY5ZlptRnNiR0poWTJ0ZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TXdvS1gxOW1ZV3hzWW1GamExOTBaWEp1WVhKNVgyWmhiSE5sUURrNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbnBsY204S0lDQWdJR0lnWDE5bVlXeHNZbUZqYTE5MFpYSnVZWEo1WDIxbGNtZGxRREV3Q2dwZlgyWmhiR3hpWVdOclgzUmxjbTVoY25sZlptRnNjMlZBTmpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllbVZ5YndvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQmlJRjlmWm1Gc2JHSmhZMnRmZEdWeWJtRnllVjl0WlhKblpVQTNDZ3BmWDJaaGJHeGlZV05yWDNSbGNtNWhjbmxmWm1Gc2MyVkFOVE02Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lucGxjbThLSUNBZ0lHSWdYMTltWVd4c1ltRmphMTkwWlhKdVlYSjVYMjFsY21kbFFEVTBDZ3BmWDJaaGJHeGlZV05yWDNSbGNtNWhjbmxmWm1Gc2MyVkFNam9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaUlGOWZabUZzYkdKaFkydGZkR1Z5Ym1GeWVWOXRaWEpuWlVBekNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dmRHVnpkSE12YzI5c2FXUnBkSGt0YzJWdFlXNTBhV010ZEdWemRITXZkR1Z6ZEhNdmMyMXZhMlV2Wm1Gc2JHSmhZMnN1YzI5c0xrRXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBREFBRWdKZ1lBQkdSaGRHRU9YMTlqZEc5eVgzQmxibVJwYm1jTVpYaDBaWEp1WVd4RVlYUmhCQlVmZkhVSFltRnNZVzVqWlNoSmdZQWdyMGsxQlRVQU5BQ0FJQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFDQVhFQTFBREVZUUFBRktpTm5JME14RzBBQUJZZ0EzaU5ESWtVQ01Sa1VSREVZUVFBcWdnVUV1c3hKNHdRYitZZ3JCTms2VTZNRWR0aWlqd1R4dGhTM05ob0FqZ1VBa3dDS0FHSUFPUUFQU3dGRkFVbEFBQWFJQUpzalJRRkRNUlpCQUNFeEZpTUpPQWdVUkN1K0tFNENUVWtWRmxjR0FreFFKd1JNVUxBalJRSkMvOHNpUXYvaE1SWkJBQ0F4RmlNSk9BZ1VSQ0luQldWRVNSVWtEa1FrcjZzbkJFeFFzQ05GQWtML29pSkMvK0l4RmtFQUh6RVdJd2s0Q0JSRUlpbGxSRWtWSkE1RUpLK3JKd1JNVUxBalJRSkMvM29pUXYvamlBQVpJMFVDUXY5dEttUkVLaUpuS1Nobkp3VW9aeU5GQWtML1dvb0FBQ0pIRHlsbFJJQUJBYUFwVEdjeEZrRUJkREVXSXdrNENCWW5CVXhuTVJ0QkFWOHhHMEVCVXpZYUFJd0FNUnNqRFVFQlFqWWFBWXNBVEZDTUFURWJnUUlOUVFFc05ob0Npd0ZNVUl3Q01SdUJBdzFCQVJZMkdnT0xBa3hRakFNeEc0RUVEVUVCQURZYUJJc0RURkNNQkRFYmdRVU5RUURxTmhvRml3Uk1VSXdGTVJ1QkJnMUJBTlEyR2dhTEJVeFFqQVl4RzRFSERVRUF2allhQjRzR1RGQ01CekViZ1FnTlFRQ29OaG9JaXdkTVVJd0lNUnVCQ1ExQkFKSTJHZ21MQ0V4UWpBa3hHNEVLRFVFQWZEWWFDb3NKVEZDTUNqRWJnUXNOUVFCbU5ob0xpd3BNVUl3TE1SdUJEQTFCQUZBMkdneUxDMHhRakF3eEc0RU5EVUVBT2pZYURZc01URkNNRFRFYmdRNE5RUUFrTmhvT2l3MU1VSXdPTVJ1QkR3MUJBQTQyR2crTERreFFLN3hJSzB5L2lTS3ZRdi93SXE5Qy85b2lyMEwveENLdlF2K3VJcTlDLzVnaXIwTC9naUt2UXY5c0lxOUMvMVlpcjBML1FDS3ZRdjhxSXE5Qy94UWlyMEwrL2lLdlF2N29JcTlDL3RJaXIwTCt2Q0t2akFCQy9xc2lyMEwvb2lKQy9vND0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo4LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
