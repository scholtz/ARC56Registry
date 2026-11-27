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

namespace Arc56.Generated.akita_protocol.akita_sc.Arc58NfdRegistryMock_8cbd9059
{


    //
    // Test-only exact name/application registry used by the NFD auto-renew audit.
    //
    public class Arc58NfdRegistryMockProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public Arc58NfdRegistryMockProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        /// <param name="slot"> </param>
        /// <param name="name"> </param>
        /// <param name="appId"> </param>
        /// <param name="enabled"> </param>
        public async Task Configure(ulong slot, string name, ulong appId, bool enabled, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 226, 35, 129, 129 };
            var slotAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); slotAbi.From(slot);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var appIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appIdAbi.From(appId);
            var enabledAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); enabledAbi.From(enabled);

            var result = await base.CallApp(new List<object> { abiHandle, slotAbi, nameAbi, appIdAbi, enabledAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Configure_Transactions(ulong slot, string name, ulong appId, bool enabled, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 226, 35, 129, 129 };
            var slotAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); slotAbi.From(slot);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var appIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appIdAbi.From(appId);
            var enabledAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); enabledAbi.From(enabled);

            return await base.MakeTransactionList(new List<object> { abiHandle, slotAbi, nameAbi, appIdAbi, enabledAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXJjNThOZmRSZWdpc3RyeU1vY2siLCJkZXNjIjoiVGVzdC1vbmx5IGV4YWN0IG5hbWUvYXBwbGljYXRpb24gcmVnaXN0cnkgdXNlZCBieSB0aGUgTkZEIGF1dG8tcmVuZXcgYXVkaXQuIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjb25maWd1cmUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2xvdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlbmFibGVkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImlzVmFsaWROZmRBcHBJZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZmROYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZmRBcHBJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6NCwiYnl0ZXMiOjJ9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzI2OCwyNzUsMjg1LDI5NiwzMDMsMzE0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY2LDI0NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmJvb2wiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzMsMjUyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1OCwxODUsMjYzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURnZ01nb2dJQ0FnWW5sMFpXTmliRzlqYXlBaVptbHljM1JmYm1GdFpTSWdJbVpwY25OMFgyRndjQ0lnSW1acGNuTjBYMlZ1WVdKc1pXUWlJQ0p6WldOdmJtUmZibUZ0WlNJZ0luTmxZMjl1WkY5aGNIQWlJQ0p6WldOdmJtUmZaVzVoWW14bFpDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzl3YkhWbmFXNXpMMjVtWkM5aGRYUnZMWEpsYm1WM0xXMXZZMnN1WVd4bmJ5NTBjem95TVFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFRnlZelU0VG1aa1VtVm5hWE4wY25sTmIyTnJJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5vZ2JXRnBibDlqY21WaGRHVmZUbTlQY0VBMkNpQWdJQ0J3ZFhOb1lubDBaWE56SURCNFpUSXlNemd4T0RFZ01IZzBZbVV5TW1aak5pQXZMeUJ0WlhSb2IyUWdJbU52Ym1acFozVnlaU2gxYVc1ME5qUXNjM1J5YVc1bkxIVnBiblEyTkN4aWIyOXNLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltbHpWbUZzYVdST1ptUkJjSEJKWkNoemRISnBibWNzZFdsdWREWTBLV0p2YjJ3aUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmpiMjVtYVdkMWNtVWdhWE5XWVd4cFpFNW1aRUZ3Y0Vsa0NpQWdJQ0JsY25JS0NtMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzl3YkhWbmFXNXpMMjVtWkM5aGRYUnZMWEpsYm1WM0xXMXZZMnN1WVd4bmJ5NTBjem95TVFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFRnlZelU0VG1aa1VtVm5hWE4wY25sTmIyTnJJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2NIVnphR0o1ZEdWeklEQjROR00xWXpZeFltRWdMeThnYldWMGFHOWtJQ0pqY21WaGRHVW9LWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmpjbVZoZEdVS0lDQWdJR1Z5Y2dvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDI1bVpDOWhkWFJ2TFhKbGJtVjNMVzF2WTJzdVlXeG5ieTUwY3pvNlFYSmpOVGhPWm1SU1pXZHBjM1J5ZVUxdlkyc3VZM0psWVhSbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZM0psWVhSbE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZibVprTDJGMWRHOHRjbVZ1WlhjdGJXOWpheTVoYkdkdkxuUnpPakl5Q2lBZ0lDQXZMeUJtYVhKemRFNWhiV1VnUFNCSGJHOWlZV3hUZEdGMFpUeHpkSEpwYm1jK0tIc2dhMlY1T2lBblptbHljM1JmYm1GdFpTY2dmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbVpwY25OMFgyNWhiV1VpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5dVptUXZZWFYwYnkxeVpXNWxkeTF0YjJOckxtRnNaMjh1ZEhNNk16RUtJQ0FnSUM4dklIUm9hWE11Wm1seWMzUk9ZVzFsTG5aaGJIVmxJRDBnSnljS0lDQWdJSEIxYzJoaWVYUmxjeUFpSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwyNW1aQzloZFhSdkxYSmxibVYzTFcxdlkyc3VZV3huYnk1MGN6b3lNd29nSUNBZ0x5OGdabWx5YzNSQmNIQWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFuWm1seWMzUmZZWEJ3SnlCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVptbHljM1JmWVhCd0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZibVprTDJGMWRHOHRjbVZ1WlhjdGJXOWpheTVoYkdkdkxuUnpPak15Q2lBZ0lDQXZMeUIwYUdsekxtWnBjbk4wUVhCd0xuWmhiSFZsSUQwZ01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OXVabVF2WVhWMGJ5MXlaVzVsZHkxdGIyTnJMbUZzWjI4dWRITTZNalFLSUNBZ0lDOHZJR1pwY25OMFJXNWhZbXhsWkNBOUlFZHNiMkpoYkZOMFlYUmxQR0p2YjJ4bFlXNCtLSHNnYTJWNU9pQW5abWx5YzNSZlpXNWhZbXhsWkNjZ2ZTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltWnBjbk4wWDJWdVlXSnNaV1FpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5dVptUXZZWFYwYnkxeVpXNWxkeTF0YjJOckxtRnNaMjh1ZEhNNk16TUtJQ0FnSUM4dklIUm9hWE11Wm1seWMzUkZibUZpYkdWa0xuWmhiSFZsSUQwZ1ptRnNjMlVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12Ym1aa0wyRjFkRzh0Y21WdVpYY3RiVzlqYXk1aGJHZHZMblJ6T2pJMUNpQWdJQ0F2THlCelpXTnZibVJPWVcxbElEMGdSMnh2WW1Gc1UzUmhkR1U4YzNSeWFXNW5QaWg3SUd0bGVUb2dKM05sWTI5dVpGOXVZVzFsSnlCOUtRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWMyVmpiMjVrWDI1aGJXVWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTl1Wm1RdllYVjBieTF5Wlc1bGR5MXRiMk5yTG1Gc1oyOHVkSE02TXpRS0lDQWdJQzh2SUhSb2FYTXVjMlZqYjI1a1RtRnRaUzUyWVd4MVpTQTlJQ2NuQ2lBZ0lDQndkWE5vWW5sMFpYTWdJaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5dVptUXZZWFYwYnkxeVpXNWxkeTF0YjJOckxtRnNaMjh1ZEhNNk1qWUtJQ0FnSUM4dklITmxZMjl1WkVGd2NDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ2R6WldOdmJtUmZZWEJ3SnlCOUtRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWMyVmpiMjVrWDJGd2NDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzl3YkhWbmFXNXpMMjVtWkM5aGRYUnZMWEpsYm1WM0xXMXZZMnN1WVd4bmJ5NTBjem96TlFvZ0lDQWdMeThnZEdocGN5NXpaV052Ym1SQmNIQXVkbUZzZFdVZ1BTQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzl3YkhWbmFXNXpMMjVtWkM5aGRYUnZMWEpsYm1WM0xXMXZZMnN1WVd4bmJ5NTBjem95TndvZ0lDQWdMeThnYzJWamIyNWtSVzVoWW14bFpDQTlJRWRzYjJKaGJGTjBZWFJsUEdKdmIyeGxZVzQrS0hzZ2EyVjVPaUFuYzJWamIyNWtYMlZ1WVdKc1pXUW5JSDBwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0p6WldOdmJtUmZaVzVoWW14bFpDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzl3YkhWbmFXNXpMMjVtWkM5aGRYUnZMWEpsYm1WM0xXMXZZMnN1WVd4bmJ5NTBjem96TmdvZ0lDQWdMeThnZEdocGN5NXpaV052Ym1SRmJtRmliR1ZrTG5aaGJIVmxJRDBnWm1Gc2MyVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZibVprTDJGMWRHOHRjbVZ1WlhjdGJXOWpheTVoYkdkdkxuUnpPakk1Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2IyNURjbVZoZEdVNklDZHlaWEYxYVhKbEp5QjlLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzl3YkhWbmFXNXpMMjVtWkM5aGRYUnZMWEpsYm1WM0xXMXZZMnN1WVd4bmJ5NTBjem82UVhKak5UaE9abVJTWldkcGMzUnllVTF2WTJzdVkyOXVabWxuZFhKbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZMjl1Wm1sbmRYSmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12Ym1aa0wyRjFkRzh0Y21WdVpYY3RiVzlqYXk1aGJHZHZMblJ6T2pNNUNpQWdJQ0F2THlCamIyNW1hV2QxY21Vb2MyeHZkRG9nZFdsdWREWTBMQ0J1WVcxbE9pQnpkSEpwYm1jc0lHRndjRWxrT2lCMWFXNTBOalFzSUdWdVlXSnNaV1E2SUdKdmIyeGxZVzRwT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJR1IxY0FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhOM1lYQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVpYjI5c0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0J6ZDJGd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OXVabVF2WVhWMGJ5MXlaVzVsZHkxdGIyTnJMbUZzWjI4dWRITTZOREFLSUNBZ0lDOHZJR2xtSUNoemJHOTBJRDA5UFNBd0tTQjdDaUFnSUNCaWJub2dZMjl1Wm1sbmRYSmxYMlZzYzJWZlltOWtlVUF6Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZibVprTDJGMWRHOHRjbVZ1WlhjdGJXOWpheTVoYkdkdkxuUnpPakl5Q2lBZ0lDQXZMeUJtYVhKemRFNWhiV1VnUFNCSGJHOWlZV3hUZEdGMFpUeHpkSEpwYm1jK0tIc2dhMlY1T2lBblptbHljM1JmYm1GdFpTY2dmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbVpwY25OMFgyNWhiV1VpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5dVptUXZZWFYwYnkxeVpXNWxkeTF0YjJOckxtRnNaMjh1ZEhNNk5ERUtJQ0FnSUM4dklIUm9hWE11Wm1seWMzUk9ZVzFsTG5aaGJIVmxJRDBnYm1GdFpRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmJtWmtMMkYxZEc4dGNtVnVaWGN0Ylc5amF5NWhiR2R2TG5Sek9qSXpDaUFnSUNBdkx5Qm1hWEp6ZEVGd2NDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ2RtYVhKemRGOWhjSEFuSUgwcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKbWFYSnpkRjloY0hBaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OXVabVF2WVhWMGJ5MXlaVzVsZHkxdGIyTnJMbUZzWjI4dWRITTZORElLSUNBZ0lDOHZJSFJvYVhNdVptbHljM1JCY0hBdWRtRnNkV1VnUFNCaGNIQkpaQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZibVprTDJGMWRHOHRjbVZ1WlhjdGJXOWpheTVoYkdkdkxuUnpPakkwQ2lBZ0lDQXZMeUJtYVhKemRFVnVZV0pzWldRZ1BTQkhiRzlpWVd4VGRHRjBaVHhpYjI5c1pXRnVQaWg3SUd0bGVUb2dKMlpwY25OMFgyVnVZV0pzWldRbklIMHBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSm1hWEp6ZEY5bGJtRmliR1ZrSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmJtWmtMMkYxZEc4dGNtVnVaWGN0Ylc5amF5NWhiR2R2TG5Sek9qUXpDaUFnSUNBdkx5QjBhR2x6TG1acGNuTjBSVzVoWW14bFpDNTJZV3gxWlNBOUlHVnVZV0pzWldRS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncGpiMjVtYVdkMWNtVmZZV1owWlhKZmFXWmZaV3h6WlVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZibVprTDJGMWRHOHRjbVZ1WlhjdGJXOWpheTVoYkdkdkxuUnpPak01Q2lBZ0lDQXZMeUJqYjI1bWFXZDFjbVVvYzJ4dmREb2dkV2x1ZERZMExDQnVZVzFsT2lCemRISnBibWNzSUdGd2NFbGtPaUIxYVc1ME5qUXNJR1Z1WVdKc1pXUTZJR0p2YjJ4bFlXNHBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbU52Ym1acFozVnlaVjlsYkhObFgySnZaSGxBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwyNW1aQzloZFhSdkxYSmxibVYzTFcxdlkyc3VZV3huYnk1MGN6bzBOUW9nSUNBZ0x5OGdZWE56WlhKMEtITnNiM1FnUFQwOUlERXBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5dVptUXZZWFYwYnkxeVpXNWxkeTF0YjJOckxtRnNaMjh1ZEhNNk1qVUtJQ0FnSUM4dklITmxZMjl1WkU1aGJXVWdQU0JIYkc5aVlXeFRkR0YwWlR4emRISnBibWMrS0hzZ2EyVjVPaUFuYzJWamIyNWtYMjVoYldVbklIMHBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSnpaV052Ym1SZmJtRnRaU0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDI1bVpDOWhkWFJ2TFhKbGJtVjNMVzF2WTJzdVlXeG5ieTUwY3pvME5nb2dJQ0FnTHk4Z2RHaHBjeTV6WldOdmJtUk9ZVzFsTG5aaGJIVmxJRDBnYm1GdFpRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmJtWmtMMkYxZEc4dGNtVnVaWGN0Ylc5amF5NWhiR2R2TG5Sek9qSTJDaUFnSUNBdkx5QnpaV052Ym1SQmNIQWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFuYzJWamIyNWtYMkZ3Y0NjZ2ZTa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0luTmxZMjl1WkY5aGNIQWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTl1Wm1RdllYVjBieTF5Wlc1bGR5MXRiMk5yTG1Gc1oyOHVkSE02TkRjS0lDQWdJQzh2SUhSb2FYTXVjMlZqYjI1a1FYQndMblpoYkhWbElEMGdZWEJ3U1dRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDI1bVpDOWhkWFJ2TFhKbGJtVjNMVzF2WTJzdVlXeG5ieTUwY3pveU53b2dJQ0FnTHk4Z2MyVmpiMjVrUlc1aFlteGxaQ0E5SUVkc2IySmhiRk4wWVhSbFBHSnZiMnhsWVc0K0tIc2dhMlY1T2lBbmMyVmpiMjVrWDJWdVlXSnNaV1FuSUgwcENpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKelpXTnZibVJmWlc1aFlteGxaQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDI1bVpDOWhkWFJ2TFhKbGJtVjNMVzF2WTJzdVlXeG5ieTUwY3pvME9Bb2dJQ0FnTHk4Z2RHaHBjeTV6WldOdmJtUkZibUZpYkdWa0xuWmhiSFZsSUQwZ1pXNWhZbXhsWkFvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0lnWTI5dVptbG5kWEpsWDJGbWRHVnlYMmxtWDJWc2MyVkFOQW9LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzl3YkhWbmFXNXpMMjVtWkM5aGRYUnZMWEpsYm1WM0xXMXZZMnN1WVd4bmJ5NTBjem82UVhKak5UaE9abVJTWldkcGMzUnllVTF2WTJzdWFYTldZV3hwWkU1bVpFRndjRWxrVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2FYTldZV3hwWkU1bVpFRndjRWxrT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmJtWmtMMkYxZEc4dGNtVnVaWGN0Ylc5amF5NWhiR2R2TG5Sek9qVXlDaUFnSUNBdkx5QnBjMVpoYkdsa1RtWmtRWEJ3U1dRb2JtWmtUbUZ0WlRvZ2MzUnlhVzVuTENCdVptUkJjSEJKWkRvZ2RXbHVkRFkwS1RvZ1ltOXZiR1ZoYmlCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmJtWmtMMkYxZEc4dGNtVnVaWGN0Ylc5amF5NWhiR2R2TG5Sek9qVTBDaUFnSUNBdkx5QW9kR2hwY3k1bWFYSnpkRVZ1WVdKc1pXUXVkbUZzZFdVZ0ppWWdibVprVG1GdFpTQTlQVDBnZEdocGN5NW1hWEp6ZEU1aGJXVXVkbUZzZFdVZ0ppWWdibVprUVhCd1NXUWdQVDA5SUhSb2FYTXVabWx5YzNSQmNIQXVkbUZzZFdVcElIeDhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZibVprTDJGMWRHOHRjbVZ1WlhjdGJXOWpheTVoYkdkdkxuUnpPakkwQ2lBZ0lDQXZMeUJtYVhKemRFVnVZV0pzWldRZ1BTQkhiRzlpWVd4VGRHRjBaVHhpYjI5c1pXRnVQaWg3SUd0bGVUb2dKMlpwY25OMFgyVnVZV0pzWldRbklIMHBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSm1hWEp6ZEY5bGJtRmliR1ZrSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmJtWmtMMkYxZEc4dGNtVnVaWGN0Ylc5amF5NWhiR2R2TG5Sek9qVTBDaUFnSUNBdkx5QW9kR2hwY3k1bWFYSnpkRVZ1WVdKc1pXUXVkbUZzZFdVZ0ppWWdibVprVG1GdFpTQTlQVDBnZEdocGN5NW1hWEp6ZEU1aGJXVXVkbUZzZFdVZ0ppWWdibVprUVhCd1NXUWdQVDA5SUhSb2FYTXVabWx5YzNSQmNIQXVkbUZzZFdVcElIeDhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnWW5vZ2FYTldZV3hwWkU1bVpFRndjRWxrWDI5eVgyTnZiblJrUURRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5dVptUXZZWFYwYnkxeVpXNWxkeTF0YjJOckxtRnNaMjh1ZEhNNk1qSUtJQ0FnSUM4dklHWnBjbk4wVG1GdFpTQTlJRWRzYjJKaGJGTjBZWFJsUEhOMGNtbHVaejRvZXlCclpYazZJQ2RtYVhKemRGOXVZVzFsSnlCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVptbHljM1JmYm1GdFpTSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzl3YkhWbmFXNXpMMjVtWkM5aGRYUnZMWEpsYm1WM0xXMXZZMnN1WVd4bmJ5NTBjem8xTkFvZ0lDQWdMeThnS0hSb2FYTXVabWx5YzNSRmJtRmliR1ZrTG5aaGJIVmxJQ1ltSUc1bVpFNWhiV1VnUFQwOUlIUm9hWE11Wm1seWMzUk9ZVzFsTG5aaGJIVmxJQ1ltSUc1bVpFRndjRWxrSUQwOVBTQjBhR2x6TG1acGNuTjBRWEJ3TG5aaGJIVmxLU0I4ZkFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHUnBaeUF5Q2lBZ0lDQTlQUW9nSUNBZ1lub2dhWE5XWVd4cFpFNW1aRUZ3Y0Vsa1gyOXlYMk52Ym5Sa1FEUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OXVabVF2WVhWMGJ5MXlaVzVsZHkxdGIyTnJMbUZzWjI4dWRITTZNak1LSUNBZ0lDOHZJR1pwY25OMFFYQndJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHdGxlVG9nSjJacGNuTjBYMkZ3Y0NjZ2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltWnBjbk4wWDJGd2NDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzl3YkhWbmFXNXpMMjVtWkM5aGRYUnZMWEpsYm1WM0xXMXZZMnN1WVd4bmJ5NTBjem8xTkFvZ0lDQWdMeThnS0hSb2FYTXVabWx5YzNSRmJtRmliR1ZrTG5aaGJIVmxJQ1ltSUc1bVpFNWhiV1VnUFQwOUlIUm9hWE11Wm1seWMzUk9ZVzFsTG5aaGJIVmxJQ1ltSUc1bVpFRndjRWxrSUQwOVBTQjBhR2x6TG1acGNuTjBRWEJ3TG5aaGJIVmxLU0I4ZkFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQTlQUW9nSUNBZ1ltNTZJR2x6Vm1Gc2FXUk9abVJCY0hCSlpGOWliMjlzWDNSeWRXVkFOd29LYVhOV1lXeHBaRTVtWkVGd2NFbGtYMjl5WDJOdmJuUmtRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5dVptUXZZWFYwYnkxeVpXNWxkeTF0YjJOckxtRnNaMjh1ZEhNNk5UVUtJQ0FnSUM4dklDaDBhR2x6TG5ObFkyOXVaRVZ1WVdKc1pXUXVkbUZzZFdVZ0ppWWdibVprVG1GdFpTQTlQVDBnZEdocGN5NXpaV052Ym1ST1lXMWxMblpoYkhWbElDWW1JRzVtWkVGd2NFbGtJRDA5UFNCMGFHbHpMbk5sWTI5dVpFRndjQzUyWVd4MVpTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OXVabVF2WVhWMGJ5MXlaVzVsZHkxdGIyTnJMbUZzWjI4dWRITTZNamNLSUNBZ0lDOHZJSE5sWTI5dVpFVnVZV0pzWldRZ1BTQkhiRzlpWVd4VGRHRjBaVHhpYjI5c1pXRnVQaWg3SUd0bGVUb2dKM05sWTI5dVpGOWxibUZpYkdWa0p5QjlLUW9nSUNBZ1lubDBaV01nTlNBdkx5QWljMlZqYjI1a1gyVnVZV0pzWldRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OXVabVF2WVhWMGJ5MXlaVzVsZHkxdGIyTnJMbUZzWjI4dWRITTZOVFVLSUNBZ0lDOHZJQ2gwYUdsekxuTmxZMjl1WkVWdVlXSnNaV1F1ZG1Gc2RXVWdKaVlnYm1aa1RtRnRaU0E5UFQwZ2RHaHBjeTV6WldOdmJtUk9ZVzFsTG5aaGJIVmxJQ1ltSUc1bVpFRndjRWxrSUQwOVBTQjBhR2x6TG5ObFkyOXVaRUZ3Y0M1MllXeDFaU2tLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCaWVpQnBjMVpoYkdsa1RtWmtRWEJ3U1dSZlltOXZiRjltWVd4elpVQTRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZibVprTDJGMWRHOHRjbVZ1WlhjdGJXOWpheTVoYkdkdkxuUnpPakkxQ2lBZ0lDQXZMeUJ6WldOdmJtUk9ZVzFsSUQwZ1IyeHZZbUZzVTNSaGRHVThjM1J5YVc1blBpaDdJR3RsZVRvZ0ozTmxZMjl1WkY5dVlXMWxKeUI5S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpYzJWamIyNWtYMjVoYldVaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OXVabVF2WVhWMGJ5MXlaVzVsZHkxdGIyTnJMbUZzWjI4dWRITTZOVFVLSUNBZ0lDOHZJQ2gwYUdsekxuTmxZMjl1WkVWdVlXSnNaV1F1ZG1Gc2RXVWdKaVlnYm1aa1RtRnRaU0E5UFQwZ2RHaHBjeTV6WldOdmJtUk9ZVzFsTG5aaGJIVmxJQ1ltSUc1bVpFRndjRWxrSUQwOVBTQjBhR2x6TG5ObFkyOXVaRUZ3Y0M1MllXeDFaU2tLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCa2FXY2dNZ29nSUNBZ1BUMEtJQ0FnSUdKNklHbHpWbUZzYVdST1ptUkJjSEJKWkY5aWIyOXNYMlpoYkhObFFEZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OXVabVF2WVhWMGJ5MXlaVzVsZHkxdGIyTnJMbUZzWjI4dWRITTZNallLSUNBZ0lDOHZJSE5sWTI5dVpFRndjQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkelpXTnZibVJmWVhCd0p5QjlLUW9nSUNBZ1lubDBaV01nTkNBdkx5QWljMlZqYjI1a1gyRndjQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDI1bVpDOWhkWFJ2TFhKbGJtVjNMVzF2WTJzdVlXeG5ieTUwY3pvMU5Rb2dJQ0FnTHk4Z0tIUm9hWE11YzJWamIyNWtSVzVoWW14bFpDNTJZV3gxWlNBbUppQnVabVJPWVcxbElEMDlQU0IwYUdsekxuTmxZMjl1WkU1aGJXVXVkbUZzZFdVZ0ppWWdibVprUVhCd1NXUWdQVDA5SUhSb2FYTXVjMlZqYjI1a1FYQndMblpoYkhWbEtRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJR1JwWnlBeENpQWdJQ0E5UFFvZ0lDQWdZbm9nYVhOV1lXeHBaRTVtWkVGd2NFbGtYMkp2YjJ4ZlptRnNjMlZBT0FvS2FYTldZV3hwWkU1bVpFRndjRWxrWDJKdmIyeGZkSEoxWlVBM09nb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0NtbHpWbUZzYVdST1ptUkJjSEJKWkY5aWIyOXNYMjFsY21kbFFEazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTl1Wm1RdllYVjBieTF5Wlc1bGR5MXRiMk5yTG1Gc1oyOHVkSE02TlRJS0lDQWdJQzh2SUdselZtRnNhV1JPWm1SQmNIQkpaQ2h1Wm1ST1lXMWxPaUJ6ZEhKcGJtY3NJRzVtWkVGd2NFbGtPaUIxYVc1ME5qUXBPaUJpYjI5c1pXRnVJSHNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0thWE5XWVd4cFpFNW1aRUZ3Y0Vsa1gySnZiMnhmWm1Gc2MyVkFPRG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaUlHbHpWbUZzYVdST1ptUkJjSEJKWkY5aWIyOXNYMjFsY21kbFFEa0siLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFSUFpWUdDbVpwY25OMFgyNWhiV1VKWm1seWMzUmZZWEJ3RFdacGNuTjBYMlZ1WVdKc1pXUUxjMlZqYjI1a1gyNWhiV1VLYzJWamIyNWtYMkZ3Y0E1elpXTnZibVJmWlc1aFlteGxaREVaRkVReEdFRUFGb0lDQk9JamdZRUVTK0l2eGpZYUFJNENBQ2NBZ0FDQUJFeGNZYm8yR2dDT0FRQUJBQ2lBQUdjcEltY3FJbWNyZ0FCbkp3UWlaeWNGSW1jalF6WWFBVWtWSkJKRUYwazJHZ0pKSWxrbENFc0JGUkpFVndJQVREWWFBMGtWSkJKRUYwNENOaG9FU1JVakVrUWlVMHhBQUJCUEEwZ29Ud0puS1U4Q1p5cE1aeU5EVHdNakVrUXJUd0puSndSUEFtY25CVXhuUXYvcE5ob0JTU0paSlFoTEFSVVNSRmNDQURZYUFra1ZKQkpFRnlJcVpVUkJBQlFpS0dWRVN3SVNRUUFLSWlsbFJFc0JFa0FBSFNJbkJXVkVRUUFvSWl0bFJFc0NFa0VBSGlJbkJHVkVTd0VTUVFBVEk0QUJBQ0pQQWxTQUJCVWZmSFZNVUxBalF5SkMvK289IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MTAsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
