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

namespace Arc56.Generated.akita_protocol.akita_sc.MockNfdPairRegistry_5e9e0842
{


    //
    // Test-only registry with two explicit valid name/app ID pairs. Named apart from
    //`mocks/nfd/contract.algo.ts`'s `MockNfdRegistry`: generated clients share one flat SDK directory.
    //
    public class MockNfdPairRegistryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MockNfdPairRegistryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task Create(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="firstName"> </param>
        /// <param name="firstAppId"> </param>
        /// <param name="secondName"> </param>
        /// <param name="secondAppId"> </param>
        public async Task Configure(string firstName, ulong firstAppId, string secondName, ulong secondAppId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 38, 157, 115 };
            var firstNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); firstNameAbi.From(firstName);
            var firstAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); firstAppIdAbi.From(firstAppId);
            var secondNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); secondNameAbi.From(secondName);
            var secondAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); secondAppIdAbi.From(secondAppId);

            var result = await base.CallApp(new List<object> { abiHandle, firstNameAbi, firstAppIdAbi, secondNameAbi, secondAppIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Configure_Transactions(string firstName, ulong firstAppId, string secondName, ulong secondAppId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 38, 157, 115 };
            var firstNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); firstNameAbi.From(firstName);
            var firstAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); firstAppIdAbi.From(firstAppId);
            var secondNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); secondNameAbi.From(secondName);
            var secondAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); secondAppIdAbi.From(secondAppId);

            return await base.MakeTransactionList(new List<object> { abiHandle, firstNameAbi, firstAppIdAbi, secondNameAbi, secondAppIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="nfdName"> </param>
        /// <param name="nfdAppId"> </param>
        public async Task<bool> IsValidNfdAppId(string nfdName, ulong nfdAppId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 75, 226, 47, 198 };
            var nfdNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nfdNameAbi.From(nfdName);
            var nfdAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nfdAppIdAbi.From(nfdAppId);

            var result = await base.CallApp(new List<object> { abiHandle, nfdNameAbi, nfdAppIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsValidNfdAppId_Transactions(string nfdName, ulong nfdAppId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 75, 226, 47, 198 };
            var nfdNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nfdNameAbi.From(nfdName);
            var nfdAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nfdAppIdAbi.From(nfdAppId);

            return await base.MakeTransactionList(new List<object> { abiHandle, nfdNameAbi, nfdAppIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTW9ja05mZFBhaXJSZWdpc3RyeSIsImRlc2MiOiJUZXN0LW9ubHkgcmVnaXN0cnkgd2l0aCB0d28gZXhwbGljaXQgdmFsaWQgbmFtZS9hcHAgSUQgcGFpcnMuIE5hbWVkIGFwYXJ0IGZyb21cbmBtb2Nrcy9uZmQvY29udHJhY3QuYWxnby50c2AncyBgTW9ja05mZFJlZ2lzdHJ5YDogZ2VuZXJhdGVkIGNsaWVudHMgc2hhcmUgb25lIGZsYXQgU0RLIGRpcmVjdG9yeS4iLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNvbmZpZ3VyZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaXJzdE5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpcnN0QXBwSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlY29uZE5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlY29uZEFwcElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImlzVmFsaWROZmRBcHBJZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZmROYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZmRBcHBJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6NCwiYnl0ZXMiOjJ9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzIyM10sImVycm9yTWVzc2FnZSI6IkVSUjplcnJOb3RDcmVhdG9yIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjc0LDI4OCwyOTYsMzA2LDMxNl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MCwxNzUsMjQ2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU3LDE4MiwyNTNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY4LDE5MywyNjVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRElnT0FvZ0lDQWdZbmwwWldOaWJHOWpheUFpWm1seWMzUk9ZVzFsSWlBaVptbHljM1JCY0hCSlpDSWdJbk5sWTI5dVpFNWhiV1VpSUNKelpXTnZibVJCY0hCSlpDSWdJbU5vWldOclEyOTFiblFpSUNKc1lYTjBRMmhsWTJ0bFpDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl1Wm1RdGNtVm5hWE4wY25rdmJXOWpheTVoYkdkdkxuUnpPakUxQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1RXOWphMDVtWkZCaGFYSlNaV2RwYzNSeWVTQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o2SUcxaGFXNWZZM0psWVhSbFgwNXZUM0JBTmdvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURCa01qWTVaRGN6SURCNE5HSmxNakptWXpZZ0x5OGdiV1YwYUc5a0lDSmpiMjVtYVdkMWNtVW9jM1J5YVc1bkxIVnBiblEyTkN4emRISnBibWNzZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltbHpWbUZzYVdST1ptUkJjSEJKWkNoemRISnBibWNzZFdsdWREWTBLV0p2YjJ3aUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmpiMjVtYVdkMWNtVWdhWE5XWVd4cFpFNW1aRUZ3Y0Vsa0NpQWdJQ0JsY25JS0NtMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl1Wm1RdGNtVm5hWE4wY25rdmJXOWpheTVoYkdkdkxuUnpPakUxQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1RXOWphMDVtWkZCaGFYSlNaV2RwYzNSeWVTQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEUmpOV00yTVdKaElDOHZJRzFsZEdodlpDQWlZM0psWVhSbEtDbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1kzSmxZWFJsQ2lBZ0lDQmxjbklLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Ym1aa0xYSmxaMmx6ZEhKNUwyMXZZMnN1WVd4bmJ5NTBjem82VFc5amEwNW1aRkJoYVhKU1pXZHBjM1J5ZVM1amNtVmhkR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamNtVmhkR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmJtWmtMWEpsWjJsemRISjVMMjF2WTJzdVlXeG5ieTUwY3pveE5nb2dJQ0FnTHk4Z1ptbHljM1JPWVcxbElEMGdSMnh2WW1Gc1UzUmhkR1U4YzNSeWFXNW5QaWg3SUd0bGVUb2dKMlpwY25OMFRtRnRaU2NnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1acGNuTjBUbUZ0WlNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXVabVF0Y21WbmFYTjBjbmt2Ylc5amF5NWhiR2R2TG5Sek9qSTFDaUFnSUNBdkx5QjBhR2x6TG1acGNuTjBUbUZ0WlM1MllXeDFaU0E5SUNjbkNpQWdJQ0J3ZFhOb1lubDBaWE1nSWlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZibVprTFhKbFoybHpkSEo1TDIxdlkyc3VZV3huYnk1MGN6b3hOd29nSUNBZ0x5OGdabWx5YzNSQmNIQkpaQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkbWFYSnpkRUZ3Y0Vsa0p5QjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlabWx5YzNSQmNIQkpaQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5dVptUXRjbVZuYVhOMGNua3ZiVzlqYXk1aGJHZHZMblJ6T2pJMkNpQWdJQ0F2THlCMGFHbHpMbVpwY25OMFFYQndTV1F1ZG1Gc2RXVWdQU0F3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5dVptUXRjbVZuYVhOMGNua3ZiVzlqYXk1aGJHZHZMblJ6T2pFNENpQWdJQ0F2THlCelpXTnZibVJPWVcxbElEMGdSMnh2WW1Gc1UzUmhkR1U4YzNSeWFXNW5QaWg3SUd0bGVUb2dKM05sWTI5dVpFNWhiV1VuSUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKelpXTnZibVJPWVcxbElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMMjVtWkMxeVpXZHBjM1J5ZVM5dGIyTnJMbUZzWjI4dWRITTZNamNLSUNBZ0lDOHZJSFJvYVhNdWMyVmpiMjVrVG1GdFpTNTJZV3gxWlNBOUlDY25DaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Ym1aa0xYSmxaMmx6ZEhKNUwyMXZZMnN1WVd4bmJ5NTBjem94T1FvZ0lDQWdMeThnYzJWamIyNWtRWEJ3U1dRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQW5jMlZqYjI1a1FYQndTV1FuSUgwcENpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKelpXTnZibVJCY0hCSlpDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl1Wm1RdGNtVm5hWE4wY25rdmJXOWpheTVoYkdkdkxuUnpPakk0Q2lBZ0lDQXZMeUIwYUdsekxuTmxZMjl1WkVGd2NFbGtMblpoYkhWbElEMGdNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Ym1aa0xYSmxaMmx6ZEhKNUwyMXZZMnN1WVd4bmJ5NTBjem95TUFvZ0lDQWdMeThnWTJobFkydERiM1Z1ZENBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJyWlhrNklDZGphR1ZqYTBOdmRXNTBKeUI5S1FvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWTJobFkydERiM1Z1ZENJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXVabVF0Y21WbmFYTjBjbmt2Ylc5amF5NWhiR2R2TG5Sek9qSTVDaUFnSUNBdkx5QjBhR2x6TG1Ob1pXTnJRMjkxYm5RdWRtRnNkV1VnUFNBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXVabVF0Y21WbmFYTjBjbmt2Ylc5amF5NWhiR2R2TG5Sek9qSXhDaUFnSUNBdkx5QnNZWE4wUTJobFkydGxaRUZ3Y0Vsa0lEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUd0bGVUb2dKMnhoYzNSRGFHVmphMlZrSnlCOUtRb2dJQ0FnWW5sMFpXTWdOU0F2THlBaWJHRnpkRU5vWldOclpXUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Ym1aa0xYSmxaMmx6ZEhKNUwyMXZZMnN1WVd4bmJ5NTBjem96TUFvZ0lDQWdMeThnZEdocGN5NXNZWE4wUTJobFkydGxaRUZ3Y0Vsa0xuWmhiSFZsSUQwZ01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZibVprTFhKbFoybHpkSEo1TDIxdlkyc3VZV3huYnk1MGN6b3lNd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUc5dVEzSmxZWFJsT2lBbmNtVnhkV2x5WlNjZ2ZTa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZibVprTFhKbFoybHpkSEo1TDIxdlkyc3VZV3huYnk1MGN6bzZUVzlqYTA1bVpGQmhhWEpTWldkcGMzUnllUzVqYjI1bWFXZDFjbVZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamIyNW1hV2QxY21VNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZibVprTFhKbFoybHpkSEo1TDIxdlkyc3VZV3huYnk1MGN6b3pNeTB6T0FvZ0lDQWdMeThnWTI5dVptbG5kWEpsS0FvZ0lDQWdMeThnSUNCbWFYSnpkRTVoYldVNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ1ptbHljM1JCY0hCSlpEb2dkV2x1ZERZMExBb2dJQ0FnTHk4Z0lDQnpaV052Ym1ST1lXMWxPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJSE5sWTI5dVpFRndjRWxrT2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFwT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMMjVtWkMxeVpXZHBjM1J5ZVM5dGIyTnJMbUZzWjI4dWRITTZNemtLSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0JIYkc5aVlXd3VZM0psWVhSdmNrRmtaSEpsYzNNc0lDZGxjbkpPYjNSRGNtVmhkRzl5SnlrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHZHNiMkpoYkNCRGNtVmhkRzl5UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdKdWVpQmpiMjVtYVdkMWNtVmZZV1owWlhKZllYTnpaWEowUURNS0lDQWdJSEIxYzJoaWVYUmxjeUFpUlZKU09tVnljazV2ZEVOeVpXRjBiM0lpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZaWEp5VG05MFEzSmxZWFJ2Y2dvS1kyOXVabWxuZFhKbFgyRm1kR1Z5WDJGemMyVnlkRUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwyNW1aQzF5WldkcGMzUnllUzl0YjJOckxtRnNaMjh1ZEhNNk1UWUtJQ0FnSUM4dklHWnBjbk4wVG1GdFpTQTlJRWRzYjJKaGJGTjBZWFJsUEhOMGNtbHVaejRvZXlCclpYazZJQ2RtYVhKemRFNWhiV1VuSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKbWFYSnpkRTVoYldVaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZibVprTFhKbFoybHpkSEo1TDIxdlkyc3VZV3huYnk1MGN6bzBNQW9nSUNBZ0x5OGdkR2hwY3k1bWFYSnpkRTVoYldVdWRtRnNkV1VnUFNCbWFYSnpkRTVoYldVS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5dVptUXRjbVZuYVhOMGNua3ZiVzlqYXk1aGJHZHZMblJ6T2pFM0NpQWdJQ0F2THlCbWFYSnpkRUZ3Y0Vsa0lEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUd0bGVUb2dKMlpwY25OMFFYQndTV1FuSUgwcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKbWFYSnpkRUZ3Y0Vsa0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMMjVtWkMxeVpXZHBjM1J5ZVM5dGIyTnJMbUZzWjI4dWRITTZOREVLSUNBZ0lDOHZJSFJvYVhNdVptbHljM1JCY0hCSlpDNTJZV3gxWlNBOUlHWnBjbk4wUVhCd1NXUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXVabVF0Y21WbmFYTjBjbmt2Ylc5amF5NWhiR2R2TG5Sek9qRTRDaUFnSUNBdkx5QnpaV052Ym1ST1lXMWxJRDBnUjJ4dlltRnNVM1JoZEdVOGMzUnlhVzVuUGloN0lHdGxlVG9nSjNObFkyOXVaRTVoYldVbklIMHBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnpaV052Ym1ST1lXMWxJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDI1bVpDMXlaV2RwYzNSeWVTOXRiMk5yTG1Gc1oyOHVkSE02TkRJS0lDQWdJQzh2SUhSb2FYTXVjMlZqYjI1a1RtRnRaUzUyWVd4MVpTQTlJSE5sWTI5dVpFNWhiV1VLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl1Wm1RdGNtVm5hWE4wY25rdmJXOWpheTVoYkdkdkxuUnpPakU1Q2lBZ0lDQXZMeUJ6WldOdmJtUkJjSEJKWkNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJyWlhrNklDZHpaV052Ym1SQmNIQkpaQ2NnZlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5ObFkyOXVaRUZ3Y0Vsa0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMMjVtWkMxeVpXZHBjM1J5ZVM5dGIyTnJMbUZzWjI4dWRITTZORE1LSUNBZ0lDOHZJSFJvYVhNdWMyVmpiMjVrUVhCd1NXUXVkbUZzZFdVZ1BTQnpaV052Ym1SQmNIQkpaQW9nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5dVptUXRjbVZuYVhOMGNua3ZiVzlqYXk1aGJHZHZMblJ6T2pNekxUTTRDaUFnSUNBdkx5QmpiMjVtYVdkMWNtVW9DaUFnSUNBdkx5QWdJR1pwY25OMFRtRnRaVG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0JtYVhKemRFRndjRWxrT2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFnSUhObFkyOXVaRTVoYldVNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ2MyVmpiMjVrUVhCd1NXUTZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXVabVF0Y21WbmFYTjBjbmt2Ylc5amF5NWhiR2R2TG5Sek9qcE5iMk5yVG1aa1VHRnBjbEpsWjJsemRISjVMbWx6Vm1Gc2FXUk9abVJCY0hCSlpGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWx6Vm1Gc2FXUk9abVJCY0hCSlpEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl1Wm1RdGNtVm5hWE4wY25rdmJXOWpheTVoYkdkdkxuUnpPalEyQ2lBZ0lDQXZMeUJwYzFaaGJHbGtUbVprUVhCd1NXUW9ibVprVG1GdFpUb2djM1J5YVc1bkxDQnVabVJCY0hCSlpEb2dkV2x1ZERZMEtUb2dZbTl2YkdWaGJpQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl1Wm1RdGNtVm5hWE4wY25rdmJXOWpheTVoYkdkdkxuUnpPalEzQ2lBZ0lDQXZMeUIwYUdsekxtTm9aV05yUTI5MWJuUXVkbUZzZFdVZ0t6MGdNUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl1Wm1RdGNtVm5hWE4wY25rdmJXOWpheTVoYkdkdkxuUnpPakl3Q2lBZ0lDQXZMeUJqYUdWamEwTnZkVzUwSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR3RsZVRvZ0oyTm9aV05yUTI5MWJuUW5JSDBwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0pqYUdWamEwTnZkVzUwSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwyNW1aQzF5WldkcGMzUnllUzl0YjJOckxtRnNaMjh1ZEhNNk5EY0tJQ0FnSUM4dklIUm9hWE11WTJobFkydERiM1Z1ZEM1MllXeDFaU0FyUFNBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl1Wm1RdGNtVm5hWE4wY25rdmJXOWpheTVoYkdkdkxuUnpPakl3Q2lBZ0lDQXZMeUJqYUdWamEwTnZkVzUwSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR3RsZVRvZ0oyTm9aV05yUTI5MWJuUW5JSDBwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0pqYUdWamEwTnZkVzUwSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwyNW1aQzF5WldkcGMzUnllUzl0YjJOckxtRnNaMjh1ZEhNNk5EY0tJQ0FnSUM4dklIUm9hWE11WTJobFkydERiM1Z1ZEM1MllXeDFaU0FyUFNBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMMjVtWkMxeVpXZHBjM1J5ZVM5dGIyTnJMbUZzWjI4dWRITTZNakVLSUNBZ0lDOHZJR3hoYzNSRGFHVmphMlZrUVhCd1NXUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFuYkdGemRFTm9aV05yWldRbklIMHBDaUFnSUNCaWVYUmxZeUExSUM4dklDSnNZWE4wUTJobFkydGxaQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5dVptUXRjbVZuYVhOMGNua3ZiVzlqYXk1aGJHZHZMblJ6T2pRNENpQWdJQ0F2THlCMGFHbHpMbXhoYzNSRGFHVmphMlZrUVhCd1NXUXVkbUZzZFdVZ1BTQnVabVJCY0hCSlpBb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl1Wm1RdGNtVm5hWE4wY25rdmJXOWpheTVoYkdkdkxuUnpPalV4Q2lBZ0lDQXZMeUFvYm1aa1RtRnRaU0E5UFQwZ2RHaHBjeTVtYVhKemRFNWhiV1V1ZG1Gc2RXVWdKaVlnYm1aa1FYQndTV1FnUFQwOUlIUm9hWE11Wm1seWMzUkJjSEJKWkM1MllXeDFaU2tnZkh3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmJtWmtMWEpsWjJsemRISjVMMjF2WTJzdVlXeG5ieTUwY3pveE5nb2dJQ0FnTHk4Z1ptbHljM1JPWVcxbElEMGdSMnh2WW1Gc1UzUmhkR1U4YzNSeWFXNW5QaWg3SUd0bGVUb2dKMlpwY25OMFRtRnRaU2NnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1acGNuTjBUbUZ0WlNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXVabVF0Y21WbmFYTjBjbmt2Ylc5amF5NWhiR2R2TG5Sek9qVXhDaUFnSUNBdkx5QW9ibVprVG1GdFpTQTlQVDBnZEdocGN5NW1hWEp6ZEU1aGJXVXVkbUZzZFdVZ0ppWWdibVprUVhCd1NXUWdQVDA5SUhSb2FYTXVabWx5YzNSQmNIQkpaQzUyWVd4MVpTa2dmSHdLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWW5vZ2FYTldZV3hwWkU1bVpFRndjRWxrWDI5eVgyTnZiblJrUURNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmJtWmtMWEpsWjJsemRISjVMMjF2WTJzdVlXeG5ieTUwY3pveE53b2dJQ0FnTHk4Z1ptbHljM1JCY0hCSlpDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ2RtYVhKemRFRndjRWxrSnlCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVptbHljM1JCY0hCSlpDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl1Wm1RdGNtVm5hWE4wY25rdmJXOWpheTVoYkdkdkxuUnpPalV4Q2lBZ0lDQXZMeUFvYm1aa1RtRnRaU0E5UFQwZ2RHaHBjeTVtYVhKemRFNWhiV1V1ZG1Gc2RXVWdKaVlnYm1aa1FYQndTV1FnUFQwOUlIUm9hWE11Wm1seWMzUkJjSEJKWkM1MllXeDFaU2tnZkh3S0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJwYzFaaGJHbGtUbVprUVhCd1NXUmZZbTl2YkY5MGNuVmxRRFVLQ21selZtRnNhV1JPWm1SQmNIQkpaRjl2Y2w5amIyNTBaRUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwyNW1aQzF5WldkcGMzUnllUzl0YjJOckxtRnNaMjh1ZEhNNk5USUtJQ0FnSUM4dklDaHVabVJPWVcxbElEMDlQU0IwYUdsekxuTmxZMjl1WkU1aGJXVXVkbUZzZFdVZ0ppWWdibVprUVhCd1NXUWdQVDA5SUhSb2FYTXVjMlZqYjI1a1FYQndTV1F1ZG1Gc2RXVXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMMjVtWkMxeVpXZHBjM1J5ZVM5dGIyTnJMbUZzWjI4dWRITTZNVGdLSUNBZ0lDOHZJSE5sWTI5dVpFNWhiV1VnUFNCSGJHOWlZV3hUZEdGMFpUeHpkSEpwYm1jK0tIc2dhMlY1T2lBbmMyVmpiMjVrVG1GdFpTY2dmU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbk5sWTI5dVpFNWhiV1VpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmJtWmtMWEpsWjJsemRISjVMMjF2WTJzdVlXeG5ieTUwY3pvMU1nb2dJQ0FnTHk4Z0tHNW1aRTVoYldVZ1BUMDlJSFJvYVhNdWMyVmpiMjVrVG1GdFpTNTJZV3gxWlNBbUppQnVabVJCY0hCSlpDQTlQVDBnZEdocGN5NXpaV052Ym1SQmNIQkpaQzUyWVd4MVpTa0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0JrYVdjZ01nb2dJQ0FnUFQwS0lDQWdJR0o2SUdselZtRnNhV1JPWm1SQmNIQkpaRjlpYjI5c1gyWmhiSE5sUURZS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmJtWmtMWEpsWjJsemRISjVMMjF2WTJzdVlXeG5ieTUwY3pveE9Rb2dJQ0FnTHk4Z2MyVmpiMjVrUVhCd1NXUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFuYzJWamIyNWtRWEJ3U1dRbklIMHBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSnpaV052Ym1SQmNIQkpaQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5dVptUXRjbVZuYVhOMGNua3ZiVzlqYXk1aGJHZHZMblJ6T2pVeUNpQWdJQ0F2THlBb2JtWmtUbUZ0WlNBOVBUMGdkR2hwY3k1elpXTnZibVJPWVcxbExuWmhiSFZsSUNZbUlHNW1aRUZ3Y0Vsa0lEMDlQU0IwYUdsekxuTmxZMjl1WkVGd2NFbGtMblpoYkhWbEtRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJR1JwWnlBeENpQWdJQ0E5UFFvZ0lDQWdZbm9nYVhOV1lXeHBaRTVtWkVGd2NFbGtYMkp2YjJ4ZlptRnNjMlZBTmdvS2FYTldZV3hwWkU1bVpFRndjRWxrWDJKdmIyeGZkSEoxWlVBMU9nb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0NtbHpWbUZzYVdST1ptUkJjSEJKWkY5aWIyOXNYMjFsY21kbFFEYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Ym1aa0xYSmxaMmx6ZEhKNUwyMXZZMnN1WVd4bmJ5NTBjem8wTmdvZ0lDQWdMeThnYVhOV1lXeHBaRTVtWkVGd2NFbGtLRzVtWkU1aGJXVTZJSE4wY21sdVp5d2dibVprUVhCd1NXUTZJSFZwYm5RMk5DazZJR0p2YjJ4bFlXNGdld29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHBjMVpoYkdsa1RtWmtRWEJ3U1dSZlltOXZiRjltWVd4elpVQTJPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ2FYTldZV3hwWkU1bVpFRndjRWxrWDJKdmIyeGZiV1Z5WjJWQU53bz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFQ0NDWUdDV1pwY25OMFRtRnRaUXBtYVhKemRFRndjRWxrQ25ObFkyOXVaRTVoYldVTGMyVmpiMjVrUVhCd1NXUUtZMmhsWTJ0RGIzVnVkQXRzWVhOMFEyaGxZMnRsWkRFWkZFUXhHRUVBRm9JQ0JBMG1uWE1FUytJdnhqWWFBSTRDQUNjQWh3Q0FCRXhjWWJvMkdnQ09BUUFCQUNpQUFHY3BJbWNxZ0FCbkt5Sm5Kd1FpWnljRkltY2pRellhQVVraVdTUUlTd0VWRWtSWEFnQTJHZ0pKRlNVU1JCYzJHZ05KSWxra0NFc0JGUkpFVndJQU5ob0VTUlVsRWtRWE1RQXlDUkpBQUJXQUVVVlNVanBsY25KT2IzUkRjbVZoZEc5eXNBQW9Ud1JuS1U4RFp5cFBBbWNyVEdjalF6WWFBVWtpV1NRSVN3RVZFa1JYQWdCSk5ob0NTUlVsRWtRWFNVNENJaWNFWlVRakNDY0VUR2NuQlV4bklpaGxSQkpCQUFvaUtXVkVTd0VTUUFBVUlpcGxSRXNDRWtFQUhTSXJaVVJMQVJKQkFCTWpnQUVBSWs4Q1ZJQUVGUjk4ZFV4UXNDTkRJa0wvNmc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjEwLCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
