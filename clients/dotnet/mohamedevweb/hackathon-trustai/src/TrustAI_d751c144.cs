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

namespace Arc56.Generated.mohamedevweb.hackathon_trustai.TrustAI_d751c144
{


    public class TrustAIProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TrustAIProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="client"> </param>
        /// <param name="freelancer"> </param>
        /// <param name="amount"> </param>
        public async Task<string> FundContract(Algorand.Address client, Algorand.Address freelancer, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 161, 58, 50, 84 };
            var clientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); clientAbi.From(client);
            var freelancerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); freelancerAbi.From(freelancer);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, clientAbi, freelancerAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> FundContract_Transactions(Algorand.Address client, Algorand.Address freelancer, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 161, 58, 50, 84 };
            var clientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); clientAbi.From(client);
            var freelancerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); freelancerAbi.From(freelancer);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, clientAbi, freelancerAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="ai_result"> </param>
        public async Task<string> ValidateWithAi(bool ai_result, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 123, 224, 148, 64 };
            var ai_resultAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); ai_resultAbi.From(ai_result);

            var result = await base.CallApp(new List<object> { abiHandle, ai_resultAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> ValidateWithAi_Transactions(bool ai_result, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 123, 224, 148, 64 };
            var ai_resultAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); ai_resultAbi.From(ai_result);

            return await base.MakeTransactionList(new List<object> { abiHandle, ai_resultAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> ReleasePayment(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 58, 136, 228 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> ReleasePayment_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 58, 136, 228 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVHJ1c3RBSSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJmdW5kX2NvbnRyYWN0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjbGllbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmcmVlbGFuY2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2YWxpZGF0ZV93aXRoX2FpIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhaV9yZXN1bHQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWxlYXNlX3BheW1lbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjJ9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6Wzc4LDEwMiwxMzFdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzBdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MSwxMDUsMTM0XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3MywzMDgsMzEyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0TVRVeFpqZGpOelVnSW5aaGJHbGtZWFJsWkNJZ0ltWnlaV1ZzWVc1alpYSWlJQ0poYlc5MWJuUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JoYVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlVjblZ6ZEVGSklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWW1GeVpWOXliM1YwYVc1blFEZ0tJQ0FnSUhCMWMyaGllWFJsYzNNZ01IaGhNVE5oTXpJMU5DQXdlRGRpWlRBNU5EUXdJREI0TVRFellUZzRaVFFnTHk4Z2JXVjBhRzlrSUNKbWRXNWtYMk52Ym5SeVlXTjBLR0ZrWkhKbGMzTXNZV1JrY21WemN5eDFhVzUwTmpRcGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKMllXeHBaR0YwWlY5M2FYUm9YMkZwS0dKdmIyd3BjM1J5YVc1bklpd2diV1YwYUc5a0lDSnlaV3hsWVhObFgzQmhlVzFsYm5Rb0tYTjBjbWx1WnlJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmWm5WdVpGOWpiMjUwY21GamRGOXliM1YwWlVBeklHMWhhVzVmZG1Gc2FXUmhkR1ZmZDJsMGFGOWhhVjl5YjNWMFpVQTBJRzFoYVc1ZmNtVnNaV0Z6WlY5d1lYbHRaVzUwWDNKdmRYUmxRRFVLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkR0ZwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGUnlkWE4wUVVrZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNKbGJHVmhjMlZmY0dGNWJXVnVkRjl5YjNWMFpVQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWVdrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQnlaV3hsWVhObFgzQmhlVzFsYm5RS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1poYkdsa1lYUmxYM2RwZEdoZllXbGZjbTkxZEdWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkR0ZwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRrS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEdGcEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRlJ5ZFhOMFFVa2daWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JoYVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMkZzYkhOMVlpQjJZV3hwWkdGMFpWOTNhWFJvWDJGcENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDltZFc1a1gyTnZiblJ5WVdOMFgzSnZkWFJsUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmhhUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JoYVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlVjblZ6ZEVGSklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBZV2t2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1puVnVaRjlqYjI1MGNtRmpkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlltRnlaVjl5YjNWMGFXNW5RRGc2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSaGFTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJVY25WemRFRkpJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE1nb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z1kzSmxZWFJwYm1jS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSaGFTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFVjblZ6ZEVGSkxtWjFibVJmWTI5dWRISmhZM1FvWTJ4cFpXNTBPaUJpZVhSbGN5d2dabkpsWld4aGJtTmxjam9nWW5sMFpYTXNJR0Z0YjNWdWREb2dkV2x1ZERZMEtTQXRQaUJpZVhSbGN6b0tablZ1WkY5amIyNTBjbUZqZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRHRnBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEF0TVRFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUJtZFc1a1gyTnZiblJ5WVdOMEtHTnNhV1Z1ZERvZ1lYSmpOQzVCWkdSeVpYTnpMQ0JtY21WbGJHRnVZMlZ5T2lCaGNtTTBMa0ZrWkhKbGMzTXNJR0Z0YjNWdWREb2dkV2x1ZERZMEtTQjdDaUFnSUNCd2NtOTBieUF6SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRHRnBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOUW9nSUNBZ0x5OGdZMnhwWlc1MElEMGdSMnh2WW1Gc1UzUmhkR1U4WVhKak5DNUJaR1J5WlhOelBpZ3BDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltTnNhV1Z1ZENJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRHRnBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVElLSUNBZ0lDOHZJSFJvYVhNdVkyeHBaVzUwTG5aaGJIVmxJRDBnWTJ4cFpXNTBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JoYVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZS0lDQWdJQzh2SUdaeVpXVnNZVzVqWlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhoY21NMExrRmtaSEpsYzNNK0tDa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltWnlaV1ZzWVc1alpYSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JoYVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFekNpQWdJQ0F2THlCMGFHbHpMbVp5WldWc1lXNWpaWEl1ZG1Gc2RXVWdQU0JtY21WbGJHRnVZMlZ5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSaGFTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY0tJQ0FnSUM4dklHRnRiM1Z1ZENBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LUW9nSUNBZ1lubDBaV05mTXlBdkx5QWlZVzF2ZFc1MElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBZV2t2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkFvZ0lDQWdMeThnZEdocGN5NWhiVzkxYm5RdWRtRnNkV1VnUFNCaGJXOTFiblFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEdGcEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9Bb2dJQ0FnTHk4Z2RtRnNhV1JoZEdWa0lEMGdSMnh2WW1Gc1UzUmhkR1U4WW05dmJHVmhiajRvS1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpZG1Gc2FXUmhkR1ZrSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFlXa3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOUW9nSUNBZ0x5OGdkR2hwY3k1MllXeHBaR0YwWldRdWRtRnNkV1VnUFNCbVlXeHpaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JoYVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMkNpQWdJQ0F2THlCeVpYUjFjbTRnSWtOdmJuUnlZV04wSUdaMWJtUmxaQ0R3bjVLd0lnb2dJQ0FnY0hWemFHSjVkR1Z6SUNKRGIyNTBjbUZqZENCbWRXNWtaV1FnWEhobU1GeDRPV1pjZURreVhIaGlNQ0lLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEdGcEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sUnlkWE4wUVVrdWRtRnNhV1JoZEdWZmQybDBhRjloYVNoaGFWOXlaWE4xYkhRNklIVnBiblEyTkNrZ0xUNGdZbmwwWlhNNkNuWmhiR2xrWVhSbFgzZHBkR2hmWVdrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmhhUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU1TFRJd0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnZG1Gc2FXUmhkR1ZmZDJsMGFGOWhhU2hoYVY5eVpYTjFiSFE2SUdKdmIyeGxZVzRwSUhzS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWVdrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNENpQWdJQ0F2THlCMllXeHBaR0YwWldRZ1BTQkhiRzlpWVd4VGRHRjBaVHhpYjI5c1pXRnVQaWdwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0oyWVd4cFpHRjBaV1FpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSaGFTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXhDaUFnSUNBdkx5QjBhR2x6TG5aaGJHbGtZWFJsWkM1MllXeDFaU0E5SUdGcFgzSmxjM1ZzZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFlXa3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNZ29nSUNBZ0x5OGdjbVYwZFhKdUlHRnBYM0psYzNWc2RDQS9JQ0pCU1NCMllXeHBaR0YwWldRZzRweUZJaUE2SUNKQlNTQnlaV3BsWTNSbFpDRGluWXdpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSjZJSFpoYkdsa1lYUmxYM2RwZEdoZllXbGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeUNpQWdJQ0J3ZFhOb1lubDBaWE1nSWtGSklIWmhiR2xrWVhSbFpDQmNlR1V5WEhnNVkxeDRPRFVpQ2lBZ0lDQnlaWFJ6ZFdJS0NuWmhiR2xrWVhSbFgzZHBkR2hmWVdsZmRHVnlibUZ5ZVY5bVlXeHpaVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFlXa3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNZ29nSUNBZ0x5OGdjbVYwZFhKdUlHRnBYM0psYzNWc2RDQS9JQ0pCU1NCMllXeHBaR0YwWldRZzRweUZJaUE2SUNKQlNTQnlaV3BsWTNSbFpDRGluWXdpQ2lBZ0lDQndkWE5vWW5sMFpYTWdJa0ZKSUhKbGFtVmpkR1ZrSUZ4NFpUSmNlRGxrWEhnNFl5SUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkR0ZwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xSeWRYTjBRVWt1Y21Wc1pXRnpaVjl3WVhsdFpXNTBLQ2tnTFQ0Z1lubDBaWE02Q25KbGJHVmhjMlZmY0dGNWJXVnVkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEdGcEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9Bb2dJQ0FnTHk4Z2RtRnNhV1JoZEdWa0lEMGdSMnh2WW1Gc1UzUmhkR1U4WW05dmJHVmhiajRvS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblpoYkdsa1lYUmxaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JoYVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJM0NpQWdJQ0F2THlCcFppQW9JWFJvYVhNdWRtRnNhV1JoZEdWa0xuWmhiSFZsS1NCeVpYUjFjbTRnSWtGSklHNXZkQ0IyWVd4cFpHRjBaV1FnZVdWMElPS2RqQ0lLSUNBZ0lHSnVlaUJ5Wld4bFlYTmxYM0JoZVcxbGJuUmZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0J3ZFhOb1lubDBaWE1nSWtGSklHNXZkQ0IyWVd4cFpHRjBaV1FnZVdWMElGeDRaVEpjZURsa1hIZzRZeUlLSUNBZ0lISmxkSE4xWWdvS2NtVnNaV0Z6WlY5d1lYbHRaVzUwWDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEdGcEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qZ0tJQ0FnSUM4dklHbDBlRzR1Y0dGNWJXVnVkQ2g3SUhKbFkyVnBkbVZ5T2lCMGFHbHpMbVp5WldWc1lXNWpaWEl1ZG1Gc2RXVXVibUYwYVhabExDQmhiVzkxYm5RNklIUm9hWE11WVcxdmRXNTBMblpoYkhWbElIMHBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmhhUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPallLSUNBZ0lDOHZJR1p5WldWc1lXNWpaWElnUFNCSGJHOWlZV3hUZEdGMFpUeGhjbU0wTGtGa1pISmxjM00rS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0ptY21WbGJHRnVZMlZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEdGcEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk53b2dJQ0FnTHk4Z1lXMXZkVzUwSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaVlXMXZkVzUwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUZKbFkyVnBkbVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSaGFTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTRDaUFnSUNBdkx5QnBkSGh1TG5CaGVXMWxiblFvZXlCeVpXTmxhWFpsY2pvZ2RHaHBjeTVtY21WbGJHRnVZMlZ5TG5aaGJIVmxMbTVoZEdsMlpTd2dZVzF2ZFc1ME9pQjBhR2x6TG1GdGIzVnVkQzUyWVd4MVpTQjlLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEdGcEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qa0tJQ0FnSUM4dklISmxkSFZ5YmlBaVVHRjViV1Z1ZENCeVpXeGxZWE5sWkNEd241SzRJZ29nSUNBZ2NIVnphR0o1ZEdWeklDSlFZWGx0Wlc1MElISmxiR1ZoYzJWa0lGeDRaakJjZURsbVhIZzVNbHg0WWpnaUNpQWdJQ0J5WlhSemRXSUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUNBQUVtQkFRVkgzeDFDWFpoYkdsa1lYUmxaQXBtY21WbGJHRnVZMlZ5Qm1GdGIzVnVkREViUVFCMWdnTUVvVG95VkFSNzRKUkFCQkU2aU9RMkdnQ09Bd0EzQUJvQUFpSkRNUmtVUkRFWVJJZ0F1VWtWRmxjR0FreFFLRXhRc0NORE1Sa1VSREVZUkRZYUFTSlRpQUJyU1JVV1Z3WUNURkFvVEZDd0kwTXhHUlJFTVJoRU5ob0JOaG9DTmhvREY0Z0FHVWtWRmxjR0FreFFLRXhRc0NORE1SbEEvNkl4R0JSRUkwT0tBd0dBQm1Oc2FXVnVkSXY5WnlxTC9tY3JpLzluS1NKbmdCUkRiMjUwY21GamRDQm1kVzVrWldRZzhKK1NzSW1LQVFFcGkvOW5pLzlCQUJPQUVFRkpJSFpoYkdsa1lYUmxaQ0RpbklXSmdBOUJTU0J5WldwbFkzUmxaQ0Rpbll5SklpbGxSRUFBRzRBWVFVa2dibTkwSUhaaGJHbGtZWFJsWkNCNVpYUWc0cDJNaWJFaUttVkVJaXRsUkxJSXNnY2pzaEFpc2dHemdCVlFZWGx0Wlc1MElISmxiR1ZoYzJWa0lQQ2ZrcmlKIiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6NywicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
