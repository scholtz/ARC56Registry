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

namespace Arc56.Generated.bwmx.algorand_casino_roulette.Managable_b7173e42
{


    //
    // Manageable contract, designed to be inherited by other contracts (address will always be set to app creator initially)
    //
    public class ManagableProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ManagableProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Update the manager of this contract
        ///</summary>
        /// <param name="newManager"> </param>
        public async Task UpdateManager(Algorand.Address newManager, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 96, 22, 142 };
            var newManagerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newManagerAbi.From(newManager);

            var result = await base.CallApp(new List<object> { abiHandle, newManagerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateManager_Transactions(Algorand.Address newManager, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 96, 22, 142 };
            var newManagerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newManagerAbi.From(newManager);

            return await base.MakeTransactionList(new List<object> { abiHandle, newManagerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Delete the manager of this contract
        ///</summary>
        public async Task DeleteManager(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 141, 66, 108 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteManager_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 141, 66, 108 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Convenience function to get the current manager of this contract
        ///</summary>
        public async Task<Algorand.Address> Manager(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 103, 67, 64, 49 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> Manager_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 103, 67, 64, 49 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTWFuYWdhYmxlIiwiZGVzYyI6Ik1hbmFnZWFibGUgY29udHJhY3QsIGRlc2lnbmVkIHRvIGJlIGluaGVyaXRlZCBieSBvdGhlciBjb250cmFjdHMgKGFkZHJlc3Mgd2lsbCBhbHdheXMgYmUgc2V0IHRvIGFwcCBjcmVhdG9yIGluaXRpYWxseSkiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoidXBkYXRlTWFuYWdlciIsImRlc2MiOiJVcGRhdGUgdGhlIG1hbmFnZXIgb2YgdGhpcyBjb250cmFjdCIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3TWFuYWdlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWxldGVNYW5hZ2VyIiwiZGVzYyI6IkRlbGV0ZSB0aGUgbWFuYWdlciBvZiB0aGlzIGNvbnRyYWN0IiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1hbmFnZXIiLCJkZXNjIjoiQ29udmVuaWVuY2UgZnVuY3Rpb24gdG8gZ2V0IHRoZSBjdXJyZW50IG1hbmFnZXIgb2YgdGhpcyBjb250cmFjdCIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjoiVGhlIGN1cnJlbnQgbWFuYWdlciBvZiB0aGlzIGNvbnRyYWN0In0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzYyLDgzLDk1XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE1XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjUsODYsOThdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTIxLDE1NV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzOF0sImVycm9yTWVzc2FnZSI6Im1hbmFnZXIgY2Fubm90IGJlIHRoZSB6ZXJvIGFkZHJlc3MiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjVdLCJlcnJvck1lc3NhZ2UiOiJvbmx5IHRoZSBtYW5hZ2VyIGNhbiBjYWxsIHRoaXMgbWV0aG9kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0p0WVc1aFoyVnlJZ29nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmRXeGxkSFJsTDJ4cFluTXZiV0Z1WVdkbFlXSnNaUzVoYkdkdkxuUnpPakV5Q2lBZ0lDQXZMeUJyWlhrNklDZHRZVzVoWjJWeUp5d0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltMWhibUZuWlhJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205MWJHVjBkR1V2YkdsaWN5OXRZVzVoWjJWaFlteGxMbUZzWjI4dWRITTZNVE1LSUNBZ0lDOHZJR2x1YVhScFlXeFdZV3gxWlRvZ2JtVjNJR0Z5WXpRdVFXUmtjbVZ6Y3loSGJHOWlZV3d1WTNKbFlYUnZja0ZrWkhKbGMzTXBMQW9nSUNBZ1oyeHZZbUZzSUVOeVpXRjBiM0pCWkdSeVpYTnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOTFiR1YwZEdVdmJHbGljeTl0WVc1aFoyVmhZbXhsTG1Gc1oyOHVkSE02TVRFdE1UUUtJQ0FnSUM4dklIQnlhWFpoZEdVZ1gyMWhibUZuWlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhoY21NMExrRmtaSEpsYzNNK0tIc0tJQ0FnSUM4dklDQWdhMlY1T2lBbmJXRnVZV2RsY2ljc0NpQWdJQ0F2THlBZ0lHbHVhWFJwWVd4V1lXeDFaVG9nYm1WM0lHRnlZelF1UVdSa2NtVnpjeWhIYkc5aVlXd3VZM0psWVhSdmNrRmtaSEpsYzNNcExBb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjNWc1pYUjBaUzlzYVdKekwyMWhibUZuWldGaWJHVXVZV3huYnk1MGN6b3hNQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUUxaGJtRm5ZV0pzWlNCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMkpoY21WZmNtOTFkR2x1WjBBeE1Bb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEZzVOakF4TmpobElEQjRaRFE0WkRReU5tTWdNSGcyTnpRek5EQXpNU0F2THlCdFpYUm9iMlFnSW5Wd1pHRjBaVTFoYm1GblpYSW9ZV1JrY21WemN5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKa1pXeGxkR1ZOWVc1aFoyVnlLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnRZVzVoWjJWeUtDbGhaR1J5WlhOeklnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5MWNHUmhkR1ZOWVc1aFoyVnlYM0p2ZFhSbFFEVWdiV0ZwYmw5a1pXeGxkR1ZOWVc1aFoyVnlYM0p2ZFhSbFFEWWdiV0ZwYmw5dFlXNWhaMlZ5WDNKdmRYUmxRRGNLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIzVnNaWFIwWlM5c2FXSnpMMjFoYm1GblpXRmliR1V1WVd4bmJ5NTBjem94TUFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFMWhibUZuWVdKc1pTQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmJXRnVZV2RsY2w5eWIzVjBaVUEzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2ZFd4bGRIUmxMMnhwWW5NdmJXRnVZV2RsWVdKc1pTNWhiR2R2TG5Sek9qVXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJRzFoYm1GblpYSUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5a1pXeGxkR1ZOWVc1aFoyVnlYM0p2ZFhSbFFEWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOTFiR1YwZEdVdmJHbGljeTl0WVc1aFoyVmhZbXhsTG1Gc1oyOHVkSE02TkRFS0lDQWdJQzh2SUhCMVlteHBZeUJrWld4bGRHVk5ZVzVoWjJWeUtDazZJSFp2YVdRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJR1JsYkdWMFpVMWhibUZuWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmZFhCa1lYUmxUV0Z1WVdkbGNsOXliM1YwWlVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmRXeGxkSFJsTDJ4cFluTXZiV0Z1WVdkbFlXSnNaUzVoYkdkdkxuUnpPakk0Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkWEJrWVhSbFRXRnVZV2RsY2lodVpYZE5ZVzVoWjJWeU9pQmhjbU0wTGtGa1pISmxjM01wT2lCMmIybGtJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZkV3hsZEhSbEwyeHBZbk12YldGdVlXZGxZV0pzWlM1aGJHZHZMblJ6T2pFd0NpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdUV0Z1WVdkaFlteGxJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZkV3hsZEhSbEwyeHBZbk12YldGdVlXZGxZV0pzWlM1aGJHZHZMblJ6T2pJNENpQWdJQ0F2THlCd2RXSnNhV01nZFhCa1lYUmxUV0Z1WVdkbGNpaHVaWGROWVc1aFoyVnlPaUJoY21NMExrRmtaSEpsYzNNcE9pQjJiMmxrSUhzS0lDQWdJR05oYkd4emRXSWdkWEJrWVhSbFRXRnVZV2RsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlpWVhKbFgzSnZkWFJwYm1kQU1UQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOTFiR1YwZEdVdmJHbGljeTl0WVc1aFoyVmhZbXhsTG1Gc1oyOHVkSE02TVRBS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5Qk5ZVzVoWjJGaWJHVWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCamNtVmhkR2x1WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliM1ZzWlhSMFpTOXNhV0p6TDIxaGJtRm5aV0ZpYkdVdVlXeG5ieTUwY3pvNlRXRnVZV2RoWW14bExtOXViSGxOWVc1aFoyVnlLQ2tnTFQ0Z2RtOXBaRG9LYjI1c2VVMWhibUZuWlhJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205MWJHVjBkR1V2YkdsaWN5OXRZVzVoWjJWaFlteGxMbUZzWjI4dWRITTZNVElLSUNBZ0lDOHZJR3RsZVRvZ0oyMWhibUZuWlhJbkxBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW0xaGJtRm5aWElpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZkV3hsZEhSbEwyeHBZbk12YldGdVlXZGxZV0pzWlM1aGJHZHZMblJ6T2pJeENpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NWZiV0Z1WVdkbGNpNTJZV3gxWlM1dVlYUnBkbVVnUFQwOUlGUjRiaTV6Wlc1a1pYSXNJQ2R2Ym14NUlIUm9aU0J0WVc1aFoyVnlJR05oYmlCallXeHNJSFJvYVhNZ2JXVjBhRzlrSnlrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2IyNXNlU0IwYUdVZ2JXRnVZV2RsY2lCallXNGdZMkZzYkNCMGFHbHpJRzFsZEdodlpBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmRXeGxkSFJsTDJ4cFluTXZiV0Z1WVdkbFlXSnNaUzVoYkdkdkxuUnpPanBOWVc1aFoyRmliR1V1ZFhCa1lYUmxUV0Z1WVdkbGNpaHVaWGROWVc1aFoyVnlPaUJpZVhSbGN5a2dMVDRnZG05cFpEb0tkWEJrWVhSbFRXRnVZV2RsY2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjNWc1pYUjBaUzlzYVdKekwyMWhibUZuWldGaWJHVXVZV3huYnk1MGN6b3lPQW9nSUNBZ0x5OGdjSFZpYkdsaklIVndaR0YwWlUxaGJtRm5aWElvYm1WM1RXRnVZV2RsY2pvZ1lYSmpOQzVCWkdSeVpYTnpLVG9nZG05cFpDQjdDaUFnSUNCd2NtOTBieUF4SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjNWc1pYUjBaUzlzYVdKekwyMWhibUZuWldGaWJHVXVZV3huYnk1MGN6b3pNQW9nSUNBZ0x5OGdkR2hwY3k1dmJteDVUV0Z1WVdkbGNpZ3BDaUFnSUNCallXeHNjM1ZpSUc5dWJIbE5ZVzVoWjJWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205MWJHVjBkR1V2YkdsaWN5OXRZVzVoWjJWaFlteGxMbUZzWjI4dWRITTZNeklLSUNBZ0lDOHZJR0Z6YzJWeWRDaHVaWGROWVc1aFoyVnlMbTVoZEdsMlpTQWhQVDBnUjJ4dlltRnNMbnBsY205QlpHUnlaWE56TENBbmJXRnVZV2RsY2lCallXNXViM1FnWW1VZ2RHaGxJSHBsY204Z1lXUmtjbVZ6Y3ljcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2RzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29nSUNBZ0lUMEtJQ0FnSUdGemMyVnlkQ0F2THlCdFlXNWhaMlZ5SUdOaGJtNXZkQ0JpWlNCMGFHVWdlbVZ5YnlCaFpHUnlaWE56Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTkxYkdWMGRHVXZiR2xpY3k5dFlXNWhaMlZoWW14bExtRnNaMjh1ZEhNNk1USUtJQ0FnSUM4dklHdGxlVG9nSjIxaGJtRm5aWEluTEFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYldGdVlXZGxjaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliM1ZzWlhSMFpTOXNhV0p6TDIxaGJtRm5aV0ZpYkdVdVlXeG5ieTUwY3pvek5Bb2dJQ0FnTHk4Z2RHaHBjeTVmYldGdVlXZGxjaTUyWVd4MVpTQTlJRzVsZDAxaGJtRm5aWElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliM1ZzWlhSMFpTOXNhV0p6TDIxaGJtRm5aV0ZpYkdVdVlXeG5ieTUwY3pvNlRXRnVZV2RoWW14bExtUmxiR1YwWlUxaGJtRm5aWElvS1NBdFBpQjJiMmxrT2dwa1pXeGxkR1ZOWVc1aFoyVnlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZkV3hsZEhSbEwyeHBZbk12YldGdVlXZGxZV0pzWlM1aGJHZHZMblJ6T2pRekNpQWdJQ0F2THlCMGFHbHpMbTl1YkhsTllXNWhaMlZ5S0NrS0lDQWdJR05oYkd4emRXSWdiMjVzZVUxaGJtRm5aWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliM1ZzWlhSMFpTOXNhV0p6TDIxaGJtRm5aV0ZpYkdVdVlXeG5ieTUwY3pveE1nb2dJQ0FnTHk4Z2EyVjVPaUFuYldGdVlXZGxjaWNzQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p0WVc1aFoyVnlJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZkV3hsZEhSbEwyeHBZbk12YldGdVlXZGxZV0pzWlM1aGJHZHZMblJ6T2pRMUNpQWdJQ0F2THlCMGFHbHpMbDl0WVc1aFoyVnlMblpoYkhWbElEMGdibVYzSUdGeVl6UXVRV1JrY21WemN5aEhiRzlpWVd3dWVtVnliMEZrWkhKbGMzTXBDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205MWJHVjBkR1V2YkdsaWN5OXRZVzVoWjJWaFlteGxMbUZzWjI4dWRITTZPazFoYm1GbllXSnNaUzV0WVc1aFoyVnlLQ2tnTFQ0Z1lubDBaWE02Q20xaGJtRm5aWEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTkxYkdWMGRHVXZiR2xpY3k5dFlXNWhaMlZoWW14bExtRnNaMjh1ZEhNNk1USUtJQ0FnSUM4dklHdGxlVG9nSjIxaGJtRm5aWEluTEFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbTFoYm1GblpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmRXeGxkSFJsTDJ4cFluTXZiV0Z1WVdkbFlXSnNaUzVoYkdkdkxuUnpPalUwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1ZmJXRnVZV2RsY2k1MllXeDFaUW9nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQ0FRQW1BUWR0WVc1aFoyVnlNUmhBQUFRb01nbG5NUnRCQUU2Q0F3U0pZQmFPQk5TTlFtd0VaME5BTVRZYUFJNERBQ01BRndBQ0kwTXhHUlJFTVJoRWlBQlRnQVFWSDN4MVRGQ3dJa014R1JSRU1SaEVpQUEySWtNeEdSUkVNUmhFTmhvQmlBQVdJa014R1VEL3lURVlGRVFpUXlNb1pVUXhBQkpFaVlvQkFJai84WXYvTWdNVFJDaUwvMmVKaVAvaktESURaNGtqS0dWRWlRPT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo1LCJwYXRjaCI6MywiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
