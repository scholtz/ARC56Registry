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

namespace Arc56.Generated.mohamedevweb.hackathon_trustai.TrustAI_caea6799
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVHJ1c3RBSSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJmdW5kX2NvbnRyYWN0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjbGllbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmcmVlbGFuY2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2YWxpZGF0ZV93aXRoX2FpIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhaV9yZXN1bHQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWxlYXNlX3BheW1lbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjJ9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6Wzc4LDEwMiwxMzFdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzBdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MSwxMDUsMTM0XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3MywzMDgsMzEyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0TVRVeFpqZGpOelVnSW5aaGJHbGtZWFJsWkNJZ0ltWnlaV1ZzWVc1alpYSWlJQ0poYlc5MWJuUWlDaUFnSUNBdkx5QndjbTlxWldOMGN5OXpiV0Z5ZEMxamIyNTBjbUZqZEM5emJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmhhUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalFLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCVWNuVnpkRUZKSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZZbUZ5WlY5eWIzVjBhVzVuUURnS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhoaE1UTmhNekkxTkNBd2VEZGlaVEE1TkRRd0lEQjRNVEV6WVRnNFpUUWdMeThnYldWMGFHOWtJQ0ptZFc1a1gyTnZiblJ5WVdOMEtHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4MWFXNTBOalFwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0oyWVd4cFpHRjBaVjkzYVhSb1gyRnBLR0p2YjJ3cGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKeVpXeGxZWE5sWDNCaGVXMWxiblFvS1hOMGNtbHVaeUlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZablZ1WkY5amIyNTBjbUZqZEY5eWIzVjBaVUF6SUcxaGFXNWZkbUZzYVdSaGRHVmZkMmwwYUY5aGFWOXliM1YwWlVBMElHMWhhVzVmY21Wc1pXRnpaVjl3WVhsdFpXNTBYM0p2ZFhSbFFEVUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TWpvS0lDQWdJQzh2SUhCeWIycGxZM1J6TDNOdFlYSjBMV052Ym5SeVlXTjBMM050WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEdGcEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRlJ5ZFhOMFFVa2daWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzSmxiR1ZoYzJWZmNHRjViV1Z1ZEY5eWIzVjBaVUExT2dvZ0lDQWdMeThnY0hKdmFtVmpkSE12YzIxaGNuUXRZMjl1ZEhKaFkzUXZjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWVdrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQnlaV3hsWVhObFgzQmhlVzFsYm5RS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1poYkdsa1lYUmxYM2RwZEdoZllXbGZjbTkxZEdWQU5Eb0tJQ0FnSUM4dklIQnliMnBsWTNSekwzTnRZWEowTFdOdmJuUnlZV04wTDNOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRHRnBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklIQnliMnBsWTNSekwzTnRZWEowTFdOdmJuUnlZV04wTDNOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRHRnBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZSeWRYTjBRVWtnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQXZMeUJ3Y205cVpXTjBjeTl6YldGeWRDMWpiMjUwY21GamRDOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JoYVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMkZzYkhOMVlpQjJZV3hwWkdGMFpWOTNhWFJvWDJGcENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDltZFc1a1gyTnZiblJ5WVdOMFgzSnZkWFJsUURNNkNpQWdJQ0F2THlCd2NtOXFaV04wY3k5emJXRnlkQzFqYjI1MGNtRmpkQzl6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSaGFTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCd2NtOXFaV04wY3k5emJXRnlkQzFqYjI1MGNtRmpkQzl6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSaGFTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJVY25WemRFRkpJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjSEp2YW1WamRITXZjMjFoY25RdFkyOXVkSEpoWTNRdmMyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBZV2t2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1puVnVaRjlqYjI1MGNtRmpkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlltRnlaVjl5YjNWMGFXNW5RRGc2Q2lBZ0lDQXZMeUJ3Y205cVpXTjBjeTl6YldGeWRDMWpiMjUwY21GamRDOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JoYVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlVjblZ6ZEVGSklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TWdvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnWTNKbFlYUnBibWNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QndjbTlxWldOMGN5OXpiV0Z5ZEMxamIyNTBjbUZqZEM5emJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmhhUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBVY25WemRFRkpMbVoxYm1SZlkyOXVkSEpoWTNRb1kyeHBaVzUwT2lCaWVYUmxjeXdnWm5KbFpXeGhibU5sY2pvZ1lubDBaWE1zSUdGdGIzVnVkRG9nZFdsdWREWTBLU0F0UGlCaWVYUmxjem9LWm5WdVpGOWpiMjUwY21GamREb0tJQ0FnSUM4dklIQnliMnBsWTNSekwzTnRZWEowTFdOdmJuUnlZV04wTDNOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRHRnBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEF0TVRFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUJtZFc1a1gyTnZiblJ5WVdOMEtHTnNhV1Z1ZERvZ1lYSmpOQzVCWkdSeVpYTnpMQ0JtY21WbGJHRnVZMlZ5T2lCaGNtTTBMa0ZrWkhKbGMzTXNJR0Z0YjNWdWREb2dkV2x1ZERZMEtTQjdDaUFnSUNCd2NtOTBieUF6SURFS0lDQWdJQzh2SUhCeWIycGxZM1J6TDNOdFlYSjBMV052Ym5SeVlXTjBMM050WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEdGcEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5Rb2dJQ0FnTHk4Z1kyeHBaVzUwSUQwZ1IyeHZZbUZzVTNSaGRHVThZWEpqTkM1QlpHUnlaWE56UGlncENpQWdJQ0J3ZFhOb1lubDBaWE1nSW1Oc2FXVnVkQ0lLSUNBZ0lDOHZJSEJ5YjJwbFkzUnpMM050WVhKMExXTnZiblJ5WVdOMEwzTnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkR0ZwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJS0lDQWdJQzh2SUhSb2FYTXVZMnhwWlc1MExuWmhiSFZsSUQwZ1kyeHBaVzUwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ3Y205cVpXTjBjeTl6YldGeWRDMWpiMjUwY21GamRDOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JoYVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZS0lDQWdJQzh2SUdaeVpXVnNZVzVqWlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhoY21NMExrRmtaSEpsYzNNK0tDa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltWnlaV1ZzWVc1alpYSWlDaUFnSUNBdkx5QndjbTlxWldOMGN5OXpiV0Z5ZEMxamIyNTBjbUZqZEM5emJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmhhUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6Q2lBZ0lDQXZMeUIwYUdsekxtWnlaV1ZzWVc1alpYSXVkbUZzZFdVZ1BTQm1jbVZsYkdGdVkyVnlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QndjbTlxWldOMGN5OXpiV0Z5ZEMxamIyNTBjbUZqZEM5emJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmhhUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamNLSUNBZ0lDOHZJR0Z0YjNWdWRDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpWVcxdmRXNTBJZ29nSUNBZ0x5OGdjSEp2YW1WamRITXZjMjFoY25RdFkyOXVkSEpoWTNRdmMyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBZV2t2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkFvZ0lDQWdMeThnZEdocGN5NWhiVzkxYm5RdWRtRnNkV1VnUFNCaGJXOTFiblFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSEJ5YjJwbFkzUnpMM050WVhKMExXTnZiblJ5WVdOMEwzTnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkR0ZwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0FvZ0lDQWdMeThnZG1Gc2FXUmhkR1ZrSUQwZ1IyeHZZbUZzVTNSaGRHVThZbTl2YkdWaGJqNG9LUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlkbUZzYVdSaGRHVmtJZ29nSUNBZ0x5OGdjSEp2YW1WamRITXZjMjFoY25RdFkyOXVkSEpoWTNRdmMyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBZV2t2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlFvZ0lDQWdMeThnZEdocGN5NTJZV3hwWkdGMFpXUXVkbUZzZFdVZ1BTQm1ZV3h6WlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ3Y205cVpXTjBjeTl6YldGeWRDMWpiMjUwY21GamRDOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JoYVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMkNpQWdJQ0F2THlCeVpYUjFjbTRnSWtOdmJuUnlZV04wSUdaMWJtUmxaQ0R3bjVLd0lnb2dJQ0FnY0hWemFHSjVkR1Z6SUNKRGIyNTBjbUZqZENCbWRXNWtaV1FnWEhobU1GeDRPV1pjZURreVhIaGlNQ0lLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSEJ5YjJwbFkzUnpMM050WVhKMExXTnZiblJ5WVdOMEwzTnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkR0ZwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xSeWRYTjBRVWt1ZG1Gc2FXUmhkR1ZmZDJsMGFGOWhhU2hoYVY5eVpYTjFiSFE2SUhWcGJuUTJOQ2tnTFQ0Z1lubDBaWE02Q25aaGJHbGtZWFJsWDNkcGRHaGZZV2s2Q2lBZ0lDQXZMeUJ3Y205cVpXTjBjeTl6YldGeWRDMWpiMjUwY21GamRDOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JoYVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNUxUSXdDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z2RtRnNhV1JoZEdWZmQybDBhRjloYVNoaGFWOXlaWE4xYkhRNklHSnZiMnhsWVc0cElIc0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdMeThnY0hKdmFtVmpkSE12YzIxaGNuUXRZMjl1ZEhKaFkzUXZjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWVdrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNENpQWdJQ0F2THlCMllXeHBaR0YwWldRZ1BTQkhiRzlpWVd4VGRHRjBaVHhpYjI5c1pXRnVQaWdwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0oyWVd4cFpHRjBaV1FpQ2lBZ0lDQXZMeUJ3Y205cVpXTjBjeTl6YldGeWRDMWpiMjUwY21GamRDOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JoYVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJeENpQWdJQ0F2THlCMGFHbHpMblpoYkdsa1lYUmxaQzUyWVd4MVpTQTlJR0ZwWDNKbGMzVnNkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjSEp2YW1WamRITXZjMjFoY25RdFkyOXVkSEpoWTNRdmMyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBZV2t2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TWdvZ0lDQWdMeThnY21WMGRYSnVJR0ZwWDNKbGMzVnNkQ0EvSUNKQlNTQjJZV3hwWkdGMFpXUWc0cHlGSWlBNklDSkJTU0J5WldwbFkzUmxaQ0Rpbll3aUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0o2SUhaaGJHbGtZWFJsWDNkcGRHaGZZV2xmZEdWeWJtRnllVjltWVd4elpVQXlDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrRkpJSFpoYkdsa1lYUmxaQ0JjZUdVeVhIZzVZMXg0T0RVaUNpQWdJQ0J5WlhSemRXSUtDblpoYkdsa1lYUmxYM2RwZEdoZllXbGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeU9nb2dJQ0FnTHk4Z2NISnZhbVZqZEhNdmMyMWhjblF0WTI5dWRISmhZM1F2YzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFlXa3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNZ29nSUNBZ0x5OGdjbVYwZFhKdUlHRnBYM0psYzNWc2RDQS9JQ0pCU1NCMllXeHBaR0YwWldRZzRweUZJaUE2SUNKQlNTQnlaV3BsWTNSbFpDRGluWXdpQ2lBZ0lDQndkWE5vWW5sMFpYTWdJa0ZKSUhKbGFtVmpkR1ZrSUZ4NFpUSmNlRGxrWEhnNFl5SUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklIQnliMnBsWTNSekwzTnRZWEowTFdOdmJuUnlZV04wTDNOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRHRnBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbFJ5ZFhOMFFVa3VjbVZzWldGelpWOXdZWGx0Wlc1MEtDa2dMVDRnWW5sMFpYTTZDbkpsYkdWaGMyVmZjR0Y1YldWdWREb0tJQ0FnSUM4dklIQnliMnBsWTNSekwzTnRZWEowTFdOdmJuUnlZV04wTDNOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRHRnBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPQW9nSUNBZ0x5OGdkbUZzYVdSaGRHVmtJRDBnUjJ4dlltRnNVM1JoZEdVOFltOXZiR1ZoYmo0b0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5aaGJHbGtZWFJsWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ3Y205cVpXTjBjeTl6YldGeWRDMWpiMjUwY21GamRDOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JoYVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJM0NpQWdJQ0F2THlCcFppQW9JWFJvYVhNdWRtRnNhV1JoZEdWa0xuWmhiSFZsS1NCeVpYUjFjbTRnSWtGSklHNXZkQ0IyWVd4cFpHRjBaV1FnZVdWMElPS2RqQ0lLSUNBZ0lHSnVlaUJ5Wld4bFlYTmxYM0JoZVcxbGJuUmZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0J3ZFhOb1lubDBaWE1nSWtGSklHNXZkQ0IyWVd4cFpHRjBaV1FnZVdWMElGeDRaVEpjZURsa1hIZzRZeUlLSUNBZ0lISmxkSE4xWWdvS2NtVnNaV0Z6WlY5d1lYbHRaVzUwWDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSEJ5YjJwbFkzUnpMM050WVhKMExXTnZiblJ5WVdOMEwzTnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkR0ZwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpnS0lDQWdJQzh2SUdsMGVHNHVjR0Y1YldWdWRDaDdJSEpsWTJWcGRtVnlPaUIwYUdsekxtWnlaV1ZzWVc1alpYSXVkbUZzZFdVdWJtRjBhWFpsTENCaGJXOTFiblE2SUhSb2FYTXVZVzF2ZFc1MExuWmhiSFZsSUgwcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ3Y205cVpXTjBjeTl6YldGeWRDMWpiMjUwY21GamRDOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JoYVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZS0lDQWdJQzh2SUdaeVpXVnNZVzVqWlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhoY21NMExrRmtaSEpsYzNNK0tDa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKbWNtVmxiR0Z1WTJWeUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhCeWIycGxZM1J6TDNOdFlYSjBMV052Ym5SeVlXTjBMM050WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEdGcEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk53b2dJQ0FnTHk4Z1lXMXZkVzUwSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaVlXMXZkVzUwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUZKbFkyVnBkbVZ5Q2lBZ0lDQXZMeUJ3Y205cVpXTjBjeTl6YldGeWRDMWpiMjUwY21GamRDOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JoYVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNENpQWdJQ0F2THlCcGRIaHVMbkJoZVcxbGJuUW9leUJ5WldObGFYWmxjam9nZEdocGN5NW1jbVZsYkdGdVkyVnlMblpoYkhWbExtNWhkR2wyWlN3Z1lXMXZkVzUwT2lCMGFHbHpMbUZ0YjNWdWRDNTJZV3gxWlNCOUtTNXpkV0p0YVhRb0tRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklIQnliMnBsWTNSekwzTnRZWEowTFdOdmJuUnlZV04wTDNOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRHRnBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamtLSUNBZ0lDOHZJSEpsZEhWeWJpQWlVR0Y1YldWdWRDQnlaV3hsWVhObFpDRHduNUs0SWdvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pRWVhsdFpXNTBJSEpsYkdWaGMyVmtJRng0WmpCY2VEbG1YSGc1TWx4NFlqZ2lDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFDQUFFbUJBUVZIM3gxQ1haaGJHbGtZWFJsWkFwbWNtVmxiR0Z1WTJWeUJtRnRiM1Z1ZERFYlFRQjFnZ01Fb1RveVZBUjc0SlJBQkJFNmlPUTJHZ0NPQXdBM0FCb0FBaUpETVJrVVJERVlSSWdBdVVrVkZsY0dBa3hRS0V4UXNDTkRNUmtVUkRFWVJEWWFBU0pUaUFCclNSVVdWd1lDVEZBb1RGQ3dJME14R1JSRU1SaEVOaG9CTmhvQ05ob0RGNGdBR1VrVkZsY0dBa3hRS0V4UXNDTkRNUmxBLzZJeEdCUkVJME9LQXdHQUJtTnNhV1Z1ZEl2OVp5cUwvbWNyaS85bktTSm5nQlJEYjI1MGNtRmpkQ0JtZFc1a1pXUWc4SitTc0ltS0FRRXBpLzluaS85QkFCT0FFRUZKSUhaaGJHbGtZWFJsWkNEaW5JV0pnQTlCU1NCeVpXcGxZM1JsWkNEaW5ZeUpJaWxsUkVBQUc0QVlRVWtnYm05MElIWmhiR2xrWVhSbFpDQjVaWFFnNHAyTWliRWlLbVZFSWl0bFJMSUlzZ2Nqc2hBaXNnR3pnQlZRWVhsdFpXNTBJSEpsYkdWaGMyVmtJUENma3JpSiIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjcsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
