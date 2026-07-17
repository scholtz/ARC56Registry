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

namespace Arc56.Generated.chainaim3003.algoTITANV5.NegotiableBLTrial_0e720b1e
{


    public class NegotiableBLTrialProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public NegotiableBLTrialProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Test method like HelloWorld
        ///</summary>
        /// <param name="name"> </param>
        public async Task<string> Hello(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 190, 206, 17 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Hello_Transactions(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 190, 206, 17 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Create BL (simplified without local state)
        ///</summary>
        /// <param name="description"> </param>
        /// <param name="price"> </param>
        /// <param name="imageURI"> </param>
        /// <param name="titleJSON"> </param>
        /// <param name="complianceJSON"> </param>
        public async Task<string> CreateBl(string description, string price, string imageURI, string titleJSON, string complianceJSON, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 66, 178, 85, 232 };
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); priceAbi.From(price);
            var imageURIAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); imageURIAbi.From(imageURI);
            var titleJSONAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); titleJSONAbi.From(titleJSON);
            var complianceJSONAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); complianceJSONAbi.From(complianceJSON);

            var result = await base.CallApp(new List<object> { abiHandle, descriptionAbi, priceAbi, imageURIAbi, titleJSONAbi, complianceJSONAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> CreateBl_Transactions(string description, string price, string imageURI, string titleJSON, string complianceJSON, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 66, 178, 85, 232 };
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); priceAbi.From(price);
            var imageURIAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); imageURIAbi.From(imageURI);
            var titleJSONAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); titleJSONAbi.From(titleJSON);
            var complianceJSONAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); complianceJSONAbi.From(complianceJSON);

            return await base.MakeTransactionList(new List<object> { abiHandle, descriptionAbi, priceAbi, imageURIAbi, titleJSONAbi, complianceJSONAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get BL counter
        ///</summary>
        public async Task<ulong> GetBlCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 24, 41, 144, 222 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetBlCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 24, 41, 144, 222 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTmVnb3RpYWJsZUJMVHJpYWwiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiaGVsbG8iLCJkZXNjIjoiVGVzdCBtZXRob2QgbGlrZSBIZWxsb1dvcmxkIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjcmVhdGVCTCIsImRlc2MiOiJDcmVhdGUgQkwgKHNpbXBsaWZpZWQgd2l0aG91dCBsb2NhbCBzdGF0ZSkiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVzY3JpcHRpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByaWNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbWFnZVVSSSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGl0bGVKU09OIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjb21wbGlhbmNlSlNPTiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEJMQ291bnQiLCJkZXNjIjoiR2V0IEJMIGNvdW50ZXIiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzYwLDc3LDEzMV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2Nl0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYzLDgwLDEzNF0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTUsMjcwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0ppYkVOdmRXNTBaWElpSURCNE1UVXhaamRqTnpVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1WldkdmRHbGhZbXhsWDJKc1gzUnlhV0ZzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFNWxaMjkwYVdGaWJHVkNURlJ5YVdGc0lHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWW1GeVpWOXliM1YwYVc1blFEZ0tJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZ3dNbUpsWTJVeE1TQXdlRFF5WWpJMU5XVTRJREI0TVRneU9Ua3daR1VnTHk4Z2JXVjBhRzlrSUNKb1pXeHNieWh6ZEhKcGJtY3BjM1J5YVc1bklpd2diV1YwYUc5a0lDSmpjbVZoZEdWQ1RDaHpkSEpwYm1jc2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3NjM1J5YVc1bktYTjBjbWx1WnlJc0lHMWxkR2h2WkNBaVoyVjBRa3hEYjNWdWRDZ3BkV2x1ZERZMElnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5b1pXeHNiMTl5YjNWMFpVQXpJRzFoYVc1ZlkzSmxZWFJsUWt4ZmNtOTFkR1ZBTkNCdFlXbHVYMmRsZEVKTVEyOTFiblJmY205MWRHVkFOUW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bFoyOTBhV0ZpYkdWZllteGZkSEpwWVd3dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvekNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdUbVZuYjNScFlXSnNaVUpNVkhKcFlXd2daWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRUpNUTI5MWJuUmZjbTkxZEdWQU5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpXZHZkR2xoWW14bFgySnNYM1J5YVdGc0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16Z0tJQ0FnSUM4dklHZGxkRUpNUTI5MWJuUW9LVG9nZFdsdWREWTBJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCblpYUkNURU52ZFc1MENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJOeVpXRjBaVUpNWDNKdmRYUmxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVZuYjNScFlXSnNaVjlpYkY5MGNtbGhiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzTFRJekNpQWdJQ0F2THlCamNtVmhkR1ZDVENnS0lDQWdJQzh2SUNBZ1pHVnpZM0pwY0hScGIyNDZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdjSEpwWTJVNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ2FXMWhaMlZWVWtrNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ2RHbDBiR1ZLVTA5T09pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lHTnZiWEJzYVdGdVkyVktVMDlPT2lCemRISnBibWNLSUNBZ0lDOHZJQ2s2SUhOMGNtbHVaeUI3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVaV2R2ZEdsaFlteGxYMkpzWDNSeWFXRnNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNd29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUU1bFoyOTBhV0ZpYkdWQ1RGUnlhV0ZzSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURVS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVZuYjNScFlXSnNaVjlpYkY5MGNtbGhiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzTFRJekNpQWdJQ0F2THlCamNtVmhkR1ZDVENnS0lDQWdJQzh2SUNBZ1pHVnpZM0pwY0hScGIyNDZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdjSEpwWTJVNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ2FXMWhaMlZWVWtrNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ2RHbDBiR1ZLVTA5T09pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lHTnZiWEJzYVdGdVkyVktVMDlPT2lCemRISnBibWNLSUNBZ0lDOHZJQ2s2SUhOMGNtbHVaeUI3Q2lBZ0lDQmpZV3hzYzNWaUlHTnlaV0YwWlVKTUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlvWld4c2IxOXliM1YwWlVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bFoyOTBhV0ZpYkdWZllteGZkSEpwWVd3dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1Bb2dJQ0FnTHk4Z2FHVnNiRzhvYm1GdFpUb2djM1J5YVc1bktUb2djM1J5YVc1bklIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bFoyOTBhV0ZpYkdWZllteGZkSEpwWVd3dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvekNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdUbVZuYjNScFlXSnNaVUpNVkhKcFlXd2daWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bFoyOTBhV0ZpYkdWZllteGZkSEpwWVd3dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1Bb2dJQ0FnTHk4Z2FHVnNiRzhvYm1GdFpUb2djM1J5YVc1bktUb2djM1J5YVc1bklIc0tJQ0FnSUdOaGJHeHpkV0lnYUdWc2JHOEtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJKaGNtVmZjbTkxZEdsdVowQTRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNWxaMjkwYVdGaWJHVmZZbXhmZEhKcFlXd3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVG1WbmIzUnBZV0pzWlVKTVZISnBZV3dnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERXlDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQmpjbVZoZEdsdVp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1WldkdmRHbGhZbXhsWDJKc1gzUnlhV0ZzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2s1bFoyOTBhV0ZpYkdWQ1RGUnlhV0ZzTG1obGJHeHZLRzVoYldVNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS2FHVnNiRzg2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVZuYjNScFlXSnNaVjlpYkY5MGNtbGhiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3Q2lBZ0lDQXZMeUJvWld4c2J5aHVZVzFsT2lCemRISnBibWNwT2lCemRISnBibWNnZXdvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtVm5iM1JwWVdKc1pWOWliRjkwY21saGJDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhDaUFnSUNBdkx5QnlaWFIxY200Z1lFaGxiR3h2SUdaeWIyMGdRa3hVY21saGJDd2dKSHR1WVcxbGZXQUtJQ0FnSUhCMWMyaGllWFJsY3lBaVNHVnNiRzhnWm5KdmJTQkNURlJ5YVdGc0xDQWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNWxaMjkwYVdGaWJHVmZZbXhmZEhKcFlXd3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZUbVZuYjNScFlXSnNaVUpNVkhKcFlXd3VZM0psWVhSbFFrd29aR1Z6WTNKcGNIUnBiMjQ2SUdKNWRHVnpMQ0J3Y21salpUb2dZbmwwWlhNc0lHbHRZV2RsVlZKSk9pQmllWFJsY3l3Z2RHbDBiR1ZLVTA5T09pQmllWFJsY3l3Z1kyOXRjR3hwWVc1alpVcFRUMDQ2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LWTNKbFlYUmxRa3c2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVZuYjNScFlXSnNaVjlpYkY5MGNtbGhiQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzTFRJekNpQWdJQ0F2THlCamNtVmhkR1ZDVENnS0lDQWdJQzh2SUNBZ1pHVnpZM0pwY0hScGIyNDZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdjSEpwWTJVNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ2FXMWhaMlZWVWtrNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ2RHbDBiR1ZLVTA5T09pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lHTnZiWEJzYVdGdVkyVktVMDlPT2lCemRISnBibWNLSUNBZ0lDOHZJQ2s2SUhOMGNtbHVaeUI3Q2lBZ0lDQndjbTkwYnlBMUlERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpXZHZkR2xoWW14bFgySnNYM1J5YVdGc0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5Rb2dJQ0FnTHk4Z1lteERiM1Z1ZEdWeUlEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZbXhEYjNWdWRHVnlJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNWxaMjkwYVdGaWJHVmZZbXhmZEhKcFlXd3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOUW9nSUNBZ0x5OGdhV1lnS0NGMGFHbHpMbUpzUTI5MWJuUmxjaTVvWVhOV1lXeDFaU2tnZXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdKMWNua2dNUW9nSUNBZ1ltNTZJR055WldGMFpVSk1YMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bFoyOTBhV0ZpYkdWZllteGZkSEpwWVd3dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMUNpQWdJQ0F2THlCaWJFTnZkVzUwWlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUpzUTI5MWJuUmxjaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVaV2R2ZEdsaFlteGxYMkpzWDNSeWFXRnNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNallLSUNBZ0lDOHZJSFJvYVhNdVlteERiM1Z1ZEdWeUxuWmhiSFZsSUQwZ01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncGpjbVZoZEdWQ1RGOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1WbmIzUnBZV0pzWlY5aWJGOTBjbWxoYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVS0lDQWdJQzh2SUdKc1EyOTFiblJsY2lBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnNRMjkxYm5SbGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1WbmIzUnBZV0pzWlY5aWJGOTBjbWxoYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNd0NpQWdJQ0F2THlCMGFHbHpMbUpzUTI5MWJuUmxjaTUyWVd4MVpTQTlJSFJvYVhNdVlteERiM1Z1ZEdWeUxuWmhiSFZsSUNzZ01Rb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVaV2R2ZEdsaFlteGxYMkpzWDNSeWFXRnNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOUW9nSUNBZ0x5OGdZbXhEYjNWdWRHVnlJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWJFTnZkVzUwWlhJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1WbmIzUnBZV0pzWlY5aWJGOTBjbWxoYkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNd0NpQWdJQ0F2THlCMGFHbHpMbUpzUTI5MWJuUmxjaTUyWVd4MVpTQTlJSFJvYVhNdVlteERiM1Z1ZEdWeUxuWmhiSFZsSUNzZ01Rb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpXZHZkR2xoWW14bFgySnNYM1J5YVdGc0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16SUtJQ0FnSUM4dklISmxkSFZ5YmlCZ1EzSmxZWFJsWkNCQ1RDQm1iM0lnSkh0a1pYTmpjbWx3ZEdsdmJuMGdkbUZzZFdWa0lHRjBJQ1I3Y0hKcFkyVjlZQW9nSUNBZ2NIVnphR0o1ZEdWeklDSkRjbVZoZEdWa0lFSk1JR1p2Y2lBaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRVS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SUNJZ2RtRnNkV1ZrSUdGMElDSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCamIyNWpZWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVaV2R2ZEdsaFlteGxYMkpzWDNSeWFXRnNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPazVsWjI5MGFXRmliR1ZDVEZSeWFXRnNMbWRsZEVKTVEyOTFiblFvS1NBdFBpQjFhVzUwTmpRNkNtZGxkRUpNUTI5MWJuUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtVm5iM1JwWVdKc1pWOWliRjkwY21saGJDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVUtJQ0FnSUM4dklHSnNRMjkxYm5SbGNpQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUpzUTI5MWJuUmxjaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVaV2R2ZEdsaFlteGxYMkpzWDNSeWFXRnNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNemtLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TG1Kc1EyOTFiblJsY2k1b1lYTldZV3gxWlNBL0lIUm9hWE11WW14RGIzVnVkR1Z5TG5aaGJIVmxJRG9nTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2daMlYwUWt4RGIzVnVkRjkwWlhKdVlYSjVYMlpoYkhObFFESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpXZHZkR2xoWW14bFgySnNYM1J5YVdGc0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5Rb2dJQ0FnTHk4Z1lteERiM1Z1ZEdWeUlEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZbXhEYjNWdWRHVnlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpXZHZkR2xoWW14bFgySnNYM1J5YVdGc0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16a0tJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbUpzUTI5MWJuUmxjaTVvWVhOV1lXeDFaU0EvSUhSb2FYTXVZbXhEYjNWdWRHVnlMblpoYkhWbElEb2dNQW9nSUNBZ2NtVjBjM1ZpQ2dwblpYUkNURU52ZFc1MFgzUmxjbTVoY25sZlptRnNjMlZBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1WldkdmRHbGhZbXhsWDJKc1gzUnlhV0ZzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXprS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxtSnNRMjkxYm5SbGNpNW9ZWE5XWVd4MVpTQS9JSFJvYVhNdVlteERiM1Z1ZEdWeUxuWmhiSFZsSURvZ01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSEpsZEhOMVlnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUNBQUVtQWdsaWJFTnZkVzUwWlhJRUZSOThkVEViUVFDRGdnTUVBcjdPRVFSQ3NsWG9CQmdwa040MkdnQ09Bd0JKQUJNQUFpSkRNUmtVUkRFWVJJZ0F3QllwVEZDd0kwTXhHUlJFTVJoRU5ob0JWd0lBTmhvQ1Z3SUFOaG9EVndJQU5ob0VWd0lBTmhvRlZ3SUFpQUJVU1JVV1Z3WUNURkFwVEZDd0kwTXhHUlJFTVJoRU5ob0JWd0lBaUFBWlNSVVdWd1lDVEZBcFRGQ3dJME14R1VEL2xERVlGRVFqUTRvQkFZQVVTR1ZzYkc4Z1puSnZiU0JDVEZSeWFXRnNMQ0NMLzFDSmlnVUJJaWhsUlFGQUFBTW9JbWNpS0dWRUl3Z29UR2VBRDBOeVpXRjBaV1FnUWt3Z1ptOXlJSXY3VUlBTElIWmhiSFZsWkNCaGRDQlFpL3hRaVNJb1pVVUJRUUFGSWlobFJJa2lpUT09IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6NywicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
