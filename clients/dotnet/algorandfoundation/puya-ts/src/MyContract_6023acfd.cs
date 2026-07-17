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

namespace Arc56.Generated.algorandfoundation.puya_ts.MyContract_6023acfd
{


    public class MyContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MyContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetInt(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 147, 32, 11 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetInt_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 147, 32, 11 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> GetString(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 193, 161, 50, 149 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetString_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 193, 161, 50, 149 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<byte[]> GetBytes(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 175, 67, 219, 54 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> GetBytes_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 175, 67, 219, 54 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> GetAddress(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 5, 89, 202, 193 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> GetAddress_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 5, 89, 202, 193 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTXlDb250cmFjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJnZXRJbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRTdHJpbmciLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRCeXRlcyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEFkZHJlc3MiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoiY2Jsb2NrcyJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SUZSTlVFeGZRVTVmU1U1VUNpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE1UVXhaamRqTnpVZ1ZFMVFURjlCWDFOVVVrbE9SeUJVVFZCTVgxTlBUVVZmUWxsVVJWTWdWRTFRVEY5QlRsOUJSRVJTUlZOVENpQWdJQ0JpSUcxaGFXNWZZbXh2WTJ0QU1Bb0tiV0ZwYmw5aWJHOWphMEF3T2dvZ0lDQWdZaUJ0WVdsdVgySnNiMk5yUURFS0NtMWhhVzVmWW14dlkydEFNVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OTBaVzF3YkdGMFpTMTJZWEl1WVd4bmJ5NTBjem8zQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1RYbERiMjUwY21GamRDQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnSVQwS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFERXhDaUFnSUNCaUlHMWhhVzVmWVdKcFgzSnZkWFJwYm1kQU1nb0tiV0ZwYmw5aFltbGZjbTkxZEdsdVowQXlPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzUmxiWEJzWVhSbExYWmhjaTVoYkdkdkxuUnpPamNLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCTmVVTnZiblJ5WVdOMElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklFNXZUM0FLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdJVDBLSUNBZ0lHSjZJRzFoYVc1ZlkzSmxZWFJsWDA1dlQzQkFPUW9nSUNBZ1lpQnRZV2x1WDJOaGJHeGZUbTlQY0VBekNncHRZV2x1WDJOaGJHeGZUbTlQY0VBek9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNSbGJYQnNZWFJsTFhaaGNpNWhiR2R2TG5Sek9qY0tJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJOZVVOdmJuUnlZV04wSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WW1VNU16SXdNR0lnTHk4Z2JXVjBhRzlrSUNKblpYUkpiblFvS1hWcGJuUTJOQ0lLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR014WVRFek1qazFJQzh2SUcxbGRHaHZaQ0FpWjJWMFUzUnlhVzVuS0NsemRISnBibWNpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhoWmpRelpHSXpOaUF2THlCdFpYUm9iMlFnSW1kbGRFSjVkR1Z6S0NsaWVYUmxXMTBpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TlRVNVkyRmpNU0F2THlCdFpYUm9iMlFnSW1kbGRFRmtaSEpsYzNNb0tXRmtaSEpsYzNNaUNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHMWhkR05vSUcxaGFXNWZaMlYwU1c1MFgzSnZkWFJsUURRZ2JXRnBibDluWlhSVGRISnBibWRmY205MWRHVkFOU0J0WVdsdVgyZGxkRUo1ZEdWelgzSnZkWFJsUURZZ2JXRnBibDluWlhSQlpHUnlaWE56WDNKdmRYUmxRRGNLSUNBZ0lHSWdiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURnS0NtMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUE0T2dvZ0lDQWdZaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRBS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhNRG9LSUNBZ0lHSWdiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREV5Q2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1USTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmRHVnRjR3hoZEdVdGRtRnlMbUZzWjI4dWRITTZOd29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUUxNVEyOXVkSEpoWTNRZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0JsY25JS0NtMWhhVzVmWjJWMFFXUmtjbVZ6YzE5eWIzVjBaVUEzT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMM1JsYlhCc1lYUmxMWFpoY2k1aGJHZHZMblJ6T2pJd0NpQWdJQ0F2THlCblpYUkJaR1J5WlhOektDa2dld29nSUNBZ1kyRnNiSE4xWWlCblpYUkJaR1J5WlhOekNpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQTRDZ3B0WVdsdVgyZGxkRUo1ZEdWelgzSnZkWFJsUURZNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12ZEdWdGNHeGhkR1V0ZG1GeUxtRnNaMjh1ZEhNNk1UWUtJQ0FnSUM4dklHZGxkRUo1ZEdWektDa2dld29nSUNBZ1kyRnNiSE4xWWlCblpYUkNlWFJsY3dvZ0lDQWdZaUJ0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU9Bb0tiV0ZwYmw5blpYUlRkSEpwYm1kZmNtOTFkR1ZBTlRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTkwWlcxd2JHRjBaUzEyWVhJdVlXeG5ieTUwY3pveE1nb2dJQ0FnTHk4Z1oyVjBVM1J5YVc1bktDa2dld29nSUNBZ1kyRnNiSE4xWWlCblpYUlRkSEpwYm1jS0lDQWdJR0lnYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFEZ0tDbTFoYVc1ZloyVjBTVzUwWDNKdmRYUmxRRFE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZkR1Z0Y0d4aGRHVXRkbUZ5TG1Gc1oyOHVkSE02T0FvZ0lDQWdMeThnWjJWMFNXNTBLQ2tnZXdvZ0lDQWdZMkZzYkhOMVlpQm5aWFJKYm5RS0lDQWdJR0lnYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFEZ0tDbTFoYVc1ZlkzSmxZWFJsWDA1dlQzQkFPVG9LSUNBZ0lHSWdiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREV3Q2dwdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQXhNVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OTBaVzF3YkdGMFpTMTJZWEl1WVd4bmJ5NTBjem8zQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1RYbERiMjUwY21GamRDQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5Qk9iMDl3Q2lBZ0lDQTlQUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQTlQUW9nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQW9nSUNBZ1kyRnNiSE4xWWlCZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1VLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmRHVnRjR3hoZEdVdGRtRnlMbUZzWjI4dWRITTZPazE1UTI5dWRISmhZM1F1WjJWMFNXNTBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFNXNTBPZ29nSUNBZ1lpQm5aWFJKYm5SZllteHZZMnRBTUFvS1oyVjBTVzUwWDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZkR1Z0Y0d4aGRHVXRkbUZ5TG1Gc1oyOHVkSE02T0FvZ0lDQWdMeThnWjJWMFNXNTBLQ2tnZXdvZ0lDQWdZMkZzYkhOMVlpQjBaWE4wY3k5aGNIQnliM1poYkhNdmRHVnRjR3hoZEdVdGRtRnlMbUZzWjI4dWRITTZPazE1UTI5dWRISmhZM1F1WjJWMFNXNTBDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZkR1Z0Y0d4aGRHVXRkbUZ5TG1Gc1oyOHVkSE02T2sxNVEyOXVkSEpoWTNRdVoyVjBVM1J5YVc1blczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwVTNSeWFXNW5PZ29nSUNBZ1lpQm5aWFJUZEhKcGJtZGZZbXh2WTJ0QU1Bb0taMlYwVTNSeWFXNW5YMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmRHVnRjR3hoZEdVdGRtRnlMbUZzWjI4dWRITTZNVElLSUNBZ0lDOHZJR2RsZEZOMGNtbHVaeWdwSUhzS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzUmxiWEJzWVhSbExYWmhjaTVoYkdkdkxuUnpPanBOZVVOdmJuUnlZV04wTG1kbGRGTjBjbWx1WndvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzUmxiWEJzWVhSbExYWmhjaTVoYkdkdkxuUnpPanBOZVVOdmJuUnlZV04wTG1kbGRFSjVkR1Z6VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBRbmwwWlhNNkNpQWdJQ0JpSUdkbGRFSjVkR1Z6WDJKc2IyTnJRREFLQ21kbGRFSjVkR1Z6WDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZkR1Z0Y0d4aGRHVXRkbUZ5TG1Gc1oyOHVkSE02TVRZS0lDQWdJQzh2SUdkbGRFSjVkR1Z6S0NrZ2V3b2dJQ0FnWTJGc2JITjFZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZkR1Z0Y0d4aGRHVXRkbUZ5TG1Gc1oyOHVkSE02T2sxNVEyOXVkSEpoWTNRdVoyVjBRbmwwWlhNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OTBaVzF3YkdGMFpTMTJZWEl1WVd4bmJ5NTBjem82VFhsRGIyNTBjbUZqZEM1blpYUkJaR1J5WlhOelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwUVdSa2NtVnpjem9LSUNBZ0lHSWdaMlYwUVdSa2NtVnpjMTlpYkc5amEwQXdDZ3BuWlhSQlpHUnlaWE56WDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZkR1Z0Y0d4aGRHVXRkbUZ5TG1Gc1oyOHVkSE02TWpBS0lDQWdJQzh2SUdkbGRFRmtaSEpsYzNNb0tTQjdDaUFnSUNCallXeHNjM1ZpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTkwWlcxd2JHRjBaUzEyWVhJdVlXeG5ieTUwY3pvNlRYbERiMjUwY21GamRDNW5aWFJCWkdSeVpYTnpDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZkR1Z0Y0d4aGRHVXRkbUZ5TG1Gc1oyOHVkSE02T2sxNVEyOXVkSEpoWTNRdVoyVjBTVzUwS0NrZ0xUNGdkV2x1ZERZME9ncDBaWE4wY3k5aGNIQnliM1poYkhNdmRHVnRjR3hoZEdVdGRtRnlMbUZzWjI4dWRITTZPazE1UTI5dWRISmhZM1F1WjJWMFNXNTBPZ29nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdmRHVnRjR3hoZEdVdGRtRnlMbUZzWjI4dWRITTZPazE1UTI5dWRISmhZM1F1WjJWMFNXNTBYMkpzYjJOclFEQUtDblJsYzNSekwyRndjSEp2ZG1Gc2N5OTBaVzF3YkdGMFpTMTJZWEl1WVd4bmJ5NTBjem82VFhsRGIyNTBjbUZqZEM1blpYUkpiblJmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OTBaVzF3YkdGMFpTMTJZWEl1WVd4bmJ5NTBjem81Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdWR1Z0Y0d4aGRHVldZWEk4ZFdsdWREWTBQaWduUVU1ZlNVNVVKeWtLSUNBZ0lHbHVkR05mTWlBdkx5QlVUVkJNWDBGT1gwbE9WQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzUmxiWEJzWVhSbExYWmhjaTVoYkdkdkxuUnpPanBOZVVOdmJuUnlZV04wTG1kbGRGTjBjbWx1WnlncElDMCtJR0o1ZEdWek9ncDBaWE4wY3k5aGNIQnliM1poYkhNdmRHVnRjR3hoZEdVdGRtRnlMbUZzWjI4dWRITTZPazE1UTI5dWRISmhZM1F1WjJWMFUzUnlhVzVuT2dvZ0lDQWdZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZkR1Z0Y0d4aGRHVXRkbUZ5TG1Gc1oyOHVkSE02T2sxNVEyOXVkSEpoWTNRdVoyVjBVM1J5YVc1blgySnNiMk5yUURBS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5MFpXMXdiR0YwWlMxMllYSXVZV3huYnk1MGN6bzZUWGxEYjI1MGNtRmpkQzVuWlhSVGRISnBibWRmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OTBaVzF3YkdGMFpTMTJZWEl1WVd4bmJ5NTBjem94TXdvZ0lDQWdMeThnY21WMGRYSnVJRlJsYlhCc1lYUmxWbUZ5UEhOMGNtbHVaejRvSjBGZlUxUlNTVTVISnlrS0lDQWdJR0o1ZEdWalh6RWdMeThnVkUxUVRGOUJYMU5VVWtsT1J3b2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNSbGJYQnNZWFJsTFhaaGNpNWhiR2R2TG5Sek9qcE5lVU52Ym5SeVlXTjBMbWRsZEVKNWRHVnpLQ2tnTFQ0Z1lubDBaWE02Q25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTkwWlcxd2JHRjBaUzEyWVhJdVlXeG5ieTUwY3pvNlRYbERiMjUwY21GamRDNW5aWFJDZVhSbGN6b0tJQ0FnSUdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDNSbGJYQnNZWFJsTFhaaGNpNWhiR2R2TG5Sek9qcE5lVU52Ym5SeVlXTjBMbWRsZEVKNWRHVnpYMkpzYjJOclFEQUtDblJsYzNSekwyRndjSEp2ZG1Gc2N5OTBaVzF3YkdGMFpTMTJZWEl1WVd4bmJ5NTBjem82VFhsRGIyNTBjbUZqZEM1blpYUkNlWFJsYzE5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMM1JsYlhCc1lYUmxMWFpoY2k1aGJHZHZMblJ6T2pFM0NpQWdJQ0F2THlCeVpYUjFjbTRnVkdWdGNHeGhkR1ZXWVhJOFlubDBaWE0rS0NkVFQwMUZYMEpaVkVWVEp5a0tJQ0FnSUdKNWRHVmpYeklnTHk4Z1ZFMVFURjlUVDAxRlgwSlpWRVZUQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZkR1Z0Y0d4aGRHVXRkbUZ5TG1Gc1oyOHVkSE02T2sxNVEyOXVkSEpoWTNRdVoyVjBRV1JrY21WemN5Z3BJQzArSUdKNWRHVnpPZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZkR1Z0Y0d4aGRHVXRkbUZ5TG1Gc1oyOHVkSE02T2sxNVEyOXVkSEpoWTNRdVoyVjBRV1JrY21WemN6b0tJQ0FnSUdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDNSbGJYQnNZWFJsTFhaaGNpNWhiR2R2TG5Sek9qcE5lVU52Ym5SeVlXTjBMbWRsZEVGa1pISmxjM05mWW14dlkydEFNQW9LZEdWemRITXZZWEJ3Y205MllXeHpMM1JsYlhCc1lYUmxMWFpoY2k1aGJHZHZMblJ6T2pwTmVVTnZiblJ5WVdOMExtZGxkRUZrWkhKbGMzTmZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5MFpXMXdiR0YwWlMxMllYSXVZV3huYnk1MGN6b3lNUW9nSUNBZ0x5OGdjbVYwZFhKdUlITndaV05wWVd4QlpHUnlaWE56Q2lBZ0lDQmllWFJsWTE4eklDOHZJRlJOVUV4ZlFVNWZRVVJFVWtWVFV3b2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNSbGJYQnNZWFJsTFhaaGNpNWhiR2R2TG5Sek9qcE5lVU52Ym5SeVlXTjBMbDlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpTZ3BJQzArSUhadmFXUTZDbDlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpUb0tJQ0FnSUdJZ1gxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsWDJKc2IyTnJRREFLQ2w5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVjlpYkc5amEwQXdPZ29nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JpSUcxaGFXNWZZbXh2WTJ0QU1Bb0tiV0ZwYmw5aWJHOWphMEF3T2dvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBREFBRUFKZ1FFRlI5OGRRQUFBRUlBQUVJQUFERWJJaE5CQUY1Q0FBQXhHU0lTUkRFWUloTkJBRXhDQUFBMkdnQ0FCTDZUSUF1QUJNR2hNcFdBQks5RDJ6YUFCQVZaeXNGUEJJNEVBQndBRmdBUUFBcENBQUJDQUFCQ0FBQUFpQUJoUXYvemlBQkZRdi90aUFBcFF2L25pQUFWUXYvaFF2L2hNUmtpRWpFWUloSVFSSWdBWFNORFFnQUFpQUJCRmloUEFWQ3dJME5DQUFDSUFEaEpGUlpYQmdKUEFWQW9Ud0ZRc0NORFFnQUFpQUFuU1JVV1Z3WUNUd0ZRS0U4QlVMQWpRMElBQUlnQUZpaFBBVkN3STBOQ0FBQWtpVUlBQUNtSlFnQUFLb2xDQUFBcmlVSUFBSWs9IiwiY2xlYXIiOiJDMElBQUlFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7IkFOX0lOVCI6eyJ0eXBlIjoiQVZNVWludDY0IiwidmFsdWUiOm51bGx9LCJBX1NUUklORyI6eyJ0eXBlIjoiQVZNU3RyaW5nIiwidmFsdWUiOm51bGx9LCJTT01FX0JZVEVTIjp7InR5cGUiOiJBVk1CeXRlcyIsInZhbHVlIjpudWxsfSwiQU5fQUREUkVTUyI6eyJ0eXBlIjoiYWRkcmVzcyIsInZhbHVlIjpudWxsfX0sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
